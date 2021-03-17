<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMSBomber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMSBomber))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.virgin = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cricket = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.boost = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.alltel = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.sprint = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.tmobile = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rogers = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.cellcom = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.bluegrass = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.metropcs = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.verizon = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.att = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.PhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BombTime = New System.Windows.Forms.TextBox()
        Me.multipleText = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Subject = New System.Windows.Forms.TextBox()
        Me.MessageToBomb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Showpass = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.ClearMail = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.LoadMail = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.saveSettings = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.emailPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.emailEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Start = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.virgin)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cricket)
        Me.GroupBox1.Controls.Add(Me.boost)
        Me.GroupBox1.Controls.Add(Me.alltel)
        Me.GroupBox1.Controls.Add(Me.sprint)
        Me.GroupBox1.Controls.Add(Me.tmobile)
        Me.GroupBox1.Controls.Add(Me.rogers)
        Me.GroupBox1.Controls.Add(Me.cellcom)
        Me.GroupBox1.Controls.Add(Me.bluegrass)
        Me.GroupBox1.Controls.Add(Me.metropcs)
        Me.GroupBox1.Controls.Add(Me.verizon)
        Me.GroupBox1.Controls.Add(Me.att)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 153)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carriers"
        '
        'virgin
        '
        Me.virgin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.virgin.Location = New System.Drawing.Point(89, 129)
        Me.virgin.Name = "virgin"
        Me.virgin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.virgin.Size = New System.Drawing.Size(51, 16)
        Me.virgin.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.virgin.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.virgin.TabIndex = 37
        Me.virgin.Values.Text = "Virgin"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 14)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "*"
        '
        'cricket
        '
        Me.cricket.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cricket.Location = New System.Drawing.Point(89, 107)
        Me.cricket.Name = "cricket"
        Me.cricket.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.cricket.Size = New System.Drawing.Size(57, 16)
        Me.cricket.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.cricket.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cricket.TabIndex = 36
        Me.cricket.Values.Text = "Cricket"
        '
        'boost
        '
        Me.boost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.boost.Location = New System.Drawing.Point(89, 85)
        Me.boost.Name = "boost"
        Me.boost.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.boost.Size = New System.Drawing.Size(51, 16)
        Me.boost.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.boost.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boost.TabIndex = 35
        Me.boost.Values.Text = "Boost"
        '
        'alltel
        '
        Me.alltel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.alltel.Location = New System.Drawing.Point(89, 63)
        Me.alltel.Name = "alltel"
        Me.alltel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.alltel.Size = New System.Drawing.Size(47, 16)
        Me.alltel.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.alltel.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alltel.TabIndex = 34
        Me.alltel.Values.Text = "Alltel"
        '
        'sprint
        '
        Me.sprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sprint.Location = New System.Drawing.Point(89, 41)
        Me.sprint.Name = "sprint"
        Me.sprint.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.sprint.Size = New System.Drawing.Size(52, 16)
        Me.sprint.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.sprint.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sprint.TabIndex = 33
        Me.sprint.Values.Text = "Sprint"
        '
        'tmobile
        '
        Me.tmobile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmobile.Location = New System.Drawing.Point(89, 19)
        Me.tmobile.Name = "tmobile"
        Me.tmobile.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.tmobile.Size = New System.Drawing.Size(66, 16)
        Me.tmobile.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.tmobile.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmobile.TabIndex = 32
        Me.tmobile.Values.Text = "T-Mobile"
        '
        'rogers
        '
        Me.rogers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rogers.Location = New System.Drawing.Point(6, 129)
        Me.rogers.Name = "rogers"
        Me.rogers.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.rogers.Size = New System.Drawing.Size(59, 16)
        Me.rogers.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.rogers.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rogers.TabIndex = 31
        Me.rogers.Values.Text = "Rogers"
        '
        'cellcom
        '
        Me.cellcom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cellcom.Location = New System.Drawing.Point(6, 107)
        Me.cellcom.Name = "cellcom"
        Me.cellcom.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.cellcom.Size = New System.Drawing.Size(63, 16)
        Me.cellcom.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.cellcom.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cellcom.TabIndex = 30
        Me.cellcom.Values.Text = "Cellcom"
        '
        'bluegrass
        '
        Me.bluegrass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bluegrass.Location = New System.Drawing.Point(6, 85)
        Me.bluegrass.Name = "bluegrass"
        Me.bluegrass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.bluegrass.Size = New System.Drawing.Size(75, 16)
        Me.bluegrass.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.bluegrass.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bluegrass.TabIndex = 29
        Me.bluegrass.Values.Text = "BlueGrass"
        '
        'metropcs
        '
        Me.metropcs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.metropcs.Location = New System.Drawing.Point(6, 63)
        Me.metropcs.Name = "metropcs"
        Me.metropcs.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.metropcs.Size = New System.Drawing.Size(74, 16)
        Me.metropcs.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.metropcs.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metropcs.TabIndex = 28
        Me.metropcs.Values.Text = "MetroPCS"
        '
        'verizon
        '
        Me.verizon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.verizon.Location = New System.Drawing.Point(6, 41)
        Me.verizon.Name = "verizon"
        Me.verizon.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.verizon.Size = New System.Drawing.Size(61, 16)
        Me.verizon.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.verizon.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verizon.TabIndex = 27
        Me.verizon.Values.Text = "Verizon"
        '
        'att
        '
        Me.att.Cursor = System.Windows.Forms.Cursors.Hand
        Me.att.Location = New System.Drawing.Point(6, 19)
        Me.att.Name = "att"
        Me.att.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.att.Size = New System.Drawing.Size(44, 16)
        Me.att.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.att.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.att.TabIndex = 26
        Me.att.Values.Text = "ATT"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhoneNumber.ForeColor = System.Drawing.Color.Gray
        Me.PhoneNumber.Location = New System.Drawing.Point(12, 48)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(160, 20)
        Me.PhoneNumber.TabIndex = 4
        Me.PhoneNumber.Text = "1234567890"
        Me.PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(156, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 14)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 14)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Enter 10-Digit Phone Number"
        '
        'BombTime
        '
        Me.BombTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BombTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BombTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BombTime.ForeColor = System.Drawing.Color.White
        Me.BombTime.Location = New System.Drawing.Point(12, 91)
        Me.BombTime.Name = "BombTime"
        Me.BombTime.Size = New System.Drawing.Size(160, 20)
        Me.BombTime.TabIndex = 35
        Me.BombTime.Text = "2"
        Me.BombTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'multipleText
        '
        Me.multipleText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.multipleText.Location = New System.Drawing.Point(12, 117)
        Me.multipleText.Name = "multipleText"
        Me.multipleText.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.multipleText.Size = New System.Drawing.Size(93, 16)
        Me.multipleText.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.multipleText.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multipleText.TabIndex = 36
        Me.multipleText.Values.Text = "Multiple Texts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 14)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Number of times to bomb"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 24)
        Me.Panel1.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Roasting SMS Bomber"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Roasting_SMS_Bomber.My.Resources.Resources.phone
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(331, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Subject
        '
        Me.Subject.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Subject.ForeColor = System.Drawing.Color.White
        Me.Subject.Location = New System.Drawing.Point(193, 48)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(150, 20)
        Me.Subject.TabIndex = 39
        '
        'MessageToBomb
        '
        Me.MessageToBomb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MessageToBomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageToBomb.ForeColor = System.Drawing.Color.White
        Me.MessageToBomb.Location = New System.Drawing.Point(193, 91)
        Me.MessageToBomb.Multiline = True
        Me.MessageToBomb.Name = "MessageToBomb"
        Me.MessageToBomb.Size = New System.Drawing.Size(150, 42)
        Me.MessageToBomb.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(287, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 14)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 14)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Message To Bomb"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(236, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 14)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 14)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Subject"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Showpass)
        Me.GroupBox3.Controls.Add(Me.ClearMail)
        Me.GroupBox3.Controls.Add(Me.LoadMail)
        Me.GroupBox3.Controls.Add(Me.saveSettings)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.emailPass)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.emailEmail)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(187, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(156, 143)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Login Info"
        '
        'Showpass
        '
        Me.Showpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Showpass.Location = New System.Drawing.Point(112, 74)
        Me.Showpass.Name = "Showpass"
        Me.Showpass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Showpass.Size = New System.Drawing.Size(47, 14)
        Me.Showpass.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.Showpass.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.Showpass.TabIndex = 41
        Me.Showpass.Values.Text = "Show"
        '
        'ClearMail
        '
        Me.ClearMail.Location = New System.Drawing.Point(84, 119)
        Me.ClearMail.Name = "ClearMail"
        Me.ClearMail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.ClearMail.Size = New System.Drawing.Size(66, 18)
        Me.ClearMail.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.ClearMail.TabIndex = 39
        Me.ClearMail.Values.Text = "Clear"
        '
        'LoadMail
        '
        Me.LoadMail.Location = New System.Drawing.Point(6, 119)
        Me.LoadMail.Name = "LoadMail"
        Me.LoadMail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.LoadMail.Size = New System.Drawing.Size(66, 18)
        Me.LoadMail.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.LoadMail.TabIndex = 38
        Me.LoadMail.Values.Text = "Load"
        '
        'saveSettings
        '
        Me.saveSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveSettings.Location = New System.Drawing.Point(9, 97)
        Me.saveSettings.Name = "saveSettings"
        Me.saveSettings.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.saveSettings.Size = New System.Drawing.Size(93, 16)
        Me.saveSettings.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.saveSettings.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveSettings.TabIndex = 37
        Me.saveSettings.Values.Text = "Save Settings"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(61, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 14)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 14)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "*"
        '
        'emailPass
        '
        Me.emailPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.emailPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailPass.ForeColor = System.Drawing.Color.White
        Me.emailPass.Location = New System.Drawing.Point(6, 71)
        Me.emailPass.Name = "emailPass"
        Me.emailPass.Size = New System.Drawing.Size(105, 20)
        Me.emailPass.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 14)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Password:"
        '
        'emailEmail
        '
        Me.emailEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.emailEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailEmail.ForeColor = System.Drawing.Color.White
        Me.emailEmail.Location = New System.Drawing.Point(6, 32)
        Me.emailEmail.Name = "emailEmail"
        Me.emailEmail.Size = New System.Drawing.Size(144, 20)
        Me.emailEmail.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Email:"
        '
        'Start
        '
        Me.Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Start.Location = New System.Drawing.Point(217, 288)
        Me.Start.Name = "Start"
        Me.Start.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Start.Size = New System.Drawing.Size(90, 25)
        Me.Start.StateNormal.Back.Color1 = System.Drawing.Color.Black
        Me.Start.StateNormal.Back.Color2 = System.Drawing.Color.Black
        Me.Start.TabIndex = 46
        Me.Start.Values.Text = "Start Bombing"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 299)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 14)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "* field is required"
        '
        'SMSBomber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(355, 322)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MessageToBomb)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.multipleText)
        Me.Controls.Add(Me.BombTime)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SMSBomber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents virgin As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents cricket As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents boost As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents alltel As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents sprint As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents tmobile As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rogers As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents cellcom As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents bluegrass As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents metropcs As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents verizon As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents att As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents PhoneNumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BombTime As TextBox
    Friend WithEvents multipleText As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Subject As TextBox
    Friend WithEvents MessageToBomb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents emailPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents emailEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Start As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ClearMail As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents LoadMail As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents saveSettings As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents Showpass As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
