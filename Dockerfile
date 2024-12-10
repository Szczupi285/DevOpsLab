# File: Dockerfile

# Use the .NET SDK to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["src/WebApi/WebApi.csproj", "./WebApi/"]
WORKDIR /src/WebApi
RUN dotnet restore

# Copy the entire source code and publish the application
COPY ["src/WebApi/", "./"]
RUN dotnet publish -c Release -o /app/publish

# Use the ASP.NET Core runtime to run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Expose the ports used by the Web API
EXPOSE 80
EXPOSE 443

# Entry point to run the application
ENTRYPOINT ["dotnet", "WebApi.dll"]

