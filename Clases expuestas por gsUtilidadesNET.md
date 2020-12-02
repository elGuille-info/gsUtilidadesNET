# Contenido del ensamblado 'gsUtilidadesNET.dll'

Informaci�n de los tipos definidos en el ensamblado.


>**NOTA:**
>Esta informaci�n la he conseguido usando la utilidad [Mostrar contenido ensamblado](https://github.com/elGuille-info/Mostrar-contenido-ensamblado)


## Clase: VB$AnonymousDelegate_0`2
    IsGenericType = True
    Constructores:
        IsPublic = True
            Par�metros: Object TargetObject, IntPtr TargetMethod
    VB$AnonymousDelegate_0`2.M�todos:
        IAsyncResult  BeginInvoke
            Par�metros: TArg0 c, AsyncCallback DelegateCallback, Object DelegateAsyncState
        TResult  EndInvoke
            Par�metros: IAsyncResult DelegateAsyncResult
        TResult  Invoke
            Par�metros: TArg0 c
        Void  GetObjectData
            Par�metros: SerializationInfo info, StreamingContext context
        Boolean  Equals
            Par�metros: Object obj
        Delegate[]  GetInvocationList
        Int32  GetHashCode
        Object  Clone
        Object  DynamicInvoke
            Par�metros: Object[] args
        Type  GetType
        String  ToString
    VB$AnonymousDelegate_0`2.Interfaces:
        ICloneable
            Clone
        ISerializable
            GetObjectData

## Clase: MyApplication
    Constructores:
        IsPublic = True
            Sin par�metros
    MyApplication.M�todos:
        Type  GetType
        String  ToString
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Clase: CompararString
    Constructores:
        IsPublic = True
            Sin par�metros
    CompararString.M�todos:
        Int32  Compare
            Par�metros: String x, String y
        Boolean  Equals
            Par�metros: String x, String y
        Int32  GetHashCode
            Par�metros: String obj
        Type  GetType
        String  ToString
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode
    CompararString.Interfaces:
        IComparer`1
            Compare
        IEqualityComparer`1
            Equals
            GetHashCode

## Clase: Compilar
    Constructores:
        IsPublic = True
            Sin par�metros
    Compilar.M�todos:
        Drawing.Color  GetColorFromName
            Par�metros: String classificationTypeName
        String  GetStringColorFromName
            Par�metros: String classificationTypeName
        Void  WriteColorDictionaryToFile
        Void  WriteColorDictionaryToFile
            Par�metros: String ficPath
        Void  UpdateColorDictionaryFromFile
        Void  UpdateColorDictionaryFromFile
            Par�metros: String ficPath
        Microsoft.CodeAnalysis.Emit.EmitResult  ComprobarCodigo
            Par�metros: String sourceCode, String lenguaje
        ValueTuple`2[Microsoft.CodeAnalysis.Emit.EmitResult,String]  CompileRun
            Par�metros: String file, [Optional] Boolean run = True
        ValueTuple`3[Microsoft.CodeAnalysis.Emit.EmitResult,String,Boolean]  CompileFile
            Par�metros: String filepath
        Void  CrearJson
            Par�metros: ValueTuple`3 res
        Collections.Generic.Dictionary`2[String,Collections.Generic.Dictionary`2[String,gsUtilidadesNET.ClassifSpanInfo]]  EvaluaCodigo
            Par�metros: String sourceCode, String lenguaje
        ValueTuple`2[String,String]  WindowsDesktopApp
        ValueTuple`2[String,String]  NETCoreApp
        String  ColoreaHTML
            Par�metros: String sourceCode, String lenguaje, Boolean mostrarLineas
        Type  GetType
        String  ToString
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Clase: Config
    Constructores:
        IsPublic = True
            Par�metros: String fic
        IsPublic = True
            Par�metros: String fic, Boolean guardarAlAsignar
    Config.M�todos:
        String  GetValue
            Par�metros: String seccion, String clave
        String  GetValue
            Par�metros: String seccion, String clave, String predeterminado
        Int32  GetValue
            Par�metros: String seccion, String clave, Int32 predeterminado
        Double  GetValue
            Par�metros: String seccion, String clave, Double predeterminado
        Boolean  GetValue
            Par�metros: String seccion, String clave, Boolean predeterminado
        Void  SetValue
            Par�metros: String seccion, String clave, String valor
        Void  SetValue
            Par�metros: String seccion, String clave, Int32 valor
        Void  SetValue
            Par�metros: String seccion, String clave, Double valor
        Void  SetKeyValue
            Par�metros: String seccion, String clave, Double valor
        Void  SetValue
            Par�metros: String seccion, String clave, Boolean valor
        Void  SetKeyValue
            Par�metros: String seccion, String clave, String valor
        Void  SetKeyValue
            Par�metros: String seccion, String clave, Int32 valor
        Void  SetKeyValue
            Par�metros: String seccion, String clave, Boolean valor
        Void  RemoveSection
            Par�metros: String seccion
        Collections.Generic.List`1[String]  Secciones
        Collections.Generic.Dictionary`2[String,String]  Claves
            Par�metros: String seccion
        Void  Save
        Void  Read
        Type  GetType
        String  ToString
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Clase: ClassifSpanInfo
    Constructores:
        IsPublic = True
            Sin par�metros
        IsPublic = True
            Par�metros: ClassifiedSpan classifSpan, TrueString word
    ClassifSpanInfo.M�todos:
        String  ToString
        Void  SetClassifiedSpan
            Par�metros: ClassifiedSpan classifSpan, [Optional] String word = <Nada>
        Type  GetType
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Clase: DiagInfo
    Constructores:
        IsPublic = True
            Sin par�metros
        IsPublic = True
            Par�metros: Diagnostic diag
    DiagInfo.M�todos:
        String  ToString
        Void  SetDiagnostic
            Par�metros: Diagnostic diag
        Type  GetType
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Clase: Extensiones
    Extensiones.M�todos:
        Boolean  ContienePalabra
            Par�metros: String texto, String palabra
        String  ComprobarFinLinea
            Par�metros: String selT
        String  QuitarPredeterminado
            Par�metros: String texto, String predeterminado
        Boolean  ContieneLetras
            Par�metros: String texto
        String  QuitarTildes
            Par�metros: String s
        String  ReplaceSiNoEstaPoner
            Par�metros: String texto, String buscar, String poner
        String  ReplaceSiNoEstaPoner
            Par�metros: String texto, String buscar, String poner, StringComparison comparar
        String  ReplaceWordSiNoEstaPoner
            Par�metros: String texto, String buscar, String poner, StringComparison comparar
        String  QuitarTodosLosEspacios
            Par�metros: String texto
        Int32  CuantasPalabras
            Par�metros: String texto
        String  CambiarCase
            Par�metros: String text, CasingValues queCase
        String  ToTitle
            Par�metros: String text
        String  ToUpperFirstChar
            Par�metros: String text
        String  ToLowerFirstChar
            Par�metros: String text
        String  ToLowerFirst
            Par�metros: String text
        Collections.Generic.List`1[String]  Palabras
            Par�metros: String text
        String  ReplaceWordOrdinal
            Par�metros: String texto, String buscar, String poner
        String  ReplaceWordIgnoreCase
            Par�metros: String texto, String buscar, String poner
        String  ReplaceWord
            Par�metros: String texto, String buscar, String poner, StringComparison comparar
        Type  GetType
        String  ToString
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Clase: InfoEnsambladoWrap
    Constructores:
        IsPublic = True
            Sin par�metros
    InfoEnsambladoWrap.M�todos:
        Boolean  GuardarInfo
            Par�metros: String[] args, String fic
        String  InfoTipo
            Par�metros: String[] args, [Optional] Boolean mostrarComandos = False
        String  MostrarAyuda
            Par�metros: Boolean mostrarEnConsola, Boolean esperar
        Type  GetType
        String  ToString
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Clase: Marcadores
    Constructores:
        IsPublic = True
            Par�metros: Int32 selStart, String fic
    Marcadores.M�todos:
        Void  Add
            Par�metros: Int32 inicio, Int32 selStart
        Int32  GetSelectionStart
            Par�metros: Int32 inicio
        Boolean  Contains
            Par�metros: Int32 inicio
        Boolean  Remove
            Par�metros: Int32 inicio
        Int32  Count
        Collections.Generic.List`1[Int32]  ToList
        Void  Clear
        Collections.Generic.IEnumerable`1[Int32]  Where
            Par�metros: Func`2 p
        Void  Sort
        Type  GetType
        String  ToString
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Clase: UtilEnum
    UtilEnum.M�todos:
        Boolean  CheckValidEnumValue
            Par�metros: String arg, Object val, Type class, [Optional] Boolean exception = False
        Type  GetType
        String  ToString
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Clase: UtilidadesCompilarColorear
    Constructores:
        IsPublic = True
            Sin par�metros
    UtilidadesCompilarColorear.M�todos:
        Void  Main
        String  Version
        Collections.Generic.HashSet`1[String]  ClasesExpuestas
        Type  GetType
        String  ToString
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Enumeraci�n: CasingValues
    Normal
    Upper
    Lower
    Title
    FirstToUpper
    FirstToLower

    CasingValues.M�todos:
        Boolean  Equals
            Par�metros: Object obj
        Boolean  HasFlag
            Par�metros: Enum flag
        Int32  GetHashCode
        String  ToString
        Int32  CompareTo
            Par�metros: Object target
        String  ToString
            Par�metros: String format, IFormatProvider provider
        String  ToString
            Par�metros: String format
        String  ToString
            Par�metros: IFormatProvider provider
        TypeCode  GetTypeCode
        Type  GetType
    CasingValues.Interfaces:
        IComparable
            CompareTo
        IFormattable
            ToString
        IConvertible
            GetTypeCode
            ToBoolean
            ToChar
            ToSByte
            ToByte
            ToInt16
            ToUInt16
            ToInt32
            ToUInt32
            ToInt64
            ToUInt64
            ToSingle
            ToDouble
            ToDecimal
            ToDateTime
            ToString
            ToType

## Clase: _Closure$__
    Constructores:
        IsPublic = True
            Sin par�metros
    _Closure$__.M�todos:
        Type  GetType
        String  ToString
        Boolean  Equals
            Par�metros: Object obj
        Int32  GetHashCode

## Enumeraci�n: FormatosEncoding
    Latin1
    UTF8
    Default

    FormatosEncoding.M�todos:
        Boolean  Equals
            Par�metros: Object obj
        Boolean  HasFlag
            Par�metros: Enum flag
        Int32  GetHashCode
        String  ToString
        Int32  CompareTo
            Par�metros: Object target
        String  ToString
            Par�metros: String format, IFormatProvider provider
        String  ToString
            Par�metros: String format
        String  ToString
            Par�metros: IFormatProvider provider
        TypeCode  GetTypeCode
        Type  GetType
    FormatosEncoding.Interfaces:
        IComparable
            CompareTo
        IFormattable
            ToString
        IConvertible
            GetTypeCode
            ToBoolean
            ToChar
            ToSByte
            ToByte
            ToInt16
            ToUInt16
            ToInt32
            ToUInt32
            ToInt64
            ToUInt64
            ToSingle
            ToDouble
            ToDecimal
            ToDateTime
            ToString
            ToType
