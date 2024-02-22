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

namespace BrockCafeCW
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string item = (sender as Button).Tag.ToString();
            string sql = $"SELECT  Quantity FROM[Menu Items] WHERE(ItemName = '{item}')";
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            dbConnector.Connect();
            dr = dbConnector.DoSQL(sql);
            while (dr.Read())
            {
                MessageBox.Show("Quantity: "+ dr[0].ToString());
            }
        }

        private void flpStock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmStock_Load(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection();
            string dbProvider;
            string dbSource;
            string workingDirectory = Environment.CurrentDirectory;
            dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;";
            dbSource = @"Data Source = " + workingDirectory + @"\OrderingDatabaseCW1.accdb";
            conn.ConnectionString = dbProvider + dbSource;

            int i = 0;
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT        ItemName FROM[Menu Items]";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                Button btn = new Button();
                btn.BackColor = Color.Pink;
                btn.Size = new Size(90,80);
                btn.Text = Convert.ToString(dr[0]);
                btn.Tag = dr[0].ToString();
                btn.Name = "btn_" + i;
                i++;
                btn.Click += btn_Click;
                flpStock.Controls.Add(btn);

            }

            dbConnector.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Settings kitchen = new Settings();
            kitchen.Show();
        }

        private void btnRestockAll_Click(object sender, EventArgs e)
        {
            int a;
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            dbConnector.Connect();
            
                
               string Sql = $"UPDATE  [Menu Items] SET Quantity = 50";
                dbConnector.DoSQL(Sql);
               
        }
    }
}
