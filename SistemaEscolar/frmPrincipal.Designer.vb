<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btn_professores = New System.Windows.Forms.Button()
        Me.btn_alunos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_professores
        '
        Me.btn_professores.BackColor = System.Drawing.Color.Transparent
        Me.btn_professores.BackgroundImage = CType(resources.GetObject("btn_professores.BackgroundImage"), System.Drawing.Image)
        Me.btn_professores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_professores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_professores.FlatAppearance.BorderSize = 0
        Me.btn_professores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_professores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_professores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_professores.Location = New System.Drawing.Point(530, 98)
        Me.btn_professores.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_professores.Name = "btn_professores"
        Me.btn_professores.Size = New System.Drawing.Size(134, 127)
        Me.btn_professores.TabIndex = 1
        Me.btn_professores.UseVisualStyleBackColor = False
        '
        'btn_alunos
        '
        Me.btn_alunos.BackColor = System.Drawing.Color.Transparent
        Me.btn_alunos.BackgroundImage = CType(resources.GetObject("btn_alunos.BackgroundImage"), System.Drawing.Image)
        Me.btn_alunos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_alunos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_alunos.FlatAppearance.BorderSize = 0
        Me.btn_alunos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_alunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_alunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alunos.Location = New System.Drawing.Point(110, 98)
        Me.btn_alunos.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btn_alunos.Name = "btn_alunos"
        Me.btn_alunos.Size = New System.Drawing.Size(134, 127)
        Me.btn_alunos.TabIndex = 2
        Me.btn_alunos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(144, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alunos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(543, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Professores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Script", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label3.Location = New System.Drawing.Point(599, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SysEscolarVb"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_alunos)
        Me.Controls.Add(Me.btn_professores)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_professores As Button
    Friend WithEvents btn_alunos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
