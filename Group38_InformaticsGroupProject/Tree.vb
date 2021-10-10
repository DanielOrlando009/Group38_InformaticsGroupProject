
'############################################################################
' Team Number: 38
' Team Member 1 Details: Orlando, DA (220004186)
' Team Member 2 Details: Buys,P (221038891)
' Team Member 3 Details: Osler,A (221041006)
' Pratical: Group Project
' Class Name: Tree 
'############################################################################


Option Explicit On
Option Infer Off
Option Strict On

<Serializable()> Public Class Tree
    Inherits Environment
    'variables
    Private _treeQuantity As Integer 'how many trees planted
    Private _treeSpecies As Integer 'select type of tree
    Private _treeClubName As String 'what is your tree club name
    Private _treeClubMembers As Integer 'how many members in tree club

    Private Const line As String = vbNewLine 'Constant Bonus Mark A

    'constructor
    Private Sub New()
        MyBase.New()
        _treeQuantity = 0
        _treeClubMembers = 0
    End Sub
    'property methods

    Public Property treeQuantity As Integer
        Get
            Return _treeQuantity
        End Get
        Set(value As Integer)
            _treeQuantity = value
        End Set
    End Property

    Public ReadOnly Property treeSpecies As String
        Get
            Select Case _treeSpecies
                Case 1
                    Return "Laurel Oak Tree"
                Case 2
                    Return "Red Mulberry Tree"
                Case 3
                    Return "Silver Maple Tree"
                Case Else
                    Return "Error"
            End Select
        End Get
    End Property

    Public Property treeClubName As String
        Get
            Return _treeClubName
        End Get
        Set(value As String)
            _treeClubName = value
        End Set
    End Property

    Public Property TreeClubMembers As Integer
        Get
            Return _treeClubMembers
        End Get
        Set(value As Integer)
            _treeClubMembers = value
        End Set
    End Property

    Public Function CalcBestEcoTree() As Integer
        'calculating the result of tree selected how much CO2 emissions can be combatted with thus tree
        Dim value As Integer
        If _treeSpecies = 1 Then

            value = _treeQuantity + 10

        ElseIf _treeSpecies = 2 Then

            value = _treeQuantity + 5

        ElseIf _treeSpecies = 3 Then

            value = _treeQuantity + 2
        End If
        Return value
    End Function

    'calculate Total Tree club score 
    Public Function CalcTotalTreeClubScore() As Integer
        Dim value As Integer
        value = (CalcBestEcoTree() * _treeClubMembers)
        Return value
    End Function

    Public Overrides Function CalcScore() As Integer 'calculate score used for money and award
        Dim ans As Integer
        ans = CalcTotalTreeClubScore()
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
        'display data
        Dim temp As String

        temp = "Trees are essencial because they purify the air" & line _
             & "By planting more trees you are also creating more homes and food sources for many animals." & line _
             & "How many trees did you plant: " & _treeQuantity & line _
             & "What is you Tree club's name: " & _treeClubName & line _
             & "Total Tree planting score: " & CalcScore() & line _
             & "Total money earned by helping the environment: " & CalcMoney() & line _
             & "You award is: " & CalcAward() & line

        Return temp

    End Function


End Class
