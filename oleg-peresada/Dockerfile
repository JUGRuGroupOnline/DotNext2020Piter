FROM mcr.microsoft.com/dotnet/core/sdk:5.0-alpine AS build

WORKDIR /app

COPY /service1 ./

RUN dotnet restore

COPY /service1 ./
WORKDIR /app

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:5.0-alpine AS runtime

WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "service1.dll"]