Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmJefe
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub frmJefe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Personal' Puede moverla o quitarla según sea necesario.
    'Me.PersonalTableAdapter.Fill(Me.Merca_plusDataSet.Personal)
    'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Departamento' Puede moverla o quitarla según sea necesario.
    'Me.DepartamentoTableAdapter.Fill(Me.Merca_plusDataSet.Departamento)
    'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Cargo' Puede moverla o quitarla según sea necesario.
    'Me.CargoTableAdapter.Fill(Me.Merca_plusDataSet.Cargo)

    'End Sub







    Private Sub TabPage3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim f2 As New Form2
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim f2 As New Form2
        f2.Show()
        Me.Hide()
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        If TabControl1.SelectedIndex = 0 Then
            Me.Size = New Size(970, 359)
            TabControl1.Size = New Size(932, 298)
        End If
        If TabControl1.SelectedIndex = 1 Then
            Me.Size = New Size(970, 505)
            TabControl1.Size = New Size(932, 444)
            ImprimirPersonal()
        End If
    End Sub

    Private Sub btnEliminarPer_Click(sender As Object, e As EventArgs) Handles btnEliminarPer.Click
        Dim act As String = "Eliminar"
        Dim conexion As String
        conexion = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()

        Dim comando As New SqlCommand("delete from Personal where ID_personal = '" & TextBox7.Text & "' ", cn)
        comando.ExecuteNonQuery()
        dgvListadoPer.Rows.Remove(dgvListadoPer.CurrentRow)
        MsgBox("Se eliminaron correctamente")
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox8.Text = ""
        cn.Close()
    End Sub
    Private Sub btnActualizarPer_Click(sender As Object, e As EventArgs) Handles btnActualizarPer.Click
        Dim act As String = "Actualizar"
        Dim conexion As String
        conexion = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlCommand("update Personal set contraseña ='" & TextBox5.Text & "',
                                                                          Nombre ='" & TextBox4.Text & "',
                                                                     Apellido ='" & TextBox6.Text & "',
                                                                     sexo = '" & ComboBox5.Text & "',
                                                                    turno_D = '" & ComboBox6.Text & "', 
                                                                ID_Cargo = '" & ComboBox7.Text & "',
                                                                            ID_Departamento =  '" & ComboBox8.Text & "'
                                                                 where ID_Personal = " & TextBox7.Text & "", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Dato actualizado correctamente")
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox8.Text = ""



        Dim conexion1 As String
        conexion1 = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1

        Dim sqll As String
        sqll = "Select * From Personal"
        Dim adapt As New SqlDataAdapter(sqll, cn1)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "ID_personal")
        dgvListadoPer.DataSource = obtenerdatos
        dgvListadoPer.DataMember = "ID_personal"
    End Sub

    Private Sub btnAgregarPer_Click(sender As Object, e As EventArgs) Handles btnAgregarPer.Click
        per(1)
    End Sub
    Private Sub dgvListadoPer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPer.CellContentClick
        Dim i As Integer
        i = dgvListadoPer.CurrentRow.Index
        Me.TextBox7.Text = dgvListadoPer.Item(0, i).Value
        Me.TextBox5.Text = dgvListadoPer.Item(1, i).Value
        Me.TextBox4.Text = dgvListadoPer.Item(2, i).Value
        Me.TextBox6.Text = dgvListadoPer.Item(3, i).Value
        Me.ComboBox5.Text = dgvListadoPer.Item(4, i).Value
        Me.ComboBox6.Text = dgvListadoPer.Item(5, i).Value
        Me.ComboBox7.Text = dgvListadoPer.Item(6, i).Value
        Me.ComboBox8.Text = dgvListadoPer.Item(7, i).Value


    End Sub

    Private Sub frmJefe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Personal' Puede moverla o quitarla según sea necesario.
        'Me.PersonalTableAdapter.Fill(Me.Merca_plusDataSet.Personal)
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Personal' Puede moverla o quitarla según sea necesario.
        ' Me.PersonalTableAdapter.Fill(Me.Merca_plusDataSet.Personal)
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Personal' Puede moverla o quitarla según sea necesario.
        ' Me.PersonalTableAdapter.Fill(Me.Merca_plusDataSet.Personal)

    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        MsgBox("Primera pestaña: permite ingresar una persona nueva en el listado del personal" & vbNewLine & "Segunda pestaña: Seleccionando en la tabla una fila, se podrá actualizar algun campo o eliminarla")
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class