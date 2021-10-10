
'############################################################################
' Team Number: 38
' Team Member 1 Details: Orlando, DA (220004186)
' Team Member 2 Details: Buys,P (221038891)
' Team Member 3 Details: Osler,A (221041006)
' Pratical: Group Project
' Class Name: Environment 
'############################################################################



Option Strict On
Option Explicit On
Option Infer Off


<Serializable()> Public MustInherit Class Environment
    'Variables
    Protected _Score, _Money As Integer
    Protected _Award As String

    Public Sub New() 'Constructor
        _Score = 0
        _Money = 0
        _Award = "None"
    End Sub

    'Property Methods
    Public Property Score() As Integer
        Get
            Return _Score
        End Get
        Set(value As Integer)
            _Score = value
        End Set

    End Property


    Public Property Money() As Integer
        Get
            Return _Money
        End Get
        Set(value As Integer)
            _Money = value
        End Set
    End Property

    Public Property Award As String
        Get
            Return _Award
        End Get
        Set(value As String)
            _Award = value
        End Set
    End Property

    Public MustOverride Function CalcScore() As Integer 'calculate score used for money and award

    Public Function CalcMoney() As Integer
        'Calculates the money earned for helping the environment
        _Money = CalcScore() * 10
        Return Money
    End Function

    Public Function CalcAward() As String
        'Determines which award is assigned to the user 
        If CalcScore() < 33 Then
            _Award = "No Award"
        ElseIf CalcScore() >= 33 And CalcScore() < 66 Then
            _Award = "Hard Worker"
        ElseIf CalcScore() >= 66 Then
            _Award = "Top Achiever"
        End If

        Return Award
    End Function

    Public MustOverride Function display() As String 'output data

End Class
