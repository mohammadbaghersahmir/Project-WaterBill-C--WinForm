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
using WaterBill_ViewModel.Customer;

namespace WaterBill.Forms
{
    public partial class Frm_Calculate : Form
    {
        public Frm_Calculate()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public List<CalcDebt> ItemsDebt = new List<CalcDebt>();
        public void AddToCalcItem()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                ItemsDebt.Add(new CalcDebt { Bed = double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()), Bes = double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()), Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), Key = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()), Date = dataGridView1.CurrentRow.Cells[5].Value.ToString(), Name = dataGridView1.CurrentRow.Cells[2].Value.ToString(), Type = dataGridView1.CurrentRow.Cells[6].Value.ToString() });
            }
        }
        private void Frm_Calculate_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListMoshtarakViewModel> list = new List<ListMoshtarakViewModel>();
                list.Add(new ListMoshtarakViewModel()
                {
                    CustomerID = 0,
                    FullName = "انتخاب کنید"
                });
                list.AddRange(db.Company.GetNameCustomers());
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
            }
            BindReportSum();

        }
        public void BindReportSum()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> data = db.Company.GetAllCalcMoshtarakSum();


                var r = data.GroupBy(l => l.Id)
    .Select(cl => new
    {
        Name = cl.First().Name,
        bedehi = cl.Sum(c => c.bedehi).ToString(),
        paradakhti = cl.Sum(c => c.paradakhti).ToString(),
        datesabt = cl.First().datesabt.Value.ToShamsi()

    }).OrderByDescending(j => j.bedehi).ToList();
                //var r = (from p in data select p).ToList();
                dgvreportsum.DataSource = r;
                // for (int i = 0; i < dgvreportsum.Rows.Count; i++)
                // {
                //DateTime.Parse(dgvreportsum.Rows[i].Cells["datesabt"].Value.ToString()).ToShamsi();
                // }

                var bedehi = data.Sum(l => l.bedehi);
                string rbedehi = String.Format("{0:#,#}", bedehi) + "تومان";
                lblAllBedehi.Text = rbedehi;
                var best = data.Sum(l => l.paradakhti);
                string rbestan = String.Format("{0:#,#}", best) + "تومان";
                lblSumBedehi.Text = rbestan;
            }
        }
        private void CbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            MethodCalclator();

        }

        private void lbsumbedehi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbsumbest_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbsum_TextChanged(object sender, EventArgs e)
        {
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

        }
        public void MethodCalclator()
        {
            if (cbCustomer.Text == "انتخاب کنید")
            {
                lbname.Text = "-";
                dataGridView1.DataSource = null;
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    dataGridView1.AutoGenerateColumns = false;
                    lbname.Text = cbCustomer.Text;
                    List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> data = db.Company.GetAllCalcMoshtarak(cbCustomer.Text);
                    var filldatadgv = data.Where(id => id.Id == db.Company.Getbysubbyname(cbCustomer.Text)).GroupBy(id => id).Select(cl => new
                    {
                        id = cl.First().Id,
                        key = cl.First().Key,
                        Name = cl.First().Name,
                        bedehi = cl.Sum(c => c.bedehi).ToString(),
                        paradakhti = cl.Sum(c => c.paradakhti).ToString(),
                        datesabt = cl.First().datesabt.Value.ToShamsi(),
                        type = cl.First().type

                    }).ToList();
                    dataGridView1.DataSource = filldatadgv;
                    int sumbest = 0, sumbedehi = 0, sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sumbest += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString().Replace(",", ""));
                        sumbedehi += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString().Replace(",", ""));
                    }
                    string rsumbest = String.Format("{0:#,#}", sumbest) + "تومان";
                    lbsumbest.Text = rsumbest;
                    string rbsumbed = String.Format("{0:#,#}", sumbedehi) + "تومان";
                    lbsumbedehi.Text = rbsumbed;
                    sum = (sumbest * -1) + sumbedehi;
                    if (sum < 0)
                    {
                        string rsum = String.Format("{0:#,#}", (sum * -1)) + "تومان";
                        lbsum.Text = rsum;
                        lbsum.ForeColor = Color.Green;
                    }
                    else
                    {
                        string rsum = String.Format("{0:#,#}", sum) + "تومان";
                        lbsum.Text = rsum;
                        lbsum.ForeColor = Color.Red;
                    }

                }
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvreportsum_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Btinsert_Click(object sender, EventArgs e)
        {
            if (cbCustomer.Text == "انتخاب کنید")
            {
                RtlMessageBox.Show("لطفایک مشترک را انتخاب کنید");
            }
            else
            {

                Frm_Calculator f = new Frm_Calculator();
                f.name = cbCustomer.Text;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MethodCalclator();
                    BindReportSum();
                }
            }
        }

        private void Btupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int companyid = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                Frm_Calculator f = new Frm_Calculator();
                f.companyid = companyid;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MethodCalclator();
                    BindReportSum();
                }
            }
        }
        public List<DeleteList> listdelet = new List<DeleteList>();
        private void Btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool checkSate = false;
                int listdeletcount = 0;
                for (int index = 0; index < dataGridView1.RowCount; index++)
                {

                    DataGridViewCheckBoxCell chk = dataGridView1["charchiv", index] as DataGridViewCheckBoxCell;
                    if (chk != null)
                        if (chk.Value != null)
                        {
                            checkSate = (bool)chk.Value;
                            if (checkSate)
                            {
                                listdeletcount++;
                                listdelet.Add(new DeleteList { IdDelete = int.Parse(dataGridView1.Rows[index].Cells[1].Value.ToString()) });
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

                                db.Company.DeleteMoshtarakById(item.IdDelete);
                                db.Save();
                                MethodCalclator();
                                BindReportSum();
                                UpdateDebt();
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
        public void UpdateDebt()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                int idmoshtarak = db.Company.Getbysubbyname(cbCustomer.Text);
                List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> datares = db.Company.GetAllCalcMoshtarakSum();
                var r = datares.Where(i => i.Id == idmoshtarak).GroupBy(l => l.Id)
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
        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            try
            {
                ch1 = (DataGridViewCheckBoxCell)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2];
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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbsort.Text == "تاریخ")
            {
                SortbyDate();
            }
            else if (cbsort.Text == "بیشترین بدهی")
            {
                SortbyMaxBedehi();
            }
            else if (cbsort.Text == "کمترین بدهی")
            {
                SortbyMinBedehi();
            }
        }
        public void SortbyMaxBedehi()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> data = db.Company.GetAllCalcMoshtarakSum();
                var r = data.GroupBy(l => l.Id)
        .Select(cl => new
        {
            Name = cl.First().Name,
            bedehi = cl.Sum(c => c.bedehi).ToString(),
            paradakhti = cl.Sum(c => c.paradakhti).ToString(),
            datesabt = cl.First().datesabt.Value.ToShamsi(),
            datemiladi = cl.First().datesabt

        }).OrderByDescending(j => j.bedehi).ToList();
                dgvreportsum.AutoGenerateColumns = false;
                dgvreportsum.DataSource = r;
            }
        }
        public void SortbyMinBedehi()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> data = db.Company.GetAllCalcMoshtarakSum();
                var r = data.GroupBy(l => l.Id)
        .Select(cl => new
        {
            Name = cl.First().Name,
            bedehi = cl.Sum(c => c.bedehi).ToString(),
            paradakhti = cl.Sum(c => c.paradakhti).ToString(),
            datesabt = cl.First().datesabt.Value.ToShamsi(),
            datemiladi = cl.First().datesabt

        }).OrderBy(j => j.bedehi).ToList();
                dgvreportsum.AutoGenerateColumns = false;
                dgvreportsum.DataSource = r;
            }
        }
        public void SortbyDate()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> data = db.Company.GetAllCalcMoshtarakSum();
                var r = data.GroupBy(l => l.Id)
        .Select(cl => new
        {
            Name = cl.First().Name,
            bedehi = cl.Sum(c => c.bedehi).ToString(),
            paradakhti = cl.Sum(c => c.paradakhti).ToString(),
            datesabt = cl.First().datesabt.Value.ToShamsi(),
            datemiladi = cl.First().datesabt

        }).OrderByDescending(j => j.datemiladi).ToList();
                dgvreportsum.AutoGenerateColumns = false;
                dgvreportsum.DataSource = r;
            }
        }

        private void Btnsub_Click(object sender, EventArgs e)
        {
            if (txtFromDate.Text == "" || txtToDate.Text == "")
                RtlMessageBox.Show("یکی از تاریخ ها راوارد نکرده اید");
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    List<WaterBill_DataLayer.EfModel.Tb_Receipt_calc> data = db.Company.GetAllCalcMoshtarakSum();
                    var result = data.GroupBy(l => l.Id)
        .Select(cl => new
        {
            Name = cl.First().Name,
            bedehi = cl.Sum(c => c.bedehi).ToString(),
            paradakhti = cl.Sum(c => c.paradakhti).ToString(),
            datesabt = cl.First().datesabt.Value

        }).OrderByDescending(j => j.bedehi).ToList();
                    DateTime? startDate;
                    DateTime? endDate;
                    if (txtFromDate.Text != "    /  /")
                    {
                        startDate = Convert.ToDateTime(txtFromDate.Text);
                        startDate = DateAndTimeConvertor.ToMiladi(startDate.Value);
                        result = result.Where(r => r.datesabt >= startDate.Value).ToList();
                    }
                    if (txtToDate.Text != "    /  /")
                    {
                        endDate = Convert.ToDateTime(txtToDate.Text);
                        endDate = DateAndTimeConvertor.ToMiladi(endDate.Value);
                        result = result.Where(r => r.datesabt <= endDate.Value).ToList();

                    }

                    if (result.Count == 0)
                        RtlMessageBox.Show("در تاریخ انتخابی مشترکی به عنوان بیشترین بدهی وجود ندارد لطفا تاریخ دیگری را امتحان کنید");
                    else
                    {
                        lbmaxbed.Text = String.Format("{0:#,#}", result.First().bedehi) + "تومان";
                        lbmaxbed.ForeColor = Color.Red;
                        lbnamemaxbed.Text = "اقا/خانم " + result.First().Name;
                        lbnamemaxbed.ForeColor = Color.Green;
                    }

                }
                isflag = 1;
            }
        }
        bool flag1, flag2, flag3;
        int isflag = 0;
        private void Chtype1_CheckedChanged(object sender, EventArgs e)
        {
            if(chtype1.Checked == true)
            {
                lbtype1.Text =
                    lbnamemaxbed.Text
                    +
                    " قبض اب شمابه مبلغ "
                    +
                    lbmaxbed.Text
                    +
                    " صادرشد ";
                flag1 = true;
            }
            if (chtype1.Checked == false)
            {
                lbtype1.Text = "-";
                flag1 = false;
            }
        }

        private void Btnsms_Click(object sender, EventArgs e)
        {
            if (isflag == 0)
                RtlMessageBox.Show("لطفا ابتدا نسبت به تعیین فرد اقدام کنید");
            else if(chtype1.Checked!=false||chtype2.Checked!=false||chtype3.Checked!=false)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string paterncode = "";
                    if (flag1 == true)
                    {
                        try
                        {
                            var login = db.companylogin.Get(p => p.LoginId == 2).First();
                            PanelSMS.smsserver client = new PanelSMS.smsserver();
                            paterncode = login.UserName;
                            var username = "mir6251";
                            var password = "aminso123";
                            var fromNum = "3000505";
                            var data = new PanelSMS.input_data_type[] {
                        // key is your parameter name and value is what you want to send to the receiptor 
                new PanelSMS.input_data_type() { key = "name", value =lbnamemaxbed.Text.Replace("اقا/خانم ","") },
                new PanelSMS.input_data_type() { key = "amount", value = lbmaxbed.Text.Replace("تومان","")}
                    };
                            string[] toNum = { db.Company.GetbyPhoneWithName(lbnamemaxbed.Text.Replace("اقا/خانم ", "")) };
                            var response = client.sendPatternSms(fromNum, toNum, username, password, paterncode, data);
                            RtlMessageBox.Show("پیامک نوع اول باموفقیت ارسال شد!!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            RtlMessageBox.Show("پیامک نوع اول باموفقیت ارسال نشد!!", "عدم موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (flag2 == true)
                    {
                        try
                        {
                            var login = db.companylogin.Get(p => p.LoginId == 3).First();
                            PanelSMS.smsserver client = new PanelSMS.smsserver();
                            paterncode = login.UserName;
                            var username = "mir6251";
                            var password = "aminso123";
                            var fromNum = "3000505";
                            var data = new PanelSMS.input_data_type[] {
                        // key is your parameter name and value is what you want to send to the receiptor 
                new PanelSMS.input_data_type() { key = "name", value =lbnamemaxbed.Text },
                    };
                            string[] toNum = { db.Company.GetbyPhoneWithName(lbnamemaxbed.Text.Replace("اقا/خانم ", "")) };
                            var response = client.sendPatternSms(fromNum, toNum, username, password, paterncode, data);
                            RtlMessageBox.Show("پیامک نوع دوم باموفقیت ارسال شد!!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            RtlMessageBox.Show("پیامک نوع دوم باموفقیت ارسال نشد!!", "عدم موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    if (flag3 == true)
                    {
                        try
                        {
                            var login = db.companylogin.Get(p => p.LoginId == 4).First();
                            PanelSMS.smsserver client = new PanelSMS.smsserver();
                            paterncode = login.UserName;
                            var username = "mir6251";
                            var password = "aminso123";
                            var fromNum = "3000505";
                            var data = new PanelSMS.input_data_type[] {
                        // key is your parameter name and value is what you want to send to the receiptor 
                new PanelSMS.input_data_type() { key = "name", value =lbnamemaxbed.Text },
                    };
                            string[] toNum = { db.Company.GetbyPhoneWithName(lbnamemaxbed.Text.Replace("اقا/خانم ", "")) };
                            var response = client.sendPatternSms(fromNum, toNum, username, password, paterncode, data);
                            RtlMessageBox.Show("پیامک نوع سوم باموفقیت ارسال شد!!", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            RtlMessageBox.Show("پیامک نوع سوم باموفقیت ارسال نشد!!", "عدم موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            RtlMessageBox.Show("حداقل یک نوع پیامک را انتخاب کنید");

        }

        private void Chtype2_CheckedChanged(object sender, EventArgs e)
        {
            if (chtype2.Checked == true)
            {
                lbtype2.Text =
                    lbnamemaxbed.Text
                    +
                    " قبض اب شماصادرشده است لطفا از مسول مربوطه تحویل بگیرید ";
                flag2 = true;
            }
            if (chtype2.Checked == false)
            {
                lbtype2.Text = "-";
                flag2 = false;
            }
        }

        private void Chtype3_CheckedChanged(object sender, EventArgs e)
        {
            if (chtype3.Checked == true)
            {
                lbtype3.Text =
                    lbnamemaxbed.Text
                    +
                    " لطفا جهت پرداخت قبض خود اقدام فرمایید ";
                flag3 = true;
            }
            if (chtype3.Checked == false)
            {
                lbtype3.Text = "-";
                flag3 = false;
            }
        }
    }

}
