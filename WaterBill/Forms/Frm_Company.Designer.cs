namespace WaterBill.Forms
{
    partial class Frm_Company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Company));
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txpelak = new System.Windows.Forms.TextBox();
            this.txaddres = new System.Windows.Forms.TextBox();
            this.txnamecompany = new System.Windows.Forms.TextBox();
            this.txphonenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.txfatheraname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txshenasname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txcodemeli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsubmit.Location = new System.Drawing.Point(60, 325);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(61, 31);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "ثبت";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txpelak
            // 
            this.txpelak.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txpelak.Location = new System.Drawing.Point(16, 127);
            this.txpelak.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txpelak.Name = "txpelak";
            this.txpelak.Size = new System.Drawing.Size(121, 29);
            this.txpelak.TabIndex = 3;
            this.txpelak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txphonenumber_KeyPress);
            // 
            // txaddres
            // 
            this.txaddres.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txaddres.Location = new System.Drawing.Point(17, 256);
            this.txaddres.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txaddres.Multiline = true;
            this.txaddres.Name = "txaddres";
            this.txaddres.Size = new System.Drawing.Size(121, 59);
            this.txaddres.TabIndex = 6;
            this.txaddres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txaddres_KeyDown);
            // 
            // txnamecompany
            // 
            this.txnamecompany.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txnamecompany.Location = new System.Drawing.Point(17, 13);
            this.txnamecompany.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txnamecompany.Name = "txnamecompany";
            this.txnamecompany.Size = new System.Drawing.Size(121, 29);
            this.txnamecompany.TabIndex = 0;
            this.txnamecompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txnamecompany_KeyDown);
            // 
            // txphonenumber
            // 
            this.txphonenumber.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txphonenumber.Location = new System.Drawing.Point(17, 210);
            this.txphonenumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txphonenumber.Name = "txphonenumber";
            this.txphonenumber.Size = new System.Drawing.Size(121, 29);
            this.txphonenumber.TabIndex = 5;
            this.txphonenumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txphonenumber_KeyDown);
            this.txphonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txphonenumber_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(166, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "شماره موبایل:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(168, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "شماره پرونده:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(208, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "ادرس:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(179, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "نام مشترک:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Controls.Add(this.rbB);
            this.groupBox1.Controls.Add(this.rbA);
            this.groupBox1.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(11, 378);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(242, 123);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "متراژ";
            this.groupBox1.Visible = false;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbC.Location = new System.Drawing.Point(43, 78);
            this.rbC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(122, 26);
            this.rbC.TabIndex = 2;
            this.rbC.Text = "متراژ 2000متر به بالا";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbB.Location = new System.Drawing.Point(2, 47);
            this.rbB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(163, 26);
            this.rbB.TabIndex = 1;
            this.rbB.Text = "متراژ 600متر تا1999 مترمربع";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Checked = true;
            this.rbA.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbA.Location = new System.Drawing.Point(9, 17);
            this.rbA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(156, 26);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "متراژ 100متر تا599 مترمربع";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // txfatheraname
            // 
            this.txfatheraname.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txfatheraname.Location = new System.Drawing.Point(16, 88);
            this.txfatheraname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txfatheraname.Name = "txfatheraname";
            this.txfatheraname.Size = new System.Drawing.Size(121, 29);
            this.txfatheraname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(201, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "نام پدر:";
            // 
            // txshenasname
            // 
            this.txshenasname.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txshenasname.Location = new System.Drawing.Point(16, 166);
            this.txshenasname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txshenasname.Name = "txshenasname";
            this.txshenasname.Size = new System.Drawing.Size(121, 29);
            this.txshenasname.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(155, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "شماره شناسنامه:";
            // 
            // txcodemeli
            // 
            this.txcodemeli.Font = new System.Drawing.Font("B Roya", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txcodemeli.Location = new System.Drawing.Point(17, 52);
            this.txcodemeli.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txcodemeli.Name = "txcodemeli";
            this.txcodemeli.Size = new System.Drawing.Size(121, 29);
            this.txcodemeli.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(202, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "کدملی:";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txnamecompany;
            this.requiredFieldValidator1.ErrorMessage = "نامعتبر";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txphonenumber;
            this.requiredFieldValidator2.ErrorMessage = "نامعتبر";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txpelak;
            this.requiredFieldValidator3.ErrorMessage = "نامعتبر";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.txaddres;
            this.requiredFieldValidator4.ErrorMessage = "نامعتبر";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // Frm_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 360);
            this.Controls.Add(this.txcodemeli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txshenasname);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txfatheraname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txpelak);
            this.Controls.Add(this.txaddres);
            this.Controls.Add(this.txnamecompany);
            this.Controls.Add(this.txphonenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("IRANSans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_Company";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت شرکت";
            this.Load += new System.EventHandler(this.Frm_Company_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txpelak;
        private System.Windows.Forms.TextBox txaddres;
        private System.Windows.Forms.TextBox txnamecompany;
        private System.Windows.Forms.TextBox txphonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.TextBox txfatheraname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txshenasname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txcodemeli;
        private System.Windows.Forms.Label label7;
    }
}