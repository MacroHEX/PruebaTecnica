using Microsoft.AspNetCore.Mvc;
using RestAPI.Modelos;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProductosController: ControllerBase
    {
        [HttpGet("productos/all")]
        public ActionResult<IEnumerable<Productos>> GetAll()
        {
            // Lista de productos dummy
            return new[]
            {
                new Productos { CodArt = "1", Descripcion = "Producto 1 ", PrecioUni = 10000 },
                new Productos { CodArt = "2", Descripcion = "Producto 2", PrecioUni = 50000 },
                new Productos { CodArt = "3", Descripcion = "Producto 3", PrecioUni = 125000 },
                new Productos { CodArt = "4", Descripcion = "Producto 4", PrecioUni = 10000000 },
                new Productos { CodArt = "5", Descripcion = "Producto 5", PrecioUni = 23000 }
            };
        }
    }
}
