using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("Proveedor")]
    public class Proveedor
    {
        [Key]
        [Display(Name = "Id Proveedor")]
        public int IdProveedor { get; set; }

        [Display(Name = "Nombre Proveedor")]
        [Index(IsUnique = true)]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [StringLength(50)]
        public string ProveedorName { get; set; }

        [Display(Name = "Razon Social")]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [StringLength(50)]
        public string RazonSocial { get; set; }

        [Display(Name = "Numero Ruc")]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [StringLength(50)]
        public string NumeroRuc { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(8)]
        [Required(ErrorMessage = "El CAMPO {0} REQUERIDO")]
        public string Telefono { get; set; }

        [Display(Name = "Direccion")]
        [StringLength(200)]
        [Required(ErrorMessage = "El CAMPO {0} REQUERIDO")]
        public string Direccion { get; set; }

        [Display(Name = "CorreoElectronico")]
        [StringLength(60)]
        public string CorreoElectronico { get; set; }

    }
}