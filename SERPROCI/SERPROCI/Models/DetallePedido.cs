using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("DetallePedido")]
    public class DetallePedido
    {
        [Key]
        [Display(Name = "Id Detalle Pedido")]
        public int IdDetallePedido { get; set; }

        [Display(Name = "Id Producto")]
        public int IdProducto { get; set; }

        [Display(Name = "Id Pedido")]
        public int IdMasterPedido { get; set; }

        [Display(Name = "Id Servicio")]
        public int IdServicio { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Cantidad { get; set; }

        [Display(Name = "Monto")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Monto { get { return Cantidad * Productos.Precio; } }

        [ForeignKey("IdProducto")]
        public virtual Productos Productos { get; set; }

        [ForeignKey("IdMasterPedido")]
        public virtual MasterPedido MasterPedido { get; set; }

        [ForeignKey("IdServicio")]
        public virtual Servicio Servicio { get; set; }
    }
}