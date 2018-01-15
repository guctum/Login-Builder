'Owner/Writer: Greg Uctum
'Date: 2/27/2015
'Updated: 1/14/2018
'Title: Extra Credit Login Generator
Option Strict On

Imports System.Text

Public Class Form1
    Dim First As String = ""
    Dim Last As String = ""
    Dim Last6Letters As String = ""
    Dim RandomGenerator As New Random
    Dim Login As String = ""

    Dim NewFirst As New StringBuilder
    Dim NewLast As New StringBuilder
    Dim NewLast6Letters As New StringBuilder
    Dim NewLogin As New StringBuilder

    Private Sub btnString_Click(sender As Object, e As EventArgs) Handles btnString.Click
        First = txtFirst.Text()
        Last = txtLast.Text()

        If Last.Length < 6 Then
            Last6Letters = Last.Substring(0, Last.Length)
        Else
            Last6Letters = Last.Substring(0, 6)
        End If

        Dim Random1 As Integer = RandomGenerator.Next(0, 10)
        Dim Random2 As Integer = RandomGenerator.Next(0, 10)

        Login = Last6Letters.ToLower & CStr(First(0)).ToLower & Random1 & Random2
        txtLogin.Text = Login
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
