Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim request As WebRequest = WebRequest.Create("http://api.macvendors.com/" & TextBox1.Text)

        Try
            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            MessageBox.Show("Manufacturer: " & responseFromServer, "Success", MessageBoxButtons.OK)

            reader.Close()
            response.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Error", MessageBoxButtons.OK)
        End Try

    End Sub
End Class
