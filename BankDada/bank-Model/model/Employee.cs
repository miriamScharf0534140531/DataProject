using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model.model
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Required]
        public int IdEmployee { get; set; }
        public string NameEmployee { get; set; }
        public string PhoneEmployee { get; set; }
        public int Salary { get; set; }
    }
}
