using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Web.Models.Almacen.Articulo
{
    public class CrearViewModel
    {
        [Required]
        public int idcategoria { get; set; }
        public string codigo { get; set; }
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "El nombre no debe tener más de {1} caracteres, ni menos de {0} caracteres")]
        public string nombre { get; set; }
        [Required]
        [Column(TypeName = "decimal(11,2)")]
        public decimal precio_venta { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }

    }
}
