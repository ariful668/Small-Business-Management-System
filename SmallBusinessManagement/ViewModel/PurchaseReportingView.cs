using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagement.ViewModel
{
    public class PurchaseReportingView
    {
        public string PurchaseDate { set; get; }
        public string Code { set; get; }
        public string Product { set; get; }
        public string Category { set; get; }
        public int AvailableQuantiy { set; get; }
        public double CP { set; get; }
        public double Salesprice { set; get; }
        public double Profit { set; get; }
    }
}
