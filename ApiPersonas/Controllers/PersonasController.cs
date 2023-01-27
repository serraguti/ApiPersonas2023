using ApiPersonas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        //CREAMOS UNA COLECCION DE PERSONAS PARA
        //DEVOLVER DATOS EN NUESTRA APP
        List<Persona> personas;

        public PersonasController()
        {
            //CREAMOS UNAS CUANTAS PERSONAS PARA TENER DATOS EN EL SERVICIO
            this.personas = new List<Persona>
            {
                new Persona  { IdPersona = 1, Nombre = "Carlos", Edad=20},
                new Persona  { IdPersona = 2, Nombre = "Adrian", Edad=25},
                new Persona  { IdPersona = 3, Nombre = "Lucia", Edad=21},
                new Persona  { IdPersona = 4, Nombre = "Miriam", Edad=29},
                new Persona  { IdPersona = 5, Nombre = "Pedro", Edad=46},
                new Persona  { IdPersona = 6, Nombre = "Vanessa", Edad=39},
                new Persona  { IdPersona = 7, Nombre = "Antonia", Edad=66}
            };
        }

        //LOS METODOS GET DE UN SERVICIO API SIEMPRE TENDRAN LA 
        //DECORACION [HttpGet]
        [HttpGet]
        public ActionResult<List<Persona>> GetPersonas()
        {
            return this.personas;
        }

        //EL METODO GET(ID) DEBE IR DECORADO CON [HttpGet("{id}")]
        [HttpGet("{id}")]
        public ActionResult<Persona> FindPersona(int id)
        {
            //VOY A UTILIZAR UNA EXPRESION PARA BUSCAR UNA PERSONA
            //DENTRO DE UNA COLECCION
            Persona persona = this.personas.FirstOrDefault(z => z.IdPersona == id);
            return persona;
        }
    }
}
