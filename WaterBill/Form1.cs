using SmsIrRestful;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterBill.Forms;
using System.Data.SqlClient;
using WaterBill_Utility.Convertor;
using System.Data.SQLite;
using WaterBill_DataLayer.Contex;
using System.Threading;

namespace WaterBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login f = new Frm_Login();
            f.ShowDialog();
            if (f.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
                lbdater.Text = DateTime.Now.ToShamsi();
                lbday.Text=DateAndTimeConvertor.todayofshamsi(DateTime.Now.DayOfWeek.ToString());
              
               
            }
        }

        private void btnmagementcompany_Click(object sender, EventArgs e)
        {

        }

        private void btnbill_Click(object sender, EventArgs e)
        {

        }

        private void btnbill_Click_1(object sender, EventArgs e)
        {
           
        }

        private void piccompany_MouseHover(object sender, EventArgs e)
        {
            piccompany.BackColor = Color.SteelBlue;
            piccompany1.BackColor = Color.SteelBlue;
        }

        private void piccompany_MouseLeave(object sender, EventArgs e)
        {
            piccompany.BackColor = Color.SkyBlue;
            piccompany1.BackColor = Color.SkyBlue;
        }

        private void picbill_MouseHover(object sender, EventArgs e)
        {
            picbill.BackColor = Color.SteelBlue;
            picbill1.BackColor = Color.SteelBlue;
        }

        private void picbill_MouseLeave(object sender, EventArgs e)
        {
            picbill.BackColor = Color.SkyBlue;
            picbill1.BackColor = Color.SkyBlue;
        }

        private void picbackup_MouseHover(object sender, EventArgs e)
        {
            picbackup.BackColor = Color.SteelBlue;
            picback1.BackColor = Color.SteelBlue;
        }

        private void picbackup_MouseLeave(object sender, EventArgs e)
        {
            picbackup.BackColor = Color.SkyBlue;
            picback1.BackColor = Color.SkyBlue;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
           
        }

        private void btnrestor_Click(object sender, EventArgs e)
        {
          
        }

        private void btncompany_Click(object sender, EventArgs e)
        {
           
        }

        private void btnoptionsbill_Click(object sender, EventArgs e)
        {
            Frm_OptionsFirst options = new Frm_OptionsFirst();
            options.ShowDialog();
        }

        private void btnoptionslogin_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.IsEdit = true;
            login.ShowDialog();
        }

        private void picbill1_Click(object sender, EventArgs e)
        {
            Frm_Bill f = new Frm_Bill();
            f.ShowDialog();
        }

        private void btnbackupe_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "*.Bak|*.Bak";
                saveFile.FileName = "DbWaterBill";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(Application.StartupPath + "\\DbWaterBill.db", saveFile.FileName);
                    RtlMessageBox.Show("پشتیبان گیری با موفقیت انجام شد");
                }

            }
            catch
            {
                RtlMessageBox.Show("پشتیبان گیری با موفقیت انجام نشد");

            }

        }
        private static readonly string filePath = Environment.CurrentDirectory;
        private void btnrestore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openBackup = new OpenFileDialog();
                openBackup.Filter = "sql backup file(*.BAK)|*.BAK";
                if (openBackup.ShowDialog() == DialogResult.OK)
                {
                    DialogResult result = RtlMessageBox.Show("فایل پشتیان جایگزین شود؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string fileSavePath = Application.StartupPath + "\\DbWaterBill.db";
                    //Thread.Sleep(3000);
                    using (FileStream s = File.Open(fileSavePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
                    {
                        s.Close();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        s.Dispose();
                        System.Data.SQLite.SQLiteConnection.ClearAllPools();
                    }
                  
                    System.IO.File.Delete(fileSavePath); //File deletad sucessfully!
                        //File.Delete(delpath);
                        //File.Delete(Application.StartupPath + "\\DbWaterBill.db");
                        File.Copy(openBackup.FileName, Application.StartupPath + "\\DbWaterBill.db");
                        RtlMessageBox.Show("بازیابی با موفقیت انجام شد.نرم افزار مجدد راه اندازی می شود");
                        Application.Restart();
                    }
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                RtlMessageBox.Show("بازیابی با موفقیت انجام نشد");
            }

}
      
        private void btnbill_Click_2(object sender, EventArgs e)
        {
            Frm_Bill f = new Frm_Bill();
            f.ShowDialog();
        }

        private void btncompany_Click_1(object sender, EventArgs e)
        {
            Frm_VeiwOrEditCompany company = new Frm_VeiwOrEditCompany();
            company.ShowDialog();
        }

        private void picbill_Click(object sender, EventArgs e)
        {
            Frm_Bill f = new Frm_Bill();
            f.ShowDialog();
        }
        
        private void piccompany1_Click(object sender, EventArgs e)
        {
            Frm_VeiwOrEditCompany company = new Frm_VeiwOrEditCompany();
            company.ShowDialog();
        }

        private void piccompany_Click(object sender, EventArgs e)
        {
            Frm_VeiwOrEditCompany company = new Frm_VeiwOrEditCompany();
            company.ShowDialog();
        }

        private void picachiv_MouseLeave(object sender, EventArgs e)
        {
            picachiv.BackColor = Color.SkyBlue;
            picachiv.BackColor = Color.SkyBlue;
        }

        private void picachiv_MouseHover(object sender, EventArgs e)
        {
            picachiv.BackColor = Color.SteelBlue;
            picachiv.BackColor = Color.SteelBlue;
        }

        private void picachiv_Click(object sender, EventArgs e)
        {
            Frm_Archive f = new Frm_Archive();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Frm_Archive f = new Frm_Archive();
            f.ShowDialog();
        }

        private void picachive_Click(object sender, EventArgs e)
        {
            Frm_Archive f = new Frm_Archive();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnaboutme_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://asrenovin.org/درباره-ما/");
            Frm_PanelSms p = new Frm_PanelSms();
            p.ShowDialog();
        }

        private void btncall_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://asrenovin.org/contact-us/");
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            Frm_Calculate f = new Frm_Calculate();
            f.ShowDialog();
        }
    }
}
