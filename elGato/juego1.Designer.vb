<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class juego1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(juego1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.marco = New System.Windows.Forms.Label()
        Me.marcx = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cantidad de Rondas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(199, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(447, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(67, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 31)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Marcador:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label5.Location = New System.Drawing.Point(139, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 32)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "O"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label7.Location = New System.Drawing.Point(139, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 32)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "X"
        '
        'marco
        '
        Me.marco.AutoSize = True
        Me.marco.BackColor = System.Drawing.Color.MediumVioletRed
        Me.marco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.marco.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marco.Location = New System.Drawing.Point(181, 180)
        Me.marco.Name = "marco"
        Me.marco.Size = New System.Drawing.Size(32, 31)
        Me.marco.TabIndex = 30
        Me.marco.Text = "0"
        '
        'marcx
        '
        Me.marcx.AutoSize = True
        Me.marcx.BackColor = System.Drawing.Color.MediumVioletRed
        Me.marcx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.marcx.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marcx.Location = New System.Drawing.Point(181, 130)
        Me.marcx.Name = "marcx"
        Me.marcx.Size = New System.Drawing.Size(32, 31)
        Me.marcx.TabIndex = 29
        Me.marcx.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(84, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Tiempo:"
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTiempo.Location = New System.Drawing.Point(165, 324)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(20, 24)
        Me.lblTiempo.TabIndex = 27
        Me.lblTiempo.Text = "0"
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.White
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.Black
        Me.btn9.Location = New System.Drawing.Point(527, 229)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(80, 80)
        Me.btn9.TabIndex = 26
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.White
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.Black
        Me.btn8.Location = New System.Drawing.Point(427, 229)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(80, 80)
        Me.btn8.TabIndex = 25
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.White
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.Black
        Me.btn7.Location = New System.Drawing.Point(327, 229)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(80, 80)
        Me.btn7.TabIndex = 24
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.White
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.Black
        Me.btn6.Location = New System.Drawing.Point(527, 141)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(80, 80)
        Me.btn6.TabIndex = 23
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.White
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.Black
        Me.btn5.Location = New System.Drawing.Point(427, 141)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(80, 80)
        Me.btn5.TabIndex = 22
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.White
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.Black
        Me.btn4.Location = New System.Drawing.Point(327, 141)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(80, 80)
        Me.btn4.TabIndex = 21
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.White
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.Black
        Me.btn3.Location = New System.Drawing.Point(527, 52)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(80, 80)
        Me.btn3.TabIndex = 20
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.White
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.Black
        Me.btn2.Location = New System.Drawing.Point(427, 52)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(80, 80)
        Me.btn2.TabIndex = 19
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.White
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.Black
        Me.btn1.Location = New System.Drawing.Point(327, 52)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(80, 80)
        Me.btn1.TabIndex = 18
        Me.btn1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Enabled = False
        Me.Button4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button4.Location = New System.Drawing.Point(317, 45)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(302, 273)
        Me.Button4.TabIndex = 17
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(524, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 26)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'juego1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(663, 378)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.marco)
        Me.Controls.Add(Me.marcx)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "juego1"
        Me.Text = "Un jugador - El Gato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents marco As Label
    Friend WithEvents marcx As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTiempo As Label
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
End Class
