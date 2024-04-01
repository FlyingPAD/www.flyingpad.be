# Step 1 : Build APP

FROM mcr.microsoft.com/dotnet/sdk:latest AS build
WORKDIR /src

# Step 2 : Copy *.csproj Files

COPY ["MB.API/MB.API.csproj", "MB.API/"]
COPY ["MB.Application/MB.Application.csproj", "MB.Application/"]
COPY ["MB.Domain/MB.Domain.csproj", "MB.Domain/"]
COPY ["MB.Infrastructure/MB.Infrastructure.csproj", "MB.Infrastructure/"]
COPY ["MB.Persistence/MB.Persistence.csproj", "MB.Persistence/"]
COPY ["MB.API.Test/MB.API.Test.csproj", "MB.API.Test/"]
COPY ["MB.Application.Test/MB.Application.Test.csproj", "MB.Application.Test/"]
COPY ["MB.Domain.Test/MB.Domain.Test.csproj", "MB.Domain.Test/"]
COPY ["MB.Infrastructure.Test/MB.Infrastructure.Test.csproj", "MB.Infrastructure.Test/"]
COPY ["MB.Persistence.Test/MB.Persistence.Test.csproj", "MB.Persistence.Test/"]

# Step 3 : Restore Dependencies

RUN dotnet restore "MB.API/MB.API.csproj"

# Step 4 : Copy All Files

COPY . .

# Step 5 : Build

FROM build AS publish
RUN dotnet build "MB.API/MB.API.csproj" -c Release -o /app/build

# Step 6 : Publish

RUN dotnet publish "MB.API/MB.API.csproj" -c Release -o /app/publish

# Step 7 : 

FROM mcr.microsoft.com/dotnet/aspnet:latest
WORKDIR /src

# Step 8 : Copy Published Files

COPY --from=publish /app/publish .

# Step 9 : Expose Ports

EXPOSE 7211 443 5019 80

# Step 10 : Copy Certificate

COPY ["flyingpad.back.pfx", "/https/"]

# Step 11 : Configure Env. for using HTTPS

ENV ASPNETCORE_URLS="https://+;http://+"
ENV ASPNETCORE_HTTPS_PORT=7211
ENV ASPNETCORE_Kestrel__Certificates__Default__Password="fp12345"
ENV ASPNETCORE_Kestrel__Certificates__Default__Path="/https/flyingpad.back.pfx"

# Etape 12 : Entry Point with Config for HTTPS

CMD ["dotnet", "MB.API.dll", "--urls", "https://+;http://+", "--environment", "Development"]