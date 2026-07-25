using System.ComponentModel.DataAnnotations;

namespace SalesCET105.Web.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name ="Pais")]
        [MaxLength(50, ErrorMessage = "O campo {0} dever ter no maximo {1} caracters!")]
        [Required(ErrorMessage ="O campo {0} e obrigatorio!")]
        public string Name { get; set; }
    }
}
