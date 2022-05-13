using System.ComponentModel;

namespace RestAPI.Modelos
{
    // Modelo para los servicios/productos
    public class Productos
    {
        public string CodArt { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUni { get; set; }
    }
}
