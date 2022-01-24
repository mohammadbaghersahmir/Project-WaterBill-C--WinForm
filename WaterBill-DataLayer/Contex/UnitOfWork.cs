using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterBill_DataLayer.EfModel;
using WaterBill_DataLayer.Repositories;
using WaterBill_DataLayer.Services;
namespace WaterBill_DataLayer.Contex
{
    public class UnitOfWork : IDisposable
    {
        DbWaterBillEntities db = new DbWaterBillEntities();


        private IWaterBillRepositori _companyrepository;
        public IWaterBillRepositori Company
        {
            get
            {

                if (_companyrepository == null)
                {
                    _companyrepository = new RepositoriWaterBill(db);
                }
                return _companyrepository;

            }
        }
        private GenericRepositori<Tb_Company> _companyRepository;

        public GenericRepositori<Tb_Company> CompanyRepository
        {
            get
            {
                if (_companyRepository == null)
                {
                    _companyRepository = new GenericRepositori<Tb_Company>(db);
                }

                return _companyRepository;
            }
        }
        private GenericRepositori<Tb_FirstOptions> _optionsRepository;

        public GenericRepositori<Tb_FirstOptions> OptionsRepository
        {
            get
            {
                if (_optionsRepository == null)
                {
                    _optionsRepository = new GenericRepositori<Tb_FirstOptions>(db);
                }

                return _optionsRepository;
            }
        }
        private GenericRepositori<Tb_Login> _companylogin;
        public GenericRepositori<Tb_Login> companylogin
        {
            get
            {
                if (_companylogin == null)
                {
                    _companylogin = new GenericRepositori<Tb_Login>(db);
                }

                return _companylogin;
            }
        }
        private GenericRepositori<Tb_OptionsSms> _optionssms;
        public GenericRepositori<Tb_OptionsSms> optionssms
        {
            get
            {
                if (_optionssms == null)
                {
                    _optionssms = new GenericRepositori<Tb_OptionsSms>(db);
                }

                return _optionssms;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
