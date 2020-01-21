Option Strict Off
Option Explicit On
Friend Class frmBidCalc
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtMU As System.Windows.Forms.TextBox
	Public WithEvents txtRadio As System.Windows.Forms.TextBox
	Public WithEvents txtTank As System.Windows.Forms.TextBox
    Public WithEvents txtInsurance As System.Windows.Forms.TextBox
    Public WithEvents txtTotalFuelCost As System.Windows.Forms.TextBox
    Public WithEvents txtER As System.Windows.Forms.TextBox
    Public WithEvents txtCommisions As System.Windows.Forms.TextBox
    Public WithEvents txtCustoms As System.Windows.Forms.TextBox
    Public WithEvents txtLanding As System.Windows.Forms.TextBox
    Public WithEvents txtAF3 As System.Windows.Forms.TextBox
    Public WithEvents txtAF2 As System.Windows.Forms.TextBox
    Public WithEvents txtAF1 As System.Windows.Forms.TextBox
    Public WithEvents txtCrewPD3 As System.Windows.Forms.TextBox
    Public WithEvents txtCrewPD2 As System.Windows.Forms.TextBox
    Public WithEvents txtPerDiemCost As System.Windows.Forms.TextBox
    Public WithEvents txtCrew3 As System.Windows.Forms.TextBox
    Public WithEvents txtCrew2 As System.Windows.Forms.TextBox
    Public WithEvents txtCrew1 As System.Windows.Forms.TextBox
    Public WithEvents txtDaysAway As System.Windows.Forms.TextBox
    Public WithEvents txtPerDiem As System.Windows.Forms.TextBox
    Public WithEvents txtTotalFuel As System.Windows.Forms.TextBox
    Public WithEvents txtFuelCost As System.Windows.Forms.TextBox
    Public WithEvents txtRes As System.Windows.Forms.TextBox
    Public WithEvents txtEorW As System.Windows.Forms.TextBox
    Public WithEvents txtTotal As System.Windows.Forms.TextBox
    Public WithEvents cmbAC As System.Windows.Forms.ComboBox
    Public WithEvents txtAC As System.Windows.Forms.TextBox
    Public WithEvents cmdExit As System.Windows.Forms.Label
    Public WithEvents cmdPrint As System.Windows.Forms.Label
    Public WithEvents lblSubTitle As System.Windows.Forms.Label
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents lblMarkupDec As System.Windows.Forms.Label
    Public WithEvents lblRadioCosts As System.Windows.Forms.Label
    Public WithEvents lblTankingCosts As System.Windows.Forms.Label
    Public WithEvents lblInsurance As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents lblEmergencyEquip As System.Windows.Forms.Label
    Public WithEvents lblCustomerCommision As System.Windows.Forms.Label
    Public WithEvents lblCustomsCosts As System.Windows.Forms.Label
    Public WithEvents lblLandingCosts As System.Windows.Forms.Label
    Public WithEvents lblReturnFares As System.Windows.Forms.Label
    Public WithEvents lblCrewPerDiemCosts As System.Windows.Forms.Label
    Public WithEvents lblCrewSalaries As System.Windows.Forms.Label
    Public WithEvents lblPerDiemDays As System.Windows.Forms.Label
    Public WithEvents lblPerDiemRate As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents lblAvgFuelCost As System.Windows.Forms.Label
    Public WithEvents lblResFltDays As System.Windows.Forms.Label
    Public WithEvents lblEorW As System.Windows.Forms.Label
    Public WithEvents lblTotalMiles As System.Windows.Forms.Label
    Public WithEvents lblACModel As System.Windows.Forms.Label
    Public WithEvents cmdBack As Label
    Public WithEvents lblInsured As Label
    Public WithEvents lblUninsured As Label
    Public WithEvents lblBidTotals As Label
    Public WithEvents txtUninsTotal As TextBox
    Public WithEvents txtCalc As TextBox
    Public WithEvents txtGal As TextBox
    Public WithEvents txtSpeed As TextBox
    Public WithEvents txtInsTotal As TextBox
    Public WithEvents txtOrig As TextBox
    Public WithEvents txtDest As TextBox
    Public WithEvents txtFuel As TextBox
    Public WithEvents imgBtnBkgd As PictureBox
    Public WithEvents imgBtnBkgdBack As System.Windows.Forms.PictureBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBidCalc))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtMU = New System.Windows.Forms.TextBox()
        Me.txtRadio = New System.Windows.Forms.TextBox()
        Me.txtTank = New System.Windows.Forms.TextBox()
        Me.txtInsurance = New System.Windows.Forms.TextBox()
        Me.txtTotalFuelCost = New System.Windows.Forms.TextBox()
        Me.txtER = New System.Windows.Forms.TextBox()
        Me.txtCommisions = New System.Windows.Forms.TextBox()
        Me.txtCustoms = New System.Windows.Forms.TextBox()
        Me.txtLanding = New System.Windows.Forms.TextBox()
        Me.txtAF3 = New System.Windows.Forms.TextBox()
        Me.txtAF2 = New System.Windows.Forms.TextBox()
        Me.txtAF1 = New System.Windows.Forms.TextBox()
        Me.txtCrewPD3 = New System.Windows.Forms.TextBox()
        Me.txtCrewPD2 = New System.Windows.Forms.TextBox()
        Me.txtPerDiemCost = New System.Windows.Forms.TextBox()
        Me.txtCrew3 = New System.Windows.Forms.TextBox()
        Me.txtCrew2 = New System.Windows.Forms.TextBox()
        Me.txtCrew1 = New System.Windows.Forms.TextBox()
        Me.txtDaysAway = New System.Windows.Forms.TextBox()
        Me.txtPerDiem = New System.Windows.Forms.TextBox()
        Me.txtTotalFuel = New System.Windows.Forms.TextBox()
        Me.txtFuelCost = New System.Windows.Forms.TextBox()
        Me.txtRes = New System.Windows.Forms.TextBox()
        Me.txtEorW = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cmbAC = New System.Windows.Forms.ComboBox()
        Me.txtAC = New System.Windows.Forms.TextBox()
        Me.cmdExit = New System.Windows.Forms.Label()
        Me.cmdPrint = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMarkupDec = New System.Windows.Forms.Label()
        Me.lblRadioCosts = New System.Windows.Forms.Label()
        Me.lblTankingCosts = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblEmergencyEquip = New System.Windows.Forms.Label()
        Me.lblCustomerCommision = New System.Windows.Forms.Label()
        Me.lblCustomsCosts = New System.Windows.Forms.Label()
        Me.lblLandingCosts = New System.Windows.Forms.Label()
        Me.lblReturnFares = New System.Windows.Forms.Label()
        Me.lblCrewPerDiemCosts = New System.Windows.Forms.Label()
        Me.lblCrewSalaries = New System.Windows.Forms.Label()
        Me.lblPerDiemDays = New System.Windows.Forms.Label()
        Me.lblPerDiemRate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblAvgFuelCost = New System.Windows.Forms.Label()
        Me.lblResFltDays = New System.Windows.Forms.Label()
        Me.lblEorW = New System.Windows.Forms.Label()
        Me.lblTotalMiles = New System.Windows.Forms.Label()
        Me.lblACModel = New System.Windows.Forms.Label()
        Me.imgBtnBkgdBack = New System.Windows.Forms.PictureBox()
        Me.cmdBack = New System.Windows.Forms.Label()
        Me.lblInsured = New System.Windows.Forms.Label()
        Me.lblUninsured = New System.Windows.Forms.Label()
        Me.lblBidTotals = New System.Windows.Forms.Label()
        Me.txtUninsTotal = New System.Windows.Forms.TextBox()
        Me.txtCalc = New System.Windows.Forms.TextBox()
        Me.txtGal = New System.Windows.Forms.TextBox()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.txtInsTotal = New System.Windows.Forms.TextBox()
        Me.txtOrig = New System.Windows.Forms.TextBox()
        Me.txtDest = New System.Windows.Forms.TextBox()
        Me.txtFuel = New System.Windows.Forms.TextBox()
        Me.imgBtnBkgd = New System.Windows.Forms.PictureBox()
        CType(Me.imgBtnBkgdBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBtnBkgd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMU
        '
        Me.txtMU.AcceptsReturn = True
        Me.txtMU.BackColor = System.Drawing.SystemColors.Window
        Me.txtMU.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMU.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtMU.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMU.Location = New System.Drawing.Point(632, 384)
        Me.txtMU.MaxLength = 0
        Me.txtMU.Name = "txtMU"
        Me.txtMU.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMU.Size = New System.Drawing.Size(114, 23)
        Me.txtMU.TabIndex = 26
        Me.txtMU.Text = ".333"
        '
        'txtRadio
        '
        Me.txtRadio.AcceptsReturn = True
        Me.txtRadio.BackColor = System.Drawing.SystemColors.Window
        Me.txtRadio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRadio.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtRadio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRadio.Location = New System.Drawing.Point(632, 144)
        Me.txtRadio.MaxLength = 0
        Me.txtRadio.Name = "txtRadio"
        Me.txtRadio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRadio.Size = New System.Drawing.Size(114, 23)
        Me.txtRadio.TabIndex = 20
        Me.txtRadio.Text = "0.00"
        '
        'txtTank
        '
        Me.txtTank.AcceptsReturn = True
        Me.txtTank.BackColor = System.Drawing.SystemColors.Window
        Me.txtTank.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTank.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtTank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTank.Location = New System.Drawing.Point(632, 104)
        Me.txtTank.MaxLength = 0
        Me.txtTank.Name = "txtTank"
        Me.txtTank.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTank.Size = New System.Drawing.Size(114, 23)
        Me.txtTank.TabIndex = 19
        Me.txtTank.Text = "0.00"
        '
        'txtInsurance
        '
        Me.txtInsurance.AcceptsReturn = True
        Me.txtInsurance.BackColor = System.Drawing.SystemColors.Window
        Me.txtInsurance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInsurance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtInsurance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInsurance.Location = New System.Drawing.Point(632, 344)
        Me.txtInsurance.MaxLength = 0
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInsurance.Size = New System.Drawing.Size(114, 23)
        Me.txtInsurance.TabIndex = 25
        Me.txtInsurance.Text = "0.00"
        '
        'txtTotalFuelCost
        '
        Me.txtTotalFuelCost.AcceptsReturn = True
        Me.txtTotalFuelCost.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalFuelCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalFuelCost.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtTotalFuelCost.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalFuelCost.Location = New System.Drawing.Point(116, 340)
        Me.txtTotalFuelCost.MaxLength = 0
        Me.txtTotalFuelCost.Name = "txtTotalFuelCost"
        Me.txtTotalFuelCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalFuelCost.Size = New System.Drawing.Size(145, 23)
        Me.txtTotalFuelCost.TabIndex = 7
        Me.txtTotalFuelCost.Text = "0.00"
        '
        'txtER
        '
        Me.txtER.AcceptsReturn = True
        Me.txtER.BackColor = System.Drawing.SystemColors.Window
        Me.txtER.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtER.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtER.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtER.Location = New System.Drawing.Point(632, 304)
        Me.txtER.MaxLength = 0
        Me.txtER.Name = "txtER"
        Me.txtER.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtER.Size = New System.Drawing.Size(114, 23)
        Me.txtER.TabIndex = 24
        Me.txtER.Text = "200.00"
        '
        'txtCommisions
        '
        Me.txtCommisions.AcceptsReturn = True
        Me.txtCommisions.BackColor = System.Drawing.SystemColors.Window
        Me.txtCommisions.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCommisions.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCommisions.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCommisions.Location = New System.Drawing.Point(632, 264)
        Me.txtCommisions.MaxLength = 0
        Me.txtCommisions.Name = "txtCommisions"
        Me.txtCommisions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCommisions.Size = New System.Drawing.Size(114, 23)
        Me.txtCommisions.TabIndex = 23
        Me.txtCommisions.Text = "100.00"
        '
        'txtCustoms
        '
        Me.txtCustoms.AcceptsReturn = True
        Me.txtCustoms.BackColor = System.Drawing.SystemColors.Window
        Me.txtCustoms.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustoms.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCustoms.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCustoms.Location = New System.Drawing.Point(632, 224)
        Me.txtCustoms.MaxLength = 0
        Me.txtCustoms.Name = "txtCustoms"
        Me.txtCustoms.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCustoms.Size = New System.Drawing.Size(114, 23)
        Me.txtCustoms.TabIndex = 22
        Me.txtCustoms.Text = "200.00"
        '
        'txtLanding
        '
        Me.txtLanding.AcceptsReturn = True
        Me.txtLanding.BackColor = System.Drawing.SystemColors.Window
        Me.txtLanding.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLanding.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtLanding.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLanding.Location = New System.Drawing.Point(632, 184)
        Me.txtLanding.MaxLength = 0
        Me.txtLanding.Name = "txtLanding"
        Me.txtLanding.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLanding.Size = New System.Drawing.Size(114, 23)
        Me.txtLanding.TabIndex = 21
        Me.txtLanding.Text = "200.00"
        '
        'txtAF3
        '
        Me.txtAF3.AcceptsReturn = True
        Me.txtAF3.BackColor = System.Drawing.SystemColors.Window
        Me.txtAF3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAF3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtAF3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAF3.Location = New System.Drawing.Point(389, 280)
        Me.txtAF3.MaxLength = 0
        Me.txtAF3.Name = "txtAF3"
        Me.txtAF3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAF3.Size = New System.Drawing.Size(80, 23)
        Me.txtAF3.TabIndex = 15
        Me.txtAF3.Text = "0.00"
        '
        'txtAF2
        '
        Me.txtAF2.AcceptsReturn = True
        Me.txtAF2.BackColor = System.Drawing.SystemColors.Window
        Me.txtAF2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAF2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtAF2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAF2.Location = New System.Drawing.Point(389, 248)
        Me.txtAF2.MaxLength = 0
        Me.txtAF2.Name = "txtAF2"
        Me.txtAF2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAF2.Size = New System.Drawing.Size(80, 23)
        Me.txtAF2.TabIndex = 13
        Me.txtAF2.Text = "0.00"
        '
        'txtAF1
        '
        Me.txtAF1.AcceptsReturn = True
        Me.txtAF1.BackColor = System.Drawing.SystemColors.Window
        Me.txtAF1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAF1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtAF1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAF1.Location = New System.Drawing.Point(389, 216)
        Me.txtAF1.MaxLength = 0
        Me.txtAF1.Name = "txtAF1"
        Me.txtAF1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAF1.Size = New System.Drawing.Size(80, 23)
        Me.txtAF1.TabIndex = 11
        Me.txtAF1.Text = "0.00"
        '
        'txtCrewPD3
        '
        Me.txtCrewPD3.AcceptsReturn = True
        Me.txtCrewPD3.BackColor = System.Drawing.SystemColors.Window
        Me.txtCrewPD3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrewPD3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCrewPD3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCrewPD3.Location = New System.Drawing.Point(389, 392)
        Me.txtCrewPD3.MaxLength = 0
        Me.txtCrewPD3.Name = "txtCrewPD3"
        Me.txtCrewPD3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCrewPD3.Size = New System.Drawing.Size(80, 23)
        Me.txtCrewPD3.TabIndex = 18
        Me.txtCrewPD3.Text = "0.00"
        '
        'txtCrewPD2
        '
        Me.txtCrewPD2.AcceptsReturn = True
        Me.txtCrewPD2.BackColor = System.Drawing.SystemColors.Window
        Me.txtCrewPD2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrewPD2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCrewPD2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCrewPD2.Location = New System.Drawing.Point(389, 360)
        Me.txtCrewPD2.MaxLength = 0
        Me.txtCrewPD2.Name = "txtCrewPD2"
        Me.txtCrewPD2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCrewPD2.Size = New System.Drawing.Size(80, 23)
        Me.txtCrewPD2.TabIndex = 17
        Me.txtCrewPD2.Text = "0.00"
        '
        'txtPerDiemCost
        '
        Me.txtPerDiemCost.AcceptsReturn = True
        Me.txtPerDiemCost.BackColor = System.Drawing.SystemColors.Window
        Me.txtPerDiemCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerDiemCost.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtPerDiemCost.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPerDiemCost.Location = New System.Drawing.Point(389, 328)
        Me.txtPerDiemCost.MaxLength = 0
        Me.txtPerDiemCost.Name = "txtPerDiemCost"
        Me.txtPerDiemCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPerDiemCost.Size = New System.Drawing.Size(80, 23)
        Me.txtPerDiemCost.TabIndex = 16
        Me.txtPerDiemCost.Text = "0.00"
        '
        'txtCrew3
        '
        Me.txtCrew3.AcceptsReturn = True
        Me.txtCrew3.BackColor = System.Drawing.SystemColors.Window
        Me.txtCrew3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrew3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCrew3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCrew3.Location = New System.Drawing.Point(389, 168)
        Me.txtCrew3.MaxLength = 0
        Me.txtCrew3.Name = "txtCrew3"
        Me.txtCrew3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCrew3.Size = New System.Drawing.Size(80, 23)
        Me.txtCrew3.TabIndex = 14
        Me.txtCrew3.Text = "0.00"
        '
        'txtCrew2
        '
        Me.txtCrew2.AcceptsReturn = True
        Me.txtCrew2.BackColor = System.Drawing.SystemColors.Window
        Me.txtCrew2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrew2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCrew2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCrew2.Location = New System.Drawing.Point(389, 136)
        Me.txtCrew2.MaxLength = 0
        Me.txtCrew2.Name = "txtCrew2"
        Me.txtCrew2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCrew2.Size = New System.Drawing.Size(80, 23)
        Me.txtCrew2.TabIndex = 12
        Me.txtCrew2.Text = "0.00"
        '
        'txtCrew1
        '
        Me.txtCrew1.AcceptsReturn = True
        Me.txtCrew1.BackColor = System.Drawing.SystemColors.Window
        Me.txtCrew1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrew1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCrew1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCrew1.Location = New System.Drawing.Point(389, 104)
        Me.txtCrew1.MaxLength = 0
        Me.txtCrew1.Name = "txtCrew1"
        Me.txtCrew1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCrew1.Size = New System.Drawing.Size(80, 23)
        Me.txtCrew1.TabIndex = 10
        Me.txtCrew1.Text = "0.00"
        '
        'txtDaysAway
        '
        Me.txtDaysAway.AcceptsReturn = True
        Me.txtDaysAway.BackColor = System.Drawing.SystemColors.Window
        Me.txtDaysAway.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDaysAway.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtDaysAway.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDaysAway.Location = New System.Drawing.Point(116, 420)
        Me.txtDaysAway.MaxLength = 0
        Me.txtDaysAway.Name = "txtDaysAway"
        Me.txtDaysAway.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDaysAway.Size = New System.Drawing.Size(145, 23)
        Me.txtDaysAway.TabIndex = 9
        Me.txtDaysAway.Text = "0"
        '
        'txtPerDiem
        '
        Me.txtPerDiem.AcceptsReturn = True
        Me.txtPerDiem.BackColor = System.Drawing.SystemColors.Window
        Me.txtPerDiem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPerDiem.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtPerDiem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPerDiem.Location = New System.Drawing.Point(116, 380)
        Me.txtPerDiem.MaxLength = 0
        Me.txtPerDiem.Name = "txtPerDiem"
        Me.txtPerDiem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPerDiem.Size = New System.Drawing.Size(145, 23)
        Me.txtPerDiem.TabIndex = 8
        Me.txtPerDiem.Text = "0.00"
        '
        'txtTotalFuel
        '
        Me.txtTotalFuel.AcceptsReturn = True
        Me.txtTotalFuel.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalFuel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalFuel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtTotalFuel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalFuel.Location = New System.Drawing.Point(116, 300)
        Me.txtTotalFuel.MaxLength = 0
        Me.txtTotalFuel.Name = "txtTotalFuel"
        Me.txtTotalFuel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalFuel.Size = New System.Drawing.Size(145, 23)
        Me.txtTotalFuel.TabIndex = 6
        Me.txtTotalFuel.Text = "0"
        '
        'txtFuelCost
        '
        Me.txtFuelCost.AcceptsReturn = True
        Me.txtFuelCost.BackColor = System.Drawing.SystemColors.Window
        Me.txtFuelCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFuelCost.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtFuelCost.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFuelCost.Location = New System.Drawing.Point(116, 260)
        Me.txtFuelCost.MaxLength = 0
        Me.txtFuelCost.Name = "txtFuelCost"
        Me.txtFuelCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFuelCost.Size = New System.Drawing.Size(145, 23)
        Me.txtFuelCost.TabIndex = 5
        Me.txtFuelCost.Text = "4.50"
        '
        'txtRes
        '
        Me.txtRes.AcceptsReturn = True
        Me.txtRes.BackColor = System.Drawing.SystemColors.Window
        Me.txtRes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRes.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtRes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRes.Location = New System.Drawing.Point(116, 180)
        Me.txtRes.MaxLength = 0
        Me.txtRes.Name = "txtRes"
        Me.txtRes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRes.Size = New System.Drawing.Size(145, 23)
        Me.txtRes.TabIndex = 3
        Me.txtRes.Text = "3"
        '
        'txtEorW
        '
        Me.txtEorW.AcceptsReturn = True
        Me.txtEorW.BackColor = System.Drawing.SystemColors.Window
        Me.txtEorW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEorW.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtEorW.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEorW.Location = New System.Drawing.Point(116, 220)
        Me.txtEorW.MaxLength = 0
        Me.txtEorW.Name = "txtEorW"
        Me.txtEorW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEorW.Size = New System.Drawing.Size(145, 23)
        Me.txtEorW.TabIndex = 4
        Me.txtEorW.Text = "0"
        '
        'txtTotal
        '
        Me.txtTotal.AcceptsReturn = True
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotal.Location = New System.Drawing.Point(116, 140)
        Me.txtTotal.MaxLength = 0
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotal.Size = New System.Drawing.Size(145, 23)
        Me.txtTotal.TabIndex = 2
        '
        'cmbAC
        '
        Me.cmbAC.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAC.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbAC.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbAC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAC.Location = New System.Drawing.Point(116, 100)
        Me.cmbAC.Name = "cmbAC"
        Me.cmbAC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbAC.Size = New System.Drawing.Size(145, 24)
        Me.cmbAC.TabIndex = 0
        '
        'txtAC
        '
        Me.txtAC.AcceptsReturn = True
        Me.txtAC.BackColor = System.Drawing.SystemColors.Window
        Me.txtAC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAC.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtAC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAC.Location = New System.Drawing.Point(116, 100)
        Me.txtAC.MaxLength = 50
        Me.txtAC.Name = "txtAC"
        Me.txtAC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAC.Size = New System.Drawing.Size(145, 23)
        Me.txtAC.TabIndex = 1
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Transparent
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(480, 495)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(97, 27)
        Me.cmdExit.TabIndex = 66
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(184, 495)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrint.Size = New System.Drawing.Size(113, 27)
        Me.cmdPrint.TabIndex = 64
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSubTitle.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.Color.White
        Me.lblSubTitle.Location = New System.Drawing.Point(152, 48)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSubTitle.Size = New System.Drawing.Size(521, 33)
        Me.lblSubTitle.TabIndex = 63
        Me.lblSubTitle.Text = "Bid Calculations"
        Me.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(130, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(521, 41)
        Me.lblTitle.TabIndex = 62
        Me.lblTitle.Text = "INTERNATIONAL AIRCRAFT DELIVERY"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMarkupDec
        '
        Me.lblMarkupDec.BackColor = System.Drawing.Color.Transparent
        Me.lblMarkupDec.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMarkupDec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarkupDec.ForeColor = System.Drawing.Color.White
        Me.lblMarkupDec.Location = New System.Drawing.Point(484, 390)
        Me.lblMarkupDec.Name = "lblMarkupDec"
        Me.lblMarkupDec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMarkupDec.Size = New System.Drawing.Size(141, 25)
        Me.lblMarkupDec.TabIndex = 61
        Me.lblMarkupDec.Text = "Markup in Decimal:"
        Me.lblMarkupDec.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRadioCosts
        '
        Me.lblRadioCosts.BackColor = System.Drawing.Color.Transparent
        Me.lblRadioCosts.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRadioCosts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadioCosts.ForeColor = System.Drawing.Color.White
        Me.lblRadioCosts.Location = New System.Drawing.Point(528, 149)
        Me.lblRadioCosts.Name = "lblRadioCosts"
        Me.lblRadioCosts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRadioCosts.Size = New System.Drawing.Size(97, 17)
        Me.lblRadioCosts.TabIndex = 60
        Me.lblRadioCosts.Text = "Radio Costs:"
        Me.lblRadioCosts.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTankingCosts
        '
        Me.lblTankingCosts.BackColor = System.Drawing.Color.Transparent
        Me.lblTankingCosts.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTankingCosts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTankingCosts.ForeColor = System.Drawing.Color.White
        Me.lblTankingCosts.Location = New System.Drawing.Point(496, 109)
        Me.lblTankingCosts.Name = "lblTankingCosts"
        Me.lblTankingCosts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTankingCosts.Size = New System.Drawing.Size(129, 17)
        Me.lblTankingCosts.TabIndex = 59
        Me.lblTankingCosts.Text = "Tanking Costs:"
        Me.lblTankingCosts.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInsurance
        '
        Me.lblInsurance.BackColor = System.Drawing.Color.Transparent
        Me.lblInsurance.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInsurance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurance.ForeColor = System.Drawing.Color.White
        Me.lblInsurance.Location = New System.Drawing.Point(537, 349)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsurance.Size = New System.Drawing.Size(88, 25)
        Me.lblInsurance.TabIndex = 56
        Me.lblInsurance.Text = "Insurance:"
        Me.lblInsurance.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(19, 345)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(90, 33)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Fuel Cost:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEmergencyEquip
        '
        Me.lblEmergencyEquip.BackColor = System.Drawing.Color.Transparent
        Me.lblEmergencyEquip.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmergencyEquip.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmergencyEquip.ForeColor = System.Drawing.Color.White
        Me.lblEmergencyEquip.Location = New System.Drawing.Point(488, 309)
        Me.lblEmergencyEquip.Name = "lblEmergencyEquip"
        Me.lblEmergencyEquip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmergencyEquip.Size = New System.Drawing.Size(137, 17)
        Me.lblEmergencyEquip.TabIndex = 49
        Me.lblEmergencyEquip.Text = "Emergency Equip:"
        Me.lblEmergencyEquip.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCustomerCommision
        '
        Me.lblCustomerCommision.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerCommision.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustomerCommision.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerCommision.ForeColor = System.Drawing.Color.White
        Me.lblCustomerCommision.Location = New System.Drawing.Point(515, 268)
        Me.lblCustomerCommision.Name = "lblCustomerCommision"
        Me.lblCustomerCommision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustomerCommision.Size = New System.Drawing.Size(110, 40)
        Me.lblCustomerCommision.TabIndex = 48
        Me.lblCustomerCommision.Text = "Commissions:"
        Me.lblCustomerCommision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCustomsCosts
        '
        Me.lblCustomsCosts.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomsCosts.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCustomsCosts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomsCosts.ForeColor = System.Drawing.Color.White
        Me.lblCustomsCosts.Location = New System.Drawing.Point(512, 230)
        Me.lblCustomsCosts.Name = "lblCustomsCosts"
        Me.lblCustomsCosts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCustomsCosts.Size = New System.Drawing.Size(113, 17)
        Me.lblCustomsCosts.TabIndex = 47
        Me.lblCustomsCosts.Text = "Customs Costs:"
        Me.lblCustomsCosts.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLandingCosts
        '
        Me.lblLandingCosts.BackColor = System.Drawing.Color.Transparent
        Me.lblLandingCosts.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLandingCosts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLandingCosts.ForeColor = System.Drawing.Color.White
        Me.lblLandingCosts.Location = New System.Drawing.Point(512, 190)
        Me.lblLandingCosts.Name = "lblLandingCosts"
        Me.lblLandingCosts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLandingCosts.Size = New System.Drawing.Size(113, 25)
        Me.lblLandingCosts.TabIndex = 46
        Me.lblLandingCosts.Text = "Landing Costs:"
        Me.lblLandingCosts.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblReturnFares
        '
        Me.lblReturnFares.BackColor = System.Drawing.Color.Transparent
        Me.lblReturnFares.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblReturnFares.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnFares.ForeColor = System.Drawing.Color.White
        Me.lblReturnFares.Location = New System.Drawing.Point(277, 206)
        Me.lblReturnFares.Name = "lblReturnFares"
        Me.lblReturnFares.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblReturnFares.Size = New System.Drawing.Size(105, 50)
        Me.lblReturnFares.TabIndex = 45
        Me.lblReturnFares.Text = "Return Trip Airline Fares:"
        Me.lblReturnFares.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCrewPerDiemCosts
        '
        Me.lblCrewPerDiemCosts.BackColor = System.Drawing.Color.Transparent
        Me.lblCrewPerDiemCosts.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCrewPerDiemCosts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrewPerDiemCosts.ForeColor = System.Drawing.Color.White
        Me.lblCrewPerDiemCosts.Location = New System.Drawing.Point(280, 317)
        Me.lblCrewPerDiemCosts.Name = "lblCrewPerDiemCosts"
        Me.lblCrewPerDiemCosts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCrewPerDiemCosts.Size = New System.Drawing.Size(102, 44)
        Me.lblCrewPerDiemCosts.TabIndex = 44
        Me.lblCrewPerDiemCosts.Text = "Crew Per Diem Costs:"
        Me.lblCrewPerDiemCosts.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCrewSalaries
        '
        Me.lblCrewSalaries.BackColor = System.Drawing.Color.Transparent
        Me.lblCrewSalaries.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCrewSalaries.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrewSalaries.ForeColor = System.Drawing.Color.White
        Me.lblCrewSalaries.Location = New System.Drawing.Point(269, 109)
        Me.lblCrewSalaries.Name = "lblCrewSalaries"
        Me.lblCrewSalaries.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCrewSalaries.Size = New System.Drawing.Size(113, 25)
        Me.lblCrewSalaries.TabIndex = 43
        Me.lblCrewSalaries.Text = "Crew Salaries:"
        Me.lblCrewSalaries.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPerDiemDays
        '
        Me.lblPerDiemDays.BackColor = System.Drawing.Color.Transparent
        Me.lblPerDiemDays.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPerDiemDays.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerDiemDays.ForeColor = System.Drawing.Color.White
        Me.lblPerDiemDays.Location = New System.Drawing.Point(0, 425)
        Me.lblPerDiemDays.Name = "lblPerDiemDays"
        Me.lblPerDiemDays.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPerDiemDays.Size = New System.Drawing.Size(109, 41)
        Me.lblPerDiemDays.TabIndex = 42
        Me.lblPerDiemDays.Text = "Per Diem Days:"
        Me.lblPerDiemDays.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPerDiemRate
        '
        Me.lblPerDiemRate.BackColor = System.Drawing.Color.Transparent
        Me.lblPerDiemRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPerDiemRate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerDiemRate.ForeColor = System.Drawing.Color.White
        Me.lblPerDiemRate.Location = New System.Drawing.Point(3, 384)
        Me.lblPerDiemRate.Name = "lblPerDiemRate"
        Me.lblPerDiemRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPerDiemRate.Size = New System.Drawing.Size(106, 41)
        Me.lblPerDiemRate.TabIndex = 41
        Me.lblPerDiemRate.Text = "Per Diem Rate:"
        Me.lblPerDiemRate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(28, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(81, 41)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Total Fuel Required:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAvgFuelCost
        '
        Me.lblAvgFuelCost.BackColor = System.Drawing.Color.Transparent
        Me.lblAvgFuelCost.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAvgFuelCost.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgFuelCost.ForeColor = System.Drawing.Color.White
        Me.lblAvgFuelCost.Location = New System.Drawing.Point(0, 250)
        Me.lblAvgFuelCost.Name = "lblAvgFuelCost"
        Me.lblAvgFuelCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAvgFuelCost.Size = New System.Drawing.Size(109, 41)
        Me.lblAvgFuelCost.TabIndex = 39
        Me.lblAvgFuelCost.Text = "Avg Fuel Cost Per Gal:"
        Me.lblAvgFuelCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblResFltDays
        '
        Me.lblResFltDays.BackColor = System.Drawing.Color.Transparent
        Me.lblResFltDays.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblResFltDays.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResFltDays.ForeColor = System.Drawing.Color.White
        Me.lblResFltDays.Location = New System.Drawing.Point(0, 183)
        Me.lblResFltDays.Name = "lblResFltDays"
        Me.lblResFltDays.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblResFltDays.Size = New System.Drawing.Size(109, 21)
        Me.lblResFltDays.TabIndex = 37
        Me.lblResFltDays.Text = "Res Flt Days:"
        Me.lblResFltDays.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEorW
        '
        Me.lblEorW.BackColor = System.Drawing.Color.Transparent
        Me.lblEorW.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEorW.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEorW.ForeColor = System.Drawing.Color.White
        Me.lblEorW.Location = New System.Drawing.Point(22, 206)
        Me.lblEorW.Name = "lblEorW"
        Me.lblEorW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEorW.Size = New System.Drawing.Size(87, 43)
        Me.lblEorW.TabIndex = 36
        Me.lblEorW.Text = "East or West in Decimal:"
        Me.lblEorW.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalMiles
        '
        Me.lblTotalMiles.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalMiles.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalMiles.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMiles.ForeColor = System.Drawing.Color.White
        Me.lblTotalMiles.Location = New System.Drawing.Point(16, 145)
        Me.lblTotalMiles.Name = "lblTotalMiles"
        Me.lblTotalMiles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalMiles.Size = New System.Drawing.Size(93, 41)
        Me.lblTotalMiles.TabIndex = 34
        Me.lblTotalMiles.Text = "Total Miles:"
        Me.lblTotalMiles.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblACModel
        '
        Me.lblACModel.BackColor = System.Drawing.Color.Transparent
        Me.lblACModel.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblACModel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblACModel.ForeColor = System.Drawing.Color.White
        Me.lblACModel.Location = New System.Drawing.Point(3, 107)
        Me.lblACModel.Name = "lblACModel"
        Me.lblACModel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblACModel.Size = New System.Drawing.Size(106, 28)
        Me.lblACModel.TabIndex = 31
        Me.lblACModel.Text = "Aircraft Model:"
        Me.lblACModel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'imgBtnBkgdBack
        '
        Me.imgBtnBkgdBack.BackgroundImage = CType(resources.GetObject("imgBtnBkgdBack.BackgroundImage"), System.Drawing.Image)
        Me.imgBtnBkgdBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgBtnBkgdBack.Location = New System.Drawing.Point(0, 489)
        Me.imgBtnBkgdBack.Name = "imgBtnBkgdBack"
        Me.imgBtnBkgdBack.Size = New System.Drawing.Size(775, 33)
        Me.imgBtnBkgdBack.TabIndex = 68
        Me.imgBtnBkgdBack.TabStop = False
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.Color.Transparent
        Me.cmdBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.ForeColor = System.Drawing.Color.White
        Me.cmdBack.Location = New System.Drawing.Point(333, 495)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBack.Size = New System.Drawing.Size(105, 27)
        Me.cmdBack.TabIndex = 65
        Me.cmdBack.Text = "&Back"
        Me.cmdBack.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInsured
        '
        Me.lblInsured.BackColor = System.Drawing.Color.Transparent
        Me.lblInsured.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInsured.Font = New System.Drawing.Font("Arial", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblInsured.ForeColor = System.Drawing.Color.DarkGray
        Me.lblInsured.Location = New System.Drawing.Point(542, 462)
        Me.lblInsured.Name = "lblInsured"
        Me.lblInsured.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsured.Size = New System.Drawing.Size(83, 17)
        Me.lblInsured.TabIndex = 78
        Me.lblInsured.Text = "Insured:"
        Me.lblInsured.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUninsured
        '
        Me.lblUninsured.BackColor = System.Drawing.Color.Transparent
        Me.lblUninsured.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUninsured.Font = New System.Drawing.Font("Arial", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblUninsured.ForeColor = System.Drawing.Color.DarkGray
        Me.lblUninsured.Location = New System.Drawing.Point(527, 433)
        Me.lblUninsured.Name = "lblUninsured"
        Me.lblUninsured.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUninsured.Size = New System.Drawing.Size(99, 17)
        Me.lblUninsured.TabIndex = 79
        Me.lblUninsured.Text = "Uninsured:"
        Me.lblUninsured.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBidTotals
        '
        Me.lblBidTotals.BackColor = System.Drawing.Color.Transparent
        Me.lblBidTotals.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBidTotals.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBidTotals.ForeColor = System.Drawing.Color.DarkGray
        Me.lblBidTotals.Location = New System.Drawing.Point(411, 440)
        Me.lblBidTotals.Name = "lblBidTotals"
        Me.lblBidTotals.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBidTotals.Size = New System.Drawing.Size(113, 25)
        Me.lblBidTotals.TabIndex = 75
        Me.lblBidTotals.Text = "Bid Totals:"
        Me.lblBidTotals.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUninsTotal
        '
        Me.txtUninsTotal.AcceptsReturn = True
        Me.txtUninsTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtUninsTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUninsTotal.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtUninsTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUninsTotal.Location = New System.Drawing.Point(632, 425)
        Me.txtUninsTotal.MaxLength = 0
        Me.txtUninsTotal.Name = "txtUninsTotal"
        Me.txtUninsTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUninsTotal.Size = New System.Drawing.Size(114, 24)
        Me.txtUninsTotal.TabIndex = 69
        '
        'txtCalc
        '
        Me.txtCalc.AcceptsReturn = True
        Me.txtCalc.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCalc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCalc.Location = New System.Drawing.Point(674, 424)
        Me.txtCalc.MaxLength = 0
        Me.txtCalc.Name = "txtCalc"
        Me.txtCalc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCalc.Size = New System.Drawing.Size(53, 20)
        Me.txtCalc.TabIndex = 74
        Me.txtCalc.Text = "1"
        Me.txtCalc.Visible = False
        '
        'txtGal
        '
        Me.txtGal.AcceptsReturn = True
        Me.txtGal.BackColor = System.Drawing.SystemColors.Window
        Me.txtGal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGal.Location = New System.Drawing.Point(654, 428)
        Me.txtGal.MaxLength = 0
        Me.txtGal.Name = "txtGal"
        Me.txtGal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGal.Size = New System.Drawing.Size(45, 20)
        Me.txtGal.TabIndex = 72
        Me.txtGal.Text = "0"
        Me.txtGal.Visible = False
        '
        'txtSpeed
        '
        Me.txtSpeed.AcceptsReturn = True
        Me.txtSpeed.BackColor = System.Drawing.SystemColors.Window
        Me.txtSpeed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSpeed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpeed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSpeed.Location = New System.Drawing.Point(667, 427)
        Me.txtSpeed.MaxLength = 0
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSpeed.Size = New System.Drawing.Size(49, 20)
        Me.txtSpeed.TabIndex = 71
        Me.txtSpeed.Text = "1"
        Me.txtSpeed.Visible = False
        '
        'txtInsTotal
        '
        Me.txtInsTotal.AcceptsReturn = True
        Me.txtInsTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtInsTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInsTotal.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtInsTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInsTotal.Location = New System.Drawing.Point(632, 455)
        Me.txtInsTotal.MaxLength = 0
        Me.txtInsTotal.Name = "txtInsTotal"
        Me.txtInsTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInsTotal.Size = New System.Drawing.Size(114, 24)
        Me.txtInsTotal.TabIndex = 70
        '
        'txtOrig
        '
        Me.txtOrig.AcceptsReturn = True
        Me.txtOrig.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrig.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrig.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrig.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrig.Location = New System.Drawing.Point(670, 424)
        Me.txtOrig.MaxLength = 50
        Me.txtOrig.Name = "txtOrig"
        Me.txtOrig.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrig.Size = New System.Drawing.Size(60, 20)
        Me.txtOrig.TabIndex = 77
        Me.txtOrig.TabStop = False
        Me.txtOrig.Visible = False
        '
        'txtDest
        '
        Me.txtDest.AcceptsReturn = True
        Me.txtDest.BackColor = System.Drawing.SystemColors.Window
        Me.txtDest.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDest.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDest.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDest.Location = New System.Drawing.Point(667, 424)
        Me.txtDest.MaxLength = 0
        Me.txtDest.Name = "txtDest"
        Me.txtDest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDest.Size = New System.Drawing.Size(63, 20)
        Me.txtDest.TabIndex = 76
        Me.txtDest.Visible = False
        '
        'txtFuel
        '
        Me.txtFuel.AcceptsReturn = True
        Me.txtFuel.BackColor = System.Drawing.SystemColors.Window
        Me.txtFuel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFuel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFuel.Location = New System.Drawing.Point(667, 427)
        Me.txtFuel.MaxLength = 0
        Me.txtFuel.Name = "txtFuel"
        Me.txtFuel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFuel.Size = New System.Drawing.Size(53, 20)
        Me.txtFuel.TabIndex = 73
        Me.txtFuel.Visible = False
        '
        'imgBtnBkgd
        '
        Me.imgBtnBkgd.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgBtnBkgd.Image = CType(resources.GetObject("imgBtnBkgd.Image"), System.Drawing.Image)
        Me.imgBtnBkgd.Location = New System.Drawing.Point(0, 489)
        Me.imgBtnBkgd.Name = "imgBtnBkgd"
        Me.imgBtnBkgd.Size = New System.Drawing.Size(775, 33)
        Me.imgBtnBkgd.TabIndex = 67
        Me.imgBtnBkgd.TabStop = False
        '
        'frmBidCalc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(775, 519)
        Me.Controls.Add(Me.lblInsured)
        Me.Controls.Add(Me.lblUninsured)
        Me.Controls.Add(Me.lblBidTotals)
        Me.Controls.Add(Me.txtUninsTotal)
        Me.Controls.Add(Me.txtCalc)
        Me.Controls.Add(Me.txtGal)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.txtInsTotal)
        Me.Controls.Add(Me.txtOrig)
        Me.Controls.Add(Me.txtDest)
        Me.Controls.Add(Me.txtFuel)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.txtMU)
        Me.Controls.Add(Me.txtRadio)
        Me.Controls.Add(Me.txtTank)
        Me.Controls.Add(Me.txtInsurance)
        Me.Controls.Add(Me.txtTotalFuelCost)
        Me.Controls.Add(Me.txtER)
        Me.Controls.Add(Me.txtCommisions)
        Me.Controls.Add(Me.txtCustoms)
        Me.Controls.Add(Me.txtLanding)
        Me.Controls.Add(Me.txtAF3)
        Me.Controls.Add(Me.txtAF2)
        Me.Controls.Add(Me.txtAF1)
        Me.Controls.Add(Me.txtCrewPD3)
        Me.Controls.Add(Me.txtCrewPD2)
        Me.Controls.Add(Me.txtPerDiemCost)
        Me.Controls.Add(Me.txtCrew3)
        Me.Controls.Add(Me.txtCrew2)
        Me.Controls.Add(Me.txtCrew1)
        Me.Controls.Add(Me.txtDaysAway)
        Me.Controls.Add(Me.txtPerDiem)
        Me.Controls.Add(Me.txtTotalFuel)
        Me.Controls.Add(Me.txtFuelCost)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.txtEorW)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblMarkupDec)
        Me.Controls.Add(Me.lblRadioCosts)
        Me.Controls.Add(Me.lblTankingCosts)
        Me.Controls.Add(Me.lblInsurance)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblEmergencyEquip)
        Me.Controls.Add(Me.lblCustomerCommision)
        Me.Controls.Add(Me.lblCustomsCosts)
        Me.Controls.Add(Me.lblLandingCosts)
        Me.Controls.Add(Me.lblReturnFares)
        Me.Controls.Add(Me.lblCrewPerDiemCosts)
        Me.Controls.Add(Me.lblCrewSalaries)
        Me.Controls.Add(Me.lblPerDiemDays)
        Me.Controls.Add(Me.lblPerDiemRate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblAvgFuelCost)
        Me.Controls.Add(Me.lblResFltDays)
        Me.Controls.Add(Me.lblEorW)
        Me.Controls.Add(Me.lblTotalMiles)
        Me.Controls.Add(Me.lblACModel)
        Me.Controls.Add(Me.imgBtnBkgd)
        Me.Controls.Add(Me.imgBtnBkgdBack)
        Me.Controls.Add(Me.cmbAC)
        Me.Controls.Add(Me.txtAC)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmBidCalc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bid Calculations"
        CType(Me.imgBtnBkgdBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBtnBkgd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As frmBidCalc
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmBidCalc
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmBidCalc()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Dim ctlCurrent As System.Windows.Forms.Control
    Dim intTAS, intDist, intEorW As Double
    Dim intPerHr, intRes, intAvgCost As Double
    Dim intCS2, intTotalFuel, intCS1, intCS3 As Double
    Dim intPD2, intPD1, intPD3 As Double
    Dim intAF3, intAF1, intAF2, intFC As Double
    Dim intCCost, intLCost, intCComm As Double
    Dim intMU1, intBid, intEE, intMU, intMU2 As Double
    Dim strMU As String
    Dim intInsurance As Short
    Dim intRadio, intTank As Short

    Private Sub cmdBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBack.Click
        frmMileageCalc.DefInstance.Show()
        DefInstance.Hide()
    End Sub

    <Obsolete>
    Private Sub cmdBack_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdBack.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

        imgBtnBkgdBack.Visible = True
        imgBtnBkgd.Visible = False

    End Sub

    <Obsolete>
    Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
        End
    End Sub

    <Obsolete>
    Private Sub cmdExit_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdExit.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

        imgBtnBkgdBack.Visible = False
        imgBtnBkgd.Visible = True

    End Sub

    <Obsolete>
    Private Sub cmdPrint_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdPrint.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

        imgBtnBkgdBack.Visible = False
        imgBtnBkgd.Visible = True

    End Sub

    'UPGRADE_WARNING: Form event frmBidCalc.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
    <Obsolete>
    Private Sub frmBidCalc_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated

        If frmMileageCalc.DefInstance.cmbICAO.Text = "ASSY" Then
            txtOrig.Text = "Sidney"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "AYPY" Then
            txtOrig.Text = "Port Moresby, PNG"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "BGBW" Then
            txtOrig.Text = "Narsarsuaq"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "BGGH" Then
            txtOrig.Text = "Godthab"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "BIRK" Then
            txtOrig.Text = "Reykjavik"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "CYAM" Then
            txtOrig.Text = "Sault Ste. Marie"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "CYFB" Then
            txtOrig.Text = "Iqaluit"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "CYQX" Then
            txtOrig.Text = "Gander"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "CYYQ" Then
            txtOrig.Text = "Churchill Falls"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "CYYR" Then
            txtOrig.Text = "Goose Bay"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "CYYT" Then
            txtOrig.Text = "St John's, NFLD"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "DAAG" Then
            txtOrig.Text = "Algiers, Algeria"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "DIAP" Then
            txtOrig.Text = "Abidjan"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "DNMM" Then
            txtOrig.Text = "Lagos, Nigeria"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "DRRN" Then
            txtOrig.Text = "Niami, Niger"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "EBBR" Then
            txtOrig.Text = "Brussels"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "EDDW" Then
            txtOrig.Text = "Bremen, Germany"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "EFHK" Then
            txtOrig.Text = "Helsinki, Finland"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "EGPD" Then
            txtOrig.Text = "Aberdeen"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "EGPK" Then
            txtOrig.Text = "Prestwick"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "EHBK" Then
            txtOrig.Text = "Maastricht, Netherlands"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "EINN" Then
            txtOrig.Text = "Shannon"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "EKCH" Then
            txtOrig.Text = "Copenhagen"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "ELLX" Then
            txtOrig.Text = "Luxembourg"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "ENBR" Then
            txtOrig.Text = "Bergen, Norway"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FAGM" Then
            txtOrig.Text = "Rand"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FALA" Then
            txtOrig.Text = "Lanseria, RSA"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FAWM" Then
            txtOrig.Text = "Windhoek"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FCBB" Then
            txtOrig.Text = "Brazzaville, Congo"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FEFF" Then
            txtOrig.Text = "Bangui, CAE"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FMMI" Then
            txtOrig.Text = "Antananarivo, Madagascar"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FNLU" Then
            txtOrig.Text = "Luanda"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FOOL" Then
            txtOrig.Text = "Libreville"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FSIA" Then
            txtOrig.Text = "Seychelles Intl"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FVHA" Then
            txtOrig.Text = "Harare, Zimbabwe"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "FZNA" Then
            txtOrig.Text = "Goma, Zaire"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "GBYD" Then
            txtOrig.Text = "Banjul"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "GCXO" Then
            txtOrig.Text = "Tenerife"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "GMAA" Then
            txtOrig.Text = "Agadir"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "GOOY" Then
            txtOrig.Text = "Dakar"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "HELX" Then
            txtOrig.Text = "Luxor"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "HKNW" Then
            txtOrig.Text = "Nairobi-Wilson"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "HSSS" Then
            txtOrig.Text = "Khartoum"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "HTDA" Then
            txtOrig.Text = "Dar-Es-Salaam"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "I69" Then
            txtOrig.Text = "Batavia, OH"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KANC" Then
            txtOrig.Text = "Anchorage"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KBGR" Then
            txtOrig.Text = "Bangor"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KBOI" Then
            txtOrig.Text = "Boise"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KCAE" Then
            txtOrig.Text = "Columbia, SC"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KICT" Then
            txtOrig.Text = "Wichita, KS"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KIDP" Then
            txtOrig.Text = "Independence, KS"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KJNU" Then
            txtOrig.Text = "Juneau, AK"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KMIA" Then
            txtOrig.Text = "Miami, FL"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KMSP" Then
            txtOrig.Text = "Minneapolis, MN"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KNUD" Then
            txtOrig.Text = "ADAK, AK"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KOAK" Then
            txtOrig.Text = "Oakland, CA"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KPDK" Then
            txtOrig.Text = "Atlanta, GA"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "KVRB" Then
            txtOrig.Text = "Vero Beach"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LCPH" Then
            txtOrig.Text = "Larnaca, Cyprus"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LEMD" Then
            txtOrig.Text = "Madrid"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LEMG" Then
            txtOrig.Text = "Malaga"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LFPN" Then
            txtOrig.Text = "Toussus Le Noble"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LGAT" Then
            txtOrig.Text = "Athens"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LGIR" Then
            txtOrig.Text = "Iraklion"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LIRA" Then
            txtOrig.Text = "Rome"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LKPR" Then
            txtOrig.Text = "Prague, Czech"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LPAZ" Then
            txtOrig.Text = "Santa Maria"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LPPR" Then
            txtOrig.Text = "Porto, Portugal"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LROP" Then
            txtOrig.Text = "Bucharest, Romania"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LTAC" Then
            txtOrig.Text = "Ankara"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "LTBA" Then
            txtOrig.Text = "Istanbul, Turkey"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "MROC" Then
            txtOrig.Text = "San Jose, CR"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "NTSU" Then
            txtOrig.Text = "Pago Pago"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "NZAA" Then
            txtOrig.Text = "Auckland"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "OOMS" Then
            txtOrig.Text = "SEEB, Oman"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "OPKC" Then
            txtOrig.Text = "Karachi"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "PAOM" Then
            txtOrig.Text = "Nome, AK"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "PGSN" Then
            txtOrig.Text = "Saipan"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "PHNL" Then
            txtOrig.Text = "Honolulu, HI"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "PHTO" Then
            txtOrig.Text = "HILO"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "PKMJ" Then
            txtOrig.Text = "Majuro"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "PLCH" Then
            txtOrig.Text = "Christmas Island"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "PMDY" Then
            txtOrig.Text = "Midway"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "PTRO" Then
            txtOrig.Text = "Palau"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "PWAK" Then
            txtOrig.Text = "WAKE"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "RCTP" Then
            txtOrig.Text = "Chiang Kai Shek"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "RJCK" Then
            txtOrig.Text = "Kushiro"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "RJTT" Then
            txtOrig.Text = "Tokyo"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "RKSS" Then
            txtOrig.Text = "Seoul, Korea"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "RPMM" Then
            txtOrig.Text = "Manilla"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "SAEZ" Then
            txtOrig.Text = "Ezeiza"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "SBEG" Then
            txtOrig.Text = "Manaus"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "SBGL" Then
            txtOrig.Text = "Rio De Janeiro, Brazil"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "SBSP" Then
            txtOrig.Text = "Sao Paulo"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "SCEL" Then
            txtOrig.Text = "Santiago, Chile"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "SVMG" Then
            txtOrig.Text = "Margarita, VE"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "TTPP" Then
            txtOrig.Text = "Picaro"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "UHHH" Then
            txtOrig.Text = "Khabarovsk, Russia"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "UHMM" Then
            txtOrig.Text = "Magadan, Russia"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "UHPP" Then
            txtOrig.Text = "Petropavlovsk, Russia"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "UHSS" Then
            txtOrig.Text = "Yuzhno, Russia"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "UTTT" Then
            txtOrig.Text = "Tashkent, Russia"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "UUEE" Then
            txtOrig.Text = "Moscow, Russia"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "VABB" Then
            txtOrig.Text = "Bombay"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "VCBI" Then
            txtOrig.Text = "Columbo, Sri Lanka"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "VIDP" Then
            txtOrig.Text = "Delhi"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "VNKT" Then
            txtOrig.Text = "Katmandu, Nepal"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "VOMM" Then
            txtOrig.Text = "Madras"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "VOPB" Then
            txtOrig.Text = "Port Blair, Nicobar"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "VRMM" Then
            txtOrig.Text = "Male, Maldives"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "VTBD" Then
            txtOrig.Text = "Bangkok"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "WMKJ" Then
            txtOrig.Text = "Johor Bahru, Malaysia"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "WMKK" Then
            txtOrig.Text = "Kuala Lumpur"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "WSSL" Then
            txtOrig.Text = "Singapore"
        ElseIf frmMileageCalc.DefInstance.cmbICAO.Text = "ZGGG" Then
            txtOrig.Text = "Guangzhou"
        Else
            txtOrig.Text = frmMileageCalc.DefInstance.txtOrig.Text
        End If

        If frmMileageCalc.DefInstance.txtPort1.Text = "" Then
            txtDest.Text = frmMileageCalc.DefInstance.txtPort.Text
        ElseIf frmMileageCalc.DefInstance.txtPort2.Text = "" Then
            txtDest.Text = frmMileageCalc.DefInstance.txtPort1.Text
        ElseIf frmMileageCalc.DefInstance.txtPort3.Text = "" Then
            txtDest.Text = frmMileageCalc.DefInstance.txtPort2.Text
        ElseIf frmMileageCalc.DefInstance.txtPort4.Text = "" Then
            txtDest.Text = frmMileageCalc.DefInstance.txtPort3.Text
        ElseIf frmMileageCalc.DefInstance.txtPort5.Text = "" Then
            txtDest.Text = frmMileageCalc.DefInstance.txtPort4.Text
        ElseIf frmMileageCalc.DefInstance.txtPort6.Text = "" Then
            txtDest.Text = frmMileageCalc.DefInstance.txtPort5.Text
        ElseIf frmMileageCalc.DefInstance.txtPort7.Text = "" Then
            txtDest.Text = frmMileageCalc.DefInstance.txtPort6.Text
        ElseIf frmMileageCalc.DefInstance.txtPort7.Text <> "" Then
            txtDest.Text = frmMileageCalc.DefInstance.txtPort7.Text
        End If

        If frmMileageCalc.DefInstance.txtTotal1.Text = "" Then
            txtTotal.Text = frmMileageCalc.DefInstance.txtTotal.Text
        ElseIf frmMileageCalc.DefInstance.txtTotal2.Text = "" Then
            txtTotal.Text = frmMileageCalc.DefInstance.txtTotal1.Text
        ElseIf frmMileageCalc.DefInstance.txtTotal3.Text = "" Then
            txtTotal.Text = frmMileageCalc.DefInstance.txtTotal2.Text
        ElseIf frmMileageCalc.DefInstance.txtTotal4.Text = "" Then
            txtTotal.Text = frmMileageCalc.DefInstance.txtTotal3.Text
        ElseIf frmMileageCalc.DefInstance.txtTotal5.Text = "" Then
            txtTotal.Text = frmMileageCalc.DefInstance.txtTotal4.Text
        ElseIf frmMileageCalc.DefInstance.txtTotal6.Text = "" Then
            txtTotal.Text = frmMileageCalc.DefInstance.txtTotal5.Text
        ElseIf frmMileageCalc.DefInstance.txtTotal7.Text = "" Then
            txtTotal.Text = frmMileageCalc.DefInstance.txtTotal6.Text
        ElseIf frmMileageCalc.DefInstance.txtTotal7.Text <> "" Then
            txtTotal.Text = frmMileageCalc.DefInstance.txtTotal7.Text
        End If

        'strMU = InputBox("Enter Mileage Markup as Decimal", "Mileage Markup", ".15")
        'If strMU = "" Then
        '  intMU = 0
        'Else
        '   intMU = Val(strMU)
        'End If
        intMU = 0.15
        intDist = Val(txtTotal.Text)
        intMU2 = intDist * intMU
        intDist = intDist + intMU2
        txtTotal.Text = CStr(intDist)
        txtTotal.Text = VB6.Format(txtTotal.Text, "Fixed")

        Call CalcFuel()
        Call CalcBid()

    End Sub

    Private Sub frmBidCalc_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        cmbAC.Items.Add("B-200")
        cmbAC.Items.Add("BE-350")
        cmbAC.Items.Add("BE-400A")
        cmbAC.Items.Add("C-172")
        cmbAC.Items.Add("C-182")
        cmbAC.Items.Add("C-206")
        cmbAC.Items.Add("C-208")
        cmbAC.Items.Add("C-210")
        cmbAC.Items.Add("C-303")
        cmbAC.Items.Add("C-406")
        cmbAC.Items.Add("C-421")
        cmbAC.Items.Add("C-425")
        cmbAC.Items.Add("C-500")
        cmbAC.Items.Add("C-525")
        cmbAC.Items.Add("C-550")
        cmbAC.Items.Add("C-560")
        cmbAC.Items.Add("C-650")
        cmbAC.Items.Add("CE-560-XL")
        cmbAC.Items.Add("CE-750")
        cmbAC.Items.Add("CL-604")
        cmbAC.Items.Add("DHC-6")
        cmbAC.Items.Add("DHC-8-300")
        cmbAC.Items.Add("DO-228")
        cmbAC.Items.Add("DO-328")
        cmbAC.Items.Add("F-20")
        cmbAC.Items.Add("G-1")
        cmbAC.Items.Add("LR-25")
        cmbAC.Items.Add("LR-35")
        cmbAC.Items.Add("PA-28R-201T")
        cmbAC.Items.Add("PA-31-350")
        cmbAC.Items.Add("Other")

    End Sub

    'UPGRADE_WARNING: Event cmbAC.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
    <Obsolete>
    Private Sub cmbAC_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbAC.SelectedIndexChanged

        If cmbAC.Text = "B-200" Then
            txtFuel.Text = "600"
            txtSpeed.Text = "250"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "BE-350" Then
            txtFuel.Text = "400"
            txtSpeed.Text = "230"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "BE-400A" Then
            txtFuel.Text = "940"
            txtSpeed.Text = "399"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-172" Then
            txtFuel.Text = "54"
            txtSpeed.Text = "125"
            txtGal.Text = "6"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-182" Then
            txtFuel.Text = "69"
            txtSpeed.Text = "135"
            txtGal.Text = "6"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-206" Then
            txtFuel.Text = "82"
            txtSpeed.Text = "138"
            txtGal.Text = "6"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-208" Then
            txtFuel.Text = "300"
            txtSpeed.Text = "170"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-210" Then
            txtFuel.Text = "82"
            txtSpeed.Text = "162"
            txtGal.Text = "6"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-303" Then
            txtFuel.Text = "147"
            txtSpeed.Text = "170"
            txtGal.Text = "6"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-406" Then
            txtFuel.Text = "425"
            txtSpeed.Text = "176"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-421" Then
            txtFuel.Text = "300"
            txtSpeed.Text = "218"
            txtGal.Text = "6"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-425" Then
            txtFuel.Text = "350"
            txtSpeed.Text = "210"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-500" Then
            txtFuel.Text = "800"
            txtSpeed.Text = "310"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-525" Then
            txtFuel.Text = "675"
            txtSpeed.Text = "347"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-550" Then
            txtFuel.Text = "950"
            txtSpeed.Text = "350"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-560" Then
            txtFuel.Text = "900"
            txtSpeed.Text = "350"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "C-650" Then
            txtFuel.Text = "1223"
            txtSpeed.Text = "416"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "CE-560-XL" Then
            txtFuel.Text = "1143"
            txtSpeed.Text = "403"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "CE-750" Then
            txtFuel.Text = "1667"
            txtSpeed.Text = "463"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "CL-604" Then
            txtFuel.Text = "1840"
            txtSpeed.Text = "419"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "DHC-6" Then
            txtFuel.Text = "655"
            txtSpeed.Text = "182"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "DHC-8-300" Then
            txtFuel.Text = "1000"
            txtSpeed.Text = "248"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "DO-228" Then
            txtFuel.Text = "750"
            txtSpeed.Text = "220"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "DO-328" Then
            txtFuel.Text = "1350"
            txtSpeed.Text = "300"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "F-20" Then
            txtFuel.Text = "1685"
            txtSpeed.Text = "374"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "G-1" Then
            txtFuel.Text = "1650"
            txtSpeed.Text = "275"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "LR-25" Then
            txtFuel.Text = "1500"
            txtSpeed.Text = "400"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "LR-35" Then
            txtFuel.Text = "1000"
            txtSpeed.Text = "424"
            txtGal.Text = "6.7"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "PA-28R-201T" Then
            txtFuel.Text = "70"
            txtSpeed.Text = "140"
            txtGal.Text = "6"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "PA-31-350" Then
            txtFuel.Text = "185"
            txtSpeed.Text = "168"
            txtGal.Text = "6"
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
        ElseIf cmbAC.Text = "Other" Then
            cmbAC.Visible = False
            txtAC.Text = InputBox("Enter Aircraft Model.", "Other Aircraft")
            txtFuel.Text = InputBox("Enter Total Fuel in Pounds.", "Other Aircraft")
            txtSpeed.Text = InputBox("Enter Aircraft TAS.", "Other Aircraft")
            txtGal.Text = InputBox("Enter Fuel Calculation (AvGas = 6, Jet = 6.7). ", "Other Aircraft")
            txtCalc.Text = CStr(Val(txtFuel.Text) / Val(txtGal.Text))
            txtCalc.Text = VB6.Format(txtCalc.Text, "Fixed")
            '        frmOther.Show
            '        txtCalc.Text = Format(txtCalc.Text, "Fixed")
        End If

        If cmbAC.Text <> "Other" Then
            txtAC.Text = cmbAC.Text
        End If

        Call CalcFuel()
        Call CalcBid()
        txtEorW.Focus()

    End Sub

    'UPGRADE_WARNING: Form event frmBidCalc.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
    Private Sub frmBidCalc_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub txtAC_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAC.DoubleClick
        cmbAC.Text = ""
        cmbAC.Visible = True
    End Sub

    Private Sub txtAF1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAF1.Enter
        txtAF1.SelectionStart = 0
        txtAF1.SelectionLength = Len(txtAF1.Text)
    End Sub

    <Obsolete>
    Private Sub txtAF1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAF1.Leave
        txtAF1.Text = VB6.Format(txtAF1.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtAF2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAF2.Enter
        txtAF2.SelectionStart = 0
        txtAF2.SelectionLength = Len(txtAF2.Text)
    End Sub

    <Obsolete>
    Private Sub txtAF2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAF2.Leave
        txtAF2.Text = VB6.Format(txtAF2.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtAF3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAF3.Enter
        txtAF3.SelectionStart = 0
        txtAF3.SelectionLength = Len(txtAF3.Text)
    End Sub

    <Obsolete>
    Private Sub txtAF3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAF3.Leave
        txtAF3.Text = VB6.Format(txtAF3.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtUninsTotal_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        txtUninsTotal.SelectionStart = 0
        txtUninsTotal.SelectionLength = Len(txtUninsTotal.Text)
    End Sub

    Private Sub txtCalc_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        txtCalc.SelectionStart = 0
        txtCalc.SelectionLength = Len(txtCalc.Text)
    End Sub

    Private Sub txtCrew1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCrew1.Enter
        txtCrew1.SelectionStart = 0
        txtCrew1.SelectionLength = Len(txtCrew1.Text)
    End Sub

    <Obsolete>
    Private Sub txtCrew1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCrew1.Leave
        txtCrew1.Text = VB6.Format(txtCrew1.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtCrew2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCrew2.Enter
        txtCrew2.SelectionStart = 0
        txtCrew2.SelectionLength = Len(txtCrew2.Text)
    End Sub

    <Obsolete>
    Private Sub txtCrew2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCrew2.Leave
        txtCrew2.Text = VB6.Format(txtCrew2.Text, "Fixed")
        If txtCrew2.Text <> "0.00" Then
            txtCrewPD2.Text = txtPerDiemCost.Text
            txtAF2.Focus()
        End If
        Call CalcBid()
    End Sub

    Private Sub txtCrew3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCrew3.Enter
        txtCrew3.SelectionStart = 0
        txtCrew3.SelectionLength = Len(txtCrew3.Text)
    End Sub

    <Obsolete>
    Private Sub txtCrew3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCrew3.Leave
        txtCrew3.Text = VB6.Format(txtCrew3.Text, "Fixed")
        If txtCrew3.Text <> "0.00" Then
            txtCrewPD3.Text = txtPerDiemCost.Text
            txtAF3.Focus()
        End If
        Call CalcBid()
    End Sub

    Private Sub txtPerDiemCost_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPerDiemCost.Enter
        txtPerDiemCost.SelectionStart = 0
        txtPerDiemCost.SelectionLength = Len(txtPerDiemCost.Text)
    End Sub

    <Obsolete>
    Private Sub txtPerDiemCost_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPerDiemCost.Leave
        txtPerDiemCost.Text = VB6.Format(txtPerDiemCost.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtCrewPD2_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCrewPD2.Enter
        txtCrewPD2.SelectionStart = 0
        txtCrewPD2.SelectionLength = Len(txtCrewPD2.Text)
    End Sub

    <Obsolete>
    Private Sub txtCrewPD2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCrewPD2.Leave
        txtCrewPD2.Text = VB6.Format(txtCrewPD2.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtCrewPD3_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCrewPD3.Enter
        txtCrewPD3.SelectionStart = 0
        txtCrewPD3.SelectionLength = Len(txtCrewPD3.Text)
    End Sub

    <Obsolete>
    Private Sub txtCrewPD3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCrewPD3.Leave
        txtCrewPD3.Text = VB6.Format(txtCrewPD3.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtCommisions_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCommisions.Enter
        txtCommisions.SelectionStart = 0
        txtCommisions.SelectionLength = Len(txtCommisions.Text)
    End Sub

    <Obsolete>
    Private Sub txtCommisions_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCommisions.Leave
        txtCommisions.Text = VB6.Format(txtCommisions.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtCustoms_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCustoms.Enter
        txtCustoms.SelectionStart = 0
        txtCustoms.SelectionLength = Len(txtCustoms.Text)
    End Sub

    <Obsolete>
    Private Sub txtCustoms_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCustoms.Leave
        txtCustoms.Text = VB6.Format(txtCustoms.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtDaysAway_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDaysAway.Enter
        txtDaysAway.SelectionStart = 0
        txtDaysAway.SelectionLength = Len(txtDaysAway.Text)
    End Sub

    <Obsolete>
    Private Sub txtDaysAway_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDaysAway.Leave
        txtPerDiemCost.Text = CStr(Val(txtPerDiem.Text) * Val(txtDaysAway.Text))
        txtPerDiemCost.Text = VB6.Format(txtPerDiemCost.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtDest_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        txtDest.SelectionStart = 0
        txtDest.SelectionLength = Len(txtDest.Text)
    End Sub

    Private Sub txtEorW_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtEorW.Enter
        txtEorW.SelectionStart = 0
        txtEorW.SelectionLength = Len(txtEorW.Text)
    End Sub

    <Obsolete>
    Private Sub txtEorW_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtEorW.Leave
        Call CalcFuel()
        Call CalcBid()
    End Sub

    Private Sub txtER_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtER.Enter
        txtER.SelectionStart = 0
        txtER.SelectionLength = Len(txtER.Text)
    End Sub

    <Obsolete>
    Private Sub txtER_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtER.Leave
        txtER.Text = VB6.Format(txtER.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtFuel_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        txtFuel.SelectionStart = 0
        txtFuel.SelectionLength = Len(txtFuel.Text)
    End Sub

    <Obsolete>
    Private Sub txtFuel_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Call CalcBid()
    End Sub

    Private Sub txtFuelCost_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFuelCost.Enter
        txtFuelCost.SelectionStart = 0
        txtFuelCost.SelectionLength = Len(txtFuelCost.Text)
    End Sub

    <Obsolete>
    Private Sub txtFuelCost_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFuelCost.Leave
        Call CalcFuel()
        Call CalcBid()
        txtPerDiem.Focus()
    End Sub

    Private Sub txtGal_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        txtGal.SelectionStart = 0
        txtGal.SelectionLength = Len(txtGal.Text)
    End Sub

    <Obsolete>
    Private Sub txtGal_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Call CalcBid()
    End Sub

    Private Sub txtInsurance_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtInsurance.Enter
        txtInsurance.SelectionStart = 0
        txtInsurance.SelectionLength = Len(txtInsurance.Text)
    End Sub

    <Obsolete>
    Private Sub txtInsurance_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtInsurance.Leave
        txtInsurance.Text = VB6.Format(txtInsurance.Text, "Fixed")
        Call CalcIns()
        Call CalcBid()
    End Sub

    Private Sub txtLanding_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLanding.Enter
        txtLanding.SelectionStart = 0
        txtLanding.SelectionLength = Len(txtLanding.Text)
    End Sub

    <Obsolete>
    Private Sub txtLanding_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLanding.Leave
        txtLanding.Text = VB6.Format(txtLanding.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtMU_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMU.Enter
        txtMU.SelectionStart = 0
        txtMU.SelectionLength = Len(txtMU.Text)
    End Sub

    <Obsolete>
    Private Sub txtMU_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMU.Leave
        Call CalcBid()
    End Sub

    Private Sub txtOrig_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        txtOrig.SelectionStart = 0
        txtOrig.SelectionLength = Len(txtOrig.Text)
    End Sub

    Private Sub txtPerDiem_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPerDiem.Enter
        txtPerDiem.SelectionStart = 0
        txtPerDiem.SelectionLength = Len(txtPerDiem.Text)
    End Sub

    <Obsolete>
    Private Sub txtPerDiem_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPerDiem.Leave
        txtPerDiem.Text = VB6.Format(txtPerDiem.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtRadio_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRadio.Enter
        txtRadio.SelectionStart = 0
        txtRadio.SelectionLength = Len(txtRadio.Text)
    End Sub

    <Obsolete>
    Private Sub txtRadio_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRadio.Leave
        txtRadio.Text = VB6.Format(txtRadio.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtRes_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRes.Enter
        txtRes.SelectionStart = 0
        txtRes.SelectionLength = Len(txtRes.Text)
    End Sub

    <Obsolete>
    Private Sub txtRes_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtRes.Leave
        Call CalcFuel()
        Call CalcBid()
    End Sub

    Private Sub txtSpeed_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        txtSpeed.SelectionStart = 0
        txtSpeed.SelectionLength = Len(txtSpeed.Text)
    End Sub

    <Obsolete>
    Private Sub txtSpeed_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Call CalcBid()
    End Sub

    Private Sub txtTank_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTank.Enter
        txtTank.SelectionStart = 0
        txtTank.SelectionLength = Len(txtTank.Text)
    End Sub

    <Obsolete>
    Private Sub txtTank_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTank.Leave
        txtTank.Text = VB6.Format(txtTank.Text, "Fixed")
        Call CalcBid()
    End Sub

    Private Sub txtTotal_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTotal.Enter
        txtTotal.SelectionStart = 0
        txtTotal.SelectionLength = Len(txtTotal.Text)
    End Sub

    <Obsolete>
    Private Sub txtTotal_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTotal.Leave
        Call CalcBid()
    End Sub

    Private Sub txtTotalFuel_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTotalFuel.Enter
        txtTotalFuel.SelectionStart = 0
        txtTotalFuel.SelectionLength = Len(txtTotalFuel.Text)
    End Sub

    <Obsolete>
    Private Sub txtTotalFuel_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTotalFuel.Leave
        Call CalcBid()
    End Sub

    Private Sub txtTotalFuelCost_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTotalFuelCost.Enter
        txtTotalFuelCost.SelectionStart = 0
        txtTotalFuelCost.SelectionLength = Len(txtTotalFuelCost.Text)
    End Sub

    <Obsolete>
    Private Sub txtTotalFuelCost_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTotalFuelCost.Leave
        txtTotalFuelCost.Text = VB6.Format(txtTotalFuelCost.Text, "Fixed")
        Call CalcBid()
    End Sub

    <Obsolete>
    Private Sub CalcBid()

        txtUninsTotal.Text = ""
        intTotalFuel = CDbl(txtTotalFuel.Text)
        intAvgCost = CDbl(txtFuelCost.Text)
        txtTotalFuelCost.Text = CStr(intTotalFuel * intAvgCost)
        txtTotalFuelCost.Text = VB6.Format(txtTotalFuelCost.Text, "Fixed")
        intCS1 = CDbl(txtCrew1.Text)
        intCS2 = CDbl(txtCrew2.Text)
        intCS3 = CDbl(txtCrew3.Text)
        intPD1 = CDbl(txtPerDiemCost.Text)
        intPD2 = CDbl(txtCrewPD2.Text)
        intPD3 = CDbl(txtCrewPD3.Text)
        intAF1 = CDbl(txtAF1.Text)
        intAF2 = CDbl(txtAF2.Text)
        intAF3 = CDbl(txtAF3.Text)
        intInsurance = CShort(txtInsurance.Text)
        intFC = CDbl(txtTotalFuelCost.Text)
        intLCost = CDbl(txtLanding.Text)
        intCCost = CDbl(txtCustoms.Text)
        intCComm = CDbl(txtCommisions.Text)
        intEE = CDbl(txtER.Text)
        intRadio = CShort(txtRadio.Text)
        intTank = CShort(txtTank.Text)
        intMU1 = CDbl(txtMU.Text)

        intBid = intCS1 + intCS2 + intCS3 + intPD1 + intPD2 + intPD3 + intAF1 + intAF2 + intAF3 + intFC + intLCost + intCCost + intCComm + intEE + intRadio + intTank
        intMU1 = intMU1 * intBid
        intBid = intBid + intMU1
        txtUninsTotal.Text = CStr(intBid)
        txtUninsTotal.Text = VB6.Format(txtUninsTotal.Text, "Fixed")
        If txtInsurance.Text <> "0.00" Then
            Call CalcIns()
        End If

    End Sub

    <Obsolete>
    Private Sub CalcFuel()

        intDist = Val(txtTotal.Text)
        intTAS = Val(txtSpeed.Text)
        intEorW = Val(txtEorW.Text)
        intRes = Val(txtRes.Text)
        intPerHr = Val(txtCalc.Text)
        txtTotalFuel.Text = CStr((intDist / (intTAS + intEorW) + intRes) * intPerHr)
        txtTotalFuel.Text = VB6.Format(txtTotalFuel.Text, "Fixed")
        txtFuelCost.Text = VB6.Format(txtFuelCost.Text, "Fixed")
        intTotalFuel = CDbl(txtTotalFuel.Text)
        intAvgCost = CDbl(txtFuelCost.Text)
        txtTotalFuelCost.Text = CStr(intTotalFuel * intAvgCost)
        txtTotalFuelCost.Text = VB6.Format(txtTotalFuelCost.Text, "Fixed")

    End Sub

    <Obsolete>
    Private Sub CalcIns()

        intInsurance = CShort(txtInsurance.Text)
        txtInsTotal.Text = CStr(intBid + intInsurance)
        txtInsTotal.Text = VB6.Format(txtInsTotal.Text, "Fixed")
        txtInsurance.Text = CStr(intInsurance)
        txtInsurance.Text = VB6.Format(txtInsurance.Text, "Fixed")

    End Sub
End Class