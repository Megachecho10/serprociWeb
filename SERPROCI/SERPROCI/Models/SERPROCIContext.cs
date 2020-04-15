using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SERPROCI.Models
{
    public class SERPROCIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SERPROCIContext() : base("name=SERPROCIContext")
        {
        }

        public System.Data.Entity.DbSet<SERPROCI.Models.Empresa> Empresas { get; set; }

        public System.Data.Entity.DbSet<SERPROCI.Models.Almacen> Almacens { get; set; }

        public System.Data.Entity.DbSet<SERPROCI.Models.Umd> Umds { get; set; }

        public System.Data.Entity.DbSet<SERPROCI.Models.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<SERPROCI.Models.Grupo> Grupoes { get; set; }

        public System.Data.Entity.DbSet<SERPROCI.Models.Marca> Marcas { get; set; }

        public System.Data.Entity.DbSet<SERPROCI.Models.Servicio> Servicios { get; set; }

        public System.Data.Entity.DbSet<SERPROCI.Models.TipoServicio> TipoServicios { get; set; }
    }
}
