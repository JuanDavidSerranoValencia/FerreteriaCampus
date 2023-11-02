using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria.Clases
{
    public class DetalleFactura:BaseEntity
    {
    
        public int  NroFactura { get; set; }
        public Factura Factura { get; set; }
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public int Valor { get; set; }

    }
}