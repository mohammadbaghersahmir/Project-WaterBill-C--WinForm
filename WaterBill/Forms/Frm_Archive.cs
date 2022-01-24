using Stimulsoft.Report;
using Stimulsoft.Report.Components;
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
    public partial class Frm_Archive : Form
    {
        public Frm_Archive()
        {
            InitializeComponent();
        }
        public void Binde()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvarchive.AutoGenerateColumns = false;
                dgvarchive.DataSource = db.Company.GetAllReciept();
            }
        }
        public List<SmsList> ListSms = new List<SmsList>();
        public List<PrintList> ListPrint = new List<PrintList>();
        public List<DeleteList> listdelet = new List<DeleteList>();
        int count = 0;
        public void AddtoSmsList()
        {
            bool checkSate = false;
            for (int index = 0; index < dgvarchive.RowCount; index++)
            {
                //if(DateTime.Parse(dgvarchive.Rows[index].Cells[5].Value.ToString())==DateTime.Now)
                //{
                //    dgvarchive.Rows[index].Cells[1].Value = true;
                //}
                DataGridViewCheckBoxCell chk = dgvarchive["charchiv",index] as DataGridViewCheckBoxCell;
                if (chk != null)
                    if (chk.Value != null)
                    {
                        checkSate = (bool)chk.Value;
                        if (checkSate)
                        {
                            count++;
                            using (UnitOfWork db = new UnitOfWork())
                            {

                                ListSms.Add(new SmsList()
                                {
                                    curency = db.Company.GetbyCurencyinRecpeit(int.Parse(dgvarchive.Rows[index].Cells[23].Value.ToString())),
                                    phonenumber = db.Company.GetByPhoneNumber(int.Parse(dgvarchive.Rows[index].Cells[27].Value.ToString())),
                                    isremove = true,
                                    name = db.Company.GetbyNameinRecpiet(int.Parse(dgvarchive.Rows[index].Cells[27].Value.ToString())),
                                    datenow = dgvarchive.Rows[index].Cells[5].Value.ToString(),
                                    id=int.Parse(dgvarchive.Rows[index].Cells[27].Value.ToString())
                                }
                                );
                            }
                        }
                    }

            }
        }
        public void AddToPrint()
        {
            bool checkSate = false;
            int countprint = 0;
            for (int index = 0; index < dgvarchive.RowCount; index++)
            {

                DataGridViewCheckBoxCell chk = dgvarchive["charchiv", index] as DataGridViewCheckBoxCell;
                if (chk != null)
                    if (chk.Value != null)
                    {
                        checkSate = (bool)chk.Value;
                        if (checkSate)
                        {
                            countprint++;

                            using (UnitOfWork db = new UnitOfWork())
                            {

                                ListPrint.Add(new PrintList()
                                {
                                    curency = dgvarchive.Rows[index].Cells[30].Value.ToString(),
                                    isremov = true,
                                    name = db.Company.GetbyNameinRecpiet(int.Parse(dgvarchive.Rows[index].Cells[27].Value.ToString())),
                                    datenow = DateAndTimeConvertor.ToShamsi(DateTime.Parse(dgvarchive.Rows[index].Cells[21].Value.ToString())),
                                    curencypay = db.Company.GetbyCurencyPay(0).ToString(),
                                    amountlevel = dgvarchive.Rows[index].Cells[6].Value.ToString(),
                                    amountnow = dgvarchive.Rows[index].Cells[20].Value.ToString(),
                                    amountpast = dgvarchive.Rows[index].Cells[19].Value.ToString(),
                                    code = dgvarchive.Rows[index].Cells[2].Value.ToString(),
                                    debt = dgvarchive.Rows[index].Cells[10].Value.ToString(),
                                    ghabelpardakht = dgvarchive.Rows[index].Cells[8].Value.ToString(),
                                    ghotsre = dgvarchive.Rows[index].Cells[11].Value.ToString(),
                                    hesabnumber = dgvarchive.Rows[index].Cells[12].Value.ToString(),
                                    jarime = dgvarchive.Rows[index].Cells[13].Value.ToString(),
                                    khadamat = dgvarchive.Rows[index].Cells[14].Value.ToString(),
                                    maliat = dgvarchive.Rows[index].Cells[15].Value.ToString(),
                                    mohlat = dgvarchive.Rows[index].Cells[16].Value.ToString(),
                                    pelacknumber = int.Parse(dgvarchive.Rows[index].Cells[4].Value.ToString()),
                                    sodore = DateAndTimeConvertor.ToShamsi(DateTime.Parse(dgvarchive.Rows[index].Cells[21].Value.ToString())),
                                    curencydigit =dgvarchive.Rows[index].Cells[18].Value.ToString(),
                                    amount = dgvarchive.Rows[index].Cells[6].Value.ToString(),
                                    datepast = DateAndTimeConvertor.ToShamsi(DateTime.Parse(dgvarchive.Rows[index].Cells[9].Value.ToString())),
                                    best = dgvarchive.Rows[index].Cells[22].Value.ToString(),
                                    curencyindore = dgvarchive.Rows[index].Cells[24].Value.ToString(),
                                    fathername = dgvarchive.Rows[index].Cells[25].Value.ToString(),
                                    shenasname = dgvarchive.Rows[index].Cells[26].Value.ToString(),
                                    phonenumber = dgvarchive.Rows[index].Cells[17].Value.ToString(),
                                    pay2 = dgvarchive.Rows[index].Cells[28].Value.ToString(),
                                    pay3 = dgvarchive.Rows[index].Cells[29].Value.ToString(),
                                    curencyoftoup = db.Company.GetbyCurencyOfunit(0).ToString(),
                                    WaterAzad=db.OptionsRepository.GetById(1).HesabPhone,
                                    Cardname= db.OptionsRepository.GetById(3).HesabPhone
                                }
                                );
                            }
                        }
                    }
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("code");
            dt.Columns.Add("name");
            dt.Columns.Add("curency");
            dt.Columns.Add("datenow");
            dt.Columns.Add("amountpast");
            dt.Columns.Add("curencypay");
            dt.Columns.Add("amountlevel");
            dt.Columns.Add("amountnow");
            dt.Columns.Add("debt");
            dt.Columns.Add("bestan");
            dt.Columns.Add("ghabelpardakht");
            dt.Columns.Add("ghotsre");
            dt.Columns.Add("hesabnumber");
            dt.Columns.Add("jarime");
            dt.Columns.Add("khadamat");
            dt.Columns.Add("maliat");
            dt.Columns.Add("mohlat");
            dt.Columns.Add("pelacknumber");
            dt.Columns.Add("sodore");
            dt.Columns.Add("curencydigit");
            dt.Columns.Add("amount");
            dt.Columns.Add("datepast");
            dt.Columns.Add("curencyindore");
            dt.Columns.Add("fathername");
            dt.Columns.Add("shenasname");
            dt.Columns.Add("phonenumber");
            dt.Columns.Add("pay2");
            dt.Columns.Add("pay3");
            dt.Columns.Add("curencyoftoup");
            dt.Columns.Add("waterazad");
            dt.Columns.Add("cardname");
            for (int i =0; i <countprint; i++)
            {
                dt.Rows.Add(ListPrint[i].code,
                    ListPrint[i].name,
                    ListPrint[i].curency,
                    ListPrint[i].datenow,
                    ListPrint[i].amountpast,
                    ListPrint[i].curencypay,
                    ListPrint[i].amountlevel,
                    ListPrint[i].amountnow,
                    ListPrint[i].debt,
                    ListPrint[i].best,
                    ListPrint[i].ghabelpardakht,
                    ListPrint[i].ghotsre,
                    ListPrint[i].hesabnumber,
                    ListPrint[i].jarime,
                    ListPrint[i].khadamat,
                    ListPrint[i].maliat,
                    ListPrint[i].mohlat,
                    ListPrint[i].pelacknumber,
                    ListPrint[i].sodore,
                    ListPrint[i].curencydigit,
                    ListPrint[i].amount,
                    ListPrint[i].datepast,
                    ListPrint[i].curencyindore,
                    ListPrint[i].fathername,
                    ListPrint[i].shenasname,
                    ListPrint[i].phonenumber,
                    ListPrint[i].pay2,
                    ListPrint[i].pay3,
                    ListPrint[i].curencyoftoup,
                    ListPrint[i].WaterAzad,
                     ListPrint[i].Cardname
                    );

            }
            ReportPrint.Load(Application.StartupPath + "/ReportOfBill.mrt");
            ReportPrint.RegData("DT", dt);
            ReportPrint.Show();
            ListPrint.RemoveAll(i => i.isremov == true);
        }
       
        private void Frm_Archive_Load(object sender, EventArgs e)
        {
            try
            {
                Binde();
                //dgvarchive.Rows[0].Cells[1].Value = true;
                //this.dgvarchive.Columns[7].DefaultCellStyle.Format = "N0";
                //this.dgvarchive.Columns[10].DefaultCellStyle.Format = "N0";
                //this.dgvarchive.Columns[13].DefaultCellStyle.Format = "N0";
                //this.dgvarchive.Columns[14].DefaultCellStyle.Format = "N0";
                //this.dgvarchive.Columns[15].DefaultCellStyle.Format = "N0";
                //this.dgvarchive.Columns[22].DefaultCellStyle.Format = "N0";
            }
            catch
            {

            }
        }

        private void dgvarchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            try
            {
                ch1 = (DataGridViewCheckBoxCell)dgvarchive.Rows[dgvarchive.CurrentRow.Index].Cells[1];
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
            catch
            {
               
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Binde();
        }

        private void txsearchbill_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvarchive.DataSource = db.Company.GetAllRecpietFilter(txsearchbill.Text);
                if (txsearchbill.TextLength == 0)
                {
                    Binde();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddtoSmsList();
            Frm_sms fs = new Frm_sms();
            fs.count = count;
            fs.ListSms = ListSms;
            if(fs.ShowDialog()==DialogResult.Cancel)
            {
                count = 0;
                ListSms.RemoveAll(s => s.isremove == true);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            AddToPrint();
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dgvarchive.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvarchive.Rows[i].Cells[1].Value) == false)
                {
                    dgvarchive.Rows[i].Cells[1].Value = true;
                }
                else
                    dgvarchive.Rows[i].Cells[1].Value = false;
            }
        }
      public  void FilterDate()
        {
            List<WaterBill_DataLayer.EfModel.Tb_Receipt> result = new List<WaterBill_DataLayer.EfModel.Tb_Receipt>();
            DateTime? startDate;
            DateTime? endDate;
            UnitOfWork db = new UnitOfWork();
            result.AddRange(db.Company.GetAllReciept());
            if (txtFromDate.Text != "    /  /")
            {
                startDate = Convert.ToDateTime(txtFromDate.Text);
                startDate = DateAndTimeConvertor.ToMiladi(startDate.Value);
                result = result.Where(r => DateAndTimeConvertor.ToMiladi(DateTime.Parse(r.DateShamsi))>= startDate.Value).ToList();                
            }
            if (txtToDate.Text != "    /  /")
            {
                endDate = Convert.ToDateTime(txtToDate.Text);
                endDate = DateAndTimeConvertor.ToMiladi(endDate.Value);
                result = result.Where(r => DateAndTimeConvertor.ToMiladi(DateTime.Parse(r.DateShamsi))<= endDate.Value).ToList();

            }
            dgvarchive.DataSource = result;

        }
     
        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            try
            {
                FilterDate();
            }
            catch
            {
                RtlMessageBox.Show(" در شش ماه دوم سال فرمت تاریخ را 30 روزه وارد کنید");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool checkSate = false;
                int listdeletcount = 0;
                for (int index = 0; index < dgvarchive.RowCount; index++)
                {

                    DataGridViewCheckBoxCell chk = dgvarchive["charchiv", index] as DataGridViewCheckBoxCell;
                    if (chk != null)
                        if (chk.Value != null)
                        {
                            checkSate = (bool)chk.Value;
                            if (checkSate)
                            {
                                listdeletcount++;
                                listdelet.Add(new DeleteList { IdDelete = int.Parse(dgvarchive.Rows[index].Cells[0].Value.ToString()) });
                            }


                        }
                }
                if (checkSate != true)
                    RtlMessageBox.Show("لطفا سطری را برای حذف انتخاب کنید");
                else
                {
                    if (RtlMessageBox.Show("آیا از حذف مطمئن هستید ؟ ", "هشدار", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        foreach (var item in listdelet)
                        {
                            using (UnitOfWork db = new UnitOfWork())
                            {

                                db.Company.DeleteRecpeitById(item.IdDelete);
                                db.Save();
                                Binde();
                            }
                        }
                        RtlMessageBox.Show("اطلاعات با موفقیت حذف شد");
                    }
                }
            }
            catch
            {
                RtlMessageBox.Show("مشکلی در حذف اطلاعات وجود دارد");
            }
            }
       
        private void btnnowbill_Click(object sender, EventArgs e)
        {
            List<WaterBill_DataLayer.EfModel.Tb_Receipt> result = new List<WaterBill_DataLayer.EfModel.Tb_Receipt>();
            DateTime? startDate;
            DateTime? endDate;
            UnitOfWork db = new UnitOfWork();
            result.AddRange(db.Company.GetAllReciept());
                startDate = DateTime.Now.AddDays(-7);
                startDate = DateAndTimeConvertor.ToMiladi(startDate.Value);
                result = result.Where(r => DateAndTimeConvertor.ToMiladi(DateTime.Parse(r.DateShamsi)) >=DateTime.Parse(startDate.Value.ToShamsi())).ToList();
                endDate = DateTime.Now;
                endDate = DateAndTimeConvertor.ToMiladi(endDate.Value);
            result = result.Where(r => DateAndTimeConvertor.ToMiladi(DateTime.Parse(r.DateShamsi)) <=DateTime.Parse(endDate.Value.ToShamsi())).ToList();
            dgvarchive.DataSource = result;
            for (int i = 0; i < dgvarchive.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvarchive.Rows[i].Cells[1].Value) == false)
                {
                    dgvarchive.Rows[i].Cells[1].Value = true;
                }
            }
            }
    }
}
