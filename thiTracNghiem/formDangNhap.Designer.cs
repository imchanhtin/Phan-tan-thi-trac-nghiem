namespace thiTracNghiem
{
    partial class formDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDangNhap));
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.tracNghiemDataSet = new thiTracNghiem.TracNghiemDataSet();
            this.v_DS_PHANMANHTableAdapter1 = new thiTracNghiem.TracNghiemDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nhapID = new System.Windows.Forms.TextBox();
            this.nhapPass = new System.Windows.Forms.TextBox();
            this.nutDN = new System.Windows.Forms.Button();
            this.nutThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracNghiemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DataSource = this.bdsPM;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(297, 152);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(426, 33);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "V_DS_PHANMANH";
            this.bdsPM.DataSource = this.tracNghiemDataSet;
            this.bdsPM.CurrentChanged += new System.EventHandler(this.bdsPM_CurrentChanged);
            // 
            // tracNghiemDataSet
            // 
            this.tracNghiemDataSet.DataSetName = "TracNghiemDataSet";
            this.tracNghiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter1
            // 
            this.v_DS_PHANMANHTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(100, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn chi nhánh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(100, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(146, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu: ";
            // 
            // nhapID
            // 
            this.nhapID.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapID.Location = new System.Drawing.Point(297, 243);
            this.nhapID.Name = "nhapID";
            this.nhapID.Size = new System.Drawing.Size(426, 33);
            this.nhapID.TabIndex = 4;
            this.nhapID.TextChanged += new System.EventHandler(this.nhapID_TextChanged);
            // 
            // nhapPass
            // 
            this.nhapPass.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapPass.Location = new System.Drawing.Point(297, 311);
            this.nhapPass.Name = "nhapPass";
            this.nhapPass.PasswordChar = '*';
            this.nhapPass.Size = new System.Drawing.Size(426, 33);
            this.nhapPass.TabIndex = 5;
            // 
            // nutDN
            // 
            this.nutDN.BackColor = System.Drawing.Color.Coral;
            this.nutDN.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutDN.Location = new System.Drawing.Point(342, 424);
            this.nutDN.Name = "nutDN";
            this.nutDN.Size = new System.Drawing.Size(127, 40);
            this.nutDN.TabIndex = 6;
            this.nutDN.Text = "Đăng nhập";
            this.nutDN.UseVisualStyleBackColor = false;
            this.nutDN.Click += new System.EventHandler(this.nutDN_Click);
            // 
            // nutThoat
            // 
            this.nutThoat.BackColor = System.Drawing.Color.Coral;
            this.nutThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nutThoat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutThoat.Location = new System.Drawing.Point(488, 424);
            this.nutThoat.Name = "nutThoat";
            this.nutThoat.Size = new System.Drawing.Size(127, 40);
            this.nutThoat.TabIndex = 7;
            this.nutThoat.Text = "Thoát";
            this.nutThoat.UseVisualStyleBackColor = false;
            this.nutThoat.Click += new System.EventHandler(this.nutThoat_Click);
            // 
            // formDangNhap
            // 
            this.AcceptButton = this.nutDN;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.nutThoat;
            this.ClientSize = new System.Drawing.Size(872, 533);
            this.Controls.Add(this.nutThoat);
            this.Controls.Add(this.nutDN);
            this.Controls.Add(this.nhapPass);
            this.Controls.Add(this.nhapID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChiNhanh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formDangNhap";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracNghiemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private TracNghiemDataSet tracNghiemDataSet;
        private System.Windows.Forms.BindingSource bdsPM;
        private TracNghiemDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nhapID;
        private System.Windows.Forms.TextBox nhapPass;
        private System.Windows.Forms.Button nutDN;
        private System.Windows.Forms.Button nutThoat;
    }
}