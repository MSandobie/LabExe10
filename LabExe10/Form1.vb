Imports System.IO

Public Class Form1
    Dim filePath As String = "file.text"
    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click

        Try
            Using Writer As New StreamWriter(filePath, True)
                While 
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class
