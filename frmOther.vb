Option Strict Off
Option Explicit On
Friend Class frmOther
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
	Public WithEvents cmbAJ As System.Windows.Forms.ComboBox
	Public WithEvents txtAC As System.Windows.Forms.TextBox
	Public WithEvents txtFuel As System.Windows.Forms.TextBox
	Public WithEvents txtSpeed As System.Windows.Forms.TextBox
	Public WithEvents cmdExit As System.Windows.Forms.Label
	Public WithEvents cmdCancel As System.Windows.Forms.Label
	Public WithEvents cmdDone As System.Windows.Forms.Label
	Public WithEvents Image3 As System.Windows.Forms.PictureBox
	Public WithEvents Image2 As System.Windows.Forms.PictureBox
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOther))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.cmbAJ = New System.Windows.Forms.ComboBox
		Me.txtAC = New System.Windows.Forms.TextBox
		Me.txtFuel = New System.Windows.Forms.TextBox
		Me.txtSpeed = New System.Windows.Forms.TextBox
		Me.cmdExit = New System.Windows.Forms.Label
		Me.cmdCancel = New System.Windows.Forms.Label
		Me.cmdDone = New System.Windows.Forms.Label
		Me.Image3 = New System.Windows.Forms.PictureBox
		Me.Image2 = New System.Windows.Forms.PictureBox
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Text = "Other Aircraft"
		Me.ClientSize = New System.Drawing.Size(775, 523)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BackgroundImage = CType(resources.GetObject("frmOther.BackgroundImage"), System.Drawing.Image)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmOther"
		Me.cmbAJ.Size = New System.Drawing.Size(150, 26)
		Me.cmbAJ.Location = New System.Drawing.Point(384, 368)
		Me.cmbAJ.TabIndex = 3
		Me.cmbAJ.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbAJ.BackColor = System.Drawing.SystemColors.Window
		Me.cmbAJ.CausesValidation = True
		Me.cmbAJ.Enabled = True
		Me.cmbAJ.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbAJ.IntegralHeight = True
		Me.cmbAJ.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbAJ.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmbAJ.Sorted = False
		Me.cmbAJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbAJ.TabStop = True
		Me.cmbAJ.Visible = True
		Me.cmbAJ.Name = "cmbAJ"
		Me.txtAC.AutoSize = False
		Me.txtAC.Size = New System.Drawing.Size(150, 26)
		Me.txtAC.Location = New System.Drawing.Point(384, 224)
		Me.txtAC.TabIndex = 0
		Me.txtAC.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAC.AcceptsReturn = True
		Me.txtAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAC.BackColor = System.Drawing.SystemColors.Window
		Me.txtAC.CausesValidation = True
		Me.txtAC.Enabled = True
		Me.txtAC.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAC.HideSelection = True
		Me.txtAC.ReadOnly = False
		Me.txtAC.Maxlength = 0
		Me.txtAC.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAC.MultiLine = False
		Me.txtAC.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAC.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAC.TabStop = True
		Me.txtAC.Visible = True
		Me.txtAC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAC.Name = "txtAC"
		Me.txtFuel.AutoSize = False
		Me.txtFuel.Size = New System.Drawing.Size(150, 26)
		Me.txtFuel.Location = New System.Drawing.Point(384, 272)
		Me.txtFuel.TabIndex = 1
		Me.txtFuel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFuel.AcceptsReturn = True
		Me.txtFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFuel.BackColor = System.Drawing.SystemColors.Window
		Me.txtFuel.CausesValidation = True
		Me.txtFuel.Enabled = True
		Me.txtFuel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFuel.HideSelection = True
		Me.txtFuel.ReadOnly = False
		Me.txtFuel.Maxlength = 0
		Me.txtFuel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFuel.MultiLine = False
		Me.txtFuel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFuel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFuel.TabStop = True
		Me.txtFuel.Visible = True
		Me.txtFuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFuel.Name = "txtFuel"
		Me.txtSpeed.AutoSize = False
		Me.txtSpeed.Size = New System.Drawing.Size(150, 26)
		Me.txtSpeed.Location = New System.Drawing.Point(384, 320)
		Me.txtSpeed.TabIndex = 2
		Me.txtSpeed.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSpeed.AcceptsReturn = True
		Me.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSpeed.BackColor = System.Drawing.SystemColors.Window
		Me.txtSpeed.CausesValidation = True
		Me.txtSpeed.Enabled = True
		Me.txtSpeed.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSpeed.HideSelection = True
		Me.txtSpeed.ReadOnly = False
		Me.txtSpeed.Maxlength = 0
		Me.txtSpeed.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSpeed.MultiLine = False
		Me.txtSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSpeed.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSpeed.TabStop = True
		Me.txtSpeed.Visible = True
		Me.txtSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSpeed.Name = "txtSpeed"
		Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.cmdExit.Text = "E&xit"
		Me.cmdExit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdExit.ForeColor = System.Drawing.Color.White
		Me.cmdExit.Size = New System.Drawing.Size(113, 33)
		Me.cmdExit.Location = New System.Drawing.Point(488, 492)
		Me.cmdExit.TabIndex = 13
		Me.cmdExit.BackColor = System.Drawing.Color.Transparent
		Me.cmdExit.Enabled = True
		Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdExit.UseMnemonic = True
		Me.cmdExit.Visible = True
		Me.cmdExit.AutoSize = False
		Me.cmdExit.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.cmdExit.Name = "cmdExit"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.cmdCancel.Text = "&Cancel"
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.ForeColor = System.Drawing.Color.White
		Me.cmdCancel.Size = New System.Drawing.Size(113, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(336, 492)
		Me.cmdCancel.TabIndex = 12
		Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.UseMnemonic = True
		Me.cmdCancel.Visible = True
		Me.cmdCancel.AutoSize = False
		Me.cmdCancel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdDone.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.cmdDone.Text = "&Done"
		Me.cmdDone.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDone.ForeColor = System.Drawing.Color.White
		Me.cmdDone.Size = New System.Drawing.Size(113, 33)
		Me.cmdDone.Location = New System.Drawing.Point(184, 492)
		Me.cmdDone.TabIndex = 11
		Me.cmdDone.BackColor = System.Drawing.Color.Transparent
		Me.cmdDone.Enabled = True
		Me.cmdDone.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDone.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDone.UseMnemonic = True
		Me.cmdDone.Visible = True
		Me.cmdDone.AutoSize = False
		Me.cmdDone.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.cmdDone.Name = "cmdDone"
		Me.Image3.Size = New System.Drawing.Size(794, 34)
		Me.Image3.Location = New System.Drawing.Point(0, 488)
		Me.Image3.Image = CType(resources.GetObject("Image3.Image"), System.Drawing.Image)
		Me.Image3.Visible = False
		Me.Image3.Enabled = True
		Me.Image3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image3.Name = "Image3"
		Me.Image2.Size = New System.Drawing.Size(794, 34)
		Me.Image2.Location = New System.Drawing.Point(0, 488)
		Me.Image2.Image = CType(resources.GetObject("Image2.Image"), System.Drawing.Image)
		Me.Image2.Visible = False
		Me.Image2.Enabled = True
		Me.Image2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Image2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image2.Name = "Image2"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label11.Text = "Bid Calculations"
		Me.Label11.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.White
		Me.Label11.Size = New System.Drawing.Size(521, 33)
		Me.Label11.Location = New System.Drawing.Point(144, 48)
		Me.Label11.TabIndex = 10
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.Enabled = True
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label12.Text = "PILOT INTERNATIONAL"
		Me.Label12.Font = New System.Drawing.Font("Arial", 24!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.ForeColor = System.Drawing.Color.White
		Me.Label12.Size = New System.Drawing.Size(521, 41)
		Me.Label12.Location = New System.Drawing.Point(144, 8)
		Me.Label12.TabIndex = 9
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Enabled = True
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = False
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label4.Text = "AvGas or Jet Fuel:"
		Me.Label4.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.White
		Me.Label4.Size = New System.Drawing.Size(145, 25)
		Me.Label4.Location = New System.Drawing.Point(224, 376)
		Me.Label4.TabIndex = 8
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label5.Text = "Other Aircraft Specs"
		Me.Label5.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.White
		Me.Label5.Size = New System.Drawing.Size(761, 33)
		Me.Label5.Location = New System.Drawing.Point(8, 144)
		Me.Label5.TabIndex = 7
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label3.Text = "Aircraft Model:"
		Me.Label3.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.White
		Me.Label3.Size = New System.Drawing.Size(153, 25)
		Me.Label3.Location = New System.Drawing.Point(216, 232)
		Me.Label3.TabIndex = 6
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label2.Text = "Top Speed:"
		Me.Label2.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Size = New System.Drawing.Size(145, 25)
		Me.Label2.Location = New System.Drawing.Point(224, 328)
		Me.Label2.TabIndex = 5
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label1.Text = "Total Fuel in Lbs:"
		Me.Label1.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Size = New System.Drawing.Size(137, 17)
		Me.Label1.Location = New System.Drawing.Point(232, 280)
		Me.Label1.TabIndex = 4
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(cmbAJ)
		Me.Controls.Add(txtAC)
		Me.Controls.Add(txtFuel)
		Me.Controls.Add(txtSpeed)
		Me.Controls.Add(cmdExit)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdDone)
		Me.Controls.Add(Image3)
		Me.Controls.Add(Image2)
		Me.Controls.Add(Label11)
		Me.Controls.Add(Label12)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmOther
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmOther
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmOther()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Dim intAJ, intFuelLbs, intCalc As Short
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		frmBidCalc.DefInstance.cmbAC.Visible = True
		frmBidCalc.DefInstance.Show()
		Me.Close()
	End Sub

	<Obsolete>
	Private Sub cmdCancel_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdCancel.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

		Image2.Visible = True
		Image3.Visible = False

	End Sub

	Private Sub cmdDone_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDone.Click

		frmBidCalc.DefInstance.cmbAC.Visible = False
		frmBidCalc.DefInstance.txtAC.Text = txtAC.Text
		frmBidCalc.DefInstance.txtFuel.Text = txtFuel.Text
		frmBidCalc.DefInstance.txtSpeed.Text = txtSpeed.Text
		intFuelLbs = CShort(txtFuel.Text)
		If cmbAJ.Text = "AvGas" Then
			intAJ = 6
		Else
			intAJ = 6.7
		End If
		intCalc = intFuelLbs / intAJ
		frmBidCalc.DefInstance.txtCalc.Text = CStr(intCalc)
		frmBidCalc.DefInstance.Show()
		Me.Close()
		
	End Sub

    <Obsolete>
    Private Sub cmdDone_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdDone.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Image2.Visible = False
		Image3.Visible = False
	End Sub
	
	Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
		End
	End Sub

    <Obsolete>
    Private Sub cmdExit_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdExit.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Image2.Visible = False
		Image3.Visible = True
		
	End Sub
	
	Private Sub frmOther_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		cmbAJ.Items.Add("AvGas")
		cmbAJ.Items.Add("Jet Fuel")
	End Sub
	
	'UPGRADE_WARNING: Form event frmOther.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmOther_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
		End
	End Sub
End Class