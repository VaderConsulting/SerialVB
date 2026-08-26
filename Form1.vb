Option Explicit On 
Option Strict On

'==========================================================================================
'
'		OpenNETCF.Samples.SerialVB
'		Copyright (c) 2003, OpenNETCF.org
'
'		This library is free software; you can redistribute it and/or modify it under 
'		the terms of the OpenNETCF.org Shared Source License.
'
'		This library is distributed in the hope that it will be useful, but 
'		WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or 
'		FITNESS FOR A PARTICULAR PURPOSE. See the OpenNETCF.org Shared Source License 
'		for more details.
'
'		You should have received a copy of the OpenNETCF.org Shared Source License 
'		along with this library; if not, email licensing@opennetcf.org to request a copy.
'
'		If you wish to contact the OpenNETCF Advisory Board to discuss licensing, please 
'		email licensing@opennetcf.org.
'
'		For general enquiries, email enquiries@opennetcf.org or visit our website at:
'		http:'www.opennetcf.org
'
'==========================================================================================

Imports OpenNETCF
Imports System.Text

Public Class Form1
    Inherits System.Windows.Forms.Form
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MainMenu2 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem

    Public WithEvents SerialPort As New IO.Serial.Port("COM4")

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.txtTerm = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MainMenu2 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        '
        'txtTerm
        '
        Me.txtTerm.Multiline = True
        Me.txtTerm.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTerm.Size = New System.Drawing.Size(240, 163)
        Me.txtTerm.Text = ""
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.MenuItem17)
        '
        'MenuItem17
        '
        Me.MenuItem17.Text = ""
        '
        'MainMenu2
        '
        Me.MainMenu2.MenuItems.Add(Me.MenuItem1)
        Me.MainMenu2.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem4)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem5)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem6)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem7)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem8)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem9)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem10)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem11)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem12)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem13)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem16)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem14)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem15)
        Me.MenuItem1.Text = "Port"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "Com1:"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "Com2:"
        '
        'MenuItem5
        '
        Me.MenuItem5.Text = "Com3:"
        '
        'MenuItem6
        '
        Me.MenuItem6.Text = "Com4:"
        '
        'MenuItem7
        '
        Me.MenuItem7.Text = "Com5:"
        '
        'MenuItem8
        '
        Me.MenuItem8.Text = "Com6:"
        '
        'MenuItem9
        '
        Me.MenuItem9.Text = "Com7:"
        '
        'MenuItem10
        '
        Me.MenuItem10.Text = "Com8:"
        '
        'MenuItem11
        '
        Me.MenuItem11.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Text = "300 bps"
        '
        'MenuItem13
        '
        Me.MenuItem13.Text = "1200 bps"
        '
        'MenuItem16
        '
        Me.MenuItem16.Text = "4800 bps"
        '
        'MenuItem14
        '
        Me.MenuItem14.Text = "9600 bps"
        '
        'MenuItem15
        '
        Me.MenuItem15.Text = "115200 bps"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Open Port"
        '
        'Form1
        '
        Me.Controls.Add(Me.txtTerm)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu2
        Me.MinimizeBox = False
        Me.Text = "Form1"

    End Sub

