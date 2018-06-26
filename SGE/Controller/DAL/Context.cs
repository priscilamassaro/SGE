using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DAL
{
    public class Context : DbContext
    {
        public Context() : base("strConn")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Contexto>());

            //Database.SetInitializer(new DropCreateDatabaseAlways<Contexto>());

            Database.SetInitializer(new ContextInitializer());
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<SubCategory> subCategories { get; set; }
        public DbSet<TypeOfSkin> typeOfSkins { get; set; }


    }


    class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            context.categories.Add(new Category { Name = "Cuidados com a Pele" });
            context.categories.Add(new Category { Name = "Maquiagem" });
            context.categories.Add(new Category { Name = "Corpo & Sol" });
            context.categories.Add(new Category { Name = "Fragrâncias" });
            context.categories.Add(new Category { Name = "Homens" });

            context.subCategories.Add(new SubCategory { Name = "Botanical Effects", CategoryID=1 });
            context.subCategories.Add(new SubCategory { Name = "TimeWise", CategoryID = 1 });
            context.subCategories.Add(new SubCategory { Name = "TimeWise Repair", CategoryID = 1 });
            context.subCategories.Add(new SubCategory { Name = "Cuidados com a Pele com Tendência à Acne", CategoryID = 1 });
            context.subCategories.Add(new SubCategory { Name = "MKMen", CategoryID = 1 }); 
            context.subCategories.Add(new SubCategory { Name = "Satin Lips", CategoryID = 1 });

            context.typeOfSkins.Add(new TypeOfSkin { Type = "Seca" });
            context.typeOfSkins.Add(new TypeOfSkin { Type = "Normal" });
            context.typeOfSkins.Add(new TypeOfSkin { Type = "Normal a Seca" });
            context.typeOfSkins.Add(new TypeOfSkin { Type = "Mista" });
            context.typeOfSkins.Add(new TypeOfSkin { Type = "Mista a Oleosa" });                         
            context.typeOfSkins.Add(new TypeOfSkin { Type = "Oleosa" });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}