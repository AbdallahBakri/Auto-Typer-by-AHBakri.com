<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown_Time_Delay = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Text = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripBtb_About = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Start = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown_Time_Delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Time between presses:"
        '
        'NumericUpDown_Time_Delay
        '
        Me.NumericUpDown_Time_Delay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NumericUpDown_Time_Delay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.NumericUpDown_Time_Delay.Location = New System.Drawing.Point(17, 111)
        Me.NumericUpDown_Time_Delay.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.NumericUpDown_Time_Delay.Name = "NumericUpDown_Time_Delay"
        Me.NumericUpDown_Time_Delay.ReadOnly = True
        Me.NumericUpDown_Time_Delay.Size = New System.Drawing.Size(76, 24)
        Me.NumericUpDown_Time_Delay.TabIndex = 6
        Me.NumericUpDown_Time_Delay.TabStop = False
        Me.NumericUpDown_Time_Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown_Time_Delay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(103, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "miliseconds(s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(14, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Text:"
        '
        'TextBox_Text
        '
        Me.TextBox_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox_Text.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.TextBox_Text.Location = New System.Drawing.Point(17, 41)
        Me.TextBox_Text.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox_Text.Name = "TextBox_Text"
        Me.TextBox_Text.Size = New System.Drawing.Size(416, 24)
        Me.TextBox_Text.TabIndex = 7
        Me.TextBox_Text.TabStop = False
        '
        'btn_start
        '
        Me.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_start.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.btn_start.Location = New System.Drawing.Point(307, 146)
        Me.btn_start.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(126, 29)
        Me.btn_start.TabIndex = 8
        Me.btn_start.TabStop = False
        Me.btn_start.Text = "Start Working"
        Me.btn_start.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.btn_stop.Location = New System.Drawing.Point(307, 146)
        Me.btn_stop.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(126, 29)
        Me.btn_stop.TabIndex = 8
        Me.btn_stop.TabStop = False
        Me.btn_stop.Text = "Stop Working"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripSeparator1, Me.ToolStripBtb_About})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 187)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(444, 27)
        Me.ToolStrip2.TabIndex = 28
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(139, 15)
        Me.ToolStripLabel3.Text = "© Abdallah Bakri — 2020"
        Me.ToolStripLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripBtb_About
        '
        Me.ToolStripBtb_About.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripBtb_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtb_About.Image = Global.Auto_Typer_by_AHBakri.com.My.Resources.Resources.Info
        Me.ToolStripBtb_About.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtb_About.Name = "ToolStripBtb_About"
        Me.ToolStripBtb_About.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripBtb_About.Text = "About"
        '
        'Timer2
        '
        '
        'lbl_Start
        '
        Me.lbl_Start.AutoSize = True
        Me.lbl_Start.Location = New System.Drawing.Point(14, 155)
        Me.lbl_Start.Name = "lbl_Start"
        Me.lbl_Start.Size = New System.Drawing.Size(256, 13)
        Me.lbl_Start.TabIndex = 39
        Me.lbl_Start.Text = "Click the Start button and then click on the text area."
        Me.lbl_Start.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 214)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Start)
        Me.Controls.Add(Me.NumericUpDown_Time_Delay)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_Text)
        Me.Controls.Add(Me.btn_stop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Auto Typer by AHBakri.com"
        CType(Me.NumericUpDown_Time_Delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown_Time_Delay As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Text As TextBox
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripBtb_About As ToolStripButton
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lbl_Start As Label
End Class
