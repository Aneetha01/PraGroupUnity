using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraGroupUnity.Services
{
    public interface ICalculation
    {
        decimal BasePrice(decimal price, int qty);

        decimal GrandTotal(decimal baseprice, int discount, int tax);
    }
}

