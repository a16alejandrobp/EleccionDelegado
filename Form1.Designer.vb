<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Candidatos = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Votados = New System.Windows.Forms.ListBox()
        Me.Votos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(171, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(141, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Candidatos
        '
        Me.Candidatos.FormattingEnabled = True
        Me.Candidatos.Location = New System.Drawing.Point(15, 66)
        Me.Candidatos.Name = "Candidatos"
        Me.Candidatos.Size = New System.Drawing.Size(120, 173)
        Me.Candidatos.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Votados
        '
        Me.Votados.FormattingEnabled = True
        Me.Votados.Location = New System.Drawing.Point(171, 66)
        Me.Votados.Name = "Votados"
        Me.Votados.Size = New System.Drawing.Size(120, 173)
        Me.Votados.TabIndex = 5
        '
        'Votos
        '
        Me.Votos.FormattingEnabled = True
        Me.Votos.Location = New System.Drawing.Point(290, 66)
        Me.Votos.Name = "Votos"
        Me.Votos.Size = New System.Drawing.Size(40, 173)
        Me.Votos.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Resultado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Delegado/a:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Subdelegado/a:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Primero/a"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Segundo/a"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(255, 26)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Calcular"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 350)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Votos)
        Me.Controls.Add(Me.Votados)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Candidatos)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Elección Delegado/a"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Candidatos As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Votados As ListBox
    Friend WithEvents Votos As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button4 As Button
End Class
