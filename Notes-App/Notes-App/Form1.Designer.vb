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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorNote = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenBtn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NewNoteBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextToSpeechBtn = New System.Windows.Forms.Button()
        Me.SaveNote = New System.Windows.Forms.Button()
        Me.CancelNote = New System.Windows.Forms.Button()
        Me.SetFont = New System.Windows.Forms.Button()
        Me.fontText = New System.Windows.Forms.TextBox()
        Me.Decrease_font = New System.Windows.Forms.Button()
        Me.Increase_font = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Cancel_creating_newNote = New System.Windows.Forms.Button()
        Me.Create_newNote = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.note_text_color_picked = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_color_picker_btn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.note_bg_color_picked = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bg_color_picker_btn = New System.Windows.Forms.Button()
        Me.new_name_textbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.newColor = New System.Windows.Forms.Label()
        Me.newName = New System.Windows.Forms.Label()
        Me.popupTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ErrorNote)
        Me.Panel1.Controls.Add(Me.DeleteBtn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.OpenBtn)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.NewNoteBtn)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(-3, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 646)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 612)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Created by @Cristian Iacomachi"
        '
        'ErrorNote
        '
        Me.ErrorNote.AutoSize = True
        Me.ErrorNote.ForeColor = System.Drawing.Color.Crimson
        Me.ErrorNote.Location = New System.Drawing.Point(75, 329)
        Me.ErrorNote.Name = "ErrorNote"
        Me.ErrorNote.Size = New System.Drawing.Size(91, 13)
        Me.ErrorNote.TabIndex = 6
        Me.ErrorNote.Text = "Note not selected"
        Me.ErrorNote.Visible = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.Crimson
        Me.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DeleteBtn.Location = New System.Drawing.Point(166, 352)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(100, 35)
        Me.DeleteBtn.TabIndex = 5
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "View your notes :"
        '
        'OpenBtn
        '
        Me.OpenBtn.BackColor = System.Drawing.Color.Teal
        Me.OpenBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.OpenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OpenBtn.Location = New System.Drawing.Point(76, 352)
        Me.OpenBtn.Name = "OpenBtn"
        Me.OpenBtn.Size = New System.Drawing.Size(84, 35)
        Me.OpenBtn.TabIndex = 3
        Me.OpenBtn.Text = "Open"
        Me.OpenBtn.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(78, 292)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 34)
        Me.ComboBox1.TabIndex = 1
        '
        'NewNoteBtn
        '
        Me.NewNoteBtn.BackColor = System.Drawing.Color.Teal
        Me.NewNoteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewNoteBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.NewNoteBtn.FlatAppearance.BorderSize = 5
        Me.NewNoteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.NewNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewNoteBtn.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewNoteBtn.ForeColor = System.Drawing.Color.Black
        Me.NewNoteBtn.Location = New System.Drawing.Point(107, 174)
        Me.NewNoteBtn.Name = "NewNoteBtn"
        Me.NewNoteBtn.Size = New System.Drawing.Size(132, 43)
        Me.NewNoteBtn.TabIndex = 0
        Me.NewNoteBtn.Text = "New Note"
        Me.NewNoteBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Notes_App.My.Resources.Resources.ballpen
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(195, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 46)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Notes_App.My.Resources.Resources.logo1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(-337, -164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(993, 472)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        Me.ColorDialog1.FullOpen = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.TextToSpeechBtn)
        Me.Panel2.Controls.Add(Me.SaveNote)
        Me.Panel2.Controls.Add(Me.CancelNote)
        Me.Panel2.Controls.Add(Me.SetFont)
        Me.Panel2.Controls.Add(Me.fontText)
        Me.Panel2.Controls.Add(Me.Decrease_font)
        Me.Panel2.Controls.Add(Me.Increase_font)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(361, -3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(879, 646)
        Me.Panel2.TabIndex = 2
        '
        'TextToSpeechBtn
        '
        Me.TextToSpeechBtn.BackColor = System.Drawing.Color.Transparent
        Me.TextToSpeechBtn.BackgroundImage = Global.Notes_App.My.Resources.Resources.sound_icon
        Me.TextToSpeechBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TextToSpeechBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextToSpeechBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.TextToSpeechBtn.FlatAppearance.BorderSize = 0
        Me.TextToSpeechBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.TextToSpeechBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TextToSpeechBtn.Location = New System.Drawing.Point(790, 53)
        Me.TextToSpeechBtn.Name = "TextToSpeechBtn"
        Me.TextToSpeechBtn.Padding = New System.Windows.Forms.Padding(2)
        Me.TextToSpeechBtn.Size = New System.Drawing.Size(46, 40)
        Me.TextToSpeechBtn.TabIndex = 11
        Me.TextToSpeechBtn.UseVisualStyleBackColor = False
        Me.TextToSpeechBtn.Visible = False
        '
        'SaveNote
        '
        Me.SaveNote.BackColor = System.Drawing.Color.Teal
        Me.SaveNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.SaveNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.SaveNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveNote.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveNote.Location = New System.Drawing.Point(686, 557)
        Me.SaveNote.Name = "SaveNote"
        Me.SaveNote.Size = New System.Drawing.Size(73, 34)
        Me.SaveNote.TabIndex = 10
        Me.SaveNote.Text = "Save"
        Me.SaveNote.UseVisualStyleBackColor = False
        Me.SaveNote.Visible = False
        '
        'CancelNote
        '
        Me.CancelNote.BackColor = System.Drawing.Color.Crimson
        Me.CancelNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CancelNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CancelNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelNote.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelNote.Location = New System.Drawing.Point(774, 557)
        Me.CancelNote.Name = "CancelNote"
        Me.CancelNote.Size = New System.Drawing.Size(73, 34)
        Me.CancelNote.TabIndex = 10
        Me.CancelNote.Text = "Cancel"
        Me.CancelNote.UseVisualStyleBackColor = False
        Me.CancelNote.Visible = False
        '
        'SetFont
        '
        Me.SetFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetFont.Location = New System.Drawing.Point(188, 559)
        Me.SetFont.Name = "SetFont"
        Me.SetFont.Size = New System.Drawing.Size(34, 34)
        Me.SetFont.TabIndex = 5
        Me.SetFont.Text = "Set"
        Me.SetFont.UseVisualStyleBackColor = True
        Me.SetFont.Visible = False
        '
        'fontText
        '
        Me.fontText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontText.Location = New System.Drawing.Point(123, 559)
        Me.fontText.MaxLength = 3
        Me.fontText.Multiline = True
        Me.fontText.Name = "fontText"
        Me.fontText.Size = New System.Drawing.Size(59, 34)
        Me.fontText.TabIndex = 4
        Me.fontText.Tag = ""
        Me.fontText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.fontText.Visible = False
        '
        'Decrease_font
        '
        Me.Decrease_font.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Decrease_font.Location = New System.Drawing.Point(60, 559)
        Me.Decrease_font.Name = "Decrease_font"
        Me.Decrease_font.Size = New System.Drawing.Size(31, 34)
        Me.Decrease_font.TabIndex = 3
        Me.Decrease_font.Text = "-"
        Me.Decrease_font.UseVisualStyleBackColor = True
        Me.Decrease_font.Visible = False
        '
        'Increase_font
        '
        Me.Increase_font.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Increase_font.Location = New System.Drawing.Point(23, 559)
        Me.Increase_font.Name = "Increase_font"
        Me.Increase_font.Size = New System.Drawing.Size(31, 34)
        Me.Increase_font.TabIndex = 2
        Me.Increase_font.Text = "+"
        Me.Increase_font.UseVisualStyleBackColor = True
        Me.Increase_font.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Cancel_creating_newNote)
        Me.Panel3.Controls.Add(Me.Create_newNote)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.new_name_textbox)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.newColor)
        Me.Panel3.Controls.Add(Me.newName)
        Me.Panel3.Controls.Add(Me.popupTitle)
        Me.Panel3.Location = New System.Drawing.Point(150, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(545, 356)
        Me.Panel3.TabIndex = 1
        Me.Panel3.Visible = False
        '
        'Cancel_creating_newNote
        '
        Me.Cancel_creating_newNote.BackColor = System.Drawing.Color.Crimson
        Me.Cancel_creating_newNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_creating_newNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cancel_creating_newNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cancel_creating_newNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_creating_newNote.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_creating_newNote.Location = New System.Drawing.Point(273, 292)
        Me.Cancel_creating_newNote.Name = "Cancel_creating_newNote"
        Me.Cancel_creating_newNote.Size = New System.Drawing.Size(87, 29)
        Me.Cancel_creating_newNote.TabIndex = 9
        Me.Cancel_creating_newNote.Text = "Cancel"
        Me.Cancel_creating_newNote.UseVisualStyleBackColor = False
        '
        'Create_newNote
        '
        Me.Create_newNote.BackColor = System.Drawing.Color.Teal
        Me.Create_newNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Create_newNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Create_newNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Create_newNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Create_newNote.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create_newNote.Location = New System.Drawing.Point(178, 292)
        Me.Create_newNote.Name = "Create_newNote"
        Me.Create_newNote.Size = New System.Drawing.Size(87, 29)
        Me.Create_newNote.TabIndex = 8
        Me.Create_newNote.Text = "Create"
        Me.Create_newNote.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.note_text_color_picked)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Txt_color_picker_btn)
        Me.Panel5.Location = New System.Drawing.Point(298, 197)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(220, 61)
        Me.Panel5.TabIndex = 7
        '
        'note_text_color_picked
        '
        Me.note_text_color_picked.Location = New System.Drawing.Point(164, 17)
        Me.note_text_color_picked.Name = "note_text_color_picked"
        Me.note_text_color_picked.Size = New System.Drawing.Size(35, 28)
        Me.note_text_color_picked.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(52, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Selected color :"
        '
        'Txt_color_picker_btn
        '
        Me.Txt_color_picker_btn.BackColor = System.Drawing.Color.Transparent
        Me.Txt_color_picker_btn.BackgroundImage = Global.Notes_App.My.Resources.Resources.color_wheel
        Me.Txt_color_picker_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Txt_color_picker_btn.Location = New System.Drawing.Point(16, 17)
        Me.Txt_color_picker_btn.Name = "Txt_color_picker_btn"
        Me.Txt_color_picker_btn.Size = New System.Drawing.Size(30, 29)
        Me.Txt_color_picker_btn.TabIndex = 0
        Me.Txt_color_picker_btn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(294, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 26)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Pick the text color:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.note_bg_color_picked)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Bg_color_picker_btn)
        Me.Panel4.Location = New System.Drawing.Point(25, 197)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(220, 61)
        Me.Panel4.TabIndex = 5
        '
        'note_bg_color_picked
        '
        Me.note_bg_color_picked.Location = New System.Drawing.Point(164, 17)
        Me.note_bg_color_picked.Name = "note_bg_color_picked"
        Me.note_bg_color_picked.Size = New System.Drawing.Size(35, 28)
        Me.note_bg_color_picked.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(52, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Selected color :"
        '
        'Bg_color_picker_btn
        '
        Me.Bg_color_picker_btn.BackColor = System.Drawing.Color.Transparent
        Me.Bg_color_picker_btn.BackgroundImage = Global.Notes_App.My.Resources.Resources.color_wheel
        Me.Bg_color_picker_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bg_color_picker_btn.Location = New System.Drawing.Point(16, 17)
        Me.Bg_color_picker_btn.Name = "Bg_color_picker_btn"
        Me.Bg_color_picker_btn.Size = New System.Drawing.Size(30, 29)
        Me.Bg_color_picker_btn.TabIndex = 0
        Me.Bg_color_picker_btn.UseVisualStyleBackColor = False
        '
        'new_name_textbox
        '
        Me.new_name_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_name_textbox.Location = New System.Drawing.Point(24, 110)
        Me.new_name_textbox.Name = "new_name_textbox"
        Me.new_name_textbox.Size = New System.Drawing.Size(200, 26)
        Me.new_name_textbox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 2)
        Me.Label2.TabIndex = 3
        '
        'newColor
        '
        Me.newColor.AutoSize = True
        Me.newColor.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.newColor.Location = New System.Drawing.Point(20, 155)
        Me.newColor.Name = "newColor"
        Me.newColor.Size = New System.Drawing.Size(225, 26)
        Me.newColor.TabIndex = 2
        Me.newColor.Text = "Pick a background color:"
        '
        'newName
        '
        Me.newName.AutoSize = True
        Me.newName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.newName.Location = New System.Drawing.Point(19, 66)
        Me.newName.Name = "newName"
        Me.newName.Size = New System.Drawing.Size(68, 26)
        Me.newName.TabIndex = 1
        Me.newName.Text = "Name:"
        '
        'popupTitle
        '
        Me.popupTitle.AutoSize = True
        Me.popupTitle.BackColor = System.Drawing.Color.Transparent
        Me.popupTitle.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.popupTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.popupTitle.Location = New System.Drawing.Point(3, 0)
        Me.popupTitle.Name = "popupTitle"
        Me.popupTitle.Size = New System.Drawing.Size(347, 45)
        Me.popupTitle.TabIndex = 0
        Me.popupTitle.Text = "Creating a new note:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(332, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Blank..."
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 644)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Notes-App-@Crys28"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents NewNoteBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents newColor As Label
    Friend WithEvents newName As Label
    Friend WithEvents popupTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents new_name_textbox As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Bg_color_picker_btn As Button
    Friend WithEvents note_bg_color_picked As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents note_text_color_picked As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_color_picker_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Cancel_creating_newNote As Button
    Friend WithEvents Create_newNote As Button
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents Decrease_font As Button
    Friend WithEvents Increase_font As Button
    Friend WithEvents SetFont As Button
    Friend WithEvents fontText As TextBox
    Friend WithEvents SaveNote As Button
    Friend WithEvents CancelNote As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents OpenBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents TextToSpeechBtn As Button
    Friend WithEvents ErrorNote As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFD As OpenFileDialog
End Class
