using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagement.Repository;
using SmallBusinessManagement.BLL;

namespace SmallBusinessManagement.Model
{
    public class Purchase
    {   
        public DateTime Date1 { set; get; }
        public int  Purchase_Id { get; set; }
        public string ProuctCode { set; get; }
        public string InvoiceNo { set; get; }
        public string Code { get; set; }
        public string SupplierName { get; set; }
        public int Supplier_id { get; set; }
        public int category_id { get; set; }
        public int Product_id { get; set; }
        public string ProductName { get; set; }
        public DateTime Manufacture_Date { get; set; }
        public DateTime Expire_Date { get; set; }
        public int Quantity { get; set; }
        public double Unit_Price { get; set; }
        public double MRP { get; set; }
        public string Remarks { get; set; }

        public double TotalPrice { get; set; }
        public DateTime Date2 { set; get; }

    }
}
