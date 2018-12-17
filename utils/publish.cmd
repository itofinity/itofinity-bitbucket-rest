dotnet publish --framework netcoreapp2.1 --runtime win-x64
dotnet publish --framework netcoreapp2.1 --runtime linux-x64
dotnet publish --framework netcoreapp2.1 --runtime osx-x64

dir .\src\Itofinit.Appveyor.Cli\Release\netcoreapp2.1\win-x64\publish

EXIT /B 0