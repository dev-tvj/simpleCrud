FROM mcr.microsoft.com/mssql/server:latest
ENV ACCEPT_EULA=Y \
    SA_PASSWORD=SenhaSuperPoderosa123
EXPOSE 1433
USER root
RUN apt-get update && apt-get install -y mssql-tools
COPY dbCreateScript.sql /tmp/scripts/
RUN /opt/mssql/bin/sqlservr & sleep 10 && opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P SenhaSuperPoderosa123 -i /tmp/scripts/dbCreateScript.sql
