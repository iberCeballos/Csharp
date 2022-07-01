using Microsoft.AspNetCore.Mvc;
using api5.model;
using api5.repositorio;

namespace api5.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class clientescontroller : ControllerBase
    {
        //[HttpGet]
        //public IActionResult Get() => Ok.cliente;

        //[HttpGet]
        //public IActionResult Get(int id)
        //{
        //    RPClientes rpCli = new RPClientes();

        //    var cliRet = rpCli.ObtenerCliente(id);

        //    if (cliRet == null)
        //    {
        //        var nf = NotFound("El cliente " + id.ToString() + " no existe.");
        //        return nf;
        //    }

        //    return Ok(cliRet);
        //}
        /*[HttpGet]
        public cliente<WeatherForeca> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("agregar")]
        public IActionResult AgregarCliente(cliente nuevoCliente)
        {
            RPClientes rpCli = new RPClientes();
            rpCli.Agregar(nuevoCliente);
            return CreatedAtAction(nameof(AgregarCliente), nuevoCliente);
        }*/

        [HttpGet]
        [Route("{Id}")]
        public string GetObject(int Id)
        {
            return Id switch { 
                1=>"Cliente #1" + " "+ "Breilyn Stiven Velasquez Hernandez",
                2=>"Cliente #2" + " "+ "Monica Alejandra Restrepo Moreno",
                3=>"Cliente #3" + " "+ "Jeison Andrés Ortiz",
            
            };
        }
        public string Post(Cliente perfilPersonal )
        {
            return perfilPersonal.Nombre + " " + perfilPersonal.Apellido;

        }
    }
    public class Cliente
    {
        public string Nombre { get; set; }  
        public string Apellido { get; set; } 

    }
}