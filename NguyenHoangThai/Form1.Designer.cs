
namespace NguyenHoangThai
{
    partial class Form1
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
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.btnDiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Location = new System.Drawing.Point(165, 45);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(120, 52);
            this.btnHocSinh.TabIndex = 0;
            this.btnHocSinh.Text = "Học Sinh";
            this.btnHocSinh.UseVisualStyleBackColor = true;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.Location = new System.Drawing.Point(165, 126);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(120, 50);
            this.btnDiem.TabIndex = 1;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.UseVisualStyleBackColor = true;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnHocSinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 233);
            this.Controls.Add(this.btnDiem);
            this.Controls.Add(this.btnHocSinh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QLHS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnDiem;
    }
}

