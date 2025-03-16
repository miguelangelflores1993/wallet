## Qué Incluye Este Repositorio

#### Comunicación entre Microservicios
* Comunicación asincrónica entre microservicios con **RabbitMQ como servicio de intermediario de mensajes**
* Uso de **MassTransit** para abstracción sobre el sistema de intermediario de mensajes RabbitMQ

#### Microservicio de Wallet
* Implementación de **DDD, CQRS y Arquitectura Limpia** utilizando las mejores prácticas
* Desarrollo de **CQRS con los paquetes MediatR, FluentValidation y Mapster**
* Conexión a base de datos **SqlServer** y contenedorización
* Uso de **Entity Framework Core ORM** y migración automática a SqlServer al iniciar la aplicación
	
#### Microservicio API Gateway con Yarp
* Desarrollo de API Gateways con **Yarp Reverse Proxy** aplicando el patrón de enrutamiento de Gateway
* Configuración de Yarp Reverse Proxy; Ruta, Clúster, Ruta de acceso, Transformación, Destinos
* **Limitación de tasa** con FixedWindowLimiter en la configuración de Yarp Reverse Proxy

#### Establecimiento de Docker Compose con todos los microservicios en Docker:
* Contenerización de microservicios
* Contenerización de bases de datos
* Sobrescritura de variables de entorno

## Ejecutar el Proyecto
Necesitarás las siguientes herramientas:

* [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
* [.Net Core 8 o posterior](https://dotnet.microsoft.com/download/dotnet-core/8)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Instalación
1. Clona el repositorio
2. En el directorio raíz de la solución, selecciona **docker-compose** y **Establecer un proyecto de inicio**. **Ejecuta docker-compose sin depuración en Visual Studio**.
   O puedes ir al directorio raíz que contiene el archivo **docker-compose.yml**, y ejecutar el siguiente comando:
```csharp
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```