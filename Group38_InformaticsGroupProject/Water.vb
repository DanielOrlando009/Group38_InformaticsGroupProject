
'############################################################################
' Team Number: 38
' Team Member 1 Details: Orlando, DA (220004186)
' Team Member 2 Details: Buys,P (221038891)
' Team Member 3 Details: Osler,A (221041006)
' Pratical: Group Project
' Class Name: Environment 
'############################################################################

Option Explicit On
Option Infer Off
Option Strict On
<Serializable()> Public Class Water
    Inherits Environment
    'variables
    Private _LitersWater As Integer 'Rain water collected and stored
    Private _BeginWaterBill As Integer 'water billed by municipality
    Private _EndWaterBill As Integer

    'constructor
    Public Sub New()
        MyBase.New()
        _LitersWater = 0
        _BeginWaterBill = 0
        _EndWaterBill = 0
    End Sub
    'property methods
    Public Property LitersWater As Integer
        Get
            Return _LitersWater
        End Get
        Set(value As Integer)
            _LitersWater = value
        End Set
    End Property

    Public Property BeginWaterBill As Integer
        Get

            Return _BeginWaterBill
        End Get
        Set(value As Integer)

            _BeginWaterBill = value
        End Set
    End Property

    Public Property EndWaterBill As Integer
        Get
            Return _EndWaterBill
        End Get
        Set(value As Integer)
            _EndWaterBill = value
        End Set
    End Property


    Public Function CalcWaterSaving() As Integer
        Dim value As Integer
        Dim saving As Integer
        value = (BeginWaterBill - EndWaterBill)
        If value < 20 Then
            saving = 200
        ElseIf value >= 20 Or value < 40 Then
            saving = 400
        ElseIf value >= 40 Or value < 60 Then
            saving = 600
        ElseIf value >= 60 Or value < 80 Then
            saving = 800
        ElseIf value >= 80 Then
            saving = 1000
        End If

        Return saving
    End Function
    'function to calculate how much water usage reduced
    Public Overrides Function CalcScore() As Integer 'calculate score used for money and award
        Dim ans As Integer
        ans = (LitersWater + CalcWaterSaving())
        If ans < 0 Then
            Return 0
        ElseIf ans > 100 Then
            Return 100
        Else
            Return ans
        End If

    End Function

    'display override function
    Public Overrides Function display() As String

    End Function


End Class

