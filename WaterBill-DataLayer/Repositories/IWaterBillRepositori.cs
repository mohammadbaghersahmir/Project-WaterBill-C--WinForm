using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterBill_DataLayer.EfModel;
using WaterBill_ViewModel;
using WaterBill_ViewModel.Customer;

namespace WaterBill_DataLayer.Repositories
{
    public interface IWaterBillRepositori
    {
        List<Tb_Receipt> GetBydate(DateTime start, DateTime end);
        List<Tb_Receipt_calc> GetBydateMaxbedehi(DateTime start, DateTime end);

        List<ListMoshtarakViewModel> GetNameCustomers(string filter = "");
        int GetbyCurencyPay(int id);
        List<Tb_Receipt_calc> GetAllCalcMoshtarak(string sub);
        List<Tb_Receipt_calc> GetAllCalcMoshtarakSum();
        List<Tb_Receipt_calc>Filldata();
        List<Tb_PanelSms> Fillsms();
        int GetbyMaliat();
        string GetbyKhadamat();
        string Getbypaterncode(int loginid);
        string GetbyPhoneWithName(string name);
        int Getbysubbyname(string name);
        int GetbyCurencyOfunit(int id);
        string GetbyCodemeli(int sub);
        int Getbyshenasname(int melicode);
        string GetbyFathername(int melicode);
        string GetbyNameinRecpiet(int sub);
        double GetByAmountPast(int sub);
        double GetByAmountNow(int sub);
        double GetByAbuonma();
        double GetBymetraz2();
        double GetBynerkh3();

        double GetByGhotre();

        double GeybyIdRecpiet(int sub);
        double GetbyCurencyinRecpeit(double ID);
        double AmountDebt(int Subcribid);
        string GetByPhoneNumber(int sub);  
       List<Tb_Company> GetAllCompany();
        string GetByDescrib(int sub);
        double AmountLevel(int sub);
        DateTime GetbyPastDate(int sub);
        float GetByCurencyPublic(string Type);
        double GetByCurency(string type);
        string GetByTypePublic(int Subscrib);
        int GetByPelak(int sub);
        string GetFindNameCompany(string nameCompany);
        string GetFindNameCompanyes(int idCompany);
        IEnumerable<Tb_Company> GetAllCompanyFilter(string parameter);
        IEnumerable<Tb_Bill> GetAllBillFilter(string parameter);
        IEnumerable<Tb_Receipt> GetAllRecpietFilter(string parameter);
        List<ListCustomerViewModel> GetNameNerkh(string filter = "");
        List<Tb_FirstOptions> GetAllOptions();
        List<Tb_Bill> GetAllBill();
        List<Tb_Receipt> GetAllReciept();
        Tb_Company GetCompanyByID(int CompanyId);
        Tb_Receipt_calc GetReceiptCalcByID(int CompanyId);
        Tb_Bill GetBillByID(int Bill);
        Tb_Calculate GetCalcID(int Calc);
        Tb_Receipt GetbyIdtolist(int rec);
        Tb_Debt GetDebtID(int debt);
        Tb_Receipt_calc GetResKey(int key);
        bool UpdateCompany(Tb_Company Company);
        bool UpdateNerkh(NerkhMasraf nerkh);
        bool UpdateCountBill(Tb_CountBill Count);
        double GetBySumTotal(int Subcode);
        double GetBySumTotalMaliat(int Subcode);
        bool InsertCompany(Tb_Company Company);
        bool InsertDebt(Tb_Debt debt);
        bool InsertRecieptCalc(Tb_Receipt_calc Reciept);
        bool InsertReciept(Tb_Receipt Reciept);
        bool InsertSms(Tb_PanelSms sms);
        bool InsertCalculate(Tb_Calculate calculate);
        bool InsertBill(Tb_Bill Bill);
        bool DeleteCompany(Tb_Company Company);
        bool DeleteBill(Tb_Bill bill);
        bool DeleteCalc(Tb_Calculate calc);
        bool DeleteDebt(Tb_Debt debt);
        bool DeleteRecpiet(Tb_Receipt rec);
        bool DeleteCompanyById(int companyid);
        bool DeleteMoshtarakById(int key);
        bool DeleteReceipt_Calc(Tb_Receipt_calc receipt_Calc);
        bool DeleteRecpeitById(int Idrecpiet);
        bool DeleteBillById(int companyid);
        bool DeleteCalCulateById(int companyid);
        bool DeleteCalDebtById(int companyid);
        bool UpdateOptionsFirst(Tb_FirstOptions options);
        bool UpadateBill(Tb_Bill tbill);
        bool UpadateDebt(Tb_Debt debt);
        bool UpadateCalculate(Tb_Calculate calculate);
        bool UpadateResCalc(Tb_Receipt_calc Receipt);
        bool UpadateSmsoptions(Tb_OptionsSms tbsmsoptions);
        Tb_FirstOptions GetOptionsByID(int optionsid);
        double GetByBedehi(int subcode);
        double GetByBestankar(int subcode);
        double GetBillId(int IdBill);
        double Amount(int Subcribid);
        List<Tb_FirstOptions> GetAllOptions(int id);
        int GetByType(int Subcribid);
        double GetByCountType(int TypeId);
        int GetByBillIdInBill(int idbill);
        int GetByBillIdInPast(int idbill);
        double GetByUnit(int Subscrirb);
        float GetByAmount(float Subscrib);
        string GetByAddres(int Subscrib);
        double GetByMetercountinBill(double Subcode);
        string Getbyseenshamsi(int id);
        string Getbyseendate(int id);
        
    }
}
