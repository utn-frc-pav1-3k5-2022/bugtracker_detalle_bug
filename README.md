


# BugTracker - Actividad Detalle Bug


## 1. Clonar Repositorio (Clone/Checkout)

**1.1. Ejecutar comando clone para descargar repositorio:** 
```sh
$ git clone https://github.com/utn-frc-pav1-3k5-2022/bugtracker_detalle_bug
```
**1.2. Ubicarse en la carpeta generada con el nombre del repositorio: 

```sh
$ cd bugtracker_detalle_bug
```

**1.3. Crear un nuevo branch (rama)**

Para crear una nueva rama (branch) y saltar a ella, en un solo paso, puedes utilizar el comando  `git checkout`  con la opción  `-b`, indicando el nombre del nuevo branch (reemplazando el nro de legajo) de la siguiente forma branch_{legajo}, para el legajo 12345:

```sh
$ git checkout -b branch_12345 
Switched to a new branch "12345"
```
Y para que se vea reflejada en GitHub:
```sh
$ git push --set-upstream origin branch_12345
```

## 2. Ejecutar Script Base de datos (Solo si es necesario)
**2.1. Iniciar la aplicación `Sql Server Management Studio`**

Solicitará ingresar los datos de la base de datos para generar una conexión, completar los datos y hacer click en **Connect**. Los datos del servidor del labsis son:

 - **Tipo Servidor:** Database Engine
 - **Nombre Servidor:** .\SQLEXPRESS
 - **Autenticación:** Windows Authentication.
 
 
 **2.2. Abrir archivo `BugTracker_Crear_BaseDatos.sql`**
 Ir a la opción `Archivo -> Abrir -> Archivo` (o combinación de teclas `Ctrl + O`) y buscar el archivo BugTracker_Crear_BaseDatos.sql en el disco local.
  

**2.5. Ejecutar Script** 
Para ejecutar el script hacer click sobre el botón `Ejecutar` (o usar la tecla `F5`)


## 3. Actividad: Detalle Bug

3.1 Consulta Bug con JOIN

```sql
SELECT bug.id_bug, 
       bug.titulo,
       bug.descripcion,
       bug.fecha_alta,
       bug.id_usuario_responsable,
       responsable.usuario as responsable,  
       bug.id_usuario_asignado,
       asignado.usuario as asignado,
       bug.id_producto,
       producto.nombre as producto, 
       bug.id_prioridad,
       prioridad.nombre as prioridad,
       bug.id_criticidad,
       criticidad.nombre as criticidad, 
       bug.id_estado,
       estado.nombre as estado
   FROM Bugs as bug
   LEFT JOIN Usuarios as responsable ON responsable.id_usuario = bug.id_usuario_responsable
   LEFT JOIN Usuarios as asignado ON asignado.id_usuario = bug.id_usuario_asignado
  INNER JOIN Productos as producto ON producto.id_producto = bug.id_producto
  INNER JOIN Prioridades as prioridad ON  prioridad.id_prioridad = bug.id_prioridad
  INNER JOIN Criticidades as criticidad ON criticidad.id_criticidad = bug.id_criticidad
  INNER JOIN Estados as estado ON estado.id_estado = bug.id_estado
 WHERE id_bug = 3
```

## 4. Versionar los cambios locales (add / commit / push)

> A continuación vamos a crear el **commit** y subir los cambios al servidor GitHub.

1. **Status**. Verificamos los cambios pendientes de versionar.

```sh
$ git status
```

2. **Add** Agregamos todos los archivos nuevos no versionados.

```sh
$ git add -A
```

3. **Commit** Generamos un commit con todos los cambios y agregamos un comentario.

```sh
$ git commit -a -m "Comentario"
```

4. **Push** Enviamos todos los commits locales a GitHub

```sh
$ git push
```

5. **Status** Verificar que no quedaron cambios pendientes de versionar

```sh
$ git status
```

