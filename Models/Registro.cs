using System.ComponentModel.DataAnnotations;

namespace prg.Models
{
    public class Registro
    {
        [Required]
        [Display(Name="Ingrese su nombre: ")]
        public string nombre { get; set; }

        [Required]
        [Display(Name="Ingrese el precio: ")]
        public int precio { get; set; }
        

        [Required]
        [Display(Name="Ingrese una descripcion: ")]
        public string descripcion { get; set; }
    }
}
