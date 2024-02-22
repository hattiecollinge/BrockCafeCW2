using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrockCafeCW
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            OleDbDataReader da;
            OleDbDataReader ds;
            dbConnector.Connect();
            string plainText = txtPinNum.Text;
            string hashedText = GetHashSHA256(plainText);
            int count = 0;
            string sql = $"SELECT StudentID FROM Student WHERE(StudentNumber = {cmbStudentNum.Text})";
            dr = dbConnector.DoSQL(sql);
            while (dr.Read())
            {
                int ID = Convert.ToInt32(dr[0]);
                string sqlstr = "SELECT StudentID FROM LogIn";
                ds = dbConnector.DoSQL(sqlstr);
                while (ds.Read())
                {
                    if (ds[0].ToString() == dr[0].ToString())
                    {

                        count++;
                    }
                }
                if (count == 0)
                {
                    if (ValidatePassword(plainText))
                    {

                        string Sql = $"INSERT INTO LogIn (StudentID, PinNum) VALUES({ID}, '{hashedText}')";
                        da = dbConnector.DoSQL(Sql);
                    }
                }
                else
                {
                    string sqlStr = $"DELETE FROM LogIn WHERE(StudentID = {ID})";
                    da = dbConnector.DoSQL(sqlStr);
                    if (ValidatePassword(plainText))
                    {

                    string Sql = $"INSERT INTO LogIn (StudentID, PinNum) VALUES({ID}, '{hashedText}')";
                    da = dbConnector.DoSQL(Sql);
                    }
                }
            }
            this.Close();
            dbConnector.Close();
        }
        private bool ValidatePassword(string plainText)
        {
            int number;
            if (plainText.Length > 10)
            {
                MessageBox.Show("password needs to be less than 10 numbers");
                return false;
            }
            else if (string.IsNullOrEmpty(plainText))
            {
                MessageBox.Show("Enter a number!");
                return false;
            }
            else if (int.TryParse(plainText, out number) == false)
            {
                MessageBox.Show("Numbers only!");
                return false;
            }

            return true;



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

        private void txtPinNum_TextChanged(object sender, EventArgs e)
        {
            txtPinNum.PasswordChar = '*';
            txtPinNum.MaxLength = 10;
        }
    }
}
