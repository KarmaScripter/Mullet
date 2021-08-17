Option Compare Database
Option Explicit



Private mBudgetExecution As DAO.Workspace
Private mDatabase As DAO.Database


Private Sub Class_Initialize()
    Set mDatabase = CurrentDb
    Set mBudgetExecution = DBEngine.Workspaces(0)
End Sub

Private Sub Class_Terminate()
    If Not IsNull(mDatabase) Then
        Set mDatabase = Nothing
    End If
    If Not IsNull(mBudgetExecution) Then
        Set mBudgetExecution = Nothing
    End If
End Sub


'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name        IsConnected
'   Parameters  Void
'   RetVal      Boolean
'   Purpose     Function returns boolean value indicating if Workspace is open
'---------------------------------------------------------------------------------
Public Property Get IsConnected() As Boolean
    If Not IsObject(mDatabase) Then
        IsConnected = True
    End If
    If IsObject(mDatabase) Then
        IsConnected = False
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name        IsOpen
'   Parameters  Void
'   RetVal      Boolean
'   Purpose     Function returns boolean value indicating if Workspace is open
'---------------------------------------------------------------------------------
Public Property Get IsOpen() As Boolean
    If Not IsObject(mBudgetExecution) Then
        IsOpen = True
    End If
    If IsObject(mBudgetExecution) Then
        IsOpen = False
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Function
'   Name        GetDataSet
'   Parameters  String - table;
'   RetVal      DAO.Recordset
'   Purpose     Function returns the records from the Data Table using the table's
'               name or a sql select query
'---------------------------------------------------------------------------------
Public Function GetDataSet(table As String) As DAO.Recordset
    Dim rs As DAO.Recordset
    If Not IsNull(mDatabase) And _
        Not table & "" = "" Then
           Set rs = mDatabase.OpenRecordset(table, dbOpenDynaset)
    End If
    Set GetDataSet = rs
End Function


'----------------------------------------------------------------------------------
'   Type        Function
'   Name        GetRecord
'   Parameters  String - table;
'   RetVal      DAO.Recordset
'   Purpose     Function returns record using ID parameter and Primary Key
'               defined in a sql select query
'---------------------------------------------------------------------------------
Public Function GetDataRecord(table As String, primarykey As String, ID As Integer) As DAO.Recordset
    Dim DB As DAO.Database
    Set DB = mDatabase
    Dim rs As DAO.Recordset
    Dim SQL As String
    If Not IsNull(mDatabase) And _
        Not table & "" = "" And _
        Not primarykey & "" = "" And _
        ID > 0 Then
            SQL = "SELECT * FROM table WHERE key = 'id'"
            Set rs = mDatabase.OpenRecordset(SQL, dbOpenDynaset)
            Set GetDataRecord = rs
    End If
End Function


'----------------------------------------------------------------------------------
'   Type        Subprocedure
'   Name        CloseDatabase
'   Parameters  Void
'   RetVal      Void
'   Purpose     Method used to close the database
'---------------------------------------------------------------------------------
Public Sub CloseDatabase()
    If Not IsNull(mDatabase) Then
        Set mDatabase = Nothing
    End If
End Sub


'----------------------------------------------------------------------------------
'   Type        Subprocedure
'   Name        CloseWorkspace
'   Parameters  Void
'   RetVal      Void
'   Purpose     Method used to close the database
'---------------------------------------------------------------------------------
Public Sub CloseWorkspace()
    If Not IsNull(mBudgetExecution) Then
        Set mBudgetExecution = Nothing
    End If
End Sub


'----------------------------------------------------------------------------------
'   Type        Subprocedure
'   Name        UpdateDate
'   Parameters  table - String, field - String, value - Variant
'   RetVal      Void
'   Purpose     Method used to update data in current recordset
'---------------------------------------------------------------------------------
Public Sub UpdateData(table As String, field As String, Value As Variant)
    Dim DB As DAO.Database
    Set DB = mDatabase
    Dim rs As DAO.Recordset
    If Not table & "" = "" Then
        Set rs = GetDataSet(table)
    End If
    If Not field & "" = "" _
        And Not IsNull(Value) Then
            rs.Edit
            rs.Fields(field) = Value
            rs.Update
    End If
End Sub

'----------------------------------------------------------------------------------
'   Type        Subprocedure
'   Name        AddRecord
'   Parameters  table - String, field - String, value - Variant
'   RetVal      Void
'   Purpose     Method used to add data to recordset
'---------------------------------------------------------------------------------
Public Sub AddRecord(table As String, field As String, Value As Variant)
    Dim DB As DAO.Database
    Dim rs As DAO.Recordset
    Set DB = mDatabase
    Set rs = GetDataSet(table)
    With rs
      .AddNew
      !Fields(field) = Value
      .Update
    End With
End Sub

'----------------------------------------------------------------------------------
'   Type        Subprocedure
'   Name        UpdateRecord
'   Parameters  table - String, field - String, value - Variant
'   RetVal      Void
'   Purpose     Method used to add data to recordset
'---------------------------------------------------------------------------------
Public Sub UpdateRecord(table As String, field As String, NewValue As Variant, ID As Integer)
    Dim DB As DAO.Database
    Dim rs As DAO.Recordset
    Set DB = mDatabase
    Set rs = GetDataRecord(table, field, ID)
    If Not IsNull(rs) Then
        With rs
          .AddNew
          !Fields(field) = NewValue
          .Update
        End With
    End If
End Sub


'----------------------------------------------------------------------------------
'   Type        Subprocedure
'   Name        DeleteRecord
'   Parameters  table - String, pk - String, id - integer
'   RetVal      Void
'   Purpose     Method used to delete records from the data set
'---------------------------------------------------------------------------------
Public Sub DeleteRecord(table As String, pk As String, ID As Integer)
    Dim DB As DAO.Database
    Dim rs As DAO.Recordset
    Set DB = mDatabase
    Dim SQL As String
    SQL = "DELETE FROM table WHERE pk = id"
    Set rs = DB.OpenRecordset(SQL)
End Sub

