<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Licencia
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
        Me.EntradaLi = New System.Windows.Forms.TextBox()
        Me.btInsertar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtDescifrar = New System.Windows.Forms.Button()
        Me.ConteLic = New System.Windows.Forms.RichTextBox()
        Me.BtCifrar = New System.Windows.Forms.Button()
        Me.Btguardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EntradaLi
        '
        Me.EntradaLi.Location = New System.Drawing.Point(122, 66)
        Me.EntradaLi.Name = "EntradaLi"
        Me.EntradaLi.Size = New System.Drawing.Size(345, 20)
        Me.EntradaLi.TabIndex = 0
        '
        'btInsertar
        '
        Me.btInsertar.Location = New System.Drawing.Point(511, 63)
        Me.btInsertar.Name = "btInsertar"
        Me.btInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btInsertar.TabIndex = 1
        Me.btInsertar.Text = "Insertar"
        Me.btInsertar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Introducir Hash"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(122, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Abrir Archivo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtDescifrar
        '
        Me.BtDescifrar.Location = New System.Drawing.Point(122, 264)
        Me.BtDescifrar.Name = "BtDescifrar"
        Me.BtDescifrar.Size = New System.Drawing.Size(75, 23)
        Me.BtDescifrar.TabIndex = 4
        Me.BtDescifrar.Text = "Descifrar"
        Me.BtDescifrar.UseVisualStyleBackColor = True
        '
        'ConteLic
        '
        Me.ConteLic.Location = New System.Drawing.Point(247, 191)
        Me.ConteLic.Name = "ConteLic"
        Me.ConteLic.Size = New System.Drawing.Size(202, 96)
        Me.ConteLic.TabIndex = 5
        Me.ConteLic.Text = ""
        '
        'BtCifrar
        '
        Me.BtCifrar.Location = New System.Drawing.Point(495, 216)
        Me.BtCifrar.Name = "BtCifrar"
        Me.BtCifrar.Size = New System.Drawing.Size(75, 23)
        Me.BtCifrar.TabIndex = 7
        Me.BtCifrar.Text = "cifrar"
        Me.BtCifrar.UseVisualStyleBackColor = True
        Me.BtCifrar.Visible = False
        '
        'Btguardar
        '
        Me.Btguardar.Location = New System.Drawing.Point(495, 264)
        Me.Btguardar.Name = "Btguardar"
        Me.Btguardar.Size = New System.Drawing.Size(75, 23)
        Me.Btguardar.TabIndex = 8
        Me.Btguardar.Text = "Button2"
        Me.Btguardar.UseVisualStyleBackColor = True
        Me.Btguardar.Visible = False
        '
        'Licencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 326)
        Me.Controls.Add(Me.Btguardar)
        Me.Controls.Add(Me.BtCifrar)
        Me.Controls.Add(Me.ConteLic)
        Me.Controls.Add(Me.BtDescifrar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btInsertar)
        Me.Controls.Add(Me.EntradaLi)
        Me.Name = "Licencia"
        Me.Text = "Licencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EntradaLi As TextBox
    Friend WithEvents btInsertar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtDescifrar As Button
    Friend WithEvents ConteLic As RichTextBox
    Friend WithEvents BtCifrar As Button
    Friend WithEvents Btguardar As Button
End Class
