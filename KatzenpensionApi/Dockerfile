# 1. Build Stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# csproj kopieren und Wiederherstellung ausführen
COPY KatzenpensionApi.csproj ./
RUN dotnet restore

# Restlichen Code kopieren und bauen
COPY . ./
RUN dotnet publish -c Release -o /app/out

# 2. Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

COPY --from=build /app/out .

# Verhindert den "inotify limit"-Crashes auf Cloud-Servern wie Render
ENV DOTNET_hostBuilder__reloadConfigOnChange=false

# Port für Render setzen
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

# Hier deine spezifische DLL angeben:
ENTRYPOINT ["dotnet", "KatzenpensionApi.dll"]