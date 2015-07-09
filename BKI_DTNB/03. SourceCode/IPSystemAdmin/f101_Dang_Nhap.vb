Option Strict On
Option Explicit On 

Imports IP.Core.IPCommon
Imports IP.Core.IPException
Imports IP.Core.IPUserService
Imports IP.Core.IPData
Imports IP.Core.IPBusinessService
Imports IP.Core.IPData.DBNames


Public Class f101_Dang_Nhap
    Inherits System.Windows.Forms.Form

#Region "Nhiệm vụ của class"
    '***************************************************
    '* LOGIN - vào hệ thống   & setup application context
    '*     
    '***************************************************
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        FormatForm()
        
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents m_btnCancel As SIS.Controls.Button.SiSButton
    Friend WithEvents m_btnOK As SIS.Controls.Button.SiSButton
    Friend WithEvents m_txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents m_txtTenTruyNhap As System.Windows.Forms.TextBox
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f101_Dang_Nhap))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.m_btnOK = New SIS.Controls.Button.SiSButton()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.m_btnCancel = New SIS.Controls.Button.SiSButton()
        Me.m_txtMatKhau = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.m_txtTenTruyNhap = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.m_btnOK)
        Me.Panel1.Controls.Add(Me.m_btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(296, 36)
        Me.Panel1.TabIndex = 4
        '
        'm_btnOK
        '
        Me.m_btnOK.AdjustImageLocation = New System.Drawing.Point(0, 0)
        Me.m_btnOK.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle
        Me.m_btnOK.BtnStyle = SIS.Controls.Button.emunType.XPStyle.[Default]
        Me.m_btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.m_btnOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.m_btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.m_btnOK.ImageIndex = 1
        Me.m_btnOK.ImageList = Me.ImageList
        Me.m_btnOK.Location = New System.Drawing.Point(119, 3)
        Me.m_btnOK.Name = "m_btnOK"
        Me.m_btnOK.Size = New System.Drawing.Size(86, 30)
        Me.m_btnOK.TabIndex = 0
        Me.m_btnOK.Text = "Đăng nhập"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        '
        'm_btnCancel
        '
        Me.m_btnCancel.AdjustImageLocation = New System.Drawing.Point(0, 0)
        Me.m_btnCancel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle
        Me.m_btnCancel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.[Default]
        Me.m_btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.m_btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.m_btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.m_btnCancel.ImageIndex = 0
        Me.m_btnCancel.ImageList = Me.ImageList
        Me.m_btnCancel.Location = New System.Drawing.Point(205, 3)
        Me.m_btnCancel.Name = "m_btnCancel"
        Me.m_btnCancel.Size = New System.Drawing.Size(88, 30)
        Me.m_btnCancel.TabIndex = 1
        Me.m_btnCancel.Text = "&Thoát"
        '
        'm_txtMatKhau
        '
        Me.m_txtMatKhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txtMatKhau.Location = New System.Drawing.Point(114, 77)
        Me.m_txtMatKhau.MaxLength = 12
        Me.m_txtMatKhau.Name = "m_txtMatKhau"
        Me.m_txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.m_txtMatKhau.Size = New System.Drawing.Size(98, 20)
        Me.m_txtMatKhau.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(49, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mật khẩu:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(25, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên truy nhập:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'm_txtTenTruyNhap
        '
        Me.m_txtTenTruyNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_txtTenTruyNhap.Location = New System.Drawing.Point(114, 47)
        Me.m_txtTenTruyNhap.MaxLength = 12
        Me.m_txtTenTruyNhap.Name = "m_txtTenTruyNhap"
        Me.m_txtTenTruyNhap.Size = New System.Drawing.Size(147, 20)
        Me.m_txtTenTruyNhap.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.m_txtTenTruyNhap)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.m_txtMatKhau)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Đăng nhập - Hệ thống quản lý tài chính"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 165)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(302, 40)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(3, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Designed by BKIndex Group, 3T Corp.Ltd"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'f101_Dang_Nhap
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(302, 205)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "f101_Dang_Nhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "M001-Đăng nhập"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "PUBLIC INTERFACES"
    Public Sub displayLogin(ByRef o_Information As CLoginInformation_302, _
                            ByRef o_LoginResult As DialogResult)
        '*********************************************************************
        '* Hiện thị cửa sổ đăng nhập vào hệ thống
        '* Trả lại kết quả tùy theo kết quả đăng nhập. Có hai loại
        '* - Thành công : o_LoginResult = DialogResult.OK
        '* - Không thành công : o_LoginResult = DialogResult.Cancel
        '*********************************************************************
        Me.DialogResult = DialogResult.Cancel
        'Hiện thị cửa sổ
        Me.ShowDialog()
        o_LoginResult = Me.DialogResult
        If o_LoginResult = DialogResult.OK Then
            'phai lap trinh
            o_Information = New CLoginInformation_302(m_us_user)
        End If

    End Sub
#End Region

#Region "Data Structure"

#End Region

#Region "Members"
    Private m_strUserName As String
    Private m_us_user As New US_HT_NGUOI_SU_DUNG
#End Region

#Region "Private methods"
    Private Sub FormatForm()
        ' CControlFormat.setFormStyle(Me)
        Me.ShowInTaskbar = True
    End Sub
    Private Function ValidLogonData() As Boolean
        If Not CValidateTextBox.IsValid(Me.m_txtTenTruyNhap, DataType.StringType, allowNull.NO, False) Then
            BaseMessages.MsgBox_Warning(19)
            Return False
        End If

        If Not CValidateTextBox.IsValid(Me.m_txtMatKhau, DataType.StringType, allowNull.NO, False) Then
            BaseMessages.MsgBox_Warning(20)
            Return False
        End If



        Return True
    End Function
    Private Sub Form2UsObject()
        m_us_user.strTEN_TRUY_CAP = m_txtTenTruyNhap.Text.Trim
        m_us_user.strMAT_KHAU = m_txtMatKhau.Text.Trim
        'm_us_user.strMAT_KHAU = CIPConvert.Encoding(m_txtMatKhau.Text.Trim)
    End Sub
    Private Function SubmitLogonIsOK() As Boolean
        '*********************************************************************   
        '*  1. Kiểm tra các trường trên màn hình
        '*  2. Kiểm tra xem password, tên, nhóm có đúng không 
        '*  3. Trả lại kết quả
        '*********************************************************************
        If (Not ValidLogonData()) Then Return False
        Dim v_us_user As New US_HT_NGUOI_SU_DUNG
        Dim v_logonResult As US_HT_NGUOI_SU_DUNG.LogonResult
        Form2UsObject()
        m_us_user.check_user(m_us_user.strTEN_TRUY_CAP, CIPConvert.Encoding(m_us_user.strMAT_KHAU), v_logonResult)
        Dim v_loginSucceeded As Boolean = False

        Select Case v_logonResult
            Case US_HT_NGUOI_SU_DUNG.LogonResult.WrongPassword_OR_Name
                BaseMessages.MsgBox_Warning(18)
            Case US_HT_NGUOI_SU_DUNG.LogonResult.User_Is_Locked
                BaseMessages.MsgBox_Warning(21)
            Case US_HT_NGUOI_SU_DUNG.LogonResult.OK_Login_Succeeded
                v_loginSucceeded = True
            Case Else 'should never happen, stop if get there
                Debug.Assert(False)
        End Select
        If v_loginSucceeded Then
            Return True
        Else
            Return False
        End If
        Return True

    End Function


    Private Sub setInitialFormLoad()
    End Sub
#End Region
    '
    '    EVENTS HANDER
    '
    Private Sub f101_Dang_Nhap_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Try
            setInitialFormLoad()
            ' Dim v_settingReader As New System.Configuration.AppSettingsReader
            '  Me.m_strMaDonVi = v_settingReader.GetValue("MA_DON_VI", System.Type.GetType("System.String")).ToString()
            '  Me.m_strMaHeThongDangNhap = v_settingReader.GetValue("MA_HE_THONG", System.Type.GetType("System.String")).ToString(
            ' LoadUserGroup() 
            AddHandler m_btnOK.Click, AddressOf m_btnOK_Click
            AddHandler m_btnCancel.Click, AddressOf m_btnCancel_Click
        Catch v_e As System.Exception
            CSystemLog_301.ExceptionHandle(v_e)
        End Try
    End Sub



    Private Sub m_btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '**********************************************************************
        '*  Thoát ra không vào hệ thống nữa
        '********************************************************************
        Try
            Me.DialogResult = DialogResult.Cancel
            Me.Close()

        Catch ex As Exception
            CSystemLog_301.ExceptionHandle(ex)
        End Try

    End Sub


    Private Sub m_btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If (SubmitLogonIsOK()) Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            CSystemLog_301.ExceptionHandle(ex)
        End Try
    End Sub

    Private Sub f101_Dang_Nhap_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    'SendKeys.Send("{tab}")
                    If (SubmitLogonIsOK()) Then
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                Case Keys.Escape
                    Me.m_btnCancel_Click(sender, e)
            End Select
        Catch ex As Exception
            CSystemLog_301.ExceptionHandle(ex)
        End Try
    End Sub




   
End Class