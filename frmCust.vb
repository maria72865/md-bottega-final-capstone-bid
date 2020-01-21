Option Strict Off
Option Explicit On
Friend Class frmCust
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
	Public WithEvents txtPhone As System.Windows.Forms.TextBox
	Public WithEvents txtFax As System.Windows.Forms.TextBox
	Public WithEvents txtCountry As System.Windows.Forms.TextBox
	Public WithEvents txtState As System.Windows.Forms.TextBox
	Public WithEvents txtCity As System.Windows.Forms.TextBox
	Public WithEvents txtAddress As System.Windows.Forms.TextBox
	Public WithEvents txtContact As System.Windows.Forms.TextBox
	Public WithEvents txtCompany As System.Windows.Forms.TextBox
	Public WithEvents cmdExit As System.Windows.Forms.Label
	Public WithEvents cmdNext As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents lblPhone As System.Windows.Forms.Label
    Public WithEvents lblFax As System.Windows.Forms.Label
    Public WithEvents lblCountry As System.Windows.Forms.Label
    Public WithEvents lblState As System.Windows.Forms.Label
    Public WithEvents lblCity As System.Windows.Forms.Label
    Public WithEvents lblAddress As System.Windows.Forms.Label
    Public WithEvents lblContact As System.Windows.Forms.Label
    Public WithEvents lblEmail As Label
    Public WithEvents txtEmail As TextBox
    Public WithEvents lblCompany As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCust))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.cmdExit = New System.Windows.Forms.Label()
        Me.cmdNext = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPhone
        '
        Me.txtPhone.AcceptsReturn = True
        Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPhone.Location = New System.Drawing.Point(111, 360)
        Me.txtPhone.MaxLength = 0
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhone.Size = New System.Drawing.Size(257, 26)
        Me.txtPhone.TabIndex = 6
        '
        'txtFax
        '
        Me.txtFax.AcceptsReturn = True
        Me.txtFax.BackColor = System.Drawing.SystemColors.Window
        Me.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFax.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtFax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFax.Location = New System.Drawing.Point(488, 360)
        Me.txtFax.MaxLength = 0
        Me.txtFax.Multiline = True
        Me.txtFax.Name = "txtFax"
        Me.txtFax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFax.Size = New System.Drawing.Size(257, 26)
        Me.txtFax.TabIndex = 7
        '
        'txtCountry
        '
        Me.txtCountry.AcceptsReturn = True
        Me.txtCountry.BackColor = System.Drawing.SystemColors.Window
        Me.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCountry.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCountry.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCountry.Location = New System.Drawing.Point(488, 304)
        Me.txtCountry.MaxLength = 0
        Me.txtCountry.Multiline = True
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCountry.Size = New System.Drawing.Size(257, 26)
        Me.txtCountry.TabIndex = 5
        '
        'txtState
        '
        Me.txtState.AcceptsReturn = True
        Me.txtState.BackColor = System.Drawing.SystemColors.Window
        Me.txtState.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtState.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtState.Location = New System.Drawing.Point(111, 304)
        Me.txtState.MaxLength = 0
        Me.txtState.Multiline = True
        Me.txtState.Name = "txtState"
        Me.txtState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtState.Size = New System.Drawing.Size(257, 26)
        Me.txtState.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.AcceptsReturn = True
        Me.txtCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCity.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCity.Location = New System.Drawing.Point(488, 248)
        Me.txtCity.MaxLength = 0
        Me.txtCity.Multiline = True
        Me.txtCity.Name = "txtCity"
        Me.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCity.Size = New System.Drawing.Size(257, 26)
        Me.txtCity.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.AcceptsReturn = True
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress.Location = New System.Drawing.Point(111, 248)
        Me.txtAddress.MaxLength = 0
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddress.Size = New System.Drawing.Size(257, 26)
        Me.txtAddress.TabIndex = 2
        '
        'txtContact
        '
        Me.txtContact.AcceptsReturn = True
        Me.txtContact.BackColor = System.Drawing.SystemColors.Window
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtContact.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContact.Location = New System.Drawing.Point(488, 192)
        Me.txtContact.MaxLength = 0
        Me.txtContact.Multiline = True
        Me.txtContact.Name = "txtContact"
        Me.txtContact.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtContact.Size = New System.Drawing.Size(257, 26)
        Me.txtContact.TabIndex = 1
        '
        'txtCompany
        '
        Me.txtCompany.AcceptsReturn = True
        Me.txtCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompany.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCompany.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCompany.Location = New System.Drawing.Point(111, 192)
        Me.txtCompany.MaxLength = 0
        Me.txtCompany.Multiline = True
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCompany.Size = New System.Drawing.Size(257, 26)
        Me.txtCompany.TabIndex = 0
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Transparent
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(424, 495)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(121, 25)
        Me.cmdExit.TabIndex = 20
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdNext
        '
        Me.cmdNext.BackColor = System.Drawing.Color.Transparent
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.ForeColor = System.Drawing.Color.White
        Me.cmdNext.Location = New System.Drawing.Point(240, 495)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNext.Size = New System.Drawing.Size(113, 25)
        Me.cmdNext.TabIndex = 19
        Me.cmdNext.Text = "&Next"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(126, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(521, 41)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "INTERNATIONAL AIRCRAFT DELIVERY"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(152, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(521, 33)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Bid Calculations"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(777, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Client Information"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.White
        Me.lblPhone.Location = New System.Drawing.Point(24, 368)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPhone.Size = New System.Drawing.Size(81, 17)
        Me.lblPhone.TabIndex = 15
        Me.lblPhone.Text = "Phone:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFax
        '
        Me.lblFax.BackColor = System.Drawing.Color.Transparent
        Me.lblFax.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.ForeColor = System.Drawing.Color.White
        Me.lblFax.Location = New System.Drawing.Point(400, 368)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFax.Size = New System.Drawing.Size(81, 17)
        Me.lblFax.TabIndex = 14
        Me.lblFax.Text = "Fax:"
        Me.lblFax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCountry
        '
        Me.lblCountry.BackColor = System.Drawing.Color.Transparent
        Me.lblCountry.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCountry.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.ForeColor = System.Drawing.Color.White
        Me.lblCountry.Location = New System.Drawing.Point(400, 312)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountry.Size = New System.Drawing.Size(81, 17)
        Me.lblCountry.TabIndex = 13
        Me.lblCountry.Text = "Country:"
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblState
        '
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.White
        Me.lblState.Location = New System.Drawing.Point(24, 312)
        Me.lblState.Name = "lblState"
        Me.lblState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblState.Size = New System.Drawing.Size(81, 17)
        Me.lblState.TabIndex = 12
        Me.lblState.Text = "State:"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCity
        '
        Me.lblCity.BackColor = System.Drawing.Color.Transparent
        Me.lblCity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.White
        Me.lblCity.Location = New System.Drawing.Point(400, 256)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCity.Size = New System.Drawing.Size(81, 17)
        Me.lblCity.TabIndex = 11
        Me.lblCity.Text = "City:"
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(24, 256)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(81, 17)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblContact.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.White
        Me.lblContact.Location = New System.Drawing.Point(400, 200)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblContact.Size = New System.Drawing.Size(81, 17)
        Me.lblContact.TabIndex = 9
        Me.lblContact.Text = "Contact:"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCompany
        '
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCompany.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.White
        Me.lblCompany.Location = New System.Drawing.Point(16, 200)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompany.Size = New System.Drawing.Size(89, 17)
        Me.lblCompany.TabIndex = 8
        Me.lblCompany.Text = "Company:"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(24, 424)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmail.Size = New System.Drawing.Size(81, 17)
        Me.lblEmail.TabIndex = 21
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEmail
        '
        Me.txtEmail.AcceptsReturn = True
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEmail.Location = New System.Drawing.Point(111, 415)
        Me.txtEmail.MaxLength = 0
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmail.Size = New System.Drawing.Size(257, 26)
        Me.txtEmail.TabIndex = 22
        '
        'frmCust
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(775, 523)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblCompany)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.MaximizeBox = False
        Me.Name = "frmCust"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As frmCust
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmCust
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmCust()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdNext_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.Click
        frmMileageCalc.DefInstance.Show()
        frmCust.DefInstance.Hide()
    End Sub

    'UPGRADE_WARNING: Form event frmCust.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
    Private Sub frmCust_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

End Class