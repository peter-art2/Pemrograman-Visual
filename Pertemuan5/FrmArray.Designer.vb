<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArray
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
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPanjang = New System.Windows.Forms.TextBox()
        Me.txtLebar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstNilai = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(244, 212)
        Me.btnHitung.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(74, 19)
        Me.btnHitung.TabIndex = 0
        Me.btnHitung.Text = "HItung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Panjang :"
        '
        'txtPanjang
        '
        Me.txtPanjang.Location = New System.Drawing.Point(243, 117)
        Me.txtPanjang.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPanjang.Name = "txtPanjang"
        Me.txtPanjang.Size = New System.Drawing.Size(76, 20)
        Me.txtPanjang.TabIndex = 2
        '
        'txtLebar
        '
        Me.txtLebar.Location = New System.Drawing.Point(243, 174)
        Me.txtLebar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLebar.Name = "txtLebar"
        Me.txtLebar.Size = New System.Drawing.Size(76, 20)
        Me.txtLebar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lebar :"
        '
        'lstNilai
        '
        Me.lstNilai.FormattingEnabled = True
        Me.lstNilai.Location = New System.Drawing.Point(173, 237)
        Me.lstNilai.Name = "lstNilai"
        Me.lstNilai.Size = New System.Drawing.Size(120, 95)
        Me.lstNilai.TabIndex = 5
        '
        'FrmArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lstNilai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLebar)
        Me.Controls.Add(Me.txtPanjang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHitung)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmArray"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstNilai As ListBox
End Class
