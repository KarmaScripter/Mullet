Option Compare Database
Option Explicit


Private mBudgetPath As BudgetPath
Private mSavePath As String
Private mName As String
Private mExtension As String
Private mLocation As String
Private mFileSys As Scripting.FileSystemObject
Private mExcel As Excel.Application
Private mWorkbook As Excel.Workbook
Private mWorksheet As Excel.Worksheet
Private mChart As Excel.Chart
Private mPivotTable As Excel.PivotTable
Private mPivotFields As Excel.PivotFields
Private mPivotItems As Excel.PivotItems
Private mError As String
Private mNotification As String
Private mDatabase As DAO.Database
Private mData As DAO.Recordset


'---------------------------------------------------------------------------------
'   Type:            Constructor
'   Name:            ExcelReport
'   Parameters:      Void
'   Retval:          BudgetFile
'   Purpose:
'---------------------------------------------------------------------------------
Private Sub Class_Initialize()
    Set mExcel = New Excel.Application
End Sub



'---------------------------------------------------------------------------------
'   Type:            Destructor
'   Name:
'   Parameters:      Void
'   Retval:          BudgetFile
'   Purpose:
'---------------------------------------------------------------------------------
Private Sub Class_Terminate()
    Set mExcel = Nothing
End Sub




'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            CreateWorkbook
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub CreateWorkbook(pFilePath As String)
    On Error GoTo ErrorHandler:
    If Not pFilePath & "" = "" Then
        Dim mDatabase As DAO.Database
        Dim rec As DAO.Recordset
        Dim f As DAO.field
        Dim i As Integer, j As Integer
        Set mWorkbook = mExcel.Workbooks.add
        Set mWorksheet = mWorkbook.Worksheets(1)
        mWorkbook.SaveAs filename:=pFilePath, _
            FileFormat:=xlOpenXMLWorkbook
        mWorkbook.Close SaveChanges:=False
    End If
ErrorHandler:
    If Err.Number > 0 Then
        Set mWorkbook = Nothing
        mExcel.Quit
        Set mExcel = Nothing
        mError = "Source:       ExceReport" _
            & vbCrLf & "Member:     CreateWorkbook(String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub



'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            RecursiveDelete
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetTemplate() As Excel.Workbook
    On Error GoTo ErrorHandler:
    Dim mBudgetPath As BudgetPath
    Dim mTemplate As String
    Set mBudgetPath = New BudgetPath
    mTemplate = mBudgetPath.ReportTemplate
    Dim mReport As Excel.Workbook
    Set mReport = mExcel.Workbooks.Open(mTemplate)
    Set GetTemplate = mWorkbook
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExceReport" _
            & vbCrLf & "Member:     GetTemplate()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            RecursiveDelete
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetRange(mColumn As Integer, mRow As Integer) As Excel.Range
    On Error GoTo ErrorHandler:
    Dim mBudgetPath As BudgetPath
    Dim mReport As Excel.Workbook
    Dim mRange As Excel.Range
    Dim mTemplate As String
    Set mBudgetPath = New BudgetPath
    mTemplate = mBudgetPath.ReportTemplate
    Set mReport = mExcel.Workbooks.Open(mTemplate)
    Set mRange = mReport.Worksheets(1).Cells(mColumn, mRow)
    Set GetRange = mRange
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExceReport" _
            & vbCrLf & "Member:     GetTemplate()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            RecursiveDelete
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub PopulateData(mData As DAO.Recordset)
    On Error GoTo ErrorHandler:
    Dim mBudgetPath As BudgetPath
    Dim mReport As Excel.Workbook
    Dim mTemplate As String
    Dim mRange As Excel.Range
    Set mBudgetPath = New BudgetPath
    mTemplate = mBudgetPath.ReportTemplate
    Set mReport = mExcel.Workbooks.Open(mTemplate)
    mReport.Worksheets(2).Visible = False
    Set mRange = mReport.Worksheets(1).Cells(1, 2)
    mRange.CopyFromRecordset Data:=mData, MaxRows:=10, MaxColumns:=8
    mExcel.Visible = True
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExceReport" _
            & vbCrLf & "Member:     GetTemplate()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub



'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub OpenFileDialog()
    On Error GoTo ErrorHandler:
    Dim mDialog As FileDialog
    Dim result As Integer
    Set mDialog = Application.FileDialog(msoFileDialogFilePicker)
    mDialog.AllowMultiSelect = False
    mDialog.Title = "Select an Excel file"
    mDialog.InitialFileName = "C:\"
    mDialog.Filters.Clear
    mDialog.Filters.add "Excel files", "*.xlsx"
    mDialog.Filters.add "All files", "*.*"
    If mDialog.Show = -1 Then
       Debug.Print mDialog.SelectedItems(1)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExceReport" _
            & vbCrLf & "Member:     OpenFileDialog()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub



