Class frmMenu
    Private Sub lblMulti_Click(sender As Object, e As EventArgs) Handles lblMulti.Click

        Juego2.Show()
        Me.Close()

    End Sub

    Private Sub lblMulti_MouseMove(sender As Object, e As MouseEventArgs) Handles lblMulti.MouseMove

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        matriz.Show()
        Me.Close()
    End Sub
End Class