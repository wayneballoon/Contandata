FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5003
EXPOSE 44311

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY SoldTo/SoldTo.csproj SoldTo/
RUN dotnet restore SoldTo/SoldTo.csproj
COPY . .
WORKDIR /src/SoldTo
RUN dotnet build SoldTo.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish SoldTo.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SoldTo.dll"]