'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub OpenFolderDialog()
    On Error GoTo ErrorHandler:
    Dim mDialog As FileDialog
    Dim result As Integer
    Set mDialog = Application.FileDialog(msoFileDialogFolderPicker)
    mDialog.AllowMultiSelect = False
    mDialog.Title = "Select an Folder"
    mDialog.InitialFileName = "C:\"
    mDialog.Filters.Clear
    If mDialog.Show = -1 Then
       Debug.Print mDialog.SelectedItems(1)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExceReport" _
            & vbCrLf & "Member:     OpenFolderDialog()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub




'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub OpenSaveDialog()
    On Error GoTo ErrorHandler:
    Dim mDialog As FileDialog
    Dim result As Integer
    Set mDialog = Application.FileDialog(msoFileDialogSaveAs)
    mDialog.AllowMultiSelect = False
    mDialog.Title = "Select ocation to save file."
    mDialog.InitialFileName = "C:\"
    mDialog.Filters.Clear
    If mDialog.Show = -1 Then
       Debug.Print mDialog.SelectedItems(1)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExceReport" _
            & vbCrLf & "Member:     OpenFileDialog()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub



'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            RecursiveDelete
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub OpenExcelFile(pFileName As String, pFilePath As String)
    On Error GoTo ErrorHandler:
    Dim view As ADODB.Connection
    Dim rec As ADODB.Recordset
    Set view = New ADODB.Connection
    view.Open "Provider=Microsoft.ACE.OLEDB.12.0;" _
        & "Data Source=" & pFileName & _
        "Extended Properties=""Excel 12.0; HDR=YES"";"
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExceReport" _
            & vbCrLf & "Member:     OpenExcelFile(String, String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub




'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            CreateCsvFile
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub CreateCsvFile(pFileName As String, pFilePath As String)
    On Error GoTo ErrorHandler:
    If Not pFileName & "" = "" And _
        Not pFilePath & "" = "" Then
            Dim mFilePath As String
            Dim mCsvName As String
            Dim mSheet As Worksheet
            Set mSheet = ActiveWorkbook.Sheets("Sheet1")
            mCsvName = pFileName & ".csv"
            mFilePath = Application.CurrentProject.mBudgetPath
            mSheet.Copy
            ActiveWorkbook.SaveAs filename:=mFilePath & "\" & mCsvName, _
                FileFormat:=xlCSV, CreateBackup:=False
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExceReport" _
            & vbCrLf & "Member:     CreateCsvFile(String, String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub



'---------------------------------------------------------------------------------------
' Type:         Function
' Name:         ExcelExport(String)
' Parameters:   Sting
' Retval:       Excel.Application
' Purpose:      Export recordset to Excel
'---------------------------------------------------------------------------------------
Function ExportQuery(ByVal pQuery As String)
    On Error GoTo ErrorHandler:
    Set mDatabase = Application.CurrentDb
    Set mData = mDatabase.OpenRecordset(pQuery)
    Dim mIsOpen As Boolean
    Dim iCols As Integer
    Const xlCenter = -4108
    Set mExcel = CreateObject("Excel.Application")
    mIsOpen = True
    mExcel.ScreenUpdating = False
    mExcel.Visible = False   '
    Set mWorkbook = mExcel.Workbooks.add()
    Set mWorksheet = mWorkbook.Sheets(1)
    With mData
        If .RecordCount <> 0 Then
            For iCols = 0 To mData.Fields.count - 1
                mWorksheet.Cells(1, iCols + 1).Value = mData.Fields(iCols).Name
            Next
            With mWorksheet.Range(mWorksheet.Cells(1, 1), _
                mWorksheet.Cells(1, mData.Fields.count))
                .Font.Bold = True
                .Font.ColorIndex = 2
                .Interior.ColorIndex = 1
                .HorizontalAlignment = xlCenter
            End With
            mWorksheet.Range("A2").CopyFromRecordset mData
            mWorksheet.Range(mWorksheet.Cells(1, 1), _
                mWorksheet.Cells(1, mData.Fields.count)).Columns.AutoFit
            mWorksheet.Range("A1").Select
        End If
    End With
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   ExceReport" _
            & vbCrLf & "Member:     ExcelExport(String)" _
            & vbCrLf & "Descript: " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------------
