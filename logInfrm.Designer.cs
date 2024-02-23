namespace BrockCafeCW
{
    partial class logInfrm
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
            this.cmbStudentNum = new System.Windows.Forms.ComboBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btncreatePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbStudentNum
            // 
            this.cmbStudentNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStudentNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStudentNum.Location = new System.Drawing.Point(590, 434);
            this.cmbStudentNum.Name = "cmbStudentNum";
            this.cmbStudentNum.Size = new System.Drawing.Size(136, 28);
            this.cmbStudentNum.TabIndex = 0;
            this.cmbStudentNum.SelectedIndexChanged += new System.EventHandler(this.cmbStudentNum_SelectedIndexChanged);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(590, 472);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(136, 26);
            this.txtPin.TabIndex = 1;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncreatePassword
            // 
            this.btncreatePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btncreatePassword.Location = new System.Drawing.Point(454, 551);
            this.btncreatePassword.Name = "btncreatePassword";
            this.btncreatePassword.Size = new System.Drawing.Size(400, 49);
            this.btncreatePassword.TabIndex = 3;
            this.btncreatePassword.Text = "Not logged in before? Create password here. ";
            this.btncreatePassword.UseVisualStyleBackColor = false;
            this.btncreatePassword.Click += new System.EventHandler(this.btncreatePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOG IN";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(32, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(13, 20);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = ".";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(32, 54);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(13, 20);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = ".";
            this.lbl2.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(32, 91);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 20);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "dwvkg";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(36, 131);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(51, 20);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "label4";
            // 
            // logInfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1424, 992);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncreatePassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.cmbStudentNum);
            this.Name = "logInfrm";
            this.Text = "logInfrm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.logInfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudentNum;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncreatePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}