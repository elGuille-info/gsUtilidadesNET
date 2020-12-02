'------------------------------------------------------------------------------
' Para guardar la informaci�n al evaluar/compilar                   (04/Oct/20)
'
' Dos clases:
'   ClassifSpanInfo
'   DiagInfo
'
'
' (c) Guillermo (elGuille) Som, 2020
'------------------------------------------------------------------------------
Option Strict On
Option Infer On

Imports System
Imports System.Linq
Imports System.Collections.Generic

'Imports System.IO
Imports System.Text

Imports Microsoft.CodeAnalysis
'Imports Microsoft.CodeAnalysis.CSharp
'Imports Microsoft.CodeAnalysis.Emit
'Imports Microsoft.CodeAnalysis.VisualBasic
Imports Microsoft.CodeAnalysis.Text
Imports Microsoft.CodeAnalysis.Classification

''' <summary>
''' Clase para manejar informaci�n del tipo ClassifiedSpan
''' </summary>
Public Class ClassifSpanInfo
    Public Sub New()

    End Sub

    Public Sub New(classifSpan As ClassifiedSpan, Optional word As String = "<Nada>")
        SetClassifiedSpan(classifSpan, word)
    End Sub

    Public Overrides Function ToString() As String
        ' si est� el DrawMode del listbox en Normal
        ' no a�ade los espacios
        Return $"    {Word}"
        'Return Word
    End Function


    '
    ' Para ClassifiedSpan
    '

    ''' <summary>
    ''' El objeto SourceText del c�digo procesado.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property SourceText As SourceText

    ''' <summary>
    ''' Asignar el objeto del tipo <see cref="ClassifiedSpan"/> a la clase.
    ''' </summary>
    ''' <param name="classifSpan"></param>
    ''' <param name="word"></param>
    Public Sub SetClassifiedSpan(classifSpan As ClassifiedSpan, Optional word As String = "<Nada>")
        Me.StartPosition = classifSpan.TextSpan.Start
        Me.EndPosition = classifSpan.TextSpan.End
        Me.ClassificationType = classifSpan.ClassificationType
        'Me.TextSpan = classifSpan.TextSpan
        If word <> "<Nada>" Then Me.Word = word
        Me.ClassifSpan = classifSpan
    End Sub

    ''' <summary>
    ''' El objecto ClassifiedSpan asociado
    ''' </summary>
    ''' <returns></returns>
    Public Property ClassifSpan As ClassifiedSpan
    '''' <summary>
    '''' El objeto TextSpan asociado
    '''' </summary>
    '''' <returns></returns>
    'Public Property TextSpan As TextSpan
    ''' <summary>
    ''' La posici�n de inicio en el c�digo
    ''' </summary>
    ''' <returns></returns>
    Public Property StartPosition As Integer
    ''' <summary>
    ''' La posici�n final en el c�digo
    ''' </summary>
    ''' <returns></returns>
    Public Property EndPosition As Integer
    ''' <summary>
    ''' El tipo de elemento del c�digo (clase, keyword, etc.)
    ''' </summary>
    ''' <returns></returns>
    Public Property ClassificationType As String
    ''' <summary>
    ''' La palabra clave
    ''' </summary>
    ''' <returns></returns>
    Public Property Word As String

End Class

''' <summary>
''' Clase para manejar informaci�n del tipo Diagnostic
''' </summary>
Public Class DiagInfo

    Public Sub New()

    End Sub

    'Public Sub New(classifSpan As ClassifiedSpan, diag As Diagnostic, Optional word As String = "<Nada>")
    '    Me.New(diag)
    '    'diag.Severity.
    '    SetClassifiedSpan(classifSpan, word)
    'End Sub

    'Public Sub New(classifSpan As ClassifiedSpan, Optional word As String = "<Nada>")
    '    SetClassifiedSpan(classifSpan, word)
    'End Sub

    Public Sub New(diag As Diagnostic)
        SetDiagnostic(diag)
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("{0}: {1} (Posici�n: {2},{3}-{4},{5})",
                             Id, Message,
                             StartLinePosition.Line + 1, StartLinePosition.Character,
                             EndLinePosition.Line + 1, EndLinePosition.Character)
    End Function

    '
    ' Para Diagnostic
    '

    Public Sub SetDiagnostic(diag As Diagnostic)
        Me.StartLinePosition = diag.Location.GetLineSpan.StartLinePosition
        Me.EndLinePosition = diag.Location.GetLineSpan.EndLinePosition
        Me.Id = diag.Id
        Me.Message = diag.GetMessage
        Me.Diagnostic = diag
    End Sub

    ''' <summary>
    ''' El objeto Diagnostic asociado
    ''' </summary>
    ''' <returns></returns>
    Public Property Diagnostic As Diagnostic
    ''' <summary>
    ''' La posici�n de inicio en el c�digo del error
    ''' </summary>
    ''' <returns></returns>
    Public Property StartLinePosition As LinePosition
    ''' <summary>
    ''' La posici�n final en el c�digo del error
    ''' </summary>
    ''' <returns></returns>
    Public Property EndLinePosition As LinePosition
    ''' <summary>
    ''' El n�mero del error
    ''' </summary>
    ''' <returns></returns>
    Public Property Id As String
    ''' <summary>
    ''' Texto del error o warning
    ''' </summary>
    ''' <returns></returns>
    Public Property Message As String

    ''' <summary>
    ''' La severidad del error o advertencia
    ''' </summary>
    ''' <returns></returns>
    Public Property Severity As DiagnosticSeverity

End Class