' Type:         Function
' Name:         ExcelExport(String)
' Parameters:   Sting
' Retval:       Excel.Application
' Purpose:      Export recordset to Excel
'---------------------------------------------------------------------------------------
Public Function ExportData(pData As DAO.Recordset)
    On Error GoTo ErrorHandler:
    Set mData = pData
    Dim mIsOpen As Boolean
    Dim iCols As Integer
    Const xlCenter = -4108
    Set mExcel = CreateObject("Excel.Application")
    mIsOpen = True
    mExcel.ScreenUpdating = False
    mExcel.Visible = False   '
    Set mWorkbook = mExcel.Workbooks.add()
    Set mWorksheet = mWorkbook.Sheets(1)
    With pData
        If .RecordCount <> 0 Then
            For iCols = 0 To pData.Fields.count - 1
                mWorksheet.Cells(1, iCols + 1).Value = pData.Fields(iCols).Name
            Next
            With mWorksheet.Range(mWorksheet.Cells(1, 1), _
                mWorksheet.Cells(1, pData.Fields.count))
                .Font.Bold = True
                .Font.ColorIndex = 2
                .Interior.ColorIndex = 1
                .HorizontalAlignment = xlCenter
            End With
            mWorksheet.Range("A2").CopyFromRecordset pData
            mWorksheet.Range(mWorksheet.Cells(1, 1), _
                mWorksheet.Cells(1, pData.Fields.count)).Columns.AutoFit
            mWorksheet.Range("A1").Select
        End If
    End With
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   ExceReport" _
            & vbCrLf & "Member:     ExcelExport(String)" _
            & vbCrLf & "Descript: " & Err.Description
        Err.Clear
    End If
    Set pData = Nothing
    MessageFactory.ShowError (mError)
    Exit Function
End Function






'---------------------------------------------------------------------------------------
' Type:         Sub Procedure
' Name:
' Parameters:   Sting
' Retval:       Void
' Purpose:
'---------------------------------------------------------------------------------------
Public Sub SetLeftHeader(pText As String)
    On Error GoTo ErrorHandler:
    Dim mText As String
    mText = pText
    ActiveSheet.PageSetup.LeftHeader = mText
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   ExceReport" _
            & vbCrLf & "Member:     SetLeftHeader(String)" _
            & vbCrLf & "Descript: " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub




'---------------------------------------------------------------------------------------
' Type:         Sub Procedure
' Name:
' Parameters:   Sting
' Retval:       Void
' Purpose:
'---------------------------------------------------------------------------------------
Public Sub SetCenterHeader(pText As String)
    On Error GoTo ErrorHandler:
    Dim mText As String
    mText = pText
    ActiveSheet.PageSetup.CenterHeader = mText
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   ExceReport" _
            & vbCrLf & "Member:     SetCenterHeader(String)" _
            & vbCrLf & "Descript: " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub




'---------------------------------------------------------------------------------------
' Type:         Sub Procedure
' Name:
' Parameters:   Sting
' Retval:       Void
' Purpose:
'---------------------------------------------------------------------------------------
Public Sub SetRightHeader(pText As String)
    On Error GoTo ErrorHandler:
    Dim mText As String
    mText = pText
   ActiveSheet.PageSetup.RightFooter = mText
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   ExceReport" _
            & vbCrLf & "Member:     SetRightHeader(String)" _
            & vbCrLf & "Descript: " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub




'---------------------------------------------------------------------------------------
' Type:         Sub Procedure
' Name:
' Parameters:   Sting
' Retval:       Void
' Purpose:
'---------------------------------------------------------------------------------------
Public Sub SetLeftFooter(pText As String)
    On Error GoTo ErrorHandler:
    Dim mText As String
    mText = pText
    ActiveSheet.PageSetup.LeftFooter = mText
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   ExceReport" _
            & vbCrLf & "Member:     SetLeftFooter(String)" _
            & vbCrLf & "Descript: " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub




'---------------------------------------------------------------------------------------
' Type:         Sub Procedure
' Name:
' Parameters:   Sting
' Retval:       Void
' Purpose:
'---------------------------------------------------------------------------------------
Public Sub SetCenterFooter(pText As String)
    On Error GoTo ErrorHandler:
    Dim mText As String
    mText = pText
    ActiveSheet.PageSetup.CenterFooter = mText
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   ExceReport" _
            & vbCrLf & "Member:     SetCenterFooterString)" _
            & vbCrLf & "Descript: " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub


