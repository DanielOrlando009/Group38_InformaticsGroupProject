
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
    Private _PeopleNeedsWater As Integer
    Private _WaterImprovement As Integer
    Private _Budget As Integer

    'constructor
    Public Sub New()
        MyBase.New()
        _PeopleNeedsWater = 0
        _Budget = 0
    End Sub
    'property methods
    Public Property PeoplenNeedsWater As Integer
        Get
            Return _PeopleNeedsWater
        End Get
        Set(value As Integer)
            _PeopleNeedsWater = value
        End Set
    End Property

    Public Property WaterImprovement As Integer
        Get
            CalcImprovement(_WaterImprovement)
            Return _WaterImprovement
        End Get
        Set(value As Integer)
            CalcImprovement(_WaterImprovement)
            _WaterImprovement = value
        End Set
    End Property

    Public Property Budget As Integer
        Get
            Return _Budget
        End Get
        Set(value As Integer)
            _Budget = value
        End Set
    End Property

    'subroutine to calculate improvment needed
    Private Sub CalcImprovement(ByRef value As Integer)
        value = CInt(_PeopleNeedsWater ^ 2)
    End Sub

    'function to calculate how many water sources can be provided
    Public Function WaterSourcesNeeded() As Double
        Dim value As Double
        value = _Budget / _WaterImprovement
        Return value
    End Function

    Public Overrides Function CalcScore() As Integer 'calculate score used for money and award

    End Function

    'display override function
    Public Overrides Function display() As String

    End Function


End Class

