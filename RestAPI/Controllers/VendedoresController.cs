using Microsoft.AspNetCore.Mvc;
using RestAPI.Modelos;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class VendedoresController: ControllerBase
    {
        [HttpGet("vendedores/all")]
        public ActionResult<IEnumerable<Vendedores>> GetAll()
        {
            // Lista de productos dummy
            return new[]
            {
                new Vendedores { IdVendedor = "5000", NombreVendedor = "Vendedor 1" },
                new Vendedores { IdVendedor = "5001", NombreVendedor = "Vendedor 2 " },
                new Vendedores { IdVendedor = "5002", NombreVendedor = "Vendedor 3 " },
                new Vendedores { IdVendedor = "5003", NombreVendedor = "Vendedor 4 " },
                new Vendedores { IdVendedor = "5004", NombreVendedor = "Vendedor 5 " },
            };
        }
    }
}