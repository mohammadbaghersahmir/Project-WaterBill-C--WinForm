using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterBill_Utility.Convertor;
using WaterBill_DataLayer.Contex;
using WaterBill_ViewModel;
using WaterBill_DataLayer.EfModel;
using System.Data.OleDb;

namespace WaterBill.Forms
{
    public partial class Frm_Bill : Form
    {
        public Frm_Bill()
        {
            InitializeComponent();
        }

        private void txidbill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))//a

                e.Handled = true;//b
        }

        private void txamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 46)//backspace&.
            { return; }
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }
        public bool isexits = true;
        private void Frm_Bill_Load(object sender, EventArgs e)
        {
            ViewDataGried();
            //FillInTxt();


            //Somewhere in code initialize datagridview

            //dgvbill.Rows[0].Cells[1].Value = true;

        }
        public void ViewDataGried()
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
            {
                    dgvbill.AutoGenerateColumns = false;
                    dgvbill.DataSource= db.Company.GetAllBill();
                    //dgvbill.Rows.Clear();
                    //foreach (var Rows in RowsInDataGrid)
                    //{
                    //    dgvbill.Rows.Add(Rows.SubScribCode, chselect.ValueType, Rows.NameCompany, Rows.MeterNumberNow, Rows.SeenDate.ToShamsi());
                    //}
                    //dgvbill.DataSource = db.Company.GetAllBill();
                    foreach (DataGridViewRow row in dgvbill.Rows)
                    {
                    if (Convert.ToInt32(row.Cells[3].Value) == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                    else if (int.Parse(row.Cells[3].Value.ToString()) != 0 && int.Parse(DateTime.Now.ToShamsi().ToString().Replace("/", "")) != int.Parse(row.Cells[4].Value.ToString().Replace("/", "")))
                    {

                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }

                }

                 }
              }
                catch
                {
                    RtlMessageBox.Show("خطایی وجود دارد ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                }
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnnewbill_Click(object sender, EventArgs e)
        {

        }

        private void btnnewbill_Click_1(object sender, EventArgs e)
        {

        }
        private void btnsubmitt_Click(object sender, EventArgs e)
        {
        }
       
        private void btnsubmitt_Click_1(object sender, EventArgs e)
        {
           
        }
        //if (dgvbill.CurrentRow != null)
        //{
        //    string name = dgvbill.CurrentRow.Cells[2].Value.ToString();
        //    if (RtlMessageBox.Show("آیا میخواهید شماره کنتور و تاریخ از فایل اکسل خوانده شود؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        {
        //            Frm_InformationExel exel = new Frm_InformationExel();
        //            exel.CompanyId = int.Parse(dgvbill.CurrentRow.Cells[0].Value.ToString());
        //            exel.ShowDialog();
        //        }

        //    }
        //    else
        //    {
        //        RtlMessageBox.Show("شماره کنتور را در فیلد مربوطه وارد کنید");
        //        txamountmeterpast.ReadOnly = false;
        //    }
        //}
        //public void FillInTxt()
        // {
        //     using (UnitOfWork db = new UnitOfWork())
        //     {

        //         if (int.Parse(dgvbill.CurrentRow.Cells[3].Value.ToString()) == 0)
        //         {
        //             txamountmeterpast.ReadOnly = false;
        //             txamountmeterpast.Text = dgvbill.CurrentRow.Cells[3].Value.ToString();
        //             txamountmeternow.Text = dgvbill.CurrentRow.Cells[3].Value.ToString();
        //         }
        //         else
        //         {
        //             txamountmeterpast.ReadOnly = true;
        //             txamountmeterpast.Text = dgvbill.CurrentRow.Cells[3].Value.ToString();
        //             txamountmeternow.Text = dgvbill.CurrentRow.Cells[3].Value.ToString();
        //         }
        //         txcodeasli.Text = dgvbill.CurrentRow.Cells[0].Value.ToString();
        //         txname.Text = dgvbill.CurrentRow.Cells[2].Value.ToString();
        //         txadress.Text = db.Company.GetByAddres(int.Parse(dgvbill.CurrentRow.Cells[0].Value.ToString()));
        //         txidbill.Text=Convert.ToInt16(dgvbill.CurrentCell.RowIndex+1).ToString();
        //         txdate.Text = dgvbill.CurrentRow.Cells[4].Value.ToString();
        //         txdatenow.Text = DateTime.Now.ToShamsi();
        //         string nametype = db.Company.GetByTypePublic(int.Parse(dgvbill.CurrentRow.Cells[0].Value.ToString()));
        //         try
        //         {
        //             txdescrib.Text = db.Company.GetByDescrib(int.Parse(dgvbill.CurrentRow.Cells[0].Value.ToString()));
        //         }
        //         catch
        //         {
        //             txdescrib.Text = "";
        //         }
        //         txnerkh.Text = db.Company.GetByCurencyPublic(nametype).ToString()+"تومان";
        //         try
        //         {
        //             txbedehi.Text = (db.Company.GetByBedehi(int.Parse(dgvbill.CurrentRow.Cells[0].Value.ToString()))*-1).ToString();
        //             txbestankar.Text =db.Company.GetByBestankar(int.Parse(dgvbill.CurrentRow.Cells[0].Value.ToString())).ToString();
        //         }
        //         catch
        //         {
        //             txbedehi.Text = "0";
        //             txbestankar.Text = "0";
        //         }
        //         var resultmaliat = db.Company.GetAllOptions();
        //         double sumall = 0;
        //         foreach (var item in resultmaliat)
        //         {
        //             txabunman.Text =item.Abunman.ToString()+"تومان";
        //             txghotre.Text = item.GhotreEnsheab.ToString();
        //             txhesab.Text = item.HesabPhone.ToString();
        //             txmaliat.Text = item.Maliat.ToString() + " تومان";
        //             sumall = item.Maliat+ item.PublicWork + item.Abunman;
        //             txunit.Text = item.CurencyOfUnit.ToString() + " تومان";
        //             txunittoup.Text = item.CurencyOfUnitToUp.ToString() + " تومان";
        //         }
        //         txkhadamat.Text = (sumall + int.Parse(txnerkh.Text.ToString().Replace("تومان",""))).ToString()+" تومان";
        //      }
        // }



        private void dgvbill_Click(object sender, EventArgs e)
        {
           
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[1];
            if (ch1.Value == null)
                ch1.Value = false;
            switch (ch1.Value.ToString())
            {
                case "False":
                    break;
            }

        }
       
        private void btncalc_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvbill_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.State & DataGridViewElementStates.Selected) != 0)
            {
                e.CellStyle.SelectionBackColor = Color.MediumBlue;
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            ViewDataGried();
           
        }

        private void txbedehi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 46)//backspace&.
            { return; }
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }

        private void txbestankar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 46)//backspace&.
            { return; }
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }

        private void txunit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 46)//backspace&.
            { return; }
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }
     public    List<Rec> SelectedItems = new List<Rec>();
       
        private void btnsms_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool checkSate = false;
            for (int index = 0; index < dgvbill.RowCount; index++)
            {

                DataGridViewCheckBoxCell chk = dgvbill["chselect", index] as DataGridViewCheckBoxCell;
                if (chk != null)

                    if (chk.Value != null)
                    {
                        checkSate = (bool)chk.Value;
                        if (checkSate)
                        {
                            UnitOfWork db = new UnitOfWork();
                            string describ = "";
                            string nametype = db.Company.GetByTypePublic(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString()));
                            try
                            {
                                describ = db.Company.GetByDescrib(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString()));
                            }
                            catch
                            {
                                describ = "";
                            }
                            var resultmaliat = db.Company.GetAllOptions();
                            double abunma = 0,maliat=0,unit=0,unitup=0,ghotr=0;
                            string hesab = "";    
                            foreach (var item in resultmaliat)
                            {
                                abunma = item.PublicWork;
                                maliat = item.Maliat;
                                unit = item.CurencuOfUnit;
                                unitup = item.Abunman;
                                hesab = item.HesabPhone;
                                ghotr = item.GhotreEnsheab;
                            }
                            //محاسبه بدهی و بستانکاری قبلی
                                List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> data = db.Company.GetAllCalcMoshtarakSum();
                                var filldatadgv = data.Where(id => id.Id == db.Company.Getbysubbyname(dgvbill.Rows[index].Cells[2].Value.ToString())).GroupBy(id => id).Select(cl => new
                                {
                                    //id = cl.First().Id,
                                    //key = cl.First().Key,
                                    //Name = cl.First().Name,
                                    bedehi = cl.Sum(c => c.bedehi).ToString(),
                                    paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                                    //datesabt = cl.First().datesabt.Value.ToShamsi(),
                                    //type = cl.First().type
                                }).ToList();
                            double bedehi = 0, bestankar = 0;
                            if(filldatadgv.Count==0)
                            {
                                bedehi = 0;
                                bestankar = 0;
                            }
                            else
                            {
                                bedehi = double.Parse(filldatadgv.Sum(d => long.Parse(d.bedehi)).ToString());
                                bestankar = double.Parse(filldatadgv.Sum(d => long.Parse(d.paradakhti)).ToString());
                                //if (bestankar < 0)
                                //    bestankar = 0;
                                //if (bedehi < 0)
                                //    bedehi = 0;
                                double sum = bestankar - bedehi;
                                if(sum>0)
                                {
                                    bestankar = sum;
                                    bedehi = 0;
                                }
                                else if(sum<0)
                                {
                                    bestankar = 0;
                                    bedehi = sum*-1;
                                }
                                else if(sum==0)
                                {
                                    bestankar = 0;
                                    bedehi = 0;
                                }
                                    
                            }

                                //
                                SelectedItems.Add(new Rec() { companyid = int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString()), name = dgvbill.Rows[index].Cells[2].Value.ToString(), date = db.Company.GetbyPastDate(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString())).ToShamsi().Replace("-","/"), istru = true, adress = db.Company.GetByAddres(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString())), bedehi =bedehi, bestankar = bestankar, nerkh = db.Company.GetByCurencyPublic(nametype), meternow = db.Company.GetByAmountNow(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString())), describ = describ, meterpast = db.Company.GetByAmountNow(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString())),
                                phonenumber = db.Company.GetByPhoneNumber(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString()))

                            ,
                                abunman = abunma, ghotre = ghotr, hesab = hesab, maliat = maliat, unit = unit, unitofup = unitup, summaliat = db.Company.GetBySumTotalMaliat(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString())), Pelak = db.Company.GetByPelak(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString()))
                            ,fathername=db.Company.GetbyFathername(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString())),shenasname=db.Company.Getbyshenasname(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString())),codemeli=db.Company.GetbyCodemeli(int.Parse(dgvbill.Rows[index].Cells[0].Value.ToString()))
                            } 
                             );
                            count++;
                        }
                    }
            }
           
            Frm_SelectAll f = new Frm_SelectAll();
            f.count = count;
            f.SelectedItems = SelectedItems;
            if (checkSate!=true)
                RtlMessageBox.Show("یک سطر را انتخاب کنید","هشدار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                if (f.ShowDialog() == DialogResult.Cancel)
                {
                    ViewDataGried();
                    SelectedItems.RemoveAll(s => s.istru == true);
                }
            }
        }

        private void dgvbill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dgvbill.Rows[dgvbill.CurrentRow.Index].Cells[1];
            if (ch1.Value == null)

                ch1.Value = false;

            switch (ch1.Value.ToString())

            {
                case "True":
                    ch1.Value = false;
                    break;

                case "False":

                    ch1.Value = true;

                    break;

            }
        }
      
        private void dgvbill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnchekall_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dgvbill.Rows.Count ; i++)
            {

                
                if(Convert.ToBoolean(dgvbill.Rows[i].Cells[1].Value)== false)
                {
                    dgvbill.Rows[i].Cells[1].Value = true;
                }
                else
                    dgvbill.Rows[i].Cells[1].Value = false;
            }
        }
     
        private void txsearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvbill.DataSource = db.Company.GetAllBillFilter(txsearch.Text);
                if (txsearch.TextLength == 0)
                {
                    ViewDataGried();
                }
            }
        }

        private void toolStrip1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Frm_EditBill f = new Frm_EditBill();
            if (dgvbill.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    f.name = dgvbill.CurrentRow.Cells[2].Value.ToString();
                    f.sub = dgvbill.CurrentRow.Cells[0].Value.ToString();
                    f.mpast = db.Company.GetByAmountPast(int.Parse(dgvbill.CurrentRow.Cells[0].Value.ToString())).ToString();
                    f.mnow = db.Company.GetByMetercountinBill(int.Parse(dgvbill.CurrentRow.Cells[0].Value.ToString())).ToString();
                    f.dpast = dgvbill.CurrentRow.Cells[4].Value.ToString();
                    f.dnow = DateAndTimeConvertor.ToShamsi(DateTime.Now);
                    f.txdescrib = db.Company.GetByDescrib(int.Parse(dgvbill.CurrentRow.Cells[0].Value.ToString())).ToString();  
                }
               if(f.ShowDialog()==DialogResult.Cancel)

                {
                    ViewDataGried();
                }
            }
            else
                RtlMessageBox.Show("شرکت یا مشترک را انتخاب کنید");
        }
    }
}
