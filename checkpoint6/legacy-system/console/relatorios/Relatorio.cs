using System;
using System.Collections.Generic;
using LegacySystem.Clientes; // Certifique-se de que está importando o namespace correto

namespace LegacySystem.Relatorios
{
    public class Relatorio
    {
        #region Metodos
        // Método para gerar relatório de clientes
        public void GerarRelatorioCliente(IEnumerable<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Cliente: {cliente.Nome} | Email: {cliente.Email}");
            }
        }

        // Método para gerar relatório caso haja clientes duplicados
        public void GerarRelatorioClienteDuplicado(IEnumerable<Cliente> clientes)
        {
            // Implementar lógica para detectar duplicados, por exemplo, usando um HashSet ou GroupBy
            var duplicados = new HashSet<string>();
            var vistos = new HashSet<string>();

            foreach (var cliente in clientes)
            {
                if (!vistos.Add(cliente.Email)) // Adiciona o email se não estiver presente
                {
                    duplicados.Add(cliente.Email); // Adiciona à lista de duplicados
                }
            }

            foreach (var cliente in clientes)
            {
                if (duplicados.Contains(cliente.Email))
                {
                    Console.WriteLine($"Cliente Duplicado: {cliente.Nome} | Email: {cliente.Email}");
                }
            }
        }
        #endregion
    }
}
