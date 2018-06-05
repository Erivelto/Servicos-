using GerenciadorFC.Bilhetagem.Domino.Implementacao;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorFC.Bilhetagem.Servicos.Repositorios
{
    public class Repositorio		
	{
		BancoContexto ctx = new BancoContexto();
		public HistoricoDeProcesso Adicionar(HistoricoDeProcesso historicoDeProcesso)
		{
			ctx.HistoricoDeProcessos.Add(historicoDeProcesso);
			ctx.SaveChanges();
			return historicoDeProcesso;
		}
		public HistoricoDeProcesso Atualizar(HistoricoDeProcesso historicoDeProcesso)
		{
			ctx.Entry(historicoDeProcesso).State = EntityState.Modified;
			ctx.SaveChanges();
			return historicoDeProcesso;
		}
		public List<HistoricoDeProcesso> ObterLista()
		{
			return ctx.Set<HistoricoDeProcesso>().ToList();
		}
		public HistoricoDeProcesso ObterPorCodigo(int codigo)
		{
			return ctx.Set<HistoricoDeProcesso>().Where(x => x.Codigo == codigo).FirstOrDefault(); 
		}
    }
}
