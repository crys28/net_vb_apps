

Public Class Form1
    Dim selectedColor_bg As Color
    Dim selectedColor_text As Color

    Dim i As Integer = 14

    ReadOnly newnote As New TextBox() With {
                                        .Text = "write something...",
                                        .Location = New Point(25, 100),
                                        .TabIndex = 10,
                                        .Font = New Font("comic sans ms", i),
                                        .Width = 825,
                                        .Height = 450,
                                        .Multiline = True,
                                        .BackColor = Color.White,
                                        .ForeColor = Color.Black,
                                        .ScrollBars = ScrollBars.Both,
                                        .Visible = False
                                       }
    ReadOnly newlabel As New Label() With {
                                      .Text = "New Note",
                                      .Location = New Point(15, 15),
                                      .Font = New Font("comic sans ms", 32, FontStyle.Bold Or FontStyle.Underline),
                                      .Width = 500,
                                      .Height = 60,
                                      .ForeColor = Color.White,
                                      .BackColor = Color.Transparent,
                                      .Visible = False
                                       }




    Public Sub NewNoteBtn_Click(sender As Object, e As EventArgs) Handles NewNoteBtn.Click
        Panel3.Show()
        new_name_textbox.Text = ""
        note_bg_color_picked.BackColor = Color.Transparent
        note_text_color_picked.BackColor = Color.Transparent
        newnote.Text = "write something..."
        newnote.BackColor = Color.White
        newnote.ForeColor = Color.Black
        selectedColor_text = Color.Black
        selectedColor_bg = Color.White
        newnote.Visible = False
        newlabel.Visible = False
        Increase_font.Visible = False
        Decrease_font.Visible = False
        fontText.Visible = False
        SetFont.Visible = False
        SaveNote.Visible = False
        CancelNote.Visible = False
        TextToSpeechBtn.Visible = False
    End Sub

    Public Sub Bg_color_picker_btn_Click_1(sender As Object, e As EventArgs) Handles Bg_color_picker_btn.Click
        ColorDialog1.ShowDialog()
        selectedColor_bg = ColorDialog1.Color
        note_bg_color_picked.BackColor = selectedColor_bg
    End Sub

    Public Sub Txt_color_picker_btn_Click_1(sender As Object, e As EventArgs) Handles Txt_color_picker_btn.Click
        ColorDialog2.ShowDialog()
        selectedColor_text = ColorDialog2.Color
        note_text_color_picked.BackColor = selectedColor_text
    End Sub

    Private Sub Cancel_creating_newNote_Click(sender As Object, e As EventArgs) Handles Cancel_creating_newNote.Click
        Panel3.Hide()
        Label1.Show()

        newnote.Visible = False
        newlabel.Visible = False
        Increase_font.Visible = False
        Decrease_font.Visible = False
        fontText.Visible = False
        SetFont.Visible = False
        SaveNote.Visible = False
        CancelNote.Visible = False
        TextToSpeechBtn.Visible = False
    End Sub

    Public Sub Create_newNote_Click(sender As Object, e As EventArgs) Handles Create_newNote.Click
        Me.Panel2.Controls.Add(newnote)
        Me.Panel2.Controls.Add(newlabel)

        If new_name_textbox.Text IsNot "" Then


            newnote.BackColor = selectedColor_bg
            newnote.ForeColor = selectedColor_text
            newnote.Visible = True


            newlabel.Text = new_name_textbox.Text

            newlabel.Visible = True

            Panel3.Hide()
            Label1.Hide()

            Increase_font.Visible = True
            Decrease_font.Visible = True
            fontText.Visible = True
            SetFont.Visible = True
            SaveNote.Visible = True
            CancelNote.Visible = True
            TextToSpeechBtn.Visible = True
        End If
    End Sub


    Private Sub Increase_font_Click(sender As Object, e As EventArgs) Handles Increase_font.Click
        i += 2
        newnote.Font = New Font("comic sans ms", i)
    End Sub

    Private Sub Decrease_font_Click(sender As Object, e As EventArgs) Handles Decrease_font.Click

        If i = 2 Then
            newnote.Font = New Font("comic sans ms", 2)
        Else i -= 2
        End If

        newnote.Font = New Font("comic sans ms", i)

    End Sub

    Private Sub SetFont_Click(sender As Object, e As EventArgs) Handles SetFont.Click

        i = fontText.Text
        newnote.Font = New Font("comic sans ms", i)
    End Sub

    Private Sub CancelNote_Click(sender As Object, e As EventArgs) Handles CancelNote.Click
        Label1.Show()
        newnote.Visible = False
        newlabel.Visible = False
        Increase_font.Visible = False
        Decrease_font.Visible = False
        fontText.Visible = False
        SetFont.Visible = False
        SaveNote.Visible = False
        CancelNote.Visible = False
        TextToSpeechBtn.Visible = False
    End Sub

    Private Sub SaveNote_Click(sender As Object, e As EventArgs) Handles SaveNote.Click

        System.IO.File.WriteAllText("C:\Users\crys_\OneDrive\Desktop\Note-App\" + newlabel.Text + ".txt", newnote.Text)
        System.IO.File.WriteAllText("C:\Users\crys_\OneDrive\Desktop\Note-App\bg\" + newlabel.Text + "bg.txt", selectedColor_bg.ToString)
        System.IO.File.WriteAllText("C:\Users\crys_\OneDrive\Desktop\Note-App\txt\" + newlabel.Text + "txt.txt", selectedColor_text.ToString)
        Label1.Show()
        newnote.Visible = False
        newlabel.Visible = False
        Increase_font.Visible = False
        Decrease_font.Visible = False
        fontText.Visible = False
        SetFont.Visible = False
        SaveNote.Visible = False
        CancelNote.Visible = False
        TextToSpeechBtn.Visible = False
        Me.ComboBox1.Items.Add(newlabel.Text)
    End Sub

    Private Sub OpenBtn_Click(sender As Object, e As EventArgs) Handles OpenBtn.Click

        If ComboBox1.Text Is "" Then
            ErrorNote.Visible = True
        Else
            ErrorNote.Visible = False
            newlabel.Text = ComboBox1.SelectedItem
            'newnote.Text = My.Computer.FileSystem.ReadAllText(newlabel.Text + ".txt")
            newnote.Text = System.IO.File.ReadAllText("C:\Users\crys_\OneDrive\Desktop\Note-App\" + newlabel.Text + ".txt")
            Dim bgTxt As String = System.IO.File.ReadAllText("C:\Users\crys_\OneDrive\Desktop\Note-App\bg\" + newlabel.Text + "bg.txt").Replace("Color [", "").Replace("]", "")
            Dim txtTxt As String = System.IO.File.ReadAllText("C:\Users\crys_\OneDrive\Desktop\Note-App\txt\" + newlabel.Text + "txt.txt").Replace("Color [", "").Replace("]", "")


            'newnote.BackColor = Color.FromArgb(System.IO.File.ReadAllText("C:\Users\crys_\OneDrive\Desktop\Note-App\bg\" + newlabel.Text + "bg.txt").Replace("Color [", "").Replace("]", "").Replace("A=", "").Replace("R=", "").Replace("G=", "").Replace("B=", ""))
            newnote.BackColor = Color.FromName(bgTxt)



            'newnote.ForeColor = Color.FromArgb(System.IO.File.ReadAllText("C:\Users\crys_\OneDrive\Desktop\Note-App\txt\" + newlabel.Text + "txt.txt").Replace("Color [", "").Replace("]", "").Replace("A=", "").Replace("R=", "").Replace("G=", "").Replace("B=", ""))
            newnote.ForeColor = Color.FromName(txtTxt)


            'newnote.BackColor = Color.FromName(System.IO.File.ReadAllText("C:\Users\crys_\OneDrive\Desktop\Note-App\bg\" + newlabel.Text + "bg.txt").Replace("Color [", "").Replace("]", ""))
            'newnote.ForeColor = Color.FromName(System.IO.File.ReadAllText("C:\Users\crys_\OneDrive\Desktop\Note-App\txt\" + newlabel.Text + "txt.txt").Replace("Color [", "").Replace("]", ""))
            newnote.Visible = True
            newlabel.Visible = True
            Increase_font.Visible = True
            Decrease_font.Visible = True
            fontText.Visible = True
            SetFont.Visible = True
            SaveNote.Visible = True
            CancelNote.Visible = True
            TextToSpeechBtn.Visible = True
            Label1.Hide()
        End If


    End Sub

    Private Sub TextToSpeechBtn_Click(sender As Object, e As EventArgs) Handles TextToSpeechBtn.Click
        If newnote.Text IsNot "" Then
            Dim tts = CreateObject("SAPI.spvoice")
            tts.speak(newnote.Text)
        End If

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If ComboBox1.Text Is "" Then
            ErrorNote.Visible = True
            ComboBox1.ForeColor = Color.Red
        Else
            ComboBox1.Items.Remove(ComboBox1.Text)
            ErrorNote.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
