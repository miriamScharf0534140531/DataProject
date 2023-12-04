using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model.model
{
    [Table("Moves")]
    internal class Moves
    {
        [Key]
        [Required]
        public int IdMoves { get; set; }
        [Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateMove { get; set; }
        public Account AccountId { get; set; }
        public string DescriptionMove { get; set; }
        public int SumMove { get; set; }
    }
}
