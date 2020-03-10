using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgramaAlmacen.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Almacenes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false),
                    Correo_electronico = table.Column<string>(nullable: false),
                    Ubicacion = table.Column<string>(nullable: false),
                    Capacidad_articulos = table.Column<int>(nullable: false),
                    Proveedores = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Almacenes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Anexos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Archivo = table.Column<string>(nullable: false),
                    Codigo_articulo = table.Column<string>(nullable: false),
                    Estatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Articulo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_articulo = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    Marca_articulo = table.Column<string>(nullable: false),
                    Precio_compra = table.Column<decimal>(nullable: false),
                    Precio_venta = table.Column<decimal>(nullable: false),
                    Ganancias = table.Column<decimal>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Estatus = table.Column<bool>(nullable: false),
                    Fecha_ingreso = table.Column<DateTime>(nullable: false),
                    Fecha_venta = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Articulo_Proveedores",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_articulo = table.Column<string>(nullable: false),
                    Almacen_id = table.Column<int>(nullable: false),
                    Estatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo_Proveedores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_proveedor = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false),
                    Correo_electronico = table.Column<string>(nullable: false),
                    Ubicacion = table.Column<string>(nullable: false),
                    Articulos = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Almacenes");

            migrationBuilder.DropTable(
                name: "Anexos");

            migrationBuilder.DropTable(
                name: "Articulo");

            migrationBuilder.DropTable(
                name: "Articulo_Proveedores");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
