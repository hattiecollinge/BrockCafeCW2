using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.Text.RegularExpressions;
using RestSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BrockCafeCW
{

    public partial class logInfrm : Form
    {
        string weather;
        string temperature;
        string Wind;
        string humidity;
        public logInfrm()
        {
            InitializeComponent();
        }

        private void logInfrm_Load(object sender, EventArgs e)
        {
            GetWeatherData("Hampshire");
            OleDbConnection conn = new OleDbConnection();
            string dbProvider;
            string dbSource;
            string workingDirectory = Environment.CurrentDirectory;
            dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;";
            dbSource = @"Data Source = " + workingDirectory + @"\OrderingDatabaseCW1.accdb";
            conn.ConnectionString = dbProvider + dbSource;

            string SqlString = "SELECT StudentNumber FROM Student";
            OleDbDataAdapter da = new OleDbDataAdapter(SqlString, conn.ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Student");
            cmbStudentNum.ValueMember = "StudentNumber";
            cmbStudentNum.DataSource = ds.Tables["Student"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = false;
            if (ValidateStudentNum(cmbStudentNum.Text))
            {
                valid = true;
            }
            while (valid == true)
            {

                string plainText = txtPin.Text;
                string hashedText = GetHashSHA256(plainText);
                string sql;
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                OleDbDataReader da;
                OleDbDataReader ds;
                dbConnector.Connect();
                int count = 0;
                string sql1 = $"SELECT StudentID FROM Student WHERE(StudentNumber = {cmbStudentNum.Text})";
                da = dbConnector.DoSQL(sql1);
                while (da.Read())
                {
                    string sqlstr = "SELECT StudentID FROM LogIn";

                    ds = dbConnector.DoSQL(sqlstr);


                    while (ds.Read())
                    {
                        if (ds[0].ToString() == da[0].ToString())
                        {
                            count++;

                            break;
                        }
                    }

                }
                if (count < 1)
                {
                    MessageBox.Show("You don't have a password yet!");
                    valid = false;
                    break;
                }
                string SQLS = "SELECT StudentID FROM Student";
                dr = dbConnector.DoSQL(SQLS);


                sql = $"SELECT StudentID FROM Student WHERE(StudentNumber = {cmbStudentNum.Text})";
                dr = dbConnector.DoSQL(sql);


                while (dr.Read())
                {

                    string studentnum = dr[0].ToString();
                    StudentView.studentID = Convert.ToInt32(studentnum);
                    string sqlStr = $"SELECT StudentID, PinNum FROM LogIn WHERE(StudentID = {studentnum})";
                    da = dbConnector.DoSQL(sqlStr);
                    while (da.Read())
                    {
                        if (hashedText == da[1].ToString())
                        {
                            valid = false;


                            string SQL = $"SELECT Status FROM Status WHERE(PersonID = {studentnum})";
                            ds = dbConnector.DoSQL(SQL);
                            while (ds.Read())
                            {
                                if (ds[0].ToString() == "Staff")
                                {
                                    Hide();
                                    KitchenView kitchen = new KitchenView();

                                    kitchen.Show();
                                }
                                else
                                {
                                    Hide();
                                    StudentView studentview = new StudentView();
                                    studentview.Show();

                                }
                            }


                        }
                        else
                        {
                            MessageBox.Show("wrong, try again!");
                            valid = false;
                        }
                    }
                }

            }

        }

        private bool ValidateStudentNum(string studentNum)
        {



            int number;
            int count = 0;
            int c = 0;
            bool valid = true;
            string sql = $"SELECT StudentNumber FROM Student";
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr, ds, da;

            dbConnector.Connect();
            dr = dbConnector.DoSQL(sql);

            while (dr.Read())
            {
                if (studentNum == dr[0].ToString())
                {
                    count++;
                }
            }

            //string sql1 = $"SELECT StudentID FROM Student WHERE(StudentNumber = {studentNum})";
            //da = dbConnector.DoSQL(sql1);
            //while (da.Read())
            //{
            //    string sqlstr = "SELECT StudentID FROM LogIn";

            //    ds = dbConnector.DoSQL(sqlstr);


            //    while (ds.Read())
            //    {
            //        if (ds[0].ToString() == da[0].ToString())
            //        {
            //            c++;
                       
            //            break;
            //        }
            //    }

            //}
            //if (c < 1)
            //{
            //    MessageBox.Show("You don't have a password yet!");
            //    valid = false;

            //}
            if (count == 0)
            {
                MessageBox.Show("Invalid Student ID");
                valid = false;
            }
            else if (count > 0)
            {
                valid = true;
            }
            if (int.TryParse(studentNum, out number) == false)
            {
                MessageBox.Show("Invalid Student ID");
                valid = false;
            }
            if (studentNum == "")
            {
                MessageBox.Show("You have not entered anything");
                valid = false;
            }


            return valid;
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {


            txtPin.PasswordChar = '*';
            txtPin.MaxLength = 14;
        }

        private string GetHashSHA256(string plainText)
        {
            string hashText = "";
            Encoding encoding = Encoding.UTF8;
            SHA256Managed hash = new SHA256Managed();
            byte[] result = hash.ComputeHash(encoding.GetBytes(plainText));
            foreach (Byte item in result)
            {
                hashText = hashText + item.ToString("X");
            }
            return hashText;
        }

        private void btncreatePassword_Click(object sender, EventArgs e)
        {
            Hide();
            frmCreatePin frmCreatePin = new frmCreatePin();
            frmCreatePin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void cmbStudentNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GetWeatherData(string location)
        {
            var client = new RestClient($"https://wttr.in/{WebUtility.UrlEncode(location)}?format=%t+%c");
            var request = new RestRequest();
            request.AddParameter("method", "GET");
            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                string[] weatherParameter = Regex.Split(response.Content, " ");
                weather = weatherParameter[1];
                temperature = weatherParameter[0];

                DisplayData();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void DisplayData()
        {
            lbl1.Text = weather;
            lbl2.Text = "Temp: " + temperature;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            frmForgotPassword forgot = new frmForgotPassword();
            forgot.Show();
        }
    }
}
