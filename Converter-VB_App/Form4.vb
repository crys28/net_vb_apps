Public Class Form4
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Dim data = TextBox1.Text

		If Label2.Text = "Decimal" And TextBox1.Text IsNot "" Then
			TextBox2.Text = DecimalToBinary(data)
		ElseIf Label2.Text = "Binary" And TextBox1.Text IsNot "" And TextBox1.Text.Contains("1") Or TextBox1.Text.Contains("0") Then
			TextBox2.Text = BinaryToDecimal(data)
		End If

	End Sub


	Public Shared Function DecimalToBinary(dec As Integer) As String
		If dec < 1 Then Return "0"

		Dim binStr As String = String.Empty

		While dec > 0
			binStr = binStr.Insert(0, (dec Mod 2).ToString())
			dec = Int(dec / 2)
		End While

		Return binStr
	End Function

	Public Shared Function BinaryToDecimal(bin As String) As Integer
		Dim binLength As Integer = bin.Length
		Dim dec As Double = 0

		For i As Integer = 0 To binLength - 1
			dec += (CByte(AscW(bin(i))) - 48) * Math.Pow(2, ((binLength - i) - 1))
		Next

		Return CInt(Math.Truncate(dec))
	End Function



	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		TextBox1.Text = ""
		TextBox2.Text = ""
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		If Label2.Text = "Decimal" Then
			Label2.Text = "Binary"
			Label3.Text = "Decimal"
		Else
			Label2.Text = "Decimal"
			Label3.Text = "Binary"
		End If
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Me.Close()
	End Sub
End Class