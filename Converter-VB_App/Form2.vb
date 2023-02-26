Public Class Form2
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Double
        If Label2.Text = "Fahrenheit" And TextBox1.Text IsNot "" Then
            result = (5 * (TextBox1.Text - 32)) / 9
            TextBox2.Text = result
        ElseIf Label2.Text = "Celsius" And TextBox1.Text IsNot "" Then
            result = (9 * TextBox1.Text + (32 * 5)) / 5
            TextBox2.Text = result
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Label2.Text = "Fahrenheit" Then
            Label2.Text = "Celsius"
            Label3.Text = "Fahrenheit"
        Else
            Label2.Text = "Fahrenheit"
            Label3.Text = "Celsius"
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class