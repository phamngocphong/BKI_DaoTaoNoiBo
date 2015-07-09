Option Explicit On 
Option Strict On

Imports System.IO
Imports Excel
Imports System.Web.UI.WebControls


Public Class CExcelReport
    Private Const c_ReportTemplatesDir As String = "Reports\Templates\"
    Private Const c_ReportOutputDir As String = "Reports\Output\"

    Protected m_strOutputPath As String = ""
    Protected m_strTemplatesPath As String = ""

    Private m_strTemplateFileNameWithPath As String
    Private m_iSheetStartRow As Integer
    Private m_iSheetStartCol As Integer

    Private m_objExcelApp As Excel.Application
    Private m_objExcelWorksheet As Excel.Worksheet
    Private m_init_successful As Boolean
    Private m_b_haved_show As Boolean
    Private m_b_set_style As Boolean = True

    Public FindAndReplaceCollection As Hashtable

    Public Sub New(ByVal i_strTemplateFileWithoutPath As String _
                            , ByVal i_iSheetStartRow As Integer _
                            , ByVal i_iSheetStartCol As Integer)
        InitPaths()
        m_strTemplateFileNameWithPath = m_strTemplatesPath & i_strTemplateFileWithoutPath
        m_iSheetStartCol = i_iSheetStartCol
        m_iSheetStartRow = i_iSheetStartRow
        m_objExcelApp = New Excel.Application
        FindAndReplaceCollection = New Hashtable
        m_init_successful = False
        m_b_haved_show = False
        init_excel()
    End Sub
    Public Sub New(ByVal i_str_TemplateFilePath As String)
        InitPaths()
        m_strTemplateFileNameWithPath = i_str_TemplateFilePath
        m_init_successful = False
        m_b_haved_show = False
        m_init_successful = True
    End Sub
    Public Sub SetVisibleStyle4Node()
        m_b_set_style = True
    End Sub

    Public Sub SetInvisibleStyle4Node()
        m_b_set_style = False

    End Sub
    Public Function GetOutputFileNameWithPath() As String
        Dim v_strRandomName As String
        Randomize()
        v_strRandomName = m_strOutputPath & "~" & CType(Rnd() * 1000000000000, Int64) & ".xls"
        Return v_strRandomName
    End Function

    '' LinhDH thêm vào để export khi dùng Web
    ''' <summary>
    ''' Dùng để export excel dùng template khi lập trình Web
    ''' </summary>
    ''' <param name="i_fg"></param>
    ''' <param name="i_iFromGridCol"></param>
    ''' <param name="i_iToGridCol"></param>
    ''' <param name="i_b_show"></param>
    ''' <remarks></remarks>
    'Public Sub Export2Excel(ByVal i_fg As GridView _
    '                        , ByVal i_iFromGridCol As Integer _
    '                        , ByVal i_iToGridCol As Integer, Optional ByVal i_b_show As Boolean = True)
    '    Try
    '        If Not m_init_successful Then Exit Sub
    '        Dim v_objFact As New CExportColumnFactory(i_fg, m_objExcelWorksheet)
    '        Dim v_objExpCol As IExportColumn
    '        Dim v_iGridCol As Integer
    '        Dim v_iNumberOfCol As Integer = 0
    '        Dim v_iVisibleColsCount As Integer = 0
    '        Dim v_iCount As Integer = 0
    '        ' Chen 1 so dong trong Excel tuong ung voi so Ban ghi can insert
    '        Dim v_obj_range As Range = m_objExcelWorksheet.Range( _
    '        m_objExcelWorksheet.Cells(m_iSheetStartRow + 2, m_iSheetStartCol) _
    '        , m_objExcelWorksheet.Cells(m_iSheetStartRow + 2, m_iSheetStartCol))
    '        For v_iCount = i_fg.Rows.Fixed To i_fg.Rows.Count - 1
    '            v_obj_range.EntireRow.Insert(Excel.XlDirection.xlUp)
    '        Next
    '        For v_iGridCol = i_iFromGridCol To i_iToGridCol
    '            If i_fg.Cols(v_iGridCol).Visible Then
    '                v_objExpCol = v_objFact.CreateExportColumn(v_iGridCol _
    '                                        , m_iSheetStartCol + v_iNumberOfCol _
    '                                        , m_iSheetStartRow)
    '                v_iNumberOfCol += 1
    '                v_objExpCol.Export()
    '                v_iVisibleColsCount += 1
    '            End If
    '        Next
    '        If (m_b_set_style) Then
    '            setStyle4Node(i_fg, v_iVisibleColsCount)
    '        End If
    '        m_iSheetStartRow = m_iSheetStartRow + i_fg.Rows.Count

    '        If i_b_show Then
    '            m_objExcelApp.Visible = True
    '            Unmount()
    '        End If

    '    Catch v_e As Exception
    '        m_objExcelApp.Workbooks.Close()
    '        m_objExcelApp.Quit()
    '        Unmount()
    '        Throw v_e
    '    End Try
    'End Sub

    Public Sub ChangeSheetExported(ByVal i_sheet_index As Integer)
        m_objExcelApp.Workbooks(1).Worksheets.Select(i_sheet_index)
        m_objExcelWorksheet = CType(m_objExcelApp.Workbooks(1).Worksheets(i_sheet_index), Excel.Worksheet)
    End Sub

    ''' <summary>
    ''' Dùng trong ASP.NET
    ''' </summary>
    ''' <param name="i_fg"></param>
    ''' <param name="i_iFromGridCol"></param>
    ''' <param name="i_iToGridCol"></param>
    ''' <param name="i_b_show"></param>
    ''' <remarks></remarks>
    Public Sub Export2ExcelWithoutFixedRows(ByVal i_fgv As GridView _
                                , ByVal i_iFromGridCol As Integer _
                                , ByVal i_iToGridCol As Integer _
                                , ByVal i_b_show As Boolean)
        Try
            If Not m_init_successful Then Exit Sub
            ''PrepareGrid(i_fgv)
            Dim v_objFact As New CExportColumnFactory(i_fgv, m_objExcelWorksheet)
            Dim v_objExpCol As IExportColumn
            Dim v_iGridCol As Integer
            Dim v_iNumberOfCol As Integer = 0
            Dim v_iVisibleColsCount As Integer = 0
            Dim v_iCount As Integer = 0
            ' Chen 1 so dong trong Excel tuong ung voi so Ban ghi can insert
            Dim v_obj_range As Range = m_objExcelWorksheet.Range( _
            m_objExcelWorksheet.Cells(m_iSheetStartRow + 1, m_iSheetStartCol) _
            , m_objExcelWorksheet.Cells(m_iSheetStartRow + 1, m_iSheetStartCol))
            For v_iCount = 0 To i_fgv.Rows.Count - 1
                v_obj_range.EntireRow.Insert(Excel.XlDirection.xlUp)
            Next
            For v_iGridCol = i_iFromGridCol To i_iToGridCol
                If i_fgv.Columns(v_iGridCol).Visible Then
                    v_objExpCol = v_objFact.CreateExportColumnAsp(v_iGridCol _
                                            , m_iSheetStartCol + v_iNumberOfCol _
                                            , m_iSheetStartRow)
                    v_iNumberOfCol += 1
                    v_objExpCol.ExportWithoutFixedRowsAsp()
                    v_iVisibleColsCount += 1

                End If
            Next
            'If (m_b_set_style) Then
            '    setStyle4Node(i_fg, v_iVisibleColsCount)
            'End If
            m_iSheetStartRow = m_iSheetStartRow + i_fgv.Rows.Count
            If i_b_show Then
                m_objExcelApp.Visible = True
                Unmount()
            End If
        Catch v_e As Exception
            m_objExcelApp.Workbooks.Close()
            m_objExcelApp.Quit()
            Unmount()
            Throw v_e
        End Try

    End Sub
    'Export dữ liệu từ Excel ra DS
    'Cột đầu tiên (ID) CỦA DS sẽ luôn được set = 1
    'Cột đầu tiên CỦA FILE EXCEL có Index = 1
    Public Sub Export2DatasetDS_by_DucVT(ByVal i_DataSet As System.Data.DataSet _
                               , ByVal i_TableName As String _
                              , ByVal i_iSheetStartRow As Integer)
        Try
            'Initialize
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
            m_objExcelApp = New Excel.Application

            'Mở file excel từ filename
            m_objExcelApp.Workbooks.Open(m_strTemplateFileNameWithPath)

            'Mở và lấy worksheet thứ 1
            m_objExcelApp.Workbooks(1).Worksheets.Select(1)
            m_objExcelWorksheet = CType(m_objExcelApp.Workbooks(1).Worksheets(1), Excel.Worksheet)

            'Init
            Dim i_iExcelRow As Integer = 0 'index excel row
            Dim v_bol_stop As Boolean = False 'điều kiện dừng vòng lặp


            While Not v_bol_stop
                'Init
                Dim i_iExcelCol As Integer = 0 'index excel col
                Dim v_iDataRow As System.Data.DataRow 'DataRow

                'Tạo DataRow mới từ DataTable trong DS truyền vào
                v_iDataRow = i_DataSet.Tables(i_DataSet.Tables(i_TableName).TableName).NewRow()
                v_iDataRow(i_iExcelCol) = i_iExcelRow + 1 'Set cột đầu tiên của DS với giá trị tăng dần (Số thứ tự)

                'Kiểm tra cell đầu tiên của row hiện tại có dữ liệu hay không (cột STT), không có thì kết thúc duyệt file excel
                'Vì cột đầu tiên của Excel bằng 1, nên ở đây ta đặt index_col = 1 chứ không phải bằng 0
                If Not Object.ReferenceEquals(CType(m_objExcelWorksheet.Cells(i_iExcelRow + i_iSheetStartRow, 1), Excel.Range).Value(), Nothing) Then

                    ' Khi cột đầu tiên có dữ liệu.
                    ' Lặp với số lượng trường trong DS, duyệt đúng số lượng đó để convert dữ liệu trên excel sang cột DS tương ứng (trừ trường đầu tiên trong DS, vì nó mặc định là DS)
                    ' Ở đây không trừ 1 nữa, vì ví dụ: Có 52 cột, cột 1 Excel ứng với dòng 1 của DS (dòng 1 nhưng có Index = 0)
                    For i_iExcelCol = 2 To i_DataSet.Tables(i_TableName).Columns.Count
                        If Not CType(m_objExcelWorksheet.Cells(i_iExcelRow + i_iSheetStartRow, i_iExcelCol), Excel.Range).Value() Is Nothing Then
                            v_iDataRow(i_iExcelCol - 1) = CType(m_objExcelWorksheet.Cells(i_iExcelRow + i_iSheetStartRow, i_iExcelCol), Excel.Range).Value()
                        End If
                    Next

                Else
                    v_bol_stop = True
                End If


                If Not v_bol_stop Then
                    i_DataSet.Tables(i_TableName).Rows.InsertAt(v_iDataRow, i_iExcelRow)
                    i_iExcelRow += 1
                End If
            End While
            m_objExcelApp.DisplayAlerts = False
            m_objExcelApp.Workbooks.Close()
            m_objExcelApp.DisplayAlerts = True
            m_objExcelApp.Quit()
            Unmount()
        Catch v_e As Exception
            m_objExcelApp.DisplayAlerts = False
            m_objExcelApp.Workbooks.Close()
            m_objExcelApp.DisplayAlerts = True
            m_objExcelApp.Quit()
            Unmount()
            Throw v_e
        End Try
    End Sub
    Public Sub ExportDataSet2ExcelWithoutFixedRows(ByVal i_fgv As GridView _
                                , ByVal i_iFromGridCol As Integer _
                                , ByVal i_iToGridCol As Integer _
                                , ByVal i_b_show As Boolean)
        Try
            If Not m_init_successful Then Exit Sub
            Dim v_objFact As New CExportColumnFactory(i_fgv, m_objExcelWorksheet)
            Dim v_objExpCol As IExportColumn
            Dim v_iGridCol As Integer
            Dim v_iNumberOfCol As Integer = 0
            Dim v_iVisibleColsCount As Integer = 0
            Dim v_iCount As Integer = 0

            ' Chen 1 so dong trong Excel tuong ung voi so Ban ghi can insert
            Dim v_obj_range As Range = m_objExcelWorksheet.Range( _
            m_objExcelWorksheet.Cells(m_iSheetStartRow + 1, m_iSheetStartCol) _
            , m_objExcelWorksheet.Cells(m_iSheetStartRow + 1, m_iSheetStartCol))
            For v_iCount = 0 To i_fgv.Rows.Count - 1
                v_obj_range.EntireRow.Insert(Excel.XlDirection.xlUp)
            Next
            For v_iGridCol = i_iFromGridCol To i_iToGridCol
                If i_fgv.Columns(v_iGridCol).Visible Then
                    v_objExpCol = v_objFact.CreateExportColumnAsp(v_iGridCol _
                                            , m_iSheetStartCol + v_iNumberOfCol _
                                            , m_iSheetStartRow)
                    v_iNumberOfCol += 1
                    v_objExpCol.ExportWithoutFixedRowsAsp()
                    v_iVisibleColsCount += 1

                End If
            Next
            'If (m_b_set_style) Then
            '    setStyle4Node(i_fg, v_iVisibleColsCount)
            'End If
            m_iSheetStartRow = m_iSheetStartRow + i_fgv.Rows.Count
            If i_b_show Then
                m_objExcelApp.Visible = True
                Unmount()
            End If
        Catch v_e As Exception
            m_objExcelApp.Workbooks.Close()
            m_objExcelApp.Quit()
            Unmount()
            Throw v_e
        End Try

    End Sub
    Public Sub GotoExportPosition(ByVal i_iSheetStartRow As Integer _
                            , ByVal i_iSheetCol As Integer)
        m_iSheetStartRow = i_iSheetStartRow
        m_iSheetStartCol = i_iSheetCol
    End Sub
    Public Sub AddFindAndReplaceItem(ByVal i_obj_find As Object _
                                , ByVal i_obj_replace As Object)
        Me.FindAndReplaceCollection.Add(i_obj_find, i_obj_replace)
    End Sub



    Public Sub FindAndReplace(ByVal i_b_show As Boolean)
        Try
            If Not m_init_successful Then Exit Sub
            Dim v_str_replace As String
            For Each v_str_find As String In Me.FindAndReplaceCollection.Keys
                v_str_replace = Me.FindAndReplaceCollection.Item(v_str_find).ToString()
                m_objExcelWorksheet.Cells.Replace(What:=v_str_find, Replacement:=v_str_replace)
                If Not m_b_haved_show Then
                    m_objExcelApp.Visible = True
                    m_b_haved_show = True
                End If
            Next
            If i_b_show Then
                m_objExcelApp.Visible = True
                Unmount()
            End If
        Catch v_e As Exception
            m_objExcelApp.Workbooks.Close()
            m_objExcelApp.Quit()
            Unmount()
            Throw v_e
        End Try
    End Sub

    Private Sub init_excel()
        Dim v_strFileName As String
        v_strFileName = GetOutputFileNameWithPath()
        If Not CopyFileSuccess(v_strFileName) Then Exit Sub
        m_objExcelApp.Workbooks.Open(v_strFileName)
        m_objExcelApp.Workbooks(1).Worksheets.Select(1)
        m_objExcelWorksheet = CType(m_objExcelApp.Workbooks(1).Worksheets(1), Excel.Worksheet)
        m_init_successful = True

    End Sub


    'Tra ve xem co copy thanh cong hay khong
    Private Function CopyFileSuccess(ByVal i_strFileDest As String) As Boolean
        Try
            Dim v_objFileInfo As New FileInfo(m_strTemplateFileNameWithPath)
            Debug.Assert(v_objFileInfo.Exists(), "Khong co file template nay - tuanqt")
            v_objFileInfo.CopyTo(i_strFileDest)
            Return True
        Catch v_e As Exception
            Return False
        End Try
    End Function

    Private Sub InitPaths()
        m_strOutputPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase & c_ReportOutputDir
        m_strTemplatesPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase & c_ReportTemplatesDir
    End Sub

    Private Sub Unmount()

        m_objExcelWorksheet = Nothing
        m_objExcelApp = Nothing
        GC.Collect()

    End Sub
End Class
