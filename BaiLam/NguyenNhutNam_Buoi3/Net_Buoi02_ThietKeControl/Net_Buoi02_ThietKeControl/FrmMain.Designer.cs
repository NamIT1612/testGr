namespace Net_Buoi02_ThietKeControl
{
    partial class FrmMain
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
            this.txtUser1 = new UserTextBox.TxtUser();
            this.txtUpper1 = new UpperTextBox.TxtUpper();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber1 = new NumberTextBox.TxtNumber();
            this.txtMail1 = new MailTextBox.TxtMail();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUser1
            // 
            this.txtUser1.Location = new System.Drawing.Point(147, 52);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(187, 20);
            this.txtUser1.TabIndex = 0;
            // 
            // txtUpper1
            // 
            this.txtUpper1.Location = new System.Drawing.Point(147, 98);
            this.txtUpper1.Name = "txtUpper1";
            this.txtUpper1.Size = new System.Drawing.Size(187, 20);
            this.txtUpper1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ko nhập kí tự đặc biệt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chỉ nhập In hoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chỉ nhập Số";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(147, 155);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(187, 20);
            this.txtNumber1.TabIndex = 5;
            // 
            // txtMail1
            // 
            this.txtMail1.Location = new System.Drawing.Point(147, 207);
            this.txtMail1.Name = "txtMail1";
            this.txtMail1.Size = new System.Drawing.Size(187, 20);
            this.txtMail1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chỉ nhập Mail";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMail1);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpper1);
            this.Controls.Add(this.txtUser1);
            this.Name = "FrmMain";
            this.Text = "TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserTextBox.TxtUser txtUser1;
        private UpperTextBox.TxtUpper txtUpper1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private NumberTextBox.TxtNumber txtNumber1;
        private MailTextBox.TxtMail txtMail1;
        private System.Windows.Forms.Label label4;
    }
}

