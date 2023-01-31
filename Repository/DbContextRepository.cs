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
            modelBuilder.Entity<Client>(clientSetting =>
            {
                clientSetting.HasIndex(cl => cl.Client_parCode).IsUnique();
                //clientSetting.Property(cl => cl.Client_parCode).HasComputedColumnSql("Concat(Format(GETDATE(), '%m%d'),Client_id)");
                clientSetting.HasCheckConstraint("client_account_ch", "Client_money >= 0");

            });
            modelBuilder.Entity<Trader>(traderSetting =>
            {
                traderSetting.HasIndex(cl => cl.Tad_parCode).IsUnique();
                //traderSetting.Property(cl => cl.Tad_parCode).HasComputedColumnSql("Concat(Format(GETDATE(), '%m%d'),Tad_id)");
            });

           

            modelBuilder.Entity<Financal_Transaction>(FTSetting =>
            {
                FTSetting.HasCheckConstraint("FT_date_ch", "FT_date >= getdate()");
                FTSetting.HasCheckConstraint("FT_transeredAmount_ch", "FT_tranferedAmount>=0");
                FTSetting.HasCheckConstraint("FT_exchangeRate_ch", "FT_exchangeRate>=0");
                FTSetting.HasCheckConstraint("FT_amount_ch", "FT_amount>=0");
            });

            modelBuilder.Entity<Desposit>(DepSetting =>
            {
                DepSetting.HasCheckConstraint("Despt_amount_prv_ch", "Despt_money_prv > 0");
                DepSetting.HasCheckConstraint("Despt_amount_add_ch", "Despt_money_add > 0");
                DepSetting.HasCheckConstraint("Despt_amount_now_ch", "Despt_money_now > 0");
                DepSetting.HasCheckConstraint("Despt_date_ch", "Despt_date >= getdate()");

            });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CRecevier> CReceviers { get; set; }
        public DbSet<Desposit> Desposits { get; set; }
        public DbSet<Financal_Transaction> Financal_Transactions { get; set; }
        public DbSet<Sales_voucher> Sales_Vouchers { get; set; }
        public DbSet<Shopping_Voucher> Shopping_Vouchers { get; set; }
        public DbSet<Trader> Traders { get; set; }
        public DbSet<withdrawal> Withdrawals { get; set; }
    }
}
