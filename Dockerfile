# Base Image from Docker Hub
FROM microsoft/aspnetcore:2.0

MAINTAINER Jeremy Morgan version: 0.1

# Our working directory
WORKDIR /app
# Copy over our artifacts and certificate
COPY ./artifacts .
# Open our Port
EXPOSE 5001
# Run the application
ENTRYPOINT ["dotnet", "friendlyphonenumber.dll"]