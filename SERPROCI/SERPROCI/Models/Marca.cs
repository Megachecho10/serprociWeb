using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace SERPROCI.Models
{
    [Table("Marca")]
    public class Marca
    {
        [Key]
        [Display(Name = "Id Marca")]
        public int IdMarca { get; set; }

        [Display(Name = "Nombre Marca")]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string MarcaName { get; set; }
    }
}