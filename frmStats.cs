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
            var dataSource = new List<Charts>();
            dataSource.Add(new Charts() { Name = "Most Items Ordered" });
            dataSource.Add(new Charts() { Name = "Least Items Ordered" });
            dataSource.Add(new Charts() { Name = "3" });
            this.comboBox1.DataSource = dataSource;
            this.comboBox1.DisplayMember = "Name";

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            if (comboBox1.Text == "Most Items Ordered")
            {
                flpChart.Controls.Clear();
                TopOrderedChart();
            }
            else  if (comboBox1.Text == "Least Items Ordered")
            {
                flpChart.Controls.Clear();
                LeastOrderedChart();
            }
        }

        private void LeastOrderedChart()
        {
            Chart chart2 = new Chart();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            dbConnector.Connect();
            string SQL = $"SELECT  top 10 Ordered, ItemName FROM[Menu Items] ORDER BY Ordered DESC ";
            dr = dbConnector.DoSQL(SQL);
            while (dr.Read())
            {
                string desc = dr[1].ToString();
   
                chart2.Series["ItemsOrdered"].Points.AddXY(desc, Convert.ToDouble(dr[0].ToString()));

            flpChart.Controls.Add(chart2);
            }
        }

        private void TopOrderedChart()
        {
            Chart chart1 = new Chart();
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
            flpChart.Controls.Add(chart1);  
        }

        private void chart1_Click(object sender, EventArgs e)
        {


        }
    }
}
