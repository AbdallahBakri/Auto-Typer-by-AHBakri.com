Public Class Form1
    Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        lbl_Start.Visible = True
        Timer2.Start()
        'Time between presses: Max and Min numbers
        NumericUpDown_Time_Delay.Minimum = 1
        NumericUpDown_Time_Delay.Maximum = 999999
        'Repeat Count: Max and Min numbers
        'NumericUpDown_Repeat_Count.Minimum = 1
        'NumericUpDown_Repeat_Count.Maximum = 999999
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SendKeys.Send(TextBox_Text.Text)
        SendKeys.Send("{Enter}")
    End Sub

    ' Button Start
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Dim TimeToStart As Double
        TimeToStart = NumericUpDown_Time_Delay.Text * 100
        Timer1.Interval = TimeToStart
        btn_start.Visible = False
        btn_stop.Visible = True
        lbl_Start.Visible = False
        'NumericUpDown_Repeat_Count.Enabled = False
        NumericUpDown_Time_Delay.Enabled = False
        TextBox_Text.Enabled = False
        Timer1.Start()
    End Sub

    ' Button Stop
    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        btn_stop.Visible = False
        btn_start.Visible = True
        lbl_Start.Visible = True
        'NumericUpDown_Repeat_Count.Enabled = True
        NumericUpDown_Time_Delay.Enabled = True
        TextBox_Text.Enabled = True
        Timer1.Stop()
    End Sub


    Private Sub ToolStripBtniNFO_Click(sender As Object, e As EventArgs)
        AboutBox1.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripBtb_About.Click
        AboutBox1.Show()
    End Sub

End Class