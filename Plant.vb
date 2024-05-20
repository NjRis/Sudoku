Public Class Plant
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

    Private Sub Plant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim originalImagePlant As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Background_Plant.jpg")
        Me.BackgroundImage = ResizeImage(originalImagePlant, Me.Size)

        ' ajuster le style de l'image pour remplir le formulaire
        Me.BackgroundImageLayout = ImageLayout.Stretch
        ' redimensionner l'image du bouton Return
        Dim originalImageReturn As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Button_Return.jpg")
        Dim resizedImageReturn As Image = ResizeImage(originalImageReturn, Button_Return.Size)

        ' l'image redimensionnée au bouton Return
        Button_Return.Image = resizedImageReturn
        Button_Return.ImageAlign = ContentAlignment.MiddleCenter
        Button_Return.TextImageRelation = TextImageRelation.ImageAboveText
        Button_Return.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class