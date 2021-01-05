Imports Microsoft.Win32
Imports System.IO
Imports System.ServiceProcess
Imports System.Threading

Public Class main

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim environmentKey As RegistryKey
            Dim pwdID As String = "" ' Insert ID here
            Dim pwd As String = "" ' Insert hashed password here

            If tbComputerName.Text.Length = 0 Then
                MsgBox("The name of the remote computer must be specified.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, Application.ProductName)
                Return
            End If

            environmentKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, tbComputerName.Text)

            Dim key6 As RegistryKey = environmentKey.OpenSubKey("SOFTWARE\TeamViewer\Version6")
            Dim key7 As RegistryKey = environmentKey.OpenSubKey("SOFTWARE\TeamViewer\Version7")
            Dim key8 As RegistryKey = environmentKey.OpenSubKey("SOFTWARE\TeamViewer\Version8")
            Dim key9 As RegistryKey = environmentKey.OpenSubKey("SOFTWARE\TeamViewer\Version9")

            Dim key6_64 As RegistryKey = environmentKey.OpenSubKey("SOFTWARE\Wow6432Node\TeamViewer\Version6")
            Dim key7_64 As RegistryKey = environmentKey.OpenSubKey("SOFTWARE\Wow6432Node\TeamViewer\Version7")
            Dim key8_64 As RegistryKey = environmentKey.OpenSubKey("SOFTWARE\Wow6432Node\TeamViewer\Version8")
            Dim key9_64 As RegistryKey = environmentKey.OpenSubKey("SOFTWARE\Wow6432Node\TeamViewer\Version9")

            If key6 Is Nothing = False Then
                tbTVID.Text = key6.GetValue("ClientID").ToString()
                'key6.SetValue("MultiPwdMgmtIDs", pwdID)
                'key6.SetValue("MultiPwdMgmtPwdData", pwd)
            ElseIf key7 Is Nothing = False Then
                tbTVID.Text = key7.GetValue("ClientID").ToString()
                'key7.SetValue("MultiPwdMgmtIDs", pwdID)
                'key7.SetValue("MultiPwdMgmtPwdData", pwd)
            ElseIf key8 Is Nothing = False Then
                tbTVID.Text = key8.GetValue("ClientID").ToString()
                'key8.SetValue("MultiPwdMgmtIDs", pwdID)
                'key8.SetValue("MultiPwdMgmtPwdData", pwd)
            ElseIf key9 Is Nothing = False Then
                tbTVID.Text = key9.GetValue("ClientID").ToString()
                'key9.SetValue("MultiPwdMgmtIDs", pwdID)
                'key9.SetValue("MultiPwdMgmtPwdData", pwd)
            ElseIf key6_64 Is Nothing = False Then
                tbTVID.Text = key6_64.GetValue("ClientID").ToString()
                'key6_64.SetValue("MultiPwdMgmtIDs", pwdID)
                'key6_64.SetValue("MultiPwdMgmtPwdData", pwd)
            ElseIf key7_64 Is Nothing = False Then
                tbTVID.Text = key7_64.GetValue("ClientID").ToString()
                'key7_64.SetValue("MultiPwdMgmtIDs", pwdID)
                'key7_64.SetValue("MultiPwdMgmtPwdData", pwd)
            ElseIf key8_64 Is Nothing = False Then
                tbTVID.Text = key8_64.GetValue("ClientID").ToString()
                'key8_64.SetValue("MultiPwdMgmtIDs", pwdID)
                'key8_64.SetValue("MultiPwdMgmtPwdData", pwd)
            ElseIf key9_64 Is Nothing = False Then
                tbTVID.Text = key9_64.GetValue("ClientID").ToString()
                'key9_64.SetValue("MultiPwdMgmtIDs", pwdID)
                'key9_64.SetValue("MultiPwdMgmtPwdData", pwd)
            Else
                tbTVID.Text = "0" 'Fallback
            End If

            environmentKey.Close()

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & ex.StackTrace.ToString, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, Application.ProductName)
        End Try

        ' Connection Info
        Try
            dgvConnInfo.Rows.Clear()
            Dim machinename As String = tbComputerName.Text

            If machinename.Length = 0 Then
                MsgBox("The name of the remote computer must be specified.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, Application.ProductName)
                Return
            End If

            Dim fileV9 As String = "\\" & machinename & "\c$\Program Files (x86)\TeamViewer\Version9\Connections_incoming.txt"

            If File.Exists(fileV9) Then
                Dim fReader As New StreamReader(fileV9)
                fReader.ReadLine()
                Do While fReader.Peek() <> -1
                    Dim lineArr As Array = fReader.ReadLine.Split(New Char() {"	"c})
                    Dim id As String = lineArr(0)
                    Dim connectedname As String = lineArr(1)
                    Dim connectedtime As String = lineArr(2)
                    Dim disconnectedtime As String = lineArr(3)
                    Dim loggedinuser As String = lineArr(4)
                    Dim connectiontype As String = lineArr(5)
                    Dim na As String = lineArr(6)
                    Dim row As String() = New String() {id, connectedname, connectedtime, disconnectedtime, loggedinuser, connectiontype, na}
                    dgvConnInfo.Rows.Add(row)
                Loop
                fReader.Dispose()
                fReader.Close()
            Else
                'MsgBox("Connection file not found.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, Application.ProductName)
                dgvConnInfo.Rows.Add("Connections file not found.")
                Return
            End If

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & ex.StackTrace.ToString, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, Application.ProductName)
            Return
        End Try

    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsslVersion.Text = "v" & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & "." _
                    & My.Application.Info.Version.Build.ToString & " Build " & My.Application.Info.Version.Revision.ToString
        Me.Text = Application.ProductName
        'tbComputerName.Text = "X-PC-1"
        tbComputerName.Text = My.Computer.Name
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If tbComputerName.Text.Length = 0 Then
            MsgBox("The name of the remote computer must be specified.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, Application.ProductName)
            Return
        End If
        cmdLaunch_Click()
    End Sub
    Private Sub cmdLaunch_Click()

        Dim strComputer As String
        Dim strProcess As String
        Dim errReturn As Integer
        Dim objWMIService As Object
        Dim intProcessID As Integer
        Dim colProcesses As Object

        strComputer = tbComputerName.Text
        strProcess = "cmd.exe"
        objWMIService = GetObject("winmgmts:" _
          & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2:Win32_Process")
        errReturn = objWMIService.Create(strProcess, DBNull.Value, DBNull.Value, intProcessID)

        If errReturn = 0 Then
            MsgBox(strProcess & " was started with a process ID of " & intProcessID & ".")
        Else
            MsgBox(strProcess & " could not be started due to error " & _
            errReturn & ".")
        End If

        objWMIService = GetObject("winmgmts:" _
            & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")

        colProcesses = objWMIService.ExecQuery _
            ("SELECT * FROM Win32_Process WHERE Name = '" & strProcess & "'")
        If colProcesses.Count = 0 Then
            MsgBox(strProcess & " is not running.")
        Else
            MsgBox(strProcess & " is running.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tbComputerName.Text = ""
        tbTVID.Text = ""
        dgvConnInfo.Rows.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If tbComputerName.Text.Length = 0 Then
                MsgBox("The name of the remote computer must be specified.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, Application.ProductName)
                Return
            End If

            Dim servicename As String = "TeamViewer9"
            Dim computername As String = tbComputerName.Text
            Dim sc As ServiceController = New ServiceController(servicename, computername)
            If sc.Status = ServiceControllerStatus.Running Then
                lblServiceStatus.Text = "Status: Running"
                sc.Stop()
                lblServiceStatus.Text = "Status: Stopping..."
                sc.WaitForStatus(ServiceControllerStatus.Stopped)
                lblServiceStatus.Text = "Status: Stopped"
                sc.Start()
                lblServiceStatus.Text = "Status: Running"
            ElseIf sc.Status = ServiceControllerStatus.Stopped Then
                sc.Start()
                lblServiceStatus.Text = "Status: Running"
            Else
                lblServiceStatus.Text = "Status: N/A"
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & ex.StackTrace.ToString, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, Application.ProductName)
            Return
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If tbComputerName.Text.Length = 0 Then
                MsgBox("The name of the remote computer must be specified.", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, Application.ProductName)
                Return
            End If

            Dim servicename As String = "TeamViewer9"
            Dim computername As String = tbComputerName.Text
            Dim sc As ServiceController = New ServiceController(servicename, computername)
            If sc.Status = ServiceControllerStatus.Running Then
                lblServiceStatus.Text = "Status: Running"
                sc.Stop()
                lblServiceStatus.Text = "Status: Stopping..."
                sc.WaitForStatus(ServiceControllerStatus.Stopped)
                lblServiceStatus.Text = "Status: Stopped"
            ElseIf sc.Status = ServiceControllerStatus.Stopped Then
                sc.Start()
                lblServiceStatus.Text = "Status: Running"
            Else
                lblServiceStatus.Text = "Status: N/A"
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & ex.StackTrace.ToString, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, Application.ProductName)
            Return
        End Try
    End Sub
End Class
