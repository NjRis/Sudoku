<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomizeGame
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
        Me.Label_Return = New System.Windows.Forms.Label()
        Me.Button_Return = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_Return
        '
        Me.Label_Return.AutoSize = True
        Me.Label_Return.Location = New System.Drawing.Point(8, 0)
        Me.Label_Return.Name = "Label_Return"
        Me.Label_Return.Size = New System.Drawing.Size(44, 15)
        Me.Label_Return.TabIndex = 24
        Me.Label_Return.Text = "Return"
        '
        'Button_Return
        '
        Me.Button_Return.Location = New System.Drawing.Point(10, 18)
        Me.Button_Return.Name = "Button_Return"
        Me.Button_Return.Size = New System.Drawing.Size(42, 40)
        Me.Button_Return.TabIndex = 15
        Me.Button_Return.UseVisualStyleBackColor = True
        '
        'CustomizeGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label_Return)
        Me.Controls.Add(Me.Button_Return)
        Me.Name = "CustomizeGame"
        Me.Text = "CustomizeGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Return As Label
    Friend WithEvents Button_Return As Button
End Class
