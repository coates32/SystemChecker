<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.OS_Label = New System.Windows.Forms.Label()
        Me.RAM_Label = New System.Windows.Forms.Label()
        Me.Processor_Label = New System.Windows.Forms.Label()
        Me.MOBO_Label = New System.Windows.Forms.Label()
        Me.VRAM_Label = New System.Windows.Forms.Label()
        Me.Rez_Label = New System.Windows.Forms.Label()
        Me.lblMOBO = New System.Windows.Forms.Label()
        Me.lblVRam = New System.Windows.Forms.Label()
        Me.lblRez = New System.Windows.Forms.Label()
        Me.lblProcessor = New System.Windows.Forms.Label()
        Me.lblRam = New System.Windows.Forms.Label()
        Me.lblOS = New System.Windows.Forms.Label()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.lblVAdapter = New System.Windows.Forms.Label()
        Me.VName_Label = New System.Windows.Forms.Label()
        Me.lblSerialNo = New System.Windows.Forms.Label()
        Me.Serial_Label = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.sfdbSystem = New System.Windows.Forms.SaveFileDialog()
        Me.pBarStatus = New System.Windows.Forms.ProgressBar()
        Me.bgwScan = New System.ComponentModel.BackgroundWorker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblPercent = New System.Windows.Forms.LinkLabel()
        Me.lblMOBOBrand = New System.Windows.Forms.Label()
        Me.MOBO_Brand_Label = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OS_Label
        '
        Me.OS_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OS_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OS_Label.Location = New System.Drawing.Point(13, 22)
        Me.OS_Label.Name = "OS_Label"
        Me.OS_Label.Size = New System.Drawing.Size(367, 30)
        Me.OS_Label.TabIndex = 0
        Me.OS_Label.Text = "OS"
        Me.OS_Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RAM_Label
        '
        Me.RAM_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RAM_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAM_Label.Location = New System.Drawing.Point(13, 109)
        Me.RAM_Label.Name = "RAM_Label"
        Me.RAM_Label.Size = New System.Drawing.Size(367, 29)
        Me.RAM_Label.TabIndex = 1
        Me.RAM_Label.Text = "System RAM"
        Me.RAM_Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Processor_Label
        '
        Me.Processor_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Processor_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Processor_Label.Location = New System.Drawing.Point(13, 152)
        Me.Processor_Label.Name = "Processor_Label"
        Me.Processor_Label.Size = New System.Drawing.Size(367, 29)
        Me.Processor_Label.TabIndex = 2
        Me.Processor_Label.Text = "Processor"
        Me.Processor_Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MOBO_Label
        '
        Me.MOBO_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MOBO_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOBO_Label.Location = New System.Drawing.Point(13, 236)
        Me.MOBO_Label.Name = "MOBO_Label"
        Me.MOBO_Label.Size = New System.Drawing.Size(367, 29)
        Me.MOBO_Label.TabIndex = 5
        Me.MOBO_Label.Text = "Motherboard Name"
        Me.MOBO_Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'VRAM_Label
        '
        Me.VRAM_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VRAM_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VRAM_Label.Location = New System.Drawing.Point(12, 278)
        Me.VRAM_Label.Name = "VRAM_Label"
        Me.VRAM_Label.Size = New System.Drawing.Size(367, 29)
        Me.VRAM_Label.TabIndex = 4
        Me.VRAM_Label.Text = "Video Memory"
        Me.VRAM_Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Rez_Label
        '
        Me.Rez_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Rez_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rez_Label.Location = New System.Drawing.Point(13, 359)
        Me.Rez_Label.Name = "Rez_Label"
        Me.Rez_Label.Size = New System.Drawing.Size(367, 29)
        Me.Rez_Label.TabIndex = 3
        Me.Rez_Label.Text = "Current Resolution (Primary Monitor)"
        Me.Rez_Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMOBO
        '
        Me.lblMOBO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMOBO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMOBO.Location = New System.Drawing.Point(386, 236)
        Me.lblMOBO.Name = "lblMOBO"
        Me.lblMOBO.Size = New System.Drawing.Size(664, 29)
        Me.lblMOBO.TabIndex = 11
        Me.lblMOBO.Text = "<Output>"
        '
        'lblVRam
        '
        Me.lblVRam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVRam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVRam.Location = New System.Drawing.Point(385, 278)
        Me.lblVRam.Name = "lblVRam"
        Me.lblVRam.Size = New System.Drawing.Size(664, 29)
        Me.lblVRam.TabIndex = 10
        Me.lblVRam.Text = "<Output>"
        '
        'lblRez
        '
        Me.lblRez.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRez.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRez.Location = New System.Drawing.Point(386, 359)
        Me.lblRez.Name = "lblRez"
        Me.lblRez.Size = New System.Drawing.Size(664, 29)
        Me.lblRez.TabIndex = 9
        Me.lblRez.Text = "<Output>"
        '
        'lblProcessor
        '
        Me.lblProcessor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessor.Location = New System.Drawing.Point(386, 152)
        Me.lblProcessor.Name = "lblProcessor"
        Me.lblProcessor.Size = New System.Drawing.Size(664, 29)
        Me.lblProcessor.TabIndex = 8
        Me.lblProcessor.Text = "<Output>"
        '
        'lblRam
        '
        Me.lblRam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRam.Location = New System.Drawing.Point(386, 109)
        Me.lblRam.Name = "lblRam"
        Me.lblRam.Size = New System.Drawing.Size(664, 29)
        Me.lblRam.TabIndex = 7
        Me.lblRam.Text = "<Output>"
        '
        'lblOS
        '
        Me.lblOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOS.Location = New System.Drawing.Point(386, 22)
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Size = New System.Drawing.Size(664, 30)
        Me.lblOS.TabIndex = 6
        Me.lblOS.Text = "<Output>"
        '
        'btnScan
        '
        Me.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScan.Location = New System.Drawing.Point(168, 442)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(221, 54)
        Me.btnScan.TabIndex = 12
        Me.btnScan.Text = "Scan System"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'lblVAdapter
        '
        Me.lblVAdapter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVAdapter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAdapter.Location = New System.Drawing.Point(385, 320)
        Me.lblVAdapter.Name = "lblVAdapter"
        Me.lblVAdapter.Size = New System.Drawing.Size(664, 29)
        Me.lblVAdapter.TabIndex = 14
        Me.lblVAdapter.Text = "<Output>"
        '
        'VName_Label
        '
        Me.VName_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.VName_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VName_Label.Location = New System.Drawing.Point(12, 320)
        Me.VName_Label.Name = "VName_Label"
        Me.VName_Label.Size = New System.Drawing.Size(367, 29)
        Me.VName_Label.TabIndex = 13
        Me.VName_Label.Text = "Video Adapter Name"
        Me.VName_Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSerialNo
        '
        Me.lblSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNo.Location = New System.Drawing.Point(385, 66)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.Size = New System.Drawing.Size(664, 29)
        Me.lblSerialNo.TabIndex = 16
        Me.lblSerialNo.Text = "<Output>"
        '
        'Serial_Label
        '
        Me.Serial_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Serial_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Serial_Label.Location = New System.Drawing.Point(12, 66)
        Me.Serial_Label.Name = "Serial_Label"
        Me.Serial_Label.Size = New System.Drawing.Size(367, 29)
        Me.Serial_Label.TabIndex = 15
        Me.Serial_Label.Text = "Serial Number"
        Me.Serial_Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(435, 442)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(221, 54)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save Results"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(435, 517)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(221, 43)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pBarStatus
        '
        Me.pBarStatus.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pBarStatus.ForeColor = System.Drawing.Color.Lime
        Me.pBarStatus.Location = New System.Drawing.Point(706, 516)
        Me.pBarStatus.Name = "pBarStatus"
        Me.pBarStatus.Size = New System.Drawing.Size(293, 44)
        Me.pBarStatus.TabIndex = 19
        '
        'bgwScan
        '
        Me.bgwScan.WorkerReportsProgress = True
        Me.bgwScan.WorkerSupportsCancellation = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(165, 517)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(221, 43)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel Scan"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblPercent
        '
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(899, 490)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(100, 23)
        Me.lblPercent.TabIndex = 22
        Me.lblPercent.TabStop = True
        Me.lblPercent.Text = "<>"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMOBOBrand
        '
        Me.lblMOBOBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMOBOBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMOBOBrand.Location = New System.Drawing.Point(385, 194)
        Me.lblMOBOBrand.Name = "lblMOBOBrand"
        Me.lblMOBOBrand.Size = New System.Drawing.Size(664, 29)
        Me.lblMOBOBrand.TabIndex = 24
        Me.lblMOBOBrand.Text = "<Output>"
        '
        'MOBO_Brand_Label
        '
        Me.MOBO_Brand_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MOBO_Brand_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOBO_Brand_Label.Location = New System.Drawing.Point(12, 194)
        Me.MOBO_Brand_Label.Name = "MOBO_Brand_Label"
        Me.MOBO_Brand_Label.Size = New System.Drawing.Size(367, 29)
        Me.MOBO_Brand_Label.TabIndex = 23
        Me.MOBO_Brand_Label.Text = "Motherboard Brand"
        Me.MOBO_Brand_Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnAbout
        '
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(958, 404)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(103, 43)
        Me.btnAbout.TabIndex = 25
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 570)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.lblMOBOBrand)
        Me.Controls.Add(Me.MOBO_Brand_Label)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pBarStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblSerialNo)
        Me.Controls.Add(Me.Serial_Label)
        Me.Controls.Add(Me.lblVAdapter)
        Me.Controls.Add(Me.VName_Label)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.lblMOBO)
        Me.Controls.Add(Me.lblVRam)
        Me.Controls.Add(Me.lblRez)
        Me.Controls.Add(Me.lblProcessor)
        Me.Controls.Add(Me.lblRam)
        Me.Controls.Add(Me.lblOS)
        Me.Controls.Add(Me.MOBO_Label)
        Me.Controls.Add(Me.VRAM_Label)
        Me.Controls.Add(Me.Rez_Label)
        Me.Controls.Add(Me.Processor_Label)
        Me.Controls.Add(Me.RAM_Label)
        Me.Controls.Add(Me.OS_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "System Scanner"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OS_Label As System.Windows.Forms.Label
    Friend WithEvents RAM_Label As System.Windows.Forms.Label
    Friend WithEvents Processor_Label As System.Windows.Forms.Label
    Friend WithEvents MOBO_Label As System.Windows.Forms.Label
    Friend WithEvents VRAM_Label As System.Windows.Forms.Label
    Friend WithEvents Rez_Label As System.Windows.Forms.Label
    Friend WithEvents lblMOBO As System.Windows.Forms.Label
    Friend WithEvents lblVRam As System.Windows.Forms.Label
    Friend WithEvents lblRez As System.Windows.Forms.Label
    Friend WithEvents lblProcessor As System.Windows.Forms.Label
    Friend WithEvents lblRam As System.Windows.Forms.Label
    Friend WithEvents lblOS As System.Windows.Forms.Label
    Friend WithEvents btnScan As System.Windows.Forms.Button
    Friend WithEvents lblVAdapter As System.Windows.Forms.Label
    Friend WithEvents VName_Label As System.Windows.Forms.Label
    Friend WithEvents lblSerialNo As System.Windows.Forms.Label
    Friend WithEvents Serial_Label As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents sfdbSystem As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pBarStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents bgwScan As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblPercent As LinkLabel
    Friend WithEvents lblMOBOBrand As Label
    Friend WithEvents MOBO_Brand_Label As Label
    Friend WithEvents btnAbout As Button
End Class
