using aspcoredemo.Models;
using Microsoft.EntityFrameworkCore;

namespace aspcoredemo.Data
{
    public class studentdbcontext:DbContext
    {
        //ctor double tab creates constructor
        public studentdbcontext(DbContextOptions<studentdbcontext>o)
            :base(o)
        {
                
        }

        public DbSet<studentregister> student { get; set; }  //studentregister->modal class name & student is table name


    }
}
