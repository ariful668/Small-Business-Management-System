using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagement.Repository;
using SmallBusinessManagement.Model;
using System.Data;

namespace SmallBusinessManagement.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }
        public bool IsCodeExist(Customer customer)
        {
            return _customerRepository.IsCodeExist(customer);
        }
        public bool IsContactExist(Customer customer)
        {
            return _customerRepository.IsContactExist(customer);
        }
        public bool IsEmailExist(Customer customer)
        {
            return _customerRepository.IsEmailExist(customer);
        }
        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);

        }
        public DataTable Display()
        {
            return _customerRepository.Display();
        }
        public DataTable Search(string contact, string name, string email)
        {
            return _customerRepository.Search(contact, name, email);
        }
    }
}
