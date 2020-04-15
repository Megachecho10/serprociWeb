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

         [Display(Name = "")]

    }
}