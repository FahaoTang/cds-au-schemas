:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::

@echo off

dotnet restore src\ConsumerDataStandards
dotnet build src\ConsumerDataStandards
echo Now, run the following to start the project: dotnet run -p src\ConsumerDataStandards\ConsumerDataStandards.csproj --launch-profile web.
echo.
