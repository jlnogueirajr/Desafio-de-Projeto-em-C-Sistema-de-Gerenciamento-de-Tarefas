namespace Projeto.Modulos
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Status{ get; set; }
        public DateTime DataCriacao { get; set; }

        public Tarefa(int id, string descricao, string status)
        {
            Id = id;
            Descricao = descricao;
            Status = status;
            DataCriacao = DateTime.Now;//A data da tarefa é preenchida com a data Atual.
        }
    }
}
