using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria.Clases
{
    public class Producto :BaseEntity
    {
        public string Nombre { get; set; }
        public int PrecioUnit { get; set; }
        public int Cantidad { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
    }
}