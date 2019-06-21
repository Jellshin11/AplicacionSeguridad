Public Class Form1
    Private Sub BtListar_Click(sender As Object, e As EventArgs) Handles BtListar.Click
        ListBox1.Items.Clear()
        Dim desde, hasta As Double
        Dim contador As Integer = 0
        desde = Val(cajaentrada.Text)
        hasta = Val(cajaentrada1.Text)
        For i = desde To hasta
            For j = i To 0 Step -1
                If i Mod j = 0 Then
                    contador = contador + 1

                End If
            Next
            If contador = 2 Then
                ListBox1.Items.Add(i)
            End If
            contador = 0

        Next





    End Sub

    Private Sub BtBorrar_Click(sender As Object, e As EventArgs) Handles BtBorrar.Click
        cajaentrada.Text = ""
        cajaentrada1.Text = ""
        ListBox1.Items.Clear()





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Ingreso = False
        My.Settings.Registro = False


        If My.Settings.Registro = False Then
            If My.Settings.Ingreso = False Then
                MsgBox("Primer ingreso")
                Timer1.Start()
                fechaActu.Text = DateTime.Now
                My.Settings.Vencimiento = DateTime.Now.AddDays(10)

                My.Settings.Ingreso = True
                fechaVence.Text = My.Settings.Vencimiento
                My.Settings.Save()
            Else
                MsgBox("No es la primera Vez")
                Timer1.Start()
                fechaActu.Text = DateTime.Now

                fechaVence.Text = My.Settings.Vencimiento

            End If
        Else
            MsgBox("Activacion con exito")

        End If
    End Sub

    Public Sub actualizar()
        fechaActu.Text = DateTime.Now

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        actualizar()
        If DateTime.Now > My.Settings.Vencimiento Then
            Me.Hide()
            Licencia.show()
            Timer1.Stop()




        End If

    End Sub
End Class
