<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mode
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
        Me.Button_Kawai = New System.Windows.Forms.Button()
        Me.Button_Minecraft = New System.Windows.Forms.Button()
        Me.Button_Customize = New System.Windows.Forms.Button()
        Me.Button_Plant = New System.Windows.Forms.Button()
        Me.Button_Return = New System.Windows.Forms.Button()
        Me.Button_TimerOff = New System.Windows.Forms.Button()
        Me.Button_TimerOn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Kawai
        '
        Me.Button_Kawai.Location = New System.Drawing.Point(312, 90)
        Me.Button_Kawai.Name = "Button_Kawai"
        Me.Button_Kawai.Size = New System.Drawing.Size(144, 58)
        Me.Button_Kawai.TabIndex = 0
        Me.Button_Kawai.Text = "KAWAI"
        Me.Button_Kawai.UseVisualStyleBackColor = True
        '
        'Button_Minecraft
        '
        Me.Button_Minecraft.Location = New System.Drawing.Point(312, 154)
        Me.Button_Minecraft.Name = "Button_Minecraft"
        Me.Button_Minecraft.Size = New System.Drawing.Size(144, 58)
        Me.Button_Minecraft.TabIndex = 2
        Me.Button_Minecraft.Text = "MINECRAFT"
        Me.Button_Minecraft.UseVisualStyleBackColor = True
        '
        'Button_Customize
        '
        Me.Button_Customize.Location = New System.Drawing.Point(312, 282)
        Me.Button_Customize.Name = "Button_Customize"
        Me.Button_Customize.Size = New System.Drawing.Size(144, 58)
        Me.Button_Customize.TabIndex = 3
        Me.Button_Customize.Text = "CUSTOMIZE"
        Me.Button_Customize.UseVisualStyleBackColor = True
        '
        'Button_Plant
        '
        Me.Button_Plant.Location = New System.Drawing.Point(312, 218)
        Me.Button_Plant.Name = "Button_Plant"
        Me.Button_Plant.Size = New System.Drawing.Size(144, 58)
        Me.Button_Plant.TabIndex = 4
        Me.Button_Plant.Text = "PLANT"
        Me.Button_Plant.UseVisualStyleBackColor = True
        '
        'Button_Return
        '
        Me.Button_Return.Location = New System.Drawing.Point(13, 13)
        Me.Button_Return.Name = "Button_Return"
        Me.Button_Return.Size = New System.Drawing.Size(41, 33)
        Me.Button_Return.TabIndex = 5
        Me.Button_Return.UseVisualStyleBackColor = True
        '
        'Button_TimerOff
        '
        Me.Button_TimerOff.Location = New System.Drawing.Point(393, 380)
        Me.Button_TimerOff.Name = "Button_TimerOff"
        Me.Button_TimerOff.Size = New System.Drawing.Size(39, 37)
        Me.Button_TimerOff.TabIndex = 17
        Me.Button_TimerOff.UseVisualStyleBackColor = True
        '
        'Button_TimerOn
        '
        Me.Button_TimerOn.Location = New System.Drawing.Point(327, 380)
        Me.Button_TimerOn.Name = "Button_TimerOn"
        Me.Button_TimerOn.Size = New System.Drawing.Size(39, 37)
        Me.Button_TimerOn.TabIndex = 16
        Me.Button_TimerOn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(357, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "TIMER"
        '
        'Mode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_TimerOff)
        Me.Controls.Add(Me.Button_TimerOn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Return)
        Me.Controls.Add(Me.Button_Plant)
        Me.Controls.Add(Me.Button_Customize)
        Me.Controls.Add(Me.Button_Minecraft)
        Me.Controls.Add(Me.Button_Kawai)
        Me.Name = "Mode"
        Me.Text = "Mode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Kawai As Button
    Friend WithEvents Button_Minecraft As Button
    Friend WithEvents Button_Customize As Button
    Friend WithEvents Button_Plant As Button
    Friend WithEvents Button_Return As Button
    Friend WithEvents Button_TimerOff As Button
    Friend WithEvents Button_TimerOn As Button
    Friend WithEvents Label1 As Label
End Class
