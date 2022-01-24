namespace WaterBill
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbday = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbdater = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbtime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbtimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btncalculate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnoptionsbill = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnoptionslogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnaboutme = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btncall = new System.Windows.Forms.ToolStripButton();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.btnbill = new System.Windows.Forms.Label();
            this.btnbackupe = new System.Windows.Forms.Label();
            this.btnrestore = new System.Windows.Forms.Label();
            this.btncompany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picachive = new System.Windows.Forms.PictureBox();
            this.picachiv = new System.Windows.Forms.PictureBox();
            this.picback1 = new System.Windows.Forms.PictureBox();
            this.picbill1 = new System.Windows.Forms.PictureBox();
            this.piccompany1 = new System.Windows.Forms.PictureBox();
            this.picbackup = new System.Windows.Forms.PictureBox();
            this.piccompany = new System.Windows.Forms.PictureBox();
            this.picbill = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picachive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picachiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picback1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbill1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccompany1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbill)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbday,
            this.lbdate,
            this.lbdater,
            this.lbtime,
            this.lbtimer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.statusStrip1.Size = new System.Drawing.Size(533, 38);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("IRANSans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 33);
            this.toolStripStatusLabel1.Text = "امروز:";
            // 
            // lbday
            // 
            this.lbday.Font = new System.Drawing.Font("IRANSans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbday.Name = "lbday";
            this.lbday.Size = new System.Drawing.Size(0, 33);
            // 
            // lbdate
            // 
            this.lbdate.Font = new System.Drawing.Font("IRANSans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(66, 33);
            this.lbdate.Text = "تاریخ:";
            // 
            // lbdater
            // 
            this.lbdater.Font = new System.Drawing.Font("B Roya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbdater.Name = "lbdater";
            this.lbdater.Size = new System.Drawing.Size(0, 33);
            // 
            // lbtime
            // 
            this.lbtime.Font = new System.Drawing.Font("IRANSans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(72, 33);
            this.lbtime.Text = "ساعت:";
            // 
            // lbtimer
            // 
            this.lbtimer.Font = new System.Drawing.Font("B Roya", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbtimer.Name = "lbtimer";
            this.lbtimer.Size = new System.Drawing.Size(0, 33);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncalculate,
            this.toolStripSeparator4,
            this.btnoptionsbill,
            this.toolStripSeparator1,
            this.btnoptionslogin,
            this.toolStripSeparator2,
            this.btnaboutme,
            this.toolStripSeparator3,
            this.btncall});
            this.toolStrip1.Location = new System.Drawing.Point(444, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(89, 434);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("IRANSans Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Image = global::WaterBill.Properties.Resources.Calculator_icon;
            this.btncalculate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btncalculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(86, 71);
            this.btncalculate.Text = "حسابداری";
            this.btncalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(86, 6);
            // 
            // btnoptionsbill
            // 
            this.btnoptionsbill.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnoptionsbill.Image = global::WaterBill.Properties.Resources.Ekisho_Deep_Ocean_Developer_icon;
            this.btnoptionsbill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnoptionsbill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnoptionsbill.Name = "btnoptionsbill";
            this.btnoptionsbill.Size = new System.Drawing.Size(86, 73);
            this.btnoptionsbill.Text = "تنظیمات قبض";
            this.btnoptionsbill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnoptionsbill.Click += new System.EventHandler(this.btnoptionsbill_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(86, 6);
            // 
            // btnoptionslogin
            // 
            this.btnoptionslogin.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnoptionslogin.Image = global::WaterBill.Properties.Resources.user_login_icon;
            this.btnoptionslogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnoptionslogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnoptionslogin.Name = "btnoptionslogin";
            this.btnoptionslogin.Size = new System.Drawing.Size(86, 73);
            this.btnoptionslogin.Text = "تنظیمات ورود";
            this.btnoptionslogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnoptionslogin.Click += new System.EventHandler(this.btnoptionslogin_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(86, 6);
            // 
            // btnaboutme
            // 
            this.btnaboutme.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnaboutme.Image = global::WaterBill.Properties.Resources.SMS_Message_icon;
            this.btnaboutme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnaboutme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaboutme.Name = "btnaboutme";
            this.btnaboutme.Size = new System.Drawing.Size(86, 73);
            this.btnaboutme.Text = "پنل پیامک";
            this.btnaboutme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnaboutme.Click += new System.EventHandler(this.btnaboutme_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(86, 6);
            // 
            // btncall
            // 
            this.btncall.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btncall.Image = global::WaterBill.Properties.Resources.phone_icon;
            this.btncall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btncall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncall.Name = "btncall";
            this.btncall.Size = new System.Drawing.Size(86, 73);
            this.btncall.Text = "تماس با ما";
            this.btncall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncall.Click += new System.EventHandler(this.btncall_Click);
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 472D;
            this.reSize1.InitialHostContainerWidth = 533D;
            this.reSize1.Tag = null;
            // 
            // btnbill
            // 
            this.btnbill.BackColor = System.Drawing.Color.SkyBlue;
            this.btnbill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnbill.Location = new System.Drawing.Point(258, 93);
            this.btnbill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(94, 25);
            this.btnbill.TabIndex = 17;
            this.btnbill.Text = "مدیریت قبوض";
            this.btnbill.Click += new System.EventHandler(this.btnbill_Click_2);
            // 
            // btnbackupe
            // 
            this.btnbackupe.BackColor = System.Drawing.Color.SkyBlue;
            this.btnbackupe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnbackupe.Location = new System.Drawing.Point(257, 269);
            this.btnbackupe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnbackupe.Name = "btnbackupe";
            this.btnbackupe.Size = new System.Drawing.Size(94, 25);
            this.btnbackupe.TabIndex = 18;
            this.btnbackupe.Text = "پشتیبان گیری";
            this.btnbackupe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbackupe.Click += new System.EventHandler(this.btnbackupe_Click);
            // 
            // btnrestore
            // 
            this.btnrestore.BackColor = System.Drawing.Color.SkyBlue;
            this.btnrestore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnrestore.Location = new System.Drawing.Point(257, 298);
            this.btnrestore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(94, 25);
            this.btnrestore.TabIndex = 19;
            this.btnrestore.Text = "بازیابی بانک";
            this.btnrestore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrestore.Click += new System.EventHandler(this.btnrestore_Click);
            // 
            // btncompany
            // 
            this.btncompany.BackColor = System.Drawing.Color.SkyBlue;
            this.btncompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btncompany.Location = new System.Drawing.Point(77, 93);
            this.btncompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btncompany.Name = "btncompany";
            this.btncompany.Size = new System.Drawing.Size(119, 25);
            this.btncompany.TabIndex = 20;
            this.btncompany.Text = "مدیریت مشترکین";
            this.btncompany.Click += new System.EventHandler(this.btncompany_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(77, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "بایگانی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picachive
            // 
            this.picachive.BackColor = System.Drawing.Color.SkyBlue;
            this.picachive.Image = global::WaterBill.Properties.Resources.folder_icon;
            this.picachive.Location = new System.Drawing.Point(109, 198);
            this.picachive.Margin = new System.Windows.Forms.Padding(2);
            this.picachive.Name = "picachive";
            this.picachive.Size = new System.Drawing.Size(70, 78);
            this.picachive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picachive.TabIndex = 21;
            this.picachive.TabStop = false;
            this.picachive.Click += new System.EventHandler(this.picachive_Click);
            // 
            // picachiv
            // 
            this.picachiv.BackColor = System.Drawing.Color.SkyBlue;
            this.picachiv.Location = new System.Drawing.Point(54, 181);
            this.picachiv.Margin = new System.Windows.Forms.Padding(2);
            this.picachiv.Name = "picachiv";
            this.picachiv.Size = new System.Drawing.Size(162, 161);
            this.picachiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picachiv.TabIndex = 13;
            this.picachiv.TabStop = false;
            this.picachiv.Click += new System.EventHandler(this.picachiv_Click);
            this.picachiv.MouseLeave += new System.EventHandler(this.picachiv_MouseLeave);
            this.picachiv.MouseHover += new System.EventHandler(this.picachiv_MouseHover);
            // 
            // picback1
            // 
            this.picback1.BackColor = System.Drawing.Color.SkyBlue;
            this.picback1.Image = global::WaterBill.Properties.Resources.database_icon;
            this.picback1.Location = new System.Drawing.Point(272, 198);
            this.picback1.Margin = new System.Windows.Forms.Padding(2);
            this.picback1.Name = "picback1";
            this.picback1.Size = new System.Drawing.Size(70, 69);
            this.picback1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picback1.TabIndex = 9;
            this.picback1.TabStop = false;
            // 
            // picbill1
            // 
            this.picbill1.BackColor = System.Drawing.Color.SkyBlue;
            this.picbill1.Image = global::WaterBill.Properties.Resources.clipart1003811;
            this.picbill1.Location = new System.Drawing.Point(272, 21);
            this.picbill1.Margin = new System.Windows.Forms.Padding(2);
            this.picbill1.Name = "picbill1";
            this.picbill1.Size = new System.Drawing.Size(70, 69);
            this.picbill1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbill1.TabIndex = 7;
            this.picbill1.TabStop = false;
            this.picbill1.Click += new System.EventHandler(this.picbill1_Click);
            // 
            // piccompany1
            // 
            this.piccompany1.BackColor = System.Drawing.Color.SkyBlue;
            this.piccompany1.Image = global::WaterBill.Properties.Resources.Group_icon;
            this.piccompany1.Location = new System.Drawing.Point(109, 21);
            this.piccompany1.Margin = new System.Windows.Forms.Padding(2);
            this.piccompany1.Name = "piccompany1";
            this.piccompany1.Size = new System.Drawing.Size(70, 70);
            this.piccompany1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccompany1.TabIndex = 5;
            this.piccompany1.TabStop = false;
            this.piccompany1.Click += new System.EventHandler(this.piccompany1_Click);
            // 
            // picbackup
            // 
            this.picbackup.BackColor = System.Drawing.Color.SkyBlue;
            this.picbackup.Location = new System.Drawing.Point(233, 181);
            this.picbackup.Margin = new System.Windows.Forms.Padding(2);
            this.picbackup.Name = "picbackup";
            this.picbackup.Size = new System.Drawing.Size(162, 161);
            this.picbackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbackup.TabIndex = 4;
            this.picbackup.TabStop = false;
            this.picbackup.MouseLeave += new System.EventHandler(this.picbackup_MouseLeave);
            this.picbackup.MouseHover += new System.EventHandler(this.picbackup_MouseHover);
            // 
            // piccompany
            // 
            this.piccompany.BackColor = System.Drawing.Color.SkyBlue;
            this.piccompany.Location = new System.Drawing.Point(54, 4);
            this.piccompany.Margin = new System.Windows.Forms.Padding(2);
            this.piccompany.Name = "piccompany";
            this.piccompany.Size = new System.Drawing.Size(162, 161);
            this.piccompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccompany.TabIndex = 2;
            this.piccompany.TabStop = false;
            this.piccompany.Click += new System.EventHandler(this.piccompany_Click);
            this.piccompany.MouseLeave += new System.EventHandler(this.piccompany_MouseLeave);
            this.piccompany.MouseHover += new System.EventHandler(this.piccompany_MouseHover);
            // 
            // picbill
            // 
            this.picbill.BackColor = System.Drawing.Color.SkyBlue;
            this.picbill.Location = new System.Drawing.Point(233, 4);
            this.picbill.Margin = new System.Windows.Forms.Padding(2);
            this.picbill.Name = "picbill";
            this.picbill.Size = new System.Drawing.Size(162, 161);
            this.picbill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbill.TabIndex = 1;
            this.picbill.TabStop = false;
            this.picbill.Click += new System.EventHandler(this.picbill_Click);
            this.picbill.MouseLeave += new System.EventHandler(this.picbill_MouseLeave);
            this.picbill.MouseHover += new System.EventHandler(this.picbill_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(533, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picachive);
            this.Controls.Add(this.btncompany);
            this.Controls.Add(this.btnrestore);
            this.Controls.Add(this.btnbackupe);
            this.Controls.Add(this.btnbill);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picachiv);
            this.Controls.Add(this.picback1);
            this.Controls.Add(this.picbill1);
            this.Controls.Add(this.piccompany1);
            this.Controls.Add(this.picbackup);
            this.Controls.Add(this.piccompany);
            this.Controls.Add(this.picbill);
            this.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار مدیریت قبوض مزرعه مبارکه بالا";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picachive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picachiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picback1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbill1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccompany1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picbill;
        private System.Windows.Forms.PictureBox piccompany;
        private System.Windows.Forms.PictureBox picbackup;
        private System.Windows.Forms.PictureBox piccompany1;
        private System.Windows.Forms.PictureBox picbill1;
        private System.Windows.Forms.PictureBox picback1;
        private System.Windows.Forms.PictureBox picachiv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbday;
        private System.Windows.Forms.ToolStripStatusLabel lbdate;
        private System.Windows.Forms.ToolStripStatusLabel lbtime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lbtimer;
        private System.Windows.Forms.ToolStripStatusLabel lbdater;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnoptionsbill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnoptionslogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Label btnbill;
        private System.Windows.Forms.Label btnbackupe;
        private System.Windows.Forms.Label btnrestore;
        private System.Windows.Forms.Label btncompany;
        private System.Windows.Forms.PictureBox picachive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnaboutme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btncall;
        private System.Windows.Forms.ToolStripButton btncalculate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

