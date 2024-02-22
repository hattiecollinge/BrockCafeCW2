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
            dataSource.Add(new Charts() { Name = "Items Ordered" });
            dataSource.Add(new Charts() { Name = "2" });
            dataSource.Add(new Charts() { Name = "3" });
            this.comboBox1.DataSource = dataSource;
            this.comboBox1.DisplayMember = "Name";

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            if (comboBox1.Text == "Items Ordered")
            {
                OrderedChart();
            }
            else
            {

            }
        }

        private void OrderedChart()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr, da;
            dbConnector.Connect();
            string SQL = $"SELECT  top 10 Ordered, ItemName FROM[Menu Items] ORDER BY Ordered DESC ";
            dr = dbConnector.DoSQL(SQL);
            while (dr.Read())
            {
                string desc = dr[1].ToString();
                chart1.Series["ItemsOrdered"].Points.AddXY(desc, Convert.ToDouble(dr[0].ToString()));

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {


        }
    }
}
