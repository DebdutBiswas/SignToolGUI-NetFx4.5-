<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutDialog
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
        Me.AppLbl = New System.Windows.Forms.PictureBox()
        Me.AppNameLbl = New System.Windows.Forms.Label()
        Me.VerLbl = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Win81CompatiblePic = New System.Windows.Forms.PictureBox()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.CompanyLbl = New System.Windows.Forms.Label()
        Me.FadeEffectOpenTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FadeEffectCloseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.AppLbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        CType(Me.Win81CompatiblePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AppLbl
        '
        Me.AppLbl.BackColor = System.Drawing.Color.Transparent
        Me.AppLbl.ErrorImage = Nothing
        Me.AppLbl.Image = Global.SignToolGUI.My.Resources.Resources.AppIconImg
        Me.AppLbl.InitialImage = Nothing
        Me.AppLbl.Location = New System.Drawing.Point(140, 31)
        Me.AppLbl.Name = "AppLbl"
        Me.AppLbl.Size = New System.Drawing.Size(35, 35)
        Me.AppLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppLbl.TabIndex = 2
        Me.AppLbl.TabStop = False
        '
        'AppNameLbl
        '
        Me.AppNameLbl.AutoSize = True
        Me.AppNameLbl.BackColor = System.Drawing.Color.Transparent
        Me.AppNameLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppNameLbl.Location = New System.Drawing.Point(71, 69)
        Me.AppNameLbl.Name = "AppNameLbl"
        Me.AppNameLbl.Size = New System.Drawing.Size(182, 15)
        Me.AppNameLbl.TabIndex = 3
        Me.AppNameLbl.Text = "SignTool Graphical User Interface"
        '
        'VerLbl
        '
        Me.VerLbl.AutoSize = True
        Me.VerLbl.BackColor = System.Drawing.Color.Transparent
        Me.VerLbl.Location = New System.Drawing.Point(125, 88)
        Me.VerLbl.Name = "VerLbl"
        Me.VerLbl.Size = New System.Drawing.Size(64, 13)
        Me.VerLbl.TabIndex = 4
        Me.VerLbl.Text = "Version 1.0"
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.Color.White
        Me.GroupBox.Controls.Add(Me.Win81CompatiblePic)
        Me.GroupBox.Controls.Add(Me.CloseBtn)
        Me.GroupBox.Controls.Add(Me.CompanyLbl)
        Me.GroupBox.Controls.Add(Me.VerLbl)
        Me.GroupBox.Controls.Add(Me.AppLbl)
        Me.GroupBox.Controls.Add(Me.AppNameLbl)
        Me.GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox.ForeColor = System.Drawing.Color.Black
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(320, 175)
        Me.GroupBox.TabIndex = 5
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "About"
        '
        'Win81CompatiblePic
        '
        Me.Win81CompatiblePic.BackColor = System.Drawing.Color.Transparent
        Me.Win81CompatiblePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Win81CompatiblePic.ErrorImage = Nothing
        Me.Win81CompatiblePic.Image = Global.SignToolGUI.My.Resources.Resources.Win81CompatibleImg
        Me.Win81CompatiblePic.InitialImage = Nothing
        Me.Win81CompatiblePic.Location = New System.Drawing.Point(265, 110)
        Me.Win81CompatiblePic.Name = "Win81CompatiblePic"
        Me.Win81CompatiblePic.Size = New System.Drawing.Size(50, 60)
        Me.Win81CompatiblePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Win81CompatiblePic.TabIndex = 19
        Me.Win81CompatiblePic.TabStop = False
        Me.ToolTip.SetToolTip(Me.Win81CompatiblePic, "Windows 8 and Windows 8.1 Compatible")
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Silver
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.Location = New System.Drawing.Point(120, 139)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "&Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'CompanyLbl
        '
        Me.CompanyLbl.AutoSize = True
        Me.CompanyLbl.BackColor = System.Drawing.Color.Transparent
        Me.CompanyLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CompanyLbl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.CompanyLbl.Location = New System.Drawing.Point(86, 111)
        Me.CompanyLbl.Name = "CompanyLbl"
        Me.CompanyLbl.Size = New System.Drawing.Size(146, 13)
        Me.CompanyLbl.TabIndex = 6
        Me.CompanyLbl.Text = "Dev Software Development"
        '
        'FadeEffectOpenTimer
        '
        Me.FadeEffectOpenTimer.Interval = 1
        '
        'FadeEffectCloseTimer
        '
        Me.FadeEffectCloseTimer.Interval = 1
        '
        'ToolTip
        '
        Me.ToolTip.BackColor = System.Drawing.Color.White
        Me.ToolTip.ForeColor = System.Drawing.Color.Black
        '
        'AboutDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.SignToolGUI.My.Resources.Resources.MainMenuBackground
        Me.ClientSize = New System.Drawing.Size(345, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDialog"
        Me.Opacity = 0.0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.AppLbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.Win81CompatiblePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AppLbl As System.Windows.Forms.PictureBox
    Friend WithEvents AppNameLbl As System.Windows.Forms.Label
    Friend WithEvents VerLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CompanyLbl As System.Windows.Forms.Label
    Public WithEvents FadeEffectOpenTimer As System.Windows.Forms.Timer
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Public WithEvents FadeEffectCloseTimer As System.Windows.Forms.Timer
    Friend WithEvents Win81CompatiblePic As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
End Class
