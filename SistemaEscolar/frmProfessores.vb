Imports System.Data.SqlClient

Public Class frmProfessores
    Private Sub frmProfessores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1140
        dateTime.Value = "01/01/2000"
        Listar()
    End Sub


    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM professor", conexao)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim x As Integer = DataGridView1.Rows.Count
            lbl_total.Text = CInt(x)
        Catch ex As Exception
            fechar()
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Limpar()
        txt_buscarCPF.Clear()
        txtNome.Clear()
        txtCpf.Clear()
        txtSobrenome.Clear()
        txtEndereco.Clear()
        txtEmail.Clear()
        txtTelefone.Clear()
        txtMateria.Clear()
        txtIdade.Clear()
        rb_Mas.Checked = True
        dateTime.Value = "01/01/2000"
        txtCpf.Focus()
    End Sub

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
        Me.Width = 1140
        If rb_Cpf.Checked Then
            txtCpf.Text = txt_buscarCPF.Text
            txt_buscarCPF.Text = ""
            txtNome.Text = ""
            txtNome.Focus()
        Else
            txtNome.Text = txt_buscarCPF.Text
            txt_buscarCPF.Text = ""
            txtCpf.Text = ""
            txtCpf.Focus()
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand
        codAl = txtCpf.Text
        If txtCpf.Text <> "" And txtNome.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("registrarProfessor", conexao)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text)
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text)
                cmd.Parameters.AddWithValue("@SOBRENOME", txtSobrenome.Text)
                cmd.Parameters.AddWithValue("@IDADE", txtIdade.Text)
                cmd.Parameters.AddWithValue("@SEXO", If(rb_Mas.Checked = True, "M", "F"))
                cmd.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", dateTime.Value)
                cmd.Parameters.AddWithValue("@ID_MATERIA", txtMateria.Text)
                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
                Me.Width = 648

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                fechar()
            End Try

        Else
            Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
            MessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub dateTime_ValueChanged(sender As Object, e As EventArgs) Handles dateTime.ValueChanged

    End Sub

    Private Sub txtBuscarNome_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarNome.TextChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("BuscarNomeProfessor", conexao)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@Nome", txt_buscarNome.Text)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim x As Integer
            x = DataGridView1.Rows.Count
            lbl_total.Text = CStr(x)


        Catch ex As Exception
            MsgBox(ex.Message)
            Close()
        End Try
    End Sub

    Private Sub rbCpf_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Cpf.CheckedChanged
        lblBuscar.Text = "CPF"
        txt_buscarCPF.Visible = True
        txt_buscarCPF.Clear()
        txt_buscarCPF.Focus()
        txt_buscarCPF.Visible = False
        Listar()
    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Nome.CheckedChanged
        lblBuscar.Text = "Nome"
        txt_buscarNome.Visible = True
        txt_buscarNome.Clear()
        txt_buscarNome.Focus()
        txt_buscarCPF.Visible = False
        Listar()
    End Sub

    Private Sub txtBuscarCPF_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarCPF.TextChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("BuscarCPFProfessor", conexao)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@CPF", txt_buscarCPF.Text)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim x As Integer
            x = DataGridView1.Rows.Count
            lbl_total.Text = CStr(x)


        Catch ex As Exception
            MsgBox(ex.Message)
            Close()
        End Try
    End Sub

    Private Sub btnFecharCad_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Width = 648
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand
        codAl = txtCpf.Text
        If txtCpf.Text <> "" And txtNome.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("EditarProfessor", conexao)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text)
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text)
                cmd.Parameters.AddWithValue("@SOBRENOME", txtSobrenome.Text)
                cmd.Parameters.AddWithValue("@IDADE", txtIdade.Text)
                cmd.Parameters.AddWithValue("@SEXO", If(rb_Mas.Checked = True, "M", "F"))
                cmd.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", dateTime.Value)
                cmd.Parameters.AddWithValue("@ID_MATERIA", txtMateria.Text)
                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
                Me.Width = 648
                txtCpf.Enabled = True
                btnSalvar.Enabled = True
                btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                fechar()
            End Try

        Else
            Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
            MessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Label14.Text = "Dê um duplo clique sobre o nome para editar!"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Me.Width = 1140
        txtCpf.Enabled = False
        txtCpf.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtNome.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtSobrenome.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtIdade.Text = DataGridView1.CurrentRow.Cells(3).Value
        Dim sexo As Char = DataGridView1.CurrentRow.Cells(4).Value
        If sexo = "M" Then
            rb_Mas.Checked = True
        Else
            rb_Fem.Checked = True
        End If
        txtEndereco.Text = DataGridView1.CurrentRow.Cells(5).Value
        txtTelefone.Text = DataGridView1.CurrentRow.Cells(6).Value
        txtEmail.Text = DataGridView1.CurrentRow.Cells(7).Value
        dateTime.Value = DataGridView1.CurrentRow.Cells(8).Value
        txtMateria.Text = DataGridView1.CurrentRow.Cells(9).Value

        btnEditar.Enabled = True
        btnSalvar.Enabled = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class