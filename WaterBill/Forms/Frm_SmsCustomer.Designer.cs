namespace WaterBill.Forms
{
    partial class Frm_SmsCustomer
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
            this.dgvsmscustomer = new System.Windows.Forms.DataGridView();
            this.lbtype1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnsms = new System.Windows.Forms.Button();
            this.lbtype3 = new System.Windows.Forms.Label();
            this.lbtype2 = new System.Windows.Forms.Label();
            this.chtype3 = new System.Windows.Forms.CheckBox();
            this.chtype2 = new System.Windows.Forms.CheckBox();
            this.chtype1 = new System.Windows.Forms.CheckBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsmscustomer)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvsmscustomer
            // 
            this.dgvsmscustomer.AllowUserToAddRows = false;
            this.dgvsmscustomer.AllowUserToDeleteRows = false;
            this.dgvsmscustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsmscustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column4});
            this.dgvsmscustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvsmscustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvsmscustomer.Name = "dgvsmscustomer";
            this.dgvsmscustomer.ReadOnly = true;
            this.dgvsmscustomer.Size = new System.Drawing.Size(274, 166);
            this.dgvsmscustomer.TabIndex = 1;
            // 
            // lbtype1
            // 
            this.lbtype1.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbtype1.Location = new System.Drawing.Point(3, 40);
            this.lbtype1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtype1.Name = "lbtype1";
            this.lbtype1.Size = new System.Drawing.Size(257, 50);
            this.lbtype1.TabIndex = 59;
            this.lbtype1.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbtype3);
            this.groupBox4.Controls.Add(this.lbtype2);
            this.groupBox4.Controls.Add(this.chtype1);
            this.groupBox4.Controls.Add(this.lbtype1);
            this.groupBox4.Controls.Add(this.chtype2);
            this.groupBox4.Controls.Add(this.chtype3);
            this.groupBox4.Location = new System.Drawing.Point(8, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 262);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "انتخاب نوع پیامک";
            // 
            // btnsms
            // 
            this.btnsms.Image = global::WaterBill.Properties.Resources.sms_alt_icon;
            this.btnsms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsms.Location = new System.Drawing.Point(73, 442);
            this.btnsms.Name = "btnsms";
            this.btnsms.Size = new System.Drawing.Size(110, 34);
            this.btnsms.TabIndex = 59;
            this.btnsms.Text = "ارسال پیامک";
            this.btnsms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsms.UseVisualStyleBackColor = true;
            this.btnsms.Click += new System.EventHandler(this.btnsms_Click);
            // 
            // lbtype3
            // 
            this.lbtype3.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbtype3.Location = new System.Drawing.Point(3, 204);
            this.lbtype3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtype3.Name = "lbtype3";
            this.lbtype3.Size = new System.Drawing.Size(257, 51);
            this.lbtype3.TabIndex = 61;
            this.lbtype3.Text = "-";
            // 
            // lbtype2
            // 
            this.lbtype2.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbtype2.Location = new System.Drawing.Point(3, 125);
            this.lbtype2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtype2.Name = "lbtype2";
            this.lbtype2.Size = new System.Drawing.Size(257, 47);
            this.lbtype2.TabIndex = 60;
            this.lbtype2.Text = "-";
            // 
            // chtype3
            // 
            this.chtype3.AutoSize = true;
            this.chtype3.Location = new System.Drawing.Point(85, 176);
            this.chtype3.Name = "chtype3";
            this.chtype3.Size = new System.Drawing.Size(64, 26);
            this.chtype3.TabIndex = 2;
            this.chtype3.Text = "نوع سوم";
            this.chtype3.UseVisualStyleBackColor = true;
            this.chtype3.CheckedChanged += new System.EventHandler(this.chtype3_CheckedChanged);
            // 
            // chtype2
            // 
            this.chtype2.AutoSize = true;
            this.chtype2.Location = new System.Drawing.Point(86, 93);
            this.chtype2.Name = "chtype2";
            this.chtype2.Size = new System.Drawing.Size(63, 26);
            this.chtype2.TabIndex = 1;
            this.chtype2.Text = "نوع دوم";
            this.chtype2.UseVisualStyleBackColor = true;
            this.chtype2.CheckedChanged += new System.EventHandler(this.chtype2_CheckedChanged);
            // 
            // chtype1
            // 
            this.chtype1.AutoSize = true;
            this.chtype1.Location = new System.Drawing.Point(89, 18);
            this.chtype1.Name = "chtype1";
            this.chtype1.Size = new System.Drawing.Size(60, 26);
            this.chtype1.TabIndex = 0;
            this.chtype1.Text = "نوع اول";
            this.chtype1.UseVisualStyleBackColor = true;
            this.chtype1.CheckedChanged += new System.EventHandler(this.chtype1_CheckedChanged);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "نام مشترک";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "شماره همراه";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Frm_SmsCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 488);
            this.Controls.Add(this.btnsms);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvsmscustomer);
            this.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SmsCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Frm_SmsCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsmscustomer)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsmscustomer;
        private System.Windows.Forms.Label lbtype1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnsms;
        private System.Windows.Forms.Label lbtype3;
        private System.Windows.Forms.Label lbtype2;
        private System.Windows.Forms.CheckBox chtype3;
        private System.Windows.Forms.CheckBox chtype2;
        private System.Windows.Forms.CheckBox chtype1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}