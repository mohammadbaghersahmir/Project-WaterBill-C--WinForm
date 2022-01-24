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
using CEWorld.Convert;


namespace WaterBill.Forms
{
    public partial class Frm_SelectAll : Form
    {
        public Frm_SelectAll()
        {
            InitializeComponent();
        }

        public int count = 0;
        public List<CalcDebt> ItemsDebt = new List<CalcDebt>();
        public List<Rec> SelectedItems = new List<Rec>();
        Frm_Bill f = new Frm_Bill();
       
        public void Filltxt()
        {
            txdatenow.Text = DateTime.Now.ToShamsi().Replace("-","/");
            txsubscribid.Text = SelectedItems[0].codemeli.ToString();
            txdate.Text = SelectedItems[0].date.ToString();
            txname.Text = SelectedItems[0].name.ToString();
            txnerkh.Text = SelectedItems[0].nerkh.ToString() + " تومان";
            txdescrib.Text = SelectedItems[0].describ.ToString();
            txbestankar.Text = SelectedItems[0].bestankar.ToString() + " تومان";
            txbedehi.Text =int.Parse((SelectedItems[0].bedehi).ToString()).ToString()+ " تومان";
            txamountmeternow.Text = SelectedItems[0].meternow.ToString();     
            txamountmeterpast.Text = SelectedItems[0].meterpast.ToString();
            txadress.Text = SelectedItems[0].adress.ToString();
            txabunman.Text = SelectedItems[0].abunman.ToString() + " تومان";
            txnerkh3.Text = SelectedItems[0].maliat.ToString() + " تومان";
            txunit.Text = SelectedItems[0].unit.ToString() + " تومان";
            txunittoup.Text = SelectedItems[0].unitofup.ToString() + " تومان";
            txhesab.Text = SelectedItems[0].hesab.ToString();
            txghotre.Text = SelectedItems[0].ghotre.ToString();
            txkhadamat.Text = (int.Parse(txnerkh.Text.Replace("تومان", "")) + int.Parse(txabunman.Text.Replace("تومان", ""))).ToString();
            txpelack.Text = SelectedItems[0].Pelak.ToString();
            txphone.Text = SelectedItems[0].phonenumber;
            txfathername.Text = SelectedItems[0].fathername;
            txshenasname.Text = SelectedItems[0].shenasname.ToString();
            txcodeasli.Text = SelectedItems[0].companyid.ToString();
            using (UnitOfWork db = new UnitOfWork())
            {
                txidbill.Text = db.Company.GetBillId(0).ToString();
             }
        }
          
