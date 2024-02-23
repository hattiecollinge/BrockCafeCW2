namespace BrockCafeCW
{
    partial class Settings
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
            this.btnPreviousOrders = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnStockControl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPreviousOrders
            // 
            this.btnPreviousOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPreviousOrders.Location = new System.Drawing.Point(43, 60);
            this.btnPreviousOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreviousOrders.Name = "btnPreviousOrders";
            this.btnPreviousOrders.Size = new System.Drawing.Size(420, 284);
            this.btnPreviousOrders.TabIndex = 0;
            this.btnPreviousOrders.Text = "Previous Orders";
            this.btnPreviousOrders.UseVisualStyleBackColor = false;
            this.btnPreviousOrders.Click += new System.EventHandler(this.btnPreviousOrders_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStats.Location = new System.Drawing.Point(251, 348);
            this.btnStats.Margin = new System.Windows.Forms.Padding(2);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(420, 284);
            this.btnStats.TabIndex = 2;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnStockControl
            // 
            this.btnStockControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStockControl.Location = new System.Drawing.Point(481, 60);
            this.btnStockControl.Margin = new System.Windows.Forms.Padding(2);
            this.btnStockControl.Name = "btnStockControl";
            this.btnStockControl.Size = new System.Drawing.Size(420, 284);
            this.btnStockControl.TabIndex = 3;
            this.btnStockControl.Text = "StockControl";
            this.btnStockControl.UseVisualStyleBackColor = false;
            this.btnStockControl.Click += new System.EventHandler(this.btnStockControl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(949, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStockControl);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnPreviousOrders);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPreviousOrders;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnStockControl;
        private System.Windows.Forms.Button button1;
    }
}