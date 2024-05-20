<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button_Lune = New System.Windows.Forms.Button()
        Me.Button_Soleil = New System.Windows.Forms.Button()
        Me.Button_Return = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Lune
        '
        Me.Button_Lune.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_Lune.BackColor = System.Drawing.Color.Transparent
        Me.Button_Lune.Location = New System.Drawing.Point(702, 12)
        Me.Button_Lune.Name = "Button_Lune"
        Me.Button_Lune.Size = New System.Drawing.Size(39, 33)
        Me.Button_Lune.TabIndex = 0
        Me.Button_Lune.UseVisualStyleBackColor = False
        '
        'Button_Soleil
        '
        Me.Button_Soleil.Location = New System.Drawing.Point(747, 12)
        Me.Button_Soleil.Name = "Button_Soleil"
        Me.Button_Soleil.Size = New System.Drawing.Size(41, 33)
        Me.Button_Soleil.TabIndex = 1
        Me.Button_Soleil.UseVisualStyleBackColor = True
        '
        'Button_Return
        '
        Me.Button_Return.Location = New System.Drawing.Point(13, 12)
        Me.Button_Return.Name = "Button_Return"
        Me.Button_Return.Size = New System.Drawing.Size(38, 32)
        Me.Button_Return.TabIndex = 2
        Me.Button_Return.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Return)
        Me.Controls.Add(Me.Button_Soleil)
        Me.Controls.Add(Me.Button_Lune)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Lune As Button
    Friend WithEvents Button_Soleil As Button
    Friend WithEvents Button_Return As Button
End Class
