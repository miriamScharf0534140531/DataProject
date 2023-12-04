using Bank.Model.model;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service.DAL
{
    public class BankRepository : IBankRepository
    {
        readonly BankContext _BankContext;
        public BankRepository(BankContext bankContext)
        {
            _BankContext = bankContext;
        }

        public List<Customer> GetAll()
        {
            return _BankContext.customers.ToList();
        }
        public bool AddCustomer(Customer c)
        {
            try
            {
                _BankContext.Add(c);
                _BankContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Customer GetCustomerByTz(string Tz)
        {
            return _BankContext.customers.Where(t => t.Tz == Tz).FirstOrDefault();
        }

        public bool deleteCustomer(string c)
        {
            try
            {
                Customer customer = _BankContext.customers.Where(t => t.Tz == c).FirstOrDefault();
                if (customer != null)
                {
                    _BankContext.Remove(customer);
                    _BankContext.SaveChanges();
                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
