Public Class WorkingDialog

    Private Sub WarkingDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.ProgressIcon
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class