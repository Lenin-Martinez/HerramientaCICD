using System.ComponentModel.DataAnnotations;

namespace MVCProyecto.Models
{
    public class Empleado
    {

        public int Id { get; set; }

        [Display(Name = "Nombre de empleado")]
        [Required(ErrorMessage = "El campo \"Nombre de empleado\" es obligatorio")]
        public string Nombre { get; set; }


        [Display(Name = "Apellido de empleado")]
        [Required(ErrorMessage = "El campo \"Apellido de empleado\" es obligatorio")]
        public string Apellido { get; set; }


        [Display(Name = "Fecha de contrato")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo \"Fecha de contrato\" es obligatorio")]
        public DateTime FechaContrato { get; set; }


        [Display(Name = "Puesto de contratacion")]
        [Required(ErrorMessage = "El campo \"Puesto de contratacion\" es obligatorio")]
        public string Puesto { get; set; }


        //Propiedad de navegacion
        public ICollection<Asignacion> Asignaciones { get; set; }
    }
}
