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
    public partial class formSV : Form
    {
        int vitri;
        string macoso = "";
        public formSV()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formSV_Load(object sender, EventArgs e)
        {
            if (Program.mGroup != "truong") cmbCoSo.Enabled = false;
            this.cOSOTableAdapter.Fill(this.DS.COSO);
            DS.EnforceConstraints = false;
            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DS.LOP);
            this.svTableAdapter.Connection.ConnectionString = Program.connstr;
            this.svTableAdapter.Fill(this.DS.SINHVIEN);
            this.bANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);
            //lấy mã cơ sở của tài khoản đăng nhập
            macoso = ((DataRowView)Program.bds_dspm[0])["TENCN"].ToString();

        }

        private void nutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsSV.Position; //vị trí con trỏ đang đứng để undo sau này
            groupTT.Enabled = true;
            bdsSV.AddNew(); //Thêm vào cuối danh sách
            nutThem.Enabled = nutXoa.Enabled = false;
            nutLuu.Enabled= true;
            gcSV.Enabled = false;
        }

        private void nutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBangDiem.Count > 0) //Nếu như GV đó đã đk hoặc tạo bộ đề thì sẽ không được xóa
            {
                MessageBox.Show($"Sinh viên {txtHo.Text} {txtTen.Text} đã có điểm thi",
                                "Lỗi xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa Sinh viên này?",
                    "Xóa Sinh viên", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        bdsSV.RemoveCurrent();
                        this.svTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.svTableAdapter.Update(this.DS.SINHVIEN);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa nhân viên không thành công :3",
                                        "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.svTableAdapter.Fill(this.DS.SINHVIEN);
                        bdsSV.Position = bdsSV.Find("MASV", bdsSV.Current);
                    }
                if (bdsSV.Count == 0) nutXoa.Enabled = false; //Nếu không có nhân viên thì nút xóa bị làm mờ
            }
        }

        private void nutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupTT.Enabled = true;
            nutLuu.Enabled = nutHuy.Enabled = true;
            nutSua.Enabled = nutXoa.Enabled = nutThem.Enabled = false;
        }

        private void nutLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền mã sinh viên!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền họ của sinh viên!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền tên của sinh viên!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền ngày sinh của sinh viên!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtDC.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền địa chỉ của sinh viên!", "", MessageBoxButtons.OK);
                txtDC.Focus();
                return;
            }

            try
            {
                //Thực thi SP kiểm tra mã GV đã tồn tại hay chưa!
                String strLenh = "EXEC SP_KTSV '" + txtMaSV.Text.Trim() + "'";
                Program.myreader = Program.ExecSqlDataReader(strLenh);
                if (Program.myreader != null)
                {
                    Program.myreader.Read();
                    MessageBox.Show("Mã sinh viên này đã tồn tại");
                    Program.myreader.Close();
                    return;
                }
                else
                {
                    bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    this.svTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.svTableAdapter.Update(this.DS.SINHVIEN);
                }
                gcSV.Enabled = true;
                nutThem.Enabled = nutXoa.Enabled =  true;
                nutLuu.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void nutHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            groupTT.Enabled = false;
        }
    }
}

