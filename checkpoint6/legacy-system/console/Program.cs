using System; 
using System.Collections.Generic; 
using System.IO; 
using LegacySystem.Clientes; 
using LegacySystem.Transacoes; 
using LegacySystem.Relatorios; 

namespace LegacySystem 
{
    class MainSistema 
    {
        
        static void Main(string[] args)
        {
            // Cria uma instância do sistema de clientes
            SistemaCliente sc = new SistemaCliente();
            // Adiciona dois clientes ao sistema
            sc.AdicionarCliente(1, "Joao", "joao@email.com");
            sc.AdicionarCliente(2, "Maria", "maria@email.com");

            // Cria uma instância do sistema de transações
            SistemaTransacao st = new SistemaTransacao();
            // Adiciona três transações ao sistema
            st.AdicionarTransacao(1, 100.50m, "Compra de Produto");
            st.AdicionarTransacao(2, 200.00m, "Compra de Serviço");
            st.AdicionarTransacao(3, 300.75m, "Compra de Software");

            // Exibe todos os clientes registrados
            sc.ExibirTodosOsClientes();
            // Exibe todas as transações registradas
            st.ExibirTransacao();

            // Remove o cliente com ID 1
            sc.RemoverCliente(1);
            // Exibe a lista de clientes após a remoção
            sc.ExibirTodosOsClientes();

            // Atualiza o nome do cliente com ID 2
            sc.AtualizarNomeCliente(2, "Maria Silva");

            // Define variáveis para o nome da empresa e descrição da transação
            const string nomeEmpresa = "Empresa Teste"; // Usa const para evitar strings mágicas
            const string descricaoTransacao = "Compra de Insumo"; // Usa const para evitar strings mágicas

            // Loop para imprimir o nome da empresa e descrição da transação 5 vezes
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Nome da Empresa: {nomeEmpresa} Descrição: {descricaoTransacao}");
            }

            // Cria uma instância do relatório
            Relatorio relatorio = new Relatorio();
            // Gera um relatório com os clientes existentes
            relatorio.GerarRelatorioCliente(sc.Clientes);
            // Gera um relatório de clientes duplicados
            relatorio.GerarRelatorioClienteDuplicado(sc.Clientes);

            // Inicializa uma variável para somar
            int soma = 0;
            // Loop para calcular a soma dos números de 0 a 9
            for (int i = 0; i < 10; i++)
            {
                // Soma os números
                soma += i;
            }

            // Exibe a soma total
            Console.WriteLine("Soma total: " + soma);
        }
    }
}
