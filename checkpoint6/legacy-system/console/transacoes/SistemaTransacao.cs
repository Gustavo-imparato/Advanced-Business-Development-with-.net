using System.Collections.Generic;

namespace LegacySystem.Transacoes
{
    public class SistemaTransacao
    {
        private readonly List<Transacao> _listaDeTransacoes = new List<Transacao>();

        #region Metodos

        public void AdicionarTransacao(int id, decimal valor, string descricao)
        {
            var novaTransacao = new Transacao(id, valor, descricao);
            _listaDeTransacoes.Add(novaTransacao);
        }

        public void ExibirTransacao()
        {
            foreach (var transacao in _listaDeTransacoes)
            {
                transacao.ExibirTransacao();
            }
        }

        #endregion
    }
}
