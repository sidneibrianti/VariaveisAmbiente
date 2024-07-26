## README

# Aplicativo de Teste: Enviando Variáveis de Ambiente com Dockerfile e Docker Compose no .NET 8

Este repositório contém um aplicativo de exemplo que demonstra como enviar variáveis de ambiente utilizando Dockerfile e Docker Compose em um projeto .NET 8.

### Pré-requisitos

- Docker instalado na máquina
- Docker Compose instalado na máquina
- .NET 8 SDK instalado na máquina


### Passos para Execução

1. Clone o repositório:
   ```bash
   git clone https://github.com/sidneibrianti/VariaveisAmbiente.git
   cd seu-repositorio
   ```


### Observação

Ao executar o aplicativo, o valor da variável de ambiente `Nivel1__Nivel2a=DockerCompose1` `Nivel1__Nivel2b__Nivel3=DockerCompose2` será exibido no console. Este valor é definido no arquivo `docker-compose.yml`, mas pode ser sobrescrito conforme necessário.

### Conclusão

Este exemplo simples demonstra como utilizar variáveis de ambiente com Dockerfile e Docker Compose em um projeto .NET 8. Isso é particularmente útil para configurar e gerenciar diferentes ambientes em suas aplicações Dockerizadas.

### Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou um pull request.

### Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

