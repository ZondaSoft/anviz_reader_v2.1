Option Strict Off
Option Explicit On
Imports System.Runtime.InteropServices

Module CKT_DLL
    ' Consts

    Public Const CKT_ERROR_INVPARAM As Short = -1
    Public Const CKT_ERROR_NETDAEMONREADY As Short = -1
    Public Const CKT_ERROR_CHECKSUMERR As Short = -2
    Public Const CKT_ERROR_MEMORYFULL As Short = -1
    Public Const CKT_ERROR_INVFILENAME As Short = -3
    Public Const CKT_ERROR_FILECANNOTOPEN As Short = -4
    Public Const CKT_ERROR_FILECONTENTBAD As Short = -5
    Public Const CKT_ERROR_FILECANNOTCREATED As Short = -2
    Public Const CKT_ERROR_NOTHISPERSON As Short = -1

    Public Const CKT_RESULT_OK As Short = 1
    Public Const CKT_RESULT_ADDOK As Short = 1
    Public Const CKT_RESULT_HASMORECONTENT As Short = 2


    'Public Const PERSONINFOSIZE As Short = 44
    Public CLOCKINGRECORDSIZE As Short

    ' Types

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
    Public Structure NETINFO
        <MarshalAs(UnmanagedType.I4)> _
        Dim ID As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
        Dim IP() As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
        Dim Mask() As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
        Dim Gateway() As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
        Dim ServerIP() As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> _
        Dim MAC() As Byte
    End Structure

    Public Structure DATETIMEINFO
        Dim ID As Integer
        Dim Year_Renamed As Short
        Dim Month_Renamed As Byte
        Dim Day_Renamed As Byte
        Dim Hour_Renamed As Byte
        Dim Minute_Renamed As Byte
        Dim Second_Renamed As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
    Public Structure PERSONINFO
        <MarshalAs(UnmanagedType.I4)> _
        Dim PersonID As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> _
        Public Password() As Byte
        <MarshalAs(UnmanagedType.I4)> _
        Public CardNo As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> _
        Dim Name() As Byte
        <MarshalAs(UnmanagedType.I4)> _
        Dim Dept As Integer '部门
        <MarshalAs(UnmanagedType.I4)> _
        Dim Group As Integer '部门
        <MarshalAs(UnmanagedType.I4)> _
        Dim KQOption As Integer '考勤模式
        <MarshalAs(UnmanagedType.I4)> _
        Dim FPMark As Integer '
        <MarshalAs(UnmanagedType.I4)> _
        Dim Other As Integer '特殊信息 =0 普通人员, =1 管理员
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
    Public Structure CLOCKINGRECORD
        <MarshalAs(UnmanagedType.I4)> _
        Dim ID As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim PersonID As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim Stat As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Public BackupCode As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Public WorkTyte As Integer
        '<VBFixedString(20), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=20)> _
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> _
        Public Time() As Byte
    End Structure

    Public Structure DEVICEINFO
        Dim ID As Integer
        Dim MajorVersion As Integer
        Dim MinorVersion As Integer
        Dim AdminPassword As Integer
        Dim DoorLockDelay As Integer
        Dim SpeakerVolume As Integer
        Dim Parameter As Integer
        Dim DefaultAuth As Integer
        Dim Capacity As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
    Public Structure RINGTIME
        <MarshalAs(UnmanagedType.I4)> _
        Dim hour As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim minute As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim week As Integer
    End Structure

    Public Structure TIMESECT
        Dim bHour As Byte
        Dim bMinute As Byte
        Dim eHour As Byte
        Dim eMinute As Byte
    End Structure


    Public Structure CKT_MessageInfo
        <MarshalAs(UnmanagedType.I4)> _
        Dim PersonID As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim sYear As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim sMon As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim sDay As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim eYear As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim eMon As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim eDay As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=48)> _
        Dim msg() As Byte
    End Structure

    Public Structure CKT_MessageHead
        <MarshalAs(UnmanagedType.I4)> _
        Dim PersonID As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim sYear As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim sMon As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim sDay As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim eYear As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim eMon As Integer
        <MarshalAs(UnmanagedType.I4)> _
        Dim eDay As Integer
    End Structure

    ' Routines

    Public Declare Function CKT_FreeMemory Lib "tc400.dll" (ByVal memory As Integer) As Integer


    Public Declare Function CKT_RegisterSno Lib "tc400.dll" (ByVal Sno As Integer, ByVal ComPort As Integer) As Integer
    'Public Declare Function CKT_RegisterNet Lib "tc400.dll" (ByVal Sno As Integer, <MarshalAs(UnmanagedType.LPStr)> ByVal Addr As String) As Integer
    Public Declare Function CKT_RegisterNet Lib "tc400.dll" (ByVal Sno As Integer, ByVal Addr As String) As Integer
    Public Declare Sub CKT_UnregisterSnoNet Lib "tc400.dll" (ByVal Sno As Integer)
    Public Declare Function CKT_NetDaemon Lib "tc400.dll" () As Integer
    Public Declare Function CKT_ComDaemon Lib "tc400.dll" () As Integer
    Public Declare Sub CKT_Disconnect Lib "tc400.dll" ()
    Public Declare Function CKT_ReportConnections Lib "tc400.dll" (ByRef ppSno As Integer) As Integer


    Public Declare Function CKT_GetDeviceNetInfo Lib "tc400.dll" (ByVal Sno As Integer, ByRef pNetInfo As NETINFO) As Integer
    'Public Declare Function CKT_SetDeviceIPAddr Lib "tc400.dll" (ByVal Sno As Integer, ByRef IP As Byte) As Integer
    Public Declare Function CKT_SetDeviceIPAddr Lib "tc400.dll" (ByVal Sno As Integer, ByVal IP As Byte()) As Integer
    Public Declare Function CKT_SetDeviceMask Lib "tc400.dll" (ByVal Sno As Integer, ByRef Mask As Byte) As Integer
    Public Declare Function CKT_SetDeviceGateway Lib "tc400.dll" (ByVal Sno As Integer, ByRef Gate As Byte) As Integer
    Public Declare Function CKT_SetDeviceServerIPAddr Lib "tc400.dll" (ByVal Sno As Integer, ByRef Svr As Byte) As Integer
    Public Declare Function CKT_SetDeviceMAC Lib "tc400.dll" (ByVal Sno As Integer, ByRef MAC As Byte) As Integer


    Public Declare Function CKT_GetDeviceClock Lib "tc400.dll" (ByVal Sno As Integer, ByRef pDateTimeInfo As DATETIMEINFO) As Integer
    Public Declare Function CKT_SetDeviceDate Lib "tc400.dll" (ByVal Sno As Integer, ByVal Year_Renamed As Short, ByVal Month_Renamed As Byte, ByVal Day_Renamed As Byte) As Integer
    Public Declare Function CKT_SetDeviceTime Lib "tc400.dll" (ByVal Sno As Integer, ByVal Hour_Renamed As Byte, ByVal Minute_Renamed As Byte, ByVal Second_Renamed As Byte) As Integer


    Public Declare Function CKT_GetFPTemplate Lib "tc400.dll" (ByVal Sno As Integer, ByVal PersonID As Integer, ByVal FPID As Integer, ByRef pFPData As Integer, ByRef FPDataLen As Integer) As Integer
    Public Declare Function CKT_PutFPTemplate Lib "tc400.dll" (ByVal Sno As Integer, ByVal PersonID As Integer, ByVal FPID As Integer, ByVal pFPData As Byte(), ByVal FPDataLen As Integer) As Integer
    Public Declare Function CKT_GetFPTemplateSaveFile Lib "tc400.dll" (ByVal Sno As Integer, ByVal PersonID As Integer, ByVal FPID As Integer, ByVal FPDataFilename As String) As Integer
    Public Declare Function CKT_PutFPTemplateLoadFile Lib "tc400.dll" (ByVal Sno As Integer, ByVal PersonID As Integer, ByVal FPID As Integer, ByVal FPDataFilename As String) As Integer


    Public Declare Function CKT_GetFPRawData Lib "tc400.dll" (ByVal Sno As Integer, ByVal PersonID As Integer, ByVal FPID As Integer, ByRef FPRawData As Byte) As Integer
    Public Declare Function CKT_PutFPRawData Lib "tc400.dll" (ByVal Sno As Integer, ByVal PersonID As Integer, ByVal FPID As Integer, ByRef FPRawData As Byte) As Integer
    Public Declare Function CKT_GetFPRawDataSaveFile Lib "tc400.dll" (ByVal Sno As Integer, ByVal PersonID As Integer, ByVal FPID As Integer, ByVal FPDataFilename As String) As Integer
    Public Declare Function CKT_PutFPRawDataLoadFile Lib "tc400.dll" (ByVal Sno As Integer, ByVal PersonID As Integer, ByVal FPID As Integer, ByVal FPDataFilename As String) As Integer


    Public Declare Function CKT_ListPersonInfo Lib "tc400.dll" (ByVal Sno As Integer, ByRef pRecordCount As Integer, ByRef ppPersons As Integer) As Integer
    Public Declare Function CKT_ModifyPersonInfo Lib "tc400.dll" (ByVal Sno As Integer, ByRef person As PERSONINFO) As Integer
    Public Declare Function CKT_DeletePersonInfo Lib "tc400.dll" (ByVal Sno As Integer, ByVal PersonID As Integer, ByVal backupID As Integer) As Integer
    Public Declare Function CKT_EraseAllPerson Lib "tc400.dll" (ByVal Sno As Integer) As Integer


    Public Declare Function CKT_ListPersonInfoEx Lib "tc400.dll" (ByVal Sno As Integer, ByRef ppLongRun As Integer) As Integer
    Public Declare Function CKT_ListPersonProgress Lib "tc400.dll" (ByVal pLongRun As Integer, ByRef pRecCount As Integer, ByRef pRetCount As Integer, ByRef ppPersons As UInteger) As Integer


    Public Declare Function CKT_GetCounts Lib "tc400.dll" (ByVal Sno As Integer, ByRef pPersonCount As Integer, ByRef pFPCount As Integer, ByRef pClockingsCount As Integer) As Integer
    Public Declare Function CKT_ClearClockingRecord Lib "tc400.dll" (ByVal Sno As Integer, ByVal type As Integer, ByVal count As Integer) As Integer
    Public Declare Function CKT_GetClockingRecordEx Lib "tc400.dll" (ByVal Sno As Integer, ByRef ppLongRun As Integer) As Integer
    Public Declare Function CKT_GetClockingNewRecordEx Lib "tc400.dll" (ByVal Sno As Integer, ByRef ppLongRun As Integer) As Integer
    Public Declare Function CKT_GetClockingRecordProgress Lib "tc400.dll" (ByVal pLongRun As Integer, ByRef pRecCount As Integer, ByRef pRetCount As Integer, ByRef ppPersons As Integer) As Integer


    Public Declare Function CKT_ResetDevice Lib "tc400.dll" (ByVal Sno As Integer) As Integer

    Public Declare Function CKT_GetDeviceInfo Lib "tc400.dll" (ByVal Sno As Integer, ByRef devinfo As DEVICEINFO) As Integer
    Public Declare Function CKT_SetDefaultAuth Lib "tc400.dll" (ByVal Sno As Integer, ByVal Auth As Integer) As Integer
    Public Declare Function CKT_SetDoor Lib "tc400.dll" (ByVal Sno As Integer, ByVal Second_Renamed As Integer) As Integer
    Public Declare Function CKT_SetSpeakerVolume Lib "tc400.dll" (ByVal Sno As Integer, ByVal Volume As Integer) As Integer
    Public Declare Function CKT_SetDeviceAdminPassword Lib "tc400.dll" (ByVal Sno As Integer, <MarshalAs(UnmanagedType.LPStr)> ByVal Password As String) As Integer
    Public Declare Function CKT_SetRealtimeMode Lib "tc400.dll" (ByVal Sno As Integer, ByVal RealMode As Integer) As Integer
    Public Declare Function CKT_SetFixWGHead Lib "tc400.dll" (ByVal Sno As Integer, ByVal WGHead As Integer) As Integer
    Public Declare Function CKT_SetWG Lib "tc400.dll" (ByVal Sno As Integer, ByVal WGMode As Integer) As Integer
    Public Declare Function CKT_SetRingAllow Lib "tc400.dll" (ByVal Sno As Integer, ByVal type As Integer) As Integer
    Public Declare Function CKT_SetRepeatKQ Lib "tc400.dll" (ByVal Sno As Integer, ByVal time As Integer) As Integer
    Public Declare Function CKT_SetAutoUpdate Lib "tc400.dll" (ByVal Sno As Integer, ByVal AutoUpdate As Integer) As Integer
    Public Declare Function CKT_ForceOpenLock Lib "tc400.dll" (ByVal Sno As Integer) As Integer


    Public Declare Function CKT_ReadRealtimeClocking Lib "tc400.dll" (ByRef ppClockings As Integer) As Integer

    Public Declare Function CKT_GetTimeSection Lib "tc400.dll" (ByVal Sno As Integer, ByVal ord As Integer, <Out()> ByVal ts As TIMESECT()) As Integer
    Public Declare Function CKT_SetTimeSection Lib "tc400.dll" (ByVal Sno As Integer, ByVal ord As Integer, <[In]()> ByVal ts As TIMESECT()) As Integer
    Public Declare Function CKT_GetGroup Lib "tc400.dll" (ByVal Sno As Integer, ByVal ord As Integer, <Out()> ByVal grp As Integer()) As Integer
    Public Declare Function CKT_SetGroup Lib "tc400.dll" (ByVal Sno As Integer, ByVal ord As Integer, ByVal grp As Integer()) As Integer
    Public Declare Function CKT_GetHitRingInfo Lib "tc400.dll" (ByVal Sno As Integer, <Out()> ByVal array As RINGTIME()) As Integer
    Public Declare Function CKT_SetHitRingInfo Lib "tc400.dll" (ByVal Sno As Integer, ByVal ord As Integer, ByRef ring As RINGTIME) As Integer

    Public Declare Function CKT_GetMessageByIndex Lib "tc400.dll" (ByVal Sno As Integer, ByVal idx As Integer, ByRef msg As CKT_MessageInfo) As Integer
    Public Declare Function CKT_AddMessage Lib "tc400.dll" (ByVal Sno As Integer, ByRef msg As CKT_MessageInfo) As Integer
    'Public Declare Function CKT_GetAllMessageHead Lib "tc400.dll" (ByVal Sno As Integer, <[In](), Out()> ByVal mh As CKT_MessageHead()) As Integer
    Public Declare Function CKT_GetAllMessageHead Lib "tc400.dll" (ByVal Sno As Integer, <Out()> ByVal mh As CKT_MessageHead()) As Integer
    Public Declare Function CKT_DelMessageByIndex Lib "tc400.dll" (ByVal Sno As Integer, ByVal idx As Integer) As Integer


End Module