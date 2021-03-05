
using DomainLayer.Models;
using System.Collections.Generic;

namespace ServicesLayer.CustomerService
{
   public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomer(int id);
        void InsertCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
