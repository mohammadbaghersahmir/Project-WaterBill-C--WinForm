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
using WaterBill_Utility.Convertor;

namespace WaterBill.Forms
{
    public partial class Frm_Calculator : Form
    {
        public Frm_Calculator()
        {
            InitializeComponent();
        }
        public List<CalcDebt> ItemsDebt = new List<CalcDebt>();
        public void FillTxtInDebt()
        {
            if (companyid != 0)
            {
                var company = db.Company.GetReceiptCalcByID(companyid);
                txbed.Text = company.bedehi.ToString();
                txbest.Text = company.paradakhti.ToString();
                //txsum.Text = ItemsDebt[0].Sum.ToString() + " تومان";
                txname.Text = company.Name;
                txtype.Text = company.type;
                txdate.Text = company.datesabt.Value.ToShamsi();
                txname.Enabled = false;
                
            }
            else
            {
                txname.Text = name;
                txdate.Text = DateTime.Now.ToShamsi().ToString();
                txname.Enabled = false;
            }
           
        }
        public int companyid = 0;
        public string name = "";
        UnitOfWork db = new UnitOfWork();
        private void Frm_Calculator_Load(object sender, EventArgs e)
        {
            FillTxtInDebt();
        }

        public void InsertDebt()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                //if (ItemsDebt[0].Bed == 0 && ItemsDebt[0].Bes == 0)
                //{

                Tb_Debt debt = new Tb_Debt()
                {
                    ID = ItemsDebt[0].Id,
                    Debt = double.Parse(txbed.Text) * -1,
                    Best = double.Parse(txbest.Text)
                };

