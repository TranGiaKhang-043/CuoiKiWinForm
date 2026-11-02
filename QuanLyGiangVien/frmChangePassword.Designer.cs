using System.Windows.Forms;
using System.Drawing;
namespace QuanLyGiangVien
{
    partial class frmChangePassword
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlDoiMatKhau = new System.Windows.Forms.Panel();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblNhapLaiMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblIconMatKhauCu = new System.Windows.Forms.Label();
            this.lblIconMatKhauMoi = new System.Windows.Forms.Label();
            this.lblIconNhapLai = new System.Windows.Forms.Label();
            this.pnlDoiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(25, 42, 70);
            this.lblTieuDe.Location = new System.Drawing.Point(30, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(460, 42);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "ĐỔI MẬT KHẨU";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDoiMatKhau
            // 
            this.pnlDoiMatKhau.BackColor = System.Drawing.Color.White;
            this.pnlDoiMatKhau.Controls.Add(this.lblIconNhapLai);
            this.pnlDoiMatKhau.Controls.Add(this.lblIconMatKhauMoi);
            this.pnlDoiMatKhau.Controls.Add(this.lblIconMatKhauCu);
            this.pnlDoiMatKhau.Controls.Add(this.lblThongBao);
            this.pnlDoiMatKhau.Controls.Add(this.btnHuy);
            this.pnlDoiMatKhau.Controls.Add(this.btnDoiMatKhau);
            this.pnlDoiMatKhau.Controls.Add(this.txtNhapLaiMatKhau);
            this.pnlDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.pnlDoiMatKhau.Controls.Add(this.txtMatKhauCu);
            this.pnlDoiMatKhau.Controls.Add(this.lblNhapLaiMatKhau);
            this.pnlDoiMatKhau.Controls.Add(this.lblMatKhauMoi);
            this.pnlDoiMatKhau.Controls.Add(this.lblMatKhauCu);
            this.pnlDoiMatKhau.Location = new System.Drawing.Point(40, 90);
            this.pnlDoiMatKhau.Name = "pnlDoiMatKhau";
            this.pnlDoiMatKhau.Size = new System.Drawing.Size(440, 360);
            this.pnlDoiMatKhau.TabIndex = 1;
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblMatKhauCu.Location = new System.Drawing.Point(56, 24);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(380, 25);
            this.lblMatKhauCu.TabIndex = 0;
            this.lblMatKhauCu.Text = "Mật khẩu hiện tại";
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblMatKhauMoi.Location = new System.Drawing.Point(56, 100);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(380, 25);
            this.lblMatKhauMoi.TabIndex = 1;
            this.lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lblNhapLaiMatKhau
            // 
            this.lblNhapLaiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblNhapLaiMatKhau.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblNhapLaiMatKhau.Location = new System.Drawing.Point(56, 176);
            this.lblNhapLaiMatKhau.Name = "lblNhapLaiMatKhau";
            this.lblNhapLaiMatKhau.Size = new System.Drawing.Size(380, 25);
            this.lblNhapLaiMatKhau.TabIndex = 2;
            this.lblNhapLaiMatKhau.Text = "Nhập lại mật khẩu mới";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.BackColor = System.Drawing.Color.White;
            this.txtMatKhauCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtMatKhauCu.Location = new System.Drawing.Point(30, 54);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(380, 31);
            this.txtMatKhauCu.TabIndex = 3;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.White;
            this.txtMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtMatKhauMoi.Location = new System.Drawing.Point(30, 130);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(380, 31);
            this.txtMatKhauMoi.TabIndex = 1;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.BackColor = System.Drawing.Color.White;
            this.txtNhapLaiMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtNhapLaiMatKhau.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(30, 206);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(380, 31);
            this.txtNhapLaiMatKhau.TabIndex = 2;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(30, 266);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(260, 42);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnHuy.Location = new System.Drawing.Point(302, 266);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(108, 42);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // lblThongBao
            // 
            this.lblThongBao.ForeColor = System.Drawing.Color.Firebrick;
            this.lblThongBao.Location = new System.Drawing.Point(30, 316);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(380, 40);
            this.lblThongBao.TabIndex = 5;
            // 
            // lblIconMatKhauCu
            // 
            this.lblIconMatKhauCu.BackColor = System.Drawing.Color.Transparent;
            this.lblIconMatKhauCu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.lblIconMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblIconMatKhauCu.Location = new System.Drawing.Point(30, 24);
            this.lblIconMatKhauCu.Name = "lblIconMatKhauCu";
            this.lblIconMatKhauCu.Size = new System.Drawing.Size(20, 25);
            this.lblIconMatKhauCu.TabIndex = 6;
            this.lblIconMatKhauCu.Text = "";
            this.lblIconMatKhauCu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIconMatKhauMoi
            // 
            this.lblIconMatKhauMoi.BackColor = System.Drawing.Color.Transparent;
            this.lblIconMatKhauMoi.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.lblIconMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblIconMatKhauMoi.Location = new System.Drawing.Point(30, 100);
            this.lblIconMatKhauMoi.Name = "lblIconMatKhauMoi";
            this.lblIconMatKhauMoi.Size = new System.Drawing.Size(20, 25);
            this.lblIconMatKhauMoi.TabIndex = 7;
            this.lblIconMatKhauMoi.Text = "";
            this.lblIconMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIconNhapLai
            // 
            this.lblIconNhapLai.BackColor = System.Drawing.Color.Transparent;
            this.lblIconNhapLai.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.lblIconNhapLai.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblIconNhapLai.Location = new System.Drawing.Point(30, 176);
            this.lblIconNhapLai.Name = "lblIconNhapLai";
            this.lblIconNhapLai.Size = new System.Drawing.Size(20, 25);
            this.lblIconNhapLai.TabIndex = 8;
            this.lblIconNhapLai.Text = "";
            this.lblIconNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(522, 493);
            this.Controls.Add(this.pnlDoiMatKhau);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu — Quản lý giảng viên";
            this.pnlDoiMatKhau.ResumeLayout(false);
            this.pnlDoiMatKhau.PerformLayout();
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.pnlDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.pnlDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.lblNhapLaiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblNhapLaiMatKhau.ForeColor = System.Drawing.Color.FromArgb(181,199,220);
            this.lblMatKhauMoi.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(181,199,220);
            this.lblMatKhauCu.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(181,199,220);
            this.txtNhapLaiMatKhau.BackColor = System.Drawing.Color.FromArgb(17,29,46);
            this.txtNhapLaiMatKhau.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.FromArgb(17,29,46);
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.txtMatKhauCu.BackColor = System.Drawing.Color.FromArgb(17,29,46);
            this.txtMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(49,91,190);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62,82,110);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.btnHuy.FlatAppearance.BorderSize = 1;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62,82,110);
            this.lblThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb(255,165,157);
            this.lblIconMatKhauCu.BackColor = System.Drawing.Color.Transparent;
            this.lblIconMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(144,211,240);
            this.lblIconNhapLai.BackColor = System.Drawing.Color.Transparent;
            this.lblIconNhapLai.ForeColor = System.Drawing.Color.FromArgb(144,211,240);
            this.lblIconMatKhauMoi.BackColor = System.Drawing.Color.Transparent;
            this.lblIconMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(144,211,240);
            this.BackColor = System.Drawing.Color.FromArgb(16,23,37);
            this.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.ResumeLayout(false);
        }

        
        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnlDoiMatKhau;
        private System.Windows.Forms.Label lblNhapLaiMatKhau;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblIconMatKhauCu;
        private System.Windows.Forms.Label lblIconNhapLai;
        private System.Windows.Forms.Label lblIconMatKhauMoi;
    }
}
