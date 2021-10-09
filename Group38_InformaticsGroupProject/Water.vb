
'############################################################################
' Team Number: 38
' Team Member 1 Details: Orlando, DA (220004186)
' Team Member 2 Details:
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


    Public Function CalcWaterSaving() As Double
        Dim value As Double
        Dim saving As Double
        value = (BeginWaterBill - EndWaterBill) / BeginWaterBill * 100
        If value < 50 Then
            saving = 500
        Else
            saving = 100
        End If

        Return saving
    End Function
    'function to calculate how much water usage reduced
    Public Overrides Function CalcScore() As Integer 'calculate score used for money and award
        Dim ans As Integer
        ans = CInt(LitersWater + CalcWaterSaving())
        Return ans
    End Function

    'display override function
    Public Overrides Function display() As String

    End Function


End Class

