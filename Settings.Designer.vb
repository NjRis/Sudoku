<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label_Sound = New System.Windows.Forms.Label()
        Me.Button_ON = New System.Windows.Forms.Button()
        Me.Button_Off = New System.Windows.Forms.Button()
        Me.Label_Opacity = New System.Windows.Forms.Label()
        Me.Label_Format = New System.Windows.Forms.Label()
        Me.Button_Small = New System.Windows.Forms.Button()
        Me.Button_Medium = New System.Windows.Forms.Button()
        Me.Button_Large = New System.Windows.Forms.Button()
        Me.Label_Police = New System.Windows.Forms.Label()
        Me.ComboBox_Police = New System.Windows.Forms.ComboBox()
        Me.TextBox_Opacity = New System.Windows.Forms.TextBox()
        Me.Button_Return = New System.Windows.Forms.Button()
        Me.Label_Level = New System.Windows.Forms.Label()
        Me.Button_Easy = New System.Windows.Forms.Button()
        Me.Button_Normal = New System.Windows.Forms.Button()
        Me.Button_Hard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Sound
        '
        Me.Label_Sound.AutoSize = True
        Me.Label_Sound.Location = New System.Drawing.Point(360, 23)
        Me.Label_Sound.Name = "Label_Sound"
        Me.Label_Sound.Size = New System.Drawing.Size(51, 15)
        Me.Label_Sound.TabIndex = 0
        Me.Label_Sound.Text = "SOUND"
        '
        'Button_ON
        '
        Me.Button_ON.Location = New System.Drawing.Point(333, 57)
        Me.Button_ON.Name = "Button_ON"
        Me.Button_ON.Size = New System.Drawing.Size(39, 37)
        Me.Button_ON.TabIndex = 1
        Me.Button_ON.UseVisualStyleBackColor = True
        '
        'Button_Off
        '
        Me.Button_Off.Location = New System.Drawing.Point(399, 57)
        Me.Button_Off.Name = "Button_Off"
        Me.Button_Off.Size = New System.Drawing.Size(39, 37)
        Me.Button_Off.TabIndex = 2
        Me.Button_Off.UseVisualStyleBackColor = True
        '
        'Label_Opacity
        '
        Me.Label_Opacity.AutoSize = True
        Me.Label_Opacity.Location = New System.Drawing.Point(363, 118)
        Me.Label_Opacity.Name = "Label_Opacity"
        Me.Label_Opacity.Size = New System.Drawing.Size(56, 15)
        Me.Label_Opacity.TabIndex = 3
        Me.Label_Opacity.Text = "OPACITY"
        '
        'Label_Format
        '
        Me.Label_Format.AutoSize = True
        Me.Label_Format.Location = New System.Drawing.Point(363, 180)
        Me.Label_Format.Name = "Label_Format"
        Me.Label_Format.Size = New System.Drawing.Size(57, 15)
        Me.Label_Format.TabIndex = 4
        Me.Label_Format.Text = "FORMAT"
        '
        'Button_Small
        '
        Me.Button_Small.Location = New System.Drawing.Point(312, 214)
        Me.Button_Small.Name = "Button_Small"
        Me.Button_Small.Size = New System.Drawing.Size(39, 37)
        Me.Button_Small.TabIndex = 5
        Me.Button_Small.Text = "S"
        Me.Button_Small.UseVisualStyleBackColor = True
        '
        'Button_Medium
        '
        Me.Button_Medium.Location = New System.Drawing.Point(372, 214)
        Me.Button_Medium.Name = "Button_Medium"
        Me.Button_Medium.Size = New System.Drawing.Size(39, 37)
        Me.Button_Medium.TabIndex = 6
        Me.Button_Medium.Text = "M"
        Me.Button_Medium.UseVisualStyleBackColor = True
        '
        'Button_Large
        '
        Me.Button_Large.Location = New System.Drawing.Point(432, 214)
        Me.Button_Large.Name = "Button_Large"
        Me.Button_Large.Size = New System.Drawing.Size(39, 37)
        Me.Button_Large.TabIndex = 7
        Me.Button_Large.Text = "L"
        Me.Button_Large.UseVisualStyleBackColor = True
        '
        'Label_Police
        '
        Me.Label_Police.AutoSize = True
        Me.Label_Police.Location = New System.Drawing.Point(363, 282)
        Me.Label_Police.Name = "Label_Police"
        Me.Label_Police.Size = New System.Drawing.Size(50, 15)
        Me.Label_Police.TabIndex = 8
        Me.Label_Police.Text = "POLICE"
        '
        'ComboBox_Police
        '
        Me.ComboBox_Police.FormattingEnabled = True
        Me.ComboBox_Police.Location = New System.Drawing.Point(333, 316)
        Me.ComboBox_Police.Name = "ComboBox_Police"
        Me.ComboBox_Police.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Police.TabIndex = 9
        '
        'TextBox_Opacity
        '
        Me.TextBox_Opacity.Location = New System.Drawing.Point(338, 145)
        Me.TextBox_Opacity.Name = "TextBox_Opacity"
        Me.TextBox_Opacity.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Opacity.TabIndex = 10
        '
        'Button_Return
        '
        Me.Button_Return.Location = New System.Drawing.Point(12, 12)
        Me.Button_Return.Name = "Button_Return"
        Me.Button_Return.Size = New System.Drawing.Size(39, 37)
        Me.Button_Return.TabIndex = 11
        Me.Button_Return.UseVisualStyleBackColor = True
        '
        'Label_Level
        '
        Me.Label_Level.AutoSize = True
        Me.Label_Level.Location = New System.Drawing.Point(367, 357)
        Me.Label_Level.Name = "Label_Level"
        Me.Label_Level.Size = New System.Drawing.Size(44, 15)
        Me.Label_Level.TabIndex = 12
        Me.Label_Level.Text = "LEVEL"
        '
        'Button_Easy
        '
        Me.Button_Easy.Location = New System.Drawing.Point(312, 391)
        Me.Button_Easy.Name = "Button_Easy"
        Me.Button_Easy.Size = New System.Drawing.Size(39, 37)
        Me.Button_Easy.TabIndex = 13
        Me.Button_Easy.Text = "E"
        Me.Button_Easy.UseVisualStyleBackColor = True
        '
        'Button_Normal
        '
        Me.Button_Normal.Location = New System.Drawing.Point(372, 391)
        Me.Button_Normal.Name = "Button_Normal"
        Me.Button_Normal.Size = New System.Drawing.Size(39, 37)
        Me.Button_Normal.TabIndex = 14
        Me.Button_Normal.Text = "N"
        Me.Button_Normal.UseVisualStyleBackColor = True
        '
        'Button_Hard
        '
        Me.Button_Hard.Location = New System.Drawing.Point(432, 391)
        Me.Button_Hard.Name = "Button_Hard"
        Me.Button_Hard.Size = New System.Drawing.Size(39, 37)
        Me.Button_Hard.TabIndex = 15
        Me.Button_Hard.Text = "H"
        Me.Button_Hard.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Hard)
        Me.Controls.Add(Me.Button_Normal)
        Me.Controls.Add(Me.Button_Easy)
        Me.Controls.Add(Me.Label_Level)
        Me.Controls.Add(Me.Button_Return)
        Me.Controls.Add(Me.TextBox_Opacity)
        Me.Controls.Add(Me.ComboBox_Police)
        Me.Controls.Add(Me.Label_Police)
        Me.Controls.Add(Me.Button_Large)
        Me.Controls.Add(Me.Button_Medium)
        Me.Controls.Add(Me.Button_Small)
        Me.Controls.Add(Me.Label_Format)
        Me.Controls.Add(Me.Label_Opacity)
        Me.Controls.Add(Me.Button_Off)
        Me.Controls.Add(Me.Button_ON)
        Me.Controls.Add(Me.Label_Sound)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Sound As Label
    Friend WithEvents Button_ON As Button
    Friend WithEvents Button_Off As Button
    Friend WithEvents Label_Opacity As Label
    Friend WithEvents Label_Format As Label
    Friend WithEvents Button_Small As Button
    Friend WithEvents Button_Medium As Button
    Friend WithEvents Button_Large As Button
    Friend WithEvents Label_Police As Label
    Friend WithEvents ComboBox_Police As ComboBox
    Friend WithEvents TextBox_Opacity As TextBox
    Friend WithEvents Button_Return As Button
    Friend WithEvents Label_Level As Label
    Friend WithEvents Button_Easy As Button
    Friend WithEvents Button_Normal As Button
    Friend WithEvents Button_Hard As Button
End Class
