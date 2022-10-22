FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ProjetoComandas.View/ProjetoComandas.View.csproj", "ProjetoComandas.View/"]
RUN dotnet restore "ProjetoComandas.View/ProjetoComandas.View.csproj"
COPY . .
WORKDIR "/src/ProjetoComandas.View"
RUN dotnet build "ProjetoComandas.View.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjetoComandas.View.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjetoComandas.View.dll"]
