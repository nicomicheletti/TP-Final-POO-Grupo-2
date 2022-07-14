# Trabajo Final - Programación Orientada a Objetos - Grupo 2

### Introducción
En Programación Orientada a Objetos en la carrera Ingenieria en Sistemas de la Universidad Abierta Interamericana, el profesor nos asignó un trabajo en el cual trabajando con C#, .NET y SQL Server debíamos crear un módulo de seguridad.
<br>
El mismo, consiste en la creación de diversos formularios y usuarios que van a interactuar con el sistema. A continuación desarrollaremos detalladamente el mismo.
<br>

### El proyecto

#### Descripción del sistema
<br>
El sistema cuenta con 2 tipos de perfiles. En primer lugar el o los administradores, estos tienen la posbilidad de acceder a todas las facetas del formulario. Por un lado puede agregar nuevos usuarios (admins o clientes) como también gestionar los mismos (listarlos, modificarlos o eliminarlos). El otro perfil, denominado cliente, solo tiene la posibilidad de crear nuevos perfiles pero sólo del tipo "cliente". Cada usuario, esta alojado en una base de datos y poseen sus datos personales como así también una contraseña, ésta se encuentra encriptada para brindar mayor seguridad a los usuarios.
<br>
El mismo está dividido en VISTA, CONTROLADORA y MODELO.
<br>
<br>
En la VISTA lo que hacemos es observar las diversas pantallas que componen el proyecto. Log In, visión del admin, del cliente, etc.
<br>
<br>
En la CONTROLADORA es donde se desarrolla toda la lógica de los formularios.
<br>
<br>
Y en el MODELO, por medio de un singleton hacemos la conexión con la base de datos.
<br>
<br>
#####Modelos: 
<br>
#####Patrones utilizados:
<br>
El sistema se desarrolla bajo “Modelo-Vista-Controladora”, este es un patrón en el diseño de software utilizado para implementar interfaces de usuario, datos y lógica de control. 
También se usa el patrón de diseño Singleton, permitiendo que una clase tenga una sola instancia.
<br>
<br>
#####Formularios:
<br>
<ol>El sistema posee:
 <li>Un login en el cual se debe ingresar usuario y contraseña para acceder.</li>
<li>Un menú principal, en donde se puede agregar o gestionar usuarios.</li> 
<li>Un registro el cual cuenta con un botón para agregar al usuario o cancelar y regresar al menú principal. En este formulario se deben ingresar los siguientes datos: Nombre, Email, Contraseña, DNI, y se debe seleccionar si el perfil (si es cliente o admin).</li>
<li>Gestionar usuario, en donde se podrá ver la lista de los usuarios registrados, y se podrá modificar y eliminar a los mismos.</li>
 </ol>
<br>
<br>
El sistema cuenta con 2 tipos de perfiles. En primer lugar el o los administradores, estos tienen la posbilidad de acceder a todas las facetas del formulario. Por un lado puede agregar nuevos usuarios (admins o clientes) como también gestionar los mismos (listarlos, modificarlos o eliminarlos). El otro perfil, denominado cliente, solo tiene la posibilidad de crear nuevos perfiles pero sólo del tipo "cliente".
<br>
El mismo está dividido en VISTA, CONTROLADORA y MODELO.
<br>
En la VISTA lo que hacemos es observar las diversas pantallas que componen el proyecto. Log In, visión del admin, del cliente, etc.
<br>
En la CONTROLADORA es donde se desarrolla toda la lógica de los formularios.
<br>
Y en el MODELO, por medio de un singleton hacemos la conexión con la base de datos.

<br>

### Miembros

 Nombre  | Mail | Github | Rol
| :-----: | :-----: | :-----: | :-----: |
| Lautaro Cabral | lautacabral96@gmail.com | [@lautarocabral](https://github.com/lautarocabral) | DEV
| Mauricio Dottore | mauriciodottore@gmail.com | [@mauridottore](https://github.com/mauridottore) | DEV
| Nicolás Micheletti | nicolasamicheletti@gmail.com | [@nicomicheletti](https://github.com/nicomicheletti) | DEV
| Germán Tagliarini | germanarielt@gmail.com | [@](https://github.com/) | DEV
