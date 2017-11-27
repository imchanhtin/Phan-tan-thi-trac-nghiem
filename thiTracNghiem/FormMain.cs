using System;
using System.Windows.Forms;

namespace thiTracNghiem
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private formDangNhap formDN = new formDangNhap();
        private formSV formSV = new formSV();
        private formLop formLop = new formLop();
        private formMH formMH = new formMH();
        private formDeThi formDeThi = new formDeThi();
        private formKhoa formKhoa = new formKhoa();
        private formGiaoVien formGV = new formGiaoVien();
        
        public FormMain()
        {
            InitializeComponent();
            showLoginForm();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        public void showLoginForm()
        {
            Form form = this.CheckExists(typeof(formDangNhap));
            if (form != null) form.Show();
            else
            {
                formDangNhap newForm = new formDangNhap();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void nutDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDangNhap));
            if (frm != null) frm.Activate();
            else
            {
               formDN.MdiParent = this;
               formDN.Show();
            }
            nutDX.Enabled = false;            
        }

        private void nutGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nutDN.Enabled = false;
            nutDX.Enabled = nutSV.Enabled = true;
            Form frm = this.CheckExists(typeof(formGiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                formGV.MdiParent = this;
                formGV.Show();
                formDN.Hide();
            }
        }

        private void nutDX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mlogin = "";
            Program.password = "";
            Program.mGroup = "";
            Program.mHoten = "";
            Program.passwordDN = "";
            Program.servername = "";
            Program.username = "";
            maGV.Text = "";
            hoten.Text = "";
            nhomquyen.Text = "";
            Form frm = this.CheckExists(typeof(formDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                formDN.MdiParent = this;
                formDN.Show();
            }
            
        }

        private void nutSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formSV));
            if (frm != null) frm.Activate();
            else
            {               
                formSV.MdiParent = this;
                formSV.Show();
            }
        }

        private void nutKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formKhoa));
            if (frm != null) frm.Activate();
            else
            {
                formKhoa.MdiParent = this;
                formKhoa.Show();
            }
        }

        private void nutLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formLop));
            if (frm != null) frm.Activate();
            else
            {
                formLop.MdiParent = this;
                formLop.Show();
            }
        }

        private void nutMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formMH));
            if (frm != null) frm.Activate();
            else
            {
                formMH.MdiParent = this;
                formMH.Show();
            }
        }

        private void nutDeThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDeThi));
            if (frm != null) frm.Activate();
            else
            {
                formDeThi.MdiParent = this;
                formDeThi.Show();
            }
        }
    }
}
