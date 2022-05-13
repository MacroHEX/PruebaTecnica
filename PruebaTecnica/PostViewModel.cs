using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    public class Detalles
    {
        // Campos de los atributos que se reciben
        public int CodArt { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUni { get; set; }
    }
    public class Cliente
    {
        // Campos de los atributos que se reciben
        public string CodCliente { get; set; }

        public string NombreCliente { get; set; }
    }
}
