' Name:         Payment Project
' Purpose:      Display the monthly mortgage payments
'               for terms of 15, 20, 25, and 30 years
' Programmer:   Zachary Murphy on 3-7-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill list box with rates and select first rate

        For dblRates As Double = 2 To 7 Step 0.5
            lstRates.Items.Add(dblRates.ToString("n1"))
        Next dblRates
        lstRates.SelectedItem = "3.0"

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' display the monthly mortgage payment
        Dim intPrincipal As Integer
        Dim dblRate As Double
        Dim dblPay As Double

        Integer.TryParse(txtPrincipal.Text, intPrincipal)
        Double.TryParse(lstRates.SelectedItem.ToString, dblRate)

        dblRate = dblRate / 100
        lblPay.Text = String.Empty

        For intTerm As Integer = 15 To 30 Step 5
            dblPay = -Financial.Pmt(dblRate / 12, intTerm * 12, intPrincipal)
            lblPay.Text = lblPay.Text & intTerm.ToString & " years:   " & dblPay.ToString("c2") & ControlChars.NewLine
        Next intTerm

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPrincipal_Enter(sender As Object, e As EventArgs) Handles txtPrincipal.Enter
        txtPrincipal.SelectAll()
    End Sub

    Private Sub ClearPayment(sender As Object, e As EventArgs) Handles txtPrincipal.TextChanged, lstRates.SelectedValueChanged
        lblPay.Text = String.Empty
    End Sub

    Private Sub txtPrincipal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrincipal.KeyPress
        ' accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
