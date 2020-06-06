﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FAcT.Models
{
    public class Tasadecambio
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int tasadecambioID { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Codigo Tasa Cambio")]
        public int Codigo { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
    }
}
