Public Class Form2
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub AddNewPassword_Click(sender As Object, e As EventArgs) Handles AddNewPassword.Click
        AddPswdPanel.Visible = True
        RemPswdPanel.Visible = False
        NewPassword.Text = ""
        NewName.Text = ""
    End Sub

    Private Sub RemovePassword_Click(sender As Object, e As EventArgs) Handles RemovePassword.Click
        AddPswdPanel.Visible = False
        RemPswdPanel.Visible = True
        TextBox3.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim name = NewName.Text
        Dim pass = NewPassword.Text

        Dim li As ListViewItem
        li = New ListViewItem({name, pass})

        ListView1.Items.Add(li)



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pos As Int32
        Dim listItem As ListViewItem
        Dim name = TextBox3.Text


        For pos = ListView1.Items.Count - 1 To 0 Step -1
            listItem = ListView1.Items(pos)
            If listItem.SubItems(0).Text = name Then
                ListView1.Items.Remove(listItem)
            End If
        Next
    End Sub
End Class