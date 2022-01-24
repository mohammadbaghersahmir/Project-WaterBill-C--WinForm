namespace WaterBill.Forms
{
    partial class Frm_PanelSms
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnsms = new System.Windows.Forms.Button();
            this.rbtype1 = new System.Windows.Forms.RadioButton();
            this.rbtype2 = new System.Windows.Forms.RadioButton();
            this.rbtype3 = new System.Windows.Forms.RadioButton();
            this.lbtype1 = new System.Windows.Forms.TextBox();
            this.lbtype2 = new System.Windows.Forms.TextBox();
            this.lbtype3 = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txcodepatern = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txcodepatern);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.lbtype3);
            this.groupBox4.Controls.Add(this.lbtype2);
            this.groupBox4.Controls.Add(this.lbtype1);
            this.groupBox4.Controls.Add(this.rbtype3);
            this.groupBox4.Controls.Add(this.btnsms);
            this.groupBox4.Controls.Add(this.rbtype2);
            this.groupBox4.Controls.Add(this.rbtype1);
            this.groupBox4.Location = new System.Drawing.Point(-2, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 254);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "انتخاب نوع پیامک";
            // 
            // btnsms
            // 
            this.btnsms.Image = global::WaterBill.Properties.Resources.Open_folder_accept_icon;
            this.btnsms.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnsms.Location = new System.Drawing.Point(14, 209);
            this.btnsms.Name = "btnsms";
            this.btnsms.Size = new System.Drawing.Size(110, 45);
            this.btnsms.TabIndex = 59;
            this.btnsms.Text = "پیش فرض";
            this.btnsms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsms.UseVisualStyleBackColor = true;
            this.btnsms.Click += new System.EventHandler(this.btnsms_Click);
            // 
            // rbtype1
            // 
            this.rbtype1.AutoSize = true;
            this.rbtype1.Location = new System.Drawing.Point(388, 32);
            this.rbtype1.Name = "rbtype1";
            this.rbtype1.Size = new System.Drawing.Size(59, 26);
            this.rbtype1.TabIndex = 62;
            this.rbtype1.Text = "نوع اول";
            this.rbtype1.UseVisualStyleBackColor = true;
            this.rbtype1.CheckedChanged += new System.EventHandler(this.rbtype1_CheckedChanged);
            // 
            // rbtype2
            // 
            this.rbtype2.AutoSize = true;
            this.rbtype2.Location = new System.Drawing.Point(385, 98);
            this.rbtype2.Name = "rbtype2";
            this.rbtype2.Size = new System.Drawing.Size(62, 26);
            this.rbtype2.TabIndex = 63;
            this.rbtype2.Text = "نوع دوم";
            this.rbtype2.UseVisualStyleBackColor = true;
            this.rbtype2.CheckedChanged += new System.EventHandler(this.rbtype2_CheckedChanged);
            // 
            // rbtype3
            // 
            this.rbtype3.AutoSize = true;
            this.rbtype3.Location = new System.Drawing.Point(380, 161);
            this.rbtype3.Name = "rbtype3";
            this.rbtype3.Size = new System.Drawing.Size(63, 26);
            this.rbtype3.TabIndex = 64;
            this.rbtype3.Text = "نوع سوم";
            this.rbtype3.UseVisualStyleBackColor = true;
            this.rbtype3.CheckedChanged += new System.EventHandler(this.rbtype3_CheckedChanged);
            // 
            // lbtype1
            // 
            this.lbtype1.Enabled = false;
            this.lbtype1.Location = new System.Drawing.Point(14, 24);
            this.lbtype1.Multiline = true;
            this.lbtype1.Name = "lbtype1";
            this.lbtype1.Size = new System.Drawing.Size(368, 47);
            this.lbtype1.TabIndex = 65;
            // 
            // lbtype2
            // 
            this.lbtype2.Enabled = false;
            this.lbtype2.Location = new System.Drawing.Point(14, 86);
            this.lbtype2.Multiline = true;
            this.lbtype2.Name = "lbtype2";
            this.lbtype2.Size = new System.Drawing.Size(368, 47);
            this.lbtype2.TabIndex = 66;
            // 
            // lbtype3
            // 
            this.lbtype3.Enabled = false;
            this.lbtype3.Location = new System.Drawing.Point(14, 150);
            this.lbtype3.Multiline = true;
            this.lbtype3.Name = "lbtype3";
            this.lbtype3.Size = new System.Drawing.Size(368, 47);
            this.lbtype3.TabIndex = 67;
            // 
            // btnupdate
            // 
            this.btnupdate.Image = global::WaterBill.Properties.Resources.folder_check_icon;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnupdate.Location = new System.Drawing.Point(130, 209);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(128, 45);
            this.btnupdate.TabIndex = 68;
            this.btnupdate.Text = "اعمال تغییرات";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Roya", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(389, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "کدپترن:";
            // 
            // txcodepatern
            // 
            this.txcodepatern.Location = new System.Drawing.Point(263, 217);
            this.txcodepatern.Name = "txcodepatern";
            this.txcodepatern.Size = new System.Drawing.Size(119, 29);
            this.txcodepatern.TabIndex = 70;
            // 
            // Frm_PanelSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 298);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PanelSms";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Frm_PanelSms_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtype3;
        private System.Windows.Forms.RadioButton rbtype2;
        private System.Windows.Forms.RadioButton rbtype1;
        private System.Windows.Forms.Button btnsms;
        private System.Windows.Forms.TextBox lbtype3;
        private System.Windows.Forms.TextBox lbtype2;
        private System.Windows.Forms.TextBox lbtype1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txcodepatern;
        private System.Windows.Forms.Label label1;
    }
}