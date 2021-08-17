Option Compare Database
Option Explicit

Private mBudgetPath As BudgetPath
Private mError As String
Private mNotification As String
Private mDataModels As Collection
Private mConnection As ADODB.Connection
Private mCommand As ADODB.Command
Private mData As ADODB.Recordset
Private mRecord As ADODB.Record

'----------------------------------------------------------------------------------
'   Type        Constructor/Initializer
'   Name        Class_Terminate
'   Parameters  Void
'   Retval      AccessData
'   Purpose
'---------------------------------------------------------------------------------
Private Sub Class_Initialize()
    Set mBudgetPath = New BudgetPath
    Set mData = New ADODB.Recordset
End Sub
 

'----------------------------------------------------------------------------------
'   Type        Destructor
'   Name        Class_Terminate
'   Parameters  Void
'   Retval      AccessData
'   Purpose
'---------------------------------------------------------------------------------
Private Sub Class_Terminate()
    Set mBudgetPath = Nothing
    Set mData = Nothing
End Sub




'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name        Data
'   Parameters  Void
'   Retval      ADODB.Connection
'   Purpose     Function to create and return the current ADO connection
'---------------------------------------------------------------------------------
Public Property Get Data() As ADODB.Connection
    On Error GoTo ErrorHandler:
    Dim cnn As ADODB.Connection
    Set cnn = New ADODB.Connection
    cnn.Open mBudgetPath.Data
    Set Data = cnn
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   AccessData" _
            & vbCrLf & "Member:     " _
            & vbCrLf & "Descript:   " & Err.Description
    End If
    MessageFactory.ShowError (mError)
    Set cnn = Nothing
    Exit Property
End Property


'----------------------------------------------------------------------------------
'   Type        Function
'   Name        References
'   Parameters  Void
'   Retval      ADODB.Connection
'   Purpose     Function to create property getter and return the current ADO connection
'---------------------------------------------------------------------------------
Public Property Get References() As ADODB.Connection
    On Error GoTo ErrorHandler:
    Dim cnn As ADODB.Connection
    Set cnn = New ADODB.Connection
    cnn.Open mBudgetPath.References
    Set References = cnn
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   AccessData" _
            & vbCrLf & "Member:     AccessData" _
            & vbCrLf & "Descript:   " & Err.Description
    End If
    MessageFactory.ShowError (mError)
    Set cnn = Nothing
    Exit Property
End Property



'----------------------------------------------------------------------------------
'   Type        Function
'   Name        Divisions
'   Parameters  Void
'   Retval      ADODB.Connection
'   Purpose     Function to create and return the current ADO connection
'---------------------------------------------------------------------------------
Public Property Get Divisions() As ADODB.Connection
    On Error GoTo ErrorHandler:
    Dim cnn As ADODB.Connection
    Set cnn = New ADODB.Connection
    cnn.Open mBudgetPath.Divisions
    Set Divisions = cnn
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   AccessData" _
            & vbCrLf & "Member:     AccessData" _
            & vbCrLf & "Descript:   " & Err.Description
    End If
    MessageFactory.ShowError (mError)
    Set cnn = Nothing
    Exit Property
End Property



'----------------------------------------------------------------------------------
'   Type        Function
'   Name        ReferenceData
'   Parameters  Void
'   Retval      ADODB.Recordset
'   Purpose     Function to create and return the pTableName
'---------------------------------------------------------------------------------
Public Function GetReferenceModel(pTableName As String) As ADODB.Recordset
    On Error GoTo ErrorHandler:
    If Not pTableName & "" = "" Then
        Dim rst As ADODB.Recordset
        Dim SQL As String
        SQL = "SELECT * FROM pTableName"
        Set rst = New ADODB.Recordset
        rst.Open SQL, References, adOpenStatic, adLockOptimistic
        Set GetReferenceModel = rst
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   AccessData" _
            & vbCrLf & "Member:     GetReferenceModel(String)" _
            & vbCrLf & "Descript: " & Err.Description
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function





'----------------------------------------------------------------------------------
'   Type        Function
'   Name        CreateSqlCommand
'   Parameters  String - sql
'   Purpose     Function to create and return a command
'               based on a sql string argument
'---------------------------------------------------------------------------------
Public Function CreateCommand(pSQL As String) As ADODB.Command
    On Error GoTo ErrorHandler:
    Dim rst As ADODB.Recordset
    Set rst = New ADODB.Recordset
    Dim cmd As ADODB.Command
    Set cmd = New ADODB.Command
    cmd.ActiveConnection = CurrentProject.Connection
    If Not pSQL & "" = "" Then
        cmd.CommandText = pSQL
    End If
    If Not IsNull(cmd) Then
        Set CreateCommand = cmd
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   AccessData" _
            & vbCrLf & "Member:     CreateCommand(String)" _
            & vbCrLf & "Descript: " & Err.Description
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function


'----------------------------------------------------------------------------------
'   Type        Function
'   Name        GetModel
'   Parameters  String - Table
'   Purpose     Function to create and return a recordset
'               based on a pTableName name provided as parameter argument
'---------------------------------------------------------------------------------
Public Function GetModel(pTableName As String) As ADODB.Recordset
    On Error GoTo ErrorHandler:
    Dim rst As ADODB.Recordset
    Set rst = New ADODB.Recordset
    rst.Open (pTableName)
    If rst.RecordCount > 0 Then
        Set GetModel = rst
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       AccessData" _
            & vbCrLf & "Member:     ExcelExport(String)" _
            & vbCrLf & "Descript:   " & Err.Description
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function


'----------------------------------------------------------------------------------
'   Type        Sub-Procedure
'   Name        ImportExcelData
'   Parameters  String
'   Retval      Void
'   Purpose     Function to Import Excel data into MS Access
'---------------------------------------------------------------------------------
Public Sub ImportExcelData(pFilePath As String)
    On Error GoTo ErrorHandler:
    Dim mFilePath As String
    Dim mList() As String
    Dim mCount As Integer
    Dim mWorksheet As Excel.Worksheet
    mFilePath = pFilePath
    Dim mExcel As Excel.Application
    Set mExcel = CreateObject("Excel.Application")
    mExcel.Visible = False
    mExcel.DisplayAlerts = False
    mExcel.Workbooks.Open mFilePath
    If mExcel.Worksheets.count > 1 Then
        Dim i As Integer
        For Each mWorksheet In mExcel.Worksheets
            ReDim Preserve mList(mCount)
            mList(mCount) = mWorksheet.Name
            mCount = mCount + 1
        Next
        For i = LBound(mList()) To UBound(mList())
            DoCmd.TransferSpreadsheet acImport, acSpreadsheetTypeExcel12, mList(i), _
                mFilePath, True, mList(i) & "!A1:IU9999"
        Next i
    Else
        DoCmd.TransferSpreadsheet acImport, acSpreadsheetTypeExcel12, mList(0), _
            mFilePath, True, mList(i) & "!A1:IU9999"
    End If
    mExcel.ActiveWorkbook.Close (True)
    mExcel.Quit
    Set mExcel = Nothing
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:       AccessData" _
            & vbCrLf & "Member:     ImportExcelData(String)" _
            & vbCrLf & "Descript:   " & Err.Description
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub

