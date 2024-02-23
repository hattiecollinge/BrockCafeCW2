namespace BrockCafeCW
{
    partial class frmStats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMostOrdered = new System.Windows.Forms.Button();
            this.btnLeastOrdered = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 229);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1389, 661);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // btnMostOrdered
            // 
            this.btnMostOrdered.Location = new System.Drawing.Point(69, 90);
            this.btnMostOrdered.Name = "btnMostOrdered";
            this.btnMostOrdered.Size = new System.Drawing.Size(107, 94);
            this.btnMostOrdered.TabIndex = 4;
            this.btnMostOrdered.Text = "Most Ordered Items";
            this.btnMostOrdered.UseVisualStyleBackColor = true;
            this.btnMostOrdered.Click += new System.EventHandler(this.btnMostOrdered_Click);
            // 
            // btnLeastOrdered
            // 
            this.btnLeastOrdered.Location = new System.Drawing.Point(212, 90);
            this.btnLeastOrdered.Name = "btnLeastOrdered";
            this.btnLeastOrdered.Size = new System.Drawing.Size(107, 94);
            this.btnLeastOrdered.TabIndex = 5;
            this.btnLeastOrdered.Text = "Least Ordered Items";
            this.btnLeastOrdered.UseVisualStyleBackColor = true;
            this.btnLeastOrdered.Click += new System.EventHandler(this.btnLeastOrdered_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1424, 992);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLeastOrdered);
            this.Controls.Add(this.btnMostOrdered);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStats";
            this.Text = "frmStats";
            this.Load += new System.EventHandler(this.frmStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnMostOrdered;
        private System.Windows.Forms.Button btnLeastOrdered;
        private System.Windows.Forms.Button button1;
    }
}