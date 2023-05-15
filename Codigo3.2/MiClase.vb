Public Class MiClase
    ' Variables de instancia
    Private variableEntera As Integer
    Private variableCadena As String

    ' Constructor por defecto
    Public Sub New()
        variableEntera = 0
        variableCadena = "Sin valor"
    End Sub

    ' Constructor con parámetros
    Public Sub New(entero As Integer, cadena As String)
        variableEntera = entero
        variableCadena = cadena
    End Sub

    ' Destructor
    Protected Overrides Sub Finalize()
        MessageBox.Show("Objeto destruido")
        MyBase.Finalize()
    End Sub

    ' Método que muestra el valor de las variables
    Public Sub MostrarVariables()
        MessageBox.Show("Variable Entera: " & variableEntera.ToString() & vbCrLf & "Variable Cadena: " & variableCadena)
    End Sub
End Class

Public Class MainForm
    Private objeto1 As MiClase
    Private objeto2 As MiClase

End Class
