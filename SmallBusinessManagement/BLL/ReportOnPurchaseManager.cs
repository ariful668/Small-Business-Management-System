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
    public class ReportOnPurchaseManager
    {
        ReportOnPurchaseRepository _reportOnPurchaseRepository = new ReportOnPurchaseRepository();
        public List<PurchaseReportingView> SearchValue(string Date, string Date2)
        {
            return _reportOnPurchaseRepository.SearchValue(Date, Date2);
        }
        public List<PurchaseReportingView> Display(PurchaseReportingView purchaseReportingView)
        {
            return _reportOnPurchaseRepository.Display(purchaseReportingView);
        }
    }
}
