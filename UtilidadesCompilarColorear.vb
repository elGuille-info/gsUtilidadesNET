'------------------------------------------------------------------------------
' gsUtilidadesCompilarColorear                                      (27/Nov/20)
' Biblioteca de clases para .NET 5.0 (en realidad es una aplicaci�n de Windows Forms)
'
'v1.0.0.0   27/Nov/20   Primera versi�n ;-)
'v1.0.0.2               comprobaciones de error al obtener el directorio de dotnet
'v1.0.0.3               Se comprueba si est� la carpeta de dotnet, se avisa mediante el evento Compilar.TieneDotnetEvent
'v1.0.0.4               Versi�n espec�fica para plataformas de x86
'v1.0.0.5               Versi�n espec�fica para AnyCPU sin preferencia de 32 bits
'                       Usar la misma versi�n para x86 y AnyCPU
'v1.0.0.6               Quito el evento compartido de Compilar en el programa cliente comprobar el valor de TieneDotnet.
'                       Las versiones x86 y AnyCPU tendr�n la misma versi�n
'
' (c) Guillermo (elGuille) Som, 2020
'------------------------------------------------------------------------------
Option Strict On
Option Infer On

Imports System
Imports System.Data
Imports System.Collections.Generic
Imports System.Text
Imports System.Linq
Imports Microsoft.VisualBasic
'Imports vb = Microsoft.VisualBasic

''' <summary>
''' Clase con definici�n de la versi�n y las clases expuestas.
''' </summary>
Public Class UtilidadesCompilarColorear

    <STAThread>
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FormInfo())
    End Sub


    ''' <summary>
    ''' Devuelve la versi�n de esta biblioteca de clases.
    ''' </summary>
    ''' <returns>Una cadena con la informaci�n de la biblioteca</returns>
    Public Shared Function Version() As String
        ' A�adir la versi�n de esta utilidad                        (15/Sep/20)
        Dim ensamblado As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly
        Dim fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(ensamblado.Location)

        Dim versionAttr = ensamblado.GetCustomAttributes(GetType(System.Reflection.AssemblyVersionAttribute), False)
        Dim vers = If(versionAttr.Length > 0,
                                (TryCast(versionAttr(0), System.Reflection.AssemblyVersionAttribute)).Version,
                                "1.0.0.0")
        Dim prodAttr = ensamblado.GetCustomAttributes(GetType(System.Reflection.AssemblyProductAttribute), False)
        Dim producto = If(prodAttr.Length > 0,
                                (TryCast(prodAttr(0), System.Reflection.AssemblyProductAttribute)).Product,
                                "gsUtilidadesCompilarColorear")
        Dim descAttr = ensamblado.GetCustomAttributes(GetType(System.Reflection.AssemblyDescriptionAttribute), False)
        Dim desc = If(descAttr.Length > 0,
                                (TryCast(descAttr(0), System.Reflection.AssemblyDescriptionAttribute)).Description,
                                "(para .NET 5.0 revisi�n del 27/Nov/2020)")

        Dim k = desc.IndexOf("(para .NET")
        Dim desc1 = desc.Substring(k)
        Dim descL = desc.Substring(0, k - 1).TrimEnd
        Dim otrosCopyR = "Parte del c�digo para colorear est� basado en ColorSelector usada en CSharpToVB de Paul1956."
        otrosCopyR &= $"{vbCrLf}Algunas funciones y c�digo est�n adaptados de ejemplos encontrados en Internet, principalmente en C#."

        'MessageBox.Show($"{producto} v{vers} ({fvi.FileVersion})" & vbCrLf & vbCrLf &
        '                $"{descL}" & vbCrLf &
        '                $"{desc1}",
        '                $"Acerca de {producto}",
        '                MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim ret = $"{producto} v{vers} ({fvi.FileVersion}){vbCrLf}{vbCrLf}{descL}{vbCrLf}{vbCrLf}{desc1}" &
                  If(Compilar.TieneDotnet, "", $"{vbCrLf}{vbCrLf}{Compilar.TieneDotNetMsg}") &
                  $"{vbCrLf}{vbCrLf}" &
                  $"Reconocimientos:{vbCrLf}{otrosCopyR}"

        Return ret
    End Function

    ''' <summary>
    ''' Devuelve un <see cref="HashSet(Of String)"/> con los nombres de las clases y formularios
    ''' contenidos en esta biblioteca.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function ClasesExpuestas() As HashSet(Of String)
        ' Usar reflection para mostrar las clases definidas
        Dim col = New HashSet(Of String) From {
            "CompararString - Clase para hacer las comparaciones de cadenas que implementa IComparer(Of String) y IEqualityComparer(Of String).",
            "Compilar - Clase para evaluar, compilar y colorear c�digo de VB y C#.",
            "Config - Clase para manejar ficheros de configuraci�n.",
            "DiagClassifSpanInfo.ClassifSpanInfo - Clase para manejar informaci�n del tipo ClassifiedSpan.",
            "DiagClassifSpanInfo.DiagInfo - Clase para manejar informaci�n del tipo Diagnostic.",
            "Extensiones - M�dulo con extensiones para varias clases y tipos de datos.",
            "FormInfo - Formulario para mostrar la informaci�n de esta utilidad y las clases que la componen.",
            "FormVisorHTML - Formulario visor de p�ginas HTML.",
            "FormRecortes - Formulario para mostrar recortes (texto) y pegarlos.",
            "FormProcesando - Formulario para mostrar un di�logo cuando se est� procesando (acciones largas).",
            "Marcadores - Clase para manejar marcadores (Bookmarks).",
            "UtilEnum - Clase con la definici�n de la enumeraci�n FormatosEncoding y utilidades para manejar enumeraciones.",
            "UtilidadesCompilarColorear - Clase con definici�n de la versi�n y las clases expuestas."
        }

        Return col
    End Function

End Class
