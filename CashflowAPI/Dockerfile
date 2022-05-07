FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
RUN dotnet build -c Release
# Build and publish a release
RUN dotnet publish -c Release -o out

# Production server container
FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine

ENV ASPNETCORE_ENVIRONMENT Production
ENV ASPNETCORE_URLS http://+:80
EXPOSE 80

WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "CashflowAPI.dll"]