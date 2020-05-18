<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitedStatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JapanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MexicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CountryToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(479, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CountryToolStripMenuItem
        '
        Me.CountryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnitedStatesToolStripMenuItem, Me.CanadaToolStripMenuItem, Me.JapanToolStripMenuItem, Me.MexicoToolStripMenuItem})
        Me.CountryToolStripMenuItem.Name = "CountryToolStripMenuItem"
        Me.CountryToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.CountryToolStripMenuItem.Text = "&Country"
        '
        'UnitedStatesToolStripMenuItem
        '
        Me.UnitedStatesToolStripMenuItem.CheckOnClick = True
        Me.UnitedStatesToolStripMenuItem.Name = "UnitedStatesToolStripMenuItem"
        Me.UnitedStatesToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.UnitedStatesToolStripMenuItem.Text = "&United States"
        '
        'CanadaToolStripMenuItem
        '
        Me.CanadaToolStripMenuItem.CheckOnClick = True
        Me.CanadaToolStripMenuItem.Name = "CanadaToolStripMenuItem"
        Me.CanadaToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.CanadaToolStripMenuItem.Text = "Ca&nada"
        '
        'JapanToolStripMenuItem
        '
        Me.JapanToolStripMenuItem.CheckOnClick = True
        Me.JapanToolStripMenuItem.Name = "JapanToolStripMenuItem"
        Me.JapanToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.JapanToolStripMenuItem.Text = "&Japan"
        '
        'MexicoToolStripMenuItem
        '
        Me.MexicoToolStripMenuItem.CheckOnClick = True
        Me.MexicoToolStripMenuItem.Name = "MexicoToolStripMenuItem"
        Me.MexicoToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.MexicoToolStripMenuItem.Text = "&Mexico"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitleToolStripMenuItem, Me.CountryToolStripMenuItem1, Me.ProgrammerToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'TitleToolStripMenuItem
        '
        Me.TitleToolStripMenuItem.Checked = True
        Me.TitleToolStripMenuItem.CheckOnClick = True
        Me.TitleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem"
        Me.TitleToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.TitleToolStripMenuItem.Text = "&Title"
        '
        'CountryToolStripMenuItem1
        '
        Me.CountryToolStripMenuItem1.CheckOnClick = True
        Me.CountryToolStripMenuItem1.Name = "CountryToolStripMenuItem1"
        Me.CountryToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
        Me.CountryToolStripMenuItem1.Text = "C&ountry Name"
        '
        'ProgrammerToolStripMenuItem
        '
        Me.ProgrammerToolStripMenuItem.CheckOnClick = True
        Me.ProgrammerToolStripMenuItem.Name = "ProgrammerToolStripMenuItem"
        Me.ProgrammerToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ProgrammerToolStripMenuItem.Text = "&Programmer"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Flag Viewer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(120, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Country"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(12, 403)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(232, 132)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.InitialImage = Nothing
        Me.PictureBox4.Location = New System.Drawing.Point(235, 403)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(232, 132)
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.InitialImage = Nothing
        Me.PictureBox5.Location = New System.Drawing.Point(235, 435)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(232, 132)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Programmed By: TBS Author"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(12, 435)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(232, 132)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 603)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flag Viewer Application"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitedStatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CanadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JapanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MexicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TitleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProgrammerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
