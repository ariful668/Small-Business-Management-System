using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SmallBusinessManagement.Model;
using SmallBusinessManagement.Repository;

namespace SmallBusinessManagement.BLL
{
    public class ReportOnSalesManager
    {
        ReportOnSalesRepository _reportOnSalesRepository = new ReportOnSalesRepository();

        public DataTable Search(Sales sales)
        {
            return _reportOnSalesRepository.Search(sales);
        }
    }
}
