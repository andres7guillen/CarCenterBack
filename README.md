# CarCenterBack
Es una aplicacion para administrar un Car Center consiste de varios proyectos:
API Rest(.net core 2.2)
Capa de acceso a datos(.net core 2.2 y entity framework core)
Fue hecha con visual studio 2019 community y net core 2.2

Para ejecutar el proyecto debe tener visual studio 2017 o 2019 con el sdk de .net core 2.2 instalado.
Se debe modificar el connection string con la key "CarCenter", depues de tener la nueva conexion de debe ejecutar el comando
update-database -migration ApiSefuridad_Y_Modelado_BaseDeDatos en la consola de paquetes apuntando al proyecto de CarCnterData y ya eso seria suficiante para correr el proyecto.

NO USO PROCEDIMIENTOS ALMACENADOS ESTA LOGICA DE LOS PUNTOS DE FACTURACION ESTA EN SERVICIOS HECHOS USANDO EL CONTEXTO, ENTITY FRAMEWORK CORE Y CODIGO C#
