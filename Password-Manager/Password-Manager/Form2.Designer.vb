<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Facebook", System.Drawing.Color.Cornsilk, System.Drawing.Color.DarkGoldenrod, New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "123Denis123", System.Drawing.Color.Gold, System.Drawing.Color.DarkGoldenrod, New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Youtube", System.Drawing.Color.Cornsilk, System.Drawing.Color.DarkGoldenrod, New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "yt2000yt", System.Drawing.Color.Gold, System.Drawing.Color.DarkGoldenrod, New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.AddPswdPanel = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.NewName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddNewPassword = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RemPswdPanel = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RemovePassword = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.AddPswdPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.RemPswdPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.ExitBtn)
        Me.Panel1.Controls.Add(Me.AddPswdPanel)
        Me.Panel1.Controls.Add(Me.AddNewPassword)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 532)
        Me.Panel1.TabIndex = 0
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(99, 496)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(62, 23)
        Me.ExitBtn.TabIndex = 8
        Me.ExitBtn.Text = "EXIT"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'AddPswdPanel
        '
        Me.AddPswdPanel.BackColor = System.Drawing.Color.Cornsilk
        Me.AddPswdPanel.Controls.Add(Me.Button4)
        Me.AddPswdPanel.Controls.Add(Me.NewPassword)
        Me.AddPswdPanel.Controls.Add(Me.NewName)
        Me.AddPswdPanel.Controls.Add(Me.Label3)
        Me.AddPswdPanel.Controls.Add(Me.Label1)
        Me.AddPswdPanel.Location = New System.Drawing.Point(32, 224)
        Me.AddPswdPanel.Name = "AddPswdPanel"
        Me.AddPswdPanel.Size = New System.Drawing.Size(197, 183)
        Me.AddPswdPanel.TabIndex = 7
        Me.AddPswdPanel.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(67, 147)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NewPassword
        '
        Me.NewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassword.Location = New System.Drawing.Point(23, 104)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.Size = New System.Drawing.Size(146, 29)
        Me.NewPassword.TabIndex = 3
        '
        'NewName
        '
        Me.NewName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewName.Location = New System.Drawing.Point(23, 39)
        Me.NewName.Name = "NewName"
        Me.NewName.Size = New System.Drawing.Size(146, 29)
        Me.NewName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'AddNewPassword
        '
        Me.AddNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewPassword.Location = New System.Drawing.Point(32, 151)
        Me.AddNewPassword.Name = "AddNewPassword"
        Me.AddNewPassword.Size = New System.Drawing.Size(197, 37)
        Me.AddNewPassword.TabIndex = 6
        Me.AddNewPassword.Text = "Add New Password"
        Me.AddNewPassword.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Password_Manager.My.Resources.Resources.unlocked
        Me.PictureBox1.Location = New System.Drawing.Point(99, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Papyrus", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password Manager"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Panel2.Controls.Add(Me.RemPswdPanel)
        Me.Panel2.Controls.Add(Me.RemovePassword)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Location = New System.Drawing.Point(265, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 532)
        Me.Panel2.TabIndex = 1
        '
        'RemPswdPanel
        '
        Me.RemPswdPanel.BackColor = System.Drawing.Color.Cornsilk
        Me.RemPswdPanel.Controls.Add(Me.Button5)
        Me.RemPswdPanel.Controls.Add(Me.TextBox3)
        Me.RemPswdPanel.Controls.Add(Me.Label4)
        Me.RemPswdPanel.Location = New System.Drawing.Point(210, 443)
        Me.RemPswdPanel.Name = "RemPswdPanel"
        Me.RemPswdPanel.Size = New System.Drawing.Size(313, 76)
        Me.RemPswdPanel.TabIndex = 10
        Me.RemPswdPanel.Visible = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(206, 21)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 38)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Remove"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(6, 38)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(146, 29)
        Me.TextBox3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Tomato
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 36)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Write the exact name of the item you want removed:"
        '
        'RemovePassword
        '
        Me.RemovePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemovePassword.Location = New System.Drawing.Point(24, 454)
        Me.RemovePassword.Name = "RemovePassword"
        Me.RemovePassword.Size = New System.Drawing.Size(135, 56)
        Me.RemovePassword.TabIndex = 9
        Me.RemovePassword.Text = "Remove Password"
        Me.RemovePassword.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Cornsilk
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        ListViewItem5.StateImageIndex = 0
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6})
        Me.ListView1.Location = New System.Drawing.Point(24, 11)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(499, 426)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 245
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Password"
        Me.ColumnHeader2.Width = 250
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 532)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AddPswdPanel.ResumeLayout(False)
        Me.AddPswdPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.RemPswdPanel.ResumeLayout(False)
        Me.RemPswdPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitBtn As Button
    Friend WithEvents AddPswdPanel As Panel
    Friend WithEvents AddNewPassword As Button
    Friend WithEvents RemovePassword As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents NewPassword As TextBox
    Friend WithEvents NewName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RemPswdPanel As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
