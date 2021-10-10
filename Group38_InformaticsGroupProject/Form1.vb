Option Strict On
Option Explicit On
Option Infer Off

'############################################################################
' Team Number: 38
' Team Member 1 Details: Orlando, DA (220004186)
' Team Member 2 Details:
' Team Member 3 Details:
' Pratical: Group Project
' Class Name: frmGUI 
'############################################################################

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmGUI
    'Variables
    Private Enviros(2) As Environment
    Private objective As Integer
    Private Const line As String = vbNewLine 'Constant Bonus Mark A

    Private Enum Env 'Enumeration Bonus Mark A
        Tree = 0
        Water = 1
        Waste = 2
    End Enum


    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        'Target score of user
        objective = CInt(InputBox("What Score would you like to achieve?"))





        'Saving to a text file Bonus Mark Section C
        Dim file As FileStream
        Dim binForm As BinaryFormatter

        file = New FileStream("Output.txt", FileMode.Create, FileAccess.Write)
        binForm = New BinaryFormatter()

        binForm.Serialize(file, Enviros)
        file.Close()
    End Sub

End Class
