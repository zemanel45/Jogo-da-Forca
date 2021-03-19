<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Me.rdpaises = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbanimais = New System.Windows.Forms.RadioButton()
        Me.rbprof = New System.Windows.Forms.RadioButton()
        Me.rbfrutas = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbdificil = New System.Windows.Forms.RadioButton()
        Me.rbfacil = New System.Windows.Forms.RadioButton()
        Me.btjogar = New System.Windows.Forms.Button()
        Me.lblnome = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Jogo da Forca"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rdpaises
        '
        Me.rdpaises.AutoSize = True
        Me.rdpaises.Location = New System.Drawing.Point(18, 19)
        Me.rdpaises.Name = "rdpaises"
        Me.rdpaises.Size = New System.Drawing.Size(67, 20)
        Me.rdpaises.TabIndex = 4
        Me.rdpaises.Text = "Países"
        Me.rdpaises.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbanimais)
        Me.GroupBox1.Controls.Add(Me.rbprof)
        Me.GroupBox1.Controls.Add(Me.rbfrutas)
        Me.GroupBox1.Controls.Add(Me.rdpaises)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(346, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 115)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temas"
        '
        'rbanimais
        '
        Me.rbanimais.AutoSize = True
        Me.rbanimais.Location = New System.Drawing.Point(18, 88)
        Me.rbanimais.Name = "rbanimais"
        Me.rbanimais.Size = New System.Drawing.Size(77, 20)
        Me.rbanimais.TabIndex = 8
        Me.rbanimais.Text = "Animais"
        Me.rbanimais.UseVisualStyleBackColor = True
        '
        'rbprof
        '
        Me.rbprof.AutoSize = True
        Me.rbprof.Location = New System.Drawing.Point(18, 65)
        Me.rbprof.Name = "rbprof"
        Me.rbprof.Size = New System.Drawing.Size(90, 20)
        Me.rbprof.TabIndex = 6
        Me.rbprof.Text = "Profissões"
        Me.rbprof.UseVisualStyleBackColor = True
        '
        'rbfrutas
        '
        Me.rbfrutas.AutoSize = True
        Me.rbfrutas.Location = New System.Drawing.Point(18, 42)
        Me.rbfrutas.Name = "rbfrutas"
        Me.rbfrutas.Size = New System.Drawing.Size(65, 20)
        Me.rbfrutas.TabIndex = 7
        Me.rbfrutas.Text = "Frutas"
        Me.rbfrutas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbdificil)
        Me.GroupBox2.Controls.Add(Me.rbfacil)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(503, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 73)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dificuldade"
        '
        'rbdificil
        '
        Me.rbdificil.AutoSize = True
        Me.rbdificil.Location = New System.Drawing.Point(18, 42)
        Me.rbdificil.Name = "rbdificil"
        Me.rbdificil.Size = New System.Drawing.Size(62, 20)
        Me.rbdificil.TabIndex = 7
        Me.rbdificil.TabStop = True
        Me.rbdificil.Text = "Dificil"
        Me.rbdificil.UseVisualStyleBackColor = True
        '
        'rbfacil
        '
        Me.rbfacil.AutoSize = True
        Me.rbfacil.Location = New System.Drawing.Point(18, 19)
        Me.rbfacil.Name = "rbfacil"
        Me.rbfacil.Size = New System.Drawing.Size(57, 20)
        Me.rbfacil.TabIndex = 4
        Me.rbfacil.TabStop = True
        Me.rbfacil.Text = "Fácil"
        Me.rbfacil.UseVisualStyleBackColor = True
        '
        'btjogar
        '
        Me.btjogar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btjogar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btjogar.Location = New System.Drawing.Point(450, 259)
        Me.btjogar.Name = "btjogar"
        Me.btjogar.Size = New System.Drawing.Size(145, 59)
        Me.btjogar.TabIndex = 10
        Me.btjogar.Text = "Jogar"
        Me.btjogar.UseVisualStyleBackColor = False
        '
        'lblnome
        '
        Me.lblnome.BackColor = System.Drawing.Color.Transparent
        Me.lblnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnome.ForeColor = System.Drawing.Color.Black
        Me.lblnome.Location = New System.Drawing.Point(12, 9)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(221, 63)
        Me.lblnome.TabIndex = 11
        Me.lblnome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox2.Location = New System.Drawing.Point(552, 275)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 250)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(681, 379)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblnome)
        Me.Controls.Add(Me.btjogar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmmenu"
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rdpaises As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbfrutas As RadioButton
    Friend WithEvents rbprof As RadioButton
    Friend WithEvents rbanimais As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbdificil As RadioButton
    Friend WithEvents rbfacil As RadioButton
    Friend WithEvents btjogar As Button
    Friend WithEvents lblnome As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
