FROM mcr.microsoft.com/dotnet/core/sdk:2.2.301-alpine3.9 AS build-env

WORKDIR /usr/app/src
COPY ./Controllers ./Models ./Services ./Program.cs ./Startup.cs ./RegisterApi.csproj ./
RUN dotnet publish -o Release --configuration release

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2.6-alpine3.9

WORKDIR /usr/app/bin
COPY --from=build-env /usr/app/src/Release .

ENTRYPOINT [ "dotnet", "RegisterApi.dll" ]