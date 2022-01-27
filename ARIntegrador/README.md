# ARIntegrador

Es una aplicación de realidad aumentada complementaria de la aplicación EcoApp. 

 - [Requisitos](#requisitos )
 - [Instalación](#instalación )
 - [Base de Datos](#base-de-datos)
 
## Requisitos
 
La aplicación fue creada en una computadora con sistema operativo Windows, lo que se debe tener instalado es lo siguiente:

1.	Unity
2.	Android Studio  o emulador físico 

## Instalación

Se debe instalar todos los paquetes con el siguiente comando: 

`npm install -g `

Se debe instalar *`Vuforia`*, debido a que en las versiones modernas de Unity ya no viene incluido el SDK, para lo cual se debe seguir los siguientes pasos:

1.	Ir a la página de  *Vuforia* y crearse una cuenta.
2.	Crear un nuevo proyecto en  *Vuforia*.
3.	Copiar la llave del proyecto e incluirla en Unity. 

Para ejecutar la aplicación es necesario incluir la llave generada por el proyecto, la llave se encuentra en el repositorio con el nombre (user.keystore).
La credencial para la ejecución es (FreddyDaniel), esta misma debe ser ingresada para la publicación en la Google Play Store, si no es así no se permitirá ninguna modificación, ejecución o publicación de posibles actualizaciones. 

## Base de datos

La base de datos utilizada es la proporcionada por *Vuforia*, en donde se encuentran almacenadas todas las images target del proyecto.
