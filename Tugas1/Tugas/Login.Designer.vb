<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        picImage = New PictureBox()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        lblRole = New Label()
        lblNama = New Label()
        lblNIM = New Label()
        btnLogin = New Button()
        cmbRole = New ComboBox()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(319, 62)
        picImage.Name = "picImage"
        picImage.Size = New Size(125, 62)
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(303, 197)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(151, 27)
        txtNama.TabIndex = 2
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(303, 250)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(151, 27)
        txtNIM.TabIndex = 3
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(225, 155)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(50, 20)
        lblRole.TabIndex = 4
        lblRole.Text = "Role  :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(225, 204)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(60, 20)
        lblNama.TabIndex = 5
        lblNama.Text = "Nama  :"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(225, 257)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(48, 20)
        lblNIM.TabIndex = 6
        lblNIM.Text = "NIM  :"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(333, 303)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(303, 147)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(151, 28)
        cmbRole.TabIndex = 8
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmbRole)
        Controls.Add(btnLogin)
        Controls.Add(lblNIM)
        Controls.Add(lblNama)
        Controls.Add(lblRole)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(picImage)
        Name = "FrmLogin"
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents cmbRole As ComboBox
End Class
