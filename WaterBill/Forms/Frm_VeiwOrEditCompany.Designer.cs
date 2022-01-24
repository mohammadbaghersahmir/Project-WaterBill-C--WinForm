namespace WaterBill.Forms
{
    partial class Frm_VeiwOrEditCompany
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnaddcompany = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btneditcompany = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btndeletecompany = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnprint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnrefreshcompany = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txsearchcompany = new System.Windows.Forms.ToolStripTextBox();
            this.dgvcompany = new System.Windows.Forms.DataGridView();
            this.charchiv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.ReportPrint = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompany)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnaddcompany,
            this.toolStripSeparator1,
            this.btneditcompany,
            this.toolStripSeparator2,
            this.btndeletecompany,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.btnprint,
            this.toolStripSeparator5,
            this.btnrefreshcompany,
            this.toolStripLabel1,
            this.txsearchcompany});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(673, 76);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnaddcompany
            // 
            this.btnaddcompany.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnaddcompany.Image = global::WaterBill.Properties.Resources.document_add_icon;
            this.btnaddcompany.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnaddcompany.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaddcompany.Name = "btnaddcompany";
            this.btnaddcompany.Size = new System.Drawing.Size(109, 73);
            this.btnaddcompany.Text = "اضافه کردن شرکت";
            this.btnaddcompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnaddcompany.Click += new System.EventHandler(this.btnaddcompany_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 76);
            // 
            // btneditcompany
            // 
            this.btneditcompany.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btneditcompany.Image = global::WaterBill.Properties.Resources.document_pencil_icon;
            this.btneditcompany.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btneditcompany.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneditcompany.Name = "btneditcompany";
            this.btneditcompany.Size = new System.Drawing.Size(99, 73);
            this.btneditcompany.Text = "ویرایش اطلاعات";
            this.btneditcompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btneditcompany.Click += new System.EventHandler(this.btneditcompany_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 76);
            // 
            // btndeletecompany
            // 
            this.btndeletecompany.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndeletecompany.Image = global::WaterBill.Properties.Resources.blue_document_cross_icon;
            this.btndeletecompany.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btndeletecompany.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndeletecompany.Name = "btndeletecompany";
            this.btndeletecompany.Size = new System.Drawing.Size(77, 73);
            this.btndeletecompany.Text = "حذف شرکت";
            this.btndeletecompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndeletecompany.Click += new System.EventHandler(this.btndeletecompany_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 76);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripButton1.Image = global::WaterBill.Properties.Resources.message_already_read_icon1;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 73);
            this.toolStripButton1.Text = "پیامک";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "بروزرسانی";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 76);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnprint.Image = global::WaterBill.Properties.Resources.ModernXP_46_Network_Printer_icon;
            this.btnprint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(52, 73);
            this.btnprint.Text = "چاپ";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnprint.ToolTipText = "بروزرسانی";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 76);
            // 
            // btnrefreshcompany
            // 
            this.btnrefreshcompany.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnrefreshcompany.Image = global::WaterBill.Properties.Resources.arrow_refresh_4_icon;
            this.btnrefreshcompany.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnrefreshcompany.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefreshcompany.Name = "btnrefreshcompany";
            this.btnrefreshcompany.Size = new System.Drawing.Size(64, 73);
            this.btnrefreshcompany.Text = "بروزرسانی";
            this.btnrefreshcompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrefreshcompany.ToolTipText = "بروزرسانی";
            this.btnrefreshcompany.Click += new System.EventHandler(this.btnrefreshcompany_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 73);
            this.toolStripLabel1.Text = "جستجو:";
            // 
            // txsearchcompany
            // 
            this.txsearchcompany.Name = "txsearchcompany";
            this.txsearchcompany.Size = new System.Drawing.Size(123, 23);
            this.txsearchcompany.TextChanged += new System.EventHandler(this.txsearchcompany_TextChanged);
            // 
            // dgvcompany
            // 
            this.dgvcompany.AllowDrop = true;
            this.dgvcompany.AllowUserToAddRows = false;
            this.dgvcompany.AllowUserToDeleteRows = false;
            this.dgvcompany.AllowUserToOrderColumns = true;
            this.dgvcompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.charchiv,
            this.Column5,
            this.Column1,
            this.Column6,
            this.CompanyId,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvcompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcompany.Location = new System.Drawing.Point(0, 76);
            this.dgvcompany.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvcompany.Name = "dgvcompany";
            this.dgvcompany.ReadOnly = true;
            this.dgvcompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvcompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcompany.Size = new System.Drawing.Size(673, 213);
            this.dgvcompany.TabIndex = 1;
            this.dgvcompany.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcompany_CellContentClick);
            this.dgvcompany.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcompany_CellMouseDown);
            this.dgvcompany.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcompany_CellMouseMove);
            this.dgvcompany.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvcompany_DragDrop);
            this.dgvcompany.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvcompany_DragEnter);
            this.dgvcompany.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvcompany_DragOver);
            this.dgvcompany.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvcompany_KeyUp);
            this.dgvcompany.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvcompany_MouseClick);
            this.dgvcompany.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvcompany_MouseDown);
            this.dgvcompany.MouseEnter += new System.EventHandler(this.dgvcompany_MouseEnter);
            this.dgvcompany.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvcompany_MouseMove);
            this.dgvcompany.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvcompany_MouseUp);
            // 
            // charchiv
            // 
            this.charchiv.FillWeight = 15.93155F;
            this.charchiv.HeaderText = "انتخاب";
            this.charchiv.Name = "charchiv";
            this.charchiv.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 18.32092F;
            this.Column5.HeaderText = "ردیف";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CompanyName";
            this.Column1.FillWeight = 44.56016F;
            this.Column1.HeaderText = " شرکت\\مشترک";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Codemeli";
            this.Column6.FillWeight = 37.67997F;
            this.Column6.HeaderText = "کدملی";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // CompanyId
            // 
            this.CompanyId.DataPropertyName = "SubscribId";
            this.CompanyId.FillWeight = 75.23464F;
            this.CompanyId.HeaderText = "شماره اشتراک";
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.ReadOnly = true;
            this.CompanyId.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PhoneNumber";
            this.Column2.FillWeight = 40.84681F;
            this.Column2.HeaderText = "شماره تماس";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PelakId";
            this.Column3.FillWeight = 36.26938F;
            this.Column3.HeaderText = "شماره پرونده";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Addres";
            this.Column4.FillWeight = 44.56016F;
            this.Column4.HeaderText = "ادرس";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 289D;
            this.reSize1.InitialHostContainerWidth = 673D;
            this.reSize1.Tag = null;
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
            // Frm_VeiwOrEditCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 289);
            this.Controls.Add(this.dgvcompany);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_VeiwOrEditCompany";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Frm_VeiwOrEditCompany_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvcompany;
        private System.Windows.Forms.ToolStripButton btnaddcompany;
        private System.Windows.Forms.ToolStripButton btneditcompany;
        private System.Windows.Forms.ToolStripButton btndeletecompany;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnrefreshcompany;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txsearchcompany;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.ToolStripButton btnprint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Stimulsoft.Report.StiReport ReportPrint;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn charchiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}