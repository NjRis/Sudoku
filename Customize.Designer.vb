<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customize
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
        Me.ListBox_Colors = New System.Windows.Forms.ListBox()
        Me.OpenFileDialogCustomize = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox_Buttons = New System.Windows.Forms.ListBox()
        Me.Button_Help = New System.Windows.Forms.Button()
        Me.Button_RestoreDefaults = New System.Windows.Forms.Button()
        Me.Button_Import = New System.Windows.Forms.Button()
        Me.Button_SaveSettings = New System.Windows.Forms.Button()
        Me.Button_ApplyColor = New System.Windows.Forms.Button()
        Me.Button_ImportImage = New System.Windows.Forms.Button()
        Me.Label_Return = New System.Windows.Forms.Label()
        Me.Label_RestoreDefaults = New System.Windows.Forms.Label()
        Me.Label_Save = New System.Windows.Forms.Label()
        Me.Label__Import = New System.Windows.Forms.Label()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Return
        '
        Me.Button_Return.Location = New System.Drawing.Point(5, 17)
        Me.Button_Return.Name = "Button_Return"
        Me.Button_Return.Size = New System.Drawing.Size(42, 40)
        Me.Button_Return.TabIndex = 0
        Me.Button_Return.UseVisualStyleBackColor = True
        '
        'ListBox_Colors
        '
        Me.ListBox_Colors.FormattingEnabled = True
        Me.ListBox_Colors.Location = New System.Drawing.Point(242, 106)
        Me.ListBox_Colors.Name = "ListBox_Colors"
        Me.ListBox_Colors.Size = New System.Drawing.Size(120, 95)
        Me.ListBox_Colors.TabIndex = 1
        '
        'OpenFileDialogCustomize
        '
        Me.OpenFileDialogCustomize.FileName = "OpenFileDialog1"
        '
        'ListBox_Buttons
        '
        Me.ListBox_Buttons.FormattingEnabled = True
        Me.ListBox_Buttons.Location = New System.Drawing.Point(388, 106)
        Me.ListBox_Buttons.Name = "ListBox_Buttons"
        Me.ListBox_Buttons.Size = New System.Drawing.Size(120, 95)
        Me.ListBox_Buttons.TabIndex = 2
        '
        'Button_Help
        '
        Me.Button_Help.Location = New System.Drawing.Point(746, 12)
        Me.Button_Help.Name = "Button_Help"
        Me.Button_Help.Size = New System.Drawing.Size(42, 36)
        Me.Button_Help.TabIndex = 3
        Me.Button_Help.UseVisualStyleBackColor = True
        '
        'Button_RestoreDefaults
        '
        Me.Button_RestoreDefaults.Location = New System.Drawing.Point(6, 392)
        Me.Button_RestoreDefaults.Name = "Button_RestoreDefaults"
        Me.Button_RestoreDefaults.Size = New System.Drawing.Size(42, 40)
        Me.Button_RestoreDefaults.TabIndex = 4
        Me.Button_RestoreDefaults.UseVisualStyleBackColor = True
        '
        'Button_Import
        '
        Me.Button_Import.Location = New System.Drawing.Point(686, 392)
        Me.Button_Import.Name = "Button_Import"
        Me.Button_Import.Size = New System.Drawing.Size(42, 40)
        Me.Button_Import.TabIndex = 5
        Me.Button_Import.UseVisualStyleBackColor = True
        '
        'Button_SaveSettings
        '
        Me.Button_SaveSettings.Location = New System.Drawing.Point(746, 392)
        Me.Button_SaveSettings.Name = "Button_SaveSettings"
        Me.Button_SaveSettings.Size = New System.Drawing.Size(42, 40)
        Me.Button_SaveSettings.TabIndex = 6
        Me.Button_SaveSettings.UseVisualStyleBackColor = True
        '
        'Button_ApplyColor
        '
        Me.Button_ApplyColor.Location = New System.Drawing.Point(242, 238)
        Me.Button_ApplyColor.Name = "Button_ApplyColor"
        Me.Button_ApplyColor.Size = New System.Drawing.Size(266, 31)
        Me.Button_ApplyColor.TabIndex = 8
        Me.Button_ApplyColor.UseVisualStyleBackColor = True
        '
        'Button_ImportImage
        '
        Me.Button_ImportImage.Location = New System.Drawing.Point(242, 275)
        Me.Button_ImportImage.Name = "Button_ImportImage"
        Me.Button_ImportImage.Size = New System.Drawing.Size(266, 31)
        Me.Button_ImportImage.TabIndex = 9
        Me.Button_ImportImage.UseVisualStyleBackColor = True
        '
        'Label_Return
        '
        Me.Label_Return.AutoSize = True
        Me.Label_Return.Location = New System.Drawing.Point(3, -1)
        Me.Label_Return.Name = "Label_Return"
        Me.Label_Return.Size = New System.Drawing.Size(44, 15)
        Me.Label_Return.TabIndex = 10
        Me.Label_Return.Text = "Return"
        '
        'Label_RestoreDefaults
        '
        Me.Label_RestoreDefaults.AutoSize = True
        Me.Label_RestoreDefaults.Location = New System.Drawing.Point(3, 435)
        Me.Label_RestoreDefaults.Name = "Label_RestoreDefaults"
        Me.Label_RestoreDefaults.Size = New System.Drawing.Size(101, 15)
        Me.Label_RestoreDefaults.TabIndex = 11
        Me.Label_RestoreDefaults.Text = "Restore Defaukts"
        '
        'Label_Save
        '
        Me.Label_Save.AutoSize = True
        Me.Label_Save.Location = New System.Drawing.Point(754, 435)
        Me.Label_Save.Name = "Label_Save"
        Me.Label_Save.Size = New System.Drawing.Size(34, 15)
        Me.Label_Save.TabIndex = 12
        Me.Label_Save.Text = "Save"
        '
        'Label__Import
        '
        Me.Label__Import.AutoSize = True
        Me.Label__Import.Location = New System.Drawing.Point(693, 435)
        Me.Label__Import.Name = "Label__Import"
        Me.Label__Import.Size = New System.Drawing.Size(42, 15)
        Me.Label__Import.TabIndex = 13
        Me.Label__Import.Text = "Import"
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(286, 342)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(169, 69)
        Me.Button_Start.TabIndex = 14
        Me.Button_Start.Text = "START"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Customize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.Label__Import)
        Me.Controls.Add(Me.Label_Save)
        Me.Controls.Add(Me.Label_RestoreDefaults)
        Me.Controls.Add(Me.Label_Return)
        Me.Controls.Add(Me.Button_ImportImage)
        Me.Controls.Add(Me.Button_ApplyColor)
        Me.Controls.Add(Me.Button_SaveSettings)
        Me.Controls.Add(Me.Button_Import)
        Me.Controls.Add(Me.Button_RestoreDefaults)
        Me.Controls.Add(Me.Button_Help)
        Me.Controls.Add(Me.ListBox_Buttons)
        Me.Controls.Add(Me.ListBox_Colors)
        Me.Controls.Add(Me.Button_Return)
        Me.Name = "Customize"
        Me.Text = "Customize"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Return As Button
    Friend WithEvents ListBox_Colors As ListBox
    Friend WithEvents OpenFileDialogCustomize As OpenFileDialog
    Friend WithEvents ListBox_Buttons As ListBox
    Friend WithEvents Button_Help As Button
    Friend WithEvents Button_RestoreDefaults As Button
    Friend WithEvents Button_Import As Button
    Friend WithEvents Button_SaveSettings As Button
    Friend WithEvents Button_ApplyColor As Button
    Friend WithEvents Button_ImportImage As Button
    Friend WithEvents Label_Return As Label
    Friend WithEvents Label_RestoreDefaults As Label
    Friend WithEvents Label_Save As Label
    Friend WithEvents Label__Import As Label
    Friend WithEvents Button_Start As Button
End Class
