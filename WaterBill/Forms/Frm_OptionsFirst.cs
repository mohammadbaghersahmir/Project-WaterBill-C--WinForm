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
using WaterBill_ViewModel;

namespace WaterBill.Forms
{
    public partial class Frm_OptionsFirst : Form
    {
        public Frm_OptionsFirst()
        {
            InitializeComponent();
        }
        private void Frm_OptionsFirst_Load(object sender, EventArgs e)
        {
           
           
            Bindgrid();
        }
        public string flag = "";
        void Bindgrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var options = db.OptionsRepository.Get().First();
                txnekh.Text = options.Abunman.ToString()+"تومان";
                txnekh2.Text = options.Maliat.ToString() + "تومان";
                txhesab.Text = options.HesabPhone.ToString();
                txmetra.Text = options.GhotreEnsheab.ToString();           
                txUnit.Text = options.CurencuOfUnit.ToString() + "تومان";
                txmetra2.Text = options.CurencuOfUnitToUp.ToString();
                txwaterh.Text = db.OptionsRepository.GetById(1).HesabPhone;
                txnamecard.Text = db.OptionsRepository.GetById(3).HesabPhone;
                txkhadamat.Text = db.Company.GetbyKhadamat()+ "تومان";
                txabunman.Text = options.PublicWork.ToString() + "تومان";
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
          
        }

        private void cmtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (UnitOfWork db = new UnitOfWork())
            //{
            //    if (cmtype.SelectedIndex == 0)
            //    {
            //        txtypeshow.Text = db.Company.GetByCurency("A").ToString() + " تومان";
            //        flag = "A";
            //    }
            //    else if (cmtype.SelectedIndex == 1)
            //    {
            //        txtypeshow.Text = db.Company.GetByCurency("B").ToString() + " تومان";
            //        flag = "B";
            //    }

            //    else if (cmtype.SelectedIndex == 2)
            //    {
            //        txtypeshow.Text = db.Company.GetByCurency("C").ToString() + " تومان";
            //        flag = "C";
            //    }
            //}
        }

        private void txmaliat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 46)//backspace&.
            { return; }
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
                e.Handled = true;
        }

        private void txhesab_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var options = db.OptionsRepository.Get().First();
                    options.Abunman = double.Parse(txnekh.Text.Replace("تومان", ""));
                    options.GhotreEnsheab = double.Parse(txmetra.Text);
                    options.HesabPhone = txhesab.Text; ;
                    options.Maliat = double.Parse(txnekh2.Text.Replace("تومان", ""));
                    options.Id = 0;
                    options.CurencuOfUnit = float.Parse(txUnit.Text.Replace("تومان", ""));
                    options.CurencuOfUnitToUp = float.Parse(txmetra2.Text);
                    options.PublicWork = double.Parse(txabunman.Text.Replace("تومان", ""));
                    var op2 = db.OptionsRepository.Get().Where(id=>id.Id==1).First();
                    op2.HesabPhone = txwaterh.Text;
                    var op3 = db.OptionsRepository.Get().Where(id => id.Id == 3).First();
                    op3.HesabPhone = txnamecard.Text;
                    NerkhMasraf nerkh = new NerkhMasraf()
                    {
                        Curency = double.Parse(txkhadamat.Text.Replace("تومان", "")),
                        TypeName = "A"
                    };
                    db.Company.UpdateNerkh(nerkh);
                    db.OptionsRepository.Update(options);
                    db.OptionsRepository.Update(op2);
                    db.OptionsRepository.Update(op3);
                    db.Save();
                    RtlMessageBox.Show("اطلاعات با موفقیت ویرایش شد");
                }
            }
            catch
            {
                RtlMessageBox.Show("اطلاعات با موفقیت ویرایش نشد");
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
