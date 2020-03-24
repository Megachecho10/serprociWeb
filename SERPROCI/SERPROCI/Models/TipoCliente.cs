using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace SERPROCI.Models
{
    [Table("TipoCliente")]
    public class TipoCliente
    {
        [Key]
        [Display(Name = "Id TipoCliente")]
        public int IdTipoCliente { get; set; }

        [Display(Name = "TipoCliente")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        public string TiposClientes { get; set; }


    }
}