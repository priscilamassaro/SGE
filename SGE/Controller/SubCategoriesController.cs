using Controller.DAL;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class SubCategoriesController
    {
        Context ctx = new Context();

        public List<SubCategory> ListAll()
        {
            return ctx.subCategories.ToList();
        }
    }
}
