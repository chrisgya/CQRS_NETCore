FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["CQRS_NETCore.API/CQRS_NETCore.API.csproj", "CQRS_NETCore.API/"]
RUN dotnet restore "CQRS_NETCore.API/CQRS_NETCore.API.csproj"
COPY . .
WORKDIR "/src/CQRS_NETCore.API"
RUN dotnet build "CQRS_NETCore.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CQRS_NETCore.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CQRS_NETCore.API.dll"]