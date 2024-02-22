namespace BrockCafeCW
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnItem1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblOrder
            // 
            this.lblOrder.BackColor = System.Drawing.SystemColors.Control;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(18, 13);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(130, 21);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(6, 173);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(163, 38);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Order Done ";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItem1,
            this.columnQuantity});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(163, 130);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnItem1
            // 
            this.columnItem1.Text = "Item";
            this.columnItem1.Width = 83;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            this.columnQuantity.Width = 102;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblOrder);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(172, 226);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnItem1;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        public System.Windows.Forms.Label lblOrder;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Button btnDone;
    }
}
