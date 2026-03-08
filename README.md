## Sobre o projeto

Esta **API** foi desenvolvida com o objetivo de oferecer uma solução estruturada para o controle financeiro pessoal. Utilizando o ecossistema **.NET 8** e seguindo os princípios do **Domain-Driven Design (DDD)**, a aplicação permite que os usuários registrem detalhadamente suas movimentações, incluindo título, data e hora, descrição, valor e tipo de pagamento. Todo o armazenamento de dados é realizado de forma persistente em um banco de dados **MySQL**, garantindo a integridade e a segurança das informações registradas.

A arquitetura da API baseia-se no modelo **REST**, utilizando os métodos **HTTP** padrão para uma comunicação eficiente e simplificada. Para facilitar o desenvolvimento e a integração, o projeto conta com o **Swagger**, uma ferramenta essencial que gera uma interface interativa que visa simplificar o design, a documentação, a construção e o consumo de APIs REST, permitindo que desenvolvedores e usuários testem os endpoints de maneira simplificada. 

Para otimizar o desenvolvimento e garantir a qualidade do código, o projeto faz uso de pacotes NuGet essenciais. O **AutoMapper** é responsável pelo mapeamento ágil entre os objetos de domínio e os de requisição/resposta, reduzindo drasticamente a necessidade de código manual e repetitivo. Já o **FluentValidation** implementa as regras de validação de forma simples e intuitiva diretamente nas classes de requisição, mantendo o código limpo, centralizado e de fácil manutenção. No contexto de garantia de qualidade, o **Shouldly** é utilizado nos testes de unidade para tornar as verificações mais expressivas e legíveis, ajudando na construção de testes claros e compreensíveis. Por fim, o **Entity Framework Core** atua como o ORM (Object-Relational Mapper) da aplicação, simplificando as interações com o banco de dados e permitindo a manipulação dos dados diretamente através de objetos .NET, abstraindo a complexidade de consultas SQL manuais.

### Features

- **Domain-Driven Design (DDD)**: Estrutura modular focada na clareza do negócio e na facilidade de manutenção a longo prazo.

- **Testes de Unidade**: Testes abrangentes com Shouldly para garantir a funcionalidade e a qualidade.

- **Business Intelligence & Reports**: Geração de relatórios analíticos em **PDF e Excel**, transformando dados brutos em insights visuais para uma gestão financeira estratégica.

- **API RESTful com Swagger**: Interface padronizada e totalmente documentada, otimizando a experiência do desenvolvedor e agilizando integrações.

# Getting Started

Para obter uma cópia local funcionando, siga estes passos simples.

### Requisitos

* Visual Studio versão 2022+ ou Visual Studio Code
* Windows 10+ ou Linux/MacOS com [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) instalado
* MySql Server

### Instalação

1. Clone o repositório:
    ```sh
    git clone https://github.com/LeonardoHMG/CashFlow.git
    ```

2. Preencha as informações no arquivo `appsettings.Development.json`.
3. Execute a API e aproveite o seu teste :)