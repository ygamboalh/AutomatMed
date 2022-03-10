FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR app
COPY ./out .

ENV TZ=America/Tegucigalpa
EXPOSE 80

ENV ASPNETCORE_ENVIRONMENT Development

CMD ["dotnet", "/app/TacticaReparaciones.Servicios.dll"]