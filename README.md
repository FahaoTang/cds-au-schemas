# Consumer Data Standards - ASP.NET Core 2.2 Server

API sets created by the Australian Consumer Data Standards to meet the needs of the Consumer Data Right

## Live demo
https://cds-dotnetcore.azurewebsites.net/ 

## Sample screenshot
![sample screenshot][sample-screenshot]


# How to run the application

## Run

### Linux/OS X:

```
sh build.sh
```

### Windows:

```
build.bat
```

### Directly run
```
dotnet run -p src\ConsumerDataStandards\ConsumerDataStandards.csproj --launch-profile web
```

## Run in Docker

```
cd src/ConsumerDataStandards
docker build -t consumerdatastandards .
docker run -p 5000:5000 consumerdatastandards
```

# To be done
Please join me if you want to contribute in the following areas.

## Sample data sets
The current APIs don't include sample data. 

## OIDC implementation
This is to be done for authentication and authorisation purpose. 

# References
## Consumer Data Standards
https://consumerdatastandardsaustralia.github.io/standards/#introduction

[sample-screenshot]: img/sample-api-website.PNG "sample screenshot"