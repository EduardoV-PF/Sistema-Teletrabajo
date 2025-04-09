Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmEmpleado


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim act As String = "Agregar"
        Dim conexion As String
        conexion = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("insert into Productos values(
                                                                    '" & TextBox2.Text & "',
                                                                    '" & TextBox3.Text & "',
                                                                    " & TextBox4.Text & ",
                                                                     " & TextBox5.Text & ",
                                                                     " & ComboBox3.Text & ",
                                                                     " & ComboBox4.Text & ",
                                                                     '" & TextBox8.Text & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        TextBox8.Text = ""
        MsgBox("Se registro exitosamente")

        cambio(1, act)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        For i As Integer = 0 To DataGridView2.Rows.Count()

        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        Dim act As String = "Actualizar"
        Dim conexion As String
        conexion = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlCommand("update Productos set Nombre =           '" & TextBox9.Text & "',
                                                                          Marca ='" & TextBox11.Text & "',
                                                                     Precio_Uni ='" & TextBox12.Text & "',
                                                                     Cantidad = '" & TextBox10.Text & "',
                                                                    ID_provedor ='" & TextBox13.Text & "', 
                                                                ID_Departamento ='" & TextBox14.Text & "',
                                                                            XP =  '" & TextBox15.Text & "'
                                                                 where ID_productos = " & TextBox7.Text & "", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Dato actualizado correctamente")
        TextBox7.Text = ""
        TextBox9.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox10.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""

        Dim conexion1 As String
        conexion1 = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1

        Dim sqll As String
        sqll = "Select * From Productos"
        Dim adapt As New SqlDataAdapter(sqll, cn1)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "ID_productos")
        DataGridView2.DataSource = obtenerdatos
        DataGridView2.DataMember = "ID_productos"
        cambio(1, act)
    End Sub

    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        'Me.DepartamentoTableAdapter.Fill(Me.Merca_plusDataSet.Departamento)
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Provedor' Puede moverla o quitarla según sea necesario.
        'Me.ProvedorTableAdapter.Fill(Me.Merca_plusDataSet.Provedor)
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.Fill(Me.Merca_plusDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        'Me.DepartamentoTableAdapter.Fill(Me.Merca_plusDataSet.Departamento)
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Provedor' Puede moverla o quitarla según sea necesario.
        'Me.ProvedorTableAdapter.Fill(Me.Merca_plusDataSet.Provedor)
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Departamento' Puede moverla o quitarla según sea necesario.
        'Me.DepartamentoTableAdapter.Fill(Me.Merca_plusDataSet.Departamento)
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Productos' Puede moverla o quitarla según sea necesario.
        'Me.ProductosTableAdapter.Fill(Me.Merca_plusDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Productos' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Departamento' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'Merca_plusDataSet.Provedor' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim act As String = "Eliminar"
        Dim conexion As String
        conexion = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()

        Dim comando As New SqlCommand("delete from Productos where ID_productos = " & TextBox7.Text & " ", cn)
        comando.ExecuteNonQuery()
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        MsgBox("Se eliminaron correctamente")
        cn.Close()
        cambio(1, act)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim f2 As New Form2
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim f2 As New Form2
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim conexion As String
        conexion = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlDataAdapter("SELECT TOP 1 ID_productos FROM Productos ORDER BY ID_productos DESC", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")


        If ds.Tables("datos").Rows.Count > 0 Then
            TextBox1.Text = ds.Tables("datos").Rows(0).Item(0)
        End If

        TextBox1.Text = Val(TextBox1.Text) + 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim conexion As String
        conexion = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlDataAdapter("SELECT * from Productos ", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        actualizarinventario(1)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        actualizarhistorial(1)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim i As Integer
        i = DataGridView2.CurrentRow.Index
        Me.TextBox7.Text = DataGridView2.Item(0, i).Value
        Me.TextBox9.Text = DataGridView2.Item(1, i).Value
        Me.TextBox11.Text = DataGridView2.Item(2, i).Value
        Me.TextBox12.Text = DataGridView2.Item(3, i).Value
        Me.TextBox10.Text = DataGridView2.Item(4, i).Value
        Me.TextBox13.Text = DataGridView2.Item(5, i).Value
        Me.TextBox14.Text = DataGridView2.Item(6, i).Value
        Me.TextBox15.Text = DataGridView2.Item(7, i).Value

    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        MsgBox("Primera pestaña: podrá ingresar nuevos productos" & vbNewLine & "Segunda pestaña: Visualizar la lista de productos" & vbNewLine & "Tercera pestaña: Se pueden eliminar y actualizar la lista de productos, clickeando sobre ellos en la tabla")
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

End Class


