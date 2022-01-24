using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBill
{
   public class Calculate
    {
        public double CalculateCountMeter(double meternow,double meterpast)
        {
            double result;
            result = meternow-meterpast;
            return result;   
        }
        public double CalcPay(double bestankar,double bedehi)
        {
            double result;
            result = bestankar + bedehi;
            return result;
        }
        public double Accounting(double meter,int unit,int unittasaodi,int sumkhadamat,double metraz,double metraz2,int nerkh3,bool flag)   
             {
            double result1,result2,result3;
            if (!flag)
            {
                if (meter >= metraz && meter <= metraz2 && !flag)
                {
                    result1 = ((meter - metraz) * unittasaodi);
                    result2 = metraz * unit + sumkhadamat;
                    result1 = result1 + result2;
                }
                else if (meter >= metraz && meter >= metraz2)
                {
                    result1 = metraz * unit;
                    result2 = (metraz2 - metraz) * unittasaodi;
                    result3 = (meter - metraz2) * nerkh3 + sumkhadamat;
                    result1 = result1 + result2 + result3;
                }
                else
                {
                    result1 = (meter * unit)+ sumkhadamat;
                }
            }
            else
            {
                result1 = (meter *nerkh3) + sumkhadamat;
            }
            return result1;
        }
        public double AcountingFinaly(double SumKol, double bestankari, double bedehkar)
        {
            double res,view;
           view= (bestankari + (bedehkar*-1))*-1;
            if (view >= 0)
            {
                res = SumKol + view;
            }
            else if (view < 0)
            {
                res = (SumKol - (view * -1));
            }
            else
                res = 0;
            return res;
        }
        public double AcountingFinalyBedehi(double SumKol, double bedehkar)
        {
            double res;
            res = SumKol + bedehkar*-1;
            return res;
        }
    }
}
