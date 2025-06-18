🔥 Desafio de Projeto em C#: Sistema de Gerenciamento de Tarefas
💡 Descrição:

Crie um Gerenciador de Tarefas, onde é possível cadastrar tarefas, listar, atualizar status (pendente, em andamento, concluída) e excluir tarefas.
🚀 Funcionalidades obrigatórias:

    ➕ Adicionar Tarefa

        Descrição da tarefa

        Data de criação (gerada automaticamente)

        Status (começa como “Pendente”)

    📜 Listar Tarefas

        Exibir todas as tarefas cadastradas com:

            ID

            Descrição

            Status

            Data de Criação

    ✍️ Atualizar Status da Tarefa

        Usuário escolhe a tarefa pelo ID e altera o status:

            Pendente ➡️ Em andamento ➡️ Concluído

    ❌ Remover Tarefa

        Remover pelo ID

    🔍 Filtrar Tarefas

        Por status (Ex.: mostrar só as pendentes ou só as concluídas)

🎯 O que vocês vão treinar:
Conceito	Onde será aplicado
Variáveis	Armazenar dados das tarefas
Listas (List<>)	Guardar as tarefas na memória
Laços (foreach, for)	Para percorrer e exibir as tarefas
Condicionais (if, switch)	Atualizar status, verificar ações do usuário
Métodos (Funções)	Criar funções como AdicionarTarefa(), ListarTarefas(), etc.
Classe e Objetos (OOP)	A classe Tarefa vai representar cada tarefa
Manipulação de Datas	Usar DateTime.Now para registrar a data de criação
🧠 Modelagem da Classe

class Tarefa
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public string Status { get; set; } // "Pendente", "Em andamento", "Concluída"
    public DateTime DataCriacao { get; set; }
}

🏗️ Menu de Operações

Exibir no console um menu como este:

======= GERENCIADOR DE TAREFAS =======
1 - Adicionar nova tarefa
2 - Listar tarefas
3 - Atualizar status da tarefa
4 - Remover tarefa
5 - Filtrar tarefas por status
0 - Sair
Escolha uma opção:

💾 Desafio bônus (opcional):

    💾 Salvar os dados das tarefas em um arquivo .txt ou .json para que o programa não perca os dados ao fechar.

    🕵️ Adicionar uma busca por palavra-chave na descrição.

📦 Divisão de tarefas na dupla:

    🔧 Pessoa 1: cuida da criação da classe Tarefa, métodos de cadastro e atualização.

    🎨 Pessoa 2: cuida do menu, da exibição, das listagens e dos filtros.

No final, juntam tudo.
