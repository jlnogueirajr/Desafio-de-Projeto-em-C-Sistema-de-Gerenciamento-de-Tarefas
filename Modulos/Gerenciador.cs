namespace Projeto.Modulos
{
    public class Gerenciador
    {
        //Dentro do gerenciador serao adiocionadas todas as funçoes do programa
        //onde sera criado um objeto gerenciador no Program.cs onde sera chamada as
        //funções pelo menu

        List<Tarefa> tarefas = new List<Tarefa>();//Lista para aarmazenar as tarefas
        int Id = 1;

        //Funçao para adicionar uma tarefa, que contem ID, DESCRIÇÂO e STATUS na criação
        public void AdicionarTarefa(string descricao)
        {
            Tarefa adicionarTarefa = new Tarefa(Id, descricao, "Pendente");
            tarefas.Add(adicionarTarefa);
            Id++;
        }

        //função para mostrar as tarefas adiocionadas
        public void ListarTarefas()
        {
            foreach (Tarefa tarefa in tarefas)//laço de repetição onde ao ser chamada mostra a tarefa for ID e Descrição
            {
                Console.WriteLine($"{tarefa.Id}. {tarefa.Descricao}");
            }
        }
    }
}
