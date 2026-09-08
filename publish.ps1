dotnet publish -r win-x64 -c Release
Remove-Item src\bin\Release\net10.0\win-x64\publish\*.pdb
Copy-Item src\wwwroot src\bin\Release\net10.0\win-x64\publish -Recurse -Force
makensis installer.nsi