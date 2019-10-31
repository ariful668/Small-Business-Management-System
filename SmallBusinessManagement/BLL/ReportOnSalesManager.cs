using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SmallBusinessManagement.Model;
using SmallBusinessManagement.ViewModel;
using SmallBusinessManagement.Repository;

namespace SmallBusinessManagement.BLL
{
    public class ReportOnSalesManager
    {
        ReportOnSalesRepository _reportOnSalesRepository = new ReportOnSalesRepository();

        public List<SalesReportingView> SearchValue(string Date, string Date2)
        {
            return _reportOnSalesRepository.SearchValue(Date, Date2);
        }
        public List<SalesReportingView> Display(SalesReportingView salesReportingView)
        {
            return _reportOnSalesRepository.Display(salesReportingView);
        }
    }
}
