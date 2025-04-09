Imports System.Data.Sql
Imports System.Data.SqlClient




Module Conexion
    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public Personalc As Integer
    Public fecha As DateTime = DateTime.Now



    Sub abrir()
        Try
            conexion = New SqlConnection("Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True")
            conexion.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select *from Personal where ID_personal = '" & nombreUsuario & "'", conexion)

            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If

            respuesta.Close()

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

        Return resultado

    End Function
    Function ImprimirPersonal() As Boolean
        Dim conexion As String
        conexion = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("Select * from Personal", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")
        frmJefe.dgvListadoPer.DataSource = ds
        frmJefe.dgvListadoPer.DataMember = "datos"
    End Function


    Function contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select contraseña from Personal where ID_personal='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("contraseña")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select ID_cargo from Personal where ID_personal='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("ID_cargo"))
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function ConsultarTipodepar(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("Select ID_Departamento from Personal where ID_personal='" & nombreUsuario & "'", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("ID_Departamento"))
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    Function per(band3 As Integer) As String

        Dim conexion As String
        conexion = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion


        Dim adaptador As New SqlCommand("insert into Personal(contraseña, Nombre, Apellido, sexo, turno_D, ID_Cargo, ID_Departamento) values('" & frmJefe.TextBox1.Text & "',
                                                                      '" & frmJefe.TextBox2.Text & "',
                                                                     '" & frmJefe.TextBox3.Text & "',
                                                                     '" & frmJefe.ComboBox1.Text & "',
                                                                     '" & frmJefe.ComboBox4.Text & "',
                                                                     '" & frmJefe.ComboBox2.Text & "',
                                                                     '" & frmJefe.ComboBox3.Text & "')", cn)

        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Se registro exitosamente")
        frmJefe.TextBox1.Text = ""
        frmJefe.TextBox2.Text = ""
        frmJefe.TextBox3.Text = ""
    End Function





    Function actualizarhistorial(band1 As Integer) As Integer
        Dim conexion1 As String
        conexion1 = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1


        Dim sqll As String
        sqll = "Select * From Productos"
        Dim adapt As New SqlDataAdapter(sqll, cn1)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "ID_productos")
        FrmEmpleado.DataGridView1.DataSource = obtenerdatos
        FrmEmpleado.DataGridView1.DataMember = "ID_productos"
    End Function


    Function actualizarinventario(band1 As Integer) As Integer
        Dim conexion1 As String
        conexion1 = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1


        Dim sqll As String
        sqll = "Select * From Productos"
        Dim adapt As New SqlDataAdapter(sqll, cn1)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "ID_productos")
        FrmEmpleado.DataGridView2.DataSource = obtenerdatos
        FrmEmpleado.DataGridView2.DataMember = "ID_productos"
    End Function

    Function super1(band3 As Integer) As Integer
        Dim conexion1 As String
        conexion1 = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1

        Dim sqll As String
        sqll = "Select * From Cambios"
        Dim adapt As New SqlDataAdapter(sqll, cn1)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "ID_personal")
        frmAdministrador.DataGridView2.DataSource = obtenerdatos
        frmAdministrador.DataGridView2.DataMember = "ID_personal"
    End Function

    Function super2(band4 As Integer) As Integer
        Dim conexion1 As String
        conexion1 = "Data Source=LAPTOP-GK03A61I;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn1 As New SqlConnection
        cn1.ConnectionString = conexion1


        Dim sqll As String
        sqll = "Select * From Productos"
        Dim adapt As New SqlDataAdapter(sqll, cn1)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "ID_productos")
        frmAdministrador.DataGridView1.DataSource = obtenerdatos
        frmAdministrador.DataGridView1.DataMember = "ID_productos"
    End Function


















    Function cambio(band11 As Integer, act As String) As String

        Dim tabla As String = "Productos"
        Dim conexion As String
        conexion = "Data Source=(localdb)\ELEGER;Initial Catalog=Merca_plus;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlCommand("insert into Cambios values(" & Personalc.ToString & ", 
                                                                    '" & act & "', 
                                                                    '" & tabla & "' ,
                                                                     '" & fecha & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()


    End Function

End Module
