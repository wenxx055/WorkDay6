Option Strict On
Public Class Form1
    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim Population As Double = 7000
        Dim Year As Integer = 2012

        Do While Population > 6
            Year = Year - 50
            Population = Population / 2
        Loop

        MessageBox.Show("The year is: " & Year)

    End Sub
End Class