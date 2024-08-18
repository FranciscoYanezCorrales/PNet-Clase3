Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rutaArchivo As String = System.IO.Path.Combine(Application.StartupPath, "carga.txt")
        'C:\Users\franc\source\repos\Clase3\Clase3\bin\Debug\net8.0-windows
        'Dim rutaArchivo As String = "C:\ruta\estudiantes.txt"
        Try
            If My.Computer.FileSystem.FileExists(rutaArchivo) Then
                Dim contenido As String = My.Computer.FileSystem.ReadAllText(rutaArchivo)
                txtcarga.Text = contenido
                lblestado.Text = "Archivo cargado correctamente......"
            Else
                lblestado.Text = "El archivo no fue encontrado."
            End If
        Catch ex As Exception
            lblestado.Text = "Error al cargar el archivo: " & ex.Message
        End Try
    End Sub
End Class
