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
    public partial class StudentView : Form
    {

        public static int studentID { get; internal set; }

        public StudentView()
        {
            InitializeComponent();
        }

        private void StudentView_Load(object sender, EventArgs e)
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
            sqlStr = "SELECT Category FROM Categories";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                Button btn = new Button();
                btn.BackColor = Color.Pink;
                btn.Size = new Size(100, 90);
                btn.Text = Convert.ToString(dr[0]);
                btn.Tag = dr[0].ToString();
                btn.Name = "btn_" + i;
                i++;
                btn.Click += btn_Click;
                flpOrderView.Controls.Add(btn);

            }

            dbConnector.Close();

        }

        private void btn_Click(object sender, EventArgs e)
        {
            flpCats.Controls.Clear();
            int i = 0;
            string catName = (sender as Button).Tag.ToString();
            string SqlStr = $"SELECT[Menu Items].ItemName FROM(Categories INNER JOIN [Menu Items] ON Categories.CategoryID = [Menu Items].CategoryID) WHERE(Categories.Category = '{catName}')";
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;

            dbConnector.Connect();
            dr = dbConnector.DoSQL(SqlStr);
            while (dr.Read())
            {
                Button btn1 = new Button();
                btn1.BackColor = Color.Pink;
                btn1.Size = new Size(100, 90);
                btn1.Text = Convert.ToString(dr[0]);
                btn1.Tag = dr[0].ToString();
                btn1.Name = "btn_" + i;
                i++;
                btn1.Click += btn1_click;
                flpCats.Controls.Add(btn1);

            }
            dbConnector.Close();
        }

        private void btn1_click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr, da;

            dbConnector.Connect();
            string sql = $"SELECT Quantity, Ordered FROM[Menu Items] WHERE(ItemName = '{(sender as Button).Tag.ToString()}')";
            da = dbConnector.DoSQL(sql);
            while (da.Read())
            {
                if (Convert.ToInt32(da[0]) == 0)
                {
                    MessageBox.Show("Out Of Stock!");
                }
                else
                {
                    int q = Convert.ToInt32(da[0]) - 1; 
                    int p = Convert.ToInt32(da[1]) + 1; 
                    string SQL = $"UPDATE  [Menu Items] SET Quantity = {q} WHERE(ItemName = '{(sender as Button).Tag.ToString()}') ";
                    dbConnector.DoSQL(SQL);
                    string SQLSTR = $"UPDATE  [Menu Items] SET Ordered = {p} WHERE(ItemName = '{(sender as Button).Tag.ToString()}') ";
                    dbConnector.DoSQL(SQLSTR);
                    string SqlStr = $"SELECT ItemName, ItemCost,  menuItemID FROM[Menu Items] WHERE(ItemName = '{(sender as Button).Tag.ToString()}')";

                    dr = dbConnector.DoSQL(SqlStr);

                    int quantity = 1;
                    double cost = 0;
                    double total = 0;
                    while (dr.Read())
                    {
                        for (int i = 0; i < lvBasket.Items.Count; i++)
                        {
                            if (lvBasket.Items[i].SubItems[1].Text == (sender as Button).Tag.ToString())
                            {
                                quantity = Convert.ToInt32(lvBasket.Items[i].SubItems[0].Text) + 1;
                                lvBasket.Items[i].SubItems[0].Text = Convert.ToString(quantity);
                                cost = Convert.ToDouble(dr[1]) * quantity;
                                lvBasket.Items[i].SubItems[2].Text = Convert.ToString("£" + cost);

                            }
                        }
                        if (quantity == 1)
                        {
                            lvBasket.Items.Add(quantity.ToString());
                            lvBasket.Items[lvBasket.Items.Count - 1].SubItems.Add(dr[0].ToString());
                            lvBasket.Items[lvBasket.Items.Count - 1].SubItems.Add("£" + dr[1].ToString());
                            lvBasket.Items[lvBasket.Items.Count - 1].SubItems.Add(dr[2].ToString());
                        }


                        for (int i = 0; i < lvBasket.Items.Count; i++)
                        {
                            string testmoney = (lvBasket.Items[i].SubItems[2].Text).ToString();
                            testmoney = testmoney.Remove(0, 1);
                            total = total + Convert.ToDouble(testmoney);
                            txtRunningTotal.Text = "£" + total.ToString();
                        }
                    }
                }
            }
            dbConnector.Close();
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            bool empty = false;
            if (lvBasket.Items.Count == 0)
            {
                MessageBox.Show("Add Items to order");
                empty = true;
            }
            if (empty == false)
            {


                dbConnector.Connect();

                string price1 = txtRunningTotal.Text;
                price1 = price1.Remove(0, 1);
                double price2 = Convert.ToDouble(price1);

                string SQl = $"INSERT INTO Orders (StudentID, OrderDone, OrderTime, OrderCollected, TotalCost) VALUES({studentID}, No, '{DateTime.Now}', No, {price2})";
                dr = dbConnector.DoSQL(SQl);

                dbConnector.Close();

                int OID = 0;
                for (int i = 0; i < lvBasket.Items.Count; i++)
                {
                    string menID = lvBasket.Items[i].SubItems[3].Text;
                    int quantity = Convert.ToInt32(lvBasket.Items[i].SubItems[0].Text);
                    string testmoney = (lvBasket.Items[i].SubItems[2].Text).ToString();
                    testmoney = testmoney.Remove(0, 1);
                    double price = Convert.ToDouble(testmoney);

                    string sql;
                    dbConnector.Connect();
                    sql = " SELECT MAX(OrderID) AS maxID FROM Orders ";
                    dr = dbConnector.DoSQL(sql);
                    while (dr.Read())
                    {
                        OID = Convert.ToInt32(dr[0]);

                    }

                    string sqlStr = $"INSERT INTO [Order Items] (OrderID, menuItemID, Quantity, price) VALUES ({OID}, {menID}, {quantity}, {price})";
                    dr = dbConnector.DoSQL(sqlStr);

                    dbConnector.Close();

                }
                MessageBox.Show("ORDER" + OID);
                lvBasket.Items.Clear();
                txtRunningTotal.Clear();
                LogOut();
            }

        }

        private void LogOut()
        {

            this.Close();
            logInfrm login = new logInfrm();
            login.Show();
        }

        private void flpCats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flpOrderView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvBasket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogOut();
        }
    }


}
