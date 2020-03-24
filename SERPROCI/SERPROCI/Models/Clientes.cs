using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        [Display(Name = "Id Cliente")]
        public int IdCliente { get; set; }

        [Display(Name = "Nombre Cliente")]
        [Index(IsUnique = true)]
        [StringLength(100)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        public string NombreCliente { get; set; }

        [Display(Name = "Razon Social")]
        [Index(IsUnique = true)]
        [StringLength(100)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        public string RazonSocial { get; set; }

        [Display(Name = "Cedula")]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        [Index(IsUnique = true)]
        [StringLength(16)]
        public string Cedula { get; set; }

        [Display(Name = "NumeroRuc")]
        [Index(IsUnique = true)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        [StringLength(100)]
        public string NumeroRuc { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(20)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        public string Telefono { get; set; }

        [Display(Name = "Direccion")]
        [StringLength(200)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        public string Direccion { get; set; }

        

    }
}