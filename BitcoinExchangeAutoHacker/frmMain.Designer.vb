<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpExchanges = New System.Windows.Forms.GroupBox()
        Me.chlExchanges = New System.Windows.Forms.CheckedListBox()
        Me.txtProgress = New System.Windows.Forms.TextBox()
        Me.grpProgress = New System.Windows.Forms.GroupBox()
        Me.btnHack = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.grpExchanges.SuspendLayout()
        Me.grpProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpExchanges
        '
        Me.grpExchanges.Controls.Add(Me.chlExchanges)
        Me.grpExchanges.Location = New System.Drawing.Point(13, 23)
        Me.grpExchanges.Name = "grpExchanges"
        Me.grpExchanges.Size = New System.Drawing.Size(240, 260)
        Me.grpExchanges.TabIndex = 0
        Me.grpExchanges.TabStop = False
        Me.grpExchanges.Text = "Exchanges"
        '
        'chlExchanges
        '
        Me.chlExchanges.FormattingEnabled = True
        Me.chlExchanges.Items.AddRange(New Object() {"Accesscoin", "AurumXChange Company", "AutoMtGox", "Bahtcoin", "Bit Innovate", "BitBargain", "BitBox", "Bitcoil", "Bitcoin Argentina", "Bitcoin Brasil", "Bitcoin Nordic", "Bitcoin-24", "Bitcoin-Central", "Bitcoin-otc", "Bitcoin.com.es", "Bitcoin.de", "Bitcoin2Cash", "BitcoinExchange Services", "BitcoinMarket24", "Bitcoins Direct", "Bitcoins In Berlin", "Bitcoins.co.kr", "Bitcoiny.cz", "Bitfloor", "BitInstant", "BitMarket.co", "BitMarket.eu", "BitMe", "BitNZ", "Bitparking", "BitPiggy", "Bitstamp", "Britcoin", "BTC Buy", "BTC China", "Btc-Direct", "BTC-E", "BTC4Euro.eu", "Btcnow", "BTCPak", "BTCX.se", "BuyBTC.cz", "Buying bitcoins", "Camp BX", "Canadian Bitcoins", "Coin2Pal", "Coinapult", "Coinbase", "Crypto::Stocks", "Currency exchange", "Dark Exchange", "DialCoin", "ECurrencyZone", "First-time buyers guide", "ExchangeBitcoins.com", "FastCash4Bitcoins", "FYB-SG", "GetBitcoin", "ICBIT", "In Person Traders", "InstaWire", "Intersango", "Kapiton.se", "Liberty2Reserve", "Lilion Transfer", "Mang Sweeney", "MercaBit.eu", "Mercado Bitcoin", "MPEx", "Mr Bitcoins", "MtGox", "Nanaimo Gold", "Omnicoins", "OTC Exchange", "Picostocks", "Rock Currency Exchange", "Selling bitcoins", "Spend Bitcoins", "Swissbitcoins", "Ubitex", "Vircurex", "VirtEx", "VirWoX", "WeExchange", "WM-Center", "ZIGGAP"})
        Me.chlExchanges.Location = New System.Drawing.Point(7, 20)
        Me.chlExchanges.Name = "chlExchanges"
        Me.chlExchanges.Size = New System.Drawing.Size(227, 229)
        Me.chlExchanges.TabIndex = 0
        '
        'txtProgress
        '
        Me.txtProgress.Enabled = False
        Me.txtProgress.Location = New System.Drawing.Point(6, 21)
        Me.txtProgress.Multiline = True
        Me.txtProgress.Name = "txtProgress"
        Me.txtProgress.Size = New System.Drawing.Size(188, 234)
        Me.txtProgress.TabIndex = 1
        '
        'grpProgress
        '
        Me.grpProgress.Controls.Add(Me.txtProgress)
        Me.grpProgress.Location = New System.Drawing.Point(297, 22)
        Me.grpProgress.Name = "grpProgress"
        Me.grpProgress.Size = New System.Drawing.Size(200, 261)
        Me.grpProgress.TabIndex = 2
        Me.grpProgress.TabStop = False
        Me.grpProgress.Text = "Progress"
        '
        'btnHack
        '
        Me.btnHack.Location = New System.Drawing.Point(303, 306)
        Me.btnHack.Name = "btnHack"
        Me.btnHack.Size = New System.Drawing.Size(194, 45)
        Me.btnHack.TabIndex = 3
        Me.btnHack.Text = "Hack"
        Me.btnHack.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(64, 319)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(189, 20)
        Me.txtAddress.TabIndex = 4
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(13, 319)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 5
        Me.lblAddress.Text = "Address"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 372)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnHack)
        Me.Controls.Add(Me.grpProgress)
        Me.Controls.Add(Me.grpExchanges)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Bitcoin Exchange Auto Hacker"
        Me.grpExchanges.ResumeLayout(False)
        Me.grpProgress.ResumeLayout(False)
        Me.grpProgress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpExchanges As System.Windows.Forms.GroupBox
    Friend WithEvents chlExchanges As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtProgress As System.Windows.Forms.TextBox
    Friend WithEvents grpProgress As System.Windows.Forms.GroupBox
    Friend WithEvents btnHack As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label

End Class
