<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpleado
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Merca_plusDataSet = New INICIAL.Merca_plusDataSet()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ProvedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDproductosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDprovedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDproductosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUniDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDprovedorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDepartamentoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XPDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New INICIAL.Merca_plusDataSetTableAdapters.ProductosTableAdapter()
        Me.ProvedorTableAdapter = New INICIAL.Merca_plusDataSetTableAdapters.ProvedorTableAdapter()
        Me.DepartamentoTableAdapter = New INICIAL.Merca_plusDataSetTableAdapters.DepartamentoTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Merca_plusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1030, 342)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.ComboBox4)
        Me.TabPage1.Controls.Add(Me.ComboBox3)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TextBox8)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1022, 316)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ingreso de Productos"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(344, 59)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(111, 25)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "Generar ID"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.DepartamentoBindingSource
        Me.ComboBox4.DisplayMember = "ID_Departamento"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(588, 151)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox4.TabIndex = 18
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.Merca_plusDataSet
        '
        'Merca_plusDataSet
        '
        Me.Merca_plusDataSet.DataSetName = "Merca_plusDataSet"
        Me.Merca_plusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.ProvedorBindingSource
        Me.ComboBox3.DisplayMember = "ID_provedor"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(588, 110)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox3.TabIndex = 17
        '
        'ProvedorBindingSource
        '
        Me.ProvedorBindingSource.DataMember = "Provedor"
        Me.ProvedorBindingSource.DataSource = Me.Merca_plusDataSet
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GreenYellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(397, 234)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 69)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(588, 193)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(82, 20)
        Me.TextBox8.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(588, 62)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(82, 20)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(239, 193)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(82, 20)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(239, 151)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(82, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(239, 110)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(82, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(239, 62)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(82, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(479, 196)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha de Expiracion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(479, 154)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ID del Departemento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(479, 113)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ID Provedor  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(479, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(125, 196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio Unitario "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(123, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre del Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(125, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(123, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID del Producto"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1022, 316)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historial de Productos "
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(535, 275)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(53, 26)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(425, 267)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(57, 42)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDproductosDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.PrecioUniDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.IDprovedorDataGridViewTextBoxColumn, Me.IDDepartamentoDataGridViewTextBoxColumn, Me.XPDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(23, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(801, 242)
        Me.DataGridView1.TabIndex = 0
        '
        'IDproductosDataGridViewTextBoxColumn
        '
        Me.IDproductosDataGridViewTextBoxColumn.DataPropertyName = "ID_productos"
        Me.IDproductosDataGridViewTextBoxColumn.HeaderText = "ID_productos"
        Me.IDproductosDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDproductosDataGridViewTextBoxColumn.Name = "IDproductosDataGridViewTextBoxColumn"
        Me.IDproductosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioUniDataGridViewTextBoxColumn
        '
        Me.PrecioUniDataGridViewTextBoxColumn.DataPropertyName = "Precio_Uni"
        Me.PrecioUniDataGridViewTextBoxColumn.HeaderText = "Precio_Uni"
        Me.PrecioUniDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PrecioUniDataGridViewTextBoxColumn.Name = "PrecioUniDataGridViewTextBoxColumn"
        Me.PrecioUniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDprovedorDataGridViewTextBoxColumn
        '
        Me.IDprovedorDataGridViewTextBoxColumn.DataPropertyName = "ID_provedor"
        Me.IDprovedorDataGridViewTextBoxColumn.HeaderText = "ID_provedor"
        Me.IDprovedorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDprovedorDataGridViewTextBoxColumn.Name = "IDprovedorDataGridViewTextBoxColumn"
        Me.IDprovedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDDepartamentoDataGridViewTextBoxColumn
        '
        Me.IDDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "ID_Departamento"
        Me.IDDepartamentoDataGridViewTextBoxColumn.HeaderText = "ID_Departamento"
        Me.IDDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDDepartamentoDataGridViewTextBoxColumn.Name = "IDDepartamentoDataGridViewTextBoxColumn"
        Me.IDDepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'XPDataGridViewTextBoxColumn
        '
        Me.XPDataGridViewTextBoxColumn.DataPropertyName = "XP"
        Me.XPDataGridViewTextBoxColumn.HeaderText = "XP"
        Me.XPDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.XPDataGridViewTextBoxColumn.Name = "XPDataGridViewTextBoxColumn"
        Me.XPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductosBindingSource1
        '
        Me.ProductosBindingSource1.DataMember = "Productos"
        Me.ProductosBindingSource1.DataSource = Me.Merca_plusDataSet
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage3.Controls.Add(Me.TextBox15)
        Me.TabPage3.Controls.Add(Me.TextBox14)
        Me.TabPage3.Controls.Add(Me.TextBox13)
        Me.TabPage3.Controls.Add(Me.TextBox12)
        Me.TabPage3.Controls.Add(Me.TextBox11)
        Me.TabPage3.Controls.Add(Me.TextBox10)
        Me.TabPage3.Controls.Add(Me.TextBox9)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Button9)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.TabPage3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(1022, 316)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Inventario"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(103, 267)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(68, 20)
        Me.TextBox15.TabIndex = 59
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(103, 235)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(68, 20)
        Me.TextBox14.TabIndex = 58
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(103, 200)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(68, 20)
        Me.TextBox13.TabIndex = 57
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(103, 143)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(68, 20)
        Me.TextBox12.TabIndex = 56
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(103, 117)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(68, 20)
        Me.TextBox11.TabIndex = 55
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(103, 171)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(68, 20)
        Me.TextBox10.TabIndex = 55
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(103, 90)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(68, 20)
        Me.TextBox9.TabIndex = 54
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(103, 65)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(68, 20)
        Me.TextBox7.TabIndex = 53
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(-294, -66)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(68, 20)
        Me.TextBox6.TabIndex = 50
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 270)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "Fecha de exp."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 203)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 13)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "ID Proveedor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 174)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Cantidad"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 238)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "ID Departamento"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 120)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Marca"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 146)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Precio unitario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 93)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 68)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Id Productos"
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(614, 195)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(121, 29)
        Me.Button9.TabIndex = 42
        Me.Button9.Text = "Refrescar la tabla"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDproductosDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn1, Me.MarcaDataGridViewTextBoxColumn1, Me.PrecioUniDataGridViewTextBoxColumn1, Me.CantidadDataGridViewTextBoxColumn1, Me.IDprovedorDataGridViewTextBoxColumn1, Me.IDDepartamentoDataGridViewTextBoxColumn1, Me.XPDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.ProductosBindingSource3
        Me.DataGridView2.Location = New System.Drawing.Point(185, 41)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 62
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(803, 136)
        Me.DataGridView2.TabIndex = 41
        '
        'IDproductosDataGridViewTextBoxColumn1
        '
        Me.IDproductosDataGridViewTextBoxColumn1.DataPropertyName = "ID_productos"
        Me.IDproductosDataGridViewTextBoxColumn1.HeaderText = "ID_productos"
        Me.IDproductosDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.IDproductosDataGridViewTextBoxColumn1.Name = "IDproductosDataGridViewTextBoxColumn1"
        Me.IDproductosDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MarcaDataGridViewTextBoxColumn1
        '
        Me.MarcaDataGridViewTextBoxColumn1.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.MarcaDataGridViewTextBoxColumn1.Name = "MarcaDataGridViewTextBoxColumn1"
        Me.MarcaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PrecioUniDataGridViewTextBoxColumn1
        '
        Me.PrecioUniDataGridViewTextBoxColumn1.DataPropertyName = "Precio_Uni"
        Me.PrecioUniDataGridViewTextBoxColumn1.HeaderText = "Precio_Uni"
        Me.PrecioUniDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.PrecioUniDataGridViewTextBoxColumn1.Name = "PrecioUniDataGridViewTextBoxColumn1"
        Me.PrecioUniDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn1
        '
        Me.CantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.CantidadDataGridViewTextBoxColumn1.Name = "CantidadDataGridViewTextBoxColumn1"
        Me.CantidadDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IDprovedorDataGridViewTextBoxColumn1
        '
        Me.IDprovedorDataGridViewTextBoxColumn1.DataPropertyName = "ID_provedor"
        Me.IDprovedorDataGridViewTextBoxColumn1.HeaderText = "ID_provedor"
        Me.IDprovedorDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.IDprovedorDataGridViewTextBoxColumn1.Name = "IDprovedorDataGridViewTextBoxColumn1"
        Me.IDprovedorDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IDDepartamentoDataGridViewTextBoxColumn1
        '
        Me.IDDepartamentoDataGridViewTextBoxColumn1.DataPropertyName = "ID_Departamento"
        Me.IDDepartamentoDataGridViewTextBoxColumn1.HeaderText = "ID_Departamento"
        Me.IDDepartamentoDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.IDDepartamentoDataGridViewTextBoxColumn1.Name = "IDDepartamentoDataGridViewTextBoxColumn1"
        Me.IDDepartamentoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'XPDataGridViewTextBoxColumn1
        '
        Me.XPDataGridViewTextBoxColumn1.DataPropertyName = "XP"
        Me.XPDataGridViewTextBoxColumn1.HeaderText = "XP"
        Me.XPDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.XPDataGridViewTextBoxColumn1.Name = "XPDataGridViewTextBoxColumn1"
        Me.XPDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProductosBindingSource3
        '
        Me.ProductosBindingSource3.DataMember = "Productos"
        Me.ProductosBindingSource3.DataSource = Me.Merca_plusDataSet
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(185, 196)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(79, 36)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.YellowGreen
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(185, 246)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 37)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Actualizar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 106)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 133)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 127)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 4
        '
        'ProductosBindingSource2
        '
        Me.ProductosBindingSource2.DataMember = "Productos"
        Me.ProductosBindingSource2.DataSource = Me.Merca_plusDataSet
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.Merca_plusDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ProvedorTableAdapter
        '
        Me.ProvedorTableAdapter.ClearBeforeFill = True
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1049, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
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
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1049, 360)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmEmpleado"
        Me.Text = "Monitoreo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Merca_plusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Merca_plusDataSet As Merca_plusDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As Merca_plusDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProvedorBindingSource As BindingSource
    Friend WithEvents ProvedorTableAdapter As Merca_plusDataSetTableAdapters.ProvedorTableAdapter
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As Merca_plusDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents ProductosBindingSource1 As BindingSource
    Friend WithEvents ProductosBindingSource2 As BindingSource
    Friend WithEvents ProductosBindingSource3 As BindingSource
    Friend WithEvents Button10 As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button9 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents IDproductosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDprovedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents XPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDproductosDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUniDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDprovedorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDDepartamentoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents XPDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
End Class
