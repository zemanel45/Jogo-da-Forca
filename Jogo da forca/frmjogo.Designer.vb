<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmjogo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmjogo))
        Me.tbxresposta = New System.Windows.Forms.TextBox()
        Me.lblpalavra = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxresposta
        '
        Me.tbxresposta.Location = New System.Drawing.Point(140, 339)
        Me.tbxresposta.Name = "tbxresposta"
        Me.tbxresposta.Size = New System.Drawing.Size(100, 20)
        Me.tbxresposta.TabIndex = 5
        '
        'lblpalavra
        '
        Me.lblpalavra.AutoSize = True
        Me.lblpalavra.Location = New System.Drawing.Point(279, 288)
        Me.lblpalavra.Name = "lblpalavra"
        Me.lblpalavra.Size = New System.Drawing.Size(0, 13)
        Me.lblpalavra.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(397, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Verificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.jogo_2.My.Resources.Resources.pic2
        Me.PictureBox1.Location = New System.Drawing.Point(196, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 273)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "5fc65eb744e2a6be85526f5adf3d36c1.jpg")
        Me.ImageList1.Images.SetKeyName(1, "5fe96f870c86548f84361e793f5f4642.jpg")
        Me.ImageList1.Images.SetKeyName(2, "7fafbf6524e89b3f5b3b5524e471e3c2.jpg")
        Me.ImageList1.Images.SetKeyName(3, "9c60f72c58c8767c12ad6615ee6e635d.jpg")
        '
        'frmjogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(597, 419)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbxresposta)
        Me.Controls.Add(Me.lblpalavra)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmjogo"
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxresposta As TextBox
    Friend WithEvents lblpalavra As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
