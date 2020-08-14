FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app


COPY ../Core ./Core/
COPY BackGroudService ./BackGroudService/
RUN cd BackGroudService && dotnet build

WORKDIR /app/BackGroudService
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/BackGroudService/out .
# ENTRYPOINT ["dotnet", "BackGroudService.dll"]
# heroku uses the following
CMD ASPNETCORE_URLS=http://*:$PORT dotnet BackGroudService.dll