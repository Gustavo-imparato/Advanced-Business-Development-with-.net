using System;

namespace LegacySystem.Clientes
{
    public class Cliente
    {
        // Propriedades
        public int Id { get; }
        public string Nome { get; }
        public string Email { get; }
        public DateTime Cadastro { get; }

        #region Construtor
        public Cliente(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cadastro = DateTime.Now;
        }
        #endregion

        #region Métodos
        public Cliente MudarNome(string novoNome)
        {
            return new Cliente(Id, novoNome, Email);
        }

        public Cliente AtualizarEmail(string novoEmail)
        {
            return new Cliente(Id, Nome, novoEmail);
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Id: {Id} Nome: {Nome} Email: {Email} Cadastro: {Cadastro}");
        }
        #endregion
    }
}
