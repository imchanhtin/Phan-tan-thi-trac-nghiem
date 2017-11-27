namespace thiTracNghiem
{
    partial class formMH
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAMHLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.nutThem = new DevExpress.XtraBars.BarButtonItem();
            this.nutXoa = new DevExpress.XtraBars.BarButtonItem();
            this.nutSua = new DevExpress.XtraBars.BarButtonItem();
            this.nutLuu = new DevExpress.XtraBars.BarButtonItem();
            this.nutHuy = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new thiTracNghiem.DS();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.MonHocTableAdapter = new thiTracNghiem.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new thiTracNghiem.DSTableAdapters.TableAdapterManager();
            this.gcMonHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupTT = new System.Windows.Forms.GroupBox();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new DevExpress.XtraEditors.TextEdit();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new thiTracNghiem.DSTableAdapters.BODETableAdapter();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new thiTracNghiem.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bdsBangDiem = new System.Windows.Forms.BindingSource(this.components);
            this.bANGDIEMTableAdapter = new thiTracNghiem.DSTableAdapters.BANGDIEMTableAdapter();
            tENMHLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).BeginInit();
            this.SuspendLayout();
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
            this.nutHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1193, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 673);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1193, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 633);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1193, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 633);
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
            this.nutThem.Caption = "Thêm ";
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
            // nutHuy
            // 
            this.nutHuy.Caption = "Hủy";
            this.nutHuy.Id = 4;
            this.nutHuy.ImageOptions.Image = global::thiTracNghiem.Properties.Resources.Undo_icon_24;
            this.nutHuy.Name = "nutHuy";
            this.nutHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nutHuy_ItemClick);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DS;
            // 
            // MonHocTableAdapter
            // 
            this.MonHocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.MonHocTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = thiTracNghiem.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.DataSource = this.bdsMonHoc;
            this.gcMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMonHoc.Location = new System.Drawing.Point(0, 40);
            this.gcMonHoc.MainView = this.gridView1;
            this.gcMonHoc.MenuManager = this.barManager1;
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(1193, 413);
            this.gcMonHoc.TabIndex = 5;
            this.gcMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.GridControl = this.gcMonHoc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã Môn học ";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMAMH.OptionsColumn.AllowMove = false;
            this.colMAMH.OptionsColumn.AllowSize = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên Môn học ";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTENMH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colTENMH.OptionsColumn.AllowMove = false;
            this.colTENMH.OptionsColumn.AllowShowHide = false;
            this.colTENMH.OptionsColumn.AllowSize = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // groupTT
            // 
            this.groupTT.Controls.Add(tENMHLabel);
            this.groupTT.Controls.Add(this.txtTenMH);
            this.groupTT.Controls.Add(mAMHLabel);
            this.groupTT.Controls.Add(this.txtMaMH);
            this.groupTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTT.Location = new System.Drawing.Point(0, 453);
            this.groupTT.Name = "groupTT";
            this.groupTT.Size = new System.Drawing.Size(1193, 220);
            this.groupTT.TabIndex = 6;
            this.groupTT.TabStop = false;
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(578, 107);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(160, 29);
            tENMHLabel.TabIndex = 11;
            tENMHLabel.Text = "Tên Môn học:";
            // 
            // txtTenMH
            // 
            this.txtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "TENMH", true));
            this.txtTenMH.Location = new System.Drawing.Point(744, 104);
            this.txtTenMH.MenuManager = this.barManager1;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.Properties.Appearance.Options.UseFont = true;
            this.txtTenMH.Size = new System.Drawing.Size(317, 32);
            this.txtTenMH.TabIndex = 12;
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(105, 107);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(150, 29);
            mAMHLabel.TabIndex = 9;
            mAMHLabel.Text = "Mã Môn học ";
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonHoc, "MAMH", true));
            this.txtMaMH.Location = new System.Drawing.Point(261, 104);
            this.txtMaMH.MenuManager = this.barManager1;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Properties.Appearance.Options.UseFont = true;
            this.txtMaMH.Size = new System.Drawing.Size(221, 32);
            this.txtMaMH.TabIndex = 10;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gcMonHoc;
            this.searchControl1.Location = new System.Drawing.Point(894, 13);
            this.searchControl1.MenuManager = this.barManager1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gcMonHoc;
            this.searchControl1.Size = new System.Drawing.Size(287, 22);
            this.searchControl1.TabIndex = 7;
            // 
            // bdsBoDe
            // 
            this.bdsBoDe.DataMember = "FK_BODE_MONHOC";
            this.bdsBoDe.DataSource = this.bdsMonHoc;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "FK_GIAOVIEN_DANGKY_MONHOC1";
            this.bdsGVDK.DataSource = this.bdsMonHoc;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bdsBangDiem
            // 
            this.bdsBangDiem.DataMember = "FK_BANGDIEM_MONHOC";
            this.bdsBangDiem.DataSource = this.bdsMonHoc;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // formMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 673);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.groupTT);
            this.Controls.Add(this.gcMonHoc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formMH";
            this.Text = "Môn học ";
            this.Load += new System.EventHandler(this.formMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupTT.ResumeLayout(false);
            this.groupTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem nutThem;
        private DevExpress.XtraBars.BarButtonItem nutXoa;
        private DevExpress.XtraBars.BarButtonItem nutSua;
        private DevExpress.XtraBars.BarButtonItem nutLuu;
        private DevExpress.XtraBars.BarButtonItem nutHuy;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DS DS;
        private DSTableAdapters.MONHOCTableAdapter MonHocTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.GroupBox groupTT;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private DevExpress.XtraEditors.TextEdit txtMaMH;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsBangDiem;
    }
}