using System;

namespace LegacySystem.Transacoes
{
    public class Transacao
    {
        #region propriedades
        public int Id { get; }
        public decimal Valor { get; }
        public DateTime Data { get; }
        public string Descricao { get; }

        #endregion

        #region MetodoEContructor

        public Transacao(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor;
            Data = DateTime.Now;
            Descricao = descricao;
        }

        public void ExibirTransacao()
        {
            Console.WriteLine($"Id: {Id} Valor: {Valor} Descricao: {Descricao} Data: {Data}");
        }
        #endregion
    }
}
