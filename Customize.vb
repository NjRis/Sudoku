Imports System.Runtime.Serialization.Formatters.Binary

Public Class Customize
    Private originalSettings As New Dictionary(Of String, Color)
    Private selectedBackgroundImage As Image

    Private Sub Customize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' redimensionner et configurer les images des boutons
        ConfigureButtonImage(Button_Return, "Button_Return.jpg")
        ConfigureButtonImage(Button_Help, "Button_Help.jpg")
        ConfigureButtonImage(Button_ApplyColor, "Button_ApplyColor.png")
        ConfigureButtonImage(Button_ImportImage, "Button_ImportImage.png")
        ConfigureButtonImage(Button_SaveSettings, "Button_SaveSettings.png")
        'configureButtonImage(Button_LoadSettings, "Button_LoadSettings.png")
        ConfigureButtonImage(Button_RestoreDefaults, "Button_RestoreDefaults.png")

        ' ajouter les couleurs et les boutons à leurs ListBox
        ListBox_Colors.Items.AddRange([Enum].GetNames(GetType(KnownColor)))
        ListBox_Buttons.Items.AddRange(New String() {"Button_Return", "Button_SaveSettings", "Button_RestoreDefaults", "Button_Start"})

        ' sauvegarder les paramètres originaux des boutons
        SaveOriginalSettings()
    End Sub

    Private Sub ConfigureButtonImage(button As Button, imageName As String)
        Dim originalImage As Image = Image.FromFile($"C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\{imageName}")
        Dim resizedImage As Image = ResizeImage(originalImage, button.Size)
        button.Image = resizedImage
        button.ImageAlign = ContentAlignment.MiddleCenter
        button.TextImageRelation = TextImageRelation.ImageAboveText
        button.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Function ResizeImage(ByVal img As Image, ByVal newSize As Size) As Image
        Dim ratioX As Double = newSize.Width / CDbl(img.Width)
        Dim ratioY As Double = newSize.Height / CDbl(img.Height)
        Dim ratio As Double = Math.Min(ratioX, ratioY)
        Dim newWidth As Integer = CInt(img.Width * ratio)
        Dim newHeight As Integer = CInt(img.Height * ratio)
        Dim newImg As New Bitmap(newWidth, newHeight)
        Using g As Graphics = Graphics.FromImage(newImg)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(img, 0, 0, newWidth, newHeight)
        End Using
        Return newImg
    End Function

    Private Sub ListBox_Colors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Colors.SelectedIndexChanged
        ApplyColorPreview()
    End Sub

    Private Sub ListBox_Buttons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Buttons.SelectedIndexChanged
        ApplyColorPreview()
    End Sub

    Private Sub ApplyColorPreview()
        If ListBox_Colors.SelectedItem IsNot Nothing AndAlso ListBox_Buttons.SelectedItem IsNot Nothing Then
            Dim selectedColorName As String = ListBox_Colors.SelectedItem.ToString()
            Dim selectedButtonName As String = ListBox_Buttons.SelectedItem.ToString()
            Dim selectedColor As Color = Color.FromName(selectedColorName)

            Dim button As Button = Me.Controls.OfType(Of Button)().FirstOrDefault(Function(b) b.Name = selectedButtonName)
            If button IsNot Nothing Then
                button.BackColor = selectedColor
            End If
        End If
    End Sub

    Private Sub Button_Return_Click(sender As Object, e As EventArgs) Handles Button_Return.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment retourner au Mode ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            'RestoreOriginalSettings()
            Me.Hide()
            Mode.Show()
        End If
    End Sub

    Private Sub Button_Help_Click(sender As Object, e As EventArgs) Handles Button_Help.Click
        MessageBox.Show("Utilisez cette fenêtre pour personnaliser les paramètres suivants :" & vbCrLf &
                        "- Importer une image comme arrière-plan" & vbCrLf &
                        "- Appliquer des couleurs aux boutons" & vbCrLf &
                        "- Sauvegarder et charger les paramètres" & vbCrLf &
                        "- Restaurer les paramètres par défaut", "Aide", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button_ApplyColor_Click(sender As Object, e As EventArgs) Handles Button_ApplyColor.Click
        ApplyColorPreview()
    End Sub

    Private Sub Button_ImportImage_Click(sender As Object, e As EventArgs) Handles Button_ImportImage.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                selectedBackgroundImage = Image.FromFile(openFileDialog.FileName)
                Me.BackgroundImage = ResizeImage(selectedBackgroundImage, Me.Size)
                Me.BackgroundImageLayout = ImageLayout.Stretch
            End If
        End Using
    End Sub

    Private Sub Button_SaveSettings_Click(sender As Object, e As EventArgs) Handles Button_SaveSettings.Click
        SaveSettings()
    End Sub

    Private Sub SaveSettings()
        Dim settings As New Dictionary(Of String, Object)
        settings("BackgroundImage") = selectedBackgroundImage
        settings(Button_Return.Name) = Button_Return.BackColor
        settings(Button_SaveSettings.Name) = Button_SaveSettings.BackColor
        settings(Button_RestoreDefaults.Name) = Button_RestoreDefaults.BackColor
        settings(Button_Start.Name) = Button_Start.BackColor

        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Settings Files|*.settings"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Using stream As New IO.FileStream(saveFileDialog.FileName, IO.FileMode.Create)
                    Dim formatter As New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                    formatter.Serialize(stream, settings)
                End Using
            End If
        End Using
    End Sub

    'Private Sub Button_LoadSettings_Click(sender As Object, e As EventArgs) Handles Button_LoadSettings.Click
    '    Using openFileDialog As New OpenFileDialog()
    '        openFileDialog.Filter = "Settings Files|*.settings"
    '        If openFileDialog.ShowDialog() = DialogResult.OK Then
    '            Using stream As New IO.FileStream(openFileDialog.FileName, IO.FileMode.Open)
    '                Dim formatter As New Runtime.Serialization.Formatters.Binary.BinaryFormatter()
    '                Dim settings As Dictionary(Of String, Color) = DirectCast(formatter.Deserialize(stream), Dictionary(Of String, Color))

    '                ApplySettings(settings)
    '            End Using
    '        End If
    '    End Using
    'End Sub

    Private Sub ApplySettings(settings As Dictionary(Of String, Object))
        If settings.ContainsKey("BackgroundImage") Then
            selectedBackgroundImage = TryCast(settings("BackgroundImage"), Image)
            If selectedBackgroundImage IsNot Nothing Then
                Me.BackgroundImage = selectedBackgroundImage
                Me.BackgroundImageLayout = ImageLayout.Stretch
            End If
        End If

        If settings.ContainsKey(Button_Return.Name) Then
            Button_Return.BackColor = ConvertToColor(settings(Button_Return.Name))
        End If

        If settings.ContainsKey(Button_SaveSettings.Name) Then
            Button_SaveSettings.BackColor = ConvertToColor(settings(Button_SaveSettings.Name))
        End If

        If settings.ContainsKey(Button_RestoreDefaults.Name) Then
            Button_RestoreDefaults.BackColor = ConvertToColor(settings(Button_RestoreDefaults.Name))
        End If

        If settings.ContainsKey(Button_Start.Name) Then
            Button_Start.BackColor = ConvertToColor(settings(Button_Start.Name))
        End If
    End Sub

    Private Function ConvertToColor(value As Object) As Color
        If TypeOf value Is Color Then
            Return DirectCast(value, Color)
        ElseIf TypeOf value Is String Then
            Return Color.FromName(value.ToString())
        Else
            Throw New InvalidCastException("Invalid color value in settings.")
        End If
    End Function

    Private Sub Button_RestoreDefaults_Click(sender As Object, e As EventArgs) Handles Button_RestoreDefaults.Click
        RestoreOriginalSettings()
    End Sub

    Private Sub RestoreOriginalSettings()
        Button_Return.BackColor = originalSettings(Button_Return.Name)
        Button_Import.BackColor = originalSettings(Button_Import.Name)
        Button_SaveSettings.BackColor = originalSettings(Button_SaveSettings.Name)
        Button_RestoreDefaults.BackColor = originalSettings(Button_RestoreDefaults.Name)
        Button_Start.BackColor = originalSettings(Button_Start.Name)
    End Sub

    Private Sub SaveOriginalSettings()
        originalSettings.Clear()
        originalSettings(Button_Return.Name) = Button_Return.BackColor
        originalSettings(Button_Import.Name) = Button_Import.BackColor
        originalSettings(Button_SaveSettings.Name) = Button_SaveSettings.BackColor
        originalSettings(Button_RestoreDefaults.Name) = Button_RestoreDefaults.BackColor
        originalSettings(Button_Start.Name) = Button_Start.BackColor
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        If AreAllModificationsComplete() Then
            Me.Hide()
            Dim customizeGameForm As New CustomizeGame()
            ApplyModificationsToCustomizeGame(customizeGameForm)
            customizeGameForm.Show()
        Else
            MessageBox.Show("Veuillez compléter toutes les modifications avant de continuer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CustomizeGameForm_ReturnClicked(sender As Object, e As EventArgs)
        'RestoreOriginalSettings()
        Me.Show()
    End Sub

    Private Function AreAllModificationsComplete() As Boolean
        Return selectedBackgroundImage IsNot Nothing AndAlso ListBox_Colors.SelectedItem IsNot Nothing AndAlso ListBox_Buttons.SelectedItem IsNot Nothing
    End Function

    Private Sub ApplyModificationsToCustomizeGame(customizeGameForm As CustomizeGame)
        ' appliquer l'image de fond
        If selectedBackgroundImage IsNot Nothing Then
            customizeGameForm.BackgroundImage = selectedBackgroundImage
            customizeGameForm.BackgroundImageLayout = ImageLayout.Stretch
        End If

        ' Appliquer les couleurs des boutons
        customizeGameForm.Button_Return.BackColor = Button_Return.BackColor
        'customizeGameForm.Button_LoadSettings.BackColor = Button_LoadSettings.BackColor
        'customizeGameForm.Button_SaveSettings.BackColor = Button_SaveSettings.BackColor
        'customizeGameForm.Button_RestoreDefaults.BackColor = Button_RestoreDefaults.BackColor
        'customizeGameForm.Button_Start.BackColor = Button_Start.BackColor
    End Sub

    Private Sub Button_Import_Click(sender As Object, e As EventArgs) Handles Button_Import.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Settings Files|*.settings"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Using stream As New IO.FileStream(openFileDialog.FileName, IO.FileMode.Open)
                    Dim formatter As New BinaryFormatter()
                    Dim settings As Dictionary(Of String, Object) = DirectCast(formatter.Deserialize(stream), Dictionary(Of String, Object))

                    ApplySettings(settings)
                End Using
            End If
        End Using
    End Sub

    Private Sub Customize_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Me.Visible Then
            ResetToDefaultSettings()
        End If
    End Sub

    Private Sub ResetToDefaultSettings()
        Me.BackgroundImage = Nothing
        Button_Return.BackColor = SystemColors.Control
        Button_SaveSettings.BackColor = SystemColors.Control
        Button_RestoreDefaults.BackColor = SystemColors.Control
        Button_Start.BackColor = SystemColors.Control
    End Sub
End Class





