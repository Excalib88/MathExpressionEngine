FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TestCalculator/TestCalculator.csproj", "TestCalculator/"]
RUN dotnet restore "TestCalculator/TestCalculator.csproj"
COPY . .
WORKDIR "/src/TestCalculator"
RUN dotnet build "TestCalculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestCalculator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestCalculator.dll"]
