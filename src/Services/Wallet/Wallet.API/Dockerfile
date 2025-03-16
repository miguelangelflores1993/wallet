FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Services/Wallet/Wallet.API/Wallet.API.csproj", "Services/Wallet/Wallet.API/"]
COPY ["Services/Wallet/Wallet.Application/Wallet.Application.csproj", "Services/Wallet/Wallet.Application/"]
COPY ["BuildingBlocks/BuildingBlocks.Messaging/BuildingBlocks.Messaging.csproj", "BuildingBlocks/BuildingBlocks.Messaging/"]
COPY ["BuildingBlocks/BuildingBlocks/BuildingBlocks.csproj", "BuildingBlocks/BuildingBlocks/"]
COPY ["Services/Wallet/Wallet.Domain/Wallet.Domain.csproj", "Services/Wallet/Wallet.Domain/"]
COPY ["Services/Wallet/Wallet.Infrastructure/Wallet.Infrastructure.csproj", "Services/Wallet/Wallet.Infrastructure/"]
RUN dotnet restore "./Services/Wallet/Wallet.API/./Wallet.API.csproj"
COPY . .
WORKDIR "/src/Services/Wallet/Wallet.API"
RUN dotnet build "./Wallet.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Wallet.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Wallet.API.dll"]