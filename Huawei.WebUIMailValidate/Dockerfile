#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
RUN apt-get update -y
RUN apt-get install -y tzdata
ENV TZ=Europe/Istanbul
WORKDIR /app


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Huawei.WebUIMailValidate/Huawei.WebUIMailValidate.csproj", "Huawei.WebUIMailValidate/"]
RUN dotnet restore "Huawei.WebUIMailValidate/Huawei.WebUIMailValidate.csproj"
COPY . .
WORKDIR "/src/Huawei.WebUIMailValidate"
RUN dotnet build "Huawei.WebUIMailValidate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Huawei.WebUIMailValidate.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 8090
ENV ASPNETCORE_URLS=http://+:8090
ENTRYPOINT ["dotnet", "Huawei.WebUIMailValidate.dll"]