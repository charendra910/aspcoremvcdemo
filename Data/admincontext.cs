using aspcoredemo.Models;
using Microsoft.EntityFrameworkCore;

namespace aspcoredemo.Data
{
    public class admincontext:DbContext
    {
        public admincontext(DbContextOptions<admincontext> obj)
        :base(obj)
        { 
            
        }
        public DbSet<table1> admin { get; set; }
    }
}


