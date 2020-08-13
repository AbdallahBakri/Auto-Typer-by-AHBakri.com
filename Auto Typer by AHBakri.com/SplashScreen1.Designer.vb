<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel_Website = New System.Windows.Forms.LinkLabel()
        Me.Label_AutoTyper = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Auto_Typer_by_AHBakri.com.My.Resources.Resources.Auto_Typer_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel_Website
        '
        Me.LinkLabel_Website.AutoSize = True
        Me.LinkLabel_Website.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.LinkLabel_Website.Location = New System.Drawing.Point(41, 31)
        Me.LinkLabel_Website.Name = "LinkLabel_Website"
        Me.LinkLabel_Website.Size = New System.Drawing.Size(0, 17)
        Me.LinkLabel_Website.TabIndex = 47
        '
        'Label_AutoTyper
        '
        Me.Label_AutoTyper.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AutoTyper.Location = New System.Drawing.Point(12, 94)
        Me.Label_AutoTyper.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label_AutoTyper.Name = "Label_AutoTyper"
        Me.Label_AutoTyper.Size = New System.Drawing.Size(299, 17)
        Me.Label_AutoTyper.TabIndex = 46
        Me.Label_AutoTyper.Text = "Auto Typer By: AHBakri.com"
        Me.Label_AutoTyper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Version
        '
        Me.Version.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Version.Location = New System.Drawing.Point(9, 124)
        Me.Version.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(106, 17)
        Me.Version.TabIndex = 44
        Me.Version.Text = "Version 0.1"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Copyright
        '
        Me.Copyright.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Copyright.Location = New System.Drawing.Point(135, 124)
        Me.Copyright.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(176, 17)
        Me.Copyright.TabIndex = 43
        Me.Copyright.Text = "© Abdallah Bakri  2020"
        Me.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(323, 146)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel_Website)
        Me.Controls.Add(Me.Label_AutoTyper)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel_Website As LinkLabel
    Friend WithEvents Label_AutoTyper As Label
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
End Class
