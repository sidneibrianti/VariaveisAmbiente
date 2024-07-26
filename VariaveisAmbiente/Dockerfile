#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

ENV Nivel1__Nivel2a "Dockerfile1"
ENV Nivel1__Nivel2b__Nivel3 "Dockerfile2"

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["VariaveisAmbiente/VariaveisAmbiente.csproj", "VariaveisAmbiente/"]
RUN dotnet restore "./VariaveisAmbiente/VariaveisAmbiente.csproj"
COPY . .
WORKDIR "/src/VariaveisAmbiente"
RUN dotnet build "./VariaveisAmbiente.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./VariaveisAmbiente.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VariaveisAmbiente.dll"]