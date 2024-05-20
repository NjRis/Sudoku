Public Class Settings
    Private Sub Button_ON_Click(sender As Object, e As EventArgs) Handles Button_ON.Click
        MusicManager.StartMusic()
    End Sub

    Private Sub Button_Off_Click(sender As Object, e As EventArgs) Handles Button_Off.Click
        MusicManager.StopMusic()
    End Sub

    Private Sub Settings_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' redimensionner l'image de fond lorsque la taille du formulaire change
        If Me.BackgroundImage IsNot Nothing Then
            Me.BackgroundImage = ResizeImage(Me.BackgroundImage, Me.Size)
        End If

    End Sub

    Private Sub TextBox_Opacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Opacity.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private isUpdating As Boolean = False

    Private Sub TextBox_Opacity_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Opacity.TextChanged
        If isUpdating Then Return

        Dim opacityValue As Integer
        If Integer.TryParse(TextBox_Opacity.Text, opacityValue) Then
            If opacityValue < 20 Then
                MessageBox.Show("La valeur minimale requise est 20.", "Valeur trop basse", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                isUpdating = True
                TextBox_Opacity.Text = "20"
                TextBox_Opacity.SelectAll()
                isUpdating = False
                Return
            End If
            Dim opacity As Double = opacityValue / 100.0
            For Each form As Form In Application.OpenForms
                form.Opacity = opacity
            Next
        End If
    End Sub

    Private Sub Button_Small_Click(sender As Object, e As EventArgs) Handles Button_Small.Click
        ResizeForms(0.5)
    End Sub

    Private Sub Button_Medium_Click(sender As Object, e As EventArgs) Handles Button_Medium.Click
        ResizeForms(0.75)
    End Sub

    Private Sub Button_Large_Click(sender As Object, e As EventArgs) Handles Button_Large.Click
        ResizeForms(1.0)
    End Sub

    Private Sub ResizeForms(factor As Double)
        For Each form As Form In Application.OpenForms
            form.WindowState = FormWindowState.Normal
            form.Size = New Size(CInt(Screen.PrimaryScreen.WorkingArea.Width * factor), CInt(Screen.PrimaryScreen.WorkingArea.Height * factor))
            form.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - form.Width) \ 2, (Screen.PrimaryScreen.WorkingArea.Height - form.Height) \ 2)
        Next
    End Sub

    Private Sub ComboBox_Police_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Police.SelectedIndexChanged
        Dim selectedFont As String = ComboBox_Police.SelectedItem.ToString()
        Dim newFont As New Font(selectedFont, 10) ' Taille de police par défaut
        For Each form As Form In Application.OpenForms
            UpdateLabelsFont(form, newFont)
        Next
    End Sub

    Private Sub UpdateLabelsFont(ctrl As Control, font As Font)
        If TypeOf ctrl Is Label Then
            DirectCast(ctrl, Label).Font = font
        End If
        For Each childCtrl As Control In ctrl.Controls
            UpdateLabelsFont(childCtrl, font)
        Next
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each font As FontFamily In FontFamily.Families
            ComboBox_Police.Items.Add(font.Name)
        Next

        Dim originalImageAccueil As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Background.jpg")
        Me.BackgroundImage = ResizeImage(originalImageAccueil, Me.Size)

        ' ajuster le style de l'image pour remplir le formulaire
        Me.BackgroundImageLayout = ImageLayout.Stretch

        ' cap max opacité
        TextBox_Opacity.MaxLength = 3

        ' centre les contrôles lors du chargement
        ' CenterControls(Me)

        ' redimensionner l'image du bouton Off
        Dim originalImageOff As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Button_Mute.jpg")
        Dim resizedImageOff As Image = ResizeImage(originalImageOff, Button_Off.Size)

        ' l'image redimensionnée au bouton Off
        Button_Off.Image = resizedImageOff
        Button_Off.ImageAlign = ContentAlignment.MiddleCenter
        Button_Off.TextImageRelation = TextImageRelation.ImageAboveText
        Button_Off.BackgroundImageLayout = ImageLayout.Stretch

        ' redimensionner l'image du bouton On
        Dim originalImageOn As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Button_Mic.jpg")
        Dim resizedImageOn As Image = ResizeImage(originalImageOn, Button_ON.Size)

        ' l'image redimensionnée au bouton On
        Button_ON.Image = resizedImageOn
        Button_ON.ImageAlign = ContentAlignment.MiddleCenter
        Button_ON.TextImageRelation = TextImageRelation.ImageAboveText
        Button_ON.BackgroundImageLayout = ImageLayout.Stretch


        ' redimensionner l'image du bouton Return
        Dim originalImageReturn As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Button_Return.jpg")
        Dim resizedImageReturn As Image = ResizeImage(originalImageReturn, Button_Return.Size)

        ' l'image redimensionnée au bouton Return
        Button_Return.Image = resizedImageReturn
        Button_Return.ImageAlign = ContentAlignment.MiddleCenter
        Button_Return.TextImageRelation = TextImageRelation.ImageAboveText
        Button_Return.BackgroundImageLayout = ImageLayout.Stretch

        ' centre les contrôles lors du chargement = pas fonctionnel
        ' CenterControls(Me)

    End Sub

    'Private Sub Settings_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    '    CenterControls(Me)
    'End Sub

    Private Sub Button_Return_Click(sender As Object, e As EventArgs) Handles Button_Return.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment retourner à l'accueil ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Accueil.Show()
        End If
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

End Class
