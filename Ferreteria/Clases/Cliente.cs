using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteria.Clases
{
    public class Cliente : BaseEntity
    {
        public string NombreCliente { get; set; }
        public string Email { get; set; }
        
    }
}