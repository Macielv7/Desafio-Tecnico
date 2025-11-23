## 🚀 WebAPI - Desafio Técnico

Este projeto consiste em uma **WebAPI de To Do List** desenvolvida como parte do desafio técnico para a vaga de Desenvolvedor C\#.

A solução implementa o **CRUD** (Create, Read, Update, Delete) em uma tabela de tarefas, permitindo adicionar, editar e remover itens da lista.

### 🛠️ Tecnologias e Ferramentas

A solução foi construída utilizando as seguintes tecnologias, conforme as especificações do desafio:

**Estrutura de Destino:** .NET 8.0
**ORM (Object-Relational Mapping):** Entity Framework Core
**Banco de Dados:** SQL Server

### ⚙️ Configuração e Execução

Siga os passos abaixo para configurar o ambiente, realizar o *build* e executar a solução.

#### 1\. Pré-requisitos

Certifique-se de ter os seguintes itens instalados em sua máquina:

  **.NET SDK:** Versão 8.0 ou superior.
  **SQL Server:** Qualquer versão.

#### 2\. Configuração do Banco de Dados

1.  **Restauração do Banco de Dados:**

      * O backup do banco de dados utilizado no projeto (`WebApiTarefasDB.bak`) está disponível neste repositório.
      * Restaure o backup em sua instância local do SQL Server.
      * **Nome do Banco de Dados:** `[WebApiTarefasDB]`.

2.  **Ajuste da String de Conexão:**

      * Localize o arquivo `appsettings.json` na solução.
      * Atualize a `ConnectionString` para corresponder à sua configuração local do SQL Server (servidor, nome do banco, credenciais, etc.).

    > Exemplo (Ajuste conforme necessário):

    > ```json
    > "ConnectionStrings": {
    >   "DefaultConnection": "Server=[SEU_SERVIDOR];Database=[NomeDoSeuBanco];"
    > }
    > ```

#### 3\. Build e Execução

1.  **Clone o Repositório:**

    ```bash
    git clone [https://github.com/Macielv7/Desafio-Tecnico]
    cd [PastaDoProjeto]
    ```

2.  **Execute o Build da Solução:**

    ```bash
    dotnet build
    ```

3.  **Execute a WebAPI:**
   
      * Execute o comando:
        ```bash
        dotnet run
        ```

5.  **Acesso à API:**

      * A API estará disponível no endereço indicado no *output* do comando `dotnet run` (geralmente `http://localhost:api/Tarefa`).
      * A documentação do **Swagger/OpenAPI** estará acessível em `http://localhost:5018/swagger/index.html`.

### 📖 Endpoints da API

A WebAPI expõe os seguintes *endpoints* para gerenciar a lista de tarefas:

| Método | Endpoint | Descrição |
| :---: | :--- | :--- |
| `GET` | `/api/Tarefa` | Retorna todas as tarefas. |
| `GET` | `/api/Tarefa/{id}` | Retorna uma tarefa específica pelo ID. |
| `POST` | `/api/Tarefa` | **Adiciona** uma nova tarefa. |
| `PUT` | `/api/Tarefa/{id}` | **Edita** uma tarefa existente. |
| `DELETE` | `/api/Tarefa/{id}` | **Remove** uma tarefa pelo ID. |
