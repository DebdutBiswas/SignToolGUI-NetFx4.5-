
Public Class MainDialog

    Private Sub MainDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FadeEffectOpenTimer.Enabled = True
        If System.IO.File.Exists(Application.StartupPath + "\SignAPI.exe") Then
            Me.Icon = My.Resources.MainDialogIcon
            TimestampServerCombo.Text = "http://timestamp.verisign.com/scripts/timstamp.dll"
            AlgorithmCombo.Text = "sha1"
        Else
            MsgBox("SignAPI.exe not found!", MsgBoxStyle.Critical, "Error!")
            Me.Close()
        End If

    End Sub


    Public Sub SignFunction()

        Dim Discription As String
        Discription = """" & DiscriptionTxt.Text & """"
        Dim DiscriptionURL As String
        DiscriptionURL = """" & DiscriptionURLTxt.Text & """"
        Dim IssuarName As String
        IssuarName = """" & IssuarTxt.Text & """"
        Dim SubjectName As String
        SubjectName = """" & SubjectTxt.Text & """"
        Dim TSA As String
        TSA = """" & TimestampServerCombo.Text & """"
        Dim FDA As String
        FDA = """" & AlgorithmCombo.Text & """"
        Dim Password As String
        Password = """" & PasswordTxt.Text & """"
        Dim PFX As String
        PFX = """" & PFXPathTxt.Text & """"
        Dim Win32PE As String
        Win32PE = """" & PEPathTxt.Text & """"
        Dim CommandSeperator As String
        CommandSeperator = "&&"
        Dim ErrorLevel As String
        ErrorLevel = "goto answar%errorlevel%" & vbNewLine & ":answar0" & vbNewLine & "echo FATAL ERROR!"

        If System.IO.File.Exists(Application.StartupPath + "\SignAPI.exe") Then
            If TimestampCheck.Checked = True Then
                Dim SignProcess = New Process
                SignProcess.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.System) & "\cmd.exe"
                SignProcess.StartInfo.Arguments = "/k echo off" & CommandSeperator & "echo SignAPI CommandLine v1.0" & CommandSeperator & "echo." & CommandSeperator & "echo Author: Debdut Biswas" & CommandSeperator & "echo Copyright(C) Dev Software Development " & Date.Today.Year & CommandSeperator & "echo." & CommandSeperator & "SignAPI.exe sign /f " & PFX & " /p " & Password & " /d " & Discription & " /du " & DiscriptionURL & " /i " & IssuarName & " /n " & SubjectName & " /fd " & FDA & " /t " & TSA & " " & Win32PE & CommandSeperator & "echo Signing and TimeStamping Time: " & Date.Now
                SignProcess.StartInfo.UseShellExecute = False
                SignProcess.StartInfo.CreateNoWindow = True
                SignProcess.StartInfo.RedirectStandardOutput = True
                SignProcess.StartInfo.RedirectStandardError = True
                SignProcess.Start()
                Me.ShowInTaskbar = False
                Me.Hide()
                WorkingDialog.Show()
                SignProcess.WaitForExit(4000)
                If Not SignProcess.HasExited Then
                    SignProcess.Kill()
                    WorkingDialog.Close()
                    Dim SuccessOutPut As IO.StreamReader = SignProcess.StandardOutput()
                    Dim ErrorOutPut As IO.StreamReader = SignProcess.StandardError()
                    Dim ProcessSuccess As String
                    Dim ProcessError As String
                    ProcessSuccess = SuccessOutPut.ReadToEnd
                    ProcessError = ErrorOutPut.ReadToEnd
                    If ProcessError = "" Then
                        MsgBox(ProcessSuccess, MsgBoxStyle.Information, "Information")
                    Else
                        MsgBox(ProcessError, MsgBoxStyle.Critical, "Error")
                    End If
                    SuccessOutPut.Close()
                    ErrorOutPut.Close()
                    SignProcess.Close()
                    Me.ShowInTaskbar = True
                    Me.Show()
                End If
            Else
                Dim SignProcess = New Process
                SignProcess.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.System) & "\cmd.exe"
                SignProcess.StartInfo.Arguments = "/k echo off" & CommandSeperator & "echo SignAPI CommandLine v1.0" & CommandSeperator & "echo." & CommandSeperator & "echo Author: Debdut Biswas" & CommandSeperator & "echo Copyright(C) Dev Software Development " & Date.Today.Year & CommandSeperator & "echo." & CommandSeperator & "SignAPI.exe sign /f " & PFX & " /p " & Password & " /d " & Discription & " /du " & DiscriptionURL & " /i " & IssuarName & " /n " & SubjectName & " /fd " & FDA & " " & Win32PE & CommandSeperator & "echo Signing Time: " & Date.Now
                SignProcess.StartInfo.UseShellExecute = False
                SignProcess.StartInfo.CreateNoWindow = True
                SignProcess.StartInfo.RedirectStandardOutput = True
                SignProcess.StartInfo.RedirectStandardError = True
                SignProcess.Start()
                Me.ShowInTaskbar = False
                Me.Hide()
                WorkingDialog.Show()
                SignProcess.WaitForExit(2000)
                If Not SignProcess.HasExited Then
                    SignProcess.Kill()
                    WorkingDialog.Close()
                    Dim SuccessOutPut As IO.StreamReader = SignProcess.StandardOutput()
                    Dim ErrorOutPut As IO.StreamReader = SignProcess.StandardError()
                    Dim ProcessSuccess As String
                    Dim ProcessError As String
                    ProcessSuccess = SuccessOutPut.ReadToEnd
                    ProcessError = ErrorOutPut.ReadToEnd
                    If ProcessError = "" Then
                        MsgBox(ProcessSuccess, MsgBoxStyle.Information, "Information")
                    Else
                        MsgBox(ProcessError, MsgBoxStyle.Critical, "Error")
                    End If
                    SuccessOutPut.Close()
                    ErrorOutPut.Close()
                    SignProcess.Close()
                    Me.ShowInTaskbar = True
                    Me.Show()
                End If
            End If
        Else
            MsgBox("SignAPI.exe not found!", MsgBoxStyle.Critical, "Error!")
            FadeEffectCloseTimer.Enabled = True
        End If

    End Sub

    Private Sub PFXBrowseBtn_Click(sender As Object, e As EventArgs) Handles PFXBrowseBtn.Click

        My.Computer.Audio.Play(My.Resources.Windows_Navigation_Start, AudioPlayMode.Background)

        If PFXOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            PFXPathTxt.Text = PFXOpenFileDialog.FileName
        End If

    End Sub

    Private Sub Win32PeBrowseBtn_Click(sender As Object, e As EventArgs) Handles Win32PeBrowseBtn.Click

        My.Computer.Audio.Play(My.Resources.Windows_Navigation_Start, AudioPlayMode.Background)

        If Win32PEOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            PEPathTxt.Text = Win32PEOpenFileDialog.FileName
        End If

    End Sub

    Private Sub TimestampCheck_Click(sender As Object, e As EventArgs) Handles TimestampCheck.Click

        If Not My.Computer.Network.IsAvailable Then
            TimestampCheck.Checked = False
            Network_Dialog.ShowDialog()
        End If

    End Sub

    Private Sub TimestampCheck_CheckedChanged(sender As Object, e As EventArgs) Handles TimestampCheck.CheckedChanged

        If My.Computer.Network.IsAvailable Then
            TimestampServerCombo.Enabled = True
        ElseIf Not My.Computer.Network.IsAvailable Then
            TimestampServerCombo.Enabled = False
        End If

    End Sub

    Private Sub SignBtn_Click(sender As Object, e As EventArgs) Handles SignBtn.Click

        My.Computer.Audio.Play(My.Resources.Windows_Navigation_Start, AudioPlayMode.Background)
        'SignBackgroundWorker.RunWorkerAsync()
        SignFunction()

    End Sub

    Private Sub SignMnuItm_Click(sender As Object, e As EventArgs) Handles SignMnuItm.Click

        SignFunction()

    End Sub

    Private Sub ExitMnuItm_Click(sender As Object, e As EventArgs) Handles ExitMnuItm.Click

        FadeEffectCloseTimer.Enabled = True

    End Sub

    Private Sub AboutMnuItm_Click(sender As Object, e As EventArgs) Handles AboutMnuItm.Click

        AboutDialog.ShowDialog()

    End Sub

    Private Sub FadeEffectOpenTimer_Tick(sender As Object, e As EventArgs) Handles FadeEffectOpenTimer.Tick

        Me.Opacity += 0.05

    End Sub

    Private Sub FadeEffectCloseTimer_Tick(sender As Object, e As EventArgs) Handles FadeEffectCloseTimer.Tick

        FadeEffectOpenTimer.Enabled = False
        Me.Opacity -= 0.05
        If Me.Opacity = 0 Then Me.Close()

    End Sub

    Private Sub SignChecker_Tick(sender As Object, e As EventArgs) Handles SignChecker.Tick

        If System.IO.File.Exists(PFXPathTxt.Text) Then
            PFXPathTxt.Enabled = True
            PFXPathTxt.ForeColor = Color.Green
        Else
            PFXPathTxt.Text = "File not exists! (Browse for a file)>>>"
            PFXPathTxt.Enabled = False
            PFXPathTxt.ForeColor = Color.Black
        End If

        If System.IO.File.Exists(PEPathTxt.Text) Then
            PEPathTxt.Enabled = True
            PEPathTxt.ForeColor = Color.Green
        Else
            PEPathTxt.Text = "File not exists! (Browse for a file)>>>"
            PEPathTxt.Enabled = False
            PEPathTxt.ForeColor = Color.Black
        End If

        If Not PFXPathTxt.Enabled = True Or Not PEPathTxt.Enabled = True Then
            SignBtn.Enabled = False
            SignMnuItm.Enabled = False
        Else
            SignBtn.Enabled = True
            SignMnuItm.Enabled = True
        End If

    End Sub

    Private Sub SignBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SignBackgroundWorker.DoWork

        SignFunction()

    End Sub
End Class
