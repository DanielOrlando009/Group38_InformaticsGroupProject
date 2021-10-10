Option Strict On
Option Explicit On
Option Infer Off

'############################################################################
' Team Number: 38
' Team Member 1 Details: Orlando, DA (220004186)
' Team Member 2 Details: Buys,P (221038891)
' Team Member 3 Details: Osler,A (221041006)
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
        Trash = 2
    End Enum


    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        'downcasting
        Enviros(Env.Tree) = New Tree() 'check what integer is used in constructor
        Enviros(Env.Water) = New Water()
        Enviros(Env.Trash) = New Trash()

        'data input and processing
        'tree input
        Dim temptree As Tree = New Tree()

        temptree.treeQuantity = CInt(InputBox("Enter the amount of trees that were planted. "))
        temptree.treeSpecies = CInt(InputBox("Enter the type of tree planted. (1 - Laurel Oak)(2 - Red Mulberry)(3 - Silver Maple)"))
        temptree.treeClubName = InputBox("Enter the name of your tree Club. ")
        temptree.treeClubMembers = CInt(InputBox("Enter the number of members in your group."))

        Enviros(Env.Tree) = TryCast(temptree, Tree)


        'water input
        Dim tempwater As Water = New Water()

        tempwater.LitersWater = CInt(InputBox("Enter the amount of rain water you collected and stored (litres)"))
        tempwater.BeginWaterBill = CInt(InputBox("Enter your starting water bill (whole numbers)"))
        tempwater.EndWaterBill = CInt(InputBox("Enter your last water bill (whole numbers)(Should be lower than starting bill)"))

        Enviros(Env.Water) = TryCast(tempwater, Water)


        'trash input
        Dim temptrash As Trash = New Trash()

        temptrash.Materials = CInt(InputBox("Enter the material that was recycled(1 - Plastic)(2 - Paper)(3 - Glass)(4 - All)"))
        temptrash.KG = CInt(InputBox("Enter the amount of trash recycled (In kilograms)"))
        temptrash.Separate = CInt(InputBox("Did you separate the materials (1 - Yes)(2 - No)"))

        Enviros(Env.Trash) = TryCast(temptrash, Trash)

        'output data
        txtOutput.Text = "Trees: " & line & Enviros(Env.Tree).display() & line & line _
            & "Water: " & line & Enviros(Env.Water).display() & line & line _
            & "Recycling: " & line & Enviros(Env.Trash).display()


        'output money and awards
        Dim totMoney As Integer = 0
        For i As Integer = 0 To 2
            totMoney += Enviros(i).Money
        Next i

        Dim allAwards As String = ""
        For i2 As Integer = 0 To 2
            allAwards = allAwards + Enviros(i2).Award + ", "
        Next i2

        txtMoney.Text = "R" + CStr(totMoney)
        txtAward.Text = allAwards


        'Saving to a text file Bonus Mark Section C
        Dim file As FileStream
        Dim binForm As BinaryFormatter

        file = New FileStream("Output.txt", FileMode.Create, FileAccess.Write)
        binForm = New BinaryFormatter()

        binForm.Serialize(file, Enviros)
        file.Close()
    End Sub

End Class
