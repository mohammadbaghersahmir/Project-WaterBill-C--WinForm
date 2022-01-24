using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBill
{
   public class Accounting
    {
        private double nerkh1;
        private double nerkh2;
        private double nerkh3;
      
        private double _result;
        public double Nerkh1
        {
            get

            {
                return nerkh1;
            }
            set
            {
                nerkh1 = value;
            }
        }
        public double Nerkh2
        {
            get

            {
                return nerkh2;
            }
            set
            {
                nerkh2 = value;
            }
        }
        public double Nerkh3
        {
            get

            {
                return nerkh3;
            }
            set
            {
                nerkh3 = value;
            }
        }
        public double Result
        {
            get

            {
                return _result;
            }
            set
            {
                _result = value;
            }
        }
        public double Acc(double meter, double unit, double unittasaodi, double sumkhadamat, double metraz, double metraz2, double nerkh3)
        {
            double result1, result2, result3;

            if (meter >= metraz && meter <= metraz2)
            {
                result1 = ((meter - metraz) * unittasaodi);
                Nerkh2 = result1;
                result2 = metraz * unit;
                Nerkh1 = result2;
                result1 = result1 + result2+sumkhadamat;
                Nerkh3 = 0;
            }
             if (meter >= metraz && meter >= metraz2)
            {
                result1 = metraz * unit;
                Nerkh1 = result1;
                result2 = (metraz2 - metraz) * unittasaodi;
                Nerkh2 = result2;
                result3 = (meter - metraz2) * nerkh3 ;
                result1 = result1 + result2 + result3+ sumkhadamat;
                Nerkh3 = result3;
            }
            else if(meter <= metraz)
            {
                result1 = (meter * unit) + sumkhadamat;
                Nerkh1 = (meter*unit);
                Nerkh2 = 0;
                Nerkh3 = 0;
            }
             else
            {
                result1 = 0;
            }
            return result1;
        }
    }
}
