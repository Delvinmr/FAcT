using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Empleado
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int empleadoID { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Codigo Empleado")]
        public int Codigo { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Empleado")]
        public string nombre { get; set; }


        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellidos Empleado")]
        public string apellidos { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Documento Empleado")]
        public string Documento { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Direccion Empleado")]
        public string Direccion { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Telefono Empleado")]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Celelular Empleado")]
        public string Celular { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Correo Empleado")]
        public string Correo { get; set; }

        [Required]
        [Display(Name = "Empresa")]
        [ForeignKey("Empresa")]
        public int empresaID { get; set; }
        public Empresa Empresa { get; set; }

        [Required]
        [Display(Name = "Puesto de Trabajo")]
        [ForeignKey("Puestodetrabajo")]
        public int puestodetrabID { get; set; }
        public Puestodetrabajo Puestodetrabajo { get; set; }

    }
}
