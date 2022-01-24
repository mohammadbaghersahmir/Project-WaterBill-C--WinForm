namespace WaterBill.Forms
{
    partial class Frm_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bill));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnselectall = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnedit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnrefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txsearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnchekall = new System.Windows.Forms.ToolStripButton();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chselect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NameCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator5 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnselectall,
            this.toolStripSeparator3,
            this.btnedit,
            this.toolStripSeparator4,
            this.btnrefresh,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.txsearch,
            this.toolStripSeparator1,
            this.btnchekall});
            this.toolStrip1.Location = new System.Drawing.Point(395, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(117, 470);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextChanged += new System.EventHandler(this.toolStrip1_TextChanged);
            // 
            // btnselectall
            // 
            this.btnselectall.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnselectall.Image = global::WaterBill.Properties.Resources.Graphic_designer_icon;
            this.btnselectall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnselectall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnselectall.Name = "btnselectall";
            this.btnselectall.Size = new System.Drawing.Size(114, 73);
            this.btnselectall.Text = "صدور قبض";
            this.btnselectall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnselectall.Click += new System.EventHandler(this.btnsms_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(114, 6);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedit.Image = global::WaterBill.Properties.Resources.document_edit_icon;
            this.btnedit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(114, 73);
            this.btnedit.Text = "ویرایش اطلاعات";
            this.btnedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(114, 6);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnrefresh.Image = global::WaterBill.Properties.Resources.arrow_refresh_4_icon;
            this.btnrefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(114, 73);
            this.btnrefresh.Text = "بروزرسانی اطلاعات";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(114, 6);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 21);
            this.toolStripLabel1.Text = "جستجو:";
            // 
            // txsearch
            // 
            this.txsearch.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txsearch.Name = "txsearch";
            this.txsearch.Size = new System.Drawing.Size(112, 28);
            this.txsearch.TextChanged += new System.EventHandler(this.txsearch_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // btnchekall
            // 
            this.btnchekall.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnchekall.Image = global::WaterBill.Properties.Resources.user_check_icon;
            this.btnchekall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnchekall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnchekall.Name = "btnchekall";
            this.btnchekall.Size = new System.Drawing.Size(114, 73);
            this.btnchekall.Text = "علامت دارکردن همه";
            this.btnchekall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnchekall.Click += new System.EventHandler(this.btnchekall_Click);
            // 
            // dgvbill
            // 
            this.dgvbill.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvbill.AllowUserToAddRows = false;
            this.dgvbill.AllowUserToDeleteRows = false;
            this.dgvbill.AllowUserToResizeColumns = false;
            this.dgvbill.AllowUserToResizeRows = false;
            this.dgvbill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbill.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvbill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvbill.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyId,
            this.chselect,
            this.NameCompany,
            this.Column2,
            this.Column3});
            this.dgvbill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvbill.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvbill.Location = new System.Drawing.Point(0, 0);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.ReadOnly = true;
            this.dgvbill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbill.Size = new System.Drawing.Size(393, 470);
            this.dgvbill.TabIndex = 14;
            this.dgvbill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellContentClick);
            this.dgvbill.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellEndEdit);
            this.dgvbill.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvbill_CellPainting);
            this.dgvbill.Click += new System.EventHandler(this.dgvbill_Click);
            // 
            // CompanyId
            // 
            this.CompanyId.DataPropertyName = "BillId";
            this.CompanyId.FillWeight = 1F;
            this.CompanyId.HeaderText = "Column4";
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.ReadOnly = true;
            this.CompanyId.Visible = false;
            // 
            // chselect
            // 
            this.chselect.FillWeight = 33.69791F;
            this.chselect.HeaderText = "انتخاب ";
            this.chselect.Name = "chselect";
            this.chselect.ReadOnly = true;
            this.chselect.TrueValue = "";
            // 
            // NameCompany
            // 
            this.NameCompany.DataPropertyName = "NameCompany";
            this.NameCompany.FillWeight = 50.54688F;
            this.NameCompany.HeaderText = "نام مشترک";
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MeterNumberNow";
            this.Column2.FillWeight = 68.63598F;
            this.Column2.HeaderText = "شماره کنتورقبلی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SeenDateShamsi";
            this.Column3.FillWeight = 60F;
            this.Column3.HeaderText = "تاریخ بازدید";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 470D;
            this.reSize1.InitialHostContainerWidth = 512D;
            this.reSize1.Tag = null;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = null;
            this.requiredFieldValidator2.ErrorMessage = "نامعتبر";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = null;
            this.requiredFieldValidator3.ErrorMessage = "نامعتبر";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = null;
            this.requiredFieldValidator4.ErrorMessage = "نامعتبر";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator5.ControlToValidate = null;
            this.requiredFieldValidator5.ErrorMessage = "نامعتبر";
            this.requiredFieldValidator5.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator5.Icon")));
            // 
            // Frm_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 470);
            this.Controls.Add(this.dgvbill);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_Bill";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "قبض";
            this.Load += new System.EventHandler(this.Frm_Bill_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnselectall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.ToolStripButton btnrefresh;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txsearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnchekall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chselect;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripButton btnedit;
    }
}