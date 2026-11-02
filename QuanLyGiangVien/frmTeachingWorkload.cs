using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyGiangVien
{
    public partial class frmTeachingWorkload : Form
    {
        // Dinh muc theo yeu cau do an: toi da 300 tiet / giang vien / hoc ky.
        private const int DINH_MUC_GIANG_DAY = 300;

        // Tam thoi suy ra tu vi du trong tai lieu:
        // 280 tiet = Dat, 190 tiet = Thieu.
        // Can xac nhan voi nhom/giang vien huong dan nguong toi thieu chinh thuc.
        private const int NGUONG_DAT_TOI_THIEU = 280;

        public frmTeachingWorkload()
        {
            InitializeComponent();

            // Gan ten thuoc tinh du lieu cho cac cot da tao bang Designer.
            colMaGV.DataPropertyName = "MaGV";
            colHoTen.DataPropertyName = "HoTen";
            colKhoa.DataPropertyName = "TenKhoa";
            colTongTiet.DataPropertyName = "TongTiet";
            colDinhMuc.DataPropertyName = "DinhMuc";
            colTrangThai.DataPropertyName = "TrangThai";

            // Su kien Load va nut Xem thong ke.
            this.Load += frmTeachingWorkload_Load;
            btnThongKe.Click += btnThongKe_Click;
        }

        private void frmTeachingWorkload_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            ThongKeKhoiLuong();
        }

        // Nap danh sach nam hoc, hoc ky va khoa tu SQL Server.
        private void LoadDanhMuc()
        {
            try
            {
                using (var db = new QuanLyGiangVienDataContext())
                {
                    // Xoa cac muc mau duoc them trong Designer truoc khi gan du lieu database.
                    cboNamHoc.DataSource = null;
                    cboNamHoc.Items.Clear();

                    cboHocKy.DataSource = null;
                    cboHocKy.Items.Clear();

                    cboKhoa.DataSource = null;
                    cboKhoa.Items.Clear();

                    var namHocs = db.NAM_HOCs
                        .OrderByDescending(x => x.TuNam)
                        .Select(x => new
                        {
                            x.MaNamHoc,
                            x.TenNamHoc,
                            x.TuNam,
                            x.TrangThai
                        })
                        .ToList()
                        .Select(x => new ComboItem
                        {
                            Id = x.MaNamHoc,
                            Name = x.TenNamHoc,
                            IsActive = x.TrangThai
                        })
                        .ToList();

                    cboNamHoc.DisplayMember = "Name";
                    cboNamHoc.ValueMember = "Id";
                    cboNamHoc.DataSource = namHocs;

                    // Uu tien nam hoc dang hoat dong; neu khong co thi chon nam moi nhat.
                    var namHocMacDinh = namHocs.FirstOrDefault(x => x.IsActive)
                        ?? namHocs.FirstOrDefault();

                    if (namHocMacDinh != null)
                        cboNamHoc.SelectedValue = namHocMacDinh.Id;

                    var hocKies = db.HOC_Kies
                        .OrderBy(x => x.MaHocKy)
                        .Select(x => new
                        {
                            x.MaHocKy,
                            x.TenHocKy
                        })
                        .ToList()
                        .Select(x => new ComboItem
                        {
                            Id = x.MaHocKy,
                            Name = x.TenHocKy
                        })
                        .ToList();

                    cboHocKy.DisplayMember = "Name";
                    cboHocKy.ValueMember = "Id";
                    cboHocKy.DataSource = hocKies;

                    if (cboHocKy.Items.Count > 0)
                        cboHocKy.SelectedIndex = 0;

                    var khoas = db.KHOAs
                        .OrderBy(x => x.TenKhoa)
                        .Select(x => new
                        {
                            x.MaKhoa,
                            x.TenKhoa
                        })
                        .ToList()
                        .Select(x => new ComboItem
                        {
                            Id = x.MaKhoa,
                            Name = x.TenKhoa
                        })
                        .ToList();

                    // MaKhoa = 0 dai dien cho lua chon Tat ca khoa.
                    khoas.Insert(0, new ComboItem
                    {
                        Id = 0,
                        Name = "Tất cả khoa"
                    });

                    cboKhoa.DisplayMember = "Name";
                    cboKhoa.ValueMember = "Id";
                    cboKhoa.DataSource = khoas;
                    cboKhoa.SelectedValue = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không tải được danh mục năm học, học kỳ hoặc khoa. "
                    + "Hãy kiểm tra SQL Server và chuỗi kết nối trong App.config.\n\n"
                    + ex.Message,
                    "Lỗi tải dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeKhoiLuong();
        }

        // Tinh tong so tiet cua tung giang vien theo nam hoc va hoc ky da chon.
        private void ThongKeKhoiLuong()
        {
            if (cboNamHoc.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn năm học và học kỳ.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            int maNamHoc = Convert.ToInt32(cboNamHoc.SelectedValue);
            int maHocKy = Convert.ToInt32(cboHocKy.SelectedValue);
            int maKhoa = cboKhoa.SelectedValue == null
                ? 0
                : Convert.ToInt32(cboKhoa.SelectedValue);

            try
            {
                using (var db = new QuanLyGiangVienDataContext())
                {
                    // Lay tat ca giang vien thuoc khoa duoc chon.
                    // Truy van con tinh tong SoTiet tu cac lop hoc phan
                    // thuoc dung nam hoc va hoc ky.
                    var ketQua = (
                        from gv in db.GIANG_VIENs
                        join bm in db.BO_MONs
                            on gv.MaBoMon equals bm.MaBoMon
                        join khoa in db.KHOAs
                            on bm.MaKhoa equals khoa.MaKhoa
                        where maKhoa == 0 || khoa.MaKhoa == maKhoa
                        let tongTiet = (
                            from pc in db.PHAN_CONG_GIANG_DAYs
                            join lop in db.LOP_HOC_PHANs
                                on pc.MaLopHP equals lop.MaLopHP
                            where pc.MaGV == gv.MaGV
                                  && lop.MaNamHoc == maNamHoc
                                  && lop.MaHocKy == maHocKy
                            select (int?)pc.SoTiet
                        ).Sum() ?? 0
                        orderby gv.MaGV
                        select new
                        {
                            MaGV = gv.MaGV,
                            HoTen = gv.HoTen,
                            TenKhoa = khoa.TenKhoa,
                            TongTiet = tongTiet,
                            DinhMuc = DINH_MUC_GIANG_DAY,
                            TrangThai = tongTiet > DINH_MUC_GIANG_DAY
                                ? "Vượt"
                                : tongTiet >= NGUONG_DAT_TOI_THIEU
                                    ? "Đạt"
                                    : "Thiếu"
                        }
                    ).ToList();

                    dgvTeachingWorkload.DataSource = null;
                    dgvTeachingWorkload.DataSource = ketQua;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể thống kê khối lượng giảng dạy. "
                    + "Hãy kiểm tra kết nối và cấu trúc database.\n\n"
                    + ex.Message,
                    "Lỗi thống kê",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Nap lai cac danh muc va dua bo loc ve gia tri mac dinh.
            LoadDanhMuc();
            ThongKeKhoiLuong();
        }

        // Lop nho dung lam nguon du lieu cho cac ComboBox.
        private sealed class ComboItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool IsActive { get; set; }
        }

        // Cac su kien duoc tao tu Designer, hien chua can xu ly rieng.
        private void lblNamHoc_Click(object sender, EventArgs e) { }
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblHocKy_Click(object sender, EventArgs e) { }
    }
}
