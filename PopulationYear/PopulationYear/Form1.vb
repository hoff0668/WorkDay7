Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim year As Integer = 2014
        Dim Population As Double = 7000000000



        Do While Population > 6000000
            Population = Population / 2
            year = year - 50
        Loop




        MessageBox.Show("The year was " & CStr(year))

    End Sub
End Class
