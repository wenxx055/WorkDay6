Option Strict On
Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()
        Dim Number As Integer = 1

        Do While Number <= 10
            lstResult.Items.Add("The perfect square is: " & Number ^ 2)
            Number = Number + 1
        Loop
    End Sub
End Class
