using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterBill_DataLayer.EfModel;
using WaterBill_DataLayer.Contex;
using WaterBill_Utility.Convertor;

namespace WaterBill.Forms
{
    public partial class Frm_EditBill : Form
    {
        public Frm_EditBill()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public string name, sub, mnow, mpast, dnow, dpast,txdescrib;

        private void btnsub_Click(object sender, EventArgs e)
        {
            //if (int.Parse(txmeterpast.Text) >= int.Parse(txmeternow.Text))
            //{
            //    RtlMessageBox.Show("شماره های کنتور را به درستی وارد کنید");
            //}
            //else
            //{
                using (UnitOfWork db = new UnitOfWork())
                {
                    Tb_Bill bill = new Tb_Bill()
                    {
                        BillId = int.Parse(txsub.Text),
                        MeterNumberNow = double.Parse(txmeternow.Text),
                        MeterNumberPast =db.Company.GetByAmountPast(int.Parse(txsub.Text)),
                        SeenDate = DateAndTimeConvertor.ToMiladi(DateTime.Parse(txdatepast.Text)),
                        SubScribCode = int.Parse(txsub.Text),
                        Describtion = txdes.Text,
                        NameCompany = txname.Text,
                        SeenDateShamsi = txdatepast.Text
                    };
                    bool isvalid = db.Company.UpadateBill(bill);
                    if (isvalid)
                    {
                        db.Save();
                        RtlMessageBox.Show("اطلاعات با موفقیت ویرایش شد");
                    }
                    else
                        RtlMessageBox.Show("مشکلی در ویرایش اطلاعات وجود دارد");
                //}
            }
        }

        private void Frm_EditBill_Load(object sender, EventArgs e)
        {
            txname.Text = name;
            txsub.Text = sub;
            //txmeterpast.Text = mpast;
            txmeternow.Text = mnow;
            txdatepast.Text = dpast;
            //txdatenow.Text = dnow;
            txdes.Text =txdescrib;
        }
    }
}
