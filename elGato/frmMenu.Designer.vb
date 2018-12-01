<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblJugar = New System.Windows.Forms.Label()
        Me.lblMulti = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.dibujar = New System.Windows.Forms.Timer(Me.components)
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(255, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 127)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "El Gato"
        '
        'lblJugar
        '
        Me.lblJugar.AutoSize = True
        Me.lblJugar.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugar.Location = New System.Drawing.Point(298, 162)
        Me.lblJugar.Name = "lblJugar"
        Me.lblJugar.Size = New System.Drawing.Size(179, 50)
        Me.lblJugar.TabIndex = 1
        Me.lblJugar.Text = "    Jugar"
        '
        'lblMulti
        '
        Me.lblMulti.AutoSize = True
        Me.lblMulti.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMulti.Location = New System.Drawing.Point(228, 237)
        Me.lblMulti.Name = "lblMulti"
        Me.lblMulti.Size = New System.Drawing.Size(336, 50)
        Me.lblMulti.TabIndex = 2
        Me.lblMulti.Text = "    MultiJugador"
        '
        'btn1
        '
        Me.btn1.Enabled = False
        Me.btn1.Location = New System.Drawing.Point(66, 134)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(10, 147)
        Me.btn1.TabIndex = 3
        Me.btn1.UseVisualStyleBackColor = True
        Me.btn1.Visible = False
        '
        'btn2
        '
        Me.btn2.Enabled = False
        Me.btn2.Location = New System.Drawing.Point(127, 134)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(10, 148)
        Me.btn2.TabIndex = 5
        Me.btn2.UseVisualStyleBackColor = True
        Me.btn2.Visible = False
        '
        'btn3
        '
        Me.btn3.Enabled = False
        Me.btn3.Location = New System.Drawing.Point(25, 181)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(153, 11)
        Me.btn3.TabIndex = 6
        Me.btn3.UseVisualStyleBackColor = True
        Me.btn3.Visible = False
        '
        'btn4
        '
        Me.btn4.Enabled = False
        Me.btn4.Location = New System.Drawing.Point(24, 228)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(154, 11)
        Me.btn4.TabIndex = 7
        Me.btn4.UseVisualStyleBackColor = True
        Me.btn4.Visible = False
        '
        'dibujar
        '
        Me.dibujar.Enabled = True
        Me.dibujar.Interval = 500
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(134, 139)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(44, 39)
        Me.lbl5.TabIndex = 8
        Me.lbl5.Text = "O"
        Me.lbl5.Visible = False
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(28, 238)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(40, 39)
        Me.lbl6.TabIndex = 9
        Me.lbl6.Text = "X"
        Me.lbl6.Visible = False
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.Location = New System.Drawing.Point(24, 139)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(44, 39)
        Me.lbl7.TabIndex = 10
        Me.lbl7.Text = "O"
        Me.lbl7.Visible = False
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.Location = New System.Drawing.Point(82, 139)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(40, 39)
        Me.lbl8.TabIndex = 11
        Me.lbl8.Text = "X"
        Me.lbl8.Visible = False
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.Location = New System.Drawing.Point(137, 238)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(44, 39)
        Me.lbl9.TabIndex = 12
        Me.lbl9.Text = "O"
        Me.lbl9.Visible = False
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.Location = New System.Drawing.Point(137, 190)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(40, 39)
        Me.lbl10.TabIndex = 13
        Me.lbl10.Text = "X"
        Me.lbl10.Visible = False
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.Location = New System.Drawing.Point(82, 190)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(44, 39)
        Me.lbl11.TabIndex = 14
        Me.lbl11.Text = "O"
        Me.lbl11.Visible = False
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWin.Location = New System.Drawing.Point(8, 98)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(219, 33)
        Me.lblWin.TabIndex = 15
        Me.lblWin.Text = "¡Jugador uno gana!"
        Me.lblWin.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 31)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "    Calculadora Matrices"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(707, 374)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblMulti)
        Me.Controls.Add(Me.lblJugar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.Text = "Menú"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents lblJugar As Label

    Private Sub lblJugar_Click(sender As Object, e As EventArgs) Handles lblJugar.Click

        juego1.Show()
        Me.Close()

    End Sub

    Private Sub lblJugar_MouseMove(sender As Object, e As MouseEventArgs) Handles lblJugar.MouseMove
        lblJugar.Text = ">> Jugar <<"
    End Sub

    Private Sub lblJugar_MouseLeave(sender As Object, e As EventArgs) Handles lblJugar.MouseLeave
        lblJugar.Text = "    Jugar"
    End Sub


    Friend WithEvents lblMulti As Label

    Private Sub lblMulti_MouseMove(sender As Object, e As EventArgs) Handles lblMulti.MouseMove
        lblMulti.Text = ">> MultiJugador <<"
    End Sub
    Private Sub lblMulti_MouseLeave(sender As Object, e As EventArgs) Handles lblMulti.MouseLeave
        lblMulti.Text = "    MultiJugador"
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents dibujar As Timer

    Dim cont As Integer
    Private Sub dibujar_Tick(sender As Object, e As EventArgs) Handles dibujar.Tick
        cont = cont + 1
        Select Case cont
            Case 1
                btn1.Visible = True
            Case 2
                btn2.Visible = True
            Case 3
                btn3.Visible = True
            Case 4
                btn4.Visible = True
            Case 5
                lbl5.Visible = True
            Case 6
                lbl6.Visible = True
            Case 7
                lbl7.Visible = True
            Case 8
                lbl8.Visible = True
            Case 9
                lbl9.Visible = True
            Case 10
                lbl10.Visible = True
            Case 11
                lbl11.Visible = True
            Case 12
                lblWin.Visible = True
                lbl7.ForeColor = Color.Red
                lbl11.ForeColor = Color.Red
                lbl9.ForeColor = Color.Red

            Case 15
                lblWin.Visible = False
                btn1.Visible = False
                btn2.Visible = False
                btn2.Visible = False
                btn3.Visible = False
                btn4.Visible = False
                lbl5.Visible = False
                lbl6.Visible = False
                lbl7.Visible = False
                lbl8.Visible = False
                lbl9.Visible = False
                lbl10.Visible = False
                lbl11.Visible = False
                lbl7.ForeColor = Color.Black
                lbl11.ForeColor = Color.Black
                lbl9.ForeColor = Color.Black
                cont = 0
        End Select
    End Sub

    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents lblWin As Label
    Friend WithEvents Label2 As Label

End Class
