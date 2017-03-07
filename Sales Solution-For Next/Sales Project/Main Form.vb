' Name:         Sales Project
' Purpose:      Display the projected sales for each of four years
' Programmer:   Zachary Murphy on 3-6-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' display the projected sales

        Const dblGROWTH_RATE As Double = 0.03
        Dim dblSales As Double
        Dim dblIncrease As Double

        Double.TryParse(txtCurrentSales.Text, dblSales)
        lblProjSales.Text = "Year         Sales" & ControlChars.NewLine

        For intYear As Integer = 2017 To 2020
            dblIncrease = dblSales * dblGROWTH_RATE
            dblSales = dblSales + dblIncrease
            lblProjSales.Text = lblProjSales.Text & intYear.ToString & "         " & dblSales.ToString("c0") & ControlChars.NewLine
        Next intYear


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCurrentSales_Enter(sender As Object, e As EventArgs) Handles txtCurrentSales.Enter
        txtCurrentSales.SelectAll()
    End Sub

    Private Sub txtCurrentSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrentSales.KeyPress
        ' accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9'") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCurrentSales_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentSales.TextChanged
        lblProjSales.Text = String.Empty
    End Sub
End Class
