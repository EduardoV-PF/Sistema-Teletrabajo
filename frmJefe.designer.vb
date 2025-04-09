<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJefe
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tpRegistrarPer = New System.Windows.Forms.TabPage()
        Me.btnAgregarPer = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpListadoPer = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnActualizarPer = New System.Windows.Forms.Button()
        Me.btnEliminarPer = New System.Windows.Forms.Button()
        Me.dgvListadoPer = New System.Windows.Forms.DataGridView()
        Me.IDpersonalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TurnoDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDcargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Merca_plusDataSet = New INICIAL.Merca_plusDataSet()
        Me.DepartamentoTableAdapter = New INICIAL.Merca_plusDataSetTableAdapters.DepartamentoTableAdapter()
        Me.IDpersonalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonalTableAdapter = New INICIAL.Merca_plusDataSetTableAdapters.PersonalTableAdapter()
        Me.DepartamentoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IinicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpRegistrarPer.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpListadoPer.SuspendLayout()
        CType(Me.dgvListadoPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Merca_plusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpRegistrarPer
        '
        Me.tpRegistrarPer.BackColor = System.Drawing.Color.SteelBlue
        Me.tpRegistrarPer.Controls.Add(Me.btnAgregarPer)
        Me.tpRegistrarPer.Controls.Add(Me.ComboBox4)
        Me.tpRegistrarPer.Controls.Add(Me.ComboBox3)
        Me.tpRegistrarPer.Controls.Add(Me.ComboBox2)
        Me.tpRegistrarPer.Controls.Add(Me.ComboBox1)
        Me.tpRegistrarPer.Controls.Add(Me.TextBox3)
        Me.tpRegistrarPer.Controls.Add(Me.TextBox2)
        Me.tpRegistrarPer.Controls.Add(Me.TextBox1)
        Me.tpRegistrarPer.Controls.Add(Me.Label8)
        Me.tpRegistrarPer.Controls.Add(Me.Label7)
        Me.tpRegistrarPer.Controls.Add(Me.Label6)
        Me.tpRegistrarPer.Controls.Add(Me.Label5)
        Me.tpRegistrarPer.Controls.Add(Me.Label4)
        Me.tpRegistrarPer.Controls.Add(Me.Label3)
        Me.tpRegistrarPer.Controls.Add(Me.Label2)
        Me.tpRegistrarPer.Cursor = System.Windows.Forms.Cursors.Default
        Me.tpRegistrarPer.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.tpRegistrarPer.Location = New System.Drawing.Point(4, 22)
        Me.tpRegistrarPer.Margin = New System.Windows.Forms.Padding(2)
        Me.tpRegistrarPer.Name = "tpRegistrarPer"
        Me.tpRegistrarPer.Padding = New System.Windows.Forms.Padding(2)
        Me.tpRegistrarPer.Size = New System.Drawing.Size(924, 418)
        Me.tpRegistrarPer.TabIndex = 3
        Me.tpRegistrarPer.Text = "Registrar Colaborador  al Sistema"
        '
        'btnAgregarPer
        '
        Me.btnAgregarPer.BackColor = System.Drawing.Color.GreenYellow
        Me.btnAgregarPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPer.Location = New System.Drawing.Point(422, 196)
        Me.btnAgregarPer.Name = "btnAgregarPer"
        Me.btnAgregarPer.Size = New System.Drawing.Size(108, 48)
        Me.btnAgregarPer.TabIndex = 15
        Me.btnAgregarPer.Text = "Agregar"
        Me.btnAgregarPer.UseVisualStyleBackColor = False
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Matutino", "Diurno", "Nocturno"})
        Me.ComboBox4.Location = New System.Drawing.Point(614, 31)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(110, 21)
        Me.ComboBox4.TabIndex = 14
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700"})
        Me.ComboBox3.Location = New System.Drawing.Point(614, 116)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(110, 21)
        Me.ComboBox3.TabIndex = 13
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBox2.Location = New System.Drawing.Point(614, 76)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(110, 21)
        Me.ComboBox2.TabIndex = 12
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.ComboBox1.Location = New System.Drawing.Point(214, 154)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(103, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(214, 116)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(103, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(214, 72)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(103, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(214, 31)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(103, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(483, 119)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(483, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Turno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(483, 75)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cargo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(113, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(113, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(113, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(113, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpRegistrarPer)
        Me.TabControl1.Controls.Add(Me.tpListadoPer)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Location = New System.Drawing.Point(11, 34)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(932, 444)
        Me.TabControl1.TabIndex = 0
        '
        'tpListadoPer
        '
        Me.tpListadoPer.BackColor = System.Drawing.Color.SteelBlue
        Me.tpListadoPer.Controls.Add(Me.Label17)
        Me.tpListadoPer.Controls.Add(Me.TextBox7)
        Me.tpListadoPer.Controls.Add(Me.ComboBox8)
        Me.tpListadoPer.Controls.Add(Me.ComboBox7)
        Me.tpListadoPer.Controls.Add(Me.ComboBox6)
        Me.tpListadoPer.Controls.Add(Me.ComboBox5)
        Me.tpListadoPer.Controls.Add(Me.TextBox6)
        Me.tpListadoPer.Controls.Add(Me.TextBox5)
        Me.tpListadoPer.Controls.Add(Me.Label16)
        Me.tpListadoPer.Controls.Add(Me.Label15)
        Me.tpListadoPer.Controls.Add(Me.Label14)
        Me.tpListadoPer.Controls.Add(Me.Label13)
        Me.tpListadoPer.Controls.Add(Me.TextBox4)
        Me.tpListadoPer.Controls.Add(Me.Label12)
        Me.tpListadoPer.Controls.Add(Me.Label11)
        Me.tpListadoPer.Controls.Add(Me.Label10)
        Me.tpListadoPer.Controls.Add(Me.Label9)
        Me.tpListadoPer.Controls.Add(Me.Label1)
        Me.tpListadoPer.Controls.Add(Me.btnActualizarPer)
        Me.tpListadoPer.Controls.Add(Me.btnEliminarPer)
        Me.tpListadoPer.Controls.Add(Me.dgvListadoPer)
        Me.tpListadoPer.Location = New System.Drawing.Point(4, 22)
        Me.tpListadoPer.Name = "tpListadoPer"
        Me.tpListadoPer.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListadoPer.Size = New System.Drawing.Size(924, 418)
        Me.tpListadoPer.TabIndex = 4
        Me.tpListadoPer.Text = "Listado del Personal"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(177, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 15)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "ID Personal:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(257, 271)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 19
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(538, 306)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox8.TabIndex = 18
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(281, 372)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox7.TabIndex = 17
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(281, 340)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox6.TabIndex = 16
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(281, 303)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(85, 372)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(107, 20)
        Me.TextBox6.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(85, 340)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(107, 20)
        Me.TextBox5.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(428, 306)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 15)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "ID Departamento:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(224, 375)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 15)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "ID Cargo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(224, 342)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 15)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Turno:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(224, 306)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 15)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Sexo:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(85, 303)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(107, 20)
        Me.TextBox4.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 373)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 15)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Apellido:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Nombre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 306)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Contraseña:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(275, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Campos a actualizar:"
        '
        'btnActualizarPer
        '
        Me.btnActualizarPer.BackColor = System.Drawing.Color.YellowGreen
        Me.btnActualizarPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarPer.Location = New System.Drawing.Point(563, 343)
        Me.btnActualizarPer.Name = "btnActualizarPer"
        Me.btnActualizarPer.Size = New System.Drawing.Size(75, 50)
        Me.btnActualizarPer.TabIndex = 2
        Me.btnActualizarPer.Text = "Actualizar"
        Me.btnActualizarPer.UseVisualStyleBackColor = False
        '
        'btnEliminarPer
        '
        Me.btnEliminarPer.BackColor = System.Drawing.Color.Red
        Me.btnEliminarPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPer.Location = New System.Drawing.Point(832, 109)
        Me.btnEliminarPer.Name = "btnEliminarPer"
        Me.btnEliminarPer.Size = New System.Drawing.Size(70, 50)
        Me.btnEliminarPer.TabIndex = 1
        Me.btnEliminarPer.Text = "Eliminar"
        Me.btnEliminarPer.UseVisualStyleBackColor = False
        '
        'dgvListadoPer
        '
        Me.dgvListadoPer.AllowUserToAddRows = False
        Me.dgvListadoPer.AutoGenerateColumns = False
        Me.dgvListadoPer.BackgroundColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListadoPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoPer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDpersonalDataGridViewTextBoxColumn1, Me.ContraseñaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.TurnoDDataGridViewTextBoxColumn, Me.IDcargoDataGridViewTextBoxColumn, Me.IDDepartamentoDataGridViewTextBoxColumn})
        Me.dgvListadoPer.DataSource = Me.PersonalBindingSource
        Me.dgvListadoPer.GridColor = System.Drawing.Color.Teal
        Me.dgvListadoPer.Location = New System.Drawing.Point(6, 6)
        Me.dgvListadoPer.Name = "dgvListadoPer"
        Me.dgvListadoPer.ReadOnly = True
        Me.dgvListadoPer.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPer.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoPer.RowHeadersVisible = False
        Me.dgvListadoPer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoPer.Size = New System.Drawing.Size(803, 256)
        Me.dgvListadoPer.TabIndex = 0
        '
        'IDpersonalDataGridViewTextBoxColumn1
        '
        Me.IDpersonalDataGridViewTextBoxColumn1.DataPropertyName = "ID_personal"
        Me.IDpersonalDataGridViewTextBoxColumn1.HeaderText = "ID_personal"
        Me.IDpersonalDataGridViewTextBoxColumn1.Name = "IDpersonalDataGridViewTextBoxColumn1"
        Me.IDpersonalDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        Me.ContraseñaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TurnoDDataGridViewTextBoxColumn
        '
        Me.TurnoDDataGridViewTextBoxColumn.DataPropertyName = "turno_D"
        Me.TurnoDDataGridViewTextBoxColumn.HeaderText = "turno_D"
        Me.TurnoDDataGridViewTextBoxColumn.Name = "TurnoDDataGridViewTextBoxColumn"
        Me.TurnoDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDcargoDataGridViewTextBoxColumn
        '
        Me.IDcargoDataGridViewTextBoxColumn.DataPropertyName = "ID_cargo"
        Me.IDcargoDataGridViewTextBoxColumn.HeaderText = "ID_cargo"
        Me.IDcargoDataGridViewTextBoxColumn.Name = "IDcargoDataGridViewTextBoxColumn"
        Me.IDcargoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDDepartamentoDataGridViewTextBoxColumn
        '
        Me.IDDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "ID_Departamento"
        Me.IDDepartamentoDataGridViewTextBoxColumn.HeaderText = "ID_Departamento"
        Me.IDDepartamentoDataGridViewTextBoxColumn.Name = "IDDepartamentoDataGridViewTextBoxColumn"
        Me.IDDepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "Personal"
        Me.PersonalBindingSource.DataSource = Me.Merca_plusDataSet
        '
        'Merca_plusDataSet
        '
        Me.Merca_plusDataSet.DataSetName = "Merca_plusDataSet"
        Me.Merca_plusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'IDpersonalDataGridViewTextBoxColumn
        '
        Me.IDpersonalDataGridViewTextBoxColumn.DataPropertyName = "ID_personal"
        Me.IDpersonalDataGridViewTextBoxColumn.HeaderText = "ID_personal"
        Me.IDpersonalDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDpersonalDataGridViewTextBoxColumn.Name = "IDpersonalDataGridViewTextBoxColumn"
        Me.IDpersonalDataGridViewTextBoxColumn.Width = 150
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IinicioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(954, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IinicioToolStripMenuItem
        '
        Me.IinicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.IinicioToolStripMenuItem.Name = "IinicioToolStripMenuItem"
        Me.IinicioToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.IinicioToolStripMenuItem.Text = "Iinicio"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'frmJefe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(954, 489)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmJefe"
        Me.Text = "Gerencia"
        Me.tpRegistrarPer.ResumeLayout(False)
        Me.tpRegistrarPer.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpListadoPer.ResumeLayout(False)
        Me.tpListadoPer.PerformLayout()
        CType(Me.dgvListadoPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Merca_plusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tpRegistrarPer As TabPage
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DepartamentoTableAdapter As Merca_plusDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents DepartamentoBindingSource2 As BindingSource
    Friend WithEvents IDpersonalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tpListadoPer As TabPage
    Friend WithEvents dgvListadoPer As DataGridView
    Friend WithEvents btnAgregarPer As Button
    Friend WithEvents btnEliminarPer As Button
    Friend WithEvents btnActualizarPer As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Merca_plusDataSet As Merca_plusDataSet
    Friend WithEvents PersonalBindingSource As BindingSource
    Friend WithEvents PersonalTableAdapter As Merca_plusDataSetTableAdapters.PersonalTableAdapter
    Friend WithEvents IDpersonalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TurnoDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDcargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IinicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
End Class
