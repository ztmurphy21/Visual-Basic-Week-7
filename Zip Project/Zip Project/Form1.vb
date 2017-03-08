'zip program
'Purpose: Outputs the zipcode of a city, based off select from box list.
'Programmer: Zachary Murphy on 3-7-2017

Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click, lstCities.SelectedIndexChanged
        lstZips.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes application
        Me.Close()
    End Sub

    Private Sub btnFindZips_Click(sender As Object, e As EventArgs) Handles btnFindZips.Click
        Dim intZip As Integer

        'determines the zip code based off selected city.
        If (lstCities.SelectedItem = "Baxley") Then
            For intZip = 31513 To 31515 Step 2
                lstZips.Items.Add(intZip.ToString)
            Next intZip

        ElseIf (lstCities.SelectedItem = "Newton") Then
            For intZip = 39870 To 39870
                lstZips.Items.Add(intZip.ToString)
            Next intZip

        ElseIf (lstCities.SelectedItem = "Adairsville") Then
            For intZip = 30103 To 30103
                lstZips.Items.Add(intZip.ToString)
            Next intZip

        ElseIf (lstCities.SelectedItem = "Statesboro") Then
            For intZip = 30458 To 30461 Step 1
                lstZips.Items.Add(intZip.ToString)
            Next intZip

        ElseIf (lstCities.SelectedItem = "Canton") Then
            For intZip = 30114 To 30115 Step 1
                lstZips.Items.Add(intZip.ToString)
            Next intZip
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'fill list box with cities
        lstCities.Items.Add("Baxley")
        lstCities.Items.Add("Newton")
        lstCities.Items.Add("Adairsville")
        lstCities.Items.Add("Statesboro")
        lstCities.Items.Add("Canton")
    End Sub



End Class
