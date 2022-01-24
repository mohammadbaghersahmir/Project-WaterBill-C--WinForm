namespace WaterBill.Forms
{
    partial class Frm_InformationExel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InformationExel));
            this.dgvexel = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnexelinpute = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnsubmitexel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexel)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvexel
            // 
            this.dgvexel.AllowUserToAddRows = false;
            this.dgvexel.AllowUserToDeleteRows = false;
            this.dgvexel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvexel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvexel.Location = new System.Drawing.Point(0, 0);
            this.dgvexel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvexel.Name = "dgvexel";
            this.dgvexel.ReadOnly = true;
            this.dgvexel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvexel.Size = new System.Drawing.Size(365, 300);
            this.dgvexel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnexelinpute,
            this.toolStripSeparator1,
            this.btnsubmitexel,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 300);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(365, 81);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnexelinpute
            // 
            this.btnexelinpute.Font = new System.Drawing.Font("B Mehr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnexelinpute.Image = global::WaterBill.Properties.Resources.exel_icon;
            this.btnexelinpute.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnexelinpute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnexelinpute.Name = "btnexelinpute";
            this.btnexelinpute.Size = new System.Drawing.Size(70, 78);
            this.btnexelinpute.Text = "فایل اکسل";
            this.btnexelinpute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnexelinpute.Click += new System.EventHandler(this.btnexelinpute_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 81);
            // 
            // btnsubmitexel
            // 
            this.btnsubmitexel.Font = new System.Drawing.Font("B Mehr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsubmitexel.Image = global::WaterBill.Properties.Resources.Actions_insert_table_icon;
            this.btnsubmitexel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnsubmitexel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsubmitexel.Name = "btnsubmitexel";
            this.btnsubmitexel.Size = new System.Drawing.Size(70, 78);
            this.btnsubmitexel.Text = "اضافه کردن";
            this.btnsubmitexel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsubmitexel.Click += new System.EventHandler(this.btnsubmitexel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 81);
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 379D;
            this.reSize1.InitialHostContainerWidth = 365D;
            this.reSize1.Tag = null;
            // 
            // Frm_InformationExel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 379);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvexel);
            this.Font = new System.Drawing.Font("B Mehr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_InformationExel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Frm_InformationExel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexel)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvexel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnexelinpute;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnsubmitexel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}