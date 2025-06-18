using System;
using System.Globalization;

namespace GerenciadorTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            void ExibirOpcoesMenu()
            {
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Listar Tarefas");
                Console.WriteLine("3 - Atualizar status Tarefas");
                Console.WriteLine("4 - Remover tarefa");
                Console.WriteLine("5 - Filtar tarefa por status");
                Console.WriteLine("0 - Sair");

                Console.Write("\nDigite a opção");
                string opcaoEscolhida = Console.ReadLine()!;
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch(opcaoEscolhidaNumerica)
                {
                    case 1: AdicionarTarefa();
                        break;
                }

            }

            void AdicionarTarefa()
            {

            }

            ExibirOpcoesMenu();

        }
    }
}