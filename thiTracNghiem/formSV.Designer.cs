namespace thiTracNghiem
{
    partial class formSV
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
            System.Windows.Forms.Label label_Ten;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label tENCSLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.nutThem = new DevExpress.XtraBars.BarButtonItem();
            this.nutXoa = new DevExpress.XtraBars.BarButtonItem();
            this.nutSua = new DevExpress.XtraBars.BarButtonItem();
            this.nutLuu = new DevExpress.XtraBars.BarButtonItem();
            this.nutIn = new DevExpress.XtraBars.BarButtonItem();
            this.nutHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new thiTracNghiem.DS();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.LopTableAdapter = new thiTracNghiem.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new thiTracNghiem.DSTableAdapters.TableAdapterManager();
            this.bANGDIEMTableAdapter = new thiTracNghiem.DSTableAdapters.BANGDIEMTableAdapter();
            this.svTableAdapter = new thiTracNghiem.DSTableAdapters.SINHVIENTableAdapter();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.gcSV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupTT = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDC = new DevExpress.XtraEditors.TextEdit();
            this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.cOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOSOTableAdapter = new thiTracNghiem.DSTableAdapters.COSOTableAdapter();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            label_Ten = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            tENCSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Ten
            // 
            label_Ten.AutoSize = true;
            label_Ten.Location = new System.Drawing.Point(736, 15);
            label_Ten.Name = "label_Ten";
            label_Ten.Size = new System.Drawing.Size(36, 17);
            label_Ten.TabIndex = 5;
            label_Ten.Text = "Lớp:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(808, 161);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(36, 17);
            mALOPLabel.TabIndex = 29;
            mALOPLabel.Text = "Lớp ";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(808, 109);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(56, 17);
            dIACHILabel.TabIndex = 27;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(808, 63);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(83, 17);
            nGAYSINHLabel.TabIndex = 25;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(342, 114);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(40, 17);
            tENLabel.TabIndex = 23;
            tENLabel.Text = "TEN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(197, 114);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(33, 17);
            hOLabel.TabIndex = 21;
            hOLabel.Text = "HO:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(190, 55);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(50, 17);
            mASVLabel.TabIndex = 19;
            mASVLabel.Text = "MASV:";
            // 
            // tENCSLabel
            // 
            tENCSLabel.AutoSize = true;
            tENCSLabel.Location = new System.Drawing.Point(545, 15);
            tENCSLabel.Name = "tENCSLabel";
            tENCSLabel.Size = new System.Drawing.Size(48, 17);
            tENCSLabel.TabIndex = 30;
            tENCSLabel.Text = "Cơ sở:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.nutThem,
            this.nutXoa,
            this.nutSua,
            this.nutLuu,
            this.nutIn,
            this.nutHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(257, 191);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nutThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nutXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nutSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nutHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nutLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // nutThem
            // 
            this.nutThem.Caption = "Thêm";
            this.nutThem.Id = 0;
            this.nutThem.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Button_Add_24_icon;
            this.nutThem.Name = "nutThem";
            this.nutThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nutThem_ItemClick);
            // 
            // nutXoa
            // 
            this.nutXoa.Caption = "Xóa";
            this.nutXoa.Id = 1;
            this.nutXoa.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Delete_2_icon_24;
            this.nutXoa.Name = "nutXoa";
            this.nutXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nutXoa_ItemClick);
            // 
            // nutSua
            // 
            this.nutSua.Caption = "Chỉnh sửa";
            this.nutSua.Id = 2;
            this.nutSua.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Text_Edit_icon_24;
            this.nutSua.Name = "nutSua";
            this.nutSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nutSua_ItemClick);
            // 
            // nutLuu
            // 
            this.nutLuu.Caption = "Lưu";
            this.nutLuu.Id = 3;
            this.nutLuu.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Save_icon_24;
            this.nutLuu.Name = "nutLuu";
            this.nutLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nutLuu_ItemClick);
            // 
            // nutIn
            // 
            this.nutIn.Caption = "In";
            this.nutIn.Id = 4;
            this.nutIn.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.print;
            this.nutIn.Name = "nutIn";
            // 
            // nutHuy
            // 
            this.nutHuy.Caption = "Hủy";
            this.nutHuy.Id = 5;
            this.nutHuy.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Undo_icon_241;
            this.nutHuy.Name = "nutHuy";
            this.nutHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nutHuy_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1187, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 628);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1187, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 588);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1187, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 588);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // LopTableAdapter
            // 
            this.LopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LopTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.svTableAdapter;
            this.tableAdapterManager.UpdateOrder = thiTracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // svTableAdapter
            // 
            this.svTableAdapter.ClearBeforeFill = true;
            // 
            // cmbLop
            // 
            this.cmbLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.cmbLop.DataSource = this.bdsLop;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(778, 12);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(157, 24);
            this.cmbLop.TabIndex = 6;
            this.cmbLop.ValueMember = "MALOP";
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLop;
            // 
            // gcSV
            // 
            this.gcSV.DataSource = this.bdsSV;
            this.gcSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSV.Location = new System.Drawing.Point(0, 40);
            this.gcSV.MainView = this.gridView1;
            this.gcSV.MenuManager = this.barManager1;
            this.gcSV.Name = "gcSV";
            this.gcSV.Size = new System.Drawing.Size(1187, 354);
            this.gcSV.TabIndex = 6;
            this.gcSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colMALOP});
            this.gridView1.GridControl = this.gcSV;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã SV";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã Lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 5;
            // 
            // groupTT
            // 
            this.groupTT.Controls.Add(this.comboBox1);
            this.groupTT.Controls.Add(mALOPLabel);
            this.groupTT.Controls.Add(dIACHILabel);
            this.groupTT.Controls.Add(this.txtDC);
            this.groupTT.Controls.Add(nGAYSINHLabel);
            this.groupTT.Controls.Add(this.txtNgaySinh);
            this.groupTT.Controls.Add(tENLabel);
            this.groupTT.Controls.Add(this.txtTen);
            this.groupTT.Controls.Add(hOLabel);
            this.groupTT.Controls.Add(this.txtHo);
            this.groupTT.Controls.Add(mASVLabel);
            this.groupTT.Controls.Add(this.txtMaSV);
            this.groupTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTT.Location = new System.Drawing.Point(0, 394);
            this.groupTT.Name = "groupTT";
            this.groupTT.Size = new System.Drawing.Size(1187, 288);
            this.groupTT.TabIndex = 7;
            this.groupTT.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.comboBox1.DataSource = this.bdsLop;
            this.comboBox1.DisplayMember = "TENLOP";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(897, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.ValueMember = "MALOP";
            // 
            // txtDC
            // 
            this.txtDC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DIACHI", true));
            this.txtDC.Location = new System.Drawing.Point(897, 106);
            this.txtDC.MenuManager = this.barManager1;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(168, 22);
            this.txtDC.TabIndex = 28;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.txtNgaySinh.EditValue = null;
            this.txtNgaySinh.Location = new System.Drawing.Point(897, 60);
            this.txtNgaySinh.MenuManager = this.barManager1;
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Size = new System.Drawing.Size(168, 22);
            this.txtNgaySinh.TabIndex = 26;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(388, 111);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 24;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(236, 111);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(100, 22);
            this.txtHo.TabIndex = 22;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(246, 52);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 22);
            this.txtMaSV.TabIndex = 20;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gcSV;
            this.searchControl1.Location = new System.Drawing.Point(970, 12);
            this.searchControl1.MenuManager = this.barManager1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gcSV;
            this.searchControl1.Size = new System.Drawing.Size(217, 22);
            this.searchControl1.TabIndex = 8;
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "FK_BANGDIEM_SINHVIEN1";
            this.bdsBangDiem.DataSource = this.bdsSV;
            // 
            // cOSOBindingSource
            // 
            this.cOSOBindingSource.DataMember = "COSO";
            this.cOSOBindingSource.DataSource = this.DS;
            // 
            // cOSOTableAdapter
            // 
            this.cOSOTableAdapter.ClearBeforeFill = true;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOSOBindingSource, "TENCS", true));
            this.cmbCoSo.DataSource = this.cOSOBindingSource;
            this.cmbCoSo.DisplayMember = "TENCS";
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbCoSo.Location = new System.Drawing.Point(609, 12);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(121, 24);
            this.cmbCoSo.TabIndex = 31;
            this.cmbCoSo.ValueMember = "MACS";
            // 
            // formSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 628);
            this.Controls.Add(tENCSLabel);
            this.Controls.Add(label_Ten);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.groupTT);
            this.Controls.Add(this.gcSV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupTT.ResumeLayout(false);
            this.groupTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem nutThem;
        private DevExpress.XtraBars.BarButtonItem nutXoa;
        private DevExpress.XtraBars.BarButtonItem nutSua;
        private DevExpress.XtraBars.BarButtonItem nutLuu;
        private DevExpress.XtraBars.BarButtonItem nutIn;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS DS;
        private DSTableAdapters.LOPTableAdapter LopTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbLop;
        private DSTableAdapters.SINHVIENTableAdapter svTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
        private DevExpress.XtraGrid.GridControl gcSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.GroupBox groupTT;
        private DevExpress.XtraEditors.TextEdit txtDC;
        private DevExpress.XtraEditors.DateEdit txtNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsBangDiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cOSOBindingSource;
        private DSTableAdapters.COSOTableAdapter cOSOTableAdapter;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private DevExpress.XtraBars.BarButtonItem nutHuy;
    }
}