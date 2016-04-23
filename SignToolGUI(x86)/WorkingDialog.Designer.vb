<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkingDialog
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
        Me.InfoLbl = New System.Windows.Forms.Label()
        Me.WarkIcn = New System.Windows.Forms.PictureBox()
        CType(Me.WarkIcn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InfoLbl
        '
        Me.InfoLbl.AutoSize = True
        Me.InfoLbl.BackColor = System.Drawing.Color.Transparent
        Me.InfoLbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.InfoLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoLbl.Location = New System.Drawing.Point(75, 61)
        Me.InfoLbl.Name = "InfoLbl"
        Me.InfoLbl.Size = New System.Drawing.Size(238, 21)
        Me.InfoLbl.TabIndex = 0
        Me.InfoLbl.Text = "Signing in progress, Please wait..."
        '
        'WarkIcn
        '
        Me.WarkIcn.BackColor = System.Drawing.Color.Transparent
        Me.WarkIcn.ErrorImage = Nothing
        Me.WarkIcn.Image = Global.SignToolGUI.My.Resources.Resources.SignLogo
        Me.WarkIcn.InitialImage = Nothing
        Me.WarkIcn.Location = New System.Drawing.Point(21, 48)
        Me.WarkIcn.Name = "WarkIcn"
        Me.WarkIcn.Size = New System.Drawing.Size(48, 48)
        Me.WarkIcn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.WarkIcn.TabIndex = 1
        Me.WarkIcn.TabStop = False
        '
        'WorkingDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SignToolGUI.My.Resources.Resources.DialogBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(349, 151)
        Me.ControlBox = False
        Me.Controls.Add(Me.WarkIcn)
        Me.Controls.Add(Me.InfoLbl)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WorkingDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Processing"
        CType(Me.WarkIcn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InfoLbl As System.Windows.Forms.Label
    Friend WithEvents WarkIcn As System.Windows.Forms.PictureBox
End Class
