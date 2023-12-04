using Bank.Model.model;
using Bank.Service.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.BL
{
    public class BankService : IBankService
    {
        readonly IBankRepository _BankRepository;
        public BankService(IBankRepository bankRepository)
        {
            _BankRepository = bankRepository;
        }

        public bool? AddCustomer(Customer c)
        {
            Customer customer = _BankRepository.GetCustomerByTz(c.Tz);
            if(customer != null)
                return null;
            return _BankRepository.AddCustomer(c);
        }

        public bool? DeleteCustomer(string tz)
        {
           Customer c= _BankRepository.GetCustomerByTz(tz);
            if (c != null)
                return _BankRepository.deleteCustomer(tz);
            return null;
        }

        public List<Customer> getAll()
        {
            return _BankRepository.GetAll();
        }

        public Customer getCustomerByTz(string Tz)
        {
            return _BankRepository.GetCustomerByTz(Tz);
        }
    }
}
