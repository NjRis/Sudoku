Public Class Mode

    Private Sub Mode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim originalImageMode As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Background.jpg")
        Me.BackgroundImage = ResizeImage(originalImageMode, Me.Size)

        ' ajuster le style de l'image pour remplir le formulaire
        Me.BackgroundImageLayout = ImageLayout.Stretch

        ' redimensionner l'image du bouton TimerOn
        Dim originalImageTimerOn As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Button_TimerOn.png")
        Dim resizedImageTimerOn As Image = ResizeImage(originalImageTimerOn, Button_TimerOn.Size)

        ' l'image redimensionnée au bouton TimerOn
        Button_TimerOn.Image = resizedImageTimerOn
        Button_TimerOn.ImageAlign = ContentAlignment.MiddleCenter
        Button_TimerOn.TextImageRelation = TextImageRelation.ImageAboveText
        Button_TimerOn.BackgroundImageLayout = ImageLayout.Stretch

        ' redimensionner l'image du bouton TimerOff
        Dim originalImageTimerOff As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Button_TimerOff.png")
        Dim resizedImageTimerOff As Image = ResizeImage(originalImageTimerOff, Button_TimerOff.Size)

        ' l'image redimensionnée au bouton Off
        Button_TimerOff.Image = resizedImageTimerOff
        Button_TimerOff.ImageAlign = ContentAlignment.MiddleCenter
        Button_TimerOff.TextImageRelation = TextImageRelation.ImageAboveText
        Button_TimerOff.BackgroundImageLayout = ImageLayout.Stretch

        ' redimensionner l'image du bouton Return
        Dim originalImageReturn As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Button_Return.jpg")
        Dim resizedImageReturn As Image = ResizeImage(originalImageReturn, Button_Return.Size)

        ' l'image redimensionnée au bouton Return
        Button_Return.Image = resizedImageReturn
        Button_Return.ImageAlign = ContentAlignment.MiddleCenter
        Button_Return.TextImageRelation = TextImageRelation.ImageAboveText
        Button_Return.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Mode_Resize(sender As Object, e As EventArgs) Handles Me.Resize ' retirer plus tard
        ' redimensionner l'image de fond lorsque la taille du formulaire change
        If Me.BackgroundImage IsNot Nothing Then
            Me.BackgroundImage = ResizeImage(Me.BackgroundImage, Me.Size)
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

    Private Sub Button_Return_Click(sender As Object, e As EventArgs) Handles Button_Return.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment retourner à l'accueil ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Accueil.Show()
        End If
    End Sub

    Private Sub Button_Kawai_Click(sender As Object, e As EventArgs) Handles Button_Kawai.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous accéder au mode Kawai ?", "Kawai Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Hide()
            Kawai.Show()
        End If
    End Sub

    Private Sub Button_Minecraft_Click(sender As Object, e As EventArgs) Handles Button_Minecraft.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous accéder au mode Minecraft ?", "Minecraft Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Hide()
            Minecraft.Show()
        End If
    End Sub

    Private Sub Button_Customize_Click(sender As Object, e As EventArgs) Handles Button_Customize.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous accéder au mode Customize ?", "Customize Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Hide()
            Customize.Show()
        End If
    End Sub

    Private Sub Button_Plant_Click(sender As Object, e As EventArgs) Handles Button_Plant.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous accéder au mode Plant ?", "Plant Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Hide()
            Plant.Show()
        End If
    End Sub
End Class