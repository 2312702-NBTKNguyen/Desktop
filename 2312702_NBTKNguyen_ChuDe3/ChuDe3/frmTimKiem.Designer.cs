namespace ChuDe3
{
    partial class frmTimKiem
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbTimLop = new System.Windows.Forms.ComboBox();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.txtTimMSSV = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(313, 223);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(131, 223);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cbbTimLop
            // 
            this.cbbTimLop.FormattingEnabled = true;
            this.cbbTimLop.Location = new System.Drawing.Point(131, 154);
            this.cbbTimLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTimLop.Name = "cbbTimLop";
            this.cbbTimLop.Size = new System.Drawing.Size(281, 24);
            this.cbbTimLop.TabIndex = 13;
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(131, 93);
            this.txtTimTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(281, 22);
            this.txtTimTen.TabIndex = 12;
            // 
            // txtTimMSSV
            // 
            this.txtTimMSSV.Location = new System.Drawing.Point(131, 36);
            this.txtTimMSSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimMSSV.Name = "txtTimMSSV";
            this.txtTimMSSV.Size = new System.Drawing.Size(281, 22);
            this.txtTimMSSV.TabIndex = 11;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(35, 158);
            this.lblLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(33, 16);
            this.lblLop.TabIndex = 10;
            this.lblLop.Text = "Lớp:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(35, 96);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(34, 16);
            this.lblTen.TabIndex = 9;
            this.lblTen.Text = "Tên:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(35, 40);
            this.lblMSSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(48, 16);
            this.lblMSSV.TabIndex = 8;
            this.lblMSSV.Text = "MSSV:";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 318);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbbTimLop);
            this.Controls.Add(this.txtTimTen);
            this.Controls.Add(this.txtTimMSSV);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMSSV);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbTimLop;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.TextBox txtTimMSSV;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMSSV;
    }
}