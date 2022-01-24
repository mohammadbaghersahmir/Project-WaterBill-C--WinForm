namespace WaterBill.Forms
{
    partial class Frm_sms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_sms));
            this.dgvsms = new System.Windows.Forms.DataGridView();
            this.dgvdatesms = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfilter = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFromDate = new Atf.UI.DateTimeSelector();
            this.txtToDate = new Atf.UI.DateTimeSelector();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatesms)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsms
            // 
            this.dgvsms.AllowUserToAddRows = false;
            this.dgvsms.AllowUserToDeleteRows = false;
            this.dgvsms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvsms.Location = new System.Drawing.Point(0, 1);
            this.dgvsms.Name = "dgvsms";
            this.dgvsms.ReadOnly = true;
            this.dgvsms.Size = new System.Drawing.Size(443, 136);
            this.dgvsms.TabIndex = 0;
            // 
            // dgvdatesms
            // 
            this.dgvdatesms.AllowUserToAddRows = false;
            this.dgvdatesms.AllowUserToDeleteRows = false;
            this.dgvdatesms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatesms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.dgvdatesms.Location = new System.Drawing.Point(0, 14);
            this.dgvdatesms.Name = "dgvdatesms";
            this.dgvdatesms.ReadOnly = true;
            this.dgvdatesms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatesms.Size = new System.Drawing.Size(323, 150);
            this.dgvdatesms.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnfilter);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbcustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dgvdatesms);
            this.groupBox1.Location = new System.Drawing.Point(0, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تاریخچه پیامک ها";
            // 
            // btnfilter
            // 
            this.btnfilter.Location = new System.Drawing.Point(34, 187);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(75, 30);
            this.btnfilter.TabIndex = 64;
            this.btnfilter.Text = "فیلترکردن";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 22);
            this.label12.TabIndex = 63;
            this.label12.Text = "تا";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFromDate.Location = new System.Drawing.Point(291, 187);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFromDate.Size = new System.Drawing.Size(98, 30);
            this.txtFromDate.TabIndex = 62;
            this.txtFromDate.UsePersianFormat = true;
            // 
            // txtToDate
            // 
            this.txtToDate.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtToDate.Location = new System.Drawing.Point(159, 187);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtToDate.Size = new System.Drawing.Size(98, 30);
            this.txtToDate.TabIndex = 57;
            this.txtToDate.UsePersianFormat = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "ازتاریخ:";
            // 
            // cbcustomer
            // 
            this.cbcustomer.FormattingEnabled = true;
            this.cbcustomer.Location = new System.Drawing.Point(329, 109);
            this.cbcustomer.Name = "cbcustomer";
            this.cbcustomer.Size = new System.Drawing.Size(108, 30);
            this.cbcustomer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "انتخاب مشترک";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WaterBill.Properties.Resources.Folder_URL_History_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(364, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsend.Image = global::WaterBill.Properties.Resources.email_send_icon;
            this.btnsend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsend.Location = new System.Drawing.Point(174, 143);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(83, 26);
            this.btnsend.TabIndex = 1;
            this.btnsend.Text = "ارسال";
            this.btnsend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NameCustomer";
            this.Column5.HeaderText = "نام مشترک";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DateSms";
            this.Column6.HeaderText = "تاریخ ارسال پیامک";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "نام مشترک";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Format = "yyyy/MM/dd";
            dataGridViewCellStyle1.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "تاریخ ثبت";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "مبلغ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "شماره همراه";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Frm_sms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.dgvsms);
            this.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_sms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم ارسال پیامک";
            this.Load += new System.EventHandler(this.Frm_sms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatesms)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsms;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.DataGridView dgvdatesms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbcustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Atf.UI.DateTimeSelector txtToDate;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.Label label12;
        private Atf.UI.DateTimeSelector txtFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}