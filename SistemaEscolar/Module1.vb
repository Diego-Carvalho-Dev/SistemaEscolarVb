Imports System.Data.SqlClient

Module Module1
    Public conexao As New SqlConnection("Server=.; Database=sistema; Integrated Security=SSPI")
    Sub abrir()
        If conexao.State = 0 Then
            conexao.Open()
        End If
    End Sub

    Sub fechar()
        If conexao.State = 1 Then
            conexao.Close()
        End If
    End Sub


    Public usuario As String
    Public codAl As String
End Module
