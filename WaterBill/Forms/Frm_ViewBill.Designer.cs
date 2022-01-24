namespace WaterBill.Forms
{
    partial class Frm_ViewBill
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
            this.dgvcompanyes = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnsubmit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnupdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnlist = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnprint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txsearchcompany = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txghotre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txhesab = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txpublicservice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txmaliat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txnerkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txabunman = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmohasebe = new System.Windows.Forms.Button();
            this.txsumpardakhti = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbestankar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbedehighabli = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txviewhesab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompanyes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcompanyes
            // 
            this.dgvcompanyes.AllowUserToAddRows = false;
            this.dgvcompanyes.AllowUserToDeleteRows = false;
            this.dgvcompanyes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcompanyes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompanyes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.cul});
            this.dgvcompanyes.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvcompanyes.Location = new System.Drawing.Point(0, 0);
            this.dgvcompanyes.Name = "dgvcompanyes";
            this.dgvcompanyes.ReadOnly = true;
            this.dgvcompanyes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvcompanyes.Size = new System.Drawing.Size(248, 357);
            this.dgvcompanyes.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CompanyName";
            this.Column2.FillWeight = 90F;
            this.Column2.HeaderText = "نام شرکت";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cul
            // 
            this.cul.DataPropertyName = "SubscribId";
            this.cul.HeaderText = "شماره اشتراک";
            this.cul.Name = "cul";
            this.cul.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnsubmit,
            this.toolStripSeparator1,
            this.btnupdate,
            this.toolStripSeparator2,
            this.btndelete,
            this.toolStripSeparator3,
            this.btnlist,
            this.toolStripSeparator4,
            this.btnprint,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.txsearchcompany,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(248, 276);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(580, 81);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("B Mehr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsubmit.Image = global::WaterBill.Properties.Resources.folder_check_icon;
            this.btnsubmit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnsubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(52, 78);
            this.btnsubmit.Text = "ثبت";
            this.btnsubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 81);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("B Mehr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnupdate.Image = global::WaterBill.Properties.Resources.Edit_icon;
            this.btnupdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnupdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(55, 78);
            this.btnupdate.Text = "ویرایش";
            this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 81);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("B Mehr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndelete.Image = global::WaterBill.Properties.Resources.symbol_delete_icon;
            this.btndelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(52, 78);
            this.btndelete.Text = "حذف";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 81);
            // 
            // btnlist
            // 
            this.btnlist.Font = new System.Drawing.Font("B Mehr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnlist.Image = global::WaterBill.Properties.Resources.checklist_icon;
            this.btnlist.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnlist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(52, 78);
            this.btnlist.Text = "لیست";
            this.btnlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 81);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("B Mehr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnprint.Image = global::WaterBill.Properties.Resources.Places_folder_print_icon;
            this.btnprint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(52, 78);
            this.btnprint.Text = "چاپ";
            this.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 81);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("B Mehr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(126, 78);
            this.toolStripLabel1.Text = "جستجو مشترک/شرکت:";
            // 
            // txsearchcompany
            // 
            this.txsearchcompany.Name = "txsearchcompany";
            this.txsearchcompany.Size = new System.Drawing.Size(100, 81);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 81);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.txghotre);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txhesab);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txpublicservice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txmaliat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txnerkh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txabunman);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(248, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 71);
            this.panel1.TabIndex = 2;
            // 
            // txghotre
            // 
            this.txghotre.Location = new System.Drawing.Point(6, 34);
            this.txghotre.Name = "txghotre";
            this.txghotre.Size = new System.Drawing.Size(89, 33);
            this.txghotre.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "قطر انشعاب";
            // 
            // txhesab
            // 
            this.txhesab.Location = new System.Drawing.Point(108, 35);
            this.txhesab.Name = "txhesab";
            this.txhesab.Size = new System.Drawing.Size(89, 33);
            this.txhesab.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "شماره حساب";
            // 
            // txpublicservice
            // 
            this.txpublicservice.Location = new System.Drawing.Point(203, 34);
            this.txpublicservice.Name = "txpublicservice";
            this.txpublicservice.Size = new System.Drawing.Size(89, 33);
            this.txpublicservice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "خدمات عمومی";
            // 
            // txmaliat
            // 
            this.txmaliat.Location = new System.Drawing.Point(298, 34);
            this.txmaliat.Name = "txmaliat";
            this.txmaliat.Size = new System.Drawing.Size(89, 33);
            this.txmaliat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "مالیات";
            // 
            // txnerkh
            // 
            this.txnerkh.Location = new System.Drawing.Point(393, 34);
            this.txnerkh.Name = "txnerkh";
            this.txnerkh.Size = new System.Drawing.Size(89, 33);
            this.txnerkh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "نرخ مصرف";
            // 
            // txabunman
            // 
            this.txabunman.Location = new System.Drawing.Point(488, 34);
            this.txabunman.Name = "txabunman";
            this.txabunman.Size = new System.Drawing.Size(89, 33);
            this.txabunman.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ابونمان";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.btnmohasebe);
            this.groupBox1.Controls.Add(this.txsumpardakhti);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txbestankar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txbedehighabli);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txviewhesab);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(248, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(580, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "محاسبات";
            // 
            // btnmohasebe
            // 
            this.btnmohasebe.Location = new System.Drawing.Point(20, 68);
            this.btnmohasebe.Name = "btnmohasebe";
            this.btnmohasebe.Size = new System.Drawing.Size(75, 29);
            this.btnmohasebe.TabIndex = 10;
            this.btnmohasebe.Text = "محاسبه";
            this.btnmohasebe.UseVisualStyleBackColor = true;
            // 
            // txsumpardakhti
            // 
            this.txsumpardakhti.Location = new System.Drawing.Point(113, 68);
            this.txsumpardakhti.Name = "txsumpardakhti";
            this.txsumpardakhti.Size = new System.Drawing.Size(118, 33);
            this.txsumpardakhti.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "قابل پرداخت";
            // 
            // txbestankar
            // 
            this.txbestankar.Location = new System.Drawing.Point(113, 20);
            this.txbestankar.Name = "txbestankar";
            this.txbestankar.Size = new System.Drawing.Size(118, 33);
            this.txbestankar.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "بستانکاری";
            // 
            // txbedehighabli
            // 
            this.txbedehighabli.Location = new System.Drawing.Point(320, 71);
            this.txbedehighabli.Name = "txbedehighabli";
            this.txbedehighabli.Size = new System.Drawing.Size(118, 33);
            this.txbedehighabli.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "صورت حساب این دوره";
            // 
            // txviewhesab
            // 
            this.txviewhesab.Location = new System.Drawing.Point(320, 20);
            this.txviewhesab.Name = "txviewhesab";
            this.txviewhesab.Size = new System.Drawing.Size(118, 33);
            this.txviewhesab.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "بدهی قبلی";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 357D;
            this.reSize1.InitialHostContainerWidth = 828D;
            this.reSize1.Tag = null;
            // 
            // Frm_ViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvcompanyes);
            this.Font = new System.Drawing.Font("B Mehr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "Frm_ViewBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Frm_ViewBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompanyes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcompanyes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnsubmit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnupdate;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnlist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnprint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txsearchcompany;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txghotre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txhesab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txpublicservice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txmaliat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txnerkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txabunman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmohasebe;
        private System.Windows.Forms.TextBox txsumpardakhti;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbestankar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbedehighabli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txviewhesab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cul;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}