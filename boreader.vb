Option Strict Off
Option Explicit On

Imports VB = Microsoft.VisualBasic
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Xml


Friend Class boreader
    Inherits System.Windows.Forms.Form
    'Private Declare Sub PCopyMemory Lib "kernel32"  Alias "RtlMoveMemory"(ByRef Destination As Any, ByVal Source As Integer, ByVal Length As Integer)
    Private Declare Sub PCopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef Destination As Integer, ByVal Source As Integer, ByVal Length As Integer)
    Private Declare Sub PCopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef Destination As Byte, ByVal Source As Integer, ByVal Length As Integer)
    Private Declare Sub PCopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef Destination As PERSONINFO, ByVal Source As Integer, ByVal Length As Integer)
    Private Declare Sub PCopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef Destination As CLOCKINGRECORD, ByVal Source As Integer, ByVal Length As Integer)
    Private Declare Sub PCopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef Destination As NETINFO, ByVal Source As UInteger, ByVal Length As Integer)
    Private Declare Sub PCopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef Destination As RINGTIME, ByVal Source As Integer, ByVal Length As Integer)
    Private Declare Sub PCopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef Destination As TIMESECT, ByVal Source As Integer, ByVal Length As Integer)
    Private Declare Sub PCopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByVal Source As Integer, ByRef Destination As TIMESECT, ByVal Length As Integer)
    Private Declare Sub PPCopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByVal Destination As Integer, ByVal Source As Integer, ByVal Length As Integer)
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
    Private Structure SYSTEMTIME
        Dim wYear As Short
        Dim wMonth As Short
        Dim wDayOfWeek As Short
        Dim wDay As Short
        Dim wHour As Short
        Dim wMinute As Short
        Dim wSecond As Short
        Dim wMilliseconds As Short
    End Structure
    Dim IDNumber As Int32


    Private Declare Sub GetLocalTime Lib "kernel32" (ByRef lpSystemTime As SYSTEMTIME)

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim myXmlDocument As XmlDocument = New XmlDocument()
        Dim node As XmlNode
        Dim node2 As XmlNode 'Used for internal loop.
        Dim reloj1 As Decimal
        Dim reloj2 As Decimal
        Dim clocking As CLOCKINGRECORD

        reloj1 = -1  ' -1 default, 0 No usado, > 0 Seleccionar

        Try
            myXmlDocument.Load("boreader.xml")
            node = myXmlDocument.DocumentElement
            For Each node In node.ChildNodes
                'Find the price child node.
                For Each node2 In node.ChildNodes
                    If node2.Name = "reloj1" Then
                        'nodePriceText = node2.InnerText
                        reloj1 = System.Decimal.Parse(node2.InnerText)
                    End If
                    If node2.Name = "reloj2" Then
                        'nodePriceText = node2.InnerText
                        reloj2 = System.Decimal.Parse(node2.InnerText)
                    End If
                Next
            Next
        Catch
            reloj1 = 1  ' -1 default, 0 No usado, > 0 Seleccionar
        End Try

        ' Seleccionar reloj 1
        If reloj1 = 0 Then  ' No usado
            Me.cmbId.Text = "(Sin uso)"
        End If
        If reloj1 > 0 Then  ' No usado
            Me.cmbId.Text = reloj1

            Select Case cmbId.Text
                Case 55555555
                    txtIp.Text = "10.0.0.249"
                Case 55555554
                    txtIp.Text = "10.0.0.240"
                Case 1
                    txtIp.Text = "10.0.1.218"
                Case 76130011
                    txtIp.Text = "10.0.0.31"
                Case 76120114
                    txtIp.Text = "10.0.0.32"
            End Select
        End If

        ' Seleccionar reloj 2
        If reloj2 = 0 Then  ' No usado
            Me.cmbId2.Text = "(Sin uso)"
        End If
        If reloj2 > 0 Then  ' No usado
            Me.cmbId2.Text = reloj2

            Select Case cmbId2.Text
                Case 55555555
                    txtIp2.Text = "10.0.0.249"
                Case 55555554
                    txtIp2.Text = "10.0.0.240"
                Case 1
                    txtIp2.Text = "10.0.1.218"
                Case 76130011
                    txtIp2.Text = "10.0.0.31"
                Case 76120114
                    txtIp2.Text = "10.0.0.32"
            End Select
        End If

        'First minimize the form
        Me.WindowState = FormWindowState.Minimized
        'Now make it invisible (make it look like it went into the system tray)

        ' Tiempo de re-lectura
        ' Unidad expresada en minutos por eso 1 min = 60 seg = 60.000 miliseg
        Me.Timer1.Interval = Me.txtIntervalo.Text * 60000   ' Si la unidad esta expresada en segundos es : 1000
        Me.Timer3.Interval = Me.txtIntervalo.Text * 60000

        If My.Application.CommandLineArgs.Count > 0 Then

            'MessageBox.Show("Se paso argumentos")
            'MessageBox.Show(My.Application.CommandLineArgs(0))

            If My.Application.CommandLineArgs(0) = "1" Or My.Application.CommandLineArgs(0) = "/1" Or My.Application.CommandLineArgs(0) = "-1" Then
                Me.cmbId.Text = 55555555
                txtIp.Text = "10.0.0.249"
            Else
                Me.cmbId.Text = 55555554
                txtIp.Text = "10.0.0.240"
            End If
        End If

        '-------------------------------------------------
        CLOCKINGRECORDSIZE = Marshal.SizeOf(clocking)
        cmbComPort.SelectedIndex = 0

        ' Coloco el Puerto por Defecto en COM7
        Me.cmbComPort.SelectedIndex = 6

        ' Corro el Boton de Lectura de Registros
        Me.Refresh()

        'Me.Visible = True

        Me.BtnGenerarTXT2.PerformClick()              'Me.BtnLeerReg.PerformClick()
        Me.BtnGenerarTXT.PerformClick()              'Me.BtnLeerReg.PerformClick()
    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CKT_Disconnect()
        Sleep((500))
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim i As Integer
        Dim SnoPtr As UInt32
        Dim pSno As Integer
        Dim count As Integer
        Dim Sno As Integer

        count = CKT_ReportConnections(SnoPtr)

        If count > 0 Then
            pSno = SnoPtr
            For i = 1 To count
                PCopyMemory(Sno, pSno, 4)
                MsgBox(Str(Sno))
                pSno = pSno + 4
            Next

            CKT_FreeMemory(SnoPtr)
        End If
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim msg As String
        Dim devnetinfo As NETINFO = New NETINFO()

        If CKT_GetDeviceNetInfo(IDNumber, devnetinfo) Then
            msg = "IP: " & devnetinfo.IP(0) & "." & devnetinfo.IP(1) & "." & devnetinfo.IP(2) & "." & devnetinfo.IP(3) & Chr(10)
            msg = msg & "Mask: " & devnetinfo.Mask(0) & "." & devnetinfo.Mask(1) & "." & devnetinfo.Mask(2) & "." & devnetinfo.Mask(3) & Chr(10)
            msg = msg & "Gate: " & devnetinfo.Gateway(0) & "." & devnetinfo.Gateway(1) & "." & devnetinfo.Gateway(2) & "." & devnetinfo.Gateway(3) & Chr(10)
            msg = msg & "Server: " & devnetinfo.ServerIP(0) & "." & devnetinfo.ServerIP(1) & "." & devnetinfo.ServerIP(2) & "." & devnetinfo.ServerIP(3) & Chr(10)
            msg = msg & "MAC: " & devnetinfo.MAC(0) & "." & devnetinfo.MAC(1) & "." & devnetinfo.MAC(2) & "." & devnetinfo.MAC(3) & "." & devnetinfo.MAC(4) & "." & devnetinfo.MAC(5) & Chr(10)
            MsgBox(msg)
        End If
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim msg As String
        Dim IP(3) As Byte

        IP(0) = 192
        IP(1) = 168
        IP(2) = 10
        IP(3) = 94

        'If CKT_SetDeviceIPAddr(IDNumber, IP(0)) Then
        If CKT_SetDeviceIPAddr(IDNumber, IP) Then
            msg = "New IP: 192.168.10.94"
        Else
            msg = "Fail to set IP to (192.168.10.94)"
        End If

        MsgBox(msg)
    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim msg As String
        Dim Mask(3) As Byte

        Mask(0) = 255
        Mask(1) = 255
        Mask(2) = 255
        Mask(3) = 0

        If CKT_SetDeviceMask(IDNumber, Mask(0)) Then
            msg = "New Mask: 255.255.255.0"
        Else
            msg = "Fail to set Mask to (255.255.255.0)"
        End If

        MsgBox(msg)
    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim msg As String
        Dim Gate(3) As Byte

        Gate(0) = 192
        Gate(1) = 168
        Gate(2) = 0
        Gate(3) = 1

        If CKT_SetDeviceGateway(IDNumber, Gate(0)) Then
            msg = "New Gate: 192.168.0.1"
        Else
            msg = "Fail to set Gate to (192.168.0.1)"
        End If

        MsgBox(msg)
    End Sub

    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim msg As String
        Dim SvrIP(3) As Byte

        SvrIP(0) = 192
        SvrIP(1) = 168
        SvrIP(2) = 0
        SvrIP(3) = 7

        If CKT_SetDeviceServerIPAddr(IDNumber, SvrIP(0)) Then
            msg = "New SvrIP: 192.168.0.7"
        Else
            msg = "Fail to set SvrIP to (192.168.0.7)"
        End If

        MsgBox(msg)
    End Sub

    Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim msg As String
        Dim MAC(5) As Byte

        MAC(0) = 160
        MAC(1) = 168
        MAC(2) = 10
        MAC(3) = 2
        MAC(4) = 10
        MAC(5) = 2

        If CKT_SetDeviceMAC(IDNumber, MAC(0)) Then
            msg = "New MAC: 160-168-10-2-10-2"
        Else
            msg = "Fail to set MAC to (160-168-10-2-10-2)"
        End If

        MsgBox(msg)
    End Sub

    Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
        Dim msg As String
        Dim devclock As DATETIMEINFO

        If CKT_GetDeviceClock(IDNumber, devclock) Then
            msg = "Clock: " & devclock.Year_Renamed & "-" & devclock.Month_Renamed & "-" & devclock.Day_Renamed & Chr(10) & "       " & devclock.Hour_Renamed & ":" & devclock.Minute_Renamed & ":" & devclock.Second_Renamed
            MsgBox(msg)
        End If
    End Sub

    Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim tim As SYSTEMTIME
        GetLocalTime(tim)

        If CKT_SetDeviceDate(IDNumber, tim.wYear, tim.wMonth, tim.wDay) Then
            MsgBox("Sucess to send date")
        End If

        Sleep((300))

        GetLocalTime(tim)

        If CKT_SetDeviceTime(IDNumber, tim.wHour, tim.wMinute, tim.wSecond) Then
            MsgBox("Sucess to send time")
        End If
    End Sub

    Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command10.Click
        Dim msg As String = ""
        Dim By As Object
        Dim i As Integer
        Dim pFPData As Integer
        Dim FPDataLen As Integer
        Dim vbFPData() As Byte

        If CKT_GetFPTemplate(IDNumber, 1, 0, pFPData, FPDataLen) = 1 Then
            ReDim vbFPData(FPDataLen - 1)
            Call PCopyMemory(vbFPData(0), pFPData, FPDataLen)
            CKT_FreeMemory(pFPData)

            i = 0
            For Each By In vbFPData
                If i = 10 Then
                    msg = msg & Chr(10)
                    i = 0
                End If
                msg = msg & Hex(By) & " "
                i = i + 1
            Next By 'i

            MsgBox(msg)

            If CKT_PutFPTemplate(IDNumber, 1, 1, vbFPData, FPDataLen) = 1 Then
                MsgBox("First template to second OK!")
            Else
                MsgBox("First template to second ERROR!")
            End If
        End If
    End Sub

    Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnWriteFile.Click
        If CKT_GetFPTemplateSaveFile(IDNumber, 1, 0, "C:\1.anv") = 1 Then
            MsgBox("Template Data Save C:\1.anv OK!")
        End If
    End Sub

    Private Sub Command12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnReaderFile.Click
        If CKT_PutFPTemplateLoadFile(IDNumber, 200, 1, "C:\1.anv") = 1 Then
            MsgBox("Template Data From C:\1.anv£¬Download OK!")
        End If
    End Sub

    Private Sub Command14_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim mpiRet As Integer
        Dim person As PERSONINFO

        With person
            .CardNo = 123456

            .Name = Encoding.Default.GetBytes("Ajax")
            ReDim Preserve .Name(11)
            .Password = Encoding.Default.GetBytes("")
            ReDim Preserve .Password(7)
            .PersonID = 200
        End With

        mpiRet = CKT_ModifyPersonInfo(IDNumber, person)
        If mpiRet = CKT_RESULT_ADDOK Then
            MsgBox("Edit OK!")
        ElseIf mpiRet = CKT_ERROR_MEMORYFULL Then
            MsgBox("MEMORY FUL")
        Else
            MsgBox("Edit ERROR!")
        End If
    End Sub

    Private Sub Command15_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim dpiRet As Integer
        dpiRet = CKT_DeletePersonInfo(IDNumber, 1, &H4)
        If dpiRet = CKT_RESULT_OK Then
            MsgBox("Delete OK!")
        ElseIf dpiRet = CKT_ERROR_NOTHISPERSON Then
            MsgBox("No this user!")
        Else
            MsgBox("Delete ERROR!")
        End If
    End Sub

    Private Sub Command16_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If CKT_SetFixWGHead(IDNumber, 1) Then
            MsgBox(" CKT_SetFixWGHead OK!")
        End If
    End Sub

    Private Sub Command17_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If CKT_DelMessageByIndex(IDNumber, 0) Then
            MsgBox("Del Message OK!")
        End If
    End Sub

    Private Sub Command18_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command18.Click
        Dim i As Integer
        Dim array(49) As CKT_MessageHead
        i = CKT_GetAllMessageHead(IDNumber, array)
    End Sub

    Private Sub Command19_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command19.Click
        Dim i As Integer
        Dim Ret As Integer
        Dim RecordCount As Integer
        Dim RetCount As Integer
        Dim pPersons As UInteger
        Dim pLongRun As Integer
        Dim person As PERSONINFO

        Dim ptemp As Integer
        If CKT_ListPersonInfoEx(IDNumber, pLongRun) Then
            ProgressBar2.Value = 0
            ListView2.Items.Clear()
            Do While True
                Ret = CKT_ListPersonProgress(pLongRun, RecordCount, RetCount, pPersons)
                If Ret = 0 Then
                    Exit Sub
                End If
                If RecordCount > 0 Then ProgressBar2.Maximum = RecordCount

                If (Ret <> 0) Then
                    ptemp = pPersons
                    For i = 0 To RetCount - 1
                        Call PCopyMemory(person, pPersons, Marshal.SizeOf(person))
                        pPersons = pPersons + Marshal.SizeOf(person)

                        Dim item1 As New ListViewItem(ListView2.Items.Count)
                        item1.Checked = True
                        item1.SubItems.Add(person.PersonID)
                        item1.SubItems.Add(Encoding.Default.GetString(person.Name))
                        item1.SubItems.Add(Encoding.Default.GetString(person.Password))
                        item1.SubItems.Add(person.CardNo)
                        ListView2.Items.Insert(ListView2.Items.Count, item1)
                        ProgressBar2.Value += 1

                    Next

                    If ptemp <> 0 Then
                        Call CKT_FreeMemory(ptemp)
                    End If
                End If

                If Ret = 1 Then
                    Exit Sub
                End If
            Loop
        End If

    End Sub

    Private Sub Command20_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnTotales.Click
        Dim msg As String
        Dim personCount, FPCount As Integer
        Dim clockingCount As Integer
        If CKT_GetCounts(IDNumber, personCount, FPCount, clockingCount) Then
            msg = "Legajos: " & personCount & Chr(10) & "Huellas digitales: " & FPCount & Chr(10) & "Registros: " & clockingCount

            MsgBox(msg)
        End If
    End Sub



    Private Sub Command22_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If CKT_ClearClockingRecord(IDNumber, 0, 0) Then
            MsgBox("CKT_ClearClockingRecord OK!")
        Else
            MsgBox("Í¨Ñ¶Ê§°Ü")
        End If

    End Sub

    Private Sub Command24_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnLeerReg.Click
        Dim i As Integer
        Dim Ret As Integer
        Dim RecordCount As Integer
        Dim RetCount As Integer
        Dim pClockings As Integer
        Dim pLongRun As Integer
        Dim clocking As CLOCKINGRECORD
        ReDim clocking.Time(19)

        Dim ptemp As Integer
        ProgressBar1.Value = 0
        ListView1.Items.Clear()
        'If CKT_GetClockingNewRecordEx(IDNumber, pLongRun) Then 'IF GET NewRecord
        MessageBox.Show(CKT_GetClockingNewRecordEx(IDNumber, pLongRun))
        MessageBox.Show(CKT_GetClockingRecordEx(IDNumber, pLongRun))

        If CKT_GetClockingRecordEx(IDNumber, pLongRun) Then 'IF GET Record
            Do While True
                'ListView1.Refresh()
                Ret = CKT_GetClockingRecordProgress(pLongRun, RecordCount, RetCount, pClockings)
                If RecordCount > 0 Then ProgressBar1.Maximum = RecordCount
                If Ret = 0 Then
                    Exit Do ' Sub
                End If

                If (Ret <> 0) Then
                    ptemp = pClockings

                    For i = 1 To RetCount
                        Call PCopyMemory(clocking, pClockings, CLOCKINGRECORDSIZE)
                        pClockings = pClockings + CLOCKINGRECORDSIZE
                        'Dim item1 As New ListViewItem("item1", 0)
                        'Dim item1 As New ListViewItem(ListView1.Items.Count)
                        Dim item1 As ListViewItem = New ListViewItem(ListView1.Items.Count)
                        item1.Checked = True
                        item1.SubItems.Add(clocking.PersonID)
                        item1.SubItems.Add(Encoding.Default.GetString(clocking.Time))
                        item1.SubItems.Add(clocking.Stat)
                        item1.SubItems.Add(clocking.ID)
                        ListView1.Items.Insert(ListView1.Items.Count, item1)
                        ProgressBar1.Value += 1

                    Next

                    If ptemp <> 0 Then
                        Call CKT_FreeMemory(ptemp)
                    End If
                End If

                If Ret = 1 Then
                    Exit Do ' Sub
                End If
            Loop
            ListView1.Refresh()
        End If
    End Sub

    Private Sub Command26_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If CKT_SetDoor(IDNumber, 2) Then
            MsgBox("CKT_SetDoor OK!")
        End If
    End Sub

    Private Sub Command27_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If CKT_SetSpeakerVolume(IDNumber, 5) Then
            MsgBox("CKT_SetSpeakerVolume OK!")
        End If
    End Sub

    Private Sub Command28_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If CKT_SetDeviceAdminPassword(IDNumber, "9999") Then
            MsgBox("CKT_SetDeviceAdminPassword OK!")
        End If
    End Sub

    Private Sub Command29_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If CKT_SetRealtimeMode(IDNumber, 1) Then
            MsgBox("CKT_SetRealtimeMode OK!")
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
        Dim i As Integer
        Dim count As Integer
        Dim pClockings As UInt32
        Dim ptemp As Integer
        Dim clocking As CLOCKINGRECORD

        count = CKT_ReadRealtimeClocking(pClockings)

        ptemp = pClockings
        For i = 1 To count
            Call PCopyMemory(clocking, ptemp, CLOCKINGRECORDSIZE)
            ptemp = ptemp + CLOCKINGRECORDSIZE

            Dim item1 As New ListViewItem(ListView1.Items.Count)
            item1.Checked = True
            item1.SubItems.Add(clocking.PersonID)
            item1.SubItems.Add(Encoding.Default.GetString(clocking.Time))
            item1.SubItems.Add(clocking.Stat)
            item1.SubItems.Add(clocking.ID)
            ListView1.Items.Insert(0, item1)

        Next

        If pClockings <> 0 Then
            CKT_FreeMemory(pClockings)
        End If
    End Sub

    Private Sub Command30_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If CKT_ResetDevice(IDNumber) Then
            MsgBox("CKT_ResetDevice OK!")
        End If
    End Sub

    Private Sub Command31_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command31.Click
        Dim msg As String
        Dim devnfo As DEVICEINFO

        If CKT_GetDeviceInfo(IDNumber, devnfo) Then
            msg = devnfo.ID & Chr(10)
            msg = msg & devnfo.MajorVersion & "." & devnfo.MinorVersion & Chr(10)
            MsgBox(msg)
        End If
    End Sub

    Private Sub Command32_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If CKT_SetWG(IDNumber, 1) Then
            MsgBox("CKT_SetWG OK!")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim grp(3) As Integer
        Dim i As Integer
        grp(0) = 13
        grp(1) = 16
        grp(2) = 10
        grp(3) = 2
        i = CKT_SetGroup(IDNumber, 2, grp)
        If i = 1 Then
            MsgBox("CKT_SetGroup OK!")
        End If

        Dim array(3) As Integer
        i = CKT_GetGroup(IDNumber, 2, array)
        If i = 1 Then
            MsgBox("CKT_GetGroup OK!")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rt As RINGTIME
        Dim i As Integer
        Dim msg As String
        rt.hour = 16
        rt.minute = 16
        rt.week = 7
        i = CKT_SetHitRingInfo(IDNumber, 2, rt)

        Dim array(29) As RINGTIME
        i = CKT_GetHitRingInfo(IDNumber, array)
        For i = 0 To 29

            msg = " HitRingInfo ID: " & i + 1 & " at: " & array(i).hour & " " & array(i).minute.ToString

            MsgBox(msg)
        Next
    End Sub

    Private Sub Command23_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command23.Click
        Dim msg As CKT_MessageInfo = New CKT_MessageInfo
        ReDim msg.msg(47)
        If (CKT_GetMessageByIndex(IDNumber, 0, msg)) = 1 Then
            Dim a As String
            a = String.Format("PersonID {0} from {1}:{2}:{3} to {4}:{5}:{6} Message Content:{7}\n", _
            msg.PersonID, msg.sYear, msg.sMon, msg.sDay, _
            msg.eYear, msg.eMon, msg.eDay, Encoding.Default.GetString(msg.msg))
            MsgBox(a)
            msg.msg = Encoding.Default.GetBytes("ANVIZ")
            ReDim Preserve msg.msg(47)
            If (CKT_AddMessage(IDNumber, msg)) = 1 Then

                MsgBox("CKT_AddMessage OK!")


            End If
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        IDNumber = cmbId.Text 'CInt()
        If RadioCom.Checked Then
            Call CKT_RegisterSno(IDNumber, cmbComPort.SelectedIndex + 1) 'if from com
        End If
        If RadioNet.Checked Then
            Call CKT_RegisterNet(IDNumber, txtIp.Text) 'if from net
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Call CKT_UnregisterSnoNet(IDNumber)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click, BtnHora.Click
        Dim grp(6) As TIMESECT
        Dim i As Integer

        grp(0).bHour = 9
        grp(0).bMinute = 30
        grp(0).eHour = 17
        grp(0).eMinute = 0
        grp(1).bHour = 9
        grp(1).bMinute = 40
        grp(1).eHour = 17
        grp(1).eMinute = 10
        i = CKT_SetTimeSection(IDNumber, 2, grp)

        Dim array(6) As TIMESECT
        i = CKT_GetTimeSection(IDNumber, 2, array)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CKT_SetRingAllow(IDNumber, 1) Then
            MsgBox("CKT_SetRingAllow OK!")
        End If
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CKT_SetRepeatKQ(IDNumber, 2) Then
            MsgBox("CKT_SetRepeatKQ OK!")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CKT_SetAutoUpdate(IDNumber, 1) Then
            MsgBox("CKT_SetAutoUpdate OK!")
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CKT_ForceOpenLock(IDNumber) Then
            MsgBox("CKT_ForceOpenLock OK!")
        End If

    End Sub


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If CKT_ComDaemon = 0 Then
            FileClose()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNetDaemon.Click
        If CKT_NetDaemon = 0 Then
            FileClose()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComPort.SelectedIndexChanged

    End Sub

    Private Sub BtnGenerarTXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerarTXT.Click
        Dim intentos As Integer = 0
        Dim Exito As Boolean
        Dim i As Integer
        Dim Ret As Integer
        Dim RecordCount As Integer
        Dim RetCount As Integer
        Dim pClockings As Integer
        Dim pLongRun As Integer
        Dim clocking As CLOCKINGRECORD
        ReDim clocking.Time(19)
        Dim FILE_NAME As String
        Dim FILE_NAME2 As String
        Dim existeFile As String
        Dim NewName As String
        Dim nRegistro As Integer
        Dim nReintentos As Integer

        ' Controlo si el reloj está en uso
        If Me.cmbId.Text = "(Sin uso)" Then
            lblUltima.Text = Me.cmbId.Text
            Notify_icon.Text = ""
            Exit Sub
        End If

        lblUltima.Text = "Abriendo conexión (1)..."
        Notify_icon.Text = "Zonda relojes - Abriendo conexión (1)..."

        ' lblUltima.Refresh()
        Me.Refresh()

        ' Corro el Boton de inicio de conexión
        Me.btnStart.PerformClick()

        lblUltima.Text = "Conexión abierta (1) - " & IDNumber
        Notify_icon.Text = "Zonda relojes - Conexión abierta (1)... " & IDNumber

        Me.Refresh()

        'Me.WindowState = FormWindowState.Minimized
        '-------------------------------------------------

        Exito = True
        FILE_NAME = ""
        FILE_NAME2 = ""

        ' Variables de creación del archivo .TXT
        Select Case cmbId.Text
            Case 76120114   ' Agrotecnica Relleno
                'txtIp.Text = "10.0.0.32"
                FILE_NAME = "C:\Zonda\zexporta_76120114"
                FILE_NAME2 = "C:\Zonda\zexporta_76120114_Ok"
            Case 76130011   ' Agrotecnica Base
                ' txtIp.Text = "10.0.0.31"
                FILE_NAME = "C:\Zonda\zexporta_76130011"
                FILE_NAME2 = "C:\Zonda\zexporta_76130011_Ok"
            Case 55555555   ' HP3C Viejo
                ' txtIp.Text = "10.0.0.249"
                FILE_NAME = "C:\Zonda\zexporta_55555555"
                FILE_NAME2 = "C:\Zonda\zexporta_55555555_Ok"
            Case 55555554   ' HP3C Nuevo
                ' txtIp.Text = "10.0.0.240"
                FILE_NAME = "C:\Zonda\zexporta_55555554"
                FILE_NAME2 = "C:\Zonda\zexporta_55555554_Ok"
            Case 1  ' UCC
                ' txtIp.Text = "10.0.1.218"
                FILE_NAME = "C:\Zonda\zexporta_1"
                FILE_NAME2 = "C:\Zonda\zexporta_1_Ok"
        End Select

        existeFile = FILE_NAME

        FILE_NAME = FILE_NAME & ".txt"
        FILE_NAME2 = FILE_NAME2 & ".txt"

        lblUltima.Text = "Leyendo reloj (1)"
        'lblTiempo.Text = "Ultimo intento: " & TimeOfDay.Now.ToLongTimeString
        lblUltima.Refresh()
        Notify_icon.Text = "Leyendo reloj (1)"

        'Me.Visible = False
        'Me.WindowState = FormWindowState.Minimized

        Try
            Dim ptemp As Integer

            ProgressBar1.Value = 0
            ListView1.Items.Clear()
            'If CKT_GetClockingNewRecordEx(IDNumber, pLongRun) Then 'IF GET NewRecord

            lblUltima.Text = "Leyendo reloj (1).."
            Notify_icon.Text = "Leyendo reloj (1).."

            lblUltima.Refresh()

            'MessageBox.Show(CKT_GetClockingRecordEx(IDNumber, pLongRun))

            Do While CKT_GetClockingRecordEx(IDNumber, pLongRun) = 0
                'MessageBox.Show(CKT_GetClockingRecordEx(IDNumber, pLongRun))
                intentos = intentos + 1

                If intentos > 1 Then
                    If CKT_GetClockingRecordEx(IDNumber, pLongRun) = 0 Then
                        Exito = False
                    End If
                    Exit Do
                End If

                lblUltima.Text = "Reintentando (1)..."
                Notify_icon.Text = "Reintentando (1)..."
                lblUltima.Refresh()
            Loop

            If Exito = True Then 'IF GET Record
                ' Si el archivo existe lo renombro primero
                lblUltima.Text = "Renombrando archivo anterior..."
                Notify_icon.Text = "Renombrando archivo anterior..."

                If System.IO.File.Exists(FILE_NAME) Then
                    NewName = existeFile & "_" & Date.Now.Year.ToString & "_" & Date.Now.Month.ToString & "_" & Date.Now.Day.ToString &
                        " (" & Date.Now.TimeOfDay.Hours.ToString & "-" & Date.Now.TimeOfDay.Minutes.ToString & "-" &
                        Date.Now.TimeOfDay.Seconds.ToString() & ")" & ".txt"

                    ' MessageBox.Show(FILE_NAME & "->" & NewName)

                    Rename(FILE_NAME, NewName)
                End If

                lblUltima.Text = "Leyendo (1)..."
                Notify_icon.Text = "Leyendo (1)..."

                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                ' lblUltima.Text = "Obteniendo datos..."

                Me.Refresh()

                nRegistro = 1
                nReintentos = 0

                Do While True
                    Ret = CKT_GetClockingRecordProgress(pLongRun, RecordCount, RetCount, pClockings)    ' Estaba debajo del Do while...

                    'ListView1.Refresh()
                    If RecordCount > 0 Then ProgressBar1.Maximum = RecordCount

                    If Ret = 0 Then
                        nReintentos = nReintentos + 1

                        lblArchivo1.Text = "Reintentos por problemas de conexión : " & nReintentos
                        lblArchivo1.Refresh()

                        If nReintentos > 1000 Then
                            MessageBox.Show("Salio por Problemas de conectividad (ret = 0)")
                            MessageBox.Show("pClockings:" & pClockings & "    RetCount:" & RetCount & "     RecordCount:" & RecordCount)

                            Exit Do ' Sub  ==> Salida por problemas de conectividad ???
                        End If
                    End If

                    If (Ret <> 0) Then
                        ptemp = pClockings

                        'MessageBox.Show("pClockings:" & pClockings & "    RetCount:" & RetCount & "     RecordCount:" & RecordCount)

                        For i = 1 To RetCount   ' RetCount


                            lblUltima.Text = "Leyendo " & nRegistro & " registros de " & RecordCount
                            Notify_icon.Text = "Leyendo " & nRegistro & " registros de " & RecordCount

                            lblUltima.Refresh()

                            Try
                                Call PCopyMemory(clocking, pClockings, CLOCKINGRECORDSIZE)
                            Catch
                                CLOCKINGRECORDSIZE = 0
                            End Try

                            pClockings = pClockings + CLOCKINGRECORDSIZE

                            lblErrorIntervalo.Text = CLOCKINGRECORDSIZE
                            lblErrorIntervalo.Visible = True
                            lblErrorIntervalo.Refresh()

                            'Dim item1 As New ListViewItem("item1", 0)
                            'Dim item1 As New ListViewItem(ListView1.Items.Count)

                            '-------------------------------------------------
                            'Dim item1 As ListViewItem = New ListViewItem(ListView1.Items.Count)
                            'item1.Checked = True
                            'item1.SubItems.Add(clocking.PersonID)
                            'item1.SubItems.Add(Encoding.Default.GetString(clocking.Time))
                            'item1.SubItems.Add(clocking.Stat)
                            'item1.SubItems.Add(clocking.ID)
                            'ListView1.Items.Insert(ListView1.Items.Count, item1)
                            '--------------------------------------------------
                            ProgressBar1.Value += 1

                            ' Rutina de creacion y escritura del archivo .TXT
                            If System.IO.File.Exists(FILE_NAME) = True Then
                                objWriter.WriteLine(Encoding.Default.GetString(clocking.Time) & "      " & clocking.Stat & "    " & _
                                                    clocking.ID & "    " & clocking.PersonID & "       " & nRegistro)
                                'objWriter.Write(clocking.PersonID)
                                'objWriter.WriteLine(Encoding.Default.GetString(clocking.Time))
                            Else
                                lblUltima.Text = "El archivo no existe!!"
                                Notify_icon.Text = "El archivo no existe!!"

                                'MessageBox.Show(" El archivo no existe ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                                Exit For
                            End If

                            nRegistro = nRegistro + 1
                        Next

                        'MessageBox.Show("Salgo de for...next ")

                        If ptemp <> 0 Then
                            Call CKT_FreeMemory(ptemp)
                        End If
                    End If

                    If Ret = 1 Then
                        'MessageBox.Show("Salio por ret = 1")
                        Exit Do ' Sub  => Salida estandar despues de leer fichadas
                    End If
                Loop

                ' Cierro el objeto del archivo
                objWriter.Close()

                Me.lblTiempo.Text = "Ultimo intento: " & TimeOfDay.Now.ToLongTimeString

                ' Controlo si el archivo se genero con exitos
                If System.IO.File.Exists(FILE_NAME) = True Then
                    ' MsgBox("Text written to file")
                    If nRegistro > 0 Then
                        lblUltima.Text = "Leidos " & nRegistro - 1 & " de " & RecordCount & " registros."

                        Notify_icon.BalloonTipIcon = ToolTipIcon.Info
                        Notify_icon.BalloonTipTitle = "Relojes"
                        Notify_icon.BalloonTipText = "Reloj: " & cmbId.Text & " - Se leyeron " & nRegistro - 1 & " de " & RecordCount & " registros."

                        If nRegistro - 1 >= RecordCount Then
                            lblArchivo1.Text = "Archivo " & FILE_NAME & " generado exitosamente"
                        Else
                            lblArchivo1.Text = "Archivo " & FILE_NAME & " generado parcialmente"

                        End If

                        Notify_icon.ShowBalloonTip(1)
                    Else
                        lblUltima.Text = "No se encontraron registros"

                        Notify_icon.BalloonTipIcon = ToolTipIcon.Error
                        Notify_icon.BalloonTipTitle = "Error en relojes"
                        Notify_icon.BalloonTipText = "No se encontraron registros"
                        Notify_icon.ShowBalloonTip(1)
                    End If

                    Dim objWriter2 As New System.IO.StreamWriter(FILE_NAME2)

                    objWriter2.Write("Ok")

                    ' Cierro el objeto del archivo
                    objWriter2.Close()
                Else
                    ' MsgBox("No se pudo crear el archivo " & FILE_NAME, MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Exclamation, "Error")
                    Notify_icon.BalloonTipIcon = ToolTipIcon.Error
                    Notify_icon.BalloonTipTitle = "Error en relojes"
                    Notify_icon.BalloonTipText = "No se pudo crear el archivo " & FILE_NAME
                    Notify_icon.ShowBalloonTip(1)

                End If

                ListView1.Refresh()
            Else
                ' Cierro el objeto del archivo
                'objWriter.Close()

                lblUltima.Text = "Reloj 1 inaccesible : " & IDNumber & " - " & CStr(CKT_GetClockingRecordEx(IDNumber, pLongRun))
                Notify_icon.Text = "Zonda relojes - Reloj (1) inaccesible"

                lblTiempo.Text = "Ultimo intento: " & TimeOfDay.Now.ToLongTimeString

                Notify_icon.BalloonTipIcon = ToolTipIcon.Error
                Notify_icon.BalloonTipTitle = "Error en relojes"
                Notify_icon.BalloonTipText = "Reloj (1) inaccesible : " & IDNumber & " - " & CStr(CKT_GetClockingRecordEx(IDNumber, pLongRun))
                Notify_icon.ShowBalloonTip(1)


            End If

        Catch ex As Exception

            lblUltima.Text = "Archivo inaccesible!! " + ex.Message

            Notify_icon.BalloonTipIcon = ToolTipIcon.Error
            Notify_icon.BalloonTipTitle = "Error en relojes"
            Notify_icon.BalloonTipText = "Archivo inaccesible!! " + ex.Message
            Notify_icon.ShowBalloonTip(1)
            'MessageBox.Show("El archivo de lectura de registros está siendo leido o procesado en este momento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '------------> Exit Sub
        End Try

        ' Cierro la conexión
        Call CKT_UnregisterSnoNet(IDNumber)

        ' Corro el Boton de Lectura de Registros
        Me.Refresh()

        'Me.Visible = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'lblTiempo.Text = "Ultimo intento: " & TimeOfDay.Now.ToLongTimeString
        Me.BtnGenerarTXT.PerformClick()
    End Sub

    Private Sub lblUltima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUltima.Click

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub RadioCom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioCom.CheckedChanged
        lblComPort.Enabled = True
        cmbComPort.Enabled = True

        lblIp.Enabled = False
        txtIp.Enabled = False
    End Sub

    Private Sub RadioNet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioNet.CheckedChanged
        lblComPort.Enabled = False
        cmbComPort.Enabled = False

        lblIp.Enabled = True
        txtIp.Enabled = True
    End Sub

    Private Sub cmbId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbId.SelectedIndexChanged
        Select cmbId.Text
            Case 55555555
                txtIp.Text = "10.0.0.249"
            Case 55555554
                txtIp.Text = "10.0.0.240"
            Case 1
                txtIp.Text = "10.0.1.218"
            Case 76130011
                txtIp.Text = "10.0.0.31"
            Case 76120114
                txtIp.Text = "10.0.0.32"
        End Select
    End Sub

    Private Sub txtIntervalo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIntervalo.TextChanged
        Try
            ' Unidad expresada en minutos por eso 1 min = 60 seg = 60.000 miliseg
            Me.Timer1.Interval = Me.txtIntervalo.Text * 60000   ' Si la unidad esta expresada en segundos es : 1000
            Me.Timer3.Interval = Me.txtIntervalo.Text * 60000
        Catch ex As Exception
            lblErrorIntervalo.Visible = True
        End Try
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub boreader_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        If Me.WindowState = FormWindowState.Minimized Then
            'Me.Visible = False
            Notify_icon.Visible = True
        End If

    End Sub

    Private Sub Notify_icon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Notify_icon.MouseDoubleClick

        Me.Visible = True
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BtnGenerarTXT_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerarTXT2.Click
        Dim intentos As Integer = 0
        Dim Exito As Boolean
        Dim i As Integer
        Dim Ret As Integer
        Dim RecordCount As Integer
        Dim RetCount As Integer
        Dim pClockings As Integer
        Dim pLongRun As Integer
        Dim clocking As CLOCKINGRECORD
        ReDim clocking.Time(19)
        Dim FILE_NAME As String
        Dim FILE_NAME2 As String
        Dim existeFile As String
        Dim NewName As String
        Dim nRegistro As Integer

        ' Controlo si el reloj está en uso
        If Me.cmbId2.Text = "(Sin uso)" Then
            lblUltima2.Text = Me.cmbId2.Text
            Notify_icon.Text = ""
            Exit Sub
        End If

        lblUltima2.Text = "Abriendo conexión (2)..."
        Notify_icon.Text = "Zonda relojes - Abriendo conexión (2)..."
        ' lblUltima.Refresh()

        Me.Refresh()

        ' Abro la conexion : Antes usaba -> Corro el Boton de inicio de conexión
        IDNumber = cmbId2.Text 'CInt()
        If RadioCom2.Checked Then
            Call CKT_RegisterSno(IDNumber, cmbComPort2.SelectedIndex + 1) 'if from com
        End If
        If RadioNet2.Checked Then
            Call CKT_RegisterNet(IDNumber, txtIp2.Text) 'if from net
        End If

        'Me.btnStart.PerformClick()
        lblUltima2.Text = "Conexión abierta... " & IDNumber

        Notify_icon.Text = "Zonda relojes - Conexión abierta (2)... " & IDNumber

        Me.Refresh()

        'Me.WindowState = FormWindowState.Minimized
        '-------------------------------------------------

        Exito = True
        FILE_NAME = ""
        FILE_NAME2 = ""

        ' Variables de creación del archivo .TXT
        Select Case cmbId2.Text
            Case 76120114   ' Agrotecnica Relleno
                'txtIp.Text = "10.0.0.32"
                FILE_NAME = "C:\Zonda\zexporta_76120114"
                FILE_NAME2 = "C:\Zonda\zexporta_76120114_Ok"
            Case 76130011   ' Agrotecnica Base
                ' txtIp.Text = "10.0.0.31"
                FILE_NAME = "C:\Zonda\zexporta_76130011"
                FILE_NAME2 = "C:\Zonda\zexporta_76130011_Ok"
            Case 55555555   ' HP3C Viejo
                ' txtIp.Text = "10.0.0.249"
                FILE_NAME = "C:\Zonda\zexporta_55555555"
                FILE_NAME2 = "C:\Zonda\zexporta_55555555_Ok"
            Case 55555554   ' HP3C Nuevo
                ' txtIp.Text = "10.0.0.240"
                FILE_NAME = "C:\Zonda\zexporta_55555554"
                FILE_NAME2 = "C:\Zonda\zexporta_55555554_Ok"
            Case 1  ' UCC
                ' txtIp.Text = "10.0.1.218"
                FILE_NAME = "C:\Zonda\zexporta_1"
                FILE_NAME2 = "C:\Zonda\zexporta_1_Ok"
        End Select

        existeFile = FILE_NAME

        FILE_NAME = FILE_NAME & ".txt"
        FILE_NAME2 = FILE_NAME2 & ".txt"

        lblUltima2.Text = "Leyendo reloj (2)"
        Notify_icon.Text = "Leyendo reloj (2)"

        'lblTiempo.Text = "Ultimo intento: " & TimeOfDay.Now.ToLongTimeString
        lblUltima2.Refresh()

        'Me.Visible = False
        'Me.WindowState = FormWindowState.Minimized

        Try
            Dim ptemp As Integer

            ProgressBar3.Value = 0
            ListView1.Items.Clear()
            'If CKT_GetClockingNewRecordEx(IDNumber, pLongRun) Then 'IF GET NewRecord

            lblUltima2.Text = "Leyendo reloj (2)..."
            lblUltima2.Refresh()

            'Me.Refresh()
            'MessageBox.Show(CKT_GetClockingRecordEx(IDNumber, pLongRun))

            Do While CKT_GetClockingRecordEx(IDNumber, pLongRun) = 0
                'MessageBox.Show(CKT_GetClockingRecordEx(IDNumber, pLongRun))
                intentos = intentos + 1

                If intentos > 1 Then
                    If CKT_GetClockingRecordEx(IDNumber, pLongRun) = 0 Then
                        Exito = False
                    End If
                    Exit Do
                End If

                lblUltima2.Text = "Reintentando lectura reloj 2..."
                Notify_icon.Text = "Reintentando lectura reloj 2..."

                lblUltima2.Refresh()
            Loop

            If Exito = True Then 'IF GET Record
                ' Si el archivo existe lo renombro primero
                lblUltima2.Text = "Renombrando archivo anterior..."
                Notify_icon.Text = "Renombrando archivo anterior..."

                If System.IO.File.Exists(FILE_NAME) Then
                    NewName = existeFile & "_" & Date.Now.Year.ToString & "_" & Date.Now.Month.ToString & "_" & Date.Now.Day.ToString &
                        " (" & Date.Now.TimeOfDay.Hours.ToString & "-" & Date.Now.TimeOfDay.Minutes.ToString & "-" &
                        Date.Now.TimeOfDay.Seconds.ToString() & ")" & ".txt"

                    ' MessageBox.Show(FILE_NAME & "->" & NewName)

                    Rename(FILE_NAME, NewName)
                End If

                lblUltima2.Text = "Leyendo reloj (2)..."
                Notify_icon.Text = "Leyendo reloj (2)..."

                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                ' lblUltima.Text = "Obteniendo datos..."

                Me.Refresh()

                nRegistro = 1

                Do While True
                    'ListView1.Refresh()
                    Ret = CKT_GetClockingRecordProgress(pLongRun, RecordCount, RetCount, pClockings)
                    If RecordCount > 0 Then ProgressBar3.Maximum = RecordCount
                    If Ret = 0 Then
                        Exit Do ' Sub
                    End If

                    If (Ret <> 0) Then
                        ptemp = pClockings

                        For i = 1 To RetCount    ' RetCount
                            lblUltima2.Text = "Leyendo " & nRegistro & " registros de " & RecordCount
                            Notify_icon.Text = "Leyendo " & nRegistro & " registros de " & RecordCount

                            nRegistro = nRegistro + 1
                            lblUltima2.Refresh()

                            Call PCopyMemory(clocking, pClockings, CLOCKINGRECORDSIZE)
                            pClockings = pClockings + CLOCKINGRECORDSIZE
                            'Dim item1 As New ListViewItem("item1", 0)
                            'Dim item1 As New ListViewItem(ListView1.Items.Count)
                            Dim item1 As ListViewItem = New ListViewItem(ListView1.Items.Count)
                            item1.Checked = True
                            item1.SubItems.Add(clocking.PersonID)
                            item1.SubItems.Add(Encoding.Default.GetString(clocking.Time))
                            item1.SubItems.Add(clocking.Stat)
                            item1.SubItems.Add(clocking.ID)
                            ListView1.Items.Insert(ListView1.Items.Count, item1)
                            ProgressBar3.Value += 1

                            ' Rutina de creacion y escritura del archivo .TXT
                            If System.IO.File.Exists(FILE_NAME) = True Then
                                objWriter.WriteLine(Encoding.Default.GetString(clocking.Time) & "      " & clocking.Stat & "    " & _
                                                    clocking.ID & "    " & clocking.PersonID & "       " & ListView1.Items.Count)
                                'objWriter.Write(clocking.PersonID)
                                'objWriter.WriteLine(Encoding.Default.GetString(clocking.Time))
                            Else
                                lblUltima2.Text = "El archivo no existe!!"
                                Exit For
                            End If

                        Next

                        If ptemp <> 0 Then
                            Call CKT_FreeMemory(ptemp)
                        End If
                    End If

                    If Ret = 1 Then
                        Exit Do ' Sub
                    End If
                Loop

                ' Cierro el objeto del archivo
                objWriter.Close()

                Me.lblTiempo2.Text = "Ultimo intento: " & TimeOfDay.Now.ToLongTimeString

                ' Controlo si el archivo se genero con exitos
                If System.IO.File.Exists(FILE_NAME) = True Then
                    ' MsgBox("Text written to file")
                    If nRegistro > 0 Then
                        lblUltima2.Text = "Leidos " & nRegistro - 1 & " de " & RecordCount & " registros."

                        Notify_icon.BalloonTipIcon = ToolTipIcon.Info
                        Notify_icon.BalloonTipTitle = "Relojes"
                        Notify_icon.BalloonTipText = "Reloj (2): " & cmbId2.Text & " - Se leyeron " & nRegistro - 1 & " de " & RecordCount & " registros."

                        If nRegistro - 1 >= RecordCount Then
                            lblArchivo2.Text = "Archivo " & FILE_NAME & " generado exitosamente"
                        Else
                            lblArchivo2.Text = "Archivo " & FILE_NAME & " generado parcialmente"
                        End If

                        Notify_icon.ShowBalloonTip(1)
                    Else
                        lblUltima.Text = "No se encontraron registros"

                        Notify_icon.BalloonTipIcon = ToolTipIcon.Error
                        Notify_icon.BalloonTipTitle = "Error en reloj (2)"
                        Notify_icon.BalloonTipText = "No se encontraron registros"
                        Notify_icon.ShowBalloonTip(1)
                    End If

                    Dim objWriter2 As New System.IO.StreamWriter(FILE_NAME2)

                    objWriter2.Write("Ok")

                    ' Cierro el objeto del archivo
                    objWriter2.Close()
                Else
                    ' MsgBox("No se pudo crear el archivo " & FILE_NAME, MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Exclamation, "Error")
                    Notify_icon.BalloonTipIcon = ToolTipIcon.Error
                    Notify_icon.BalloonTipTitle = "Error en reloj (2)"
                    Notify_icon.BalloonTipText = "No se pudo crear el archivo " & FILE_NAME
                    Notify_icon.ShowBalloonTip(1)

                End If

                ListView1.Refresh()
            Else
                ' Cierro el objeto del archivo
                'objWriter.Close()

                lblUltima2.Text = "Reloj 2 inaccesible : " & IDNumber & " - " & CStr(CKT_GetClockingRecordEx(IDNumber, pLongRun))

                lblTiempo2.Text = "Ultimo intento: " & TimeOfDay.Now.ToLongTimeString

                Notify_icon.BalloonTipIcon = ToolTipIcon.Error
                Notify_icon.BalloonTipTitle = "Error en reloj"
                Notify_icon.BalloonTipText = "Reloj (2) inaccesible : " & IDNumber & " - " & CStr(CKT_GetClockingRecordEx(IDNumber, pLongRun))
                Notify_icon.ShowBalloonTip(1)
            End If

        Catch ex As Exception
            ' Cierro el objeto del archivo
            'objWriter.Close()

            lblUltima.Text = "Archivo inaccesible!! " + ex.Message

            Notify_icon.BalloonTipIcon = ToolTipIcon.Error
            Notify_icon.BalloonTipTitle = "Error en reloj (2)"
            Notify_icon.BalloonTipText = "Archivo inaccesible!! " + ex.Message
            Notify_icon.ShowBalloonTip(1)
            'MessageBox.Show("El archivo de lectura de registros está siendo leido o procesado en este momento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '------------> Exit Sub
        End Try

        ' Cierro la conexión
        Call CKT_UnregisterSnoNet(IDNumber)
    End Sub

    Private Sub cmbId2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbId2.SelectedIndexChanged
        Select Case cmbId2.Text
            Case 55555555
                txtIp2.Text = "10.0.0.249"
            Case 55555554
                txtIp2.Text = "10.0.0.240"
            Case 1
                txtIp2.Text = "10.0.1.218"
            Case 76130011
                txtIp2.Text = "10.0.0.31"
            Case 76120114
                txtIp2.Text = "10.0.0.32"
        End Select
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.BtnGenerarTXT2.PerformClick()
    End Sub
End Class