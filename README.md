# Referências Bibliográficas

Simples script para formatação de nome de autores para padrão ABNT. Para mais informações sobre o desafio, veja o arquivo [Challenge](CHALLENGE.md)

## Como rodar

É simples de rodar com Docker, e é recomendado. Se você não tem o docker instalado, por favor, veja a [documentação do Docker](https://docs.docker.com/compose/install/).

### Com docker

Clone este repositório, navegue até a pasta dele e execute o comando abaixo para criar a imagem:

```shell
$ docker-build . -t obras-bibliograficas
```

Então basta chamar a imagem passando os seguintes parametros:

- Número representando a quantidade de nomes que serão fornecidos
- Nomes dos autores

Exemplo de uso:

```shell
$ docker run obras-bibliograficas 3 "Ricardo da Verdade Silva" "ricardo da verdade silva neto" "guimaraes"
```

A saída do programa será:

```shell
SILVA, Ricardo da Verdade
SILVA NETO, Ricardo da Verdade
GUIMARAES
```

### Sem docker

A única dependência para este projeto é o [.NET Core v3.0](https://dotnet.microsoft.com/download)

Após instalar o .NET e o Node, faça o download deste repositório e navegue até a pasta _src_ (substitua ~/git pelo seu caminho de download):

```shell
$ cd ~/git/obras-bibliograficas/src
```

Faça o download de todos os pacotes utilizados neste projeto:

```shell
$ dotnet restore
```

(OPCIONAL) Rode todos os testes para ter certeza que você não baixou uma versão instável:

```shell
$ dotnet test
```

Então basta rodar o programa os seguintes parametros:

- Número representando a quantidade de nomes que serão fornecidos
- Nomes dos autores

Exemplo de uso:

```shell
$ dotnet run 3 "Ricardo da Verdade Silva" "ricardo da verdade silva neto" "guimaraes"
```

A saída do programa será:

```shell
SILVA, Ricardo da Verdade
SILVA NETO, Ricardo da Verdade
GUIMARAES
```
