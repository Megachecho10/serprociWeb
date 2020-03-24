using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("Umd")]
    public class Umd
    {
        [Key]
        [Display(Name = "Id Umd")]
        public int IdUmd { get; set; }

        [Display(Name = "Unidad Medida")]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string UmdName { get; set; }

        public virtual ICollection<Productos> Productos { get; set;}
    }
}