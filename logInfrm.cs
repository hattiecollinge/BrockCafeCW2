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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrockCafeCW
{
    public partial class logInfrm : Form
    {
      
        public logInfrm()
        {
            InitializeComponent();
        }

        private void logInfrm_Load(object sender, EventArgs e)
        {
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
            


            string plainText = txtPin.Text;
            string hashedText = GetHashSHA256(plainText);

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            OleDbDataReader da;
            OleDbDataReader ds;
            dbConnector.Connect();
            string sql = $"SELECT StudentID FROM Student WHERE(StudentNumber = {cmbStudentNum.Text})";
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
                    }
                }
            }
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
            
            frmCreatePin frmCreatePin = new frmCreatePin();
            frmCreatePin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmForgotPassword forgot = new frmForgotPassword();
            forgot.Show();  
            
        }
    }
}
