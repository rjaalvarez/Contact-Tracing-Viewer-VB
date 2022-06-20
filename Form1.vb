Imports System.IO
Public Class contactTracingViewerVB
    Private Sub showFilesBtn_Click(sender As Object, e As EventArgs) Handles showFilesBtn.Click
        For Each filename As String In IO.Directory.GetFiles("C:\Users\RJ\source\repos\Contact Tracing Viewer VB\bin\Debug", "*.txt")
            If Not filesListBox.Items.Contains(filesListBox.Text) Then
                filesListBox.Items.Add(Path.GetFileName(filename))
            End If
        Next

    End Sub
End Class
