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

        [Display(Name = "Id ProSer")]
        public int IdProser { get; set; }

    }
}