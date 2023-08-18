using System;
using System.Collections.Generic;

namespace CadastroClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();

            bool continuarCadastro = true;

            while (continuarCadastro)
            {
                Console.WriteLine("Cadastro de Clientes");
                Console.WriteLine("====================");

                Console.Write("Digite o nome do cliente: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a idade do cliente: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o contato do cliente: ");
                string contato = Console.ReadLine();

                Cliente novoCliente = new Cliente(nome, idade, contato);
                clientes.Add(novoCliente);

                Console.Write("Deseja cadastrar outro cliente? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta != "S")
                {
                    continuarCadastro = false;
                }

                Console.Clear();
            }

            Console.WriteLine("Clientes Cadastrados:");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome}");
            }

            Console.ReadLine();
        }
    }

    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Contato { get; set; }

        public Cliente(string nome, int idade, string contato)
        {
            Nome = nome;
            Idade = idade;
            Contato = contato;
        }
    }
}
