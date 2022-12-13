using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PEventos.API.Data;
using PEventos.API.Models;

namespace PEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {
            _context = context;
        }

        //estrutua básica de get, post, put e delete

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos; //recebendo todos os eventos e passando para o Get, para não adicionar diretamente aqui
        }


        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id); //fazendo uma consulta de um evento pelo ID
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string DHttpDelete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
