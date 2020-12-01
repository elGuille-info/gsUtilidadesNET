# gsUtilidadesNET
Utilidades para colorear, evaluar y compilar con dotnet Evaluar si tiene fallos, Compilar, Ejecutar y Colorear el código y para HTML  (para .NET 5.0 revisión del 01-dic-2020)

Eata "biblioteca" es una aplicación para WindowsForms que expone varias clases.
CompararString - Clase para hacer las comparaciones de cadenas que implementa IComparer(Of String) y IEqualityComparer(Of String).
Compilar - Clase para evaluar, compilar y colorear código de VB y C#.
Config - Clase para manejar ficheros de configuración.
DiagClassifSpanInfo.ClassifSpanInfo - Clase para manejar información del tipo ClassifiedSpan.
DiagClassifSpanInfo.DiagInfo - Clase para manejar información del tipo Diagnostic.
Extensiones - Módulo con extensiones para varias clases y tipos de datos.
FormInfo - Formulario para mostrar la información de esta utilidad y las clases que la componen.
FormVisorHTML - Formulario visor de páginas HTML.
FormRecortes - Formulario para mostrar recortes (texto) y pegarlos.
FormProcesando - Formulario para mostrar un diálogo cuando se está procesando (acciones largas).
Marcadores - Clase para manejar marcadores (Bookmarks).
UtilEnum - Clase con la definición de la enumeración FormatosEncoding y utilidades para manejar enumeraciones.
UtilidadesCompilarColorear - Clase con definición de la versión y las clases expuestas.


En el código fuente verás dos ficheros de proyectos, uno lo utilizo para compilar a 32 bits (x86) y el otro para compilar a 64 bits (x64).
Esto es porque esta biblioteca la utilizo en gsEvaluarColorearCodigoNET y tengo dos versiones diferentes también.

## Nota sobre la versión de 32 bits (x86)
La de 32 bits la he probado en una máquina virtual con Windows 7 Enterpise SP1 (32 bits) y funciona bien, salvo que al compilar da error.
Es porque falta una actualización de Microsoft (windows6.1-kb2533623), pero que no se puede descargar porque Microsoft lo retiró.
Buscando con Bing me encontré con el aviso de que se podía descargar la actualización de kb4457144.



