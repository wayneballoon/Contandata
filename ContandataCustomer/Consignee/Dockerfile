FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5004
EXPOSE 44377

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Consignee/Consignee.csproj Consignee/
RUN dotnet restore Consignee/Consignee.csproj
COPY . .
WORKDIR /src/Consignee
RUN dotnet build Consignee.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Consignee.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Consignee.dll"]
