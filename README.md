# Test Development

> Também disponível em [português](README-pt.md).

Welcome to our test development technical test.

First, if you are here it means that you are moving forward, this is good.
Now you have a chance to show us how good you are.

Before you start take a big breath and...

- Relax
- Take your time
- Quality above all else
- Be creative
- Surprise us

About the recruitment process...

- [x] HR Brief
- [x] **Technical test** (you are here)
- [ ] Manager Interview
- [ ] Tech Lead interview
- [ ] Job offer

## What to do

Access [this online store](http://automationpractice.com/index.php) page and look for situations to test.

Some examples are...

- Sign in _(requires you to sign up)_
- Cart
- Quick View

Find at least 3 features to be tested.

### Gherkin

> Also known as _Cucumber_

Write at least 2 scenarios to be tested for each feature.  
`.feature` files should be placed in the `src/gherkin` folder.

> Not familiar with Gherkin? You can check the [official tutorial](https://cucumber.io/docs/gherkin/) or check any online tutorial

### Code

Code 2 of the Gherkin items.  
You may want to use a tool to grab the data from the website, such as [Selenium](http://www.seleniumframework.com/).

## Rules and Tips

- Use **English** for everything
- Add the `.feature` file to the `src/gherkin/` folder
  - At least 3 features
  - At least 2 scenarios per feature
- Automate 2 of the scenarios listed
- Use [git](https://git-scm.com/) for versioning. Commit often
- Use [Selenium](http://www.seleniumframework.com/) for obtaining data from and navigating the website
- The programming language is up to you
  - If you choose C\#, you may have a _headstart_ following the guide below

### C\#

To develop tests in C\#, make sure to have the [.NET Core 2.2 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.2) installed.  

If you program with [VSCode](https://code.visualstudio.com/download), open the `src/csharp` folder with it.  
You have 2 pre-configured tasks to help you develop. Just press `Ctrl + Shift + P`, type `Run Task` and select either `build` or `test`.

Because `SpecFlow` is installed, you just need to add your `.feature` file in the `WebsiteTests/Features` folder and a class will be auto-generated when building.

On the test files, you just need to add the `[Binding]` attribute to the `public class` and one of `[Given("")]`, `[When("")]` or `[Then("")]` on the `public void` test methods.

> Check `Calculator.cs` for a complete example.
