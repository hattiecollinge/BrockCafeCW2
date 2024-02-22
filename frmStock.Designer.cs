namespace BrockCafeCW
{
    partial class frmStock
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
            this.flpStock = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRestockAll = new System.Windows.Forms.Button();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flpStock
            // 
            this.flpStock.Location = new System.Drawing.Point(5, 65);
            this.flpStock.Name = "flpStock";
            this.flpStock.Size = new System.Drawing.Size(688, 568);
            this.flpStock.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(5, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestockAll
            // 
            this.btnRestockAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRestockAll.Location = new System.Drawing.Point(769, 522);
            this.btnRestockAll.Name = "btnRestockAll";
            this.btnRestockAll.Size = new System.Drawing.Size(91, 86);
            this.btnRestockAll.TabIndex = 7;
            this.btnRestockAll.Text = "Restock All";
            this.btnRestockAll.UseVisualStyleBackColor = false;
            this.btnRestockAll.Click += new System.EventHandler(this.btnRestockAll_Click);
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(751, 128);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.TabIndex = 8;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(949, 645);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.btnRestockAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flpStock);
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRestockAll;
        private System.Windows.Forms.ComboBox cmbItem;
    }
}