using System.ComponentModel.DataAnnotations;

namespace MVCProyecto.Models
{
    public class Proyecto
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de proyecto")]
        [Required(ErrorMessage = "El campo \"Nombre de proyecto\" es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion de proyecto")]
        [Required(ErrorMessage = "El campo \"Descripcion de proyecto\" es obligatorio")]
        public string Descripcion { get; set; }


        [Display(Name = "Fecha de proyecto")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo \"Fecha de proyecto\" es obligatorio")]
        public DateTime FechaProyecto { get; set; }

        //Propiedad de navegacion
        public ICollection<Asignacion> Asignaciones { get; set; }
    }
}
