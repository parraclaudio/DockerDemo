# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY /app/publish ./
ENTRYPOINT ["dotnet", "DockerDemo.Api.dll"]	