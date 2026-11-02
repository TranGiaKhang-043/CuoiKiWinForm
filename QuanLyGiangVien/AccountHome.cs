using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyGiangVien
{
    // Điểm vào phân hệ tài khoản; frmMain của nhóm có thể mở các form bằng cùng Session.
    internal sealed class AccountHome : Form
    {
        private readonly Session session;
        private readonly Button accounts,roles;
        internal AccountHome(Session current)
        {
            session=current; Text="Tài khoản · Quản lý giảng viên"; Font=new Font("Segoe UI",10);
            ClientSize=new Size(510,360); FormBorderStyle=FormBorderStyle.FixedDialog; MaximizeBox=false; StartPosition=FormStartPosition.CenterScreen;
            Controls.Add(new Label {Name="lblTieuDe",Text="Tài khoản của tôi",Font=new Font(Font,FontStyle.Bold),Location=new Point(28,23),AutoSize=true});
            Controls.Add(new Label {Text="Đã đăng nhập · "+current.Username,Location=new Point(28,58),Size=new Size(450,28)});
            accounts=Add("btnAccounts","Quản lý tài khoản",102,()=>{using(var f=new frmUserManagement(session)) f.ShowDialog(this);});
            roles=Add("btnRoles","Vai trò và phân quyền",151,()=>{using(var f=new frmRoleManagement(session)) f.ShowDialog(this);});
            Add("btnPassword","Đổi mật khẩu của tôi",200,()=>{using(var f=new frmChangePassword(session)) f.ShowDialog(this);});
            var logout=Add("btnLogout","Đăng xuất",265,Close); logout.Width=216;
            var theme=Add("btnTheme","Giao diện sáng",265,Theme.Toggle); theme.Left=264; theme.Width=218;
            Shown+=(s,e)=>RefreshRights();
            Theme.Apply(this);
        }
        private Button Add(string name,string text,int y,Action action)
        {
            var b=new Button{Name=name,Text=text,Location=new Point(28,y),Size=new Size(454,40)};
            b.Click+=(s,e)=>{Ui.Run(this,action); if(!IsDisposed && Visible) RefreshRights();}; Controls.Add(b); return b;
        }
        private void RefreshRights()
        {
            accounts.Enabled=roles.Enabled=false;
            try { accounts.Enabled=session.Can(AccountService.Accounts,ActionRight.View); roles.Enabled=session.Can(AccountService.Roles,ActionRight.View); }
            catch(UserMessage e){MessageBox.Show(this,e.Message);Close();}
            catch(System.Data.SqlClient.SqlException){MessageBox.Show(this,"Mất kết nối dữ liệu.");Close();}
        }
    }
}
