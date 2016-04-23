Imports System.IO

Namespace My

    'The following events are available for MyApplication
    '
    'Startup: Raised when the application starts, before the startup form is created.
    'Shutdown: Raised after all application forms are closed.  This event is not raised if the application is terminating abnormally.
    'UnhandledException: Raised if the application encounters an unhandled exception.
    'StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    'NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    Class MyApplication

#If _MyType = "WindowsForms" Then

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim Path As String = Directory.GetCurrentDirectory()

            If Not System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\SignAPI.exe") Then
                File.WriteAllBytes(Path + "\SignAPI.exe", My.Resources.SignAPI)
            End If

            If Not System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\capicom.dll") Then
                File.WriteAllBytes(Path + "\capicom.dll", My.Resources.capicom)
            End If

            If Not System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\SignAPIcli.exe") Then
                File.WriteAllBytes(Path + "\SignAPIcli.exe", My.Resources.SignAPIcli)
            End If

            If Not System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\cli.cmd") Then
                File.WriteAllBytes(Path + "\cli.cmd", My.Resources.cli)
            End If

            If Not System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\help.cmd") Then
                File.WriteAllBytes(Path + "\help.cmd", My.Resources.help)
            End If

            If e.CommandLine.Count > 0 Then
                ' Get the 2 character command line argument
                Dim CommandLineArgument As String = e.CommandLine(0).ToLower(System.Globalization.CultureInfo.InvariantCulture).Trim().Substring(0, 2)
                Select Case CommandLineArgument
                    Case "/m"
                        Me.MainForm = MainDialog
                    Case "/a"
                        Me.MainForm = AboutDialog
                    Case "/c"
                        'Dim CommandSeperator As String
                        'CommandSeperator = "&&"
                        'Dim Console = New Process
                        'Console.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.System) & "\cmd.exe"
                        'Console.StartInfo.Arguments = "/k echo off" & CommandSeperator & "cls" & CommandSeperator & "SignAPI.exe /?" & CommandSeperator & "echo." & CommandSeperator & "SignAPI.exe sign /?" & CommandSeperator & "echo." & CommandSeperator & "echo Starting SignTool CommandLine..." & CommandSeperator & "echo Press any key to continue..." & CommandSeperator & "pause>nul" & CommandSeperator & "start" & CommandSeperator & "exit"
                        'Console.StartInfo.UseShellExecute = False
                        'Console.Start()
                        Process.Start("SignAPIcli.exe")
                        End
                    Case "/h"
                        Process.Start("https://facebook.com/dev.software.development")
                        End
                    Case Else
                        MessageBox.Show("Invalid Command Line Argument :" + CommandLineArgument, "Invalid Command Line Argument", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End
                End Select

            End If

        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

            MessageBox.Show("Applicaton Can't Start!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End

        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown

            'Dim Path As String = Directory.GetCurrentDirectory()
            'System.IO.File.Delete(Path + "\capicom.dll")
            'System.IO.File.Delete(Path + "\SignAPI.exe")

        End Sub

        'OnInitialize is used for advanced customization of the My Application Model (MyApplication).
        'Startup code for your specific application should be placed in a Startup event handler.
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean

            Return MyBase.OnInitialize(commandLineArgs)

        End Function
#End If

    End Class

End Namespace

