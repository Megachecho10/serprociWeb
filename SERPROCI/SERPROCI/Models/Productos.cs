using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace SERPROCI.Models
{
    [Table("Productos")]
    public class Productos
    {
        [Key]
        [Display(Name = "Id Producto")]
        public int IdProducto { get; set; }

        [Display(Name = "Id Almacen")]
        public int IdAlmacen { get; set; }

        [Display(Name = "Id Categoria")]
        public int IdCategoria { get; set; }

        [Display(Name = "Id Grupo")]
        public int IdGrupo { get; set; }

        [Display(Name = "Id Marca")]
        public int IdMarca { get; set; }

        [Display(Name = "Id Proveedor")]
        public int IdProveedor { get; set; }

        [Display(Name = "Id Umd")]
        public int IdUmd { get; set; }

        [Display(Name = "Nombre Producto")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        public string ProductoName { get; set; }

        [Display(Name = "Descripcion Producto")]
        [StringLength(100)]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        public string DescripcionProducto { get; set; }

        [Display(Name = "Saldo Inicial")]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal SaldoInicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Saldo Actual")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal SaldoActual { get { return 0; } }


        [Display(Name = "Total Salida")]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal TotalSalida { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Salida")]
        public DateTime FechaSalida{ get; set; }

        [Display(Name = "Total Entradas")]
        [Required(ErrorMessage = "El Campo {0} Es Requqerido")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal TotalEntrada { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Entrada")]
        public DateTime FechaEntrada { get; set; }




        [Display(Name = "Activo")]
        public Byte? Activo { get; set; }

        //RELACIONES 

        [ForeignKey("IdAlmacen")]
        public virtual Almacen Almacen { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("IdGrupo")]
        public virtual Grupo Grupo { get; set; }

        [ForeignKey("IdMarca")]
        public virtual Marca Marca { get; set; }

        [ForeignKey("IdProveedor")]
        public virtual Proveedor Proveedor { get; set; }

        [ForeignKey("IdUmd")]
        public virtual Umd Umd { get; set; }


    }
}