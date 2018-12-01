Public Class matriz
    Private valor = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}} 'Aqui se declara el arreglo para la matriz
    Dim deter1 As Integer = 0 'Variable para la primera multiplicacion
    Dim deter2 As Integer = 0 'Variable para la segunda multiplicacion

    Sub matriz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'En esta parte se asigna al arreglos los valores de la matriz
    End Sub


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim des As String
        Dim deter As String
        'Aqui se asignan los valores a nuestro arreglo y de igual forma de convierte a entero
        valor(0, 0) = Convert.ToInt32(cua1.Text)
        valor(0, 1) = Convert.ToInt32(cua2.Text)
        valor(0, 2) = Convert.ToInt32(cua3.Text)
        valor(1, 0) = Convert.ToInt32(cua4.Text)
        valor(1, 1) = Convert.ToInt32(cua5.Text)
        valor(1, 2) = Convert.ToInt32(cua6.Text)
        valor(2, 0) = Convert.ToInt32(cua7.Text)
        valor(2, 1) = Convert.ToInt32(cua8.Text)
        valor(2, 2) = Convert.ToInt32(cua9.Text)
        'Aqui se sacan los valores de las diagonales segun la regla de Sarrus
        deter1 = ((valor(0, 0) * valor(1, 1) * valor(2, 2)) + (valor(1, 0) * valor(2, 1) * valor(0, 2)) + (valor(2, 0) * valor(0, 1) * valor(1, 2)))
        deter2 = ((valor(0, 2) * valor(1, 1) * valor(2, 0)) + (valor(1, 2) * valor(2, 1) * valor(0, 0)) + (valor(2, 2) * valor(0, 1) * valor(1, 0)))
        deter = Convert.ToString(deter1 - deter2)
        'En lo siguiente vamos a imprimir el resultado y preguntar si desea seguir
        des = MsgBox("La determinante de la matriz es " + deter + " ¿Desea seguir?", vbQuestion + vbYesNo, "Resultados") 'Funciona para mostrar una ventana emergente y saber que desea el usuario
        If des = vbNo Then
            frmMenu.Show()
            Me.Close()
        Else
            'Limpia las celdas para la tarea siguiente
            cua1.Text = ""
            cua2.Text = ""
            cua3.Text = ""
            cua4.Text = ""
            cua5.Text = ""
            cua6.Text = ""
            cua7.Text = ""
            cua8.Text = ""
            cua9.Text = ""
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        frmMenu.Show()
        Me.Close()
    End Sub
End Class