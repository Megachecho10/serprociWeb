using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("Almacen")]
    public class Almacen
    {
        [Key]
        [Display(Name = "Id Almacen")]
        public int IdAlmacen { get; set; }

        [Display(Name = "Id Empresa")] 
        public int IdEmpresa { get; set; }

        [Display(Name = "Codigo Almacen")]
        [Index(IsUnique = true)]
        [StringLength(5)]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        public string CodigoAlmacen { get; set; }

        [Display(Name = "Nombre Almacen")]
        [StringLength(50)]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        public string NombreAlmacen { get; set; }

        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa { get; set; }

    }
}