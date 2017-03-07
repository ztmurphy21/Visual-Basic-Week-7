' Name:         Addition Project
' Purpose:      Display the sum of the numbers entered
' Programmer:   Zachary Murphy on 3-6-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private intSum As Integer

    ' class-level accumulator

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' accumulate the numbers entered by the user
        Dim intNum As Integer

        'display number in the list
        txtList.Text = txtList.Text & txtNumber.Text & ControlChars.NewLine
        Integer.TryParse(txtNumber.Text, intNum)
        intSum += intNum
        lblSum.Text = intSum.ToString
        'send focus and select text
        txtNumber.Focus()
        txtNumber.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStartOver_Click(sender As Object, e As EventArgs) Handles btnStartOver.Click
        'reset accumulator, clear screen, set focus
        intSum = 0
        txtNumber.Text = String.Empty
        txtList.Text = String.Empty
        lblSum.Text = String.Empty
        txtNumber.Focus()
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' accept only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lblSum.Text = String.Empty
    End Sub
End Class
