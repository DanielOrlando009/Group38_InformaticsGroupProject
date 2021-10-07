
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

Public Class Tree

    'variables
    Private _treeQuantity As Integer
    Private _treeSpecies As Integer
    Private _treeClub() As Integer
    Private _treeClubName As String

    'constructor
    Private Sub New(value As Integer)
        _treeQuantity = 0
        ReDim _treeClub(value)
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

    Public Property treeClub(index As Integer) As Integer
        Get
            Return _treeClub(index)
        End Get
        Set(value As Integer)
            _treeClub(index) = value
        End Set
    End Property

    Public Property TreeClubName As String
        Get
            Return _treeClubName
        End Get
        Set(value As String)
            _treeClubName = value
        End Set
    End Property

    Public Function CalcBestEcoTree() As Integer
        'calculating the result of tree selected how much CO2 emissions can be combatted with thus tree
        Dim value As Integer
        If _treeSpecies = 1 Then

            value = _treeQuantity * 10

        ElseIf _treeSpecies = 2 Then

            value = _treeQuantity * 5

        ElseIf _treeSpecies = 3 Then

            value = _treeQuantity * 2
        End If
        Return value
    End Function

    'calculate Total Tree club score 
    Public Function CalcTotalTreeClubScore() As Integer
        Dim value As Integer
        For c As Integer = 1 To _treeClub.Length - 1
            value += CalcBestEcoTree() * 5
        Next
        Return value
    End Function





End Class
