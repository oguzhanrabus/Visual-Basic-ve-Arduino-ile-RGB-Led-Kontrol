<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnRastTmr = New System.Windows.Forms.Button()
        Me.BtnRastgele = New System.Windows.Forms.Button()
        Me.BtnBeyaz = New System.Windows.Forms.Button()
        Me.BtnSarı = New System.Windows.Forms.Button()
        Me.BtnMavi = New System.Windows.Forms.Button()
        Me.BtnYeşil = New System.Windows.Forms.Button()
        Me.BtnKırmızı = New System.Windows.Forms.Button()
        Me.BtnBağlantıKes = New System.Windows.Forms.Button()
        Me.BtnBağlantıAç = New System.Windows.Forms.Button()
        Me.VeriHızı = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComPort = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnComPort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Interval = 750
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Label2"
        '
        'BtnStop
        '
        Me.BtnStop.BackgroundImage = CType(resources.GetObject("BtnStop.BackgroundImage"), System.Drawing.Image)
        Me.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStop.Location = New System.Drawing.Point(251, 83)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(25, 25)
        Me.BtnStop.TabIndex = 28
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnRastTmr
        '
        Me.BtnRastTmr.BackgroundImage = CType(resources.GetObject("BtnRastTmr.BackgroundImage"), System.Drawing.Image)
        Me.BtnRastTmr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRastTmr.Location = New System.Drawing.Point(220, 83)
        Me.BtnRastTmr.Name = "BtnRastTmr"
        Me.BtnRastTmr.Size = New System.Drawing.Size(25, 25)
        Me.BtnRastTmr.TabIndex = 27
        Me.BtnRastTmr.UseVisualStyleBackColor = True
        '
        'BtnRastgele
        '
        Me.BtnRastgele.BackgroundImage = CType(resources.GetObject("BtnRastgele.BackgroundImage"), System.Drawing.Image)
        Me.BtnRastgele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRastgele.Location = New System.Drawing.Point(189, 83)
        Me.BtnRastgele.Name = "BtnRastgele"
        Me.BtnRastgele.Size = New System.Drawing.Size(25, 25)
        Me.BtnRastgele.TabIndex = 26
        Me.BtnRastgele.UseVisualStyleBackColor = True
        '
        'BtnBeyaz
        '
        Me.BtnBeyaz.BackColor = System.Drawing.Color.White
        Me.BtnBeyaz.Location = New System.Drawing.Point(158, 83)
        Me.BtnBeyaz.Name = "BtnBeyaz"
        Me.BtnBeyaz.Size = New System.Drawing.Size(25, 25)
        Me.BtnBeyaz.TabIndex = 25
        Me.BtnBeyaz.UseVisualStyleBackColor = False
        '
        'BtnSarı
        '
        Me.BtnSarı.BackColor = System.Drawing.Color.Yellow
        Me.BtnSarı.Location = New System.Drawing.Point(127, 83)
        Me.BtnSarı.Name = "BtnSarı"
        Me.BtnSarı.Size = New System.Drawing.Size(25, 25)
        Me.BtnSarı.TabIndex = 24
        Me.BtnSarı.UseVisualStyleBackColor = False
        '
        'BtnMavi
        '
        Me.BtnMavi.BackColor = System.Drawing.Color.Aqua
        Me.BtnMavi.Location = New System.Drawing.Point(96, 83)
        Me.BtnMavi.Name = "BtnMavi"
        Me.BtnMavi.Size = New System.Drawing.Size(25, 25)
        Me.BtnMavi.TabIndex = 23
        Me.BtnMavi.UseVisualStyleBackColor = False
        '
        'BtnYeşil
        '
        Me.BtnYeşil.BackColor = System.Drawing.Color.Lime
        Me.BtnYeşil.Location = New System.Drawing.Point(65, 83)
        Me.BtnYeşil.Name = "BtnYeşil"
        Me.BtnYeşil.Size = New System.Drawing.Size(25, 25)
        Me.BtnYeşil.TabIndex = 22
        Me.BtnYeşil.UseVisualStyleBackColor = False
        '
        'BtnKırmızı
        '
        Me.BtnKırmızı.BackColor = System.Drawing.Color.Red
        Me.BtnKırmızı.Location = New System.Drawing.Point(34, 83)
        Me.BtnKırmızı.Name = "BtnKırmızı"
        Me.BtnKırmızı.Size = New System.Drawing.Size(25, 25)
        Me.BtnKırmızı.TabIndex = 21
        Me.BtnKırmızı.UseVisualStyleBackColor = False
        '
        'BtnBağlantıKes
        '
        Me.BtnBağlantıKes.Location = New System.Drawing.Point(220, 13)
        Me.BtnBağlantıKes.Name = "BtnBağlantıKes"
        Me.BtnBağlantıKes.Size = New System.Drawing.Size(75, 58)
        Me.BtnBağlantıKes.TabIndex = 20
        Me.BtnBağlantıKes.Text = "Bağlantıyı" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kes"
        Me.BtnBağlantıKes.UseVisualStyleBackColor = True
        '
        'BtnBağlantıAç
        '
        Me.BtnBağlantıAç.Location = New System.Drawing.Point(220, 12)
        Me.BtnBağlantıAç.Name = "BtnBağlantıAç"
        Me.BtnBağlantıAç.Size = New System.Drawing.Size(75, 60)
        Me.BtnBağlantıAç.TabIndex = 19
        Me.BtnBağlantıAç.Text = "Bağlantıyı" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aç"
        Me.BtnBağlantıAç.UseVisualStyleBackColor = True
        '
        'VeriHızı
        '
        Me.VeriHızı.FormattingEnabled = True
        Me.VeriHızı.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.VeriHızı.Location = New System.Drawing.Point(93, 51)
        Me.VeriHızı.Name = "VeriHızı"
        Me.VeriHızı.Size = New System.Drawing.Size(121, 21)
        Me.VeriHızı.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Veri Hızı : "
        '
        'ComPort
        '
        Me.ComPort.FormattingEnabled = True
        Me.ComPort.Location = New System.Drawing.Point(93, 14)
        Me.ComPort.Name = "ComPort"
        Me.ComPort.Size = New System.Drawing.Size(121, 21)
        Me.ComPort.TabIndex = 16
        '
        'BtnComPort
        '
        Me.BtnComPort.Location = New System.Drawing.Point(12, 12)
        Me.BtnComPort.Name = "BtnComPort"
        Me.BtnComPort.Size = New System.Drawing.Size(75, 23)
        Me.BtnComPort.TabIndex = 15
        Me.BtnComPort.Text = "Port Ara"
        Me.BtnComPort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 179)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnRastTmr)
        Me.Controls.Add(Me.BtnRastgele)
        Me.Controls.Add(Me.BtnBeyaz)
        Me.Controls.Add(Me.BtnSarı)
        Me.Controls.Add(Me.BtnMavi)
        Me.Controls.Add(Me.BtnYeşil)
        Me.Controls.Add(Me.BtnKırmızı)
        Me.Controls.Add(Me.BtnBağlantıKes)
        Me.Controls.Add(Me.BtnBağlantıAç)
        Me.Controls.Add(Me.VeriHızı)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComPort)
        Me.Controls.Add(Me.BtnComPort)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer2 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnStop As Button
    Friend WithEvents BtnRastTmr As Button
    Friend WithEvents BtnRastgele As Button
    Friend WithEvents BtnBeyaz As Button
    Friend WithEvents BtnSarı As Button
    Friend WithEvents BtnMavi As Button
    Friend WithEvents BtnYeşil As Button
    Friend WithEvents BtnKırmızı As Button
    Friend WithEvents BtnBağlantıKes As Button
    Friend WithEvents BtnBağlantıAç As Button
    Friend WithEvents VeriHızı As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComPort As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnComPort As Button
End Class
