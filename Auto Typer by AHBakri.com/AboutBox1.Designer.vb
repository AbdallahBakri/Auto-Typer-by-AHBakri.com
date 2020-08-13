<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox1))
        Me.LinkLabel_Website = New System.Windows.Forms.LinkLabel()
        Me.Label_AutoTyper = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.Label_Copyright = New System.Windows.Forms.Label()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.Linklbl_flaticon = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox_Logo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel_Website
        '
        Me.LinkLabel_Website.AutoSize = True
        Me.LinkLabel_Website.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.LinkLabel_Website.Location = New System.Drawing.Point(56, 89)
        Me.LinkLabel_Website.Name = "LinkLabel_Website"
        Me.LinkLabel_Website.Size = New System.Drawing.Size(106, 17)
        Me.LinkLabel_Website.TabIndex = 38
        Me.LinkLabel_Website.TabStop = True
        Me.LinkLabel_Website.Text = "AHBakri.com"
        '
        'Label_AutoTyper
        '
        Me.Label_AutoTyper.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label_AutoTyper.Location = New System.Drawing.Point(9, 72)
        Me.Label_AutoTyper.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label_AutoTyper.Name = "Label_AutoTyper"
        Me.Label_AutoTyper.Size = New System.Drawing.Size(153, 17)
        Me.Label_AutoTyper.TabIndex = 37
        Me.Label_AutoTyper.Text = "Auto Typer"
        Me.Label_AutoTyper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "By:                       "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelVersion
        '
        Me.LabelVersion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.LabelVersion.Location = New System.Drawing.Point(9, 106)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(153, 17)
        Me.LabelVersion.TabIndex = 35
        Me.LabelVersion.Text = "Version 0.0.0.0"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Copyright
        '
        Me.Label_Copyright.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label_Copyright.Location = New System.Drawing.Point(9, 123)
        Me.Label_Copyright.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label_Copyright.Name = "Label_Copyright"
        Me.Label_Copyright.Size = New System.Drawing.Size(153, 17)
        Me.Label_Copyright.TabIndex = 34
        Me.Label_Copyright.Text = "© Abdallah Bakri  2020"
        Me.Label_Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_OK
        '
        Me.btn_OK.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.btn_OK.Location = New System.Drawing.Point(16, 202)
        Me.btn_OK.Margin = New System.Windows.Forms.Padding(3, 30, 3, 5)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(153, 30)
        Me.btn_OK.TabIndex = 33
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'Linklbl_flaticon
        '
        Me.Linklbl_flaticon.AutoSize = True
        Me.Linklbl_flaticon.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Linklbl_flaticon.Location = New System.Drawing.Point(12, 179)
        Me.Linklbl_flaticon.Name = "Linklbl_flaticon"
        Me.Linklbl_flaticon.Size = New System.Drawing.Size(139, 17)
        Me.Linklbl_flaticon.TabIndex = 40
        Me.Linklbl_flaticon.TabStop = True
        Me.Linklbl_flaticon.Text = "www.flaticon.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Icons made by:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "______________________"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox_Logo
        '
        Me.PictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox_Logo.Image = Global.Auto_Typer_by_AHBakri.com.My.Resources.Resources.Auto_Typer_Logo
        Me.PictureBox_Logo.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox_Logo.Name = "PictureBox_Logo"
        Me.PictureBox_Logo.Size = New System.Drawing.Size(155, 50)
        Me.PictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Logo.TabIndex = 32
        Me.PictureBox_Logo.TabStop = False
        '
        'AboutBox1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(173, 239)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Linklbl_flaticon)
        Me.Controls.Add(Me.LinkLabel_Website)
        Me.Controls.Add(Me.Label_AutoTyper)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.Label_Copyright)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.PictureBox_Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox1"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TopMost = True
        CType(Me.PictureBox_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel_Website As LinkLabel
    Friend WithEvents Label_AutoTyper As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents Label_Copyright As Label
    Friend WithEvents btn_OK As Button
    Friend WithEvents PictureBox_Logo As PictureBox
    Friend WithEvents Linklbl_flaticon As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