                bool isdebt = db.Company.UpadateDebt(debt);
                //if (isdebt)
                //{
                db.Save();
                //RtlMessageBox.Show("اطلاعات حساب مشترک اولین بار با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //}
                //else
                //{
                double SumDebt = db.Company.AmountDebt(ItemsDebt[0].Id);
                if (SumDebt > 0)
                {
                    Tb_Debt debt1 = new Tb_Debt()
                    {
                        ID = ItemsDebt[0].Id,
                        Debt = 0,
                        Best = SumDebt
                    };
                    db.Company.UpadateDebt(debt1);
                    db.Save();
                    txbed.Text = (db.Company.GetByBedehi(ItemsDebt[0].Id) * -1).ToString();
                    txbest.Text = db.Company.GetByBestankar(ItemsDebt[0].Id).ToString();
                    if (db.Company.AmountDebt(ItemsDebt[0].Id) > 0)
                    {
                        //txsum.Text = (db.Company.AmountDebt(ItemsDebt[0].Id)).ToString() + "تومان";
                    }
                    else
                    {
                        //txsum.Text = (db.Company.AmountDebt(ItemsDebt[0].Id) * -1).ToString() + "تومان";
                    }
                    RtlMessageBox.Show("اطلاعات حساب مشترک با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (SumDebt < 0)
                {
                    Tb_Debt debt2 = new Tb_Debt()
                    {
                        ID = ItemsDebt[0].Id,
                        Debt = SumDebt,
                        Best = 0
                    };
                    db.Company.UpadateDebt(debt2);
                    db.Save();
                    txbed.Text = (db.Company.GetByBedehi(ItemsDebt[0].Id) * -1).ToString();
                    txbest.Text = db.Company.GetByBestankar(ItemsDebt[0].Id).ToString();
                    if (db.Company.AmountDebt(ItemsDebt[0].Id) > 0)
                    {
                        //txsum.Text = (db.Company.AmountDebt(ItemsDebt[0].Id)).ToString() + "تومان";
                    }
                    else
                    {
                        //txsum.Text = (db.Company.AmountDebt(ItemsDebt[0].Id) * -1).ToString() + "تومان";
                    }
                    RtlMessageBox.Show("اطلاعات حساب مشترک با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (SumDebt == 0)
                {
                    Tb_Debt debt3 = new Tb_Debt()
                    {
                        ID = ItemsDebt[0].Id,
                        Debt = 0,
                        Best = 0
                    };
                    db.Company.UpadateDebt(debt3);
                    db.Save();
                    txbed.Text = (db.Company.GetByBedehi(ItemsDebt[0].Id) * -1).ToString();
                    txbest.Text = db.Company.GetByBestankar(ItemsDebt[0].Id).ToString();
                    if (db.Company.AmountDebt(ItemsDebt[0].Id) > 0)
                    {
                        //txsum.Text = (db.Company.AmountDebt(ItemsDebt[0].Id)).ToString() + "تومان";
                    }
                    else
                    {
                        //txsum.Text = (db.Company.AmountDebt(ItemsDebt[0].Id) * -1).ToString() + "تومان";
                    }
                    RtlMessageBox.Show("اطلاعات حساب مشترک با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //}
            }
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (companyid == 0 && BaseValidator.IsFormValid(this.components))
                {
                    //InsertDebt();
                    InsertRescal();
                    UpdateDebt();
                }
                else if (BaseValidator.IsFormValid(this.components))
                {
                    UpdateRescalc();
                    UpdateDebt();
                }
            }
            catch
            {
                RtlMessageBox.Show("مشکلی در ثبت اطلاعات یاغیره وجود دارد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateDebt()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                int idmoshtarak = db.Company.Getbysubbyname(txname.Text);
                List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> datares = db.Company.GetAllCalcMoshtarakSum();
                var r = datares.Where(i=>i.Id==idmoshtarak).GroupBy(l => l.Id)
            .Select(cl => new
            {
                bedehi = cl.Sum(c => c.bedehi),
                paradakhti = cl.Sum(c => c.paradakhti),
            }).First();
                Tb_Debt debt = new Tb_Debt()
                {
                    ID = idmoshtarak,
                    Debt = r.bedehi * -1,
                    Best = r.paradakhti
                };
                bool isvalidupdate = db.Company.UpadateDebt(debt);
                if (isvalidupdate)
                {
                    db.Save();
                    RtlMessageBox.Show("جدول بدهی/بستانکاری باموفقیت به روز رسانی  شد");
                }
                else
                    RtlMessageBox.Show(" مشکلی در بروز رسانی جدول بدهی/بستانکاری وجود دارد");


            }
        }
            public void InsertRescal()
        {
            int sub = db.Company.Getbysubbyname(name);
            Tb_Receipt_calc res = new Tb_Receipt_calc()
            {
                Id = sub,
                bedehi =int.Parse(txbed.Text.Replace(",","")),
                paradakhti =int.Parse(txbest.Text.Replace(",","")),
                datesabt = DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdate.Text)),
                Name = txname.Text,
                type = txtype.Text
            };
            bool isvalid;
            isvalid = db.Company.InsertRecieptCalc(res);
            if (isvalid)
            {
                db.Save();
                RtlMessageBox.Show("ثبت فیش باموفقیت انجام شد");
                DialogResult = DialogResult.OK;
            }
            else
                RtlMessageBox.Show("ثبت فیش باموفقیت انجام نشد","هشدار",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public void UpdateRescalc()
        {
            var company = db.Company.GetReceiptCalcByID(companyid);
            Tb_Receipt_calc res = new Tb_Receipt_calc()
            {
                Id=company.Id,
                Key=company.Key,
                bedehi=int.Parse(txbed.Text.Replace(",","")),
                paradakhti=int.Parse(txbest.Text.Replace(",","")),
                datesabt= DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdate.Text)),
                 Name=txname.Text,
                 type=txtype.Text
            };
            bool isvalid;
            isvalid = db.Company.UpadateResCalc(res);
            if(isvalid)
            {
                db.Save();
                RtlMessageBox.Show("ویرایش باموفقیت انجام شد");
                DialogResult = DialogResult.OK;
            }
            else
                RtlMessageBox.Show("ویرایش باموفقیت انجام نشد","هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txbest_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = string.Format("{0:#,##0}", value);
            else
                textBox.Text = String.Empty;
        }

        private void txbed_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = string.Format("{0:#,##0}", value);
            else
                textBox.Text = String.Empty;
        }
    }
}
