'*Author: Lonnie Coates, Jr.
'*Date: 1/28/2015
'*Program Name: System Checker
'*Details: Checks system specifications (OS, RAM, Video Memory, Processor Speed and # of Cores, and Max Resolution for main monitor)

'' go here for transparent label: https://www.codeproject.com/articles/31406/add-the-percent-or-any-text-into-a-standard-progre
Option Strict Off

Imports System.IO
Imports System.Reflection


Public Class Main
    Dim strOS As String = ""
    Dim strSNO As String = ""
    Dim strRam As String = ""
    Dim strCPU As String = ""
    Dim strMoBo As String = ""
    Dim strMoBoBrand As String = ""
    Dim strVRAM As String = ""
    Dim strVName As String = ""
    Dim strRez As String = ""


    Private Function LoadDLLFromStream(
            ByVal sender As Object,
            ByVal args As System.ResolveEventArgs) As System.Reflection.Assembly

        Dim resourceName As String = "System_Checker." & New AssemblyName(args.Name).Name & ".dll"
        Dim assemblyName As String = Assembly.GetExecutingAssembly().GetName().Name
        'had to use this line to debug and figure out why it didnt load at first
        Dim resources() As String = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames

        Using stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)

            Dim assemblyData(CInt(stream.Length - 1)) As Byte

            stream.Read(assemblyData, 0, assemblyData.Length)

            Return System.Reflection.Assembly.Load(assemblyData)

        End Using
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pBarStatus.Visible = True

        pBarStatus.Maximum = 8
        pBarStatus.Value = 0
        pBarStatus.Step = 1

        bgwScan.WorkerReportsProgress = True
        bgwScan.WorkerSupportsCancellation = True

        btnCancel.Enabled = False

        lblPercent.BackColor = Color.Transparent ' Color.Transparent

        lblPercent.BackColor = Color.Transparent ' Color.Transparent
        lblPercent.ForeColor = Color.Black

        lblPercent.Visible = True
        lblPercent.Text = ""
        lblPercent.Refresh()

        MakeTransparentLabel(lblPercent, Color.Black)
    End Sub

    Private Sub btnScan_Click(sender As System.Object, e As System.EventArgs) Handles btnScan.Click
        pBarStatus.Value = 0
        Try
            pBarStatus.Visible = True
            btnSave.Enabled = True
            btnCancel.Enabled = True
            bgwScan.RunWorkerAsync()



        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
            bgwScan.CancelAsync()
            btnCancel.Enabled = False
        End Try

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            SaveResults()
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub DisplayResults()

        lblOS.Text = strOS

        lblSerialNo.Text = strSNO

        lblRam.Text = strRam

        lblProcessor.Text = strCPU
        lblMOBOBrand.Text = strMoBoBrand
        lblMOBO.Text = strMoBo

        lblVRam.Text = strVRAM

        lblVAdapter.Text = strVName

        lblRez.Text = strRez

    End Sub

    Private Sub SaveResults()
        Dim strDefault As String
        Dim strFile As String
        Dim intAnswer As Integer

        strFile = ""

        strDefault = Environment.CurrentDirectory


        sfdbSystem.InitialDirectory = strDefault

        sfdbSystem.Filter = "Text File (*.txt)|*.txt"
        sfdbSystem.FilterIndex = 1
        sfdbSystem.FileName = "SystemInfo"
        'If the user clicks "OK"
        If sfdbSystem.ShowDialog() = DialogResult.OK Then
            Try
                'store file name
                strFile = sfdbSystem.FileName

                'create file
                FileWriter(strFile)

                intAnswer = MsgBox("Save Successful. Do you wish to open the file: " & strFile & " ?", MsgBoxStyle.YesNo, "Save Successful")

                If intAnswer = vbYes Then
                    Process.Start(strFile)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error!")
            End Try
        End If

    End Sub


    Private Function CpuRecord() As String
        Dim streamReader As String
        streamReader = ""

        streamReader = OS_Label.Text & ": " + lblOS.Text + vbNewLine
        streamReader = streamReader & Serial_Label.Text & ": " & lblSerialNo.Text & vbNewLine
        streamReader = streamReader & Processor_Label.Text & ": " & lblProcessor.Text & vbNewLine
        streamReader = streamReader & MOBO_Brand_Label.Text & ": " & lblMOBOBrand.Text & vbNewLine
        streamReader = streamReader & MOBO_Label.Text & ": " & lblMOBO.Text & vbNewLine

        streamReader = streamReader & RAM_Label.Text & ": " & lblRam.Text & vbNewLine
        streamReader = streamReader & VRAM_Label.Text & ": " & lblVRam.Text & vbNewLine
        streamReader = streamReader & VName_Label.Text & ": " & lblVAdapter.Text & vbNewLine
        streamReader = streamReader & Rez_Label.Text & ": " & lblRez.Text & vbNewLine

        Return streamReader
    End Function

    Private Sub FileWriter(ByVal strFile As String)

        Dim iFileName As New System.IO.StreamWriter(strFile, False)
        Dim iWriteData As String
        'Dim Buffer As String

        'calling System Specs function "CpuRecord"
        iWriteData = CpuRecord()

        'Write string to file
        iFileName.WriteLine(iWriteData)

        iFileName.Close()
    End Sub

    Private Sub bgwScan_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwScan.DoWork
        'lblOS.Text 
        strOS = FindOS()
        ''ProgressBar1.Value = ProgressBar1.Value + 1
        bgwScan.ReportProgress(1)

        'lblSerialNo.Text 
        strSNO = FindPCSerialNo()
        ''ProgressBar1.Value = ProgressBar1.Value + 1
        bgwScan.ReportProgress(2)

        ''lblRam.Text
        strRam = FindRAM()
        ''ProgressBar1.Value = ProgressBar1.Value + 1
        bgwScan.ReportProgress(3)

        'lblProcessor.Text
        strCPU = FindProcessor() + " " + FindCores() + " Core(s)"
        ''ProgressBar1.Value = ProgressBar1.Value + 1
        bgwScan.ReportProgress(4)

        'lblCores.Text
        strMoBo = FindMoBo() ''FindMoBo()
        strMoBoBrand = FindMoBoBrand() ''FindMoBoBrand()
        ''ProgressBar1.Value = ProgressBar1.Value + 1
        bgwScan.ReportProgress(5)

        'lblVRam.Text
        strVRAM = FindVidRAM()
        ''ProgressBar1.Value = ProgressBar1.Value + 1
        bgwScan.ReportProgress(6)

        'lblVAdapter.Text
        strVName = FindVideoAdapter()
        ''ProgressBar1.Value = ProgressBar1.Value + 1
        bgwScan.ReportProgress(7)

        'lblRez.Text
        strRez = FindResolution()
        ''ProgressBar1.Value = ProgressBar1.Value + 1
        bgwScan.ReportProgress(8)
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        bgwScan.CancelAsync()
        btnCancel.Enabled = False
    End Sub

    Private Sub bgwScan_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwScan.ProgressChanged
        pBarStatus.PerformStep()
        lblPercent.Text = (100 * (pBarStatus.Value / pBarStatus.Maximum)).ToString("00.00") & "%"


        lblPercent.Refresh()
        ''UpdateLabel(pBarStatus, "")
    End Sub

    Private Sub bgwScan_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwScan.RunWorkerCompleted
        DisplayResults()
        btnCancel.Enabled = False
    End Sub

    Private Sub MakeTransparentLabel(ByVal LinkLabel As System.Windows.Forms.LinkLabel, ByVal ForeColor As Color)

        LinkLabel.ForeColor = ForeColor
        LinkLabel.LinkColor = ForeColor
        LinkLabel.VisitedLinkColor = ForeColor
        LinkLabel.ActiveLinkColor = ForeColor
        LinkLabel.DisabledLinkColor = ForeColor
        LinkLabel.LinkArea = New LinkArea(0, 0)
        LinkLabel.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel.Cursor = Cursors.Arrow
        LinkLabel.BackColor = Color.Transparent

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim myAbout As New frmAbout

        myAbout.ShowDialog()
    End Sub
End Class
