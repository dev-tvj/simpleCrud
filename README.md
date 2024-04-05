# simpleCrudApp

SimpleCrudApp
Esta é uma simples aplicação web para manipular dados (CRUD) em uma tabela usando NET 6 + Angular + SQLserver + Docker.


Estrutura do Banco de Dados

O banco de dados subjacente possui a seguinte estrutura:

Tabela Order
    id (int, PK): Identificador único da ordem.
    ClientName (varchar(60)): Nome do cliente.
    ClientEmail (varchar(60)): E-mail do cliente.
    CreationData (datetime): Data de criação da ordem.
    Paid (bit): Indica se a ordem foi paga.

Tabela OrderProduct
    id (int, PK): Identificador único do produto na ordem.
    OrderId (int, FK): Chave estrangeira para a tabela Order.
    ProductId (int, FK): Chave estrangeira para a tabela Product.
    Quantity (int): Quantidade do produto na ordem.

Tabela Product
    Id (int, PK): Identificador único do produto.
    ProductName (varchar(20)): Nome do produto.
    Value (decimal(10,2)): Valor do produto.

O CRUD no backend da aplicação manipula exclusivamente a tabela Order.

Funcionalidades da Aplicação

    CRUD de Orders: A aplicação web permite a criação, leitura, atualização e exclusão de orders.
    Outras tabelas: Embora o CRUD no backend se concentre na tabela Orders, os produtos podem ser gerenciados caso seja habilitado seus controllers já criados.

Pré-Requisitos
    Banco de dados SQL Server
    Docker
    .NET core 6


Instalação

    Clone o repositório: git clone https://github.com/dev-tvj/simpleCrud/
    Navegue até o diretório do projeto até a pasta Persistence
        Execute na sequencia os seguintes comandos: 
            docker build -t sqlserver .
            docker run --name sqlserver --network=my-docker-net --ip=172.19.0.5 -d sqlserver
            docker start sqlserver
            sudo docker exec -dit sqlserver bash
        Agora seu SQL Server em seu container docker está configurado e pronto para uso
    
    Seguindo as configurações, assim que você der run no backend com o .NET 6, a aplicação estará já configurada para se comunicar com o SQL server, uma vez que a configuração de conexção já está feita de acordo com o IP estático estipulado na criação do container.




Este projeto está licenciado sob a Licença MIT.
