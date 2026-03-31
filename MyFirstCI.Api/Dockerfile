FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY MyFirstCI.Api.csproj ./

RUN dotnet restore

COPY . .

RUN dotnet publish MyFirstCI.Api.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS release
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

RUN apt-get update && apt-get install -y --no-install-recommends curl && rm -rf /var/lib/apt/lists/*
HEALTHCHECK --interval=30s --timeout=10s --retries=3 CMD curl -f http://localhost:8080/api/Weather/WeatherForecast || exit 1

COPY --from=build /app/out .
EXPOSE 8080
ENTRYPOINT ["dotnet", "MyFirstCI.Api.dll"]