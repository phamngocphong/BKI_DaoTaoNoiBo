option Strict on
option explicit On 

Imports System.Windows.Forms
Imports System.Web.UI



public Enum allowNull
    YES = 0
    NO = 1
End Enum

Public Class CValidateTextBox
    Public Shared Function IsValid(ByVal i_txtCtrl As WebControls.TextBox _
                , ByVal i_DataType As DataType _
                , ByVal i_AllowNull As allowNull _
                ) As Boolean


        Dim v_textbox_is_valid As Boolean
        Dim v_strText As String = i_txtCtrl.Text


        If v_strText = "" Then
            'Kiem tra dieu kien rong
            Select Case i_AllowNull
                Case allowNull.NO
                    'If i_displayDefaultMsg Then
                    '    'BaseMessages.MsgBox_Warning(1)
                    '    op_str_ErrMessage = "Trường dữ liệu yêu cầu phải nhập!"

                    'End If
                    v_textbox_is_valid = False
                Case allowNull.YES
                    v_textbox_is_valid = True
            End Select
        Else  'Trong truong hop khac rong 
            Select Case i_DataType
                Case DataType.NumberType
                    v_textbox_is_valid = CUtil.IsValidNumber(v_strText, False)
                    'If i_displayDefaultMsg And Not v_textbox_is_valid Then
                    '    op_str_ErrMessage = "Trường dữ liệu yêu cầu phải là số!"
                    'End If
                Case DataType.DateType
                    v_textbox_is_valid = CDateTime.isValidDateString(v_strText, CDateTime.GetDateFormatString())
                    'If i_displayDefaultMsg And Not v_textbox_is_valid Then
                    '    op_str_ErrMessage = "Trường dữ liệu yêu cầu phải có dạng ngày tháng!"
                    'End If
                Case DataType.StringType
                    v_textbox_is_valid = True
            End Select
        End If

        'If Not v_textbox_is_valid Then
        '    CErrorTextBoxHandler.markAsErrorTxtBox(i_txtCtrl)
        'End If
        Return v_textbox_is_valid
    End Function



    Public Shared Function IsValid(ByVal i_txtCtrl As TextBox _
                , ByVal i_DataType As DataType _
                , ByVal i_AllowNull As allowNull _
                , Optional ByVal i_displayDefaultMsg As Boolean = True) As Boolean


        Dim v_textbox_is_valid As Boolean
        Dim v_strText As String = i_txtCtrl.Text
        If v_strText = "" Then
            'Kiem tra dieu kien rong
            Select Case i_Allownull
                Case AllowNull.NO
                    If i_displayDefaultMsg Then
                        basemessages.MsgBox_Warning(1)
                    End If
                    v_textbox_is_valid = False
                Case allowNull.YES
                    v_textbox_is_valid = True
            End Select
        Else  'Trong truong hop khac rong 
            Select Case i_DataType
                Case DataType.NumberType
                    v_textbox_is_valid = cutil.isValidNumber(v_strText, False)
                    If i_displayDefaultMsg And Not v_textbox_is_valid Then
                        basemessages.MsgBox_Warning(12)
                    End If
                Case DataType.DateType
                    v_textbox_is_valid = CDateTime.isValidDateString(v_strText, CDateTime.GetDateFormatString())
                    If i_displayDefaultMsg And Not v_textbox_is_valid Then
                        basemessages.MsgBox_Warning(14)
                    End If
                Case DataType.StringType
                    v_textbox_is_valid = True
            End Select
        End If

        If Not v_textbox_is_valid Then
            CErrorTextBoxHandler.markAsErrorTxtBox(i_txtCtrl)
        End If
        Return v_textbox_is_valid
    End Function
End Class


