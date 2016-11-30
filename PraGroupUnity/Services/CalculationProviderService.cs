using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PraGroupUnity.Services
{
    public class CalculationProviderService : ICalculation
    {
        public decimal BasePrice(decimal price, int qty)
        {
            return price * qty;
        }

        public decimal GrandTotal(decimal baseprice, int discount, int tax)
        {
            return (baseprice - GetPercent(discount, baseprice)) + GetPercent(tax, baseprice);
        }

        private decimal GetPercent(int percent, decimal value)
        {
            if (percent > 0)
                return value * percent / 100;
            else
                return 0;
        }
    }
}