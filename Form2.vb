Public Class Form2
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If usuarioRegistrado(TextBox1.Text) = True Then
                Dim contra As String = contrasena(TextBox1.Text)
                If contra.Equals(TextBox2.Text) = True Then
                    Me.Hide()
                    Personalc = TextBox1.Text
                    If ConsultarTipoUsuario(TextBox1.Text) = 1 And ConsultarTipodepar(TextBox1.Text) = 100 Then
                        FrmEmpleado.ShowDialog()
                    ElseIf ConsultarTipoUsuario(TextBox1.Text) = 2 Then
                        frmAdministrador.ShowDialog()
                    ElseIf ConsultarTipoUsuario(TextBox1.Text) = 3 Then
                        frmJefe.ShowDialog()
                    Else
                        MsgBox("Debido al departamento donde pertenece no puede acceder al Sistema")
                    End If

                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El Usuario: " + TextBox1.Text + " no se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        MsgBox("Ingrese su usuario(ID Personal) y la contraseña correspondiente")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class