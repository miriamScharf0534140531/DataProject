using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model.model
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerId { get; set; }
        [MinLength(9)]
        [MaxLength(9)]
        public string  Tz { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]

        public Employee EmployeeOfCustomer { get; set; }

    }
}
