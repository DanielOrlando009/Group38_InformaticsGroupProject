'############################################################################
' Team Number: 38
' Team Member 1 Details: Orlando, DA (220004186)
' Team Member 2 Details: Buys,P (221038891)
' Team Member 3 Details: Osler,A (221041006)
' Pratical: Group Project
' Class Name: Trash
'############################################################################
'Option Statements
Option Strict On
Option Explicit On
Option Infer Off
'Class Trash
<Serializable()> Public Class Trash
    Inherits Environment
    'Global Variable
    Private _Materials As Integer
    Private _KG As Double
    Private _Separate As Integer
    'Public property Materials

    Private Const line As String = vbNewLine 'Constant Bonus Mark A

    Public Sub New()
        MyBase.New()
        _Materials = 0
        _KG = 0
        _Separate = 0
    End Sub

    Public Property Materials As Integer
        Get
            Return _Materials
        End Get
        Set(value As Integer)
            _Materials = value
        End Set
    End Property
    'Public property KG
    Public Property KG As Double
        Get
            Return _KG
        End Get
        Set(value As Double)
            _KG = value
        End Set
    End Property
    'Public property Separate
    Public Property Separate As Integer
        Get
            Return _Separate
        End Get
        Set(value As Integer)
            _Separate = value
        End Set
    End Property
    'Function CalcM determining the Material
    Public Function CalcM() As String
        Select Case Materials
            Case 1
                Return "Plastic"
            Case 2
                Return "Paper"
            Case 3
                Return "Glass"
            Case 4
                Return "All"
            Case Else
                Return "Error"
        End Select
    End Function
    'Function CalcS determining whether people Separate Trash
    Public Function CalcS() As String
        If Separate = 1 Then
            Return "Yes"
        ElseIf Separate = 2 Then
            Return "No"
        Else
            Return "Error"
        End If
    End Function
    'Function CalcMaterialScore returning an integer value
    Public Function CalcMaterialScore() As Integer
        Select Case Materials
            Case 1
                Return 5
            Case 2
                Return 10
            Case 3
                Return 12
            Case 4
                Return 15
            Case Else
                Return 0
        End Select
    End Function
    'Function CalcScore returning an integer value of the users score
    Public Overrides Function CalcScore() As Integer 'Overrides
        Dim ans As Integer = 0
        If Separate = 1 Then
            ans = CInt((KG * 5) + 10 + CalcMaterialScore())
            If ans < 0 Then
                Return 0
            ElseIf ans > 100 Then
                Return 100
            Else
                Return ans
            End If
        ElseIf Separate = 2 Then
            ans = CInt((KG * 5) + CalcMaterialScore())
            If ans < 0 Then
                Return 0
            ElseIf ans > 100 Then
                Return 100
            Else
                Return ans
            End If
        Else
            Return 0
        End If
    End Function

    'Overrides Function Display Presenting the data
    Public Overrides Function display() As String
        Dim T As String = ""
        T = "KG: " & KG & line
        T &= "Materials: " & Materials & line
        T &= "Seperates Materials: " & Separate & line
        T &= "Score: " & CalcScore() & line
        T &= "Money Earned: " & CalcMoney() & line
        T &= "Award Earned: " & CalcAward() & line
        Return T
    End Function
End Class
