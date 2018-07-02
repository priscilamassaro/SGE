using Controller.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ProductController
    {
        private Context context = new Context();

        public void AddProduct(Product entity)
        {
            entity.Available = true;
            context.products.Add(entity);
            context.SaveChanges();
        }

        public Product FindByID(int id)
        {
            return context.products.Find(id);
        }

        public void Edit(Product entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product prod = FindByID(id);

            if (prod != null)
            {
                context.products.Remove(prod);
            }
        }  

        public IList<Product> ListByName(string name)
        {
            return context.products.Where(prod => prod.Name == name).ToList();
        }

        public IList<Product> ListAll()
        {
            return context.products.ToList();
        }
    }
}
