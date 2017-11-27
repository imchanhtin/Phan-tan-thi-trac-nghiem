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
    public partial class formDeThi : Form
    {
        int socauhoi;
        public formDeThi()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formDeThi_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.BoDeTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BoDeTableAdapter.Fill(this.DS.BODE);
            groupTT.Enabled = false;
            List<String> cachXem = new List<String> { "Tất cả", "Cá nhân" };
            cmbCachXem.DataSource = cachXem;
            if (cmbCachXem.SelectedValue.ToString() == "Cá Nhân")
            {
                bdsBoDe.Filter = "MAGV = '" + Program.mlogin + "'";
                nutThem.Enabled = nutSua.Enabled = nutLuu.Enabled = nutHuy.Enabled = nutXoa.Enabled = true;
            }
            else
            {
                bdsBoDe.Filter = "";
                nutThem.Enabled = nutSua.Enabled = nutLuu.Enabled = nutHuy.Enabled = nutXoa.Enabled = false;
            }
            if (Program.mGroup == "Truong")
            {
                nutXoa.Enabled = nutSua.Enabled = nutThem.Enabled = nutLuu.Enabled = nutHuy.Enabled = false;
                cmbCachXem.Enabled = false;
            }
        }

        private void txtDapAn_EditValueChanged(object sender, EventArgs e)
        {
            if (txtDapAn.Text.Length != 1)
            {
                MessageBox.Show("Vui lòng nhập ký tự đáp án: A / B / C / D", "", MessageBoxButtons.OK);
                txtDapAn.Focus();
            }
        }

        private void maCauHoi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cAUHOITextEdit_KeyPress(object sender, KeyPressEventArgs e) //Kiểm tra ký tự nhập vào ô câu hỏi có phải là số hay không?
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số!", "Lỗi nhập liệu", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void nutThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupTT.Enabled = true;
            bdsBoDe.AddNew(); //Thêm vào cuối danh sách
            nutThem.Enabled = nutXoa.Enabled = false;
            nutLuu.Enabled = nutHuy.Enabled = true;
            gcBoDe.Enabled = false;
            int countTable = DS.BODE.Count;
            MessageBox.Show(""+countTable,"",MessageBoxButtons.OK);
            //đếm số hàng có trong bảng Bộ đề 
            int socauhoi = Convert.ToInt32(DS.BODE.Rows[countTable - 1]["CAUHOI"]); 
            txtCauHoi.EditValue = socauhoi + 1;
            txtCauHoi.Enabled = false;
        }

        private void nutXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa câu hỏi này?",
                    "Xóa ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                try
                {
                    bdsBoDe.RemoveCurrent();
                    this.BoDeTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.BoDeTableAdapter.Update(this.DS.BODE);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Xóa không thành công!",
                                    "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BoDeTableAdapter.Fill(this.DS.BODE);
                    bdsBoDe.Position = bdsBoDe.Find("CAUHOI", bdsBoDe.Current);
                }
            if (bdsBoDe.Count == 0) nutXoa.Enabled = false; //Nếu không có câu hỏi thì nút xóa bị làm mờ
        }

        private void nutLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
    }
}
