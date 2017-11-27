namespace thiTracNghiem
{
    partial class formGiaoVien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mAKHLabel;
            DevExpress.XtraGrid.Columns.GridColumn colMAGV;
            DevExpress.XtraGrid.Columns.GridColumn colHO;
            DevExpress.XtraGrid.Columns.GridColumn colTEN;
            DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
            DevExpress.XtraGrid.Columns.GridColumn colMAKH;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.nutThem = new DevExpress.XtraBars.BarButtonItem();
            this.nutXoa = new DevExpress.XtraBars.BarButtonItem();
            this.nutSua = new DevExpress.XtraBars.BarButtonItem();
            this.nutHuy = new DevExpress.XtraBars.BarButtonItem();
            this.nutLuu = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.nutPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.nutTimKiem = new DevExpress.XtraBars.BarButtonItem();
            this.nutIn = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.cOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new thiTracNghiem.DS();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENTableAdapter = new thiTracNghiem.DSTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new thiTracNghiem.DSTableAdapters.TableAdapterManager();
            this.groupTT = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.txtDC = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcGV = new DevExpress.XtraGrid.GridControl();
            this.cOSOTableAdapter = new thiTracNghiem.DSTableAdapters.COSOTableAdapter();
            this.bds_GVDK = new System.Windows.Forms.BindingSource(this.components);
            this.GVDKTableAdapter = new thiTracNghiem.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bds_bode = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new thiTracNghiem.DSTableAdapters.BODETableAdapter();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            this.groupTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_bode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(83, 91);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(90, 25);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Mã GV: ";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(83, 165);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(109, 25);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ và tên: ";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(762, 166);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(88, 25);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ: ";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(751, 91);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(99, 25);
            mAKHLabel.TabIndex = 8;
            mAKHLabel.Text = "Mã Khoa:";
            // 
            // colMAGV
            // 
            colMAGV.Caption = "Mã Giáo viên";
            colMAGV.FieldName = "MAGV";
            colMAGV.Name = "colMAGV";
            colMAGV.OptionsColumn.AllowEdit = false;
            colMAGV.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            colMAGV.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colMAGV.OptionsColumn.AllowMove = false;
            colMAGV.OptionsColumn.AllowShowHide = false;
            colMAGV.OptionsColumn.AllowSize = false;
            colMAGV.OptionsColumn.ReadOnly = true;
            colMAGV.OptionsFilter.AllowAutoFilter = false;
            colMAGV.OptionsFilter.AllowFilter = false;
            colMAGV.Visible = true;
            colMAGV.VisibleIndex = 0;
            colMAGV.Width = 140;
            // 
            // colHO
            // 
            colHO.Caption = "Họ";
            colHO.FieldName = "HO";
            colHO.Name = "colHO";
            colHO.OptionsColumn.AllowEdit = false;
            colHO.OptionsColumn.AllowMove = false;
            colHO.OptionsColumn.AllowShowHide = false;
            colHO.OptionsColumn.AllowSize = false;
            colHO.OptionsColumn.ReadOnly = true;
            colHO.OptionsFilter.AllowFilter = false;
            colHO.Visible = true;
            colHO.VisibleIndex = 1;
            colHO.Width = 271;
            // 
            // colTEN
            // 
            colTEN.Caption = "Tên";
            colTEN.FieldName = "TEN";
            colTEN.Name = "colTEN";
            colTEN.OptionsColumn.AllowEdit = false;
            colTEN.OptionsColumn.AllowMove = false;
            colTEN.OptionsColumn.AllowShowHide = false;
            colTEN.OptionsColumn.AllowSize = false;
            colTEN.OptionsColumn.ReadOnly = true;
            colTEN.OptionsFilter.AllowAutoFilter = false;
            colTEN.OptionsFilter.AllowFilter = false;
            colTEN.Visible = true;
            colTEN.VisibleIndex = 2;
            colTEN.Width = 265;
            // 
            // colDIACHI
            // 
            colDIACHI.Caption = "Địa chỉ";
            colDIACHI.FieldName = "DIACHI";
            colDIACHI.Name = "colDIACHI";
            colDIACHI.OptionsColumn.AllowEdit = false;
            colDIACHI.OptionsColumn.AllowMove = false;
            colDIACHI.OptionsColumn.AllowShowHide = false;
            colDIACHI.OptionsColumn.AllowSize = false;
            colDIACHI.OptionsColumn.ReadOnly = true;
            colDIACHI.OptionsFilter.AllowAutoFilter = false;
            colDIACHI.OptionsFilter.AllowFilter = false;
            colDIACHI.Visible = true;
            colDIACHI.VisibleIndex = 3;
            colDIACHI.Width = 315;
            // 
            // colMAKH
            // 
            colMAKH.Caption = "Mã Khoa ";
            colMAKH.FieldName = "MAKH";
            colMAKH.Name = "colMAKH";
            colMAKH.OptionsColumn.AllowEdit = false;
            colMAKH.OptionsColumn.AllowMove = false;
            colMAKH.OptionsColumn.AllowShowHide = false;
            colMAKH.OptionsColumn.AllowSize = false;
            colMAKH.OptionsColumn.ReadOnly = true;
            colMAKH.OptionsFilter.AllowAutoFilter = false;
            colMAKH.OptionsFilter.AllowFilter = false;
            colMAKH.Visible = true;
            colMAKH.VisibleIndex = 4;
            colMAKH.Width = 223;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.nutXoa,
            this.nutLuu,
            this.nutPhucHoi,
            this.nutTimKiem,
            this.nutThem,
            this.nutSua,
            this.nutIn,
            this.nutHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(104, 184);
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
            this.nutThem.Id = 5;
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
            this.nutSua.Id = 6;
            this.nutSua.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Text_Edit_icon_24;
            this.nutSua.Name = "nutSua";
            this.nutSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nutSua_ItemClick);
            // 
            // nutHuy
            // 
            this.nutHuy.Caption = "Hủy";
            this.nutHuy.Id = 9;
            this.nutHuy.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Undo_icon_241;
            this.nutHuy.Name = "nutHuy";
            this.nutHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nutHuy_ItemClick);
            // 
            // nutLuu
            // 
            this.nutLuu.Caption = "Lưu";
            this.nutLuu.Id = 2;
            this.nutLuu.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Save_icon_24;
            this.nutLuu.Name = "nutLuu";
            this.nutLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nutLuu_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1234, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 882);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1234, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 842);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1234, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 842);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm ";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.add1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // nutPhucHoi
            // 
            this.nutPhucHoi.Caption = "Phục hồi ";
            this.nutPhucHoi.Id = 3;
            this.nutPhucHoi.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Undo_icon_24;
            this.nutPhucHoi.Name = "nutPhucHoi";
            // 
            // nutTimKiem
            // 
            this.nutTimKiem.Id = 8;
            this.nutTimKiem.Name = "nutTimKiem";
            // 
            // nutIn
            // 
            this.nutIn.Caption = "In ";
            this.nutIn.Id = 7;
            this.nutIn.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.print;
            this.nutIn.Name = "nutIn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbCoSo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 70);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở: ";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DataSource = this.cOSOBindingSource;
            this.cmbCoSo.DisplayMember = "MACS";
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(555, 10);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(261, 33);
            this.cmbCoSo.TabIndex = 0;
            this.cmbCoSo.ValueMember = "TENCS";
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // cOSOBindingSource
            // 
            this.cOSOBindingSource.DataMember = "COSO";
            this.cOSOBindingSource.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIAOVIEN";
            this.bdsGV.DataSource = this.DS;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = thiTracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupTT
            // 
            this.groupTT.Controls.Add(mAKHLabel);
            this.groupTT.Controls.Add(this.txtMaKH);
            this.groupTT.Controls.Add(dIACHILabel);
            this.groupTT.Controls.Add(this.txtDC);
            this.groupTT.Controls.Add(this.txtTen);
            this.groupTT.Controls.Add(hOLabel);
            this.groupTT.Controls.Add(this.txtHo);
            this.groupTT.Controls.Add(mAGVLabel);
            this.groupTT.Controls.Add(this.txtMaGV);
            this.groupTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTT.Location = new System.Drawing.Point(0, 410);
            this.groupTT.Name = "groupTT";
            this.groupTT.Size = new System.Drawing.Size(1234, 472);
            this.groupTT.TabIndex = 11;
            this.groupTT.TabStop = false;
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "MAKH", true));
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAKH", true));
            this.txtMaKH.EditValue = "<Null>";
            this.txtMaKH.Location = new System.Drawing.Point(856, 88);
            this.txtMaKH.MenuManager = this.barManager1;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(246, 22);
            this.txtMaKH.TabIndex = 9;
            // 
            // txtDC
            // 
            this.txtDC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "DIACHI", true));
            this.txtDC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "DIACHI", true));
            this.txtDC.EditValue = "<Null>";
            this.txtDC.Location = new System.Drawing.Point(856, 170);
            this.txtDC.MenuManager = this.barManager1;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(246, 22);
            this.txtDC.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "TEN", true));
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(441, 169);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(130, 22);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HO", true));
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "HO", true));
            this.txtHo.EditValue = "<Null>";
            this.txtHo.Location = new System.Drawing.Point(198, 169);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(237, 22);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "MAGV", true));
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGV, "MAGV", true));
            this.txtMaGV.EditValue = "<Null>";
            this.txtMaGV.Location = new System.Drawing.Point(198, 88);
            this.txtMaGV.MenuManager = this.barManager1;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(272, 22);
            this.txtMaGV.TabIndex = 1;
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            colMAGV,
            colHO,
            colTEN,
            colDIACHI,
            colMAKH});
            this.gvData.GridControl = this.gcGV;
            this.gvData.Name = "gvData";
            // 
            // gcGV
            // 
            this.gcGV.DataSource = this.bdsGV;
            this.gcGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGV.Location = new System.Drawing.Point(0, 110);
            this.gcGV.MainView = this.gvData;
            this.gcGV.MenuManager = this.barManager1;
            this.gcGV.Name = "gcGV";
            this.gcGV.Size = new System.Drawing.Size(1234, 300);
            this.gcGV.TabIndex = 6;
            this.gcGV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // cOSOTableAdapter
            // 
            this.cOSOTableAdapter.ClearBeforeFill = true;
            // 
            // bds_GVDK
            // 
            this.bds_GVDK.DataMember = "GIAOVIEN_DANGKY";
            this.bds_GVDK.DataSource = this.DS;
            // 
            // GVDKTableAdapter
            // 
            this.GVDKTableAdapter.ClearBeforeFill = true;
            // 
            // bds_bode
            // 
            this.bds_bode.DataMember = "FK_BODE_GIAOVIEN";
            this.bds_bode.DataSource = this.bdsGV;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gcGV;
            this.searchControl1.Location = new System.Drawing.Point(945, 2);
            this.searchControl1.MenuManager = this.barManager1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gcGV;
            this.searchControl1.Size = new System.Drawing.Size(289, 38);
            this.searchControl1.TabIndex = 21;
            // 
            // formGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 907);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.groupTT);
            this.Controls.Add(this.gcGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            this.groupTT.ResumeLayout(false);
            this.groupTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_bode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem nutXoa;
        private DevExpress.XtraBars.BarButtonItem nutLuu;
        private DevExpress.XtraBars.BarButtonItem nutPhucHoi;
        private DevExpress.XtraBars.BarButtonItem nutTimKiem;
        private DevExpress.XtraBars.BarButtonItem nutThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.BindingSource bdsGV;
        private DS DS;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupTT;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.TextEdit txtDC;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraGrid.GridControl gcGV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private System.Windows.Forms.BindingSource cOSOBindingSource;
        private DSTableAdapters.COSOTableAdapter cOSOTableAdapter;
        private System.Windows.Forms.BindingSource bds_GVDK;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter GVDKTableAdapter;
        private DevExpress.XtraBars.BarButtonItem nutSua;
        private DevExpress.XtraBars.BarButtonItem nutIn;
        private System.Windows.Forms.BindingSource bds_bode;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraBars.BarButtonItem nutHuy;
    }
}