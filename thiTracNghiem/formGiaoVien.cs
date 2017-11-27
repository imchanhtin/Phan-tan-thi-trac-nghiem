using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thiTracNghiem
{
    public partial class formGiaoVien : Form
    {
        int vitri = 0;
        string macoso = "";
        public formGiaoVien()
        {
            InitializeComponent();
        }


        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formGiaoVien_Load(object sender, EventArgs e)
        {

            groupTT.Enabled = false;
            this.bODETableAdapter.Fill(this.DS.BODE);
            DS.EnforceConstraints = false; //Chặn kiểm tra khóa ngoại 
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            //lấy mã cơ sở của tài khoản đăng nhập
            macoso = ((DataRowView)Program.bds_dspm[0])["TENCN"].ToString(); 
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            // Kiểm tra phân quyền hiện tại, nếu là truong thì mới cho phép thay đổi cơ sở bằng comboBox cơ sở
            if (Program.mGroup == "truong") cmbCoSo.Enabled = true;
            else cmbCoSo.Enabled = false;

            
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e) //Chỉ áp dụng cho tài khoản Trường
        {
           
            try
            {
                if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                Program.servername = cmbCoSo.SelectedValue.ToString(); //Tên cơ sở mới
                if (cmbCoSo.SelectedIndex != Program.mCoso) //Nếu lựa chọn cơ sở mới khác với chi nhánh đăng nhập
                {
                    //sử dụng tài khoản đăng nhập mới là Remote Login
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    //Nếu vẫn là cơ sở lúc đăng nhập thì sử dụng lại tài khoản đăng nhập cũ
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show("Xảy ra lỗi khi truy cập đến cơ sở", "", MessageBoxButtons.OK);
                else
                {
                    //Nếu kết nối thành công thì tải dữ liệu mới về
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                    //Cập nhật mã cơ sở đang sử dụng
                    macoso = ((DataRowView)Program.bds_dspm[0])["TENCN"].ToString(); 
                }
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }
        }

        private void nutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupTT.Enabled = true;
            bdsGV.AddNew(); //Thêm vào cuối danh sách
            nutThem.Enabled = nutXoa.Enabled = false;
            nutLuu.Enabled = nutHuy.Enabled= true;
            gcGV.Enabled = false;
            }

        private void nutLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền mã Giáo viên!", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền họ của giáo viên!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền tên của giáo viên!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if(txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền tên của giáo viên!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if(txtDC.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa điền địa chỉ của giáo viên!", "", MessageBoxButtons.OK);
                txtDC.Focus();
                return;
            }
            try
            {
                //Thực thi SP kiểm tra mã GV đã tồn tại hay chưa!
                String strLenh = "EXEC SP_KTGV '" + txtMaGV.Text.Trim() + "'";
                Program.myreader = Program.ExecSqlDataReader(strLenh);
                if (Program.myreader != null)
                {
                    Program.myreader.Read();
                    MessageBox.Show("Mã giáo viên này đã tồn tại");
                    Program.myreader.Close();
                    return;
                }
                else
                {
                    bdsGV.EndEdit();
                    bdsGV.ResetCurrentItem();
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                }
                gcGV.Enabled = true;
                nutThem.Enabled = nutXoa.Enabled = nutTimKiem.Enabled = true;
                nutLuu.Enabled = nutPhucHoi.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void nutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_GVDK.Count > 0 || bds_bode.Count > 0) //Nếu như GV đó đã đk hoặc tạo bộ đề thì sẽ không được xóa
            {
                MessageBox.Show($"Giáo viên {txtHo.Text} {txtTen.Text} đã tạo bộ đề nên không thể xóa",
                                "Lỗi xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Giáo viên {txtHo.Text} {txtTen.Text} đã đăng ký thi nên không thể xóa",
                                "Lỗi xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa Giáo viên này khỏi CSDL?",
                    "Xóa Giáo viên", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        bdsGV.RemoveCurrent();
                        this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa nhân viên không thành công :3",
                                        "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
                        bdsGV.Position = bdsGV.Find("MAGV", bdsGV.Current);
                    }
                if (bdsGV.Count == 0) nutXoa.Enabled = false; //Nếu không có giáo viên thì nút xóa bị làm mờ
            }
        }


        private void nutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupTT.Enabled = true;
            nutLuu.Enabled =  true;
            nutSua.Enabled = nutXoa.Enabled = nutThem.Enabled = false;
        }

        private void nutHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            groupTT.Enabled = false;
        }
    }
}
