namespace WaterBill.Forms
{
    partial class Frm_Archive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Archive));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnprint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnsms = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnnowbill = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnall = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnrefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txsearchbill = new System.Windows.Forms.ToolStripTextBox();
            this.dgvarchive = new System.Windows.Forms.DataGridView();
            this.ReportPrint = new Stimulsoft.Report.StiReport();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtToDate = new Atf.UI.DateTimeSelector();
            this.txtFromDate = new Atf.UI.DateTimeSelector();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charchiv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curencyindore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarchive)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnprint,
            this.toolStripSeparator2,
            this.btnsms,
            this.toolStripSeparator3,
            this.btndelete,
            this.toolStripSeparator5,
            this.btnnowbill,
            this.toolStripSeparator4,
            this.btnall,
            this.toolStripSeparator6,
            this.btnrefresh,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txsearchbill});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1072, 76);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnprint.Image = global::WaterBill.Properties.Resources.Print_icon;
            this.btnprint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(73, 73);
            this.btnprint.Text = "چاپ قبوض";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 76);
            // 
            // btnsms
            // 
            this.btnsms.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsms.Image = global::WaterBill.Properties.Resources.message_already_read_icon1;
            this.btnsms.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnsms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsms.Name = "btnsms";
            this.btnsms.Size = new System.Drawing.Size(84, 73);
            this.btnsms.Text = "ارسال پیامک ";
            this.btnsms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsms.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 76);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndelete.Image = global::WaterBill.Properties.Resources.delete_file_icon;
            this.btndelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(86, 73);
            this.btndelete.Text = "حذف اطلاعات";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 76);
            // 
            // btnnowbill
            // 
            this.btnnowbill.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnowbill.Image = global::WaterBill.Properties.Resources.Calendar_icon;
            this.btnnowbill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnnowbill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnowbill.Name = "btnnowbill";
            this.btnnowbill.Size = new System.Drawing.Size(77, 73);
            this.btnnowbill.Text = "قبوض جدید";
            this.btnnowbill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnnowbill.Click += new System.EventHandler(this.btnnowbill_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 76);
            // 
            // btnall
            // 
            this.btnall.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnall.Image = global::WaterBill.Properties.Resources.Graphic_designer_icon;
            this.btnall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(74, 73);
            this.btnall.Text = "علامت همه";
            this.btnall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 76);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnrefresh.Image = global::WaterBill.Properties.Resources.ModernXP_36_Folder_Refresh_icon;
            this.btnrefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(64, 73);
            this.btnrefresh.Text = "بروزرسانی";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrefresh.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 76);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 73);
            this.toolStripLabel1.Text = " جستجو قبض:";
            // 
            // txsearchbill
            // 
            this.txsearchbill.BackColor = System.Drawing.SystemColors.Window;
            this.txsearchbill.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txsearchbill.Name = "txsearchbill";
            this.txsearchbill.Size = new System.Drawing.Size(90, 76);
            this.txsearchbill.TextChanged += new System.EventHandler(this.txsearchbill_TextChanged);
            // 
            // dgvarchive
            // 
            this.dgvarchive.AllowUserToAddRows = false;
            this.dgvarchive.AllowUserToDeleteRows = false;
            this.dgvarchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.charchiv,
            this.Column1,
            this.SubName,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column11,
            this.Column17,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.i,
            this.curencyindore,
            this.Column5,
            this.Column22,
            this.code,
            this.pay2,
            this.pay3,
            this.Column23});
            this.dgvarchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvarchive.Location = new System.Drawing.Point(0, 76);
            this.dgvarchive.Name = "dgvarchive";
            this.dgvarchive.ReadOnly = true;
            this.dgvarchive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvarchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvarchive.Size = new System.Drawing.Size(1072, 366);
            this.dgvarchive.TabIndex = 1;
            this.dgvarchive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvarchive_CellContentClick);
            // 
            // ReportPrint
            // 
            this.ReportPrint.CookieContainer = null;
            this.ReportPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.ReportPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.ReportPrint.ReportAlias = "Report";
            this.ReportPrint.ReportGuid = "a056dc1a0dea4240888e12c6e0b08a78";
            this.ReportPrint.ReportName = "Report";
            this.ReportPrint.ReportSource = null;
            this.ReportPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ReportPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.ReportPrint.UseProgressInThread = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر";
            // 
            // txtToDate
            // 
            this.txtToDate.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtToDate.Location = new System.Drawing.Point(68, 21);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtToDate.Size = new System.Drawing.Size(98, 30);
            this.txtToDate.TabIndex = 55;
            this.txtToDate.UsePersianFormat = true;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFromDate.Location = new System.Drawing.Point(223, 21);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFromDate.Size = new System.Drawing.Size(98, 30);
            this.txtFromDate.TabIndex = 54;
            this.txtFromDate.UsePersianFormat = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFilter.Location = new System.Drawing.Point(1, 21);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(63, 28);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "انجام";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(165, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "تا تاریخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(320, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "از تاریخ :";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // charchiv
            // 
            this.charchiv.FillWeight = 45.95336F;
            this.charchiv.HeaderText = "انتخاب";
            this.charchiv.Name = "charchiv";
            this.charchiv.ReadOnly = true;
            this.charchiv.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codemeli";
            this.Column1.FillWeight = 103.3807F;
            this.Column1.HeaderText = "کدملی";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 112;
            // 
            // SubName
            // 
            this.SubName.DataPropertyName = "SubName";
            this.SubName.FillWeight = 93.45074F;
            this.SubName.HeaderText = "نام مشترک";
            this.SubName.Name = "SubName";
            this.SubName.ReadOnly = true;
            this.SubName.Width = 102;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PelakNumber";
            this.Column3.FillWeight = 45.82306F;
            this.Column3.HeaderText = "شماره پرونده";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateShamsi";
            dataGridViewCellStyle1.Format = "yyyy/MM/dd";
            dataGridViewCellStyle1.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.FillWeight = 90F;
            this.Column4.HeaderText = "تاریخ صدور";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 95;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "AmountLevel";
            this.Column8.FillWeight = 45.33187F;
            this.Column8.HeaderText = "مصرف";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 49;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "CurencyinDore";
            dataGridViewCellStyle2.NullValue = null;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column11.HeaderText = "آب بها";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 90;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "LeterCurency";
            this.Column17.FillWeight = 360F;
            this.Column17.HeaderText = "قابل پرداخت";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 455;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DatePast";
            dataGridViewCellStyle3.Format = "yyyy/MM/dd";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Debt";
            dataGridViewCellStyle4.Format = "n0";
            dataGridViewCellStyle4.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Ghotre";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "HesabNumber";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Penalty";
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "PublicWork";
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Maliat";
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "DeadlineCurency";
            dataGridViewCellStyle5.Format = "yyyy/MM/dd";
            this.Column14.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column14.HeaderText = "Column14";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "PhoneNumber";
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "NumberCurency";
            this.Column16.HeaderText = "Column16";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Visible = false;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "MeterPast";
            this.Column18.HeaderText = "Column18";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "MeterNow";
            this.Column19.HeaderText = "Column19";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Visible = false;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "DateNow";
            this.Column20.HeaderText = "Column20";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Visible = false;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "Bestan";
            dataGridViewCellStyle6.Format = "n0";
            dataGridViewCellStyle6.NullValue = null;
            this.Column21.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column21.HeaderText = "Column21";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Visible = false;
            // 
            // i
            // 
            this.i.DataPropertyName = "ID";
            this.i.HeaderText = "Column22";
            this.i.Name = "i";
            this.i.ReadOnly = true;
            this.i.Visible = false;
            // 
            // curencyindore
            // 
            this.curencyindore.DataPropertyName = "CurencyinDore";
            this.curencyindore.HeaderText = "Column5";
            this.curencyindore.Name = "curencyindore";
            this.curencyindore.ReadOnly = true;
            this.curencyindore.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FatherName";
            this.Column5.HeaderText = "fathername";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "Shenasname";
            this.Column22.HeaderText = "shenasname";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Visible = false;
            // 
            // code
            // 
            this.code.DataPropertyName = "SubaScribId";
            this.code.HeaderText = "code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Visible = false;
            // 
            // pay2
            // 
            this.pay2.DataPropertyName = "pay2";
            this.pay2.HeaderText = "Column23";
            this.pay2.Name = "pay2";
            this.pay2.ReadOnly = true;
            this.pay2.Visible = false;
            // 
            // pay3
            // 
            this.pay3.DataPropertyName = "pay3";
            this.pay3.HeaderText = "Column23";
            this.pay3.Name = "pay3";
            this.pay3.ReadOnly = true;
            this.pay3.Visible = false;
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "Curency";
            this.Column23.HeaderText = "Column23";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Frm_Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvarchive);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_Archive";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "بایگانی";
            this.Load += new System.EventHandler(this.Frm_Archive_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarchive)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ToolStripButton btnprint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnsms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnrefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridView dgvarchive;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txsearchbill;
        private Stimulsoft.Report.StiReport ReportPrint;
        private System.Windows.Forms.ToolStripButton btnall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btnnowbill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Atf.UI.DateTimeSelector txtToDate;
        private Atf.UI.DateTimeSelector txtFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn charchiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn curencyindore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
    }
}