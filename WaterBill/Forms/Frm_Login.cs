using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;
using WaterBill_DataLayer.Contex;
using WaterBill_DataLayer.EfModel;

namespace WaterBill.Forms
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        public bool IsEdit = false;
        private void btninput_Click(object sender, EventArgs e)
        {
            EnterFromProgram();
        }
        public void EnterFromProgram()
        {

            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {

                    if (IsEdit)
                    {
                        var login = db.companylogin.Get().First();
                        login.UserName = txtusername.Text;
                        login.Password = txtpassword.Text;
                        db.companylogin.Update(login);
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.companylogin.Get(l => l.UserName == txtusername.Text && l.Password == txtpassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("چنین کاربری وجود ندارد");
                        }
                    }
                }
            }
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.Text = "تنظیمات ورود به برنامه";
                btninput.Text = "ذخیره تغییرات";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.companylogin.Get().First();
                    txtusername.Text = login.UserName;
                    txtpassword.Text = login.Password;
                }
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterFromProgram();
                e.SuppressKeyPress = true;
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

       

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = default(char);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '.';
        }
    }
}
