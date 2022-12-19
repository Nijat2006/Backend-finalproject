using BackendFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BackendFinal.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public  DbSet<Settings> Settings{ get; set; }
        public  DbSet<About> Abouts{ get; set; }
        public DbSet<Courses> Courses  { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Teacher>  teachers{ get; set; }


    }
}
