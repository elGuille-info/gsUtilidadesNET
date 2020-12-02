# Contenido del ensamblado 'gsUtilidadesNET.dll'

Información de los tipos definidos en el ensamblado.


>**NOTA:**
>Esta información la he conseguido usando la utilidad [Mostrar contenido ensamblado](https://github.com/elGuille-info/Mostrar-contenido-ensamblado)


## Clase: VB$AnonymousDelegate_0`2
    IsGenericType = True
    Constructores:
        IsPublic = True
            Parámetros: Object TargetObject, IntPtr TargetMethod
    VB$AnonymousDelegate_0`2.Métodos:
        IAsyncResult  BeginInvoke
            Parámetros: TArg0 c, AsyncCallback DelegateCallback, Object DelegateAsyncState
        TResult  EndInvoke
            Parámetros: IAsyncResult DelegateAsyncResult
        TResult  Invoke
            Parámetros: TArg0 c
        Void  GetObjectData
            Parámetros: SerializationInfo info, StreamingContext context
        Boolean  Equals
            Parámetros: Object obj
        Delegate[]  GetInvocationList
        Int32  GetHashCode
        Object  Clone
        Object  DynamicInvoke
            Parámetros: Object[] args
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
            Sin parámetros
    MyApplication.Métodos:
        Type  GetType
        String  ToString
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Clase: CompararString
    Constructores:
        IsPublic = True
            Sin parámetros
    CompararString.Métodos:
        Int32  Compare
            Parámetros: String x, String y
        Boolean  Equals
            Parámetros: String x, String y
        Int32  GetHashCode
            Parámetros: String obj
        Type  GetType
        String  ToString
        Boolean  Equals
            Parámetros: Object obj
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
            Sin parámetros
    Compilar.Métodos:
        Drawing.Color  GetColorFromName
            Parámetros: String classificationTypeName
        String  GetStringColorFromName
            Parámetros: String classificationTypeName
        Void  WriteColorDictionaryToFile
        Void  WriteColorDictionaryToFile
            Parámetros: String ficPath
        Void  UpdateColorDictionaryFromFile
        Void  UpdateColorDictionaryFromFile
            Parámetros: String ficPath
        Microsoft.CodeAnalysis.Emit.EmitResult  ComprobarCodigo
            Parámetros: String sourceCode, String lenguaje
        ValueTuple`2[Microsoft.CodeAnalysis.Emit.EmitResult,String]  CompileRun
            Parámetros: String file, [Optional] Boolean run = True
        ValueTuple`3[Microsoft.CodeAnalysis.Emit.EmitResult,String,Boolean]  CompileFile
            Parámetros: String filepath
        Void  CrearJson
            Parámetros: ValueTuple`3 res
        Collections.Generic.Dictionary`2[String,Collections.Generic.Dictionary`2[String,gsUtilidadesNET.ClassifSpanInfo]]  EvaluaCodigo
            Parámetros: String sourceCode, String lenguaje
        ValueTuple`2[String,String]  WindowsDesktopApp
        ValueTuple`2[String,String]  NETCoreApp
        String  ColoreaHTML
            Parámetros: String sourceCode, String lenguaje, Boolean mostrarLineas
        Type  GetType
        String  ToString
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Clase: Config
    Constructores:
        IsPublic = True
            Parámetros: String fic
        IsPublic = True
            Parámetros: String fic, Boolean guardarAlAsignar
    Config.Métodos:
        String  GetValue
            Parámetros: String seccion, String clave
        String  GetValue
            Parámetros: String seccion, String clave, String predeterminado
        Int32  GetValue
            Parámetros: String seccion, String clave, Int32 predeterminado
        Double  GetValue
            Parámetros: String seccion, String clave, Double predeterminado
        Boolean  GetValue
            Parámetros: String seccion, String clave, Boolean predeterminado
        Void  SetValue
            Parámetros: String seccion, String clave, String valor
        Void  SetValue
            Parámetros: String seccion, String clave, Int32 valor
        Void  SetValue
            Parámetros: String seccion, String clave, Double valor
        Void  SetKeyValue
            Parámetros: String seccion, String clave, Double valor
        Void  SetValue
            Parámetros: String seccion, String clave, Boolean valor
        Void  SetKeyValue
            Parámetros: String seccion, String clave, String valor
        Void  SetKeyValue
            Parámetros: String seccion, String clave, Int32 valor
        Void  SetKeyValue
            Parámetros: String seccion, String clave, Boolean valor
        Void  RemoveSection
            Parámetros: String seccion
        Collections.Generic.List`1[String]  Secciones
        Collections.Generic.Dictionary`2[String,String]  Claves
            Parámetros: String seccion
        Void  Save
        Void  Read
        Type  GetType
        String  ToString
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Clase: ClassifSpanInfo
    Constructores:
        IsPublic = True
            Sin parámetros
        IsPublic = True
            Parámetros: ClassifiedSpan classifSpan, TrueString word
    ClassifSpanInfo.Métodos:
        String  ToString
        Void  SetClassifiedSpan
            Parámetros: ClassifiedSpan classifSpan, [Optional] String word = <Nada>
        Type  GetType
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Clase: DiagInfo
    Constructores:
        IsPublic = True
            Sin parámetros
        IsPublic = True
            Parámetros: Diagnostic diag
    DiagInfo.Métodos:
        String  ToString
        Void  SetDiagnostic
            Parámetros: Diagnostic diag
        Type  GetType
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Clase: Extensiones
    Extensiones.Métodos:
        Boolean  ContienePalabra
            Parámetros: String texto, String palabra
        String  ComprobarFinLinea
            Parámetros: String selT
        String  QuitarPredeterminado
            Parámetros: String texto, String predeterminado
        Boolean  ContieneLetras
            Parámetros: String texto
        String  QuitarTildes
            Parámetros: String s
        String  ReplaceSiNoEstaPoner
            Parámetros: String texto, String buscar, String poner
        String  ReplaceSiNoEstaPoner
            Parámetros: String texto, String buscar, String poner, StringComparison comparar
        String  ReplaceWordSiNoEstaPoner
            Parámetros: String texto, String buscar, String poner, StringComparison comparar
        String  QuitarTodosLosEspacios
            Parámetros: String texto
        Int32  CuantasPalabras
            Parámetros: String texto
        String  CambiarCase
            Parámetros: String text, CasingValues queCase
        String  ToTitle
            Parámetros: String text
        String  ToUpperFirstChar
            Parámetros: String text
        String  ToLowerFirstChar
            Parámetros: String text
        String  ToLowerFirst
            Parámetros: String text
        Collections.Generic.List`1[String]  Palabras
            Parámetros: String text
        String  ReplaceWordOrdinal
            Parámetros: String texto, String buscar, String poner
        String  ReplaceWordIgnoreCase
            Parámetros: String texto, String buscar, String poner
        String  ReplaceWord
            Parámetros: String texto, String buscar, String poner, StringComparison comparar
        Type  GetType
        String  ToString
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Clase: InfoEnsambladoWrap
    Constructores:
        IsPublic = True
            Sin parámetros
    InfoEnsambladoWrap.Métodos:
        Boolean  GuardarInfo
            Parámetros: String[] args, String fic
        String  InfoTipo
            Parámetros: String[] args, [Optional] Boolean mostrarComandos = False
        String  MostrarAyuda
            Parámetros: Boolean mostrarEnConsola, Boolean esperar
        Type  GetType
        String  ToString
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Clase: Marcadores
    Constructores:
        IsPublic = True
            Parámetros: Int32 selStart, String fic
    Marcadores.Métodos:
        Void  Add
            Parámetros: Int32 inicio, Int32 selStart
        Int32  GetSelectionStart
            Parámetros: Int32 inicio
        Boolean  Contains
            Parámetros: Int32 inicio
        Boolean  Remove
            Parámetros: Int32 inicio
        Int32  Count
        Collections.Generic.List`1[Int32]  ToList
        Void  Clear
        Collections.Generic.IEnumerable`1[Int32]  Where
            Parámetros: Func`2 p
        Void  Sort
        Type  GetType
        String  ToString
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Clase: UtilEnum
    UtilEnum.Métodos:
        Boolean  CheckValidEnumValue
            Parámetros: String arg, Object val, Type class, [Optional] Boolean exception = False
        Type  GetType
        String  ToString
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Clase: UtilidadesCompilarColorear
    Constructores:
        IsPublic = True
            Sin parámetros
    UtilidadesCompilarColorear.Métodos:
        Void  Main
        String  Version
        Collections.Generic.HashSet`1[String]  ClasesExpuestas
        Type  GetType
        String  ToString
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Enumeración: CasingValues
    Normal
    Upper
    Lower
    Title
    FirstToUpper
    FirstToLower

    CasingValues.Métodos:
        Boolean  Equals
            Parámetros: Object obj
        Boolean  HasFlag
            Parámetros: Enum flag
        Int32  GetHashCode
        String  ToString
        Int32  CompareTo
            Parámetros: Object target
        String  ToString
            Parámetros: String format, IFormatProvider provider
        String  ToString
            Parámetros: String format
        String  ToString
            Parámetros: IFormatProvider provider
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
            Sin parámetros
    _Closure$__.Métodos:
        Type  GetType
        String  ToString
        Boolean  Equals
            Parámetros: Object obj
        Int32  GetHashCode

## Enumeración: FormatosEncoding
    Latin1
    UTF8
    Default

    FormatosEncoding.Métodos:
        Boolean  Equals
            Parámetros: Object obj
        Boolean  HasFlag
            Parámetros: Enum flag
        Int32  GetHashCode
        String  ToString
        Int32  CompareTo
            Parámetros: Object target
        String  ToString
            Parámetros: String format, IFormatProvider provider
        String  ToString
            Parámetros: String format
        String  ToString
            Parámetros: IFormatProvider provider
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
