using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("MasterFactura")]
    public class MasterFactura
    {
        [Key]
        [Display(Name = "Id MasterFactura")]
        public int IdMasterFactura { get; set; }

        [Display(Name = "Id Pedido")]
        public int IdMasterPedido { get; set; }

        [Display(Name = "Id Detalle Pedido")]
        public int IdDetallePedido { get; set; }

        [Display(Name = "Id Cliente")]
        public int IdCliente { get; set; }

        [Display(Name = "Credito")]
        public byte Credito { get; set; }

        [Display(Name = "Contado")]
        public byte Contado { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha")]
        public DateTime FechaFactura { get; set; }

        [Display(Name = "Total Factura")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal TotalFactura { get { return DetallePedido.Monto + TotalFactura; } }

        [Display(Name = "Concepto")]
        [StringLength(300)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        public string Concepto { get; set; }


        [ForeignKey("IdMasterPedido")]
        public virtual MasterPedido MasterPedido { get; set; }

        [ForeignKey("IdDetallePedido")]
        public virtual DetallePedido DetallePedido { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Clientes Clientes { get; set; }
    }
}