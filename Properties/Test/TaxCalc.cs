﻿namespace AP.Properties.Test
{
    public delegate float TaxMoney(float salary);
    public class TaxCalc
    {
        public static float VietNamTax(float salary)
        {
            return 10 * salary / 100;
        }

        public static float USATax(float salary)
        {
            return 15 * salary / 100;
        }

        public static float OtherTax(float salary)
        {
            return 5 * salary / 100;
        }
        //viet ham tra ve mot ham bang delegate

        public static TaxMoney GetTax(string country)
        {
            if (country=="VN")
            {
                return VietNamTax;
            }
            else if (country == "US")
            {
                return USATax;
            }
            else
            {
                return OtherTax;
            }
        }
    }
}