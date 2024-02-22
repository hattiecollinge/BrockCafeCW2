namespace BrockCafeCW
{
    partial class KitchenView
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
            this.components = new System.ComponentModel.Container();
            this.flpOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOrderView = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpOrders
            // 
            this.flpOrders.AutoScroll = true;
            this.flpOrders.Location = new System.Drawing.Point(12, 12);
            this.flpOrders.Name = "flpOrders";
            this.flpOrders.Size = new System.Drawing.Size(822, 588);
            this.flpOrders.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOrderView
            // 
            this.btnOrderView.Location = new System.Drawing.Point(850, 23);
            this.btnOrderView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrderView.Name = "btnOrderView";
            this.btnOrderView.Size = new System.Drawing.Size(70, 46);
            this.btnOrderView.TabIndex = 1;
            this.btnOrderView.Text = "View Order Screen";
            this.btnOrderView.UseVisualStyleBackColor = true;
            this.btnOrderView.Click += new System.EventHandler(this.btnOrderView_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(850, 74);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(70, 46);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings ";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // KitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(949, 645);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnOrderView);
            this.Controls.Add(this.flpOrders);
            this.Name = "KitchenView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KitchenView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpOrders;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOrderView;
        private System.Windows.Forms.Button btnSettings;
    }
}