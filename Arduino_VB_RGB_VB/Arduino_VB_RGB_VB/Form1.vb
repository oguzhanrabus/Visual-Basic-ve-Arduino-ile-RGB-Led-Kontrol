Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        BtnBağlantıAç.Enabled = False
        BtnBağlantıAç.BringToFront()

        BtnBağlantıKes.Enabled = False
        BtnBağlantıKes.SendToBack()
        VeriHızı.SelectedItem = "9600"

        Timer1.Start()

    End Sub

    Private Sub BtnComPort_Click(sender As Object, e As EventArgs) Handles BtnComPort.Click
        ComPort.Items.Clear()
        Dim myport As Array
        Dim i As Integer
        myport = IO.Ports.SerialPort.GetPortNames
        ComPort.Items.AddRange(myport)
        i = ComPort.Items.Count
        i = i - i

        Try
            ComPort.SelectedIndex = i

        Catch ex As Exception
            Dim result As DialogResult
            result = MessageBox.Show("Comport Bulunamadı", "Dikkat !!!!", MessageBoxButtons.OK)
            ComPort.Text = ""
            ComPort.Items.Clear()
            Call Form1_Load(Me, e)
        End Try
        BtnBağlantıAç.Enabled = True
        BtnComPort.BringToFront()
        ComPort.DroppedDown = True
    End Sub

    Private Sub BtnBağlantıAç_Click(sender As Object, e As EventArgs) Handles BtnBağlantıAç.Click
        BtnBağlantıAç.Enabled = False
        BtnBağlantıAç.SendToBack()
        SerialPort1.BaudRate = VeriHızı.SelectedItem
        SerialPort1.PortName = ComPort.SelectedItem
        SerialPort1.Open()
        BtnBağlantıKes.Enabled = True
        BtnBağlantıKes.BringToFront()

    End Sub

    Private Sub BtnBağlantıKes_Click(sender As Object, e As EventArgs) Handles BtnBağlantıKes.Click
        BtnBağlantıKes.Enabled = False
        BtnBağlantıKes.SendToBack()

        SerialPort1.Close()
        BtnBağlantıAç.Enabled = True
        BtnBağlantıAç.BringToFront()
    End Sub

    Private Sub BtnKırmızı_Click(sender As Object, e As EventArgs) Handles BtnKırmızı.Click
        SerialPort1.Write("1")
        Timer2.Stop()
    End Sub

    Private Sub BtnYeşil_Click(sender As Object, e As EventArgs) Handles BtnYeşil.Click
        SerialPort1.Write("2")
        Timer2.Stop()
    End Sub

    Private Sub BtnMavi_Click(sender As Object, e As EventArgs) Handles BtnMavi.Click
        SerialPort1.Write("3")
        Timer2.Stop()
    End Sub

    Private Sub BtnSarı_Click(sender As Object, e As EventArgs) Handles BtnSarı.Click
        SerialPort1.Write("4")
        Timer2.Stop()
    End Sub

    Private Sub BtnBeyaz_Click(sender As Object, e As EventArgs) Handles BtnBeyaz.Click
        SerialPort1.Write("5")
        Timer2.Stop()
    End Sub

    Private Sub BtnRastgele_Click(sender As Object, e As EventArgs) Handles BtnRastgele.Click
        SerialPort1.Write("6")
        Timer2.Stop()
    End Sub

    Private Sub BtnRastTmr_Click(sender As Object, e As EventArgs) Handles BtnRastTmr.Click
        Timer2.Start()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        SerialPort1.Write("0")
        Timer2.Stop()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SerialPort1.Write("7")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SerialPort1.IsOpen Then
            Me.BackColor = Color.Green
            Label2.Text = ("Bağlantı Başarılı")
            BtnKırmızı.Enabled = True
            BtnYeşil.Enabled = True
            BtnMavi.Enabled = True
            BtnSarı.Enabled = True
            BtnBeyaz.Enabled = True
            BtnRastgele.Enabled = True
            BtnRastTmr.Enabled = True
            BtnStop.Enabled = True
        Else
            Me.BackColor = Color.Red
            Label2.Text = ("Bağlantı Yok")
            BtnKırmızı.Enabled = False
            BtnYeşil.Enabled = False
            BtnMavi.Enabled = False
            BtnSarı.Enabled = False
            BtnBeyaz.Enabled = False
            BtnRastgele.Enabled = False
            BtnRastTmr.Enabled = False
            BtnStop.Enabled = False
            Timer2.Stop()

        End If
    End Sub

End Class
