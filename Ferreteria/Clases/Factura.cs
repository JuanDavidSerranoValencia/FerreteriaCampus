using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria.Clases
{
    public class Factura 
    {
    
        public int NroFactura { get; set; }
        public DateOnly Fecha { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int TotalFactura { get; set; }


        
    }
}