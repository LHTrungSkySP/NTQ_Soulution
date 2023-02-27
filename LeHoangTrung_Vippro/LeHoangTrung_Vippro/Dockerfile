#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LeHoangTrung_Vippro/LeHoangTrung_Vippro.csproj", "LeHoangTrung_Vippro/"]
RUN dotnet restore "LeHoangTrung_Vippro/LeHoangTrung_Vippro.csproj"
COPY . .
WORKDIR "/src/LeHoangTrung_Vippro"
RUN dotnet build "LeHoangTrung_Vippro.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeHoangTrung_Vippro.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeHoangTrung_Vippro.dll"]