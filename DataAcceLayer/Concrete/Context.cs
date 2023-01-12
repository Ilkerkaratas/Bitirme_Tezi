using Entitylayer;
using Entitylayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=BitirmeDB;integrated security=true;");
        }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Work>? Works { get; set; }
        public DbSet<OurService>? ourServices { get; set; }
        public DbSet<Announcement>? announcements { get; set; }
        public DbSet<OurTeam>? ourTeams { get; set; }
        public DbSet<Contact>? contacts { get; set; }   
         
    }
}
