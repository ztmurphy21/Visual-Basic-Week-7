' Name:         Clock Project
' Purpose:      Displays minutes and seconds
' Programmer:   Zach Murphy on 3-7-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' display minutes (from 0 through 2 only)
        ' and seconds (from 0 through 5 only)\
        Dim intMinutes As Integer = 0
        Do While intMinutes < 2

            For intSeconds As Integer = 0 To 5
                lblSeconds.Text = intSeconds.ToString
                'referesh interface and then pause execution
                Me.Refresh()
                System.Threading.Thread.Sleep(500)
            Next intSeconds
            intMinutes += 1
            lblMinutes.Text = intMinutes.ToString
        Loop

    End Sub
End Class
