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
using System.Windows.Forms.DataVisualization.Charting;

namespace BrockCafeCW
{
    public partial class frmStats : Form
    {
        public class Charts
        {
            public string Name { get; set; }

        }

        public frmStats()
        {
            InitializeComponent();

        }

        private void frmStats_Load(object sender, EventArgs e)
        {
           

        }

        private void LeastOrderedChart()
        {
            chart1.Series.Clear();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            dbConnector.Connect();
            string SQL = $"SELECT  top 10 Ordered, ItemName FROM[Menu Items] ORDER BY Ordered ASC ";
            dr = dbConnector.DoSQL(SQL);
            chart1.Series.Add("ItemsOrdered");
            while (dr.Read())
            {
                string desc = dr[1].ToString();
                chart1.Series["ItemsOrdered"].Points.AddXY(desc, Convert.ToDouble(dr[0].ToString()));

            }
        }

        private void TopOrderedChart()
        {
            chart1.Series.Clear();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            dbConnector.Connect();
            string SQL = $"SELECT  top 10 Ordered, ItemName FROM[Menu Items] ORDER BY Ordered DESC ";
            dr = dbConnector.DoSQL(SQL);
            chart1.Series.Add("ItemsOrdered");
            while (dr.Read())
            {
                string desc = dr[1].ToString();
                chart1.Series["ItemsOrdered"].Points.AddXY(desc, Convert.ToDouble(dr[0].ToString()));

            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {


        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void btnMostOrdered_Click(object sender, EventArgs e)
        {
            TopOrderedChart();
        }

        private void btnLeastOrdered_Click(object sender, EventArgs e)
        {
            LeastOrderedChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Settings kitchen = new Settings();
            kitchen.Show();
        }
    }
}
