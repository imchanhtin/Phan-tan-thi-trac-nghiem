using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace thiTracNghiem
{
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            this.v_DS_PHANMANHTableAdapter1.Fill(this.tracNghiemDataSet.V_DS_PHANMANH);
            cmbChiNhanh.SelectedIndex = 0;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch(NullReferenceException nullRef)
            {
                return;
            }
        }
        private void nutDN_Click(object sender, EventArgs e)
        {
            if (nhapID.Text.Trim() == "" || nhapPass.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên đăng nhập và mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK);
                nhapID.Focus();
                nhapPass.Focus();
                return;
            }

            Program.mlogin = nhapID.Text;
            Program.password = nhapPass.Text;
            Program.bds_dspm = bdsPM;                   //Ghi lại tên server
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            if (Program.KetNoi() == 0)return;
            Program.mCoso = cmbChiNhanh.SelectedIndex;// Ghi lại index của chi nhánh được chọn lúc đăng nhập
            MessageBox.Show("Đăng nhập thành công", " ", MessageBoxButtons.OK);



            //Thực thi SP Đăng nhập
            String strLenh = "EXEC SP_DANGNHAP'" + Program.mlogin + "'";
            Program.myreader = Program.ExecSqlDataReader(strLenh);
            if (Program.myreader == null) return;
            Program.myreader.Read();//Đọc 1 dòng trong bảng, trả về trạng thái của do

            //Lấy username 
            Program.username = Program.myreader.GetString(0);
            //Dữ liệu sẽ được trích xuất ra theo từng cột
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản đăng nhập không có quyền truy cập dữ liệu \n ",
                                "Lỗi quyền truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.mHoten = Program.myreader.GetString(1);
            Program.mGroup = Program.myreader.GetString(2);
            Program.myreader.Close();
            

            //Hiển thị thông tin tài khoản đăng nhập ở phần cạnh dưới chương trình
            Program.formChinh.maGV.Text = "Mã: " + Program.username;
            Program.formChinh.hoten.Text = "Họ và tên: " + Program.mHoten;
            Program.formChinh.nhomquyen.Text = "Nhóm quyền: " + Program.mGroup;
            this.Hide();
            if (Program.mGroup == "giaovien" || Program.mGroup == "coso")
            { 
                formGiaoVien formGiaoVien = new formGiaoVien();
                formGiaoVien.MdiParent = Program.formChinh;
                formGiaoVien.Show();

            }
            if (Program.mGroup == "sinhvien")
            {
                formSV formSinhVien = new formSV();
                formSinhVien.MdiParent = Program.formChinh;
                formSinhVien.Show();
            }
        }
            
        private void nutThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bdsPM_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void nhapID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
