using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrockCafeCW
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            KitchenView kitchen = new KitchenView();
            kitchen.Show();
        }

        private void btnPreviousOrders_Click(object sender, EventArgs e)
        {
            Close();
            frmPreviousOrders frmPreviousOrders = new frmPreviousOrders();  
            frmPreviousOrders.Show();
        }

        private void btnStockControl_Click(object sender, EventArgs e)
        {
            Close();
            frmStock stock = new frmStock();
            stock.Show();   
        }
    }
}
