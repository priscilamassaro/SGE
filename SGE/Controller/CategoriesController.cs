using Controller.DAL;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class CategoriesController
    {
        Context ctx = new Context();

        public List<Category> ListAll()
        {
            return ctx.categories.ToList();
        }
    }
}
