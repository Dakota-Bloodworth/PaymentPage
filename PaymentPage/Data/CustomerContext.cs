using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentPage.Models;
using Microsoft.EntityFrameworkCore;

namespace PaymentPage.Models.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> Options) : base(Options)
        {

        }
        public DbSet<CustInfo> CustInfo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<CustInfo>().ToTable("CustLogin");
            modelbuilder.Entity<Payment>().ToTable("PaymentInfo");
        }
    }
}
