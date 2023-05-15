Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Creación de objetos utilizando diferentes constructores
        objeto1 = New MiClase()
        objeto2 = New MiClase(10, "Hola")

        ' Llamada al método MostrarVariables
        MessageBox.Show("Objeto 1:")
        objeto1.MostrarVariables()

        MessageBox.Show(vbCrLf & "Objeto 2:")
        objeto2.MostrarVariables()

        ' Liberación de memoria utilizando el recolector de basura
        objeto1 = Nothing
        objeto2 = Nothing
        GC.Collect()
    End Sub
End Class