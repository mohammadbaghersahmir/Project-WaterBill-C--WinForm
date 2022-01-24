using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterBill_DataLayer.Contex;
using WaterBill_DataLayer.EfModel;

namespace WaterBill.Forms
{
    public partial class Frm_PanelSms : Form
    {
        public Frm_PanelSms()
        {
            InitializeComponent();
        }

        private void Frm_PanelSms_Load(object sender, EventArgs e)
        {
            ShowSms();
        }
        public void ShowSms()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                lbtype1.Text= db.optionssms.Get().First(i => i.key == 1).MatnSms;
                lbtype2.Text= db.optionssms.Get().First(i => i.key == 2).MatnSms;
                lbtype3.Text= db.optionssms.Get().First(i => i.key == 3).MatnSms;
                if(db.optionssms.Get().First(i => i.key == 1).Isflag==true)
                {
                    rbtype1.Checked = true;
                    lbtype1.Enabled = true;
                    txcodepatern.Text = db.Company.Getbypaterncode(2);
                }
                else if (db.optionssms.Get().First(i => i.key == 2).Isflag == true)
                {
                    rbtype2.Checked = true;
                    lbtype2.Enabled = true;
                    txcodepatern.Text = db.Company.Getbypaterncode(3);

                }
                else if (db.optionssms.Get().First(i => i.key == 3).Isflag == true)
                {
                    rbtype3.Checked = true;
                    lbtype3.Enabled = true;
                    txcodepatern.Text = db.Company.Getbypaterncode(4);
                }
            }
        }
        public void Defultsms()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
               
                int key = 0;
                if (rbtype1.Checked == true)
                {
                    key = 1;
                }
                else if (rbtype2.Checked == true)
                {
                    key = 2;
                }
                else if (rbtype3.Checked == true)
                {
                    key = 3;
                }
               List<long> li=new List<long>();
              var  list=db.optionssms.Get().Where(t => t.key != key).ToList();
                foreach (var item in list)
                {
                    if (item.Isflag == true)
                        item.Isflag = false;
                  
                }
                
                var smsflag1 = list.Where(t=>t.key!=key).First().Isflag;
                var smsflag2 = list.Where(t => t.key != key).Last().Isflag;
                var smskey1 = list[0].key;
                var smskey2 = list[1].key;

                Tb_OptionsSms sms1 = new Tb_OptionsSms()
                {
                    Isflag = smsflag1,
                    key = smskey1,
                    MatnSms= db.optionssms.Get().First(m=>m.key==smskey1).MatnSms
                };
                Tb_OptionsSms sms2 = new Tb_OptionsSms()
                {
                    Isflag = smsflag2,
                    key = smskey2,
                    MatnSms= db.optionssms.Get().First(m => m.key == smskey2).MatnSms
                };
                Tb_OptionsSms sms = new Tb_OptionsSms()
                {
                    Isflag = true,
                    key = key,
                    MatnSms = db.optionssms.Get().First(m => m.key == key).MatnSms
                };
                var isflag1 = db.Company.UpadateSmsoptions(sms1);
                var isflag2 = db.Company.UpadateSmsoptions(sms2);
                var  isflag=db.Company.UpadateSmsoptions(sms);
                if (isflag&&isflag1&&isflag2)
                {
                    db.Save();
                    RtlMessageBox.Show("تنظیمات باموفقیت اعمال شد", "موفق", MessageBoxButtons.OK);
                }
                else
                {
                    RtlMessageBox.Show(" مشکلی در تنظیمات وجود دارد","خطا",MessageBoxButtons.OK);
                }
            }
       }
        private void btnsms_Click(object sender, EventArgs e)
        {
            Defultsms();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int key = 0;
            if (rbtype1.Checked == true)
            {
                key = 1;
                
            }
            else if (rbtype2.Checked == true)
            {
                key = 2;
            }
            else if (rbtype3.Checked == true)
            {
                key = 3;
            }
            using (UnitOfWork db = new UnitOfWork())
            {
                var customer = db.optionssms.Get(f => f.key == key).First();
                var patern = db.companylogin.Get(f => f.LoginId == key+1).First();
                if (lbtype1.Enabled)
                {
                    customer.MatnSms = lbtype1.Text;
                    patern.UserName = txcodepatern.Text;
                    db.companylogin.Update(patern);
                    db.optionssms.Update(customer);
                    db.Save();
                    RtlMessageBox.Show("تنظیمات نوع اول باموفقیت تغییرکرد", "موفق", MessageBoxButtons.OK);
                }
                else if (lbtype2.Enabled)
                {
                    customer.MatnSms = lbtype2.Text;
                    patern.UserName = txcodepatern.Text;
                    db.companylogin.Update(patern);
                    db.optionssms.Update(customer);
                    db.Save();
                    RtlMessageBox.Show("تنظیمات  نوع دوم باموفقیت تغییرکرد", "موفق", MessageBoxButtons.OK);
                }
                else if (lbtype3.Enabled)
                {
                    customer.MatnSms = lbtype3.Text;
                    patern.UserName = txcodepatern.Text;
                    db.companylogin.Update(patern);
                    db.optionssms.Update(customer);
                    db.Save();
                    RtlMessageBox.Show("تنظیمات نوع سوم باموفقیت تغییرکرد", "موفق", MessageBoxButtons.OK);
                }
            }
            }

        private void rbtype1_CheckedChanged(object sender, EventArgs e)
        {
            lbtype1.Enabled = true;
            lbtype2.Enabled = false;
            lbtype3.Enabled = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                txcodepatern.Text = db.Company.Getbypaterncode(2);

            }
        }

        private void rbtype2_CheckedChanged(object sender, EventArgs e)
        {
            lbtype1.Enabled = false;
            lbtype2.Enabled = true;
            lbtype3.Enabled = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                txcodepatern.Text = db.Company.Getbypaterncode(3);

            }
        }

        private void rbtype3_CheckedChanged(object sender, EventArgs e)
        {
            lbtype1.Enabled = false;
            lbtype2.Enabled = false;
            lbtype3.Enabled = true;
            using (UnitOfWork db = new UnitOfWork())
            {
                txcodepatern.Text = db.Company.Getbypaterncode(4);

            }
        }
    }
}
