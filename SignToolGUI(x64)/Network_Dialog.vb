Public Class Network_Dialog

    Private Sub Network_Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.InfoIcon
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
    End Sub

    Private Sub Network_Dialog_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Me.Close()
    End Sub

    Private Sub NetworkLbl_Click(sender As Object, e As EventArgs) Handles NetworkLbl.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class