using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DAL
{
    class Context : DbContext
    {
        public Context() : base("strConn")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Contexto>());

            //Database.SetInitializer(new DropCreateDatabaseAlways<Contexto>());

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<SubCategory> subCategories { get; set; }
        public DbSet<TypeOfSkin> typeOfSkins { get; set; }
    }
}
