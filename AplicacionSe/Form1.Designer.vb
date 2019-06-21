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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtListar = New System.Windows.Forms.Button()
        Me.BtBorrar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fechaActu = New System.Windows.Forms.Label()
        Me.fechaVence = New System.Windows.Forms.Label()
        Me.cajaentrada = New System.Windows.Forms.TextBox()
        Me.cajaentrada1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'BtListar
        '
        Me.BtListar.Location = New System.Drawing.Point(506, 82)
        Me.BtListar.Name = "BtListar"
        Me.BtListar.Size = New System.Drawing.Size(75, 23)
        Me.BtListar.TabIndex = 0
        Me.BtListar.Text = "Listar"
        Me.BtListar.UseVisualStyleBackColor = True
        '
        'BtBorrar
        '
        Me.BtBorrar.Location = New System.Drawing.Point(506, 168)
        Me.BtBorrar.Name = "BtBorrar"
        Me.BtBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BtBorrar.TabIndex = 1
        Me.BtBorrar.Text = "Borrar"
        Me.BtBorrar.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(168, 129)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(246, 95)
        Me.ListBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingrese un Numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Actual:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha de Vencimiento:"
        '
        'fechaActu
        '
        Me.fechaActu.AutoSize = True
        Me.fechaActu.Location = New System.Drawing.Point(246, 301)
        Me.fechaActu.Name = "fechaActu"
        Me.fechaActu.Size = New System.Drawing.Size(39, 13)
        Me.fechaActu.TabIndex = 6
        Me.fechaActu.Text = "Label4"
        '
        'fechaVence
        '
        Me.fechaVence.AutoSize = True
        Me.fechaVence.Location = New System.Drawing.Point(246, 338)
        Me.fechaVence.Name = "fechaVence"
        Me.fechaVence.Size = New System.Drawing.Size(39, 13)
        Me.fechaVence.TabIndex = 7
        Me.fechaVence.Text = "Label5"
        '
        'cajaentrada
        '
        Me.cajaentrada.Location = New System.Drawing.Point(194, 58)
        Me.cajaentrada.Name = "cajaentrada"
        Me.cajaentrada.Size = New System.Drawing.Size(100, 20)
        Me.cajaentrada.TabIndex = 8
        '
        'cajaentrada1
        '
        Me.cajaentrada1.Location = New System.Drawing.Point(194, 103)
        Me.cajaentrada1.Name = "cajaentrada1"
        Me.cajaentrada1.Size = New System.Drawing.Size(100, 20)
        Me.cajaentrada1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Desde"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Hasta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 360)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cajaentrada1)
        Me.Controls.Add(Me.cajaentrada)
        Me.Controls.Add(Me.fechaVence)
        Me.Controls.Add(Me.fechaActu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtBorrar)
        Me.Controls.Add(Me.BtListar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtListar As Button
    Friend WithEvents BtBorrar As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fechaActu As Label
    Friend WithEvents fechaVence As Label
    Friend WithEvents cajaentrada As TextBox
    Friend WithEvents cajaentrada1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
