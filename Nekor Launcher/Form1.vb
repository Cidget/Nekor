Public Class frmVideoGameLauncher

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbxMusicMute.Appearance = Appearance.Button
        My.Computer.Audio.Play(My.Resources._2018_04_11_17_24_55, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub cbxMusicMute_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMusicMute.CheckedChanged

        cbxMusicMute.Text = "Play Music"

        If cbxMusicMute.Checked = True Then

            My.Computer.Audio.Stop()

        End If

        If cbxMusicMute.Checked = False Then

            My.Computer.Audio.Play(My.Resources._2018_04_11_17_24_55, AudioPlayMode.BackgroundLoop)
            cbxMusicMute.Text = "Stop Music"

        End If

    End Sub

    Private Sub btnWebsite_Click(sender As Object, e As EventArgs) Handles btnWebsite.Click

        Process.Start("https://maya3d-animation.weebly.com/")

    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click

        tmrTime.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick

        pbrGameProgress.Increment(5)

        If pbrGameProgress.Value = 100 Then

            tmrTime.Stop()

            MsgBox("No File Found", , "ERROR")

        End If

    End Sub

End Class
