using Projeto.Modulos;
using System;
using System.Globalization;

namespace GerenciadorTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerenciador gerenciador = new Gerenciador();//criando um objeto gerenciador para usar as funcoes
            gerenciador.CarregarTarefasDoArquivo();



            void Titulo()
            {
                Console.WriteLine(@"
                ░█▀▀█ █▀▀ █▀▀█ █▀▀ █▀▀▄ █▀▀ ─▀─ █▀▀█ █▀▀▄ █▀▀█ █▀▀█ 　 █▀▀▄ █▀▀ 　 ▀▀█▀▀ █▀▀█ █▀▀█ █▀▀ █▀▀ █▀▀█ █▀▀ 
                ░█─▄▄ █▀▀ █▄▄▀ █▀▀ █──█ █── ▀█▀ █▄▄█ █──█ █──█ █▄▄▀ 　 █──█ █▀▀ 　 ─░█── █▄▄█ █▄▄▀ █▀▀ █▀▀ █▄▄█ ▀▀█ 
                ░█▄▄█ ▀▀▀ ▀─▀▀ ▀▀▀ ▀──▀ ▀▀▀ ▀▀▀ ▀──▀ ▀▀▀─ ▀▀▀▀ ▀─▀▀ 　 ▀▀▀─ ▀▀▀ 　 ─░█── ▀──▀ ▀─▀▀ ▀▀▀ ▀── ▀──▀ ▀▀▀"+"\n");
            }

            void ExibirOpcoesMenu()
            {
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Listar Tarefas");
                Console.WriteLine("3 - Atualizar status da Tarefas");
                Console.WriteLine("4 - Atualizar descrição da Tarefa");
                Console.WriteLine("5 - Remover tarefa");
                Console.WriteLine("6 - Filtar tarefa por status");
                Console.WriteLine("0 - Sair");

                Console.Write("\nDigite a opção: ");
               
                string opcaoEscolhida = Console.ReadLine()!;
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch(opcaoEscolhidaNumerica)
                {
                    case 1:
                        Console.Write("\nDigite a descrição da tarefa:");
                        string descricao = Console.ReadLine();
                        gerenciador.AdicionarTarefa(descricao);
                        Thread.Sleep(2000);
                        Console.WriteLine("\nSua tarefa foi adicionada com sucesso\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("Tecle ENTER para voltar ao menu !!");
                        Console.ReadLine();
                        Console.Clear();
                        ExibirOpcoesMenu();
                        break;

                    case 2:gerenciador.ListarTarefas();
                        
                        Thread.Sleep(2000);
                        Console.WriteLine("\nTecle ENTER para voltar ao menu !!");
                        Console.ReadLine();
                        Console.Clear();
                        ExibirOpcoesMenu();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("\nDigite o ID da tarefa: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("digite o status a ser adicionado a tarefa: ");
                        string status = Console.ReadLine();

                        gerenciador.AtualizarStatusDeTarefa(id, status);
                        Thread.Sleep(1000);
                        Console.WriteLine("\nTecle ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        ExibirOpcoesMenu();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\nDigite o ID da tarefa: ");
                        int Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("digite o descricao a ser adicionado a tarefa: ");
                        string novaDescricao = Console.ReadLine();

                        gerenciador.AtualizarDescricao(Id, novaDescricao);
                        Thread.Sleep(1000);
                        Console.WriteLine("\nTecle ENTER para voltar ao menu");
                        Console.ReadLine();
                        Console.Clear();
                        ExibirOpcoesMenu();
                        break;

                    case 0: Console.WriteLine("Fim do Programa !!");
                        break;
                    default: Console.WriteLine("\nopçao invalida");
                        Thread.Sleep(2000);
                        Console.Clear();
                        ExibirOpcoesMenu();
                        break;
                }

            }

            //Inicio do programa v2.
            Titulo();
            ExibirOpcoesMenu();

        }
    }
}
