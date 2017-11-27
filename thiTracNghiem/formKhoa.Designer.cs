namespace thiTracNghiem
{
    partial class formKhoa
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
            System.Windows.Forms.Label tENCSLabel;
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mAKHLabel;
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new thiTracNghiem.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.nutThem = new DevExpress.XtraBars.BarButtonItem();
            this.nutXoa = new DevExpress.XtraBars.BarButtonItem();
            this.nutSua = new DevExpress.XtraBars.BarButtonItem();
            this.nutLuu = new DevExpress.XtraBars.BarButtonItem();
            this.nutHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.KhoaTableAdapter = new thiTracNghiem.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new thiTracNghiem.DSTableAdapters.TableAdapterManager();
            this.cosoTableAdapter = new thiTracNghiem.DSTableAdapters.COSOTableAdapter();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCoSo = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.groupTT = new System.Windows.Forms.GroupBox();
            this.txtMaCoSo = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new thiTracNghiem.DSTableAdapters.LOPTableAdapter();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            tENCSLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCoSo)).BeginInit();
            this.groupTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCoSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCSLabel
            // 
            tENCSLabel.AutoSize = true;
            tENCSLabel.Location = new System.Drawing.Point(573, 12);
            tENCSLabel.Name = "tENCSLabel";
            tENCSLabel.Size = new System.Drawing.Size(48, 17);
            tENCSLabel.TabIndex = 5;
            tENCSLabel.Text = "Cơ sở:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "MACS", true));
            mACSLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACSLabel.Location = new System.Drawing.Point(809, 117);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(113, 25);
            mACSLabel.TabIndex = 17;
            mACSLabel.Text = "Mã Cơ sở: ";
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHLabel.Location = new System.Drawing.Point(443, 117);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(98, 25);
            tENKHLabel.TabIndex = 15;
            tENKHLabel.Text = "Tên Khoa";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(144, 117);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(93, 25);
            mAKHLabel.TabIndex = 13;
            mAKHLabel.Text = "Mã Khoa";
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
            this.nutHuy,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nutThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nutXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nutSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nutLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nutHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.nutThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.nutSua.Caption = "Sửa";
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
            // nutHuy
            // 
            this.nutHuy.Caption = "Hủy";
            this.nutHuy.Id = 4;
            this.nutHuy.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Undo_icon_24;
            this.nutHuy.Name = "nutHuy";
            this.nutHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nutHuy_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1186, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 693);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1186, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 653);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1186, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 653);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // KhoaTableAdapter
            // 
            this.KhoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = this.cosoTableAdapter;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.KhoaTableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = thiTracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cosoTableAdapter
            // 
            this.cosoTableAdapter.ClearBeforeFill = true;
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.bdsKhoa;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKhoa.Location = new System.Drawing.Point(0, 40);
            this.gcKhoa.MainView = this.gridView1;
            this.gcKhoa.MenuManager = this.barManager1;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(1186, 396);
            this.gcKhoa.TabIndex = 5;
            this.gcKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.gcKhoa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã Khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.OptionsColumn.AllowFocus = false;
            this.colMAKH.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMAKH.OptionsColumn.AllowMove = false;
            this.colMAKH.OptionsColumn.AllowShowHide = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            // 
            // colTENKH
            // 
            this.colTENKH.Caption = "Tên Khoa";
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.OptionsColumn.AllowEdit = false;
            this.colTENKH.OptionsColumn.AllowFocus = false;
            this.colTENKH.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTENKH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTENKH.OptionsColumn.AllowMove = false;
            this.colTENKH.OptionsColumn.AllowShowHide = false;
            this.colTENKH.OptionsColumn.AllowSize = false;
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            // 
            // colMACS
            // 
            this.colMACS.Caption = "Mã cơ sở";
            this.colMACS.FieldName = "MACS";
            this.colMACS.Name = "colMACS";
            this.colMACS.OptionsColumn.AllowEdit = false;
            this.colMACS.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMACS.OptionsColumn.AllowIncrementalSearch = false;
            this.colMACS.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMACS.OptionsColumn.AllowMove = false;
            this.colMACS.OptionsColumn.AllowShowHide = false;
            this.colMACS.OptionsColumn.AllowSize = false;
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            // 
            // bdsCoSo
            // 
            this.bdsCoSo.DataMember = "COSO";
            this.bdsCoSo.DataSource = this.DS;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCoSo, "TENCS", true));
            this.cmbCoSo.DataSource = this.bdsCoSo;
            this.cmbCoSo.DisplayMember = "TENCS";
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(637, 9);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(119, 24);
            this.cmbCoSo.TabIndex = 6;
            this.cmbCoSo.ValueMember = "MACS";
            // 
            // groupTT
            // 
            this.groupTT.Controls.Add(mACSLabel);
            this.groupTT.Controls.Add(this.txtMaCoSo);
            this.groupTT.Controls.Add(tENKHLabel);
            this.groupTT.Controls.Add(this.txtTenKhoa);
            this.groupTT.Controls.Add(mAKHLabel);
            this.groupTT.Controls.Add(this.txtMaKhoa);
            this.groupTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTT.Location = new System.Drawing.Point(0, 436);
            this.groupTT.Name = "groupTT";
            this.groupTT.Size = new System.Drawing.Size(1186, 260);
            this.groupTT.TabIndex = 17;
            this.groupTT.TabStop = false;
            // 
            // txtMaCoSo
            // 
            this.txtMaCoSo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "MACS", true));
            this.txtMaCoSo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.txtMaCoSo.Location = new System.Drawing.Point(928, 114);
            this.txtMaCoSo.MenuManager = this.barManager1;
            this.txtMaCoSo.Name = "txtMaCoSo";
            this.txtMaCoSo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCoSo.Properties.Appearance.Options.UseFont = true;
            this.txtMaCoSo.Size = new System.Drawing.Size(115, 32);
            this.txtMaCoSo.TabIndex = 18;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(554, 114);
            this.txtTenKhoa.MenuManager = this.barManager1;
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtTenKhoa.Size = new System.Drawing.Size(191, 32);
            this.txtTenKhoa.TabIndex = 16;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(247, 114);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(115, 32);
            this.txtMaKhoa.TabIndex = 14;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "FK_LOP_KHOA";
            this.bdsLop.DataSource = this.bdsKhoa;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gcKhoa;
            this.searchControl1.Location = new System.Drawing.Point(905, 14);
            this.searchControl1.MenuManager = this.barManager1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gcKhoa;
            this.searchControl1.Size = new System.Drawing.Size(280, 22);
            this.searchControl1.TabIndex = 22;
            // 
            // formKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.groupTT);
            this.Controls.Add(tENCSLabel);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.gcKhoa);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formKhoa";
            this.Text = "formKhoa";
            this.Load += new System.EventHandler(this.formKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCoSo)).EndInit();
            this.groupTT.ResumeLayout(false);
            this.groupTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCoSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem nutThem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem nutXoa;
        private DevExpress.XtraBars.BarButtonItem nutSua;
        private DevExpress.XtraBars.BarButtonItem nutLuu;
        private DevExpress.XtraBars.BarButtonItem nutHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DS DS;
        private DSTableAdapters.KHOATableAdapter KhoaTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DSTableAdapters.COSOTableAdapter cosoTableAdapter;
        private System.Windows.Forms.BindingSource bdsCoSo;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.GroupBox groupTT;
        private DevExpress.XtraEditors.TextEdit txtMaCoSo;
        private DevExpress.XtraEditors.TextEdit txtTenKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraEditors.SearchControl searchControl1;
    }
}