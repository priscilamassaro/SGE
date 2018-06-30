using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public string Name { get; set; }

        // relacionamento
        public int CategoryID { get; set; }
       
        public virtual Category _Category { get; set; }
                
        public int TypeOfSkinID { get; set; }

        public virtual TypeOfSkin _TypeOfSkin { get; set; }
      
        public int Quantity { get; set; }

        public double Price { get; set; }

        public bool Available { get; set; }
    }
}
