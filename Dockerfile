FROM mcr.microsoft.com/dotnet/aspnet:5.0.9-alpine3.13-amd64 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine3.13-amd64 AS build
WORKDIR /src
COPY ["ProductStoreAPI/ProductStoreAPI.csproj", "ProductStoreAPI/"]
RUN dotnet restore "ProductStoreAPI/ProductStoreAPI.csproj"
COPY . .
WORKDIR "/src/ProductStoreAPI"
RUN dotnet build "ProductStoreAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProductStoreAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProductStoreAPI.dll"]
