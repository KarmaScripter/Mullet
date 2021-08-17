Option Compare Database
Option Explicit


Private mBudgetPath As BudgetPath
Private mName As String
Private mExtension As String
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
Private mRecordset As DAO.Recordset
Private mQuery As DAO.QueryDef
Private mConnection As ADODB.Connection
Private mData As ADODB.Recordset
Private mDataCommand As ADODB.Command


'---------------------------------------------------------------------------------
'   Type:            Constructor
'   Name:
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
'   Type:            Destructor
'   Name:
'   Parameters:      Void
'   Retval:          BudgetFile
'   Purpose:
'---------------------------------------------------------------------------------
Public Function WorksheetExists(pSheetName As String, pWorkbook As Workbook) As Boolean
    On Error GoTo ErrorHandler:
    Dim mCheckSheet As Worksheet
    Set mCheckSheet = pWorkbook.Worksheets(pSheetName)
    WorksheetExists = True
    Exit Function
ErrorHandler:
    If Err.Number > 0 Then
        Set mWorkbook = Nothing
        mExcel.Quit
        Set mExcel = Nothing
        mError = "Source:       ExcelBudget" _
            & vbCrLf & "Member:     WorksheetExists(String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    WorksheetExists = False
    Exit Function
End Function




'---------------------------------------------------------------------------------
'   Type:            Destructor
'   Name:
'   Parameters:      Void
'   Retval:          BudgetFile
'   Purpose:
'---------------------------------------------------------------------------------
Public Function WorkbookExists(pWorkbookName As String) As Boolean
    On Error GoTo ErrorHandler:
    Dim mTest As Excel.Workbook
    Set mTest = New Excel.Workbook
    Set mTest = Workbooks(pWorkbookName)
    WorkbookExists = True
    Exit Function
ErrorHandler:
    If Err.Number > 0 Then
        Set mWorkbook = Nothing
        mExcel.Quit
        Set mExcel = Nothing
        mError = "Source:       ExcelBudget" _
            & vbCrLf & "Member:     WorkbookExists(String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    WorkbookExists = False
    Exit Function
End Function




'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            CreateWorkbook
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub CreateWorkbook(pFilePath As String)
    On Error GoTo ErrorHandler:
    Dim mDatabase As DAO.Database
    Dim mRecordset As DAO.Recordset
    Dim f As DAO.field
    Dim i As Integer, j As Integer
    Set mExcel = CreateObject("Excel.Application")
    Set mWorkbook = mExcel.Workbooks.add
    Set mWorksheet = mWorkbook.Worksheets(1)
    mWorkbook.SaveAs filename:=pFilePath, _
        FileFormat:=xlOpenXMLWorkbook
    mWorkbook.Close SaveChanges:=False
ErrorHandler:
    If Err.Number > 0 Then
        Set mWorkbook = Nothing
        mExcel.Quit
        Set mExcel = Nothing
        mError = "Source:       ExcelBudget" _
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
Public Function GetReportTemplate() As Excel.Workbook
    On Error GoTo ErrorHandler:
    Dim mBudgetPath As BudgetPath
    Dim mTemplate As String
    Dim mReport As String
    Set mBudgetPath = New BudgetPath
    mTemplate = mBudgetPath.ReportTemplate
    Set mWorkbook = mExcel.Workbooks.Open(mTemplate)
    Set GetReportTemplate = mWorkbook
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExcelBudget" _
            & vbCrLf & "Member:     GetReportTemplate()" _
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
Private Function GetBudgetTemplate() As Excel.Workbook
    On Error GoTo ErrorHandler:
    Dim mBudgetPath As BudgetPath
    Dim mTemplate As String
    Dim mReport As String
    Set mBudgetPath = New BudgetPath
    mTemplate = mBudgetPath.BudgetTemplate
    Set mWorkbook = mExcel.Workbooks.Open(mTemplate)
    mExcel.Workbooks.add (mWorkbook)
    Set GetReportTemplate = mWorkbook
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExcelBudget" _
            & vbCrLf & "Member:     GetBudgetTemplate()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



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
        mError = "Source:       ExcelBudget" _
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
Public Sub OpenExcelFile(filename As String, FilePath As String)
    On Error GoTo ErrorHandler:
    Dim view As ADODB.Connection
    Dim mRecordset As ADODB.Recordset
    Set view = New ADODB.Connection
    view.Open "Provider=Microsoft.ACE.OLEDB.12.0;" _
        & "Data Source=" & filename & _
        "Extended Properties=""Excel 12.0; HDR=YES"";"
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExcelBudget" _
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
        mError = "Source:       ExcelBudget" _
            & vbCrLf & "Member:     CreateCsvFile(String, String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub



'---------------------------------------------------------------------------------------
' Type:         Function
' Name:         ExportQuery(String)
' Parameters:   Sting
' Retval:       Excel.Application
' Purpose:      Export recordset to Excel
'---------------------------------------------------------------------------------------
Function ExportQuery(ByVal pQuery As String)
    On Error GoTo ErrorHandler:
    Set mDatabase = Application.CurrentDb
    Set mRecordset = mDatabase.OpenRecordset(pQuery)
    Dim mIsOpen As Boolean
    Dim iCols As Integer
    Const xlCenter = -4108
    Set mExcel = CreateObject("Excel.Application")
    mIsOpen = True
    mExcel.ScreenUpdating = False
    mExcel.Visible = False   '
    Set mWorkbook = mExcel.Workbooks.add()
    Set mWorksheet = mWorkbook.Sheets(1)
    With mRecordset
        If .RecordCount <> 0 Then
            For iCols = 0 To mRecordset.Fields.count - 1
                mWorksheet.Cells(1, iCols + 1).Value = mRecordset.Fields(iCols).Name
            Next
            With mWorksheet.Range(mWorksheet.Cells(1, 1), _
                mWorksheet.Cells(1, mRecordset.Fields.count))
                .Font.Bold = True
                .Font.ColorIndex = 2
                .Interior.ColorIndex = 1
                .HorizontalAlignment = xlCenter
            End With
            mWorksheet.Range("A2").CopyFromRecordset mRecordset
            mWorksheet.Range(mWorksheet.Cells(1, 1), _
                mWorksheet.Cells(1, mRecordset.Fields.count)).Columns.AutoFit
            mWorksheet.Range("A1").Select
        End If
    End With
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   ExcelBudget" _
            & vbCrLf & "Member:     ExportQuery(String)" _
            & vbCrLf & "Descript: " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function




'---------------------------------------------------------------------------------------
' Type:         Function
' Name:         ExportData(DAO.Recordset)
' Parameters:   Sting
' Retval:       Excel.Application
' Purpose:      Export recordset to Excel
'---------------------------------------------------------------------------------------
Public Function ExportRecordset(pData As DAO.Recordset)
    On Error GoTo ErrorHandler:
    Set mRecordset = pData
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
        mError = "Source:   ExcelBudget" _
            & vbCrLf & "Member:     ExportData(DAO.Recordset)" _
            & vbCrLf & "Descript: " & Err.Description
        Err.Clear
    End If
    Set pData = Nothing
    MessageFactory.ShowError (mError)
    Exit Function
End Function



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
    mDialog.Title = "Select location to save file."
    mDialog.InitialFileName = "C:\"
    mDialog.Filters.Clear
    If mDialog.Show = -1 Then
       Debug.Print mDialog.SelectedItems(1)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       ExceBudget" _
            & vbCrLf & "Member:     OpenSaveDialog()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub



