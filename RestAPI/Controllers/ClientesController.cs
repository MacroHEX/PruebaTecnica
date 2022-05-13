using Microsoft.AspNetCore.Mvc;
using RestAPI.Modelos;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ClientesController : ControllerBase
    {

        [HttpGet("clientes/all")]
        public ActionResult<IEnumerable<Clientes>> GetAll()
        {
            // Lista de clientes dummy
            return new[]
            {
                new Clientes { CodCliente = "1000", NombreCliente = "Ramón Basilio"},
                new Clientes { CodCliente = "1001", NombreCliente = "Natalia Teobaldo"},
                new Clientes { CodCliente = "1002", NombreCliente = "Federico Eloy"},
                new Clientes { CodCliente = "1003", NombreCliente = "Isabela Roldán"},
                new Clientes { CodCliente = "1004", NombreCliente = "Feliciano Custodio"}
            };
        }
    }
}
