' Name:         Electric Project
' Purpose:      Display the average electric bill
' Programmer:   Zachary Murphy on 3-7-2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate the average electric bill

        Const strPROMPT As String =
            "Enter electric bill. " &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Monthly Bill"
        Dim strMonthBill As String
        Dim dblMonthBill As Double
        Dim blnNumeric As Boolean
        Dim intMonths As Integer    ' counter
        Dim dblTotal As Double      ' accumulator
        Dim dblAvg As Double

        ' clear lstMonthly and lblAvg
        lstMonthly.Items.Clear()
        lblAvg.Text = String.Empty

        ' get first amount
        strMonthBill = InputBox(strPROMPT, strTITLE, "0")
        ' repeat as long as the user enters an amount
        Do While strMonthBill <> String.Empty
            blnNumeric = Double.TryParse(strMonthBill, dblMonthBill)
            If blnNumeric Then
                'display the amount in the list box
                lstMonthly.Items.Add(dblMonthBill.ToString("N2"))

                'update the counter and accumulator
                intMonths += 1
                dblTotal += dblMonthBill
            Else
                MessageBox.Show("Please enter a number.", "Monthly Bill", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            strMonthBill = InputBox(strPROMPT, strTITLE, "0")
        Loop

        ' verify that the counter is greater than 0
        If intMonths > 0 Then
            dblAvg = dblTotal / intMonths
            lblAvg.Text = dblAvg.ToString("c2")
        Else
            lblAvg.Text = "N/A"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
