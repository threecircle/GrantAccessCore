using System;
using GrantAccessCore.Models;
using Microsoft.EntityFrameworkCore;

namespace GrantAccessCore
{
	public class DBContextPg : DbContext
	{
		public DbSet<Project> Projects { get; set; }

        

        readonly private string connectString;

        public DBContextPg(IConfiguration config)
        {
            connectString = config["Connections:PostgreSQL"];

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseNpgsql(connectString).UseSnakeCaseNamingConvention();

        }
    }
}

