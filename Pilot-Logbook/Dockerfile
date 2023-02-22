# Use the official Microsoft .NET SDK as a parent image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Set the working directory to /app
WORKDIR /app

# Copy the .csproj file and restore dependencies
COPY Pilot-Logbook.csproj .
RUN dotnet restore

# Copy the remaining source code files
COPY . .

# Build the app
RUN dotnet publish -c Release -o out

# Use the official Microsoft .NET runtime as a parent image
FROM mcr.microsoft.com/dotnet/runtime:7.0
WORKDIR /app
COPY --from=build /app/out .

# Expose port 80 for HTTP traffic
EXPOSE 80

# Start the .NET app using the Pilot-Logbook.dll file
ENTRYPOINT ["dotnet", "Pilot-Logbook.dll"]
