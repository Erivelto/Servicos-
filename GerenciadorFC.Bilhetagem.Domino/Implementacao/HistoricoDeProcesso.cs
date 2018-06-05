using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Bilhetagem.Domino.Implementacao
{
    public class HistoricoDeProcesso
    {
		public int Codigo { get; set; }
		public int TipoProcesso { get; set; }
		public DateTime DataProcesso { get; set; }
		public int Sistema { get; set; }
		public int Status { get; set; }
		public string Descricao { get; set; }
		public string ValorHistorico { get; set; }
		public string Documento { get; set; }
		public string Arquivo { get; set; }
		public string NumeroProcesso { get; set; }
		public string VerificacaoProcesso { get; set; }
	}
}
