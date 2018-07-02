using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SubCategory
    {
        public int SubCategoryID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Name { get; set; }

        //// relacionamento
        //public int CategoryID { get; set; }

        //public virtual Category _Category { get; set; }
    }
}
