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
'v1.0.0.7   30/Nov/20   A�ado la extensi�n ToUpperFirstChar
'v1.0.0.8   01-dic-20   A�ado el proyecto Mostrar contenido ensamblado (x86 y x64)
'v1.0.0.9               NuGet dice que la referencia (en la versi�n x64) es el paquete de x86
'v1.0.0.10  02-dic-20   A�ado una clase como la de InfoEnsamblado para acceder a ese ensamblado
'v1.0.0.11              A�ado la funci�n FormatoFichero para averiguar el Encoding
'
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
            "InfoEnsambladoWrap - Esta clase accede a los m�todos y propiedades compartidas de InfoEnsamblado de Mostrar contenido ensamblado.",
            "Marcadores - Clase para manejar marcadores (Bookmarks).",
            "UtilEnum - Clase con la definici�n de la enumeraci�n FormatosEncoding y utilidades para manejar enumeraciones.",
            "UtilidadesCompilarColorear - Clase con definici�n de la versi�n, las clases expuestas Y FormatoFichero."
        }

        Return col
    End Function

    '''<summary>
    ''' Averigua el formato del fichero indicado
    ''' S�lo se comprueban los formatos Unicode, UTF-8 y UTF-7 (manualmente)
    ''' si el formato no se puede averiguar, se devolver� ANSI (predeterminado de Windows)
    '''</summary>
    '''<remarks>
    ''' Originalmente en Utilidades (clases de VS2005) 21/Dic/03 y 16/Nov/05
    ''' NOTA
    ''' Con .NET (Core) es recomendable usar Latin1, ya que Default en realidad devuelve UT8
    ''' (lo comprobar� con .NET Framework 4.8, pero creo que ah� el Default va bien)
    ''' Por tanto, el valor predeterminado lo cambio a Latin1.
    ''' </remarks>
    Public Shared Function FormatoFichero(fichero As String) As System.Text.Encoding
        ' por defecto devolver ANSI
        ' Los ficheros Unicode tienen estos dos bytes: FF FE (normal o little-endian) o FE FF (big-endian)
        ' Los ficheros UTF-8 tienen estos tres bytes: EF BB BF
        Dim f As System.Text.Encoding
        Dim fs As System.IO.FileStream = Nothing
        ' Con .NET (Core) parece que Default no va igual que con .NET Framework
        f = System.Text.Encoding.Latin1 ' .Default
        Try
            ' Abrir el fichero y averiguar el formato
            fs = New System.IO.FileStream(fichero, System.IO.FileMode.Open)
            Dim c1 As Integer = fs.ReadByte
            Dim c2 As Integer = fs.ReadByte
            Dim c3 As Integer = fs.ReadByte
            '
            If (c1 = &HFF AndAlso c2 = &HFE) OrElse (c1 = &HFE AndAlso c2 = &HFF) Then
                f = System.Text.Encoding.Unicode
            ElseIf c1 = &HEF AndAlso c2 = &HBB AndAlso c3 = &HBF Then
                f = System.Text.Encoding.UTF8

                ' El formato UTF-7 est� obsoleto,                   (02/Dic/20)
                ' as� que no se comprueba, pero dejo el c�digo
                'Else
                '    ' comprobaci�n del formato UTF-7                    (05/May/04)
                '    ' En el formato UTF-7 si tiene caracteres no ASCII contendr�: 2B 41 (+A)
                '    '
                '    ' cerramos el fichero anterior, para poder abrirlo de nuevo
                '    fs.Close()
                '    Dim sr As New System.IO.StreamReader(fichero) ', System.Text.Encoding.Default)
                '    Dim s As String
                '    ' El problema ser� cuando el fichero sea demasiado grande
                '    ' Nos arriesgamos a leer s�lo una cantidad de caracteres, por ejemplo 100KB,
                '    ' ser�a mala suerte que en los primeros 100KB no hubiese caracteres "especiales"
                '    Const count As Integer = (100 * 1024)
                '    If sr.BaseStream.Length > count Then
                '        Dim charBuffer(count - 1) As Char
                '        sr.ReadBlock(charBuffer, 0, count)
                '        s = charBuffer
                '    Else
                '        s = sr.ReadToEnd()
                '    End If
                '    If s.IndexOf("+A") > -1 Then
                '        f = System.Text.Encoding.UTF7
                '    End If
                '    sr.Close()
            End If
        Catch ex As Exception
            ' si se produce alg�n error, asumimos que es ANSI
            f = System.Text.Encoding.Default
        Finally
            ' Comprobar si es nulo, si no, dar� error
            If Not fs Is Nothing Then
                fs.Close()
            End If
        End Try

        Return f
    End Function

End Class
