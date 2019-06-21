Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Licencia
    Private Sub btInsertar_Click(sender As Object, e As EventArgs) Handles btInsertar.Click
        If EntradaLi.Equals(My.Settings.Serial) Then
            MsgBox("Registrado")
            My.Settings.Registro = True
            My.Settings.Save()
            Me.Close()
            Form1.ShowDialog()
            Me.Hide()
        Else
            MsgBox("Hash Invalido")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abrir As New OpenFileDialog

        abrir.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        abrir.Filter = "Files|*.*"
        If (abrir.ShowDialog() = DialogResult.OK) Then
            Dim nombre As String = abrir.FileName
            Me.ConteLic.LoadFile(abrir.FileName, RichTextBoxStreamType.PlainText)

            MsgBox(abrir.FileName)



        End If

    End Sub

    Private Function encriptar(ByVal cadena As String) As String
        Dim resultado As String = String.Empty
        Dim encriptarC As Byte() = Encoding.Unicode.GetBytes(cadena)
        resultado = Convert.ToBase64String(encriptarC)
        Return resultado

    End Function

    Private Function descifrar(ByVal cadena As String) As String
        Dim resultado As String = String.Empty
        Dim desc As Byte() = Convert.FromBase64String(cadena)
        resultado = Encoding.Unicode.GetString(desc)
        Return resultado
    End Function
    Private Sub BtDescifrar_Click(sender As Object, e As EventArgs) Handles BtDescifrar.Click
        Me.ConteLic.Text = descifrar(Me.ConteLic.Text)
    End Sub

    Private Sub BtCifrar_Click(sender As Object, e As EventArgs) Handles BtCifrar.Click
        BtCifrar.Visible = False

        Me.ConteLic.Text = encriptar(Me.ConteLic.Text)


    End Sub

    Private Sub Btguardar_Click(sender As Object, e As EventArgs) Handles Btguardar.Click
        Btguardar.Visible = False

        Dim grabar As SaveFileDialog = New SaveFileDialog()
        grabar.Filter = "Archivo|*.*"

        If grabar.ShowDialog() = DialogResult.OK Then

            Using escribir As StreamWriter = New StreamWriter(grabar.FileName)
                escribir.Write(Me.ConteLic.Text)
            End Using
        End If


    End Sub


End Class