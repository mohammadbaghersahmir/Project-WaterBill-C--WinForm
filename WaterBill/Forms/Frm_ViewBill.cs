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

namespace WaterBill.Forms
{
    public partial class Frm_ViewBill : Form
    {
        public Frm_ViewBill()
        {
            InitializeComponent();
        }

        private void Frm_ViewBill_Load(object sender, EventArgs e)
        {
            Bindgrid();
        }
        void Bindgrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvcompanyes.AutoGenerateColumns = false;
                dgvcompanyes.DataSource = db.Company.GetAllCompany();
            }
        }
    }
}
