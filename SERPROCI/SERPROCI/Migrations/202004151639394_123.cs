namespace SERPROCI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        CategoriaName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdCategoria)
                .Index(t => t.CategoriaName, unique: true);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        IdAlmacen = c.Int(nullable: false),
                        IdCategoria = c.Int(nullable: false),
                        IdGrupo = c.Int(nullable: false),
                        IdMarca = c.Int(nullable: false),
                        IdProveedor = c.Int(nullable: false),
                        IdUmd = c.Int(nullable: false),
                        ProductoName = c.String(nullable: false, maxLength: 50),
                        DescripcionProducto = c.String(nullable: false, maxLength: 100),
                        SaldoInicio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaInicio = c.DateTime(nullable: false),
                        TotalSalida = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaSalida = c.DateTime(nullable: false),
                        TotalEntrada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaEntrada = c.DateTime(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Activo = c.Byte(),
                    })
                .PrimaryKey(t => t.IdProducto)
                .ForeignKey("dbo.Almacen", t => t.IdAlmacen, cascadeDelete: true)
                .ForeignKey("dbo.Categoria", t => t.IdCategoria, cascadeDelete: true)
                .ForeignKey("dbo.Grupo", t => t.IdGrupo, cascadeDelete: true)
                .ForeignKey("dbo.Marca", t => t.IdMarca, cascadeDelete: true)
                .ForeignKey("dbo.Proveedor", t => t.IdProveedor, cascadeDelete: true)
                .ForeignKey("dbo.Umd", t => t.IdUmd, cascadeDelete: true)
                .Index(t => t.IdAlmacen)
                .Index(t => t.IdCategoria)
                .Index(t => t.IdGrupo)
                .Index(t => t.IdMarca)
                .Index(t => t.IdProveedor)
                .Index(t => t.IdUmd)
                .Index(t => t.ProductoName, unique: true);
            
            CreateTable(
                "dbo.Grupo",
                c => new
                    {
                        IdGrupo = c.Int(nullable: false, identity: true),
                        GrupoName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdGrupo)
                .Index(t => t.GrupoName, unique: true);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        IdMarca = c.Int(nullable: false, identity: true),
                        MarcaName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdMarca)
                .Index(t => t.MarcaName, unique: true);
            
            CreateTable(
                "dbo.Proveedor",
                c => new
                    {
                        IdProveedor = c.Int(nullable: false, identity: true),
                        ProveedorName = c.String(nullable: false, maxLength: 50),
                        RazonSocial = c.String(nullable: false, maxLength: 50),
                        NumeroRuc = c.String(nullable: false, maxLength: 50),
                        Telefono = c.String(nullable: false, maxLength: 8),
                        Direccion = c.String(nullable: false, maxLength: 200),
                        CorreoElectronico = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.IdProveedor)
                .Index(t => t.ProveedorName, unique: true)
                .Index(t => t.RazonSocial, unique: true)
                .Index(t => t.NumeroRuc, unique: true);
            
            CreateTable(
                "dbo.Umd",
                c => new
                    {
                        IdUmd = c.Int(nullable: false, identity: true),
                        UmdName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdUmd)
                .Index(t => t.UmdName, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "IdUmd", "dbo.Umd");
            DropForeignKey("dbo.Productos", "IdProveedor", "dbo.Proveedor");
            DropForeignKey("dbo.Productos", "IdMarca", "dbo.Marca");
            DropForeignKey("dbo.Productos", "IdGrupo", "dbo.Grupo");
            DropForeignKey("dbo.Productos", "IdCategoria", "dbo.Categoria");
            DropForeignKey("dbo.Productos", "IdAlmacen", "dbo.Almacen");
            DropIndex("dbo.Umd", new[] { "UmdName" });
            DropIndex("dbo.Proveedor", new[] { "NumeroRuc" });
            DropIndex("dbo.Proveedor", new[] { "RazonSocial" });
            DropIndex("dbo.Proveedor", new[] { "ProveedorName" });
            DropIndex("dbo.Marca", new[] { "MarcaName" });
            DropIndex("dbo.Grupo", new[] { "GrupoName" });
            DropIndex("dbo.Productos", new[] { "ProductoName" });
            DropIndex("dbo.Productos", new[] { "IdUmd" });
            DropIndex("dbo.Productos", new[] { "IdProveedor" });
            DropIndex("dbo.Productos", new[] { "IdMarca" });
            DropIndex("dbo.Productos", new[] { "IdGrupo" });
            DropIndex("dbo.Productos", new[] { "IdCategoria" });
            DropIndex("dbo.Productos", new[] { "IdAlmacen" });
            DropIndex("dbo.Categoria", new[] { "CategoriaName" });
            DropTable("dbo.Umd");
            DropTable("dbo.Proveedor");
            DropTable("dbo.Marca");
            DropTable("dbo.Grupo");
            DropTable("dbo.Productos");
            DropTable("dbo.Categoria");
        }
    }
}
