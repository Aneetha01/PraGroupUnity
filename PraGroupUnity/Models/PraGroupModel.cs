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

        [Required(ErrorMessage = "Please select Widget")]
        public int SelectedWidgetId { get; set; }

        [Required(ErrorMessage = "Please select State")]
        public int SelectedStateId { get; set; }

        public int SalesTax { get; set; }

        public int Discount { get; set; }

        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Qty must be a natural number")]
        public int WidgetQty { get; set; }

        public decimal BasePrice { get; set; }
        public decimal GrandTotal { get; set; }
    }

   
}