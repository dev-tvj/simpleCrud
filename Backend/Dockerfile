# Imagem base
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Imagem para compilação
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["/simpleCrudBackend/simpleCrudBackend.csproj", "./"]
RUN dotnet restore "./simpleCrudBackend.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./simpleCrudBackend/simpleCrudBackend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./simpleCrudBackend/simpleCrudBackend.csproj" -c Release -o /app/publish

# Imagem final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "simpleCrudBackend.dll"]