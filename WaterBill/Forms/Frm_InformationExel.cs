using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WaterBill_DataLayer.Contex;
using WaterBill_DataLayer.EfModel;
using WaterBill_Utility.Convertor;

namespace WaterBill.Forms
{
    public partial class Frm_InformationExel : Form
    {
        public Frm_InformationExel()
        {
            InitializeComponent();
        }
        public int CompanyId = 0;

        private void Frm_InformationExel_Load(object sender, EventArgs e)
        {

        }
        public void ViewExel()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "انتخاب فایل اکسل حاوی اطلاعات";
            ofd.Filter = "فایل اکسل 2003 (*.xls)|*.xls|فایل اکسل 2007 به بعد(*.xlsx)|*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string SourceFilePath = ofd.FileName;
                var fileName = SourceFilePath;
                var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;IMEX=1;HDR=NO;TypeGuessRows=0;ImportMixedType s=Text\"";
                var conn = new OleDbConnection(connectionString);
                conn.Open();
                //var sheets = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSc hemaGuid.Tables, new object[] { null, null, null, "person" });
                var cmd = conn.CreateCommand();
                //cmd.CommandText = "SELECT * FROM [" + sheets.Rows[1]["A"].ToString() + "] ";
                cmd.CommandText = "SELECT * FROM [Sheet1$]";
                var adapter = new OleDbDataAdapter(cmd);
                var ds = new DataSet();
                DataTable dt = new DataTable();
                adapter.Fill(ds);
                adapter.Fill(dt);
                dgvexel.DataSource = dt;
            }
        }

        private void btnexelinpute_Click(object sender, EventArgs e)
        {
            ViewExel();
        }

        private void btnsubmitexel_Click(object sender, EventArgs e)
        {
            try
            {
                InsertBill();
            }
            catch
            {
                RtlMessageBox.Show("خطایی وجود دارد");
            }
        }

        public void InsertBill()
        {
            //using (UnitOfWork db = new UnitOfWork())
            //{

            //    Tb_Meter meter = new Tb_Meter()
            //    {
            //        MeterId = CompanyId,
            //        Describtion = "",
            //        MeterAmount = double.Parse(dgvexel.CurrentRow.Cells[1].Value.ToString()),
            //        MeterDate = DateAndTimeConvertor.ToMiladi(DateTime.Parse(dgvexel.CurrentRow.Cells[0].Value.ToString())),
            //        SumAll = 0,
            //    };
            //    Frm_Bill f = new Frm_Bill();
            //    Tb_Bill bill = new Tb_Bill()
            //    {
            //        BillId = db.Company.GetBillId(0),
            //        CompanyId = CompanyId,
            //        TypeId = 1,
            //        MeterId = CompanyId,
            //    };
            //    Tb_CountBill countbill = new Tb_CountBill()
            //    {
            //        Id = 0,
            //        count = db.Company.GetBillId(0),
            //    };
            //    bool isvalid = db.Company.InsertBill(bill);
            //    bool isvalidmeter = db.Company.InsertMeter(meter);
            //    if (isvalid == true && isvalidmeter == true)
            //    {
            //        db.Company.UpdateBillCount(countbill);
            //        db.Save();
            //        RtlMessageBox.Show("باموفقیت ثبت گردید", "هشدار");
            //        DialogResult = DialogResult.OK;
            //    }
            //}
        }
    }
}
