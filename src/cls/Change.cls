Option Compare Database
Option Explicit

'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   FIELDS  -------------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------

Private mTableName As String
Private mFieldName As String
Private mAction As String
Private mTimeStamp As String
Private mOldValue As String
Private mNewValue As String
Private mChangeId As Integer

'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   CONSTRUCTORS   ------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------


Private Sub Class_Initialize()
    mTableName = ""
    mFieldName = ""
    mAction = ""
    mOldValue = ""
    mNewValue = ""
    mTimeStamp = Now
    mChangeId = 0
End Sub

Private Sub Class_Terminate()
    mTableName = ""
    mFieldName = ""
    mAction = ""
    mOldValue = ""
    mNewValue = ""
    mTimeStamp = Now
    mChangeId = 0
End Sub

'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------  METHODS      ---------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        ID(Integer)
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ID(cid As Integer)
    If cid > 0 Then
        mChangeId = cid
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        ID()
'   Parameters  Void
'   RetVal      Integer
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ID() As Integer
    If mChangeId > 0 Then
        ID = mChangeId
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        TableName(String)
'   Parameters  Void
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let tableName(table As String)
    If Not table & "" = "" Then
        mTableName = table
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        FieldName()
'   Parameters  Void
'   RetVal      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get tableName() As String
    If Not mTableName & "" = "" Then
        tableName = mTableName
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        FieldName(String)
'   Parameters  String
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let FieldName(field As String)
    If Not field & "" = "" Then
        mFieldName = field
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        FieldName()
'   Parameters  Void
'   RetVal      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FieldName() As String
    If Not mFieldName & "" = "" Then
        FieldName = mFieldName
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        Action(String)
'   Parameters  Void
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Action(act As String)
    If Not act & "" = "" Then
        mAction = act
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        Action()
'   Parameters  Void
'   RetVal      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Action() As String
    If Not mAction & "" = "" Then
        Action = mAction
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        TimeStamp(String)
'   Parameters  String
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let TimeStamp(tm As String)
    If Not tm & "" = "" Then
        mTimeStamp = tm
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        TimeStamp
'   Parameters  Void
'   RetVal      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get TimeStamp() As String
    If Not mTimeStamp & "" = "" Then
        TimeStamp = mTimeStamp
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        OldValue(String)
'   Parameters  Void
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let OldValue(ov As String)
    If Not ov & "" = "" Then
        mOldValue = ov
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        OldValue()
'   Parameters  Void
'   RetVal      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get OldValue() As String
    If Not mOldValue & "" = "" Then
        OldValue = mOldValue
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let NewValue(nv As String)
    If Not nv & "" = "" Then
        mNewValue = nv
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        Void
'   Parameters  Void
'   RetVal      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get NewValue() As String
    If Not mNewValue & "" = "" Then
        NewValue = mNewValue
    End If
End Property

