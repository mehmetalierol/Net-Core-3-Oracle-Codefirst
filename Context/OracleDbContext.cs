using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Net_Core_3_Oracle_Codefirst.Entities;
using System;

namespace Net_Core_3_Oracle_Codefirst.Context
{
    public class OracleDbContext : DbContext
    {
        #region Constructor

        public OracleDbContext(DbContextOptions<OracleDbContext> options)
            : base(options)
        {

        }

        #endregion Constructor

        #region ModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        #endregion ModelCreating

        #region OnConfiguring

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseOracle(config.GetConnectionString("DefaultConnection"));
        }

        #endregion OnConfiguring

        #region DbSets

        public DbSet<EntityUser> EntityUser { get; set; }

        #endregion DbSets

    }
}
