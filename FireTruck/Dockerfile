FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /app
# Copy everything and build
COPY . ./
RUN dotnet restore "./FireTruck.csproj"
RUN dotnet publish "FireTruck.csproj" -c Release -o out
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
copy --from=build-env /app/out .
ENTRYPOINT ["dotnet", "FireTruck.dll"]