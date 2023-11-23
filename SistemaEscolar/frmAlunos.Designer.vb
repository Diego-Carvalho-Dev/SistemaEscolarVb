<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAlunos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlunos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_buscarNome = New System.Windows.Forms.TextBox()
        Me.rb_Nome = New System.Windows.Forms.RadioButton()
        Me.txt_buscarCPF = New System.Windows.Forms.TextBox()
        Me.rb_Cpf = New System.Windows.Forms.RadioButton()
        Me.btn_inserir = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.rb_Fem = New System.Windows.Forms.RadioButton()
        Me.rb_Mas = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.dateTime = New System.Windows.Forms.DateTimePicker()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSobrenome = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCpf = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.txt_buscarNome)
        Me.GroupBox1.Controls.Add(Me.rb_Nome)
        Me.GroupBox1.Controls.Add(Me.txt_buscarCPF)
        Me.GroupBox1.Controls.Add(Me.rb_Cpf)
        Me.GroupBox1.Controls.Add(Me.btn_inserir)
        Me.GroupBox1.Controls.Add(Me.lblBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Por"
        '
        'txt_buscarNome
        '
        Me.txt_buscarNome.Location = New System.Drawing.Point(71, 78)
        Me.txt_buscarNome.Name = "txt_buscarNome"
        Me.txt_buscarNome.Size = New System.Drawing.Size(269, 26)
        Me.txt_buscarNome.TabIndex = 4
        '
        'rb_Nome
        '
        Me.rb_Nome.AutoSize = True
        Me.rb_Nome.Location = New System.Drawing.Point(156, 35)
        Me.rb_Nome.Name = "rb_Nome"
        Me.rb_Nome.Size = New System.Drawing.Size(69, 24)
        Me.rb_Nome.TabIndex = 2
        Me.rb_Nome.TabStop = True
        Me.rb_Nome.Text = "Nome"
        Me.rb_Nome.UseVisualStyleBackColor = True
        '
        'txt_buscarCPF
        '
        Me.txt_buscarCPF.Location = New System.Drawing.Point(71, 78)
        Me.txt_buscarCPF.Name = "txt_buscarCPF"
        Me.txt_buscarCPF.Size = New System.Drawing.Size(269, 26)
        Me.txt_buscarCPF.TabIndex = 3
        '
        'rb_Cpf
        '
        Me.rb_Cpf.AutoSize = True
        Me.rb_Cpf.Location = New System.Drawing.Point(10, 35)
        Me.rb_Cpf.Name = "rb_Cpf"
        Me.rb_Cpf.Size = New System.Drawing.Size(58, 24)
        Me.rb_Cpf.TabIndex = 1
        Me.rb_Cpf.TabStop = True
        Me.rb_Cpf.Text = "CPF"
        Me.rb_Cpf.UseVisualStyleBackColor = True
        '
        'btn_inserir
        '
        Me.btn_inserir.BackColor = System.Drawing.Color.Transparent
        Me.btn_inserir.BackgroundImage = CType(resources.GetObject("btn_inserir.BackgroundImage"), System.Drawing.Image)
        Me.btn_inserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_inserir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inserir.FlatAppearance.BorderSize = 0
        Me.btn_inserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inserir.Location = New System.Drawing.Point(552, 7)
        Me.btn_inserir.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_inserir.Name = "btn_inserir"
        Me.btn_inserir.Size = New System.Drawing.Size(40, 35)
        Me.btn_inserir.TabIndex = 2
        Me.btn_inserir.UseVisualStyleBackColor = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(6, 81)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 20)
        Me.lblBuscar.TabIndex = 1
        Me.lblBuscar.Text = "CPF"
        '
        'rb_Fem
        '
        Me.rb_Fem.AutoSize = True
        Me.rb_Fem.Location = New System.Drawing.Point(168, 198)
        Me.rb_Fem.Name = "rb_Fem"
        Me.rb_Fem.Size = New System.Drawing.Size(92, 24)
        Me.rb_Fem.TabIndex = 21
        Me.rb_Fem.TabStop = True
        Me.rb_Fem.Text = "Feminino"
        Me.rb_Fem.UseVisualStyleBackColor = True
        '
        'rb_Mas
        '
        Me.rb_Mas.AutoSize = True
        Me.rb_Mas.Location = New System.Drawing.Point(168, 168)
        Me.rb_Mas.Name = "rb_Mas"
        Me.rb_Mas.Size = New System.Drawing.Size(98, 24)
        Me.rb_Mas.TabIndex = 20
        Me.rb_Mas.TabStop = True
        Me.rb_Mas.Text = "Masculino"
        Me.rb_Mas.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 217)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(595, 142)
        Me.DataGridView1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(564, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Enabled = False
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(611, 385)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(18, 20)
        Me.lbl_total.TabIndex = 5
        Me.lbl_total.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(31, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Registro de Alunos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.btnFechar)
        Me.GroupBox2.Controls.Add(Me.dateTime)
        Me.GroupBox2.Controls.Add(Me.txtEndereco)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.rb_Fem)
        Me.GroupBox2.Controls.Add(Me.txtIdade)
        Me.GroupBox2.Controls.Add(Me.rb_Mas)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtSobrenome)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNome)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCpf)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(647, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 298)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Pessoais"
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Location = New System.Drawing.Point(424, 13)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(35, 23)
        Me.btnFechar.TabIndex = 10
        Me.btnFechar.Text = "X"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'dateTime
        '
        Me.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTime.Location = New System.Drawing.Point(283, 168)
        Me.dateTime.Name = "dateTime"
        Me.dateTime.Size = New System.Drawing.Size(157, 26)
        Me.dateTime.TabIndex = 7
        Me.dateTime.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(28, 256)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(412, 26)
        Me.txtEndereco.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Endereço"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(278, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Data de Nascimento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(129, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Sexo"
        '
        'txtIdade
        '
        Me.txtIdade.Location = New System.Drawing.Point(28, 168)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(61, 26)
        Me.txtIdade.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Idade"
        '
        'txtSobrenome
        '
        Me.txtSobrenome.Location = New System.Drawing.Point(120, 99)
        Me.txtSobrenome.Name = "txtSobrenome"
        Me.txtSobrenome.Size = New System.Drawing.Size(320, 26)
        Me.txtSobrenome.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sobrenome"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(282, 52)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(158, 26)
        Me.txtNome.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nome"
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(69, 52)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(129, 26)
        Me.txtCpf.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CPF"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(993, 385)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(119, 31)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSalvar.Location = New System.Drawing.Point(847, 385)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(113, 31)
        Me.btnSalvar.TabIndex = 9
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(41, 362)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 20)
        Me.lblInfo.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label1.Location = New System.Drawing.Point(922, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 38)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "SysEscolarVb"
        '
        'frmAlunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1124, 441)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAlunos"
        Me.Text = "Registro de Alunos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents rb_Fem As RadioButton
    Friend WithEvents rb_Mas As RadioButton
    Friend WithEvents txt_buscarCPF As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_inserir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSobrenome As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCpf As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rb_Nome As RadioButton
    Friend WithEvents rb_Cpf As RadioButton
    Friend WithEvents dateTime As DateTimePicker
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents txt_buscarNome As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label1 As Label
End Class
