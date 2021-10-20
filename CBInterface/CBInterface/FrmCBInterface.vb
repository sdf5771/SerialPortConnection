Imports System.IO.Ports
Imports System.Threading
Imports System.Data
Imports System.Data.SqlClient

Public Class FrmCBInterface
    Private WithEvents ComPort As New System.IO.Ports.SerialPort

    Delegate Sub AddMessageDelegate(ByVal str As String)

    Private Sub GetData(ByVal selectCommand)


    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmCBInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            SerialPort.PortName = Trim(cboPortNm.Text)
            SerialPort.BaudRate = 9600
            SerialPort.Parity = Parity.None
            SerialPort.DataBits = 8
            SerialPort.StopBits = StopBits.One

            If (SerialPort.IsOpen = True) Then
                MessageBox.Show(SerialPort.PortName & "is Already", "This Port is Already Opened", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Call SerialPort.Open()

            If (SerialPort.IsOpen = True) Then
                MessageBox.Show(SerialPort.PortName & " is Open", "ComPort Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("cbo.serialport" & "is Not Open, Please Check Your Serial Port Number", "Serial Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim aaa As String
        ''aaa = DataGridView1.Ro
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnSearchOrder_Click(sender As Object, e As EventArgs) Handles btnSearchOrder.Click
        Dim constr As String
        Dim conn As SqlConnection
        Dim adapter As SqlDataAdapter
        Dim ds As New DataSet
        constr = "Server=127.0.0.1;Database=RABDIS_ii_1;User Id=sa;Password=1004;"
        conn = New SqlConnection(constr)
        Try
            conn.Open()
            adapter = New SqlDataAdapter("   SELECT	orders.sampleno
		                                            , orders.orderdt
		                                            , orders.testtype
		                                            , orders.usercd
		                                            , orders.remark
		                                            , s.itemcd 
                                              FROM datRESULTM AS orders
                                             INNER Join datRESULTD AS s
	                                            ON s.sampleno = orders.sampleno
                                             WHERE orders.eqpcd = 'CDX'", conn)

            adapter.Fill(ds)
            conn.Close()
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
