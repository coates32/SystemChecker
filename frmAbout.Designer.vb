<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.License_Label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtbLicense = New System.Windows.Forms.RichTextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'License_Label
        '
        Me.License_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.License_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.License_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.License_Label.Location = New System.Drawing.Point(6, 16)
        Me.License_Label.Name = "License_Label"
        Me.License_Label.Size = New System.Drawing.Size(367, 30)
        Me.License_Label.TabIndex = 1
        Me.License_Label.Text = "License Information:"
        Me.License_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.rtbLicense)
        Me.GroupBox1.Controls.Add(Me.License_Label)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(705, 542)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'rtbLicense
        '
        Me.rtbLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbLicense.Location = New System.Drawing.Point(13, 49)
        Me.rtbLicense.Name = "rtbLicense"
        Me.rtbLicense.Size = New System.Drawing.Size(677, 428)
        Me.rtbLicense.TabIndex = 2
        Me.rtbLicense.Text = ""
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(402, 483)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(221, 43)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(67, 483)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(221, 43)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save To File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAbout"
        Me.Text = "About"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents License_Label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtbLicense As RichTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
End Class
