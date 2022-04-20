FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY *.sln .
COPY CancStore/*.csproj ./CancStore/
RUN dotnet restore

COPY CancStore/. ./CancStore/
WORKDIR /src/CancStore
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT [ "dotnet", "CancStore.dll" ]