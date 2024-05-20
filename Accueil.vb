Public Class Accueil

    ' variable où le soundtrack est stocké
    Private WithEvents soundPlayer As System.Media.SoundPlayer

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ici on utilise la classe Music Manager
        MusicManager.StartMusic()

        Dim originalImageAccueil As Image = Image.FromFile("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\IMAGES\Background.jpg")
        Me.BackgroundImage = ResizeImage(originalImageAccueil, Me.Size)

        ' ajuster le style de l'image pour remplir le formulaire
        Me.BackgroundImageLayout = ImageLayout.Stretch

        ' cacher le Button_Continue tant qu'aucune partie n'a été commencé. a mettre dans une boucle + Event MouseClick
        Button_Continue.Hide()

        ' CenterControls(Me)

    End Sub


    Private Sub Accueil_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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

    ' gestionnaire d'event quand le formulaire close
    Private Sub Accueil_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MusicManager.StopMusic()
    End Sub

    Private Sub Button_Play_Click(sender As Object, e As EventArgs) Handles Button_Play.Click
        Dim result As DialogResult = MessageBox.Show("Es-tu prêt à jouer ?!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Button_Mode_Click(sender As Object, e As EventArgs) Handles Button_Mode.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous accéder au mode ?", "Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Hide()
            Mode.Show()
        End If
    End Sub

    Private Sub Button_Settings_Click(sender As Object, e As EventArgs) Handles Button_Settings.Click
        Dim result As DialogResult = MessageBox.Show("Voulez-vous accéder aux paramètres ?", "Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Hide()
            Settings.Show()
        End If
    End Sub
End Class