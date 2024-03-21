namespace BrockCafeCW
{
    partial class StudentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentView));
            this.flpOrderView = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCats = new System.Windows.Forms.FlowLayoutPanel();
            this.lvBasket = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.txtRunningTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // flpOrderView
            // 
            this.flpOrderView.Location = new System.Drawing.Point(12, 12);
            this.flpOrderView.Name = "flpOrderView";
            this.flpOrderView.Size = new System.Drawing.Size(589, 207);
            this.flpOrderView.TabIndex = 0;
            this.flpOrderView.Paint += new System.Windows.Forms.PaintEventHandler(this.flpOrderView_Paint);
            // 
            // flpCats
            // 
            this.flpCats.Location = new System.Drawing.Point(12, 271);
            this.flpCats.Name = "flpCats";
            this.flpCats.Size = new System.Drawing.Size(589, 300);
            this.flpCats.TabIndex = 1;
            this.flpCats.Paint += new System.Windows.Forms.PaintEventHandler(this.flpCats_Paint);
            // 
            // lvBasket
            // 
            this.lvBasket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBasket.FullRowSelect = true;
            this.lvBasket.HideSelection = false;
            this.lvBasket.HoverSelection = true;
            this.lvBasket.Location = new System.Drawing.Point(623, 54);
            this.lvBasket.Name = "lvBasket";
            this.lvBasket.Size = new System.Drawing.Size(304, 385);
            this.lvBasket.TabIndex = 2;
            this.lvBasket.UseCompatibleStateImageBehavior = false;
            this.lvBasket.View = System.Windows.Forms.View.Details;
            this.lvBasket.SelectedIndexChanged += new System.EventHandler(this.lvBasket_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quantity";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cost";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Basket";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Location = new System.Drawing.Point(842, 443);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(85, 65);
            this.btnSaveOrder.TabIndex = 4;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // txtRunningTotal
            // 
            this.txtRunningTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunningTotal.Location = new System.Drawing.Point(861, 403);
            this.txtRunningTotal.Name = "txtRunningTotal";
            this.txtRunningTotal.ReadOnly = true;
            this.txtRunningTotal.Size = new System.Drawing.Size(51, 27);
            this.txtRunningTotal.TabIndex = 5;
            this.txtRunningTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(644, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(949, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRunningTotal);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvBasket);
            this.Controls.Add(this.flpCats);
            this.Controls.Add(this.flpOrderView);
            this.Name = "StudentView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpOrderView;
        private System.Windows.Forms.FlowLayoutPanel flpCats;
        private System.Windows.Forms.ListView lvBasket;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.TextBox txtRunningTotal;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

