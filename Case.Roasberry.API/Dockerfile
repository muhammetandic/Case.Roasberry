#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Case.Roasberry.API/Case.Roasberry.API.csproj", "Case.Roasberry.API/"]
COPY ["Case.Roasberry.Application/Case.Roasberry.Application.csproj", "Case.Roasberry.Application/"]
COPY ["Case.Roasberry.Core/Case.Roasberry.Core.csproj", "Case.Roasberry.Core/"]
COPY ["Case.Roasberry.Infrastructure/Case.Roasberry.Infrastructure.csproj", "Case.Roasberry.Infrastructure/"]
COPY ["Case.Roasberry.Persistence/Case.Roasberry.Persistence.csproj", "Case.Roasberry.Persistence/"]
RUN dotnet restore "./Case.Roasberry.API/./Case.Roasberry.API.csproj"
COPY . .
WORKDIR "/src/Case.Roasberry.API"
RUN dotnet build "./Case.Roasberry.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Case.Roasberry.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Case.Roasberry.API.dll"]