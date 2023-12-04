using Bank.Model.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.BL
{
    public interface IBankService
    {
        bool? AddCustomer(Customer c);
        List<Customer> getAll();
        Customer getCustomerByTz(string Tz);
        bool? DeleteCustomer(string tz);
    }
}
