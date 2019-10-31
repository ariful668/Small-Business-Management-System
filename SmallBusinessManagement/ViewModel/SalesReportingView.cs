using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagement.ViewModel
{
    public class SalesReportingView
    {

        public string SalesDate { set; get; }
        public string Code { set; get; }
        public string Product { set; get; }
        public string Category { set; get; }
        public int Sold_Qty { set; get; }
        public double CP { set; get; }
        public double Sales_price { set; get; }
        public double Profit { set; get; }
    }
}
