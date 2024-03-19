<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2dplatformer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PicPlayer = New System.Windows.Forms.PictureBox()
        Me.PicGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CharacterPic1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.CharacterPic4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.CharacterPic2 = New System.Windows.Forms.PictureBox()
        Me.CharacterPic3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PicAir = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Mover2 = New Platformer.Mover()
        Me.Mover1 = New Platformer.Mover()
        Me.Mover4 = New Platformer.Mover()
        Me.Mover5 = New Platformer.Mover()
        Me.Mover3 = New Platformer.Mover()
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterPic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterPic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterPic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPlayer
        '
        Me.PicPlayer.BackColor = System.Drawing.Color.Black
        Me.PicPlayer.Location = New System.Drawing.Point(21, 518)
        Me.PicPlayer.Name = "PicPlayer"
        Me.PicPlayer.Size = New System.Drawing.Size(51, 50)
        Me.PicPlayer.TabIndex = 0
        Me.PicPlayer.TabStop = False
        '
        'PicGround
        '
        Me.PicGround.BackColor = System.Drawing.Color.Gray
        Me.PicGround.Location = New System.Drawing.Point(-1, 597)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(1163, 75)
        Me.PicGround.TabIndex = 2
        Me.PicGround.TabStop = False
        Me.PicGround.Tag = "Bound"
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 20
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 20
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 20
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 20
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(12, 470)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 29)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Bound"
        '
        'CharacterPic1
        '
        Me.CharacterPic1.BackColor = System.Drawing.Color.Blue
        Me.CharacterPic1.Location = New System.Drawing.Point(72, 79)
        Me.CharacterPic1.Name = "CharacterPic1"
        Me.CharacterPic1.Size = New System.Drawing.Size(51, 50)
        Me.CharacterPic1.TabIndex = 10
        Me.CharacterPic1.TabStop = False
        Me.CharacterPic1.Tag = "coin"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(298, 470)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(213, 29)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "Bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(604, 470)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(213, 29)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "Bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(905, 470)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(213, 29)
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "Bound"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox6.Location = New System.Drawing.Point(455, 294)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(213, 29)
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "Bound"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox7.Location = New System.Drawing.Point(748, 294)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(298, 29)
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "Bound"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox9.Location = New System.Drawing.Point(-13, 294)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(332, 29)
        Me.PictureBox9.TabIndex = 17
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "Bound"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox10.Location = New System.Drawing.Point(1044, 249)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(148, 74)
        Me.PictureBox10.TabIndex = 18
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "Bound"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox11.Location = New System.Drawing.Point(12, 125)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(268, 29)
        Me.PictureBox11.TabIndex = 19
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "Bound"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox12.Location = New System.Drawing.Point(367, 125)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(213, 29)
        Me.PictureBox12.TabIndex = 20
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "Bound"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox13.Location = New System.Drawing.Point(672, 125)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(289, 29)
        Me.PictureBox13.TabIndex = 21
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "Bound"
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox14.Location = New System.Drawing.Point(987, 125)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(213, 29)
        Me.PictureBox14.TabIndex = 22
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Tag = "Bound"
        '
        'CharacterPic4
        '
        Me.CharacterPic4.BackColor = System.Drawing.Color.Blue
        Me.CharacterPic4.Location = New System.Drawing.Point(907, 385)
        Me.CharacterPic4.Name = "CharacterPic4"
        Me.CharacterPic4.Size = New System.Drawing.Size(51, 50)
        Me.CharacterPic4.TabIndex = 25
        Me.CharacterPic4.TabStop = False
        Me.CharacterPic4.Tag = "coin"
        '
        'PictureBox19
        '
        Me.PictureBox19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox19.Location = New System.Drawing.Point(-26, 584)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(1175, 29)
        Me.PictureBox19.TabIndex = 32
        Me.PictureBox19.TabStop = False
        Me.PictureBox19.Tag = "Bound"
        '
        'CharacterPic2
        '
        Me.CharacterPic2.BackColor = System.Drawing.Color.Blue
        Me.CharacterPic2.Location = New System.Drawing.Point(995, 43)
        Me.CharacterPic2.Name = "CharacterPic2"
        Me.CharacterPic2.Size = New System.Drawing.Size(51, 50)
        Me.CharacterPic2.TabIndex = 35
        Me.CharacterPic2.TabStop = False
        Me.CharacterPic2.Tag = "coin"
        '
        'CharacterPic3
        '
        Me.CharacterPic3.BackColor = System.Drawing.Color.Blue
        Me.CharacterPic3.Location = New System.Drawing.Point(11, 249)
        Me.CharacterPic3.Name = "CharacterPic3"
        Me.CharacterPic3.Size = New System.Drawing.Size(51, 50)
        Me.CharacterPic3.TabIndex = 36
        Me.CharacterPic3.TabStop = False
        Me.CharacterPic3.Tag = "coin"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(967, -1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 22)
        Me.TextBox1.TabIndex = 41
        '
        'PicAir
        '
        Me.PicAir.Location = New System.Drawing.Point(-13, -30)
        Me.PicAir.Name = "PicAir"
        Me.PicAir.Size = New System.Drawing.Size(1150, 621)
        Me.PicAir.TabIndex = 42
        Me.PicAir.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(935, -13)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(257, 50)
        Me.PictureBox5.TabIndex = 43
        Me.PictureBox5.TabStop = False
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.BackColor = System.Drawing.Color.White
        Me.ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ScoreLabel.Location = New System.Drawing.Point(9, 9)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(79, 31)
        Me.ScoreLabel.TabIndex = 44
        Me.ScoreLabel.Text = "Score"
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 200
        Me.Mover2.Location = New System.Drawing.Point(21, 229)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(298, 10)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.CharacterPic3
        Me.Mover2.TabIndex = 37
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 300
        Me.Mover1.Location = New System.Drawing.Point(12, 59)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(186, 10)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.CharacterPic1
        Me.Mover1.TabIndex = 28
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 300
        Me.Mover4.Location = New System.Drawing.Point(685, 53)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(420, 10)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.CharacterPic2
        Me.Mover4.TabIndex = 39
        '
        'Mover5
        '
        Me.Mover5.BackColor = System.Drawing.Color.Transparent
        Me.Mover5.interval = 400
        Me.Mover5.Location = New System.Drawing.Point(917, 395)
        Me.Mover5.Name = "Mover5"
        Me.Mover5.Size = New System.Drawing.Size(129, 15)
        Me.Mover5.speed = 10
        Me.Mover5.sprite = Me.CharacterPic4
        Me.Mover5.TabIndex = 40
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 100
        Me.Mover3.Location = New System.Drawing.Point(767, 208)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(308, 31)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Nothing
        Me.Mover3.TabIndex = 38
        '
        'frm2dplatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1125, 646)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CharacterPic3)
        Me.Controls.Add(Me.CharacterPic2)
        Me.Controls.Add(Me.CharacterPic1)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.CharacterPic4)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicPlayer)
        Me.Controls.Add(Me.PicGround)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.Mover5)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.PicAir)
        Me.Name = "frm2dplatformer"
        Me.Text = "Form1"
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterPic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterPic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterPic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterPic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicPlayer As PictureBox
    Friend WithEvents PicGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CharacterPic1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents CharacterPic4 As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents CharacterPic2 As PictureBox
    Friend WithEvents CharacterPic3 As PictureBox
    Friend WithEvents Mover2 As Mover
    Friend WithEvents Mover3 As Mover
    Friend WithEvents Mover4 As Mover
    Friend WithEvents Mover5 As Mover
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PicAir As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ScoreLabel As Label
End Class
