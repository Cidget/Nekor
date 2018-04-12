<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVideoGameLauncher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnWebsite = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pbrGameProgress = New System.Windows.Forms.ProgressBar()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.cbxMusicMute = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnLaunch
        '
        Me.btnLaunch.BackColor = System.Drawing.Color.DimGray
        Me.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaunch.ForeColor = System.Drawing.Color.White
        Me.btnLaunch.Location = New System.Drawing.Point(876, 527)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(115, 38)
        Me.btnLaunch.TabIndex = 0
        Me.btnLaunch.Text = "Launch"
        Me.btnLaunch.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("ROG Fonts v1.6", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblTitle.Location = New System.Drawing.Point(5, -18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(336, 46)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Nekor - Fantasy RPG"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnWebsite
        '
        Me.btnWebsite.BackColor = System.Drawing.Color.DimGray
        Me.btnWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWebsite.ForeColor = System.Drawing.Color.White
        Me.btnWebsite.Location = New System.Drawing.Point(916, 440)
        Me.btnWebsite.Name = "btnWebsite"
        Me.btnWebsite.Size = New System.Drawing.Size(75, 23)
        Me.btnWebsite.TabIndex = 5
        Me.btnWebsite.Text = "Website"
        Me.btnWebsite.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(916, 498)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pbrGameProgress
        '
        Me.pbrGameProgress.BackColor = System.Drawing.Color.DarkGray
        Me.pbrGameProgress.ForeColor = System.Drawing.Color.DarkGray
        Me.pbrGameProgress.Location = New System.Drawing.Point(12, 537)
        Me.pbrGameProgress.Name = "pbrGameProgress"
        Me.pbrGameProgress.Size = New System.Drawing.Size(858, 18)
        Me.pbrGameProgress.TabIndex = 7
        '
        'tmrTime
        '
        '
        'cbxMusicMute
        '
        Me.cbxMusicMute.BackColor = System.Drawing.Color.DimGray
        Me.cbxMusicMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxMusicMute.ForeColor = System.Drawing.Color.Transparent
        Me.cbxMusicMute.Location = New System.Drawing.Point(916, 469)
        Me.cbxMusicMute.Name = "cbxMusicMute"
        Me.cbxMusicMute.Size = New System.Drawing.Size(75, 23)
        Me.cbxMusicMute.TabIndex = 8
        Me.cbxMusicMute.Text = "Mute Music"
        Me.cbxMusicMute.UseVisualStyleBackColor = False
        '
        'frmVideoGameLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Video_Game_Launcher.My.Resources.Resources._72a534f93500052ffd94c1f5dc11423c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1003, 577)
        Me.Controls.Add(Me.cbxMusicMute)
        Me.Controls.Add(Me.pbrGameProgress)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWebsite)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnLaunch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVideoGameLauncher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLaunch As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnWebsite As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pbrGameProgress As ProgressBar
    Friend WithEvents tmrTime As Timer
    Friend WithEvents cbxMusicMute As CheckBox
End Class
