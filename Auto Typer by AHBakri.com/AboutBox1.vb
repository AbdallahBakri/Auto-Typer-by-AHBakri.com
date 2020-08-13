Public NotInheritable Class AboutBox1
    Private Sub AboutBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        Me.Close()
    End Sub

    Private Sub Linklbl_flaticon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linklbl_flaticon.LinkClicked
        System.Diagnostics.Process.Start("IExplore", "https://www.flaticon.com/authors/freepik")
    End Sub

    Private Sub LinkLabel_Website_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Website.LinkClicked
        System.Diagnostics.Process.Start("IExplore", "https://www.ahbakri.com/")
    End Sub
End Class
