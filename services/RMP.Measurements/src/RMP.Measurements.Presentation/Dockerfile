#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/RMP.Measurements.Presentation/RMP.Measurements.Presentation.csproj", "src/RMP.Measurements.Presentation/"]
RUN dotnet restore "src/RMP.Measurements.Presentation/RMP.Measurements.Presentation.csproj"
COPY . .
WORKDIR "/src/src/RMP.Measurements.Presentation"
RUN dotnet build "RMP.Measurements.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RMP.Measurements.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RMP.Measurements.Presentation.dll"]