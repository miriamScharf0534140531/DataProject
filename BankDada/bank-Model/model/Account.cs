using bank_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model.model
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [Required]
        public int AccountId { get; set; }
        public int AccountNum { get; set; }

        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer CustomerDetail { get; set; }

            
    }
}
