using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipEF_LoadingDb_18._07_WF.Model
{
     class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductionHouse> ProductionHouse { get; set; }


        public LibraryContext() : base("LibraryBD")
        {

        }
    }
}
