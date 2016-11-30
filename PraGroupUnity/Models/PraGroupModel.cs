using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PraGroup;
using System.ComponentModel.DataAnnotations;
using PraGroupUnity;

namespace PraGroup.Models
{
    public class PraGroupModel
    {
        public List<Widgets> wd { get; set; }
        public List<States> state { get; set; }

        public int SelectedWidgetId { get; set; }
        public int SelectedStateId { get; set; }

        public int SalesTax { get; set; }

        public int Discount { get; set; }

        public int WidgetQty { get; set; }

        public decimal BasePrice { get; set; }
        public decimal GrandTotal { get; set; }
    }
}