using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("TipoServicio")]
    public class TipoServicio
    {
        [Key]
        [Display(Name = "Id TipoServicio")]
        public int IdTipoServicio{ get; set; }

        [Display(Name = "Id Empresa")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int IdEmpresa { get; set; }

        [Display(Name = "TipoServicio")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        [Required(ErrorMessage = "El CAMPO {0} REQUERIDO")]
        public string TipoServicioName { get; set; }

        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }

    }
}