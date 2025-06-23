using Microsoft.Win32;
using System.IO;
using System.Text.Json;

namespace Projeto.Modulos
{
    public class Gerenciador
    {
        //Dentro do gerenciador serao adiocionadas todas as funçoes do programa
        //onde sera criado um objeto gerenciador no Program.cs onde sera chamada as
        //funções pelo menu

        string caminhoJson = "C:\\Users\\Xabloncio\\Desktop\\projeto\\Desafio-de-Projeto-em-C-Sistema-de-Gerenciamento-de-Tarefas\\tarefas.json";//Caminho de arquivo em formato JSON

        List<Tarefa> tarefas = new List<Tarefa>();//Lista para armazenar as tarefas
        int Id = 1;

        //Funçao para adicionar uma tarefa, que contem ID, DESCRIÇÂO e STATUS na criação
        public void AdicionarTarefa(string descricao, string status = "Pendente")
        {
           
            Tarefa adicionarTarefa = new Tarefa(Id, descricao, status: status);
            tarefas.Add(adicionarTarefa);
            Id++;

            
            SalvarTarefasEmJson();//chamada da função
        }

        //função para mostrar as tarefas adiocionadas
        public void ListarTarefas()
        {

            foreach (Tarefa tarefa in tarefas)//laço de repetição onde ao ser chamada mostra a tarefa por ID, Descrição, Status atual e a data de criação
            {
                Console.WriteLine($"{tarefa.Id}. {tarefa.Descricao} | Status: {tarefa.Status} | Criada em: {tarefa.DataCriacao}");
            }
        }

        //funcao para adicionar um arquivo.json com os registros de tarefas
        public void SalvarTarefasEmJson()
        {
            try
            {
                string json = JsonSerializer.Serialize(tarefas, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("C:\\Users\\Xabloncio\\Desktop\\projeto\\Desafio-de-Projeto-em-C-Sistema-de-Gerenciamento-de-Tarefas\\tarefas.txt", json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar tarefas em JSON: " + ex.Message);
            }
        }

        //função para carregar todos os dados que estao no arquivo se o programa for fechado
        public void CarregarTarefasDoArquivo()
        {
            try
            {
                if (File.Exists("C:\\Users\\Xabloncio\\Desktop\\projeto\\Desafio-de-Projeto-em-C-Sistema-de-Gerenciamento-de-Tarefas\\tarefas.txt"))
                {
                    string json = File.ReadAllText("C:\\Users\\Xabloncio\\Desktop\\projeto\\Desafio-de-Projeto-em-C-Sistema-de-Gerenciamento-de-Tarefas\\tarefas.txt");
                    tarefas = JsonSerializer.Deserialize<List<Tarefa>>(json) ?? new List<Tarefa>();

                    // Garante que o próximo ID seja sempre o maior + 1
                    if (tarefas.Any())
                        Id = tarefas.Max(t => t.Id) + 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar tarefas do JSON: " + ex.Message);
            }
        }
    }
}
