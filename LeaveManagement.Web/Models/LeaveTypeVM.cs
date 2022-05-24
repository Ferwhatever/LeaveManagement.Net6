using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Tipo de permiso")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Name { get; set; }
        [Display(Name="Numero de dias")]
        [Range(1,25,ErrorMessage ="Ingresa un numero Valido [1/25 dias]")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int DefaultDays { get; set; }
    }
}
