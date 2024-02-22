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
    public partial class ORDERS : Form
    {
        public ORDERS()
        {
            InitializeComponent();
        }

        private void ORDERS_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            string dbProvider;
            string dbSource;
            string workingDirectory = Environment.CurrentDirectory;
            dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;";
            dbSource = @"Data Source = " + workingDirectory + @"\OrderingDatabaseCW1.accdb";
            conn.ConnectionString = dbProvider + dbSource;
            updatePreparing();
            UpdateReady();
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string OrderNum = (sender as Button).Tag.ToString();
            string sql = $"SELECT orderID, OrderCollected FROM Orders WHERE(orderID = {OrderNum})";
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr, da;

            dbConnector.Connect();
            dr = dbConnector.DoSQL(sql);
            while (dr.Read())
            {
                string Sql = $"UPDATE Orders SET OrderCollected = True WHERE(orderID = {OrderNum})";
                da = dbConnector.DoSQL(Sql);
            }
          flpOrdersReady.Controls.Remove(sender as Button );

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void UpdateReady()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;

            dbConnector.Connect();
            string sql = "SELECT orderID, OrderDone, OrderCollected FROM Orders WHERE(OrderDone = True) AND(OrderCollected = False)";
            dr = dbConnector.DoSQL(sql);
            while (dr.Read())
            {

                int i = 0;

                Button btn = new Button();
                btn.BackColor = Color.Pink;
                btn.Size = new Size(100, 90);
                btn.Text = Convert.ToString(dr[0]);
                btn.Tag = dr[0].ToString();
                btn.Name = "btn_" + i;
                i++;
                btn.Click += btn_Click;
                flpOrdersReady.Controls.Add(btn);

            }
            dbConnector.Close();
        }

        private void updatePreparing()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;

            dbConnector.Connect();
            string sql = "SELECT orderID, OrderDone, OrderCollected FROM Orders WHERE(OrderDone = False) AND(OrderCollected = False)";
            dr = dbConnector.DoSQL(sql);
            while (dr.Read())
            {

                int i = 0;

                Button btn = new Button();
                btn.BackColor = Color.Pink;
                btn.Size = new Size(100, 90);
                btn.Text = Convert.ToString(dr[0]);
                btn.Tag = dr[0].ToString();
                btn.Name = "btn_" + i;
                i++;
                btn.Click += btn_Click1;
                flpOrdersPreparing.Controls.Add(btn);

            }
            dbConnector.Close();
        }

        private void btn_Click1(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;

            dbConnector.Connect();
            string sqlStr = $"UPDATE Orders SET OrderDone = True WHERE(Orders.orderID = {(sender as Button).Tag.ToString()})";
            dbConnector.DoSQL(sqlStr);
            dbConnector.Close();
            flpOrdersPreparing.Controls.Remove(sender as Button);
            flpOrdersReady.Controls.Clear();
            UpdateReady();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            KitchenView kitchen = new KitchenView();    
            kitchen.Show();
        }
    }
}
