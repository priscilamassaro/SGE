using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SubCategory
    {
        public int SubCategoryID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // relacionamento
        public int CategoryID { get; set; }

        public virtual Category _Category { get; set; }
    }
}
