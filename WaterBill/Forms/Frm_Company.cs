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
    public partial class Frm_Company : Form
    {
        public Frm_Company()
        {
            InitializeComponent();
        }
        public int companyid = 0;
        UnitOfWork db = new UnitOfWork();
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            SubmitInmformation();
        }
        public void SubmitInmformation()
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string iscompanyexits="";
                try
                {
                    iscompanyexits = db.Company.GetFindNameCompany(txnamecompany.Text);
                }
                catch
                {

                }
                if (iscompanyexits == txnamecompany.Text&&btnsubmit.Text!="ویرایش")
                {
                    RtlMessageBox.Show("شرکتی یا مشترکی با همین نام ثبت شده است");
                }
                else
                {

                    if (txphonenumber.TextLength != 11)
                        RtlMessageBox.Show("شماره همراه نامعتبر است");
                    else
                    {
                        try
                        {

                            string name = txnamecompany.Text;
                            if (RtlMessageBox.Show($"   آیا از اضافه کردن مشترک {name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                //تولید کد اشتراک
                                string subscribid = "";
                                string codeeshterak = DateTime.Now.TimeOfDay.ToString();
                                codeeshterak = codeeshterak.Replace(':', '0').Replace('.', '1');
                                for (int i = 0; i < 10; i++)
                                {

                                    subscribid += codeeshterak[i].ToString();
                                }
                                string type;
                                if (rbA.Checked==true)
                                {
                                    type = "A";
                                }
                                else if(rbB.Checked == true)
                                {
                                    type = "B";
                                }
                                else
                                {
                                     type = "C";
                                }
                                
                                Tb_Company companyes = new Tb_Company()
                                {
                                    SubscribId = int.Parse(subscribid),
                                    CompanyName = txnamecompany.Text,
                                    PelakId = int.Parse(txpelak.Text),
                                    PhoneNumber = txphonenumber.Text,
                                    Addres = txaddres.Text,
                                    TypePublicService=type,
                                    FatherName=txfatheraname.Text,
                                    Shenasname=int.Parse(txshenasname.Text),
                                    Codemeli=txcodemeli.Text
                                };
                                Tb_Debt debt = new Tb_Debt()
                                {

                                    ID= int.Parse(subscribid),
                                    Best=0,
                                    Debt=0
                                };
                                Tb_Bill bill = new Tb_Bill()
                                {
                                    BillId = int.Parse(subscribid),
                                    Describtion = "",
                                    SeenDate = Convert.ToDateTime("01/01/2000"),
                                    SubScribCode = int.Parse(subscribid),
                                    MeterNumberPast = 0,
                                    MeterNumberNow=0,
                                    NameCompany=txnamecompany.Text,
                                    SeenDateShamsi="1300/01/01",
                                    PelackNumber = int.Parse(txpelak.Text)
                                   
                                };
                                Tb_Calculate calculate = new Tb_Calculate()
                                {
                                    Bedehi=0,
                                    Bestankar=0,
                                    CalculateId= int.Parse(subscribid),
                                    SubscribCode= int.Parse(subscribid),
                                    SumMaliat=0,
                                    SumTotal=0,
                                    UnitPay=0
                                };
                                if (companyid == 0)
                                {
                                    bool isvalid = db.Company.InsertCompany(companyes);
                                    bool isvalidbill = db.Company.InsertBill(bill);
                                    bool iscalc = db.Company.InsertCalculate(calculate);
                                    bool isdebt = db.Company.InsertDebt(debt);
                                    if (isvalid == true && isvalidbill == true&&iscalc&&isdebt)
                                    {

                                        db.Save();
                                        RtlMessageBox.Show("شرکت جدید ثبت گردید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        DialogResult = DialogResult.OK;

                                    }
                                    else RtlMessageBox.Show("اضافه کردن شرکت انجام نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                                else
                                {
                                    companyes.SubscribId = companyid;
                                    bool isvalid = false,isvalidbill=false;
                                    if (txphonenumber.TextLength == 11)
                                    {
                                     
                                        Tb_Bill billupdate = new Tb_Bill()
                                        {
                                            
                                            BillId =companyid,
                                            Describtion = db.Company.GetByDescrib(companyid),
                                            SeenDate =db.Company.GetbyPastDate(companyid),
                                            SubScribCode = companyid,
                                            MeterNumberPast = db.Company.GetByAmountPast(companyid),
                                            MeterNumberNow = db.Company.GetByAmountNow(companyid),
                                            NameCompany = txnamecompany.Text,
                                            SeenDateShamsi =db.Company.Getbyseenshamsi(companyid),
                                            PelackNumber = db.Company.GetByPelak(companyid)
                                            
                                        };
                                       
                                        isvalid = db.Company.UpdateCompany(companyes);
                                        isvalidbill = db.Company.UpadateBill(billupdate);

                                    }
                                    else RtlMessageBox.Show("شماره همراه نامعتبر است");
                                    if (isvalid == true&&isvalidbill==true)
                                    {

                                        db.Save();
                                        RtlMessageBox.Show("اطلاعات ویرایش شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        DialogResult = DialogResult.OK;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            RtlMessageBox.Show("مشکلی در ایجاد اطلاعات وجود دارد");
                            //MessageBox.Show(ex.Message);

                        }
                    }
                }
            }
        }
      //public  int sub;
        private void Frm_Company_Load(object sender, EventArgs e)
        {
            if (companyid != 0)
            {
                this.Text = "ویرایش شرکت";
                btnsubmit.Text = "ویرایش";
                var company = db.Company.GetCompanyByID(companyid);
                txnamecompany.Text = company.CompanyName;
                txaddres.Text = company.Addres;
                txphonenumber.Text = company.PhoneNumber;
                txfatheraname.Text = company.FatherName;
                txshenasname.Text = company.Shenasname.ToString();
                txcodemeli.Text = company.Codemeli.ToString();
                //sub =companyid;
                txpelak.Text = company.PelakId.ToString();
                if (company.TypePublicService == "A")
                    rbA.Checked = true;
                else if (company.TypePublicService == "B")
                    rbB.Checked = true;
                else
                    rbC.Checked = true;
            }
        }

        private void txphonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 46)//backspace&.
            { return; }
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }

        private void txphonenumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 46)//backspace&.
            { return; }
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }

        private void txaddres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitInmformation();
                e.SuppressKeyPress = true;
            }
        }

        private void txnamecompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txphonenumber.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txphonenumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txpelak.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
