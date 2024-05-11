using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.EntityFramework
{
    internal class SimpleTraderDbContextFactory : IDesignTimeDbContextFactory<SimpleTraderDbContext>
    {      

        public SimpleTraderDbContext CreateDbContext(string[] args)
        {
            var optionbuilder = new DbContextOptionsBuilder<SimpleTraderDbContext>();
            optionbuilder.UseSqlServer("Data Source=DESKTOP-2BV8UEP;Initial Catalog=SimpleTraderDB;User ID=sa;Password=LocalAdmin@123;TrustServerCertificate=true");
            return new SimpleTraderDbContext(optionbuilder.Options);
        }
    }
}
