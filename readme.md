# Algebra Formulas

_Library of important formulas from algebra, cross plataform_

## Get Started 🚀

_You can download the project and upgrade the project cloning the repository or use it and adding the dll reference on the new project_

### Pre-requisites and builded with 📋 🛠️

* [.net 6](https://dotnet.microsoft.com/en-us/download) - dotnet 6.0.1
* [git](https://git-scm.com/) - For branching
* [vs code](https://code.visualstudio.com/) - For code edit

_xUnit For unit testings_

```
dotnet add package xunit --version 2.4.1
```

### Instalation 🔧

_You can download it as a zip for link the DLL to your project_

_Once downloaded on zip, unzip it and go to file bin/ref_

```
C: \Algebra> cd bin/ref 
```

_This file contain a dll files that you can put on your project to make the reference_

### Unit Testing ⌨️

_Find the testing project here_ [Calculator Testing](https://github.com/kikhi/CalculatorTest)

_xUnit used for this project_
```
dotnet new xunit -o AlgebraTests
```

_Add reference from project to testing project_
```
dotnet add AlgebraTests/AlgebraTests.csproj reference Algebra.csproj
```

_For test code use fallow command_
```
dotnet test AlgebraTests/AlgebraTests.csproj
```

_If the second time testing there are problems, put the follow instruction on files .csproj from project and test project_
```
<GenerateAssemblyInfo> false </GenerateAssemblyInfo>
```

## Deploy 📦

_For deployment need only build the project_

```
dotnet build
```

_Then take the dll file generated on the bin file and publish it_

## Licence 📄

This project is for free use - See the licence [LICENSE.md](LICENSE.md) for more details


---
[kikhi](https://github.com/kikhi) 😊