Imports System.IO

Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLicenseInfo()
    End Sub

    Private Sub LoadLicenseInfo()
        ''Sharp_DX_license
        Dim licenseData = New StringReader(My.Resources.Sharp_DX_license)
        Dim BeginningText As String = "This program uses Sharp DX." + Environment.NewLine + Environment.NewLine
        rtbLicense.Text = BeginningText + licenseData.ReadToEnd

    End Sub

    Private Sub SaveResults()
        Dim strDefault As String
        Dim strFile As String
        Dim intAnswer As Integer

        strFile = ""

        strDefault = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Dim sfdbSystem As New System.Windows.Forms.SaveFileDialog With {
            .InitialDirectory = strDefault,
            .Filter = "Text File (*.txt)|*.txt",
            .FilterIndex = 1,
            .FileName = "License Information"
        }
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

    Private Sub FileWriter(ByVal strFile As String)

        Dim iFileName As New System.IO.StreamWriter(strFile, False)
        Dim iWriteData As String

        iWriteData = rtbLicense.Text

        'Write string to file
        iFileName.WriteLine(iWriteData)

        iFileName.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveResults()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class