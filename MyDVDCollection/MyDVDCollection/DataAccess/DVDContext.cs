using MyDVDCollection.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
	

namespace MyDVDCollection.DataAccess
{
    public class DVDContext : DbContext
    {
        public DVDContext() : base("DVDContext")
        {
        }

        public DbSet<Titles> Titles { get; set; }
        

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    
}