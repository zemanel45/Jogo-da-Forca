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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 20)
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
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbanimais)
        Me.GroupBox1.Controls.Add(Me.rbprof)
        Me.GroupBox1.Controls.Add(Me.rbfrutas)
        Me.GroupBox1.Controls.Add(Me.rdpaises)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(49, 94)
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
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbdificil)
        Me.GroupBox2.Controls.Add(Me.rbfacil)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(234, 113)
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
        Me.btjogar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btjogar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btjogar.Location = New System.Drawing.Point(405, 253)
        Me.btjogar.Name = "btjogar"
        Me.btjogar.Size = New System.Drawing.Size(75, 30)
        Me.btjogar.TabIndex = 10
        Me.btjogar.Text = "&Start"
        Me.btjogar.UseVisualStyleBackColor = False
        '
        'lblnome
        '
        Me.lblnome.BackColor = System.Drawing.Color.Transparent
        Me.lblnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnome.ForeColor = System.Drawing.Color.Black
        Me.lblnome.Location = New System.Drawing.Point(409, 9)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(100, 32)
        Me.lblnome.TabIndex = 11
        Me.lblnome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.jogo_2.My.Resources.Resources.FUNDOCOA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(514, 311)
        Me.Controls.Add(Me.lblnome)
        Me.Controls.Add(Me.btjogar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frmmenu"
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
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
End Class
