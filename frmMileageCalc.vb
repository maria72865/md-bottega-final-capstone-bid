Option Strict Off
Option Explicit On
Friend Class frmMileageCalc
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
	Public WithEvents txtEW As System.Windows.Forms.TextBox
	Public WithEvents txtNS As System.Windows.Forms.TextBox
	Public WithEvents txtRad As System.Windows.Forms.TextBox
	Public WithEvents txtCos3 As System.Windows.Forms.TextBox
	Public WithEvents txtCos2 As System.Windows.Forms.TextBox
	Public WithEvents txtCos1 As System.Windows.Forms.TextBox
	Public WithEvents txtSin2 As System.Windows.Forms.TextBox
	Public WithEvents txtSin1 As System.Windows.Forms.TextBox
	Public WithEvents txtLongRad1 As System.Windows.Forms.TextBox
	Public WithEvents txtLatDeg As System.Windows.Forms.TextBox
	Public WithEvents txtLatMin As System.Windows.Forms.TextBox
	Public WithEvents txtLatSec As System.Windows.Forms.TextBox
	Public WithEvents txtLongDeg As System.Windows.Forms.TextBox
	Public WithEvents txtLongMin As System.Windows.Forms.TextBox
	Public WithEvents txtLongSec As System.Windows.Forms.TextBox
	Public WithEvents txtLatRad1 As System.Windows.Forms.TextBox
	Public WithEvents txtTotal7 As System.Windows.Forms.TextBox
	Public WithEvents txtTotal6 As System.Windows.Forms.TextBox
	Public WithEvents txtTotal5 As System.Windows.Forms.TextBox
	Public WithEvents txtTotal4 As System.Windows.Forms.TextBox
	Public WithEvents txtTotal3 As System.Windows.Forms.TextBox
	Public WithEvents txtTotal2 As System.Windows.Forms.TextBox
	Public WithEvents txtTotal1 As System.Windows.Forms.TextBox
	Public WithEvents txtTotal As System.Windows.Forms.TextBox
	Public WithEvents txtLeg7 As System.Windows.Forms.TextBox
	Public WithEvents txtLeg6 As System.Windows.Forms.TextBox
	Public WithEvents txtLeg5 As System.Windows.Forms.TextBox
	Public WithEvents txtLeg4 As System.Windows.Forms.TextBox
	Public WithEvents txtLeg3 As System.Windows.Forms.TextBox
	Public WithEvents txtLeg2 As System.Windows.Forms.TextBox
	Public WithEvents txtLeg1 As System.Windows.Forms.TextBox
	Public WithEvents txtLeg As System.Windows.Forms.TextBox
	Public WithEvents txtPort1 As System.Windows.Forms.TextBox
	Public WithEvents txtPort7 As System.Windows.Forms.TextBox
	Public WithEvents txtPort6 As System.Windows.Forms.TextBox
	Public WithEvents txtPort5 As System.Windows.Forms.TextBox
	Public WithEvents txtPort4 As System.Windows.Forms.TextBox
	Public WithEvents txtPort3 As System.Windows.Forms.TextBox
	Public WithEvents txtPort2 As System.Windows.Forms.TextBox
	Public WithEvents cmbICAO15 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO14 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO12 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO13 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO10 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO11 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO8 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO9 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO6 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO7 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO4 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO5 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO3 As System.Windows.Forms.ComboBox
	Public WithEvents cmbICAO2 As System.Windows.Forms.ComboBox
	Public WithEvents txtICAO15 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO14 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO12 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO13 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO11 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO10 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO9 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO8 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO7 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO6 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO5 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO4 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO2 As System.Windows.Forms.TextBox
	Public WithEvents txtICAO3 As System.Windows.Forms.TextBox
	Public WithEvents txtNS14 As System.Windows.Forms.TextBox
	Public WithEvents txtLongRad As System.Windows.Forms.TextBox
	Public WithEvents txtLatRad As System.Windows.Forms.TextBox
	Public WithEvents txtNS15 As System.Windows.Forms.TextBox
	Public WithEvents txtLongDec As System.Windows.Forms.TextBox
	Public WithEvents txtLatDec As System.Windows.Forms.TextBox
	Public WithEvents txtPort As System.Windows.Forms.TextBox
	Public WithEvents txtDist As System.Windows.Forms.TextBox
	Public WithEvents Text7 As System.Windows.Forms.TextBox
	Public WithEvents Text6 As System.Windows.Forms.TextBox
	Public WithEvents Text5 As System.Windows.Forms.TextBox
	Public WithEvents Text4 As System.Windows.Forms.TextBox
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents cmbICAO1 As System.Windows.Forms.ComboBox
	Public WithEvents txtICAO1 As System.Windows.Forms.TextBox
	Public WithEvents cmbICAO As System.Windows.Forms.ComboBox
	Public WithEvents txtICAO As System.Windows.Forms.TextBox
	Public WithEvents txtOrig As System.Windows.Forms.TextBox
	Public WithEvents cmdNext As System.Windows.Forms.Label
	Public WithEvents cmdExit As System.Windows.Forms.Label
	Public WithEvents cmdBack As System.Windows.Forms.Label
	Public WithEvents cmdClear As System.Windows.Forms.Label
	Public WithEvents lblSubtitle As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents lblTotalMiles As System.Windows.Forms.Label
	Public WithEvents lblDist As System.Windows.Forms.Label
	Public WithEvents lblAirport As System.Windows.Forms.Label
	Public WithEvents lblToICAO As System.Windows.Forms.Label
	Public WithEvents lblFromICAO As System.Windows.Forms.Label
	Public WithEvents imgBtnClear As System.Windows.Forms.PictureBox
	Public WithEvents imgBtnBack As PictureBox
	Public WithEvents imgBtnBkgd As PictureBox
	Public WithEvents imgBkgd As PictureBox
	Public WithEvents imgBtnExit As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMileageCalc))
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtEW = New System.Windows.Forms.TextBox()
		Me.txtNS = New System.Windows.Forms.TextBox()
		Me.txtRad = New System.Windows.Forms.TextBox()
		Me.txtCos3 = New System.Windows.Forms.TextBox()
		Me.txtCos2 = New System.Windows.Forms.TextBox()
		Me.txtCos1 = New System.Windows.Forms.TextBox()
		Me.txtSin2 = New System.Windows.Forms.TextBox()
		Me.txtSin1 = New System.Windows.Forms.TextBox()
		Me.txtLongRad1 = New System.Windows.Forms.TextBox()
		Me.txtLatDeg = New System.Windows.Forms.TextBox()
		Me.txtLatMin = New System.Windows.Forms.TextBox()
		Me.txtLatSec = New System.Windows.Forms.TextBox()
		Me.txtLongDeg = New System.Windows.Forms.TextBox()
		Me.txtLongMin = New System.Windows.Forms.TextBox()
		Me.txtLongSec = New System.Windows.Forms.TextBox()
		Me.txtLatRad1 = New System.Windows.Forms.TextBox()
		Me.txtTotal7 = New System.Windows.Forms.TextBox()
		Me.txtTotal6 = New System.Windows.Forms.TextBox()
		Me.txtTotal5 = New System.Windows.Forms.TextBox()
		Me.txtTotal4 = New System.Windows.Forms.TextBox()
		Me.txtTotal3 = New System.Windows.Forms.TextBox()
		Me.txtTotal2 = New System.Windows.Forms.TextBox()
		Me.txtTotal1 = New System.Windows.Forms.TextBox()
		Me.txtTotal = New System.Windows.Forms.TextBox()
		Me.txtLeg7 = New System.Windows.Forms.TextBox()
		Me.txtLeg6 = New System.Windows.Forms.TextBox()
		Me.txtLeg5 = New System.Windows.Forms.TextBox()
		Me.txtLeg4 = New System.Windows.Forms.TextBox()
		Me.txtLeg3 = New System.Windows.Forms.TextBox()
		Me.txtLeg2 = New System.Windows.Forms.TextBox()
		Me.txtLeg1 = New System.Windows.Forms.TextBox()
		Me.txtLeg = New System.Windows.Forms.TextBox()
		Me.txtPort1 = New System.Windows.Forms.TextBox()
		Me.txtPort7 = New System.Windows.Forms.TextBox()
		Me.txtPort6 = New System.Windows.Forms.TextBox()
		Me.txtPort5 = New System.Windows.Forms.TextBox()
		Me.txtPort4 = New System.Windows.Forms.TextBox()
		Me.txtPort3 = New System.Windows.Forms.TextBox()
		Me.txtPort2 = New System.Windows.Forms.TextBox()
		Me.cmbICAO15 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO14 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO12 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO13 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO10 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO11 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO8 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO9 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO6 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO7 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO4 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO5 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO3 = New System.Windows.Forms.ComboBox()
		Me.cmbICAO2 = New System.Windows.Forms.ComboBox()
		Me.txtICAO15 = New System.Windows.Forms.TextBox()
		Me.txtICAO14 = New System.Windows.Forms.TextBox()
		Me.txtICAO12 = New System.Windows.Forms.TextBox()
		Me.txtICAO13 = New System.Windows.Forms.TextBox()
		Me.txtICAO11 = New System.Windows.Forms.TextBox()
		Me.txtICAO10 = New System.Windows.Forms.TextBox()
		Me.txtICAO9 = New System.Windows.Forms.TextBox()
		Me.txtICAO8 = New System.Windows.Forms.TextBox()
		Me.txtICAO7 = New System.Windows.Forms.TextBox()
		Me.txtICAO6 = New System.Windows.Forms.TextBox()
		Me.txtICAO5 = New System.Windows.Forms.TextBox()
		Me.txtICAO4 = New System.Windows.Forms.TextBox()
		Me.txtICAO2 = New System.Windows.Forms.TextBox()
		Me.txtICAO3 = New System.Windows.Forms.TextBox()
		Me.txtNS14 = New System.Windows.Forms.TextBox()
		Me.txtLongRad = New System.Windows.Forms.TextBox()
		Me.txtLatRad = New System.Windows.Forms.TextBox()
		Me.txtNS15 = New System.Windows.Forms.TextBox()
		Me.txtLongDec = New System.Windows.Forms.TextBox()
		Me.txtLatDec = New System.Windows.Forms.TextBox()
		Me.txtPort = New System.Windows.Forms.TextBox()
		Me.txtDist = New System.Windows.Forms.TextBox()
		Me.Text7 = New System.Windows.Forms.TextBox()
		Me.Text6 = New System.Windows.Forms.TextBox()
		Me.Text5 = New System.Windows.Forms.TextBox()
		Me.Text4 = New System.Windows.Forms.TextBox()
		Me.Text3 = New System.Windows.Forms.TextBox()
		Me.Text2 = New System.Windows.Forms.TextBox()
		Me.Text1 = New System.Windows.Forms.TextBox()
		Me.cmbICAO1 = New System.Windows.Forms.ComboBox()
		Me.txtICAO1 = New System.Windows.Forms.TextBox()
		Me.cmbICAO = New System.Windows.Forms.ComboBox()
		Me.txtICAO = New System.Windows.Forms.TextBox()
		Me.txtOrig = New System.Windows.Forms.TextBox()
		Me.cmdNext = New System.Windows.Forms.Label()
		Me.cmdExit = New System.Windows.Forms.Label()
		Me.cmdBack = New System.Windows.Forms.Label()
		Me.cmdClear = New System.Windows.Forms.Label()
		Me.lblSubtitle = New System.Windows.Forms.Label()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblTotalMiles = New System.Windows.Forms.Label()
		Me.lblDist = New System.Windows.Forms.Label()
		Me.lblAirport = New System.Windows.Forms.Label()
		Me.lblToICAO = New System.Windows.Forms.Label()
		Me.lblFromICAO = New System.Windows.Forms.Label()
		Me.imgBtnClear = New System.Windows.Forms.PictureBox()
		Me.imgBtnExit = New System.Windows.Forms.PictureBox()
		Me.imgBtnBack = New System.Windows.Forms.PictureBox()
		Me.imgBtnBkgd = New System.Windows.Forms.PictureBox()
		Me.imgBkgd = New System.Windows.Forms.PictureBox()
		CType(Me.imgBtnClear, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBtnBack, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBtnBkgd, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgBkgd, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtEW
		'
		Me.txtEW.AcceptsReturn = True
		Me.txtEW.BackColor = System.Drawing.SystemColors.Window
		Me.txtEW.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEW.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtEW.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEW.Location = New System.Drawing.Point(345, 152)
		Me.txtEW.MaxLength = 0
		Me.txtEW.Name = "txtEW"
		Me.txtEW.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEW.Size = New System.Drawing.Size(97, 23)
		Me.txtEW.TabIndex = 91
		Me.txtEW.Visible = False
		'
		'txtNS
		'
		Me.txtNS.AcceptsReturn = True
		Me.txtNS.BackColor = System.Drawing.SystemColors.Window
		Me.txtNS.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNS.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtNS.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNS.Location = New System.Drawing.Point(364, 152)
		Me.txtNS.MaxLength = 0
		Me.txtNS.Name = "txtNS"
		Me.txtNS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNS.Size = New System.Drawing.Size(97, 23)
		Me.txtNS.TabIndex = 90
		Me.txtNS.Visible = False
		'
		'txtRad
		'
		Me.txtRad.AcceptsReturn = True
		Me.txtRad.BackColor = System.Drawing.SystemColors.Window
		Me.txtRad.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRad.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtRad.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRad.Location = New System.Drawing.Point(373, 152)
		Me.txtRad.MaxLength = 0
		Me.txtRad.Name = "txtRad"
		Me.txtRad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRad.Size = New System.Drawing.Size(97, 23)
		Me.txtRad.TabIndex = 89
		Me.txtRad.Visible = False
		'
		'txtCos3
		'
		Me.txtCos3.AcceptsReturn = True
		Me.txtCos3.BackColor = System.Drawing.SystemColors.Window
		Me.txtCos3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCos3.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtCos3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCos3.Location = New System.Drawing.Point(373, 152)
		Me.txtCos3.MaxLength = 0
		Me.txtCos3.Name = "txtCos3"
		Me.txtCos3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCos3.Size = New System.Drawing.Size(97, 23)
		Me.txtCos3.TabIndex = 88
		Me.txtCos3.Text = "Text12"
		Me.txtCos3.Visible = False
		'
		'txtCos2
		'
		Me.txtCos2.AcceptsReturn = True
		Me.txtCos2.BackColor = System.Drawing.SystemColors.Window
		Me.txtCos2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCos2.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtCos2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCos2.Location = New System.Drawing.Point(373, 153)
		Me.txtCos2.MaxLength = 0
		Me.txtCos2.Name = "txtCos2"
		Me.txtCos2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCos2.Size = New System.Drawing.Size(97, 23)
		Me.txtCos2.TabIndex = 87
		Me.txtCos2.Text = "Text11"
		Me.txtCos2.Visible = False
		'
		'txtCos1
		'
		Me.txtCos1.AcceptsReturn = True
		Me.txtCos1.BackColor = System.Drawing.SystemColors.Window
		Me.txtCos1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCos1.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtCos1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCos1.Location = New System.Drawing.Point(373, 153)
		Me.txtCos1.MaxLength = 0
		Me.txtCos1.Name = "txtCos1"
		Me.txtCos1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtCos1.Size = New System.Drawing.Size(97, 23)
		Me.txtCos1.TabIndex = 86
		Me.txtCos1.Text = "Text10"
		Me.txtCos1.Visible = False
		'
		'txtSin2
		'
		Me.txtSin2.AcceptsReturn = True
		Me.txtSin2.BackColor = System.Drawing.SystemColors.Window
		Me.txtSin2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSin2.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtSin2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSin2.Location = New System.Drawing.Point(373, 152)
		Me.txtSin2.MaxLength = 0
		Me.txtSin2.Name = "txtSin2"
		Me.txtSin2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSin2.Size = New System.Drawing.Size(97, 23)
		Me.txtSin2.TabIndex = 85
		Me.txtSin2.Text = "Text9"
		Me.txtSin2.Visible = False
		'
		'txtSin1
		'
		Me.txtSin1.AcceptsReturn = True
		Me.txtSin1.BackColor = System.Drawing.SystemColors.Window
		Me.txtSin1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSin1.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtSin1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSin1.Location = New System.Drawing.Point(373, 154)
		Me.txtSin1.MaxLength = 0
		Me.txtSin1.Name = "txtSin1"
		Me.txtSin1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSin1.Size = New System.Drawing.Size(97, 23)
		Me.txtSin1.TabIndex = 84
		Me.txtSin1.Text = "Text8"
		Me.txtSin1.Visible = False
		'
		'txtLongRad1
		'
		Me.txtLongRad1.AcceptsReturn = True
		Me.txtLongRad1.BackColor = System.Drawing.SystemColors.Window
		Me.txtLongRad1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLongRad1.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLongRad1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLongRad1.Location = New System.Drawing.Point(381, 152)
		Me.txtLongRad1.MaxLength = 0
		Me.txtLongRad1.Name = "txtLongRad1"
		Me.txtLongRad1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLongRad1.Size = New System.Drawing.Size(89, 23)
		Me.txtLongRad1.TabIndex = 82
		Me.txtLongRad1.TabStop = False
		Me.txtLongRad1.Visible = False
		'
		'txtLatDeg
		'
		Me.txtLatDeg.AcceptsReturn = True
		Me.txtLatDeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtLatDeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLatDeg.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLatDeg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLatDeg.Location = New System.Drawing.Point(353, 152)
		Me.txtLatDeg.MaxLength = 0
		Me.txtLatDeg.Name = "txtLatDeg"
		Me.txtLatDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLatDeg.Size = New System.Drawing.Size(81, 23)
		Me.txtLatDeg.TabIndex = 81
		Me.txtLatDeg.Visible = False
		'
		'txtLatMin
		'
		Me.txtLatMin.AcceptsReturn = True
		Me.txtLatMin.BackColor = System.Drawing.SystemColors.Window
		Me.txtLatMin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLatMin.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLatMin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLatMin.Location = New System.Drawing.Point(345, 152)
		Me.txtLatMin.MaxLength = 0
		Me.txtLatMin.Name = "txtLatMin"
		Me.txtLatMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLatMin.Size = New System.Drawing.Size(81, 23)
		Me.txtLatMin.TabIndex = 80
		Me.txtLatMin.Visible = False
		'
		'txtLatSec
		'
		Me.txtLatSec.AcceptsReturn = True
		Me.txtLatSec.BackColor = System.Drawing.SystemColors.Window
		Me.txtLatSec.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLatSec.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLatSec.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLatSec.Location = New System.Drawing.Point(345, 152)
		Me.txtLatSec.MaxLength = 0
		Me.txtLatSec.Name = "txtLatSec"
		Me.txtLatSec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLatSec.Size = New System.Drawing.Size(81, 23)
		Me.txtLatSec.TabIndex = 79
		Me.txtLatSec.Visible = False
		'
		'txtLongDeg
		'
		Me.txtLongDeg.AcceptsReturn = True
		Me.txtLongDeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtLongDeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLongDeg.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLongDeg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLongDeg.Location = New System.Drawing.Point(345, 152)
		Me.txtLongDeg.MaxLength = 0
		Me.txtLongDeg.Name = "txtLongDeg"
		Me.txtLongDeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLongDeg.Size = New System.Drawing.Size(81, 23)
		Me.txtLongDeg.TabIndex = 78
		Me.txtLongDeg.Visible = False
		'
		'txtLongMin
		'
		Me.txtLongMin.AcceptsReturn = True
		Me.txtLongMin.BackColor = System.Drawing.SystemColors.Window
		Me.txtLongMin.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLongMin.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLongMin.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLongMin.Location = New System.Drawing.Point(345, 152)
		Me.txtLongMin.MaxLength = 0
		Me.txtLongMin.Name = "txtLongMin"
		Me.txtLongMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLongMin.Size = New System.Drawing.Size(81, 23)
		Me.txtLongMin.TabIndex = 77
		Me.txtLongMin.Visible = False
		'
		'txtLongSec
		'
		Me.txtLongSec.AcceptsReturn = True
		Me.txtLongSec.BackColor = System.Drawing.SystemColors.Window
		Me.txtLongSec.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLongSec.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLongSec.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLongSec.Location = New System.Drawing.Point(345, 152)
		Me.txtLongSec.MaxLength = 0
		Me.txtLongSec.Name = "txtLongSec"
		Me.txtLongSec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLongSec.Size = New System.Drawing.Size(81, 23)
		Me.txtLongSec.TabIndex = 76
		Me.txtLongSec.Visible = False
		'
		'txtLatRad1
		'
		Me.txtLatRad1.AcceptsReturn = True
		Me.txtLatRad1.BackColor = System.Drawing.SystemColors.Window
		Me.txtLatRad1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLatRad1.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLatRad1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLatRad1.Location = New System.Drawing.Point(345, 152)
		Me.txtLatRad1.MaxLength = 0
		Me.txtLatRad1.Name = "txtLatRad1"
		Me.txtLatRad1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLatRad1.Size = New System.Drawing.Size(89, 23)
		Me.txtLatRad1.TabIndex = 75
		Me.txtLatRad1.TabStop = False
		Me.txtLatRad1.Visible = False
		'
		'txtTotal7
		'
		Me.txtTotal7.AcceptsReturn = True
		Me.txtTotal7.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotal7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotal7.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtTotal7.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotal7.Location = New System.Drawing.Point(656, 432)
		Me.txtTotal7.MaxLength = 0
		Me.txtTotal7.Name = "txtTotal7"
		Me.txtTotal7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal7.Size = New System.Drawing.Size(81, 23)
		Me.txtTotal7.TabIndex = 39
		'
		'txtTotal6
		'
		Me.txtTotal6.AcceptsReturn = True
		Me.txtTotal6.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotal6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotal6.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtTotal6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotal6.Location = New System.Drawing.Point(656, 392)
		Me.txtTotal6.MaxLength = 0
		Me.txtTotal6.Name = "txtTotal6"
		Me.txtTotal6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal6.Size = New System.Drawing.Size(81, 23)
		Me.txtTotal6.TabIndex = 34
		'
		'txtTotal5
		'
		Me.txtTotal5.AcceptsReturn = True
		Me.txtTotal5.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotal5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotal5.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtTotal5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotal5.Location = New System.Drawing.Point(656, 352)
		Me.txtTotal5.MaxLength = 0
		Me.txtTotal5.Name = "txtTotal5"
		Me.txtTotal5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal5.Size = New System.Drawing.Size(81, 23)
		Me.txtTotal5.TabIndex = 29
		'
		'txtTotal4
		'
		Me.txtTotal4.AcceptsReturn = True
		Me.txtTotal4.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotal4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotal4.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtTotal4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotal4.Location = New System.Drawing.Point(656, 312)
		Me.txtTotal4.MaxLength = 0
		Me.txtTotal4.Name = "txtTotal4"
		Me.txtTotal4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal4.Size = New System.Drawing.Size(81, 23)
		Me.txtTotal4.TabIndex = 24
		'
		'txtTotal3
		'
		Me.txtTotal3.AcceptsReturn = True
		Me.txtTotal3.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotal3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotal3.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtTotal3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotal3.Location = New System.Drawing.Point(656, 272)
		Me.txtTotal3.MaxLength = 0
		Me.txtTotal3.Name = "txtTotal3"
		Me.txtTotal3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal3.Size = New System.Drawing.Size(81, 23)
		Me.txtTotal3.TabIndex = 19
		'
		'txtTotal2
		'
		Me.txtTotal2.AcceptsReturn = True
		Me.txtTotal2.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotal2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotal2.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtTotal2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotal2.Location = New System.Drawing.Point(656, 232)
		Me.txtTotal2.MaxLength = 0
		Me.txtTotal2.Name = "txtTotal2"
		Me.txtTotal2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal2.Size = New System.Drawing.Size(81, 23)
		Me.txtTotal2.TabIndex = 14
		'
		'txtTotal1
		'
		Me.txtTotal1.AcceptsReturn = True
		Me.txtTotal1.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotal1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotal1.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtTotal1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotal1.Location = New System.Drawing.Point(656, 192)
		Me.txtTotal1.MaxLength = 0
		Me.txtTotal1.Name = "txtTotal1"
		Me.txtTotal1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal1.Size = New System.Drawing.Size(81, 23)
		Me.txtTotal1.TabIndex = 9
		'
		'txtTotal
		'
		Me.txtTotal.AcceptsReturn = True
		Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotal.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotal.Location = New System.Drawing.Point(656, 152)
		Me.txtTotal.MaxLength = 0
		Me.txtTotal.Name = "txtTotal"
		Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal.Size = New System.Drawing.Size(81, 23)
		Me.txtTotal.TabIndex = 4
		'
		'txtLeg7
		'
		Me.txtLeg7.AcceptsReturn = True
		Me.txtLeg7.BackColor = System.Drawing.SystemColors.Window
		Me.txtLeg7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLeg7.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLeg7.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLeg7.Location = New System.Drawing.Point(536, 432)
		Me.txtLeg7.MaxLength = 0
		Me.txtLeg7.Name = "txtLeg7"
		Me.txtLeg7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLeg7.Size = New System.Drawing.Size(81, 23)
		Me.txtLeg7.TabIndex = 38
		'
		'txtLeg6
		'
		Me.txtLeg6.AcceptsReturn = True
		Me.txtLeg6.BackColor = System.Drawing.SystemColors.Window
		Me.txtLeg6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLeg6.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLeg6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLeg6.Location = New System.Drawing.Point(536, 392)
		Me.txtLeg6.MaxLength = 0
		Me.txtLeg6.Name = "txtLeg6"
		Me.txtLeg6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLeg6.Size = New System.Drawing.Size(81, 23)
		Me.txtLeg6.TabIndex = 33
		'
		'txtLeg5
		'
		Me.txtLeg5.AcceptsReturn = True
		Me.txtLeg5.BackColor = System.Drawing.SystemColors.Window
		Me.txtLeg5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLeg5.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLeg5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLeg5.Location = New System.Drawing.Point(536, 352)
		Me.txtLeg5.MaxLength = 0
		Me.txtLeg5.Name = "txtLeg5"
		Me.txtLeg5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLeg5.Size = New System.Drawing.Size(81, 23)
		Me.txtLeg5.TabIndex = 28
		'
		'txtLeg4
		'
		Me.txtLeg4.AcceptsReturn = True
		Me.txtLeg4.BackColor = System.Drawing.SystemColors.Window
		Me.txtLeg4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLeg4.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLeg4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLeg4.Location = New System.Drawing.Point(536, 312)
		Me.txtLeg4.MaxLength = 0
		Me.txtLeg4.Name = "txtLeg4"
		Me.txtLeg4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLeg4.Size = New System.Drawing.Size(81, 23)
		Me.txtLeg4.TabIndex = 23
		'
		'txtLeg3
		'
		Me.txtLeg3.AcceptsReturn = True
		Me.txtLeg3.BackColor = System.Drawing.SystemColors.Window
		Me.txtLeg3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLeg3.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLeg3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLeg3.Location = New System.Drawing.Point(536, 272)
		Me.txtLeg3.MaxLength = 0
		Me.txtLeg3.Name = "txtLeg3"
		Me.txtLeg3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLeg3.Size = New System.Drawing.Size(81, 23)
		Me.txtLeg3.TabIndex = 18
		'
		'txtLeg2
		'
		Me.txtLeg2.AcceptsReturn = True
		Me.txtLeg2.BackColor = System.Drawing.SystemColors.Window
		Me.txtLeg2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLeg2.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLeg2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLeg2.Location = New System.Drawing.Point(536, 232)
		Me.txtLeg2.MaxLength = 0
		Me.txtLeg2.Name = "txtLeg2"
		Me.txtLeg2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLeg2.Size = New System.Drawing.Size(81, 23)
		Me.txtLeg2.TabIndex = 13
		'
		'txtLeg1
		'
		Me.txtLeg1.AcceptsReturn = True
		Me.txtLeg1.BackColor = System.Drawing.SystemColors.Window
		Me.txtLeg1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLeg1.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLeg1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLeg1.Location = New System.Drawing.Point(536, 192)
		Me.txtLeg1.MaxLength = 0
		Me.txtLeg1.Name = "txtLeg1"
		Me.txtLeg1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLeg1.Size = New System.Drawing.Size(81, 23)
		Me.txtLeg1.TabIndex = 8
		'
		'txtLeg
		'
		Me.txtLeg.AcceptsReturn = True
		Me.txtLeg.BackColor = System.Drawing.SystemColors.Window
		Me.txtLeg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLeg.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLeg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLeg.Location = New System.Drawing.Point(536, 152)
		Me.txtLeg.MaxLength = 0
		Me.txtLeg.Name = "txtLeg"
		Me.txtLeg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLeg.Size = New System.Drawing.Size(81, 23)
		Me.txtLeg.TabIndex = 3
		'
		'txtPort1
		'
		Me.txtPort1.AcceptsReturn = True
		Me.txtPort1.BackColor = System.Drawing.SystemColors.Window
		Me.txtPort1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPort1.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtPort1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPort1.Location = New System.Drawing.Point(280, 192)
		Me.txtPort1.MaxLength = 0
		Me.txtPort1.Name = "txtPort1"
		Me.txtPort1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPort1.Size = New System.Drawing.Size(214, 23)
		Me.txtPort1.TabIndex = 7
		'
		'txtPort7
		'
		Me.txtPort7.AcceptsReturn = True
		Me.txtPort7.BackColor = System.Drawing.SystemColors.Window
		Me.txtPort7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPort7.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtPort7.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPort7.Location = New System.Drawing.Point(280, 432)
		Me.txtPort7.MaxLength = 0
		Me.txtPort7.Name = "txtPort7"
		Me.txtPort7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPort7.Size = New System.Drawing.Size(214, 23)
		Me.txtPort7.TabIndex = 37
		'
		'txtPort6
		'
		Me.txtPort6.AcceptsReturn = True
		Me.txtPort6.BackColor = System.Drawing.SystemColors.Window
		Me.txtPort6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPort6.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtPort6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPort6.Location = New System.Drawing.Point(280, 392)
		Me.txtPort6.MaxLength = 0
		Me.txtPort6.Name = "txtPort6"
		Me.txtPort6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPort6.Size = New System.Drawing.Size(214, 23)
		Me.txtPort6.TabIndex = 32
		'
		'txtPort5
		'
		Me.txtPort5.AcceptsReturn = True
		Me.txtPort5.BackColor = System.Drawing.SystemColors.Window
		Me.txtPort5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPort5.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtPort5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPort5.Location = New System.Drawing.Point(280, 352)
		Me.txtPort5.MaxLength = 0
		Me.txtPort5.Name = "txtPort5"
		Me.txtPort5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPort5.Size = New System.Drawing.Size(214, 23)
		Me.txtPort5.TabIndex = 27
		'
		'txtPort4
		'
		Me.txtPort4.AcceptsReturn = True
		Me.txtPort4.BackColor = System.Drawing.SystemColors.Window
		Me.txtPort4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPort4.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtPort4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPort4.Location = New System.Drawing.Point(280, 312)
		Me.txtPort4.MaxLength = 0
		Me.txtPort4.Name = "txtPort4"
		Me.txtPort4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPort4.Size = New System.Drawing.Size(214, 23)
		Me.txtPort4.TabIndex = 22
		'
		'txtPort3
		'
		Me.txtPort3.AcceptsReturn = True
		Me.txtPort3.BackColor = System.Drawing.SystemColors.Window
		Me.txtPort3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPort3.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtPort3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPort3.Location = New System.Drawing.Point(280, 272)
		Me.txtPort3.MaxLength = 0
		Me.txtPort3.Name = "txtPort3"
		Me.txtPort3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPort3.Size = New System.Drawing.Size(214, 23)
		Me.txtPort3.TabIndex = 17
		'
		'txtPort2
		'
		Me.txtPort2.AcceptsReturn = True
		Me.txtPort2.BackColor = System.Drawing.SystemColors.Window
		Me.txtPort2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPort2.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtPort2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPort2.Location = New System.Drawing.Point(280, 232)
		Me.txtPort2.MaxLength = 0
		Me.txtPort2.Name = "txtPort2"
		Me.txtPort2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPort2.Size = New System.Drawing.Size(214, 23)
		Me.txtPort2.TabIndex = 12
		'
		'cmbICAO15
		'
		Me.cmbICAO15.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO15.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO15.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO15.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO15.Location = New System.Drawing.Point(152, 432)
		Me.cmbICAO15.Name = "cmbICAO15"
		Me.cmbICAO15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO15.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO15.TabIndex = 36
		'
		'cmbICAO14
		'
		Me.cmbICAO14.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO14.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO14.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO14.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO14.Location = New System.Drawing.Point(32, 432)
		Me.cmbICAO14.Name = "cmbICAO14"
		Me.cmbICAO14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO14.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO14.TabIndex = 35
		'
		'cmbICAO12
		'
		Me.cmbICAO12.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO12.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO12.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO12.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO12.Location = New System.Drawing.Point(32, 392)
		Me.cmbICAO12.Name = "cmbICAO12"
		Me.cmbICAO12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO12.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO12.TabIndex = 30
		'
		'cmbICAO13
		'
		Me.cmbICAO13.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO13.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO13.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO13.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO13.Location = New System.Drawing.Point(152, 392)
		Me.cmbICAO13.Name = "cmbICAO13"
		Me.cmbICAO13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO13.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO13.TabIndex = 31
		'
		'cmbICAO10
		'
		Me.cmbICAO10.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO10.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO10.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO10.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO10.Location = New System.Drawing.Point(32, 352)
		Me.cmbICAO10.Name = "cmbICAO10"
		Me.cmbICAO10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO10.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO10.TabIndex = 25
		'
		'cmbICAO11
		'
		Me.cmbICAO11.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO11.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO11.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO11.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO11.Location = New System.Drawing.Point(152, 352)
		Me.cmbICAO11.Name = "cmbICAO11"
		Me.cmbICAO11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO11.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO11.TabIndex = 26
		'
		'cmbICAO8
		'
		Me.cmbICAO8.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO8.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO8.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO8.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO8.Location = New System.Drawing.Point(32, 312)
		Me.cmbICAO8.Name = "cmbICAO8"
		Me.cmbICAO8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO8.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO8.TabIndex = 20
		'
		'cmbICAO9
		'
		Me.cmbICAO9.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO9.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO9.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO9.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO9.Location = New System.Drawing.Point(152, 312)
		Me.cmbICAO9.Name = "cmbICAO9"
		Me.cmbICAO9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO9.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO9.TabIndex = 21
		'
		'cmbICAO6
		'
		Me.cmbICAO6.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO6.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO6.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO6.Location = New System.Drawing.Point(32, 272)
		Me.cmbICAO6.Name = "cmbICAO6"
		Me.cmbICAO6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO6.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO6.TabIndex = 15
		'
		'cmbICAO7
		'
		Me.cmbICAO7.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO7.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO7.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO7.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO7.Location = New System.Drawing.Point(152, 272)
		Me.cmbICAO7.Name = "cmbICAO7"
		Me.cmbICAO7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO7.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO7.TabIndex = 16
		'
		'cmbICAO4
		'
		Me.cmbICAO4.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO4.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO4.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO4.Location = New System.Drawing.Point(32, 232)
		Me.cmbICAO4.Name = "cmbICAO4"
		Me.cmbICAO4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO4.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO4.TabIndex = 10
		'
		'cmbICAO5
		'
		Me.cmbICAO5.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO5.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO5.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO5.Location = New System.Drawing.Point(152, 232)
		Me.cmbICAO5.Name = "cmbICAO5"
		Me.cmbICAO5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO5.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO5.TabIndex = 11
		'
		'cmbICAO3
		'
		Me.cmbICAO3.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO3.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO3.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO3.Location = New System.Drawing.Point(152, 192)
		Me.cmbICAO3.Name = "cmbICAO3"
		Me.cmbICAO3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO3.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO3.TabIndex = 6
		'
		'cmbICAO2
		'
		Me.cmbICAO2.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO2.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO2.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO2.Location = New System.Drawing.Point(32, 192)
		Me.cmbICAO2.Name = "cmbICAO2"
		Me.cmbICAO2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO2.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO2.TabIndex = 5
		'
		'txtICAO15
		'
		Me.txtICAO15.AcceptsReturn = True
		Me.txtICAO15.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO15.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO15.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO15.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO15.Location = New System.Drawing.Point(152, 432)
		Me.txtICAO15.MaxLength = 0
		Me.txtICAO15.Name = "txtICAO15"
		Me.txtICAO15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO15.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO15.TabIndex = 71
		Me.txtICAO15.TabStop = False
		'
		'txtICAO14
		'
		Me.txtICAO14.AcceptsReturn = True
		Me.txtICAO14.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO14.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO14.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO14.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO14.Location = New System.Drawing.Point(32, 432)
		Me.txtICAO14.MaxLength = 0
		Me.txtICAO14.Name = "txtICAO14"
		Me.txtICAO14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO14.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO14.TabIndex = 70
		Me.txtICAO14.TabStop = False
		'
		'txtICAO12
		'
		Me.txtICAO12.AcceptsReturn = True
		Me.txtICAO12.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO12.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO12.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO12.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO12.Location = New System.Drawing.Point(32, 392)
		Me.txtICAO12.MaxLength = 0
		Me.txtICAO12.Name = "txtICAO12"
		Me.txtICAO12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO12.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO12.TabIndex = 69
		Me.txtICAO12.TabStop = False
		'
		'txtICAO13
		'
		Me.txtICAO13.AcceptsReturn = True
		Me.txtICAO13.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO13.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO13.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO13.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO13.Location = New System.Drawing.Point(152, 392)
		Me.txtICAO13.MaxLength = 0
		Me.txtICAO13.Name = "txtICAO13"
		Me.txtICAO13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO13.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO13.TabIndex = 68
		Me.txtICAO13.TabStop = False
		'
		'txtICAO11
		'
		Me.txtICAO11.AcceptsReturn = True
		Me.txtICAO11.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO11.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO11.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO11.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO11.Location = New System.Drawing.Point(152, 352)
		Me.txtICAO11.MaxLength = 0
		Me.txtICAO11.Name = "txtICAO11"
		Me.txtICAO11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO11.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO11.TabIndex = 67
		Me.txtICAO11.TabStop = False
		'
		'txtICAO10
		'
		Me.txtICAO10.AcceptsReturn = True
		Me.txtICAO10.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO10.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO10.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO10.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO10.Location = New System.Drawing.Point(32, 352)
		Me.txtICAO10.MaxLength = 0
		Me.txtICAO10.Name = "txtICAO10"
		Me.txtICAO10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO10.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO10.TabIndex = 66
		Me.txtICAO10.TabStop = False
		'
		'txtICAO9
		'
		Me.txtICAO9.AcceptsReturn = True
		Me.txtICAO9.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO9.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO9.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO9.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO9.Location = New System.Drawing.Point(152, 312)
		Me.txtICAO9.MaxLength = 0
		Me.txtICAO9.Name = "txtICAO9"
		Me.txtICAO9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO9.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO9.TabIndex = 65
		Me.txtICAO9.TabStop = False
		'
		'txtICAO8
		'
		Me.txtICAO8.AcceptsReturn = True
		Me.txtICAO8.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO8.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO8.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO8.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO8.Location = New System.Drawing.Point(32, 312)
		Me.txtICAO8.MaxLength = 0
		Me.txtICAO8.Name = "txtICAO8"
		Me.txtICAO8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO8.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO8.TabIndex = 64
		Me.txtICAO8.TabStop = False
		'
		'txtICAO7
		'
		Me.txtICAO7.AcceptsReturn = True
		Me.txtICAO7.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO7.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO7.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO7.Location = New System.Drawing.Point(152, 272)
		Me.txtICAO7.MaxLength = 0
		Me.txtICAO7.Name = "txtICAO7"
		Me.txtICAO7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO7.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO7.TabIndex = 63
		Me.txtICAO7.TabStop = False
		'
		'txtICAO6
		'
		Me.txtICAO6.AcceptsReturn = True
		Me.txtICAO6.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO6.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO6.Location = New System.Drawing.Point(32, 272)
		Me.txtICAO6.MaxLength = 0
		Me.txtICAO6.Name = "txtICAO6"
		Me.txtICAO6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO6.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO6.TabIndex = 62
		Me.txtICAO6.TabStop = False
		'
		'txtICAO5
		'
		Me.txtICAO5.AcceptsReturn = True
		Me.txtICAO5.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO5.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO5.Location = New System.Drawing.Point(152, 232)
		Me.txtICAO5.MaxLength = 0
		Me.txtICAO5.Name = "txtICAO5"
		Me.txtICAO5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO5.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO5.TabIndex = 61
		Me.txtICAO5.TabStop = False
		'
		'txtICAO4
		'
		Me.txtICAO4.AcceptsReturn = True
		Me.txtICAO4.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO4.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO4.Location = New System.Drawing.Point(32, 232)
		Me.txtICAO4.MaxLength = 0
		Me.txtICAO4.Name = "txtICAO4"
		Me.txtICAO4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO4.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO4.TabIndex = 60
		Me.txtICAO4.TabStop = False
		'
		'txtICAO2
		'
		Me.txtICAO2.AcceptsReturn = True
		Me.txtICAO2.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO2.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO2.Location = New System.Drawing.Point(32, 192)
		Me.txtICAO2.MaxLength = 0
		Me.txtICAO2.Name = "txtICAO2"
		Me.txtICAO2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO2.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO2.TabIndex = 59
		Me.txtICAO2.TabStop = False
		'
		'txtICAO3
		'
		Me.txtICAO3.AcceptsReturn = True
		Me.txtICAO3.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO3.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO3.Location = New System.Drawing.Point(152, 192)
		Me.txtICAO3.MaxLength = 0
		Me.txtICAO3.Name = "txtICAO3"
		Me.txtICAO3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO3.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO3.TabIndex = 58
		Me.txtICAO3.TabStop = False
		'
		'txtNS14
		'
		Me.txtNS14.AcceptsReturn = True
		Me.txtNS14.BackColor = System.Drawing.SystemColors.Window
		Me.txtNS14.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNS14.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtNS14.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNS14.Location = New System.Drawing.Point(353, 152)
		Me.txtNS14.MaxLength = 0
		Me.txtNS14.Name = "txtNS14"
		Me.txtNS14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNS14.Size = New System.Drawing.Size(89, 23)
		Me.txtNS14.TabIndex = 57
		Me.txtNS14.TabStop = False
		Me.txtNS14.Visible = False
		'
		'txtLongRad
		'
		Me.txtLongRad.AcceptsReturn = True
		Me.txtLongRad.BackColor = System.Drawing.SystemColors.Window
		Me.txtLongRad.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLongRad.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLongRad.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLongRad.Location = New System.Drawing.Point(345, 152)
		Me.txtLongRad.MaxLength = 0
		Me.txtLongRad.Name = "txtLongRad"
		Me.txtLongRad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLongRad.Size = New System.Drawing.Size(89, 23)
		Me.txtLongRad.TabIndex = 56
		Me.txtLongRad.TabStop = False
		Me.txtLongRad.Visible = False
		'
		'txtLatRad
		'
		Me.txtLatRad.AcceptsReturn = True
		Me.txtLatRad.BackColor = System.Drawing.SystemColors.Window
		Me.txtLatRad.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLatRad.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLatRad.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLatRad.Location = New System.Drawing.Point(345, 152)
		Me.txtLatRad.MaxLength = 0
		Me.txtLatRad.Name = "txtLatRad"
		Me.txtLatRad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLatRad.Size = New System.Drawing.Size(89, 23)
		Me.txtLatRad.TabIndex = 55
		Me.txtLatRad.TabStop = False
		Me.txtLatRad.Visible = False
		'
		'txtNS15
		'
		Me.txtNS15.AcceptsReturn = True
		Me.txtNS15.BackColor = System.Drawing.SystemColors.Window
		Me.txtNS15.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNS15.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtNS15.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNS15.Location = New System.Drawing.Point(353, 152)
		Me.txtNS15.MaxLength = 0
		Me.txtNS15.Name = "txtNS15"
		Me.txtNS15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNS15.Size = New System.Drawing.Size(89, 23)
		Me.txtNS15.TabIndex = 54
		Me.txtNS15.TabStop = False
		Me.txtNS15.Visible = False
		'
		'txtLongDec
		'
		Me.txtLongDec.AcceptsReturn = True
		Me.txtLongDec.BackColor = System.Drawing.SystemColors.Window
		Me.txtLongDec.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLongDec.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLongDec.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLongDec.Location = New System.Drawing.Point(353, 152)
		Me.txtLongDec.MaxLength = 0
		Me.txtLongDec.Name = "txtLongDec"
		Me.txtLongDec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLongDec.Size = New System.Drawing.Size(89, 23)
		Me.txtLongDec.TabIndex = 53
		Me.txtLongDec.TabStop = False
		Me.txtLongDec.Visible = False
		'
		'txtLatDec
		'
		Me.txtLatDec.AcceptsReturn = True
		Me.txtLatDec.BackColor = System.Drawing.SystemColors.Window
		Me.txtLatDec.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtLatDec.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtLatDec.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtLatDec.Location = New System.Drawing.Point(353, 152)
		Me.txtLatDec.MaxLength = 0
		Me.txtLatDec.Name = "txtLatDec"
		Me.txtLatDec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLatDec.Size = New System.Drawing.Size(89, 23)
		Me.txtLatDec.TabIndex = 52
		Me.txtLatDec.TabStop = False
		Me.txtLatDec.Visible = False
		'
		'txtPort
		'
		Me.txtPort.AcceptsReturn = True
		Me.txtPort.BackColor = System.Drawing.SystemColors.Window
		Me.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPort.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtPort.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPort.Location = New System.Drawing.Point(280, 152)
		Me.txtPort.MaxLength = 0
		Me.txtPort.Name = "txtPort"
		Me.txtPort.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPort.Size = New System.Drawing.Size(214, 23)
		Me.txtPort.TabIndex = 2
		'
		'txtDist
		'
		Me.txtDist.AcceptsReturn = True
		Me.txtDist.BackColor = System.Drawing.SystemColors.Window
		Me.txtDist.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDist.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtDist.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDist.Location = New System.Drawing.Point(353, 152)
		Me.txtDist.MaxLength = 0
		Me.txtDist.Name = "txtDist"
		Me.txtDist.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDist.Size = New System.Drawing.Size(89, 23)
		Me.txtDist.TabIndex = 51
		Me.txtDist.TabStop = False
		Me.txtDist.Visible = False
		'
		'Text7
		'
		Me.Text7.AcceptsReturn = True
		Me.Text7.BackColor = System.Drawing.SystemColors.Window
		Me.Text7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text7.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.Text7.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text7.Location = New System.Drawing.Point(353, 152)
		Me.Text7.MaxLength = 0
		Me.Text7.Name = "Text7"
		Me.Text7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text7.Size = New System.Drawing.Size(89, 23)
		Me.Text7.TabIndex = 50
		Me.Text7.TabStop = False
		Me.Text7.Visible = False
		'
		'Text6
		'
		Me.Text6.AcceptsReturn = True
		Me.Text6.BackColor = System.Drawing.SystemColors.Window
		Me.Text6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text6.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.Text6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text6.Location = New System.Drawing.Point(353, 152)
		Me.Text6.MaxLength = 0
		Me.Text6.Name = "Text6"
		Me.Text6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text6.Size = New System.Drawing.Size(89, 23)
		Me.Text6.TabIndex = 49
		Me.Text6.TabStop = False
		Me.Text6.Visible = False
		'
		'Text5
		'
		Me.Text5.AcceptsReturn = True
		Me.Text5.BackColor = System.Drawing.SystemColors.Window
		Me.Text5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text5.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.Text5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text5.Location = New System.Drawing.Point(353, 152)
		Me.Text5.MaxLength = 0
		Me.Text5.Name = "Text5"
		Me.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text5.Size = New System.Drawing.Size(89, 23)
		Me.Text5.TabIndex = 48
		Me.Text5.TabStop = False
		Me.Text5.Visible = False
		'
		'Text4
		'
		Me.Text4.AcceptsReturn = True
		Me.Text4.BackColor = System.Drawing.SystemColors.Window
		Me.Text4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text4.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.Text4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text4.Location = New System.Drawing.Point(353, 152)
		Me.Text4.MaxLength = 0
		Me.Text4.Name = "Text4"
		Me.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text4.Size = New System.Drawing.Size(89, 23)
		Me.Text4.TabIndex = 47
		Me.Text4.TabStop = False
		Me.Text4.Visible = False
		'
		'Text3
		'
		Me.Text3.AcceptsReturn = True
		Me.Text3.BackColor = System.Drawing.SystemColors.Window
		Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text3.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text3.Location = New System.Drawing.Point(353, 152)
		Me.Text3.MaxLength = 0
		Me.Text3.Name = "Text3"
		Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text3.Size = New System.Drawing.Size(89, 23)
		Me.Text3.TabIndex = 46
		Me.Text3.TabStop = False
		Me.Text3.Visible = False
		'
		'Text2
		'
		Me.Text2.AcceptsReturn = True
		Me.Text2.BackColor = System.Drawing.SystemColors.Window
		Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text2.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text2.Location = New System.Drawing.Point(361, 152)
		Me.Text2.MaxLength = 0
		Me.Text2.Name = "Text2"
		Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text2.Size = New System.Drawing.Size(89, 23)
		Me.Text2.TabIndex = 45
		Me.Text2.TabStop = False
		Me.Text2.Visible = False
		'
		'Text1
		'
		Me.Text1.AcceptsReturn = True
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.Location = New System.Drawing.Point(361, 152)
		Me.Text1.MaxLength = 0
		Me.Text1.Name = "Text1"
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.Size = New System.Drawing.Size(89, 23)
		Me.Text1.TabIndex = 44
		Me.Text1.TabStop = False
		Me.Text1.Visible = False
		'
		'cmbICAO1
		'
		Me.cmbICAO1.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO1.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO1.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO1.Location = New System.Drawing.Point(152, 152)
		Me.cmbICAO1.Name = "cmbICAO1"
		Me.cmbICAO1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO1.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO1.TabIndex = 1
		'
		'txtICAO1
		'
		Me.txtICAO1.AcceptsReturn = True
		Me.txtICAO1.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO1.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO1.Location = New System.Drawing.Point(152, 152)
		Me.txtICAO1.MaxLength = 0
		Me.txtICAO1.Name = "txtICAO1"
		Me.txtICAO1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO1.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO1.TabIndex = 43
		Me.txtICAO1.TabStop = False
		'
		'cmbICAO
		'
		Me.cmbICAO.BackColor = System.Drawing.SystemColors.Window
		Me.cmbICAO.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbICAO.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.cmbICAO.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbICAO.Location = New System.Drawing.Point(32, 152)
		Me.cmbICAO.Name = "cmbICAO"
		Me.cmbICAO.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbICAO.Size = New System.Drawing.Size(87, 24)
		Me.cmbICAO.TabIndex = 0
		'
		'txtICAO
		'
		Me.txtICAO.AcceptsReturn = True
		Me.txtICAO.BackColor = System.Drawing.SystemColors.Window
		Me.txtICAO.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtICAO.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtICAO.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtICAO.Location = New System.Drawing.Point(32, 152)
		Me.txtICAO.MaxLength = 0
		Me.txtICAO.Name = "txtICAO"
		Me.txtICAO.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtICAO.Size = New System.Drawing.Size(87, 23)
		Me.txtICAO.TabIndex = 40
		Me.txtICAO.TabStop = False
		'
		'txtOrig
		'
		Me.txtOrig.AcceptsReturn = True
		Me.txtOrig.BackColor = System.Drawing.SystemColors.Window
		Me.txtOrig.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOrig.Font = New System.Drawing.Font("Arial", 10.0!)
		Me.txtOrig.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOrig.Location = New System.Drawing.Point(32, 152)
		Me.txtOrig.MaxLength = 0
		Me.txtOrig.Name = "txtOrig"
		Me.txtOrig.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOrig.Size = New System.Drawing.Size(89, 23)
		Me.txtOrig.TabIndex = 83
		Me.txtOrig.Visible = False
		'
		'cmdNext
		'
		Me.cmdNext.BackColor = System.Drawing.Color.Transparent
		Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNext.ForeColor = System.Drawing.Color.White
		Me.cmdNext.Location = New System.Drawing.Point(129, 499)
		Me.cmdNext.Name = "cmdNext"
		Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNext.Size = New System.Drawing.Size(80, 27)
		Me.cmdNext.TabIndex = 97
		Me.cmdNext.Text = "&Next"
		Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'cmdExit
		'
		Me.cmdExit.BackColor = System.Drawing.Color.Transparent
		Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdExit.ForeColor = System.Drawing.Color.White
		Me.cmdExit.Location = New System.Drawing.Point(559, 499)
		Me.cmdExit.Name = "cmdExit"
		Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdExit.Size = New System.Drawing.Size(80, 27)
		Me.cmdExit.TabIndex = 96
		Me.cmdExit.Text = "E&xit"
		Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'cmdBack
		'
		Me.cmdBack.BackColor = System.Drawing.Color.Transparent
		Me.cmdBack.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBack.ForeColor = System.Drawing.Color.White
		Me.cmdBack.Location = New System.Drawing.Point(414, 499)
		Me.cmdBack.Name = "cmdBack"
		Me.cmdBack.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBack.Size = New System.Drawing.Size(80, 27)
		Me.cmdBack.TabIndex = 95
		Me.cmdBack.Text = "&Back"
		Me.cmdBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'cmdClear
		'
		Me.cmdClear.BackColor = System.Drawing.Color.Transparent
		Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClear.ForeColor = System.Drawing.Color.White
		Me.cmdClear.Location = New System.Drawing.Point(274, 499)
		Me.cmdClear.Name = "cmdClear"
		Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClear.Size = New System.Drawing.Size(80, 27)
		Me.cmdClear.TabIndex = 94
		Me.cmdClear.Text = "&Clear"
		Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblSubtitle
		'
		Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
		Me.lblSubtitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSubtitle.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSubtitle.ForeColor = System.Drawing.Color.White
		Me.lblSubtitle.Location = New System.Drawing.Point(144, 48)
		Me.lblSubtitle.Name = "lblSubtitle"
		Me.lblSubtitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSubtitle.Size = New System.Drawing.Size(521, 33)
		Me.lblSubtitle.TabIndex = 93
		Me.lblSubtitle.Text = "Bid Calculations"
		Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblTitle
		'
		Me.lblTitle.BackColor = System.Drawing.Color.Transparent
		Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.White
		Me.lblTitle.Location = New System.Drawing.Point(144, 8)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTitle.Size = New System.Drawing.Size(521, 41)
		Me.lblTitle.TabIndex = 92
		Me.lblTitle.Text = "INTERNATIONAL AIRCRAFT DELIVERY"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblTotalMiles
		'
		Me.lblTotalMiles.BackColor = System.Drawing.Color.Transparent
		Me.lblTotalMiles.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTotalMiles.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotalMiles.ForeColor = System.Drawing.Color.White
		Me.lblTotalMiles.Location = New System.Drawing.Point(649, 123)
		Me.lblTotalMiles.Name = "lblTotalMiles"
		Me.lblTotalMiles.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTotalMiles.Size = New System.Drawing.Size(96, 17)
		Me.lblTotalMiles.TabIndex = 74
		Me.lblTotalMiles.Text = "Total Miles"
		Me.lblTotalMiles.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblDist
		'
		Me.lblDist.BackColor = System.Drawing.Color.Transparent
		Me.lblDist.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDist.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDist.ForeColor = System.Drawing.Color.White
		Me.lblDist.Location = New System.Drawing.Point(536, 123)
		Me.lblDist.Name = "lblDist"
		Me.lblDist.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDist.Size = New System.Drawing.Size(81, 25)
		Me.lblDist.TabIndex = 73
		Me.lblDist.Text = "Leg Dist"
		Me.lblDist.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblAirport
		'
		Me.lblAirport.BackColor = System.Drawing.Color.Transparent
		Me.lblAirport.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAirport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAirport.ForeColor = System.Drawing.Color.White
		Me.lblAirport.Location = New System.Drawing.Point(280, 123)
		Me.lblAirport.Name = "lblAirport"
		Me.lblAirport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAirport.Size = New System.Drawing.Size(213, 25)
		Me.lblAirport.TabIndex = 72
		Me.lblAirport.Text = "Destination Airport"
		Me.lblAirport.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblToICAO
		'
		Me.lblToICAO.BackColor = System.Drawing.Color.Transparent
		Me.lblToICAO.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblToICAO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
		Me.lblToICAO.ForeColor = System.Drawing.Color.White
		Me.lblToICAO.Location = New System.Drawing.Point(152, 123)
		Me.lblToICAO.Name = "lblToICAO"
		Me.lblToICAO.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblToICAO.Size = New System.Drawing.Size(86, 17)
		Me.lblToICAO.TabIndex = 42
		Me.lblToICAO.Text = "To ICAO"
		Me.lblToICAO.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblFromICAO
		'
		Me.lblFromICAO.BackColor = System.Drawing.Color.Transparent
		Me.lblFromICAO.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFromICAO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
		Me.lblFromICAO.ForeColor = System.Drawing.Color.White
		Me.lblFromICAO.Location = New System.Drawing.Point(29, 123)
		Me.lblFromICAO.Name = "lblFromICAO"
		Me.lblFromICAO.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFromICAO.Size = New System.Drawing.Size(97, 17)
		Me.lblFromICAO.TabIndex = 41
		Me.lblFromICAO.Text = "From ICAO"
		Me.lblFromICAO.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'imgBtnClear
		'
		Me.imgBtnClear.BackgroundImage = CType(resources.GetObject("imgBtnClear.BackgroundImage"), System.Drawing.Image)
		Me.imgBtnClear.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBtnClear.Location = New System.Drawing.Point(0, 497)
		Me.imgBtnClear.Name = "imgBtnClear"
		Me.imgBtnClear.Size = New System.Drawing.Size(775, 33)
		Me.imgBtnClear.TabIndex = 99
		Me.imgBtnClear.TabStop = False
		Me.imgBtnClear.Visible = False
		'
		'imgBtnExit
		'
		Me.imgBtnExit.BackgroundImage = CType(resources.GetObject("imgBtnExit.BackgroundImage"), System.Drawing.Image)
		Me.imgBtnExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBtnExit.Location = New System.Drawing.Point(0, 497)
		Me.imgBtnExit.Name = "imgBtnExit"
		Me.imgBtnExit.Size = New System.Drawing.Size(775, 33)
		Me.imgBtnExit.TabIndex = 100
		Me.imgBtnExit.TabStop = False
		Me.imgBtnExit.Visible = False
		'
		'imgBtnBack
		'
		Me.imgBtnBack.BackgroundImage = CType(resources.GetObject("imgBtnBack.BackgroundImage"), System.Drawing.Image)
		Me.imgBtnBack.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBtnBack.Location = New System.Drawing.Point(0, 497)
		Me.imgBtnBack.Name = "imgBtnBack"
		Me.imgBtnBack.Size = New System.Drawing.Size(775, 33)
		Me.imgBtnBack.TabIndex = 98
		Me.imgBtnBack.TabStop = False
		Me.imgBtnBack.Visible = False
		'
		'imgBtnBkgd
		'
		Me.imgBtnBkgd.BackgroundImage = CType(resources.GetObject("imgBtnBkgd.BackgroundImage"), System.Drawing.Image)
		Me.imgBtnBkgd.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBtnBkgd.Location = New System.Drawing.Point(0, 497)
		Me.imgBtnBkgd.Name = "imgBtnBkgd"
		Me.imgBtnBkgd.Size = New System.Drawing.Size(775, 33)
		Me.imgBtnBkgd.TabIndex = 101
		Me.imgBtnBkgd.TabStop = False
		'
		'imgBkgd
		'
		Me.imgBkgd.BackgroundImage = CType(resources.GetObject("imgBkgd.BackgroundImage"), System.Drawing.Image)
		Me.imgBkgd.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBkgd.Location = New System.Drawing.Point(0, 497)
		Me.imgBkgd.Name = "imgBkgd"
		Me.imgBkgd.Size = New System.Drawing.Size(775, 33)
		Me.imgBkgd.TabIndex = 102
		Me.imgBkgd.TabStop = False
		'
		'frmMileageCalc
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(777, 531)
		Me.Controls.Add(Me.cmdNext)
		Me.Controls.Add(Me.cmdClear)
		Me.Controls.Add(Me.cmdBack)
		Me.Controls.Add(Me.cmdExit)
		Me.Controls.Add(Me.txtNS)
		Me.Controls.Add(Me.txtRad)
		Me.Controls.Add(Me.txtCos3)
		Me.Controls.Add(Me.txtCos2)
		Me.Controls.Add(Me.txtCos1)
		Me.Controls.Add(Me.txtSin2)
		Me.Controls.Add(Me.txtSin1)
		Me.Controls.Add(Me.txtLongRad1)
		Me.Controls.Add(Me.txtLatDeg)
		Me.Controls.Add(Me.txtLatMin)
		Me.Controls.Add(Me.txtLatSec)
		Me.Controls.Add(Me.txtLongDeg)
		Me.Controls.Add(Me.txtLongMin)
		Me.Controls.Add(Me.txtLongSec)
		Me.Controls.Add(Me.txtLatRad1)
		Me.Controls.Add(Me.txtTotal7)
		Me.Controls.Add(Me.txtTotal6)
		Me.Controls.Add(Me.txtTotal5)
		Me.Controls.Add(Me.txtTotal4)
		Me.Controls.Add(Me.txtTotal3)
		Me.Controls.Add(Me.txtTotal2)
		Me.Controls.Add(Me.txtTotal1)
		Me.Controls.Add(Me.txtTotal)
		Me.Controls.Add(Me.txtLeg7)
		Me.Controls.Add(Me.txtLeg6)
		Me.Controls.Add(Me.txtLeg5)
		Me.Controls.Add(Me.txtLeg4)
		Me.Controls.Add(Me.txtLeg3)
		Me.Controls.Add(Me.txtLeg2)
		Me.Controls.Add(Me.txtLeg1)
		Me.Controls.Add(Me.txtLeg)
		Me.Controls.Add(Me.txtPort1)
		Me.Controls.Add(Me.txtPort7)
		Me.Controls.Add(Me.txtPort6)
		Me.Controls.Add(Me.txtPort5)
		Me.Controls.Add(Me.txtPort4)
		Me.Controls.Add(Me.txtPort3)
		Me.Controls.Add(Me.txtPort2)
		Me.Controls.Add(Me.cmbICAO15)
		Me.Controls.Add(Me.cmbICAO14)
		Me.Controls.Add(Me.cmbICAO12)
		Me.Controls.Add(Me.cmbICAO13)
		Me.Controls.Add(Me.cmbICAO10)
		Me.Controls.Add(Me.cmbICAO11)
		Me.Controls.Add(Me.cmbICAO8)
		Me.Controls.Add(Me.cmbICAO9)
		Me.Controls.Add(Me.cmbICAO6)
		Me.Controls.Add(Me.cmbICAO7)
		Me.Controls.Add(Me.cmbICAO4)
		Me.Controls.Add(Me.cmbICAO5)
		Me.Controls.Add(Me.cmbICAO3)
		Me.Controls.Add(Me.cmbICAO2)
		Me.Controls.Add(Me.txtICAO15)
		Me.Controls.Add(Me.txtICAO14)
		Me.Controls.Add(Me.txtICAO12)
		Me.Controls.Add(Me.txtICAO13)
		Me.Controls.Add(Me.txtICAO11)
		Me.Controls.Add(Me.txtICAO10)
		Me.Controls.Add(Me.txtICAO9)
		Me.Controls.Add(Me.txtICAO8)
		Me.Controls.Add(Me.txtICAO7)
		Me.Controls.Add(Me.txtICAO6)
		Me.Controls.Add(Me.txtICAO5)
		Me.Controls.Add(Me.txtICAO4)
		Me.Controls.Add(Me.txtICAO2)
		Me.Controls.Add(Me.txtICAO3)
		Me.Controls.Add(Me.txtNS14)
		Me.Controls.Add(Me.txtLongRad)
		Me.Controls.Add(Me.txtLatRad)
		Me.Controls.Add(Me.txtNS15)
		Me.Controls.Add(Me.txtLongDec)
		Me.Controls.Add(Me.txtLatDec)
		Me.Controls.Add(Me.txtPort)
		Me.Controls.Add(Me.txtDist)
		Me.Controls.Add(Me.Text7)
		Me.Controls.Add(Me.Text6)
		Me.Controls.Add(Me.Text5)
		Me.Controls.Add(Me.Text4)
		Me.Controls.Add(Me.Text3)
		Me.Controls.Add(Me.Text2)
		Me.Controls.Add(Me.Text1)
		Me.Controls.Add(Me.cmbICAO1)
		Me.Controls.Add(Me.txtICAO1)
		Me.Controls.Add(Me.cmbICAO)
		Me.Controls.Add(Me.txtICAO)
		Me.Controls.Add(Me.txtOrig)
		Me.Controls.Add(Me.lblSubtitle)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.lblTotalMiles)
		Me.Controls.Add(Me.lblDist)
		Me.Controls.Add(Me.lblAirport)
		Me.Controls.Add(Me.lblToICAO)
		Me.Controls.Add(Me.lblFromICAO)
		Me.Controls.Add(Me.txtEW)
		Me.Controls.Add(Me.imgBtnBkgd)
		Me.Controls.Add(Me.imgBtnBack)
		Me.Controls.Add(Me.imgBtnExit)
		Me.Controls.Add(Me.imgBtnClear)
		Me.Controls.Add(Me.imgBkgd)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Location = New System.Drawing.Point(4, 30)
		Me.Name = "frmMileageCalc"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Bid Calculations"
		CType(Me.imgBtnClear, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBtnExit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBtnBack, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBtnBkgd, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgBkgd, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
#End Region
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmMileageCalc
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmMileageCalc
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmMileageCalc()
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
	Dim intTotal As Double
	Dim MyAcos, MySin1, MySin2, MyRad As Double
	Dim MyCos2, MyCos1, MyCos3 As Double
	Dim ArcCos, MyLongRad, MyCalc, MyLongRad1, Pi As Double
	Dim intLatRad1, intLatRad, intLongRad, intLongRad1 As Double
	Dim intLatMin, intLatDeg, intLatSec As Double
	Dim intLongMin, intLongDeg, intLongSec As Double
	Dim intNS, intEW As Double
	Dim strLatRad, strICAO, strPort, strLongRad As String

	Private Sub cmdBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBack.Click
		frmCust.DefInstance.Show()
		DefInstance.Hide()
	End Sub

	<Obsolete>
	Private Sub cmdBack_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdBack.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

		imgBtnClear.Visible = False
		imgBtnBack.Visible = True
		imgBtnExit.Visible = False
		imgBtnBkgd.Visible = False

	End Sub

	Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
		For Each ctlCurrent In Controls
			'UPGRADE_WARNING: TypeOf has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If TypeOf ctlCurrent Is System.Windows.Forms.TextBox Then
				ctlCurrent.Text = ""
			End If
		Next ctlCurrent
		cmbICAO.Text = ""
		cmbICAO1.Text = ""
		cmbICAO2.Text = ""
		cmbICAO3.Text = ""
		cmbICAO4.Text = ""
		cmbICAO5.Text = ""
		cmbICAO6.Text = ""
		cmbICAO7.Text = ""
		cmbICAO8.Text = ""
		cmbICAO9.Text = ""
		cmbICAO10.Text = ""
		cmbICAO11.Text = ""
		cmbICAO12.Text = ""
		cmbICAO13.Text = ""
		cmbICAO14.Text = ""
		cmbICAO15.Text = ""


		cmbICAO.Visible = True
		cmbICAO1.Visible = True
		cmbICAO2.Visible = True
		cmbICAO3.Visible = True
		cmbICAO4.Visible = True
		cmbICAO5.Visible = True
		cmbICAO6.Visible = True
		cmbICAO7.Visible = True
		cmbICAO8.Visible = True
		cmbICAO9.Visible = True
		cmbICAO10.Visible = True
		cmbICAO11.Visible = True
		cmbICAO12.Visible = True
		cmbICAO13.Visible = True
		cmbICAO14.Visible = True
		cmbICAO15.Visible = True
		cmbICAO.Focus()

	End Sub

	<Obsolete>
	Private Sub cmdClear_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdClear.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

		imgBtnClear.Visible = True
		imgBtnBack.Visible = False
		imgBtnExit.Visible = False
		imgBtnBkgd.Visible = False

	End Sub

	<Obsolete>
	Private Sub cmdExit_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdExit.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

		imgBtnClear.Visible = False
		imgBtnBack.Visible = False
		imgBtnExit.Visible = True
		imgBtnBkgd.Visible = False

	End Sub

	Private Sub cmdNext_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.Click
		frmBidCalc.Show()
		DefInstance.Hide()
	End Sub

	<Obsolete>
	Private Sub cmdNext_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdNext.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

		imgBtnClear.Visible = False
		imgBtnBack.Visible = False
		imgBtnExit.Visible = False
		imgBtnBkgd.Visible = True

	End Sub

	Private Sub frmBidCalc1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

		cmbICAO.Items.Add("ASSY")
		cmbICAO.Items.Add("AYPY")
		cmbICAO.Items.Add("BGBW")
		cmbICAO.Items.Add("BGGH")
		cmbICAO.Items.Add("BIRK")
		cmbICAO.Items.Add("CYAM")
		cmbICAO.Items.Add("CYFB")
		cmbICAO.Items.Add("CYQX")
		cmbICAO.Items.Add("CYYQ")
		cmbICAO.Items.Add("CYYR")
		cmbICAO.Items.Add("CYYT")
		cmbICAO.Items.Add("DAAG")
		cmbICAO.Items.Add("DIAP")
		cmbICAO.Items.Add("DNMM")
		cmbICAO.Items.Add("DRRN")
		cmbICAO.Items.Add("EBBR")
		cmbICAO.Items.Add("EDDW")
		cmbICAO.Items.Add("EFHK")
		cmbICAO.Items.Add("EGPD")
		cmbICAO.Items.Add("EGPK")
		cmbICAO.Items.Add("EHBK")
		cmbICAO.Items.Add("EINN")
		cmbICAO.Items.Add("EKCH")
		cmbICAO.Items.Add("ELLX")
		cmbICAO.Items.Add("ENBR")
		cmbICAO.Items.Add("FAGM")
		cmbICAO.Items.Add("FALA")
		cmbICAO.Items.Add("FAWM")
		cmbICAO.Items.Add("FCBB")
		cmbICAO.Items.Add("FEFF")
		cmbICAO.Items.Add("FMMI")
		cmbICAO.Items.Add("FNLU")
		cmbICAO.Items.Add("FOOL")
		cmbICAO.Items.Add("FSIA")
		cmbICAO.Items.Add("FVHA")
		cmbICAO.Items.Add("FZNA")
		cmbICAO.Items.Add("GBYD")
		cmbICAO.Items.Add("GCXO")
		cmbICAO.Items.Add("GMAA")
		cmbICAO.Items.Add("GOOY")
		cmbICAO.Items.Add("HELX")
		cmbICAO.Items.Add("HKNW")
		cmbICAO.Items.Add("HSSS")
		cmbICAO.Items.Add("HTDA")
		cmbICAO.Items.Add("I69")
		cmbICAO.Items.Add("KANC")
		cmbICAO.Items.Add("KBGR")
		cmbICAO.Items.Add("KBOI")
		cmbICAO.Items.Add("KCAE")
		cmbICAO.Items.Add("KEWK")
		cmbICAO.Items.Add("KICT")
		cmbICAO.Items.Add("KIDP")
		cmbICAO.Items.Add("KJNU")
		cmbICAO.Items.Add("KMIA")
		cmbICAO.Items.Add("KMSP")
		cmbICAO.Items.Add("KNUD")
		cmbICAO.Items.Add("KOAK")
		cmbICAO.Items.Add("KPDK")
		cmbICAO.Items.Add("KVRB")
		cmbICAO.Items.Add("LCPH")
		cmbICAO.Items.Add("LEMD")
		cmbICAO.Items.Add("LEMG")
		cmbICAO.Items.Add("LFPN")
		cmbICAO.Items.Add("LGAT")
		cmbICAO.Items.Add("LGIR")
		cmbICAO.Items.Add("LIRA")
		cmbICAO.Items.Add("LKPR")
		cmbICAO.Items.Add("LPAZ")
		cmbICAO.Items.Add("LPPR")
		cmbICAO.Items.Add("LROP")
		cmbICAO.Items.Add("LTAC")
		cmbICAO.Items.Add("LTBA")
		cmbICAO.Items.Add("MROC")
		cmbICAO.Items.Add("NTSU")
		cmbICAO.Items.Add("NZAA")
		cmbICAO.Items.Add("OOMS")
		cmbICAO.Items.Add("OPKC")
		cmbICAO.Items.Add("PAOM")
		cmbICAO.Items.Add("PGSN")
		cmbICAO.Items.Add("PHNL")
		cmbICAO.Items.Add("PHTO")
		cmbICAO.Items.Add("PKMJ")
		cmbICAO.Items.Add("PLCH")
		cmbICAO.Items.Add("PMDY")
		cmbICAO.Items.Add("PTRO")
		cmbICAO.Items.Add("PWAK")
		cmbICAO.Items.Add("RCTP")
		cmbICAO.Items.Add("RJCK")
		cmbICAO.Items.Add("RJTT")
		cmbICAO.Items.Add("RKSS")
		cmbICAO.Items.Add("RPMM")
		cmbICAO.Items.Add("SAEZ")
		cmbICAO.Items.Add("SBEG")
		cmbICAO.Items.Add("SBGL")
		cmbICAO.Items.Add("SBSP")
		cmbICAO.Items.Add("SCEL")
		cmbICAO.Items.Add("SVMG")
		cmbICAO.Items.Add("TTPP")
		cmbICAO.Items.Add("UHHH")
		cmbICAO.Items.Add("UHMM")
		cmbICAO.Items.Add("UHPP")
		cmbICAO.Items.Add("UHSS")
		cmbICAO.Items.Add("UTTT")
		cmbICAO.Items.Add("UUEE")
		cmbICAO.Items.Add("VABB")
		cmbICAO.Items.Add("VCBI")
		cmbICAO.Items.Add("VIDP")
		cmbICAO.Items.Add("VNKT")
		cmbICAO.Items.Add("VOMM")
		cmbICAO.Items.Add("VOPB")
		cmbICAO.Items.Add("VRMM")
		cmbICAO.Items.Add("VTBD")
		cmbICAO.Items.Add("WMKJ")
		cmbICAO.Items.Add("WMKK")
		cmbICAO.Items.Add("WSSL")
		cmbICAO.Items.Add("ZGGG")
		cmbICAO.Items.Add("Other")

		cmbICAO1.Items.Add("ASSY")
		cmbICAO1.Items.Add("AYPY")
		cmbICAO1.Items.Add("BGBW")
		cmbICAO1.Items.Add("BGGH")
		cmbICAO1.Items.Add("BIRK")
		cmbICAO1.Items.Add("CYAM")
		cmbICAO1.Items.Add("CYFB")
		cmbICAO1.Items.Add("CYQX")
		cmbICAO1.Items.Add("CYYQ")
		cmbICAO1.Items.Add("CYYR")
		cmbICAO1.Items.Add("CYYT")
		cmbICAO1.Items.Add("DAAG")
		cmbICAO1.Items.Add("DIAP")
		cmbICAO1.Items.Add("DNMM")
		cmbICAO1.Items.Add("DRRN")
		cmbICAO1.Items.Add("EBBR")
		cmbICAO1.Items.Add("EDDW")
		cmbICAO1.Items.Add("EFHK")
		cmbICAO1.Items.Add("EGPD")
		cmbICAO1.Items.Add("EGPK")
		cmbICAO1.Items.Add("EHBK")
		cmbICAO1.Items.Add("EINN")
		cmbICAO1.Items.Add("EKCH")
		cmbICAO1.Items.Add("ELLX")
		cmbICAO1.Items.Add("ENBR")
		cmbICAO1.Items.Add("FAGM")
		cmbICAO1.Items.Add("FALA")
		cmbICAO1.Items.Add("FAWM")
		cmbICAO1.Items.Add("FCBB")
		cmbICAO1.Items.Add("FEFF")
		cmbICAO1.Items.Add("FMMI")
		cmbICAO1.Items.Add("FNLU")
		cmbICAO1.Items.Add("FOOL")
		cmbICAO1.Items.Add("FSIA")
		cmbICAO1.Items.Add("FVHA")
		cmbICAO1.Items.Add("FZNA")
		cmbICAO1.Items.Add("GBYD")
		cmbICAO1.Items.Add("GCXO")
		cmbICAO1.Items.Add("GMAA")
		cmbICAO1.Items.Add("GOOY")
		cmbICAO1.Items.Add("HELX")
		cmbICAO1.Items.Add("HKNW")
		cmbICAO1.Items.Add("HSSS")
		cmbICAO1.Items.Add("HTDA")
		cmbICAO1.Items.Add("I69")
		cmbICAO1.Items.Add("KANC")
		cmbICAO1.Items.Add("KBGR")
		cmbICAO1.Items.Add("KBOI")
		cmbICAO1.Items.Add("KCAE")
		cmbICAO1.Items.Add("KEWK")
		cmbICAO1.Items.Add("KICT")
		cmbICAO1.Items.Add("KIDP")
		cmbICAO1.Items.Add("KJNU")
		cmbICAO1.Items.Add("KMIA")
		cmbICAO1.Items.Add("KMSP")
		cmbICAO1.Items.Add("KNUD")
		cmbICAO1.Items.Add("KOAK")
		cmbICAO1.Items.Add("KPDK")
		cmbICAO1.Items.Add("KVRB")
		cmbICAO1.Items.Add("LCPH")
		cmbICAO1.Items.Add("LEMD")
		cmbICAO1.Items.Add("LEMG")
		cmbICAO1.Items.Add("LFPN")
		cmbICAO1.Items.Add("LGAT")
		cmbICAO1.Items.Add("LGIR")
		cmbICAO1.Items.Add("LIRA")
		cmbICAO1.Items.Add("LKPR")
		cmbICAO1.Items.Add("LPAZ")
		cmbICAO1.Items.Add("LPPR")
		cmbICAO1.Items.Add("LROP")
		cmbICAO1.Items.Add("LTAC")
		cmbICAO1.Items.Add("LTBA")
		cmbICAO1.Items.Add("MROC")
		cmbICAO1.Items.Add("NTSU")
		cmbICAO1.Items.Add("NZAA")
		cmbICAO1.Items.Add("OOMS")
		cmbICAO1.Items.Add("OPKC")
		cmbICAO1.Items.Add("PAOM")
		cmbICAO1.Items.Add("PGSN")
		cmbICAO1.Items.Add("PHNL")
		cmbICAO1.Items.Add("PHTO")
		cmbICAO1.Items.Add("PKMJ")
		cmbICAO1.Items.Add("PLCH")
		cmbICAO1.Items.Add("PMDY")
		cmbICAO1.Items.Add("PTRO")
		cmbICAO1.Items.Add("PWAK")
		cmbICAO1.Items.Add("RCTP")
		cmbICAO1.Items.Add("RJCK")
		cmbICAO1.Items.Add("RJTT")
		cmbICAO1.Items.Add("RKSS")
		cmbICAO1.Items.Add("RPMM")
		cmbICAO1.Items.Add("SAEZ")
		cmbICAO1.Items.Add("SBEG")
		cmbICAO1.Items.Add("SBGL")
		cmbICAO1.Items.Add("SBSP")
		cmbICAO1.Items.Add("SCEL")
		cmbICAO1.Items.Add("SVMG")
		cmbICAO1.Items.Add("TTPP")
		cmbICAO1.Items.Add("UHHH")
		cmbICAO1.Items.Add("UHMM")
		cmbICAO1.Items.Add("UHPP")
		cmbICAO1.Items.Add("UHSS")
		cmbICAO1.Items.Add("UTTT")
		cmbICAO1.Items.Add("UUEE")
		cmbICAO1.Items.Add("VABB")
		cmbICAO1.Items.Add("VCBI")
		cmbICAO1.Items.Add("VIDP")
		cmbICAO1.Items.Add("VNKT")
		cmbICAO1.Items.Add("VOMM")
		cmbICAO1.Items.Add("VOPB")
		cmbICAO1.Items.Add("VRMM")
		cmbICAO1.Items.Add("VTBD")
		cmbICAO1.Items.Add("WMKJ")
		cmbICAO1.Items.Add("WMKK")
		cmbICAO1.Items.Add("WSSL")
		cmbICAO1.Items.Add("ZGGG")
		cmbICAO1.Items.Add("Other")

		cmbICAO2.Items.Add("ASSY")
		cmbICAO2.Items.Add("AYPY")
		cmbICAO2.Items.Add("BGBW")
		cmbICAO2.Items.Add("BGGH")
		cmbICAO2.Items.Add("BIRK")
		cmbICAO2.Items.Add("CYAM")
		cmbICAO2.Items.Add("CYFB")
		cmbICAO2.Items.Add("CYQX")
		cmbICAO2.Items.Add("CYYQ")
		cmbICAO2.Items.Add("CYYR")
		cmbICAO2.Items.Add("CYYT")
		cmbICAO2.Items.Add("DAAG")
		cmbICAO2.Items.Add("DIAP")
		cmbICAO2.Items.Add("DNMM")
		cmbICAO2.Items.Add("DRRN")
		cmbICAO2.Items.Add("EBBR")
		cmbICAO2.Items.Add("EDDW")
		cmbICAO2.Items.Add("EFHK")
		cmbICAO2.Items.Add("EGPD")
		cmbICAO2.Items.Add("EGPK")
		cmbICAO2.Items.Add("EHBK")
		cmbICAO2.Items.Add("EINN")
		cmbICAO2.Items.Add("EKCH")
		cmbICAO2.Items.Add("ELLX")
		cmbICAO2.Items.Add("ENBR")
		cmbICAO2.Items.Add("FAGM")
		cmbICAO2.Items.Add("FALA")
		cmbICAO2.Items.Add("FAWM")
		cmbICAO2.Items.Add("FCBB")
		cmbICAO2.Items.Add("FEFF")
		cmbICAO2.Items.Add("FMMI")
		cmbICAO2.Items.Add("FNLU")
		cmbICAO2.Items.Add("FOOL")
		cmbICAO2.Items.Add("FSIA")
		cmbICAO2.Items.Add("FVHA")
		cmbICAO2.Items.Add("FZNA")
		cmbICAO2.Items.Add("GBYD")
		cmbICAO2.Items.Add("GCXO")
		cmbICAO2.Items.Add("GMAA")
		cmbICAO2.Items.Add("GOOY")
		cmbICAO2.Items.Add("HELX")
		cmbICAO2.Items.Add("HKNW")
		cmbICAO2.Items.Add("HSSS")
		cmbICAO2.Items.Add("HTDA")
		cmbICAO2.Items.Add("I69")
		cmbICAO2.Items.Add("KANC")
		cmbICAO2.Items.Add("KBGR")
		cmbICAO2.Items.Add("KBOI")
		cmbICAO2.Items.Add("KCAE")
		cmbICAO2.Items.Add("KEWK")
		cmbICAO2.Items.Add("KICT")
		cmbICAO2.Items.Add("KIDP")
		cmbICAO2.Items.Add("KJNU")
		cmbICAO2.Items.Add("KMIA")
		cmbICAO2.Items.Add("KMSP")
		cmbICAO2.Items.Add("KNUD")
		cmbICAO2.Items.Add("KOAK")
		cmbICAO2.Items.Add("KPDK")
		cmbICAO2.Items.Add("KVRB")
		cmbICAO2.Items.Add("LCPH")
		cmbICAO2.Items.Add("LEMD")
		cmbICAO2.Items.Add("LEMG")
		cmbICAO2.Items.Add("LFPN")
		cmbICAO2.Items.Add("LGAT")
		cmbICAO2.Items.Add("LGIR")
		cmbICAO2.Items.Add("LIRA")
		cmbICAO2.Items.Add("LKPR")
		cmbICAO2.Items.Add("LPAZ")
		cmbICAO2.Items.Add("LPPR")
		cmbICAO2.Items.Add("LROP")
		cmbICAO2.Items.Add("LTAC")
		cmbICAO2.Items.Add("LTBA")
		cmbICAO2.Items.Add("MROC")
		cmbICAO2.Items.Add("NTSU")
		cmbICAO2.Items.Add("NZAA")
		cmbICAO2.Items.Add("OOMS")
		cmbICAO2.Items.Add("OPKC")
		cmbICAO2.Items.Add("PAOM")
		cmbICAO2.Items.Add("PGSN")
		cmbICAO2.Items.Add("PHNL")
		cmbICAO2.Items.Add("PHTO")
		cmbICAO2.Items.Add("PKMJ")
		cmbICAO2.Items.Add("PLCH")
		cmbICAO2.Items.Add("PMDY")
		cmbICAO2.Items.Add("PTRO")
		cmbICAO2.Items.Add("PWAK")
		cmbICAO2.Items.Add("RCTP")
		cmbICAO2.Items.Add("RJCK")
		cmbICAO2.Items.Add("RJTT")
		cmbICAO2.Items.Add("RKSS")
		cmbICAO2.Items.Add("RPMM")
		cmbICAO2.Items.Add("SAEZ")
		cmbICAO2.Items.Add("SBEG")
		cmbICAO2.Items.Add("SBGL")
		cmbICAO2.Items.Add("SBSP")
		cmbICAO2.Items.Add("SCEL")
		cmbICAO2.Items.Add("SVMG")
		cmbICAO2.Items.Add("TTPP")
		cmbICAO2.Items.Add("UHHH")
		cmbICAO2.Items.Add("UHMM")
		cmbICAO2.Items.Add("UHPP")
		cmbICAO2.Items.Add("UHSS")
		cmbICAO2.Items.Add("UTTT")
		cmbICAO2.Items.Add("UUEE")
		cmbICAO2.Items.Add("VABB")
		cmbICAO2.Items.Add("VCBI")
		cmbICAO2.Items.Add("VIDP")
		cmbICAO2.Items.Add("VNKT")
		cmbICAO2.Items.Add("VOMM")
		cmbICAO2.Items.Add("VOPB")
		cmbICAO2.Items.Add("VRMM")
		cmbICAO2.Items.Add("VTBD")
		cmbICAO2.Items.Add("WMKJ")
		cmbICAO2.Items.Add("WMKK")
		cmbICAO2.Items.Add("WSSL")
		cmbICAO2.Items.Add("ZGGG")
		cmbICAO2.Items.Add("Other")

		cmbICAO3.Items.Add("ASSY")
		cmbICAO3.Items.Add("AYPY")
		cmbICAO3.Items.Add("BGBW")
		cmbICAO3.Items.Add("BGGH")
		cmbICAO3.Items.Add("BIRK")
		cmbICAO3.Items.Add("CYAM")
		cmbICAO3.Items.Add("CYFB")
		cmbICAO3.Items.Add("CYQX")
		cmbICAO3.Items.Add("CYYQ")
		cmbICAO3.Items.Add("CYYR")
		cmbICAO3.Items.Add("CYYT")
		cmbICAO3.Items.Add("DAAG")
		cmbICAO3.Items.Add("DIAP")
		cmbICAO3.Items.Add("DNMM")
		cmbICAO3.Items.Add("DRRN")
		cmbICAO3.Items.Add("EBBR")
		cmbICAO3.Items.Add("EDDW")
		cmbICAO3.Items.Add("EFHK")
		cmbICAO3.Items.Add("EGPD")
		cmbICAO3.Items.Add("EGPK")
		cmbICAO3.Items.Add("EHBK")
		cmbICAO3.Items.Add("EINN")
		cmbICAO3.Items.Add("EKCH")
		cmbICAO3.Items.Add("ELLX")
		cmbICAO3.Items.Add("ENBR")
		cmbICAO3.Items.Add("FAGM")
		cmbICAO3.Items.Add("FALA")
		cmbICAO3.Items.Add("FAWM")
		cmbICAO3.Items.Add("FCBB")
		cmbICAO3.Items.Add("FEFF")
		cmbICAO3.Items.Add("FMMI")
		cmbICAO3.Items.Add("FNLU")
		cmbICAO3.Items.Add("FOOL")
		cmbICAO3.Items.Add("FSIA")
		cmbICAO3.Items.Add("FVHA")
		cmbICAO3.Items.Add("FZNA")
		cmbICAO3.Items.Add("GBYD")
		cmbICAO3.Items.Add("GCXO")
		cmbICAO3.Items.Add("GMAA")
		cmbICAO3.Items.Add("GOOY")
		cmbICAO3.Items.Add("HELX")
		cmbICAO3.Items.Add("HKNW")
		cmbICAO3.Items.Add("HSSS")
		cmbICAO3.Items.Add("HTDA")
		cmbICAO3.Items.Add("I69")
		cmbICAO3.Items.Add("KANC")
		cmbICAO3.Items.Add("KBGR")
		cmbICAO3.Items.Add("KBOI")
		cmbICAO3.Items.Add("KCAE")
		cmbICAO3.Items.Add("KEWK")
		cmbICAO3.Items.Add("KICT")
		cmbICAO3.Items.Add("KIDP")
		cmbICAO3.Items.Add("KJNU")
		cmbICAO3.Items.Add("KMIA")
		cmbICAO3.Items.Add("KMSP")
		cmbICAO3.Items.Add("KNUD")
		cmbICAO3.Items.Add("KOAK")
		cmbICAO3.Items.Add("KPDK")
		cmbICAO3.Items.Add("KVRB")
		cmbICAO3.Items.Add("LCPH")
		cmbICAO3.Items.Add("LEMD")
		cmbICAO3.Items.Add("LEMG")
		cmbICAO3.Items.Add("LFPN")
		cmbICAO3.Items.Add("LGAT")
		cmbICAO3.Items.Add("LGIR")
		cmbICAO3.Items.Add("LIRA")
		cmbICAO3.Items.Add("LKPR")
		cmbICAO3.Items.Add("LPAZ")
		cmbICAO3.Items.Add("LPPR")
		cmbICAO3.Items.Add("LROP")
		cmbICAO3.Items.Add("LTAC")
		cmbICAO3.Items.Add("LTBA")
		cmbICAO3.Items.Add("MROC")
		cmbICAO3.Items.Add("NTSU")
		cmbICAO3.Items.Add("NZAA")
		cmbICAO3.Items.Add("OOMS")
		cmbICAO3.Items.Add("OPKC")
		cmbICAO3.Items.Add("PAOM")
		cmbICAO3.Items.Add("PGSN")
		cmbICAO3.Items.Add("PHNL")
		cmbICAO3.Items.Add("PHTO")
		cmbICAO3.Items.Add("PKMJ")
		cmbICAO3.Items.Add("PLCH")
		cmbICAO3.Items.Add("PMDY")
		cmbICAO3.Items.Add("PTRO")
		cmbICAO3.Items.Add("PWAK")
		cmbICAO3.Items.Add("RCTP")
		cmbICAO3.Items.Add("RJCK")
		cmbICAO3.Items.Add("RJTT")
		cmbICAO3.Items.Add("RKSS")
		cmbICAO3.Items.Add("RPMM")
		cmbICAO3.Items.Add("SAEZ")
		cmbICAO3.Items.Add("SBEG")
		cmbICAO3.Items.Add("SBGL")
		cmbICAO3.Items.Add("SBSP")
		cmbICAO3.Items.Add("SCEL")
		cmbICAO3.Items.Add("SVMG")
		cmbICAO3.Items.Add("TTPP")
		cmbICAO3.Items.Add("UHHH")
		cmbICAO3.Items.Add("UHMM")
		cmbICAO3.Items.Add("UHPP")
		cmbICAO3.Items.Add("UHSS")
		cmbICAO3.Items.Add("UTTT")
		cmbICAO3.Items.Add("UUEE")
		cmbICAO3.Items.Add("VABB")
		cmbICAO3.Items.Add("VCBI")
		cmbICAO3.Items.Add("VIDP")
		cmbICAO3.Items.Add("VNKT")
		cmbICAO3.Items.Add("VOMM")
		cmbICAO3.Items.Add("VOPB")
		cmbICAO3.Items.Add("VRMM")
		cmbICAO3.Items.Add("VTBD")
		cmbICAO3.Items.Add("WMKJ")
		cmbICAO3.Items.Add("WMKK")
		cmbICAO3.Items.Add("WSSL")
		cmbICAO3.Items.Add("ZGGG")
		cmbICAO3.Items.Add("Other")

		cmbICAO4.Items.Add("ASSY")
		cmbICAO4.Items.Add("AYPY")
		cmbICAO4.Items.Add("BGBW")
		cmbICAO4.Items.Add("BGGH")
		cmbICAO4.Items.Add("BIRK")
		cmbICAO4.Items.Add("CYAM")
		cmbICAO4.Items.Add("CYFB")
		cmbICAO4.Items.Add("CYQX")
		cmbICAO4.Items.Add("CYYQ")
		cmbICAO4.Items.Add("CYYR")
		cmbICAO4.Items.Add("CYYT")
		cmbICAO4.Items.Add("DAAG")
		cmbICAO4.Items.Add("DIAP")
		cmbICAO4.Items.Add("DNMM")
		cmbICAO4.Items.Add("DRRN")
		cmbICAO4.Items.Add("EBBR")
		cmbICAO4.Items.Add("EDDW")
		cmbICAO4.Items.Add("EFHK")
		cmbICAO4.Items.Add("EGPD")
		cmbICAO4.Items.Add("EGPK")
		cmbICAO4.Items.Add("EHBK")
		cmbICAO4.Items.Add("EINN")
		cmbICAO4.Items.Add("EKCH")
		cmbICAO4.Items.Add("ELLX")
		cmbICAO4.Items.Add("ENBR")
		cmbICAO4.Items.Add("FAGM")
		cmbICAO4.Items.Add("FALA")
		cmbICAO4.Items.Add("FAWM")
		cmbICAO4.Items.Add("FCBB")
		cmbICAO4.Items.Add("FEFF")
		cmbICAO4.Items.Add("FMMI")
		cmbICAO4.Items.Add("FNLU")
		cmbICAO4.Items.Add("FOOL")
		cmbICAO4.Items.Add("FSIA")
		cmbICAO4.Items.Add("FVHA")
		cmbICAO4.Items.Add("FZNA")
		cmbICAO4.Items.Add("GBYD")
		cmbICAO4.Items.Add("GCXO")
		cmbICAO4.Items.Add("GMAA")
		cmbICAO4.Items.Add("GOOY")
		cmbICAO4.Items.Add("HELX")
		cmbICAO4.Items.Add("HKNW")
		cmbICAO4.Items.Add("HSSS")
		cmbICAO4.Items.Add("HTDA")
		cmbICAO4.Items.Add("I69")
		cmbICAO4.Items.Add("KANC")
		cmbICAO4.Items.Add("KBGR")
		cmbICAO4.Items.Add("KBOI")
		cmbICAO4.Items.Add("KCAE")
		cmbICAO4.Items.Add("KEWK")
		cmbICAO4.Items.Add("KICT")
		cmbICAO4.Items.Add("KIDP")
		cmbICAO4.Items.Add("KJNU")
		cmbICAO4.Items.Add("KMIA")
		cmbICAO4.Items.Add("KMSP")
		cmbICAO4.Items.Add("KNUD")
		cmbICAO4.Items.Add("KOAK")
		cmbICAO4.Items.Add("KPDK")
		cmbICAO4.Items.Add("KVRB")
		cmbICAO4.Items.Add("LCPH")
		cmbICAO4.Items.Add("LEMD")
		cmbICAO4.Items.Add("LEMG")
		cmbICAO4.Items.Add("LFPN")
		cmbICAO4.Items.Add("LGAT")
		cmbICAO4.Items.Add("LGIR")
		cmbICAO4.Items.Add("LIRA")
		cmbICAO4.Items.Add("LKPR")
		cmbICAO4.Items.Add("LPAZ")
		cmbICAO4.Items.Add("LPPR")
		cmbICAO4.Items.Add("LROP")
		cmbICAO4.Items.Add("LTAC")
		cmbICAO4.Items.Add("LTBA")
		cmbICAO4.Items.Add("MROC")
		cmbICAO4.Items.Add("NTSU")
		cmbICAO4.Items.Add("NZAA")
		cmbICAO4.Items.Add("OOMS")
		cmbICAO4.Items.Add("OPKC")
		cmbICAO4.Items.Add("PAOM")
		cmbICAO4.Items.Add("PGSN")
		cmbICAO4.Items.Add("PHNL")
		cmbICAO4.Items.Add("PHTO")
		cmbICAO4.Items.Add("PKMJ")
		cmbICAO4.Items.Add("PLCH")
		cmbICAO4.Items.Add("PMDY")
		cmbICAO4.Items.Add("PTRO")
		cmbICAO4.Items.Add("PWAK")
		cmbICAO4.Items.Add("RCTP")
		cmbICAO4.Items.Add("RJCK")
		cmbICAO4.Items.Add("RJTT")
		cmbICAO4.Items.Add("RKSS")
		cmbICAO4.Items.Add("RPMM")
		cmbICAO4.Items.Add("SAEZ")
		cmbICAO4.Items.Add("SBEG")
		cmbICAO4.Items.Add("SBGL")
		cmbICAO4.Items.Add("SBSP")
		cmbICAO4.Items.Add("SCEL")
		cmbICAO4.Items.Add("SVMG")
		cmbICAO4.Items.Add("TTPP")
		cmbICAO4.Items.Add("UHHH")
		cmbICAO4.Items.Add("UHMM")
		cmbICAO4.Items.Add("UHPP")
		cmbICAO4.Items.Add("UHSS")
		cmbICAO4.Items.Add("UTTT")
		cmbICAO4.Items.Add("UUEE")
		cmbICAO4.Items.Add("VABB")
		cmbICAO4.Items.Add("VCBI")
		cmbICAO4.Items.Add("VIDP")
		cmbICAO4.Items.Add("VNKT")
		cmbICAO4.Items.Add("VOMM")
		cmbICAO4.Items.Add("VOPB")
		cmbICAO4.Items.Add("VRMM")
		cmbICAO4.Items.Add("VTBD")
		cmbICAO4.Items.Add("WMKJ")
		cmbICAO4.Items.Add("WMKK")
		cmbICAO4.Items.Add("WSSL")
		cmbICAO4.Items.Add("ZGGG")
		cmbICAO4.Items.Add("Other")

		cmbICAO5.Items.Add("ASSY")
		cmbICAO5.Items.Add("AYPY")
		cmbICAO5.Items.Add("BGBW")
		cmbICAO5.Items.Add("BGGH")
		cmbICAO5.Items.Add("BIRK")
		cmbICAO5.Items.Add("CYAM")
		cmbICAO5.Items.Add("CYFB")
		cmbICAO5.Items.Add("CYQX")
		cmbICAO5.Items.Add("CYYQ")
		cmbICAO5.Items.Add("CYYR")
		cmbICAO5.Items.Add("CYYT")
		cmbICAO5.Items.Add("DAAG")
		cmbICAO5.Items.Add("DIAP")
		cmbICAO5.Items.Add("DNMM")
		cmbICAO5.Items.Add("DRRN")
		cmbICAO5.Items.Add("EBBR")
		cmbICAO5.Items.Add("EDDW")
		cmbICAO5.Items.Add("EFHK")
		cmbICAO5.Items.Add("EGPD")
		cmbICAO5.Items.Add("EGPK")
		cmbICAO5.Items.Add("EHBK")
		cmbICAO5.Items.Add("EINN")
		cmbICAO5.Items.Add("EKCH")
		cmbICAO5.Items.Add("ELLX")
		cmbICAO5.Items.Add("ENBR")
		cmbICAO5.Items.Add("FAGM")
		cmbICAO5.Items.Add("FALA")
		cmbICAO5.Items.Add("FAWM")
		cmbICAO5.Items.Add("FCBB")
		cmbICAO5.Items.Add("FEFF")
		cmbICAO5.Items.Add("FMMI")
		cmbICAO5.Items.Add("FNLU")
		cmbICAO5.Items.Add("FOOL")
		cmbICAO5.Items.Add("FSIA")
		cmbICAO5.Items.Add("FVHA")
		cmbICAO5.Items.Add("FZNA")
		cmbICAO5.Items.Add("GBYD")
		cmbICAO5.Items.Add("GCXO")
		cmbICAO5.Items.Add("GMAA")
		cmbICAO5.Items.Add("GOOY")
		cmbICAO5.Items.Add("HELX")
		cmbICAO5.Items.Add("HKNW")
		cmbICAO5.Items.Add("HSSS")
		cmbICAO5.Items.Add("HTDA")
		cmbICAO5.Items.Add("I69")
		cmbICAO5.Items.Add("KANC")
		cmbICAO5.Items.Add("KBGR")
		cmbICAO5.Items.Add("KBOI")
		cmbICAO5.Items.Add("KCAE")
		cmbICAO5.Items.Add("KEWK")
		cmbICAO5.Items.Add("KICT")
		cmbICAO5.Items.Add("KIDP")
		cmbICAO5.Items.Add("KJNU")
		cmbICAO5.Items.Add("KMIA")
		cmbICAO5.Items.Add("KMSP")
		cmbICAO5.Items.Add("KNUD")
		cmbICAO5.Items.Add("KOAK")
		cmbICAO5.Items.Add("KPDK")
		cmbICAO5.Items.Add("KVRB")
		cmbICAO5.Items.Add("LCPH")
		cmbICAO5.Items.Add("LEMD")
		cmbICAO5.Items.Add("LEMG")
		cmbICAO5.Items.Add("LFPN")
		cmbICAO5.Items.Add("LGAT")
		cmbICAO5.Items.Add("LGIR")
		cmbICAO5.Items.Add("LIRA")
		cmbICAO5.Items.Add("LKPR")
		cmbICAO5.Items.Add("LPAZ")
		cmbICAO5.Items.Add("LPPR")
		cmbICAO5.Items.Add("LROP")
		cmbICAO5.Items.Add("LTAC")
		cmbICAO5.Items.Add("LTBA")
		cmbICAO5.Items.Add("MROC")
		cmbICAO5.Items.Add("NTSU")
		cmbICAO5.Items.Add("NZAA")
		cmbICAO5.Items.Add("OOMS")
		cmbICAO5.Items.Add("OPKC")
		cmbICAO5.Items.Add("PAOM")
		cmbICAO5.Items.Add("PGSN")
		cmbICAO5.Items.Add("PHNL")
		cmbICAO5.Items.Add("PHTO")
		cmbICAO5.Items.Add("PKMJ")
		cmbICAO5.Items.Add("PLCH")
		cmbICAO5.Items.Add("PMDY")
		cmbICAO5.Items.Add("PTRO")
		cmbICAO5.Items.Add("PWAK")
		cmbICAO5.Items.Add("RCTP")
		cmbICAO5.Items.Add("RJCK")
		cmbICAO5.Items.Add("RJTT")
		cmbICAO5.Items.Add("RKSS")
		cmbICAO5.Items.Add("RPMM")
		cmbICAO5.Items.Add("SAEZ")
		cmbICAO5.Items.Add("SBEG")
		cmbICAO5.Items.Add("SBGL")
		cmbICAO5.Items.Add("SBSP")
		cmbICAO5.Items.Add("SCEL")
		cmbICAO5.Items.Add("SVMG")
		cmbICAO5.Items.Add("TTPP")
		cmbICAO5.Items.Add("UHHH")
		cmbICAO5.Items.Add("UHMM")
		cmbICAO5.Items.Add("UHPP")
		cmbICAO5.Items.Add("UHSS")
		cmbICAO5.Items.Add("UTTT")
		cmbICAO5.Items.Add("UUEE")
		cmbICAO5.Items.Add("VABB")
		cmbICAO5.Items.Add("VCBI")
		cmbICAO5.Items.Add("VIDP")
		cmbICAO5.Items.Add("VNKT")
		cmbICAO5.Items.Add("VOMM")
		cmbICAO5.Items.Add("VOPB")
		cmbICAO5.Items.Add("VRMM")
		cmbICAO5.Items.Add("VTBD")
		cmbICAO5.Items.Add("WMKJ")
		cmbICAO5.Items.Add("WMKK")
		cmbICAO5.Items.Add("WSSL")
		cmbICAO5.Items.Add("ZGGG")
		cmbICAO5.Items.Add("Other")

		cmbICAO6.Items.Add("ASSY")
		cmbICAO6.Items.Add("AYPY")
		cmbICAO6.Items.Add("BGBW")
		cmbICAO6.Items.Add("BGGH")
		cmbICAO6.Items.Add("BIRK")
		cmbICAO6.Items.Add("CYAM")
		cmbICAO6.Items.Add("CYFB")
		cmbICAO6.Items.Add("CYQX")
		cmbICAO6.Items.Add("CYYQ")
		cmbICAO6.Items.Add("CYYR")
		cmbICAO6.Items.Add("CYYT")
		cmbICAO6.Items.Add("DAAG")
		cmbICAO6.Items.Add("DIAP")
		cmbICAO6.Items.Add("DNMM")
		cmbICAO6.Items.Add("DRRN")
		cmbICAO6.Items.Add("EBBR")
		cmbICAO6.Items.Add("EDDW")
		cmbICAO6.Items.Add("EFHK")
		cmbICAO6.Items.Add("EGPD")
		cmbICAO6.Items.Add("EGPK")
		cmbICAO6.Items.Add("EHBK")
		cmbICAO6.Items.Add("EINN")
		cmbICAO6.Items.Add("EKCH")
		cmbICAO6.Items.Add("ELLX")
		cmbICAO6.Items.Add("ENBR")
		cmbICAO6.Items.Add("FAGM")
		cmbICAO6.Items.Add("FALA")
		cmbICAO6.Items.Add("FAWM")
		cmbICAO6.Items.Add("FCBB")
		cmbICAO6.Items.Add("FEFF")
		cmbICAO6.Items.Add("FMMI")
		cmbICAO6.Items.Add("FNLU")
		cmbICAO6.Items.Add("FOOL")
		cmbICAO6.Items.Add("FSIA")
		cmbICAO6.Items.Add("FVHA")
		cmbICAO6.Items.Add("FZNA")
		cmbICAO6.Items.Add("GBYD")
		cmbICAO6.Items.Add("GCXO")
		cmbICAO6.Items.Add("GMAA")
		cmbICAO6.Items.Add("GOOY")
		cmbICAO6.Items.Add("HELX")
		cmbICAO6.Items.Add("HKNW")
		cmbICAO6.Items.Add("HSSS")
		cmbICAO6.Items.Add("HTDA")
		cmbICAO6.Items.Add("I69")
		cmbICAO6.Items.Add("KANC")
		cmbICAO6.Items.Add("KBGR")
		cmbICAO6.Items.Add("KBOI")
		cmbICAO6.Items.Add("KCAE")
		cmbICAO6.Items.Add("KEWK")
		cmbICAO6.Items.Add("KICT")
		cmbICAO6.Items.Add("KIDP")
		cmbICAO6.Items.Add("KJNU")
		cmbICAO6.Items.Add("KMIA")
		cmbICAO6.Items.Add("KMSP")
		cmbICAO6.Items.Add("KNUD")
		cmbICAO6.Items.Add("KOAK")
		cmbICAO6.Items.Add("KPDK")
		cmbICAO6.Items.Add("KVRB")
		cmbICAO6.Items.Add("LCPH")
		cmbICAO6.Items.Add("LEMD")
		cmbICAO6.Items.Add("LEMG")
		cmbICAO6.Items.Add("LFPN")
		cmbICAO6.Items.Add("LGAT")
		cmbICAO6.Items.Add("LGIR")
		cmbICAO6.Items.Add("LIRA")
		cmbICAO6.Items.Add("LKPR")
		cmbICAO6.Items.Add("LPAZ")
		cmbICAO6.Items.Add("LPPR")
		cmbICAO6.Items.Add("LROP")
		cmbICAO6.Items.Add("LTAC")
		cmbICAO6.Items.Add("LTBA")
		cmbICAO6.Items.Add("MROC")
		cmbICAO6.Items.Add("NTSU")
		cmbICAO6.Items.Add("NZAA")
		cmbICAO6.Items.Add("OOMS")
		cmbICAO6.Items.Add("OPKC")
		cmbICAO6.Items.Add("PAOM")
		cmbICAO6.Items.Add("PGSN")
		cmbICAO6.Items.Add("PHNL")
		cmbICAO6.Items.Add("PHTO")
		cmbICAO6.Items.Add("PKMJ")
		cmbICAO6.Items.Add("PLCH")
		cmbICAO6.Items.Add("PMDY")
		cmbICAO6.Items.Add("PTRO")
		cmbICAO6.Items.Add("PWAK")
		cmbICAO6.Items.Add("RCTP")
		cmbICAO6.Items.Add("RJCK")
		cmbICAO6.Items.Add("RJTT")
		cmbICAO6.Items.Add("RKSS")
		cmbICAO6.Items.Add("RPMM")
		cmbICAO6.Items.Add("SAEZ")
		cmbICAO6.Items.Add("SBEG")
		cmbICAO6.Items.Add("SBGL")
		cmbICAO6.Items.Add("SBSP")
		cmbICAO6.Items.Add("SCEL")
		cmbICAO6.Items.Add("SVMG")
		cmbICAO6.Items.Add("TTPP")
		cmbICAO6.Items.Add("UHHH")
		cmbICAO6.Items.Add("UHMM")
		cmbICAO6.Items.Add("UHPP")
		cmbICAO6.Items.Add("UHSS")
		cmbICAO6.Items.Add("UTTT")
		cmbICAO6.Items.Add("UUEE")
		cmbICAO6.Items.Add("VABB")
		cmbICAO6.Items.Add("VCBI")
		cmbICAO6.Items.Add("VIDP")
		cmbICAO6.Items.Add("VNKT")
		cmbICAO6.Items.Add("VOMM")
		cmbICAO6.Items.Add("VOPB")
		cmbICAO6.Items.Add("VRMM")
		cmbICAO6.Items.Add("VTBD")
		cmbICAO6.Items.Add("WMKJ")
		cmbICAO6.Items.Add("WMKK")
		cmbICAO6.Items.Add("WSSL")
		cmbICAO6.Items.Add("ZGGG")
		cmbICAO6.Items.Add("Other")

		cmbICAO7.Items.Add("ASSY")
		cmbICAO7.Items.Add("AYPY")
		cmbICAO7.Items.Add("BGBW")
		cmbICAO7.Items.Add("BGGH")
		cmbICAO7.Items.Add("BIRK")
		cmbICAO7.Items.Add("CYAM")
		cmbICAO7.Items.Add("CYFB")
		cmbICAO7.Items.Add("CYQX")
		cmbICAO7.Items.Add("CYYQ")
		cmbICAO7.Items.Add("CYYR")
		cmbICAO7.Items.Add("CYYT")
		cmbICAO7.Items.Add("DAAG")
		cmbICAO7.Items.Add("DIAP")
		cmbICAO7.Items.Add("DNMM")
		cmbICAO7.Items.Add("DRRN")
		cmbICAO7.Items.Add("EBBR")
		cmbICAO7.Items.Add("EDDW")
		cmbICAO7.Items.Add("EFHK")
		cmbICAO7.Items.Add("EGPD")
		cmbICAO7.Items.Add("EGPK")
		cmbICAO7.Items.Add("EHBK")
		cmbICAO7.Items.Add("EINN")
		cmbICAO7.Items.Add("EKCH")
		cmbICAO7.Items.Add("ELLX")
		cmbICAO7.Items.Add("ENBR")
		cmbICAO7.Items.Add("FAGM")
		cmbICAO7.Items.Add("FALA")
		cmbICAO7.Items.Add("FAWM")
		cmbICAO7.Items.Add("FCBB")
		cmbICAO7.Items.Add("FEFF")
		cmbICAO7.Items.Add("FMMI")
		cmbICAO7.Items.Add("FNLU")
		cmbICAO7.Items.Add("FOOL")
		cmbICAO7.Items.Add("FSIA")
		cmbICAO7.Items.Add("FVHA")
		cmbICAO7.Items.Add("FZNA")
		cmbICAO7.Items.Add("GBYD")
		cmbICAO7.Items.Add("GCXO")
		cmbICAO7.Items.Add("GMAA")
		cmbICAO7.Items.Add("GOOY")
		cmbICAO7.Items.Add("HELX")
		cmbICAO7.Items.Add("HKNW")
		cmbICAO7.Items.Add("HSSS")
		cmbICAO7.Items.Add("HTDA")
		cmbICAO7.Items.Add("I69")
		cmbICAO7.Items.Add("KANC")
		cmbICAO7.Items.Add("KBGR")
		cmbICAO7.Items.Add("KBOI")
		cmbICAO7.Items.Add("KCAE")
		cmbICAO7.Items.Add("KEWK")
		cmbICAO7.Items.Add("KICT")
		cmbICAO7.Items.Add("KIDP")
		cmbICAO7.Items.Add("KJNU")
		cmbICAO7.Items.Add("KMIA")
		cmbICAO7.Items.Add("KMSP")
		cmbICAO7.Items.Add("KNUD")
		cmbICAO7.Items.Add("KOAK")
		cmbICAO7.Items.Add("KPDK")
		cmbICAO7.Items.Add("KVRB")
		cmbICAO7.Items.Add("LCPH")
		cmbICAO7.Items.Add("LEMD")
		cmbICAO7.Items.Add("LEMG")
		cmbICAO7.Items.Add("LFPN")
		cmbICAO7.Items.Add("LGAT")
		cmbICAO7.Items.Add("LGIR")
		cmbICAO7.Items.Add("LIRA")
		cmbICAO7.Items.Add("LKPR")
		cmbICAO7.Items.Add("LPAZ")
		cmbICAO7.Items.Add("LPPR")
		cmbICAO7.Items.Add("LROP")
		cmbICAO7.Items.Add("LTAC")
		cmbICAO7.Items.Add("LTBA")
		cmbICAO7.Items.Add("MROC")
		cmbICAO7.Items.Add("NTSU")
		cmbICAO7.Items.Add("NZAA")
		cmbICAO7.Items.Add("OOMS")
		cmbICAO7.Items.Add("OPKC")
		cmbICAO7.Items.Add("PAOM")
		cmbICAO7.Items.Add("PGSN")
		cmbICAO7.Items.Add("PHNL")
		cmbICAO7.Items.Add("PHTO")
		cmbICAO7.Items.Add("PKMJ")
		cmbICAO7.Items.Add("PLCH")
		cmbICAO7.Items.Add("PMDY")
		cmbICAO7.Items.Add("PTRO")
		cmbICAO7.Items.Add("PWAK")
		cmbICAO7.Items.Add("RCTP")
		cmbICAO7.Items.Add("RJCK")
		cmbICAO7.Items.Add("RJTT")
		cmbICAO7.Items.Add("RKSS")
		cmbICAO7.Items.Add("RPMM")
		cmbICAO7.Items.Add("SAEZ")
		cmbICAO7.Items.Add("SBEG")
		cmbICAO7.Items.Add("SBGL")
		cmbICAO7.Items.Add("SBSP")
		cmbICAO7.Items.Add("SCEL")
		cmbICAO7.Items.Add("SVMG")
		cmbICAO7.Items.Add("TTPP")
		cmbICAO7.Items.Add("UHHH")
		cmbICAO7.Items.Add("UHMM")
		cmbICAO7.Items.Add("UHPP")
		cmbICAO7.Items.Add("UHSS")
		cmbICAO7.Items.Add("UTTT")
		cmbICAO7.Items.Add("UUEE")
		cmbICAO7.Items.Add("VABB")
		cmbICAO7.Items.Add("VCBI")
		cmbICAO7.Items.Add("VIDP")
		cmbICAO7.Items.Add("VNKT")
		cmbICAO7.Items.Add("VOMM")
		cmbICAO7.Items.Add("VOPB")
		cmbICAO7.Items.Add("VRMM")
		cmbICAO7.Items.Add("VTBD")
		cmbICAO7.Items.Add("WMKJ")
		cmbICAO7.Items.Add("WMKK")
		cmbICAO7.Items.Add("WSSL")
		cmbICAO7.Items.Add("ZGGG")
		cmbICAO7.Items.Add("Other")

		cmbICAO8.Items.Add("ASSY")
		cmbICAO8.Items.Add("AYPY")
		cmbICAO8.Items.Add("BGBW")
		cmbICAO8.Items.Add("BGGH")
		cmbICAO8.Items.Add("BIRK")
		cmbICAO8.Items.Add("CYAM")
		cmbICAO8.Items.Add("CYFB")
		cmbICAO8.Items.Add("CYQX")
		cmbICAO8.Items.Add("CYYQ")
		cmbICAO8.Items.Add("CYYR")
		cmbICAO8.Items.Add("CYYT")
		cmbICAO8.Items.Add("DAAG")
		cmbICAO8.Items.Add("DIAP")
		cmbICAO8.Items.Add("DNMM")
		cmbICAO8.Items.Add("DRRN")
		cmbICAO8.Items.Add("EBBR")
		cmbICAO8.Items.Add("EDDW")
		cmbICAO8.Items.Add("EFHK")
		cmbICAO8.Items.Add("EGPD")
		cmbICAO8.Items.Add("EGPK")
		cmbICAO8.Items.Add("EHBK")
		cmbICAO8.Items.Add("EINN")
		cmbICAO8.Items.Add("EKCH")
		cmbICAO8.Items.Add("ELLX")
		cmbICAO8.Items.Add("ENBR")
		cmbICAO8.Items.Add("FAGM")
		cmbICAO8.Items.Add("FALA")
		cmbICAO8.Items.Add("FAWM")
		cmbICAO8.Items.Add("FCBB")
		cmbICAO8.Items.Add("FEFF")
		cmbICAO8.Items.Add("FMMI")
		cmbICAO8.Items.Add("FNLU")
		cmbICAO8.Items.Add("FOOL")
		cmbICAO8.Items.Add("FSIA")
		cmbICAO8.Items.Add("FVHA")
		cmbICAO8.Items.Add("FZNA")
		cmbICAO8.Items.Add("GBYD")
		cmbICAO8.Items.Add("GCXO")
		cmbICAO8.Items.Add("GMAA")
		cmbICAO8.Items.Add("GOOY")
		cmbICAO8.Items.Add("HELX")
		cmbICAO8.Items.Add("HKNW")
		cmbICAO8.Items.Add("HSSS")
		cmbICAO8.Items.Add("HTDA")
		cmbICAO8.Items.Add("I69")
		cmbICAO8.Items.Add("KANC")
		cmbICAO8.Items.Add("KBGR")
		cmbICAO8.Items.Add("KBOI")
		cmbICAO8.Items.Add("KCAE")
		cmbICAO8.Items.Add("KEWK")
		cmbICAO8.Items.Add("KICT")
		cmbICAO8.Items.Add("KIDP")
		cmbICAO8.Items.Add("KJNU")
		cmbICAO8.Items.Add("KMIA")
		cmbICAO8.Items.Add("KMSP")
		cmbICAO8.Items.Add("KNUD")
		cmbICAO8.Items.Add("KOAK")
		cmbICAO8.Items.Add("KPDK")
		cmbICAO8.Items.Add("KVRB")
		cmbICAO8.Items.Add("LCPH")
		cmbICAO8.Items.Add("LEMD")
		cmbICAO8.Items.Add("LEMG")
		cmbICAO8.Items.Add("LFPN")
		cmbICAO8.Items.Add("LGAT")
		cmbICAO8.Items.Add("LGIR")
		cmbICAO8.Items.Add("LIRA")
		cmbICAO8.Items.Add("LKPR")
		cmbICAO8.Items.Add("LPAZ")
		cmbICAO8.Items.Add("LPPR")
		cmbICAO8.Items.Add("LROP")
		cmbICAO8.Items.Add("LTAC")
		cmbICAO8.Items.Add("LTBA")
		cmbICAO8.Items.Add("MROC")
		cmbICAO8.Items.Add("NTSU")
		cmbICAO8.Items.Add("NZAA")
		cmbICAO8.Items.Add("OOMS")
		cmbICAO8.Items.Add("OPKC")
		cmbICAO8.Items.Add("PAOM")
		cmbICAO8.Items.Add("PGSN")
		cmbICAO8.Items.Add("PHNL")
		cmbICAO8.Items.Add("PHTO")
		cmbICAO8.Items.Add("PKMJ")
		cmbICAO8.Items.Add("PLCH")
		cmbICAO8.Items.Add("PMDY")
		cmbICAO8.Items.Add("PTRO")
		cmbICAO8.Items.Add("PWAK")
		cmbICAO8.Items.Add("RCTP")
		cmbICAO8.Items.Add("RJCK")
		cmbICAO8.Items.Add("RJTT")
		cmbICAO8.Items.Add("RKSS")
		cmbICAO8.Items.Add("RPMM")
		cmbICAO8.Items.Add("SAEZ")
		cmbICAO8.Items.Add("SBEG")
		cmbICAO8.Items.Add("SBGL")
		cmbICAO8.Items.Add("SBSP")
		cmbICAO8.Items.Add("SCEL")
		cmbICAO8.Items.Add("SVMG")
		cmbICAO8.Items.Add("TTPP")
		cmbICAO8.Items.Add("UHHH")
		cmbICAO8.Items.Add("UHMM")
		cmbICAO8.Items.Add("UHPP")
		cmbICAO8.Items.Add("UHSS")
		cmbICAO8.Items.Add("UTTT")
		cmbICAO8.Items.Add("UUEE")
		cmbICAO8.Items.Add("VABB")
		cmbICAO8.Items.Add("VCBI")
		cmbICAO8.Items.Add("VIDP")
		cmbICAO8.Items.Add("VNKT")
		cmbICAO8.Items.Add("VOMM")
		cmbICAO8.Items.Add("VOPB")
		cmbICAO8.Items.Add("VRMM")
		cmbICAO8.Items.Add("VTBD")
		cmbICAO8.Items.Add("WMKJ")
		cmbICAO8.Items.Add("WMKK")
		cmbICAO8.Items.Add("WSSL")
		cmbICAO8.Items.Add("ZGGG")
		cmbICAO8.Items.Add("Other")

		cmbICAO9.Items.Add("ASSY")
		cmbICAO9.Items.Add("AYPY")
		cmbICAO9.Items.Add("BGBW")
		cmbICAO9.Items.Add("BGGH")
		cmbICAO9.Items.Add("BIRK")
		cmbICAO9.Items.Add("CYAM")
		cmbICAO9.Items.Add("CYFB")
		cmbICAO9.Items.Add("CYQX")
		cmbICAO9.Items.Add("CYYQ")
		cmbICAO9.Items.Add("CYYR")
		cmbICAO9.Items.Add("CYYT")
		cmbICAO9.Items.Add("DAAG")
		cmbICAO9.Items.Add("DIAP")
		cmbICAO9.Items.Add("DNMM")
		cmbICAO9.Items.Add("DRRN")
		cmbICAO9.Items.Add("EBBR")
		cmbICAO9.Items.Add("EDDW")
		cmbICAO9.Items.Add("EFHK")
		cmbICAO9.Items.Add("EGPD")
		cmbICAO9.Items.Add("EGPK")
		cmbICAO9.Items.Add("EHBK")
		cmbICAO9.Items.Add("EINN")
		cmbICAO9.Items.Add("EKCH")
		cmbICAO9.Items.Add("ELLX")
		cmbICAO9.Items.Add("ENBR")
		cmbICAO9.Items.Add("FAGM")
		cmbICAO9.Items.Add("FALA")
		cmbICAO9.Items.Add("FAWM")
		cmbICAO9.Items.Add("FCBB")
		cmbICAO9.Items.Add("FEFF")
		cmbICAO9.Items.Add("FMMI")
		cmbICAO9.Items.Add("FNLU")
		cmbICAO9.Items.Add("FOOL")
		cmbICAO9.Items.Add("FSIA")
		cmbICAO9.Items.Add("FVHA")
		cmbICAO9.Items.Add("FZNA")
		cmbICAO9.Items.Add("GBYD")
		cmbICAO9.Items.Add("GCXO")
		cmbICAO9.Items.Add("GMAA")
		cmbICAO9.Items.Add("GOOY")
		cmbICAO9.Items.Add("HELX")
		cmbICAO9.Items.Add("HKNW")
		cmbICAO9.Items.Add("HSSS")
		cmbICAO9.Items.Add("HTDA")
		cmbICAO9.Items.Add("I69")
		cmbICAO9.Items.Add("KANC")
		cmbICAO9.Items.Add("KBGR")
		cmbICAO9.Items.Add("KBOI")
		cmbICAO9.Items.Add("KCAE")
		cmbICAO9.Items.Add("KEWK")
		cmbICAO9.Items.Add("KICT")
		cmbICAO9.Items.Add("KIDP")
		cmbICAO9.Items.Add("KJNU")
		cmbICAO9.Items.Add("KMIA")
		cmbICAO9.Items.Add("KMSP")
		cmbICAO9.Items.Add("KNUD")
		cmbICAO9.Items.Add("KOAK")
		cmbICAO9.Items.Add("KPDK")
		cmbICAO9.Items.Add("KVRB")
		cmbICAO9.Items.Add("LCPH")
		cmbICAO9.Items.Add("LEMD")
		cmbICAO9.Items.Add("LEMG")
		cmbICAO9.Items.Add("LFPN")
		cmbICAO9.Items.Add("LGAT")
		cmbICAO9.Items.Add("LGIR")
		cmbICAO9.Items.Add("LIRA")
		cmbICAO9.Items.Add("LKPR")
		cmbICAO9.Items.Add("LPAZ")
		cmbICAO9.Items.Add("LPPR")
		cmbICAO9.Items.Add("LROP")
		cmbICAO9.Items.Add("LTAC")
		cmbICAO9.Items.Add("LTBA")
		cmbICAO9.Items.Add("MROC")
		cmbICAO9.Items.Add("NTSU")
		cmbICAO9.Items.Add("NZAA")
		cmbICAO9.Items.Add("OOMS")
		cmbICAO9.Items.Add("OPKC")
		cmbICAO9.Items.Add("PAOM")
		cmbICAO9.Items.Add("PGSN")
		cmbICAO9.Items.Add("PHNL")
		cmbICAO9.Items.Add("PHTO")
		cmbICAO9.Items.Add("PKMJ")
		cmbICAO9.Items.Add("PLCH")
		cmbICAO9.Items.Add("PMDY")
		cmbICAO9.Items.Add("PTRO")
		cmbICAO9.Items.Add("PWAK")
		cmbICAO9.Items.Add("RCTP")
		cmbICAO9.Items.Add("RJCK")
		cmbICAO9.Items.Add("RJTT")
		cmbICAO9.Items.Add("RKSS")
		cmbICAO9.Items.Add("RPMM")
		cmbICAO9.Items.Add("SAEZ")
		cmbICAO9.Items.Add("SBEG")
		cmbICAO9.Items.Add("SBGL")
		cmbICAO9.Items.Add("SBSP")
		cmbICAO9.Items.Add("SCEL")
		cmbICAO9.Items.Add("SVMG")
		cmbICAO9.Items.Add("TTPP")
		cmbICAO9.Items.Add("UHHH")
		cmbICAO9.Items.Add("UHMM")
		cmbICAO9.Items.Add("UHPP")
		cmbICAO9.Items.Add("UHSS")
		cmbICAO9.Items.Add("UTTT")
		cmbICAO9.Items.Add("UUEE")
		cmbICAO9.Items.Add("VABB")
		cmbICAO9.Items.Add("VCBI")
		cmbICAO9.Items.Add("VIDP")
		cmbICAO9.Items.Add("VNKT")
		cmbICAO9.Items.Add("VOMM")
		cmbICAO9.Items.Add("VOPB")
		cmbICAO9.Items.Add("VRMM")
		cmbICAO9.Items.Add("VTBD")
		cmbICAO9.Items.Add("WMKJ")
		cmbICAO9.Items.Add("WMKK")
		cmbICAO9.Items.Add("WSSL")
		cmbICAO9.Items.Add("ZGGG")
		cmbICAO9.Items.Add("Other")

		cmbICAO10.Items.Add("ASSY")
		cmbICAO10.Items.Add("AYPY")
		cmbICAO10.Items.Add("BGBW")
		cmbICAO10.Items.Add("BGGH")
		cmbICAO10.Items.Add("BIRK")
		cmbICAO10.Items.Add("CYAM")
		cmbICAO10.Items.Add("CYFB")
		cmbICAO10.Items.Add("CYQX")
		cmbICAO10.Items.Add("CYYQ")
		cmbICAO10.Items.Add("CYYR")
		cmbICAO10.Items.Add("CYYT")
		cmbICAO10.Items.Add("DAAG")
		cmbICAO10.Items.Add("DIAP")
		cmbICAO10.Items.Add("DNMM")
		cmbICAO10.Items.Add("DRRN")
		cmbICAO10.Items.Add("EBBR")
		cmbICAO10.Items.Add("EDDW")
		cmbICAO10.Items.Add("EFHK")
		cmbICAO10.Items.Add("EGPD")
		cmbICAO10.Items.Add("EGPK")
		cmbICAO10.Items.Add("EHBK")
		cmbICAO10.Items.Add("EINN")
		cmbICAO10.Items.Add("EKCH")
		cmbICAO10.Items.Add("ELLX")
		cmbICAO10.Items.Add("ENBR")
		cmbICAO10.Items.Add("FAGM")
		cmbICAO10.Items.Add("FALA")
		cmbICAO10.Items.Add("FAWM")
		cmbICAO10.Items.Add("FCBB")
		cmbICAO10.Items.Add("FEFF")
		cmbICAO10.Items.Add("FMMI")
		cmbICAO10.Items.Add("FNLU")
		cmbICAO10.Items.Add("FOOL")
		cmbICAO10.Items.Add("FSIA")
		cmbICAO10.Items.Add("FVHA")
		cmbICAO10.Items.Add("FZNA")
		cmbICAO10.Items.Add("GBYD")
		cmbICAO10.Items.Add("GCXO")
		cmbICAO10.Items.Add("GMAA")
		cmbICAO10.Items.Add("GOOY")
		cmbICAO10.Items.Add("HELX")
		cmbICAO10.Items.Add("HKNW")
		cmbICAO10.Items.Add("HSSS")
		cmbICAO10.Items.Add("HTDA")
		cmbICAO10.Items.Add("I69")
		cmbICAO10.Items.Add("KANC")
		cmbICAO10.Items.Add("KBGR")
		cmbICAO10.Items.Add("KBOI")
		cmbICAO10.Items.Add("KCAE")
		cmbICAO10.Items.Add("KEWK")
		cmbICAO10.Items.Add("KICT")
		cmbICAO10.Items.Add("KIDP")
		cmbICAO10.Items.Add("KJNU")
		cmbICAO10.Items.Add("KMIA")
		cmbICAO10.Items.Add("KMSP")
		cmbICAO10.Items.Add("KNUD")
		cmbICAO10.Items.Add("KOAK")
		cmbICAO10.Items.Add("KPDK")
		cmbICAO10.Items.Add("KVRB")
		cmbICAO10.Items.Add("LCPH")
		cmbICAO10.Items.Add("LEMD")
		cmbICAO10.Items.Add("LEMG")
		cmbICAO10.Items.Add("LFPN")
		cmbICAO10.Items.Add("LGAT")
		cmbICAO10.Items.Add("LGIR")
		cmbICAO10.Items.Add("LIRA")
		cmbICAO10.Items.Add("LKPR")
		cmbICAO10.Items.Add("LPAZ")
		cmbICAO10.Items.Add("LPPR")
		cmbICAO10.Items.Add("LROP")
		cmbICAO10.Items.Add("LTAC")
		cmbICAO10.Items.Add("LTBA")
		cmbICAO10.Items.Add("MROC")
		cmbICAO10.Items.Add("NTSU")
		cmbICAO10.Items.Add("NZAA")
		cmbICAO10.Items.Add("OOMS")
		cmbICAO10.Items.Add("OPKC")
		cmbICAO10.Items.Add("PAOM")
		cmbICAO10.Items.Add("PGSN")
		cmbICAO10.Items.Add("PHNL")
		cmbICAO10.Items.Add("PHTO")
		cmbICAO10.Items.Add("PKMJ")
		cmbICAO10.Items.Add("PLCH")
		cmbICAO10.Items.Add("PMDY")
		cmbICAO10.Items.Add("PTRO")
		cmbICAO10.Items.Add("PWAK")
		cmbICAO10.Items.Add("RCTP")
		cmbICAO10.Items.Add("RJCK")
		cmbICAO10.Items.Add("RJTT")
		cmbICAO10.Items.Add("RKSS")
		cmbICAO10.Items.Add("RPMM")
		cmbICAO10.Items.Add("SAEZ")
		cmbICAO10.Items.Add("SBEG")
		cmbICAO10.Items.Add("SBGL")
		cmbICAO10.Items.Add("SBSP")
		cmbICAO10.Items.Add("SCEL")
		cmbICAO10.Items.Add("SVMG")
		cmbICAO10.Items.Add("TTPP")
		cmbICAO10.Items.Add("UHHH")
		cmbICAO10.Items.Add("UHMM")
		cmbICAO10.Items.Add("UHPP")
		cmbICAO10.Items.Add("UHSS")
		cmbICAO10.Items.Add("UTTT")
		cmbICAO10.Items.Add("UUEE")
		cmbICAO10.Items.Add("VABB")
		cmbICAO10.Items.Add("VCBI")
		cmbICAO10.Items.Add("VIDP")
		cmbICAO10.Items.Add("VNKT")
		cmbICAO10.Items.Add("VOMM")
		cmbICAO10.Items.Add("VOPB")
		cmbICAO10.Items.Add("VRMM")
		cmbICAO10.Items.Add("VTBD")
		cmbICAO10.Items.Add("WMKJ")
		cmbICAO10.Items.Add("WMKK")
		cmbICAO10.Items.Add("WSSL")
		cmbICAO10.Items.Add("ZGGG")
		cmbICAO10.Items.Add("Other")

		cmbICAO11.Items.Add("ASSY")
		cmbICAO11.Items.Add("AYPY")
		cmbICAO11.Items.Add("BGBW")
		cmbICAO11.Items.Add("BGGH")
		cmbICAO11.Items.Add("BIRK")
		cmbICAO11.Items.Add("CYAM")
		cmbICAO11.Items.Add("CYFB")
		cmbICAO11.Items.Add("CYQX")
		cmbICAO11.Items.Add("CYYQ")
		cmbICAO11.Items.Add("CYYR")
		cmbICAO11.Items.Add("CYYT")
		cmbICAO11.Items.Add("DAAG")
		cmbICAO11.Items.Add("DIAP")
		cmbICAO11.Items.Add("DNMM")
		cmbICAO11.Items.Add("DRRN")
		cmbICAO11.Items.Add("EBBR")
		cmbICAO11.Items.Add("EDDW")
		cmbICAO11.Items.Add("EFHK")
		cmbICAO11.Items.Add("EGPD")
		cmbICAO11.Items.Add("EGPK")
		cmbICAO11.Items.Add("EHBK")
		cmbICAO11.Items.Add("EINN")
		cmbICAO11.Items.Add("EKCH")
		cmbICAO11.Items.Add("ELLX")
		cmbICAO11.Items.Add("ENBR")
		cmbICAO11.Items.Add("FAGM")
		cmbICAO11.Items.Add("FALA")
		cmbICAO11.Items.Add("FAWM")
		cmbICAO11.Items.Add("FCBB")
		cmbICAO11.Items.Add("FEFF")
		cmbICAO11.Items.Add("FMMI")
		cmbICAO11.Items.Add("FNLU")
		cmbICAO11.Items.Add("FOOL")
		cmbICAO11.Items.Add("FSIA")
		cmbICAO11.Items.Add("FVHA")
		cmbICAO11.Items.Add("FZNA")
		cmbICAO11.Items.Add("GBYD")
		cmbICAO11.Items.Add("GCXO")
		cmbICAO11.Items.Add("GMAA")
		cmbICAO11.Items.Add("GOOY")
		cmbICAO11.Items.Add("HELX")
		cmbICAO11.Items.Add("HKNW")
		cmbICAO11.Items.Add("HSSS")
		cmbICAO11.Items.Add("HTDA")
		cmbICAO11.Items.Add("I69")
		cmbICAO11.Items.Add("KANC")
		cmbICAO11.Items.Add("KBGR")
		cmbICAO11.Items.Add("KBOI")
		cmbICAO11.Items.Add("KCAE")
		cmbICAO11.Items.Add("KEWK")
		cmbICAO11.Items.Add("KICT")
		cmbICAO11.Items.Add("KIDP")
		cmbICAO11.Items.Add("KJNU")
		cmbICAO11.Items.Add("KMIA")
		cmbICAO11.Items.Add("KMSP")
		cmbICAO11.Items.Add("KNUD")
		cmbICAO11.Items.Add("KOAK")
		cmbICAO11.Items.Add("KPDK")
		cmbICAO11.Items.Add("KVRB")
		cmbICAO11.Items.Add("LCPH")
		cmbICAO11.Items.Add("LEMD")
		cmbICAO11.Items.Add("LEMG")
		cmbICAO11.Items.Add("LFPN")
		cmbICAO11.Items.Add("LGAT")
		cmbICAO11.Items.Add("LGIR")
		cmbICAO11.Items.Add("LIRA")
		cmbICAO11.Items.Add("LKPR")
		cmbICAO11.Items.Add("LPAZ")
		cmbICAO11.Items.Add("LPPR")
		cmbICAO11.Items.Add("LROP")
		cmbICAO11.Items.Add("LTAC")
		cmbICAO11.Items.Add("LTBA")
		cmbICAO11.Items.Add("MROC")
		cmbICAO11.Items.Add("NTSU")
		cmbICAO11.Items.Add("NZAA")
		cmbICAO11.Items.Add("OOMS")
		cmbICAO11.Items.Add("OPKC")
		cmbICAO11.Items.Add("PAOM")
		cmbICAO11.Items.Add("PGSN")
		cmbICAO11.Items.Add("PHNL")
		cmbICAO11.Items.Add("PHTO")
		cmbICAO11.Items.Add("PKMJ")
		cmbICAO11.Items.Add("PLCH")
		cmbICAO11.Items.Add("PMDY")
		cmbICAO11.Items.Add("PTRO")
		cmbICAO11.Items.Add("PWAK")
		cmbICAO11.Items.Add("RCTP")
		cmbICAO11.Items.Add("RJCK")
		cmbICAO11.Items.Add("RJTT")
		cmbICAO11.Items.Add("RKSS")
		cmbICAO11.Items.Add("RPMM")
		cmbICAO11.Items.Add("SAEZ")
		cmbICAO11.Items.Add("SBEG")
		cmbICAO11.Items.Add("SBGL")
		cmbICAO11.Items.Add("SBSP")
		cmbICAO11.Items.Add("SCEL")
		cmbICAO11.Items.Add("SVMG")
		cmbICAO11.Items.Add("TTPP")
		cmbICAO11.Items.Add("UHHH")
		cmbICAO11.Items.Add("UHMM")
		cmbICAO11.Items.Add("UHPP")
		cmbICAO11.Items.Add("UHSS")
		cmbICAO11.Items.Add("UTTT")
		cmbICAO11.Items.Add("UUEE")
		cmbICAO11.Items.Add("VABB")
		cmbICAO11.Items.Add("VCBI")
		cmbICAO11.Items.Add("VIDP")
		cmbICAO11.Items.Add("VNKT")
		cmbICAO11.Items.Add("VOMM")
		cmbICAO11.Items.Add("VOPB")
		cmbICAO11.Items.Add("VRMM")
		cmbICAO11.Items.Add("VTBD")
		cmbICAO11.Items.Add("WMKJ")
		cmbICAO11.Items.Add("WMKK")
		cmbICAO11.Items.Add("WSSL")
		cmbICAO11.Items.Add("ZGGG")
		cmbICAO11.Items.Add("Other")

		cmbICAO12.Items.Add("ASSY")
		cmbICAO12.Items.Add("AYPY")
		cmbICAO12.Items.Add("BGBW")
		cmbICAO12.Items.Add("BGGH")
		cmbICAO12.Items.Add("BIRK")
		cmbICAO12.Items.Add("CYAM")
		cmbICAO12.Items.Add("CYFB")
		cmbICAO12.Items.Add("CYQX")
		cmbICAO12.Items.Add("CYYQ")
		cmbICAO12.Items.Add("CYYR")
		cmbICAO12.Items.Add("CYYT")
		cmbICAO12.Items.Add("DAAG")
		cmbICAO12.Items.Add("DIAP")
		cmbICAO12.Items.Add("DNMM")
		cmbICAO12.Items.Add("DRRN")
		cmbICAO12.Items.Add("EBBR")
		cmbICAO12.Items.Add("EDDW")
		cmbICAO12.Items.Add("EFHK")
		cmbICAO12.Items.Add("EGPD")
		cmbICAO12.Items.Add("EGPK")
		cmbICAO12.Items.Add("EHBK")
		cmbICAO12.Items.Add("EINN")
		cmbICAO12.Items.Add("EKCH")
		cmbICAO12.Items.Add("ELLX")
		cmbICAO12.Items.Add("ENBR")
		cmbICAO12.Items.Add("FAGM")
		cmbICAO12.Items.Add("FALA")
		cmbICAO12.Items.Add("FAWM")
		cmbICAO12.Items.Add("FCBB")
		cmbICAO12.Items.Add("FEFF")
		cmbICAO12.Items.Add("FMMI")
		cmbICAO12.Items.Add("FNLU")
		cmbICAO12.Items.Add("FOOL")
		cmbICAO12.Items.Add("FSIA")
		cmbICAO12.Items.Add("FVHA")
		cmbICAO12.Items.Add("FZNA")
		cmbICAO12.Items.Add("GBYD")
		cmbICAO12.Items.Add("GCXO")
		cmbICAO12.Items.Add("GMAA")
		cmbICAO12.Items.Add("GOOY")
		cmbICAO12.Items.Add("HELX")
		cmbICAO12.Items.Add("HKNW")
		cmbICAO12.Items.Add("HSSS")
		cmbICAO12.Items.Add("HTDA")
		cmbICAO12.Items.Add("I69")
		cmbICAO12.Items.Add("KANC")
		cmbICAO12.Items.Add("KBGR")
		cmbICAO12.Items.Add("KBOI")
		cmbICAO12.Items.Add("KCAE")
		cmbICAO12.Items.Add("KEWK")
		cmbICAO12.Items.Add("KICT")
		cmbICAO12.Items.Add("KIDP")
		cmbICAO12.Items.Add("KJNU")
		cmbICAO12.Items.Add("KMIA")
		cmbICAO12.Items.Add("KMSP")
		cmbICAO12.Items.Add("KNUD")
		cmbICAO12.Items.Add("KOAK")
		cmbICAO12.Items.Add("KPDK")
		cmbICAO12.Items.Add("KVRB")
		cmbICAO12.Items.Add("LCPH")
		cmbICAO12.Items.Add("LEMD")
		cmbICAO12.Items.Add("LEMG")
		cmbICAO12.Items.Add("LFPN")
		cmbICAO12.Items.Add("LGAT")
		cmbICAO12.Items.Add("LGIR")
		cmbICAO12.Items.Add("LIRA")
		cmbICAO12.Items.Add("LKPR")
		cmbICAO12.Items.Add("LPAZ")
		cmbICAO12.Items.Add("LPPR")
		cmbICAO12.Items.Add("LROP")
		cmbICAO12.Items.Add("LTAC")
		cmbICAO12.Items.Add("LTBA")
		cmbICAO12.Items.Add("MROC")
		cmbICAO12.Items.Add("NTSU")
		cmbICAO12.Items.Add("NZAA")
		cmbICAO12.Items.Add("OOMS")
		cmbICAO12.Items.Add("OPKC")
		cmbICAO12.Items.Add("PAOM")
		cmbICAO12.Items.Add("PGSN")
		cmbICAO12.Items.Add("PHNL")
		cmbICAO12.Items.Add("PHTO")
		cmbICAO12.Items.Add("PKMJ")
		cmbICAO12.Items.Add("PLCH")
		cmbICAO12.Items.Add("PMDY")
		cmbICAO12.Items.Add("PTRO")
		cmbICAO12.Items.Add("PWAK")
		cmbICAO12.Items.Add("RCTP")
		cmbICAO12.Items.Add("RJCK")
		cmbICAO12.Items.Add("RJTT")
		cmbICAO12.Items.Add("RKSS")
		cmbICAO12.Items.Add("RPMM")
		cmbICAO12.Items.Add("SAEZ")
		cmbICAO12.Items.Add("SBEG")
		cmbICAO12.Items.Add("SBGL")
		cmbICAO12.Items.Add("SBSP")
		cmbICAO12.Items.Add("SCEL")
		cmbICAO12.Items.Add("SVMG")
		cmbICAO12.Items.Add("TTPP")
		cmbICAO12.Items.Add("UHHH")
		cmbICAO12.Items.Add("UHMM")
		cmbICAO12.Items.Add("UHPP")
		cmbICAO12.Items.Add("UHSS")
		cmbICAO12.Items.Add("UTTT")
		cmbICAO12.Items.Add("UUEE")
		cmbICAO12.Items.Add("VABB")
		cmbICAO12.Items.Add("VCBI")
		cmbICAO12.Items.Add("VIDP")
		cmbICAO12.Items.Add("VNKT")
		cmbICAO12.Items.Add("VOMM")
		cmbICAO12.Items.Add("VOPB")
		cmbICAO12.Items.Add("VRMM")
		cmbICAO12.Items.Add("VTBD")
		cmbICAO12.Items.Add("WMKJ")
		cmbICAO12.Items.Add("WMKK")
		cmbICAO12.Items.Add("WSSL")
		cmbICAO12.Items.Add("ZGGG")
		cmbICAO12.Items.Add("Other")

		cmbICAO13.Items.Add("ASSY")
		cmbICAO13.Items.Add("AYPY")
		cmbICAO13.Items.Add("BGBW")
		cmbICAO13.Items.Add("BGGH")
		cmbICAO13.Items.Add("BIRK")
		cmbICAO13.Items.Add("CYAM")
		cmbICAO13.Items.Add("CYFB")
		cmbICAO13.Items.Add("CYQX")
		cmbICAO13.Items.Add("CYYQ")
		cmbICAO13.Items.Add("CYYR")
		cmbICAO13.Items.Add("CYYT")
		cmbICAO13.Items.Add("DAAG")
		cmbICAO13.Items.Add("DIAP")
		cmbICAO13.Items.Add("DNMM")
		cmbICAO13.Items.Add("DRRN")
		cmbICAO13.Items.Add("EBBR")
		cmbICAO13.Items.Add("EDDW")
		cmbICAO13.Items.Add("EFHK")
		cmbICAO13.Items.Add("EGPD")
		cmbICAO13.Items.Add("EGPK")
		cmbICAO13.Items.Add("EHBK")
		cmbICAO13.Items.Add("EINN")
		cmbICAO13.Items.Add("EKCH")
		cmbICAO13.Items.Add("ELLX")
		cmbICAO13.Items.Add("ENBR")
		cmbICAO13.Items.Add("FAGM")
		cmbICAO13.Items.Add("FALA")
		cmbICAO13.Items.Add("FAWM")
		cmbICAO13.Items.Add("FCBB")
		cmbICAO13.Items.Add("FEFF")
		cmbICAO13.Items.Add("FMMI")
		cmbICAO13.Items.Add("FNLU")
		cmbICAO13.Items.Add("FOOL")
		cmbICAO13.Items.Add("FSIA")
		cmbICAO13.Items.Add("FVHA")
		cmbICAO13.Items.Add("FZNA")
		cmbICAO13.Items.Add("GBYD")
		cmbICAO13.Items.Add("GCXO")
		cmbICAO13.Items.Add("GMAA")
		cmbICAO13.Items.Add("GOOY")
		cmbICAO13.Items.Add("HELX")
		cmbICAO13.Items.Add("HKNW")
		cmbICAO13.Items.Add("HSSS")
		cmbICAO13.Items.Add("HTDA")
		cmbICAO13.Items.Add("I69")
		cmbICAO13.Items.Add("KANC")
		cmbICAO13.Items.Add("KBGR")
		cmbICAO13.Items.Add("KBOI")
		cmbICAO13.Items.Add("KCAE")
		cmbICAO13.Items.Add("KEWK")
		cmbICAO13.Items.Add("KICT")
		cmbICAO13.Items.Add("KIDP")
		cmbICAO13.Items.Add("KJNU")
		cmbICAO13.Items.Add("KMIA")
		cmbICAO13.Items.Add("KMSP")
		cmbICAO13.Items.Add("KNUD")
		cmbICAO13.Items.Add("KOAK")
		cmbICAO13.Items.Add("KPDK")
		cmbICAO13.Items.Add("KVRB")
		cmbICAO13.Items.Add("LCPH")
		cmbICAO13.Items.Add("LEMD")
		cmbICAO13.Items.Add("LEMG")
		cmbICAO13.Items.Add("LFPN")
		cmbICAO13.Items.Add("LGAT")
		cmbICAO13.Items.Add("LGIR")
		cmbICAO13.Items.Add("LIRA")
		cmbICAO13.Items.Add("LKPR")
		cmbICAO13.Items.Add("LPAZ")
		cmbICAO13.Items.Add("LPPR")
		cmbICAO13.Items.Add("LROP")
		cmbICAO13.Items.Add("LTAC")
		cmbICAO13.Items.Add("LTBA")
		cmbICAO13.Items.Add("MROC")
		cmbICAO13.Items.Add("NTSU")
		cmbICAO13.Items.Add("NZAA")
		cmbICAO13.Items.Add("OOMS")
		cmbICAO13.Items.Add("OPKC")
		cmbICAO13.Items.Add("PAOM")
		cmbICAO13.Items.Add("PGSN")
		cmbICAO13.Items.Add("PHNL")
		cmbICAO13.Items.Add("PHTO")
		cmbICAO13.Items.Add("PKMJ")
		cmbICAO13.Items.Add("PLCH")
		cmbICAO13.Items.Add("PMDY")
		cmbICAO13.Items.Add("PTRO")
		cmbICAO13.Items.Add("PWAK")
		cmbICAO13.Items.Add("RCTP")
		cmbICAO13.Items.Add("RJCK")
		cmbICAO13.Items.Add("RJTT")
		cmbICAO13.Items.Add("RKSS")
		cmbICAO13.Items.Add("RPMM")
		cmbICAO13.Items.Add("SAEZ")
		cmbICAO13.Items.Add("SBEG")
		cmbICAO13.Items.Add("SBGL")
		cmbICAO13.Items.Add("SBSP")
		cmbICAO13.Items.Add("SCEL")
		cmbICAO13.Items.Add("SVMG")
		cmbICAO13.Items.Add("TTPP")
		cmbICAO13.Items.Add("UHHH")
		cmbICAO13.Items.Add("UHMM")
		cmbICAO13.Items.Add("UHPP")
		cmbICAO13.Items.Add("UHSS")
		cmbICAO13.Items.Add("UTTT")
		cmbICAO13.Items.Add("UUEE")
		cmbICAO13.Items.Add("VABB")
		cmbICAO13.Items.Add("VCBI")
		cmbICAO13.Items.Add("VIDP")
		cmbICAO13.Items.Add("VNKT")
		cmbICAO13.Items.Add("VOMM")
		cmbICAO13.Items.Add("VOPB")
		cmbICAO13.Items.Add("VRMM")
		cmbICAO13.Items.Add("VTBD")
		cmbICAO13.Items.Add("WMKJ")
		cmbICAO13.Items.Add("WMKK")
		cmbICAO13.Items.Add("WSSL")
		cmbICAO13.Items.Add("ZGGG")
		cmbICAO13.Items.Add("Other")

		cmbICAO14.Items.Add("ASSY")
		cmbICAO14.Items.Add("AYPY")
		cmbICAO14.Items.Add("BGBW")
		cmbICAO14.Items.Add("BGGH")
		cmbICAO14.Items.Add("BIRK")
		cmbICAO14.Items.Add("CYAM")
		cmbICAO14.Items.Add("CYFB")
		cmbICAO14.Items.Add("CYQX")
		cmbICAO14.Items.Add("CYYQ")
		cmbICAO14.Items.Add("CYYR")
		cmbICAO14.Items.Add("CYYT")
		cmbICAO14.Items.Add("DAAG")
		cmbICAO14.Items.Add("DIAP")
		cmbICAO14.Items.Add("DNMM")
		cmbICAO14.Items.Add("DRRN")
		cmbICAO14.Items.Add("EBBR")
		cmbICAO14.Items.Add("EDDW")
		cmbICAO14.Items.Add("EFHK")
		cmbICAO14.Items.Add("EGPD")
		cmbICAO14.Items.Add("EGPK")
		cmbICAO14.Items.Add("EHBK")
		cmbICAO14.Items.Add("EINN")
		cmbICAO14.Items.Add("EKCH")
		cmbICAO14.Items.Add("ELLX")
		cmbICAO14.Items.Add("ENBR")
		cmbICAO14.Items.Add("FAGM")
		cmbICAO14.Items.Add("FALA")
		cmbICAO14.Items.Add("FAWM")
		cmbICAO14.Items.Add("FCBB")
		cmbICAO14.Items.Add("FEFF")
		cmbICAO14.Items.Add("FMMI")
		cmbICAO14.Items.Add("FNLU")
		cmbICAO14.Items.Add("FOOL")
		cmbICAO14.Items.Add("FSIA")
		cmbICAO14.Items.Add("FVHA")
		cmbICAO14.Items.Add("FZNA")
		cmbICAO14.Items.Add("GBYD")
		cmbICAO14.Items.Add("GCXO")
		cmbICAO14.Items.Add("GMAA")
		cmbICAO14.Items.Add("GOOY")
		cmbICAO14.Items.Add("HELX")
		cmbICAO14.Items.Add("HKNW")
		cmbICAO14.Items.Add("HSSS")
		cmbICAO14.Items.Add("HTDA")
		cmbICAO14.Items.Add("I69")
		cmbICAO14.Items.Add("KANC")
		cmbICAO14.Items.Add("KBGR")
		cmbICAO14.Items.Add("KBOI")
		cmbICAO14.Items.Add("KCAE")
		cmbICAO14.Items.Add("KEWK")
		cmbICAO14.Items.Add("KICT")
		cmbICAO14.Items.Add("KIDP")
		cmbICAO14.Items.Add("KJNU")
		cmbICAO14.Items.Add("KMIA")
		cmbICAO14.Items.Add("KMSP")
		cmbICAO14.Items.Add("KNUD")
		cmbICAO14.Items.Add("KOAK")
		cmbICAO14.Items.Add("KPDK")
		cmbICAO14.Items.Add("KVRB")
		cmbICAO14.Items.Add("LCPH")
		cmbICAO14.Items.Add("LEMD")
		cmbICAO14.Items.Add("LEMG")
		cmbICAO14.Items.Add("LFPN")
		cmbICAO14.Items.Add("LGAT")
		cmbICAO14.Items.Add("LGIR")
		cmbICAO14.Items.Add("LIRA")
		cmbICAO14.Items.Add("LKPR")
		cmbICAO14.Items.Add("LPAZ")
		cmbICAO14.Items.Add("LPPR")
		cmbICAO14.Items.Add("LROP")
		cmbICAO14.Items.Add("LTAC")
		cmbICAO14.Items.Add("LTBA")
		cmbICAO14.Items.Add("MROC")
		cmbICAO14.Items.Add("NTSU")
		cmbICAO14.Items.Add("NZAA")
		cmbICAO14.Items.Add("OOMS")
		cmbICAO14.Items.Add("OPKC")
		cmbICAO14.Items.Add("PAOM")
		cmbICAO14.Items.Add("PGSN")
		cmbICAO14.Items.Add("PHNL")
		cmbICAO14.Items.Add("PHTO")
		cmbICAO14.Items.Add("PKMJ")
		cmbICAO14.Items.Add("PLCH")
		cmbICAO14.Items.Add("PMDY")
		cmbICAO14.Items.Add("PTRO")
		cmbICAO14.Items.Add("PWAK")
		cmbICAO14.Items.Add("RCTP")
		cmbICAO14.Items.Add("RJCK")
		cmbICAO14.Items.Add("RJTT")
		cmbICAO14.Items.Add("RKSS")
		cmbICAO14.Items.Add("RPMM")
		cmbICAO14.Items.Add("SAEZ")
		cmbICAO14.Items.Add("SBEG")
		cmbICAO14.Items.Add("SBGL")
		cmbICAO14.Items.Add("SBSP")
		cmbICAO14.Items.Add("SCEL")
		cmbICAO14.Items.Add("SVMG")
		cmbICAO14.Items.Add("TTPP")
		cmbICAO14.Items.Add("UHHH")
		cmbICAO14.Items.Add("UHMM")
		cmbICAO14.Items.Add("UHPP")
		cmbICAO14.Items.Add("UHSS")
		cmbICAO14.Items.Add("UTTT")
		cmbICAO14.Items.Add("UUEE")
		cmbICAO14.Items.Add("VABB")
		cmbICAO14.Items.Add("VCBI")
		cmbICAO14.Items.Add("VIDP")
		cmbICAO14.Items.Add("VNKT")
		cmbICAO14.Items.Add("VOMM")
		cmbICAO14.Items.Add("VOPB")
		cmbICAO14.Items.Add("VRMM")
		cmbICAO14.Items.Add("VTBD")
		cmbICAO14.Items.Add("WMKJ")
		cmbICAO14.Items.Add("WMKK")
		cmbICAO14.Items.Add("WSSL")
		cmbICAO14.Items.Add("ZGGG")
		cmbICAO14.Items.Add("Other")

		cmbICAO15.Items.Add("ASSY")
		cmbICAO15.Items.Add("AYPY")
		cmbICAO15.Items.Add("BGBW")
		cmbICAO15.Items.Add("BGGH")
		cmbICAO15.Items.Add("BIRK")
		cmbICAO15.Items.Add("CYAM")
		cmbICAO15.Items.Add("CYFB")
		cmbICAO15.Items.Add("CYQX")
		cmbICAO15.Items.Add("CYYQ")
		cmbICAO15.Items.Add("CYYR")
		cmbICAO15.Items.Add("CYYT")
		cmbICAO15.Items.Add("DAAG")
		cmbICAO15.Items.Add("DIAP")
		cmbICAO15.Items.Add("DNMM")
		cmbICAO15.Items.Add("DRRN")
		cmbICAO15.Items.Add("EBBR")
		cmbICAO15.Items.Add("EDDW")
		cmbICAO15.Items.Add("EFHK")
		cmbICAO15.Items.Add("EGPD")
		cmbICAO15.Items.Add("EGPK")
		cmbICAO15.Items.Add("EHBK")
		cmbICAO15.Items.Add("EINN")
		cmbICAO15.Items.Add("EKCH")
		cmbICAO15.Items.Add("ELLX")
		cmbICAO15.Items.Add("ENBR")
		cmbICAO15.Items.Add("FAGM")
		cmbICAO15.Items.Add("FALA")
		cmbICAO15.Items.Add("FAWM")
		cmbICAO15.Items.Add("FCBB")
		cmbICAO15.Items.Add("FEFF")
		cmbICAO15.Items.Add("FMMI")
		cmbICAO15.Items.Add("FNLU")
		cmbICAO15.Items.Add("FOOL")
		cmbICAO15.Items.Add("FSIA")
		cmbICAO15.Items.Add("FVHA")
		cmbICAO15.Items.Add("FZNA")
		cmbICAO15.Items.Add("GBYD")
		cmbICAO15.Items.Add("GCXO")
		cmbICAO15.Items.Add("GMAA")
		cmbICAO15.Items.Add("GOOY")
		cmbICAO15.Items.Add("HELX")
		cmbICAO15.Items.Add("HKNW")
		cmbICAO15.Items.Add("HSSS")
		cmbICAO15.Items.Add("HTDA")
		cmbICAO15.Items.Add("I69")
		cmbICAO15.Items.Add("KANC")
		cmbICAO15.Items.Add("KBGR")
		cmbICAO15.Items.Add("KBOI")
		cmbICAO15.Items.Add("KCAE")
		cmbICAO15.Items.Add("KEWK")
		cmbICAO15.Items.Add("KICT")
		cmbICAO15.Items.Add("KIDP")
		cmbICAO15.Items.Add("KJNU")
		cmbICAO15.Items.Add("KMIA")
		cmbICAO15.Items.Add("KMSP")
		cmbICAO15.Items.Add("KNUD")
		cmbICAO15.Items.Add("KOAK")
		cmbICAO15.Items.Add("KPDK")
		cmbICAO15.Items.Add("KVRB")
		cmbICAO15.Items.Add("LCPH")
		cmbICAO15.Items.Add("LEMD")
		cmbICAO15.Items.Add("LEMG")
		cmbICAO15.Items.Add("LFPN")
		cmbICAO15.Items.Add("LGAT")
		cmbICAO15.Items.Add("LGIR")
		cmbICAO15.Items.Add("LIRA")
		cmbICAO15.Items.Add("LKPR")
		cmbICAO15.Items.Add("LPAZ")
		cmbICAO15.Items.Add("LPPR")
		cmbICAO15.Items.Add("LROP")
		cmbICAO15.Items.Add("LTAC")
		cmbICAO15.Items.Add("LTBA")
		cmbICAO15.Items.Add("MROC")
		cmbICAO15.Items.Add("NTSU")
		cmbICAO15.Items.Add("NZAA")
		cmbICAO15.Items.Add("OOMS")
		cmbICAO15.Items.Add("OPKC")
		cmbICAO15.Items.Add("PAOM")
		cmbICAO15.Items.Add("PGSN")
		cmbICAO15.Items.Add("PHNL")
		cmbICAO15.Items.Add("PHTO")
		cmbICAO15.Items.Add("PKMJ")
		cmbICAO15.Items.Add("PLCH")
		cmbICAO15.Items.Add("PMDY")
		cmbICAO15.Items.Add("PTRO")
		cmbICAO15.Items.Add("PWAK")
		cmbICAO15.Items.Add("RCTP")
		cmbICAO15.Items.Add("RJCK")
		cmbICAO15.Items.Add("RJTT")
		cmbICAO15.Items.Add("RKSS")
		cmbICAO15.Items.Add("RPMM")
		cmbICAO15.Items.Add("SAEZ")
		cmbICAO15.Items.Add("SBEG")
		cmbICAO15.Items.Add("SBGL")
		cmbICAO15.Items.Add("SBSP")
		cmbICAO15.Items.Add("SCEL")
		cmbICAO15.Items.Add("SVMG")
		cmbICAO15.Items.Add("TTPP")
		cmbICAO15.Items.Add("UHHH")
		cmbICAO15.Items.Add("UHMM")
		cmbICAO15.Items.Add("UHPP")
		cmbICAO15.Items.Add("UHSS")
		cmbICAO15.Items.Add("UTTT")
		cmbICAO15.Items.Add("UUEE")
		cmbICAO15.Items.Add("VABB")
		cmbICAO15.Items.Add("VCBI")
		cmbICAO15.Items.Add("VIDP")
		cmbICAO15.Items.Add("VNKT")
		cmbICAO15.Items.Add("VOMM")
		cmbICAO15.Items.Add("VOPB")
		cmbICAO15.Items.Add("VRMM")
		cmbICAO15.Items.Add("VTBD")
		cmbICAO15.Items.Add("WMKJ")
		cmbICAO15.Items.Add("WMKK")
		cmbICAO15.Items.Add("WSSL")
		cmbICAO15.Items.Add("ZGGG")
		cmbICAO15.Items.Add("Other")

	End Sub

	'UPGRADE_WARNING: Event cmbICAO.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cmbICAO_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO.SelectedIndexChanged

		If cmbICAO.Text = "ASSY" Then
			'txtPort.Text = "Sidney"
			txtLatRad.Text = "-0.592248392843409"
			txtLongRad.Text = "-2.63835605259809"
		ElseIf cmbICAO.Text = "AYPY" Then
			'txtPort.Text = "Port Moresby, PNG"
			txtLatRad.Text = "-0.164817259029998"
			txtLongRad.Text = "-2.56941554714432"
		ElseIf cmbICAO.Text = "BGBW" Then
			'txtPort.Text = "Narsarsuaq"
			txtLatRad.Text = "1.0674724593406"
			txtLongRad.Text = "0.792873990360157"
		ElseIf cmbICAO.Text = "BGGH" Then
			'txtPort.Text = "Godthab"
			txtLatRad.Text = "1.12035593567603"
			txtLongRad.Text = "0.902044335072403"
		ElseIf cmbICAO.Text = "BIRK" Then
			'txtPort.Text = "Reykjavik"
			txtLatRad.Text = "1.1192505604831"
			txtLongRad.Text = "0.382983415529289"
		ElseIf cmbICAO.Text = "CYAM" Then
			'txtPort.Text = "Sault Ste. Marie"
			txtLatRad.Text = "0.811316302789564"
			txtLongRad.Text = "1.47497775086041"
		ElseIf cmbICAO.Text = "CYFB" Then
			'txtPort.Text = "Iqaluit"
			txtLatRad.Text = "1.11276375342985"
			txtLongRad.Text = "1.19653955752558"
		ElseIf cmbICAO.Text = "CYQX" Then
			'txtPort.Text = "Gander"
			txtLatRad.Text = "0.854164135926025"
			txtLongRad.Text = "0.952426172813306"
		ElseIf cmbICAO.Text = "CYYQ" Then
			'txtPort.Text = "Churchill Falls"
			txtLatRad.Text = "1.02520640262147"
			txtLongRad.Text = "1.64177304970933"
		ElseIf cmbICAO.Text = "CYYR" Then
			'txtPort.Text = "Goose Bay"
			txtLatRad.Text = "0.930609557163376"
			txtLongRad.Text = "1.05464428933844"
		ElseIf cmbICAO.Text = "CYYT" Then
			'txtPort.Text = "St John's, NFLD"
			txtLatRad.Text = "0.831096700978833"
			txtLongRad.Text = "0.920690269247875"
		ElseIf cmbICAO.Text = "DAAG" Then
			'txtPort.Text = "Algiers, Algeria"
			txtLatRad.Text = "0.640419480198453"
			txtLongRad.Text = "-0.0561705130933508"
		ElseIf cmbICAO.Text = "DIAP" Then
			'txtPort.Text = "Abidjan"
			txtLatRad.Text = "0.0916588745505689"
			txtLongRad.Text = "0.0685623507825106"
		ElseIf cmbICAO.Text = "DNMM" Then
			'txtPort.Text = "Lagos, Nigeria"
			txtLatRad.Text = "0.114755398318627"
			txtLongRad.Text = "-0.0579158423453452"
		ElseIf cmbICAO.Text = "DRRN" Then
			'txtPort.Text = "Niami, Niger"
			txtLatRad.Text = "0.235299471989702"
			txtLongRad.Text = "-0.0379318224100101"
		ElseIf cmbICAO.Text = "EBBR" Then
			'txtPort.Text = "Brussels"
			txtLatRad.Text = "0.88840167808598"
			txtLongRad.Text = "-0.0785107275188782"
		ElseIf cmbICAO.Text = "EDDW" Then
			'txtPort.Text = "Bremen, Germany"
			txtLatRad.Text = "0.925868079362125"
			txtLongRad.Text = "-0.153385352429435"
		ElseIf cmbICAO.Text = "EFHK" Then
			'txtPort.Text = "Helsinki, Finland"
			txtLatRad.Text = "1.05272442716125"
			txtLongRad.Text = "-0.435750536581251"
		ElseIf cmbICAO.Text = "EGPD" Then
			'txtPort.Text = "Aberdeen"
			txtLatRad.Text = "0.998415598603356"
			txtLongRad.Text = "0.0383681547230087"
		ElseIf cmbICAO.Text = "EGPK" Then
			'txtPort.Text = "Prestwick"
			txtLatRad.Text = "0.968686823677719"
			txtLongRad.Text = "0.0798779020996071"
		ElseIf cmbICAO.Text = "EHBK" Then
			'txtPort.Text = "Maastricht, Netherlands"
			txtLatRad.Text = "0.888663477473779"
			txtLongRad.Text = "-0.100821853123539"
		ElseIf cmbICAO.Text = "EINN" Then
			'txtPort.Text = "Shannon"
			txtLatRad.Text = "0.919788515801012"
			txtLongRad.Text = "0.155741546919627"
		ElseIf cmbICAO.Text = "EKCH" Then
			txtPort.Text = "Copenhagen"
			txtLatRad.Text = "0.97054850821318"
			txtLongRad.Text = "-0.220493262168617"
		ElseIf cmbICAO.Text = "ELLX" Then
			'txtPort.Text = "Luxembourg"
			txtLatRad.Text = "0.86609055248132"
			txtLongRad.Text = "-0.108297680086248"
		ElseIf cmbICAO.Text = "ENBR" Then
			'txtPort.Text = "Bergen, Norway"
			txtLatRad.Text = "1.05231718366911"
			txtLongRad.Text = "-0.091106186954104"
		ElseIf cmbICAO.Text = "FAGM" Then
			'txtPort.Text = "Rand"
			txtLatRad.Text = "-0.458003484544179"
			txtLongRad.Text = "-0.49133927325727"
		ElseIf cmbICAO.Text = "FALA" Then
			'txtPort.Text = "Lanseria, RSA"
			txtLatRad.Text = "-0.452622052683863"
			txtLongRad.Text = "-0.48735410479855"
		ElseIf cmbICAO.Text = "FAWM" Then
			'txtPort.Text = "Windhoek"
			txtLatRad.Text = "-0.392379104669192"
			txtLongRad.Text = "-0.304967197965142"
		ElseIf cmbICAO.Text = "FCBB" Then
			'txtPort.Text = "Brazzaville, Congo"
			txtLatRad.Text = "-0.0742928484932253"
			txtLongRad.Text = "-0.266162710929135"
		ElseIf cmbICAO.Text = "FEFF" Then
			'txtPort.Text = "Bangui, CAE"
			txtLatRad.Text = "0.0767653982668839"
			txtLongRad.Text = "-0.323264066290216"
		ElseIf cmbICAO.Text = "FMMI" Then
			'txtPort.Text = "Antananarivo, Madagascar"
			txtLatRad.Text = "-0.328063721733201"
			txtLongRad.Text = "-0.828624151205175"
		ElseIf cmbICAO.Text = "FNLU" Then
			'txtPort.Text = "Luanda"
			txtLatRad.Text = "-0.154548905264098"
			txtLongRad.Text = "-0.231023415322316"
		ElseIf cmbICAO.Text = "FOOL" Then
			'txtPort.Text = "Libreville"
			txtLatRad.Text = "-0.00799942573830734"
			txtLongRad.Text = "-0.164322749075266"
		ElseIf cmbICAO.Text = "FSIA" Then
			'txtPort.Text = "Seychelles Intl"
			txtLatRad.Text = "-0.0815359648890018"
			txtLongRad.Text = "-0.969064978348985"
		ElseIf cmbICAO.Text = "FVHA" Then
			'txtPort.Text = "Harare, Zimbabwe"
			txtLatRad.Text = "-0.31296662370345"
			txtLongRad.Text = "-0.54268104208677"
		ElseIf cmbICAO.Text = "FZNA" Then
			'txtPort.Text = "Goma, Zaire"
			txtLatRad.Text = "-0.0290888208665722"
			txtLongRad.Text = "-0.510217917999676"
		ElseIf cmbICAO.Text = "GBYD" Then
			'txtPort.Text = "Banjul"
			txtLatRad.Text = "0.23285601103691"
			txtLongRad.Text = "0.290742764561389"
		ElseIf cmbICAO.Text = "GCXO" Then
			'txtPort.Text = "Tenerife"
			txtLatRad.Text = "0.497157037431"
			txtLongRad.Text = "0.2851867998"
		ElseIf cmbICAO.Text = "GMAA" Then
			'txtPort.Text = "Agadir"
			txtLatRad.Text = "0.530260115577"
			txtLongRad.Text = "0.1667080324"
		ElseIf cmbICAO.Text = "GOOY" Then
			'txtPort.Text = "Dakar"
			txtLatRad.Text = "0.257290620565"
			txtLongRad.Text = "0.3052580862"
		ElseIf cmbICAO.Text = "HELX" Then
			'txtPort.Text = "Luxor"
			txtLatRad.Text = "0.447967841345"
			txtLongRad.Text = "-0.570722665"
		ElseIf cmbICAO.Text = "HKNW" Then
			'txtPort.Text = "Nairobi-Wilson"
			txtLatRad.Text = "-0.02298016848"
			txtLongRad.Text = "-0.642572053"
		ElseIf cmbICAO.Text = "HSSS" Then
			'txtPort.Text = "Khartoum"
			txtLatRad.Text = "0.272271363311"
			txtLongRad.Text = "-0.568250116"
		ElseIf cmbICAO.Text = "HTDA" Then
			'txtPort.Text = "Dar-Es-Salaam"
			txtLatRad.Text = "-0.11999138607"
			txtLongRad.Text = "-0.684198156"
		ElseIf cmbICAO.Text = "I69" Then
			'txtPort.Text = "Batavia, OH"
			txtLatRad.Text = "0.682045582859"
			txtLongRad.Text = "1.4697417631"
		ElseIf cmbICAO.Text = "KANC" Then
			'txtPort.Text = "Anchorage"
			txtLatRad.Text = "1.067292108651"
			txtLongRad.Text = "2.6215601674"
		ElseIf cmbICAO.Text = "KBGR" Then
			'txtPort.Text = "Bangor"
			txtLatRad.Text = "0.782052948998"
			txtLongRad.Text = "1.2012810353"
		ElseIf cmbICAO.Text = "KBOI" Then
			'txtPort.Text = "Boise"
			txtLatRad.Text = "0.760352688631"
			txtLongRad.Text = "2.0285089231"
		ElseIf cmbICAO.Text = "KCAE" Then
			'txtPort.Text = "Columbia, SC"
			txtLatRad.Text = "0.592364748127"
			txtLongRad.Text = "1.4158110892"
		ElseIf cmbICAO.Text = "KEWK" Then
			'txtPort.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO.Text = "KICT" Then
			'txtPort.Text = "Wichita, KS"
			txtLatRad.Text = "0.657116463376"
			txtLongRad.Text = "1.7005324679"
		ElseIf cmbICAO.Text = "KIDP" Then
			'txtPort.Text = "Independence, KS"
			txtLatRad.Text = "0.648535261220"
			txtLongRad.Text = "1.6716472687"
		ElseIf cmbICAO.Text = "KJNU" Then
			'txtPort.Text = "Juneau, AK"
			txtLatRad.Text = "1.018545062643"
			txtLongRad.Text = "2.3488738036"
		ElseIf cmbICAO.Text = "KMIA" Then
			'txtPort.Text = "Miami, FL"
			txtLatRad.Text = "0.450178591731"
			txtLongRad.Text = "1.4013248564"
		ElseIf cmbICAO.Text = "KMSP" Then
			'txtPort.Text = "Minneapolis, MN"
			txtLatRad.Text = "0.783391034758"
			txtLongRad.Text = "1.6269086622"
		ElseIf cmbICAO.Text = "KNUD" Then
			'txtPort.Text = "ADAK, AK"
			txtLatRad.Text = "0.905348825123"
			txtLongRad.Text = "3.0835022783"
		ElseIf cmbICAO.Text = "KOAK" Then
			'txtPort.Text = "Oakland, CA"
			txtLatRad.Text = "0.658454549136"
			txtLongRad.Text = "2.1331995894"
		ElseIf cmbICAO.Text = "KPDK" Then
			'txtPort.Text = "Atlanta, GA"
			txtLatRad.Text = "0.590648507696"
			txtLongRad.Text = "1.4713416483"
		ElseIf cmbICAO.Text = "KVRB" Then
			'txtPort.Text = "Vero Beach"
			txtLatRad.Text = "0.482670804639"
			txtLongRad.Text = "1.4035356068"
		ElseIf cmbICAO.Text = "LCPH" Then
			'txtPort.Text = "Larnaca, Cyprus"
			txtLatRad.Text = "0.608741754275"
			txtLongRad.Text = "-0.586954227"
		ElseIf cmbICAO.Text = "LEMD" Then
			'txtPort.Text = "Madrid"
			txtLatRad.Text = "0.706392925924"
			txtLongRad.Text = "-0.062133721"
		ElseIf cmbICAO.Text = "LEMG" Then
			'txtPort.Text = "Malaga"
			txtLatRad.Text = "0.640099503169"
			txtLongRad.Text = "0.0784816387"
		ElseIf cmbICAO.Text = "LFPN" Then
			'txtPort.Text = "Toussus Le Noble"
			txtLatRad.Text = "0.850877099168"
			txtLongRad.Text = "-0.036739181"
		ElseIf cmbICAO.Text = "LGAT" Then
			'txtPort.Text = "Athens"
			txtLatRad.Text = "0.661247075939"
			txtLongRad.Text = "-0.414166631"
		ElseIf cmbICAO.Text = "LGIR" Then
			'txtPort.Text = "Iraklion"
			txtLatRad.Text = "0.616770268834"
			txtLongRad.Text = "-0.439444817"
		ElseIf cmbICAO.Text = "LIRA" Then
			'txtPort.Text = "Rome"
			txtLatRad.Text = "0.729518538513"
			txtLongRad.Text = "-0.219824219"
		ElseIf cmbICAO.Text = "LKPR" Then
			'txtPort.Text = "Prague, Czech"
			txtLatRad.Text = "0.874439044070"
			txtLongRad.Text = "-0.248913040"
		ElseIf cmbICAO.Text = "LPAZ" Then
			'txtPort.Text = "Santa Maria"
			txtLatRad.Text = "0.645306402104"
			txtLongRad.Text = "0.4393284615"
		ElseIf cmbICAO.Text = "LPPR" Then
			'txtPort.Text = "Porto, Portugal"
			txtLatRad.Text = "0.719657428239"
			txtLongRad.Text = "0.1514364014"
		ElseIf cmbICAO.Text = "LROP" Then
			'txtPort.Text = "Bucharest, Romania"
			txtLatRad.Text = "0.777893247614"
			txtLongRad.Text = "-0.455298224"
		ElseIf cmbICAO.Text = "LTAC" Then
			'txtPort.Text = "Ankara"
			txtLatRad.Text = "0.700313362363"
			txtLongRad.Text = "-0.575842298"
		ElseIf cmbICAO.Text = "LTBA" Then
			'txtPort.Text = "Istanbul, Turkey"
			txtLatRad.Text = "0.715177749826"
			txtLongRad.Text = "-0.502945713"
		ElseIf cmbICAO.Text = "MROC" Then
			'txtPort.Text = "San Jose, CR"
			txtLatRad.Text = "0.174416569916"
			txtLongRad.Text = "1.4697708519"
		ElseIf cmbICAO.Text = "NTSU" Then
			'txtPort.Text = "Pago Pago"
			txtLatRad.Text = "0.250192948273"
			txtLongRad.Text = "2.9794515661"
		ElseIf cmbICAO.Text = "NZAA" Then
			'txtPort.Text = "Auckland"
			txtLatRad.Text = "-0.64588817852"
			txtLongRad.Text = "-3.050690088"
		ElseIf cmbICAO.Text = "OOMS" Then
			'txtPort.Text = "SEEB, Oman"
			txtLatRad.Text = "0.411781348187"
			txtLongRad.Text = "-1.017148799"
		ElseIf cmbICAO.Text = "OPKC" Then
			'txtPort.Text = "Karachi"
			txtLatRad.Text = "0.434703339030"
			txtLongRad.Text = "-1.172104948"
		ElseIf cmbICAO.Text = "PAOM" Then
			'txtPort.Text = "Nome, AK"
			txtLatRad.Text = "1.125970078103"
			txtLongRad.Text = "2.8875308921"
		ElseIf cmbICAO.Text = "PGSN" Then
			'txtPort.Text = "Saipan"
			txtLatRad.Text = "0.263922871722"
			txtLongRad.Text = "-2.543526497"
		ElseIf cmbICAO.Text = "PHNL" Then
			'txtPort.Text = "Honolulu, HI"
			txtLatRad.Text = "0.372075107704"
			txtLongRad.Text = "2.7562821324"
		ElseIf cmbICAO.Text = "PHTO" Then
			'txtPort.Text = "HILO"
			txtLatRad.Text = "0.344237106135"
			txtLongRad.Text = "2.7061620940"
		ElseIf cmbICAO.Text = "PKMJ" Then
			'txtPort.Text = "Majuro"
			txtLatRad.Text = "0.123249334012"
			txtLongRad.Text = "-2.989312676"
		ElseIf cmbICAO.Text = "PLCH" Then
			'txtPort.Text = "Christmas Island"
			txtLatRad.Text = "0.034702963294"
			txtLongRad.Text = "2.7463628445"
		ElseIf cmbICAO.Text = "PMDY" Then
			'txtPort.Text = "Midway"
			txtLatRad.Text = "0.492386470808"
			txtLongRad.Text = "3.0958650272"
		ElseIf cmbICAO.Text = "PTRO" Then
			'txtPort.Text = "Palau"
			txtLatRad.Text = "0.128543499409"
			txtLongRad.Text = "-2.348369597"
		ElseIf cmbICAO.Text = "PWAK" Then
			'txtPort.Text = "WAKE"
			txtLatRad.Text = "0.336499479785"
			txtLongRad.Text = "-2.908445754"
		ElseIf cmbICAO.Text = "RCTP" Then
			'txtPort.Text = "Chiang Kai Shek"
			txtLatRad.Text = "0.437699487579"
			txtLongRad.Text = "-2.115717208"
		ElseIf cmbICAO.Text = "RJCK" Then
			'txtPort.Text = "Kushiro"
			txtLatRad.Text = "0.751218798879"
			txtLongRad.Text = "-2.516677515"
		ElseIf cmbICAO.Text = "RJTT" Then
			'txtPort.Text = "Tokyo"
			txtLatRad.Text = "0.620580904367"
			txtLongRad.Text = "-2.437643189"
		ElseIf cmbICAO.Text = "RKSS" Then
			'txtPort.Text = "Seoul, Korea"
			txtLatRad.Text = "0.655429311766"
			txtLongRad.Text = "-2.213077492"
		ElseIf cmbICAO.Text = "RPMM" Then
			'txtPort.Text = "Manilla"
			txtLatRad.Text = "0.253218185644"
			txtLongRad.Text = "-2.112197461"
		ElseIf cmbICAO.Text = "SAEZ" Then
			'txtPort.Text = "Ezeiza"
			txtLatRad.Text = "-0.60772364554"
			txtLongRad.Text = "1.0215993888"
		ElseIf cmbICAO.Text = "SBEG" Then
			'txtPort.Text = "Manaus"
			txtLatRad.Text = "-0.05305800926"
			txtLongRad.Text = "1.0480120382"
		ElseIf cmbICAO.Text = "SBGL" Then
			'txtPort.Text = "Rio De Janeiro, Brazil"
			txtLatRad.Text = "-0.39810960238"
			txtLongRad.Text = "0.7548549015"
		ElseIf cmbICAO.Text = "SBSP" Then
			'txtPort.Text = "Sao Paulo"
			txtLatRad.Text = "-0.41233403578"
			txtLongRad.Text = "0.8143124513"
		ElseIf cmbICAO.Text = "SCEL" Then
			'txtPort.Text = "Santiago, Chile"
			txtLatRad.Text = "-0.58279452606"
			txtLongRad.Text = "1.2354022222"
		ElseIf cmbICAO.Text = "SVMG" Then
			'txtPort.Text = "Margarita, VE"
			txtLatRad.Text = "0.190531776676"
			txtLongRad.Text = "1.1163998560"
		ElseIf cmbICAO.Text = "TTPP" Then
			'txtPort.Text = "Picaro"
			txtLatRad.Text = "0.184888545428"
			txtLongRad.Text = "1.0705558744"
		ElseIf cmbICAO.Text = "UHHH" Then
			'txtPort.Text = "Khabarovsk, Russia"
			txtLatRad.Text = "0.846950108351"
			txtLongRad.Text = "-2.359452438"
		ElseIf cmbICAO.Text = "UHMM" Then
			'txtPort.Text = "Magadan, Russia"
			txtLatRad.Text = "1.045743110153"
			txtLongRad.Text = "-2.630502071"
		ElseIf cmbICAO.Text = "UHPP" Then
			'txtPort.Text = "Petropavlovsk, Russia"
			txtLatRad.Text = "0.927933385644"
			txtLongRad.Text = "-2.7654742"
		ElseIf cmbICAO.Text = "UHSS" Then
			'txtPort.Text = "Yuzhno, Russia"
			txtLatRad.Text = "0.700720605855"
			txtLongRad.Text = "-2.490730287"
		ElseIf cmbICAO.Text = "UTTT" Then
			'txtPort.Text = "Tashkent, Russia"
			txtLatRad.Text = "0.719948316448"
			txtLongRad.Text = "-1.209222283"
		ElseIf cmbICAO.Text = "UUEE" Then
			'txtPort.Text = "Moscow, Russia"
			txtLatRad.Text = "0.976889871162"
			txtLongRad.Text = "-0.65301494"
		ElseIf cmbICAO.Text = "VABB" Then
			'txtPort.Text = "Bombay"
			txtLatRad.Text = "0.333212443027"
			txtLongRad.Text = "-1.271763248"
		ElseIf cmbICAO.Text = "VCBI" Then
			'txtPort.Text = "Columbo, Sri Lanka"
			txtLatRad.Text = "0.125314640293"
			txtLongRad.Text = "-1.394227184"
		ElseIf cmbICAO.Text = "VIDP" Then
			'txtPort.Text = "Delhi"
			txtLatRad.Text = "0.498582389653"
			txtLongRad.Text = "-1.345648853"
		ElseIf cmbICAO.Text = "VNKT" Then
			'txtPort.Text = "Katmandu, Nepal"
			txtLatRad.Text = "0.485230620875"
			txtLongRad.Text = "-1.489842138"
		ElseIf cmbICAO.Text = "VOMM" Then
			'txtPort.Text = "Madras"
			txtLatRad.Text = "0.226805536297"
			txtLongRad.Text = "-1.399346817"
		ElseIf cmbICAO.Text = "VOPB" Then
			'txtPort.Text = "Port Blair, Nicobar"
			txtLatRad.Text = "0.203272680216"
			txtLongRad.Text = "-1.618531082"
		ElseIf cmbICAO.Text = "VRMM" Then
			'txtPort.Text = "Male, Maldives"
			txtLatRad.Text = "0.073158384479"
			txtLongRad.Text = "-1.283398777"
		ElseIf cmbICAO.Text = "VTBD" Then
			'txtPort.Text = "Bangkok"
			txtLatRad.Text = "0.242891654236"
			txtLongRad.Text = "-1.755888494"
		ElseIf cmbICAO.Text = "WMKJ" Then
			'txtPort.Text = "Johor Bahru, Malaysia"
			txtLatRad.Text = "0.028594310912"
			txtLongRad.Text = "-1.809411924"
		ElseIf cmbICAO.Text = "WMKK" Then
			'txtPort.Text = "Kuala Lumpur"
			txtLatRad.Text = "0.054628805587"
			txtLongRad.Text = "-1.772410944"
		ElseIf cmbICAO.Text = "WSSL" Then
			'txtPort.Text = "Singapore"
			txtLatRad.Text = "0.024725497737"
			txtLongRad.Text = "-1.812815316"
		ElseIf cmbICAO.Text = "ZGGG" Then
			'txtPort.Text = "Guangzhou"
			txtLatRad.Text = "0.404625498254"
			txtLongRad.Text = "-1.976847177"
		ElseIf cmbICAO.Text = "Other" Then
			txtICAO.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO")
			txtOrig.Text = InputBox("Enter Name of Airport.", "Other ICAO")
			txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
			txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
			txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
			txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
			intLatDeg = CDbl(txtLatDeg.Text)
			intLatMin = CDbl(txtLatMin.Text)
			intLatSec = CDbl(txtLatSec.Text)
			intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
			If txtNS.Text = "S" Then
				intLatRad = intLatRad * -1
			ElseIf txtNS.Text = "s" Then
				intLatRad = intLatRad * -1
			End If
			txtLatRad.Text = CStr(intLatRad / (180 / 3.141592654))
			txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
			txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
			txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
			txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
			intLongDeg = CDbl(txtLongDeg.Text)
			intLongMin = CDbl(txtLongMin.Text)
			intLongSec = CDbl(txtLongSec.Text)
			intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
			If txtEW.Text = "E" Then
				intLongRad = intLongRad * -1
			ElseIf txtEW.Text = "e" Then
				intLongRad = intLongRad * -1
			End If
			txtLongRad.Text = CStr(intLongRad / (180 / 3.141592654))
			cmbICAO.Visible = False

			strICAO = txtICAO.Text
			strPort = txtOrig.Text
			strLatRad = txtLatRad.Text
			strLongRad = txtLongRad.Text
			FileOpen(1, "Bid ICAO.txt", OpenMode.Append)
			WriteLine(1, strICAO, strPort, strLatRad, strLongRad)
			FileClose(1)


		End If

		cmbICAO1.Focus()


	End Sub


	'UPGRADE_WARNING: Event cmbICAO1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	<Obsolete>
	Private Sub cmbICAO1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO1.SelectedIndexChanged

		If cmbICAO2.Text <> "" Then
			cmbICAO2.Text = ""
			cmbICAO3.Text = ""
			cmbICAO4.Text = ""
			cmbICAO5.Text = ""
			cmbICAO6.Text = ""
			cmbICAO7.Text = ""
			cmbICAO8.Text = ""
			cmbICAO9.Text = ""
			cmbICAO10.Text = ""
			cmbICAO11.Text = ""
			cmbICAO12.Text = ""
			cmbICAO13.Text = ""
			cmbICAO14.Text = ""
			cmbICAO15.Text = ""
			txtPort1.Text = ""
			txtPort2.Text = ""
			txtPort3.Text = ""
			txtPort4.Text = ""
			txtPort5.Text = ""
			txtPort6.Text = ""
			txtPort7.Text = ""
			txtLeg1.Text = ""
			txtLeg2.Text = ""
			txtLeg3.Text = ""
			txtLeg4.Text = ""
			txtLeg5.Text = ""
			txtLeg6.Text = ""
			txtLeg7.Text = ""
			txtTotal1.Text = ""
			txtTotal2.Text = ""
			txtTotal3.Text = ""
			txtTotal4.Text = ""
			txtTotal5.Text = ""
			txtTotal6.Text = ""
			txtTotal7.Text = ""

			Call cmbICAO_SelectedIndexChanged(cmbICAO, New System.EventArgs())

		End If

		If cmbICAO1.Text = cmbICAO.Text Then
			If cmbICAO1.Text <> "Other" Then
				Call MsgBox("Please re-enter destination, not equal to origination.", MsgBoxStyle.OKOnly, "Re-enter Destination")
				cmbICAO1.Text = ""
				cmbICAO1.Focus()
				Exit Sub
			End If
		ElseIf cmbICAO1.Text = "ASSY" Then
			txtPort.Text = "Sidney"
			txtLatRad1.Text = "-0.592248392843409"
			txtLongRad1.Text = "-2.63835605259809"
		ElseIf cmbICAO1.Text = "AYPY" Then
			txtPort.Text = "Port Moresby, PNG"
			txtLatRad1.Text = "-0.164817259029998"
			txtLongRad1.Text = "-2.56941554714432"
		ElseIf cmbICAO1.Text = "BGBW" Then
			txtPort.Text = "Narsarsuaq"
			txtLatRad1.Text = "1.0674724593406"
			txtLongRad1.Text = "0.792873990360157"
		ElseIf cmbICAO1.Text = "BGGH" Then
			txtPort.Text = "Godthab"
			txtLatRad1.Text = "1.12035593567603"
			txtLongRad1.Text = "0.902044335072403"
		ElseIf cmbICAO1.Text = "BIRK" Then
			txtPort.Text = "Reykjavik"
			txtLatRad1.Text = "1.1192505604831"
			txtLongRad1.Text = "0.382983415529289"
		ElseIf cmbICAO1.Text = "CYAM" Then
			txtPort.Text = "Sault Ste. Marie"
			txtLatRad1.Text = "0.811316302789564"
			txtLongRad1.Text = "1.47497775086041"
		ElseIf cmbICAO1.Text = "CYFB" Then
			txtPort.Text = "Iqaluit"
			txtLatRad1.Text = "1.11276375342985"
			txtLongRad1.Text = "1.19653955752558"
		ElseIf cmbICAO1.Text = "CYQX" Then
			txtPort.Text = "Gander"
			txtLatRad1.Text = "0.854164135926025"
			txtLongRad1.Text = "0.952426172813306"
		ElseIf cmbICAO1.Text = "CYYQ" Then
			txtPort.Text = "Churchill Falls"
			txtLatRad1.Text = "1.02520640262147"
			txtLongRad1.Text = "1.64177304970933"
		ElseIf cmbICAO1.Text = "CYYR" Then
			txtPort.Text = "Goose Bay"
			txtLatRad1.Text = "0.930609557163376"
			txtLongRad1.Text = "1.05464428933844"
		ElseIf cmbICAO1.Text = "CYYT" Then
			txtPort.Text = "St John's, NFLD"
			txtLatRad1.Text = "0.831096700978833"
			txtLongRad1.Text = "0.920690269247875"
		ElseIf cmbICAO1.Text = "DAAG" Then
			txtPort.Text = "Algiers, Algeria"
			txtLatRad1.Text = "0.640419480198453"
			txtLongRad1.Text = "-0.0561705130933508"
		ElseIf cmbICAO1.Text = "DIAP" Then
			txtPort.Text = "Abidjan"
			txtLatRad1.Text = "0.0916588745505689"
			txtLongRad1.Text = "0.0685623507825106"
		ElseIf cmbICAO1.Text = "DNMM" Then
			txtPort.Text = "Lagos, Nigeria"
			txtLatRad1.Text = "0.114755398318627"
			txtLongRad1.Text = "-0.0579158423453452"
		ElseIf cmbICAO1.Text = "DRRN" Then
			txtPort.Text = "Niami, Niger"
			txtLatRad1.Text = "0.235299471989702"
			txtLongRad1.Text = "-0.0379318224100101"
		ElseIf cmbICAO1.Text = "EBBR" Then
			txtPort.Text = "Brussels"
			txtLatRad1.Text = "0.88840167808598"
			txtLongRad1.Text = "-0.0785107275188782"
		ElseIf cmbICAO1.Text = "EDDW" Then
			txtPort.Text = "Bremen, Germany"
			txtLatRad1.Text = "0.925868079362125"
			txtLongRad1.Text = "-0.153385352429435"
		ElseIf cmbICAO1.Text = "EFHK" Then
			txtPort.Text = "Helsinki, Finland"
			txtLatRad1.Text = "1.05272442716125"
			txtLongRad1.Text = "-0.435750536581251"
		ElseIf cmbICAO1.Text = "EGPD" Then
			txtPort.Text = "Aberdeen"
			txtLatRad1.Text = "0.998415598603356"
			txtLongRad1.Text = "0.0383681547230087"
		ElseIf cmbICAO1.Text = "EGPK" Then
			txtPort.Text = "Prestwick"
			txtLatRad1.Text = "0.968686823677719"
			txtLongRad1.Text = "0.0798779020996071"
		ElseIf cmbICAO1.Text = "EHBK" Then
			txtPort.Text = "Maastricht, Netherlands"
			txtLatRad1.Text = "0.888663477473779"
			txtLongRad1.Text = "-0.100821853123539"
		ElseIf cmbICAO1.Text = "EINN" Then
			txtPort.Text = "Shannon"
			txtLatRad1.Text = "0.919788515801012"
			txtLongRad1.Text = "0.155741546919627"
		ElseIf cmbICAO1.Text = "EKCH" Then
			txtPort.Text = "Copenhagen"
			txtLatRad1.Text = "0.97054850821318"
			txtLongRad1.Text = "-0.220493262168617"
		ElseIf cmbICAO1.Text = "ELLX" Then
			txtPort.Text = "Luxembourg"
			txtLatRad1.Text = "0.86609055248132"
			txtLongRad1.Text = "-0.108297680086248"
		ElseIf cmbICAO1.Text = "ENBR" Then
			txtPort.Text = "Bergen, Norway"
			txtLatRad1.Text = "1.05231718366911"
			txtLongRad1.Text = "-0.091106186954104"
		ElseIf cmbICAO1.Text = "FAGM" Then
			txtPort.Text = "Rand"
			txtLatRad1.Text = "-0.458003484544179"
			txtLongRad1.Text = "-0.49133927325727"
		ElseIf cmbICAO1.Text = "FALA" Then
			txtPort.Text = "Lanseria, RSA"
			txtLatRad1.Text = "-0.452622052683863"
			txtLongRad1.Text = "-0.48735410479855"
		ElseIf cmbICAO1.Text = "FAWM" Then
			txtPort.Text = "Windhoek"
			txtLatRad1.Text = "-0.392379104669192"
			txtLongRad1.Text = "-0.304967197965142"
		ElseIf cmbICAO1.Text = "FCBB" Then
			txtPort.Text = "Brazzaville, Congo"
			txtLatRad1.Text = "-0.0742928484932253"
			txtLongRad1.Text = "-0.266162710929135"
		ElseIf cmbICAO1.Text = "FEFF" Then
			txtPort.Text = "Bangui, CAE"
			txtLatRad1.Text = "0.0767653982668839"
			txtLongRad1.Text = "-0.323264066290216"
		ElseIf cmbICAO1.Text = "FMMI" Then
			txtPort.Text = "Antananarivo, Madagascar"
			txtLatRad1.Text = "-0.328063721733201"
			txtLongRad1.Text = "-0.828624151205175"
		ElseIf cmbICAO1.Text = "FNLU" Then
			txtPort.Text = "Luanda"
			txtLatRad1.Text = "-0.154548905264098"
			txtLongRad1.Text = "-0.231023415322316"
		ElseIf cmbICAO1.Text = "FOOL" Then
			txtPort.Text = "Libreville"
			txtLatRad1.Text = "-0.00799942573830734"
			txtLongRad1.Text = "-0.164322749075266"
		ElseIf cmbICAO1.Text = "FSIA" Then
			txtPort.Text = "Seychelles Intl"
			txtLatRad1.Text = "-0.0815359648890018"
			txtLongRad1.Text = "-0.969064978348985"
		ElseIf cmbICAO1.Text = "FVHA" Then
			txtPort.Text = "Harare, Zimbabwe"
			txtLatRad1.Text = "-0.31296662370345"
			txtLongRad1.Text = "-0.54268104208677"
		ElseIf cmbICAO1.Text = "FZNA" Then
			txtPort.Text = "Goma, Zaire"
			txtLatRad1.Text = "-0.0290888208665722"
			txtLongRad1.Text = "-0.510217917999676"
		ElseIf cmbICAO1.Text = "GBYD" Then
			txtPort.Text = "Banjul"
			txtLatRad1.Text = "0.23285601103691"
			txtLongRad1.Text = "0.290742764561389"
		ElseIf cmbICAO1.Text = "GCXO" Then
			txtPort.Text = "Tenerife"
			txtLatRad1.Text = "0.497157037431"
			txtLongRad1.Text = "0.2851867998"
		ElseIf cmbICAO1.Text = "GMAA" Then
			txtPort.Text = "Agadir"
			txtLatRad1.Text = "0.530260115577"
			txtLongRad1.Text = "0.1667080324"
		ElseIf cmbICAO1.Text = "GOOY" Then
			txtPort.Text = "Dakar"
			txtLatRad1.Text = "0.257290620565"
			txtLongRad1.Text = "0.3052580862"
		ElseIf cmbICAO1.Text = "HELX" Then
			txtPort.Text = "Luxor"
			txtLatRad1.Text = "0.447967841345"
			txtLongRad1.Text = "-0.570722665"
		ElseIf cmbICAO1.Text = "HKNW" Then
			txtPort.Text = "Nairobi-Wilson"
			txtLatRad1.Text = "-0.02298016848"
			txtLongRad1.Text = "-0.642572053"
		ElseIf cmbICAO1.Text = "HSSS" Then
			txtPort.Text = "Khartoum"
			txtLatRad1.Text = "0.272271363311"
			txtLongRad1.Text = "-0.568250116"
		ElseIf cmbICAO1.Text = "HTDA" Then
			txtPort.Text = "Dar-Es-Salaam"
			txtLatRad1.Text = "-0.11999138607"
			txtLongRad1.Text = "-0.684198156"
		ElseIf cmbICAO1.Text = "I69" Then
			txtPort.Text = "Batavia, OH"
			txtLatRad1.Text = "0.682045582859"
			txtLongRad1.Text = "1.4697417631"
		ElseIf cmbICAO1.Text = "KANC" Then
			txtPort.Text = "Anchorage"
			txtLatRad1.Text = "1.067292108651"
			txtLongRad1.Text = "2.6215601674"
		ElseIf cmbICAO1.Text = "KBGR" Then
			txtPort.Text = "Bangor"
			txtLatRad1.Text = "0.782052948998"
			txtLongRad1.Text = "1.2012810353"
		ElseIf cmbICAO1.Text = "KBOI" Then
			txtPort.Text = "Boise"
			txtLatRad1.Text = "0.760352688631"
			txtLongRad1.Text = "2.0285089231"
		ElseIf cmbICAO1.Text = "KCAE" Then
			txtPort.Text = "Columbia, SC"
			txtLatRad1.Text = "0.592364748127"
			txtLongRad1.Text = "1.4158110892"
		ElseIf cmbICAO1.Text = "KEWK" Then
			txtPort.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO1.Text = "KICT" Then
			txtPort.Text = "Wichita, KS"
			txtLatRad1.Text = "0.657116463376"
			txtLongRad1.Text = "1.7005324679"
		ElseIf cmbICAO1.Text = "KIDP" Then
			txtPort.Text = "Independence, KS"
			txtLatRad1.Text = "0.648535261220"
			txtLongRad1.Text = "1.6716472687"
		ElseIf cmbICAO1.Text = "KJNU" Then
			txtPort.Text = "Juneau, AK"
			txtLatRad1.Text = "1.018545062643"
			txtLongRad1.Text = "2.3488738036"
		ElseIf cmbICAO1.Text = "KMIA" Then
			txtPort.Text = "Miami, FL"
			txtLatRad1.Text = "0.450178591731"
			txtLongRad1.Text = "1.4013248564"
		ElseIf cmbICAO1.Text = "KMSP" Then
			txtPort.Text = "Minneapolis, MN"
			txtLatRad1.Text = "0.783391034758"
			txtLongRad1.Text = "1.6269086622"
		ElseIf cmbICAO1.Text = "KNUD" Then
			txtPort.Text = "ADAK, AK"
			txtLatRad1.Text = "0.905348825123"
			txtLongRad1.Text = "3.0835022783"
		ElseIf cmbICAO1.Text = "KOAK" Then
			txtPort.Text = "Oakland, CA"
			txtLatRad1.Text = "0.658454549136"
			txtLongRad1.Text = "2.1331995894"
		ElseIf cmbICAO1.Text = "KPDK" Then
			txtPort.Text = "Atlanta, GA"
			txtLatRad1.Text = "0.590648507696"
			txtLongRad1.Text = "1.4713416483"
		ElseIf cmbICAO1.Text = "KVRB" Then
			txtPort.Text = "Vero Beach"
			txtLatRad1.Text = "0.482670804639"
			txtLongRad1.Text = "1.4035356068"
		ElseIf cmbICAO1.Text = "LCPH" Then
			txtPort.Text = "Larnaca, Cyprus"
			txtLatRad1.Text = "0.608741754275"
			txtLongRad1.Text = "-0.586954227"
		ElseIf cmbICAO1.Text = "LEMD" Then
			txtPort.Text = "Madrid"
			txtLatRad1.Text = "0.706392925924"
			txtLongRad1.Text = "-0.062133721"
		ElseIf cmbICAO1.Text = "LEMG" Then
			txtPort.Text = "Malaga"
			txtLatRad1.Text = "0.640099503169"
			txtLongRad1.Text = "0.0784816387"
		ElseIf cmbICAO1.Text = "LFPN" Then
			txtPort.Text = "Toussus Le Noble"
			txtLatRad1.Text = "0.850877099168"
			txtLongRad1.Text = "-0.036739181"
		ElseIf cmbICAO1.Text = "LGAT" Then
			txtPort.Text = "Athens"
			txtLatRad1.Text = "0.661247075939"
			txtLongRad1.Text = "-0.414166631"
		ElseIf cmbICAO1.Text = "LGIR" Then
			txtPort.Text = "Iraklion"
			txtLatRad1.Text = "0.616770268834"
			txtLongRad1.Text = "-0.439444817"
		ElseIf cmbICAO1.Text = "LIRA" Then
			txtPort.Text = "Rome"
			txtLatRad1.Text = "0.729518538513"
			txtLongRad1.Text = "-0.219824219"
		ElseIf cmbICAO1.Text = "LKPR" Then
			txtPort.Text = "Prague, Czech"
			txtLatRad1.Text = "0.874439044070"
			txtLongRad1.Text = "-0.248913040"
		ElseIf cmbICAO1.Text = "LPAZ" Then
			txtPort.Text = "Santa Maria"
			txtLatRad1.Text = "0.645306402104"
			txtLongRad1.Text = "0.4393284615"
		ElseIf cmbICAO1.Text = "LPPR" Then
			txtPort.Text = "Porto, Portugal"
			txtLatRad1.Text = "0.719657428239"
			txtLongRad1.Text = "0.1514364014"
		ElseIf cmbICAO1.Text = "LROP" Then
			txtPort.Text = "Bucharest, Romania"
			txtLatRad1.Text = "0.777893247614"
			txtLongRad1.Text = "-0.455298224"
		ElseIf cmbICAO1.Text = "LTAC" Then
			txtPort.Text = "Ankara"
			txtLatRad1.Text = "0.700313362363"
			txtLongRad1.Text = "-0.575842298"
		ElseIf cmbICAO1.Text = "LTBA" Then
			txtPort.Text = "Istanbul, Turkey"
			txtLatRad1.Text = "0.715177749826"
			txtLongRad1.Text = "-0.502945713"
		ElseIf cmbICAO1.Text = "MROC" Then
			txtPort.Text = "San Jose, CR"
			txtLatRad1.Text = "0.174416569916"
			txtLongRad1.Text = "1.4697708519"
		ElseIf cmbICAO1.Text = "NTSU" Then
			txtPort.Text = "Pago Pago"
			txtLatRad1.Text = "0.250192948273"
			txtLongRad1.Text = "2.9794515661"
		ElseIf cmbICAO1.Text = "NZAA" Then
			txtPort.Text = "Auckland"
			txtLatRad1.Text = "-0.64588817852"
			txtLongRad1.Text = "-3.050690088"
		ElseIf cmbICAO1.Text = "OOMS" Then
			txtPort.Text = "SEEB, Oman"
			txtLatRad1.Text = "0.411781348187"
			txtLongRad1.Text = "-1.017148799"
		ElseIf cmbICAO1.Text = "OPKC" Then
			txtPort.Text = "Karachi"
			txtLatRad1.Text = "0.434703339030"
			txtLongRad1.Text = "-1.172104948"
		ElseIf cmbICAO1.Text = "PAOM" Then
			txtPort.Text = "Nome, AK"
			txtLatRad1.Text = "1.125970078103"
			txtLongRad1.Text = "2.8875308921"
		ElseIf cmbICAO1.Text = "PGSN" Then
			txtPort.Text = "Saipan"
			txtLatRad1.Text = "0.263922871722"
			txtLongRad1.Text = "-2.543526497"
		ElseIf cmbICAO1.Text = "PHNL" Then
			txtPort.Text = "Honolulu, HI"
			txtLatRad1.Text = "0.372075107704"
			txtLongRad1.Text = "2.7562821324"
		ElseIf cmbICAO1.Text = "PHTO" Then
			txtPort.Text = "HILO"
			txtLatRad1.Text = "0.344237106135"
			txtLongRad1.Text = "2.7061620940"
		ElseIf cmbICAO1.Text = "PKMJ" Then
			txtPort.Text = "Majuro"
			txtLatRad1.Text = "0.123249334012"
			txtLongRad1.Text = "-2.989312676"
		ElseIf cmbICAO1.Text = "PLCH" Then
			txtPort.Text = "Christmas Island"
			txtLatRad1.Text = "0.034702963294"
			txtLongRad1.Text = "2.7463628445"
		ElseIf cmbICAO1.Text = "PMDY" Then
			txtPort.Text = "Midway"
			txtLatRad1.Text = "0.492386470808"
			txtLongRad1.Text = "3.0958650272"
		ElseIf cmbICAO1.Text = "PTRO" Then
			txtPort.Text = "Palau"
			txtLatRad1.Text = "0.128543499409"
			txtLongRad1.Text = "-2.348369597"
		ElseIf cmbICAO1.Text = "PWAK" Then
			txtPort.Text = "WAKE"
			txtLatRad1.Text = "0.336499479785"
			txtLongRad1.Text = "-2.908445754"
		ElseIf cmbICAO1.Text = "RCTP" Then
			txtPort.Text = "Chiang Kai Shek"
			txtLatRad1.Text = "0.437699487579"
			txtLongRad1.Text = "-2.115717208"
		ElseIf cmbICAO1.Text = "RJCK" Then
			txtPort.Text = "Kushiro"
			txtLatRad1.Text = "0.751218798879"
			txtLongRad1.Text = "-2.516677515"
		ElseIf cmbICAO1.Text = "RJTT" Then
			txtPort.Text = "Tokyo"
			txtLatRad1.Text = "0.620580904367"
			txtLongRad1.Text = "-2.437643189"
		ElseIf cmbICAO1.Text = "RKSS" Then
			txtPort.Text = "Seoul, Korea"
			txtLatRad1.Text = "0.655429311766"
			txtLongRad1.Text = "-2.213077492"
		ElseIf cmbICAO1.Text = "RPMM" Then
			txtPort.Text = "Manilla"
			txtLatRad1.Text = "0.253218185644"
			txtLongRad1.Text = "-2.112197461"
		ElseIf cmbICAO1.Text = "SAEZ" Then
			txtPort.Text = "Ezeiza"
			txtLatRad1.Text = "-0.60772364554"
			txtLongRad1.Text = "1.0215993888"
		ElseIf cmbICAO1.Text = "SBEG" Then
			txtPort.Text = "Manaus"
			txtLatRad1.Text = "-0.05305800926"
			txtLongRad1.Text = "1.0480120382"
		ElseIf cmbICAO1.Text = "SBGL" Then
			txtPort.Text = "Rio De Janeiro, Brazil"
			txtLatRad1.Text = "-0.39810960238"
			txtLongRad1.Text = "0.7548549015"
		ElseIf cmbICAO1.Text = "SBSP" Then
			txtPort.Text = "Sao Paulo"
			txtLatRad1.Text = "-0.41233403578"
			txtLongRad1.Text = "0.8143124513"
		ElseIf cmbICAO1.Text = "SCEL" Then
			txtPort.Text = "Santiago, Chile"
			txtLatRad1.Text = "-0.58279452606"
			txtLongRad1.Text = "1.2354022222"
		ElseIf cmbICAO1.Text = "SVMG" Then
			txtPort.Text = "Margarita, VE"
			txtLatRad1.Text = "0.190531776676"
			txtLongRad1.Text = "1.1163998560"
		ElseIf cmbICAO1.Text = "TTPP" Then
			txtPort.Text = "Picaro"
			txtLatRad1.Text = "0.184888545428"
			txtLongRad1.Text = "1.0705558744"
		ElseIf cmbICAO1.Text = "UHHH" Then
			txtPort.Text = "Khabarovsk, Russia"
			txtLatRad1.Text = "0.846950108351"
			txtLongRad1.Text = "-2.359452438"
		ElseIf cmbICAO1.Text = "UHMM" Then
			txtPort.Text = "Magadan, Russia"
			txtLatRad1.Text = "1.045743110153"
			txtLongRad1.Text = "-2.630502071"
		ElseIf cmbICAO1.Text = "UHPP" Then
			txtPort.Text = "Petropavlovsk, Russia"
			txtLatRad1.Text = "0.927933385644"
			txtLongRad1.Text = "-2.7654742"
		ElseIf cmbICAO1.Text = "UHSS" Then
			txtPort.Text = "Yuzhno, Russia"
			txtLatRad1.Text = "0.700720605855"
			txtLongRad1.Text = "-2.490730287"
		ElseIf cmbICAO1.Text = "UTTT" Then
			txtPort.Text = "Tashkent, Russia"
			txtLatRad1.Text = "0.719948316448"
			txtLongRad1.Text = "-1.209222283"
		ElseIf cmbICAO1.Text = "UUEE" Then
			txtPort.Text = "Moscow, Russia"
			txtLatRad1.Text = "0.976889871162"
			txtLongRad1.Text = "-0.65301494"
		ElseIf cmbICAO1.Text = "VABB" Then
			txtPort.Text = "Bombay"
			txtLatRad1.Text = "0.333212443027"
			txtLongRad1.Text = "-1.271763248"
		ElseIf cmbICAO1.Text = "VCBI" Then
			txtPort.Text = "Columbo, Sri Lanka"
			txtLatRad1.Text = "0.125314640293"
			txtLongRad1.Text = "-1.394227184"
		ElseIf cmbICAO1.Text = "VIDP" Then
			txtPort.Text = "Delhi"
			txtLatRad1.Text = "0.498582389653"
			txtLongRad1.Text = "-1.345648853"
		ElseIf cmbICAO1.Text = "VNKT" Then
			txtPort.Text = "Katmandu, Nepal"
			txtLatRad1.Text = "0.485230620875"
			txtLongRad1.Text = "-1.489842138"
		ElseIf cmbICAO1.Text = "VOMM" Then
			txtPort.Text = "Madras"
			txtLatRad1.Text = "0.226805536297"
			txtLongRad1.Text = "-1.399346817"
		ElseIf cmbICAO1.Text = "VOPB" Then
			txtPort.Text = "Port Blair, Nicobar"
			txtLatRad1.Text = "0.203272680216"
			txtLongRad1.Text = "-1.618531082"
		ElseIf cmbICAO1.Text = "VRMM" Then
			txtPort.Text = "Male, Maldives"
			txtLatRad1.Text = "0.073158384479"
			txtLongRad1.Text = "-1.283398777"
		ElseIf cmbICAO1.Text = "VTBD" Then
			txtPort.Text = "Bangkok"
			txtLatRad1.Text = "0.242891654236"
			txtLongRad1.Text = "-1.755888494"
		ElseIf cmbICAO1.Text = "WMKJ" Then
			txtPort.Text = "Johor Bahru, Malaysia"
			txtLatRad1.Text = "0.028594310912"
			txtLongRad1.Text = "-1.809411924"
		ElseIf cmbICAO1.Text = "WMKK" Then
			txtPort.Text = "Kuala Lumpur"
			txtLatRad1.Text = "0.054628805587"
			txtLongRad1.Text = "-1.772410944"
		ElseIf cmbICAO1.Text = "WSSL" Then
			txtPort.Text = "Singapore"
			txtLatRad1.Text = "0.024725497737"
			txtLongRad1.Text = "-1.812815316"
		ElseIf cmbICAO1.Text = "ZGGG" Then
			txtPort.Text = "Guangzhou"
			txtLatRad1.Text = "0.404625498254"
			txtLongRad1.Text = "-1.976847177"
		ElseIf cmbICAO1.Text = "Other" Then
			'Call OtherICAO1
		End If

		If cmbICAO1.Text <> "Other" Then
			Call CalcDist()
			txtLeg.Text = txtDist.Text
			txtLeg.Text = VB6.Format(txtLeg.Text, "Fixed")
			txtTotal.Text = txtDist.Text
			txtTotal.Text = VB6.Format(txtTotal.Text, "Fixed")
		Else
			Call OtherICAO1()
		End If

		If cmbICAO1.Text = "Other" Then
			cmbICAO1.Visible = False
			cmbICAO2.Visible = False
			txtICAO2.Text = txtICAO1.Text
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
			'cmbICAO1 = txtICAO1
		Else
			cmbICAO2.Text = cmbICAO1.Text
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		End If

		cmbICAO3.Focus()

	End Sub

	<Obsolete>
	Private Sub OtherICAO1()

		txtICAO1.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO")
		txtPort.Text = InputBox("Enter Name of Airport.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
		txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
		txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
		txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
		intLatDeg = CDbl(txtLatDeg.Text)
		intLatMin = CDbl(txtLatMin.Text)
		intLatSec = CDbl(txtLatSec.Text)
		intLatMin = intLatMin / 60
		intLatSec = intLatSec / 3600
		intLatRad = intLatDeg + intLatMin + intLatSec
		intLatRad = intLatRad / (180 / 3.141592654)
		If txtNS.Text = "S" Then
			intLatRad = intLatRad * -1
		ElseIf txtNS.Text = "s" Then
			intLatRad = intLatRad * -1
		End If
		txtLatRad1.Text = CStr(intLatRad)
		txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
		txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
		txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
		txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
		intLongDeg = CDbl(txtLongDeg.Text)
		intLongMin = CDbl(txtLongMin.Text)
		intLongSec = CDbl(txtLongSec.Text)
		intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
		If txtEW.Text = "E" Then
			intLongRad = intLongRad * -1
		ElseIf txtEW.Text = "e" Then
			intLongRad = intLongRad * -1
		End If
		txtLongRad1.Text = CStr(intLongRad / (180 / 3.141592654))
		'cmbICAO.Visible = False

		Call CalcDist()

		txtLeg.Text = txtDist.Text
		txtLeg.Text = VB6.Format(txtLeg.Text, "Fixed")
		txtTotal.Text = txtDist.Text
		txtTotal.Text = VB6.Format(txtTotal.Text, "Fixed")


		strICAO = txtICAO1.Text
		strPort = txtPort.Text
		strLatRad = txtLatRad1.Text
		strLongRad = txtLongRad1.Text
		FileOpen(1, "Bid ICAO.txt", OpenMode.Append)
		WriteLine(1, strICAO, strPort, strLatRad, strLongRad)
		FileClose(1)


		intLatDeg = 0
		intLatMin = 0
		intLatSec = 0
		intLatRad = 0
		intLongDeg = 0
		intLongMin = 0
		intLongSec = 0
		intLongRad = 0

	End Sub

	'UPGRADE_WARNING: Event cmbICAO2.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cmbICAO2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO2.SelectedIndexChanged

		If cmbICAO2.Text = "ASSY" Then
			'txtPort.Text = "Sidney"
			txtLatRad.Text = "-0.592248392843409"
			txtLongRad.Text = "-2.63835605259809"
		ElseIf cmbICAO2.Text = "AYPY" Then
			'txtPort.Text = "Port Moresby, PNG"
			txtLatRad.Text = "-0.164817259029998"
			txtLongRad.Text = "-2.56941554714432"
		ElseIf cmbICAO2.Text = "BGBW" Then
			'txtPort.Text = "Narsarsuaq"
			txtLatRad.Text = "1.0674724593406"
			txtLongRad.Text = "0.792873990360157"
		ElseIf cmbICAO2.Text = "BGGH" Then
			'txtPort.Text = "Godthab"
			txtLatRad.Text = "1.12035593567603"
			txtLongRad.Text = "0.902044335072403"
		ElseIf cmbICAO2.Text = "BIRK" Then
			'txtPort.Text = "Reykjavik"
			txtLatRad.Text = "1.1192505604831"
			txtLongRad.Text = "0.382983415529289"
		ElseIf cmbICAO2.Text = "CYAM" Then
			'txtPort.Text = "Sault Ste. Marie"
			txtLatRad.Text = "0.811316302789564"
			txtLongRad.Text = "1.47497775086041"
		ElseIf cmbICAO2.Text = "CYFB" Then
			'txtPort.Text = "Iqaluit"
			txtLatRad.Text = "1.11276375342985"
			txtLongRad.Text = "1.19653955752558"
		ElseIf cmbICAO2.Text = "CYQX" Then
			'txtPort.Text = "Gander"
			txtLatRad.Text = "0.854164135926025"
			txtLongRad.Text = "0.952426172813306"
		ElseIf cmbICAO2.Text = "CYYQ" Then
			'txtPort.Text = "Churchill Falls"
			txtLatRad.Text = "1.02520640262147"
			txtLongRad.Text = "1.64177304970933"
		ElseIf cmbICAO2.Text = "CYYR" Then
			'txtPort.Text = "Goose Bay"
			txtLatRad.Text = "0.930609557163376"
			txtLongRad.Text = "1.05464428933844"
		ElseIf cmbICAO2.Text = "CYYT" Then
			'txtPort.Text = "St John's, NFLD"
			txtLatRad.Text = "0.831096700978833"
			txtLongRad.Text = "0.920690269247875"
		ElseIf cmbICAO2.Text = "DAAG" Then
			'txtPort.Text = "Algiers, Algeria"
			txtLatRad.Text = "0.640419480198453"
			txtLongRad.Text = "-0.0561705130933508"
		ElseIf cmbICAO2.Text = "DIAP" Then
			'txtPort.Text = "Abidjan"
			txtLatRad.Text = "0.0916588745505689"
			txtLongRad.Text = "0.0685623507825106"
		ElseIf cmbICAO2.Text = "DNMM" Then
			'txtPort.Text = "Lagos, Nigeria"
			txtLatRad.Text = "0.114755398318627"
			txtLongRad.Text = "-0.0579158423453452"
		ElseIf cmbICAO2.Text = "DRRN" Then
			'txtPort.Text = "Niami, Niger"
			txtLatRad.Text = "0.235299471989702"
			txtLongRad.Text = "-0.0379318224100101"
		ElseIf cmbICAO2.Text = "EBBR" Then
			'txtPort.Text = "Brussels"
			txtLatRad.Text = "0.88840167808598"
			txtLongRad.Text = "-0.0785107275188782"
		ElseIf cmbICAO2.Text = "EDDW" Then
			'txtPort.Text = "Bremen, Germany"
			txtLatRad.Text = "0.925868079362125"
			txtLongRad.Text = "-0.153385352429435"
		ElseIf cmbICAO2.Text = "EFHK" Then
			'txtPort.Text = "Helsinki, Finland"
			txtLatRad.Text = "1.05272442716125"
			txtLongRad.Text = "-0.435750536581251"
		ElseIf cmbICAO2.Text = "EGPD" Then
			'txtPort.Text = "Aberdeen"
			txtLatRad.Text = "0.998415598603356"
			txtLongRad.Text = "0.0383681547230087"
		ElseIf cmbICAO2.Text = "EGPK" Then
			'txtPort.Text = "Prestwick"
			txtLatRad.Text = "0.968686823677719"
			txtLongRad.Text = "0.0798779020996071"
		ElseIf cmbICAO2.Text = "EHBK" Then
			'txtPort.Text = "Maastricht, Netherlands"
			txtLatRad.Text = "0.888663477473779"
			txtLongRad.Text = "-0.100821853123539"
		ElseIf cmbICAO2.Text = "EINN" Then
			'txtPort.Text = "Shannon"
			txtLatRad.Text = "0.919788515801012"
			txtLongRad.Text = "0.155741546919627"
		ElseIf cmbICAO2.Text = "EKCH" Then
			txtPort.Text = "Copenhagen"
			txtLatRad.Text = "0.97054850821318"
			txtLongRad.Text = "-0.220493262168617"
		ElseIf cmbICAO2.Text = "ELLX" Then
			'txtPort.Text = "Luxembourg"
			txtLatRad.Text = "0.86609055248132"
			txtLongRad.Text = "-0.108297680086248"
		ElseIf cmbICAO2.Text = "ENBR" Then
			'txtPort.Text = "Bergen, Norway"
			txtLatRad.Text = "1.05231718366911"
			txtLongRad.Text = "-0.091106186954104"
		ElseIf cmbICAO2.Text = "FAGM" Then
			'txtPort.Text = "Rand"
			txtLatRad.Text = "-0.458003484544179"
			txtLongRad.Text = "-0.49133927325727"
		ElseIf cmbICAO2.Text = "FALA" Then
			'txtPort.Text = "Lanseria, RSA"
			txtLatRad.Text = "-0.452622052683863"
			txtLongRad.Text = "-0.48735410479855"
		ElseIf cmbICAO2.Text = "FAWM" Then
			'txtPort.Text = "Windhoek"
			txtLatRad.Text = "-0.392379104669192"
			txtLongRad.Text = "-0.304967197965142"
		ElseIf cmbICAO2.Text = "FCBB" Then
			'txtPort.Text = "Brazzaville, Congo"
			txtLatRad.Text = "-0.0742928484932253"
			txtLongRad.Text = "-0.266162710929135"
		ElseIf cmbICAO2.Text = "FEFF" Then
			'txtPort.Text = "Bangui, CAE"
			txtLatRad.Text = "0.0767653982668839"
			txtLongRad.Text = "-0.323264066290216"
		ElseIf cmbICAO2.Text = "FMMI" Then
			'txtPort.Text = "Antananarivo, Madagascar"
			txtLatRad.Text = "-0.328063721733201"
			txtLongRad.Text = "-0.828624151205175"
		ElseIf cmbICAO2.Text = "FNLU" Then
			'txtPort.Text = "Luanda"
			txtLatRad.Text = "-0.154548905264098"
			txtLongRad.Text = "-0.231023415322316"
		ElseIf cmbICAO2.Text = "FOOL" Then
			'txtPort.Text = "Libreville"
			txtLatRad.Text = "-0.00799942573830734"
			txtLongRad.Text = "-0.164322749075266"
		ElseIf cmbICAO2.Text = "FSIA" Then
			'txtPort.Text = "Seychelles Intl"
			txtLatRad.Text = "-0.0815359648890018"
			txtLongRad.Text = "-0.969064978348985"
		ElseIf cmbICAO2.Text = "FVHA" Then
			'txtPort.Text = "Harare, Zimbabwe"
			txtLatRad.Text = "-0.31296662370345"
			txtLongRad.Text = "-0.54268104208677"
		ElseIf cmbICAO2.Text = "FZNA" Then
			'txtPort.Text = "Goma, Zaire"
			txtLatRad.Text = "-0.0290888208665722"
			txtLongRad.Text = "-0.510217917999676"
		ElseIf cmbICAO2.Text = "GBYD" Then
			'txtPort.Text = "Banjul"
			txtLatRad.Text = "0.23285601103691"
			txtLongRad.Text = "0.290742764561389"
		ElseIf cmbICAO2.Text = "GCXO" Then
			'txtPort.Text = "Tenerife"
			txtLatRad.Text = "0.497157037431"
			txtLongRad.Text = "0.2851867998"
		ElseIf cmbICAO2.Text = "GMAA" Then
			'txtPort.Text = "Agadir"
			txtLatRad.Text = "0.530260115577"
			txtLongRad.Text = "0.1667080324"
		ElseIf cmbICAO2.Text = "GOOY" Then
			'txtPort.Text = "Dakar"
			txtLatRad.Text = "0.257290620565"
			txtLongRad.Text = "0.3052580862"
		ElseIf cmbICAO2.Text = "HELX" Then
			'txtPort.Text = "Luxor"
			txtLatRad.Text = "0.447967841345"
			txtLongRad.Text = "-0.570722665"
		ElseIf cmbICAO2.Text = "HKNW" Then
			'txtPort.Text = "Nairobi-Wilson"
			txtLatRad.Text = "-0.02298016848"
			txtLongRad.Text = "-0.642572053"
		ElseIf cmbICAO2.Text = "HSSS" Then
			'txtPort.Text = "Khartoum"
			txtLatRad.Text = "0.272271363311"
			txtLongRad.Text = "-0.568250116"
		ElseIf cmbICAO2.Text = "HTDA" Then
			'txtPort.Text = "Dar-Es-Salaam"
			txtLatRad.Text = "-0.11999138607"
			txtLongRad.Text = "-0.684198156"
		ElseIf cmbICAO2.Text = "I69" Then
			'txtPort.Text = "Batavia, OH"
			txtLatRad.Text = "0.682045582859"
			txtLongRad.Text = "1.4697417631"
		ElseIf cmbICAO2.Text = "KANC" Then
			'txtPort.Text = "Anchorage"
			txtLatRad.Text = "1.067292108651"
			txtLongRad.Text = "2.6215601674"
		ElseIf cmbICAO2.Text = "KBGR" Then
			'txtPort.Text = "Bangor"
			txtLatRad.Text = "0.782052948998"
			txtLongRad.Text = "1.2012810353"
		ElseIf cmbICAO2.Text = "KBOI" Then
			'txtPort.Text = "Boise"
			txtLatRad.Text = "0.760352688631"
			txtLongRad.Text = "2.0285089231"
		ElseIf cmbICAO2.Text = "KCAE" Then
			'txtPort.Text = "Columbia, SC"
			txtLatRad.Text = "0.592364748127"
			txtLongRad.Text = "1.4158110892"
		ElseIf cmbICAO2.Text = "KEWK" Then
			'txtPort.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO2.Text = "KICT" Then
			'txtPort.Text = "Wichita, KS"
			txtLatRad.Text = "0.657116463376"
			txtLongRad.Text = "1.7005324679"
		ElseIf cmbICAO2.Text = "KIDP" Then
			'txtPort.Text = "Independence, KS"
			txtLatRad.Text = "0.648535261220"
			txtLongRad.Text = "1.6716472687"
		ElseIf cmbICAO2.Text = "KJNU" Then
			'txtPort.Text = "Juneau, AK"
			txtLatRad.Text = "1.018545062643"
			txtLongRad.Text = "2.3488738036"
		ElseIf cmbICAO2.Text = "KMIA" Then
			'txtPort.Text = "Miami, FL"
			txtLatRad.Text = "0.450178591731"
			txtLongRad.Text = "1.4013248564"
		ElseIf cmbICAO2.Text = "KMSP" Then
			'txtPort.Text = "Minneapolis, MN"
			txtLatRad.Text = "0.783391034758"
			txtLongRad.Text = "1.6269086622"
		ElseIf cmbICAO2.Text = "KNUD" Then
			'txtPort.Text = "ADAK, AK"
			txtLatRad.Text = "0.905348825123"
			txtLongRad.Text = "3.0835022783"
		ElseIf cmbICAO2.Text = "KOAK" Then
			'txtPort.Text = "Oakland, CA"
			txtLatRad.Text = "0.658454549136"
			txtLongRad.Text = "2.1331995894"
		ElseIf cmbICAO2.Text = "KPDK" Then
			'txtPort.Text = "Atlanta, GA"
			txtLatRad.Text = "0.590648507696"
			txtLongRad.Text = "1.4713416483"
		ElseIf cmbICAO2.Text = "KVRB" Then
			'txtPort.Text = "Vero Beach"
			txtLatRad.Text = "0.482670804639"
			txtLongRad.Text = "1.4035356068"
		ElseIf cmbICAO2.Text = "LCPH" Then
			'txtPort.Text = "Larnaca, Cyprus"
			txtLatRad.Text = "0.608741754275"
			txtLongRad.Text = "-0.586954227"
		ElseIf cmbICAO2.Text = "LEMD" Then
			'txtPort.Text = "Madrid"
			txtLatRad.Text = "0.706392925924"
			txtLongRad.Text = "-0.062133721"
		ElseIf cmbICAO2.Text = "LEMG" Then
			'txtPort.Text = "Malaga"
			txtLatRad.Text = "0.640099503169"
			txtLongRad.Text = "0.0784816387"
		ElseIf cmbICAO2.Text = "LFPN" Then
			'txtPort.Text = "Toussus Le Noble"
			txtLatRad.Text = "0.850877099168"
			txtLongRad.Text = "-0.036739181"
		ElseIf cmbICAO2.Text = "LGAT" Then
			'txtPort.Text = "Athens"
			txtLatRad.Text = "0.661247075939"
			txtLongRad.Text = "-0.414166631"
		ElseIf cmbICAO2.Text = "LGIR" Then
			'txtPort.Text = "Iraklion"
			txtLatRad.Text = "0.616770268834"
			txtLongRad.Text = "-0.439444817"
		ElseIf cmbICAO2.Text = "LIRA" Then
			'txtPort.Text = "Rome"
			txtLatRad.Text = "0.729518538513"
			txtLongRad.Text = "-0.219824219"
		ElseIf cmbICAO2.Text = "LKPR" Then
			'txtPort.Text = "Prague, Czech"
			txtLatRad.Text = "0.874439044070"
			txtLongRad.Text = "-0.248913040"
		ElseIf cmbICAO2.Text = "LPAZ" Then
			'txtPort.Text = "Santa Maria"
			txtLatRad.Text = "0.645306402104"
			txtLongRad.Text = "0.4393284615"
		ElseIf cmbICAO2.Text = "LPPR" Then
			'txtPort.Text = "Porto, Portugal"
			txtLatRad.Text = "0.719657428239"
			txtLongRad.Text = "0.1514364014"
		ElseIf cmbICAO2.Text = "LROP" Then
			'txtPort.Text = "Bucharest, Romania"
			txtLatRad.Text = "0.777893247614"
			txtLongRad.Text = "-0.455298224"
		ElseIf cmbICAO2.Text = "LTAC" Then
			'txtPort.Text = "Ankara"
			txtLatRad.Text = "0.700313362363"
			txtLongRad.Text = "-0.575842298"
		ElseIf cmbICAO2.Text = "LTBA" Then
			'txtPort.Text = "Istanbul, Turkey"
			txtLatRad.Text = "0.715177749826"
			txtLongRad.Text = "-0.502945713"
		ElseIf cmbICAO2.Text = "MROC" Then
			'txtPort.Text = "San Jose, CR"
			txtLatRad.Text = "0.174416569916"
			txtLongRad.Text = "1.4697708519"
		ElseIf cmbICAO2.Text = "NTSU" Then
			'txtPort.Text = "Pago Pago"
			txtLatRad.Text = "0.250192948273"
			txtLongRad.Text = "2.9794515661"
		ElseIf cmbICAO2.Text = "NZAA" Then
			'txtPort.Text = "Auckland"
			txtLatRad.Text = "-0.64588817852"
			txtLongRad.Text = "-3.050690088"
		ElseIf cmbICAO2.Text = "OOMS" Then
			'txtPort.Text = "SEEB, Oman"
			txtLatRad.Text = "0.411781348187"
			txtLongRad.Text = "-1.017148799"
		ElseIf cmbICAO2.Text = "OPKC" Then
			'txtPort.Text = "Karachi"
			txtLatRad.Text = "0.434703339030"
			txtLongRad.Text = "-1.172104948"
		ElseIf cmbICAO2.Text = "PAOM" Then
			'txtPort.Text = "Nome, AK"
			txtLatRad.Text = "1.125970078103"
			txtLongRad.Text = "2.8875308921"
		ElseIf cmbICAO2.Text = "PGSN" Then
			'txtPort.Text = "Saipan"
			txtLatRad.Text = "0.263922871722"
			txtLongRad.Text = "-2.543526497"
		ElseIf cmbICAO2.Text = "PHNL" Then
			'txtPort.Text = "Honolulu, HI"
			txtLatRad.Text = "0.372075107704"
			txtLongRad.Text = "2.7562821324"
		ElseIf cmbICAO2.Text = "PHTO" Then
			'txtPort.Text = "HILO"
			txtLatRad.Text = "0.344237106135"
			txtLongRad.Text = "2.7061620940"
		ElseIf cmbICAO2.Text = "PKMJ" Then
			'txtPort.Text = "Majuro"
			txtLatRad.Text = "0.123249334012"
			txtLongRad.Text = "-2.989312676"
		ElseIf cmbICAO2.Text = "PLCH" Then
			'txtPort.Text = "Christmas Island"
			txtLatRad.Text = "0.034702963294"
			txtLongRad.Text = "2.7463628445"
		ElseIf cmbICAO2.Text = "PMDY" Then
			'txtPort.Text = "Midway"
			txtLatRad.Text = "0.492386470808"
			txtLongRad.Text = "3.0958650272"
		ElseIf cmbICAO2.Text = "PTRO" Then
			'txtPort.Text = "Palau"
			txtLatRad.Text = "0.128543499409"
			txtLongRad.Text = "-2.348369597"
		ElseIf cmbICAO2.Text = "PWAK" Then
			'txtPort.Text = "WAKE"
			txtLatRad.Text = "0.336499479785"
			txtLongRad.Text = "-2.908445754"
		ElseIf cmbICAO2.Text = "RCTP" Then
			'txtPort.Text = "Chiang Kai Shek"
			txtLatRad.Text = "0.437699487579"
			txtLongRad.Text = "-2.115717208"
		ElseIf cmbICAO2.Text = "RJCK" Then
			'txtPort.Text = "Kushiro"
			txtLatRad.Text = "0.751218798879"
			txtLongRad.Text = "-2.516677515"
		ElseIf cmbICAO2.Text = "RJTT" Then
			'txtPort.Text = "Tokyo"
			txtLatRad.Text = "0.620580904367"
			txtLongRad.Text = "-2.437643189"
		ElseIf cmbICAO2.Text = "RKSS" Then
			'txtPort.Text = "Seoul, Korea"
			txtLatRad.Text = "0.655429311766"
			txtLongRad.Text = "-2.213077492"
		ElseIf cmbICAO2.Text = "RPMM" Then
			'txtPort.Text = "Manilla"
			txtLatRad.Text = "0.253218185644"
			txtLongRad.Text = "-2.112197461"
		ElseIf cmbICAO2.Text = "SAEZ" Then
			'txtPort.Text = "Ezeiza"
			txtLatRad.Text = "-0.60772364554"
			txtLongRad.Text = "1.0215993888"
		ElseIf cmbICAO2.Text = "SBEG" Then
			'txtPort.Text = "Manaus"
			txtLatRad.Text = "-0.05305800926"
			txtLongRad.Text = "1.0480120382"
		ElseIf cmbICAO2.Text = "SBGL" Then
			'txtPort.Text = "Rio De Janeiro, Brazil"
			txtLatRad.Text = "-0.39810960238"
			txtLongRad.Text = "0.7548549015"
		ElseIf cmbICAO2.Text = "SBSP" Then
			'txtPort.Text = "Sao Paulo"
			txtLatRad.Text = "-0.41233403578"
			txtLongRad.Text = "0.8143124513"
		ElseIf cmbICAO2.Text = "SCEL" Then
			'txtPort.Text = "Santiago, Chile"
			txtLatRad.Text = "-0.58279452606"
			txtLongRad.Text = "1.2354022222"
		ElseIf cmbICAO2.Text = "SVMG" Then
			'txtPort.Text = "Margarita, VE"
			txtLatRad.Text = "0.190531776676"
			txtLongRad.Text = "1.1163998560"
		ElseIf cmbICAO2.Text = "TTPP" Then
			'txtPort.Text = "Picaro"
			txtLatRad.Text = "0.184888545428"
			txtLongRad.Text = "1.0705558744"
		ElseIf cmbICAO2.Text = "UHHH" Then
			'txtPort.Text = "Khabarovsk, Russia"
			txtLatRad.Text = "0.846950108351"
			txtLongRad.Text = "-2.359452438"
		ElseIf cmbICAO2.Text = "UHMM" Then
			'txtPort.Text = "Magadan, Russia"
			txtLatRad.Text = "1.045743110153"
			txtLongRad.Text = "-2.630502071"
		ElseIf cmbICAO2.Text = "UHPP" Then
			'txtPort.Text = "Petropavlovsk, Russia"
			txtLatRad.Text = "0.927933385644"
			txtLongRad.Text = "-2.7654742"
		ElseIf cmbICAO2.Text = "UHSS" Then
			'txtPort.Text = "Yuzhno, Russia"
			txtLatRad.Text = "0.700720605855"
			txtLongRad.Text = "-2.490730287"
		ElseIf cmbICAO2.Text = "UTTT" Then
			'txtPort.Text = "Tashkent, Russia"
			txtLatRad.Text = "0.719948316448"
			txtLongRad.Text = "-1.209222283"
		ElseIf cmbICAO2.Text = "UUEE" Then
			'txtPort.Text = "Moscow, Russia"
			txtLatRad.Text = "0.976889871162"
			txtLongRad.Text = "-0.65301494"
		ElseIf cmbICAO2.Text = "VABB" Then
			'txtPort.Text = "Bombay"
			txtLatRad.Text = "0.333212443027"
			txtLongRad.Text = "-1.271763248"
		ElseIf cmbICAO2.Text = "VCBI" Then
			'txtPort.Text = "Columbo, Sri Lanka"
			txtLatRad.Text = "0.125314640293"
			txtLongRad.Text = "-1.394227184"
		ElseIf cmbICAO2.Text = "VIDP" Then
			'txtPort.Text = "Delhi"
			txtLatRad.Text = "0.498582389653"
			txtLongRad.Text = "-1.345648853"
		ElseIf cmbICAO2.Text = "VNKT" Then
			'txtPort.Text = "Katmandu, Nepal"
			txtLatRad.Text = "0.485230620875"
			txtLongRad.Text = "-1.489842138"
		ElseIf cmbICAO2.Text = "VOMM" Then
			'txtPort.Text = "Madras"
			txtLatRad.Text = "0.226805536297"
			txtLongRad.Text = "-1.399346817"
		ElseIf cmbICAO2.Text = "VOPB" Then
			'txtPort.Text = "Port Blair, Nicobar"
			txtLatRad.Text = "0.203272680216"
			txtLongRad.Text = "-1.618531082"
		ElseIf cmbICAO2.Text = "VRMM" Then
			'txtPort.Text = "Male, Maldives"
			txtLatRad.Text = "0.073158384479"
			txtLongRad.Text = "-1.283398777"
		ElseIf cmbICAO2.Text = "VTBD" Then
			'txtPort.Text = "Bangkok"
			txtLatRad.Text = "0.242891654236"
			txtLongRad.Text = "-1.755888494"
		ElseIf cmbICAO2.Text = "WMKJ" Then
			'txtPort.Text = "Johor Bahru, Malaysia"
			txtLatRad.Text = "0.028594310912"
			txtLongRad.Text = "-1.809411924"
		ElseIf cmbICAO2.Text = "WMKK" Then
			'txtPort.Text = "Kuala Lumpur"
			txtLatRad.Text = "0.054628805587"
			txtLongRad.Text = "-1.772410944"
		ElseIf cmbICAO2.Text = "WSSL" Then
			'txtPort.Text = "Singapore"
			txtLatRad.Text = "0.024725497737"
			txtLongRad.Text = "-1.812815316"
		ElseIf cmbICAO2.Text = "ZGGG" Then
			'txtPort.Text = "Guangzhou"
			txtLatRad.Text = "0.404625498254"
			txtLongRad.Text = "-1.976847177"
		ElseIf cmbICAO2.Text = "Other" Then
			txtICAO2.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO")
			txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
			txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
			txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
			txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
			intLatDeg = CDbl(txtLatDeg.Text)
			intLatMin = CDbl(txtLatMin.Text)
			intLatSec = CDbl(txtLatSec.Text)
			intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
			If txtNS.Text = "S" Then
				intLatRad = intLatRad * -1
			ElseIf txtNS.Text = "s" Then
				intLatRad = intLatRad * -1
			End If
			txtLatRad.Text = CStr(intLatRad / (180 / 3.141592654))
			txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
			txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
			txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
			txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
			intLongDeg = CDbl(txtLongDeg.Text)
			intLongMin = CDbl(txtLongMin.Text)
			intLongSec = CDbl(txtLongSec.Text)
			intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
			If txtEW.Text = "E" Then
				intLongRad = intLongRad * -1
			ElseIf txtEW.Text = "e" Then
				intLongRad = intLongRad * -1
			End If
			txtLongRad.Text = CStr(intLongRad / (180 / 3.141592654))
			cmbICAO2.Visible = False
			cmbICAO3.Focus()
		End If

	End Sub


	'UPGRADE_WARNING: Event cmbICAO3.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	<Obsolete>
	Private Sub cmbICAO3_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO3.SelectedIndexChanged

		If cmbICAO4.Text <> "" Then
			cmbICAO4.Text = ""
			cmbICAO5.Text = ""
			cmbICAO6.Text = ""
			cmbICAO7.Text = ""
			cmbICAO8.Text = ""
			cmbICAO9.Text = ""
			cmbICAO10.Text = ""
			cmbICAO11.Text = ""
			cmbICAO12.Text = ""
			cmbICAO13.Text = ""
			cmbICAO14.Text = ""
			cmbICAO15.Text = ""
			txtPort2.Text = ""
			txtPort3.Text = ""
			txtPort4.Text = ""
			txtPort5.Text = ""
			txtPort6.Text = ""
			txtPort7.Text = ""
			txtLeg2.Text = ""
			txtLeg3.Text = ""
			txtLeg4.Text = ""
			txtLeg5.Text = ""
			txtLeg6.Text = ""
			txtLeg7.Text = ""
			txtTotal2.Text = ""
			txtTotal3.Text = ""
			txtTotal4.Text = ""
			txtTotal5.Text = ""
			txtTotal6.Text = ""
			txtTotal7.Text = ""

			Call cmbICAO2_SelectedIndexChanged(cmbICAO2, New System.EventArgs())

		End If

		If cmbICAO3.Text = cmbICAO2.Text Then
			Call MsgBox("Please re-enter destination, not equal to origination.", MsgBoxStyle.OKOnly, "Re-enter Destination")
			cmbICAO3.Text = ""
			cmbICAO3.Focus()
			Exit Sub
		ElseIf cmbICAO3.Text = "ASSY" Then
			txtPort1.Text = "Sidney"
			txtLatRad1.Text = "-0.592248392843409"
			txtLongRad1.Text = "-2.63835605259809"
		ElseIf cmbICAO3.Text = "AYPY" Then
			txtPort1.Text = "Port Moresby, PNG"
			txtLatRad1.Text = "-0.164817259029998"
			txtLongRad1.Text = "-2.56941554714432"
		ElseIf cmbICAO3.Text = "BGBW" Then
			txtPort1.Text = "Narsarsuaq"
			txtLatRad1.Text = "1.0674724593406"
			txtLongRad1.Text = "0.792873990360157"
		ElseIf cmbICAO3.Text = "BGGH" Then
			txtPort1.Text = "Godthab"
			txtLatRad1.Text = "1.12035593567603"
			txtLongRad1.Text = "0.902044335072403"
		ElseIf cmbICAO3.Text = "BIRK" Then
			txtPort1.Text = "Reykjavik"
			txtLatRad1.Text = "1.1192505604831"
			txtLongRad1.Text = "0.382983415529289"
		ElseIf cmbICAO3.Text = "CYAM" Then
			txtPort1.Text = "Sault Ste. Marie"
			txtLatRad1.Text = "0.811316302789564"
			txtLongRad1.Text = "1.47497775086041"
		ElseIf cmbICAO3.Text = "CYFB" Then
			txtPort1.Text = "Iqaluit"
			txtLatRad1.Text = "1.11276375342985"
			txtLongRad1.Text = "1.19653955752558"
		ElseIf cmbICAO3.Text = "CYQX" Then
			txtPort1.Text = "Gander"
			txtLatRad1.Text = "0.854164135926025"
			txtLongRad1.Text = "0.952426172813306"
		ElseIf cmbICAO3.Text = "CYYQ" Then
			txtPort1.Text = "Churchill Falls"
			txtLatRad1.Text = "1.02520640262147"
			txtLongRad1.Text = "1.64177304970933"
		ElseIf cmbICAO3.Text = "CYYR" Then
			txtPort1.Text = "Goose Bay"
			txtLatRad1.Text = "0.930609557163376"
			txtLongRad1.Text = "1.05464428933844"
		ElseIf cmbICAO3.Text = "CYYT" Then
			txtPort1.Text = "St John's, NFLD"
			txtLatRad1.Text = "0.831096700978833"
			txtLongRad1.Text = "0.920690269247875"
		ElseIf cmbICAO3.Text = "DAAG" Then
			txtPort1.Text = "Algiers, Algeria"
			txtLatRad1.Text = "0.640419480198453"
			txtLongRad1.Text = "-0.0561705130933508"
		ElseIf cmbICAO3.Text = "DIAP" Then
			txtPort1.Text = "Abidjan"
			txtLatRad1.Text = "0.0916588745505689"
			txtLongRad1.Text = "0.0685623507825106"
		ElseIf cmbICAO3.Text = "DNMM" Then
			txtPort1.Text = "Lagos, Nigeria"
			txtLatRad1.Text = "0.114755398318627"
			txtLongRad1.Text = "-0.0579158423453452"
		ElseIf cmbICAO3.Text = "DRRN" Then
			txtPort1.Text = "Niami, Niger"
			txtLatRad1.Text = "0.235299471989702"
			txtLongRad1.Text = "-0.0379318224100101"
		ElseIf cmbICAO3.Text = "EBBR" Then
			txtPort1.Text = "Brussels"
			txtLatRad1.Text = "0.88840167808598"
			txtLongRad1.Text = "-0.0785107275188782"
		ElseIf cmbICAO3.Text = "EDDW" Then
			txtPort1.Text = "Bremen, Germany"
			txtLatRad1.Text = "0.925868079362125"
			txtLongRad1.Text = "-0.153385352429435"
		ElseIf cmbICAO3.Text = "EFHK" Then
			txtPort1.Text = "Helsinki, Finland"
			txtLatRad1.Text = "1.05272442716125"
			txtLongRad1.Text = "-0.435750536581251"
		ElseIf cmbICAO3.Text = "EGPD" Then
			txtPort1.Text = "Aberdeen"
			txtLatRad1.Text = "0.998415598603356"
			txtLongRad1.Text = "0.0383681547230087"
		ElseIf cmbICAO3.Text = "EGPK" Then
			txtPort1.Text = "Prestwick"
			txtLatRad1.Text = "0.968686823677719"
			txtLongRad1.Text = "0.0798779020996071"
		ElseIf cmbICAO3.Text = "EHBK" Then
			txtPort1.Text = "Maastricht, Netherlands"
			txtLatRad1.Text = "0.888663477473779"
			txtLongRad1.Text = "-0.100821853123539"
		ElseIf cmbICAO3.Text = "EINN" Then
			txtPort1.Text = "Shannon"
			txtLatRad1.Text = "0.919788515801012"
			txtLongRad1.Text = "0.155741546919627"
		ElseIf cmbICAO3.Text = "EKCH" Then
			txtPort1.Text = "Copenhagen"
			txtLatRad1.Text = "0.97054850821318"
			txtLongRad1.Text = "-0.220493262168617"
		ElseIf cmbICAO3.Text = "ELLX" Then
			txtPort1.Text = "Luxembourg"
			txtLatRad1.Text = "0.86609055248132"
			txtLongRad1.Text = "-0.108297680086248"
		ElseIf cmbICAO3.Text = "ENBR" Then
			txtPort1.Text = "Bergen, Norway"
			txtLatRad1.Text = "1.05231718366911"
			txtLongRad1.Text = "-0.091106186954104"
		ElseIf cmbICAO3.Text = "FAGM" Then
			txtPort1.Text = "Rand"
			txtLatRad1.Text = "-0.458003484544179"
			txtLongRad1.Text = "-0.49133927325727"
		ElseIf cmbICAO3.Text = "FALA" Then
			txtPort1.Text = "Lanseria, RSA"
			txtLatRad1.Text = "-0.452622052683863"
			txtLongRad1.Text = "-0.48735410479855"
		ElseIf cmbICAO3.Text = "FAWM" Then
			txtPort1.Text = "Windhoek"
			txtLatRad1.Text = "-0.392379104669192"
			txtLongRad1.Text = "-0.304967197965142"
		ElseIf cmbICAO3.Text = "FCBB" Then
			txtPort1.Text = "Brazzaville, Congo"
			txtLatRad1.Text = "-0.0742928484932253"
			txtLongRad1.Text = "-0.266162710929135"
		ElseIf cmbICAO3.Text = "FEFF" Then
			txtPort1.Text = "Bangui, CAE"
			txtLatRad1.Text = "0.0767653982668839"
			txtLongRad1.Text = "-0.323264066290216"
		ElseIf cmbICAO3.Text = "FMMI" Then
			txtPort1.Text = "Antananarivo, Madagascar"
			txtLatRad1.Text = "-0.328063721733201"
			txtLongRad1.Text = "-0.828624151205175"
		ElseIf cmbICAO3.Text = "FNLU" Then
			txtPort1.Text = "Luanda"
			txtLatRad1.Text = "-0.154548905264098"
			txtLongRad1.Text = "-0.231023415322316"
		ElseIf cmbICAO3.Text = "FOOL" Then
			txtPort1.Text = "Libreville"
			txtLatRad1.Text = "-0.00799942573830734"
			txtLongRad1.Text = "-0.164322749075266"
		ElseIf cmbICAO3.Text = "FSIA" Then
			txtPort1.Text = "Seychelles Intl"
			txtLatRad1.Text = "-0.0815359648890018"
			txtLongRad1.Text = "-0.969064978348985"
		ElseIf cmbICAO3.Text = "FVHA" Then
			txtPort1.Text = "Harare, Zimbabwe"
			txtLatRad1.Text = "-0.31296662370345"
			txtLongRad1.Text = "-0.54268104208677"
		ElseIf cmbICAO3.Text = "FZNA" Then
			txtPort1.Text = "Goma, Zaire"
			txtLatRad1.Text = "-0.0290888208665722"
			txtLongRad1.Text = "-0.510217917999676"
		ElseIf cmbICAO3.Text = "GBYD" Then
			txtPort1.Text = "Banjul"
			txtLatRad1.Text = "0.23285601103691"
			txtLongRad1.Text = "0.290742764561389"
		ElseIf cmbICAO3.Text = "GCXO" Then
			txtPort1.Text = "Tenerife"
			txtLatRad1.Text = "0.497157037431"
			txtLongRad1.Text = "0.2851867998"
		ElseIf cmbICAO3.Text = "GMAA" Then
			txtPort1.Text = "Agadir"
			txtLatRad1.Text = "0.530260115577"
			txtLongRad1.Text = "0.1667080324"
		ElseIf cmbICAO3.Text = "GOOY" Then
			txtPort1.Text = "Dakar"
			txtLatRad1.Text = "0.257290620565"
			txtLongRad1.Text = "0.3052580862"
		ElseIf cmbICAO3.Text = "HELX" Then
			txtPort1.Text = "Luxor"
			txtLatRad1.Text = "0.447967841345"
			txtLongRad1.Text = "-0.570722665"
		ElseIf cmbICAO3.Text = "HKNW" Then
			txtPort1.Text = "Nairobi-Wilson"
			txtLatRad1.Text = "-0.02298016848"
			txtLongRad1.Text = "-0.642572053"
		ElseIf cmbICAO3.Text = "HSSS" Then
			txtPort1.Text = "Khartoum"
			txtLatRad1.Text = "0.272271363311"
			txtLongRad1.Text = "-0.568250116"
		ElseIf cmbICAO3.Text = "HTDA" Then
			txtPort1.Text = "Dar-Es-Salaam"
			txtLatRad1.Text = "-0.11999138607"
			txtLongRad1.Text = "-0.684198156"
		ElseIf cmbICAO3.Text = "I69" Then
			txtPort1.Text = "Batavia, OH"
			txtLatRad1.Text = "0.682045582859"
			txtLongRad1.Text = "1.4697417631"
		ElseIf cmbICAO3.Text = "KANC" Then
			txtPort1.Text = "Anchorage"
			txtLatRad1.Text = "1.067292108651"
			txtLongRad1.Text = "2.6215601674"
		ElseIf cmbICAO3.Text = "KBGR" Then
			txtPort1.Text = "Bangor"
			txtLatRad1.Text = "0.782052948998"
			txtLongRad1.Text = "1.2012810353"
		ElseIf cmbICAO3.Text = "KBOI" Then
			txtPort1.Text = "Boise"
			txtLatRad1.Text = "0.760352688631"
			txtLongRad1.Text = "2.0285089231"
		ElseIf cmbICAO3.Text = "KCAE" Then
			txtPort1.Text = "Columbia, SC"
			txtLatRad1.Text = "0.592364748127"
			txtLongRad1.Text = "1.4158110892"
		ElseIf cmbICAO3.Text = "KEWK" Then
			txtPort1.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO3.Text = "KICT" Then
			txtPort1.Text = "Wichita, KS"
			txtLatRad1.Text = "0.657116463376"
			txtLongRad1.Text = "1.7005324679"
		ElseIf cmbICAO3.Text = "KIDP" Then
			txtPort1.Text = "Independence, KS"
			txtLatRad1.Text = "0.648535261220"
			txtLongRad1.Text = "1.6716472687"
		ElseIf cmbICAO3.Text = "KJNU" Then
			txtPort1.Text = "Juneau, AK"
			txtLatRad1.Text = "1.018545062643"
			txtLongRad1.Text = "2.3488738036"
		ElseIf cmbICAO3.Text = "KMIA" Then
			txtPort1.Text = "Miami, FL"
			txtLatRad1.Text = "0.450178591731"
			txtLongRad1.Text = "1.4013248564"
		ElseIf cmbICAO3.Text = "KMSP" Then
			txtPort1.Text = "Minneapolis, MN"
			txtLatRad1.Text = "0.783391034758"
			txtLongRad1.Text = "1.6269086622"
		ElseIf cmbICAO3.Text = "KNUD" Then
			txtPort1.Text = "ADAK, AK"
			txtLatRad1.Text = "0.905348825123"
			txtLongRad1.Text = "3.0835022783"
		ElseIf cmbICAO3.Text = "KOAK" Then
			txtPort1.Text = "Oakland, CA"
			txtLatRad1.Text = "0.658454549136"
			txtLongRad1.Text = "2.1331995894"
		ElseIf cmbICAO3.Text = "KPDK" Then
			txtPort1.Text = "Atlanta, GA"
			txtLatRad1.Text = "0.590648507696"
			txtLongRad1.Text = "1.4713416483"
		ElseIf cmbICAO3.Text = "KVRB" Then
			txtPort1.Text = "Vero Beach"
			txtLatRad1.Text = "0.482670804639"
			txtLongRad1.Text = "1.4035356068"
		ElseIf cmbICAO3.Text = "LCPH" Then
			txtPort1.Text = "Larnaca, Cyprus"
			txtLatRad1.Text = "0.608741754275"
			txtLongRad1.Text = "-0.586954227"
		ElseIf cmbICAO3.Text = "LEMD" Then
			txtPort1.Text = "Madrid"
			txtLatRad1.Text = "0.706392925924"
			txtLongRad1.Text = "-0.062133721"
		ElseIf cmbICAO3.Text = "LEMG" Then
			txtPort1.Text = "Malaga"
			txtLatRad1.Text = "0.640099503169"
			txtLongRad1.Text = "0.0784816387"
		ElseIf cmbICAO3.Text = "LFPN" Then
			txtPort1.Text = "Toussus Le Noble"
			txtLatRad1.Text = "0.850877099168"
			txtLongRad1.Text = "-0.036739181"
		ElseIf cmbICAO3.Text = "LGAT" Then
			txtPort1.Text = "Athens"
			txtLatRad1.Text = "0.661247075939"
			txtLongRad1.Text = "-0.414166631"
		ElseIf cmbICAO3.Text = "LGIR" Then
			txtPort1.Text = "Iraklion"
			txtLatRad1.Text = "0.616770268834"
			txtLongRad1.Text = "-0.439444817"
		ElseIf cmbICAO3.Text = "LIRA" Then
			txtPort1.Text = "Rome"
			txtLatRad1.Text = "0.729518538513"
			txtLongRad1.Text = "-0.219824219"
		ElseIf cmbICAO3.Text = "LKPR" Then
			txtPort1.Text = "Prague, Czech"
			txtLatRad1.Text = "0.874439044070"
			txtLongRad1.Text = "-0.248913040"
		ElseIf cmbICAO3.Text = "LPAZ" Then
			txtPort1.Text = "Santa Maria"
			txtLatRad1.Text = "0.645306402104"
			txtLongRad1.Text = "0.4393284615"
		ElseIf cmbICAO3.Text = "LPPR" Then
			txtPort1.Text = "Porto, Portugal"
			txtLatRad1.Text = "0.719657428239"
			txtLongRad1.Text = "0.1514364014"
		ElseIf cmbICAO3.Text = "LROP" Then
			txtPort1.Text = "Bucharest, Romania"
			txtLatRad1.Text = "0.777893247614"
			txtLongRad1.Text = "-0.455298224"
		ElseIf cmbICAO3.Text = "LTAC" Then
			txtPort1.Text = "Ankara"
			txtLatRad1.Text = "0.700313362363"
			txtLongRad1.Text = "-0.575842298"
		ElseIf cmbICAO3.Text = "LTBA" Then
			txtPort1.Text = "Istanbul, Turkey"
			txtLatRad1.Text = "0.715177749826"
			txtLongRad1.Text = "-0.502945713"
		ElseIf cmbICAO3.Text = "MROC" Then
			txtPort1.Text = "San Jose, CR"
			txtLatRad1.Text = "0.174416569916"
			txtLongRad1.Text = "1.4697708519"
		ElseIf cmbICAO3.Text = "NTSU" Then
			txtPort1.Text = "Pago Pago"
			txtLatRad1.Text = "0.250192948273"
			txtLongRad1.Text = "2.9794515661"
		ElseIf cmbICAO3.Text = "NZAA" Then
			txtPort1.Text = "Auckland"
			txtLatRad1.Text = "-0.64588817852"
			txtLongRad1.Text = "-3.050690088"
		ElseIf cmbICAO3.Text = "OOMS" Then
			txtPort1.Text = "SEEB, Oman"
			txtLatRad1.Text = "0.411781348187"
			txtLongRad1.Text = "-1.017148799"
		ElseIf cmbICAO3.Text = "OPKC" Then
			txtPort1.Text = "Karachi"
			txtLatRad1.Text = "0.434703339030"
			txtLongRad1.Text = "-1.172104948"
		ElseIf cmbICAO3.Text = "PAOM" Then
			txtPort1.Text = "Nome, AK"
			txtLatRad1.Text = "1.125970078103"
			txtLongRad1.Text = "2.8875308921"
		ElseIf cmbICAO3.Text = "PGSN" Then
			txtPort1.Text = "Saipan"
			txtLatRad1.Text = "0.263922871722"
			txtLongRad1.Text = "-2.543526497"
		ElseIf cmbICAO3.Text = "PHNL" Then
			txtPort1.Text = "Honolulu, HI"
			txtLatRad1.Text = "0.372075107704"
			txtLongRad1.Text = "2.7562821324"
		ElseIf cmbICAO3.Text = "PHTO" Then
			txtPort1.Text = "HILO"
			txtLatRad1.Text = "0.344237106135"
			txtLongRad1.Text = "2.7061620940"
		ElseIf cmbICAO3.Text = "PKMJ" Then
			txtPort1.Text = "Majuro"
			txtLatRad1.Text = "0.123249334012"
			txtLongRad1.Text = "-2.989312676"
		ElseIf cmbICAO3.Text = "PLCH" Then
			txtPort1.Text = "Christmas Island"
			txtLatRad1.Text = "0.034702963294"
			txtLongRad1.Text = "2.7463628445"
		ElseIf cmbICAO3.Text = "PMDY" Then
			txtPort1.Text = "Midway"
			txtLatRad1.Text = "0.492386470808"
			txtLongRad1.Text = "3.0958650272"
		ElseIf cmbICAO3.Text = "PTRO" Then
			txtPort1.Text = "Palau"
			txtLatRad1.Text = "0.128543499409"
			txtLongRad1.Text = "-2.348369597"
		ElseIf cmbICAO3.Text = "PWAK" Then
			txtPort1.Text = "WAKE"
			txtLatRad1.Text = "0.336499479785"
			txtLongRad1.Text = "-2.908445754"
		ElseIf cmbICAO3.Text = "RCTP" Then
			txtPort1.Text = "Chiang Kai Shek"
			txtLatRad1.Text = "0.437699487579"
			txtLongRad1.Text = "-2.115717208"
		ElseIf cmbICAO3.Text = "RJCK" Then
			txtPort1.Text = "Kushiro"
			txtLatRad1.Text = "0.751218798879"
			txtLongRad1.Text = "-2.516677515"
		ElseIf cmbICAO3.Text = "RJTT" Then
			txtPort1.Text = "Tokyo"
			txtLatRad1.Text = "0.620580904367"
			txtLongRad1.Text = "-2.437643189"
		ElseIf cmbICAO3.Text = "RKSS" Then
			txtPort1.Text = "Seoul, Korea"
			txtLatRad1.Text = "0.655429311766"
			txtLongRad1.Text = "-2.213077492"
		ElseIf cmbICAO3.Text = "RPMM" Then
			txtPort1.Text = "Manilla"
			txtLatRad1.Text = "0.253218185644"
			txtLongRad1.Text = "-2.112197461"
		ElseIf cmbICAO3.Text = "SAEZ" Then
			txtPort1.Text = "Ezeiza"
			txtLatRad1.Text = "-0.60772364554"
			txtLongRad1.Text = "1.0215993888"
		ElseIf cmbICAO3.Text = "SBEG" Then
			txtPort1.Text = "Manaus"
			txtLatRad1.Text = "-0.05305800926"
			txtLongRad1.Text = "1.0480120382"
		ElseIf cmbICAO3.Text = "SBGL" Then
			txtPort1.Text = "Rio De Janeiro, Brazil"
			txtLatRad1.Text = "-0.39810960238"
			txtLongRad1.Text = "0.7548549015"
		ElseIf cmbICAO3.Text = "SBSP" Then
			txtPort1.Text = "Sao Paulo"
			txtLatRad1.Text = "-0.41233403578"
			txtLongRad1.Text = "0.8143124513"
		ElseIf cmbICAO3.Text = "SCEL" Then
			txtPort1.Text = "Santiago, Chile"
			txtLatRad1.Text = "-0.58279452606"
			txtLongRad1.Text = "1.2354022222"
		ElseIf cmbICAO3.Text = "SVMG" Then
			txtPort1.Text = "Margarita, VE"
			txtLatRad1.Text = "0.190531776676"
			txtLongRad1.Text = "1.1163998560"
		ElseIf cmbICAO3.Text = "TTPP" Then
			txtPort1.Text = "Picaro"
			txtLatRad1.Text = "0.184888545428"
			txtLongRad1.Text = "1.0705558744"
		ElseIf cmbICAO3.Text = "UHHH" Then
			txtPort1.Text = "Khabarovsk, Russia"
			txtLatRad1.Text = "0.846950108351"
			txtLongRad1.Text = "-2.359452438"
		ElseIf cmbICAO3.Text = "UHMM" Then
			txtPort1.Text = "Magadan, Russia"
			txtLatRad1.Text = "1.045743110153"
			txtLongRad1.Text = "-2.630502071"
		ElseIf cmbICAO3.Text = "UHPP" Then
			txtPort1.Text = "Petropavlovsk, Russia"
			txtLatRad1.Text = "0.927933385644"
			txtLongRad1.Text = "-2.7654742"
		ElseIf cmbICAO3.Text = "UHSS" Then
			txtPort1.Text = "Yuzhno, Russia"
			txtLatRad1.Text = "0.700720605855"
			txtLongRad1.Text = "-2.490730287"
		ElseIf cmbICAO3.Text = "UTTT" Then
			txtPort1.Text = "Tashkent, Russia"
			txtLatRad1.Text = "0.719948316448"
			txtLongRad1.Text = "-1.209222283"
		ElseIf cmbICAO3.Text = "UUEE" Then
			txtPort1.Text = "Moscow, Russia"
			txtLatRad1.Text = "0.976889871162"
			txtLongRad1.Text = "-0.65301494"
		ElseIf cmbICAO3.Text = "VABB" Then
			txtPort1.Text = "Bombay"
			txtLatRad1.Text = "0.333212443027"
			txtLongRad1.Text = "-1.271763248"
		ElseIf cmbICAO3.Text = "VCBI" Then
			txtPort1.Text = "Columbo, Sri Lanka"
			txtLatRad1.Text = "0.125314640293"
			txtLongRad1.Text = "-1.394227184"
		ElseIf cmbICAO3.Text = "VIDP" Then
			txtPort1.Text = "Delhi"
			txtLatRad1.Text = "0.498582389653"
			txtLongRad1.Text = "-1.345648853"
		ElseIf cmbICAO3.Text = "VNKT" Then
			txtPort1.Text = "Katmandu, Nepal"
			txtLatRad1.Text = "0.485230620875"
			txtLongRad1.Text = "-1.489842138"
		ElseIf cmbICAO3.Text = "VOMM" Then
			txtPort1.Text = "Madras"
			txtLatRad1.Text = "0.226805536297"
			txtLongRad1.Text = "-1.399346817"
		ElseIf cmbICAO3.Text = "VOPB" Then
			txtPort1.Text = "Port Blair, Nicobar"
			txtLatRad1.Text = "0.203272680216"
			txtLongRad1.Text = "-1.618531082"
		ElseIf cmbICAO3.Text = "VRMM" Then
			txtPort1.Text = "Male, Maldives"
			txtLatRad1.Text = "0.073158384479"
			txtLongRad1.Text = "-1.283398777"
		ElseIf cmbICAO3.Text = "VTBD" Then
			txtPort1.Text = "Bangkok"
			txtLatRad1.Text = "0.242891654236"
			txtLongRad1.Text = "-1.755888494"
		ElseIf cmbICAO3.Text = "WMKJ" Then
			txtPort1.Text = "Johor Bahru, Malaysia"
			txtLatRad1.Text = "0.028594310912"
			txtLongRad1.Text = "-1.809411924"
		ElseIf cmbICAO3.Text = "WMKK" Then
			txtPort1.Text = "Kuala Lumpur"
			txtLatRad1.Text = "0.054628805587"
			txtLongRad1.Text = "-1.772410944"
		ElseIf cmbICAO3.Text = "WSSL" Then
			txtPort1.Text = "Singapore"
			txtLatRad1.Text = "0.024725497737"
			txtLongRad1.Text = "-1.812815316"
		ElseIf cmbICAO3.Text = "ZGGG" Then
			txtPort1.Text = "Guangzhou"
			txtLatRad1.Text = "0.404625498254"
			txtLongRad1.Text = "-1.976847177"
		ElseIf cmbICAO3.Text = "Other" Then
			'Call ICAO3Other
		End If

		Dim intLeg, intTotal1, intLeg1 As Double
		If cmbICAO3.Text <> "Other" Then
			Call CalcDist()

			txtLeg1.Text = txtDist.Text
			txtLeg1.Text = VB6.Format(txtLeg1.Text, "Fixed")
			intLeg = CDbl(txtLeg.Text)
			intLeg1 = CDbl(txtLeg1.Text)
			intTotal1 = intLeg + intLeg1
			txtTotal1.Text = CStr(intTotal1)
			txtTotal1.Text = VB6.Format(txtTotal1.Text, "Fixed")
		Else
			Call ICAO3Other()
		End If

		If cmbICAO3.Text = "Other" Then
			cmbICAO3.Visible = False
			cmbICAO4.Visible = False
			txtICAO4.Text = txtICAO3.Text
			'cmbICAO3 = txtICAO3
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		Else
			cmbICAO4.Text = cmbICAO3.Text
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		End If

		cmbICAO5.Focus()

	End Sub

	<Obsolete>
	Private Sub ICAO3Other()

		txtICAO3.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtPort1.Text = InputBox("Enter Name of Airport.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
		txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
		txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
		txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
		intLatDeg = CDbl(txtLatDeg.Text)
		intLatMin = CDbl(txtLatMin.Text)
		intLatSec = CDbl(txtLatSec.Text)
		intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
		If txtNS.Text = "S" Then
			intLatRad = intLatRad * -1
		ElseIf txtNS.Text = "s" Then
			intLatRad = intLatRad * -1
		End If
		txtLatRad1.Text = CStr(intLatRad / (180 / 3.141592654))
		txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
		txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
		txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
		txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
		intLongDeg = CDbl(txtLongDeg.Text)
		intLongMin = CDbl(txtLongMin.Text)
		intLongSec = CDbl(txtLongSec.Text)
		intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
		If txtEW.Text = "E" Then
			intLongRad = intLongRad * -1
		ElseIf txtEW.Text = "e" Then
			intLongRad = intLongRad * -1
		End If
		txtLongRad1.Text = CStr(intLongRad / (180 / 3.141592654))
		cmbICAO3.Visible = False

		Call CalcDist()

		Dim intLeg, intTotal1, intLeg1 As Double
		txtLeg1.Text = txtDist.Text
		txtLeg1.Text = VB6.Format(txtLeg1.Text, "Fixed")
		intLeg = CDbl(txtLeg.Text)
		intLeg1 = CDbl(txtLeg1.Text)
		intTotal1 = intLeg + intLeg1
		txtTotal1.Text = CStr(intTotal1)
		txtTotal1.Text = VB6.Format(txtTotal1.Text, "Fixed")

		strICAO = txtICAO3.Text
		strPort = txtPort1.Text
		strLatRad = txtLatRad1.Text
		strLongRad = txtLongRad1.Text
		FileOpen(1, "Bid ICAO.txt", OpenMode.Append)
		WriteLine(1, strICAO, strPort, strLatRad, strLongRad)
		FileClose(1)

		intLatDeg = 0
		intLatMin = 0
		intLatSec = 0
		intLatRad = 0
		intLongDeg = 0
		intLongMin = 0
		intLongSec = 0
		intLongRad = 0

	End Sub


	'UPGRADE_WARNING: Event cmbICAO4.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cmbICAO4_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO4.SelectedIndexChanged

		If cmbICAO4.Text = "ASSY" Then
			'txtPort.Text = "Sidney"
			txtLatRad.Text = "-0.592248392843409"
			txtLongRad.Text = "-2.63835605259809"
		ElseIf cmbICAO4.Text = "AYPY" Then
			'txtPort.Text = "Port Moresby, PNG"
			txtLatRad.Text = "-0.164817259029998"
			txtLongRad.Text = "-2.56941554714432"
		ElseIf cmbICAO4.Text = "BGBW" Then
			'txtPort.Text = "Narsarsuaq"
			txtLatRad.Text = "1.0674724593406"
			txtLongRad.Text = "0.792873990360157"
		ElseIf cmbICAO4.Text = "BGGH" Then
			'txtPort.Text = "Godthab"
			txtLatRad.Text = "1.12035593567603"
			txtLongRad.Text = "0.902044335072403"
		ElseIf cmbICAO4.Text = "BIRK" Then
			'txtPort.Text = "Reykjavik"
			txtLatRad.Text = "1.1192505604831"
			txtLongRad.Text = "0.382983415529289"
		ElseIf cmbICAO4.Text = "CYAM" Then
			'txtPort.Text = "Sault Ste. Marie"
			txtLatRad.Text = "0.811316302789564"
			txtLongRad.Text = "1.47497775086041"
		ElseIf cmbICAO4.Text = "CYFB" Then
			'txtPort.Text = "Iqaluit"
			txtLatRad.Text = "1.11276375342985"
			txtLongRad.Text = "1.19653955752558"
		ElseIf cmbICAO4.Text = "CYQX" Then
			'txtPort.Text = "Gander"
			txtLatRad.Text = "0.854164135926025"
			txtLongRad.Text = "0.952426172813306"
		ElseIf cmbICAO4.Text = "CYYQ" Then
			'txtPort.Text = "Churchill Falls"
			txtLatRad.Text = "1.02520640262147"
			txtLongRad.Text = "1.64177304970933"
		ElseIf cmbICAO4.Text = "CYYR" Then
			'txtPort.Text = "Goose Bay"
			txtLatRad.Text = "0.930609557163376"
			txtLongRad.Text = "1.05464428933844"
		ElseIf cmbICAO4.Text = "CYYT" Then
			'txtPort.Text = "St John's, NFLD"
			txtLatRad.Text = "0.831096700978833"
			txtLongRad.Text = "0.920690269247875"
		ElseIf cmbICAO4.Text = "DAAG" Then
			'txtPort.Text = "Algiers, Algeria"
			txtLatRad.Text = "0.640419480198453"
			txtLongRad.Text = "-0.0561705130933508"
		ElseIf cmbICAO4.Text = "DIAP" Then
			'txtPort.Text = "Abidjan"
			txtLatRad.Text = "0.0916588745505689"
			txtLongRad.Text = "0.0685623507825106"
		ElseIf cmbICAO4.Text = "DNMM" Then
			'txtPort.Text = "Lagos, Nigeria"
			txtLatRad.Text = "0.114755398318627"
			txtLongRad.Text = "-0.0579158423453452"
		ElseIf cmbICAO4.Text = "DRRN" Then
			'txtPort.Text = "Niami, Niger"
			txtLatRad.Text = "0.235299471989702"
			txtLongRad.Text = "-0.0379318224100101"
		ElseIf cmbICAO4.Text = "EBBR" Then
			'txtPort.Text = "Brussels"
			txtLatRad.Text = "0.88840167808598"
			txtLongRad.Text = "-0.0785107275188782"
		ElseIf cmbICAO4.Text = "EDDW" Then
			'txtPort.Text = "Bremen, Germany"
			txtLatRad.Text = "0.925868079362125"
			txtLongRad.Text = "-0.153385352429435"
		ElseIf cmbICAO4.Text = "EFHK" Then
			'txtPort.Text = "Helsinki, Finland"
			txtLatRad.Text = "1.05272442716125"
			txtLongRad.Text = "-0.435750536581251"
		ElseIf cmbICAO4.Text = "EGPD" Then
			'txtPort.Text = "Aberdeen"
			txtLatRad.Text = "0.998415598603356"
			txtLongRad.Text = "0.0383681547230087"
		ElseIf cmbICAO4.Text = "EGPK" Then
			'txtPort.Text = "Prestwick"
			txtLatRad.Text = "0.968686823677719"
			txtLongRad.Text = "0.0798779020996071"
		ElseIf cmbICAO4.Text = "EHBK" Then
			'txtPort.Text = "Maastricht, Netherlands"
			txtLatRad.Text = "0.888663477473779"
			txtLongRad.Text = "-0.100821853123539"
		ElseIf cmbICAO4.Text = "EINN" Then
			'txtPort.Text = "Shannon"
			txtLatRad.Text = "0.919788515801012"
			txtLongRad.Text = "0.155741546919627"
		ElseIf cmbICAO4.Text = "EKCH" Then
			txtPort.Text = "Copenhagen"
			txtLatRad.Text = "0.97054850821318"
			txtLongRad.Text = "-0.220493262168617"
		ElseIf cmbICAO4.Text = "ELLX" Then
			'txtPort.Text = "Luxembourg"
			txtLatRad.Text = "0.86609055248132"
			txtLongRad.Text = "-0.108297680086248"
		ElseIf cmbICAO4.Text = "ENBR" Then
			'txtPort.Text = "Bergen, Norway"
			txtLatRad.Text = "1.05231718366911"
			txtLongRad.Text = "-0.091106186954104"
		ElseIf cmbICAO4.Text = "FAGM" Then
			'txtPort.Text = "Rand"
			txtLatRad.Text = "-0.458003484544179"
			txtLongRad.Text = "-0.49133927325727"
		ElseIf cmbICAO4.Text = "FALA" Then
			'txtPort.Text = "Lanseria, RSA"
			txtLatRad.Text = "-0.452622052683863"
			txtLongRad.Text = "-0.48735410479855"
		ElseIf cmbICAO4.Text = "FAWM" Then
			'txtPort.Text = "Windhoek"
			txtLatRad.Text = "-0.392379104669192"
			txtLongRad.Text = "-0.304967197965142"
		ElseIf cmbICAO4.Text = "FCBB" Then
			'txtPort.Text = "Brazzaville, Congo"
			txtLatRad.Text = "-0.0742928484932253"
			txtLongRad.Text = "-0.266162710929135"
		ElseIf cmbICAO4.Text = "FEFF" Then
			'txtPort.Text = "Bangui, CAE"
			txtLatRad.Text = "0.0767653982668839"
			txtLongRad.Text = "-0.323264066290216"
		ElseIf cmbICAO4.Text = "FMMI" Then
			'txtPort.Text = "Antananarivo, Madagascar"
			txtLatRad.Text = "-0.328063721733201"
			txtLongRad.Text = "-0.828624151205175"
		ElseIf cmbICAO4.Text = "FNLU" Then
			'txtPort.Text = "Luanda"
			txtLatRad.Text = "-0.154548905264098"
			txtLongRad.Text = "-0.231023415322316"
		ElseIf cmbICAO4.Text = "FOOL" Then
			'txtPort.Text = "Libreville"
			txtLatRad.Text = "-0.00799942573830734"
			txtLongRad.Text = "-0.164322749075266"
		ElseIf cmbICAO4.Text = "FSIA" Then
			'txtPort.Text = "Seychelles Intl"
			txtLatRad.Text = "-0.0815359648890018"
			txtLongRad.Text = "-0.969064978348985"
		ElseIf cmbICAO4.Text = "FVHA" Then
			'txtPort.Text = "Harare, Zimbabwe"
			txtLatRad.Text = "-0.31296662370345"
			txtLongRad.Text = "-0.54268104208677"
		ElseIf cmbICAO4.Text = "FZNA" Then
			'txtPort.Text = "Goma, Zaire"
			txtLatRad.Text = "-0.0290888208665722"
			txtLongRad.Text = "-0.510217917999676"
		ElseIf cmbICAO4.Text = "GBYD" Then
			'txtPort.Text = "Banjul"
			txtLatRad.Text = "0.23285601103691"
			txtLongRad.Text = "0.290742764561389"
		ElseIf cmbICAO4.Text = "GCXO" Then
			'txtPort.Text = "Tenerife"
			txtLatRad.Text = "0.497157037431"
			txtLongRad.Text = "0.2851867998"
		ElseIf cmbICAO4.Text = "GMAA" Then
			'txtPort.Text = "Agadir"
			txtLatRad.Text = "0.530260115577"
			txtLongRad.Text = "0.1667080324"
		ElseIf cmbICAO4.Text = "GOOY" Then
			'txtPort.Text = "Dakar"
			txtLatRad.Text = "0.257290620565"
			txtLongRad.Text = "0.3052580862"
		ElseIf cmbICAO4.Text = "HELX" Then
			'txtPort.Text = "Luxor"
			txtLatRad.Text = "0.447967841345"
			txtLongRad.Text = "-0.570722665"
		ElseIf cmbICAO4.Text = "HKNW" Then
			'txtPort.Text = "Nairobi-Wilson"
			txtLatRad.Text = "-0.02298016848"
			txtLongRad.Text = "-0.642572053"
		ElseIf cmbICAO4.Text = "HSSS" Then
			'txtPort.Text = "Khartoum"
			txtLatRad.Text = "0.272271363311"
			txtLongRad.Text = "-0.568250116"
		ElseIf cmbICAO4.Text = "HTDA" Then
			'txtPort.Text = "Dar-Es-Salaam"
			txtLatRad.Text = "-0.11999138607"
			txtLongRad.Text = "-0.684198156"
		ElseIf cmbICAO4.Text = "I69" Then
			'txtPort.Text = "Batavia, OH"
			txtLatRad.Text = "0.682045582859"
			txtLongRad.Text = "1.4697417631"
		ElseIf cmbICAO4.Text = "KANC" Then
			'txtPort.Text = "Anchorage"
			txtLatRad.Text = "1.067292108651"
			txtLongRad.Text = "2.6215601674"
		ElseIf cmbICAO4.Text = "KBGR" Then
			'txtPort.Text = "Bangor"
			txtLatRad.Text = "0.782052948998"
			txtLongRad.Text = "1.2012810353"
		ElseIf cmbICAO4.Text = "KBOI" Then
			'txtPort.Text = "Boise"
			txtLatRad.Text = "0.760352688631"
			txtLongRad.Text = "2.0285089231"
		ElseIf cmbICAO4.Text = "KCAE" Then
			'txtPort.Text = "Columbia, SC"
			txtLatRad.Text = "0.592364748127"
			txtLongRad.Text = "1.4158110892"
		ElseIf cmbICAO4.Text = "KEWK" Then
			'txtPort.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO4.Text = "KICT" Then
			'txtPort.Text = "Wichita, KS"
			txtLatRad.Text = "0.657116463376"
			txtLongRad.Text = "1.7005324679"
		ElseIf cmbICAO4.Text = "KIDP" Then
			'txtPort.Text = "Independence, KS"
			txtLatRad.Text = "0.648535261220"
			txtLongRad.Text = "1.6716472687"
		ElseIf cmbICAO4.Text = "KJNU" Then
			'txtPort.Text = "Juneau, AK"
			txtLatRad.Text = "1.018545062643"
			txtLongRad.Text = "2.3488738036"
		ElseIf cmbICAO4.Text = "KMIA" Then
			'txtPort.Text = "Miami, FL"
			txtLatRad.Text = "0.450178591731"
			txtLongRad.Text = "1.4013248564"
		ElseIf cmbICAO4.Text = "KMSP" Then
			'txtPort.Text = "Minneapolis, MN"
			txtLatRad.Text = "0.783391034758"
			txtLongRad.Text = "1.6269086622"
		ElseIf cmbICAO4.Text = "KNUD" Then
			'txtPort.Text = "ADAK, AK"
			txtLatRad.Text = "0.905348825123"
			txtLongRad.Text = "3.0835022783"
		ElseIf cmbICAO4.Text = "KOAK" Then
			'txtPort.Text = "Oakland, CA"
			txtLatRad.Text = "0.658454549136"
			txtLongRad.Text = "2.1331995894"
		ElseIf cmbICAO4.Text = "KPDK" Then
			'txtPort.Text = "Atlanta, GA"
			txtLatRad.Text = "0.590648507696"
			txtLongRad.Text = "1.4713416483"
		ElseIf cmbICAO4.Text = "KVRB" Then
			'txtPort.Text = "Vero Beach"
			txtLatRad.Text = "0.482670804639"
			txtLongRad.Text = "1.4035356068"
		ElseIf cmbICAO4.Text = "LCPH" Then
			'txtPort.Text = "Larnaca, Cyprus"
			txtLatRad.Text = "0.608741754275"
			txtLongRad.Text = "-0.586954227"
		ElseIf cmbICAO4.Text = "LEMD" Then
			'txtPort.Text = "Madrid"
			txtLatRad.Text = "0.706392925924"
			txtLongRad.Text = "-0.062133721"
		ElseIf cmbICAO4.Text = "LEMG" Then
			'txtPort.Text = "Malaga"
			txtLatRad.Text = "0.640099503169"
			txtLongRad.Text = "0.0784816387"
		ElseIf cmbICAO4.Text = "LFPN" Then
			'txtPort.Text = "Toussus Le Noble"
			txtLatRad.Text = "0.850877099168"
			txtLongRad.Text = "-0.036739181"
		ElseIf cmbICAO4.Text = "LGAT" Then
			'txtPort.Text = "Athens"
			txtLatRad.Text = "0.661247075939"
			txtLongRad.Text = "-0.414166631"
		ElseIf cmbICAO4.Text = "LGIR" Then
			'txtPort.Text = "Iraklion"
			txtLatRad.Text = "0.616770268834"
			txtLongRad.Text = "-0.439444817"
		ElseIf cmbICAO4.Text = "LIRA" Then
			'txtPort.Text = "Rome"
			txtLatRad.Text = "0.729518538513"
			txtLongRad.Text = "-0.219824219"
		ElseIf cmbICAO4.Text = "LKPR" Then
			'txtPort.Text = "Prague, Czech"
			txtLatRad.Text = "0.874439044070"
			txtLongRad.Text = "-0.248913040"
		ElseIf cmbICAO4.Text = "LPAZ" Then
			'txtPort.Text = "Santa Maria"
			txtLatRad.Text = "0.645306402104"
			txtLongRad.Text = "0.4393284615"
		ElseIf cmbICAO4.Text = "LPPR" Then
			'txtPort.Text = "Porto, Portugal"
			txtLatRad.Text = "0.719657428239"
			txtLongRad.Text = "0.1514364014"
		ElseIf cmbICAO4.Text = "LROP" Then
			'txtPort.Text = "Bucharest, Romania"
			txtLatRad.Text = "0.777893247614"
			txtLongRad.Text = "-0.455298224"
		ElseIf cmbICAO4.Text = "LTAC" Then
			'txtPort.Text = "Ankara"
			txtLatRad.Text = "0.700313362363"
			txtLongRad.Text = "-0.575842298"
		ElseIf cmbICAO4.Text = "LTBA" Then
			'txtPort.Text = "Istanbul, Turkey"
			txtLatRad.Text = "0.715177749826"
			txtLongRad.Text = "-0.502945713"
		ElseIf cmbICAO4.Text = "MROC" Then
			'txtPort.Text = "San Jose, CR"
			txtLatRad.Text = "0.174416569916"
			txtLongRad.Text = "1.4697708519"
		ElseIf cmbICAO4.Text = "NTSU" Then
			'txtPort.Text = "Pago Pago"
			txtLatRad.Text = "0.250192948273"
			txtLongRad.Text = "2.9794515661"
		ElseIf cmbICAO4.Text = "NZAA" Then
			'txtPort.Text = "Auckland"
			txtLatRad.Text = "-0.64588817852"
			txtLongRad.Text = "-3.050690088"
		ElseIf cmbICAO4.Text = "OOMS" Then
			'txtPort.Text = "SEEB, Oman"
			txtLatRad.Text = "0.411781348187"
			txtLongRad.Text = "-1.017148799"
		ElseIf cmbICAO4.Text = "OPKC" Then
			'txtPort.Text = "Karachi"
			txtLatRad.Text = "0.434703339030"
			txtLongRad.Text = "-1.172104948"
		ElseIf cmbICAO4.Text = "PAOM" Then
			'txtPort.Text = "Nome, AK"
			txtLatRad.Text = "1.125970078103"
			txtLongRad.Text = "2.8875308921"
		ElseIf cmbICAO4.Text = "PGSN" Then
			'txtPort.Text = "Saipan"
			txtLatRad.Text = "0.263922871722"
			txtLongRad.Text = "-2.543526497"
		ElseIf cmbICAO4.Text = "PHNL" Then
			'txtPort.Text = "Honolulu, HI"
			txtLatRad.Text = "0.372075107704"
			txtLongRad.Text = "2.7562821324"
		ElseIf cmbICAO4.Text = "PHTO" Then
			'txtPort.Text = "HILO"
			txtLatRad.Text = "0.344237106135"
			txtLongRad.Text = "2.7061620940"
		ElseIf cmbICAO4.Text = "PKMJ" Then
			'txtPort.Text = "Majuro"
			txtLatRad.Text = "0.123249334012"
			txtLongRad.Text = "-2.989312676"
		ElseIf cmbICAO4.Text = "PLCH" Then
			'txtPort.Text = "Christmas Island"
			txtLatRad.Text = "0.034702963294"
			txtLongRad.Text = "2.7463628445"
		ElseIf cmbICAO4.Text = "PMDY" Then
			'txtPort.Text = "Midway"
			txtLatRad.Text = "0.492386470808"
			txtLongRad.Text = "3.0958650272"
		ElseIf cmbICAO4.Text = "PTRO" Then
			'txtPort.Text = "Palau"
			txtLatRad.Text = "0.128543499409"
			txtLongRad.Text = "-2.348369597"
		ElseIf cmbICAO4.Text = "PWAK" Then
			'txtPort.Text = "WAKE"
			txtLatRad.Text = "0.336499479785"
			txtLongRad.Text = "-2.908445754"
		ElseIf cmbICAO4.Text = "RCTP" Then
			'txtPort.Text = "Chiang Kai Shek"
			txtLatRad.Text = "0.437699487579"
			txtLongRad.Text = "-2.115717208"
		ElseIf cmbICAO4.Text = "RJCK" Then
			'txtPort.Text = "Kushiro"
			txtLatRad.Text = "0.751218798879"
			txtLongRad.Text = "-2.516677515"
		ElseIf cmbICAO4.Text = "RJTT" Then
			'txtPort.Text = "Tokyo"
			txtLatRad.Text = "0.620580904367"
			txtLongRad.Text = "-2.437643189"
		ElseIf cmbICAO4.Text = "RKSS" Then
			'txtPort.Text = "Seoul, Korea"
			txtLatRad.Text = "0.655429311766"
			txtLongRad.Text = "-2.213077492"
		ElseIf cmbICAO4.Text = "RPMM" Then
			'txtPort.Text = "Manilla"
			txtLatRad.Text = "0.253218185644"
			txtLongRad.Text = "-2.112197461"
		ElseIf cmbICAO4.Text = "SAEZ" Then
			'txtPort.Text = "Ezeiza"
			txtLatRad.Text = "-0.60772364554"
			txtLongRad.Text = "1.0215993888"
		ElseIf cmbICAO4.Text = "SBEG" Then
			'txtPort.Text = "Manaus"
			txtLatRad.Text = "-0.05305800926"
			txtLongRad.Text = "1.0480120382"
		ElseIf cmbICAO4.Text = "SBGL" Then
			'txtPort.Text = "Rio De Janeiro, Brazil"
			txtLatRad.Text = "-0.39810960238"
			txtLongRad.Text = "0.7548549015"
		ElseIf cmbICAO4.Text = "SBSP" Then
			'txtPort.Text = "Sao Paulo"
			txtLatRad.Text = "-0.41233403578"
			txtLongRad.Text = "0.8143124513"
		ElseIf cmbICAO4.Text = "SCEL" Then
			'txtPort.Text = "Santiago, Chile"
			txtLatRad.Text = "-0.58279452606"
			txtLongRad.Text = "1.2354022222"
		ElseIf cmbICAO4.Text = "SVMG" Then
			'txtPort.Text = "Margarita, VE"
			txtLatRad.Text = "0.190531776676"
			txtLongRad.Text = "1.1163998560"
		ElseIf cmbICAO4.Text = "TTPP" Then
			'txtPort.Text = "Picaro"
			txtLatRad.Text = "0.184888545428"
			txtLongRad.Text = "1.0705558744"
		ElseIf cmbICAO4.Text = "UHHH" Then
			'txtPort.Text = "Khabarovsk, Russia"
			txtLatRad.Text = "0.846950108351"
			txtLongRad.Text = "-2.359452438"
		ElseIf cmbICAO4.Text = "UHMM" Then
			'txtPort.Text = "Magadan, Russia"
			txtLatRad.Text = "1.045743110153"
			txtLongRad.Text = "-2.630502071"
		ElseIf cmbICAO4.Text = "UHPP" Then
			'txtPort.Text = "Petropavlovsk, Russia"
			txtLatRad.Text = "0.927933385644"
			txtLongRad.Text = "-2.7654742"
		ElseIf cmbICAO4.Text = "UHSS" Then
			'txtPort.Text = "Yuzhno, Russia"
			txtLatRad.Text = "0.700720605855"
			txtLongRad.Text = "-2.490730287"
		ElseIf cmbICAO4.Text = "UTTT" Then
			'txtPort.Text = "Tashkent, Russia"
			txtLatRad.Text = "0.719948316448"
			txtLongRad.Text = "-1.209222283"
		ElseIf cmbICAO4.Text = "UUEE" Then
			'txtPort.Text = "Moscow, Russia"
			txtLatRad.Text = "0.976889871162"
			txtLongRad.Text = "-0.65301494"
		ElseIf cmbICAO4.Text = "VABB" Then
			'txtPort.Text = "Bombay"
			txtLatRad.Text = "0.333212443027"
			txtLongRad.Text = "-1.271763248"
		ElseIf cmbICAO4.Text = "VCBI" Then
			'txtPort.Text = "Columbo, Sri Lanka"
			txtLatRad.Text = "0.125314640293"
			txtLongRad.Text = "-1.394227184"
		ElseIf cmbICAO4.Text = "VIDP" Then
			'txtPort.Text = "Delhi"
			txtLatRad.Text = "0.498582389653"
			txtLongRad.Text = "-1.345648853"
		ElseIf cmbICAO4.Text = "VNKT" Then
			'txtPort.Text = "Katmandu, Nepal"
			txtLatRad.Text = "0.485230620875"
			txtLongRad.Text = "-1.489842138"
		ElseIf cmbICAO4.Text = "VOMM" Then
			'txtPort.Text = "Madras"
			txtLatRad.Text = "0.226805536297"
			txtLongRad.Text = "-1.399346817"
		ElseIf cmbICAO4.Text = "VOPB" Then
			'txtPort.Text = "Port Blair, Nicobar"
			txtLatRad.Text = "0.203272680216"
			txtLongRad.Text = "-1.618531082"
		ElseIf cmbICAO4.Text = "VRMM" Then
			'txtPort.Text = "Male, Maldives"
			txtLatRad.Text = "0.073158384479"
			txtLongRad.Text = "-1.283398777"
		ElseIf cmbICAO4.Text = "VTBD" Then
			'txtPort.Text = "Bangkok"
			txtLatRad.Text = "0.242891654236"
			txtLongRad.Text = "-1.755888494"
		ElseIf cmbICAO4.Text = "WMKJ" Then
			'txtPort.Text = "Johor Bahru, Malaysia"
			txtLatRad.Text = "0.028594310912"
			txtLongRad.Text = "-1.809411924"
		ElseIf cmbICAO4.Text = "WMKK" Then
			'txtPort.Text = "Kuala Lumpur"
			txtLatRad.Text = "0.054628805587"
			txtLongRad.Text = "-1.772410944"
		ElseIf cmbICAO4.Text = "WSSL" Then
			'txtPort.Text = "Singapore"
			txtLatRad.Text = "0.024725497737"
			txtLongRad.Text = "-1.812815316"
		ElseIf cmbICAO4.Text = "ZGGG" Then
			'txtPort.Text = "Guangzhou"
			txtLatRad.Text = "0.404625498254"
			txtLongRad.Text = "-1.976847177"
		ElseIf cmbICAO4.Text = "Other" Then
			txtICAO4.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
			txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
			txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
			txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
			txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
			intLatDeg = CDbl(txtLatDeg.Text)
			intLatMin = CDbl(txtLatMin.Text)
			intLatSec = CDbl(txtLatSec.Text)
			intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
			If txtNS.Text = "S" Then
				intLatRad = intLatRad * -1
			ElseIf txtNS.Text = "s" Then
				intLatRad = intLatRad * -1
			End If
			txtLatRad.Text = CStr(intLatRad / (180 / 3.141592654))
			txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
			txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
			txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
			txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
			intLongDeg = CDbl(txtLongDeg.Text)
			intLongMin = CDbl(txtLongMin.Text)
			intLongSec = CDbl(txtLongSec.Text)
			intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
			If txtEW.Text = "E" Then
				intLongRad = intLongRad * -1
			ElseIf txtEW.Text = "e" Then
				intLongRad = intLongRad * -1
			End If
			txtLongRad.Text = CStr(intLongRad / (180 / 3.141592654))
			cmbICAO4.Visible = False
			'cmbICAO4 = txtICAO4
			cmbICAO5.Focus()
		End If

	End Sub

	'UPGRADE_WARNING: Event cmbICAO5.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	<Obsolete>
	Private Sub cmbICAO5_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO5.SelectedIndexChanged

		If cmbICAO6.Text <> "" Then
			cmbICAO6.Text = ""
			cmbICAO7.Text = ""
			cmbICAO8.Text = ""
			cmbICAO9.Text = ""
			cmbICAO10.Text = ""
			cmbICAO11.Text = ""
			cmbICAO12.Text = ""
			cmbICAO13.Text = ""
			cmbICAO14.Text = ""
			cmbICAO15.Text = ""
			txtPort3.Text = ""
			txtPort4.Text = ""
			txtPort5.Text = ""
			txtPort6.Text = ""
			txtPort7.Text = ""
			txtLeg3.Text = ""
			txtLeg4.Text = ""
			txtLeg5.Text = ""
			txtLeg6.Text = ""
			txtLeg7.Text = ""
			txtTotal3.Text = ""
			txtTotal4.Text = ""
			txtTotal5.Text = ""
			txtTotal6.Text = ""
			txtTotal7.Text = ""

			Call cmbICAO4_SelectedIndexChanged(cmbICAO4, New System.EventArgs())

		End If

		If cmbICAO5.Text = cmbICAO4.Text Then
			Call MsgBox("Please re-enter destination, not equal to origination.", MsgBoxStyle.OKOnly, "Re-enter Destination")
			cmbICAO5.Text = ""
			cmbICAO5.Focus()
			Exit Sub
		ElseIf cmbICAO5.Text = "ASSY" Then
			txtPort2.Text = "Sidney"
			txtLatRad1.Text = "-0.592248392843409"
			txtLongRad1.Text = "-2.63835605259809"
		ElseIf cmbICAO5.Text = "AYPY" Then
			txtPort2.Text = "Port Moresby, PNG"
			txtLatRad1.Text = "-0.164817259029998"
			txtLongRad1.Text = "-2.56941554714432"
		ElseIf cmbICAO5.Text = "BGBW" Then
			txtPort2.Text = "Narsarsuaq"
			txtLatRad1.Text = "1.0674724593406"
			txtLongRad1.Text = "0.792873990360157"
		ElseIf cmbICAO5.Text = "BGGH" Then
			txtPort2.Text = "Godthab"
			txtLatRad1.Text = "1.12035593567603"
			txtLongRad1.Text = "0.902044335072403"
		ElseIf cmbICAO5.Text = "BIRK" Then
			txtPort2.Text = "Reykjavik"
			txtLatRad1.Text = "1.1192505604831"
			txtLongRad1.Text = "0.382983415529289"
		ElseIf cmbICAO5.Text = "CYAM" Then
			txtPort2.Text = "Sault Ste. Marie"
			txtLatRad1.Text = "0.811316302789564"
			txtLongRad1.Text = "1.47497775086041"
		ElseIf cmbICAO5.Text = "CYFB" Then
			txtPort2.Text = "Iqaluit"
			txtLatRad1.Text = "1.11276375342985"
			txtLongRad1.Text = "1.19653955752558"
		ElseIf cmbICAO5.Text = "CYQX" Then
			txtPort2.Text = "Gander"
			txtLatRad1.Text = "0.854164135926025"
			txtLongRad1.Text = "0.952426172813306"
		ElseIf cmbICAO5.Text = "CYYQ" Then
			txtPort2.Text = "Churchill Falls"
			txtLatRad1.Text = "1.02520640262147"
			txtLongRad1.Text = "1.64177304970933"
		ElseIf cmbICAO5.Text = "CYYR" Then
			txtPort2.Text = "Goose Bay"
			txtLatRad1.Text = "0.930609557163376"
			txtLongRad1.Text = "1.05464428933844"
		ElseIf cmbICAO5.Text = "CYYT" Then
			txtPort2.Text = "St John's, NFLD"
			txtLatRad1.Text = "0.831096700978833"
			txtLongRad1.Text = "0.920690269247875"
		ElseIf cmbICAO5.Text = "DAAG" Then
			txtPort2.Text = "Algiers, Algeria"
			txtLatRad1.Text = "0.640419480198453"
			txtLongRad1.Text = "-0.0561705130933508"
		ElseIf cmbICAO5.Text = "DIAP" Then
			txtPort2.Text = "Abidjan"
			txtLatRad1.Text = "0.0916588745505689"
			txtLongRad1.Text = "0.0685623507825106"
		ElseIf cmbICAO5.Text = "DNMM" Then
			txtPort2.Text = "Lagos, Nigeria"
			txtLatRad1.Text = "0.114755398318627"
			txtLongRad1.Text = "-0.0579158423453452"
		ElseIf cmbICAO5.Text = "DRRN" Then
			txtPort2.Text = "Niami, Niger"
			txtLatRad1.Text = "0.235299471989702"
			txtLongRad1.Text = "-0.0379318224100101"
		ElseIf cmbICAO5.Text = "EBBR" Then
			txtPort2.Text = "Brussels"
			txtLatRad1.Text = "0.88840167808598"
			txtLongRad1.Text = "-0.0785107275188782"
		ElseIf cmbICAO5.Text = "EDDW" Then
			txtPort2.Text = "Bremen, Germany"
			txtLatRad1.Text = "0.925868079362125"
			txtLongRad1.Text = "-0.153385352429435"
		ElseIf cmbICAO5.Text = "EFHK" Then
			txtPort2.Text = "Helsinki, Finland"
			txtLatRad1.Text = "1.05272442716125"
			txtLongRad1.Text = "-0.435750536581251"
		ElseIf cmbICAO5.Text = "EGPD" Then
			txtPort2.Text = "Aberdeen"
			txtLatRad1.Text = "0.998415598603356"
			txtLongRad1.Text = "0.0383681547230087"
		ElseIf cmbICAO5.Text = "EGPK" Then
			txtPort2.Text = "Prestwick"
			txtLatRad1.Text = "0.968686823677719"
			txtLongRad1.Text = "0.0798779020996071"
		ElseIf cmbICAO5.Text = "EHBK" Then
			txtPort2.Text = "Maastricht, Netherlands"
			txtLatRad1.Text = "0.888663477473779"
			txtLongRad1.Text = "-0.100821853123539"
		ElseIf cmbICAO5.Text = "EINN" Then
			txtPort2.Text = "Shannon"
			txtLatRad1.Text = "0.919788515801012"
			txtLongRad1.Text = "0.155741546919627"
		ElseIf cmbICAO5.Text = "EKCH" Then
			txtPort2.Text = "Copenhagen"
			txtLatRad1.Text = "0.97054850821318"
			txtLongRad1.Text = "-0.220493262168617"
		ElseIf cmbICAO5.Text = "ELLX" Then
			txtPort2.Text = "Luxembourg"
			txtLatRad1.Text = "0.86609055248132"
			txtLongRad1.Text = "-0.108297680086248"
		ElseIf cmbICAO5.Text = "ENBR" Then
			txtPort2.Text = "Bergen, Norway"
			txtLatRad1.Text = "1.05231718366911"
			txtLongRad1.Text = "-0.091106186954104"
		ElseIf cmbICAO5.Text = "FAGM" Then
			txtPort2.Text = "Rand"
			txtLatRad1.Text = "-0.458003484544179"
			txtLongRad1.Text = "-0.49133927325727"
		ElseIf cmbICAO5.Text = "FALA" Then
			txtPort2.Text = "Lanseria, RSA"
			txtLatRad1.Text = "-0.452622052683863"
			txtLongRad1.Text = "-0.48735410479855"
		ElseIf cmbICAO5.Text = "FAWM" Then
			txtPort2.Text = "Windhoek"
			txtLatRad1.Text = "-0.392379104669192"
			txtLongRad1.Text = "-0.304967197965142"
		ElseIf cmbICAO5.Text = "FCBB" Then
			txtPort2.Text = "Brazzaville, Congo"
			txtLatRad1.Text = "-0.0742928484932253"
			txtLongRad1.Text = "-0.266162710929135"
		ElseIf cmbICAO5.Text = "FEFF" Then
			txtPort2.Text = "Bangui, CAE"
			txtLatRad1.Text = "0.0767653982668839"
			txtLongRad1.Text = "-0.323264066290216"
		ElseIf cmbICAO5.Text = "FMMI" Then
			txtPort2.Text = "Antananarivo, Madagascar"
			txtLatRad1.Text = "-0.328063721733201"
			txtLongRad1.Text = "-0.828624151205175"
		ElseIf cmbICAO5.Text = "FNLU" Then
			txtPort2.Text = "Luanda"
			txtLatRad1.Text = "-0.154548905264098"
			txtLongRad1.Text = "-0.231023415322316"
		ElseIf cmbICAO5.Text = "FOOL" Then
			txtPort2.Text = "Libreville"
			txtLatRad1.Text = "-0.00799942573830734"
			txtLongRad1.Text = "-0.164322749075266"
		ElseIf cmbICAO5.Text = "FSIA" Then
			txtPort2.Text = "Seychelles Intl"
			txtLatRad1.Text = "-0.0815359648890018"
			txtLongRad1.Text = "-0.969064978348985"
		ElseIf cmbICAO5.Text = "FVHA" Then
			txtPort2.Text = "Harare, Zimbabwe"
			txtLatRad1.Text = "-0.31296662370345"
			txtLongRad1.Text = "-0.54268104208677"
		ElseIf cmbICAO5.Text = "FZNA" Then
			txtPort2.Text = "Goma, Zaire"
			txtLatRad1.Text = "-0.0290888208665722"
			txtLongRad1.Text = "-0.510217917999676"
		ElseIf cmbICAO5.Text = "GBYD" Then
			txtPort2.Text = "Banjul"
			txtLatRad1.Text = "0.23285601103691"
			txtLongRad1.Text = "0.290742764561389"
		ElseIf cmbICAO5.Text = "GCXO" Then
			txtPort2.Text = "Tenerife"
			txtLatRad1.Text = "0.497157037431"
			txtLongRad1.Text = "0.2851867998"
		ElseIf cmbICAO5.Text = "GMAA" Then
			txtPort2.Text = "Agadir"
			txtLatRad1.Text = "0.530260115577"
			txtLongRad1.Text = "0.1667080324"
		ElseIf cmbICAO5.Text = "GOOY" Then
			txtPort2.Text = "Dakar"
			txtLatRad1.Text = "0.257290620565"
			txtLongRad1.Text = "0.3052580862"
		ElseIf cmbICAO5.Text = "HELX" Then
			txtPort2.Text = "Luxor"
			txtLatRad1.Text = "0.447967841345"
			txtLongRad1.Text = "-0.570722665"
		ElseIf cmbICAO5.Text = "HKNW" Then
			txtPort2.Text = "Nairobi-Wilson"
			txtLatRad1.Text = "-0.02298016848"
			txtLongRad1.Text = "-0.642572053"
		ElseIf cmbICAO5.Text = "HSSS" Then
			txtPort2.Text = "Khartoum"
			txtLatRad1.Text = "0.272271363311"
			txtLongRad1.Text = "-0.568250116"
		ElseIf cmbICAO5.Text = "HTDA" Then
			txtPort2.Text = "Dar-Es-Salaam"
			txtLatRad1.Text = "-0.11999138607"
			txtLongRad1.Text = "-0.684198156"
		ElseIf cmbICAO5.Text = "I69" Then
			txtPort2.Text = "Batavia, OH"
			txtLatRad1.Text = "0.682045582859"
			txtLongRad1.Text = "1.4697417631"
		ElseIf cmbICAO5.Text = "KANC" Then
			txtPort2.Text = "Anchorage"
			txtLatRad1.Text = "1.067292108651"
			txtLongRad1.Text = "2.6215601674"
		ElseIf cmbICAO5.Text = "KBGR" Then
			txtPort2.Text = "Bangor"
			txtLatRad1.Text = "0.782052948998"
			txtLongRad1.Text = "1.2012810353"
		ElseIf cmbICAO5.Text = "KBOI" Then
			txtPort2.Text = "Boise"
			txtLatRad1.Text = "0.760352688631"
			txtLongRad1.Text = "2.0285089231"
		ElseIf cmbICAO5.Text = "KCAE" Then
			txtPort2.Text = "Columbia, SC"
			txtLatRad1.Text = "0.592364748127"
			txtLongRad1.Text = "1.4158110892"
		ElseIf cmbICAO5.Text = "KEWK" Then
			txtPort2.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO5.Text = "KICT" Then
			txtPort2.Text = "Wichita, KS"
			txtLatRad1.Text = "0.657116463376"
			txtLongRad1.Text = "1.7005324679"
		ElseIf cmbICAO5.Text = "KIDP" Then
			txtPort2.Text = "Independence, KS"
			txtLatRad1.Text = "0.648535261220"
			txtLongRad1.Text = "1.6716472687"
		ElseIf cmbICAO5.Text = "KJNU" Then
			txtPort2.Text = "Juneau, AK"
			txtLatRad1.Text = "1.018545062643"
			txtLongRad1.Text = "2.3488738036"
		ElseIf cmbICAO5.Text = "KMIA" Then
			txtPort2.Text = "Miami, FL"
			txtLatRad1.Text = "0.450178591731"
			txtLongRad1.Text = "1.4013248564"
		ElseIf cmbICAO5.Text = "KMSP" Then
			txtPort2.Text = "Minneapolis, MN"
			txtLatRad1.Text = "0.783391034758"
			txtLongRad1.Text = "1.6269086622"
		ElseIf cmbICAO5.Text = "KNUD" Then
			txtPort2.Text = "ADAK, AK"
			txtLatRad1.Text = "0.905348825123"
			txtLongRad1.Text = "3.0835022783"
		ElseIf cmbICAO5.Text = "KOAK" Then
			txtPort2.Text = "Oakland, CA"
			txtLatRad1.Text = "0.658454549136"
			txtLongRad1.Text = "2.1331995894"
		ElseIf cmbICAO5.Text = "KPDK" Then
			txtPort2.Text = "Atlanta, GA"
			txtLatRad1.Text = "0.590648507696"
			txtLongRad1.Text = "1.4713416483"
		ElseIf cmbICAO5.Text = "KVRB" Then
			txtPort2.Text = "Vero Beach"
			txtLatRad1.Text = "0.482670804639"
			txtLongRad1.Text = "1.4035356068"
		ElseIf cmbICAO5.Text = "LCPH" Then
			txtPort2.Text = "Larnaca, Cyprus"
			txtLatRad1.Text = "0.608741754275"
			txtLongRad1.Text = "-0.586954227"
		ElseIf cmbICAO5.Text = "LEMD" Then
			txtPort2.Text = "Madrid"
			txtLatRad1.Text = "0.706392925924"
			txtLongRad1.Text = "-0.062133721"
		ElseIf cmbICAO5.Text = "LEMG" Then
			txtPort2.Text = "Malaga"
			txtLatRad1.Text = "0.640099503169"
			txtLongRad1.Text = "0.0784816387"
		ElseIf cmbICAO5.Text = "LFPN" Then
			txtPort2.Text = "Toussus Le Noble"
			txtLatRad1.Text = "0.850877099168"
			txtLongRad1.Text = "-0.036739181"
		ElseIf cmbICAO5.Text = "LGAT" Then
			txtPort2.Text = "Athens"
			txtLatRad1.Text = "0.661247075939"
			txtLongRad1.Text = "-0.414166631"
		ElseIf cmbICAO5.Text = "LGIR" Then
			txtPort2.Text = "Iraklion"
			txtLatRad1.Text = "0.616770268834"
			txtLongRad1.Text = "-0.439444817"
		ElseIf cmbICAO5.Text = "LIRA" Then
			txtPort2.Text = "Rome"
			txtLatRad1.Text = "0.729518538513"
			txtLongRad1.Text = "-0.219824219"
		ElseIf cmbICAO5.Text = "LKPR" Then
			txtPort2.Text = "Prague, Czech"
			txtLatRad1.Text = "0.874439044070"
			txtLongRad1.Text = "-0.248913040"
		ElseIf cmbICAO5.Text = "LPAZ" Then
			txtPort2.Text = "Santa Maria"
			txtLatRad1.Text = "0.645306402104"
			txtLongRad1.Text = "0.4393284615"
		ElseIf cmbICAO5.Text = "LPPR" Then
			txtPort2.Text = "Porto, Portugal"
			txtLatRad1.Text = "0.719657428239"
			txtLongRad1.Text = "0.1514364014"
		ElseIf cmbICAO5.Text = "LROP" Then
			txtPort2.Text = "Bucharest, Romania"
			txtLatRad1.Text = "0.777893247614"
			txtLongRad1.Text = "-0.455298224"
		ElseIf cmbICAO5.Text = "LTAC" Then
			txtPort2.Text = "Ankara"
			txtLatRad1.Text = "0.700313362363"
			txtLongRad1.Text = "-0.575842298"
		ElseIf cmbICAO5.Text = "LTBA" Then
			txtPort2.Text = "Istanbul, Turkey"
			txtLatRad1.Text = "0.715177749826"
			txtLongRad1.Text = "-0.502945713"
		ElseIf cmbICAO5.Text = "MROC" Then
			txtPort2.Text = "San Jose, CR"
			txtLatRad1.Text = "0.174416569916"
			txtLongRad1.Text = "1.4697708519"
		ElseIf cmbICAO5.Text = "NTSU" Then
			txtPort2.Text = "Pago Pago"
			txtLatRad1.Text = "0.250192948273"
			txtLongRad1.Text = "2.9794515661"
		ElseIf cmbICAO5.Text = "NZAA" Then
			txtPort2.Text = "Auckland"
			txtLatRad1.Text = "-0.64588817852"
			txtLongRad1.Text = "-3.050690088"
		ElseIf cmbICAO5.Text = "OOMS" Then
			txtPort2.Text = "SEEB, Oman"
			txtLatRad1.Text = "0.411781348187"
			txtLongRad1.Text = "-1.017148799"
		ElseIf cmbICAO5.Text = "OPKC" Then
			txtPort2.Text = "Karachi"
			txtLatRad1.Text = "0.434703339030"
			txtLongRad1.Text = "-1.172104948"
		ElseIf cmbICAO5.Text = "PAOM" Then
			txtPort2.Text = "Nome, AK"
			txtLatRad1.Text = "1.125970078103"
			txtLongRad1.Text = "2.8875308921"
		ElseIf cmbICAO5.Text = "PGSN" Then
			txtPort2.Text = "Saipan"
			txtLatRad1.Text = "0.263922871722"
			txtLongRad1.Text = "-2.543526497"
		ElseIf cmbICAO5.Text = "PHNL" Then
			txtPort2.Text = "Honolulu, HI"
			txtLatRad1.Text = "0.372075107704"
			txtLongRad1.Text = "2.7562821324"
		ElseIf cmbICAO5.Text = "PHTO" Then
			txtPort2.Text = "HILO"
			txtLatRad1.Text = "0.344237106135"
			txtLongRad1.Text = "2.7061620940"
		ElseIf cmbICAO5.Text = "PKMJ" Then
			txtPort2.Text = "Majuro"
			txtLatRad1.Text = "0.123249334012"
			txtLongRad1.Text = "-2.989312676"
		ElseIf cmbICAO5.Text = "PLCH" Then
			txtPort2.Text = "Christmas Island"
			txtLatRad1.Text = "0.034702963294"
			txtLongRad1.Text = "2.7463628445"
		ElseIf cmbICAO5.Text = "PMDY" Then
			txtPort2.Text = "Midway"
			txtLatRad1.Text = "0.492386470808"
			txtLongRad1.Text = "3.0958650272"
		ElseIf cmbICAO5.Text = "PTRO" Then
			txtPort2.Text = "Palau"
			txtLatRad1.Text = "0.128543499409"
			txtLongRad1.Text = "-2.348369597"
		ElseIf cmbICAO5.Text = "PWAK" Then
			txtPort2.Text = "WAKE"
			txtLatRad1.Text = "0.336499479785"
			txtLongRad1.Text = "-2.908445754"
		ElseIf cmbICAO5.Text = "RCTP" Then
			txtPort2.Text = "Chiang Kai Shek"
			txtLatRad1.Text = "0.437699487579"
			txtLongRad1.Text = "-2.115717208"
		ElseIf cmbICAO5.Text = "RJCK" Then
			txtPort2.Text = "Kushiro"
			txtLatRad1.Text = "0.751218798879"
			txtLongRad1.Text = "-2.516677515"
		ElseIf cmbICAO5.Text = "RJTT" Then
			txtPort2.Text = "Tokyo"
			txtLatRad1.Text = "0.620580904367"
			txtLongRad1.Text = "-2.437643189"
		ElseIf cmbICAO5.Text = "RKSS" Then
			txtPort2.Text = "Seoul, Korea"
			txtLatRad1.Text = "0.655429311766"
			txtLongRad1.Text = "-2.213077492"
		ElseIf cmbICAO5.Text = "RPMM" Then
			txtPort2.Text = "Manilla"
			txtLatRad1.Text = "0.253218185644"
			txtLongRad1.Text = "-2.112197461"
		ElseIf cmbICAO5.Text = "SAEZ" Then
			txtPort2.Text = "Ezeiza"
			txtLatRad1.Text = "-0.60772364554"
			txtLongRad1.Text = "1.0215993888"
		ElseIf cmbICAO5.Text = "SBEG" Then
			txtPort2.Text = "Manaus"
			txtLatRad1.Text = "-0.05305800926"
			txtLongRad1.Text = "1.0480120382"
		ElseIf cmbICAO5.Text = "SBGL" Then
			txtPort2.Text = "Rio De Janeiro, Brazil"
			txtLatRad1.Text = "-0.39810960238"
			txtLongRad1.Text = "0.7548549015"
		ElseIf cmbICAO5.Text = "SBSP" Then
			txtPort2.Text = "Sao Paulo"
			txtLatRad1.Text = "-0.41233403578"
			txtLongRad1.Text = "0.8143124513"
		ElseIf cmbICAO5.Text = "SCEL" Then
			txtPort2.Text = "Santiago, Chile"
			txtLatRad1.Text = "-0.58279452606"
			txtLongRad1.Text = "1.2354022222"
		ElseIf cmbICAO5.Text = "SVMG" Then
			txtPort2.Text = "Margarita, VE"
			txtLatRad1.Text = "0.190531776676"
			txtLongRad1.Text = "1.1163998560"
		ElseIf cmbICAO5.Text = "TTPP" Then
			txtPort2.Text = "Picaro"
			txtLatRad1.Text = "0.184888545428"
			txtLongRad1.Text = "1.0705558744"
		ElseIf cmbICAO5.Text = "UHHH" Then
			txtPort2.Text = "Khabarovsk, Russia"
			txtLatRad1.Text = "0.846950108351"
			txtLongRad1.Text = "-2.359452438"
		ElseIf cmbICAO5.Text = "UHMM" Then
			txtPort2.Text = "Magadan, Russia"
			txtLatRad1.Text = "1.045743110153"
			txtLongRad1.Text = "-2.630502071"
		ElseIf cmbICAO5.Text = "UHPP" Then
			txtPort2.Text = "Petropavlovsk, Russia"
			txtLatRad1.Text = "0.927933385644"
			txtLongRad1.Text = "-2.7654742"
		ElseIf cmbICAO5.Text = "UHSS" Then
			txtPort2.Text = "Yuzhno, Russia"
			txtLatRad1.Text = "0.700720605855"
			txtLongRad1.Text = "-2.490730287"
		ElseIf cmbICAO5.Text = "UTTT" Then
			txtPort2.Text = "Tashkent, Russia"
			txtLatRad1.Text = "0.719948316448"
			txtLongRad1.Text = "-1.209222283"
		ElseIf cmbICAO5.Text = "UUEE" Then
			txtPort2.Text = "Moscow, Russia"
			txtLatRad1.Text = "0.976889871162"
			txtLongRad1.Text = "-0.65301494"
		ElseIf cmbICAO5.Text = "VABB" Then
			txtPort2.Text = "Bombay"
			txtLatRad1.Text = "0.333212443027"
			txtLongRad1.Text = "-1.271763248"
		ElseIf cmbICAO5.Text = "VCBI" Then
			txtPort2.Text = "Columbo, Sri Lanka"
			txtLatRad1.Text = "0.125314640293"
			txtLongRad1.Text = "-1.394227184"
		ElseIf cmbICAO5.Text = "VIDP" Then
			txtPort2.Text = "Delhi"
			txtLatRad1.Text = "0.498582389653"
			txtLongRad1.Text = "-1.345648853"
		ElseIf cmbICAO5.Text = "VNKT" Then
			txtPort2.Text = "Katmandu, Nepal"
			txtLatRad1.Text = "0.485230620875"
			txtLongRad1.Text = "-1.489842138"
		ElseIf cmbICAO5.Text = "VOMM" Then
			txtPort2.Text = "Madras"
			txtLatRad1.Text = "0.226805536297"
			txtLongRad1.Text = "-1.399346817"
		ElseIf cmbICAO5.Text = "VOPB" Then
			txtPort2.Text = "Port Blair, Nicobar"
			txtLatRad1.Text = "0.203272680216"
			txtLongRad1.Text = "-1.618531082"
		ElseIf cmbICAO5.Text = "VRMM" Then
			txtPort2.Text = "Male, Maldives"
			txtLatRad1.Text = "0.073158384479"
			txtLongRad1.Text = "-1.283398777"
		ElseIf cmbICAO5.Text = "VTBD" Then
			txtPort2.Text = "Bangkok"
			txtLatRad1.Text = "0.242891654236"
			txtLongRad1.Text = "-1.755888494"
		ElseIf cmbICAO5.Text = "WMKJ" Then
			txtPort2.Text = "Johor Bahru, Malaysia"
			txtLatRad1.Text = "0.028594310912"
			txtLongRad1.Text = "-1.809411924"
		ElseIf cmbICAO5.Text = "WMKK" Then
			txtPort2.Text = "Kuala Lumpur"
			txtLatRad1.Text = "0.054628805587"
			txtLongRad1.Text = "-1.772410944"
		ElseIf cmbICAO5.Text = "WSSL" Then
			txtPort2.Text = "Singapore"
			txtLatRad1.Text = "0.024725497737"
			txtLongRad1.Text = "-1.812815316"
		ElseIf cmbICAO5.Text = "ZGGG" Then
			txtPort2.Text = "Guangzhou"
			txtLatRad1.Text = "0.404625498254"
			txtLongRad1.Text = "-1.976847177"
		ElseIf cmbICAO5.Text = "Other" Then
			'Call ICAO5Other
		End If

		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg2 As Double
		If cmbICAO5.Text <> "Other" Then

			Call CalcDist()

			txtLeg2.Text = txtDist.Text
			txtLeg2.Text = VB6.Format(txtLeg2.Text, "Fixed")
			intLeg = CDbl(txtLeg.Text)
			intLeg1 = CDbl(txtLeg1.Text)
			intLeg2 = CDbl(txtLeg2.Text)
			intTotal1 = intLeg + intLeg1 + intLeg2
			txtTotal2.Text = CStr(intTotal1)
			txtTotal2.Text = VB6.Format(txtTotal2.Text, "Fixed")

		Else
			Call ICAO5Other()
		End If

		If cmbICAO5.Text = "Other" Then
			cmbICAO5.Visible = False
			cmbICAO6.Visible = False
			txtICAO6.Text = txtICAO5.Text
			'cmbICAO5 = txtICAO5
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		Else
			cmbICAO6.Text = cmbICAO5.Text
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		End If

		cmbICAO7.Focus()

	End Sub

	<Obsolete>
	Private Sub ICAO5Other()

		txtICAO5.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtPort2.Text = InputBox("Enter Name of Airport.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
		txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
		txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
		txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
		intLatDeg = CDbl(txtLatDeg.Text)
		intLatMin = CDbl(txtLatMin.Text)
		intLatSec = CDbl(txtLatSec.Text)
		intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
		If txtNS.Text = "S" Then
			intLatRad = intLatRad * -1
		ElseIf txtNS.Text = "s" Then
			intLatRad = intLatRad * -1
		End If
		txtLatRad1.Text = CStr(intLatRad / (180 / 3.141592654))
		txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
		txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
		txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
		txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
		intLongDeg = CDbl(txtLongDeg.Text)
		intLongMin = CDbl(txtLongMin.Text)
		intLongSec = CDbl(txtLongSec.Text)
		intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
		If txtEW.Text = "E" Then
			intLongRad = intLongRad * -1
		ElseIf txtEW.Text = "e" Then
			intLongRad = intLongRad * -1
		End If
		txtLongRad1.Text = CStr(intLongRad / (180 / 3.141592654))
		cmbICAO5.Visible = False

		Call CalcDist()

		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg2 As Double
		txtLeg2.Text = txtDist.Text
		txtLeg2.Text = VB6.Format(txtLeg2.Text, "Fixed")
		intLeg = CDbl(txtLeg.Text)
		intLeg1 = CDbl(txtLeg1.Text)
		intLeg2 = CDbl(txtLeg2.Text)
		intTotal1 = intLeg + intLeg1 + intLeg2
		txtTotal2.Text = CStr(intTotal1)
		txtTotal2.Text = VB6.Format(txtTotal2.Text, "Fixed")

		strICAO = txtICAO5.Text
		strPort = txtPort2.Text
		strLatRad = txtLatRad1.Text
		strLongRad = txtLongRad1.Text
		FileOpen(1, "Bid ICAO.txt", OpenMode.Append)
		WriteLine(1, strICAO, strPort, strLatRad, strLongRad)
		FileClose(1)

		intLatDeg = 0
		intLatMin = 0
		intLatSec = 0
		intLatRad = 0
		intLongDeg = 0
		intLongMin = 0
		intLongSec = 0
		intLongRad = 0

	End Sub

	'UPGRADE_WARNING: Event cmbICAO6.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cmbICAO6_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO6.SelectedIndexChanged

		If cmbICAO6.Text = "ASSY" Then
			'txtPort.Text = "Sidney"
			txtLatRad.Text = "-0.592248392843409"
			txtLongRad.Text = "-2.63835605259809"
		ElseIf cmbICAO6.Text = "AYPY" Then
			'txtPort.Text = "Port Moresby, PNG"
			txtLatRad.Text = "-0.164817259029998"
			txtLongRad.Text = "-2.56941554714432"
		ElseIf cmbICAO6.Text = "BGBW" Then
			'txtPort.Text = "Narsarsuaq"
			txtLatRad.Text = "1.0674724593406"
			txtLongRad.Text = "0.792873990360157"
		ElseIf cmbICAO6.Text = "BGGH" Then
			'txtPort.Text = "Godthab"
			txtLatRad.Text = "1.12035593567603"
			txtLongRad.Text = "0.902044335072403"
		ElseIf cmbICAO6.Text = "BIRK" Then
			'txtPort.Text = "Reykjavik"
			txtLatRad.Text = "1.1192505604831"
			txtLongRad.Text = "0.382983415529289"
		ElseIf cmbICAO6.Text = "CYAM" Then
			'txtPort.Text = "Sault Ste. Marie"
			txtLatRad.Text = "0.811316302789564"
			txtLongRad.Text = "1.47497775086041"
		ElseIf cmbICAO6.Text = "CYFB" Then
			'txtPort.Text = "Iqaluit"
			txtLatRad.Text = "1.11276375342985"
			txtLongRad.Text = "1.19653955752558"
		ElseIf cmbICAO6.Text = "CYQX" Then
			'txtPort.Text = "Gander"
			txtLatRad.Text = "0.854164135926025"
			txtLongRad.Text = "0.952426172813306"
		ElseIf cmbICAO6.Text = "CYYQ" Then
			'txtPort.Text = "Churchill Falls"
			txtLatRad.Text = "1.02520640262147"
			txtLongRad.Text = "1.64177304970933"
		ElseIf cmbICAO6.Text = "CYYR" Then
			'txtPort.Text = "Goose Bay"
			txtLatRad.Text = "0.930609557163376"
			txtLongRad.Text = "1.05464428933844"
		ElseIf cmbICAO6.Text = "CYYT" Then
			'txtPort.Text = "St John's, NFLD"
			txtLatRad.Text = "0.831096700978833"
			txtLongRad.Text = "0.920690269247875"
		ElseIf cmbICAO6.Text = "DAAG" Then
			'txtPort.Text = "Algiers, Algeria"
			txtLatRad.Text = "0.640419480198453"
			txtLongRad.Text = "-0.0561705130933508"
		ElseIf cmbICAO6.Text = "DIAP" Then
			'txtPort.Text = "Abidjan"
			txtLatRad.Text = "0.0916588745505689"
			txtLongRad.Text = "0.0685623507825106"
		ElseIf cmbICAO6.Text = "DNMM" Then
			'txtPort.Text = "Lagos, Nigeria"
			txtLatRad.Text = "0.114755398318627"
			txtLongRad.Text = "-0.0579158423453452"
		ElseIf cmbICAO6.Text = "DRRN" Then
			'txtPort.Text = "Niami, Niger"
			txtLatRad.Text = "0.235299471989702"
			txtLongRad.Text = "-0.0379318224100101"
		ElseIf cmbICAO6.Text = "EBBR" Then
			'txtPort.Text = "Brussels"
			txtLatRad.Text = "0.88840167808598"
			txtLongRad.Text = "-0.0785107275188782"
		ElseIf cmbICAO6.Text = "EDDW" Then
			'txtPort.Text = "Bremen, Germany"
			txtLatRad.Text = "0.925868079362125"
			txtLongRad.Text = "-0.153385352429435"
		ElseIf cmbICAO6.Text = "EFHK" Then
			'txtPort.Text = "Helsinki, Finland"
			txtLatRad.Text = "1.05272442716125"
			txtLongRad.Text = "-0.435750536581251"
		ElseIf cmbICAO6.Text = "EGPD" Then
			'txtPort.Text = "Aberdeen"
			txtLatRad.Text = "0.998415598603356"
			txtLongRad.Text = "0.0383681547230087"
		ElseIf cmbICAO6.Text = "EGPK" Then
			'txtPort.Text = "Prestwick"
			txtLatRad.Text = "0.968686823677719"
			txtLongRad.Text = "0.0798779020996071"
		ElseIf cmbICAO6.Text = "EHBK" Then
			'txtPort.Text = "Maastricht, Netherlands"
			txtLatRad.Text = "0.888663477473779"
			txtLongRad.Text = "-0.100821853123539"
		ElseIf cmbICAO6.Text = "EINN" Then
			'txtPort.Text = "Shannon"
			txtLatRad.Text = "0.919788515801012"
			txtLongRad.Text = "0.155741546919627"
		ElseIf cmbICAO6.Text = "EKCH" Then
			txtPort.Text = "Copenhagen"
			txtLatRad.Text = "0.97054850821318"
			txtLongRad.Text = "-0.220493262168617"
		ElseIf cmbICAO6.Text = "ELLX" Then
			'txtPort.Text = "Luxembourg"
			txtLatRad.Text = "0.86609055248132"
			txtLongRad.Text = "-0.108297680086248"
		ElseIf cmbICAO6.Text = "ENBR" Then
			'txtPort.Text = "Bergen, Norway"
			txtLatRad.Text = "1.05231718366911"
			txtLongRad.Text = "-0.091106186954104"
		ElseIf cmbICAO6.Text = "FAGM" Then
			'txtPort.Text = "Rand"
			txtLatRad.Text = "-0.458003484544179"
			txtLongRad.Text = "-0.49133927325727"
		ElseIf cmbICAO6.Text = "FALA" Then
			'txtPort.Text = "Lanseria, RSA"
			txtLatRad.Text = "-0.452622052683863"
			txtLongRad.Text = "-0.48735410479855"
		ElseIf cmbICAO6.Text = "FAWM" Then
			'txtPort.Text = "Windhoek"
			txtLatRad.Text = "-0.392379104669192"
			txtLongRad.Text = "-0.304967197965142"
		ElseIf cmbICAO6.Text = "FCBB" Then
			'txtPort.Text = "Brazzaville, Congo"
			txtLatRad.Text = "-0.0742928484932253"
			txtLongRad.Text = "-0.266162710929135"
		ElseIf cmbICAO6.Text = "FEFF" Then
			'txtPort.Text = "Bangui, CAE"
			txtLatRad.Text = "0.0767653982668839"
			txtLongRad.Text = "-0.323264066290216"
		ElseIf cmbICAO6.Text = "FMMI" Then
			'txtPort.Text = "Antananarivo, Madagascar"
			txtLatRad.Text = "-0.328063721733201"
			txtLongRad.Text = "-0.828624151205175"
		ElseIf cmbICAO6.Text = "FNLU" Then
			'txtPort.Text = "Luanda"
			txtLatRad.Text = "-0.154548905264098"
			txtLongRad.Text = "-0.231023415322316"
		ElseIf cmbICAO6.Text = "FOOL" Then
			'txtPort.Text = "Libreville"
			txtLatRad.Text = "-0.00799942573830734"
			txtLongRad.Text = "-0.164322749075266"
		ElseIf cmbICAO6.Text = "FSIA" Then
			'txtPort.Text = "Seychelles Intl"
			txtLatRad.Text = "-0.0815359648890018"
			txtLongRad.Text = "-0.969064978348985"
		ElseIf cmbICAO6.Text = "FVHA" Then
			'txtPort.Text = "Harare, Zimbabwe"
			txtLatRad.Text = "-0.31296662370345"
			txtLongRad.Text = "-0.54268104208677"
		ElseIf cmbICAO6.Text = "FZNA" Then
			'txtPort.Text = "Goma, Zaire"
			txtLatRad.Text = "-0.0290888208665722"
			txtLongRad.Text = "-0.510217917999676"
		ElseIf cmbICAO6.Text = "GBYD" Then
			'txtPort.Text = "Banjul"
			txtLatRad.Text = "0.23285601103691"
			txtLongRad.Text = "0.290742764561389"
		ElseIf cmbICAO6.Text = "GCXO" Then
			'txtPort.Text = "Tenerife"
			txtLatRad.Text = "0.497157037431"
			txtLongRad.Text = "0.2851867998"
		ElseIf cmbICAO6.Text = "GMAA" Then
			'txtPort.Text = "Agadir"
			txtLatRad.Text = "0.530260115577"
			txtLongRad.Text = "0.1667080324"
		ElseIf cmbICAO6.Text = "GOOY" Then
			'txtPort.Text = "Dakar"
			txtLatRad.Text = "0.257290620565"
			txtLongRad.Text = "0.3052580862"
		ElseIf cmbICAO6.Text = "HELX" Then
			'txtPort.Text = "Luxor"
			txtLatRad.Text = "0.447967841345"
			txtLongRad.Text = "-0.570722665"
		ElseIf cmbICAO6.Text = "HKNW" Then
			'txtPort.Text = "Nairobi-Wilson"
			txtLatRad.Text = "-0.02298016848"
			txtLongRad.Text = "-0.642572053"
		ElseIf cmbICAO6.Text = "HSSS" Then
			'txtPort.Text = "Khartoum"
			txtLatRad.Text = "0.272271363311"
			txtLongRad.Text = "-0.568250116"
		ElseIf cmbICAO6.Text = "HTDA" Then
			'txtPort.Text = "Dar-Es-Salaam"
			txtLatRad.Text = "-0.11999138607"
			txtLongRad.Text = "-0.684198156"
		ElseIf cmbICAO6.Text = "I69" Then
			'txtPort.Text = "Batavia, OH"
			txtLatRad.Text = "0.682045582859"
			txtLongRad.Text = "1.4697417631"
		ElseIf cmbICAO6.Text = "KANC" Then
			'txtPort.Text = "Anchorage"
			txtLatRad.Text = "1.067292108651"
			txtLongRad.Text = "2.6215601674"
		ElseIf cmbICAO6.Text = "KBGR" Then
			'txtPort.Text = "Bangor"
			txtLatRad.Text = "0.782052948998"
			txtLongRad.Text = "1.2012810353"
		ElseIf cmbICAO6.Text = "KBOI" Then
			'txtPort.Text = "Boise"
			txtLatRad.Text = "0.760352688631"
			txtLongRad.Text = "2.0285089231"
		ElseIf cmbICAO6.Text = "KCAE" Then
			'txtPort.Text = "Columbia, SC"
			txtLatRad.Text = "0.592364748127"
			txtLongRad.Text = "1.4158110892"
		ElseIf cmbICAO6.Text = "KEWK" Then
			'txtPort.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO6.Text = "KICT" Then
			'txtPort.Text = "Wichita, KS"
			txtLatRad.Text = "0.657116463376"
			txtLongRad.Text = "1.7005324679"
		ElseIf cmbICAO6.Text = "KIDP" Then
			'txtPort.Text = "Independence, KS"
			txtLatRad.Text = "0.648535261220"
			txtLongRad.Text = "1.6716472687"
		ElseIf cmbICAO6.Text = "KJNU" Then
			'txtPort.Text = "Juneau, AK"
			txtLatRad.Text = "1.018545062643"
			txtLongRad.Text = "2.3488738036"
		ElseIf cmbICAO6.Text = "KMIA" Then
			'txtPort.Text = "Miami, FL"
			txtLatRad.Text = "0.450178591731"
			txtLongRad.Text = "1.4013248564"
		ElseIf cmbICAO6.Text = "KMSP" Then
			'txtPort.Text = "Minneapolis, MN"
			txtLatRad.Text = "0.783391034758"
			txtLongRad.Text = "1.6269086622"
		ElseIf cmbICAO6.Text = "KNUD" Then
			'txtPort.Text = "ADAK, AK"
			txtLatRad.Text = "0.905348825123"
			txtLongRad.Text = "3.0835022783"
		ElseIf cmbICAO6.Text = "KOAK" Then
			'txtPort.Text = "Oakland, CA"
			txtLatRad.Text = "0.658454549136"
			txtLongRad.Text = "2.1331995894"
		ElseIf cmbICAO6.Text = "KPDK" Then
			'txtPort.Text = "Atlanta, GA"
			txtLatRad.Text = "0.590648507696"
			txtLongRad.Text = "1.4713416483"
		ElseIf cmbICAO6.Text = "KVRB" Then
			'txtPort.Text = "Vero Beach"
			txtLatRad.Text = "0.482670804639"
			txtLongRad.Text = "1.4035356068"
		ElseIf cmbICAO6.Text = "LCPH" Then
			'txtPort.Text = "Larnaca, Cyprus"
			txtLatRad.Text = "0.608741754275"
			txtLongRad.Text = "-0.586954227"
		ElseIf cmbICAO6.Text = "LEMD" Then
			'txtPort.Text = "Madrid"
			txtLatRad.Text = "0.706392925924"
			txtLongRad.Text = "-0.062133721"
		ElseIf cmbICAO6.Text = "LEMG" Then
			'txtPort.Text = "Malaga"
			txtLatRad.Text = "0.640099503169"
			txtLongRad.Text = "0.0784816387"
		ElseIf cmbICAO6.Text = "LFPN" Then
			'txtPort.Text = "Toussus Le Noble"
			txtLatRad.Text = "0.850877099168"
			txtLongRad.Text = "-0.036739181"
		ElseIf cmbICAO6.Text = "LGAT" Then
			'txtPort.Text = "Athens"
			txtLatRad.Text = "0.661247075939"
			txtLongRad.Text = "-0.414166631"
		ElseIf cmbICAO6.Text = "LGIR" Then
			'txtPort.Text = "Iraklion"
			txtLatRad.Text = "0.616770268834"
			txtLongRad.Text = "-0.439444817"
		ElseIf cmbICAO6.Text = "LIRA" Then
			'txtPort.Text = "Rome"
			txtLatRad.Text = "0.729518538513"
			txtLongRad.Text = "-0.219824219"
		ElseIf cmbICAO6.Text = "LKPR" Then
			'txtPort.Text = "Prague, Czech"
			txtLatRad.Text = "0.874439044070"
			txtLongRad.Text = "-0.248913040"
		ElseIf cmbICAO6.Text = "LPAZ" Then
			'txtPort.Text = "Santa Maria"
			txtLatRad.Text = "0.645306402104"
			txtLongRad.Text = "0.4393284615"
		ElseIf cmbICAO6.Text = "LPPR" Then
			'txtPort.Text = "Porto, Portugal"
			txtLatRad.Text = "0.719657428239"
			txtLongRad.Text = "0.1514364014"
		ElseIf cmbICAO6.Text = "LROP" Then
			'txtPort.Text = "Bucharest, Romania"
			txtLatRad.Text = "0.777893247614"
			txtLongRad.Text = "-0.455298224"
		ElseIf cmbICAO6.Text = "LTAC" Then
			'txtPort.Text = "Ankara"
			txtLatRad.Text = "0.700313362363"
			txtLongRad.Text = "-0.575842298"
		ElseIf cmbICAO6.Text = "LTBA" Then
			'txtPort.Text = "Istanbul, Turkey"
			txtLatRad.Text = "0.715177749826"
			txtLongRad.Text = "-0.502945713"
		ElseIf cmbICAO6.Text = "MROC" Then
			'txtPort.Text = "San Jose, CR"
			txtLatRad.Text = "0.174416569916"
			txtLongRad.Text = "1.4697708519"
		ElseIf cmbICAO6.Text = "NTSU" Then
			'txtPort.Text = "Pago Pago"
			txtLatRad.Text = "0.250192948273"
			txtLongRad.Text = "2.9794515661"
		ElseIf cmbICAO6.Text = "NZAA" Then
			'txtPort.Text = "Auckland"
			txtLatRad.Text = "-0.64588817852"
			txtLongRad.Text = "-3.050690088"
		ElseIf cmbICAO6.Text = "OOMS" Then
			'txtPort.Text = "SEEB, Oman"
			txtLatRad.Text = "0.411781348187"
			txtLongRad.Text = "-1.017148799"
		ElseIf cmbICAO6.Text = "OPKC" Then
			'txtPort.Text = "Karachi"
			txtLatRad.Text = "0.434703339030"
			txtLongRad.Text = "-1.172104948"
		ElseIf cmbICAO6.Text = "PAOM" Then
			'txtPort.Text = "Nome, AK"
			txtLatRad.Text = "1.125970078103"
			txtLongRad.Text = "2.8875308921"
		ElseIf cmbICAO6.Text = "PGSN" Then
			'txtPort.Text = "Saipan"
			txtLatRad.Text = "0.263922871722"
			txtLongRad.Text = "-2.543526497"
		ElseIf cmbICAO6.Text = "PHNL" Then
			'txtPort.Text = "Honolulu, HI"
			txtLatRad.Text = "0.372075107704"
			txtLongRad.Text = "2.7562821324"
		ElseIf cmbICAO6.Text = "PHTO" Then
			'txtPort.Text = "HILO"
			txtLatRad.Text = "0.344237106135"
			txtLongRad.Text = "2.7061620940"
		ElseIf cmbICAO6.Text = "PKMJ" Then
			'txtPort.Text = "Majuro"
			txtLatRad.Text = "0.123249334012"
			txtLongRad.Text = "-2.989312676"
		ElseIf cmbICAO6.Text = "PLCH" Then
			'txtPort.Text = "Christmas Island"
			txtLatRad.Text = "0.034702963294"
			txtLongRad.Text = "2.7463628445"
		ElseIf cmbICAO6.Text = "PMDY" Then
			'txtPort.Text = "Midway"
			txtLatRad.Text = "0.492386470808"
			txtLongRad.Text = "3.0958650272"
		ElseIf cmbICAO6.Text = "PTRO" Then
			'txtPort.Text = "Palau"
			txtLatRad.Text = "0.128543499409"
			txtLongRad.Text = "-2.348369597"
		ElseIf cmbICAO6.Text = "PWAK" Then
			'txtPort.Text = "WAKE"
			txtLatRad.Text = "0.336499479785"
			txtLongRad.Text = "-2.908445754"
		ElseIf cmbICAO6.Text = "RCTP" Then
			'txtPort.Text = "Chiang Kai Shek"
			txtLatRad.Text = "0.437699487579"
			txtLongRad.Text = "-2.115717208"
		ElseIf cmbICAO6.Text = "RJCK" Then
			'txtPort.Text = "Kushiro"
			txtLatRad.Text = "0.751218798879"
			txtLongRad.Text = "-2.516677515"
		ElseIf cmbICAO6.Text = "RJTT" Then
			'txtPort.Text = "Tokyo"
			txtLatRad.Text = "0.620580904367"
			txtLongRad.Text = "-2.437643189"
		ElseIf cmbICAO6.Text = "RKSS" Then
			'txtPort.Text = "Seoul, Korea"
			txtLatRad.Text = "0.655429311766"
			txtLongRad.Text = "-2.213077492"
		ElseIf cmbICAO6.Text = "RPMM" Then
			'txtPort.Text = "Manilla"
			txtLatRad.Text = "0.253218185644"
			txtLongRad.Text = "-2.112197461"
		ElseIf cmbICAO6.Text = "SAEZ" Then
			'txtPort.Text = "Ezeiza"
			txtLatRad.Text = "-0.60772364554"
			txtLongRad.Text = "1.0215993888"
		ElseIf cmbICAO6.Text = "SBEG" Then
			'txtPort.Text = "Manaus"
			txtLatRad.Text = "-0.05305800926"
			txtLongRad.Text = "1.0480120382"
		ElseIf cmbICAO6.Text = "SBGL" Then
			'txtPort.Text = "Rio De Janeiro, Brazil"
			txtLatRad.Text = "-0.39810960238"
			txtLongRad.Text = "0.7548549015"
		ElseIf cmbICAO6.Text = "SBSP" Then
			'txtPort.Text = "Sao Paulo"
			txtLatRad.Text = "-0.41233403578"
			txtLongRad.Text = "0.8143124513"
		ElseIf cmbICAO6.Text = "SCEL" Then
			'txtPort.Text = "Santiago, Chile"
			txtLatRad.Text = "-0.58279452606"
			txtLongRad.Text = "1.2354022222"
		ElseIf cmbICAO6.Text = "SVMG" Then
			'txtPort.Text = "Margarita, VE"
			txtLatRad.Text = "0.190531776676"
			txtLongRad.Text = "1.1163998560"
		ElseIf cmbICAO6.Text = "TTPP" Then
			'txtPort.Text = "Picaro"
			txtLatRad.Text = "0.184888545428"
			txtLongRad.Text = "1.0705558744"
		ElseIf cmbICAO6.Text = "UHHH" Then
			'txtPort.Text = "Khabarovsk, Russia"
			txtLatRad.Text = "0.846950108351"
			txtLongRad.Text = "-2.359452438"
		ElseIf cmbICAO6.Text = "UHMM" Then
			'txtPort.Text = "Magadan, Russia"
			txtLatRad.Text = "1.045743110153"
			txtLongRad.Text = "-2.630502071"
		ElseIf cmbICAO6.Text = "UHPP" Then
			'txtPort.Text = "Petropavlovsk, Russia"
			txtLatRad.Text = "0.927933385644"
			txtLongRad.Text = "-2.7654742"
		ElseIf cmbICAO6.Text = "UHSS" Then
			'txtPort.Text = "Yuzhno, Russia"
			txtLatRad.Text = "0.700720605855"
			txtLongRad.Text = "-2.490730287"
		ElseIf cmbICAO6.Text = "UTTT" Then
			'txtPort.Text = "Tashkent, Russia"
			txtLatRad.Text = "0.719948316448"
			txtLongRad.Text = "-1.209222283"
		ElseIf cmbICAO6.Text = "UUEE" Then
			'txtPort.Text = "Moscow, Russia"
			txtLatRad.Text = "0.976889871162"
			txtLongRad.Text = "-0.65301494"
		ElseIf cmbICAO6.Text = "VABB" Then
			'txtPort.Text = "Bombay"
			txtLatRad.Text = "0.333212443027"
			txtLongRad.Text = "-1.271763248"
		ElseIf cmbICAO6.Text = "VCBI" Then
			'txtPort.Text = "Columbo, Sri Lanka"
			txtLatRad.Text = "0.125314640293"
			txtLongRad.Text = "-1.394227184"
		ElseIf cmbICAO6.Text = "VIDP" Then
			'txtPort.Text = "Delhi"
			txtLatRad.Text = "0.498582389653"
			txtLongRad.Text = "-1.345648853"
		ElseIf cmbICAO6.Text = "VNKT" Then
			'txtPort.Text = "Katmandu, Nepal"
			txtLatRad.Text = "0.485230620875"
			txtLongRad.Text = "-1.489842138"
		ElseIf cmbICAO6.Text = "VOMM" Then
			'txtPort.Text = "Madras"
			txtLatRad.Text = "0.226805536297"
			txtLongRad.Text = "-1.399346817"
		ElseIf cmbICAO6.Text = "VOPB" Then
			'txtPort.Text = "Port Blair, Nicobar"
			txtLatRad.Text = "0.203272680216"
			txtLongRad.Text = "-1.618531082"
		ElseIf cmbICAO6.Text = "VRMM" Then
			'txtPort.Text = "Male, Maldives"
			txtLatRad.Text = "0.073158384479"
			txtLongRad.Text = "-1.283398777"
		ElseIf cmbICAO6.Text = "VTBD" Then
			'txtPort.Text = "Bangkok"
			txtLatRad.Text = "0.242891654236"
			txtLongRad.Text = "-1.755888494"
		ElseIf cmbICAO6.Text = "WMKJ" Then
			'txtPort.Text = "Johor Bahru, Malaysia"
			txtLatRad.Text = "0.028594310912"
			txtLongRad.Text = "-1.809411924"
		ElseIf cmbICAO6.Text = "WMKK" Then
			'txtPort.Text = "Kuala Lumpur"
			txtLatRad.Text = "0.054628805587"
			txtLongRad.Text = "-1.772410944"
		ElseIf cmbICAO6.Text = "WSSL" Then
			'txtPort.Text = "Singapore"
			txtLatRad.Text = "0.024725497737"
			txtLongRad.Text = "-1.812815316"
		ElseIf cmbICAO6.Text = "ZGGG" Then
			'txtPort.Text = "Guangzhou"
			txtLatRad.Text = "0.404625498254"
			txtLongRad.Text = "-1.976847177"
		ElseIf cmbICAO6.Text = "Other" Then
			txtICAO6.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
			txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
			txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
			txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
			txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
			intLatDeg = CDbl(txtLatDeg.Text)
			intLatMin = CDbl(txtLatMin.Text)
			intLatSec = CDbl(txtLatSec.Text)
			intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
			If txtNS.Text = "S" Then
				intLatRad = intLatRad * -1
			ElseIf txtNS.Text = "s" Then
				intLatRad = intLatRad * -1
			End If
			txtLatRad.Text = CStr(intLatRad / (180 / 3.141592654))
			txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
			txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
			txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
			txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
			intLongDeg = CDbl(txtLongDeg.Text)
			intLongMin = CDbl(txtLongMin.Text)
			intLongSec = CDbl(txtLongSec.Text)
			intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
			If txtEW.Text = "E" Then
				intLongRad = intLongRad * -1
			ElseIf txtEW.Text = "e" Then
				intLongRad = intLongRad * -1
			End If
			txtLongRad.Text = CStr(intLongRad / (180 / 3.141592654))
			cmbICAO6.Visible = False
			'cmbICAO6 = txtICAO6
			cmbICAO7.Focus()
		End If

	End Sub

	'UPGRADE_WARNING: Event cmbICAO7.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	<Obsolete>
	Private Sub cmbICAO7_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO7.SelectedIndexChanged

		If cmbICAO8.Text <> "" Then
			cmbICAO8.Text = ""
			cmbICAO9.Text = ""
			cmbICAO10.Text = ""
			cmbICAO11.Text = ""
			cmbICAO12.Text = ""
			cmbICAO13.Text = ""
			cmbICAO14.Text = ""
			cmbICAO15.Text = ""
			txtPort4.Text = ""
			txtPort5.Text = ""
			txtPort6.Text = ""
			txtPort7.Text = ""
			txtLeg4.Text = ""
			txtLeg5.Text = ""
			txtLeg6.Text = ""
			txtLeg7.Text = ""
			txtTotal4.Text = ""
			txtTotal5.Text = ""
			txtTotal6.Text = ""
			txtTotal7.Text = ""

			Call cmbICAO6_SelectedIndexChanged(cmbICAO6, New System.EventArgs())

		End If

		If cmbICAO7.Text = cmbICAO6.Text Then
			Call MsgBox("Please re-enter destination, not equal to origination.", MsgBoxStyle.OKOnly, "Re-enter Destination")
			cmbICAO7.Text = ""
			cmbICAO7.Focus()
			Exit Sub
		ElseIf cmbICAO7.Text = "ASSY" Then
			txtPort3.Text = "Sidney"
			txtLatRad1.Text = "-0.592248392843409"
			txtLongRad1.Text = "-2.63835605259809"
		ElseIf cmbICAO7.Text = "AYPY" Then
			txtPort3.Text = "Port Moresby, PNG"
			txtLatRad1.Text = "-0.164817259029998"
			txtLongRad1.Text = "-2.56941554714432"
		ElseIf cmbICAO7.Text = "BGBW" Then
			txtPort3.Text = "Narsarsuaq"
			txtLatRad1.Text = "1.0674724593406"
			txtLongRad1.Text = "0.792873990360157"
		ElseIf cmbICAO7.Text = "BGGH" Then
			txtPort3.Text = "Godthab"
			txtLatRad1.Text = "1.12035593567603"
			txtLongRad1.Text = "0.902044335072403"
		ElseIf cmbICAO7.Text = "BIRK" Then
			txtPort3.Text = "Reykjavik"
			txtLatRad1.Text = "1.1192505604831"
			txtLongRad1.Text = "0.382983415529289"
		ElseIf cmbICAO7.Text = "CYAM" Then
			txtPort3.Text = "Sault Ste. Marie"
			txtLatRad1.Text = "0.811316302789564"
			txtLongRad1.Text = "1.47497775086041"
		ElseIf cmbICAO7.Text = "CYFB" Then
			txtPort3.Text = "Iqaluit"
			txtLatRad1.Text = "1.11276375342985"
			txtLongRad1.Text = "1.19653955752558"
		ElseIf cmbICAO7.Text = "CYQX" Then
			txtPort3.Text = "Gander"
			txtLatRad1.Text = "0.854164135926025"
			txtLongRad1.Text = "0.952426172813306"
		ElseIf cmbICAO7.Text = "CYYQ" Then
			txtPort3.Text = "Churchill Falls"
			txtLatRad1.Text = "1.02520640262147"
			txtLongRad1.Text = "1.64177304970933"
		ElseIf cmbICAO7.Text = "CYYR" Then
			txtPort3.Text = "Goose Bay"
			txtLatRad1.Text = "0.930609557163376"
			txtLongRad1.Text = "1.05464428933844"
		ElseIf cmbICAO7.Text = "CYYT" Then
			txtPort3.Text = "St John's, NFLD"
			txtLatRad1.Text = "0.831096700978833"
			txtLongRad1.Text = "0.920690269247875"
		ElseIf cmbICAO7.Text = "DAAG" Then
			txtPort3.Text = "Algiers, Algeria"
			txtLatRad1.Text = "0.640419480198453"
			txtLongRad1.Text = "-0.0561705130933508"
		ElseIf cmbICAO7.Text = "DIAP" Then
			txtPort3.Text = "Abidjan"
			txtLatRad1.Text = "0.0916588745505689"
			txtLongRad1.Text = "0.0685623507825106"
		ElseIf cmbICAO7.Text = "DNMM" Then
			txtPort3.Text = "Lagos, Nigeria"
			txtLatRad1.Text = "0.114755398318627"
			txtLongRad1.Text = "-0.0579158423453452"
		ElseIf cmbICAO7.Text = "DRRN" Then
			txtPort3.Text = "Niami, Niger"
			txtLatRad1.Text = "0.235299471989702"
			txtLongRad1.Text = "-0.0379318224100101"
		ElseIf cmbICAO7.Text = "EBBR" Then
			txtPort3.Text = "Brussels"
			txtLatRad1.Text = "0.88840167808598"
			txtLongRad1.Text = "-0.0785107275188782"
		ElseIf cmbICAO7.Text = "EDDW" Then
			txtPort3.Text = "Bremen, Germany"
			txtLatRad1.Text = "0.925868079362125"
			txtLongRad1.Text = "-0.153385352429435"
		ElseIf cmbICAO7.Text = "EFHK" Then
			txtPort3.Text = "Helsinki, Finland"
			txtLatRad1.Text = "1.05272442716125"
			txtLongRad1.Text = "-0.435750536581251"
		ElseIf cmbICAO7.Text = "EGPD" Then
			txtPort3.Text = "Aberdeen"
			txtLatRad1.Text = "0.998415598603356"
			txtLongRad1.Text = "0.0383681547230087"
		ElseIf cmbICAO7.Text = "EGPK" Then
			txtPort3.Text = "Prestwick"
			txtLatRad1.Text = "0.968686823677719"
			txtLongRad1.Text = "0.0798779020996071"
		ElseIf cmbICAO7.Text = "EHBK" Then
			txtPort3.Text = "Maastricht, Netherlands"
			txtLatRad1.Text = "0.888663477473779"
			txtLongRad1.Text = "-0.100821853123539"
		ElseIf cmbICAO7.Text = "EINN" Then
			txtPort3.Text = "Shannon"
			txtLatRad1.Text = "0.919788515801012"
			txtLongRad1.Text = "0.155741546919627"
		ElseIf cmbICAO7.Text = "EKCH" Then
			txtPort3.Text = "Copenhagen"
			txtLatRad1.Text = "0.97054850821318"
			txtLongRad1.Text = "-0.220493262168617"
		ElseIf cmbICAO7.Text = "ELLX" Then
			txtPort3.Text = "Luxembourg"
			txtLatRad1.Text = "0.86609055248132"
			txtLongRad1.Text = "-0.108297680086248"
		ElseIf cmbICAO7.Text = "ENBR" Then
			txtPort3.Text = "Bergen, Norway"
			txtLatRad1.Text = "1.05231718366911"
			txtLongRad1.Text = "-0.091106186954104"
		ElseIf cmbICAO7.Text = "FAGM" Then
			txtPort3.Text = "Rand"
			txtLatRad1.Text = "-0.458003484544179"
			txtLongRad1.Text = "-0.49133927325727"
		ElseIf cmbICAO7.Text = "FALA" Then
			txtPort3.Text = "Lanseria, RSA"
			txtLatRad1.Text = "-0.452622052683863"
			txtLongRad1.Text = "-0.48735410479855"
		ElseIf cmbICAO7.Text = "FAWM" Then
			txtPort3.Text = "Windhoek"
			txtLatRad1.Text = "-0.392379104669192"
			txtLongRad1.Text = "-0.304967197965142"
		ElseIf cmbICAO7.Text = "FCBB" Then
			txtPort3.Text = "Brazzaville, Congo"
			txtLatRad1.Text = "-0.0742928484932253"
			txtLongRad1.Text = "-0.266162710929135"
		ElseIf cmbICAO7.Text = "FEFF" Then
			txtPort3.Text = "Bangui, CAE"
			txtLatRad1.Text = "0.0767653982668839"
			txtLongRad1.Text = "-0.323264066290216"
		ElseIf cmbICAO7.Text = "FMMI" Then
			txtPort3.Text = "Antananarivo, Madagascar"
			txtLatRad1.Text = "-0.328063721733201"
			txtLongRad1.Text = "-0.828624151205175"
		ElseIf cmbICAO7.Text = "FNLU" Then
			txtPort3.Text = "Luanda"
			txtLatRad1.Text = "-0.154548905264098"
			txtLongRad1.Text = "-0.231023415322316"
		ElseIf cmbICAO7.Text = "FOOL" Then
			txtPort3.Text = "Libreville"
			txtLatRad1.Text = "-0.00799942573830734"
			txtLongRad1.Text = "-0.164322749075266"
		ElseIf cmbICAO7.Text = "FSIA" Then
			txtPort3.Text = "Seychelles Intl"
			txtLatRad1.Text = "-0.0815359648890018"
			txtLongRad1.Text = "-0.969064978348985"
		ElseIf cmbICAO7.Text = "FVHA" Then
			txtPort3.Text = "Harare, Zimbabwe"
			txtLatRad1.Text = "-0.31296662370345"
			txtLongRad1.Text = "-0.54268104208677"
		ElseIf cmbICAO7.Text = "FZNA" Then
			txtPort3.Text = "Goma, Zaire"
			txtLatRad1.Text = "-0.0290888208665722"
			txtLongRad1.Text = "-0.510217917999676"
		ElseIf cmbICAO7.Text = "GBYD" Then
			txtPort3.Text = "Banjul"
			txtLatRad1.Text = "0.23285601103691"
			txtLongRad1.Text = "0.290742764561389"
		ElseIf cmbICAO7.Text = "GCXO" Then
			txtPort3.Text = "Tenerife"
			txtLatRad1.Text = "0.497157037431"
			txtLongRad1.Text = "0.2851867998"
		ElseIf cmbICAO7.Text = "GMAA" Then
			txtPort3.Text = "Agadir"
			txtLatRad1.Text = "0.530260115577"
			txtLongRad1.Text = "0.1667080324"
		ElseIf cmbICAO7.Text = "GOOY" Then
			txtPort3.Text = "Dakar"
			txtLatRad1.Text = "0.257290620565"
			txtLongRad1.Text = "0.3052580862"
		ElseIf cmbICAO7.Text = "HELX" Then
			txtPort3.Text = "Luxor"
			txtLatRad1.Text = "0.447967841345"
			txtLongRad1.Text = "-0.570722665"
		ElseIf cmbICAO7.Text = "HKNW" Then
			txtPort3.Text = "Nairobi-Wilson"
			txtLatRad1.Text = "-0.02298016848"
			txtLongRad1.Text = "-0.642572053"
		ElseIf cmbICAO7.Text = "HSSS" Then
			txtPort3.Text = "Khartoum"
			txtLatRad1.Text = "0.272271363311"
			txtLongRad1.Text = "-0.568250116"
		ElseIf cmbICAO7.Text = "HTDA" Then
			txtPort3.Text = "Dar-Es-Salaam"
			txtLatRad1.Text = "-0.11999138607"
			txtLongRad1.Text = "-0.684198156"
		ElseIf cmbICAO7.Text = "I69" Then
			txtPort3.Text = "Batavia, OH"
			txtLatRad1.Text = "0.682045582859"
			txtLongRad1.Text = "1.4697417631"
		ElseIf cmbICAO7.Text = "KANC" Then
			txtPort3.Text = "Anchorage"
			txtLatRad1.Text = "1.067292108651"
			txtLongRad1.Text = "2.6215601674"
		ElseIf cmbICAO7.Text = "KBGR" Then
			txtPort3.Text = "Bangor"
			txtLatRad1.Text = "0.782052948998"
			txtLongRad1.Text = "1.2012810353"
		ElseIf cmbICAO7.Text = "KBOI" Then
			txtPort3.Text = "Boise"
			txtLatRad1.Text = "0.760352688631"
			txtLongRad1.Text = "2.0285089231"
		ElseIf cmbICAO7.Text = "KCAE" Then
			txtPort3.Text = "Columbia, SC"
			txtLatRad1.Text = "0.592364748127"
			txtLongRad1.Text = "1.4158110892"
		ElseIf cmbICAO7.Text = "KEWK" Then
			txtPort3.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO7.Text = "KICT" Then
			txtPort3.Text = "Wichita, KS"
			txtLatRad1.Text = "0.657116463376"
			txtLongRad1.Text = "1.7005324679"
		ElseIf cmbICAO7.Text = "KIDP" Then
			txtPort3.Text = "Independence, KS"
			txtLatRad1.Text = "0.648535261220"
			txtLongRad1.Text = "1.6716472687"
		ElseIf cmbICAO7.Text = "KJNU" Then
			txtPort3.Text = "Juneau, AK"
			txtLatRad1.Text = "1.018545062643"
			txtLongRad1.Text = "2.3488738036"
		ElseIf cmbICAO7.Text = "KMIA" Then
			txtPort3.Text = "Miami, FL"
			txtLatRad1.Text = "0.450178591731"
			txtLongRad1.Text = "1.4013248564"
		ElseIf cmbICAO7.Text = "KMSP" Then
			txtPort3.Text = "Minneapolis, MN"
			txtLatRad1.Text = "0.783391034758"
			txtLongRad1.Text = "1.6269086622"
		ElseIf cmbICAO7.Text = "KNUD" Then
			txtPort3.Text = "ADAK, AK"
			txtLatRad1.Text = "0.905348825123"
			txtLongRad1.Text = "3.0835022783"
		ElseIf cmbICAO7.Text = "KOAK" Then
			txtPort3.Text = "Oakland, CA"
			txtLatRad1.Text = "0.658454549136"
			txtLongRad1.Text = "2.1331995894"
		ElseIf cmbICAO7.Text = "KPDK" Then
			txtPort3.Text = "Atlanta, GA"
			txtLatRad1.Text = "0.590648507696"
			txtLongRad1.Text = "1.4713416483"
		ElseIf cmbICAO7.Text = "KVRB" Then
			txtPort3.Text = "Vero Beach"
			txtLatRad1.Text = "0.482670804639"
			txtLongRad1.Text = "1.4035356068"
		ElseIf cmbICAO7.Text = "LCPH" Then
			txtPort3.Text = "Larnaca, Cyprus"
			txtLatRad1.Text = "0.608741754275"
			txtLongRad1.Text = "-0.586954227"
		ElseIf cmbICAO7.Text = "LEMD" Then
			txtPort3.Text = "Madrid"
			txtLatRad1.Text = "0.706392925924"
			txtLongRad1.Text = "-0.062133721"
		ElseIf cmbICAO7.Text = "LEMG" Then
			txtPort3.Text = "Malaga"
			txtLatRad1.Text = "0.640099503169"
			txtLongRad1.Text = "0.0784816387"
		ElseIf cmbICAO7.Text = "LFPN" Then
			txtPort3.Text = "Toussus Le Noble"
			txtLatRad1.Text = "0.850877099168"
			txtLongRad1.Text = "-0.036739181"
		ElseIf cmbICAO7.Text = "LGAT" Then
			txtPort3.Text = "Athens"
			txtLatRad1.Text = "0.661247075939"
			txtLongRad1.Text = "-0.414166631"
		ElseIf cmbICAO7.Text = "LGIR" Then
			txtPort3.Text = "Iraklion"
			txtLatRad1.Text = "0.616770268834"
			txtLongRad1.Text = "-0.439444817"
		ElseIf cmbICAO7.Text = "LIRA" Then
			txtPort3.Text = "Rome"
			txtLatRad1.Text = "0.729518538513"
			txtLongRad1.Text = "-0.219824219"
		ElseIf cmbICAO7.Text = "LKPR" Then
			txtPort3.Text = "Prague, Czech"
			txtLatRad1.Text = "0.874439044070"
			txtLongRad1.Text = "-0.248913040"
		ElseIf cmbICAO7.Text = "LPAZ" Then
			txtPort3.Text = "Santa Maria"
			txtLatRad1.Text = "0.645306402104"
			txtLongRad1.Text = "0.4393284615"
		ElseIf cmbICAO7.Text = "LPPR" Then
			txtPort3.Text = "Porto, Portugal"
			txtLatRad1.Text = "0.719657428239"
			txtLongRad1.Text = "0.1514364014"
		ElseIf cmbICAO7.Text = "LROP" Then
			txtPort3.Text = "Bucharest, Romania"
			txtLatRad1.Text = "0.777893247614"
			txtLongRad1.Text = "-0.455298224"
		ElseIf cmbICAO7.Text = "LTAC" Then
			txtPort3.Text = "Ankara"
			txtLatRad1.Text = "0.700313362363"
			txtLongRad1.Text = "-0.575842298"
		ElseIf cmbICAO7.Text = "LTBA" Then
			txtPort3.Text = "Istanbul, Turkey"
			txtLatRad1.Text = "0.715177749826"
			txtLongRad1.Text = "-0.502945713"
		ElseIf cmbICAO7.Text = "MROC" Then
			txtPort3.Text = "San Jose, CR"
			txtLatRad1.Text = "0.174416569916"
			txtLongRad1.Text = "1.4697708519"
		ElseIf cmbICAO7.Text = "NTSU" Then
			txtPort3.Text = "Pago Pago"
			txtLatRad1.Text = "0.250192948273"
			txtLongRad1.Text = "2.9794515661"
		ElseIf cmbICAO7.Text = "NZAA" Then
			txtPort3.Text = "Auckland"
			txtLatRad1.Text = "-0.64588817852"
			txtLongRad1.Text = "-3.050690088"
		ElseIf cmbICAO7.Text = "OOMS" Then
			txtPort3.Text = "SEEB, Oman"
			txtLatRad1.Text = "0.411781348187"
			txtLongRad1.Text = "-1.017148799"
		ElseIf cmbICAO7.Text = "OPKC" Then
			txtPort3.Text = "Karachi"
			txtLatRad1.Text = "0.434703339030"
			txtLongRad1.Text = "-1.172104948"
		ElseIf cmbICAO7.Text = "PAOM" Then
			txtPort3.Text = "Nome, AK"
			txtLatRad1.Text = "1.125970078103"
			txtLongRad1.Text = "2.8875308921"
		ElseIf cmbICAO7.Text = "PGSN" Then
			txtPort3.Text = "Saipan"
			txtLatRad1.Text = "0.263922871722"
			txtLongRad1.Text = "-2.543526497"
		ElseIf cmbICAO7.Text = "PHNL" Then
			txtPort3.Text = "Honolulu, HI"
			txtLatRad1.Text = "0.372075107704"
			txtLongRad1.Text = "2.7562821324"
		ElseIf cmbICAO7.Text = "PHTO" Then
			txtPort3.Text = "HILO"
			txtLatRad1.Text = "0.344237106135"
			txtLongRad1.Text = "2.7061620940"
		ElseIf cmbICAO7.Text = "PKMJ" Then
			txtPort3.Text = "Majuro"
			txtLatRad1.Text = "0.123249334012"
			txtLongRad1.Text = "-2.989312676"
		ElseIf cmbICAO7.Text = "PLCH" Then
			txtPort3.Text = "Christmas Island"
			txtLatRad1.Text = "0.034702963294"
			txtLongRad1.Text = "2.7463628445"
		ElseIf cmbICAO7.Text = "PMDY" Then
			txtPort3.Text = "Midway"
			txtLatRad1.Text = "0.492386470808"
			txtLongRad1.Text = "3.0958650272"
		ElseIf cmbICAO7.Text = "PTRO" Then
			txtPort3.Text = "Palau"
			txtLatRad1.Text = "0.128543499409"
			txtLongRad1.Text = "-2.348369597"
		ElseIf cmbICAO7.Text = "PWAK" Then
			txtPort3.Text = "WAKE"
			txtLatRad1.Text = "0.336499479785"
			txtLongRad1.Text = "-2.908445754"
		ElseIf cmbICAO7.Text = "RCTP" Then
			txtPort3.Text = "Chiang Kai Shek"
			txtLatRad1.Text = "0.437699487579"
			txtLongRad1.Text = "-2.115717208"
		ElseIf cmbICAO7.Text = "RJCK" Then
			txtPort3.Text = "Kushiro"
			txtLatRad1.Text = "0.751218798879"
			txtLongRad1.Text = "-2.516677515"
		ElseIf cmbICAO7.Text = "RJTT" Then
			txtPort3.Text = "Tokyo"
			txtLatRad1.Text = "0.620580904367"
			txtLongRad1.Text = "-2.437643189"
		ElseIf cmbICAO7.Text = "RKSS" Then
			txtPort3.Text = "Seoul, Korea"
			txtLatRad1.Text = "0.655429311766"
			txtLongRad1.Text = "-2.213077492"
		ElseIf cmbICAO7.Text = "RPMM" Then
			txtPort3.Text = "Manilla"
			txtLatRad1.Text = "0.253218185644"
			txtLongRad1.Text = "-2.112197461"
		ElseIf cmbICAO7.Text = "SAEZ" Then
			txtPort3.Text = "Ezeiza"
			txtLatRad1.Text = "-0.60772364554"
			txtLongRad1.Text = "1.0215993888"
		ElseIf cmbICAO7.Text = "SBEG" Then
			txtPort3.Text = "Manaus"
			txtLatRad1.Text = "-0.05305800926"
			txtLongRad1.Text = "1.0480120382"
		ElseIf cmbICAO7.Text = "SBGL" Then
			txtPort3.Text = "Rio De Janeiro, Brazil"
			txtLatRad1.Text = "-0.39810960238"
			txtLongRad1.Text = "0.7548549015"
		ElseIf cmbICAO7.Text = "SBSP" Then
			txtPort3.Text = "Sao Paulo"
			txtLatRad1.Text = "-0.41233403578"
			txtLongRad1.Text = "0.8143124513"
		ElseIf cmbICAO7.Text = "SCEL" Then
			txtPort3.Text = "Santiago, Chile"
			txtLatRad1.Text = "-0.58279452606"
			txtLongRad1.Text = "1.2354022222"
		ElseIf cmbICAO7.Text = "SVMG" Then
			txtPort3.Text = "Margarita, VE"
			txtLatRad1.Text = "0.190531776676"
			txtLongRad1.Text = "1.1163998560"
		ElseIf cmbICAO7.Text = "TTPP" Then
			txtPort3.Text = "Picaro"
			txtLatRad1.Text = "0.184888545428"
			txtLongRad1.Text = "1.0705558744"
		ElseIf cmbICAO7.Text = "UHHH" Then
			txtPort3.Text = "Khabarovsk, Russia"
			txtLatRad1.Text = "0.846950108351"
			txtLongRad1.Text = "-2.359452438"
		ElseIf cmbICAO7.Text = "UHMM" Then
			txtPort3.Text = "Magadan, Russia"
			txtLatRad1.Text = "1.045743110153"
			txtLongRad1.Text = "-2.630502071"
		ElseIf cmbICAO7.Text = "UHPP" Then
			txtPort3.Text = "Petropavlovsk, Russia"
			txtLatRad1.Text = "0.927933385644"
			txtLongRad1.Text = "-2.7654742"
		ElseIf cmbICAO7.Text = "UHSS" Then
			txtPort3.Text = "Yuzhno, Russia"
			txtLatRad1.Text = "0.700720605855"
			txtLongRad1.Text = "-2.490730287"
		ElseIf cmbICAO7.Text = "UTTT" Then
			txtPort3.Text = "Tashkent, Russia"
			txtLatRad1.Text = "0.719948316448"
			txtLongRad1.Text = "-1.209222283"
		ElseIf cmbICAO7.Text = "UUEE" Then
			txtPort3.Text = "Moscow, Russia"
			txtLatRad1.Text = "0.976889871162"
			txtLongRad1.Text = "-0.65301494"
		ElseIf cmbICAO7.Text = "VABB" Then
			txtPort3.Text = "Bombay"
			txtLatRad1.Text = "0.333212443027"
			txtLongRad1.Text = "-1.271763248"
		ElseIf cmbICAO7.Text = "VCBI" Then
			txtPort3.Text = "Columbo, Sri Lanka"
			txtLatRad1.Text = "0.125314640293"
			txtLongRad1.Text = "-1.394227184"
		ElseIf cmbICAO7.Text = "VIDP" Then
			txtPort3.Text = "Delhi"
			txtLatRad1.Text = "0.498582389653"
			txtLongRad1.Text = "-1.345648853"
		ElseIf cmbICAO7.Text = "VNKT" Then
			txtPort3.Text = "Katmandu, Nepal"
			txtLatRad1.Text = "0.485230620875"
			txtLongRad1.Text = "-1.489842138"
		ElseIf cmbICAO7.Text = "VOMM" Then
			txtPort3.Text = "Madras"
			txtLatRad1.Text = "0.226805536297"
			txtLongRad1.Text = "-1.399346817"
		ElseIf cmbICAO7.Text = "VOPB" Then
			txtPort3.Text = "Port Blair, Nicobar"
			txtLatRad1.Text = "0.203272680216"
			txtLongRad1.Text = "-1.618531082"
		ElseIf cmbICAO7.Text = "VRMM" Then
			txtPort3.Text = "Male, Maldives"
			txtLatRad1.Text = "0.073158384479"
			txtLongRad1.Text = "-1.283398777"
		ElseIf cmbICAO7.Text = "VTBD" Then
			txtPort3.Text = "Bangkok"
			txtLatRad1.Text = "0.242891654236"
			txtLongRad1.Text = "-1.755888494"
		ElseIf cmbICAO7.Text = "WMKJ" Then
			txtPort3.Text = "Johor Bahru, Malaysia"
			txtLatRad1.Text = "0.028594310912"
			txtLongRad1.Text = "-1.809411924"
		ElseIf cmbICAO7.Text = "WMKK" Then
			txtPort3.Text = "Kuala Lumpur"
			txtLatRad1.Text = "0.054628805587"
			txtLongRad1.Text = "-1.772410944"
		ElseIf cmbICAO7.Text = "WSSL" Then
			txtPort3.Text = "Singapore"
			txtLatRad1.Text = "0.024725497737"
			txtLongRad1.Text = "-1.812815316"
		ElseIf cmbICAO7.Text = "ZGGG" Then
			txtPort3.Text = "Guangzhou"
			txtLatRad1.Text = "0.404625498254"
			txtLongRad1.Text = "-1.976847177"
		ElseIf cmbICAO7.Text = "Other" Then
			'Call ICAO7Other
		End If

		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg2, intLeg3 As Double
		If cmbICAO7.Text <> "Other" Then

			Call CalcDist()
			txtLeg3.Text = txtDist.Text
			txtLeg3.Text = VB6.Format(txtLeg3.Text, "Fixed")
			intLeg = CDbl(txtLeg.Text)
			intLeg1 = CDbl(txtLeg1.Text)
			intLeg2 = CDbl(txtLeg2.Text)
			intLeg3 = CDbl(txtLeg3.Text)
			intTotal1 = intLeg + intLeg1 + intLeg2 + intLeg3
			txtTotal3.Text = CStr(intTotal1)
			txtTotal3.Text = VB6.Format(txtTotal3.Text, "Fixed")

		Else
			Call ICAO7Other()
		End If

		If cmbICAO7.Text = "Other" Then
			cmbICAO7.Visible = False
			cmbICAO8.Visible = False
			txtICAO8.Text = txtICAO7.Text
			'cmbICAO7 = txtICAO7
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		Else
			cmbICAO8.Text = cmbICAO7.Text
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		End If

		cmbICAO9.Focus()

	End Sub

	<Obsolete>
	Private Sub ICAO7Other()

		txtICAO7.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtPort3.Text = InputBox("Enter Name of Airport.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
		txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
		txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
		txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
		intLatDeg = CDbl(txtLatDeg.Text)
		intLatMin = CDbl(txtLatMin.Text)
		intLatSec = CDbl(txtLatSec.Text)
		intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
		If txtNS.Text = "S" Then
			intLatRad = intLatRad * -1
		ElseIf txtNS.Text = "s" Then
			intLatRad = intLatRad * -1
		End If
		txtLatRad1.Text = CStr(intLatRad / (180 / 3.141592654))
		txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
		txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
		txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
		txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
		intLongDeg = CDbl(txtLongDeg.Text)
		intLongMin = CDbl(txtLongMin.Text)
		intLongSec = CDbl(txtLongSec.Text)
		intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
		If txtEW.Text = "E" Then
			intLongRad = intLongRad * -1
		ElseIf txtEW.Text = "e" Then
			intLongRad = intLongRad * -1
		End If
		txtLongRad1.Text = CStr(intLongRad / (180 / 3.141592654))
		cmbICAO7.Visible = False

		Call CalcDist()
		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg2, intLeg3 As Double
		txtLeg3.Text = txtDist.Text
		txtLeg3.Text = VB6.Format(txtLeg3.Text, "Fixed")
		intLeg = CDbl(txtLeg.Text)
		intLeg1 = CDbl(txtLeg1.Text)
		intLeg2 = CDbl(txtLeg2.Text)
		intLeg3 = CDbl(txtLeg3.Text)
		intTotal1 = intLeg + intLeg1 + intLeg2 + intLeg3
		txtTotal3.Text = CStr(intTotal1)
		txtTotal3.Text = VB6.Format(txtTotal3.Text, "Fixed")

		strICAO = txtICAO7.Text
		strPort = txtPort3.Text
		strLatRad = txtLatRad1.Text
		strLongRad = txtLongRad1.Text
		FileOpen(1, "Bid ICAO.txt", OpenMode.Append)
		WriteLine(1, strICAO, strPort, strLatRad, strLongRad)
		FileClose(1)

		intLatDeg = 0
		intLatMin = 0
		intLatSec = 0
		intLatRad = 0
		intLongDeg = 0
		intLongMin = 0
		intLongSec = 0
		intLongRad = 0

	End Sub

	'UPGRADE_WARNING: Event cmbICAO8.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cmbICAO8_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO8.SelectedIndexChanged

		If cmbICAO8.Text = "ASSY" Then
			'txtPort.Text = "Sidney"
			txtLatRad.Text = "-0.592248392843409"
			txtLongRad.Text = "-2.63835605259809"
		ElseIf cmbICAO8.Text = "AYPY" Then
			'txtPort.Text = "Port Moresby, PNG"
			txtLatRad.Text = "-0.164817259029998"
			txtLongRad.Text = "-2.56941554714432"
		ElseIf cmbICAO8.Text = "BGBW" Then
			'txtPort.Text = "Narsarsuaq"
			txtLatRad.Text = "1.0674724593406"
			txtLongRad.Text = "0.792873990360157"
		ElseIf cmbICAO8.Text = "BGGH" Then
			'txtPort.Text = "Godthab"
			txtLatRad.Text = "1.12035593567603"
			txtLongRad.Text = "0.902044335072403"
		ElseIf cmbICAO8.Text = "BIRK" Then
			'txtPort.Text = "Reykjavik"
			txtLatRad.Text = "1.1192505604831"
			txtLongRad.Text = "0.382983415529289"
		ElseIf cmbICAO8.Text = "CYAM" Then
			'txtPort.Text = "Sault Ste. Marie"
			txtLatRad.Text = "0.811316302789564"
			txtLongRad.Text = "1.47497775086041"
		ElseIf cmbICAO8.Text = "CYFB" Then
			'txtPort.Text = "Iqaluit"
			txtLatRad.Text = "1.11276375342985"
			txtLongRad.Text = "1.19653955752558"
		ElseIf cmbICAO8.Text = "CYQX" Then
			'txtPort.Text = "Gander"
			txtLatRad.Text = "0.854164135926025"
			txtLongRad.Text = "0.952426172813306"
		ElseIf cmbICAO8.Text = "CYYQ" Then
			'txtPort.Text = "Churchill Falls"
			txtLatRad.Text = "1.02520640262147"
			txtLongRad.Text = "1.64177304970933"
		ElseIf cmbICAO8.Text = "CYYR" Then
			'txtPort.Text = "Goose Bay"
			txtLatRad.Text = "0.930609557163376"
			txtLongRad.Text = "1.05464428933844"
		ElseIf cmbICAO8.Text = "CYYT" Then
			'txtPort.Text = "St John's, NFLD"
			txtLatRad.Text = "0.831096700978833"
			txtLongRad.Text = "0.920690269247875"
		ElseIf cmbICAO8.Text = "DAAG" Then
			'txtPort.Text = "Algiers, Algeria"
			txtLatRad.Text = "0.640419480198453"
			txtLongRad.Text = "-0.0561705130933508"
		ElseIf cmbICAO8.Text = "DIAP" Then
			'txtPort.Text = "Abidjan"
			txtLatRad.Text = "0.0916588745505689"
			txtLongRad.Text = "0.0685623507825106"
		ElseIf cmbICAO8.Text = "DNMM" Then
			'txtPort.Text = "Lagos, Nigeria"
			txtLatRad.Text = "0.114755398318627"
			txtLongRad.Text = "-0.0579158423453452"
		ElseIf cmbICAO8.Text = "DRRN" Then
			'txtPort.Text = "Niami, Niger"
			txtLatRad.Text = "0.235299471989702"
			txtLongRad.Text = "-0.0379318224100101"
		ElseIf cmbICAO8.Text = "EBBR" Then
			'txtPort.Text = "Brussels"
			txtLatRad.Text = "0.88840167808598"
			txtLongRad.Text = "-0.0785107275188782"
		ElseIf cmbICAO8.Text = "EDDW" Then
			'txtPort.Text = "Bremen, Germany"
			txtLatRad.Text = "0.925868079362125"
			txtLongRad.Text = "-0.153385352429435"
		ElseIf cmbICAO8.Text = "EFHK" Then
			'txtPort.Text = "Helsinki, Finland"
			txtLatRad.Text = "1.05272442716125"
			txtLongRad.Text = "-0.435750536581251"
		ElseIf cmbICAO8.Text = "EGPD" Then
			'txtPort.Text = "Aberdeen"
			txtLatRad.Text = "0.998415598603356"
			txtLongRad.Text = "0.0383681547230087"
		ElseIf cmbICAO8.Text = "EGPK" Then
			'txtPort.Text = "Prestwick"
			txtLatRad.Text = "0.968686823677719"
			txtLongRad.Text = "0.0798779020996071"
		ElseIf cmbICAO8.Text = "EHBK" Then
			'txtPort.Text = "Maastricht, Netherlands"
			txtLatRad.Text = "0.888663477473779"
			txtLongRad.Text = "-0.100821853123539"
		ElseIf cmbICAO8.Text = "EINN" Then
			'txtPort.Text = "Shannon"
			txtLatRad.Text = "0.919788515801012"
			txtLongRad.Text = "0.155741546919627"
		ElseIf cmbICAO8.Text = "EKCH" Then
			txtPort.Text = "Copenhagen"
			txtLatRad.Text = "0.97054850821318"
			txtLongRad.Text = "-0.220493262168617"
		ElseIf cmbICAO8.Text = "ELLX" Then
			'txtPort.Text = "Luxembourg"
			txtLatRad.Text = "0.86609055248132"
			txtLongRad.Text = "-0.108297680086248"
		ElseIf cmbICAO8.Text = "ENBR" Then
			'txtPort.Text = "Bergen, Norway"
			txtLatRad.Text = "1.05231718366911"
			txtLongRad.Text = "-0.091106186954104"
		ElseIf cmbICAO8.Text = "FAGM" Then
			'txtPort.Text = "Rand"
			txtLatRad.Text = "-0.458003484544179"
			txtLongRad.Text = "-0.49133927325727"
		ElseIf cmbICAO8.Text = "FALA" Then
			'txtPort.Text = "Lanseria, RSA"
			txtLatRad.Text = "-0.452622052683863"
			txtLongRad.Text = "-0.48735410479855"
		ElseIf cmbICAO8.Text = "FAWM" Then
			'txtPort.Text = "Windhoek"
			txtLatRad.Text = "-0.392379104669192"
			txtLongRad.Text = "-0.304967197965142"
		ElseIf cmbICAO8.Text = "FCBB" Then
			'txtPort.Text = "Brazzaville, Congo"
			txtLatRad.Text = "-0.0742928484932253"
			txtLongRad.Text = "-0.266162710929135"
		ElseIf cmbICAO8.Text = "FEFF" Then
			'txtPort.Text = "Bangui, CAE"
			txtLatRad.Text = "0.0767653982668839"
			txtLongRad.Text = "-0.323264066290216"
		ElseIf cmbICAO8.Text = "FMMI" Then
			'txtPort.Text = "Antananarivo, Madagascar"
			txtLatRad.Text = "-0.328063721733201"
			txtLongRad.Text = "-0.828624151205175"
		ElseIf cmbICAO8.Text = "FNLU" Then
			'txtPort.Text = "Luanda"
			txtLatRad.Text = "-0.154548905264098"
			txtLongRad.Text = "-0.231023415322316"
		ElseIf cmbICAO8.Text = "FOOL" Then
			'txtPort.Text = "Libreville"
			txtLatRad.Text = "-0.00799942573830734"
			txtLongRad.Text = "-0.164322749075266"
		ElseIf cmbICAO8.Text = "FSIA" Then
			'txtPort.Text = "Seychelles Intl"
			txtLatRad.Text = "-0.0815359648890018"
			txtLongRad.Text = "-0.969064978348985"
		ElseIf cmbICAO8.Text = "FVHA" Then
			'txtPort.Text = "Harare, Zimbabwe"
			txtLatRad.Text = "-0.31296662370345"
			txtLongRad.Text = "-0.54268104208677"
		ElseIf cmbICAO8.Text = "FZNA" Then
			'txtPort.Text = "Goma, Zaire"
			txtLatRad.Text = "-0.0290888208665722"
			txtLongRad.Text = "-0.510217917999676"
		ElseIf cmbICAO8.Text = "GBYD" Then
			'txtPort.Text = "Banjul"
			txtLatRad.Text = "0.23285601103691"
			txtLongRad.Text = "0.290742764561389"
		ElseIf cmbICAO8.Text = "GCXO" Then
			'txtPort.Text = "Tenerife"
			txtLatRad.Text = "0.497157037431"
			txtLongRad.Text = "0.2851867998"
		ElseIf cmbICAO8.Text = "GMAA" Then
			'txtPort.Text = "Agadir"
			txtLatRad.Text = "0.530260115577"
			txtLongRad.Text = "0.1667080324"
		ElseIf cmbICAO8.Text = "GOOY" Then
			'txtPort.Text = "Dakar"
			txtLatRad.Text = "0.257290620565"
			txtLongRad.Text = "0.3052580862"
		ElseIf cmbICAO8.Text = "HELX" Then
			'txtPort.Text = "Luxor"
			txtLatRad.Text = "0.447967841345"
			txtLongRad.Text = "-0.570722665"
		ElseIf cmbICAO8.Text = "HKNW" Then
			'txtPort.Text = "Nairobi-Wilson"
			txtLatRad.Text = "-0.02298016848"
			txtLongRad.Text = "-0.642572053"
		ElseIf cmbICAO8.Text = "HSSS" Then
			'txtPort.Text = "Khartoum"
			txtLatRad.Text = "0.272271363311"
			txtLongRad.Text = "-0.568250116"
		ElseIf cmbICAO8.Text = "HTDA" Then
			'txtPort.Text = "Dar-Es-Salaam"
			txtLatRad.Text = "-0.11999138607"
			txtLongRad.Text = "-0.684198156"
		ElseIf cmbICAO8.Text = "I69" Then
			'txtPort.Text = "Batavia, OH"
			txtLatRad.Text = "0.682045582859"
			txtLongRad.Text = "1.4697417631"
		ElseIf cmbICAO8.Text = "KANC" Then
			'txtPort.Text = "Anchorage"
			txtLatRad.Text = "1.067292108651"
			txtLongRad.Text = "2.6215601674"
		ElseIf cmbICAO8.Text = "KBGR" Then
			'txtPort.Text = "Bangor"
			txtLatRad.Text = "0.782052948998"
			txtLongRad.Text = "1.2012810353"
		ElseIf cmbICAO8.Text = "KBOI" Then
			'txtPort.Text = "Boise"
			txtLatRad.Text = "0.760352688631"
			txtLongRad.Text = "2.0285089231"
		ElseIf cmbICAO8.Text = "KCAE" Then
			'txtPort.Text = "Columbia, SC"
			txtLatRad.Text = "0.592364748127"
			txtLongRad.Text = "1.4158110892"
		ElseIf cmbICAO8.Text = "KEWK" Then
			'txtPort.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO8.Text = "KICT" Then
			'txtPort.Text = "Wichita, KS"
			txtLatRad.Text = "0.657116463376"
			txtLongRad.Text = "1.7005324679"
		ElseIf cmbICAO8.Text = "KIDP" Then
			'txtPort.Text = "Independence, KS"
			txtLatRad.Text = "0.648535261220"
			txtLongRad.Text = "1.6716472687"
		ElseIf cmbICAO8.Text = "KJNU" Then
			'txtPort.Text = "Juneau, AK"
			txtLatRad.Text = "1.018545062643"
			txtLongRad.Text = "2.3488738036"
		ElseIf cmbICAO8.Text = "KMIA" Then
			'txtPort.Text = "Miami, FL"
			txtLatRad.Text = "0.450178591731"
			txtLongRad.Text = "1.4013248564"
		ElseIf cmbICAO8.Text = "KMSP" Then
			'txtPort.Text = "Minneapolis, MN"
			txtLatRad.Text = "0.783391034758"
			txtLongRad.Text = "1.6269086622"
		ElseIf cmbICAO8.Text = "KNUD" Then
			'txtPort.Text = "ADAK, AK"
			txtLatRad.Text = "0.905348825123"
			txtLongRad.Text = "3.0835022783"
		ElseIf cmbICAO8.Text = "KOAK" Then
			'txtPort.Text = "Oakland, CA"
			txtLatRad.Text = "0.658454549136"
			txtLongRad.Text = "2.1331995894"
		ElseIf cmbICAO8.Text = "KPDK" Then
			'txtPort.Text = "Atlanta, GA"
			txtLatRad.Text = "0.590648507696"
			txtLongRad.Text = "1.4713416483"
		ElseIf cmbICAO8.Text = "KVRB" Then
			'txtPort.Text = "Vero Beach"
			txtLatRad.Text = "0.482670804639"
			txtLongRad.Text = "1.4035356068"
		ElseIf cmbICAO8.Text = "LCPH" Then
			'txtPort.Text = "Larnaca, Cyprus"
			txtLatRad.Text = "0.608741754275"
			txtLongRad.Text = "-0.586954227"
		ElseIf cmbICAO8.Text = "LEMD" Then
			'txtPort.Text = "Madrid"
			txtLatRad.Text = "0.706392925924"
			txtLongRad.Text = "-0.062133721"
		ElseIf cmbICAO8.Text = "LEMG" Then
			'txtPort.Text = "Malaga"
			txtLatRad.Text = "0.640099503169"
			txtLongRad.Text = "0.0784816387"
		ElseIf cmbICAO8.Text = "LFPN" Then
			'txtPort.Text = "Toussus Le Noble"
			txtLatRad.Text = "0.850877099168"
			txtLongRad.Text = "-0.036739181"
		ElseIf cmbICAO8.Text = "LGAT" Then
			'txtPort.Text = "Athens"
			txtLatRad.Text = "0.661247075939"
			txtLongRad.Text = "-0.414166631"
		ElseIf cmbICAO8.Text = "LGIR" Then
			'txtPort.Text = "Iraklion"
			txtLatRad.Text = "0.616770268834"
			txtLongRad.Text = "-0.439444817"
		ElseIf cmbICAO8.Text = "LIRA" Then
			'txtPort.Text = "Rome"
			txtLatRad.Text = "0.729518538513"
			txtLongRad.Text = "-0.219824219"
		ElseIf cmbICAO8.Text = "LKPR" Then
			'txtPort.Text = "Prague, Czech"
			txtLatRad.Text = "0.874439044070"
			txtLongRad.Text = "-0.248913040"
		ElseIf cmbICAO8.Text = "LPAZ" Then
			'txtPort.Text = "Santa Maria"
			txtLatRad.Text = "0.645306402104"
			txtLongRad.Text = "0.4393284615"
		ElseIf cmbICAO8.Text = "LPPR" Then
			'txtPort.Text = "Porto, Portugal"
			txtLatRad.Text = "0.719657428239"
			txtLongRad.Text = "0.1514364014"
		ElseIf cmbICAO8.Text = "LROP" Then
			'txtPort.Text = "Bucharest, Romania"
			txtLatRad.Text = "0.777893247614"
			txtLongRad.Text = "-0.455298224"
		ElseIf cmbICAO8.Text = "LTAC" Then
			'txtPort.Text = "Ankara"
			txtLatRad.Text = "0.700313362363"
			txtLongRad.Text = "-0.575842298"
		ElseIf cmbICAO8.Text = "LTBA" Then
			'txtPort.Text = "Istanbul, Turkey"
			txtLatRad.Text = "0.715177749826"
			txtLongRad.Text = "-0.502945713"
		ElseIf cmbICAO8.Text = "MROC" Then
			'txtPort.Text = "San Jose, CR"
			txtLatRad.Text = "0.174416569916"
			txtLongRad.Text = "1.4697708519"
		ElseIf cmbICAO8.Text = "NTSU" Then
			'txtPort.Text = "Pago Pago"
			txtLatRad.Text = "0.250192948273"
			txtLongRad.Text = "2.9794515661"
		ElseIf cmbICAO8.Text = "NZAA" Then
			'txtPort.Text = "Auckland"
			txtLatRad.Text = "-0.64588817852"
			txtLongRad.Text = "-3.050690088"
		ElseIf cmbICAO8.Text = "OOMS" Then
			'txtPort.Text = "SEEB, Oman"
			txtLatRad.Text = "0.411781348187"
			txtLongRad.Text = "-1.017148799"
		ElseIf cmbICAO8.Text = "OPKC" Then
			'txtPort.Text = "Karachi"
			txtLatRad.Text = "0.434703339030"
			txtLongRad.Text = "-1.172104948"
		ElseIf cmbICAO8.Text = "PAOM" Then
			'txtPort.Text = "Nome, AK"
			txtLatRad.Text = "1.125970078103"
			txtLongRad.Text = "2.8875308921"
		ElseIf cmbICAO8.Text = "PGSN" Then
			'txtPort.Text = "Saipan"
			txtLatRad.Text = "0.263922871722"
			txtLongRad.Text = "-2.543526497"
		ElseIf cmbICAO8.Text = "PHNL" Then
			'txtPort.Text = "Honolulu, HI"
			txtLatRad.Text = "0.372075107704"
			txtLongRad.Text = "2.7562821324"
		ElseIf cmbICAO8.Text = "PHTO" Then
			'txtPort.Text = "HILO"
			txtLatRad.Text = "0.344237106135"
			txtLongRad.Text = "2.7061620940"
		ElseIf cmbICAO8.Text = "PKMJ" Then
			'txtPort.Text = "Majuro"
			txtLatRad.Text = "0.123249334012"
			txtLongRad.Text = "-2.989312676"
		ElseIf cmbICAO8.Text = "PLCH" Then
			'txtPort.Text = "Christmas Island"
			txtLatRad.Text = "0.034702963294"
			txtLongRad.Text = "2.7463628445"
		ElseIf cmbICAO8.Text = "PMDY" Then
			'txtPort.Text = "Midway"
			txtLatRad.Text = "0.492386470808"
			txtLongRad.Text = "3.0958650272"
		ElseIf cmbICAO8.Text = "PTRO" Then
			'txtPort.Text = "Palau"
			txtLatRad.Text = "0.128543499409"
			txtLongRad.Text = "-2.348369597"
		ElseIf cmbICAO8.Text = "PWAK" Then
			'txtPort.Text = "WAKE"
			txtLatRad.Text = "0.336499479785"
			txtLongRad.Text = "-2.908445754"
		ElseIf cmbICAO8.Text = "RCTP" Then
			'txtPort.Text = "Chiang Kai Shek"
			txtLatRad.Text = "0.437699487579"
			txtLongRad.Text = "-2.115717208"
		ElseIf cmbICAO8.Text = "RJCK" Then
			'txtPort.Text = "Kushiro"
			txtLatRad.Text = "0.751218798879"
			txtLongRad.Text = "-2.516677515"
		ElseIf cmbICAO8.Text = "RJTT" Then
			'txtPort.Text = "Tokyo"
			txtLatRad.Text = "0.620580904367"
			txtLongRad.Text = "-2.437643189"
		ElseIf cmbICAO8.Text = "RKSS" Then
			'txtPort.Text = "Seoul, Korea"
			txtLatRad.Text = "0.655429311766"
			txtLongRad.Text = "-2.213077492"
		ElseIf cmbICAO8.Text = "RPMM" Then
			'txtPort.Text = "Manilla"
			txtLatRad.Text = "0.253218185644"
			txtLongRad.Text = "-2.112197461"
		ElseIf cmbICAO8.Text = "SAEZ" Then
			'txtPort.Text = "Ezeiza"
			txtLatRad.Text = "-0.60772364554"
			txtLongRad.Text = "1.0215993888"
		ElseIf cmbICAO8.Text = "SBEG" Then
			'txtPort.Text = "Manaus"
			txtLatRad.Text = "-0.05305800926"
			txtLongRad.Text = "1.0480120382"
		ElseIf cmbICAO8.Text = "SBGL" Then
			'txtPort.Text = "Rio De Janeiro, Brazil"
			txtLatRad.Text = "-0.39810960238"
			txtLongRad.Text = "0.7548549015"
		ElseIf cmbICAO8.Text = "SBSP" Then
			'txtPort.Text = "Sao Paulo"
			txtLatRad.Text = "-0.41233403578"
			txtLongRad.Text = "0.8143124513"
		ElseIf cmbICAO8.Text = "SCEL" Then
			'txtPort.Text = "Santiago, Chile"
			txtLatRad.Text = "-0.58279452606"
			txtLongRad.Text = "1.2354022222"
		ElseIf cmbICAO8.Text = "SVMG" Then
			'txtPort.Text = "Margarita, VE"
			txtLatRad.Text = "0.190531776676"
			txtLongRad.Text = "1.1163998560"
		ElseIf cmbICAO8.Text = "TTPP" Then
			'txtPort.Text = "Picaro"
			txtLatRad.Text = "0.184888545428"
			txtLongRad.Text = "1.0705558744"
		ElseIf cmbICAO8.Text = "UHHH" Then
			'txtPort.Text = "Khabarovsk, Russia"
			txtLatRad.Text = "0.846950108351"
			txtLongRad.Text = "-2.359452438"
		ElseIf cmbICAO8.Text = "UHMM" Then
			'txtPort.Text = "Magadan, Russia"
			txtLatRad.Text = "1.045743110153"
			txtLongRad.Text = "-2.630502071"
		ElseIf cmbICAO8.Text = "UHPP" Then
			'txtPort.Text = "Petropavlovsk, Russia"
			txtLatRad.Text = "0.927933385644"
			txtLongRad.Text = "-2.7654742"
		ElseIf cmbICAO8.Text = "UHSS" Then
			'txtPort.Text = "Yuzhno, Russia"
			txtLatRad.Text = "0.700720605855"
			txtLongRad.Text = "-2.490730287"
		ElseIf cmbICAO8.Text = "UTTT" Then
			'txtPort.Text = "Tashkent, Russia"
			txtLatRad.Text = "0.719948316448"
			txtLongRad.Text = "-1.209222283"
		ElseIf cmbICAO8.Text = "UUEE" Then
			'txtPort.Text = "Moscow, Russia"
			txtLatRad.Text = "0.976889871162"
			txtLongRad.Text = "-0.65301494"
		ElseIf cmbICAO8.Text = "VABB" Then
			'txtPort.Text = "Bombay"
			txtLatRad.Text = "0.333212443027"
			txtLongRad.Text = "-1.271763248"
		ElseIf cmbICAO8.Text = "VCBI" Then
			'txtPort.Text = "Columbo, Sri Lanka"
			txtLatRad.Text = "0.125314640293"
			txtLongRad.Text = "-1.394227184"
		ElseIf cmbICAO8.Text = "VIDP" Then
			'txtPort.Text = "Delhi"
			txtLatRad.Text = "0.498582389653"
			txtLongRad.Text = "-1.345648853"
		ElseIf cmbICAO8.Text = "VNKT" Then
			'txtPort.Text = "Katmandu, Nepal"
			txtLatRad.Text = "0.485230620875"
			txtLongRad.Text = "-1.489842138"
		ElseIf cmbICAO8.Text = "VOMM" Then
			'txtPort.Text = "Madras"
			txtLatRad.Text = "0.226805536297"
			txtLongRad.Text = "-1.399346817"
		ElseIf cmbICAO8.Text = "VOPB" Then
			'txtPort.Text = "Port Blair, Nicobar"
			txtLatRad.Text = "0.203272680216"
			txtLongRad.Text = "-1.618531082"
		ElseIf cmbICAO8.Text = "VRMM" Then
			'txtPort.Text = "Male, Maldives"
			txtLatRad.Text = "0.073158384479"
			txtLongRad.Text = "-1.283398777"
		ElseIf cmbICAO8.Text = "VTBD" Then
			'txtPort.Text = "Bangkok"
			txtLatRad.Text = "0.242891654236"
			txtLongRad.Text = "-1.755888494"
		ElseIf cmbICAO8.Text = "WMKJ" Then
			'txtPort.Text = "Johor Bahru, Malaysia"
			txtLatRad.Text = "0.028594310912"
			txtLongRad.Text = "-1.809411924"
		ElseIf cmbICAO8.Text = "WMKK" Then
			'txtPort.Text = "Kuala Lumpur"
			txtLatRad.Text = "0.054628805587"
			txtLongRad.Text = "-1.772410944"
		ElseIf cmbICAO8.Text = "WSSL" Then
			'txtPort.Text = "Singapore"
			txtLatRad.Text = "0.024725497737"
			txtLongRad.Text = "-1.812815316"
		ElseIf cmbICAO8.Text = "ZGGG" Then
			'txtPort.Text = "Guangzhou"
			txtLatRad.Text = "0.404625498254"
			txtLongRad.Text = "-1.976847177"
		ElseIf cmbICAO8.Text = "Other" Then
			txtICAO8.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
			txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
			txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
			txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
			txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
			intLatDeg = CDbl(txtLatDeg.Text)
			intLatMin = CDbl(txtLatMin.Text)
			intLatSec = CDbl(txtLatSec.Text)
			intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
			If txtNS.Text = "S" Then
				intLatRad = intLatRad * -1
			ElseIf txtNS.Text = "s" Then
				intLatRad = intLatRad * -1
			End If
			txtLatRad.Text = CStr(intLatRad / (180 / 3.141592654))
			txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
			txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
			txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
			txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
			intLongDeg = CDbl(txtLongDeg.Text)
			intLongMin = CDbl(txtLongMin.Text)
			intLongSec = CDbl(txtLongSec.Text)
			intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
			If txtEW.Text = "E" Then
				intLongRad = intLongRad * -1
			ElseIf txtEW.Text = "e" Then
				intLongRad = intLongRad * -1
			End If
			txtLongRad.Text = CStr(intLongRad / (180 / 3.141592654))
			cmbICAO8.Visible = False
			'cmbICAO8 = txtICAO8
			cmbICAO9.Focus()
		End If

	End Sub

	'UPGRADE_WARNING: Event cmbICAO9.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	<Obsolete>
	Private Sub cmbICAO9_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO9.SelectedIndexChanged

		If cmbICAO10.Text <> "" Then

			cmbICAO10.Text = ""
			cmbICAO11.Text = ""
			cmbICAO12.Text = ""
			cmbICAO13.Text = ""
			cmbICAO14.Text = ""
			cmbICAO15.Text = ""
			txtPort5.Text = ""
			txtPort6.Text = ""
			txtPort7.Text = ""
			txtLeg5.Text = ""
			txtLeg6.Text = ""
			txtLeg7.Text = ""
			txtTotal5.Text = ""
			txtTotal6.Text = ""
			txtTotal7.Text = ""

			Call cmbICAO8_SelectedIndexChanged(cmbICAO8, New System.EventArgs())

		End If

		If cmbICAO9.Text = cmbICAO8.Text Then
			Call MsgBox("Please re-enter destination, not equal to origination.", MsgBoxStyle.OKOnly, "Re-enter Destination")
			cmbICAO9.Text = ""
			cmbICAO9.Focus()
			Exit Sub
		ElseIf cmbICAO9.Text = "ASSY" Then
			txtPort4.Text = "Sidney"
			txtLatRad1.Text = "-0.592248392843409"
			txtLongRad1.Text = "-2.63835605259809"
		ElseIf cmbICAO9.Text = "AYPY" Then
			txtPort4.Text = "Port Moresby, PNG"
			txtLatRad1.Text = "-0.164817259029998"
			txtLongRad1.Text = "-2.56941554714432"
		ElseIf cmbICAO9.Text = "BGBW" Then
			txtPort4.Text = "Narsarsuaq"
			txtLatRad1.Text = "1.0674724593406"
			txtLongRad1.Text = "0.792873990360157"
		ElseIf cmbICAO9.Text = "BGGH" Then
			txtPort4.Text = "Godthab"
			txtLatRad1.Text = "1.12035593567603"
			txtLongRad1.Text = "0.902044335072403"
		ElseIf cmbICAO9.Text = "BIRK" Then
			txtPort4.Text = "Reykjavik"
			txtLatRad1.Text = "1.1192505604831"
			txtLongRad1.Text = "0.382983415529289"
		ElseIf cmbICAO9.Text = "CYAM" Then
			txtPort4.Text = "Sault Ste. Marie"
			txtLatRad1.Text = "0.811316302789564"
			txtLongRad1.Text = "1.47497775086041"
		ElseIf cmbICAO9.Text = "CYFB" Then
			txtPort4.Text = "Iqaluit"
			txtLatRad1.Text = "1.11276375342985"
			txtLongRad1.Text = "1.19653955752558"
		ElseIf cmbICAO9.Text = "CYQX" Then
			txtPort4.Text = "Gander"
			txtLatRad1.Text = "0.854164135926025"
			txtLongRad1.Text = "0.952426172813306"
		ElseIf cmbICAO9.Text = "CYYQ" Then
			txtPort4.Text = "Churchill Falls"
			txtLatRad1.Text = "1.02520640262147"
			txtLongRad1.Text = "1.64177304970933"
		ElseIf cmbICAO9.Text = "CYYR" Then
			txtPort4.Text = "Goose Bay"
			txtLatRad1.Text = "0.930609557163376"
			txtLongRad1.Text = "1.05464428933844"
		ElseIf cmbICAO9.Text = "CYYT" Then
			txtPort4.Text = "St John's, NFLD"
			txtLatRad1.Text = "0.831096700978833"
			txtLongRad1.Text = "0.920690269247875"
		ElseIf cmbICAO9.Text = "DAAG" Then
			txtPort4.Text = "Algiers, Algeria"
			txtLatRad1.Text = "0.640419480198453"
			txtLongRad1.Text = "-0.0561705130933508"
		ElseIf cmbICAO9.Text = "DIAP" Then
			txtPort4.Text = "Abidjan"
			txtLatRad1.Text = "0.0916588745505689"
			txtLongRad1.Text = "0.0685623507825106"
		ElseIf cmbICAO9.Text = "DNMM" Then
			txtPort4.Text = "Lagos, Nigeria"
			txtLatRad1.Text = "0.114755398318627"
			txtLongRad1.Text = "-0.0579158423453452"
		ElseIf cmbICAO9.Text = "DRRN" Then
			txtPort4.Text = "Niami, Niger"
			txtLatRad1.Text = "0.235299471989702"
			txtLongRad1.Text = "-0.0379318224100101"
		ElseIf cmbICAO9.Text = "EBBR" Then
			txtPort4.Text = "Brussels"
			txtLatRad1.Text = "0.88840167808598"
			txtLongRad1.Text = "-0.0785107275188782"
		ElseIf cmbICAO9.Text = "EDDW" Then
			txtPort4.Text = "Bremen, Germany"
			txtLatRad1.Text = "0.925868079362125"
			txtLongRad1.Text = "-0.153385352429435"
		ElseIf cmbICAO9.Text = "EFHK" Then
			txtPort4.Text = "Helsinki, Finland"
			txtLatRad1.Text = "1.05272442716125"
			txtLongRad1.Text = "-0.435750536581251"
		ElseIf cmbICAO9.Text = "EGPD" Then
			txtPort4.Text = "Aberdeen"
			txtLatRad1.Text = "0.998415598603356"
			txtLongRad1.Text = "0.0383681547230087"
		ElseIf cmbICAO9.Text = "EGPK" Then
			txtPort4.Text = "Prestwick"
			txtLatRad1.Text = "0.968686823677719"
			txtLongRad1.Text = "0.0798779020996071"
		ElseIf cmbICAO9.Text = "EHBK" Then
			txtPort4.Text = "Maastricht, Netherlands"
			txtLatRad1.Text = "0.888663477473779"
			txtLongRad1.Text = "-0.100821853123539"
		ElseIf cmbICAO9.Text = "EINN" Then
			txtPort4.Text = "Shannon"
			txtLatRad1.Text = "0.919788515801012"
			txtLongRad1.Text = "0.155741546919627"
		ElseIf cmbICAO9.Text = "EKCH" Then
			txtPort4.Text = "Copenhagen"
			txtLatRad1.Text = "0.97054850821318"
			txtLongRad1.Text = "-0.220493262168617"
		ElseIf cmbICAO9.Text = "ELLX" Then
			txtPort4.Text = "Luxembourg"
			txtLatRad1.Text = "0.86609055248132"
			txtLongRad1.Text = "-0.108297680086248"
		ElseIf cmbICAO9.Text = "ENBR" Then
			txtPort4.Text = "Bergen, Norway"
			txtLatRad1.Text = "1.05231718366911"
			txtLongRad1.Text = "-0.091106186954104"
		ElseIf cmbICAO9.Text = "FAGM" Then
			txtPort4.Text = "Rand"
			txtLatRad1.Text = "-0.458003484544179"
			txtLongRad1.Text = "-0.49133927325727"
		ElseIf cmbICAO9.Text = "FALA" Then
			txtPort4.Text = "Lanseria, RSA"
			txtLatRad1.Text = "-0.452622052683863"
			txtLongRad1.Text = "-0.48735410479855"
		ElseIf cmbICAO9.Text = "FAWM" Then
			txtPort4.Text = "Windhoek"
			txtLatRad1.Text = "-0.392379104669192"
			txtLongRad1.Text = "-0.304967197965142"
		ElseIf cmbICAO9.Text = "FCBB" Then
			txtPort4.Text = "Brazzaville, Congo"
			txtLatRad1.Text = "-0.0742928484932253"
			txtLongRad1.Text = "-0.266162710929135"
		ElseIf cmbICAO9.Text = "FEFF" Then
			txtPort4.Text = "Bangui, CAE"
			txtLatRad1.Text = "0.0767653982668839"
			txtLongRad1.Text = "-0.323264066290216"
		ElseIf cmbICAO9.Text = "FMMI" Then
			txtPort4.Text = "Antananarivo, Madagascar"
			txtLatRad1.Text = "-0.328063721733201"
			txtLongRad1.Text = "-0.828624151205175"
		ElseIf cmbICAO9.Text = "FNLU" Then
			txtPort4.Text = "Luanda"
			txtLatRad1.Text = "-0.154548905264098"
			txtLongRad1.Text = "-0.231023415322316"
		ElseIf cmbICAO9.Text = "FOOL" Then
			txtPort4.Text = "Libreville"
			txtLatRad1.Text = "-0.00799942573830734"
			txtLongRad1.Text = "-0.164322749075266"
		ElseIf cmbICAO9.Text = "FSIA" Then
			txtPort4.Text = "Seychelles Intl"
			txtLatRad1.Text = "-0.0815359648890018"
			txtLongRad1.Text = "-0.969064978348985"
		ElseIf cmbICAO9.Text = "FVHA" Then
			txtPort4.Text = "Harare, Zimbabwe"
			txtLatRad1.Text = "-0.31296662370345"
			txtLongRad1.Text = "-0.54268104208677"
		ElseIf cmbICAO9.Text = "FZNA" Then
			txtPort4.Text = "Goma, Zaire"
			txtLatRad1.Text = "-0.0290888208665722"
			txtLongRad1.Text = "-0.510217917999676"
		ElseIf cmbICAO9.Text = "GBYD" Then
			txtPort4.Text = "Banjul"
			txtLatRad1.Text = "0.23285601103691"
			txtLongRad1.Text = "0.290742764561389"
		ElseIf cmbICAO9.Text = "GCXO" Then
			txtPort4.Text = "Tenerife"
			txtLatRad1.Text = "0.497157037431"
			txtLongRad1.Text = "0.2851867998"
		ElseIf cmbICAO9.Text = "GMAA" Then
			txtPort4.Text = "Agadir"
			txtLatRad1.Text = "0.530260115577"
			txtLongRad1.Text = "0.1667080324"
		ElseIf cmbICAO9.Text = "GOOY" Then
			txtPort4.Text = "Dakar"
			txtLatRad1.Text = "0.257290620565"
			txtLongRad1.Text = "0.3052580862"
		ElseIf cmbICAO9.Text = "HELX" Then
			txtPort4.Text = "Luxor"
			txtLatRad1.Text = "0.447967841345"
			txtLongRad1.Text = "-0.570722665"
		ElseIf cmbICAO9.Text = "HKNW" Then
			txtPort4.Text = "Nairobi-Wilson"
			txtLatRad1.Text = "-0.02298016848"
			txtLongRad1.Text = "-0.642572053"
		ElseIf cmbICAO9.Text = "HSSS" Then
			txtPort4.Text = "Khartoum"
			txtLatRad1.Text = "0.272271363311"
			txtLongRad1.Text = "-0.568250116"
		ElseIf cmbICAO9.Text = "HTDA" Then
			txtPort4.Text = "Dar-Es-Salaam"
			txtLatRad1.Text = "-0.11999138607"
			txtLongRad1.Text = "-0.684198156"
		ElseIf cmbICAO9.Text = "I69" Then
			txtPort4.Text = "Batavia, OH"
			txtLatRad1.Text = "0.682045582859"
			txtLongRad1.Text = "1.4697417631"
		ElseIf cmbICAO9.Text = "KANC" Then
			txtPort4.Text = "Anchorage"
			txtLatRad1.Text = "1.067292108651"
			txtLongRad1.Text = "2.6215601674"
		ElseIf cmbICAO9.Text = "KBGR" Then
			txtPort4.Text = "Bangor"
			txtLatRad1.Text = "0.782052948998"
			txtLongRad1.Text = "1.2012810353"
		ElseIf cmbICAO9.Text = "KBOI" Then
			txtPort4.Text = "Boise"
			txtLatRad1.Text = "0.760352688631"
			txtLongRad1.Text = "2.0285089231"
		ElseIf cmbICAO9.Text = "KCAE" Then
			txtPort4.Text = "Columbia, SC"
			txtLatRad1.Text = "0.592364748127"
			txtLongRad1.Text = "1.4158110892"
		ElseIf cmbICAO9.Text = "KEWK" Then
			txtPort4.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO9.Text = "KICT" Then
			txtPort4.Text = "Wichita, KS"
			txtLatRad1.Text = "0.657116463376"
			txtLongRad1.Text = "1.7005324679"
		ElseIf cmbICAO9.Text = "KIDP" Then
			txtPort4.Text = "Independence, KS"
			txtLatRad1.Text = "0.648535261220"
			txtLongRad1.Text = "1.6716472687"
		ElseIf cmbICAO9.Text = "KJNU" Then
			txtPort4.Text = "Juneau, AK"
			txtLatRad1.Text = "1.018545062643"
			txtLongRad1.Text = "2.3488738036"
		ElseIf cmbICAO9.Text = "KMIA" Then
			txtPort4.Text = "Miami, FL"
			txtLatRad1.Text = "0.450178591731"
			txtLongRad1.Text = "1.4013248564"
		ElseIf cmbICAO9.Text = "KMSP" Then
			txtPort4.Text = "Minneapolis, MN"
			txtLatRad1.Text = "0.783391034758"
			txtLongRad1.Text = "1.6269086622"
		ElseIf cmbICAO9.Text = "KNUD" Then
			txtPort4.Text = "ADAK, AK"
			txtLatRad1.Text = "0.905348825123"
			txtLongRad1.Text = "3.0835022783"
		ElseIf cmbICAO9.Text = "KOAK" Then
			txtPort4.Text = "Oakland, CA"
			txtLatRad1.Text = "0.658454549136"
			txtLongRad1.Text = "2.1331995894"
		ElseIf cmbICAO9.Text = "KPDK" Then
			txtPort4.Text = "Atlanta, GA"
			txtLatRad1.Text = "0.590648507696"
			txtLongRad1.Text = "1.4713416483"
		ElseIf cmbICAO9.Text = "KVRB" Then
			txtPort4.Text = "Vero Beach"
			txtLatRad1.Text = "0.482670804639"
			txtLongRad1.Text = "1.4035356068"
		ElseIf cmbICAO9.Text = "LCPH" Then
			txtPort4.Text = "Larnaca, Cyprus"
			txtLatRad1.Text = "0.608741754275"
			txtLongRad1.Text = "-0.586954227"
		ElseIf cmbICAO9.Text = "LEMD" Then
			txtPort4.Text = "Madrid"
			txtLatRad1.Text = "0.706392925924"
			txtLongRad1.Text = "-0.062133721"
		ElseIf cmbICAO9.Text = "LEMG" Then
			txtPort4.Text = "Malaga"
			txtLatRad1.Text = "0.640099503169"
			txtLongRad1.Text = "0.0784816387"
		ElseIf cmbICAO9.Text = "LFPN" Then
			txtPort4.Text = "Toussus Le Noble"
			txtLatRad1.Text = "0.850877099168"
			txtLongRad1.Text = "-0.036739181"
		ElseIf cmbICAO9.Text = "LGAT" Then
			txtPort4.Text = "Athens"
			txtLatRad1.Text = "0.661247075939"
			txtLongRad1.Text = "-0.414166631"
		ElseIf cmbICAO9.Text = "LGIR" Then
			txtPort4.Text = "Iraklion"
			txtLatRad1.Text = "0.616770268834"
			txtLongRad1.Text = "-0.439444817"
		ElseIf cmbICAO9.Text = "LIRA" Then
			txtPort4.Text = "Rome"
			txtLatRad1.Text = "0.729518538513"
			txtLongRad1.Text = "-0.219824219"
		ElseIf cmbICAO9.Text = "LKPR" Then
			txtPort4.Text = "Prague, Czech"
			txtLatRad1.Text = "0.874439044070"
			txtLongRad1.Text = "-0.248913040"
		ElseIf cmbICAO9.Text = "LPAZ" Then
			txtPort4.Text = "Santa Maria"
			txtLatRad1.Text = "0.645306402104"
			txtLongRad1.Text = "0.4393284615"
		ElseIf cmbICAO9.Text = "LPPR" Then
			txtPort4.Text = "Porto, Portugal"
			txtLatRad1.Text = "0.719657428239"
			txtLongRad1.Text = "0.1514364014"
		ElseIf cmbICAO9.Text = "LROP" Then
			txtPort4.Text = "Bucharest, Romania"
			txtLatRad1.Text = "0.777893247614"
			txtLongRad1.Text = "-0.455298224"
		ElseIf cmbICAO9.Text = "LTAC" Then
			txtPort4.Text = "Ankara"
			txtLatRad1.Text = "0.700313362363"
			txtLongRad1.Text = "-0.575842298"
		ElseIf cmbICAO9.Text = "LTBA" Then
			txtPort4.Text = "Istanbul, Turkey"
			txtLatRad1.Text = "0.715177749826"
			txtLongRad1.Text = "-0.502945713"
		ElseIf cmbICAO9.Text = "MROC" Then
			txtPort4.Text = "San Jose, CR"
			txtLatRad1.Text = "0.174416569916"
			txtLongRad1.Text = "1.4697708519"
		ElseIf cmbICAO9.Text = "NTSU" Then
			txtPort4.Text = "Pago Pago"
			txtLatRad1.Text = "0.250192948273"
			txtLongRad1.Text = "2.9794515661"
		ElseIf cmbICAO9.Text = "NZAA" Then
			txtPort4.Text = "Auckland"
			txtLatRad1.Text = "-0.64588817852"
			txtLongRad1.Text = "-3.050690088"
		ElseIf cmbICAO9.Text = "OOMS" Then
			txtPort4.Text = "SEEB, Oman"
			txtLatRad1.Text = "0.411781348187"
			txtLongRad1.Text = "-1.017148799"
		ElseIf cmbICAO9.Text = "OPKC" Then
			txtPort4.Text = "Karachi"
			txtLatRad1.Text = "0.434703339030"
			txtLongRad1.Text = "-1.172104948"
		ElseIf cmbICAO9.Text = "PAOM" Then
			txtPort4.Text = "Nome, AK"
			txtLatRad1.Text = "1.125970078103"
			txtLongRad1.Text = "2.8875308921"
		ElseIf cmbICAO9.Text = "PGSN" Then
			txtPort4.Text = "Saipan"
			txtLatRad1.Text = "0.263922871722"
			txtLongRad1.Text = "-2.543526497"
		ElseIf cmbICAO9.Text = "PHNL" Then
			txtPort4.Text = "Honolulu, HI"
			txtLatRad1.Text = "0.372075107704"
			txtLongRad1.Text = "2.7562821324"
		ElseIf cmbICAO9.Text = "PHTO" Then
			txtPort4.Text = "HILO"
			txtLatRad1.Text = "0.344237106135"
			txtLongRad1.Text = "2.7061620940"
		ElseIf cmbICAO9.Text = "PKMJ" Then
			txtPort4.Text = "Majuro"
			txtLatRad1.Text = "0.123249334012"
			txtLongRad1.Text = "-2.989312676"
		ElseIf cmbICAO9.Text = "PLCH" Then
			txtPort4.Text = "Christmas Island"
			txtLatRad1.Text = "0.034702963294"
			txtLongRad1.Text = "2.7463628445"
		ElseIf cmbICAO9.Text = "PMDY" Then
			txtPort4.Text = "Midway"
			txtLatRad1.Text = "0.492386470808"
			txtLongRad1.Text = "3.0958650272"
		ElseIf cmbICAO9.Text = "PTRO" Then
			txtPort4.Text = "Palau"
			txtLatRad1.Text = "0.128543499409"
			txtLongRad1.Text = "-2.348369597"
		ElseIf cmbICAO9.Text = "PWAK" Then
			txtPort4.Text = "WAKE"
			txtLatRad1.Text = "0.336499479785"
			txtLongRad1.Text = "-2.908445754"
		ElseIf cmbICAO9.Text = "RCTP" Then
			txtPort4.Text = "Chiang Kai Shek"
			txtLatRad1.Text = "0.437699487579"
			txtLongRad1.Text = "-2.115717208"
		ElseIf cmbICAO9.Text = "RJCK" Then
			txtPort4.Text = "Kushiro"
			txtLatRad1.Text = "0.751218798879"
			txtLongRad1.Text = "-2.516677515"
		ElseIf cmbICAO9.Text = "RJTT" Then
			txtPort4.Text = "Tokyo"
			txtLatRad1.Text = "0.620580904367"
			txtLongRad1.Text = "-2.437643189"
		ElseIf cmbICAO9.Text = "RKSS" Then
			txtPort4.Text = "Seoul, Korea"
			txtLatRad1.Text = "0.655429311766"
			txtLongRad1.Text = "-2.213077492"
		ElseIf cmbICAO9.Text = "RPMM" Then
			txtPort4.Text = "Manilla"
			txtLatRad1.Text = "0.253218185644"
			txtLongRad1.Text = "-2.112197461"
		ElseIf cmbICAO9.Text = "SAEZ" Then
			txtPort4.Text = "Ezeiza"
			txtLatRad1.Text = "-0.60772364554"
			txtLongRad1.Text = "1.0215993888"
		ElseIf cmbICAO9.Text = "SBEG" Then
			txtPort4.Text = "Manaus"
			txtLatRad1.Text = "-0.05305800926"
			txtLongRad1.Text = "1.0480120382"
		ElseIf cmbICAO9.Text = "SBGL" Then
			txtPort4.Text = "Rio De Janeiro, Brazil"
			txtLatRad1.Text = "-0.39810960238"
			txtLongRad1.Text = "0.7548549015"
		ElseIf cmbICAO9.Text = "SBSP" Then
			txtPort4.Text = "Sao Paulo"
			txtLatRad1.Text = "-0.41233403578"
			txtLongRad1.Text = "0.8143124513"
		ElseIf cmbICAO9.Text = "SCEL" Then
			txtPort4.Text = "Santiago, Chile"
			txtLatRad1.Text = "-0.58279452606"
			txtLongRad1.Text = "1.2354022222"
		ElseIf cmbICAO9.Text = "SVMG" Then
			txtPort4.Text = "Margarita, VE"
			txtLatRad1.Text = "0.190531776676"
			txtLongRad1.Text = "1.1163998560"
		ElseIf cmbICAO9.Text = "TTPP" Then
			txtPort4.Text = "Picaro"
			txtLatRad1.Text = "0.184888545428"
			txtLongRad1.Text = "1.0705558744"
		ElseIf cmbICAO9.Text = "UHHH" Then
			txtPort4.Text = "Khabarovsk, Russia"
			txtLatRad1.Text = "0.846950108351"
			txtLongRad1.Text = "-2.359452438"
		ElseIf cmbICAO9.Text = "UHMM" Then
			txtPort4.Text = "Magadan, Russia"
			txtLatRad1.Text = "1.045743110153"
			txtLongRad1.Text = "-2.630502071"
		ElseIf cmbICAO9.Text = "UHPP" Then
			txtPort4.Text = "Petropavlovsk, Russia"
			txtLatRad1.Text = "0.927933385644"
			txtLongRad1.Text = "-2.7654742"
		ElseIf cmbICAO9.Text = "UHSS" Then
			txtPort4.Text = "Yuzhno, Russia"
			txtLatRad1.Text = "0.700720605855"
			txtLongRad1.Text = "-2.490730287"
		ElseIf cmbICAO9.Text = "UTTT" Then
			txtPort4.Text = "Tashkent, Russia"
			txtLatRad1.Text = "0.719948316448"
			txtLongRad1.Text = "-1.209222283"
		ElseIf cmbICAO9.Text = "UUEE" Then
			txtPort4.Text = "Moscow, Russia"
			txtLatRad1.Text = "0.976889871162"
			txtLongRad1.Text = "-0.65301494"
		ElseIf cmbICAO9.Text = "VABB" Then
			txtPort4.Text = "Bombay"
			txtLatRad1.Text = "0.333212443027"
			txtLongRad1.Text = "-1.271763248"
		ElseIf cmbICAO9.Text = "VCBI" Then
			txtPort4.Text = "Columbo, Sri Lanka"
			txtLatRad1.Text = "0.125314640293"
			txtLongRad1.Text = "-1.394227184"
		ElseIf cmbICAO9.Text = "VIDP" Then
			txtPort4.Text = "Delhi"
			txtLatRad1.Text = "0.498582389653"
			txtLongRad1.Text = "-1.345648853"
		ElseIf cmbICAO9.Text = "VNKT" Then
			txtPort4.Text = "Katmandu, Nepal"
			txtLatRad1.Text = "0.485230620875"
			txtLongRad1.Text = "-1.489842138"
		ElseIf cmbICAO9.Text = "VOMM" Then
			txtPort4.Text = "Madras"
			txtLatRad1.Text = "0.226805536297"
			txtLongRad1.Text = "-1.399346817"
		ElseIf cmbICAO9.Text = "VOPB" Then
			txtPort4.Text = "Port Blair, Nicobar"
			txtLatRad1.Text = "0.203272680216"
			txtLongRad1.Text = "-1.618531082"
		ElseIf cmbICAO9.Text = "VRMM" Then
			txtPort4.Text = "Male, Maldives"
			txtLatRad1.Text = "0.073158384479"
			txtLongRad1.Text = "-1.283398777"
		ElseIf cmbICAO9.Text = "VTBD" Then
			txtPort4.Text = "Bangkok"
			txtLatRad1.Text = "0.242891654236"
			txtLongRad1.Text = "-1.755888494"
		ElseIf cmbICAO9.Text = "WMKJ" Then
			txtPort4.Text = "Johor Bahru, Malaysia"
			txtLatRad1.Text = "0.028594310912"
			txtLongRad1.Text = "-1.809411924"
		ElseIf cmbICAO9.Text = "WMKK" Then
			txtPort4.Text = "Kuala Lumpur"
			txtLatRad1.Text = "0.054628805587"
			txtLongRad1.Text = "-1.772410944"
		ElseIf cmbICAO9.Text = "WSSL" Then
			txtPort4.Text = "Singapore"
			txtLatRad1.Text = "0.024725497737"
			txtLongRad1.Text = "-1.812815316"
		ElseIf cmbICAO9.Text = "ZGGG" Then
			txtPort4.Text = "Guangzhou"
			txtLatRad1.Text = "0.404625498254"
			txtLongRad1.Text = "-1.976847177"
		ElseIf cmbICAO9.Text = "Other" Then
			'Call ICAO9Other
		End If

		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg3, intLeg2, intLeg4 As Double
		If cmbICAO9.Text <> "Other" Then
			Call CalcDist()
			txtLeg4.Text = txtDist.Text
			txtLeg4.Text = VB6.Format(txtLeg4.Text, "Fixed")
			intLeg = CDbl(txtLeg.Text)
			intLeg1 = CDbl(txtLeg1.Text)
			intLeg2 = CDbl(txtLeg2.Text)
			intLeg3 = CDbl(txtLeg3.Text)
			intLeg4 = CDbl(txtLeg4.Text)
			intTotal1 = intLeg + intLeg1 + intLeg2 + intLeg3 + intLeg4
			txtTotal4.Text = CStr(intTotal1)
			txtTotal4.Text = VB6.Format(txtTotal4.Text, "Fixed")
		Else
			Call ICAO9Other()
		End If

		If cmbICAO9.Text = "Other" Then
			cmbICAO9.Visible = False
			cmbICAO10.Visible = False
			txtICAO10.Text = txtICAO9.Text
			'cmbICAO9 = txtICAO9
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		Else
			cmbICAO10.Text = cmbICAO9.Text
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		End If

		cmbICAO11.Focus()

	End Sub

	<Obsolete>
	Private Sub ICAO9Other()

		txtICAO9.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtPort4.Text = InputBox("Enter Name of Airport.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
		txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
		txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
		txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
		intLatDeg = CDbl(txtLatDeg.Text)
		intLatMin = CDbl(txtLatMin.Text)
		intLatSec = CDbl(txtLatSec.Text)
		intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
		If txtNS.Text = "S" Then
			intLatRad = intLatRad * -1
		ElseIf txtNS.Text = "s" Then
			intLatRad = intLatRad * -1
		End If
		txtLatRad1.Text = CStr(intLatRad / (180 / 3.141592654))
		txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
		txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
		txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
		txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
		intLongDeg = CDbl(txtLongDeg.Text)
		intLongMin = CDbl(txtLongMin.Text)
		intLongSec = CDbl(txtLongSec.Text)
		intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
		If txtEW.Text = "E" Then
			intLongRad = intLongRad * -1
		ElseIf txtEW.Text = "e" Then
			intLongRad = intLongRad * -1
		End If
		txtLongRad1.Text = CStr(intLongRad / (180 / 3.141592654))
		cmbICAO9.Visible = False

		Call CalcDist()
		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg3, intLeg2, intLeg4 As Double
		txtLeg4.Text = txtDist.Text
		txtLeg4.Text = VB6.Format(txtLeg4.Text, "Fixed")
		intLeg = CDbl(txtLeg.Text)
		intLeg1 = CDbl(txtLeg1.Text)
		intLeg2 = CDbl(txtLeg2.Text)
		intLeg3 = CDbl(txtLeg3.Text)
		intLeg4 = CDbl(txtLeg4.Text)
		intTotal1 = intLeg + intLeg1 + intLeg2 + intLeg3 + intLeg4
		txtTotal4.Text = CStr(intTotal1)
		txtTotal4.Text = VB6.Format(txtTotal4.Text, "Fixed")

		strICAO = txtICAO9.Text
		strPort = txtPort4.Text
		strLatRad = txtLatRad1.Text
		strLongRad = txtLongRad1.Text
		FileOpen(1, "Bid ICAO.txt", OpenMode.Append)
		WriteLine(1, strICAO, strPort, strLatRad, strLongRad)
		FileClose(1)

		intLatDeg = 0
		intLatMin = 0
		intLatSec = 0
		intLatRad = 0
		intLongDeg = 0
		intLongMin = 0
		intLongSec = 0
		intLongRad = 0

	End Sub

	'UPGRADE_WARNING: Event cmbICAO10.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cmbICAO10_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO10.SelectedIndexChanged

		If cmbICAO10.Text = "ASSY" Then
			'txtPort.Text = "Sidney"
			txtLatRad.Text = "-0.592248392843409"
			txtLongRad.Text = "-2.63835605259809"
		ElseIf cmbICAO10.Text = "AYPY" Then
			'txtPort.Text = "Port Moresby, PNG"
			txtLatRad.Text = "-0.164817259029998"
			txtLongRad.Text = "-2.56941554714432"
		ElseIf cmbICAO10.Text = "BGBW" Then
			'txtPort.Text = "Narsarsuaq"
			txtLatRad.Text = "1.0674724593406"
			txtLongRad.Text = "0.792873990360157"
		ElseIf cmbICAO10.Text = "BGGH" Then
			'txtPort.Text = "Godthab"
			txtLatRad.Text = "1.12035593567603"
			txtLongRad.Text = "0.902044335072403"
		ElseIf cmbICAO10.Text = "BIRK" Then
			'txtPort.Text = "Reykjavik"
			txtLatRad.Text = "1.1192505604831"
			txtLongRad.Text = "0.382983415529289"
		ElseIf cmbICAO10.Text = "CYAM" Then
			'txtPort.Text = "Sault Ste. Marie"
			txtLatRad.Text = "0.811316302789564"
			txtLongRad.Text = "1.47497775086041"
		ElseIf cmbICAO10.Text = "CYFB" Then
			'txtPort.Text = "Iqaluit"
			txtLatRad.Text = "1.11276375342985"
			txtLongRad.Text = "1.19653955752558"
		ElseIf cmbICAO10.Text = "CYQX" Then
			'txtPort.Text = "Gander"
			txtLatRad.Text = "0.854164135926025"
			txtLongRad.Text = "0.952426172813306"
		ElseIf cmbICAO10.Text = "CYYQ" Then
			'txtPort.Text = "Churchill Falls"
			txtLatRad.Text = "1.02520640262147"
			txtLongRad.Text = "1.64177304970933"
		ElseIf cmbICAO10.Text = "CYYR" Then
			'txtPort.Text = "Goose Bay"
			txtLatRad.Text = "0.930609557163376"
			txtLongRad.Text = "1.05464428933844"
		ElseIf cmbICAO10.Text = "CYYT" Then
			'txtPort.Text = "St John's, NFLD"
			txtLatRad.Text = "0.831096700978833"
			txtLongRad.Text = "0.920690269247875"
		ElseIf cmbICAO10.Text = "DAAG" Then
			'txtPort.Text = "Algiers, Algeria"
			txtLatRad.Text = "0.640419480198453"
			txtLongRad.Text = "-0.0561705130933508"
		ElseIf cmbICAO10.Text = "DIAP" Then
			'txtPort.Text = "Abidjan"
			txtLatRad.Text = "0.0916588745505689"
			txtLongRad.Text = "0.0685623507825106"
		ElseIf cmbICAO10.Text = "DNMM" Then
			'txtPort.Text = "Lagos, Nigeria"
			txtLatRad.Text = "0.114755398318627"
			txtLongRad.Text = "-0.0579158423453452"
		ElseIf cmbICAO10.Text = "DRRN" Then
			'txtPort.Text = "Niami, Niger"
			txtLatRad.Text = "0.235299471989702"
			txtLongRad.Text = "-0.0379318224100101"
		ElseIf cmbICAO10.Text = "EBBR" Then
			'txtPort.Text = "Brussels"
			txtLatRad.Text = "0.88840167808598"
			txtLongRad.Text = "-0.0785107275188782"
		ElseIf cmbICAO10.Text = "EDDW" Then
			'txtPort.Text = "Bremen, Germany"
			txtLatRad.Text = "0.925868079362125"
			txtLongRad.Text = "-0.153385352429435"
		ElseIf cmbICAO10.Text = "EFHK" Then
			'txtPort.Text = "Helsinki, Finland"
			txtLatRad.Text = "1.05272442716125"
			txtLongRad.Text = "-0.435750536581251"
		ElseIf cmbICAO10.Text = "EGPD" Then
			'txtPort.Text = "Aberdeen"
			txtLatRad.Text = "0.998415598603356"
			txtLongRad.Text = "0.0383681547230087"
		ElseIf cmbICAO10.Text = "EGPK" Then
			'txtPort.Text = "Prestwick"
			txtLatRad.Text = "0.968686823677719"
			txtLongRad.Text = "0.0798779020996071"
		ElseIf cmbICAO10.Text = "EHBK" Then
			'txtPort.Text = "Maastricht, Netherlands"
			txtLatRad.Text = "0.888663477473779"
			txtLongRad.Text = "-0.100821853123539"
		ElseIf cmbICAO10.Text = "EINN" Then
			'txtPort.Text = "Shannon"
			txtLatRad.Text = "0.919788515801012"
			txtLongRad.Text = "0.155741546919627"
		ElseIf cmbICAO10.Text = "EKCH" Then
			txtPort.Text = "Copenhagen"
			txtLatRad.Text = "0.97054850821318"
			txtLongRad.Text = "-0.220493262168617"
		ElseIf cmbICAO10.Text = "ELLX" Then
			'txtPort.Text = "Luxembourg"
			txtLatRad.Text = "0.86609055248132"
			txtLongRad.Text = "-0.108297680086248"
		ElseIf cmbICAO10.Text = "ENBR" Then
			'txtPort.Text = "Bergen, Norway"
			txtLatRad.Text = "1.05231718366911"
			txtLongRad.Text = "-0.091106186954104"
		ElseIf cmbICAO10.Text = "FAGM" Then
			'txtPort.Text = "Rand"
			txtLatRad.Text = "-0.458003484544179"
			txtLongRad.Text = "-0.49133927325727"
		ElseIf cmbICAO10.Text = "FALA" Then
			'txtPort.Text = "Lanseria, RSA"
			txtLatRad.Text = "-0.452622052683863"
			txtLongRad.Text = "-0.48735410479855"
		ElseIf cmbICAO10.Text = "FAWM" Then
			'txtPort.Text = "Windhoek"
			txtLatRad.Text = "-0.392379104669192"
			txtLongRad.Text = "-0.304967197965142"
		ElseIf cmbICAO10.Text = "FCBB" Then
			'txtPort.Text = "Brazzaville, Congo"
			txtLatRad.Text = "-0.0742928484932253"
			txtLongRad.Text = "-0.266162710929135"
		ElseIf cmbICAO10.Text = "FEFF" Then
			'txtPort.Text = "Bangui, CAE"
			txtLatRad.Text = "0.0767653982668839"
			txtLongRad.Text = "-0.323264066290216"
		ElseIf cmbICAO10.Text = "FMMI" Then
			'txtPort.Text = "Antananarivo, Madagascar"
			txtLatRad.Text = "-0.328063721733201"
			txtLongRad.Text = "-0.828624151205175"
		ElseIf cmbICAO10.Text = "FNLU" Then
			'txtPort.Text = "Luanda"
			txtLatRad.Text = "-0.154548905264098"
			txtLongRad.Text = "-0.231023415322316"
		ElseIf cmbICAO10.Text = "FOOL" Then
			'txtPort.Text = "Libreville"
			txtLatRad.Text = "-0.00799942573830734"
			txtLongRad.Text = "-0.164322749075266"
		ElseIf cmbICAO10.Text = "FSIA" Then
			'txtPort.Text = "Seychelles Intl"
			txtLatRad.Text = "-0.0815359648890018"
			txtLongRad.Text = "-0.969064978348985"
		ElseIf cmbICAO10.Text = "FVHA" Then
			'txtPort.Text = "Harare, Zimbabwe"
			txtLatRad.Text = "-0.31296662370345"
			txtLongRad.Text = "-0.54268104208677"
		ElseIf cmbICAO10.Text = "FZNA" Then
			'txtPort.Text = "Goma, Zaire"
			txtLatRad.Text = "-0.0290888208665722"
			txtLongRad.Text = "-0.510217917999676"
		ElseIf cmbICAO10.Text = "GBYD" Then
			'txtPort.Text = "Banjul"
			txtLatRad.Text = "0.23285601103691"
			txtLongRad.Text = "0.290742764561389"
		ElseIf cmbICAO10.Text = "GCXO" Then
			'txtPort.Text = "Tenerife"
			txtLatRad.Text = "0.497157037431"
			txtLongRad.Text = "0.2851867998"
		ElseIf cmbICAO10.Text = "GMAA" Then
			'txtPort.Text = "Agadir"
			txtLatRad.Text = "0.530260115577"
			txtLongRad.Text = "0.1667080324"
		ElseIf cmbICAO10.Text = "GOOY" Then
			'txtPort.Text = "Dakar"
			txtLatRad.Text = "0.257290620565"
			txtLongRad.Text = "0.3052580862"
		ElseIf cmbICAO10.Text = "HELX" Then
			'txtPort.Text = "Luxor"
			txtLatRad.Text = "0.447967841345"
			txtLongRad.Text = "-0.570722665"
		ElseIf cmbICAO10.Text = "HKNW" Then
			'txtPort.Text = "Nairobi-Wilson"
			txtLatRad.Text = "-0.02298016848"
			txtLongRad.Text = "-0.642572053"
		ElseIf cmbICAO10.Text = "HSSS" Then
			'txtPort.Text = "Khartoum"
			txtLatRad.Text = "0.272271363311"
			txtLongRad.Text = "-0.568250116"
		ElseIf cmbICAO10.Text = "HTDA" Then
			'txtPort.Text = "Dar-Es-Salaam"
			txtLatRad.Text = "-0.11999138607"
			txtLongRad.Text = "-0.684198156"
		ElseIf cmbICAO10.Text = "I69" Then
			'txtPort.Text = "Batavia, OH"
			txtLatRad.Text = "0.682045582859"
			txtLongRad.Text = "1.4697417631"
		ElseIf cmbICAO10.Text = "KANC" Then
			'txtPort.Text = "Anchorage"
			txtLatRad.Text = "1.067292108651"
			txtLongRad.Text = "2.6215601674"
		ElseIf cmbICAO10.Text = "KBGR" Then
			'txtPort.Text = "Bangor"
			txtLatRad.Text = "0.782052948998"
			txtLongRad.Text = "1.2012810353"
		ElseIf cmbICAO10.Text = "KBOI" Then
			'txtPort.Text = "Boise"
			txtLatRad.Text = "0.760352688631"
			txtLongRad.Text = "2.0285089231"
		ElseIf cmbICAO10.Text = "KCAE" Then
			'txtPort.Text = "Columbia, SC"
			txtLatRad.Text = "0.592364748127"
			txtLongRad.Text = "1.4158110892"
		ElseIf cmbICAO10.Text = "KEWK" Then
			'txtPort.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO10.Text = "KICT" Then
			'txtPort.Text = "Wichita, KS"
			txtLatRad.Text = "0.657116463376"
			txtLongRad.Text = "1.7005324679"
		ElseIf cmbICAO10.Text = "KIDP" Then
			'txtPort.Text = "Independence, KS"
			txtLatRad.Text = "0.648535261220"
			txtLongRad.Text = "1.6716472687"
		ElseIf cmbICAO10.Text = "KJNU" Then
			'txtPort.Text = "Juneau, AK"
			txtLatRad.Text = "1.018545062643"
			txtLongRad.Text = "2.3488738036"
		ElseIf cmbICAO10.Text = "KMIA" Then
			'txtPort.Text = "Miami, FL"
			txtLatRad.Text = "0.450178591731"
			txtLongRad.Text = "1.4013248564"
		ElseIf cmbICAO10.Text = "KMSP" Then
			'txtPort.Text = "Minneapolis, MN"
			txtLatRad.Text = "0.783391034758"
			txtLongRad.Text = "1.6269086622"
		ElseIf cmbICAO10.Text = "KNUD" Then
			'txtPort.Text = "ADAK, AK"
			txtLatRad.Text = "0.905348825123"
			txtLongRad.Text = "3.0835022783"
		ElseIf cmbICAO10.Text = "KOAK" Then
			'txtPort.Text = "Oakland, CA"
			txtLatRad.Text = "0.658454549136"
			txtLongRad.Text = "2.1331995894"
		ElseIf cmbICAO10.Text = "KPDK" Then
			'txtPort.Text = "Atlanta, GA"
			txtLatRad.Text = "0.590648507696"
			txtLongRad.Text = "1.4713416483"
		ElseIf cmbICAO10.Text = "KVRB" Then
			'txtPort.Text = "Vero Beach"
			txtLatRad.Text = "0.482670804639"
			txtLongRad.Text = "1.4035356068"
		ElseIf cmbICAO10.Text = "LCPH" Then
			'txtPort.Text = "Larnaca, Cyprus"
			txtLatRad.Text = "0.608741754275"
			txtLongRad.Text = "-0.586954227"
		ElseIf cmbICAO10.Text = "LEMD" Then
			'txtPort.Text = "Madrid"
			txtLatRad.Text = "0.706392925924"
			txtLongRad.Text = "-0.062133721"
		ElseIf cmbICAO10.Text = "LEMG" Then
			'txtPort.Text = "Malaga"
			txtLatRad.Text = "0.640099503169"
			txtLongRad.Text = "0.0784816387"
		ElseIf cmbICAO10.Text = "LFPN" Then
			'txtPort.Text = "Toussus Le Noble"
			txtLatRad.Text = "0.850877099168"
			txtLongRad.Text = "-0.036739181"
		ElseIf cmbICAO10.Text = "LGAT" Then
			'txtPort.Text = "Athens"
			txtLatRad.Text = "0.661247075939"
			txtLongRad.Text = "-0.414166631"
		ElseIf cmbICAO10.Text = "LGIR" Then
			'txtPort.Text = "Iraklion"
			txtLatRad.Text = "0.616770268834"
			txtLongRad.Text = "-0.439444817"
		ElseIf cmbICAO10.Text = "LIRA" Then
			'txtPort.Text = "Rome"
			txtLatRad.Text = "0.729518538513"
			txtLongRad.Text = "-0.219824219"
		ElseIf cmbICAO10.Text = "LKPR" Then
			'txtPort.Text = "Prague, Czech"
			txtLatRad.Text = "0.874439044070"
			txtLongRad.Text = "-0.248913040"
		ElseIf cmbICAO10.Text = "LPAZ" Then
			'txtPort.Text = "Santa Maria"
			txtLatRad.Text = "0.645306402104"
			txtLongRad.Text = "0.4393284615"
		ElseIf cmbICAO10.Text = "LPPR" Then
			'txtPort.Text = "Porto, Portugal"
			txtLatRad.Text = "0.719657428239"
			txtLongRad.Text = "0.1514364014"
		ElseIf cmbICAO10.Text = "LROP" Then
			'txtPort.Text = "Bucharest, Romania"
			txtLatRad.Text = "0.777893247614"
			txtLongRad.Text = "-0.455298224"
		ElseIf cmbICAO10.Text = "LTAC" Then
			'txtPort.Text = "Ankara"
			txtLatRad.Text = "0.700313362363"
			txtLongRad.Text = "-0.575842298"
		ElseIf cmbICAO10.Text = "LTBA" Then
			'txtPort.Text = "Istanbul, Turkey"
			txtLatRad.Text = "0.715177749826"
			txtLongRad.Text = "-0.502945713"
		ElseIf cmbICAO10.Text = "MROC" Then
			'txtPort.Text = "San Jose, CR"
			txtLatRad.Text = "0.174416569916"
			txtLongRad.Text = "1.4697708519"
		ElseIf cmbICAO10.Text = "NTSU" Then
			'txtPort.Text = "Pago Pago"
			txtLatRad.Text = "0.250192948273"
			txtLongRad.Text = "2.9794515661"
		ElseIf cmbICAO10.Text = "NZAA" Then
			'txtPort.Text = "Auckland"
			txtLatRad.Text = "-0.64588817852"
			txtLongRad.Text = "-3.050690088"
		ElseIf cmbICAO10.Text = "OOMS" Then
			'txtPort.Text = "SEEB, Oman"
			txtLatRad.Text = "0.411781348187"
			txtLongRad.Text = "-1.017148799"
		ElseIf cmbICAO10.Text = "OPKC" Then
			'txtPort.Text = "Karachi"
			txtLatRad.Text = "0.434703339030"
			txtLongRad.Text = "-1.172104948"
		ElseIf cmbICAO10.Text = "PAOM" Then
			'txtPort.Text = "Nome, AK"
			txtLatRad.Text = "1.125970078103"
			txtLongRad.Text = "2.8875308921"
		ElseIf cmbICAO10.Text = "PGSN" Then
			'txtPort.Text = "Saipan"
			txtLatRad.Text = "0.263922871722"
			txtLongRad.Text = "-2.543526497"
		ElseIf cmbICAO10.Text = "PHNL" Then
			'txtPort.Text = "Honolulu, HI"
			txtLatRad.Text = "0.372075107704"
			txtLongRad.Text = "2.7562821324"
		ElseIf cmbICAO10.Text = "PHTO" Then
			'txtPort.Text = "HILO"
			txtLatRad.Text = "0.344237106135"
			txtLongRad.Text = "2.7061620940"
		ElseIf cmbICAO10.Text = "PKMJ" Then
			'txtPort.Text = "Majuro"
			txtLatRad.Text = "0.123249334012"
			txtLongRad.Text = "-2.989312676"
		ElseIf cmbICAO10.Text = "PLCH" Then
			'txtPort.Text = "Christmas Island"
			txtLatRad.Text = "0.034702963294"
			txtLongRad.Text = "2.7463628445"
		ElseIf cmbICAO10.Text = "PMDY" Then
			'txtPort.Text = "Midway"
			txtLatRad.Text = "0.492386470808"
			txtLongRad.Text = "3.0958650272"
		ElseIf cmbICAO10.Text = "PTRO" Then
			'txtPort.Text = "Palau"
			txtLatRad.Text = "0.128543499409"
			txtLongRad.Text = "-2.348369597"
		ElseIf cmbICAO10.Text = "PWAK" Then
			'txtPort.Text = "WAKE"
			txtLatRad.Text = "0.336499479785"
			txtLongRad.Text = "-2.908445754"
		ElseIf cmbICAO10.Text = "RCTP" Then
			'txtPort.Text = "Chiang Kai Shek"
			txtLatRad.Text = "0.437699487579"
			txtLongRad.Text = "-2.115717208"
		ElseIf cmbICAO10.Text = "RJCK" Then
			'txtPort.Text = "Kushiro"
			txtLatRad.Text = "0.751218798879"
			txtLongRad.Text = "-2.516677515"
		ElseIf cmbICAO10.Text = "RJTT" Then
			'txtPort.Text = "Tokyo"
			txtLatRad.Text = "0.620580904367"
			txtLongRad.Text = "-2.437643189"
		ElseIf cmbICAO10.Text = "RKSS" Then
			'txtPort.Text = "Seoul, Korea"
			txtLatRad.Text = "0.655429311766"
			txtLongRad.Text = "-2.213077492"
		ElseIf cmbICAO10.Text = "RPMM" Then
			'txtPort.Text = "Manilla"
			txtLatRad.Text = "0.253218185644"
			txtLongRad.Text = "-2.112197461"
		ElseIf cmbICAO10.Text = "SAEZ" Then
			'txtPort.Text = "Ezeiza"
			txtLatRad.Text = "-0.60772364554"
			txtLongRad.Text = "1.0215993888"
		ElseIf cmbICAO10.Text = "SBEG" Then
			'txtPort.Text = "Manaus"
			txtLatRad.Text = "-0.05305800926"
			txtLongRad.Text = "1.0480120382"
		ElseIf cmbICAO10.Text = "SBGL" Then
			'txtPort.Text = "Rio De Janeiro, Brazil"
			txtLatRad.Text = "-0.39810960238"
			txtLongRad.Text = "0.7548549015"
		ElseIf cmbICAO10.Text = "SBSP" Then
			'txtPort.Text = "Sao Paulo"
			txtLatRad.Text = "-0.41233403578"
			txtLongRad.Text = "0.8143124513"
		ElseIf cmbICAO10.Text = "SCEL" Then
			'txtPort.Text = "Santiago, Chile"
			txtLatRad.Text = "-0.58279452606"
			txtLongRad.Text = "1.2354022222"
		ElseIf cmbICAO10.Text = "SVMG" Then
			'txtPort.Text = "Margarita, VE"
			txtLatRad.Text = "0.190531776676"
			txtLongRad.Text = "1.1163998560"
		ElseIf cmbICAO10.Text = "TTPP" Then
			'txtPort.Text = "Picaro"
			txtLatRad.Text = "0.184888545428"
			txtLongRad.Text = "1.0705558744"
		ElseIf cmbICAO10.Text = "UHHH" Then
			'txtPort.Text = "Khabarovsk, Russia"
			txtLatRad.Text = "0.846950108351"
			txtLongRad.Text = "-2.359452438"
		ElseIf cmbICAO10.Text = "UHMM" Then
			'txtPort.Text = "Magadan, Russia"
			txtLatRad.Text = "1.045743110153"
			txtLongRad.Text = "-2.630502071"
		ElseIf cmbICAO10.Text = "UHPP" Then
			'txtPort.Text = "Petropavlovsk, Russia"
			txtLatRad.Text = "0.927933385644"
			txtLongRad.Text = "-2.7654742"
		ElseIf cmbICAO10.Text = "UHSS" Then
			'txtPort.Text = "Yuzhno, Russia"
			txtLatRad.Text = "0.700720605855"
			txtLongRad.Text = "-2.490730287"
		ElseIf cmbICAO10.Text = "UTTT" Then
			'txtPort.Text = "Tashkent, Russia"
			txtLatRad.Text = "0.719948316448"
			txtLongRad.Text = "-1.209222283"
		ElseIf cmbICAO10.Text = "UUEE" Then
			'txtPort.Text = "Moscow, Russia"
			txtLatRad.Text = "0.976889871162"
			txtLongRad.Text = "-0.65301494"
		ElseIf cmbICAO10.Text = "VABB" Then
			'txtPort.Text = "Bombay"
			txtLatRad.Text = "0.333212443027"
			txtLongRad.Text = "-1.271763248"
		ElseIf cmbICAO10.Text = "VCBI" Then
			'txtPort.Text = "Columbo, Sri Lanka"
			txtLatRad.Text = "0.125314640293"
			txtLongRad.Text = "-1.394227184"
		ElseIf cmbICAO10.Text = "VIDP" Then
			'txtPort.Text = "Delhi"
			txtLatRad.Text = "0.498582389653"
			txtLongRad.Text = "-1.345648853"
		ElseIf cmbICAO10.Text = "VNKT" Then
			'txtPort.Text = "Katmandu, Nepal"
			txtLatRad.Text = "0.485230620875"
			txtLongRad.Text = "-1.489842138"
		ElseIf cmbICAO10.Text = "VOMM" Then
			'txtPort.Text = "Madras"
			txtLatRad.Text = "0.226805536297"
			txtLongRad.Text = "-1.399346817"
		ElseIf cmbICAO10.Text = "VOPB" Then
			'txtPort.Text = "Port Blair, Nicobar"
			txtLatRad.Text = "0.203272680216"
			txtLongRad.Text = "-1.618531082"
		ElseIf cmbICAO10.Text = "VRMM" Then
			'txtPort.Text = "Male, Maldives"
			txtLatRad.Text = "0.073158384479"
			txtLongRad.Text = "-1.283398777"
		ElseIf cmbICAO10.Text = "VTBD" Then
			'txtPort.Text = "Bangkok"
			txtLatRad.Text = "0.242891654236"
			txtLongRad.Text = "-1.755888494"
		ElseIf cmbICAO10.Text = "WMKJ" Then
			'txtPort.Text = "Johor Bahru, Malaysia"
			txtLatRad.Text = "0.028594310912"
			txtLongRad.Text = "-1.809411924"
		ElseIf cmbICAO10.Text = "WMKK" Then
			'txtPort.Text = "Kuala Lumpur"
			txtLatRad.Text = "0.054628805587"
			txtLongRad.Text = "-1.772410944"
		ElseIf cmbICAO10.Text = "WSSL" Then
			'txtPort.Text = "Singapore"
			txtLatRad.Text = "0.024725497737"
			txtLongRad.Text = "-1.812815316"
		ElseIf cmbICAO10.Text = "ZGGG" Then
			'txtPort.Text = "Guangzhou"
			txtLatRad.Text = "0.404625498254"
			txtLongRad.Text = "-1.976847177"
		ElseIf cmbICAO10.Text = "Other" Then
			txtICAO10.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
			txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
			txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
			txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
			txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
			intLatDeg = CDbl(txtLatDeg.Text)
			intLatMin = CDbl(txtLatMin.Text)
			intLatSec = CDbl(txtLatSec.Text)
			intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
			If txtNS.Text = "S" Then
				intLatRad = intLatRad * -1
			ElseIf txtNS.Text = "s" Then
				intLatRad = intLatRad * -1
			End If
			txtLatRad.Text = CStr(intLatRad / (180 / 3.141592654))
			txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
			txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
			txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
			txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
			intLongDeg = CDbl(txtLongDeg.Text)
			intLongMin = CDbl(txtLongMin.Text)
			intLongSec = CDbl(txtLongSec.Text)
			intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
			If txtEW.Text = "E" Then
				intLongRad = intLongRad * -1
			ElseIf txtEW.Text = "e" Then
				intLongRad = intLongRad * -1
			End If
			txtLongRad.Text = CStr(intLongRad / (180 / 3.141592654))
			cmbICAO10.Visible = False
			'cmbICAO10 = txtICAO10
			cmbICAO11.Focus()
		End If

	End Sub

	'UPGRADE_WARNING: Event cmbICAO11.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	<Obsolete>
	Private Sub cmbICAO11_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO11.SelectedIndexChanged

		If cmbICAO12.Text <> "" Then

			cmbICAO12.Text = ""
			cmbICAO13.Text = ""
			cmbICAO14.Text = ""
			cmbICAO15.Text = ""
			txtPort6.Text = ""
			txtPort7.Text = ""
			txtLeg6.Text = ""
			txtLeg7.Text = ""
			txtTotal6.Text = ""
			txtTotal7.Text = ""

			Call cmbICAO10_SelectedIndexChanged(cmbICAO10, New System.EventArgs())

		End If

		If cmbICAO11.Text = cmbICAO10.Text Then
			Call MsgBox("Please re-enter destination, not equal to origination.", MsgBoxStyle.OKOnly, "Re-enter Destination")
			cmbICAO11.Text = ""
			cmbICAO11.Focus()
			Exit Sub
		ElseIf cmbICAO11.Text = "ASSY" Then
			txtPort5.Text = "Sidney"
			txtLatRad1.Text = "-0.592248392843409"
			txtLongRad1.Text = "-2.63835605259809"
		ElseIf cmbICAO11.Text = "AYPY" Then
			txtPort5.Text = "Port Moresby, PNG"
			txtLatRad1.Text = "-0.164817259029998"
			txtLongRad1.Text = "-2.56941554714432"
		ElseIf cmbICAO11.Text = "BGBW" Then
			txtPort5.Text = "Narsarsuaq"
			txtLatRad1.Text = "1.0674724593406"
			txtLongRad1.Text = "0.792873990360157"
		ElseIf cmbICAO11.Text = "BGGH" Then
			txtPort5.Text = "Godthab"
			txtLatRad1.Text = "1.12035593567603"
			txtLongRad1.Text = "0.902044335072403"
		ElseIf cmbICAO11.Text = "BIRK" Then
			txtPort5.Text = "Reykjavik"
			txtLatRad1.Text = "1.1192505604831"
			txtLongRad1.Text = "0.382983415529289"
		ElseIf cmbICAO11.Text = "CYAM" Then
			txtPort5.Text = "Sault Ste. Marie"
			txtLatRad1.Text = "0.811316302789564"
			txtLongRad1.Text = "1.47497775086041"
		ElseIf cmbICAO11.Text = "CYFB" Then
			txtPort5.Text = "Iqaluit"
			txtLatRad1.Text = "1.11276375342985"
			txtLongRad1.Text = "1.19653955752558"
		ElseIf cmbICAO11.Text = "CYQX" Then
			txtPort5.Text = "Gander"
			txtLatRad1.Text = "0.854164135926025"
			txtLongRad1.Text = "0.952426172813306"
		ElseIf cmbICAO11.Text = "CYYQ" Then
			txtPort5.Text = "Churchill Falls"
			txtLatRad1.Text = "1.02520640262147"
			txtLongRad1.Text = "1.64177304970933"
		ElseIf cmbICAO11.Text = "CYYR" Then
			txtPort5.Text = "Goose Bay"
			txtLatRad1.Text = "0.930609557163376"
			txtLongRad1.Text = "1.05464428933844"
		ElseIf cmbICAO11.Text = "CYYT" Then
			txtPort5.Text = "St John's, NFLD"
			txtLatRad1.Text = "0.831096700978833"
			txtLongRad1.Text = "0.920690269247875"
		ElseIf cmbICAO11.Text = "DAAG" Then
			txtPort5.Text = "Algiers, Algeria"
			txtLatRad1.Text = "0.640419480198453"
			txtLongRad1.Text = "-0.0561705130933508"
		ElseIf cmbICAO11.Text = "DIAP" Then
			txtPort5.Text = "Abidjan"
			txtLatRad1.Text = "0.0916588745505689"
			txtLongRad1.Text = "0.0685623507825106"
		ElseIf cmbICAO11.Text = "DNMM" Then
			txtPort5.Text = "Lagos, Nigeria"
			txtLatRad1.Text = "0.114755398318627"
			txtLongRad1.Text = "-0.0579158423453452"
		ElseIf cmbICAO11.Text = "DRRN" Then
			txtPort5.Text = "Niami, Niger"
			txtLatRad1.Text = "0.235299471989702"
			txtLongRad1.Text = "-0.0379318224100101"
		ElseIf cmbICAO11.Text = "EBBR" Then
			txtPort5.Text = "Brussels"
			txtLatRad1.Text = "0.88840167808598"
			txtLongRad1.Text = "-0.0785107275188782"
		ElseIf cmbICAO11.Text = "EDDW" Then
			txtPort5.Text = "Bremen, Germany"
			txtLatRad1.Text = "0.925868079362125"
			txtLongRad1.Text = "-0.153385352429435"
		ElseIf cmbICAO11.Text = "EFHK" Then
			txtPort5.Text = "Helsinki, Finland"
			txtLatRad1.Text = "1.05272442716125"
			txtLongRad1.Text = "-0.435750536581251"
		ElseIf cmbICAO11.Text = "EGPD" Then
			txtPort5.Text = "Aberdeen"
			txtLatRad1.Text = "0.998415598603356"
			txtLongRad1.Text = "0.0383681547230087"
		ElseIf cmbICAO11.Text = "EGPK" Then
			txtPort5.Text = "Prestwick"
			txtLatRad1.Text = "0.968686823677719"
			txtLongRad1.Text = "0.0798779020996071"
		ElseIf cmbICAO11.Text = "EHBK" Then
			txtPort5.Text = "Maastricht, Netherlands"
			txtLatRad1.Text = "0.888663477473779"
			txtLongRad1.Text = "-0.100821853123539"
		ElseIf cmbICAO11.Text = "EINN" Then
			txtPort5.Text = "Shannon"
			txtLatRad1.Text = "0.919788515801012"
			txtLongRad1.Text = "0.155741546919627"
		ElseIf cmbICAO11.Text = "EKCH" Then
			txtPort5.Text = "Copenhagen"
			txtLatRad1.Text = "0.97054850821318"
			txtLongRad1.Text = "-0.220493262168617"
		ElseIf cmbICAO11.Text = "ELLX" Then
			txtPort5.Text = "Luxembourg"
			txtLatRad1.Text = "0.86609055248132"
			txtLongRad1.Text = "-0.108297680086248"
		ElseIf cmbICAO11.Text = "ENBR" Then
			txtPort5.Text = "Bergen, Norway"
			txtLatRad1.Text = "1.05231718366911"
			txtLongRad1.Text = "-0.091106186954104"
		ElseIf cmbICAO11.Text = "FAGM" Then
			txtPort5.Text = "Rand"
			txtLatRad1.Text = "-0.458003484544179"
			txtLongRad1.Text = "-0.49133927325727"
		ElseIf cmbICAO11.Text = "FALA" Then
			txtPort5.Text = "Lanseria, RSA"
			txtLatRad1.Text = "-0.452622052683863"
			txtLongRad1.Text = "-0.48735410479855"
		ElseIf cmbICAO11.Text = "FAWM" Then
			txtPort5.Text = "Windhoek"
			txtLatRad1.Text = "-0.392379104669192"
			txtLongRad1.Text = "-0.304967197965142"
		ElseIf cmbICAO11.Text = "FCBB" Then
			txtPort5.Text = "Brazzaville, Congo"
			txtLatRad1.Text = "-0.0742928484932253"
			txtLongRad1.Text = "-0.266162710929135"
		ElseIf cmbICAO11.Text = "FEFF" Then
			txtPort5.Text = "Bangui, CAE"
			txtLatRad1.Text = "0.0767653982668839"
			txtLongRad1.Text = "-0.323264066290216"
		ElseIf cmbICAO11.Text = "FMMI" Then
			txtPort5.Text = "Antananarivo, Madagascar"
			txtLatRad1.Text = "-0.328063721733201"
			txtLongRad1.Text = "-0.828624151205175"
		ElseIf cmbICAO11.Text = "FNLU" Then
			txtPort5.Text = "Luanda"
			txtLatRad1.Text = "-0.154548905264098"
			txtLongRad1.Text = "-0.231023415322316"
		ElseIf cmbICAO11.Text = "FOOL" Then
			txtPort5.Text = "Libreville"
			txtLatRad1.Text = "-0.00799942573830734"
			txtLongRad1.Text = "-0.164322749075266"
		ElseIf cmbICAO11.Text = "FSIA" Then
			txtPort5.Text = "Seychelles Intl"
			txtLatRad1.Text = "-0.0815359648890018"
			txtLongRad1.Text = "-0.969064978348985"
		ElseIf cmbICAO11.Text = "FVHA" Then
			txtPort5.Text = "Harare, Zimbabwe"
			txtLatRad1.Text = "-0.31296662370345"
			txtLongRad1.Text = "-0.54268104208677"
		ElseIf cmbICAO11.Text = "FZNA" Then
			txtPort5.Text = "Goma, Zaire"
			txtLatRad1.Text = "-0.0290888208665722"
			txtLongRad1.Text = "-0.510217917999676"
		ElseIf cmbICAO11.Text = "GBYD" Then
			txtPort5.Text = "Banjul"
			txtLatRad1.Text = "0.23285601103691"
			txtLongRad1.Text = "0.290742764561389"
		ElseIf cmbICAO11.Text = "GCXO" Then
			txtPort5.Text = "Tenerife"
			txtLatRad1.Text = "0.497157037431"
			txtLongRad1.Text = "0.2851867998"
		ElseIf cmbICAO11.Text = "GMAA" Then
			txtPort5.Text = "Agadir"
			txtLatRad1.Text = "0.530260115577"
			txtLongRad1.Text = "0.1667080324"
		ElseIf cmbICAO11.Text = "GOOY" Then
			txtPort5.Text = "Dakar"
			txtLatRad1.Text = "0.257290620565"
			txtLongRad1.Text = "0.3052580862"
		ElseIf cmbICAO11.Text = "HELX" Then
			txtPort5.Text = "Luxor"
			txtLatRad1.Text = "0.447967841345"
			txtLongRad1.Text = "-0.570722665"
		ElseIf cmbICAO11.Text = "HKNW" Then
			txtPort5.Text = "Nairobi-Wilson"
			txtLatRad1.Text = "-0.02298016848"
			txtLongRad1.Text = "-0.642572053"
		ElseIf cmbICAO11.Text = "HSSS" Then
			txtPort5.Text = "Khartoum"
			txtLatRad1.Text = "0.272271363311"
			txtLongRad1.Text = "-0.568250116"
		ElseIf cmbICAO11.Text = "HTDA" Then
			txtPort5.Text = "Dar-Es-Salaam"
			txtLatRad1.Text = "-0.11999138607"
			txtLongRad1.Text = "-0.684198156"
		ElseIf cmbICAO11.Text = "I69" Then
			txtPort5.Text = "Batavia, OH"
			txtLatRad1.Text = "0.682045582859"
			txtLongRad1.Text = "1.4697417631"
		ElseIf cmbICAO11.Text = "KANC" Then
			txtPort5.Text = "Anchorage"
			txtLatRad1.Text = "1.067292108651"
			txtLongRad1.Text = "2.6215601674"
		ElseIf cmbICAO11.Text = "KBGR" Then
			txtPort5.Text = "Bangor"
			txtLatRad1.Text = "0.782052948998"
			txtLongRad1.Text = "1.2012810353"
		ElseIf cmbICAO11.Text = "KBOI" Then
			txtPort5.Text = "Boise"
			txtLatRad1.Text = "0.760352688631"
			txtLongRad1.Text = "2.0285089231"
		ElseIf cmbICAO11.Text = "KCAE" Then
			txtPort5.Text = "Columbia, SC"
			txtLatRad1.Text = "0.592364748127"
			txtLongRad1.Text = "1.4158110892"
		ElseIf cmbICAO11.Text = "KEWK" Then
			txtPort5.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO11.Text = "KICT" Then
			txtPort5.Text = "Wichita, KS"
			txtLatRad1.Text = "0.657116463376"
			txtLongRad1.Text = "1.7005324679"
		ElseIf cmbICAO11.Text = "KIDP" Then
			txtPort5.Text = "Independence, KS"
			txtLatRad1.Text = "0.648535261220"
			txtLongRad1.Text = "1.6716472687"
		ElseIf cmbICAO11.Text = "KJNU" Then
			txtPort5.Text = "Juneau, AK"
			txtLatRad1.Text = "1.018545062643"
			txtLongRad1.Text = "2.3488738036"
		ElseIf cmbICAO11.Text = "KMIA" Then
			txtPort5.Text = "Miami, FL"
			txtLatRad1.Text = "0.450178591731"
			txtLongRad1.Text = "1.4013248564"
		ElseIf cmbICAO11.Text = "KMSP" Then
			txtPort5.Text = "Minneapolis, MN"
			txtLatRad1.Text = "0.783391034758"
			txtLongRad1.Text = "1.6269086622"
		ElseIf cmbICAO11.Text = "KNUD" Then
			txtPort5.Text = "ADAK, AK"
			txtLatRad1.Text = "0.905348825123"
			txtLongRad1.Text = "3.0835022783"
		ElseIf cmbICAO11.Text = "KOAK" Then
			txtPort5.Text = "Oakland, CA"
			txtLatRad1.Text = "0.658454549136"
			txtLongRad1.Text = "2.1331995894"
		ElseIf cmbICAO11.Text = "KPDK" Then
			txtPort5.Text = "Atlanta, GA"
			txtLatRad1.Text = "0.590648507696"
			txtLongRad1.Text = "1.4713416483"
		ElseIf cmbICAO11.Text = "KVRB" Then
			txtPort5.Text = "Vero Beach"
			txtLatRad1.Text = "0.482670804639"
			txtLongRad1.Text = "1.4035356068"
		ElseIf cmbICAO11.Text = "LCPH" Then
			txtPort5.Text = "Larnaca, Cyprus"
			txtLatRad1.Text = "0.608741754275"
			txtLongRad1.Text = "-0.586954227"
		ElseIf cmbICAO11.Text = "LEMD" Then
			txtPort5.Text = "Madrid"
			txtLatRad1.Text = "0.706392925924"
			txtLongRad1.Text = "-0.062133721"
		ElseIf cmbICAO11.Text = "LEMG" Then
			txtPort5.Text = "Malaga"
			txtLatRad1.Text = "0.640099503169"
			txtLongRad1.Text = "0.0784816387"
		ElseIf cmbICAO11.Text = "LFPN" Then
			txtPort5.Text = "Toussus Le Noble"
			txtLatRad1.Text = "0.850877099168"
			txtLongRad1.Text = "-0.036739181"
		ElseIf cmbICAO11.Text = "LGAT" Then
			txtPort5.Text = "Athens"
			txtLatRad1.Text = "0.661247075939"
			txtLongRad1.Text = "-0.414166631"
		ElseIf cmbICAO11.Text = "LGIR" Then
			txtPort5.Text = "Iraklion"
			txtLatRad1.Text = "0.616770268834"
			txtLongRad1.Text = "-0.439444817"
		ElseIf cmbICAO11.Text = "LIRA" Then
			txtPort5.Text = "Rome"
			txtLatRad1.Text = "0.729518538513"
			txtLongRad1.Text = "-0.219824219"
		ElseIf cmbICAO11.Text = "LKPR" Then
			txtPort5.Text = "Prague, Czech"
			txtLatRad1.Text = "0.874439044070"
			txtLongRad1.Text = "-0.248913040"
		ElseIf cmbICAO11.Text = "LPAZ" Then
			txtPort5.Text = "Santa Maria"
			txtLatRad1.Text = "0.645306402104"
			txtLongRad1.Text = "0.4393284615"
		ElseIf cmbICAO11.Text = "LPPR" Then
			txtPort5.Text = "Porto, Portugal"
			txtLatRad1.Text = "0.719657428239"
			txtLongRad1.Text = "0.1514364014"
		ElseIf cmbICAO11.Text = "LROP" Then
			txtPort5.Text = "Bucharest, Romania"
			txtLatRad1.Text = "0.777893247614"
			txtLongRad1.Text = "-0.455298224"
		ElseIf cmbICAO11.Text = "LTAC" Then
			txtPort5.Text = "Ankara"
			txtLatRad1.Text = "0.700313362363"
			txtLongRad1.Text = "-0.575842298"
		ElseIf cmbICAO11.Text = "LTBA" Then
			txtPort5.Text = "Istanbul, Turkey"
			txtLatRad1.Text = "0.715177749826"
			txtLongRad1.Text = "-0.502945713"
		ElseIf cmbICAO11.Text = "MROC" Then
			txtPort5.Text = "San Jose, CR"
			txtLatRad1.Text = "0.174416569916"
			txtLongRad1.Text = "1.4697708519"
		ElseIf cmbICAO11.Text = "NTSU" Then
			txtPort5.Text = "Pago Pago"
			txtLatRad1.Text = "0.250192948273"
			txtLongRad1.Text = "2.9794515661"
		ElseIf cmbICAO11.Text = "NZAA" Then
			txtPort5.Text = "Auckland"
			txtLatRad1.Text = "-0.64588817852"
			txtLongRad1.Text = "-3.050690088"
		ElseIf cmbICAO11.Text = "OOMS" Then
			txtPort5.Text = "SEEB, Oman"
			txtLatRad1.Text = "0.411781348187"
			txtLongRad1.Text = "-1.017148799"
		ElseIf cmbICAO11.Text = "OPKC" Then
			txtPort5.Text = "Karachi"
			txtLatRad1.Text = "0.434703339030"
			txtLongRad1.Text = "-1.172104948"
		ElseIf cmbICAO11.Text = "PAOM" Then
			txtPort5.Text = "Nome, AK"
			txtLatRad1.Text = "1.125970078103"
			txtLongRad1.Text = "2.8875308921"
		ElseIf cmbICAO11.Text = "PGSN" Then
			txtPort5.Text = "Saipan"
			txtLatRad1.Text = "0.263922871722"
			txtLongRad1.Text = "-2.543526497"
		ElseIf cmbICAO11.Text = "PHNL" Then
			txtPort5.Text = "Honolulu, HI"
			txtLatRad1.Text = "0.372075107704"
			txtLongRad1.Text = "2.7562821324"
		ElseIf cmbICAO11.Text = "PHTO" Then
			txtPort5.Text = "HILO"
			txtLatRad1.Text = "0.344237106135"
			txtLongRad1.Text = "2.7061620940"
		ElseIf cmbICAO11.Text = "PKMJ" Then
			txtPort5.Text = "Majuro"
			txtLatRad1.Text = "0.123249334012"
			txtLongRad1.Text = "-2.989312676"
		ElseIf cmbICAO11.Text = "PLCH" Then
			txtPort5.Text = "Christmas Island"
			txtLatRad1.Text = "0.034702963294"
			txtLongRad1.Text = "2.7463628445"
		ElseIf cmbICAO11.Text = "PMDY" Then
			txtPort5.Text = "Midway"
			txtLatRad1.Text = "0.492386470808"
			txtLongRad1.Text = "3.0958650272"
		ElseIf cmbICAO11.Text = "PTRO" Then
			txtPort5.Text = "Palau"
			txtLatRad1.Text = "0.128543499409"
			txtLongRad1.Text = "-2.348369597"
		ElseIf cmbICAO11.Text = "PWAK" Then
			txtPort5.Text = "WAKE"
			txtLatRad1.Text = "0.336499479785"
			txtLongRad1.Text = "-2.908445754"
		ElseIf cmbICAO11.Text = "RCTP" Then
			txtPort5.Text = "Chiang Kai Shek"
			txtLatRad1.Text = "0.437699487579"
			txtLongRad1.Text = "-2.115717208"
		ElseIf cmbICAO11.Text = "RJCK" Then
			txtPort5.Text = "Kushiro"
			txtLatRad1.Text = "0.751218798879"
			txtLongRad1.Text = "-2.516677515"
		ElseIf cmbICAO11.Text = "RJTT" Then
			txtPort5.Text = "Tokyo"
			txtLatRad1.Text = "0.620580904367"
			txtLongRad1.Text = "-2.437643189"
		ElseIf cmbICAO11.Text = "RKSS" Then
			txtPort5.Text = "Seoul, Korea"
			txtLatRad1.Text = "0.655429311766"
			txtLongRad1.Text = "-2.213077492"
		ElseIf cmbICAO11.Text = "RPMM" Then
			txtPort5.Text = "Manilla"
			txtLatRad1.Text = "0.253218185644"
			txtLongRad1.Text = "-2.112197461"
		ElseIf cmbICAO11.Text = "SAEZ" Then
			txtPort5.Text = "Ezeiza"
			txtLatRad1.Text = "-0.60772364554"
			txtLongRad1.Text = "1.0215993888"
		ElseIf cmbICAO11.Text = "SBEG" Then
			txtPort5.Text = "Manaus"
			txtLatRad1.Text = "-0.05305800926"
			txtLongRad1.Text = "1.0480120382"
		ElseIf cmbICAO11.Text = "SBGL" Then
			txtPort5.Text = "Rio De Janeiro, Brazil"
			txtLatRad1.Text = "-0.39810960238"
			txtLongRad1.Text = "0.7548549015"
		ElseIf cmbICAO11.Text = "SBSP" Then
			txtPort5.Text = "Sao Paulo"
			txtLatRad1.Text = "-0.41233403578"
			txtLongRad1.Text = "0.8143124513"
		ElseIf cmbICAO11.Text = "SCEL" Then
			txtPort5.Text = "Santiago, Chile"
			txtLatRad1.Text = "-0.58279452606"
			txtLongRad1.Text = "1.2354022222"
		ElseIf cmbICAO11.Text = "SVMG" Then
			txtPort5.Text = "Margarita, VE"
			txtLatRad1.Text = "0.190531776676"
			txtLongRad1.Text = "1.1163998560"
		ElseIf cmbICAO11.Text = "TTPP" Then
			txtPort5.Text = "Picaro"
			txtLatRad1.Text = "0.184888545428"
			txtLongRad1.Text = "1.0705558744"
		ElseIf cmbICAO11.Text = "UHHH" Then
			txtPort5.Text = "Khabarovsk, Russia"
			txtLatRad1.Text = "0.846950108351"
			txtLongRad1.Text = "-2.359452438"
		ElseIf cmbICAO11.Text = "UHMM" Then
			txtPort5.Text = "Magadan, Russia"
			txtLatRad1.Text = "1.045743110153"
			txtLongRad1.Text = "-2.630502071"
		ElseIf cmbICAO11.Text = "UHPP" Then
			txtPort5.Text = "Petropavlovsk, Russia"
			txtLatRad1.Text = "0.927933385644"
			txtLongRad1.Text = "-2.7654742"
		ElseIf cmbICAO11.Text = "UHSS" Then
			txtPort5.Text = "Yuzhno, Russia"
			txtLatRad1.Text = "0.700720605855"
			txtLongRad1.Text = "-2.490730287"
		ElseIf cmbICAO11.Text = "UTTT" Then
			txtPort5.Text = "Tashkent, Russia"
			txtLatRad1.Text = "0.719948316448"
			txtLongRad1.Text = "-1.209222283"
		ElseIf cmbICAO11.Text = "UUEE" Then
			txtPort5.Text = "Moscow, Russia"
			txtLatRad1.Text = "0.976889871162"
			txtLongRad1.Text = "-0.65301494"
		ElseIf cmbICAO11.Text = "VABB" Then
			txtPort5.Text = "Bombay"
			txtLatRad1.Text = "0.333212443027"
			txtLongRad1.Text = "-1.271763248"
		ElseIf cmbICAO11.Text = "VCBI" Then
			txtPort5.Text = "Columbo, Sri Lanka"
			txtLatRad1.Text = "0.125314640293"
			txtLongRad1.Text = "-1.394227184"
		ElseIf cmbICAO11.Text = "VIDP" Then
			txtPort5.Text = "Delhi"
			txtLatRad1.Text = "0.498582389653"
			txtLongRad1.Text = "-1.345648853"
		ElseIf cmbICAO11.Text = "VNKT" Then
			txtPort5.Text = "Katmandu, Nepal"
			txtLatRad1.Text = "0.485230620875"
			txtLongRad1.Text = "-1.489842138"
		ElseIf cmbICAO11.Text = "VOMM" Then
			txtPort5.Text = "Madras"
			txtLatRad1.Text = "0.226805536297"
			txtLongRad1.Text = "-1.399346817"
		ElseIf cmbICAO11.Text = "VOPB" Then
			txtPort5.Text = "Port Blair, Nicobar"
			txtLatRad1.Text = "0.203272680216"
			txtLongRad1.Text = "-1.618531082"
		ElseIf cmbICAO11.Text = "VRMM" Then
			txtPort5.Text = "Male, Maldives"
			txtLatRad1.Text = "0.073158384479"
			txtLongRad1.Text = "-1.283398777"
		ElseIf cmbICAO11.Text = "VTBD" Then
			txtPort5.Text = "Bangkok"
			txtLatRad1.Text = "0.242891654236"
			txtLongRad1.Text = "-1.755888494"
		ElseIf cmbICAO11.Text = "WMKJ" Then
			txtPort5.Text = "Johor Bahru, Malaysia"
			txtLatRad1.Text = "0.028594310912"
			txtLongRad1.Text = "-1.809411924"
		ElseIf cmbICAO11.Text = "WMKK" Then
			txtPort5.Text = "Kuala Lumpur"
			txtLatRad1.Text = "0.054628805587"
			txtLongRad1.Text = "-1.772410944"
		ElseIf cmbICAO11.Text = "WSSL" Then
			txtPort5.Text = "Singapore"
			txtLatRad1.Text = "0.024725497737"
			txtLongRad1.Text = "-1.812815316"
		ElseIf cmbICAO11.Text = "ZGGG" Then
			txtPort5.Text = "Guangzhou"
			txtLatRad1.Text = "0.404625498254"
			txtLongRad1.Text = "-1.976847177"
		ElseIf cmbICAO11.Text = "Other" Then
			'Call ICAO11Other
		End If

		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg3, intLeg2, intLeg4 As Double
		Dim intLeg5 As Double
		If cmbICAO11.Text <> "Other" Then

			Call CalcDist()
			txtLeg5.Text = txtDist.Text
			txtLeg5.Text = VB6.Format(txtLeg5.Text, "Fixed")
			intLeg = CDbl(txtLeg.Text)
			intLeg1 = CDbl(txtLeg1.Text)
			intLeg2 = CDbl(txtLeg2.Text)
			intLeg3 = CDbl(txtLeg3.Text)
			intLeg4 = CDbl(txtLeg4.Text)
			intLeg5 = CDbl(txtLeg5.Text)
			intTotal1 = intLeg + intLeg1 + intLeg2 + intLeg3 + intLeg4 + intLeg5
			txtTotal5.Text = CStr(intTotal1)
			txtTotal5.Text = VB6.Format(txtTotal5.Text, "Fixed")

		Else
			Call ICAO11Other()
		End If

		If cmbICAO11.Text = "Other" Then
			cmbICAO11.Visible = False
			cmbICAO12.Visible = False
			txtICAO12.Text = txtICAO11.Text
			'cmbICAO11 = txtICAO11
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		Else
			cmbICAO12.Text = cmbICAO11.Text
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		End If

		cmbICAO13.Focus()

	End Sub

	<Obsolete>
	Private Sub ICAO11Other()

		txtICAO11.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtPort5.Text = InputBox("Enter Name of Airport.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
		txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
		txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
		txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
		intLatDeg = CDbl(txtLatDeg.Text)
		intLatMin = CDbl(txtLatMin.Text)
		intLatSec = CDbl(txtLatSec.Text)
		intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
		If txtNS.Text = "S" Then
			intLatRad = intLatRad * -1
		ElseIf txtNS.Text = "s" Then
			intLatRad = intLatRad * -1
		End If
		txtLatRad1.Text = CStr(intLatRad / (180 / 3.141592654))
		txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
		txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
		txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
		txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
		intLongDeg = CDbl(txtLongDeg.Text)
		intLongMin = CDbl(txtLongMin.Text)
		intLongSec = CDbl(txtLongSec.Text)
		intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
		If txtEW.Text = "E" Then
			intLongRad = intLongRad * -1
		ElseIf txtEW.Text = "e" Then
			intLongRad = intLongRad * -1
		End If
		txtLongRad1.Text = CStr(intLongRad / (180 / 3.141592654))
		cmbICAO11.Visible = False

		Call CalcDist()
		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg3, intLeg2, intLeg4 As Double
		Dim intLeg5 As Double
		txtLeg5.Text = txtDist.Text
		txtLeg5.Text = VB6.Format(txtLeg5.Text, "Fixed")
		intLeg = CDbl(txtLeg.Text)
		intLeg1 = CDbl(txtLeg1.Text)
		intLeg2 = CDbl(txtLeg2.Text)
		intLeg3 = CDbl(txtLeg3.Text)
		intLeg4 = CDbl(txtLeg4.Text)
		intLeg5 = CDbl(txtLeg5.Text)
		intTotal1 = intLeg + intLeg1 + intLeg2 + intLeg3 + intLeg4 + intLeg5
		txtTotal5.Text = CStr(intTotal1)
		txtTotal5.Text = VB6.Format(txtTotal5.Text, "Fixed")

		strICAO = txtICAO11.Text
		strPort = txtPort5.Text
		strLatRad = txtLatRad1.Text
		strLongRad = txtLongRad1.Text
		FileOpen(1, "Bid ICAO.txt", OpenMode.Append)
		WriteLine(1, strICAO, strPort, strLatRad, strLongRad)
		FileClose(1)
		intLatDeg = 0
		intLatMin = 0
		intLatSec = 0
		intLatRad = 0
		intLongDeg = 0
		intLongMin = 0
		intLongSec = 0
		intLongRad = 0

	End Sub

	'UPGRADE_WARNING: Event cmbICAO12.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cmbICAO12_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO12.SelectedIndexChanged

		If cmbICAO12.Text = "ASSY" Then
			'txtPort.Text = "Sidney"
			txtLatRad.Text = "-0.592248392843409"
			txtLongRad.Text = "-2.63835605259809"
		ElseIf cmbICAO12.Text = "AYPY" Then
			'txtPort.Text = "Port Moresby, PNG"
			txtLatRad.Text = "-0.164817259029998"
			txtLongRad.Text = "-2.56941554714432"
		ElseIf cmbICAO12.Text = "BGBW" Then
			'txtPort.Text = "Narsarsuaq"
			txtLatRad.Text = "1.0674724593406"
			txtLongRad.Text = "0.792873990360157"
		ElseIf cmbICAO12.Text = "BGGH" Then
			'txtPort.Text = "Godthab"
			txtLatRad.Text = "1.12035593567603"
			txtLongRad.Text = "0.902044335072403"
		ElseIf cmbICAO12.Text = "BIRK" Then
			'txtPort.Text = "Reykjavik"
			txtLatRad.Text = "1.1192505604831"
			txtLongRad.Text = "0.382983415529289"
		ElseIf cmbICAO12.Text = "CYAM" Then
			'txtPort.Text = "Sault Ste. Marie"
			txtLatRad.Text = "0.811316302789564"
			txtLongRad.Text = "1.47497775086041"
		ElseIf cmbICAO12.Text = "CYFB" Then
			'txtPort.Text = "Iqaluit"
			txtLatRad.Text = "1.11276375342985"
			txtLongRad.Text = "1.19653955752558"
		ElseIf cmbICAO12.Text = "CYQX" Then
			'txtPort.Text = "Gander"
			txtLatRad.Text = "0.854164135926025"
			txtLongRad.Text = "0.952426172813306"
		ElseIf cmbICAO12.Text = "CYYQ" Then
			'txtPort.Text = "Churchill Falls"
			txtLatRad.Text = "1.02520640262147"
			txtLongRad.Text = "1.64177304970933"
		ElseIf cmbICAO12.Text = "CYYR" Then
			'txtPort.Text = "Goose Bay"
			txtLatRad.Text = "0.930609557163376"
			txtLongRad.Text = "1.05464428933844"
		ElseIf cmbICAO12.Text = "CYYT" Then
			'txtPort.Text = "St John's, NFLD"
			txtLatRad.Text = "0.831096700978833"
			txtLongRad.Text = "0.920690269247875"
		ElseIf cmbICAO12.Text = "DAAG" Then
			'txtPort.Text = "Algiers, Algeria"
			txtLatRad.Text = "0.640419480198453"
			txtLongRad.Text = "-0.0561705130933508"
		ElseIf cmbICAO12.Text = "DIAP" Then
			'txtPort.Text = "Abidjan"
			txtLatRad.Text = "0.0916588745505689"
			txtLongRad.Text = "0.0685623507825106"
		ElseIf cmbICAO12.Text = "DNMM" Then
			'txtPort.Text = "Lagos, Nigeria"
			txtLatRad.Text = "0.114755398318627"
			txtLongRad.Text = "-0.0579158423453452"
		ElseIf cmbICAO12.Text = "DRRN" Then
			'txtPort.Text = "Niami, Niger"
			txtLatRad.Text = "0.235299471989702"
			txtLongRad.Text = "-0.0379318224100101"
		ElseIf cmbICAO12.Text = "EBBR" Then
			'txtPort.Text = "Brussels"
			txtLatRad.Text = "0.88840167808598"
			txtLongRad.Text = "-0.0785107275188782"
		ElseIf cmbICAO12.Text = "EDDW" Then
			'txtPort.Text = "Bremen, Germany"
			txtLatRad.Text = "0.925868079362125"
			txtLongRad.Text = "-0.153385352429435"
		ElseIf cmbICAO12.Text = "EFHK" Then
			'txtPort.Text = "Helsinki, Finland"
			txtLatRad.Text = "1.05272442716125"
			txtLongRad.Text = "-0.435750536581251"
		ElseIf cmbICAO12.Text = "EGPD" Then
			'txtPort.Text = "Aberdeen"
			txtLatRad.Text = "0.998415598603356"
			txtLongRad.Text = "0.0383681547230087"
		ElseIf cmbICAO12.Text = "EGPK" Then
			'txtPort.Text = "Prestwick"
			txtLatRad.Text = "0.968686823677719"
			txtLongRad.Text = "0.0798779020996071"
		ElseIf cmbICAO12.Text = "EHBK" Then
			'txtPort.Text = "Maastricht, Netherlands"
			txtLatRad.Text = "0.888663477473779"
			txtLongRad.Text = "-0.100821853123539"
		ElseIf cmbICAO12.Text = "EINN" Then
			'txtPort.Text = "Shannon"
			txtLatRad.Text = "0.919788515801012"
			txtLongRad.Text = "0.155741546919627"
		ElseIf cmbICAO12.Text = "EKCH" Then
			txtPort.Text = "Copenhagen"
			txtLatRad.Text = "0.97054850821318"
			txtLongRad.Text = "-0.220493262168617"
		ElseIf cmbICAO12.Text = "ELLX" Then
			'txtPort.Text = "Luxembourg"
			txtLatRad.Text = "0.86609055248132"
			txtLongRad.Text = "-0.108297680086248"
		ElseIf cmbICAO12.Text = "ENBR" Then
			'txtPort.Text = "Bergen, Norway"
			txtLatRad.Text = "1.05231718366911"
			txtLongRad.Text = "-0.091106186954104"
		ElseIf cmbICAO12.Text = "FAGM" Then
			'txtPort.Text = "Rand"
			txtLatRad.Text = "-0.458003484544179"
			txtLongRad.Text = "-0.49133927325727"
		ElseIf cmbICAO12.Text = "FALA" Then
			'txtPort.Text = "Lanseria, RSA"
			txtLatRad.Text = "-0.452622052683863"
			txtLongRad.Text = "-0.48735410479855"
		ElseIf cmbICAO12.Text = "FAWM" Then
			'txtPort.Text = "Windhoek"
			txtLatRad.Text = "-0.392379104669192"
			txtLongRad.Text = "-0.304967197965142"
		ElseIf cmbICAO12.Text = "FCBB" Then
			'txtPort.Text = "Brazzaville, Congo"
			txtLatRad.Text = "-0.0742928484932253"
			txtLongRad.Text = "-0.266162710929135"
		ElseIf cmbICAO12.Text = "FEFF" Then
			'txtPort.Text = "Bangui, CAE"
			txtLatRad.Text = "0.0767653982668839"
			txtLongRad.Text = "-0.323264066290216"
		ElseIf cmbICAO12.Text = "FMMI" Then
			'txtPort.Text = "Antananarivo, Madagascar"
			txtLatRad.Text = "-0.328063721733201"
			txtLongRad.Text = "-0.828624151205175"
		ElseIf cmbICAO12.Text = "FNLU" Then
			'txtPort.Text = "Luanda"
			txtLatRad.Text = "-0.154548905264098"
			txtLongRad.Text = "-0.231023415322316"
		ElseIf cmbICAO12.Text = "FOOL" Then
			'txtPort.Text = "Libreville"
			txtLatRad.Text = "-0.00799942573830734"
			txtLongRad.Text = "-0.164322749075266"
		ElseIf cmbICAO12.Text = "FSIA" Then
			'txtPort.Text = "Seychelles Intl"
			txtLatRad.Text = "-0.0815359648890018"
			txtLongRad.Text = "-0.969064978348985"
		ElseIf cmbICAO12.Text = "FVHA" Then
			'txtPort.Text = "Harare, Zimbabwe"
			txtLatRad.Text = "-0.31296662370345"
			txtLongRad.Text = "-0.54268104208677"
		ElseIf cmbICAO12.Text = "FZNA" Then
			'txtPort.Text = "Goma, Zaire"
			txtLatRad.Text = "-0.0290888208665722"
			txtLongRad.Text = "-0.510217917999676"
		ElseIf cmbICAO12.Text = "GBYD" Then
			'txtPort.Text = "Banjul"
			txtLatRad.Text = "0.23285601103691"
			txtLongRad.Text = "0.290742764561389"
		ElseIf cmbICAO12.Text = "GCXO" Then
			'txtPort.Text = "Tenerife"
			txtLatRad.Text = "0.497157037431"
			txtLongRad.Text = "0.2851867998"
		ElseIf cmbICAO12.Text = "GMAA" Then
			'txtPort.Text = "Agadir"
			txtLatRad.Text = "0.530260115577"
			txtLongRad.Text = "0.1667080324"
		ElseIf cmbICAO12.Text = "GOOY" Then
			'txtPort.Text = "Dakar"
			txtLatRad.Text = "0.257290620565"
			txtLongRad.Text = "0.3052580862"
		ElseIf cmbICAO12.Text = "HELX" Then
			'txtPort.Text = "Luxor"
			txtLatRad.Text = "0.447967841345"
			txtLongRad.Text = "-0.570722665"
		ElseIf cmbICAO12.Text = "HKNW" Then
			'txtPort.Text = "Nairobi-Wilson"
			txtLatRad.Text = "-0.02298016848"
			txtLongRad.Text = "-0.642572053"
		ElseIf cmbICAO12.Text = "HSSS" Then
			'txtPort.Text = "Khartoum"
			txtLatRad.Text = "0.272271363311"
			txtLongRad.Text = "-0.568250116"
		ElseIf cmbICAO12.Text = "HTDA" Then
			'txtPort.Text = "Dar-Es-Salaam"
			txtLatRad.Text = "-0.11999138607"
			txtLongRad.Text = "-0.684198156"
		ElseIf cmbICAO12.Text = "I69" Then
			'txtPort.Text = "Batavia, OH"
			txtLatRad.Text = "0.682045582859"
			txtLongRad.Text = "1.4697417631"
		ElseIf cmbICAO12.Text = "KANC" Then
			'txtPort.Text = "Anchorage"
			txtLatRad.Text = "1.067292108651"
			txtLongRad.Text = "2.6215601674"
		ElseIf cmbICAO12.Text = "KBGR" Then
			'txtPort.Text = "Bangor"
			txtLatRad.Text = "0.782052948998"
			txtLongRad.Text = "1.2012810353"
		ElseIf cmbICAO12.Text = "KBOI" Then
			'txtPort.Text = "Boise"
			txtLatRad.Text = "0.760352688631"
			txtLongRad.Text = "2.0285089231"
		ElseIf cmbICAO12.Text = "KCAE" Then
			'txtPort.Text = "Columbia, SC"
			txtLatRad.Text = "0.592364748127"
			txtLongRad.Text = "1.4158110892"
		ElseIf cmbICAO12.Text = "KEWK" Then
			'txtPort.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO12.Text = "KICT" Then
			'txtPort.Text = "Wichita, KS"
			txtLatRad.Text = "0.657116463376"
			txtLongRad.Text = "1.7005324679"
		ElseIf cmbICAO12.Text = "KIDP" Then
			'txtPort.Text = "Independence, KS"
			txtLatRad.Text = "0.648535261220"
			txtLongRad.Text = "1.6716472687"
		ElseIf cmbICAO12.Text = "KJNU" Then
			'txtPort.Text = "Juneau, AK"
			txtLatRad.Text = "1.018545062643"
			txtLongRad.Text = "2.3488738036"
		ElseIf cmbICAO12.Text = "KMIA" Then
			'txtPort.Text = "Miami, FL"
			txtLatRad.Text = "0.450178591731"
			txtLongRad.Text = "1.4013248564"
		ElseIf cmbICAO12.Text = "KMSP" Then
			'txtPort.Text = "Minneapolis, MN"
			txtLatRad.Text = "0.783391034758"
			txtLongRad.Text = "1.6269086622"
		ElseIf cmbICAO12.Text = "KNUD" Then
			'txtPort.Text = "ADAK, AK"
			txtLatRad.Text = "0.905348825123"
			txtLongRad.Text = "3.0835022783"
		ElseIf cmbICAO12.Text = "KOAK" Then
			'txtPort.Text = "Oakland, CA"
			txtLatRad.Text = "0.658454549136"
			txtLongRad.Text = "2.1331995894"
		ElseIf cmbICAO12.Text = "KPDK" Then
			'txtPort.Text = "Atlanta, GA"
			txtLatRad.Text = "0.590648507696"
			txtLongRad.Text = "1.4713416483"
		ElseIf cmbICAO12.Text = "KVRB" Then
			'txtPort.Text = "Vero Beach"
			txtLatRad.Text = "0.482670804639"
			txtLongRad.Text = "1.4035356068"
		ElseIf cmbICAO12.Text = "LCPH" Then
			'txtPort.Text = "Larnaca, Cyprus"
			txtLatRad.Text = "0.608741754275"
			txtLongRad.Text = "-0.586954227"
		ElseIf cmbICAO12.Text = "LEMD" Then
			'txtPort.Text = "Madrid"
			txtLatRad.Text = "0.706392925924"
			txtLongRad.Text = "-0.062133721"
		ElseIf cmbICAO12.Text = "LEMG" Then
			'txtPort.Text = "Malaga"
			txtLatRad.Text = "0.640099503169"
			txtLongRad.Text = "0.0784816387"
		ElseIf cmbICAO12.Text = "LFPN" Then
			'txtPort.Text = "Toussus Le Noble"
			txtLatRad.Text = "0.850877099168"
			txtLongRad.Text = "-0.036739181"
		ElseIf cmbICAO12.Text = "LGAT" Then
			'txtPort.Text = "Athens"
			txtLatRad.Text = "0.661247075939"
			txtLongRad.Text = "-0.414166631"
		ElseIf cmbICAO12.Text = "LGIR" Then
			'txtPort.Text = "Iraklion"
			txtLatRad.Text = "0.616770268834"
			txtLongRad.Text = "-0.439444817"
		ElseIf cmbICAO12.Text = "LIRA" Then
			'txtPort.Text = "Rome"
			txtLatRad.Text = "0.729518538513"
			txtLongRad.Text = "-0.219824219"
		ElseIf cmbICAO12.Text = "LKPR" Then
			'txtPort.Text = "Prague, Czech"
			txtLatRad.Text = "0.874439044070"
			txtLongRad.Text = "-0.248913040"
		ElseIf cmbICAO12.Text = "LPAZ" Then
			'txtPort.Text = "Santa Maria"
			txtLatRad.Text = "0.645306402104"
			txtLongRad.Text = "0.4393284615"
		ElseIf cmbICAO12.Text = "LPPR" Then
			'txtPort.Text = "Porto, Portugal"
			txtLatRad.Text = "0.719657428239"
			txtLongRad.Text = "0.1514364014"
		ElseIf cmbICAO12.Text = "LROP" Then
			'txtPort.Text = "Bucharest, Romania"
			txtLatRad.Text = "0.777893247614"
			txtLongRad.Text = "-0.455298224"
		ElseIf cmbICAO12.Text = "LTAC" Then
			'txtPort.Text = "Ankara"
			txtLatRad.Text = "0.700313362363"
			txtLongRad.Text = "-0.575842298"
		ElseIf cmbICAO12.Text = "LTBA" Then
			'txtPort.Text = "Istanbul, Turkey"
			txtLatRad.Text = "0.715177749826"
			txtLongRad.Text = "-0.502945713"
		ElseIf cmbICAO12.Text = "MROC" Then
			'txtPort.Text = "San Jose, CR"
			txtLatRad.Text = "0.174416569916"
			txtLongRad.Text = "1.4697708519"
		ElseIf cmbICAO12.Text = "NTSU" Then
			'txtPort.Text = "Pago Pago"
			txtLatRad.Text = "0.250192948273"
			txtLongRad.Text = "2.9794515661"
		ElseIf cmbICAO12.Text = "NZAA" Then
			'txtPort.Text = "Auckland"
			txtLatRad.Text = "-0.64588817852"
			txtLongRad.Text = "-3.050690088"
		ElseIf cmbICAO12.Text = "OOMS" Then
			'txtPort.Text = "SEEB, Oman"
			txtLatRad.Text = "0.411781348187"
			txtLongRad.Text = "-1.017148799"
		ElseIf cmbICAO12.Text = "OPKC" Then
			'txtPort.Text = "Karachi"
			txtLatRad.Text = "0.434703339030"
			txtLongRad.Text = "-1.172104948"
		ElseIf cmbICAO12.Text = "PAOM" Then
			'txtPort.Text = "Nome, AK"
			txtLatRad.Text = "1.125970078103"
			txtLongRad.Text = "2.8875308921"
		ElseIf cmbICAO12.Text = "PGSN" Then
			'txtPort.Text = "Saipan"
			txtLatRad.Text = "0.263922871722"
			txtLongRad.Text = "-2.543526497"
		ElseIf cmbICAO12.Text = "PHNL" Then
			'txtPort.Text = "Honolulu, HI"
			txtLatRad.Text = "0.372075107704"
			txtLongRad.Text = "2.7562821324"
		ElseIf cmbICAO12.Text = "PHTO" Then
			'txtPort.Text = "HILO"
			txtLatRad.Text = "0.344237106135"
			txtLongRad.Text = "2.7061620940"
		ElseIf cmbICAO12.Text = "PKMJ" Then
			'txtPort.Text = "Majuro"
			txtLatRad.Text = "0.123249334012"
			txtLongRad.Text = "-2.989312676"
		ElseIf cmbICAO12.Text = "PLCH" Then
			'txtPort.Text = "Christmas Island"
			txtLatRad.Text = "0.034702963294"
			txtLongRad.Text = "2.7463628445"
		ElseIf cmbICAO12.Text = "PMDY" Then
			'txtPort.Text = "Midway"
			txtLatRad.Text = "0.492386470808"
			txtLongRad.Text = "3.0958650272"
		ElseIf cmbICAO12.Text = "PTRO" Then
			'txtPort.Text = "Palau"
			txtLatRad.Text = "0.128543499409"
			txtLongRad.Text = "-2.348369597"
		ElseIf cmbICAO12.Text = "PWAK" Then
			'txtPort.Text = "WAKE"
			txtLatRad.Text = "0.336499479785"
			txtLongRad.Text = "-2.908445754"
		ElseIf cmbICAO12.Text = "RCTP" Then
			'txtPort.Text = "Chiang Kai Shek"
			txtLatRad.Text = "0.437699487579"
			txtLongRad.Text = "-2.115717208"
		ElseIf cmbICAO12.Text = "RJCK" Then
			'txtPort.Text = "Kushiro"
			txtLatRad.Text = "0.751218798879"
			txtLongRad.Text = "-2.516677515"
		ElseIf cmbICAO12.Text = "RJTT" Then
			'txtPort.Text = "Tokyo"
			txtLatRad.Text = "0.620580904367"
			txtLongRad.Text = "-2.437643189"
		ElseIf cmbICAO12.Text = "RKSS" Then
			'txtPort.Text = "Seoul, Korea"
			txtLatRad.Text = "0.655429311766"
			txtLongRad.Text = "-2.213077492"
		ElseIf cmbICAO12.Text = "RPMM" Then
			'txtPort.Text = "Manilla"
			txtLatRad.Text = "0.253218185644"
			txtLongRad.Text = "-2.112197461"
		ElseIf cmbICAO12.Text = "SAEZ" Then
			'txtPort.Text = "Ezeiza"
			txtLatRad.Text = "-0.60772364554"
			txtLongRad.Text = "1.0215993888"
		ElseIf cmbICAO12.Text = "SBEG" Then
			'txtPort.Text = "Manaus"
			txtLatRad.Text = "-0.05305800926"
			txtLongRad.Text = "1.0480120382"
		ElseIf cmbICAO12.Text = "SBGL" Then
			'txtPort.Text = "Rio De Janeiro, Brazil"
			txtLatRad.Text = "-0.39810960238"
			txtLongRad.Text = "0.7548549015"
		ElseIf cmbICAO12.Text = "SBSP" Then
			'txtPort.Text = "Sao Paulo"
			txtLatRad.Text = "-0.41233403578"
			txtLongRad.Text = "0.8143124513"
		ElseIf cmbICAO12.Text = "SCEL" Then
			'txtPort.Text = "Santiago, Chile"
			txtLatRad.Text = "-0.58279452606"
			txtLongRad.Text = "1.2354022222"
		ElseIf cmbICAO12.Text = "SVMG" Then
			'txtPort.Text = "Margarita, VE"
			txtLatRad.Text = "0.190531776676"
			txtLongRad.Text = "1.1163998560"
		ElseIf cmbICAO12.Text = "TTPP" Then
			'txtPort.Text = "Picaro"
			txtLatRad.Text = "0.184888545428"
			txtLongRad.Text = "1.0705558744"
		ElseIf cmbICAO12.Text = "UHHH" Then
			'txtPort.Text = "Khabarovsk, Russia"
			txtLatRad.Text = "0.846950108351"
			txtLongRad.Text = "-2.359452438"
		ElseIf cmbICAO12.Text = "UHMM" Then
			'txtPort.Text = "Magadan, Russia"
			txtLatRad.Text = "1.045743110153"
			txtLongRad.Text = "-2.630502071"
		ElseIf cmbICAO12.Text = "UHPP" Then
			'txtPort.Text = "Petropavlovsk, Russia"
			txtLatRad.Text = "0.927933385644"
			txtLongRad.Text = "-2.7654742"
		ElseIf cmbICAO12.Text = "UHSS" Then
			'txtPort.Text = "Yuzhno, Russia"
			txtLatRad.Text = "0.700720605855"
			txtLongRad.Text = "-2.490730287"
		ElseIf cmbICAO12.Text = "UTTT" Then
			'txtPort.Text = "Tashkent, Russia"
			txtLatRad.Text = "0.719948316448"
			txtLongRad.Text = "-1.209222283"
		ElseIf cmbICAO12.Text = "UUEE" Then
			'txtPort.Text = "Moscow, Russia"
			txtLatRad.Text = "0.976889871162"
			txtLongRad.Text = "-0.65301494"
		ElseIf cmbICAO12.Text = "VABB" Then
			'txtPort.Text = "Bombay"
			txtLatRad.Text = "0.333212443027"
			txtLongRad.Text = "-1.271763248"
		ElseIf cmbICAO12.Text = "VCBI" Then
			'txtPort.Text = "Columbo, Sri Lanka"
			txtLatRad.Text = "0.125314640293"
			txtLongRad.Text = "-1.394227184"
		ElseIf cmbICAO12.Text = "VIDP" Then
			'txtPort.Text = "Delhi"
			txtLatRad.Text = "0.498582389653"
			txtLongRad.Text = "-1.345648853"
		ElseIf cmbICAO12.Text = "VNKT" Then
			'txtPort.Text = "Katmandu, Nepal"
			txtLatRad.Text = "0.485230620875"
			txtLongRad.Text = "-1.489842138"
		ElseIf cmbICAO12.Text = "VOMM" Then
			'txtPort.Text = "Madras"
			txtLatRad.Text = "0.226805536297"
			txtLongRad.Text = "-1.399346817"
		ElseIf cmbICAO12.Text = "VOPB" Then
			'txtPort.Text = "Port Blair, Nicobar"
			txtLatRad.Text = "0.203272680216"
			txtLongRad.Text = "-1.618531082"
		ElseIf cmbICAO12.Text = "VRMM" Then
			'txtPort.Text = "Male, Maldives"
			txtLatRad.Text = "0.073158384479"
			txtLongRad.Text = "-1.283398777"
		ElseIf cmbICAO12.Text = "VTBD" Then
			'txtPort.Text = "Bangkok"
			txtLatRad.Text = "0.242891654236"
			txtLongRad.Text = "-1.755888494"
		ElseIf cmbICAO12.Text = "WMKJ" Then
			'txtPort.Text = "Johor Bahru, Malaysia"
			txtLatRad.Text = "0.028594310912"
			txtLongRad.Text = "-1.809411924"
		ElseIf cmbICAO12.Text = "WMKK" Then
			'txtPort.Text = "Kuala Lumpur"
			txtLatRad.Text = "0.054628805587"
			txtLongRad.Text = "-1.772410944"
		ElseIf cmbICAO12.Text = "WSSL" Then
			'txtPort.Text = "Singapore"
			txtLatRad.Text = "0.024725497737"
			txtLongRad.Text = "-1.812815316"
		ElseIf cmbICAO12.Text = "ZGGG" Then
			'txtPort.Text = "Guangzhou"
			txtLatRad.Text = "0.404625498254"
			txtLongRad.Text = "-1.976847177"
		ElseIf cmbICAO12.Text = "Other" Then
			txtICAO12.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
			txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
			txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
			txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
			txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
			intLatDeg = CDbl(txtLatDeg.Text)
			intLatMin = CDbl(txtLatMin.Text)
			intLatSec = CDbl(txtLatSec.Text)
			intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
			If txtNS.Text = "S" Then
				intLatRad = intLatRad * -1
			ElseIf txtNS.Text = "s" Then
				intLatRad = intLatRad * -1
			End If
			txtLatRad.Text = CStr(intLatRad / (180 / 3.141592654))
			txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
			txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
			txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
			txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
			intLongDeg = CDbl(txtLongDeg.Text)
			intLongMin = CDbl(txtLongMin.Text)
			intLongSec = CDbl(txtLongSec.Text)
			intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
			If txtEW.Text = "E" Then
				intLongRad = intLongRad * -1
			ElseIf txtEW.Text = "e" Then
				intLongRad = intLongRad * -1
			End If
			txtLongRad.Text = CStr(intLongRad / (180 / 3.141592654))
			cmbICAO12.Visible = False
			'cmbICAO12 = txtICAO12
			cmbICAO13.Focus()
		End If

	End Sub

	'UPGRADE_WARNING: Event cmbICAO13.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	<Obsolete>
	Private Sub cmbICAO13_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO13.SelectedIndexChanged

		If cmbICAO14.Text <> "" Then
			cmbICAO14.Text = ""
			cmbICAO15.Text = ""
			txtPort7.Text = ""
			txtLeg7.Text = ""
			txtTotal7.Text = ""

			Call cmbICAO12_SelectedIndexChanged(cmbICAO12, New System.EventArgs())

		End If

		If cmbICAO13.Text = cmbICAO12.Text Then
			Call MsgBox("Please re-enter destination, not equal to origination.", MsgBoxStyle.OKOnly, "Re-enter Destination")
			cmbICAO13.Text = ""
			cmbICAO13.Focus()
			Exit Sub
		ElseIf cmbICAO13.Text = "ASSY" Then
			txtPort6.Text = "Sidney"
			txtLatRad1.Text = "-0.592248392843409"
			txtLongRad1.Text = "-2.63835605259809"
		ElseIf cmbICAO13.Text = "AYPY" Then
			txtPort6.Text = "Port Moresby, PNG"
			txtLatRad1.Text = "-0.164817259029998"
			txtLongRad1.Text = "-2.56941554714432"
		ElseIf cmbICAO13.Text = "BGBW" Then
			txtPort6.Text = "Narsarsuaq"
			txtLatRad1.Text = "1.0674724593406"
			txtLongRad1.Text = "0.792873990360157"
		ElseIf cmbICAO13.Text = "BGGH" Then
			txtPort6.Text = "Godthab"
			txtLatRad1.Text = "1.12035593567603"
			txtLongRad1.Text = "0.902044335072403"
		ElseIf cmbICAO13.Text = "BIRK" Then
			txtPort6.Text = "Reykjavik"
			txtLatRad1.Text = "1.1192505604831"
			txtLongRad1.Text = "0.382983415529289"
		ElseIf cmbICAO13.Text = "CYAM" Then
			txtPort6.Text = "Sault Ste. Marie"
			txtLatRad1.Text = "0.811316302789564"
			txtLongRad1.Text = "1.47497775086041"
		ElseIf cmbICAO13.Text = "CYFB" Then
			txtPort6.Text = "Iqaluit"
			txtLatRad1.Text = "1.11276375342985"
			txtLongRad1.Text = "1.19653955752558"
		ElseIf cmbICAO13.Text = "CYQX" Then
			txtPort6.Text = "Gander"
			txtLatRad1.Text = "0.854164135926025"
			txtLongRad1.Text = "0.952426172813306"
		ElseIf cmbICAO13.Text = "CYYQ" Then
			txtPort6.Text = "Churchill Falls"
			txtLatRad1.Text = "1.02520640262147"
			txtLongRad1.Text = "1.64177304970933"
		ElseIf cmbICAO13.Text = "CYYR" Then
			txtPort6.Text = "Goose Bay"
			txtLatRad1.Text = "0.930609557163376"
			txtLongRad1.Text = "1.05464428933844"
		ElseIf cmbICAO13.Text = "CYYT" Then
			txtPort6.Text = "St John's, NFLD"
			txtLatRad1.Text = "0.831096700978833"
			txtLongRad1.Text = "0.920690269247875"
		ElseIf cmbICAO13.Text = "DAAG" Then
			txtPort6.Text = "Algiers, Algeria"
			txtLatRad1.Text = "0.640419480198453"
			txtLongRad1.Text = "-0.0561705130933508"
		ElseIf cmbICAO13.Text = "DIAP" Then
			txtPort6.Text = "Abidjan"
			txtLatRad1.Text = "0.0916588745505689"
			txtLongRad1.Text = "0.0685623507825106"
		ElseIf cmbICAO13.Text = "DNMM" Then
			txtPort6.Text = "Lagos, Nigeria"
			txtLatRad1.Text = "0.114755398318627"
			txtLongRad1.Text = "-0.0579158423453452"
		ElseIf cmbICAO13.Text = "DRRN" Then
			txtPort6.Text = "Niami, Niger"
			txtLatRad1.Text = "0.235299471989702"
			txtLongRad1.Text = "-0.0379318224100101"
		ElseIf cmbICAO13.Text = "EBBR" Then
			txtPort6.Text = "Brussels"
			txtLatRad1.Text = "0.88840167808598"
			txtLongRad1.Text = "-0.0785107275188782"
		ElseIf cmbICAO13.Text = "EDDW" Then
			txtPort6.Text = "Bremen, Germany"
			txtLatRad1.Text = "0.925868079362125"
			txtLongRad1.Text = "-0.153385352429435"
		ElseIf cmbICAO13.Text = "EFHK" Then
			txtPort6.Text = "Helsinki, Finland"
			txtLatRad1.Text = "1.05272442716125"
			txtLongRad1.Text = "-0.435750536581251"
		ElseIf cmbICAO13.Text = "EGPD" Then
			txtPort6.Text = "Aberdeen"
			txtLatRad1.Text = "0.998415598603356"
			txtLongRad1.Text = "0.0383681547230087"
		ElseIf cmbICAO13.Text = "EGPK" Then
			txtPort6.Text = "Prestwick"
			txtLatRad1.Text = "0.968686823677719"
			txtLongRad1.Text = "0.0798779020996071"
		ElseIf cmbICAO13.Text = "EHBK" Then
			txtPort6.Text = "Maastricht, Netherlands"
			txtLatRad1.Text = "0.888663477473779"
			txtLongRad1.Text = "-0.100821853123539"
		ElseIf cmbICAO13.Text = "EINN" Then
			txtPort6.Text = "Shannon"
			txtLatRad1.Text = "0.919788515801012"
			txtLongRad1.Text = "0.155741546919627"
		ElseIf cmbICAO13.Text = "EKCH" Then
			txtPort6.Text = "Copenhagen"
			txtLatRad1.Text = "0.97054850821318"
			txtLongRad1.Text = "-0.220493262168617"
		ElseIf cmbICAO13.Text = "ELLX" Then
			txtPort6.Text = "Luxembourg"
			txtLatRad1.Text = "0.86609055248132"
			txtLongRad1.Text = "-0.108297680086248"
		ElseIf cmbICAO13.Text = "ENBR" Then
			txtPort6.Text = "Bergen, Norway"
			txtLatRad1.Text = "1.05231718366911"
			txtLongRad1.Text = "-0.091106186954104"
		ElseIf cmbICAO13.Text = "FAGM" Then
			txtPort6.Text = "Rand"
			txtLatRad1.Text = "-0.458003484544179"
			txtLongRad1.Text = "-0.49133927325727"
		ElseIf cmbICAO13.Text = "FALA" Then
			txtPort6.Text = "Lanseria, RSA"
			txtLatRad1.Text = "-0.452622052683863"
			txtLongRad1.Text = "-0.48735410479855"
		ElseIf cmbICAO13.Text = "FAWM" Then
			txtPort6.Text = "Windhoek"
			txtLatRad1.Text = "-0.392379104669192"
			txtLongRad1.Text = "-0.304967197965142"
		ElseIf cmbICAO13.Text = "FCBB" Then
			txtPort6.Text = "Brazzaville, Congo"
			txtLatRad1.Text = "-0.0742928484932253"
			txtLongRad1.Text = "-0.266162710929135"
		ElseIf cmbICAO13.Text = "FEFF" Then
			txtPort6.Text = "Bangui, CAE"
			txtLatRad1.Text = "0.0767653982668839"
			txtLongRad1.Text = "-0.323264066290216"
		ElseIf cmbICAO13.Text = "FMMI" Then
			txtPort6.Text = "Antananarivo, Madagascar"
			txtLatRad1.Text = "-0.328063721733201"
			txtLongRad1.Text = "-0.828624151205175"
		ElseIf cmbICAO13.Text = "FNLU" Then
			txtPort6.Text = "Luanda"
			txtLatRad1.Text = "-0.154548905264098"
			txtLongRad1.Text = "-0.231023415322316"
		ElseIf cmbICAO13.Text = "FOOL" Then
			txtPort6.Text = "Libreville"
			txtLatRad1.Text = "-0.00799942573830734"
			txtLongRad1.Text = "-0.164322749075266"
		ElseIf cmbICAO13.Text = "FSIA" Then
			txtPort6.Text = "Seychelles Intl"
			txtLatRad1.Text = "-0.0815359648890018"
			txtLongRad1.Text = "-0.969064978348985"
		ElseIf cmbICAO13.Text = "FVHA" Then
			txtPort6.Text = "Harare, Zimbabwe"
			txtLatRad1.Text = "-0.31296662370345"
			txtLongRad1.Text = "-0.54268104208677"
		ElseIf cmbICAO13.Text = "FZNA" Then
			txtPort6.Text = "Goma, Zaire"
			txtLatRad1.Text = "-0.0290888208665722"
			txtLongRad1.Text = "-0.510217917999676"
		ElseIf cmbICAO13.Text = "GBYD" Then
			txtPort6.Text = "Banjul"
			txtLatRad1.Text = "0.23285601103691"
			txtLongRad1.Text = "0.290742764561389"
		ElseIf cmbICAO13.Text = "GCXO" Then
			txtPort6.Text = "Tenerife"
			txtLatRad1.Text = "0.497157037431"
			txtLongRad1.Text = "0.2851867998"
		ElseIf cmbICAO13.Text = "GMAA" Then
			txtPort6.Text = "Agadir"
			txtLatRad1.Text = "0.530260115577"
			txtLongRad1.Text = "0.1667080324"
		ElseIf cmbICAO13.Text = "GOOY" Then
			txtPort6.Text = "Dakar"
			txtLatRad1.Text = "0.257290620565"
			txtLongRad1.Text = "0.3052580862"
		ElseIf cmbICAO13.Text = "HELX" Then
			txtPort6.Text = "Luxor"
			txtLatRad1.Text = "0.447967841345"
			txtLongRad1.Text = "-0.570722665"
		ElseIf cmbICAO13.Text = "HKNW" Then
			txtPort6.Text = "Nairobi-Wilson"
			txtLatRad1.Text = "-0.02298016848"
			txtLongRad1.Text = "-0.642572053"
		ElseIf cmbICAO13.Text = "HSSS" Then
			txtPort6.Text = "Khartoum"
			txtLatRad1.Text = "0.272271363311"
			txtLongRad1.Text = "-0.568250116"
		ElseIf cmbICAO13.Text = "HTDA" Then
			txtPort6.Text = "Dar-Es-Salaam"
			txtLatRad1.Text = "-0.11999138607"
			txtLongRad1.Text = "-0.684198156"
		ElseIf cmbICAO13.Text = "I69" Then
			txtPort6.Text = "Batavia, OH"
			txtLatRad1.Text = "0.682045582859"
			txtLongRad1.Text = "1.4697417631"
		ElseIf cmbICAO13.Text = "KANC" Then
			txtPort6.Text = "Anchorage"
			txtLatRad1.Text = "1.067292108651"
			txtLongRad1.Text = "2.6215601674"
		ElseIf cmbICAO13.Text = "KBGR" Then
			txtPort6.Text = "Bangor"
			txtLatRad1.Text = "0.782052948998"
			txtLongRad1.Text = "1.2012810353"
		ElseIf cmbICAO13.Text = "KBOI" Then
			txtPort6.Text = "Boise"
			txtLatRad1.Text = "0.760352688631"
			txtLongRad1.Text = "2.0285089231"
		ElseIf cmbICAO13.Text = "KCAE" Then
			txtPort6.Text = "Columbia, SC"
			txtLatRad1.Text = "0.592364748127"
			txtLongRad1.Text = "1.4158110892"
		ElseIf cmbICAO13.Text = "KEWK" Then
			txtPort6.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO13.Text = "KICT" Then
			txtPort6.Text = "Wichita, KS"
			txtLatRad1.Text = "0.657116463376"
			txtLongRad1.Text = "1.7005324679"
		ElseIf cmbICAO13.Text = "KIDP" Then
			txtPort6.Text = "Independence, KS"
			txtLatRad1.Text = "0.648535261220"
			txtLongRad1.Text = "1.6716472687"
		ElseIf cmbICAO13.Text = "KJNU" Then
			txtPort6.Text = "Juneau, AK"
			txtLatRad1.Text = "1.018545062643"
			txtLongRad1.Text = "2.3488738036"
		ElseIf cmbICAO13.Text = "KMIA" Then
			txtPort6.Text = "Miami, FL"
			txtLatRad1.Text = "0.450178591731"
			txtLongRad1.Text = "1.4013248564"
		ElseIf cmbICAO13.Text = "KMSP" Then
			txtPort6.Text = "Minneapolis, MN"
			txtLatRad1.Text = "0.783391034758"
			txtLongRad1.Text = "1.6269086622"
		ElseIf cmbICAO13.Text = "KNUD" Then
			txtPort6.Text = "ADAK, AK"
			txtLatRad1.Text = "0.905348825123"
			txtLongRad1.Text = "3.0835022783"
		ElseIf cmbICAO13.Text = "KOAK" Then
			txtPort6.Text = "Oakland, CA"
			txtLatRad1.Text = "0.658454549136"
			txtLongRad1.Text = "2.1331995894"
		ElseIf cmbICAO13.Text = "KPDK" Then
			txtPort6.Text = "Atlanta, GA"
			txtLatRad1.Text = "0.590648507696"
			txtLongRad1.Text = "1.4713416483"
		ElseIf cmbICAO13.Text = "KVRB" Then
			txtPort6.Text = "Vero Beach"
			txtLatRad1.Text = "0.482670804639"
			txtLongRad1.Text = "1.4035356068"
		ElseIf cmbICAO13.Text = "LCPH" Then
			txtPort6.Text = "Larnaca, Cyprus"
			txtLatRad1.Text = "0.608741754275"
			txtLongRad1.Text = "-0.586954227"
		ElseIf cmbICAO13.Text = "LEMD" Then
			txtPort6.Text = "Madrid"
			txtLatRad1.Text = "0.706392925924"
			txtLongRad1.Text = "-0.062133721"
		ElseIf cmbICAO13.Text = "LEMG" Then
			txtPort6.Text = "Malaga"
			txtLatRad1.Text = "0.640099503169"
			txtLongRad1.Text = "0.0784816387"
		ElseIf cmbICAO13.Text = "LFPN" Then
			txtPort6.Text = "Toussus Le Noble"
			txtLatRad1.Text = "0.850877099168"
			txtLongRad1.Text = "-0.036739181"
		ElseIf cmbICAO13.Text = "LGAT" Then
			txtPort6.Text = "Athens"
			txtLatRad1.Text = "0.661247075939"
			txtLongRad1.Text = "-0.414166631"
		ElseIf cmbICAO13.Text = "LGIR" Then
			txtPort6.Text = "Iraklion"
			txtLatRad1.Text = "0.616770268834"
			txtLongRad1.Text = "-0.439444817"
		ElseIf cmbICAO13.Text = "LIRA" Then
			txtPort6.Text = "Rome"
			txtLatRad1.Text = "0.729518538513"
			txtLongRad1.Text = "-0.219824219"
		ElseIf cmbICAO13.Text = "LKPR" Then
			txtPort6.Text = "Prague, Czech"
			txtLatRad1.Text = "0.874439044070"
			txtLongRad1.Text = "-0.248913040"
		ElseIf cmbICAO13.Text = "LPAZ" Then
			txtPort6.Text = "Santa Maria"
			txtLatRad1.Text = "0.645306402104"
			txtLongRad1.Text = "0.4393284615"
		ElseIf cmbICAO13.Text = "LPPR" Then
			txtPort6.Text = "Porto, Portugal"
			txtLatRad1.Text = "0.719657428239"
			txtLongRad1.Text = "0.1514364014"
		ElseIf cmbICAO13.Text = "LROP" Then
			txtPort6.Text = "Bucharest, Romania"
			txtLatRad1.Text = "0.777893247614"
			txtLongRad1.Text = "-0.455298224"
		ElseIf cmbICAO13.Text = "LTAC" Then
			txtPort6.Text = "Ankara"
			txtLatRad1.Text = "0.700313362363"
			txtLongRad1.Text = "-0.575842298"
		ElseIf cmbICAO13.Text = "LTBA" Then
			txtPort6.Text = "Istanbul, Turkey"
			txtLatRad1.Text = "0.715177749826"
			txtLongRad1.Text = "-0.502945713"
		ElseIf cmbICAO13.Text = "MROC" Then
			txtPort6.Text = "San Jose, CR"
			txtLatRad1.Text = "0.174416569916"
			txtLongRad1.Text = "1.4697708519"
		ElseIf cmbICAO13.Text = "NTSU" Then
			txtPort6.Text = "Pago Pago"
			txtLatRad1.Text = "0.250192948273"
			txtLongRad1.Text = "2.9794515661"
		ElseIf cmbICAO13.Text = "NZAA" Then
			txtPort6.Text = "Auckland"
			txtLatRad1.Text = "-0.64588817852"
			txtLongRad1.Text = "-3.050690088"
		ElseIf cmbICAO13.Text = "OOMS" Then
			txtPort6.Text = "SEEB, Oman"
			txtLatRad1.Text = "0.411781348187"
			txtLongRad1.Text = "-1.017148799"
		ElseIf cmbICAO13.Text = "OPKC" Then
			txtPort6.Text = "Karachi"
			txtLatRad1.Text = "0.434703339030"
			txtLongRad1.Text = "-1.172104948"
		ElseIf cmbICAO13.Text = "PAOM" Then
			txtPort6.Text = "Nome, AK"
			txtLatRad1.Text = "1.125970078103"
			txtLongRad1.Text = "2.8875308921"
		ElseIf cmbICAO13.Text = "PGSN" Then
			txtPort6.Text = "Saipan"
			txtLatRad1.Text = "0.263922871722"
			txtLongRad1.Text = "-2.543526497"
		ElseIf cmbICAO13.Text = "PHNL" Then
			txtPort6.Text = "Honolulu, HI"
			txtLatRad1.Text = "0.372075107704"
			txtLongRad1.Text = "2.7562821324"
		ElseIf cmbICAO13.Text = "PHTO" Then
			txtPort6.Text = "HILO"
			txtLatRad1.Text = "0.344237106135"
			txtLongRad1.Text = "2.7061620940"
		ElseIf cmbICAO13.Text = "PKMJ" Then
			txtPort6.Text = "Majuro"
			txtLatRad1.Text = "0.123249334012"
			txtLongRad1.Text = "-2.989312676"
		ElseIf cmbICAO13.Text = "PLCH" Then
			txtPort6.Text = "Christmas Island"
			txtLatRad1.Text = "0.034702963294"
			txtLongRad1.Text = "2.7463628445"
		ElseIf cmbICAO13.Text = "PMDY" Then
			txtPort6.Text = "Midway"
			txtLatRad1.Text = "0.492386470808"
			txtLongRad1.Text = "3.0958650272"
		ElseIf cmbICAO13.Text = "PTRO" Then
			txtPort6.Text = "Palau"
			txtLatRad1.Text = "0.128543499409"
			txtLongRad1.Text = "-2.348369597"
		ElseIf cmbICAO13.Text = "PWAK" Then
			txtPort6.Text = "WAKE"
			txtLatRad1.Text = "0.336499479785"
			txtLongRad1.Text = "-2.908445754"
		ElseIf cmbICAO13.Text = "RCTP" Then
			txtPort6.Text = "Chiang Kai Shek"
			txtLatRad1.Text = "0.437699487579"
			txtLongRad1.Text = "-2.115717208"
		ElseIf cmbICAO13.Text = "RJCK" Then
			txtPort6.Text = "Kushiro"
			txtLatRad1.Text = "0.751218798879"
			txtLongRad1.Text = "-2.516677515"
		ElseIf cmbICAO13.Text = "RJTT" Then
			txtPort6.Text = "Tokyo"
			txtLatRad1.Text = "0.620580904367"
			txtLongRad1.Text = "-2.437643189"
		ElseIf cmbICAO13.Text = "RKSS" Then
			txtPort6.Text = "Seoul, Korea"
			txtLatRad1.Text = "0.655429311766"
			txtLongRad1.Text = "-2.213077492"
		ElseIf cmbICAO13.Text = "RPMM" Then
			txtPort6.Text = "Manilla"
			txtLatRad1.Text = "0.253218185644"
			txtLongRad1.Text = "-2.112197461"
		ElseIf cmbICAO13.Text = "SAEZ" Then
			txtPort6.Text = "Ezeiza"
			txtLatRad1.Text = "-0.60772364554"
			txtLongRad1.Text = "1.0215993888"
		ElseIf cmbICAO13.Text = "SBEG" Then
			txtPort6.Text = "Manaus"
			txtLatRad1.Text = "-0.05305800926"
			txtLongRad1.Text = "1.0480120382"
		ElseIf cmbICAO13.Text = "SBGL" Then
			txtPort6.Text = "Rio De Janeiro, Brazil"
			txtLatRad1.Text = "-0.39810960238"
			txtLongRad1.Text = "0.7548549015"
		ElseIf cmbICAO13.Text = "SBSP" Then
			txtPort6.Text = "Sao Paulo"
			txtLatRad1.Text = "-0.41233403578"
			txtLongRad1.Text = "0.8143124513"
		ElseIf cmbICAO13.Text = "SCEL" Then
			txtPort6.Text = "Santiago, Chile"
			txtLatRad1.Text = "-0.58279452606"
			txtLongRad1.Text = "1.2354022222"
		ElseIf cmbICAO13.Text = "SVMG" Then
			txtPort6.Text = "Margarita, VE"
			txtLatRad1.Text = "0.190531776676"
			txtLongRad1.Text = "1.1163998560"
		ElseIf cmbICAO13.Text = "TTPP" Then
			txtPort6.Text = "Picaro"
			txtLatRad1.Text = "0.184888545428"
			txtLongRad1.Text = "1.0705558744"
		ElseIf cmbICAO13.Text = "UHHH" Then
			txtPort6.Text = "Khabarovsk, Russia"
			txtLatRad1.Text = "0.846950108351"
			txtLongRad1.Text = "-2.359452438"
		ElseIf cmbICAO13.Text = "UHMM" Then
			txtPort6.Text = "Magadan, Russia"
			txtLatRad1.Text = "1.045743110153"
			txtLongRad1.Text = "-2.630502071"
		ElseIf cmbICAO13.Text = "UHPP" Then
			txtPort6.Text = "Petropavlovsk, Russia"
			txtLatRad1.Text = "0.927933385644"
			txtLongRad1.Text = "-2.7654742"
		ElseIf cmbICAO13.Text = "UHSS" Then
			txtPort6.Text = "Yuzhno, Russia"
			txtLatRad1.Text = "0.700720605855"
			txtLongRad1.Text = "-2.490730287"
		ElseIf cmbICAO13.Text = "UTTT" Then
			txtPort6.Text = "Tashkent, Russia"
			txtLatRad1.Text = "0.719948316448"
			txtLongRad1.Text = "-1.209222283"
		ElseIf cmbICAO13.Text = "UUEE" Then
			txtPort6.Text = "Moscow, Russia"
			txtLatRad1.Text = "0.976889871162"
			txtLongRad1.Text = "-0.65301494"
		ElseIf cmbICAO13.Text = "VABB" Then
			txtPort6.Text = "Bombay"
			txtLatRad1.Text = "0.333212443027"
			txtLongRad1.Text = "-1.271763248"
		ElseIf cmbICAO13.Text = "VCBI" Then
			txtPort6.Text = "Columbo, Sri Lanka"
			txtLatRad1.Text = "0.125314640293"
			txtLongRad1.Text = "-1.394227184"
		ElseIf cmbICAO13.Text = "VIDP" Then
			txtPort6.Text = "Delhi"
			txtLatRad1.Text = "0.498582389653"
			txtLongRad1.Text = "-1.345648853"
		ElseIf cmbICAO13.Text = "VNKT" Then
			txtPort6.Text = "Katmandu, Nepal"
			txtLatRad1.Text = "0.485230620875"
			txtLongRad1.Text = "-1.489842138"
		ElseIf cmbICAO13.Text = "VOMM" Then
			txtPort6.Text = "Madras"
			txtLatRad1.Text = "0.226805536297"
			txtLongRad1.Text = "-1.399346817"
		ElseIf cmbICAO13.Text = "VOPB" Then
			txtPort6.Text = "Port Blair, Nicobar"
			txtLatRad1.Text = "0.203272680216"
			txtLongRad1.Text = "-1.618531082"
		ElseIf cmbICAO13.Text = "VRMM" Then
			txtPort6.Text = "Male, Maldives"
			txtLatRad1.Text = "0.073158384479"
			txtLongRad1.Text = "-1.283398777"
		ElseIf cmbICAO13.Text = "VTBD" Then
			txtPort6.Text = "Bangkok"
			txtLatRad1.Text = "0.242891654236"
			txtLongRad1.Text = "-1.755888494"
		ElseIf cmbICAO13.Text = "WMKJ" Then
			txtPort6.Text = "Johor Bahru, Malaysia"
			txtLatRad1.Text = "0.028594310912"
			txtLongRad1.Text = "-1.809411924"
		ElseIf cmbICAO13.Text = "WMKK" Then
			txtPort6.Text = "Kuala Lumpur"
			txtLatRad1.Text = "0.054628805587"
			txtLongRad1.Text = "-1.772410944"
		ElseIf cmbICAO13.Text = "WSSL" Then
			txtPort6.Text = "Singapore"
			txtLatRad1.Text = "0.024725497737"
			txtLongRad1.Text = "-1.812815316"
		ElseIf cmbICAO13.Text = "ZGGG" Then
			txtPort6.Text = "Guangzhou"
			txtLatRad1.Text = "0.404625498254"
			txtLongRad1.Text = "-1.976847177"
		ElseIf cmbICAO13.Text = "Other" Then
			'Call ICAO13Other
		End If

		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg3, intLeg2, intLeg4 As Double
		Dim intLeg5, intLeg6 As Double
		If cmbICAO13.Text <> "Other" Then

			Call CalcDist()
			txtLeg6.Text = txtDist.Text
			txtLeg6.Text = VB6.Format(txtLeg6.Text, "Fixed")
			intLeg = CDbl(txtLeg.Text)
			intLeg1 = CDbl(txtLeg1.Text)
			intLeg2 = CDbl(txtLeg2.Text)
			intLeg3 = CDbl(txtLeg3.Text)
			intLeg4 = CDbl(txtLeg4.Text)
			intLeg5 = CDbl(txtLeg5.Text)
			intLeg6 = CDbl(txtLeg6.Text)
			intTotal1 = intLeg + intLeg1 + intLeg2 + intLeg3 + intLeg4 + intLeg5 + intLeg6
			txtTotal6.Text = CStr(intTotal1)
			txtTotal6.Text = VB6.Format(txtTotal6.Text, "Fixed")

		Else
			Call ICAO13Other()
		End If

		If cmbICAO13.Text = "Other" Then
			cmbICAO13.Visible = False
			cmbICAO14.Visible = False
			txtICAO14.Text = txtICAO13.Text
			'cmbICAO13 = txtICAO13
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		Else
			cmbICAO14.Text = cmbICAO13.Text
			txtLatRad.Text = txtLatRad1.Text
			txtLongRad.Text = txtLongRad1.Text
		End If

		cmbICAO15.Focus()

	End Sub

	<Obsolete>
	Private Sub ICAO13Other()

		txtICAO13.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtPort6.Text = InputBox("Enter Name of Airport.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
		txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
		txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
		txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
		intLatDeg = CDbl(txtLatDeg.Text)
		intLatMin = CDbl(txtLatMin.Text)
		intLatSec = CDbl(txtLatSec.Text)
		intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
		If txtNS.Text = "S" Then
			intLatRad = intLatRad * -1
		ElseIf txtNS.Text = "s" Then
			intLatRad = intLatRad * -1
		End If
		txtLatRad1.Text = CStr(intLatRad / (180 / 3.141592654))
		txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
		txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
		txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
		txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
		intLongDeg = CDbl(txtLongDeg.Text)
		intLongMin = CDbl(txtLongMin.Text)
		intLongSec = CDbl(txtLongSec.Text)
		intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
		If txtEW.Text = "E" Then
			intLongRad = intLongRad * -1
		ElseIf txtEW.Text = "e" Then
			intLongRad = intLongRad * -1
		End If
		txtLongRad1.Text = CStr(intLongRad / (180 / 3.141592654))
		cmbICAO13.Visible = False

		Call CalcDist()
		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg3, intLeg2, intLeg4 As Double
		Dim intLeg5, intLeg6 As Double
		txtLeg6.Text = txtDist.Text
		txtLeg6.Text = VB6.Format(txtLeg6.Text, "Fixed")
		intLeg = CDbl(txtLeg.Text)
		intLeg1 = CDbl(txtLeg1.Text)
		intLeg2 = CDbl(txtLeg2.Text)
		intLeg3 = CDbl(txtLeg3.Text)
		intLeg4 = CDbl(txtLeg4.Text)
		intLeg5 = CDbl(txtLeg5.Text)
		intLeg6 = CDbl(txtLeg6.Text)
		intTotal1 = intLeg + intLeg1 + intLeg2 + intLeg3 + intLeg4 + intLeg5 + intLeg6
		txtTotal6.Text = CStr(intTotal1)
		txtTotal6.Text = VB6.Format(txtTotal6.Text, "Fixed")

		strICAO = txtICAO13.Text
		strPort = txtPort6.Text
		strLatRad = txtLatRad1.Text
		strLongRad = txtLongRad1.Text
		FileOpen(1, "Bid ICAO.txt", OpenMode.Append)
		WriteLine(1, strICAO, strPort, strLatRad, strLongRad)
		FileClose(1)

		intLatDeg = 0
		intLatMin = 0
		intLatSec = 0
		intLatRad = 0
		intLongDeg = 0
		intLongMin = 0
		intLongSec = 0
		intLongRad = 0

	End Sub

	'UPGRADE_WARNING: Event cmbICAO14.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cmbICAO14_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO14.SelectedIndexChanged

		If cmbICAO14.Text = "ASSY" Then
			'txtPort.Text = "Sidney"
			txtLatRad.Text = "-0.592248392843409"
			txtLongRad.Text = "-2.63835605259809"
		ElseIf cmbICAO14.Text = "AYPY" Then
			'txtPort.Text = "Port Moresby, PNG"
			txtLatRad.Text = "-0.164817259029998"
			txtLongRad.Text = "-2.56941554714432"
		ElseIf cmbICAO14.Text = "BGBW" Then
			'txtPort.Text = "Narsarsuaq"
			txtLatRad.Text = "1.0674724593406"
			txtLongRad.Text = "0.792873990360157"
		ElseIf cmbICAO14.Text = "BGGH" Then
			'txtPort.Text = "Godthab"
			txtLatRad.Text = "1.12035593567603"
			txtLongRad.Text = "0.902044335072403"
		ElseIf cmbICAO14.Text = "BIRK" Then
			'txtPort.Text = "Reykjavik"
			txtLatRad.Text = "1.1192505604831"
			txtLongRad.Text = "0.382983415529289"
		ElseIf cmbICAO14.Text = "CYAM" Then
			'txtPort.Text = "Sault Ste. Marie"
			txtLatRad.Text = "0.811316302789564"
			txtLongRad.Text = "1.47497775086041"
		ElseIf cmbICAO14.Text = "CYFB" Then
			'txtPort.Text = "Iqaluit"
			txtLatRad.Text = "1.11276375342985"
			txtLongRad.Text = "1.19653955752558"
		ElseIf cmbICAO14.Text = "CYQX" Then
			'txtPort.Text = "Gander"
			txtLatRad.Text = "0.854164135926025"
			txtLongRad.Text = "0.952426172813306"
		ElseIf cmbICAO14.Text = "CYYQ" Then
			'txtPort.Text = "Churchill Falls"
			txtLatRad.Text = "1.02520640262147"
			txtLongRad.Text = "1.64177304970933"
		ElseIf cmbICAO14.Text = "CYYR" Then
			'txtPort.Text = "Goose Bay"
			txtLatRad.Text = "0.930609557163376"
			txtLongRad.Text = "1.05464428933844"
		ElseIf cmbICAO14.Text = "CYYT" Then
			'txtPort.Text = "St John's, NFLD"
			txtLatRad.Text = "0.831096700978833"
			txtLongRad.Text = "0.920690269247875"
		ElseIf cmbICAO14.Text = "DAAG" Then
			'txtPort.Text = "Algiers, Algeria"
			txtLatRad.Text = "0.640419480198453"
			txtLongRad.Text = "-0.0561705130933508"
		ElseIf cmbICAO14.Text = "DIAP" Then
			'txtPort.Text = "Abidjan"
			txtLatRad.Text = "0.0916588745505689"
			txtLongRad.Text = "0.0685623507825106"
		ElseIf cmbICAO14.Text = "DNMM" Then
			'txtPort.Text = "Lagos, Nigeria"
			txtLatRad.Text = "0.114755398318627"
			txtLongRad.Text = "-0.0579158423453452"
		ElseIf cmbICAO14.Text = "DRRN" Then
			'txtPort.Text = "Niami, Niger"
			txtLatRad.Text = "0.235299471989702"
			txtLongRad.Text = "-0.0379318224100101"
		ElseIf cmbICAO14.Text = "EBBR" Then
			'txtPort.Text = "Brussels"
			txtLatRad.Text = "0.88840167808598"
			txtLongRad.Text = "-0.0785107275188782"
		ElseIf cmbICAO14.Text = "EDDW" Then
			'txtPort.Text = "Bremen, Germany"
			txtLatRad.Text = "0.925868079362125"
			txtLongRad.Text = "-0.153385352429435"
		ElseIf cmbICAO14.Text = "EFHK" Then
			'txtPort.Text = "Helsinki, Finland"
			txtLatRad.Text = "1.05272442716125"
			txtLongRad.Text = "-0.435750536581251"
		ElseIf cmbICAO14.Text = "EGPD" Then
			'txtPort.Text = "Aberdeen"
			txtLatRad.Text = "0.998415598603356"
			txtLongRad.Text = "0.0383681547230087"
		ElseIf cmbICAO14.Text = "EGPK" Then
			'txtPort.Text = "Prestwick"
			txtLatRad.Text = "0.968686823677719"
			txtLongRad.Text = "0.0798779020996071"
		ElseIf cmbICAO14.Text = "EHBK" Then
			'txtPort.Text = "Maastricht, Netherlands"
			txtLatRad.Text = "0.888663477473779"
			txtLongRad.Text = "-0.100821853123539"
		ElseIf cmbICAO14.Text = "EINN" Then
			'txtPort.Text = "Shannon"
			txtLatRad.Text = "0.919788515801012"
			txtLongRad.Text = "0.155741546919627"
		ElseIf cmbICAO14.Text = "EKCH" Then
			txtPort.Text = "Copenhagen"
			txtLatRad.Text = "0.97054850821318"
			txtLongRad.Text = "-0.220493262168617"
		ElseIf cmbICAO14.Text = "ELLX" Then
			'txtPort.Text = "Luxembourg"
			txtLatRad.Text = "0.86609055248132"
			txtLongRad.Text = "-0.108297680086248"
		ElseIf cmbICAO14.Text = "ENBR" Then
			'txtPort.Text = "Bergen, Norway"
			txtLatRad.Text = "1.05231718366911"
			txtLongRad.Text = "-0.091106186954104"
		ElseIf cmbICAO14.Text = "FAGM" Then
			'txtPort.Text = "Rand"
			txtLatRad.Text = "-0.458003484544179"
			txtLongRad.Text = "-0.49133927325727"
		ElseIf cmbICAO14.Text = "FALA" Then
			'txtPort.Text = "Lanseria, RSA"
			txtLatRad.Text = "-0.452622052683863"
			txtLongRad.Text = "-0.48735410479855"
		ElseIf cmbICAO14.Text = "FAWM" Then
			'txtPort.Text = "Windhoek"
			txtLatRad.Text = "-0.392379104669192"
			txtLongRad.Text = "-0.304967197965142"
		ElseIf cmbICAO14.Text = "FCBB" Then
			'txtPort.Text = "Brazzaville, Congo"
			txtLatRad.Text = "-0.0742928484932253"
			txtLongRad.Text = "-0.266162710929135"
		ElseIf cmbICAO14.Text = "FEFF" Then
			'txtPort.Text = "Bangui, CAE"
			txtLatRad.Text = "0.0767653982668839"
			txtLongRad.Text = "-0.323264066290216"
		ElseIf cmbICAO14.Text = "FMMI" Then
			'txtPort.Text = "Antananarivo, Madagascar"
			txtLatRad.Text = "-0.328063721733201"
			txtLongRad.Text = "-0.828624151205175"
		ElseIf cmbICAO14.Text = "FNLU" Then
			'txtPort.Text = "Luanda"
			txtLatRad.Text = "-0.154548905264098"
			txtLongRad.Text = "-0.231023415322316"
		ElseIf cmbICAO14.Text = "FOOL" Then
			'txtPort.Text = "Libreville"
			txtLatRad.Text = "-0.00799942573830734"
			txtLongRad.Text = "-0.164322749075266"
		ElseIf cmbICAO14.Text = "FSIA" Then
			'txtPort.Text = "Seychelles Intl"
			txtLatRad.Text = "-0.0815359648890018"
			txtLongRad.Text = "-0.969064978348985"
		ElseIf cmbICAO14.Text = "FVHA" Then
			'txtPort.Text = "Harare, Zimbabwe"
			txtLatRad.Text = "-0.31296662370345"
			txtLongRad.Text = "-0.54268104208677"
		ElseIf cmbICAO14.Text = "FZNA" Then
			'txtPort.Text = "Goma, Zaire"
			txtLatRad.Text = "-0.0290888208665722"
			txtLongRad.Text = "-0.510217917999676"
		ElseIf cmbICAO14.Text = "GBYD" Then
			'txtPort.Text = "Banjul"
			txtLatRad.Text = "0.23285601103691"
			txtLongRad.Text = "0.290742764561389"
		ElseIf cmbICAO14.Text = "GCXO" Then
			'txtPort.Text = "Tenerife"
			txtLatRad.Text = "0.497157037431"
			txtLongRad.Text = "0.2851867998"
		ElseIf cmbICAO14.Text = "GMAA" Then
			'txtPort.Text = "Agadir"
			txtLatRad.Text = "0.530260115577"
			txtLongRad.Text = "0.1667080324"
		ElseIf cmbICAO14.Text = "GOOY" Then
			'txtPort.Text = "Dakar"
			txtLatRad.Text = "0.257290620565"
			txtLongRad.Text = "0.3052580862"
		ElseIf cmbICAO14.Text = "HELX" Then
			'txtPort.Text = "Luxor"
			txtLatRad.Text = "0.447967841345"
			txtLongRad.Text = "-0.570722665"
		ElseIf cmbICAO14.Text = "HKNW" Then
			'txtPort.Text = "Nairobi-Wilson"
			txtLatRad.Text = "-0.02298016848"
			txtLongRad.Text = "-0.642572053"
		ElseIf cmbICAO14.Text = "HSSS" Then
			'txtPort.Text = "Khartoum"
			txtLatRad.Text = "0.272271363311"
			txtLongRad.Text = "-0.568250116"
		ElseIf cmbICAO14.Text = "HTDA" Then
			'txtPort.Text = "Dar-Es-Salaam"
			txtLatRad.Text = "-0.11999138607"
			txtLongRad.Text = "-0.684198156"
		ElseIf cmbICAO14.Text = "I69" Then
			'txtPort.Text = "Batavia, OH"
			txtLatRad.Text = "0.682045582859"
			txtLongRad.Text = "1.4697417631"
		ElseIf cmbICAO14.Text = "KANC" Then
			'txtPort.Text = "Anchorage"
			txtLatRad.Text = "1.067292108651"
			txtLongRad.Text = "2.6215601674"
		ElseIf cmbICAO14.Text = "KBGR" Then
			'txtPort.Text = "Bangor"
			txtLatRad.Text = "0.782052948998"
			txtLongRad.Text = "1.2012810353"
		ElseIf cmbICAO14.Text = "KBOI" Then
			'txtPort.Text = "Boise"
			txtLatRad.Text = "0.760352688631"
			txtLongRad.Text = "2.0285089231"
		ElseIf cmbICAO14.Text = "KCAE" Then
			'txtPort.Text = "Columbia, SC"
			txtLatRad.Text = "0.592364748127"
			txtLongRad.Text = "1.4158110892"
		ElseIf cmbICAO14.Text = "KEWK" Then
			'txtPort.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO14.Text = "KICT" Then
			'txtPort.Text = "Wichita, KS"
			txtLatRad.Text = "0.657116463376"
			txtLongRad.Text = "1.7005324679"
		ElseIf cmbICAO14.Text = "KIDP" Then
			'txtPort.Text = "Independence, KS"
			txtLatRad.Text = "0.648535261220"
			txtLongRad.Text = "1.6716472687"
		ElseIf cmbICAO14.Text = "KJNU" Then
			'txtPort.Text = "Juneau, AK"
			txtLatRad.Text = "1.018545062643"
			txtLongRad.Text = "2.3488738036"
		ElseIf cmbICAO14.Text = "KMIA" Then
			'txtPort.Text = "Miami, FL"
			txtLatRad.Text = "0.450178591731"
			txtLongRad.Text = "1.4013248564"
		ElseIf cmbICAO14.Text = "KMSP" Then
			'txtPort.Text = "Minneapolis, MN"
			txtLatRad.Text = "0.783391034758"
			txtLongRad.Text = "1.6269086622"
		ElseIf cmbICAO14.Text = "KNUD" Then
			'txtPort.Text = "ADAK, AK"
			txtLatRad.Text = "0.905348825123"
			txtLongRad.Text = "3.0835022783"
		ElseIf cmbICAO14.Text = "KOAK" Then
			'txtPort.Text = "Oakland, CA"
			txtLatRad.Text = "0.658454549136"
			txtLongRad.Text = "2.1331995894"
		ElseIf cmbICAO14.Text = "KPDK" Then
			'txtPort.Text = "Atlanta, GA"
			txtLatRad.Text = "0.590648507696"
			txtLongRad.Text = "1.4713416483"
		ElseIf cmbICAO14.Text = "KVRB" Then
			'txtPort.Text = "Vero Beach"
			txtLatRad.Text = "0.482670804639"
			txtLongRad.Text = "1.4035356068"
		ElseIf cmbICAO14.Text = "LCPH" Then
			'txtPort.Text = "Larnaca, Cyprus"
			txtLatRad.Text = "0.608741754275"
			txtLongRad.Text = "-0.586954227"
		ElseIf cmbICAO14.Text = "LEMD" Then
			'txtPort.Text = "Madrid"
			txtLatRad.Text = "0.706392925924"
			txtLongRad.Text = "-0.062133721"
		ElseIf cmbICAO14.Text = "LEMG" Then
			'txtPort.Text = "Malaga"
			txtLatRad.Text = "0.640099503169"
			txtLongRad.Text = "0.0784816387"
		ElseIf cmbICAO14.Text = "LFPN" Then
			'txtPort.Text = "Toussus Le Noble"
			txtLatRad.Text = "0.850877099168"
			txtLongRad.Text = "-0.036739181"
		ElseIf cmbICAO14.Text = "LGAT" Then
			'txtPort.Text = "Athens"
			txtLatRad.Text = "0.661247075939"
			txtLongRad.Text = "-0.414166631"
		ElseIf cmbICAO14.Text = "LGIR" Then
			'txtPort.Text = "Iraklion"
			txtLatRad.Text = "0.616770268834"
			txtLongRad.Text = "-0.439444817"
		ElseIf cmbICAO14.Text = "LIRA" Then
			'txtPort.Text = "Rome"
			txtLatRad.Text = "0.729518538513"
			txtLongRad.Text = "-0.219824219"
		ElseIf cmbICAO14.Text = "LKPR" Then
			'txtPort.Text = "Prague, Czech"
			txtLatRad.Text = "0.874439044070"
			txtLongRad.Text = "-0.248913040"
		ElseIf cmbICAO14.Text = "LPAZ" Then
			'txtPort.Text = "Santa Maria"
			txtLatRad.Text = "0.645306402104"
			txtLongRad.Text = "0.4393284615"
		ElseIf cmbICAO14.Text = "LPPR" Then
			'txtPort.Text = "Porto, Portugal"
			txtLatRad.Text = "0.719657428239"
			txtLongRad.Text = "0.1514364014"
		ElseIf cmbICAO14.Text = "LROP" Then
			'txtPort.Text = "Bucharest, Romania"
			txtLatRad.Text = "0.777893247614"
			txtLongRad.Text = "-0.455298224"
		ElseIf cmbICAO14.Text = "LTAC" Then
			'txtPort.Text = "Ankara"
			txtLatRad.Text = "0.700313362363"
			txtLongRad.Text = "-0.575842298"
		ElseIf cmbICAO14.Text = "LTBA" Then
			'txtPort.Text = "Istanbul, Turkey"
			txtLatRad.Text = "0.715177749826"
			txtLongRad.Text = "-0.502945713"
		ElseIf cmbICAO14.Text = "MROC" Then
			'txtPort.Text = "San Jose, CR"
			txtLatRad.Text = "0.174416569916"
			txtLongRad.Text = "1.4697708519"
		ElseIf cmbICAO14.Text = "NTSU" Then
			'txtPort.Text = "Pago Pago"
			txtLatRad.Text = "0.250192948273"
			txtLongRad.Text = "2.9794515661"
		ElseIf cmbICAO14.Text = "NZAA" Then
			'txtPort.Text = "Auckland"
			txtLatRad.Text = "-0.64588817852"
			txtLongRad.Text = "-3.050690088"
		ElseIf cmbICAO14.Text = "OOMS" Then
			'txtPort.Text = "SEEB, Oman"
			txtLatRad.Text = "0.411781348187"
			txtLongRad.Text = "-1.017148799"
		ElseIf cmbICAO14.Text = "OPKC" Then
			'txtPort.Text = "Karachi"
			txtLatRad.Text = "0.434703339030"
			txtLongRad.Text = "-1.172104948"
		ElseIf cmbICAO14.Text = "PAOM" Then
			'txtPort.Text = "Nome, AK"
			txtLatRad.Text = "1.125970078103"
			txtLongRad.Text = "2.8875308921"
		ElseIf cmbICAO14.Text = "PGSN" Then
			'txtPort.Text = "Saipan"
			txtLatRad.Text = "0.263922871722"
			txtLongRad.Text = "-2.543526497"
		ElseIf cmbICAO14.Text = "PHNL" Then
			'txtPort.Text = "Honolulu, HI"
			txtLatRad.Text = "0.372075107704"
			txtLongRad.Text = "2.7562821324"
		ElseIf cmbICAO14.Text = "PHTO" Then
			'txtPort.Text = "HILO"
			txtLatRad.Text = "0.344237106135"
			txtLongRad.Text = "2.7061620940"
		ElseIf cmbICAO14.Text = "PKMJ" Then
			'txtPort.Text = "Majuro"
			txtLatRad.Text = "0.123249334012"
			txtLongRad.Text = "-2.989312676"
		ElseIf cmbICAO14.Text = "PLCH" Then
			'txtPort.Text = "Christmas Island"
			txtLatRad.Text = "0.034702963294"
			txtLongRad.Text = "2.7463628445"
		ElseIf cmbICAO14.Text = "PMDY" Then
			'txtPort.Text = "Midway"
			txtLatRad.Text = "0.492386470808"
			txtLongRad.Text = "3.0958650272"
		ElseIf cmbICAO14.Text = "PTRO" Then
			'txtPort.Text = "Palau"
			txtLatRad.Text = "0.128543499409"
			txtLongRad.Text = "-2.348369597"
		ElseIf cmbICAO14.Text = "PWAK" Then
			'txtPort.Text = "WAKE"
			txtLatRad.Text = "0.336499479785"
			txtLongRad.Text = "-2.908445754"
		ElseIf cmbICAO14.Text = "RCTP" Then
			'txtPort.Text = "Chiang Kai Shek"
			txtLatRad.Text = "0.437699487579"
			txtLongRad.Text = "-2.115717208"
		ElseIf cmbICAO14.Text = "RJCK" Then
			'txtPort.Text = "Kushiro"
			txtLatRad.Text = "0.751218798879"
			txtLongRad.Text = "-2.516677515"
		ElseIf cmbICAO14.Text = "RJTT" Then
			'txtPort.Text = "Tokyo"
			txtLatRad.Text = "0.620580904367"
			txtLongRad.Text = "-2.437643189"
		ElseIf cmbICAO14.Text = "RKSS" Then
			'txtPort.Text = "Seoul, Korea"
			txtLatRad.Text = "0.655429311766"
			txtLongRad.Text = "-2.213077492"
		ElseIf cmbICAO14.Text = "RPMM" Then
			'txtPort.Text = "Manilla"
			txtLatRad.Text = "0.253218185644"
			txtLongRad.Text = "-2.112197461"
		ElseIf cmbICAO14.Text = "SAEZ" Then
			'txtPort.Text = "Ezeiza"
			txtLatRad.Text = "-0.60772364554"
			txtLongRad.Text = "1.0215993888"
		ElseIf cmbICAO14.Text = "SBEG" Then
			'txtPort.Text = "Manaus"
			txtLatRad.Text = "-0.05305800926"
			txtLongRad.Text = "1.0480120382"
		ElseIf cmbICAO14.Text = "SBGL" Then
			'txtPort.Text = "Rio De Janeiro, Brazil"
			txtLatRad.Text = "-0.39810960238"
			txtLongRad.Text = "0.7548549015"
		ElseIf cmbICAO14.Text = "SBSP" Then
			'txtPort.Text = "Sao Paulo"
			txtLatRad.Text = "-0.41233403578"
			txtLongRad.Text = "0.8143124513"
		ElseIf cmbICAO14.Text = "SCEL" Then
			'txtPort.Text = "Santiago, Chile"
			txtLatRad.Text = "-0.58279452606"
			txtLongRad.Text = "1.2354022222"
		ElseIf cmbICAO14.Text = "SVMG" Then
			'txtPort.Text = "Margarita, VE"
			txtLatRad.Text = "0.190531776676"
			txtLongRad.Text = "1.1163998560"
		ElseIf cmbICAO14.Text = "TTPP" Then
			'txtPort.Text = "Picaro"
			txtLatRad.Text = "0.184888545428"
			txtLongRad.Text = "1.0705558744"
		ElseIf cmbICAO14.Text = "UHHH" Then
			'txtPort.Text = "Khabarovsk, Russia"
			txtLatRad.Text = "0.846950108351"
			txtLongRad.Text = "-2.359452438"
		ElseIf cmbICAO14.Text = "UHMM" Then
			'txtPort.Text = "Magadan, Russia"
			txtLatRad.Text = "1.045743110153"
			txtLongRad.Text = "-2.630502071"
		ElseIf cmbICAO14.Text = "UHPP" Then
			'txtPort.Text = "Petropavlovsk, Russia"
			txtLatRad.Text = "0.927933385644"
			txtLongRad.Text = "-2.7654742"
		ElseIf cmbICAO14.Text = "UHSS" Then
			'txtPort.Text = "Yuzhno, Russia"
			txtLatRad.Text = "0.700720605855"
			txtLongRad.Text = "-2.490730287"
		ElseIf cmbICAO14.Text = "UTTT" Then
			'txtPort.Text = "Tashkent, Russia"
			txtLatRad.Text = "0.719948316448"
			txtLongRad.Text = "-1.209222283"
		ElseIf cmbICAO14.Text = "UUEE" Then
			'txtPort.Text = "Moscow, Russia"
			txtLatRad.Text = "0.976889871162"
			txtLongRad.Text = "-0.65301494"
		ElseIf cmbICAO14.Text = "VABB" Then
			'txtPort.Text = "Bombay"
			txtLatRad.Text = "0.333212443027"
			txtLongRad.Text = "-1.271763248"
		ElseIf cmbICAO14.Text = "VCBI" Then
			'txtPort.Text = "Columbo, Sri Lanka"
			txtLatRad.Text = "0.125314640293"
			txtLongRad.Text = "-1.394227184"
		ElseIf cmbICAO14.Text = "VIDP" Then
			'txtPort.Text = "Delhi"
			txtLatRad.Text = "0.498582389653"
			txtLongRad.Text = "-1.345648853"
		ElseIf cmbICAO14.Text = "VNKT" Then
			'txtPort.Text = "Katmandu, Nepal"
			txtLatRad.Text = "0.485230620875"
			txtLongRad.Text = "-1.489842138"
		ElseIf cmbICAO14.Text = "VOMM" Then
			'txtPort.Text = "Madras"
			txtLatRad.Text = "0.226805536297"
			txtLongRad.Text = "-1.399346817"
		ElseIf cmbICAO14.Text = "VOPB" Then
			'txtPort.Text = "Port Blair, Nicobar"
			txtLatRad.Text = "0.203272680216"
			txtLongRad.Text = "-1.618531082"
		ElseIf cmbICAO14.Text = "VRMM" Then
			'txtPort.Text = "Male, Maldives"
			txtLatRad.Text = "0.073158384479"
			txtLongRad.Text = "-1.283398777"
		ElseIf cmbICAO14.Text = "VTBD" Then
			'txtPort.Text = "Bangkok"
			txtLatRad.Text = "0.242891654236"
			txtLongRad.Text = "-1.755888494"
		ElseIf cmbICAO14.Text = "WMKJ" Then
			'txtPort.Text = "Johor Bahru, Malaysia"
			txtLatRad.Text = "0.028594310912"
			txtLongRad.Text = "-1.809411924"
		ElseIf cmbICAO14.Text = "WMKK" Then
			'txtPort.Text = "Kuala Lumpur"
			txtLatRad.Text = "0.054628805587"
			txtLongRad.Text = "-1.772410944"
		ElseIf cmbICAO14.Text = "WSSL" Then
			'txtPort.Text = "Singapore"
			txtLatRad.Text = "0.024725497737"
			txtLongRad.Text = "-1.812815316"
		ElseIf cmbICAO14.Text = "ZGGG" Then
			'txtPort.Text = "Guangzhou"
			txtLatRad.Text = "0.404625498254"
			txtLongRad.Text = "-1.976847177"
		ElseIf cmbICAO14.Text = "Other" Then
			txtICAO14.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
			txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
			txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
			txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
			txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
			intLatDeg = CDbl(txtLatDeg.Text)
			intLatMin = CDbl(txtLatMin.Text)
			intLatSec = CDbl(txtLatSec.Text)
			intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
			If txtNS.Text = "S" Then
				intLatRad = intLatRad * -1
			ElseIf txtNS.Text = "s" Then
				intLatRad = intLatRad * -1
			End If
			txtLatRad.Text = CStr(intLatRad / (180 / 3.141592654))
			txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
			txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
			txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
			txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
			intLongDeg = CDbl(txtLongDeg.Text)
			intLongMin = CDbl(txtLongMin.Text)
			intLongSec = CDbl(txtLongSec.Text)
			intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
			If txtEW.Text = "E" Then
				intLongRad = intLongRad * -1
			ElseIf txtEW.Text = "e" Then
				intLongRad = intLongRad * -1
			End If
			txtLongRad.Text = CStr(intLongRad / (180 / 3.141592654))
			cmbICAO14.Visible = False
			'cmbICAO14 = txtICAO14
			cmbICAO15.Focus()
		End If

	End Sub

	'UPGRADE_WARNING: Event cmbICAO15.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	<Obsolete>
	Private Sub cmbICAO15_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbICAO15.SelectedIndexChanged

		If cmbICAO15.Text = cmbICAO14.Text Then
			Call MsgBox("Please re-enter destination, not equal to origination.", MsgBoxStyle.OKOnly, "Re-enter Destination")
			cmbICAO15.Text = ""
			cmbICAO15.Focus()
			Exit Sub
		ElseIf cmbICAO15.Text = "ASSY" Then
			txtPort7.Text = "Sidney"
			txtLatRad1.Text = "-0.592248392843409"
			txtLongRad1.Text = "-2.63835605259809"
		ElseIf cmbICAO15.Text = "AYPY" Then
			txtPort7.Text = "Port Moresby, PNG"
			txtLatRad1.Text = "-0.164817259029998"
			txtLongRad1.Text = "-2.56941554714432"
		ElseIf cmbICAO15.Text = "BGBW" Then
			txtPort7.Text = "Narsarsuaq"
			txtLatRad1.Text = "1.0674724593406"
			txtLongRad1.Text = "0.792873990360157"
		ElseIf cmbICAO15.Text = "BGGH" Then
			txtPort7.Text = "Godthab"
			txtLatRad1.Text = "1.12035593567603"
			txtLongRad1.Text = "0.902044335072403"
		ElseIf cmbICAO15.Text = "BIRK" Then
			txtPort7.Text = "Reykjavik"
			txtLatRad1.Text = "1.1192505604831"
			txtLongRad1.Text = "0.382983415529289"
		ElseIf cmbICAO15.Text = "CYAM" Then
			txtPort7.Text = "Sault Ste. Marie"
			txtLatRad1.Text = "0.811316302789564"
			txtLongRad1.Text = "1.47497775086041"
		ElseIf cmbICAO15.Text = "CYFB" Then
			txtPort7.Text = "Iqaluit"
			txtLatRad1.Text = "1.11276375342985"
			txtLongRad1.Text = "1.19653955752558"
		ElseIf cmbICAO15.Text = "CYQX" Then
			txtPort7.Text = "Gander"
			txtLatRad1.Text = "0.854164135926025"
			txtLongRad1.Text = "0.952426172813306"
		ElseIf cmbICAO15.Text = "CYYQ" Then
			txtPort7.Text = "Churchill Falls"
			txtLatRad1.Text = "1.02520640262147"
			txtLongRad1.Text = "1.64177304970933"
		ElseIf cmbICAO15.Text = "CYYR" Then
			txtPort7.Text = "Goose Bay"
			txtLatRad1.Text = "0.930609557163376"
			txtLongRad1.Text = "1.05464428933844"
		ElseIf cmbICAO15.Text = "CYYT" Then
			txtPort7.Text = "St John's, NFLD"
			txtLatRad1.Text = "0.831096700978833"
			txtLongRad1.Text = "0.920690269247875"
		ElseIf cmbICAO15.Text = "DAAG" Then
			txtPort7.Text = "Algiers, Algeria"
			txtLatRad1.Text = "0.640419480198453"
			txtLongRad1.Text = "-0.0561705130933508"
		ElseIf cmbICAO15.Text = "DIAP" Then
			txtPort7.Text = "Abidjan"
			txtLatRad1.Text = "0.0916588745505689"
			txtLongRad1.Text = "0.0685623507825106"
		ElseIf cmbICAO15.Text = "DNMM" Then
			txtPort7.Text = "Lagos, Nigeria"
			txtLatRad1.Text = "0.114755398318627"
			txtLongRad1.Text = "-0.0579158423453452"
		ElseIf cmbICAO15.Text = "DRRN" Then
			txtPort7.Text = "Niami, Niger"
			txtLatRad1.Text = "0.235299471989702"
			txtLongRad1.Text = "-0.0379318224100101"
		ElseIf cmbICAO15.Text = "EBBR" Then
			txtPort7.Text = "Brussels"
			txtLatRad1.Text = "0.88840167808598"
			txtLongRad1.Text = "-0.0785107275188782"
		ElseIf cmbICAO15.Text = "EDDW" Then
			txtPort7.Text = "Bremen, Germany"
			txtLatRad1.Text = "0.925868079362125"
			txtLongRad1.Text = "-0.153385352429435"
		ElseIf cmbICAO15.Text = "EFHK" Then
			txtPort7.Text = "Helsinki, Finland"
			txtLatRad1.Text = "1.05272442716125"
			txtLongRad1.Text = "-0.435750536581251"
		ElseIf cmbICAO15.Text = "EGPD" Then
			txtPort7.Text = "Aberdeen"
			txtLatRad1.Text = "0.998415598603356"
			txtLongRad1.Text = "0.0383681547230087"
		ElseIf cmbICAO15.Text = "EGPK" Then
			txtPort7.Text = "Prestwick"
			txtLatRad1.Text = "0.968686823677719"
			txtLongRad1.Text = "0.0798779020996071"
		ElseIf cmbICAO15.Text = "EHBK" Then
			txtPort7.Text = "Maastricht, Netherlands"
			txtLatRad1.Text = "0.888663477473779"
			txtLongRad1.Text = "-0.100821853123539"
		ElseIf cmbICAO15.Text = "EINN" Then
			txtPort7.Text = "Shannon"
			txtLatRad1.Text = "0.919788515801012"
			txtLongRad1.Text = "0.155741546919627"
		ElseIf cmbICAO15.Text = "EKCH" Then
			txtPort7.Text = "Copenhagen"
			txtLatRad1.Text = "0.97054850821318"
			txtLongRad1.Text = "-0.220493262168617"
		ElseIf cmbICAO15.Text = "ELLX" Then
			txtPort7.Text = "Luxembourg"
			txtLatRad1.Text = "0.86609055248132"
			txtLongRad1.Text = "-0.108297680086248"
		ElseIf cmbICAO15.Text = "ENBR" Then
			txtPort7.Text = "Bergen, Norway"
			txtLatRad1.Text = "1.05231718366911"
			txtLongRad1.Text = "-0.091106186954104"
		ElseIf cmbICAO15.Text = "FAGM" Then
			txtPort7.Text = "Rand"
			txtLatRad1.Text = "-0.458003484544179"
			txtLongRad1.Text = "-0.49133927325727"
		ElseIf cmbICAO15.Text = "FALA" Then
			txtPort7.Text = "Lanseria, RSA"
			txtLatRad1.Text = "-0.452622052683863"
			txtLongRad1.Text = "-0.48735410479855"
		ElseIf cmbICAO15.Text = "FAWM" Then
			txtPort7.Text = "Windhoek"
			txtLatRad1.Text = "-0.392379104669192"
			txtLongRad1.Text = "-0.304967197965142"
		ElseIf cmbICAO15.Text = "FCBB" Then
			txtPort7.Text = "Brazzaville, Congo"
			txtLatRad1.Text = "-0.0742928484932253"
			txtLongRad1.Text = "-0.266162710929135"
		ElseIf cmbICAO15.Text = "FEFF" Then
			txtPort7.Text = "Bangui, CAE"
			txtLatRad1.Text = "0.0767653982668839"
			txtLongRad1.Text = "-0.323264066290216"
		ElseIf cmbICAO15.Text = "FMMI" Then
			txtPort7.Text = "Antananarivo, Madagascar"
			txtLatRad1.Text = "-0.328063721733201"
			txtLongRad1.Text = "-0.828624151205175"
		ElseIf cmbICAO15.Text = "FNLU" Then
			txtPort7.Text = "Luanda"
			txtLatRad1.Text = "-0.154548905264098"
			txtLongRad1.Text = "-0.231023415322316"
		ElseIf cmbICAO15.Text = "FOOL" Then
			txtPort7.Text = "Libreville"
			txtLatRad1.Text = "-0.00799942573830734"
			txtLongRad1.Text = "-0.164322749075266"
		ElseIf cmbICAO15.Text = "FSIA" Then
			txtPort7.Text = "Seychelles Intl"
			txtLatRad1.Text = "-0.0815359648890018"
			txtLongRad1.Text = "-0.969064978348985"
		ElseIf cmbICAO15.Text = "FVHA" Then
			txtPort7.Text = "Harare, Zimbabwe"
			txtLatRad1.Text = "-0.31296662370345"
			txtLongRad1.Text = "-0.54268104208677"
		ElseIf cmbICAO15.Text = "FZNA" Then
			txtPort7.Text = "Goma, Zaire"
			txtLatRad1.Text = "-0.0290888208665722"
			txtLongRad1.Text = "-0.510217917999676"
		ElseIf cmbICAO15.Text = "GBYD" Then
			txtPort7.Text = "Banjul"
			txtLatRad1.Text = "0.23285601103691"
			txtLongRad1.Text = "0.290742764561389"
		ElseIf cmbICAO15.Text = "GCXO" Then
			txtPort7.Text = "Tenerife"
			txtLatRad1.Text = "0.497157037431"
			txtLongRad1.Text = "0.2851867998"
		ElseIf cmbICAO15.Text = "GMAA" Then
			txtPort7.Text = "Agadir"
			txtLatRad1.Text = "0.530260115577"
			txtLongRad1.Text = "0.1667080324"
		ElseIf cmbICAO15.Text = "GOOY" Then
			txtPort7.Text = "Dakar"
			txtLatRad1.Text = "0.257290620565"
			txtLongRad1.Text = "0.3052580862"
		ElseIf cmbICAO15.Text = "HELX" Then
			txtPort7.Text = "Luxor"
			txtLatRad1.Text = "0.447967841345"
			txtLongRad1.Text = "-0.570722665"
		ElseIf cmbICAO15.Text = "HKNW" Then
			txtPort7.Text = "Nairobi-Wilson"
			txtLatRad1.Text = "-0.02298016848"
			txtLongRad1.Text = "-0.642572053"
		ElseIf cmbICAO15.Text = "HSSS" Then
			txtPort7.Text = "Khartoum"
			txtLatRad1.Text = "0.272271363311"
			txtLongRad1.Text = "-0.568250116"
		ElseIf cmbICAO15.Text = "HTDA" Then
			txtPort7.Text = "Dar-Es-Salaam"
			txtLatRad1.Text = "-0.11999138607"
			txtLongRad1.Text = "-0.684198156"
		ElseIf cmbICAO15.Text = "I69" Then
			txtPort7.Text = "Batavia, OH"
			txtLatRad1.Text = "0.682045582859"
			txtLongRad1.Text = "1.4697417631"
		ElseIf cmbICAO15.Text = "KANC" Then
			txtPort7.Text = "Anchorage"
			txtLatRad1.Text = "1.067292108651"
			txtLongRad1.Text = "2.6215601674"
		ElseIf cmbICAO15.Text = "KBGR" Then
			txtPort7.Text = "Bangor"
			txtLatRad1.Text = "0.782052948998"
			txtLongRad1.Text = "1.2012810353"
		ElseIf cmbICAO15.Text = "KBOI" Then
			txtPort7.Text = "Boise"
			txtLatRad1.Text = "0.760352688631"
			txtLongRad1.Text = "2.0285089231"
		ElseIf cmbICAO15.Text = "KCAE" Then
			txtPort7.Text = "Columbia, SC"
			txtLatRad1.Text = "0.592364748127"
			txtLongRad1.Text = "1.4158110892"
		ElseIf cmbICAO15.Text = "KEWK" Then
			txtPort7.Text = "Newton, KS"
			txtLatRad.Text = "0.664222862"
			txtLongRad.Text = "1.697771939"
		ElseIf cmbICAO15.Text = "KICT" Then
			txtPort7.Text = "Wichita, KS"
			txtLatRad1.Text = "0.657116463376"
			txtLongRad1.Text = "1.7005324679"
		ElseIf cmbICAO15.Text = "KIDP" Then
			txtPort7.Text = "Independence, KS"
			txtLatRad1.Text = "0.648535261220"
			txtLongRad1.Text = "1.6716472687"
		ElseIf cmbICAO15.Text = "KJNU" Then
			txtPort7.Text = "Juneau, AK"
			txtLatRad1.Text = "1.018545062643"
			txtLongRad1.Text = "2.3488738036"
		ElseIf cmbICAO15.Text = "KMIA" Then
			txtPort7.Text = "Miami, FL"
			txtLatRad1.Text = "0.450178591731"
			txtLongRad1.Text = "1.4013248564"
		ElseIf cmbICAO15.Text = "KMSP" Then
			txtPort7.Text = "Minneapolis, MN"
			txtLatRad1.Text = "0.783391034758"
			txtLongRad1.Text = "1.6269086622"
		ElseIf cmbICAO15.Text = "KNUD" Then
			txtPort7.Text = "ADAK, AK"
			txtLatRad1.Text = "0.905348825123"
			txtLongRad1.Text = "3.0835022783"
		ElseIf cmbICAO15.Text = "KOAK" Then
			txtPort7.Text = "Oakland, CA"
			txtLatRad1.Text = "0.658454549136"
			txtLongRad1.Text = "2.1331995894"
		ElseIf cmbICAO15.Text = "KPDK" Then
			txtPort7.Text = "Atlanta, GA"
			txtLatRad1.Text = "0.590648507696"
			txtLongRad1.Text = "1.4713416483"
		ElseIf cmbICAO15.Text = "KVRB" Then
			txtPort7.Text = "Vero Beach"
			txtLatRad1.Text = "0.482670804639"
			txtLongRad1.Text = "1.4035356068"
		ElseIf cmbICAO15.Text = "LCPH" Then
			txtPort7.Text = "Larnaca, Cyprus"
			txtLatRad1.Text = "0.608741754275"
			txtLongRad1.Text = "-0.586954227"
		ElseIf cmbICAO15.Text = "LEMD" Then
			txtPort7.Text = "Madrid"
			txtLatRad1.Text = "0.706392925924"
			txtLongRad1.Text = "-0.062133721"
		ElseIf cmbICAO15.Text = "LEMG" Then
			txtPort7.Text = "Malaga"
			txtLatRad1.Text = "0.640099503169"
			txtLongRad1.Text = "0.0784816387"
		ElseIf cmbICAO15.Text = "LFPN" Then
			txtPort7.Text = "Toussus Le Noble"
			txtLatRad1.Text = "0.850877099168"
			txtLongRad1.Text = "-0.036739181"
		ElseIf cmbICAO15.Text = "LGAT" Then
			txtPort7.Text = "Athens"
			txtLatRad1.Text = "0.661247075939"
			txtLongRad1.Text = "-0.414166631"
		ElseIf cmbICAO15.Text = "LGIR" Then
			txtPort7.Text = "Iraklion"
			txtLatRad1.Text = "0.616770268834"
			txtLongRad1.Text = "-0.439444817"
		ElseIf cmbICAO15.Text = "LIRA" Then
			txtPort7.Text = "Rome"
			txtLatRad1.Text = "0.729518538513"
			txtLongRad1.Text = "-0.219824219"
		ElseIf cmbICAO15.Text = "LKPR" Then
			txtPort7.Text = "Prague, Czech"
			txtLatRad1.Text = "0.874439044070"
			txtLongRad1.Text = "-0.248913040"
		ElseIf cmbICAO15.Text = "LPAZ" Then
			txtPort7.Text = "Santa Maria"
			txtLatRad1.Text = "0.645306402104"
			txtLongRad1.Text = "0.4393284615"
		ElseIf cmbICAO15.Text = "LPPR" Then
			txtPort7.Text = "Porto, Portugal"
			txtLatRad1.Text = "0.719657428239"
			txtLongRad1.Text = "0.1514364014"
		ElseIf cmbICAO15.Text = "LROP" Then
			txtPort7.Text = "Bucharest, Romania"
			txtLatRad1.Text = "0.777893247614"
			txtLongRad1.Text = "-0.455298224"
		ElseIf cmbICAO15.Text = "LTAC" Then
			txtPort7.Text = "Ankara"
			txtLatRad1.Text = "0.700313362363"
			txtLongRad1.Text = "-0.575842298"
		ElseIf cmbICAO15.Text = "LTBA" Then
			txtPort7.Text = "Istanbul, Turkey"
			txtLatRad1.Text = "0.715177749826"
			txtLongRad1.Text = "-0.502945713"
		ElseIf cmbICAO15.Text = "MROC" Then
			txtPort7.Text = "San Jose, CR"
			txtLatRad1.Text = "0.174416569916"
			txtLongRad1.Text = "1.4697708519"
		ElseIf cmbICAO15.Text = "NTSU" Then
			txtPort7.Text = "Pago Pago"
			txtLatRad1.Text = "0.250192948273"
			txtLongRad1.Text = "2.9794515661"
		ElseIf cmbICAO15.Text = "NZAA" Then
			txtPort7.Text = "Auckland"
			txtLatRad1.Text = "-0.64588817852"
			txtLongRad1.Text = "-3.050690088"
		ElseIf cmbICAO15.Text = "OOMS" Then
			txtPort7.Text = "SEEB, Oman"
			txtLatRad1.Text = "0.411781348187"
			txtLongRad1.Text = "-1.017148799"
		ElseIf cmbICAO15.Text = "OPKC" Then
			txtPort7.Text = "Karachi"
			txtLatRad1.Text = "0.434703339030"
			txtLongRad1.Text = "-1.172104948"
		ElseIf cmbICAO15.Text = "PAOM" Then
			txtPort7.Text = "Nome, AK"
			txtLatRad1.Text = "1.125970078103"
			txtLongRad1.Text = "2.8875308921"
		ElseIf cmbICAO15.Text = "PGSN" Then
			txtPort7.Text = "Saipan"
			txtLatRad1.Text = "0.263922871722"
			txtLongRad1.Text = "-2.543526497"
		ElseIf cmbICAO15.Text = "PHNL" Then
			txtPort7.Text = "Honolulu, HI"
			txtLatRad1.Text = "0.372075107704"
			txtLongRad1.Text = "2.7562821324"
		ElseIf cmbICAO15.Text = "PHTO" Then
			txtPort7.Text = "HILO"
			txtLatRad1.Text = "0.344237106135"
			txtLongRad1.Text = "2.7061620940"
		ElseIf cmbICAO15.Text = "PKMJ" Then
			txtPort7.Text = "Majuro"
			txtLatRad1.Text = "0.123249334012"
			txtLongRad1.Text = "-2.989312676"
		ElseIf cmbICAO15.Text = "PLCH" Then
			txtPort7.Text = "Christmas Island"
			txtLatRad1.Text = "0.034702963294"
			txtLongRad1.Text = "2.7463628445"
		ElseIf cmbICAO15.Text = "PMDY" Then
			txtPort7.Text = "Midway"
			txtLatRad1.Text = "0.492386470808"
			txtLongRad1.Text = "3.0958650272"
		ElseIf cmbICAO15.Text = "PTRO" Then
			txtPort7.Text = "Palau"
			txtLatRad1.Text = "0.128543499409"
			txtLongRad1.Text = "-2.348369597"
		ElseIf cmbICAO15.Text = "PWAK" Then
			txtPort7.Text = "WAKE"
			txtLatRad1.Text = "0.336499479785"
			txtLongRad1.Text = "-2.908445754"
		ElseIf cmbICAO15.Text = "RCTP" Then
			txtPort7.Text = "Chiang Kai Shek"
			txtLatRad1.Text = "0.437699487579"
			txtLongRad1.Text = "-2.115717208"
		ElseIf cmbICAO15.Text = "RJCK" Then
			txtPort7.Text = "Kushiro"
			txtLatRad1.Text = "0.751218798879"
			txtLongRad1.Text = "-2.516677515"
		ElseIf cmbICAO15.Text = "RJTT" Then
			txtPort7.Text = "Tokyo"
			txtLatRad1.Text = "0.620580904367"
			txtLongRad1.Text = "-2.437643189"
		ElseIf cmbICAO15.Text = "RKSS" Then
			txtPort7.Text = "Seoul, Korea"
			txtLatRad1.Text = "0.655429311766"
			txtLongRad1.Text = "-2.213077492"
		ElseIf cmbICAO15.Text = "RPMM" Then
			txtPort7.Text = "Manilla"
			txtLatRad1.Text = "0.253218185644"
			txtLongRad1.Text = "-2.112197461"
		ElseIf cmbICAO15.Text = "SAEZ" Then
			txtPort7.Text = "Ezeiza"
			txtLatRad1.Text = "-0.60772364554"
			txtLongRad1.Text = "1.0215993888"
		ElseIf cmbICAO15.Text = "SBEG" Then
			txtPort7.Text = "Manaus"
			txtLatRad1.Text = "-0.05305800926"
			txtLongRad1.Text = "1.0480120382"
		ElseIf cmbICAO15.Text = "SBGL" Then
			txtPort7.Text = "Rio De Janeiro, Brazil"
			txtLatRad1.Text = "-0.39810960238"
			txtLongRad1.Text = "0.7548549015"
		ElseIf cmbICAO15.Text = "SBSP" Then
			txtPort7.Text = "Sao Paulo"
			txtLatRad1.Text = "-0.41233403578"
			txtLongRad1.Text = "0.8143124513"
		ElseIf cmbICAO15.Text = "SCEL" Then
			txtPort7.Text = "Santiago, Chile"
			txtLatRad1.Text = "-0.58279452606"
			txtLongRad1.Text = "1.2354022222"
		ElseIf cmbICAO15.Text = "SVMG" Then
			txtPort7.Text = "Margarita, VE"
			txtLatRad1.Text = "0.190531776676"
			txtLongRad1.Text = "1.1163998560"
		ElseIf cmbICAO15.Text = "TTPP" Then
			txtPort7.Text = "Picaro"
			txtLatRad1.Text = "0.184888545428"
			txtLongRad1.Text = "1.0705558744"
		ElseIf cmbICAO15.Text = "UHHH" Then
			txtPort7.Text = "Khabarovsk, Russia"
			txtLatRad1.Text = "0.846950108351"
			txtLongRad1.Text = "-2.359452438"
		ElseIf cmbICAO15.Text = "UHMM" Then
			txtPort7.Text = "Magadan, Russia"
			txtLatRad1.Text = "1.045743110153"
			txtLongRad1.Text = "-2.630502071"
		ElseIf cmbICAO15.Text = "UHPP" Then
			txtPort7.Text = "Petropavlovsk, Russia"
			txtLatRad1.Text = "0.927933385644"
			txtLongRad1.Text = "-2.7654742"
		ElseIf cmbICAO15.Text = "UHSS" Then
			txtPort7.Text = "Yuzhno, Russia"
			txtLatRad1.Text = "0.700720605855"
			txtLongRad1.Text = "-2.490730287"
		ElseIf cmbICAO15.Text = "UTTT" Then
			txtPort7.Text = "Tashkent, Russia"
			txtLatRad1.Text = "0.719948316448"
			txtLongRad1.Text = "-1.209222283"
		ElseIf cmbICAO15.Text = "UUEE" Then
			txtPort7.Text = "Moscow, Russia"
			txtLatRad1.Text = "0.976889871162"
			txtLongRad1.Text = "-0.65301494"
		ElseIf cmbICAO15.Text = "VABB" Then
			txtPort7.Text = "Bombay"
			txtLatRad1.Text = "0.333212443027"
			txtLongRad1.Text = "-1.271763248"
		ElseIf cmbICAO15.Text = "VCBI" Then
			txtPort7.Text = "Columbo, Sri Lanka"
			txtLatRad1.Text = "0.125314640293"
			txtLongRad1.Text = "-1.394227184"
		ElseIf cmbICAO15.Text = "VIDP" Then
			txtPort7.Text = "Delhi"
			txtLatRad1.Text = "0.498582389653"
			txtLongRad1.Text = "-1.345648853"
		ElseIf cmbICAO15.Text = "VNKT" Then
			txtPort7.Text = "Katmandu, Nepal"
			txtLatRad1.Text = "0.485230620875"
			txtLongRad1.Text = "-1.489842138"
		ElseIf cmbICAO15.Text = "VOMM" Then
			txtPort7.Text = "Madras"
			txtLatRad1.Text = "0.226805536297"
			txtLongRad1.Text = "-1.399346817"
		ElseIf cmbICAO15.Text = "VOPB" Then
			txtPort7.Text = "Port Blair, Nicobar"
			txtLatRad1.Text = "0.203272680216"
			txtLongRad1.Text = "-1.618531082"
		ElseIf cmbICAO15.Text = "VRMM" Then
			txtPort7.Text = "Male, Maldives"
			txtLatRad1.Text = "0.073158384479"
			txtLongRad1.Text = "-1.283398777"
		ElseIf cmbICAO15.Text = "VTBD" Then
			txtPort7.Text = "Bangkok"
			txtLatRad1.Text = "0.242891654236"
			txtLongRad1.Text = "-1.755888494"
		ElseIf cmbICAO15.Text = "WMKJ" Then
			txtPort7.Text = "Johor Bahru, Malaysia"
			txtLatRad1.Text = "0.028594310912"
			txtLongRad1.Text = "-1.809411924"
		ElseIf cmbICAO15.Text = "WMKK" Then
			txtPort7.Text = "Kuala Lumpur"
			txtLatRad1.Text = "0.054628805587"
			txtLongRad1.Text = "-1.772410944"
		ElseIf cmbICAO15.Text = "WSSL" Then
			txtPort7.Text = "Singapore"
			txtLatRad1.Text = "0.024725497737"
			txtLongRad1.Text = "-1.812815316"
		ElseIf cmbICAO15.Text = "ZGGG" Then
			txtPort7.Text = "Guangzhou"
			txtLatRad1.Text = "0.404625498254"
			txtLongRad1.Text = "-1.976847177"
		ElseIf cmbICAO15.Text = "Other" Then
			'Call ICAO15Other
		End If

		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg3, intLeg2, intLeg4 As Double
		Dim intLeg6, intLeg5, intLeg7 As Double
		If cmbICAO15.Text <> "Other" Then

			Call CalcDist()
			txtLeg7.Text = txtDist.Text
			txtLeg7.Text = VB6.Format(txtLeg7.Text, "Fixed")
			intLeg = CDbl(txtLeg.Text)
			intLeg1 = CDbl(txtLeg1.Text)
			intLeg2 = CDbl(txtLeg2.Text)
			intLeg3 = CDbl(txtLeg3.Text)
			intLeg4 = CDbl(txtLeg4.Text)
			intLeg5 = CDbl(txtLeg5.Text)
			intLeg6 = CDbl(txtLeg6.Text)
			intLeg7 = CDbl(txtLeg7.Text)
			intTotal1 = intLeg + intLeg1 + intLeg2 + intLeg3 + intLeg4 + intLeg5 + intLeg6 + intLeg7
			txtTotal7.Text = CStr(intTotal1)
			txtTotal7.Text = VB6.Format(txtTotal7.Text, "Fixed")

		Else
			Call ICAO15Other()
		End If

	End Sub

	<Obsolete>
	Private Sub ICAO15Other()

		txtICAO15.Text = InputBox("Enter ICAO Abbreviation.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtPort7.Text = InputBox("Enter Name of Airport.", "Other ICAO", CStr(MsgBoxStyle.OKOnly))
		txtLatDeg.Text = InputBox("Enter Airport Latitude Degrees.", "Other ICAO")
		txtLatMin.Text = InputBox("Enter Airport Latitude Minutes.", "Other ICAO")
		txtLatSec.Text = InputBox("Enter Airport Latitude Seconds.", "Other ICAO")
		txtNS.Text = InputBox("Enter N or S.", "Other ICAO")
		intLatDeg = CDbl(txtLatDeg.Text)
		intLatMin = CDbl(txtLatMin.Text)
		intLatSec = CDbl(txtLatSec.Text)
		intLatRad = intLatDeg + (intLatMin / 60) + (intLatSec / 3600)
		If txtNS.Text = "S" Then
			intLatRad = intLatRad * -1
		ElseIf txtNS.Text = "s" Then
			intLatRad = intLatRad * -1
		End If
		txtLatRad1.Text = CStr(intLatRad / (180 / 3.141592654))
		txtLongDeg.Text = InputBox("Enter Airport Longitude Degrees.", "Other ICAO")
		txtLongMin.Text = InputBox("Enter Airport Longitude Minutes.", "Other ICAO")
		txtLongSec.Text = InputBox("Enter Airport Longitude Seconds.", "Other ICAO")
		txtEW.Text = InputBox("Enter E or W.", "Other ICAO")
		intLongDeg = CDbl(txtLongDeg.Text)
		intLongMin = CDbl(txtLongMin.Text)
		intLongSec = CDbl(txtLongSec.Text)
		intLongRad = intLongDeg + (intLongMin / 60) + (intLongSec / 3600)
		If txtEW.Text = "E" Then
			intLongRad = intLongRad * -1
		ElseIf txtEW.Text = "e" Then
			intLongRad = intLongRad * -1
		End If
		txtLongRad1.Text = CStr(intLongRad / (180 / 3.141592654))
		cmbICAO15.Visible = False
		'cmbICAO15 = txtICAO15

		Call CalcDist()
		Dim intLeg, intTotal1, intLeg1 As Double
		Dim intLeg3, intLeg2, intLeg4 As Double
		Dim intLeg6, intLeg5, intLeg7 As Double
		txtLeg7.Text = txtDist.Text
		txtLeg7.Text = VB6.Format(txtLeg7.Text, "Fixed")
		intLeg = CDbl(txtLeg.Text)
		intLeg1 = CDbl(txtLeg1.Text)
		intLeg2 = CDbl(txtLeg2.Text)
		intLeg3 = CDbl(txtLeg3.Text)
		intLeg4 = CDbl(txtLeg4.Text)
		intLeg5 = CDbl(txtLeg5.Text)
		intLeg6 = CDbl(txtLeg6.Text)
		intLeg7 = CDbl(txtLeg7.Text)
		intTotal1 = intLeg + intLeg1 + intLeg2 + intLeg3 + intLeg4 + intLeg5 + intLeg6 + intLeg7
		txtTotal7.Text = CStr(intTotal1)
		txtTotal7.Text = VB6.Format(txtTotal7.Text, "Fixed")

		strICAO = txtICAO15.Text
		strPort = txtPort7.Text
		strLatRad = txtLatRad1.Text
		strLongRad = txtLongRad1.Text
		FileOpen(1, "Bid ICAO.txt", OpenMode.Append)
		WriteLine(1, strICAO, strPort, strLatRad, strLongRad)
		FileClose(1)

	End Sub

	Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
		End
	End Sub

	Private Sub CalcDist()

		MyLongRad = CDbl(txtLongRad.Text)
		MyLongRad1 = CDbl(txtLongRad1.Text)
		intLatRad = CDbl(txtLatRad.Text)
		intLatRad1 = CDbl(txtLatRad1.Text)
		intLongRad = CDbl(txtLongRad.Text)
		intLongRad1 = CDbl(txtLongRad1.Text)
		MyRad = MyLongRad1 - MyLongRad
		MySin1 = System.Math.Sin(intLatRad)
		MySin2 = System.Math.Sin(intLatRad1)
		MyCos1 = System.Math.Cos(intLatRad)
		MyCos2 = System.Math.Cos(intLatRad1)
		MyCos3 = System.Math.Cos(MyRad)
		txtSin1.Text = CStr(MySin1)
		txtSin2.Text = CStr(MySin2)
		txtCos1.Text = CStr(MyCos1)
		txtCos2.Text = CStr(MyCos2)
		txtCos3.Text = CStr(MyCos3)
		txtRad.Text = CStr(MyRad)
		Pi = 3.14159265359
		MyCalc = (MySin1 * MySin2) + (MyCos1 * MyCos2 * MyCos3)
		ArcCos = -System.Math.Atan(MyCalc / System.Math.Sqrt(1 - MyCalc * MyCalc)) + Pi / 2
		txtDist.Text = CStr(3437.7468 * ArcCos)
		
	End Sub
	
	'UPGRADE_WARNING: Form event frmBidCalc1.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmBidCalc1_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
		End
	End Sub
	
	Private Sub txtICAO_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO.DoubleClick
		cmbICAO.Visible = True
	End Sub
	
	Private Sub txtICAO1_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO1.DoubleClick
		cmbICAO1.Visible = True
	End Sub
	
	Private Sub txtICAO2_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO2.DoubleClick
		cmbICAO2.Visible = True
	End Sub
	
	Private Sub txtICAO3_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO3.DoubleClick
		cmbICAO3.Visible = True
	End Sub
	
	Private Sub txtICAO4_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO4.DoubleClick
		cmbICAO4.Visible = True
	End Sub
	
	Private Sub txtICAO5_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO5.DoubleClick
		cmbICAO5.Visible = True
	End Sub
	
	Private Sub txtICAO6_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO6.DoubleClick
		cmbICAO6.Visible = True
	End Sub
	
	Private Sub txtICAO7_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO7.DoubleClick
		cmbICAO7.Visible = True
	End Sub
	
	Private Sub txtICAO8_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO8.DoubleClick
		cmbICAO8.Visible = True
	End Sub
	
	Private Sub txtICAO9_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO9.DoubleClick
		cmbICAO9.Visible = True
	End Sub
	
	Private Sub txtICAO10_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO10.DoubleClick
		cmbICAO10.Visible = True
	End Sub
	
	Private Sub txtICAO11_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO11.DoubleClick
		cmbICAO11.Visible = True
	End Sub
	
	Private Sub txtICAO12_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO12.DoubleClick
		cmbICAO12.Visible = True
	End Sub
	
	Private Sub txtICAO13_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO13.DoubleClick
		cmbICAO13.Visible = True
	End Sub
	
	Private Sub txtICAO14_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO14.DoubleClick
		cmbICAO14.Visible = True
	End Sub
	
	Private Sub txtICAO15_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtICAO15.DoubleClick
		cmbICAO15.Visible = True
	End Sub
End Class