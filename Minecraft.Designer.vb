<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Minecraft
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_Return = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Return
        '
        Me.Button_Return.Location = New System.Drawing.Point(13, 13)
        Me.Button_Return.Name = "Button_Return"
        Me.Button_Return.Size = New System.Drawing.Size(35, 35)
        Me.Button_Return.TabIndex = 0
        Me.Button_Return.UseVisualStyleBackColor = True
        '
        'Minecraft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Return)
        Me.Name = "Minecraft"
        Me.Text = "Minecraft"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Return As Button
End Class
