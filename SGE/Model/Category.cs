using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Category 
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Name { get; set; }


    }
}
