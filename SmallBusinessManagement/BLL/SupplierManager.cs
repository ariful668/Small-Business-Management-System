using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SmallBusinessManagement.Repository;
using SmallBusinessManagement.Model;

namespace SmallBusinessManagement.BLL
{
   public class SupplierManager
    {
        SupplierRepository _supplierrepository = new SupplierRepository();
        public bool Add(Supplier supplier)
        {
            return _supplierrepository.Add(supplier);
        }
        public bool IsCodeExist(Supplier supplier)
        {
            return _supplierrepository.IsCodeExist(supplier); 
        }
        public bool IsContactExist(Supplier supplier)
        {
            return _supplierrepository.IsContactExist(supplier);
        }
        public bool IsEmailExist(Supplier supplier)
        {
            return _supplierrepository.IsEmailExist(supplier);
        }
        public bool Update(Supplier supplier)
        {
            return _supplierrepository.Update(supplier);

        }
        public DataTable Display()
        {
            return _supplierrepository.Display();
        }
        public DataTable Search(string contact, string name, string email)
        {
            return _supplierrepository.Search(contact, name, email);
        }
    }

}
