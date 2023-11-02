using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                Cantidad =40,
                StockMin = 2,
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

        List<Factura> Facturas = new List<Factura> (){
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
        
    /*     public void fecha (){
            var fecha = DateOnly.Parse("01/12/2023");

            var fecha2 =new DateOnly(2023,05,6) ;
            System.Console.WriteLine(fecha);
            System.Console.WriteLine(fecha2);
        } */

        public void ListaProductos (){
            var productos = (from p in Productos 
                                select p).ToList();
            if (productos.Count()!=0){
                System.Console.WriteLine("--Lista De Productos--");
                 productos.ForEach(x => System.Console.WriteLine($"{x.Id}-{x.Nombre}-{x.PrecioUnit}-{x.Cantidad}"));
            }
            else{
                System.Console.WriteLine("No hay Productos en el sistema");
            }
        }

        public void ProductosAgotarse(){
            var agotarse = (from p in Productos 
                                 where p.Cantidad < p.StockMin 
                                 select p).ToList();
            if (agotarse.Count()!=0){
                System.Console.WriteLine("--Lista De Productos Agotarse--");
                 agotarse.ForEach(x => System.Console.WriteLine($"{x.Id}-{x.Nombre}-{x.PrecioUnit}-{x.Cantidad}"));
            }
            else{
                System.Console.WriteLine("No hay Productos en el sistema");
            }
        }

        public void FacturasEnero (){
            var mes = 01;
            var año = 2023;
            var FacturasEnero=  (from f in Facturas 
                                    where f.Fecha.Month == mes  && f.Fecha.Year==año
                                    select f ).ToList();
             if (FacturasEnero.Count()!=0){
                System.Console.WriteLine("--Facturas mes de enero--");
                  FacturasEnero.ForEach(f => System.Console.WriteLine($"{f.NroFactura}-{f.Fecha}-{f.IdCliente}-{f.TotalFactura}"));
            }
            else{
                System.Console.WriteLine("No hay facturas en el mes de enero registradas en el sistema");
            }                        
          

        }

    }
}