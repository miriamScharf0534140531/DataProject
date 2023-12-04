using Bank.Model.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class BankContext : DbContext
    {

        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {

        }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Moves> moves { get; set; }
    }
}
