#movie-web-api

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* .NET 5  
  [Download](https://dotnet.microsoft.com/download/dotnet/5.0) and install latest version of .Net 5.
  And add dotnet ef to your dotnet tools globally `dotnet tool install --global dotnet-ef`.
* Docker
  [Download](https://docs.docker.com/get-docker/) and install Docker and docker-composer

### How to run
1. Start db in docker
```
docker-compose up
```

2. Run db migration
```
cd MovieDemo
dotnet ef database update
```

3. Run app
```
dotnet run
```
Check swagger on `https://localhost:5001/swagger/index.html`