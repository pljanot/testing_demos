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