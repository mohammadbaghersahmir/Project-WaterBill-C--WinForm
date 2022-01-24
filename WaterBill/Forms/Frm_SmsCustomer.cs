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
using WaterBill_Utility.Convertor;

namespace WaterBill.Forms
{
    public partial class Frm_SmsCustomer : Form
    {
        public Frm_SmsCustomer()
        {
            InitializeComponent();
        }

        private void Frm_SmsCustomer_Load(object sender, EventArgs e)
        {
            DgvFill();
        }
        public int count = 0;
        public List<SmsList> ListSms = new List<SmsList>();
        public void DgvFill()
        {
            for (int i = 0; i < count; i++)
            {
                dgvsmscustomer.Rows.Add(ListSms[i].curency,ListSms[i].name,ListSms[i].phonenumber);
            }

        }
        bool flag1, flag2, flag3;

        private void chtype2_CheckedChanged(object sender, EventArgs e)
        {
            if (chtype2.Checked == true)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    lbtype2.Text = db.optionssms.Get().First(m => m.key == 2).MatnSms;
                    patern2 = db.Company.Getbypaterncode(3);
                    flag2 = true;
                }
            }
            if (chtype2.Checked == false)
            {
                lbtype2.Text = "-";
                flag2 = false;
            }
        }

        private void chtype3_CheckedChanged(object sender, EventArgs e)
        {
            if (chtype3.Checked == true)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    lbtype3.Text = db.optionssms.Get().First(m => m.key == 3).MatnSms;
                    patern3 = db.Company.Getbypaterncode(4);
                    flag3 = true;
                }
            }
            if (chtype3.Checked == false)
            {
                lbtype3.Text = "-";
                flag3 = false;
            }
        }

        private void btnsms_Click(object sender, EventArgs e)
        {
            if (!chtype1.Checked && !chtype2.Checked && !chtype3.Checked)
            {
                RtlMessageBox.Show("حداقل یک نوع پیامک را انتخاب  کنید");
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (flag1 == true)
                    {
                        PanelSMS.smsserver client = new PanelSMS.smsserver();
                        var username = "mir6251";
                        var password = "aminso123";
                        var fromNum = "3000505";
                        if (dgvsmscustomer.CurrentRow != null)
                        {
                            int istrueall = 0, isfalseall = 0;
                            List<string> phone = new List<string>();
                            //var token = new Token().GetToken("bed4e9408ce000a0afe0edc3", "mirso6251#%^**");
                            for (int i = 0; i < count; i++)
                            {
                                var data = new PanelSMS.input_data_type[] {
                        // key is your parameter name and value is what you want to send to the receiptor 
                new PanelSMS.input_data_type() { key = "name", value = ListSms[i].name },
                new PanelSMS.input_data_type() { key = "amount", value =""}
                    };
                                string[] toNum = { ListSms[i].phonenumber };
                                var response = client.sendPatternSms(fromNum, toNum, username, password, patern1, data);
                                try
                                {
                                    if (int.Parse(response) > 0 && int.Parse(response) < 999999999)
                                    {
                                        istrueall++;
                                    }
                                }

                                catch
                                {
                                    phone.Add(ListSms[i].phonenumber);
                                    isfalseall++;
                                }
                                Tb_PanelSms sms = new Tb_PanelSms()
                                {
                                    IdCustomer = int.Parse(dgvsmscustomer.Rows[i].Cells[0].Value.ToString())
                                    ,
                                    DateSms=DateTime.Now,
                                    NameCustomer=dgvsmscustomer.Rows[i].Cells[1].Value.ToString()
                                };
                                db.Company.InsertSms(sms);
                                db.Save();
                            }
                            if (istrueall == count - isfalseall)
                            {
                              
                                RtlMessageBox.Show("پیامک  ها باموفقیت ارسال شدند!!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            if (isfalseall == count - istrueall)
                            {
                                for (int i = 0; i < isfalseall; i++)
                                {
                                    RtlMessageBox.Show("پیامک به این شماره ارسال نشد:" + phone[i]);
                                }
                            }
                        }
                        else
                        {
                            RtlMessageBox.Show("پیامکی برای ارسال وجود ندارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (flag2 == true)
                    {
                        PanelSMS.smsserver client = new PanelSMS.smsserver();
                        var username = "mir6251";
                        var password = "aminso123";
                        var fromNum = "3000505";
                        if (dgvsmscustomer.CurrentRow != null)
                        {
                            int istrueall = 0, isfalseall = 0;
                            List<string> phone = new List<string>();
                            //var token = new Token().GetToken("bed4e9408ce000a0afe0edc3", "mirso6251#%^**");
                            for (int i = 0; i < count; i++)
                            {
                                var data = new PanelSMS.input_data_type[] {
                        // key is your parameter name and value is what you want to send to the receiptor 
                new PanelSMS.input_data_type() { key = "name", value = ListSms[i].name },
                
                    };
                                string[] toNum = { ListSms[i].phonenumber };
                                var response = client.sendPatternSms(fromNum, toNum, username, password, patern2, data);
                                try
                                {
                                    if (int.Parse(response) > 0 && int.Parse(response) < 999999999)
                                    {
                                        istrueall++;
                                    }
                                }

                                catch
                                {
                                    phone.Add(ListSms[i].phonenumber);
                                    isfalseall++;
                                }
                                Tb_PanelSms sms = new Tb_PanelSms()
                                {
                                    IdCustomer = int.Parse(dgvsmscustomer.Rows[i].Cells[0].Value.ToString())
                                  ,
                                    DateSms = DateTime.Now,
                                    NameCustomer = dgvsmscustomer.Rows[i].Cells[1].Value.ToString()
                                };
                                db.Company.InsertSms(sms);
                                db.Save();
                            }
                            
                            if (istrueall == count - isfalseall)
                            {
                                RtlMessageBox.Show("پیامک  ها باموفقیت ارسال شدند!!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            if (isfalseall == count - istrueall)
                            {
                                for (int i = 0; i < isfalseall; i++)
                                {
                                    RtlMessageBox.Show("پیامک به این شماره ارسال نشد:" + phone[i]);
                                }
                            }
                        }

                        else
                        {
                            RtlMessageBox.Show("پیامکی برای ارسال وجود ندارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (flag3 == true)
                    {
                        PanelSMS.smsserver client = new PanelSMS.smsserver();
                        var username = "mir6251";
                        var password = "aminso123";
                        var fromNum = "3000505";
                        if (dgvsmscustomer.CurrentRow != null)
                        {
                            int istrueall = 0, isfalseall = 0;
                            List<string> phone = new List<string>();
                            //var token = new Token().GetToken("bed4e9408ce000a0afe0edc3", "mirso6251#%^**");
                            for (int i = 0; i < count; i++)
                            {
                                var data = new PanelSMS.input_data_type[] {
                        // key is your parameter name and value is what you want to send to the receiptor 
                new PanelSMS.input_data_type() { key = "name", value = ListSms[i].name },
                    };
                                string[] toNum = { ListSms[i].phonenumber };
                                var response = client.sendPatternSms(fromNum, toNum, username, password, patern3, data);
                                try
                                {
                                    if (int.Parse(response) > 0 && int.Parse(response) < 999999999)
                                    {
                                        istrueall++;
                                    }
                                }

                                catch
                                {
                                    phone.Add(ListSms[i].phonenumber);
                                    isfalseall++;
                                }
                                Tb_PanelSms sms = new Tb_PanelSms()
                                {
                                    IdCustomer = int.Parse(dgvsmscustomer.Rows[i].Cells[0].Value.ToString())
                                  ,
                                    DateSms = DateTime.Now,
                                    NameCustomer = dgvsmscustomer.Rows[i].Cells[1].Value.ToString()
                                };
                                db.Company.InsertSms(sms);
                                db.Save();
                            }
                            
                            if (istrueall == count - isfalseall)
                            {
                                RtlMessageBox.Show("پیامک  ها باموفقیت ارسال شدند!!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            if (isfalseall == count - istrueall)
                            {
                                for (int i = 0; i < isfalseall; i++)
                                {
                                    RtlMessageBox.Show("پیامک به این شماره ارسال نشد:" + phone[i]);
                                }
                            }
                        }

                        else
                        {
                            RtlMessageBox.Show("پیامکی برای ارسال وجود ندارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        string patern1, patern2, patern3;
        private void chtype1_CheckedChanged(object sender, EventArgs e)
        {
            if (chtype1.Checked == true)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    lbtype1.Text = db.optionssms.Get().First(m => m.key == 1).MatnSms;
                    patern1 = db.Company.Getbypaterncode(2);
                    flag1 = true;
                }
            }
            if (chtype1.Checked == false)
            {
                lbtype1.Text = "-";
                flag1 = false;
            }
        }
    }
}
