FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5005
EXPOSE 44305

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Carrier/Carrier.csproj Carrier/
RUN dotnet restore Carrier/Carrier.csproj
COPY . .
WORKDIR /src/Carrier
RUN dotnet build Carrier.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Carrier.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Carrier.dll"]
