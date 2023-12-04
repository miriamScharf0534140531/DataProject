using Bank.Model.model;
using Bank.Service.BL;
using Microsoft.AspNetCore.Mvc;

namespace BankDada.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        readonly IBankService _BankService;

        public CustomerController(IBankService bankService)
        {
            _BankService = bankService;
        }
        [HttpGet]
        public List<Customer> Get()
        {
            return _BankService.getAll();
        }
        [HttpPost]
        public ActionResult Post(Customer c)
        {
            bool? s = _BankService.AddCustomer(c);
            if (s == null)
                return NoContent();
            if (s.Value)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("getByTz")]
        public Customer GetId(string s)
        {
            
            return _BankService.getCustomerByTz(s);
        }
        [HttpDelete]
        public ActionResult Delete(string tz)
        {
            bool? s = _BankService.DeleteCustomer(tz);
            if (s == null)
                return NoContent();
            if (s.Value)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}
