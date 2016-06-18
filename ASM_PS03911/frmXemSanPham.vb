Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmXemSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "server=Admin-PC;database=QL_DT;trusted_connection=false;uid=sa;pwd=123@abc"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub
    Private Sub btnTimSP_Click(sender As Object, e As EventArgs) Handles btnTimSP.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALSP as 'Mã LSP',SANPHAM.NOIDUNG as 'Nội Dung',SANPHAM.TRANGTHAI as 'Trạng Thái' from SANPHAM inner join LOAISANPHAM on SANPHAM.MALSP = LOAISANPHAM.MALSP where SANPHAM.MASP ='" & txtMASP.Text & "' ", connect)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMASP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmXemsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTimTenSP_Click(sender As Object, e As EventArgs) Handles btnTimTenSP.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã Sản Phẩm' ,TENSP as 'Tên Sản Phẩm', MALSP as 'Mã LSP', NOIDUNG as 'Nội Dung', TrangThai as 'Trạng Thái' from SANPHAM where SANPHAM.TENSP like '%" & txttenSP.Text & "%' ", connect)
        Try
            If txttenSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txttenSP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txttenSP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class