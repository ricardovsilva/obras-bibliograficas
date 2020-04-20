FROM mcr.microsoft.com/dotnet/core/sdk:3.1

COPY ./src /app
WORKDIR /app
RUN dotnet restore
RUN dotnet test

EXPOSE 5000

ENTRYPOINT ["dotnet", "run", "--project", "app"]

