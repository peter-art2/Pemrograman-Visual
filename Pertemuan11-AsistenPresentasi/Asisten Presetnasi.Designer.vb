<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CheckBox1 = New CheckBox()
        Label3 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label6 = New Label()
        NumericUpDown2 = New NumericUpDown()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        CheckBox2 = New CheckBox()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(31, 112)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(564, 276)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 28)
        Label1.TabIndex = 1
        Label1.Text = "Asisten Presentasi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(297, 20)
        Label2.TabIndex = 2
        Label2.Text = "Jaga durasi tanpa meninggalkan slide Anda"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.Location = New Point(31, 394)
        Button1.Name = "Button1"
        Button1.Size = New Size(358, 51)
        Button1.TabIndex = 3
        Button1.Text = "Mulai presentasi"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(418, 394)
        Button2.Name = "Button2"
        Button2.Size = New Size(177, 46)
        Button2.TabIndex = 4
        Button2.Text = "Ulangi"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(418, 455)
        Button3.Name = "Button3"
        Button3.Size = New Size(177, 40)
        Button3.TabIndex = 5
        Button3.Text = "Mode Ringkas"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(31, 464)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(198, 24)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Tetap di atas aplikasi lain"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 526)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(CheckBox2)
        Panel2.Controls.Add(NumericUpDown2)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(NumericUpDown1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(34, 515)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(561, 189)
        Panel2.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 4)
        Label4.Name = "Label4"
        Label4.Size = New Size(176, 28)
        Label4.TabIndex = 0
        Label4.Text = "Durasi Presentasi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 20)
        Label5.TabIndex = 1
        Label5.Text = "Menit"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(65, 41)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(80, 27)
        NumericUpDown1.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(215, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 20)
        Label6.TabIndex = 3
        Label6.Text = "Detik"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(274, 41)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(81, 27)
        NumericUpDown2.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(218, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 20)
        Label7.TabIndex = 0
        Label7.Text = "Siap presentasi"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(164, 72)
        Label8.Name = "Label8"
        Label8.Size = New Size(251, 106)
        Label8.TabIndex = 1
        Label8.Text = "05:00"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(164, 211)
        Label9.Name = "Label9"
        Label9.Size = New Size(266, 20)
        Label9.TabIndex = 2
        Label9.Text = "Atur durasi, lalu mulai ketika Anda siap"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(384, 43)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(146, 24)
        CheckBox2.TabIndex = 5
        CheckBox2.Text = "Bunyi saat selesai"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(18, 85)
        Label10.Name = "Label10"
        Label10.Size = New Size(165, 20)
        Label10.TabIndex = 6
        Label10.Text = "Ctrl+Alt+F9: mulai/jeda"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(18, 115)
        Label11.Name = "Label11"
        Label11.Size = New Size(355, 20)
        Label11.TabIndex = 7
        Label11.Text = "Ctrl+Alt+F10: ulangi. Tombol tetap dapat digunakan"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(18, 156)
        Label12.Name = "Label12"
        Label12.Size = New Size(417, 20)
        Label12.TabIndex = 8
        Label12.Text = "Timer siap. Aktifkan di atas agar terlihat saat berganti aplikasi"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(627, 716)
        Controls.Add(Panel2)
        Controls.Add(Label3)
        Controls.Add(CheckBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label12 As Label

End Class
