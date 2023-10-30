using System.ComponentModel.DataAnnotations;

namespace InduMovel.Models
{
    public class Categoria
    { 
        [Key]
        [Display(Name ="Código")]
        public int CategoriaId {get;set;}
        [Display(Name ="Nome da Categoria")]
        [Required(ErrorMessage = "Informe o nome da Categoria")]
        public string Nome {get;set;}
        
        public List<Movel> Moveis{get;set;}
    }
}