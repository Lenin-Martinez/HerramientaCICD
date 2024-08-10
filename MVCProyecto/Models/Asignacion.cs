using MVCProyecto.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProyecto.Models
{
    public class Asignacion
    {
        public int ID { get; set; }

        [Display(Name = "Actividad realizada")]
        [Required(ErrorMessage = "El campo \"Actividad realizada\" es obligatorio")]
        public string Rol { get; set; }

        [Display(Name = "Fecha de asignacion")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo \"Fecha de asignacion\" es obligatorio")]
        public DateTime FechaAsignacion { get; set; }


        //Llave foranea
        [Required]
        [ForeignKey("Empleado")]
        [Display(Name = "Empleado asignado")]
        public int? EmpleadoId { get; set; }

        //Propiedad de navegacion
        public Empleado Empleado { get; set; }


        //Llave foranea
        [Required]
        [ForeignKey("Proyecto")]
        [Display(Name = "Proyecto asignado")]
        public int? ProyectoId { get; set; }

        //Propiedad de navegacion
        public Proyecto Proyecto { get; set; }

    }
}
