Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices


Public Class FindReplaceDialog
    ' Private Members

    Private hwndDlg As IntPtr ' Dialog handle

    ' API Class and Methods

    <StructLayout(LayoutKind.Sequential)>
    Friend Class FindReplace
        Friend cbSize As Integer
        Friend hwndOwner As IntPtr
        Friend hInstance As IntPtr
        Friend flags As Integer
        Friend findwhat As IntPtr
        Friend replacewith As IntPtr
        Friend findwhatlen As Short
        Friend replacewithlen As Short
        Friend custdata As IntPtr
        Friend hookproc As IntPtr
        Friend templateName As IntPtr
    End Class

    <DllImport("Comdlg32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function FindText(ByVal lpfr As IntPtr) As IntPtr
    End Function

    <DllImport("Comdlg32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function ReplaceText(ByVal lpfr As IntPtr) As IntPtr
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function RegisterWindowMessage(<MarshalAs(UnmanagedType.LPTStr)>
      ByVal message As String) As Integer
    End Function

    <DllImport("User32.dll")>
    Private Shared Function DestroyWindow(ByVal hwnd As IntPtr) As Integer
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure MSG
        Friend hwnd As IntPtr
        Friend message As Integer
        Friend wparam As IntPtr
        Friend lparam As IntPtr
        Private time As Integer
        Private x As Long
        Private y As Long
    End Structure

    <DllImport("User32.dll")>
    Private Shared Function IsDialogMessage(ByVal hwnd As IntPtr,
                                            ByRef msg As MSG) As Boolean
    End Function

    ' IMessageFilter Implementation

    Public Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) _
    As Boolean Implements System.Windows.Forms.IMessageFilter.PreFilterMessage
        Dim msg As New MSG()
        msg.hwnd = m.HWnd
        msg.lparam = m.LParam
        msg.message = m.Msg
        msg.wparam = m.WParam
        Return IsDialogMessage(hwndDlg, msg)
    End Function


End Class
