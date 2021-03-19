<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminicio
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
        Me.btsair = New System.Windows.Forms.Button()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.btregister = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(201, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jogo da Forca"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btsair
        '
        Me.btsair.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btsair.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsair.Location = New System.Drawing.Point(388, 274)
        Me.btsair.Name = "btsair"
        Me.btsair.Size = New System.Drawing.Size(168, 51)
        Me.btsair.TabIndex = 3
        Me.btsair.Text = "Sair"
        Me.btsair.UseVisualStyleBackColor = False
        '
        'btlogin
        '
        Me.btlogin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btlogin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btlogin.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btlogin.ImageKey = "(none)"
        Me.btlogin.Location = New System.Drawing.Point(388, 189)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(168, 52)
        Me.btlogin.TabIndex = 2
        Me.btlogin.Text = "Login"
        Me.btlogin.UseVisualStyleBackColor = False
        '
        'btregister
        '
        Me.btregister.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btregister.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btregister.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btregister.ImageKey = "(none)"
        Me.btregister.Location = New System.Drawing.Point(388, 109)
        Me.btregister.Name = "btregister"
        Me.btregister.Size = New System.Drawing.Size(168, 52)
        Me.btregister.TabIndex = 8
        Me.btregister.Text = "Register"
        Me.btregister.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight

        Me.PictureBox5.Location = New System.Drawing.Point(513, 119)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight

        Me.PictureBox2.Location = New System.Drawing.Point(513, 201)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '

        Me.PictureBox1.Location = New System.Drawing.Point(2, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 250)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frminicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(627, 355)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btregister)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btsair)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frminicio"
        Me.Text = "Menu"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btlogin As Button
    Friend WithEvents btsair As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btregister As Button
End Class
