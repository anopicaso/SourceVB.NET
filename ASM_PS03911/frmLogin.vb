Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub btnDN_Click(sender As Object, e As EventArgs) Handles btnDN.Click
        Dim conn As New SqlConnection("server=Admin-PC;database=QL_DT;trusted_connection=false;uid=sa;pwd=123@abc")
        Dim sqladap = New SqlDataAdapter("select * from Login where ID='" & txtusername.Text & "' and PWD='" & txtpwd.Text & "'", conn)
        Dim tb As New DataTable()
        Try
            conn.Open()
            sqladap.Fill(tb)
            conn.Close()
        Catch ex As Exception

        End Try
        If (tb.Rows.Count > 0) Then
            Dim f As New frmMain()
            f.Show()
            Me.Hide()
        Else
            MessageBox.Show(" Bạn Đã Nhập Sai User or PassworD ")
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class