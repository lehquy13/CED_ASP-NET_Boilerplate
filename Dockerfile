FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/CED.Web.Host/CED.Web.Host.csproj", "src/CED.Web.Host/"]
COPY ["src/CED.Web.Core/CED.Web.Core.csproj", "src/CED.Web.Core/"]
COPY ["src/CED.Application/CED.Application.csproj", "src/CED.Application/"]
COPY ["src/CED.Core/CED.Core.csproj", "src/CED.Core/"]
COPY ["src/CED.EntityFrameworkCore/CED.EntityFrameworkCore.csproj", "src/CED.EntityFrameworkCore/"]
WORKDIR "/src/src/CED.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/CED.Web.Host", "src/CED.Web.Host"]
COPY ["src/CED.Web.Core", "src/CED.Web.Core"]
COPY ["src/CED.Application", "src/CED.Application"]
COPY ["src/CED.Core", "src/CED.Core"]
COPY ["src/CED.EntityFrameworkCore", "src/CED.EntityFrameworkCore"]
WORKDIR "/src/src/CED.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "CED.Web.Host.dll"]
