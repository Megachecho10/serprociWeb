using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("Servicio")]
    public class Servicio
    {
        [Key]
        [Display(Name = "Id Servicio")]
        public int IdServicio { get; set; }

        [Display(Name = "Id TipoServicio")]
        public int IdTipoServicio { get; set; }

        [Display(Name = "Servicio")]
        [StringLength(50)]
        [Index(IsUnique = true)]
        [Required(ErrorMessage = "El CAMPO {1} REQUERIDO")]
        [Index(IsUnique =true)]
        public string ServicioName { get; set; }

        [Display(Name = "Descripcion Servicio")]
        [StringLength(200)]
        [Required(ErrorMessage = "El CAMPO {0} REQUERIDO")]
        public string DescripcionServicio { get; set; }



        [ForeignKey("IdTipoServicio")]
        public virtual TipoServicio TipoServicio { get; set; }


    }
}