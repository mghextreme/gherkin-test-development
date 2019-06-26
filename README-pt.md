# Desenvolvimento de Testes

> Also available in [english](README.md).

Bem vindo ao nosso teste técnico de desenvolvimento de testes.

Primeiro, se você está aqui é por que estamos seguindo adiante. Isso é bom.
Agora você tem a chance de nos mostrar quão bom você é.

Antes de começar, respire fundo e...

- Relaxe
- Faça com calma
- Qualidade acima de tudo
- Seja criativo
- Surpreenda-nos

Sobre o processo de recrutamento...

- [x] Introdução com o RH
- [x] **Teste técnico** (você está aqui)
- [ ] Entrevista com o gerente
- [ ] Entrevista com líderes técnicos
- [ ] Proposta

## O que fazer

Acesse [essa loja online](http://automationpractice.com/index.php) e procure por situação para testar.

Alguns exemplos são...

- Sign in _(que obriga a fazer o sign up antes)_
- Carrinho
- Visão de produto

Encontre pelo menos 3 funcionalidades para serem testadas.

### Gherkin

> Também conhecido como _Cucumber_

Escreva pelo menos 2 cenários (_scenarios_) para cada funcionalidade (_feature_).  
Arquivos `.feature` devem ser colocados na pasta `src/gherkin`.

> Não conhece Gherkin? Dê uma olhada no [tutorial oficial](https://cucumber.io/docs/gherkin/) ou dê uma pesquisada online

### Código

Codifique 2 dos items descritos no arquivo Gherkin.  
Você provavelmente vai precisar de uma ferramenta para obter os dados do site, como [Selenium](http://www.seleniumframework.com/).

## Regras e dicas

- Use **Inglês** pra tudo
- Coloque os arquivos `.feature` na pasta `src/gherkin/`
  - Descreva testes para pelo menos 3 funcionalidades (_features_)
  - Descreva pelo menos 2 cenários (_scenarios_) por funcionalidade
- Codifique 2 dos cenários listados
- Use [git](https://git-scm.com/) para versionamento. Faça commit com frequência
- Use [Selenium](http://www.seleniumframework.com/) para obter dados e navigar pelo site
- A linguagem de programação fica a sua escolha
  - Se você optar por C\#, você já tem uma base para começar seguindo o guia abaixo

### C\#

Para desenvolver testes em C\#, certifique-se de ter o [SDK do .NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2) instalado.  

Se você programar com o [VSCode](https://code.visualstudio.com/download), abra a pasta `src/csharp` com ele.  
Você já tem 2 _tasks_ pré-configuradas para te ajudar no desenvolvimento. Apenas use o atalho `Ctrl + Shift + P`, digite `Run Task` e selecione `build` (para compilar) ou `test` (para testar).

Como o `SpecFlow` está instalado, você só precisa adicionar os arquivos `.feature` na pasta `WebsiteTests/Features` e as classes serão auto-geradas ao compilar.

Para os arquivos de teste, você só precisa adicionar o atributo `[Binding]` na `public class` e adicionar `[Given("")]`, `[When("")]` ou `[Then("")]` nos métodos `public void` de teste.

> Veja a classe `Calculator.cs` para um exemplo completo.
