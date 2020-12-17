using ExampleProject1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject1.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) {}

        public DbSet<Customer> Customer { get; set; }
    }

    //create database using EF:
    // - Add-Migration yourMigrationName
    // - update-database
}
