using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    public class DbContextRepository:DbContext
    {
        public DbContextRepository(DbContextOptions options):base(options) {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CRecevier> CReceviers { get; set; }
        public DbSet<Desposit> Desposits { get; set; }
        public DbSet<Financal_Transaction> Financal_Transactions { get; set; }
        public DbSet<Sales_voucher> Sales_Vouchers { get; set; }
        public DbSet<Shopping_Voucher> Shopping_Vouchers { get; set; }
        public DbSet<Trader> Traders { get; set; }
    }
}
