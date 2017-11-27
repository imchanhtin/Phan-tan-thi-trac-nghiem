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
    public partial class formLop : Form
    {
        public formLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formLop_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            nutHuy.Enabled = groupTT.Enabled = false;
            this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhoaTableAdapter.Fill(this.DS.KHOA);
            this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LopTableAdapter.Fill(this.DS.LOP);
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            this.GVDKTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }


        private void mALOPTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupTT.Enabled = true;
            bdsLop.AddNew(); //Thêm vào cuối danh sách
            nutThem.Enabled = nutXoa.Enabled = false;
            nutLuu.Enabled = nutHuy.Enabled = true;
            gcLop.Enabled = false;
        }

        private void nutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGVDK.Count > 0 || bdsSV.Count >0) //Nếu như Lớp đã có GV ĐK và SV thì không được xóa
            {
                MessageBox.Show($"Lớp {txtTenLop.Text} này không thể xóa được!",
                                "Lỗi xóa Lớp", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa Lớp này?",
                    "Xóa Lớp", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        bdsLop.RemoveCurrent();
                        this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.LopTableAdapter.Update(this.DS.LOP);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa Lớp không thành công!",
                                        "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LopTableAdapter.Fill(this.DS.LOP);
                        bdsLop.Position = bdsLop.Find("MALOP", bdsLop.Current);
                    }
                if (bdsLop.Count == 0) nutXoa.Enabled = false; //Nếu không có khoa thì nút xóa bị làm mờ
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
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền mã Lớp!", "Thiếu mã Lớp", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền tên của Khoa!", "Thiếu tên Khoa", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            try
            {
                //Thực thi SP kiểm tra mã GV đã tồn tại hay chưa!
                String strLenh = "EXEC SP_KTLOP '" + txtMaKhoa.Text.Trim() + "'";
                Program.myreader = Program.ExecSqlDataReader(strLenh);
                if (Program.myreader != null)
                {
                    Program.myreader.Read();
                    MessageBox.Show("Lớp này đã tồn tại");
                    Program.myreader.Close();
                    return;
                }
                else
                {
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    this.LopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LopTableAdapter.Update(this.DS.LOP);
                }
                gcLop.Enabled = true;
                nutThem.Enabled = nutXoa.Enabled = true;
                nutLuu.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void nutHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            groupTT.Enabled = false;
        }
    }
}
