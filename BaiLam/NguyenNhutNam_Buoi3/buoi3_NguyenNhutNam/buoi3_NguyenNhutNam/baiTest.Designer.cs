namespace buoi3_NguyenNhutNam
{
    partial class baiTest
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
            this.THU = new chuHoa.Class1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mailTextBox1 = new mailTextBox.mailTextBox();
            this.SuspendLayout();
            // 
            // THU
            // 
            this.THU.Location = new System.Drawing.Point(128, 38);
            this.THU.Name = "THU";
            this.THU.Size = new System.Drawing.Size(157, 20);
            this.THU.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "viết chữ hoa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mail :";
            // 
            // mailTextBox1
            // 
            this.mailTextBox1.Location = new System.Drawing.Point(128, 106);
            this.mailTextBox1.Name = "mailTextBox1";
            this.mailTextBox1.Size = new System.Drawing.Size(157, 20);
            this.mailTextBox1.TabIndex = 3;
            // 
            // baiTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 262);
            this.Controls.Add(this.mailTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.THU);
            this.Name = "baiTest";
            this.Text = "BÀI TEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private chuHoa.Class1 THU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private mailTextBox.mailTextBox mailTextBox1;
    }
}