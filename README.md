# PBLauncher Project Elite - Public Version
> Not the current version of PBLauncher in use by Project Elite - Não é a versão atual do PBLauncher em uso pelo Project Elite

# Recursos
* Sistema de atualização dos arquivos do jogo
* Inicialização do jogo com suporte a o XCLoader
* Sistema de mensagem personalizada para manutenções ou alertas de aberturas
* LauncherKey via host
* Configuração do launcher simples e facil

# Configurações
* No htdocs do seu site coloque a pasta 'launcher'.
* Edite as configurações de abertura no arquivo 'settings.conf'.
* Abra o projeto no visual studio, procure o arquivo 'Connect.cs' coloque o nome do seu project e o URL do 'settings.conf', compile, se tudo ocorrer sem erros, o launcher estará pronto para uso.

```ascii
[Status]
1= Manutenção
2= Manutenção + Alerta
3= Início normal
4= Início normal + Alerta

[Notice / Alerta]
Escreva qualquer texto no arquivo que deseje anunciar aos players.
Mude um status que possua '+ alerta'
* Caso o alerta estiver vazio o status sera ajustado automaticamente e nada será exibido

O Alerta irá aparecer cada vez que o player abrir o launcher até o status voltar a ser 3.
```
