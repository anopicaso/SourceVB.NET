<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXemSanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.dgvXemsp = New System.Windows.Forms.DataGridView()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnTimSP = New System.Windows.Forms.Button()
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttenSP = New System.Windows.Forms.TextBox()
        Me.btnTimTenSP = New System.Windows.Forms.Button()
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(312, 50)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 10
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'dgvXemsp
        '
        Me.dgvXemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemsp.Location = New System.Drawing.Point(7, 101)
        Me.dgvXemsp.Name = "dgvXemsp"
        Me.dgvXemsp.Size = New System.Drawing.Size(570, 239)
        Me.dgvXemsp.TabIndex = 9
        '
        'btnXemall
        '
        Me.btnXemall.Location = New System.Drawing.Point(312, 10)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(75, 23)
        Me.btnXemall.TabIndex = 7
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'btnTimSP
        '
        Me.btnTimSP.Location = New System.Drawing.Point(224, 8)
        Me.btnTimSP.Name = "btnTimSP"
        Me.btnTimSP.Size = New System.Drawing.Size(75, 23)
        Me.btnTimSP.TabIndex = 8
        Me.btnTimSP.Text = "Tìm MSP"
        Me.btnTimSP.UseVisualStyleBackColor = True
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(49, 10)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(160, 20)
        Me.txtMASP.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã MSP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tên SP"
        '
        'txttenSP
        '
        Me.txttenSP.Location = New System.Drawing.Point(49, 52)
        Me.txttenSP.Name = "txttenSP"
        Me.txttenSP.Size = New System.Drawing.Size(160, 20)
        Me.txttenSP.TabIndex = 6
        '
        'btnTimTenSP
        '
        Me.btnTimTenSP.Location = New System.Drawing.Point(224, 50)
        Me.btnTimTenSP.Name = "btnTimTenSP"
        Me.btnTimTenSP.Size = New System.Drawing.Size(75, 23)
        Me.btnTimTenSP.TabIndex = 8
        Me.btnTimTenSP.Text = "Tìm TênSP"
        Me.btnTimTenSP.UseVisualStyleBackColor = True
        '
        'frmXemSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 351)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvXemsp)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnTimTenSP)
        Me.Controls.Add(Me.txttenSP)
        Me.Controls.Add(Me.btnTimSP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmXemSanPham"
        Me.Text = "frmXemSanPham"
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents dgvXemsp As System.Windows.Forms.DataGridView
    Friend WithEvents btnXemall As System.Windows.Forms.Button
    Friend WithEvents btnTimSP As System.Windows.Forms.Button
    Friend WithEvents txtMASP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttenSP As System.Windows.Forms.TextBox
    Friend WithEvents btnTimTenSP As System.Windows.Forms.Button
End Class
