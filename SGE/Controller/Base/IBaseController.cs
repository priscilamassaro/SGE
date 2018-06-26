using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Base
{
    interface IBaseController<T> where T : class
    {
        void AddProduct(T entity);
        IList<T> ListAll();

        IList<T> ListByName(string nome);

        T FindByID(int id);

        void Edit(T entity);

        void Delete(int id);

        IList<T> ListCategoryOptions();
    }
}
