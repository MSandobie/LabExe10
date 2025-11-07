Imports System.IO

Public Class Form1

    Dim filePath As String = "Sample.txt"
    Private Sub buttonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Try
            Dim Number As Integer
            Number = NumericUpDown1.Value

            Using writer As New StreamWriter(filePath, True) 'True to append
                writer.WriteLine(Number) '

            End Using

            MessageBox.Show("Number saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub buttonRead_Click(sender As Object, e As EventArgs) Handles ButtonREAD.Click

        If Not File.Exists(filePath) Then
            MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim numbers As New List(Of Integer)


        Using reader As New StreamReader(filePath)
            Dim line As String = reader.ReadLine()
            While line IsNot Nothing
                Dim num As Integer
                If Integer.TryParse(line, num) Then
                    numbers.Add(num)
                End If
                line = reader.ReadLine()
            End While
        End Using


        Dim sortedNumbers = numbers.OrderBy(Function(n) n).ToList()


        ListBox1.Items.Clear()
        For Each n In sortedNumbers
            ListBox1.Items.Add(n)
        Next


    End Sub
End Class
