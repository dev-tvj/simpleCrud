# SimpleCrudApp

SimpleCrudApp é uma aplicação web simples para manipulação de dados (CRUD) em uma tabela utilizando .NET 6 + Angular + SQL Server + Docker.


## Funcionalidades da Aplicação
- **Criação automatizada do container Docker e do banco de dados**: Script programado para criação automatizada do container Docker, bem como do banco de dados SQL Server.
- **CRUD de Orders**: A aplicação web permite a criação, leitura, atualização e exclusão de ordens.
- **Outras tabelas**: Embora o CRUD no backend se concentre na tabela Orders, os produtos podem ser gerenciados caso seja habilitado seus controllers já criados.


## Pré-Requisitos
Certifique-se que possui instalado em seu computador as seguintes aplicações:

- Docker
- .NET Core 6


## Instalação

1. Clone o repositório: `git clone https://github.com/dev-tvj/simpleCrud/`
2. Navegue até o diretório do projeto até a pasta `simpleCrud/Persistence`
3. Execute na sequência os seguintes comandos:
    - `docker build -t sqlserver .`
    - `docker run -e "ACCEPT_EULA=Y" -p 1433:1433 --name sqlserver -d sqlserver`
    - `docker start sqlserver`
    - `docker exec -dit sqlserver bash`
    - Agora seu SQL Server em seu container Docker está configurado, em execução e pronto para uso.
4. Via terminal, navegue até a pasta `simpleCrud/Backend/SimpleCrudApp` e digite o comando `dotnet run`.
5. Em seu navegador, abra o endereço `https://localhost:7227`. Dessa forma, você estará na página do Swagger da aplicação.
6. Pronto! Agora você está pronto para utilizar a simpleCrudAplication!

Observação: A aplicação foi devidamente testada em sistemas Linux e Windows.

Seguindo as configurações, assim que você der run no backend com o .NET 6, a aplicação estará já configurada para se comunicar com o SQL Server do container Docker, uma vez que a configuração de conexão já está devidamente implementada.

Assim que o projeto é executado, abre-se automaticamente uma janela do browser diretamente para o link do Swagger, onde você poderá fazer toda manipulação CRUD de dados. Spoiler: Na próxima versão da aplicação será implementado um frontend com Angular.


## Estrutura do Banco de Dados SQL Server

O banco de dados é criado via SQL script no momento da criação do container docker. Ao criar o container, o script é executado juntamente com uma sequência de comandos. assim, dá-se mais liberdade para se manipular o banco à vontade, sem medo de danificar qualquer dado, pois sempre que o container for recriado, você terá novamente um banco de dados novo e para uso. 

O banco de dados subjacente possui a seguinte estrutura:

### Tabela Order
- **id** (int, PK): Identificador único da order.
- **ClientName** (varchar(60)): Nome do cliente.
- **ClientEmail** (varchar(60)): E-mail do cliente.
- **CreationData** (datetime): Data de criação da order.
- **Paid** (bit): Indica se a order foi paga.

### Tabela OrderProduct
- **id** (int, PK): Identificador único do produto na order.
- **OrderId** (int, FK): Chave estrangeira para a tabela Order.
- **ProductId** (int, FK): Chave estrangeira para a tabela Product.
- **Quantity** (int): Quantidade do produto na order.

### Tabela Product
- **Id** (int, PK): Identificador único do produto.
- **ProductName** (varchar(20)): Nome do produto.
- **Value** (decimal(10,2)): Valor do produto.

O CRUD disponivel no backend da aplicação manipula exclusivamente a tabela Order.

Observação: Esse cenário é possível para essa aplicação pois se trata de um cenário de teste e demonstração de uso apenas.


Este projeto está licenciado sob a [Licença MIT](LICENSE).
