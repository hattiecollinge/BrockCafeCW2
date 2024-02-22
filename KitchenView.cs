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
    public partial class KitchenView : Form
    {
        public KitchenView()
        {
            InitializeComponent();
        }

        private void KitchenView_Load(object sender, EventArgs e)
        {

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            OleDbDataReader sr;
            OleDbDataReader ar;
            dbConnector.Connect();
            int count = 0;
            string SQLstring = $"SELECT orderID, OrderTime  FROM Orders WHERE(OrderDone = False)";
            dr = dbConnector.DoSQL(SQLstring);
            while (dr.Read())
            {
                UserControl1 userControl = new UserControl1();
                userControl.Name = "UC" + count;

                userControl.lblOrder.Text = "order: " + dr[0].ToString();
                userControl.OrderNumber = Convert.ToInt32(dr[0].ToString());
                userControl.OrderTime = Convert.ToDateTime(dr[1].ToString());
                string orderID = dr[0].ToString();
                string sqlSTR = $"SELECT [Menu Items].ItemName, [Order Items].Quantity FROM([Menu Items] INNER JOIN    [Order Items] ON[Menu Items].menuItemID = [Order Items].menuItemID) WHERE([Order Items].OrderID = {orderID})";
                sr = dbConnector.DoSQL(sqlSTR);
                while (sr.Read())
                {

                    userControl.listView1.Items.Add(sr[0].ToString());
                    userControl.listView1.Items[userControl.listView1.Items.Count - 1].SubItems.Add(sr[1].ToString());

                }
                Refresh();


                flpOrders.Controls.Add(userControl);
                count++;
            }
            


            dbConnector.Close();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (var item in flpOrders.Controls)
            {
                UserControl1 uc = (UserControl1)item;
                TimeSpan ts = new TimeSpan();
                DateTime now = DateTime.Now;
                ts = now.Subtract(uc.OrderTime);
                if (ts.TotalMinutes >= 2 && ts.TotalMinutes <= 5)
                {
                    uc.BackColor = Color.Orange;
                }
                else if (ts.TotalMinutes > 5)
                {
                    uc.BackColor = Color.Red;
                }
                else
                {
                    uc.BackColor = Color.Green;
                }
            }
            foreach (var item in flpOrders.Controls)
            {
                UserControl1 uc = (UserControl1)item;

            }
        }

        private void flpToBeCollected_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrderView_Click(object sender, EventArgs e)
        {
            
            ORDERS orders = new ORDERS();
            Close();
            orders.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            Close();
            settings.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            logInfrm login = new logInfrm();
            login.Show();
        }
    }
}
