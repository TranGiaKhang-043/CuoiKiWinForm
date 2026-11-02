using System;
using System.Windows.Forms;

namespace QuanLyGiangVien
{
    public partial class frmChangePassword : System.Windows.Forms.Form
    {
        public frmChangePassword() { InitializeComponent(); }
        internal frmChangePassword(Session session, AccountRow target=null) : this()
        {
            bool reset=target!=null && target.Id!=session.UserId;
            if(reset)
            {
                if(!session.Can(AccountService.Accounts,ActionRight.Edit)) throw new UserMessage("Bạn không được đặt lại mật khẩu.");
                Text="Đặt lại mật khẩu"; lblTieuDe.Text="ĐẶT LẠI MẬT KHẨU";
                lblMatKhauCu.Text="Tài khoản"; lblIconMatKhauCu.Visible=false;
                txtMatKhauCu.UseSystemPasswordChar=false;txtMatKhauCu.Text=target.Name;txtMatKhauCu.ReadOnly=true;
            }
            txtMatKhauMoi.MaxLength=txtNhapLaiMatKhau.MaxLength=128;
            AcceptButton=btnDoiMatKhau; CancelButton=btnHuy; btnHuy.DialogResult=DialogResult.Cancel;
            btnDoiMatKhau.Click+=(s,e)=>Ui.Run(this,()=>{
                new AccountService(session).ChangePassword(target==null ? (int?)null : target.Id,txtMatKhauCu.Text,txtMatKhauMoi.Text,txtNhapLaiMatKhau.Text);
                MessageBox.Show(this,"Đã lưu mật khẩu mới."); DialogResult=DialogResult.OK;
            },lblThongBao);
            Theme.Apply(this);
        }
    }
}
