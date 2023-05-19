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
        Me.TextBoxIP = New System.Windows.Forms.TextBox()
        Me.TextBoxPort = New System.Windows.Forms.TextBox()
        Me.RichTextBoxSend = New System.Windows.Forms.RichTextBox()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.ButtonChange = New System.Windows.Forms.Button()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.RichTextBoxReceive = New System.Windows.Forms.RichTextBox()
        Me.ButtonClearTexttoSend = New System.Windows.Forms.Button()
        Me.TimerRcv = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonClearTextReceived = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtHost = New System.Windows.Forms.TextBox()
        Me.BtnStartRev = New System.Windows.Forms.Button()
        Me.ESP32Host = New System.Windows.Forms.Label()
        Me.VBHostname = New System.Windows.Forms.Label()
        Me.TxtIotHost = New System.Windows.Forms.TextBox()
        Me.RTxt = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'TextBoxIP
        '
        Me.TextBoxIP.Location = New System.Drawing.Point(28, 71)
        Me.TextBoxIP.Name = "TextBoxIP"
        Me.TextBoxIP.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxIP.TabIndex = 0
        '
        'TextBoxPort
        '
        Me.TextBoxPort.Location = New System.Drawing.Point(217, 71)
        Me.TextBoxPort.Name = "TextBoxPort"
        Me.TextBoxPort.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPort.TabIndex = 1
        '
        'RichTextBoxSend
        '
        Me.RichTextBoxSend.Location = New System.Drawing.Point(28, 97)
        Me.RichTextBoxSend.Name = "RichTextBoxSend"
        Me.RichTextBoxSend.Size = New System.Drawing.Size(302, 117)
        Me.RichTextBoxSend.TabIndex = 2
        Me.RichTextBoxSend.Text = ""
        '
        'ButtonApply
        '
        Me.ButtonApply.Location = New System.Drawing.Point(28, 15)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(75, 23)
        Me.ButtonApply.TabIndex = 3
        Me.ButtonApply.Text = "Apply"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'ButtonChange
        '
        Me.ButtonChange.Location = New System.Drawing.Point(230, 15)
        Me.ButtonChange.Name = "ButtonChange"
        Me.ButtonChange.Size = New System.Drawing.Size(75, 23)
        Me.ButtonChange.TabIndex = 4
        Me.ButtonChange.Text = "Change"
        Me.ButtonChange.UseVisualStyleBackColor = True
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(336, 103)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSend.TabIndex = 5
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'RichTextBoxReceive
        '
        Me.RichTextBoxReceive.Location = New System.Drawing.Point(28, 303)
        Me.RichTextBoxReceive.Name = "RichTextBoxReceive"
        Me.RichTextBoxReceive.Size = New System.Drawing.Size(302, 125)
        Me.RichTextBoxReceive.TabIndex = 7
        Me.RichTextBoxReceive.Text = ""
        '
        'ButtonClearTexttoSend
        '
        Me.ButtonClearTexttoSend.Location = New System.Drawing.Point(336, 147)
        Me.ButtonClearTexttoSend.Name = "ButtonClearTexttoSend"
        Me.ButtonClearTexttoSend.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClearTexttoSend.TabIndex = 8
        Me.ButtonClearTexttoSend.Text = "Clear"
        Me.ButtonClearTexttoSend.UseVisualStyleBackColor = True
        '
        'TimerRcv
        '
        Me.TimerRcv.Interval = 50
        '
        'ButtonClearTextReceived
        '
        Me.ButtonClearTextReceived.Location = New System.Drawing.Point(348, 303)
        Me.ButtonClearTextReceived.Name = "ButtonClearTextReceived"
        Me.ButtonClearTextReceived.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClearTextReceived.TabIndex = 9
        Me.ButtonClearTextReceived.Text = "Clear"
        Me.ButtonClearTextReceived.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DisConnected"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "DisConnected"
        '
        'TxtHost
        '
        Me.TxtHost.Location = New System.Drawing.Point(28, 49)
        Me.TxtHost.Name = "TxtHost"
        Me.TxtHost.Size = New System.Drawing.Size(169, 20)
        Me.TxtHost.TabIndex = 13
        '
        'BtnStartRev
        '
        Me.BtnStartRev.Location = New System.Drawing.Point(348, 274)
        Me.BtnStartRev.Name = "BtnStartRev"
        Me.BtnStartRev.Size = New System.Drawing.Size(75, 23)
        Me.BtnStartRev.TabIndex = 14
        Me.BtnStartRev.Text = "Start"
        Me.BtnStartRev.UseVisualStyleBackColor = True
        '
        'ESP32Host
        '
        Me.ESP32Host.AutoSize = True
        Me.ESP32Host.Location = New System.Drawing.Point(346, 235)
        Me.ESP32Host.Name = "ESP32Host"
        Me.ESP32Host.Size = New System.Drawing.Size(57, 13)
        Me.ESP32Host.TabIndex = 15
        Me.ESP32Host.Text = "HostName"
        '
        'VBHostname
        '
        Me.VBHostname.AutoSize = True
        Me.VBHostname.Location = New System.Drawing.Point(343, 74)
        Me.VBHostname.Name = "VBHostname"
        Me.VBHostname.Size = New System.Drawing.Size(57, 13)
        Me.VBHostname.TabIndex = 16
        Me.VBHostname.Text = "HostName"
        '
        'TxtIotHost
        '
        Me.TxtIotHost.Location = New System.Drawing.Point(217, 44)
        Me.TxtIotHost.Name = "TxtIotHost"
        Me.TxtIotHost.Size = New System.Drawing.Size(169, 20)
        Me.TxtIotHost.TabIndex = 17
        '
        'RTxt
        '
        Me.RTxt.Location = New System.Drawing.Point(28, 220)
        Me.RTxt.Name = "RTxt"
        Me.RTxt.Size = New System.Drawing.Size(302, 50)
        Me.RTxt.TabIndex = 18
        Me.RTxt.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(447, 440)
        Me.Controls.Add(Me.RTxt)
        Me.Controls.Add(Me.TxtIotHost)
        Me.Controls.Add(Me.VBHostname)
        Me.Controls.Add(Me.ESP32Host)
        Me.Controls.Add(Me.BtnStartRev)
        Me.Controls.Add(Me.TxtHost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonClearTextReceived)
        Me.Controls.Add(Me.ButtonClearTexttoSend)
        Me.Controls.Add(Me.RichTextBoxReceive)
        Me.Controls.Add(Me.ButtonSend)
        Me.Controls.Add(Me.ButtonChange)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.RichTextBoxSend)
        Me.Controls.Add(Me.TextBoxPort)
        Me.Controls.Add(Me.TextBoxIP)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxIP As TextBox
    Friend WithEvents TextBoxPort As TextBox
    Friend WithEvents RichTextBoxSend As RichTextBox
    Friend WithEvents ButtonApply As Button
    Friend WithEvents ButtonChange As Button
    Friend WithEvents ButtonSend As Button
    Friend WithEvents RichTextBoxReceive As RichTextBox
    Friend WithEvents ButtonClearTexttoSend As Button
    Friend WithEvents TimerRcv As Timer
    Friend WithEvents ButtonClearTextReceived As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtHost As TextBox
    Friend WithEvents BtnStartRev As Button
    Friend WithEvents ESP32Host As Label
    Friend WithEvents VBHostname As Label
    Friend WithEvents TxtIotHost As TextBox
    Friend WithEvents RTxt As RichTextBox
End Class
