using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Markup;
using Microsoft.VisualBasic;

namespace Ferreteria.Clases
{
    public class Data
    {
        List<Cliente> Clientes = new List<Cliente>(){
            new Cliente(){
                Id = 1,
                NombreCliente = "Juanes",
                Email ="juanito@gmail.com"
            },
             new Cliente(){
                Id = 2,
                NombreCliente = "Carlos",
                Email ="carlitos@gmail.com"
            },
              new Cliente(){
                Id = 3,
                NombreCliente = "Katia",
                Email ="Katia123@gmail.com"
            },

        };

        List<Producto> Productos = new List<Producto>{
            new Producto(){
                Id = 1,
                Nombre = "Buñuelos",
                PrecioUnit = 3000,
                Cantidad =60,
                StockMin = 5,
                StockMax = 60
            },
             new Producto(){
                Id = 2,
                Nombre = "Gaseosa",
                PrecioUnit = 2800,
                Cantidad =20,
                StockMin = 10,
                StockMax = 50
            },
             new Producto(){
                Id = 3,
                Nombre = "Buñuelos",
                PrecioUnit = 2600,
                Cantidad =3,
                StockMin = 5,
                StockMax = 52
            }
        };

        List<Factura> Facturas = new List<Factura>(){
            new Factura(){
                NroFactura =1,
                Fecha = DateOnly.Parse("01/01/2023"),
                IdCliente = 1,
                TotalFactura = 4200
            },
            new Factura(){
                NroFactura =2,
                Fecha = new DateOnly(2023,05,6),
                IdCliente = 2,
                TotalFactura = 4200
            },
                new Factura(){
                NroFactura =3,
                Fecha = new DateOnly(2022,01,1),
                IdCliente = 3,
                TotalFactura = 4200
            }
        };

        public void fecha()
        {
            var fecha = DateOnly.Parse("01/12/2023");
            var fecha2 = new DateOnly(2023, 05, 6);
            System.Console.WriteLine(fecha);
            System.Console.WriteLine(fecha2);
        }

        public void ListaProductos()
        {
            var productos = (from p in Productos
                             select p).ToList();
            if (productos.Count() != 0)
            {
                System.Console.WriteLine("--Lista De Productos--");
                productos.ForEach(x => System.Console.WriteLine($"Id Producto:{x.Id}-Nombre Producto:{x.Nombre}-Precio Unitario:{x.PrecioUnit}-Cantidad En Tienda:{x.Cantidad}-Stock Min:{x.StockMin}-Stock Maximo:{x.StockMax}"));
            }
            else
            {
                System.Console.WriteLine("No hay Productos en el sistema");
            }
        }

        public void ProductosAgotarse()
        {
            var agotarse = (from p in Productos
                            where p.Cantidad < p.StockMin
                            select p).ToList();
            if (agotarse.Count() != 0)
            {
                System.Console.WriteLine("--Lista De Productos Agotarse--");
                agotarse.ForEach(x => System.Console.WriteLine($"Id Producto:{x.Id}-Nombre Producto:{x.Nombre}-Precio Unitario:{x.PrecioUnit}-Cantidad En tienda:{x.Cantidad}-Stock Minimo:{x.StockMin}"));
            }
            else
            {
                System.Console.WriteLine("No hay Productos en el sistema");
            }
        }

        public void FacturasEnero()
        {
            var mes = 01;
            var año = 2023;
            var FacturasEnero = (from f in Facturas
                                 where f.Fecha.Month == mes && f.Fecha.Year == año
                                 select f).ToList();
            if (FacturasEnero.Count() != 0)
            {
                System.Console.WriteLine("--Facturas mes de enero--");
                FacturasEnero.ForEach(f => System.Console.WriteLine($"NroFactura:{f.NroFactura}-Fecha Factura:{f.Fecha}-Id Cliente:{f.IdCliente}-Total Factura:{f.TotalFactura}"));
            }
            else
            {
                System.Console.WriteLine("No hay facturas en el mes de enero registradas en el sistema");
            }


        }

        public void ProductosComprar()
        {
            var comprar = (from p in Productos
                           where p.Cantidad < p.StockMin
                           select p).ToList();
            if (comprar.Count() != 0)
            {   
                System.Console.WriteLine("Productos Para Comprar");
                foreach (var item in comprar)
                {
                    var buy = item.StockMax - item.Cantidad;
                    System.Console.WriteLine($"Producto Comprar:{item.Nombre}--Cantidad Necesaria a Comprar:{buy}");
                }
            }
            else
            {
                System.Console.WriteLine("No hay productos para comprar");
            }


        }

        public void ValorInventario(){
            var productos = (from p in Productos select p ).ToList();
            var valor =0;
            System.Console.WriteLine("Valor Inventario");
            foreach(var item in productos){
                 valor+= item.Cantidad*item.PrecioUnit;
                 System.Console.WriteLine($"Producto:{item.Nombre}-Precio Unitario:{item.PrecioUnit}-Cantidad Producto:{item.Cantidad}");
            }
            System.Console.WriteLine($"Valor Total Inventario :{valor}");

        }

        public void ProductosFactura(){
            Console.WriteLine("Ingrese el id de la factura a buscar");
            int facturaBuscar= Console.Read();
            var proFactura = (from p in Productos where p.Id ==facturaBuscar select p).ToList();
            if (proFactura.Count()!=0){
                
            }else{
                System.Console.WriteLine("No se encuentran facturas con el id ingresado.");
            }
        }


        public void menu()
        {

            System.Console.WriteLine("\nFerreteria Campus");
            System.Console.WriteLine("\n1.Listar Productos del inventario" +
            "\n2.Listar Productos a punto de agotarse" +
            "\n3.Productos que se deben comprar" +
            "\n4.Total Factuas mes enero" +
            "\n5.Productos vendidos en una factura" +
            "\n6.Valor total de inventario" +
            "\n7.Salir del programa");
        }

    }
}