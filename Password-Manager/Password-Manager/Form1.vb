Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox1.Text = "0000" Then
                Form2.Show()
                Me.Hide()
            Else MsgBox("Wrong pin")
            End If
        End If
    End Sub
End Class


