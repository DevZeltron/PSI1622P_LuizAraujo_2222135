# Pizzaria Raimundo

## Projeto de uma Simulação de uma Pizzaria Virtual com Sistema de Admin e Utilizador

### Introdução
O projeto “Pizzaria Raimundo” é um programa que tem como objetivo integrar uma pizzaria virtual, onde o utilizador pode escolher entre pizzas e bebidas. O ponto principal do projeto é permitir ao utilizador fazer escolhas entre pizzas e bebidas e, depois de escolher seus produtos desejados, realizar a compra no final do programa. O projeto permite também que o administrador do sistema possa modificar os produtos da sua pizzaria para que o utilizador tenha uma experiência agradável.

Neste relatório, vou relatar as tecnologias que utilizei para realizar este projeto, o processo de implementação, o cronograma e os aspetos técnicos de desenvolvimento do meu projeto.

### Tecnologias e Recursos

#### Bibliotecas Utilizadas
- **Microsoft.Data.SqlClient**: Usada para aceder e manipular dados em SQL Server.
- **ReaLTaiizor**: Usada para fazer o design do AdminPanel.

#### Ferramentas Utilizadas
- **Visual Studio 2022**: Execução do projeto e gestão da base de dados.
- **Pencil 3.1.1**: Usado para fazer o esquema da base de dados.

#### Requisitos Mínimos
- **CPU**: Processador Intel ou AMD x64 bits.
- **RAM**: 2GB+.
- **Armazenamento**: 1GB+.

### Implementação

#### Cronograma de Desenvolvimento do Projeto

1. **Início do Projeto**
   - Data: 2 de Maio de 2024
   - Descrição: Criação inicial da documentação e do repositório GitHub.
   - Atividades:
     - Criação da pasta Docs/Originais.

2. **Prototipagem e Planeamento**
   - Data: 16 de Maio de 2024
   - Descrição: Design e UI do Pré-projeto.
   - Atividades:
     - Finalização do design do pré-projeto.

3. **Desenvolvimento da Base de Dados**
   - Data: 22 de Maio de 2024 – 23 de Maio de 2024
   - Descrição: Realização da estrutura inicial da Base de Dados.
   - Atividades:
     - Criação da Base de Dados.
     - Criação do logótipo do Projeto.
     - Criação e design de alguns forms.

4. **Desenvolvimento do Projeto e Base de Dados**
   - Data: 29 de Maio de 2024 – 31 de Maio de 2024
   - Descrição: Continuação do desenvolvimento do Projeto e alterações feitas na Base de Dados.
   - Atividades:
     - Modificações na Base de Dados.
     - Realização e alteração na UI de alguns forms.

5. **Criação do forms AdminPanel e Alterações ao projeto**
   - Data: 05 de Junho de 2024 – 21 de Junho de 2024
   - Descrição: Realização do AdminPanel (forms do admin.) e mais alterações feitas a outros forms.
   - Atividades:
     - AdminPanel realizado com mudanças de design.
     - Realização e alteração no design de alguns forms.

6. **Modificações finais aos forms para a entrega do projeto**
   - Data: 26 de Junho de 2024 – 28 de Junho de 2024
   - Descrição: Organização final do projeto e da Base de Dados.
   - Atividades:
     - Pequenas alterações na Base de Dados.
     - Organização final do código do projeto.

7. **Conclusão do Código**
   - Data: 28 de Junho de 2024
   - Descrição: Finalização e revisão do código do projeto e Base de Dados.
   - Atividades:
     - Conclusão do código.

### Aspetos Técnicos do Desenvolvimento do Projeto

#### Requisitos e Funcionalidades do Projeto
- **REQ01**: Permitir a criação de uma conta – Realizado.
- **REQ02**: Menu de produtos – Realizado.
- **REQ03**: Carrinho de compras – Realizado.
- **REQ04**: Interação com o utilizador – Realizado.

#### Requisitos Técnicos e/ou de Performance
- Base de dados eficiente.
- Modo de Administrador do programa.
- Permitir a criação de novos utilizadores.

### Interfaces

#### Interfaces de Utilizador
- Criação de conta
- Login da conta
- Seleção de Pizzas
- Seleção de Bebidas
- Secção de Pagamento
- Pagamento com Cartão
- Pagamento com Dinheiro

#### Interfaces de Administrador
- Editar Pizzas ou Bebidas
- Adicionar Pizzas ou Bebidas
- Remover Pizzas ou Bebidas

### Estrutura da Base de Dados
A base de dados foi projetada para suportar o sistema da pizzaria. O modelo de dados inclui as seguintes tabelas:

- **Tabela loginn**
  - Armazena informações dos utilizadores.
  - Campos: user_id (chave primária, autoincremento), username, password, role.
- **Tabela Bebida**
  - Armazena as informações das bebidas.
  - Campos: bebida_id(chave primária, autoincremento), nomebev, preco.
- **Tabela sabor_pizzas**
  - Armazena as informações relativas às pizzas.
  - Campos: sabor_id(chave primária, autoincremento), nome, preco.

### Conclusão
Em suma, acho que a “Pizzaria Raimundo” conseguiu atingir alguns objetivos que eu tinha em mente e estou contente com o que eu fiz, embora saiba que poderia ter ficado melhor. O projeto poderia ter fluido um pouco mais rápido se partes da matéria de SQL tivessem sido abordadas em aula, facilitando a aplicação da base de dados ao projeto.

### Bibliografia
- Admin Panel - Menu
- GitHub Desktop

### Anexos
Não há anexos para serem colocados aqui.
