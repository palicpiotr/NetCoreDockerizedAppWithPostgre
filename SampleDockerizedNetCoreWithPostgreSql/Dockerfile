FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY SampleDockerizedNetCoreWithPostgreSql/SampleDockerizedNetCoreWithPostgreSql.csproj SampleDockerizedNetCoreWithPostgreSql/
RUN dotnet restore SampleDockerizedNetCoreWithPostgreSql/SampleDockerizedNetCoreWithPostgreSql.csproj
COPY . .
WORKDIR /src/SampleDockerizedNetCoreWithPostgreSql
RUN dotnet build SampleDockerizedNetCoreWithPostgreSql.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish SampleDockerizedNetCoreWithPostgreSql.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SampleDockerizedNetCoreWithPostgreSql.dll"]
