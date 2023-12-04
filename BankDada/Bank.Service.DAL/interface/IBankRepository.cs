using Bank.Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.DAL
{
    public interface IBankRepository
    {
        List<Customer> GetAll();
        bool AddCustomer(Customer c);
        Customer GetCustomerByTz(string Tz);
        bool deleteCustomer(string c);
    }
}
