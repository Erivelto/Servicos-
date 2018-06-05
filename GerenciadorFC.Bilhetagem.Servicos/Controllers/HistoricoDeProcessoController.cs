using System;
using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Bilhetagem.Domino.Implementacao;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorFC.Bilhetagem.Servicos.Controllers
{
    [Route("api/[controller]")]
    public class HistoricoDeProcessoController : Controller
    {
		// GET api/values
		Repositorios.Repositorio repositorio = new Repositorios.Repositorio(); 
        [HttpGet]
        public List<HistoricoDeProcesso> Get()
        {
            return repositorio.ObterLista();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public HistoricoDeProcesso Get(int id)
        {
            return repositorio.ObterPorCodigo(id);
        }

        // POST api/values
        [HttpPost]
        public HistoricoDeProcesso Post(HistoricoDeProcesso historicoDeProcesso)
        {
			return repositorio.Adicionar(historicoDeProcesso);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public HistoricoDeProcesso Put(HistoricoDeProcesso historicoDeProcesso)
		{
			return repositorio.Atualizar(historicoDeProcesso);
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
