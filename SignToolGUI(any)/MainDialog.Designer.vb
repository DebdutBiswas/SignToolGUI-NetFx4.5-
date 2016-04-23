Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Linq
Imports System.Xml
Imports System.Threading.Tasks
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDialog))
        Me.DescriptionLbl = New System.Windows.Forms.Label()
        Me.DescriptionURLLbl = New System.Windows.Forms.Label()
        Me.IssuarLbl = New System.Windows.Forms.Label()
        Me.SubjectLbl = New System.Windows.Forms.Label()
        Me.AlgorithmLbl = New System.Windows.Forms.Label()
        Me.TimeStampLbl = New System.Windows.Forms.Label()
        Me.TimestampServerCombo = New System.Windows.Forms.ComboBox()
        Me.AlgorithmCombo = New System.Windows.Forms.ComboBox()
        Me.DiscriptionTxt = New System.Windows.Forms.TextBox()
        Me.DiscriptionURLTxt = New System.Windows.Forms.TextBox()
        Me.IssuarTxt = New System.Windows.Forms.TextBox()
        Me.SubjectTxt = New System.Windows.Forms.TextBox()
        Me.TimestampCheck = New System.Windows.Forms.CheckBox()
        Me.SignBtn = New System.Windows.Forms.Button()
        Me.PFXPathTxt = New System.Windows.Forms.TextBox()
        Me.PEPathTxt = New System.Windows.Forms.TextBox()
        Me.PFXBrowseBtn = New System.Windows.Forms.Button()
        Me.Win32PeBrowseBtn = New System.Windows.Forms.Button()
        Me.PFXPathLbl = New System.Windows.Forms.Label()
        Me.PEPathLbl = New System.Windows.Forms.Label()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.PFXOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Win32PEOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileMnuItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignMnuItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMnuItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMnuItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMnuItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.FadeEffectOpenTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FadeEffectCloseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SignChecker = New System.Windows.Forms.Timer(Me.components)
        Me.FBLikeBtn = New System.Windows.Forms.WebBrowser()
        Me.MainFormVisualStyler = New SkinSoft.VisualStyler.VisualStyler(Me.components)
        Me.SignBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.MainMenu.SuspendLayout()
        CType(Me.MainFormVisualStyler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLbl
        '
        Me.DescriptionLbl.AutoSize = True
        Me.DescriptionLbl.BackColor = System.Drawing.Color.Transparent
        Me.DescriptionLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLbl.Location = New System.Drawing.Point(17, 47)
        Me.DescriptionLbl.Name = "DescriptionLbl"
        Me.DescriptionLbl.Size = New System.Drawing.Size(75, 22)
        Me.DescriptionLbl.TabIndex = 0
        Me.DescriptionLbl.Text = "Description:"
        Me.DescriptionLbl.UseCompatibleTextRendering = True
        '
        'DescriptionURLLbl
        '
        Me.DescriptionURLLbl.AutoSize = True
        Me.DescriptionURLLbl.BackColor = System.Drawing.Color.Transparent
        Me.DescriptionURLLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionURLLbl.Location = New System.Drawing.Point(17, 75)
        Me.DescriptionURLLbl.Name = "DescriptionURLLbl"
        Me.DescriptionURLLbl.Size = New System.Drawing.Size(102, 22)
        Me.DescriptionURLLbl.TabIndex = 0
        Me.DescriptionURLLbl.Text = "Description URL:"
        Me.DescriptionURLLbl.UseCompatibleTextRendering = True
        '
        'IssuarLbl
        '
        Me.IssuarLbl.AutoSize = True
        Me.IssuarLbl.BackColor = System.Drawing.Color.Transparent
        Me.IssuarLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IssuarLbl.Location = New System.Drawing.Point(17, 101)
        Me.IssuarLbl.Name = "IssuarLbl"
        Me.IssuarLbl.Size = New System.Drawing.Size(81, 22)
        Me.IssuarLbl.TabIndex = 0
        Me.IssuarLbl.Text = "Issuar Name:"
        Me.IssuarLbl.UseCompatibleTextRendering = True
        '
        'SubjectLbl
        '
        Me.SubjectLbl.AutoSize = True
        Me.SubjectLbl.BackColor = System.Drawing.Color.Transparent
        Me.SubjectLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectLbl.Location = New System.Drawing.Point(17, 129)
        Me.SubjectLbl.Name = "SubjectLbl"
        Me.SubjectLbl.Size = New System.Drawing.Size(90, 22)
        Me.SubjectLbl.TabIndex = 0
        Me.SubjectLbl.Text = "Subject Name:"
        Me.SubjectLbl.UseCompatibleTextRendering = True
        '
        'AlgorithmLbl
        '
        Me.AlgorithmLbl.AutoSize = True
        Me.AlgorithmLbl.BackColor = System.Drawing.Color.Transparent
        Me.AlgorithmLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlgorithmLbl.Location = New System.Drawing.Point(17, 185)
        Me.AlgorithmLbl.Name = "AlgorithmLbl"
        Me.AlgorithmLbl.Size = New System.Drawing.Size(135, 22)
        Me.AlgorithmLbl.TabIndex = 0
        Me.AlgorithmLbl.Text = "File Digest Algoridhm:"
        Me.AlgorithmLbl.UseCompatibleTextRendering = True
        '
        'TimeStampLbl
        '
        Me.TimeStampLbl.AutoSize = True
        Me.TimeStampLbl.BackColor = System.Drawing.Color.Transparent
        Me.TimeStampLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeStampLbl.Location = New System.Drawing.Point(17, 158)
        Me.TimeStampLbl.Name = "TimeStampLbl"
        Me.TimeStampLbl.Size = New System.Drawing.Size(137, 22)
        Me.TimeStampLbl.TabIndex = 0
        Me.TimeStampLbl.Text = "Time Stamp Authority:"
        Me.TimeStampLbl.UseCompatibleTextRendering = True
        '
        'TimestampServerCombo
        '
        Me.TimestampServerCombo.BackColor = System.Drawing.Color.White
        Me.TimestampServerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TimestampServerCombo.Enabled = False
        Me.TimestampServerCombo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TimestampServerCombo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimestampServerCombo.FormattingEnabled = True
        Me.TimestampServerCombo.Items.AddRange(New Object() {"http://timestamp.comodoca.com/authenticode", "http://timestamp.verisign.com/scripts/timstamp.dll"})
        Me.TimestampServerCombo.Location = New System.Drawing.Point(159, 157)
        Me.TimestampServerCombo.Name = "TimestampServerCombo"
        Me.TimestampServerCombo.Size = New System.Drawing.Size(326, 21)
        Me.TimestampServerCombo.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.TimestampServerCombo, "Select a timestamp server (Verisign/ Comodo) default is .""Verisign""")
        '
        'AlgorithmCombo
        '
        Me.AlgorithmCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AlgorithmCombo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AlgorithmCombo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlgorithmCombo.FormattingEnabled = True
        Me.AlgorithmCombo.Items.AddRange(New Object() {"sha1", "sha256", "sha512"})
        Me.AlgorithmCombo.Location = New System.Drawing.Point(159, 184)
        Me.AlgorithmCombo.Name = "AlgorithmCombo"
        Me.AlgorithmCombo.Size = New System.Drawing.Size(121, 21)
        Me.AlgorithmCombo.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.AlgorithmCombo, "Select a file digest algoridhm, default is ""sha1""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "When signing a ""Windows App" &
        "x Package""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " file digest algoridhm must be set to ""sha256"".")
        '
        'DiscriptionTxt
        '
        Me.DiscriptionTxt.Location = New System.Drawing.Point(159, 47)
        Me.DiscriptionTxt.MaxLength = 256
        Me.DiscriptionTxt.Name = "DiscriptionTxt"
        Me.DiscriptionTxt.Size = New System.Drawing.Size(347, 22)
        Me.DiscriptionTxt.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.DiscriptionTxt, "Optional: Set description of the file which will signed." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This field is not nec" &
        "essary.")
        '
        'DiscriptionURLTxt
        '
        Me.DiscriptionURLTxt.Location = New System.Drawing.Point(159, 75)
        Me.DiscriptionURLTxt.MaxLength = 256
        Me.DiscriptionURLTxt.Name = "DiscriptionURLTxt"
        Me.DiscriptionURLTxt.Size = New System.Drawing.Size(347, 22)
        Me.DiscriptionURLTxt.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.DiscriptionURLTxt, "Optional: Set description URL of the file which will signed." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This field is not" &
        " necessary.")
        '
        'IssuarTxt
        '
        Me.IssuarTxt.Location = New System.Drawing.Point(159, 101)
        Me.IssuarTxt.MaxLength = 256
        Me.IssuarTxt.Name = "IssuarTxt"
        Me.IssuarTxt.Size = New System.Drawing.Size(347, 22)
        Me.IssuarTxt.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.IssuarTxt, resources.GetString("IssuarTxt.ToolTip"))
        '
        'SubjectTxt
        '
        Me.SubjectTxt.Location = New System.Drawing.Point(159, 129)
        Me.SubjectTxt.MaxLength = 256
        Me.SubjectTxt.Name = "SubjectTxt"
        Me.SubjectTxt.Size = New System.Drawing.Size(347, 22)
        Me.SubjectTxt.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.SubjectTxt, resources.GetString("SubjectTxt.ToolTip"))
        '
        'TimestampCheck
        '
        Me.TimestampCheck.AutoSize = True
        Me.TimestampCheck.BackColor = System.Drawing.Color.Transparent
        Me.TimestampCheck.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimestampCheck.ForeColor = System.Drawing.Color.Black
        Me.TimestampCheck.Location = New System.Drawing.Point(491, 161)
        Me.TimestampCheck.Name = "TimestampCheck"
        Me.TimestampCheck.Size = New System.Drawing.Size(15, 14)
        Me.TimestampCheck.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.TimestampCheck, resources.GetString("TimestampCheck.ToolTip"))
        Me.TimestampCheck.UseVisualStyleBackColor = False
        '
        'SignBtn
        '
        Me.SignBtn.BackColor = System.Drawing.Color.Transparent
        Me.SignBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SignBtn.Enabled = False
        Me.SignBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignBtn.Location = New System.Drawing.Point(431, 269)
        Me.SignBtn.Name = "SignBtn"
        Me.SignBtn.Size = New System.Drawing.Size(75, 22)
        Me.SignBtn.TabIndex = 13
        Me.SignBtn.Text = "&Sign"
        Me.SignBtn.UseVisualStyleBackColor = False
        '
        'PFXPathTxt
        '
        Me.PFXPathTxt.Enabled = False
        Me.PFXPathTxt.Location = New System.Drawing.Point(159, 211)
        Me.PFXPathTxt.Name = "PFXPathTxt"
        Me.PFXPathTxt.Size = New System.Drawing.Size(266, 22)
        Me.PFXPathTxt.TabIndex = 8
        '
        'PEPathTxt
        '
        Me.PEPathTxt.Enabled = False
        Me.PEPathTxt.Location = New System.Drawing.Point(159, 239)
        Me.PEPathTxt.Name = "PEPathTxt"
        Me.PEPathTxt.Size = New System.Drawing.Size(266, 22)
        Me.PEPathTxt.TabIndex = 10
        '
        'PFXBrowseBtn
        '
        Me.PFXBrowseBtn.BackColor = System.Drawing.Color.Transparent
        Me.PFXBrowseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PFXBrowseBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFXBrowseBtn.Location = New System.Drawing.Point(431, 211)
        Me.PFXBrowseBtn.Name = "PFXBrowseBtn"
        Me.PFXBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.PFXBrowseBtn.TabIndex = 9
        Me.PFXBrowseBtn.Text = "&Browse..."
        Me.PFXBrowseBtn.UseVisualStyleBackColor = False
        '
        'Win32PeBrowseBtn
        '
        Me.Win32PeBrowseBtn.BackColor = System.Drawing.Color.Transparent
        Me.Win32PeBrowseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Win32PeBrowseBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Win32PeBrowseBtn.Location = New System.Drawing.Point(431, 238)
        Me.Win32PeBrowseBtn.Name = "Win32PeBrowseBtn"
        Me.Win32PeBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.Win32PeBrowseBtn.TabIndex = 11
        Me.Win32PeBrowseBtn.Text = "Brows&e..."
        Me.Win32PeBrowseBtn.UseVisualStyleBackColor = False
        '
        'PFXPathLbl
        '
        Me.PFXPathLbl.AutoSize = True
        Me.PFXPathLbl.BackColor = System.Drawing.Color.Transparent
        Me.PFXPathLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PFXPathLbl.Location = New System.Drawing.Point(17, 212)
        Me.PFXPathLbl.Name = "PFXPathLbl"
        Me.PFXPathLbl.Size = New System.Drawing.Size(83, 22)
        Me.PFXPathLbl.TabIndex = 0
        Me.PFXPathLbl.Text = "PFX File Path:"
        Me.PFXPathLbl.UseCompatibleTextRendering = True
        '
        'PEPathLbl
        '
        Me.PEPathLbl.AutoSize = True
        Me.PEPathLbl.BackColor = System.Drawing.Color.Transparent
        Me.PEPathLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PEPathLbl.Location = New System.Drawing.Point(17, 241)
        Me.PEPathLbl.Name = "PEPathLbl"
        Me.PEPathLbl.Size = New System.Drawing.Size(107, 22)
        Me.PEPathLbl.TabIndex = 0
        Me.PEPathLbl.Text = "File to be Signed:"
        Me.PEPathLbl.UseCompatibleTextRendering = True
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLbl.Location = New System.Drawing.Point(17, 268)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(67, 17)
        Me.PasswordLbl.TabIndex = 0
        Me.PasswordLbl.Text = "Password:"
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Location = New System.Drawing.Point(159, 269)
        Me.PasswordTxt.MaxLength = 256
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(266, 22)
        Me.PasswordTxt.TabIndex = 12
        Me.ToolTip.SetToolTip(Me.PasswordTxt, resources.GetString("PasswordTxt.ToolTip"))
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'PFXOpenFileDialog
        '
        Me.PFXOpenFileDialog.Filter = "Personal Information Exchange|*.pfx|Personal Information Exchange|*.p12|Digital C" &
    "ertificate|*.cer"
        Me.PFXOpenFileDialog.SupportMultiDottedExtensions = True
        Me.PFXOpenFileDialog.Title = "Select a Personal Information Exchange File"
        '
        'Win32PEOpenFileDialog
        '
        Me.Win32PEOpenFileDialog.Filter = resources.GetString("Win32PEOpenFileDialog.Filter")
        Me.Win32PEOpenFileDialog.SupportMultiDottedExtensions = True
        Me.Win32PEOpenFileDialog.Title = "Select any type of Win32 PE File"
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 20000
        Me.ToolTip.AutoPopDelay = 20000
        Me.ToolTip.BackColor = System.Drawing.Color.White
        Me.ToolTip.ForeColor = System.Drawing.Color.Black
        Me.ToolTip.InitialDelay = 100
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.ReshowDelay = 100
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.SystemColors.Control
        Me.MainMenu.BackgroundImage = Global.SignToolGUI.My.Resources.Resources.MainMenuBackground
        Me.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMnuItm, Me.HelpMnuItm})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(522, 24)
        Me.MainMenu.TabIndex = 15
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileMnuItm
        '
        Me.FileMnuItm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignMnuItm, Me.ExitMnuItm})
        Me.FileMnuItm.Name = "FileMnuItm"
        Me.FileMnuItm.Size = New System.Drawing.Size(37, 20)
        Me.FileMnuItm.Text = "&File"
        '
        'SignMnuItm
        '
        Me.SignMnuItm.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SignMnuItm.BackgroundImage = Global.SignToolGUI.My.Resources.Resources.MainMenuBackground
        Me.SignMnuItm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SignMnuItm.Image = Global.SignToolGUI.My.Resources.Resources.SignLogo
        Me.SignMnuItm.Name = "SignMnuItm"
        Me.SignMnuItm.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SignMnuItm.Size = New System.Drawing.Size(137, 22)
        Me.SignMnuItm.Text = "&Sign"
        '
        'ExitMnuItm
        '
        Me.ExitMnuItm.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ExitMnuItm.BackgroundImage = Global.SignToolGUI.My.Resources.Resources.MainMenuBackground
        Me.ExitMnuItm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitMnuItm.Image = Global.SignToolGUI.My.Resources.Resources.ExitImg
        Me.ExitMnuItm.Name = "ExitMnuItm"
        Me.ExitMnuItm.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitMnuItm.Size = New System.Drawing.Size(137, 22)
        Me.ExitMnuItm.Text = "&Exit"
        '
        'HelpMnuItm
        '
        Me.HelpMnuItm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMnuItm})
        Me.HelpMnuItm.Name = "HelpMnuItm"
        Me.HelpMnuItm.Size = New System.Drawing.Size(44, 20)
        Me.HelpMnuItm.Text = "&Help"
        '
        'AboutMnuItm
        '
        Me.AboutMnuItm.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AboutMnuItm.BackgroundImage = Global.SignToolGUI.My.Resources.Resources.MainMenuBackground
        Me.AboutMnuItm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AboutMnuItm.Image = Global.SignToolGUI.My.Resources.Resources.InfoLogo
        Me.AboutMnuItm.Name = "AboutMnuItm"
        Me.AboutMnuItm.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutMnuItm.Size = New System.Drawing.Size(126, 22)
        Me.AboutMnuItm.Text = "&About"
        '
        'FadeEffectOpenTimer
        '
        Me.FadeEffectOpenTimer.Interval = 1
        '
        'FadeEffectCloseTimer
        '
        Me.FadeEffectCloseTimer.Interval = 1
        '
        'SignChecker
        '
        Me.SignChecker.Enabled = True
        Me.SignChecker.Interval = 1
        '
        'FBLikeBtn
        '
        Me.FBLikeBtn.AllowWebBrowserDrop = False
        Me.FBLikeBtn.Location = New System.Drawing.Point(21, 299)
        Me.FBLikeBtn.MinimumSize = New System.Drawing.Size(20, 20)
        Me.FBLikeBtn.Name = "FBLikeBtn"
        Me.FBLikeBtn.ScrollBarsEnabled = False
        Me.FBLikeBtn.Size = New System.Drawing.Size(103, 20)
        Me.FBLikeBtn.TabIndex = 15
        Me.FBLikeBtn.TabStop = False
        Me.FBLikeBtn.Url = New System.Uri("http://www.facebook.com/plugins/like.php?href=https%3A%2F%2Fwww.facebook.com%2Fde" &
        "v.software.development&width&layout=button&action=like&show_faces=false&share=fa" &
        "lse&height=35", System.UriKind.Absolute)
        Me.FBLikeBtn.WebBrowserShortcutsEnabled = False
        '
        'MainFormVisualStyler
        '
        Me.MainFormVisualStyler.HostForm = Me
        Me.MainFormVisualStyler.License = CType(resources.GetObject("MainFormVisualStyler.License"), SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
        Me.MainFormVisualStyler.ShadowStyle = SkinSoft.VisualStyler.ShadowStyle.Bold
        Me.MainFormVisualStyler.LoadVisualStyle(Nothing, "XP (Blue).vssf")
        '
        'SignBackgroundWorker
        '
        Me.SignBackgroundWorker.WorkerReportsProgress = True
        Me.SignBackgroundWorker.WorkerSupportsCancellation = True
        '
        'MainDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(522, 327)
        Me.Controls.Add(Me.FBLikeBtn)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.PasswordLbl)
        Me.Controls.Add(Me.PEPathLbl)
        Me.Controls.Add(Me.PFXPathLbl)
        Me.Controls.Add(Me.Win32PeBrowseBtn)
        Me.Controls.Add(Me.PFXBrowseBtn)
        Me.Controls.Add(Me.PEPathTxt)
        Me.Controls.Add(Me.PFXPathTxt)
        Me.Controls.Add(Me.SignBtn)
        Me.Controls.Add(Me.TimestampCheck)
        Me.Controls.Add(Me.SubjectTxt)
        Me.Controls.Add(Me.IssuarTxt)
        Me.Controls.Add(Me.DiscriptionURLTxt)
        Me.Controls.Add(Me.DiscriptionTxt)
        Me.Controls.Add(Me.AlgorithmCombo)
        Me.Controls.Add(Me.TimestampServerCombo)
        Me.Controls.Add(Me.TimeStampLbl)
        Me.Controls.Add(Me.AlgorithmLbl)
        Me.Controls.Add(Me.SubjectLbl)
        Me.Controls.Add(Me.IssuarLbl)
        Me.Controls.Add(Me.DescriptionURLLbl)
        Me.Controls.Add(Me.DescriptionLbl)
        Me.Controls.Add(Me.MainMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MainMenu
        Me.MaximizeBox = False
        Me.Name = "MainDialog"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignTool Graphical User Interface"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        CType(Me.MainFormVisualStyler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents TimestampServerCombo As System.Windows.Forms.ComboBox
    Public WithEvents AlgorithmCombo As System.Windows.Forms.ComboBox
    Public WithEvents DiscriptionTxt As System.Windows.Forms.TextBox
    Public WithEvents DiscriptionURLTxt As System.Windows.Forms.TextBox
    Public WithEvents IssuarTxt As System.Windows.Forms.TextBox
    Public WithEvents SubjectTxt As System.Windows.Forms.TextBox
    Public WithEvents TimestampCheck As System.Windows.Forms.CheckBox
    Public WithEvents SignBtn As System.Windows.Forms.Button
    Public WithEvents PFXPathTxt As System.Windows.Forms.TextBox
    Public WithEvents PEPathTxt As System.Windows.Forms.TextBox
    Public WithEvents PFXBrowseBtn As System.Windows.Forms.Button
    Public WithEvents Win32PeBrowseBtn As System.Windows.Forms.Button
    Public WithEvents PFXPathLbl As System.Windows.Forms.Label
    Public WithEvents PEPathLbl As System.Windows.Forms.Label
    Public WithEvents PasswordLbl As System.Windows.Forms.Label
    Public WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Public WithEvents DescriptionLbl As System.Windows.Forms.Label
    Public WithEvents DescriptionURLLbl As System.Windows.Forms.Label
    Public WithEvents IssuarLbl As System.Windows.Forms.Label
    Public WithEvents SubjectLbl As System.Windows.Forms.Label
    Public WithEvents AlgorithmLbl As System.Windows.Forms.Label
    Public WithEvents TimeStampLbl As System.Windows.Forms.Label
    Public WithEvents PFXOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Public WithEvents Win32PEOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMnuItm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignMnuItm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitMnuItm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMnuItm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMnuItm As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents FadeEffectOpenTimer As System.Windows.Forms.Timer
    Public WithEvents FadeEffectCloseTimer As System.Windows.Forms.Timer
    Public WithEvents SignChecker As System.Windows.Forms.Timer
    Public WithEvents FBLikeBtn As System.Windows.Forms.WebBrowser
    Friend WithEvents MainFormVisualStyler As SkinSoft.VisualStyler.VisualStyler
    Friend WithEvents SignBackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
