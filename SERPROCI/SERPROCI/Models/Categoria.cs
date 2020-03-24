using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        [Display(Name = "Id Categoria")]
        public int IdCategoria { get; set; }

        [Display(Name = "Nombre Categoria")]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string CategoriaName { get; set; }

    }
}