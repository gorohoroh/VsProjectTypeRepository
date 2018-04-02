FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY VsProjectTypeRepository.sln ./
COPY ASP.NET_Core_2.0_Web_Application_Web_MVC_with_Docker/ASP.NET_Core_2.0_Web_Application_Web_MVC_with_Docker.csproj ASP.NET_Core_2.0_Web_Application_Web_MVC_with_Docker/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/ASP.NET_Core_2.0_Web_Application_Web_MVC_with_Docker
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ASP.NET_Core_2.0_Web_Application_Web_MVC_with_Docker.dll"]
