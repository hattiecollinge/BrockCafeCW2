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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStudentNum
            // 
            this.cmbStudentNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStudentNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStudentNum.Location = new System.Drawing.Point(393, 282);
            this.cmbStudentNum.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStudentNum.Name = "cmbStudentNum";
            this.cmbStudentNum.Size = new System.Drawing.Size(92, 21);
            this.cmbStudentNum.TabIndex = 0;
            this.cmbStudentNum.SelectedIndexChanged += new System.EventHandler(this.cmbStudentNum_SelectedIndexChanged);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(393, 307);
            this.txtPin.Margin = new System.Windows.Forms.Padding(2);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(92, 20);
            this.txtPin.TabIndex = 1;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncreatePassword
            // 
            this.btncreatePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btncreatePassword.Location = new System.Drawing.Point(303, 358);
            this.btncreatePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btncreatePassword.Name = "btncreatePassword";
            this.btncreatePassword.Size = new System.Drawing.Size(267, 32);
            this.btncreatePassword.TabIndex = 3;
            this.btncreatePassword.Text = "Not logged in before? Create password here. ";
            this.btncreatePassword.UseVisualStyleBackColor = false;
            this.btncreatePassword.Click += new System.EventHandler(this.btncreatePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOG IN";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(303, 394);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Forgot Password? ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // logInfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(949, 645);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncreatePassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.cmbStudentNum);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button2;
    }
}