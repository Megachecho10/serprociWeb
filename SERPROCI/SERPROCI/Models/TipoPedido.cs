using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace SERPROCI.Models
{
    [Table("TipoPedido")]
    public class TipoPedido
    {
        [Key]
        [Display(Name = "Id TipoPedido")]
        public int IdTipoPedido { get; set; }

        [Index(IsUnique = true)]
        [Display(Name = "TIpoPedido")]
        [Required(ErrorMessage = "El Campo {0} Es Requerido ")]
        [StringLength(20)]
        public string TiposPedidos { get; set; }
    }
}