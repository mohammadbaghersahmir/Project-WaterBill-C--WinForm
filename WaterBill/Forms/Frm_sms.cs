using SmsIrRestful;
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
    public partial class Frm_sms : Form
    {
        public Frm_sms()
        {
            InitializeComponent();
        }
        public int count = 0;
        public List<SmsList> ListSms = new List<SmsList>();
       
        public void DgvFill()
        {
            for (int i = 0; i < count; i++)
            {
                dgvsms.Rows.Add(ListSms[i].id,ListSms[i].name, DateTime.Parse(ListSms[i].datenow), ListSms[i].curency, ListSms[i].phonenumber);
            }
           
         
        }
        private void Frm_sms_Load(object sender, EventArgs e)
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
                cbcustomer.DataSource = list;
                cbcustomer.DisplayMember = "FullName";
                cbcustomer.ValueMember = "CustomerID";
                //dgvdatesms.AutoGenerateColumns = false;
                List<WaterBill_DataLayer.EfModel.Tb_PanelSms> listcustomer = db.Company.Fillsms();
               var r  = listcustomer.Select(cl => new
                {
                    NameCustomer = cl.NameCustomer,
                    DateSms = cl.DateSms.Value.ToShamsi()
                }).OrderByDescending(j => j.DateSms).ToList();
                dgvdatesms.DataSource = r;
            }
            DgvFill();
           
        }
        string patternCode = "";
        private void btnsend_Click(object sender, EventArgs e)
        {
            PanelSMS.smsserver client = new PanelSMS.smsserver();
            var username = "mir6251";
            var password = "aminso123";
            var fromNum = "3000505";
            using (UnitOfWork db = new UnitOfWork())
            {
                patternCode = db.Company.Getbypaterncode(2);
            }
                if (dgvsms.CurrentRow != null)
                {
                    int istrueall = 0, isfalseall = 0;
                    List<string> phone = new List<string>();
                    //var token = new Token().GetToken("bed4e9408ce000a0afe0edc3", "mirso6251#%^**");
                    for (int i = 0; i < count; i++)
                    {
                        var data = new PanelSMS.input_data_type[] {
                        // key is your parameter name and value is what you want to send to the receiptor 
                new PanelSMS.input_data_type() { key = "name", value = ListSms[i].name },
                new PanelSMS.input_data_type() { key = "amount", value = ListSms[i].curency.ToString()}
                    };
                        string[] toNum = { ListSms[i].phonenumber };
                        var response = client.sendPatternSms(fromNum, toNum, username, password, patternCode, data);
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
                        IdCustomer = int.Parse(dgvsms.Rows[i].Cells[0].Value.ToString())
                            ,
                        DateSms = DateTime.Now,
                        NameCustomer = dgvsms.Rows[i].Cells[1].Value.ToString()
                    };
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.Company.InsertSms(sms);
                        db.Save();
                    }
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
        bool flag = false;
        private void Btnpatern_Click(object sender, EventArgs e)
        {
           
        }
        public void Findsms(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
             
                if (txtFromDate.Text == "" || txtToDate.Text == "")
                    RtlMessageBox.Show("یکی از تاریخ ها راوارد نکرده اید");
                else
                {
                    List<WaterBill_DataLayer.EfModel.Tb_PanelSms> data = db.Company.Fillsms();
                    var result = data.Where(l => l.IdCustomer == id)
        .Select(cl => new
        {
            NameCustomer = cl.NameCustomer,
            DateSms = cl.DateSms.Value.ToShamsi()

        }).OrderByDescending(j => j.DateSms).ToList();
                    DateTime? startDate;
                    DateTime? endDate;
                    if (txtFromDate.Text != "    /  /")
                    {
                        startDate = Convert.ToDateTime(txtFromDate.Text);
                        startDate = DateAndTimeConvertor.ToMiladi(startDate.Value);
                        result = result.Where(r => DateAndTimeConvertor.ToMiladi(DateTime.Parse(r.DateSms))>= startDate.Value).ToList();
                    }
                    if (txtToDate.Text != "    /  /")
                    {
                        endDate = Convert.ToDateTime(txtToDate.Text);
                        endDate = DateAndTimeConvertor.ToMiladi(endDate.Value);
                        result = result.Where(r => DateAndTimeConvertor.ToMiladi(DateTime.Parse(r.DateSms)) <= endDate.Value).ToList();
                    }
                    dgvdatesms.DataSource = result;
                }
            }
        }
        public void FindsmsWithoutID()
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                if (txtFromDate.Text == "" || txtToDate.Text == "")
                    RtlMessageBox.Show("یکی از تاریخ ها راوارد نکرده اید");
                else
                {
                    List<WaterBill_DataLayer.EfModel.Tb_PanelSms> data = db.Company.Fillsms();
                    var result = data
        .Select(cl => new
        {
            NameCustomer = cl.NameCustomer,
            DateSms = cl.DateSms.Value.ToShamsi()

        }).OrderByDescending(j => j.DateSms).ToList();
                    DateTime? startDate;
                    DateTime? endDate;
                    if (txtFromDate.Text != "    /  /")
                    {
                        startDate = Convert.ToDateTime(txtFromDate.Text);
                        startDate = DateAndTimeConvertor.ToMiladi(startDate.Value);
                        result = result.Where(r => DateAndTimeConvertor.ToMiladi(DateTime.Parse(r.DateSms))>= startDate.Value).ToList();
                    }
                    if (txtToDate.Text != "    /  /")
                    {
                        endDate = Convert.ToDateTime(txtToDate.Text);
                        endDate = DateAndTimeConvertor.ToMiladi(endDate.Value);
                        result = result.Where(r => DateAndTimeConvertor.ToMiladi(DateTime.Parse(r.DateSms)) <= endDate.Value).ToList();
                    }
                    dgvdatesms.DataSource = result;
                }

            }
        }
        private void btnfilter_Click(object sender, EventArgs e)
        {
            if (cbcustomer.Text != "انتخاب کنید")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Findsms(db.Company.Getbysubbyname(cbcustomer.Text));
                }
            }
            else
                FindsmsWithoutID();
           
        }
    }
}
