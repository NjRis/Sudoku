<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        Me.Button_Play = New System.Windows.Forms.Button()
        Me.Button_Mode = New System.Windows.Forms.Button()
        Me.Button_Settings = New System.Windows.Forms.Button()
        Me.Button_Continue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Play
        '
        Me.Button_Play.Location = New System.Drawing.Point(318, 166)
        Me.Button_Play.Name = "Button_Play"
        Me.Button_Play.Size = New System.Drawing.Size(157, 51)
        Me.Button_Play.TabIndex = 0
        Me.Button_Play.Text = "PLAY"
        Me.Button_Play.UseVisualStyleBackColor = True
        '
        'Button_Mode
        '
        Me.Button_Mode.Location = New System.Drawing.Point(318, 223)
        Me.Button_Mode.Name = "Button_Mode"
        Me.Button_Mode.Size = New System.Drawing.Size(157, 51)
        Me.Button_Mode.TabIndex = 1
        Me.Button_Mode.Text = "MODE"
        Me.Button_Mode.UseVisualStyleBackColor = True
        '
        'Button_Settings
        '
        Me.Button_Settings.Location = New System.Drawing.Point(318, 280)
        Me.Button_Settings.Name = "Button_Settings"
        Me.Button_Settings.Size = New System.Drawing.Size(157, 51)
        Me.Button_Settings.TabIndex = 2
        Me.Button_Settings.Text = "SETTINGS"
        Me.Button_Settings.UseVisualStyleBackColor = True
        '
        'Button_Continue
        '
        Me.Button_Continue.Location = New System.Drawing.Point(318, 337)
        Me.Button_Continue.Name = "Button_Continue"
        Me.Button_Continue.Size = New System.Drawing.Size(157, 51)
        Me.Button_Continue.TabIndex = 3
        Me.Button_Continue.Text = "CONTINUE"
        Me.Button_Continue.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Continue)
        Me.Controls.Add(Me.Button_Settings)
        Me.Controls.Add(Me.Button_Mode)
        Me.Controls.Add(Me.Button_Play)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Play As Button
    Friend WithEvents Button_Mode As Button
    Friend WithEvents Button_Settings As Button
    Friend WithEvents Button_Continue As Button
End Class
