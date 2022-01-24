using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterBill_DataLayer.EfModel;
using WaterBill_DataLayer.Repositories;
using WaterBill_Utility.Convertor;
using WaterBill_ViewModel;
using WaterBill_ViewModel.Customer;

namespace WaterBill_DataLayer.Services
{
    public class RepositoriWaterBill : IWaterBillRepositori
    {
        private DbWaterBillEntities db;
        public RepositoriWaterBill(DbWaterBillEntities contex)
        {
            db = contex;
        }

        public double Amount(int Subcribid)
        {
            throw new NotImplementedException();
        }

        public double AmountDebt(int Subcribid)
        {
            return (double.Parse(db.Tb_Debt.First(d => d.ID == Subcribid).Best.ToString()))+(double.Parse(db.Tb_Debt.First(r=>r.ID==Subcribid).Debt.ToString()));

        }
       
        public double AmountLevel(int sub)
        {
            return db.Tb_Bill.Where(d=>d.SubScribCode==sub).Sum(d => d.MeterNumberNow - d.MeterNumberPast);
        }

        public bool DeleteBill(Tb_Bill bill)
        {
            try
            {
                db.Entry(bill).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteBillById(int companyid)
        {
            try
            {
                var company = GetBillByID(companyid);
                DeleteBill(company);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteCalc(Tb_Calculate calc)
        {
            try
            {
                db.Entry(calc).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteCalCulateById(int companyid)
        {
            try
            {
                var company = GetCalcID(companyid);
                DeleteCalc(company);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteCalDebtById(int companyid)
        {
            try
            {
                var company = GetDebtID(companyid);
                DeleteDebt(company);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteCompany(Tb_Company Company)
        {
            try
            {
                db.Entry(Company).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteCompanyById(int companyid)
        {
            try
            {
                var company = GetCompanyByID(companyid);
                DeleteCompany(company);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteDebt(Tb_Debt debt)
        {
            try
            {
                db.Entry(debt).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteRecpeitById(int Idrecpiet)
        {
            try
            {
                var recpiet =GetbyIdtolist(Idrecpiet);
                DeleteRecpiet(recpiet);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteRecpiet(Tb_Receipt rec)
        {

            try
            {
                db.Entry(rec).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public List<Tb_Bill> GetAllBill()
        {
            return db.Tb_Bill.OrderBy(p => p.PelackNumber).ToList();
        }

        public IEnumerable<Tb_Bill> GetAllBillFilter(string parameter)
        {
            return db.Tb_Bill.Where(c => c.NameCompany.Contains(parameter)
               ).ToList();
        }

        public List<Tb_Company> GetAllCompany()
        {
            return db.Tb_Company.OrderBy(e=>e.PelakId).ToList();
        }

        public IEnumerable<Tb_Company> GetAllCompanyFilter(string parameter)
        {
            return db.Tb_Company.Where(c => c.CompanyName.Contains(parameter) || c.PhoneNumber.Contains(parameter)
                ).ToList();
        }

      

        public List<Tb_FirstOptions> GetAllOptions()
        {
            return db.Tb_FirstOptions.Where(i=>i.Id==0).ToList();
        }

        public List<Tb_FirstOptions> GetAllOptions(int id)
        {
            return db.Tb_FirstOptions.ToList();
        }

        public List<Tb_Receipt> GetAllReciept()
        {
            return db.Tb_Receipt.OrderByDescending(u => u.Id).ToList();
        }

        public IEnumerable<Tb_Receipt> GetAllRecpietFilter(string parameter)
        {
            return db.Tb_Receipt.Where(c => c.SubName.Contains(parameter)
              ).ToList();
        }

        public Tb_Bill GetBillByID(int Bill)
        {
            return db.Tb_Bill.Find(Bill);
        }

        public double GetBillId(int IdBill)
        {
            return db.Tb_CountBill.First(d => d.ID == IdBill).Count;
        }
        public double GetByAbuonma()
        {
            return db.Tb_FirstOptions.First(i => i.Id == 0).Abunman;
        }

        public string GetByAddres(int Subscrib)
        {
            return db.Tb_Company.First(a => a.SubscribId == Subscrib).Addres;
        }

        public float GetByAmount(float Subscrib)
        {
            throw new NotImplementedException();
        }

        public double GetByAmountNow(int sub)
        {
            return db.Tb_Bill.First(t => t.BillId == sub).MeterNumberNow;
        }

        public double GetByAmountPast(int sub)
        {
            return db.Tb_Bill.First(t => t.BillId == sub).MeterNumberPast;
        }

        public double GetByBedehi(int subcode)
        {
            return double.Parse(db.Tb_Debt.First(b => b.ID == subcode).Debt.ToString());
        }

        public double GetByBestankar(int subcode)
        {
            return double.Parse(db.Tb_Debt.First(b => b.ID == subcode).Best.ToString());

        }

        public int GetByBillIdInBill(int idbill)
        {
            throw new NotImplementedException();
        }

        public int GetByBillIdInPast(int idbill)
        {
            return int.Parse(db.Tb_Bill.Where(d => d.SubScribCode == idbill).OrderByDescending(d => d.MeterNumberPast).First().MeterNumberPast.ToString());

        }

        public string GetbyCodemeli(int sub)
        {
            return db.Tb_Company.First(t => t.SubscribId == sub).Codemeli;
        }

        public double GetByCountType(int TypeId)
        {
            throw new NotImplementedException();
        }

        public double GetByCurency(string type)
        {
            return db.NerkhMasraf.First(n => n.TypeName == type).Curency;
        }

        public double GetbyCurencyinRecpeit(double ID)
        {
            return db.Tb_Receipt.First(I=>I.Id==ID).NumberCurency;
        }

        public int GetbyCurencyPay(int id)
        {
            return int.Parse(db.Tb_FirstOptions.First(y => y.Id == id).CurencuOfUnit.ToString());
        }
        public int GetbyCurencyOfunit(int id)
        {
            return int.Parse(db.Tb_FirstOptions.First(y => y.Id == id).CurencuOfUnitToUp.ToString());
        }
        public float GetByCurencyPublic(string Type)
        {
            return float.Parse(db.NerkhMasraf.First(t => t.TypeName == Type).Curency.ToString());
        }

        public List<Tb_Receipt> GetBydate(DateTime start, DateTime end)
        {
            return db.Tb_Receipt.Where(r => r.DateNow <= start).ToList().Where(t=>t.DateNow>=end).ToList();
        }

        public string GetByDescrib(int sub)
        {
            return db.Tb_Bill.First(r => r.BillId == sub).Describtion;
        }

        public string GetbyFathername(int melicode)
        {
            return db.Tb_Company.First(r => r.SubscribId == melicode).FatherName;
        }

        public double GetByGhotre()
        {
            return db.Tb_FirstOptions.First(i => i.Id == 0).GhotreEnsheab;
        }

        public Tb_Receipt GetbyIdtolist(int rec)
        {
            return db.Tb_Receipt.Find(rec);
        }

        public double GetByMetercountinBill(double Subcode)
        {
            //return db.Tb_Bill.First(d=>d.SubScribCode==Subcode).MeterNumberPast;
            return db.Tb_Bill.Where(d => d.SubScribCode == Subcode).OrderByDescending(d => d.MeterNumberNow).First().MeterNumberNow;
        }

        public double GetBymetraz2()
        {
            return db.Tb_FirstOptions.First(i => i.Id == 0).CurencuOfUnitToUp;
        }

        public string GetbyNameinRecpiet(int sub)
        {
            return db.Tb_Receipt.First(r => r.SubaScribId == sub).SubName;
        }
        public double GetBynerkh3()
        {
            return db.Tb_FirstOptions.First(i => i.Id == 0).Maliat;
        }

        public DateTime GetbyPastDate(int sub)
        {
            return db.Tb_Bill.First(d => d.SubScribCode == sub).SeenDate;
        }

        public int GetByPelak(int sub)
        {
            return db.Tb_Company.First(d => d.SubscribId == sub).PelakId;
        }

        public string GetByPhoneNumber(int sub)
        {
            return db.Tb_Company.First(d => d.SubscribId == sub).PhoneNumber;
        }

        public string Getbyseendate(int id)
        {
            throw new NotImplementedException();
        }

        public string Getbyseenshamsi(int id)
        {
            return db.Tb_Bill.First(s => s.BillId == id).SeenDateShamsi.ToString();
        }

        public int Getbyshenasname(int melicode)
        {
            return db.Tb_Company.First(t => t.SubscribId == melicode).Shenasname;
        }

        public double GetBySumTotal(int Subcode)
        {
            return db.Tb_Calculate.First(s => s.SubscribCode == Subcode).SumTotal;
        }

       

        public double GetBySumTotalMaliat(int Subcode)
        {
            return db.Tb_Calculate.First(s => s.SubscribCode == Subcode).SumMaliat;
        }

        public int GetByType(int Subcribid)
        {
            throw new NotImplementedException();
        }

        public string GetByTypePublic(int Subscrib)
        {
            return db.Tb_Company.First(s => s.SubscribId == Subscrib).TypePublicService;
        }

        public double GetByUnit(int Subscrirb)
        {
            throw new NotImplementedException();
        }

        public Tb_Calculate GetCalcID(int Calc)
        {
            return db.Tb_Calculate.Find(Calc);
        }

        public Tb_Company GetCompanyByID(int CompanyId)
        {
            return db.Tb_Company.Find(CompanyId);
        }
        public Tb_Debt GetDebtID(int debt)
        {
            return db.Tb_Debt.Find(debt);
        }

        public string GetFindNameCompany(string nameCompany)
        {
            return db.Tb_Company.First(f=>f.CompanyName==nameCompany).CompanyName;
        }

        public string GetFindNameCompanyes(int idCompany)
        {
            return db.Tb_Company.First(i => i.SubscribId == idCompany).CompanyName;
        }

        public List<ListCustomerViewModel> GetNameNerkh(string filter = "")
        {
            if (filter == "")
            {
                return db.NerkhMasraf.Select(c => new ListCustomerViewModel()
                {
                
                    TypeName = c.TypeName,
                    curency = c.Curency
                }).ToList();
            }
            return db.NerkhMasraf.Where(c => c.TypeName.Contains(filter)).Select(c => new ListCustomerViewModel()
            {
               
                TypeName = c.TypeName,
                curency = c.Curency
            }).ToList();
        }

        public Tb_FirstOptions GetOptionsByID(int optionsid)
        {
            return db.Tb_FirstOptions.Find(optionsid);
        }

        public double GeybyIdRecpiet(int sub)
        {
            return  db.Tb_Receipt.First(s => s.SubaScribId == sub).Id;
        }

        public bool InsertBill(Tb_Bill Bill)
        {
            try
            {
                db.Tb_Bill.Add(Bill);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool InsertCalculate(Tb_Calculate calculate)
        {
            try
            {
                db.Tb_Calculate.Add(calculate);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool InsertCompany(Tb_Company Company)
        {
            try
            {
                db.Tb_Company.Add(Company);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool InsertDebt(Tb_Debt debt)
        {
            try
            {
                db.Tb_Debt.Add(debt);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool InsertReciept(Tb_Receipt Reciept)
        {
            try
            {
                db.Tb_Receipt.Add(Reciept);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool UpadateBill(Tb_Bill tbill)
        {
            var local = db.Set<Tb_Bill>()
         .Local
         .FirstOrDefault(f => f.BillId == tbill.BillId);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(tbill).State = EntityState.Modified;
            return true;
        }

        public bool UpadateCalculate(Tb_Calculate calculate)
        {
            var local = db.Set<Tb_Calculate>()
         .Local
         .FirstOrDefault(f => f.CalculateId == calculate.CalculateId);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(calculate).State = EntityState.Modified;
            return true;
        }

        public bool UpadateDebt(Tb_Debt debt)
        {
            var local = db.Set<Tb_Debt>()
          .Local
          .FirstOrDefault(f => f.ID == debt.ID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(debt).State = EntityState.Modified;
            return true;
        }

        public bool UpdateCompany(Tb_Company Company)
        {

            var local = db.Set<Tb_Company>()
           .Local
           .FirstOrDefault(f => f.SubscribId == Company.SubscribId);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(Company).State = EntityState.Modified;
            return true;
        }

        public bool UpdateCountBill(Tb_CountBill Count)
        {
            var local = db.Set<Tb_CountBill>()
        .Local
        .FirstOrDefault(f => f.ID == Count.ID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(Count).State = EntityState.Modified;
            return true;
        }

        public bool UpdateNerkh(NerkhMasraf nerkh)
        {
            var local = db.Set<NerkhMasraf>()
          .Local
          .FirstOrDefault(f => f.TypeName == nerkh.TypeName);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(nerkh).State = EntityState.Modified;
            return true;
        }

        public bool UpdateOptionsFirst(Tb_FirstOptions options)
        {

            var local = db.Set<Tb_FirstOptions>()
           .Local
           .FirstOrDefault(f => f.Id == options.Id);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(options).State = EntityState.Modified;
            return true;
        }

        public List<ListMoshtarakViewModel> GetNameCustomers(string filter = "")
        {
            if (filter == "")
            {
                return db.Tb_Company.Select(c => new ListMoshtarakViewModel()
                {
                    CustomerID = c.SubscribId,
                    FullName = c.CompanyName
                }).ToList();
            }

            return db.Tb_Company.Where(c => c.CompanyName.Contains(filter)).Select(c => new ListMoshtarakViewModel()
            {
                CustomerID = c.SubscribId,
                FullName = c.CompanyName
            }).ToList();
        }

        List<WaterBill_ViewModel.ListCustomerViewModel> IWaterBillRepositori.GetNameNerkh(string filter)
        {
            throw new NotImplementedException();
        }

        public List<Tb_Receipt_calc> GetAllCalcMoshtarak(string sub)
        {
            return db.Tb_Receipt_calc.Where(c => c.Name==sub
            ).ToList();
        }

        public int Getbysubbyname(string name)
        {
            return int.Parse(db.Tb_Company.First(d => d.CompanyName == name).SubscribId.ToString());
        }

        public Tb_Receipt_calc GetReceiptCalcByID(int CompanyId)
        {
            return db.Tb_Receipt_calc.Find(CompanyId);
        }

        public bool UpadateResCalc(Tb_Receipt_calc Receipt)
        {
            var local = db.Set<Tb_Receipt_calc>()
          .Local
          .FirstOrDefault(f => f.Key == Receipt.Key);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(Receipt).State = EntityState.Modified;
            return true;
        }

        public bool InsertRecieptCalc(Tb_Receipt_calc Reciept)
        {
            try
            {
                db.Tb_Receipt_calc.Add(Reciept);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public List<Tb_Receipt_calc> GetAllCalcMoshtarakSum()
        {
            return db.Tb_Receipt_calc.ToList();
        }

        public List<Tb_Receipt_calc> Filldata()
        {
            return null;
          
        }

        public bool DeleteMoshtarakById(int key)
        {
            try
            {
                var company = GetResKey(key);
                DeleteReceipt_Calc(company);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteReceipt_Calc(Tb_Receipt_calc receipt_Calc)
        {
            try
            {
                db.Entry(receipt_Calc).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public Tb_Receipt_calc GetResKey(int key)
        {
            return db.Tb_Receipt_calc.Find(key);
        }

        public List<Tb_Receipt_calc> GetBydateMaxbedehi(DateTime start, DateTime end)
        {
            return db.Tb_Receipt_calc.Where(r => r.datesabt<= start).ToList().Where(t => t.datesabt.Value >= end).ToList();
        }

        public string Getbypaterncode(int loginid)
        {
            return db.Tb_Login.First(y => y.LoginId == loginid).UserName;
        }

        public string GetbyPhoneWithName(string name)
        {
            return db.Tb_Company.First(y => y.CompanyName == name).PhoneNumber.ToString();
        }

        public bool UpadateSmsoptions(Tb_OptionsSms tbsmsoptions)
        {
            var local = db.Set<Tb_OptionsSms>()
          .Local
          .FirstOrDefault(f => f.key == tbsmsoptions.key);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(tbsmsoptions).State = EntityState.Modified;
            return true;
        }

        public bool InsertSms(Tb_PanelSms sms)
        {
            try
            {
                db.Tb_PanelSms.Add(sms);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Tb_PanelSms> Fillsms()
        {
            return db.Tb_PanelSms.ToList();
        }

        public int GetbyMaliat()
        {
            return int.Parse(db.Tb_FirstOptions.First(y => y.Id == 0).Maliat.ToString());

        }

        public string GetbyKhadamat()
        {
            return db.NerkhMasraf.First(a => a.TypeName == "A").Curency.ToString();
        }
    }
}
