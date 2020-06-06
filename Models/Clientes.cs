using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Clientes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int clienteID { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Codigo Cliente")]
        public int Codigo { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Cliente")]
        public string nombre { get; set; }


        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellidos Cliente")]
        public string apellidos { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Documento Cliente ")]
        public string Documento { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Direccion Cliente")]
        public string Direccion { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Telefono Cliente")]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Celelular Cliente")]
        public string Celular { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Correo Cliente")]
        public string Correo { get; set; }


        [Required]
        [Display(Name = "tipoDocumento")]
        [ForeignKey("tipodocumento")]
        public int tipodocumentoID { get; set; }
        public Tiposdocumentos tiposdocumentos { get; set; }


        [Required]
        [Display(Name = "Pais")]
        [ForeignKey("Pais")]
        public int paisID { get; set; }
        public Pais Pais { get; set; }


        [Required]
        [Display(Name = "Provincia")]
        [ForeignKey("Provincia")]
        public int provinciaID { get; set; }
        public  Provincia Provincia { get; set; }

        [Required]
        [Display(Name = "Municipio")]
        [ForeignKey("Municipio")]
        public int municipioID { get; set; }
        public Municipio Municipio { get; set; }


        [Required]
        [Display(Name = "Sector")]
        [ForeignKey("Sector")]
        public int sectorID { get; set; }
        public Sector Sector { get; set; }



    }
}
