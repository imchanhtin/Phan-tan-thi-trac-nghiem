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
    public partial class formMH : Form
    {
        public formMH()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formMH_Load(object sender, EventArgs e)
        {
            groupTT.Enabled = false;
            DS.EnforceConstraints = false;
            this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MonHocTableAdapter.Fill(this.DS.MONHOC);
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            this.bODETableAdapter.Fill(this.DS.BODE);
        }

        private void nutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupTT.Enabled = true;
            bdsMonHoc.AddNew(); //Thêm vào cuối danh sách
            nutThem.Enabled = nutXoa.Enabled = false;
            nutLuu.Enabled = nutHuy.Enabled = true;
            gcMonHoc.Enabled = false;
        }

        private void nutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGVDK.Count > 0 || bdsBoDe.Count > 0 || bdsBangDiem.Count >0) //Nếu như Lớp đã có GV ĐK và SV thì không được xóa
            {
                MessageBox.Show($"Môn học {txtTenMH.Text} này không thể xóa được!",
                                "Lỗi xóa Môn Học", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này?",
                    "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    try
                    {
                        bdsMonHoc.RemoveCurrent();
                        this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.MonHocTableAdapter.Update(this.DS.MONHOC);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa Lớp không thành công!",
                                        "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.MonHocTableAdapter.Fill(this.DS.MONHOC);
                        bdsMonHoc.Position = bdsMonHoc.Find("MAMH", bdsMonHoc.Current);
                    }
                if (bdsMonHoc.Count == 0) nutXoa.Enabled = false; //Nếu không có khoa thì nút xóa bị làm mờ
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
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền mã môn học!", "Thiếu mã môn học", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa điền tên của Môn học!", "Thiếu tên!", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return;
            }
            try
            {
                //Thực thi SP kiểm tra mã GV đã tồn tại hay chưa!
                String strLenh = "EXEC SP_KTMH '" + txtMaMH.Text.Trim() + "'";
                Program.myreader = Program.ExecSqlDataReader(strLenh);
                if (Program.myreader != null)
                {
                    Program.myreader.Read();
                    MessageBox.Show("Môn học này đã tồn tại");
                    Program.myreader.Close();
                    return;
                }
                else
                {
                    bdsMonHoc.EndEdit();
                    bdsMonHoc.ResetCurrentItem();
                    this.MonHocTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MonHocTableAdapter.Update(this.DS.MONHOC);
                }
                gcMonHoc.Enabled = true;
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
            bdsMonHoc.CancelEdit();
            groupTT.Enabled = false;
        }
    }
}
