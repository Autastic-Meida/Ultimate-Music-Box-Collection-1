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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button_About = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar_Volume = New System.Windows.Forms.TrackBar()
        Me.btnTogglePlayback = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar_Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Ultimate_MusicBox_Collection_1.My.Resources.Resources.ImageBoxMoveMed
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(519, 404)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Music Select: (Click on Loop Selected Music first, to loop selected music)", "01: Minuet - Luigi Boccherini", "02: Nocturne op.9 No.2 - Chopin", "03: Peer Gynt (Morning) - Grieg", "04: Peer Gynt Suite No.1 (In the Hall of the Mountain King) - Grieg", "05: Piano Concerto No.1 - Tchaikovsky", "06: Piano Sonata No. 14 (Moonlight Sonata) - Beethoven", "07: Piano Sonata No.8 (Patheyique 3rd movement) - Beethoven", "08: Radetzky March - Johann Strauss Sr.", "09: Requiem Dies Irae - Mozart", "10: Salut d’Amour Op.12 - Edward Elgar", "11: Swan Lake - Tchaikovsky", "12: Symphony No. 9  (New World 2nd Movement) - Dvorak"})
        Me.ComboBox2.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(420, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Ultimate_MusicBox_Collection_1.My.Resources.Resources.am_logo_banner_large
        Me.PictureBox3.Location = New System.Drawing.Point(6, 71)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(263, 71)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Button_Clear
        '
        Me.Button_Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Clear.Location = New System.Drawing.Point(346, 83)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(80, 21)
        Me.Button_Clear.TabIndex = 5
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Close.Location = New System.Drawing.Point(346, 110)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(166, 32)
        Me.Button_Close.TabIndex = 7
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Music Select: (Click on Loop Selected Music first, to loop selected music)", "01: Minuet - Luigi Boccherini", "02: Nocturne op.9 No.2 - Chopin", "03: Peer Gynt (Morning) - Grieg", "04: Peer Gynt Suite No.1 (In the Hall of the Mountain King) - Grieg", "05: Piano Concerto No.1 - Tchaikovsky", "06: Piano Sonata No. 14 (Moonlight Sonata) - Beethoven", "07: Piano Sonata No.8 (Patheyique 3rd movement) - Beethoven", "08: Radetzky March - Johann Strauss Sr.", "09: Requiem Dies Irae - Mozart", "10: Salut d’Amour Op.12 - Edward Elgar", "11: Swan Lake - Tchaikovsky", "12: Symphony No. 9  (New World 2nd Movement) - Dvorak"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(420, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(285, 46)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(126, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Loop Selected Music"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button_About
        '
        Me.Button_About.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_About.Location = New System.Drawing.Point(432, 83)
        Me.Button_About.Name = "Button_About"
        Me.Button_About.Size = New System.Drawing.Size(80, 21)
        Me.Button_About.TabIndex = 6
        Me.Button_About.Text = "About"
        Me.Button_About.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(427, 46)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "Play all in list"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Ultimate_MusicBox_Collection_1.My.Resources.Resources.music_box
        Me.PictureBox2.Location = New System.Drawing.Point(275, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 59)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.TrackBar_Volume)
        Me.GroupBox1.Controls.Add(Me.btnTogglePlayback)
        Me.GroupBox1.Controls.Add(Me.Button_About)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button_Close)
        Me.GroupBox1.Controls.Add(Me.Button_Clear)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 423)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 148)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(254, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(197, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "75"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(137, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(75, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "25"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "0"
        '
        'TrackBar_Volume
        '
        Me.TrackBar_Volume.LargeChange = 25
        Me.TrackBar_Volume.Location = New System.Drawing.Point(6, 42)
        Me.TrackBar_Volume.Maximum = 100
        Me.TrackBar_Volume.Name = "TrackBar_Volume"
        Me.TrackBar_Volume.Size = New System.Drawing.Size(273, 45)
        Me.TrackBar_Volume.SmallChange = 5
        Me.TrackBar_Volume.TabIndex = 2
        Me.TrackBar_Volume.TickFrequency = 25
        Me.TrackBar_Volume.Value = 100
        '
        'btnTogglePlayback
        '
        Me.btnTogglePlayback.Location = New System.Drawing.Point(432, 18)
        Me.btnTogglePlayback.Name = "btnTogglePlayback"
        Me.btnTogglePlayback.Size = New System.Drawing.Size(80, 23)
        Me.btnTogglePlayback.TabIndex = 1
        Me.btnTogglePlayback.Text = "Pause"
        Me.btnTogglePlayback.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 120)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(512, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 583)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ultimate Music Box - Collection 1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar_Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Clear As System.Windows.Forms.Button
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button_About As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnTogglePlayback As Button
    Friend WithEvents TrackBar_Volume As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
