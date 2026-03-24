FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY MyFirstCI.Api.csproj ./

RUN dotnet restore

COPY . .

RUN dotnet publish MyFirstCI.Api.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS release
WORKDIR /app
ENV ASPNETCORE_URLS=https://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production
COPY --from=build /app/out .
EXPOSE 8080
ENTRYPOINT ["dotnet", "MyFirstCI.Api.dll"]