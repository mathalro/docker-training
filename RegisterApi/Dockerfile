FROM mcr.microsoft.com/dotnet/core/sdk:2.2.301-alpine3.9 as build-env

WORKDIR /usr/app/src
COPY ./Startup.cs ./Program.cs ./Controllers ./Models ./Services ./RegisterApi.csproj ./
RUN dotnet publish -o release --configuration Release

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2.6-alpine3.9

WORKDIR /usr/app/bin
COPY --from=build-env /usr/app/src/release .

ENTRYPOINT [ "dotnet", "RegisterApi.dll" ]