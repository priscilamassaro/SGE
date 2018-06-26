using Controller.DAL;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class TypeOfSkinController
    {
        Context ctx = new Context();

        public List<TypeOfSkin> ListAll()
        {
            return ctx.typeOfSkins.ToList();
        }
    }
}