#End Region

    Private ScreenBuff As New StringBuilder(4096)

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With SerialPort
            .PortName = "COM4:"
            MenuItem6.Checked = True
            .RThreshold = 1
            .Settings.BaudRate = IO.Serial.BaudRates.CBR_115200
            MenuItem15.Checked = True
            .Settings.ByteSize = 8
            .Settings.Parity = IO.Serial.Parity.none
            .Settings.StopBits = IO.Serial.StopBits.one
            .InputLen = 0
        End With
        txtTerm.Focus()
    End Sub

    Private Sub txtTerm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTerm.KeyPress
        With SerialPort
            If .IsOpen = True Then
                Dim OutputData(0) As Byte
                OutputData(0) = CByte(Asc(e.KeyChar))
                .Output = OutputData
            Else
                MsgBox("Port Not Open")
            End If
            e.Handled = True
        End With
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        With SerialPort
            If MenuItem2.Text = "Open Port" Then
                Try
                    .Open()
                Catch ex As Exception

                End Try
                If .IsOpen Then
                    MenuItem2.Text = "Close Port"
                Else
                    MsgBox("Port open failed", MsgBoxStyle.Exclamation)
                End If
            Else
                .Close()
                MenuItem2.Text = "Open Port"
            End If
        End With
    End Sub

    Private Function OpenPort(ByVal Port As String) As Boolean
        With SerialPort
            Dim IsOpen As Boolean = .IsOpen
            Dim PortName As String = .PortName
            .PortName = Port
            Try
                .Open()
                Return True
            Catch ex As Exception
                .PortName = PortName
                If IsOpen Then .Open()
            End Try
            If IsOpen = False And .IsOpen = True Then .Close()
        End With
    End Function

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        If OpenPort("COM1:") = True Then
            ClearPortChecks()
            MenuItem3.Checked = True
        End If
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If OpenPort("COM2:") = True Then
            ClearPortChecks()
            MenuItem4.Checked = True
        End If
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If OpenPort("COM3:") = True Then
            ClearPortChecks()
            MenuItem5.Checked = True
        End If
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If OpenPort("COM4:") = True Then
            ClearPortChecks()
            MenuItem6.Checked = True
        End If
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If OpenPort("COM5:") = True Then
            ClearPortChecks()
            MenuItem7.Checked = True
        End If
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        If OpenPort("COM6:") = True Then
            ClearPortChecks()
            MenuItem8.Checked = True
        End If
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If OpenPort("COM7:") = True Then
            ClearPortChecks()
            MenuItem9.Checked = True
        End If
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If OpenPort("COM8:") = True Then
            ClearPortChecks()
            MenuItem10.Checked = True
        End If
    End Sub

    Private Sub ClearPortChecks()
        MenuItem3.Checked = False
        MenuItem4.Checked = False
        MenuItem5.Checked = False
        MenuItem6.Checked = False
        MenuItem7.Checked = False
        MenuItem8.Checked = False
        MenuItem9.Checked = False
        MenuItem10.Checked = False
    End Sub

    Private Sub ClearBitRateChecks()
        MenuItem12.Checked = False
        MenuItem13.Checked = False
        MenuItem14.Checked = False
        MenuItem15.Checked = False
        MenuItem16.Checked = False
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        SerialPort.Settings.BaudRate = IO.Serial.BaudRates.CBR_300
        ClearBitRateChecks()
        MenuItem12.Checked = True
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        SerialPort.Settings.BaudRate = IO.Serial.BaudRates.CBR_1200
        ClearBitRateChecks()
        MenuItem13.Checked = True
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        SerialPort.Settings.BaudRate = IO.Serial.BaudRates.CBR_9600
        ClearBitRateChecks()
        MenuItem14.Checked = True
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        SerialPort.Settings.BaudRate = IO.Serial.BaudRates.CBR_115200
        ClearBitRateChecks()
        MenuItem15.Checked = True
    End Sub

    Private Sub SerialPort_DataReceived() Handles SerialPort.DataReceived
        Dim Buffer(SerialPort.InBufferCount - 1) As Byte
        Buffer = SerialPort.Input
        'This is FAR from the best way to manage this data.  It is "quick and dirty."
        If Buffer.Length > 0 Then
            ScreenBuff.Append(Encoding.ASCII.GetString(Buffer, 0, Buffer.Length))
            Me.Invoke(New EventHandler(AddressOf DisplayData))
        End If
    End Sub

    Private Sub DisplayData(ByVal sender As Object, ByVal e As EventArgs)
        'This marshalls receive data from the thread context to the Windows Form STAThread context
        With txtTerm
            .Text = ScreenBuff.ToString
            .SelectionStart = .Text.Length
        End With
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If SerialPort.IsOpen Then SerialPort.Close()
    End Sub
End Class
