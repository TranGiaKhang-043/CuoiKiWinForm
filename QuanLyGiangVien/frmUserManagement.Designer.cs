using System.Windows.Forms;
using System.Drawing;
namespace QuanLyGiangVien
{
    partial class frmUserManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblLocVaiTro = new System.Windows.Forms.Label();
            this.cboLocVaiTro = new System.Windows.Forms.ComboBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.pnlThaoTac = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnMoKhoa = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.colMaNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongTaiKhoan = new System.Windows.Forms.Label();
            this.pnlTimKiem.SuspendLayout();
            this.pnlThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvTaiKhoan).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(25, 42, 70);
            this.lblTieuDe.Location = new System.Drawing.Point(24, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1034, 38);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ TÀI KHOẢN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlTimKiem.BackColor = System.Drawing.Color.White;
            this.pnlTimKiem.Controls.Add(this.cboLocTrangThai);
            this.pnlTimKiem.Controls.Add(this.lblLocTrangThai);
            this.pnlTimKiem.Controls.Add(this.cboLocVaiTro);
            this.pnlTimKiem.Controls.Add(this.lblLocVaiTro);
            this.pnlTimKiem.Controls.Add(this.btnLamMoi);
            this.pnlTimKiem.Controls.Add(this.btnTimKiem);
            this.pnlTimKiem.Controls.Add(this.txtTimKiem);
            this.pnlTimKiem.Controls.Add(this.lblTimKiem);
            this.pnlTimKiem.Location = new System.Drawing.Point(24, 82);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(1034, 100);
            this.pnlTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTimKiem.Location = new System.Drawing.Point(20, 14);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(320, 25);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm tài khoản";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.txtTimKiem.Location = new System.Drawing.Point(20, 46);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(320, 31);
            this.txtTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(352, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 34);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnLamMoi.Location = new System.Drawing.Point(454, 44);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 34);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // lblLocVaiTro
            // 
            this.lblLocVaiTro.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblLocVaiTro.Location = new System.Drawing.Point(590, 14);
            this.lblLocVaiTro.Name = "lblLocVaiTro";
            this.lblLocVaiTro.Size = new System.Drawing.Size(190, 25);
            this.lblLocVaiTro.TabIndex = 3;
            this.lblLocVaiTro.Text = "Vai trò";
            // 
            // cboLocVaiTro
            // 
            this.cboLocVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocVaiTro.FormattingEnabled = true;
            this.cboLocVaiTro.Location = new System.Drawing.Point(590, 46);
            this.cboLocVaiTro.Name = "cboLocVaiTro";
            this.cboLocVaiTro.Size = new System.Drawing.Size(190, 28);
            this.cboLocVaiTro.TabIndex = 3;
            // 
            // lblLocTrangThai
            // 
            this.lblLocTrangThai.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblLocTrangThai.Location = new System.Drawing.Point(804, 14);
            this.lblLocTrangThai.Name = "lblLocTrangThai";
            this.lblLocTrangThai.Size = new System.Drawing.Size(210, 25);
            this.lblLocTrangThai.TabIndex = 4;
            this.lblLocTrangThai.Text = "Trạng thái";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Location = new System.Drawing.Point(804, 46);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(210, 28);
            this.cboLocTrangThai.TabIndex = 4;
            // 
            // pnlThaoTac
            // 
            this.pnlThaoTac.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlThaoTac.BackColor = System.Drawing.Color.Transparent;
            this.pnlThaoTac.Controls.Add(this.btnDoiMatKhau);
            this.pnlThaoTac.Controls.Add(this.btnMoKhoa);
            this.pnlThaoTac.Controls.Add(this.btnKhoa);
            this.pnlThaoTac.Controls.Add(this.btnXoa);
            this.pnlThaoTac.Controls.Add(this.btnSua);
            this.pnlThaoTac.Controls.Add(this.btnThem);
            this.pnlThaoTac.Location = new System.Drawing.Point(24, 194);
            this.pnlThaoTac.Name = "pnlThaoTac";
            this.pnlThaoTac.Size = new System.Drawing.Size(1034, 54);
            this.pnlThaoTac.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm tài khoản";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnSua.Location = new System.Drawing.Point(162, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.btnXoa.ForeColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Location = new System.Drawing.Point(274, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnKhoa
            // 
            this.btnKhoa.BackColor = System.Drawing.Color.White;
            this.btnKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.btnKhoa.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnKhoa.Location = new System.Drawing.Point(386, 7);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(110, 40);
            this.btnKhoa.TabIndex = 3;
            this.btnKhoa.Text = "Khóa";
            this.btnKhoa.UseVisualStyleBackColor = false;
            // 
            // btnMoKhoa
            // 
            this.btnMoKhoa.BackColor = System.Drawing.Color.White;
            this.btnMoKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoKhoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnMoKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoKhoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.btnMoKhoa.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnMoKhoa.Location = new System.Drawing.Point(508, 7);
            this.btnMoKhoa.Name = "btnMoKhoa";
            this.btnMoKhoa.Size = new System.Drawing.Size(110, 40);
            this.btnMoKhoa.TabIndex = 4;
            this.btnMoKhoa.Text = "Mở khóa";
            this.btnMoKhoa.UseVisualStyleBackColor = false;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnDoiMatKhau.Location = new System.Drawing.Point(630, 7);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(150, 40);
            this.btnDoiMatKhau.TabIndex = 5;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeColumns = false;
            this.dgvTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(235, 241, 249);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(25, 42, 70);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(235, 241, 249);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(25, 42, 70);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.ColumnHeadersHeight = 40;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colMaNguoiDung, this.colTenDangNhap, this.colGiangVien, this.colVaiTro, this.colTrangThai });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(25, 42, 70);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(235, 239, 244);
            this.dgvTaiKhoan.Location = new System.Drawing.Point(24, 260);
            this.dgvTaiKhoan.MultiSelect = false;
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 36;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(1034, 350);
            this.dgvTaiKhoan.TabIndex = 3;
            // 
            // colMaNguoiDung
            // 
            this.colMaNguoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNguoiDung.FillWeight = 12F;
            this.colMaNguoiDung.HeaderText = "Mã tài khoản";
            this.colMaNguoiDung.MinimumWidth = 6;
            this.colMaNguoiDung.Name = "colMaNguoiDung";
            this.colMaNguoiDung.ReadOnly = true;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenDangNhap.FillWeight = 22F;
            this.colTenDangNhap.HeaderText = "Tên đăng nhập";
            this.colTenDangNhap.MinimumWidth = 6;
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.ReadOnly = true;
            // 
            // colGiangVien
            // 
            this.colGiangVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGiangVien.FillWeight = 28F;
            this.colGiangVien.HeaderText = "Giảng viên";
            this.colGiangVien.MinimumWidth = 6;
            this.colGiangVien.Name = "colGiangVien";
            this.colGiangVien.ReadOnly = true;
            // 
            // colVaiTro
            // 
            this.colVaiTro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVaiTro.FillWeight = 20F;
            this.colVaiTro.HeaderText = "Vai trò";
            this.colVaiTro.MinimumWidth = 6;
            this.colVaiTro.Name = "colVaiTro";
            this.colVaiTro.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrangThai.FillWeight = 18F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // lblTongTaiKhoan
            // 
            this.lblTongTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.lblTongTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.lblTongTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTongTaiKhoan.Location = new System.Drawing.Point(24, 624);
            this.lblTongTaiKhoan.Name = "lblTongTaiKhoan";
            this.lblTongTaiKhoan.Size = new System.Drawing.Size(400, 25);
            this.lblTongTaiKhoan.TabIndex = 4;
            this.lblTongTaiKhoan.Text = "Tổng số tài khoản: ";
            // 
            // frmUserManagement
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1082, 673);
            this.Controls.Add(this.lblTongTaiKhoan);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.pnlThaoTac);
            this.Controls.Add(this.pnlTimKiem);
            this.Controls.Add(this.lblTieuDe);
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "frmUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý tài khoản — Quản lý giảng viên";
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            this.pnlThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgvTaiKhoan).EndInit();
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.pnlTimKiem.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.pnlTimKiem.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.btnTimKiem.FlatAppearance.BorderSize = 1;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62,82,110);
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(17,29,46);
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.lblTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.lblTimKiem.ForeColor = System.Drawing.Color.FromArgb(181,199,220);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.btnLamMoi.FlatAppearance.BorderSize = 1;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62,82,110);
            this.lblLocVaiTro.BackColor = System.Drawing.Color.Transparent;
            this.lblLocVaiTro.ForeColor = System.Drawing.Color.FromArgb(181,199,220);
            this.cboLocVaiTro.BackColor = System.Drawing.Color.FromArgb(17,29,46);
            this.cboLocVaiTro.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.cboLocTrangThai.BackColor = System.Drawing.Color.FromArgb(17,29,46);
            this.cboLocTrangThai.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.lblLocTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblLocTrangThai.ForeColor = System.Drawing.Color.FromArgb(181,199,220);
            this.pnlThaoTac.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.pnlThaoTac.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 1;
            this.btnDoiMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62,82,110);
            this.btnMoKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoKhoa.UseVisualStyleBackColor = false;
            this.btnMoKhoa.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.btnMoKhoa.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.btnMoKhoa.FlatAppearance.BorderSize = 1;
            this.btnMoKhoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62,82,110);
            this.btnKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoa.UseVisualStyleBackColor = false;
            this.btnKhoa.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.btnKhoa.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.btnKhoa.FlatAppearance.BorderSize = 1;
            this.btnKhoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62,82,110);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(255,165,157);
            this.btnXoa.FlatAppearance.BorderSize = 1;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62,82,110);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.btnSua.FlatAppearance.BorderSize = 1;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62,82,110);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(49,91,190);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62,82,110);
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(27,39,58);
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(62,82,110);
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(17,29,46);
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(144,211,240);
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(17,29,46);
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(144,211,240);
            this.dgvTaiKhoan.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27,39,58);
            this.dgvTaiKhoan.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.dgvTaiKhoan.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.dgvTaiKhoan.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(49,91,190);
            this.lblTongTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(181,199,220);
            this.BackColor = System.Drawing.Color.FromArgb(16,23,37);
            this.ForeColor = System.Drawing.Color.FromArgb(236,242,251);
            this.ResumeLayout(false);
        }

        
        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblLocVaiTro;
        private System.Windows.Forms.ComboBox cboLocVaiTro;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.Panel pnlThaoTac;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnMoKhoa;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Label lblTongTaiKhoan;
    }
}
