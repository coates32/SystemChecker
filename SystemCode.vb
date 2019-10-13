Option Strict Off
Imports SharpDX
Imports System.Management

'' Must have SharpDX
'Reference: System.Management
Module SystemCode

    Public Function FindOS() As String

        'Stores Operating System's Name
        Dim strOS As String

        'Finds exact OS Name and type
        strOS = My.Computer.Info.OSFullName

        'Determines if current OS is 64-bit or 32-bit
        If System.Environment.Is64BitOperatingSystem = True Then
            strOS = strOS + " (64-bit)"
        Else
            strOS = strOS + " (32-bit)"
        End If
        Return strOS
    End Function
    Public Function FindMoBo() As String

        Dim cs = New ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem")
        Dim strModel As String = ""

        For Each objMgmt In cs.Get


            strModel = objMgmt("model").ToString()
        Next

        Return strModel
    End Function
    Public Function FindMoBoBrand() As String

        Dim cs = New ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem")
        Dim strModel As String = ""
        ''Dim objMB As Object
        Try
            For Each objMgmt In cs.Get

                strModel = objMgmt("manufacturer").ToString()
            Next
        Catch ex As Exception
            Dim i As String

            i = ex.Message
        End Try

        Return strModel
    End Function
    Public Function FindRAM() As String

        'Stores Ram Info
        Dim strRam, strMemType As String
        Dim dblRam, dblRamKB, dblRamMB, dblRamGB, dblRamTB, dblRamPB, dblRamEB, dblRamZB, dblRamYB As Double
        Dim dblRamFinal As Double


        strMemType = ""
        dblRamFinal = 0

        'Finds System Ram 
        dblRam = My.Computer.Info.TotalPhysicalMemory

        'Kilobyte = 1000 Bytes
        If dblRam > 1000 Then
            dblRamKB = dblRam / 1024

            dblRamFinal = dblRamKB
            strMemType = "KB"
        End If

        'Megabyte = 1000 Kilobytes
        If dblRamKB > 1000 Then
            dblRamMB = dblRamKB / 1024

            dblRamFinal = dblRamMB
            strMemType = "MB"
        End If

        'Gigabyte = 1000 Megabytes
        If dblRamMB > 1000 Then
            dblRamGB = dblRamMB / 1024

            dblRamFinal = dblRamGB
            strMemType = "GB"
        End If

        'Terabyte = 1000 Gigabytes
        If dblRamGB > 1000 Then
            dblRamTB = dblRamGB / 1024

            dblRamFinal = dblRamTB
            strMemType = "TB"
        End If

        'Petabyte = 1000 Terabytes
        If dblRamTB > 1000 Then
            dblRamPB = dblRamPB / 1024

            dblRamFinal = dblRamPB
            strMemType = "PB"
        End If

        'Exabyte = 1000 Petabytes
        If dblRamPB > 1000 Then
            dblRamEB = dblRamPB / 1024

            dblRamFinal = dblRamEB
            strMemType = "EB"
        End If

        'Zettabyte = 1000 Exabytes
        If dblRamEB > 1000 Then
            dblRamZB = dblRamEB / 1024

            dblRamFinal = dblRamZB
            strMemType = "ZB"
        End If

        'Yottabyte = 1000 Zettabytes
        If dblRamZB > 1000 Then
            dblRamYB = dblRamZB / 1024

            dblRamFinal = dblRamYB
            strMemType = "YB"
        End If

        dblRamFinal = System.Math.Round(dblRamFinal, 10)

        strRam = dblRamFinal.ToString("0.00") + " " + strMemType

        Return strRam
    End Function

    Public Function ConvertRam(ByVal dblRam As Double) As String
        'Stores Ram Info
        Dim strRam, strMemType As String
        Dim dblRamKB, dblRamMB, dblRamGB, dblRamTB, dblRamPB, dblRamEB, dblRamZB, dblRamYB As Double
        Dim dblRamFinal As Double


        strMemType = ""
        dblRamFinal = 0

        'Finds System Ram 
        dblRam = My.Computer.Info.TotalPhysicalMemory

        'Kilobyte = 1000 Bytes
        If dblRam > 1000 Then
            dblRamKB = dblRam / 1024

            dblRamFinal = dblRamKB
            strMemType = "KB"
        End If

        'Megabyte = 1000 Kilobytes
        If dblRamKB > 1000 Then
            dblRamMB = dblRamKB / 1024

            dblRamFinal = dblRamMB
            strMemType = "MB"
        End If

        'Gigabyte = 1000 Megabytes
        If dblRamMB > 1000 Then
            dblRamGB = dblRamMB / 1024

            dblRamFinal = dblRamGB
            strMemType = "GB"
        End If

        'Terabyte = 1000 Gigabytes
        If dblRamGB > 1000 Then
            dblRamTB = dblRamGB / 1024

            dblRamFinal = dblRamTB
            strMemType = "TB"
        End If

        'Petabyte = 1000 Terabytes
        If dblRamTB > 1000 Then
            dblRamPB = dblRamPB / 1024

            dblRamFinal = dblRamPB
            strMemType = "PB"
        End If

        'Exabyte = 1000 Petabytes
        If dblRamPB > 1000 Then
            dblRamEB = dblRamPB / 1024

            dblRamFinal = dblRamEB
            strMemType = "EB"
        End If

        'Zettabyte = 1000 Exabytes
        If dblRamEB > 1000 Then
            dblRamZB = dblRamEB / 1024

            dblRamFinal = dblRamZB
            strMemType = "ZB"
        End If

        'Yottabyte = 1000 Zettabytes
        If dblRamZB > 1000 Then
            dblRamYB = dblRamZB / 1024

            dblRamFinal = dblRamYB
            strMemType = "YB"
        End If

        dblRamFinal = System.Math.Round(dblRamFinal, 10)

        strRam = dblRamFinal.ToString("0.00") + " " + strMemType
        Return strRam
    End Function

    Public Function FindProcessor() As String

        'Stores Processor Info
        Dim strHz, strHertzType As String
        Dim dblHz, dblKHz, dblMHz, dblGHz, dblTHz, dblPHz, dblEHz, dblZHz, dblYHz As Double
        Dim dblHzFinal As Double

        Dim moCollection As Management.ManagementObjectCollection
        Dim moSearch As Management.ManagementObjectSearcher

        Dim mo As Management.ManagementObject
        Dim cpuName As String = ""
        moSearch = New Management.ManagementObjectSearcher("Select * from Win32_Processor")

        moCollection = moSearch.Get

        For Each mo In moCollection
            'dblHz = System.Convert.ToDouble(mo.Properties("CurrentClockSpeed").Value)
            dblHz = System.Convert.ToDouble(mo.Properties("MaxClockSpeed").Value)

            cpuName = mo.Properties("Name").Value.ToString().TrimEnd()
        Next

        strHertzType = ""
        dblHzFinal = 0

        ''Finds Processor Speed

        'Kilohert = 1000 hertz
        If dblHz > 10 Then
            dblKHz = dblHz / 10

            dblHzFinal = dblKHz
            strHertzType = "KHz"
        End If

        'Megahert = 1000 Kilohertz
        If dblKHz > 10 Then
            dblMHz = dblKHz / 10

            dblHzFinal = dblMHz
            strHertzType = "MHz"
        End If

        'Gigahert = 1000 Megahertz
        If dblMHz > 10 Then
            dblGHz = dblMHz / 10

            dblHzFinal = dblGHz
            strHertzType = "GHz"
        End If

        'Terahert = 1000 Gigahertz
        If dblGHz > 10 Then
            dblTHz = dblGHz / 10

            dblHzFinal = dblTHz
            strHertzType = "THz"
        End If

        'Petahert = 1000 Terahertz
        If dblTHz > 10 Then
            dblPHz = dblPHz / 10

            dblHzFinal = dblPHz
            strHertzType = "PHz"
        End If

        'Exahert = 1000 Petahertz
        If dblPHz > 10 Then
            dblEHz = dblPHz / 10

            dblHzFinal = dblEHz
            strHertzType = "EHz"
        End If

        'Zettahert = 1000 Exahertz
        If dblEHz > 10 Then
            dblZHz = dblEHz / 10

            dblHzFinal = dblZHz
            strHertzType = "ZHz"
        End If

        'Yottahert = 1000 Zettahertz
        If dblZHz > 10 Then
            dblYHz = dblZHz / 10

            dblHzFinal = dblYHz
            strHertzType = "YHz"
        End If

        dblHzFinal = System.Math.Round(dblHzFinal, 10)

        strHz = dblHzFinal.ToString("0.00") + " " + strHertzType

        mo = Nothing
        moSearch = Nothing
        moCollection = Nothing

        Return cpuName + " @ " + strHz
    End Function

    Public Function FindPCSerialNo() As String

        'Stores serial number
        Dim strSerialNo As String

        strSerialNo = ""

        Dim moCollection As Management.ManagementObjectCollection
        Dim moSearch As Management.ManagementObjectSearcher

        Dim mo As Management.ManagementObject

        moSearch = New Management.ManagementObjectSearcher("Select * from Win32_bios")

        moCollection = moSearch.Get

        For Each mo In moCollection

            strSerialNo = mo.Properties("serialnumber").Value.ToString
        Next

        If strSerialNo = "" Or strSerialNo = " " Or strSerialNo = Nothing Then
            strSerialNo = "N/A"
        End If

        mo = Nothing
        moSearch = Nothing
        moCollection = Nothing

        Return strSerialNo
    End Function

    Public Function FindCores() As String

        'Stores No. of Cores
        Dim strCores As String

        'Finds exact OS Name and type
        strCores = Environment.ProcessorCount.ToString

        Return strCores
    End Function

    Public Function FindVidRAM() As String

        'Video Memory
        Dim strVRam, strMemType As String
        Dim dblVRam, dblVRamKB, dblVRamMB, dblVRamGB, dblVRamTB, dblVRamPB, dblVRamEB, dblVRamZB, dblVRamYB As Double
        Dim dblVRamFinal As Double


        strMemType = ""
        dblVRamFinal = 0

        Dim strOutput As String
        strOutput = ""
        Dim searcher = New ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration")

        Dim graphicsCard = String.Empty

        For Each mo2 As ManagementObject In searcher.Get()

            For Each property1 As PropertyData In mo2.Properties

                If property1.Name = "Description" Then

                    graphicsCard = property1.Value.ToString()
                End If
            Next
        Next

        Dim query As New SelectQuery("Win32_VideoController")

        ''Graphic Card Memory

        '' Need to use SharpDX due "Win32_VideoController" only able to read up to 4GB of video memory
        Dim factory As New DXGI.Factory1


        Dim adp As New DXGI.Adapter(factory.GetAdapter(0))
        strOutput = adp.Description.DedicatedVideoMemory.ToString()
        factory.Dispose()

        dblVRam = Convert.ToDouble(strOutput)

        'Kilobyte = 1000 Bytes
        If dblVRam > 1000 Then
            dblVRamKB = dblVRam / 1024

            dblVRamFinal = dblVRamKB
            strMemType = "KB"
        End If

        'Megabyte = 1000 Kilobytes
        If dblVRamKB > 1000 Then
            dblVRamMB = dblVRamKB / 1024

            dblVRamFinal = dblVRamMB
            strMemType = "MB"
        End If

        'Gigabyte = 1000 Megabytes
        If dblVRamMB > 1000 Then
            dblVRamGB = dblVRamMB / 1024

            dblVRamFinal = dblVRamGB
            strMemType = "GB"
        End If

        'Terabyte = 1000 Gigabytes
        If dblVRamGB > 1000 Then
            dblVRamTB = dblVRamGB / 1024

            dblVRamFinal = dblVRamTB
            strMemType = "TB"
        End If

        'Petabyte = 1000 Terabytes
        If dblVRamTB > 1000 Then
            dblVRamPB = dblVRamPB / 1024

            dblVRamFinal = dblVRamPB
            strMemType = "PB"
        End If

        'Exabyte = 1000 Petabytes
        If dblVRamPB > 1000 Then
            dblVRamEB = dblVRamPB / 1024

            dblVRamFinal = dblVRamEB
            strMemType = "EB"
        End If

        'Zettabyte = 1000 Exabytes
        If dblVRamEB > 1000 Then
            dblVRamZB = dblVRamEB / 1024

            dblVRamFinal = dblVRamZB
            strMemType = "ZB"
        End If

        'Yottabyte = 1000 Zettabytes
        If dblVRamZB > 1000 Then
            dblVRamYB = dblVRamZB / 1024

            dblVRamFinal = dblVRamYB
            strMemType = "YB"
        End If

        dblVRamFinal = System.Math.Round(dblVRamFinal, 10)

        strVRam = dblVRamFinal.ToString("0.00") + " " + strMemType

        Return strVRam
    End Function

    Public Function FindResolution() As String
        Dim strY As String
        Dim strX, strFRate As String

        strX = Screen.PrimaryScreen.Bounds.Width.ToString()

        strY = Screen.PrimaryScreen.Bounds.Height.ToString()
        strFRate = ""

        Dim query As New SelectQuery("Win32_VideoController")

        'Gets Monitor's refresh rate
        For Each mo As ManagementObject In New ManagementObjectSearcher(query).Get
            Dim FrameRate As Object = mo("CurrentRefreshRate")
            If IsNothing(FrameRate) = False Then
                strFRate = FrameRate.ToString + "Hz"
            End If


        Next


        Return strX + " x " + strY + " " + strFRate
    End Function



    Public Function FindVideoAdapter() As String
        Dim strOutput As String
        strOutput = ""
        Dim query As New SelectQuery("Win32_VideoController")



        ''Graphic Card name
        For Each mo As ManagementObject In New ManagementObjectSearcher(query).Get

            Dim AdapterName As Object = mo("Description")


            If AdapterName IsNot Nothing Then

                strOutput = AdapterName.ToString
            End If
        Next


        Return strOutput
    End Function

End Module

