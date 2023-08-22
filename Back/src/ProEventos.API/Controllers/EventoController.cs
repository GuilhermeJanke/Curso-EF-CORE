using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable <Evento> _evento  = new Evento[] {

                new Evento(){
                    EventoId = 1,
                    Tema = "Festa",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Local = "Curitiba",
                    QtdPessoas = Convert.ToInt32("250"),
                    Lote = "1 LOTE"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Festa Guilherme",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Local = "São Paulo",
                    QtdPessoas = Convert.ToInt32("350"),
                    Lote = "3 LOTE"
                }
            };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable <Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable <Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de POST";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de DELETE com id = {id}";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de PUT com id = {id}";
        }
    }
}
