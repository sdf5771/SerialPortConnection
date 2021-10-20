<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCBInterface
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSearchOrder = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.cboPortNm = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchOrder
        '
        Me.btnSearchOrder.Location = New System.Drawing.Point(129, 386)
        Me.btnSearchOrder.Name = "btnSearchOrder"
        Me.btnSearchOrder.Size = New System.Drawing.Size(177, 33)
        Me.btnSearchOrder.TabIndex = 0
        Me.btnSearchOrder.Text = "Inquery"
        Me.btnSearchOrder.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(312, 386)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(177, 33)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(495, 386)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(177, 33)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'cboPortNm
        '
        Me.cboPortNm.FormattingEnabled = True
        Me.cboPortNm.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10"})
        Me.cboPortNm.Location = New System.Drawing.Point(474, 19)
        Me.cboPortNm.Name = "cboPortNm"
        Me.cboPortNm.Size = New System.Drawing.Size(167, 20)
        Me.cboPortNm.TabIndex = 3
        Me.cboPortNm.Text = "COM1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(358, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Choose ComPort : "
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(647, 17)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(53, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(668, 307)
        Me.DataGridView1.TabIndex = 7
        '
        'FrmCBInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPortNm)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnSearchOrder)
        Me.Name = "FrmCBInterface"
        Me.Text = "CBInterface"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearchOrder As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents cboPortNm As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
