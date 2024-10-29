using System.Collections.Generic;

namespace LegacySystem.Clientes
{
    public class SistemaCliente
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();

        #region Propriedades
        public IReadOnlyList<Cliente> Clientes => _clientes.AsReadOnly();
        #endregion

        #region Métodos
        public void AdicionarCliente(int id, string nome, string email)
        {
            var novoCliente = new Cliente(id, nome, email);
            _clientes.Add(novoCliente);
        }

        public void RemoverCliente(int id)
        {
            _clientes.RemoveAll(c => c.Id == id);
        }

        public void ExibirTodosOsClientes()
        {
            foreach (var cliente in _clientes)
            {
                cliente.ExibirDados();
            }
        }

        public Cliente AtualizarNomeCliente(int id, string novoNome)
        {
            var cliente = _clientes.Find(c => c.Id == id);
            if (cliente != null)
            {
                RemoverCliente(id); // Remove o cliente antigo
                var novoCliente = cliente.MudarNome(novoNome);
                AdicionarCliente(novoCliente.Id, novoCliente.Nome, novoCliente.Email);
                return novoCliente;
            }
            return null;
        }
        #endregion
    }
}
