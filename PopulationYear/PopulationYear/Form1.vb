Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click


        Dim population As Double = 7000000000, year As Integer = 2014
        Do Until population < 6000000
            population /= 2
            year -= 50
        Loop

        MessageBox.Show("The answer: " & year)
    End Sub
End Class
