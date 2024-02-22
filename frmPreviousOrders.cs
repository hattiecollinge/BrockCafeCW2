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
    public partial class frmPreviousOrders : Form
    {
        public frmPreviousOrders()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            KitchenView kitchen = new KitchenView();
            kitchen.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RecoverOrder(string orderID)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            dbConnector.Connect();
            string sql = $"UPDATE Orders SET OrderDone = False, OrderCollected = False WHERE(orderID = {orderID})";
            dbConnector.DoSQL(sql);
        }

        private void frmPreviousOrders_Load(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr = "SELECT orderID, StudentID, TotalCost, OrderTime\r\nFROM     Orders\r\nORDER BY OrderTime DESC";
            dbConnector.Connect();
            listView1.Items.Clear();
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                listView1.Items.Add(dr[0].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[1].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add("£" + dr[2].ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr[3].ToString());
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            String OrderID = listView1.SelectedItems[0].SubItems[0].Text;
            DialogResult dialogResult = MessageBox.Show("Recover Order?", "Recover order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listView1.SelectedItems[0].Remove();
                RecoverOrder(OrderID);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
