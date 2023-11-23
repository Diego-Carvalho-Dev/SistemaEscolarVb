Imports System.Data.SqlClient

Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dim confirma = MsgBox("Deseja Sair", vbYesNo + vbExclamation, "Atenção")
        If confirma = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usu As String = txtUsuario.Text
        Dim sen As String = txtSenha.Text

        If usu = "" Or sen = "" Then
            MsgBox("Preencha os campos!")
        Else

            Dim cmd As New SqlCommand("iniciarSessao", conexao)
            Try
                abrir()
                cmd.CommandType = 4
                With cmd.Parameters
                    .AddWithValue("@Nome", usu)
                    .AddWithValue("@Senha", sen)
                    .Add("@Msg", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With

                usuario = txtUsuario.Text
                Dim msg As String = cmd.Parameters("@Msg").Value
                MsgBox(msg, vbInformation)

                If (msg = "Dados incorretos") Then
                    txtSenha.Clear()
                    txtUsuario.Clear()
                    txtUsuario.Focus()
                Else
                    Dim frm As New frmPrincipal
                    Me.Hide()
                    frm.ShowDialog()
                End If

                conexao.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
