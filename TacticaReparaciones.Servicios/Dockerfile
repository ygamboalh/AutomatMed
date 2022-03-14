FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR app
COPY ./out .

ENV TZ=America/Tegucigalpa
EXPOSE 80

ENV ASPNETCORE_ENVIRONMENT Development

ENV FS_HOST 10.10.4.14
ENV FS_PORT 3306
ENV FS_USUARIO laboratorio
ENV FS_PASSWORD laboratorio
ENV FS_TACTICA_REPARACIONES_DB tactica_reparaciones_bd
ENV FS_TACTICA_DB basedemo

CMD ["dotnet", "/app/TacticaReparaciones.Servicios.dll"]