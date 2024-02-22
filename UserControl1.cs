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
    public partial class UserControl1 : UserControl
    {
        public int OrderNumber { get; set; }
        public DateTime OrderTime { get; set; } 
        public bool OrderDone { get; set; } 
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;

            dbConnector.Connect();
            string sqlStr = $"UPDATE Orders SET OrderDone = True WHERE(Orders.orderID = {OrderNumber})";
            dbConnector.DoSQL(sqlStr);
            dbConnector.Close();
            this.Parent.Controls.Remove(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
        }
    }
}
