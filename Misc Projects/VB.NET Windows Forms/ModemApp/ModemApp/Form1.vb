Imports System.IO.Ports

Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		DialModem()
	End Sub

	Sub DialModem()
		' Dial a number via an attached modem on COM1. 
		Dim com1 As SerialPort = My.Computer.Ports.OpenSerialPort("COM4", 1)
		com1.DtrEnable = True
        com1.Write("ATDT 1-717-344-9250" & vbCrLf)
        ' Insert code to transfer data to and from the modem. 
        com1.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>...")
    End Sub
End Class
