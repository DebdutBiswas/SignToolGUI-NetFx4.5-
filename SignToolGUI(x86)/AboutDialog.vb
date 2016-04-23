Public Class AboutDialog

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const DROPSHADOW = &H30000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or DROPSHADOW

            Return cParam
        End Get
    End Property

    Private Sub AboutDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.InfoIcon
        FadeEffectOpenTimer.Enabled = True
        My.Computer.Audio.Play(My.Resources.Windows_Notify_Messaging, AudioPlayMode.Background)

        'Dim bmp As New Bitmap(My.Resources.ArrowCur, 20, 20)
        'bmp.MakeTransparent(Color.White)
        'Dim HandCursor As Cursor = New Cursor(bmp.GetHicon)
        'Me.Cursor = HandCursor
    End Sub

    Private Sub FadeEffectOpenTimer_Tick(sender As Object, e As EventArgs) Handles FadeEffectOpenTimer.Tick
        Me.Opacity += 0.05
    End Sub

    Private Sub FadeEffectCloseTimer_Tick(sender As Object, e As EventArgs) Handles FadeEffectCloseTimer.Tick
        FadeEffectOpenTimer.Enabled = False
        Me.Opacity -= 0.05
        If Me.Opacity = 0 Then Me.Close()
    End Sub

    Dim DialogDrag As Boolean
    Dim MouseX As Integer
    Dim MouseY As Integer

    Private Sub AboutDialog_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        DialogDrag = True
        MouseX = Windows.Forms.Cursor.Position.X - Me.Left
        MouseY = Windows.Forms.Cursor.Position.Y - Me.Top

    End Sub

    Private Sub AboutDialog_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        If DialogDrag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - MouseY
            Me.Left = Windows.Forms.Cursor.Position.X - MouseX
            Me.BackColor = Color.DarkGray
        End If

    End Sub

    Private Sub AboutDialog_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

        DialogDrag = False
        Me.BackColor = Color.Gray

    End Sub

    Private Sub AboutDialog_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave

        DialogDrag = False
        Me.BackColor = Color.Gray

    End Sub

    Private Sub CompanyLbl_Click(sender As Object, e As EventArgs) Handles CompanyLbl.Click

        My.Computer.Audio.Play(My.Resources.Windows_Navigation_Start, AudioPlayMode.Background)
        Process.Start("https://www.facebook.com/dev.software.development")

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click

        My.Computer.Audio.Play(My.Resources.Windows_Navigation_Start, AudioPlayMode.Background)
        FadeEffectCloseTimer.Enabled = True

    End Sub

End Class