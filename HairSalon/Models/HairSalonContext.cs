using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace HairSalon.Models

{

    public class HairSalonContext : DbContext
    {
        public DbSet<Stylist> stylists { get; set; }
        public DbSet<Client> clients { get; set; }
        public HairSalonContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }

}