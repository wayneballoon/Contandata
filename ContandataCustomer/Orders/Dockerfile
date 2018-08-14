FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5006
EXPOSE 44374

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Orders/Orders.csproj Orders/
RUN dotnet restore Orders/Orders.csproj
COPY . .
WORKDIR /src/Orders
RUN dotnet build Orders.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Orders.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Orders.dll"]
