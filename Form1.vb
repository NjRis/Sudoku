Public Class Form1

    Private Sub Button_Lune_Click(sender As Object, e As EventArgs) Handles Button_Lune.Click
        Dim originalImageNightMode As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\NightMode.png")
        Me.BackgroundImage = ResizeImage(originalImageNightMode, Me.Size)

        ' ajuster le style de l'image pour remplir le formulaire
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Private Sub Mode_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' redimensionner l'image de fond lorsque la taille du formulaire change
        If Me.BackgroundImage IsNot Nothing Then
            Me.BackgroundImage = ResizeImage(Me.BackgroundImage, Me.Size)
        End If
    End Sub

    Private Sub Button_Soleil_Click(sender As Object, e As EventArgs) Handles Button_Soleil.Click
        Dim originalImageLightMode As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\LightMode.jpeg")
        Me.BackgroundImage = ResizeImage(originalImageLightMode, Me.Size)

        ' ajuster le style de l'image pour remplir le formulaire
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim originalImage As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Background.jpg")
        Me.BackgroundImage = ResizeImage(originalImage, Me.Size)

        ' ajuster le style de l'image pour remplir le formulaire
        Me.BackgroundImageLayout = ImageLayout.Stretch

        ' redimensionner l'image du bouton Lune
        Dim originalImageLune As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Button_Lune.jpg")
        Dim resizedImageLune As Image = ResizeImage(originalImageLune, Button_Lune.Size)

        ' l'image redimensionnée au bouton Lune
        Button_Lune.Image = resizedImageLune
        Button_Lune.ImageAlign = ContentAlignment.MiddleCenter
        Button_Lune.TextImageRelation = TextImageRelation.ImageAboveText
        Button_Lune.BackgroundImageLayout = ImageLayout.Stretch

        ' redimensionner l'image du bouton Soleil
        Dim originalImageSoleil As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Button_Soleil.jpg")
        Dim resizedImageSoleil As Image = ResizeImage(originalImageSoleil, Button_Soleil.Size)

        ' l'image redimensionnée au bouton Soleil
        Button_Soleil.Image = resizedImageSoleil
        Button_Soleil.ImageAlign = ContentAlignment.MiddleCenter
        Button_Soleil.TextImageRelation = TextImageRelation.ImageAboveText
        Button_Soleil.BackgroundImageLayout = ImageLayout.Stretch

        ' redimensionner l'image du bouton Return
        Dim originalImageReturn As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Button_Return.jpg")
        Dim resizedImageReturn As Image = ResizeImage(originalImageReturn, Button_Return.Size)

        ' l'image redimensionnée au bouton Return
        Button_Return.Image = resizedImageReturn
        Button_Return.ImageAlign = ContentAlignment.MiddleCenter
        Button_Return.TextImageRelation = TextImageRelation.ImageAboveText
        Button_Return.BackgroundImageLayout = ImageLayout.Stretch
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
End Class
