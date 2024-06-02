# Sistema de Hospedagem

Projeto para um sistema de hospedagem que realiza reservas em um hotel, calculando corretamente os valores das reservas, considerando a quantidade de hóspedes e aplicando um desconto para reservas de longa duração.

## Funcionalidades

- **Classe Pessoa**: Representa um hóspede.
- **Classe Suite**: Representa uma suíte do hotel.
- **Classe Reserva**: Faz a relação entre pessoas e suítes, calcula o valor total da reserva e aplica descontos para reservas acima de 10 dias.

## Estrutura do Projeto

- `Pessoa.cs`
- `Suite.cs`
- `Reserva.cs`
- `Program.cs`

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/)

## Configuração do Ambiente

1. Instale o .NET SDK.
2. Instale o Visual Studio Code.
3. Instale a extensão C# no Visual Studio Code.

## Executando o Projeto

1. Clone o repositório ou baixe os arquivos do projeto.
2. Abra o terminal no Visual Studio Code.
3. Navegue até o diretório do projeto:
   ```sh
   cd caminho/para/o/diretorio/SistemaDeHospedagem
   ```
4. Execute o projeto:
   ```sh
   dotnet run
   ```

## Contribuições

Para contribuir com melhorias:

1. Faça um fork deste repositório.
2. Crie uma branch (`git checkout -b feature/nova-feature`).
3. Faça commit das suas alterações (`git commit -m 'Adiciona nova feature'`).
4. Faça push para a branch (`git push origin feature/nova-feature`).
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
