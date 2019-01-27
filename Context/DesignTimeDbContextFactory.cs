using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Net_Core_3_Oracle_Codefirst.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OracleDbContext>
    {
        public OracleDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<OracleDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseOracle(connectionString);
            return new OracleDbContext(builder.Options);
        }
    }
}
