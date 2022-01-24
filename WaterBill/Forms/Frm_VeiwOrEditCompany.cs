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
using WaterBill_Utility.Convertor;

namespace WaterBill.Forms
{
    public partial class Frm_VeiwOrEditCompany : Form
    {
        public Frm_VeiwOrEditCompany()
        {
            InitializeComponent();
        }

        private void btnaddcompany_Click(object sender, EventArgs e)
        {
            Frm_Company newcompany = new Frm_Company();
            if (newcompany.ShowDialog() == DialogResult.OK)
            {
                Bindgrid();
            }

        }

        private void Frm_VeiwOrEditCompany_Load(object sender, EventArgs e)
        {
            Bindgrid();


            //int rownumber = 1;

            //foreach (DataGridViewRow row in dgvcompany.Rows)

            //{

            //    if (row.IsNewRow) continue;

            //    row.HeaderCell.Value = rownumber.ToString();

            //    rownumber = rownumber + 1;

            //}
            //DataTable bsPeople=new DataTable();
            //UnitOfWork db = new UnitOfWork();
            //var result=db.Company.GetAllCompany();
            //bsPeople.Columns.Add("name");
            //bsPeople.Columns.Add("eshterak");
            //bsPeople.Columns.Add("tamas");
            //bsPeople.Columns.Add("pelack");
            //bsPeople.Columns.Add("addres");

            //foreach (var item in result)
            //{
            //    bsPeople.Rows.Add(item.CompanyName, item.SubscribId, item.PhoneNumber, item.PelakId, item.Addres);
            //}
            //dgvcompany.DataSource = bsPeople;
        }
        void Bindgrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvcompany.AutoGenerateColumns = false;
                dgvcompany.DataSource = db.Company.GetAllCompany();
                foreach (DataGridViewRow r in dgvcompany.Rows)
                {

                    dgvcompany.Rows[r.Index].Cells[1].Value = String.Format("{0}", r.Index + 1);
                }
            }
        }

        private void btndeletecompany_Click(object sender, EventArgs e)
        {
            if (dgvcompany.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgvcompany.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید ؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int companyid = int.Parse(dgvcompany.CurrentRow.Cells[4].Value.ToString());
                        db.Company.DeleteCompanyById(companyid);
                        db.Company.DeleteBillById(companyid);
                        db.Company.DeleteCalCulateById(companyid);
                        db.Company.DeleteCalDebtById(companyid);
                        db.Save();
                        Bindgrid();
                    }
                }

            }
            else

                RtlMessageBox.Show("شرکت یا مشترک را انتخاب کنید");
        }

        private void btneditcompany_Click(object sender, EventArgs e)
        {
            if (dgvcompany.CurrentRow != null)
            {
                int companyid = int.Parse(dgvcompany.CurrentRow.Cells[4].Value.ToString());
                Frm_Company f = new Frm_Company();
                f.companyid = companyid;
                //f.sub = int.Parse(dgvcompany.CurrentRow.Cells[2].Value.ToString());
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Bindgrid();
                }
            }
        }

        private void txsearchcompany_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvcompany.DataSource = db.Company.GetAllCompanyFilter(txsearchcompany.Text);
            }
            if (txsearchcompany.TextLength == 0)
            {
                Bindgrid();
            }

        }

        private void btnrefreshcompany_Click(object sender, EventArgs e)
        {
            Bindgrid();
        }
        public List<PrintList> ListPrint = new List<PrintList>();
        private void btnprint_Click(object sender, EventArgs e)
        {

            //print_dgv.PrintDGV.Print_DataGridView(dgvcompany);
            for (int index = 0; index < dgvcompany.RowCount; index++)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var l = db.Company.GetAllReciept();
                  var query=l.Where(r=>r.SubaScribId==int.Parse(dgvcompany.Rows[index].Cells[4].Value.ToString())).GroupBy(u=>u.Id).Select(cl => new
                    {
                       
                        data = cl.First().DateNow,
                        mablagh = cl.First().NumberCurency.ToString()

                    }).OrderByDescending(j => j.data).ToList();
                    string date, mablagh;
                    if(query.Count==0)
                    {
                        date = "";
                        mablagh = "";
                    }
                    else
                    {
                        date = query.First().data.ToShamsi();
                        mablagh = query.First().mablagh;
                    }
                    ListPrint.Add(new PrintList()
                    {

                        name = dgvcompany.Rows[index].Cells[2].Value.ToString(),
                        pelacknumber = int.Parse(dgvcompany.Rows[index].Cells[6].Value.ToString()),
                        phonenumber = dgvcompany.Rows[index].Cells[5].Value.ToString(),
                        curencyindore = mablagh,
                        datenow = db.Company.GetByAmountNow(int.Parse(dgvcompany.Rows[index].Cells[4].Value.ToString())).ToString(),
                        isremov =false

                    });
                
                }
                }
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("pelacknumber");
            dt.Columns.Add("phonenumber");
            dt.Columns.Add("curencyindore");
            dt.Columns.Add("datenow");
            dt.Columns.Add("check");
          //ListPrint=ListPrint.OrderBy(g => g.pelacknumber).ToList();
            for (int i = 0; i < dgvcompany.Rows.Count; i++)
            {
                dt.Rows.Add(ListPrint[i].name, ListPrint[i].pelacknumber, ListPrint[i].phonenumber,ListPrint[i].curencyindore
                    ,ListPrint[i].datenow,ListPrint[i].isremov);
            }
            ReportPrint.Load(Application.StartupPath + "/ReportCustomer.mrt");
            ReportPrint.RegData("DT", dt);
            ReportPrint.Show();
            ListPrint.RemoveAll(i => i.isremov == true);
        }

        private void dgvcompany_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void dgvcompany_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
      
        private void dgvcompany_DragDrop(object sender, DragEventArgs e)
        {
           
        }

        private void dgvcompany_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dgvcompany_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
       
        private void dgvcompany_MouseMove(object sender, MouseEventArgs e)
        {
           
        }   
        private void dgvcompany_MouseUp(object sender, MouseEventArgs e)
        {
          

        }

        private void dgvcompany_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dgvcompany_DragOver(object sender, DragEventArgs e)
        {
        }

        private void dgvcompany_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void dgvcompany_MouseEnter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddtoSmsList();
            Frm_SmsCustomer fs = new Frm_SmsCustomer();
            fs.count = count;
            fs.ListSms = ListSms;
            if (fs.ShowDialog() == DialogResult.Cancel)
            {
                count = 0;
                ListSms.RemoveAll(s => s.isremove == true);
            }
        }
        public List<SmsList> ListSms = new List<SmsList>();
        int count = 0;
        public void AddtoSmsList()
        {
            bool checkSate = false;
            for (int index = 0; index < dgvcompany.RowCount; index++)
            {
                DataGridViewCheckBoxCell chk = dgvcompany["charchiv", index] as DataGridViewCheckBoxCell;
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
                                    phonenumber = db.Company.GetByPhoneNumber(int.Parse(dgvcompany.Rows[index].Cells[4].Value.ToString())),
                                    isremove = true,
                                    name = db.Company.GetFindNameCompanyes(int.Parse(dgvcompany.Rows[index].Cells[4].Value.ToString())),
                                    curency=double.Parse(dgvcompany.Rows[index].Cells[4].Value.ToString())
                                }
                                );
                            }
                        }
                    }

            }
        }

        private void dgvcompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            try
            {
                ch1 = (DataGridViewCheckBoxCell)dgvcompany.Rows[dgvcompany.CurrentRow.Index].Cells[0];
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
    }
}
