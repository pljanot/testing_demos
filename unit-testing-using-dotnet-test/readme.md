## Xunit in VSC, cmds

Basic commands to control visual studio project
```
dotnet new sln -o unit-testing-using-dotnet-test
cd unit-testing-using-dotnet-test
dotnet new classlib -o PrimeService
ren .\PrimeService\Class1.cs PrimeService.cs
dotnet sln add ./PrimeService/PrimeService.csproj
dotnet new xunit -o PrimeService.Tests
dotnet add ./PrimeService.Tests/PrimeService.Tests.csproj reference ./PrimeService/PrimeService.csproj
dotnet sln add ./PrimeService.Tests/PrimeService.Tests.csproj
```

Omnisharp - missing intelisense import namespaces
```
https://stackoverflow.com/questions/53964079/intellisense-for-available-using-imports-in-c-sharp-with-visual-studio-code
```

Xunit - Shared Context - fixtures

```
https://xunit.net/docs/shared-context
```

## Mocks 

Links:
```
https://nsubstitute.github.io/help/getting-started/
```

Adding nsubistute - one of most popular mock packages
```
dotnet new xunit -o Nsubisute.Mock.Tests
dotnet sln add ./Nsubisute.Mock.Tests/Nsubisute.Mock.Tests.csproj
dotnet add Nsubisute.Mock.Tests/Nsubisute.Mock.Tests.csproj package NSubstitute --version 4.3.0
```

I see a problem after adding Nsubsistute with discovering namespace,

```
Ctrl Shift + P (command pallete) -> Restart omnisharp [Help out]
```