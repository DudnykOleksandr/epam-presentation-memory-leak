#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-alpine3.9 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-alpine3.9 AS build
WORKDIR /src
COPY ["FillReleaseMemoryApp/FillReleaseMemoryApp.csproj", "FillReleaseMemoryApp/"]
RUN dotnet restore "FillReleaseMemoryApp/FillReleaseMemoryApp.csproj"
COPY . .
WORKDIR "/src/FillReleaseMemoryApp"
RUN dotnet build "FillReleaseMemoryApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FillReleaseMemoryApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FillReleaseMemoryApp.dll"]