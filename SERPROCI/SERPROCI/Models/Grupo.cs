using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("Grupo")]
    public class Grupo
    {
        [Key]
        [Display(Name = "Id Grupo")]
        public int IdGrupo { get; set; }

        [Display(Name = "Nombre Grupo")]
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string GrupoName { get; set; }

        public virtual ICollection<Productos> Productos {get; set;}

    }
}