        private void Frm_SelectAll_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                lbwater.Text = "اب بها:("+db.Company.GetByGhotre()+"متربه بالا)";
                lbnerkh3.Text = "اب بها:(" + db.Company.GetbyCurencyOfunit(0) + "متربه بالا)";

            }
            try
            {
                Filltxt();
                using (UnitOfWork db = new UnitOfWork())
                {
                        List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> data = db.Company.GetAllCalcMoshtarakSum();
                        var filldatadgv = data.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                        {
                            //id = cl.First().Id,
                            //key = cl.First().Key,
                            //Name = cl.First().Name,
                            bedehi = cl.Sum(c => c.bedehi).ToString(),
                            paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                            //datesabt = cl.First().datesabt.Value.ToShamsi(),
                            //type = cl.First().t
                        }).ToList();
                    if ((db.Company.GetByBedehi(int.Parse(txcodeasli.Text)) + db.Company.GetByBestankar(int.Parse(txcodeasli.Text)) * -1) < 0)
                    {
                        txbedehipast.Text = ((db.Company.GetByBedehi(int.Parse(txcodeasli.Text)) + db.Company.GetByBestankar(int.Parse(txcodeasli.Text))) * -1).ToString();

                    }
                    else
                        txbedehipast.Text = (db.Company.GetByBedehi(int.Parse(txcodeasli.Text)) * -1).ToString();


                }
                if (txamountmeterpast.Text == "0")
                {
                    txamountmeterpast.ReadOnly = false;
                }
                else
                {
                    txamountmeterpast.ReadOnly = true;
                }
                System.Globalization.PersianCalendar s = new System.Globalization.PersianCalendar();
                DateTime dt = s.ToDateTime(Convert.ToInt32(txdatenow.Text.Substring(0, 4)), Convert.ToInt32(txdatenow.Text.Substring(5, 2)), Convert.ToInt32(txdatenow.Text.Substring(8, 2)), 0, 0, 0, 0);
                txdeadline.Text=dt.AddDays(15).ToShamsi().ToString();
            }
            catch
            {
                RtlMessageBox.Show("مشکلی در بار گذاری اطلاعات وجوددارد", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int shomarande =1;
        private void txviewindore_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = string.Format("{0:#,##0}", value);
            else
                textBox.Text = String.Empty;
        }

        private void txkhadamat_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = string.Format("{0:#,##0}", value);
            else
                textBox.Text = String.Empty;
        }
        //برای اینکه بفهمیم دفعه قبل چقدر بدهی داشنه است
        double sumbedehighabl = 0;
        
        //
        private void txsumpay_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = string.Format("{0:#,##0}", value);
            else
                textBox.Text = String.Empty;
        }
        double sumtotal = 0;
        private void btsubmit_Click(object sender, EventArgs e)
        {
            Calculate newcustumer = new Calculate();
            if (txunit.Text == null || txbedehi.Text == null || txbestankar.Text == null)
            {
                RtlMessageBox.Show("لطفا در پر کردن فیلد ها دقت کنید");
            }
            else if (newcustumer.CalculateCountMeter(double.Parse(txamountmeternow.Text),double.Parse(txamountmeterpast.Text)) <= 0)
            {
                RtlMessageBox.Show("محاسبه قبض با شماره کنتور فعلی قابل محاسبه نیست", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txamountmeternow.TextLength > 5 || txamountmeterpast.TextLength > 5)
            {
                RtlMessageBox.Show("شماره کنتور را به درستی وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> data = db.Company.GetAllCalcMoshtarakSum();
                        var filldatadgv = data.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                        {
                            //id = cl.First().Id,
                            //key = cl.First().Key,
                            //Name = cl.First().Name,
                            bedehi = cl.Sum(c => c.bedehi).ToString(),
                            paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                            //datesabt = cl.First().datesabt.Value.ToShamsi(),
                            //type = cl.First().type

                        }).ToList();

                        bool isbillpast = false, isfirst = false;
                        if (db.Company.GetByAmountPast(int.Parse(txcodeasli.Text)) != 0)
                        {
                            if (RtlMessageBox.Show($" آیا میخواهید قبض قبلی مشترک {txname.Text} به قبض فعلی اعمال شود ؟", "توجه", MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                isbillpast = true;

                                RtlMessageBox.Show("قبض قبلی به قبض فعلی باموفقیت اضافه شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            else
                            {
                                sumtotal = 0;
                                isbillpast = false;
                            }
                        }
                        double meter = newcustumer.CalculateCountMeter(double.Parse(txamountmeternow.Text), double.Parse(txamountmeterpast.Text));
                        double resultaccounting = newcustumer.Accounting(meter, int.Parse(txunit.Text.Replace("تومان", "")), int.Parse(txunittoup.Text.Replace("تومان", "")), int.Parse(txkhadamat.Text.Replace(",", "")), db.Company.GetByGhotre(), db.Company.GetBymetraz2(), int.Parse(db.Company.GetBynerkh3().ToString()),chAzad.Checked);
                       
                        txbaha.Text = newcustumer.Accounting(meter, int.Parse(txunit.Text.Replace("تومان", "")), int.Parse(txunittoup.Text.Replace("تومان", "")), 0, db.Company.GetByGhotre(), db.Company.GetBymetraz2(), int.Parse(db.Company.GetBynerkh3().ToString()),chAzad.Checked).ToString();
                        if (!chAzad.Checked)
                        {
                            Accounting a = new Accounting();
                            a.Acc(meter, int.Parse(txunit.Text.Replace("تومان", "")), int.Parse(txunittoup.Text.Replace("تومان", "")), int.Parse(txkhadamat.Text.Replace(",", "")), db.Company.GetByGhotre(), db.Company.GetBymetraz2(), int.Parse(db.Company.GetBynerkh3().ToString()));
                            txone.Text = a.Nerkh1.ToString();
                            txtwo.Text = a.Nerkh2.ToString();
                            double sumtype3 = (int.Parse(txbaha.Text.Replace(",", "")) - (a.Nerkh1 + a.Nerkh2));
                            if (sumtype3 < 0)
                            {
                                txthree.Text = "0";
                            }
                            else
                            {
                                txthree.Text = sumtype3.ToString();
                            }
                        }
                        else
                        {
                            txone.Text = "0";
                            txtwo.Text = "0";
                            txthree.Text = (resultaccounting-double.Parse(txkhadamat.Text.Replace("تومان","").Replace(",",""))).ToString();
                        }
                        txviewindore.Text = resultaccounting.ToString();
                        updatebill();
                        updatecalc(double.Parse(txviewindore.Text));
                        if (db.Company.GetByAmountPast(int.Parse(txcodeasli.Text)) == 0)
                        {

                            RtlMessageBox.Show("کنتور برای اولین بار ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txamountmeterpast.Text = txamountmeternow.Text;
                            isfirst = true;
                        }
                        else
                        {

                            RtlMessageBox.Show("اطلاعات با موفقیت ثبت و محاسبه شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txamountmeterpast.Text = txamountmeternow.Text;

                        }

                        txmetercount.Text = db.Company.AmountLevel(int.Parse(txcodeasli.Text)) + "متر مکعب";
                        double resfinaly = newcustumer.AcountingFinaly(resultaccounting, double.Parse(txbestankar.Text.Replace(",", "").Replace("تومان", "")), double.Parse(txbedehi.Text.Replace(",", "").Replace("تومان", "")));
                        //double resfinalybedehi = newcustumer.AcountingFinalyBedehi(resultaccounting, );

                        //bool flag = false;
                        //int flag1 = 0;
                        //sumbedehighabl = db.Company.GetByBedehi(int.Parse(txcodeasli.Text));
                        if (isfirst)
                        {

                            Tb_Receipt_calc bedehi = new Tb_Receipt_calc()
                            {
                                Id = int.Parse(txcodeasli.Text),
                                bedehi = int.Parse(resfinaly.ToString()),
                                datesabt = DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdatenow.Text)),
                                paradakhti = 0,
                                Name = txname.Text,
                                type = ""
                            };
                            db.Company.InsertRecieptCalc(bedehi);
                            db.Save();
                            Tb_Debt debt = new Tb_Debt()
                            {
                                Best = 0,
                                Debt = resfinaly*-1,
                                ID = int.Parse(txcodeasli.Text)
                            };
                            db.Company.UpadateDebt(debt);
                            db.Save();
                        }
                        sumbedehighabl = db.Company.GetByBedehi(int.Parse(txcodeasli.Text));
                             if(resfinaly>0)
                            {
                                if (isbillpast)
                                {
                                    Tb_Receipt_calc isbedehi = new Tb_Receipt_calc()
                                    {
                                        Id = int.Parse(txcodeasli.Text),
                                        bedehi =int.Parse(resultaccounting.ToString()),
                                        datesabt = DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdatenow.Text)),
                                        paradakhti = 0,
                                        Name = txname.Text,
                                        type = "بدهکار"
                                    };
                                    db.Company.InsertRecieptCalc(isbedehi);
                                    db.Save();
                                }
                                List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> list1 = db.Company.GetAllCalcMoshtarakSum();
                                var fillone = list1.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                                {
                                    //id = cl.First().Id,
                                    //key = cl.First().Key,
                                    //Name = cl.First().Name,
                                    bedehi = cl.Sum(c => c.bedehi).ToString(),
                                    paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                                    //datesabt = cl.First().datesabt.Value.ToShamsi(),
                                    //type = cl.First().type

                                }).ToList();
                                Tb_Debt debt = new Tb_Debt()
                                {
                                    Best = fillone.Sum(d => long.Parse(d.paradakhti)),
                                    Debt = fillone.Sum(b=>long.Parse(b.bedehi))*-1,
                                    ID = int.Parse(txcodeasli.Text)
                                };
                                db.Company.UpadateDebt(debt);
                                db.Save();
                          
                            txsumpay.Text = (resfinaly).ToString();
                            //double sumbedehipas = (db.Company.GetByBedehi(int.Parse(txcodeasli.Text)) + db.Company.GetByBestankar(int.Parse(txcodeasli.Text)))*-1;
                            //txbedehipast.Text = sumbedehipas.ToString();

   
                        }
                             else if(resfinaly<0)
                            {
                           
                            Tb_Receipt_calc isbedehi = new Tb_Receipt_calc()
                                    {
                                        Id = int.Parse(txcodeasli.Text),
                                        bedehi = int.Parse(resultaccounting.ToString()),
                                       datesabt = DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdatenow.Text)),
                                        paradakhti = 0,
                                        Name = txname.Text,
                                        type = "طلبکار"
                                    };
                                    db.Company.InsertRecieptCalc(isbedehi);
                                    db.Save();
     
                                List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> list1 = db.Company.GetAllCalcMoshtarakSum();
                                var fillone = list1.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                                {
                                    //id = cl.First().Id,
                                    //key = cl.First().Key,
                                    //Name = cl.First().Name,
                                    bedehi = cl.Sum(c => c.bedehi).ToString(),
                                    paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                                    //datesabt = cl.First().datesabt.Value.ToShamsi(),
                                    //type = cl.First().type

                                }).ToList();
                                Tb_Debt debt = new Tb_Debt()
                                {
                                    Best = fillone.Sum(c =>long.Parse(c.paradakhti)),
                                    Debt = fillone.Sum(c => long.Parse(c.bedehi))*-1,
                                    ID = int.Parse(txcodeasli.Text)
                                };
                                db.Company.UpadateDebt(debt);
                                db.Save();
                                //txbedehi.Text = (db.Company.GetByBedehi(int.Parse(txcodeasli.Text)) * -1).ToString() + "تومان";
                                //txbestankar.Text = db.Company.GetByBestankar(int.Parse(txcodeasli.Text)).ToString() + "تومان";
                                txsumpay.Text = "0";
                            double sumbedehipas = (db.Company.GetByBedehi(int.Parse(txcodeasli.Text)) + db.Company.GetByBestankar(int.Parse(txcodeasli.Text)));
                            txbedehipast.Text = sumbedehipas.ToString();
                            RtlMessageBox.Show("باتوجه به اینکه مبلغ بستانکاری از مبلغ کلی قبض بیشتر است مانده بستانکاری محاسبه شده و در قبض های بعدی قابل اعمال است قبض فوق نیز صفر تومان میباشد", "هشدارمهم", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                             else if(resfinaly==0)
                        {
                            Tb_Receipt_calc isbedehi = new Tb_Receipt_calc()
                            {
                                Id = int.Parse(txcodeasli.Text),
                                bedehi =int.Parse(resultaccounting.ToString()),
                                datesabt = DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdatenow.Text)),
                                paradakhti = 0,
                                Name = txname.Text,
                                type = ""
                            };
                            db.Company.InsertRecieptCalc(isbedehi);
                            db.Save();

                            List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> list1 = db.Company.GetAllCalcMoshtarakSum();
                            var fillone = list1.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                            {
                                //id = cl.First().Id,
                                //key = cl.First().Key,
                                //Name = cl.First().Name,
                                bedehi = cl.Sum(c => c.bedehi).ToString(),
                                paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                                //datesabt = cl.First().datesabt.Value.ToShamsi(),
                                //type = cl.First().type

                            }).ToList();
                            Tb_Debt debt = new Tb_Debt()
                            {
                                Best = fillone.Sum(c => long.Parse(c.paradakhti)),
                                Debt = fillone.Sum(c => long.Parse(c.bedehi)) * -1,
                                ID = int.Parse(txcodeasli.Text)
                            };
                            db.Company.UpadateDebt(debt);
                            db.Save();
                            //txbedehi.Text = (db.Company.GetByBedehi(int.Parse(txcodeasli.Text)) * -1).ToString() + "تومان";
                            //txbestankar.Text = db.Company.GetByBestankar(int.Parse(txcodeasli.Text)).ToString() + "تومان";
                            txsumpay.Text = (resfinaly * -1).ToString();
                            //txbedehipast.Text = fillone.Sum(u => long.Parse(u.bedehi)).ToString();
                        }
                            //if (filldatadgv.Count == 0)
                            //        sumtotal = 0;
                            //    else
                            //     sumtotal = double.Parse(filldatadgv.Sum(d => long.Parse(d.bedehi)).ToString());

                            //}
                            //if (resfinaly < 0&&db.Company.GetByBestankar(int.Parse(txcodeasli.Text))!=0)
                            //{
                            //    flag1++;
                            //}
                            //else if(resfinaly > 0&& db.Company.GetByBedehi(int.Parse(txcodeasli.Text)) <= 0)
                            //{
                            //    List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> list1 = db.Company.GetAllCalcMoshtarakSum();
                            //    var fillone = list1.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                            //    {
                            //        //id = cl.First().Id,
                            //        //key = cl.First().Key,
                            //        //Name = cl.First().Name,
                            //        bedehi = cl.Sum(c => c.bedehi).ToString(),
                            //        paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                            //        //datesabt = cl.First().datesabt.Value.ToShamsi(),
                            //        //type = cl.First().type

                            //    }).ToList();
                            //    Tb_Debt debt = new Tb_Debt()
                            //    {
                            //        Best = fillone.Sum(d => long.Parse(d.paradakhti)),
                            //        Debt = fillone.Sum(d => long.Parse(d.bedehi)) * -1,
                            //        ID = int.Parse(txcodeasli.Text)
                            //    };
                            //    db.Company.UpadateDebt(debt);
                            //    db.Save();
                            //    txbedehi.Text = (db.Company.GetByBedehi(int.Parse(txcodeasli.Text)) * -1).ToString() + "تومان";
                            //    txbestankar.Text = db.Company.GetByBestankar(int.Parse(txcodeasli.Text)).ToString() + "تومان";
                            //    txsumpay.Text =(resfinaly+(sumbedehighabl*-1)).ToString();
                            //}
                            //else   if (resfinalybedehi > 0&&db.Company.GetByBedehi(int.Parse(txcodeasli.Text))!=0&&sumtotal!=0)
                            //{

                            //    flag = true;    
                            //    resultaccounting = resfinalybedehi;

                            //}
                            //else
                            //{
                            //    txsumpay.Text = resfinaly.ToString();
                            //    List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> list1 = db.Company.GetAllCalcMoshtarakSum();
                            //    var fillone = list1.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                            //    {
                            //        //id = cl.First().Id,
                            //        //key = cl.First().Key,
                            //        //Name = cl.First().Name,
                            //        bedehi = cl.Sum(c => c.bedehi).ToString(),
                            //        paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                            //        //datesabt = cl.First().datesabt.Value.ToShamsi(),
                            //        //type = cl.First().type

                            //    }).ToList();
                            //    Tb_Debt debt = new Tb_Debt()
                            //    {

                            //        Best = fillone.Sum(d => long.Parse(d.paradakhti)),
                            //        Debt = fillone.Sum(d => long.Parse(d.bedehi))* -1,
                            //        ID = int.Parse(txcodeasli.Text)
                            //    };
                            //    db.Company.UpadateDebt(debt);
                            //    db.Save();
                            //    txbedehi.Text = filldatadgv.Sum(d => long.Parse(d.bedehi)).ToString() + "تومان";
                            //    txbestankar.Text = filldatadgv.Sum(d => long.Parse(d.paradakhti)).ToString() + "تومان";
                            //}
                            //if(flag==true)
                            //{
                            //    txsumpay.Text = resfinalybedehi.ToString();
                            //    List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> list1 = db.Company.GetAllCalcMoshtarakSum();
                            //    var fillone = list1.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                            //    {
                            //        //id = cl.First().Id,
                            //        //key = cl.First().Key,
                            //        //Name = cl.First().Name,
                            //        bedehi = cl.Sum(c => c.bedehi).ToString(),
                            //        paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                            //        //datesabt = cl.First().datesabt.Value.ToShamsi(),
                            //        //type = cl.First().type

                            //    }).ToList();
                            //    Tb_Debt debt = new Tb_Debt()
                            //    {
                            //        Best = double.Parse(fillone.First().paradakhti),
                            //        Debt = double.Parse(fillone.First().bedehi) * -1,
                            //        ID = int.Parse(txcodeasli.Text)
                            //    };
                            //    db.Company.UpadateDebt(debt);
                            //    db.Save();
                            //    List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> list2 = db.Company.GetAllCalcMoshtarakSum();
                            //    var res = list2.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                            //    {
                            //        //id = cl.First().Id,
                            //        //key = cl.First().Key,
                            //        //Name = cl.First().Name,
                            //        bedehi = cl.Sum(c => c.bedehi).ToString(),
                            //        paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                            //        //datesabt = cl.First().datesabt.Value.ToShamsi(),
                            //        //type = cl.First().type

                            //    }).ToList();
                            //    txbedehi.Text = res.Sum(d => long.Parse(d.bedehi)).ToString() + "تومان";
                            //    txbestankar.Text = res.Sum(d => long.Parse(d.paradakhti)).ToString() + "تومان";
                            //}

                            //if (flag1 == 1)
                            //{
                            //    //txsumpay.Text = resfinaly.ToString();

                            //    txsumpay.Text = "0";

                            //    Tb_Receipt_calc rescalc = new Tb_Receipt_calc()
                            //    {
                            //        bedehi=int.Parse((resfinaly*-1).ToString()),
                            //        datesabt = DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdatenow.Text)),
                            //        Id=int.Parse(txcodeasli.Text),
                            //        Name=txname.Text,
                            //        paradakhti=0,
                            //        type="طلبکار"
                            //    };
                            //    db.Company.InsertRecieptCalc(rescalc);
                            //    db.Save();
                            //    List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> list2 = db.Company.GetAllCalcMoshtarakSum();
                            //    var res = list2.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                            //    {
                            //        //id = cl.First().Id,
                            //        //key = cl.First().Key,
                            //        //Name = cl.First().Name,
                            //        bedehi = cl.Sum(c => c.bedehi).ToString(),
                            //        paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                            //        //datesabt = cl.First().datesabt.Value.ToShamsi(),
                            //        //type = cl.First().type

                            //    }).ToList();
                            //    Tb_Debt debt = new Tb_Debt()
                            //    {
                            //        Best = res.Sum(d => long.Parse(d.paradakhti)),
                            //        Debt = res.Sum(d => long.Parse(d.bedehi)*-1),
                            //        ID = int.Parse(txcodeasli.Text)
                            //    };
                            //    db.Company.UpadateDebt(debt);
                            //    db.Save();
                            //    txbedehi.Text = "0"+"تومان";
                            //    txbestankar.Text = (res.Sum(d => long.Parse(d.paradakhti))- res.Sum(d => long.Parse(d.bedehi))).ToString() + "تومان";
                            //    RtlMessageBox.Show("باتوجه به اینکه مبلغ بستانکاری از مبلغ کلی قبض بیشتر است مانده بستانکاری محاسبه شده و در قبض های بعدی قابل اعمال است قبض فوق نیز صفر تومان میباشد", "هشدارمهم", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            //}


                            txletercurency.Text = NumberToWord.PersianConvertNumberToWord(txsumpay.Text.Replace(",", "")) + "تومان";
                            InsertReciept();
                        List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> list2 = db.Company.GetAllCalcMoshtarakSum();
                        var query = list2.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                        {
                            //id = cl.First().Id,
                            //key = cl.First().Key,
                            //Name = cl.First().Name,
                            bedehi = cl.Sum(c => c.bedehi).ToString(),
                            paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                            //datesabt = cl.First().datesabt.Value.ToShamsi(),
                            //type = cl.First().type

                        }).ToList();
                        double bedehi2 = 0, bestankar = 0;
                        bedehi2 = double.Parse(query.Sum(d => long.Parse(d.bedehi)).ToString());
                        bestankar = double.Parse(query.Sum(d => long.Parse(d.paradakhti)).ToString());
                        double sum = bestankar - bedehi2;
                        if (sum > 0)
                        {
                            bestankar = sum;
                            bedehi2 = 0;
                        }
                        else if (sum < 0)
                        {
                            bestankar = 0;
                            bedehi2 = sum * -1;
                        }
                        else if (sum == 0)
                        {
                            bestankar = 0;
                            bedehi2 = 0;
                        }
                        txbedehipast.Text = bedehi2.ToString();
                        txbedehi.Text = bedehi2.ToString() + "تومان";
                        txbestankar.Text = bestankar.ToString() + "تومان";
                        //List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> list3 = db.Company.GetAllCalcMoshtarakSum();
                        //var res2 = list3.Where(id => id.Id == db.Company.Getbysubbyname(txname.Text)).GroupBy(id => id).Select(cl => new
                        //{
                        //    //id = cl.First().Id,
                        //    //key = cl.First().Key,
                        //    //Name = cl.First().Name,
                        //    bedehi = cl.Sum(c => c.bedehi).ToString(),
                        //    paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                        //    //datesabt = cl.First().datesabt.Value.ToShamsi(),
                        //    //type = cl.First().type

                        //}).ToList();
                        //if (filldatadgv.Count != 0)
                        //    txbedehipast.Text = double.Parse(res2.Sum(d => long.Parse(d.bedehi)).ToString()) + "تومان";
                        //else
                        //    txbedehipast.Text = "0" + "تومان";
                    }
                    
                }
                catch
                {
                    RtlMessageBox.Show("خطایی وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
        }
        }
        public void InsertReciept()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                //double best, bed;
                //double isdebtbest = double.Parse(txsumpay.Text.Replace(",", "")) - double.Parse(txviewindore.Text.Replace(",", ""));
                //if(isdebtbest<0)
                //{
                //    bed = 0;
                //    best =double.Parse(txbestankar.Text.Replace("تومان",""));
                //}
                //else
                //{
                //    bed = isdebtbest;
                //    best =0;
                //}
                Tb_Receipt res = new Tb_Receipt()
                {
                    Id = db.Company.GetBillId(0),
                    SubaScribId = int.Parse(txcodeasli.Text),
                    SubName = txname.Text,
                    Abounman = double.Parse(txabunman.Text.Replace("تومان", "")),
                    PublicWork = double.Parse(txnerkh.Text.Replace("تومان", "")),
                    CurencyPay = txviewindore.Text,
                    AmountLevel = int.Parse((db.Company.AmountLevel(int.Parse(txcodeasli.Text))).ToString()),
                    DateNow = DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdatenow.Text)),
                    DatePast = DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdate.Text)),
                    DeadlineCurency = txdeadline.Text,
                    Debt = double.Parse(txbedehi.Text.Replace("تومان", "").Replace(",", "").ToString()),
                    Ghotre = db.Company.GetByGhotre(),
                    HesabNumber = txhesab.Text,
                    LeterCurency = txletercurency.Text,
                    Maliat =double.Parse(txunittoup.Text.Replace("تومان","")),
                    MeterNow = double.Parse(txamountmeternow.Text),
                    MeterPast = db.Company.GetByAmountPast(int.Parse(txcodeasli.Text)),
                    NumberCurency = double.Parse(txsumpay.Text.Replace(",", "")),
                    PelakNumber = int.Parse(txpelack.Text),
                    Penalty =txone.Text,
                    Curency = int.Parse(txnerkh3.Text.Replace("تومان", "")),
                    PhoneNumber = txphone.Text,
                    DateShamsi = txdatenow.Text,
                    Bestan =double.Parse(txbestankar.Text.Replace("تومان","").Replace(",","").ToString()),
                    CurencyinDore = double.Parse(txbaha.Text.Replace(",", "")),
                    Adress = txadress.Text,
                    FatherName = txfathername.Text,
                    Shenasname=int.Parse(txshenasname.Text),
                    codemeli=txsubscribid.Text,
                    pay2=txtwo.Text,
                    pay3=txthree.Text
                    
                };
                Tb_CountBill count = new Tb_CountBill()
                {
                    ID = 0,
                    Count = db.Company.GetBillId(0) + 1
                };
                bool iscount = db.Company.UpdateCountBill(count);
                bool isres = db.Company.InsertReciept(res);
                if (isres && iscount)
                {
                    db.Save();
                }

            }
        }
        public void updatebill()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                Tb_Bill bill = new Tb_Bill()
                {
                    BillId = int.Parse(txcodeasli.Text),
                    Describtion = txdescrib.Text,
                    MeterNumberPast = double.Parse(txamountmeterpast.Text),
                    MeterNumberNow = double.Parse(txamountmeternow.Text),
                    SeenDate = DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdatenow.Text)),
                    SubScribCode = int.Parse(txcodeasli.Text),
                    NameCompany = txname.Text,
                    SeenDateShamsi = txdatenow.Text
                };
                db.Company.UpadateBill(bill);
                db.Save();
                }
        }
        public void updatecalc(double result)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                Tb_Calculate calculate = new Tb_Calculate()
                {
                    Bedehi = double.Parse(txbedehi.Text.Replace("تومان", "")) * -1,
                    Bestankar = double.Parse(txbestankar.Text.Replace("تومان", "")),
                    SumMaliat = double.Parse(txkhadamat.Text.Replace(",", "")),
                    CalculateId = int.Parse(txcodeasli.Text),
                    SubscribCode = int.Parse(txcodeasli.Text),
                    UnitPay = double.Parse(txunit.Text.Replace("تومان", "")),
                    SumTotal = result
                };
                db.Company.UpadateCalculate(calculate);
                db.Save();
            }
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            if (shomarande <= count - 1)
            {

                txcodeasli.Text = SelectedItems[shomarande].companyid.ToString();
                txdate.Text = SelectedItems[shomarande].date.ToString();
                txname.Text = SelectedItems[shomarande].name.ToString();
                txnerkh.Text = SelectedItems[shomarande].nerkh.ToString() + " تومان";
                txdescrib.Text = SelectedItems[shomarande].describ.ToString();
                txbestankar.Text = SelectedItems[shomarande].bestankar.ToString();
                txbedehi.Text = SelectedItems[shomarande].bedehi.ToString();
                txamountmeternow.Text = SelectedItems[shomarande].meternow.ToString();
                txamountmeterpast.Text = SelectedItems[shomarande].meterpast.ToString();
                txadress.Text = SelectedItems[shomarande].adress.ToString();
                txkhadamat.Text = (int.Parse(txnerkh.Text.Replace("تومان", "")) + int.Parse(txabunman.Text.Replace("تومان", ""))).ToString();
                txpelack.Text = SelectedItems[shomarande].Pelak.ToString();
                txphone.Text = SelectedItems[shomarande].phonenumber;
                txfathername.Text = SelectedItems[shomarande].fathername;
                txshenasname.Text = SelectedItems[shomarande].shenasname.ToString();
                txsubscribid.Text = SelectedItems[shomarande].codemeli.ToString();
                using (UnitOfWork db = new UnitOfWork())
                {
                    txidbill.Text = db.Company.GetBillId(0).ToString();
                }
                if (txamountmeterpast.Text == "0")
                {
                    txamountmeterpast.ReadOnly = false;
                }
                else
                {
                    txamountmeterpast.ReadOnly = true;
                }

            }
            else
            {
                RtlMessageBox.Show("رکوردی برای نمایش وجود ندارد");
                //btnsubmit.Enabled = false;
                this.Close();
            }
            shomarande++;
        }
        public void AddToCalcItem()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                //ItemsDebt.Add(new CalcDebt { Bed = db.Company.GetByBedehi(int.Parse(txcodeasli.Text))*-1, Bes = db.Company.GetByBestankar(int.Parse(txcodeasli.Text)), Sum = db.Company.AmountDebt(int.Parse(txcodeasli.Text)),Id=int.Parse(txcodeasli.Text)});
            }
        }
    
        private void btncalculate_Click(object sender, EventArgs e)
        {
            AddToCalcItem();
            Frm_Calculator f = new Frm_Calculator();
            f.ItemsDebt = ItemsDebt;
            if(f.ShowDialog()==DialogResult.Cancel)
            {
                UnitOfWork db = new UnitOfWork();
                txbedehi.Text = db.Company.GetByBedehi(int.Parse(txcodeasli.Text))*-1 + "تومان";
                txbestankar.Text = db.Company.GetByBestankar(int.Parse(txcodeasli.Text)) + "تومان";
                ItemsDebt.RemoveAll(fi => fi.Id == ItemsDebt[0].Id);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbedehipast_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = string.Format("{0:#,##0}", value);
            else
                textBox.Text = String.Empty;
        }

        private void txbaha_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = string.Format("{0:#,##0}", value);
            else
                textBox.Text = String.Empty;
        }

        private void Txbedehipast_TextChanged_1(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = string.Format("{0:#,##0}", value);
            else
                textBox.Text = String.Empty;
        }

        private void txone_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = string.Format("{0:#,##0}", value);
            else
                textBox.Text = String.Empty;
        }

        private void txtwo_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Double value;
            if (Double.TryParse(textBox.Text, out value))
                textBox.Text = string.Format("{0:#,##0}", value);
            else
                textBox.Text = String.Empty;
        }

        private void txthree_TextChanged(object sender, EventArgs e)
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
