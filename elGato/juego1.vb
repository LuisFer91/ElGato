Public Class juego1

    Dim btn(10) As Button 'Arreglo para los botones del tablero
    Dim boton(10) As Integer 'Arreglo para verificar a quien le pertenece cada boton (Jugador = 1 | PC = 2)
    Dim turno As Integer 'Verifica cuantos turnos lleva el jugador (Máximo 5 turnos posibles)
    Dim tiempo As Integer 'Variable para el tiempo
    Dim marcadorx As Integer 'Marcador de puntos x, jugador 1
    Dim marcadoro As Integer 'Marcador de puntos o, jugador 2



    Sub juego1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Asignación de los botones del tablero
        btn(1) = btn1
        btn(2) = btn2
        btn(3) = btn3
        btn(4) = btn4
        btn(5) = btn5
        btn(6) = btn6
        btn(7) = btn7
        btn(8) = btn8
        btn(9) = btn9
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        jugador(1)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        jugador(2)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        jugador(3)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        jugador(4)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        jugador(5)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        jugador(6)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        jugador(7)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        jugador(8)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        jugador(9)
    End Sub
    Private Sub jugador(num As Integer)
        turno = turno + 1 'Incrementa el turno (Solo el turno del jugador)
        btn(num).Text = "X"
        boton(num) = 2 'Esto indica que ahora ese boton le pertenece al jugador (Jugador = 1 | PC = 2)
        btn(num).Enabled = False 'Desactiva el boton 
        If (turno < 5) Then
            PC()
        Else
            MsgBox("Fue empate, nadie gano")
            yesnomsg()
        End If
    End Sub
    Private Sub PC()
        Dim rn As New Random 'Nos sirve para escoger un numero al azar
        Dim num As Integer

        Do
            num = rn.Next(1, 10) 'Escoge un número al azar del 1 al 9

        Loop While boton(num) <> 0 'El ciclo se repetirá hasta que encuentre un boton desocupado

        btn(num).Text = "O"
        boton(num) = 1 'Esto indica que ahora ese boton le pertenece a la computadora (Jugador = 1 | PC = 2)
        btn(num).Enabled = False 'Desactiva el boton 
        ganador()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempo = tiempo + 1
        lblTiempo.Text = tiempo

    End Sub


    Private Sub ganador()
        If (boton(1) = 1 And boton(2) = 1 And boton(3) = 1) Then 'Comienza a encadenarse una serie de condiciones para para decidir quien es el ganador
            MsgBox("Suerte para la proxima, el ganador es la computadora")
            marcadoro = marcadoro + 1
            marco.Text = marcadoro 'Esto aumenta el marcador de la computadora
            btn1.BackColor = Color.Red
            btn2.BackColor = Color.Red
            btn3.BackColor = Color.Red
            yesnomsg()
        ElseIf (boton(4) = 1 And boton(5) = 1 And boton(6) = 1) Then
            MsgBox("Suerte para la proxima, el ganador es la computadora")
            marcadoro = marcadoro + 1
            marco.Text = marcadoro
            btn4.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn6.BackColor = Color.Red
            yesnomsg()
        ElseIf (boton(7) = 1 And boton(8) = 1 And boton(9) = 1) Then
            MsgBox("Suerte para la proxima, el ganador es la computadora")
            marcadoro = marcadoro + 1
            marco.Text = marcadoro
            btn7.BackColor = Color.Red
            btn8.BackColor = Color.Red
            btn9.BackColor = Color.Red
            yesnomsg()
        ElseIf (boton(1) = 1 And boton(4) = 1 And boton(7) = 1) Then
            MsgBox("Suerte para la proxima, el ganador es la computadora")
            btn1.BackColor = Color.Red
            btn4.BackColor = Color.Red
            btn7.BackColor = Color.Red
            yesnomsg()
        ElseIf (boton(2) = 1 And boton(5) = 1 And boton(8) = 1) Then
            MsgBox("Suerte para la proxima, el ganador es la computadora")
            marcadoro = marcadoro + 1
            marco.Text = marcadoro
            btn1.BackColor = Color.Red
            btn4.BackColor = Color.Red
            btn7.BackColor = Color.Red
            yesnomsg()
        ElseIf (boton(3) = 1 And boton(6) = 1 And boton(9) = 1) Then
            MsgBox("Suerte para la proxima, el ganador es la computadora")
            marcadoro = marcadoro + 1
            marco.Text = marcadoro
            btn3.BackColor = Color.Red
            btn6.BackColor = Color.Red
            btn9.BackColor = Color.Red
            yesnomsg()
        ElseIf (boton(1) = 1 And boton(5) = 1 And boton(9) = 1) Then
            MsgBox("Suerte para la proxima, el ganador es la computadora")
            marcadoro = marcadoro + 1
            marco.Text = marcadoro
            btn1.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn9.BackColor = Color.Red
            yesnomsg()
        ElseIf (boton(3) = 1 And boton(5) = 1 And boton(7) = 1) Then
            MsgBox("Suerte para la proxima, el ganador es la computadora")
            marcadoro = marcadoro + 1
            marco.Text = marcadoro
            btn3.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn7.BackColor = Color.Red
            yesnomsg()
        ElseIf (boton(1) = 2 And boton(2) = 2 And boton(3) = 2) Then
            MsgBox("Felicidades, ganaste")
            btn1.BackColor = Color.Green
            btn2.BackColor = Color.Green
            btn3.BackColor = Color.Green
            marcadorx = marcadorx + 1 'Esto aumenta el marcador del marcador del jugador 1
            marcx.Text = marcadorx
            yesnomsg()
        ElseIf (boton(4) = 2 And boton(5) = 2 And boton(6) = 2) Then
            MsgBox("Felicidades, ganaste")
            btn4.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn6.BackColor = Color.Green
            marcadorx = marcadorx + 1
            marcx.Text = marcadorx
            yesnomsg()
        ElseIf (boton(7) = 2 And boton(8) = 2 And boton(9) = 2) Then
            MsgBox("Felicidades, ganaste")
            btn7.BackColor = Color.Green
            btn8.BackColor = Color.Green
            btn9.BackColor = Color.Green
            marcadorx = marcadorx + 1
            marcx.Text = marcadorx
            yesnomsg()
        ElseIf (boton(1) = 2 And boton(4) = 2 And boton(7) = 2) Then
            MsgBox("Felicidades, ganaste")
            btn1.BackColor = Color.Green
            btn4.BackColor = Color.Green
            btn7.BackColor = Color.Green
            marcadorx = marcadorx + 1
            marcx.Text = marcadorx
            yesnomsg()
        ElseIf (boton(2) = 2 And boton(5) = 2 And boton(8) = 2) Then
            MsgBox("Felicidades, ganaste")
            btn2.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn8.BackColor = Color.Green
            marcadorx = marcadorx + 1
            marcx.Text = marcadorx
            yesnomsg()
        ElseIf (boton(3) = 2 And boton(6) = 2 And boton(9) = 2) Then
            MsgBox("Felicidades, ganaste")
            btn3.BackColor = Color.Green
            btn6.BackColor = Color.Green
            btn9.BackColor = Color.Green
            marcadorx = marcadorx + 1
            marcx.Text = marcadorx
            yesnomsg()
        ElseIf (boton(1) = 2 And boton(5) = 2 And boton(9) = 2) Then
            MsgBox("Felicidades, ganaste")
            btn1.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn9.BackColor = Color.Green
            marcadorx = marcadorx + 1
            marcx.Text = marcadorx
            yesnomsg()
        ElseIf (boton(3) = 2 And boton(5) = 2 And boton(7) = 2) Then
            MsgBox("Felicidades, ganaste")
            btn3.BackColor = Color.Green
            btn5.BackColor = Color.Green
            btn7.BackColor = Color.Green
            marcadorx = marcadorx + 1
            marcx.Text = marcadorx
            yesnomsg()
        End If
    End Sub
    Sub yesnomsg()
        Dim i As String
        Dim j As String
        i = "¿Desea jugar la siguiente ronda?"
        Label3.Text = Label3.Text + 1 'aumentar el numero de rondas en pantala
        If Label3.Text = 5 Then 'Existe un maximo de rondas para no hacer monotono el juego
            MsgBox("maximo de rondas alcanzadas")
            End
        Else
            j = MsgBox(i, vbQuestion + vbYesNo, "Fin de la ronda")
            If j = vbNo Then
                frmMenu.Show()
                Me.Close()

            Else
                For x As Integer = 1 To 9
                    btn(x).Text = ""
                    btn(x).Enabled = True
                    btn(x).BackColor = Color.White
                    boton(x) = "0"
                Next
                turno = 0
            End If
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        Juego2.Show()
        Me.Close()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)
        matriz.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMenu.Show()
        Me.Close()
    End Sub
End Class