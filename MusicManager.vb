Public Class MusicManager
    Private Shared soundPlayer As System.Media.SoundPlayer

    Public Shared Sub StartMusic()
        If soundPlayer Is Nothing Then
            soundPlayer = New System.Media.SoundPlayer("C:\Users\iris9\Desktop\B1.2\PD\IHM\BETA\BETA\BETA\SOUND\soundtrack.wav")
            soundPlayer.PlayLooping()
        Else
            soundPlayer.PlayLooping()
        End If
    End Sub

    Public Shared Sub StopMusic()
        If soundPlayer IsNot Nothing Then
            soundPlayer.Stop()
        End If
    End Sub
End Class
