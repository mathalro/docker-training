FROM mcr.microsoft.com/dotnet/core/sdk:2.2.300-alpine3.9 AS build-env

WORKDIR /usr/app/src

COPY ./Program.cs .
COPY ./RegisterApplication.csproj .

RUN dotnet publish -o release

FROM mcr.microsoft.com/dotnet/core/runtime

WORKDIR /usr/app/bin    

COPY --from=build-env /usr/app/src/release .

ENTRYPOINT ["dotnet", "RegisterApplication.dll"]
