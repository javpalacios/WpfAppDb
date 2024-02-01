# Descripción General

* Construye una imagen Docker basada en mcr.microsoft.com/mssql/server.
* Configura el archivo `setup.sql` con el T-SQL que deseas ejecutar después de que SQL Server se haya iniciado.
Basado en el repositorio `git clone https://github.com/microsoft/mssql-docker.git`.

## Modifica el archivo setup.sql

Modifica el archivo `mssql-docker/linux/preview/examples/mssql-customize/setup.sql` con el T-SQL que deseas personalizar para el contenedor de SQL Server.

## Construye la imagen
Construye con `docker build`:
```bash
docker build -t mssql-custom .
```

## Ejecuta el contenedor

Luego, inicia un nuevo contenedor usando `docker run`:
```bash
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=StrongPassw0rd' -p 1433:1433 --name sqls_prueba -d mssql-custom
```

Nota: Las contraseñas de MSSQL deben tener al menos 8 caracteres de longitud y contener letras mayúsculas, minúsculas y dígitos.