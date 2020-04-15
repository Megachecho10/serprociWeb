using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("MasterPedido")]
    public class MasterPedido
    {
        [Key]
        [Display(Name = "Id Pedido")]
        public int IdMasterPedido { get; set; }

        [Display(Name = "Id Cliente")]
        public int IdCliente { get; set; }

        [Display(Name = "Id TipoPedido")]
        public int IdTipoPedido { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Pedido")]
        public DateTime FechaPedido { get; set; }

        [Display(Name = "Concepto")]
        [StringLength(300)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        public string Concepto { get; set; }

        [Display(Name = "Estado")]
        [StringLength(20)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        public string Estado { get; set; }

        [Display(Name = "Anulado")]
        public bool? Anulado { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Anulado")]
        public DateTime FechaAnulado { get; set; }

        [ForeignKey("IdTipoPedido")]
        public virtual TipoPedido TipoPedido { get; set; }
    }
}