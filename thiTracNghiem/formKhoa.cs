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
    public partial class formKhoa : Form
    {
        public formKhoa()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupTT.Enabled = true;
            bdsKhoa.AddNew(); //Thêm vào cuối danh sách
            nutThem.Enabled = nutXoa.Enabled = false;
            nutLuu.Enabled = nutHuy.Enabled= true;
            gcKhoa.Enabled = false;
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formKhoa_Load(object sender, EventArgs e)
        {
            if (Program.mGroup != "truong") cmbCoSo.Enabled = false;
            DS.EnforceConstraints = false;
            nutHuy.Enabled = groupTT.Enabled= txtMaCoSo.Enabled= false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);
            this.cosoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cosoTableAdapter.Fill(this.DS.COSO);
            this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhoaTableAdapter.Fill(this.DS.KHOA);

        }

        private void nutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLop.Count > 0) //Nếu như Khoa đã có lớp rồi thì không được xóa
            {
                MessageBox.Show($"Khoa {txtTenKhoa.Text} đã có lớp!",
                                "Lỗi xóa Khoa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa Khoa này?",
                    "Xóa Khoa", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        bdsKhoa.RemoveCurrent();
                        this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.KhoaTableAdapter.Update(this.DS.KHOA);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa Khoa không thành công!",
                                        "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.KhoaTableAdapter.Fill(this.DS.KHOA);
                        bdsKhoa.Position = bdsKhoa.Find("MAKH", bdsKhoa.Current);
                    }
                if (bdsKhoa.Count == 0) nutXoa.Enabled = false; //Nếu không có khoa thì nút xóa bị làm mờ
            }
        }

        private void nutHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            groupTT.Enabled = false;
        }

        private void nutSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupTT.Enabled = true;
            nutLuu.Enabled = nutHuy.Enabled = true;
            nutSua.Enabled = nutXoa.Enabled = nutThem.Enabled = false;
        }

        private void nutLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền mã khoa!", "Thiếu mã Khoa", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền tên của Khoa!", "Thiếu tên Khoa", MessageBoxButtons.OK);
                txtTenKhoa.Focus();
                return;
            }
            try
            {
                //Thực thi SP kiểm tra mã GV đã tồn tại hay chưa!
                String strLenh = "EXEC SP_KTKHOA '" + txtMaKhoa.Text.Trim() + "'";
                Program.myreader = Program.ExecSqlDataReader(strLenh);
                if (Program.myreader != null)
                {
                    Program.myreader.Read();
                    MessageBox.Show("Khoa này đã tồn tại");
                    Program.myreader.Close();
                    return;
                }
                else
                {
                    bdsKhoa.EndEdit();
                    bdsKhoa.ResetCurrentItem();
                    this.KhoaTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhoaTableAdapter.Update(this.DS.KHOA);
                }
                gcKhoa.Enabled = true;
                nutThem.Enabled = nutXoa.Enabled = true;
                nutLuu.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
