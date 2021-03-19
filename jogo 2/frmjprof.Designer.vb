<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmjprof
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbxresposta = New System.Windows.Forms.TextBox()
        Me.lblpalavra = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(188, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 273)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'tbxresposta
        '
        Me.tbxresposta.Location = New System.Drawing.Point(132, 363)
        Me.tbxresposta.Name = "tbxresposta"
        Me.tbxresposta.Size = New System.Drawing.Size(100, 20)
        Me.tbxresposta.TabIndex = 10
        '
        'lblpalavra
        '
        Me.lblpalavra.AutoSize = True
        Me.lblpalavra.Location = New System.Drawing.Point(271, 312)
        Me.lblpalavra.Name = "lblpalavra"
        Me.lblpalavra.Size = New System.Drawing.Size(0, 13)
        Me.lblpalavra.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Verificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmjprof
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 419)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbxresposta)
        Me.Controls.Add(Me.lblpalavra)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmjprof"
        Me.Text = "Jogo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbxresposta As TextBox
    Friend WithEvents lblpalavra As Label
    Friend WithEvents Button1 As Button
End Class
