FROM mcr.microsoft.com/dotnet/core/sdk:2.2.300-alpine3.9 AS build-env

WORKDIR /usr/app/src
COPY ./Startup.cs ./Program.cs ./RegisterApi.csproj ./Controllers ./Models ./Services ./

RUN dotnet publish -o release --configuration Release

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2.5-alpine3.9

WORKDIR /usr/app/bin

COPY --from=build-env /usr/app/src/release .

ENTRYPOINT [ "dotnet", "RegisterApi.dll" ]