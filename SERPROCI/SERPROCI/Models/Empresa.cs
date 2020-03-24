using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace SERPROCI.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        [Key]
        [Display(Name = "Id Empresa")]
        public int IdEmpresa { get; set; }

        [Display(Name = "Nombre Empresa")]
        [Index(IsUnique = true)]
        [StringLength(60)]
        [Required(ErrorMessage = "El CAMPO {0} REQUERIDO")]
        public string EmpresaName { get; set; }

        [Display(Name = "Razon Social")]
        [StringLength(60)]
        [Required(ErrorMessage = "El CAMPO {0} REQUERIDO")]
        public string RazonSocial { get; set; }

        [Display(Name = "Numero Ruc")]
        [StringLength(50)]
        [Required(ErrorMessage = "El CAMPO {0} REQUERIDO")]
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

        [Display(Name = "SitioWeb")]
        [StringLength(50)]
        public string SitioWeb { get; set; }


        public virtual ICollection<TipoServicio> TipoServicios { get; set; }
        public virtual ICollection<Almacen> Almacens { get; set; }


    }
}