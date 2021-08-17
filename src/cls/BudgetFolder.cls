Option Compare Database
Option Explicit

'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   FIELDS   ------------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------

Private mLocation As String
Private mPath As String
Private mName As String
Private mExtension As String
Private mParentFolder As String
Private mFileSys As Scripting.FileSystemObject
Private mFolder As Scripting.folder
Private mFile As Scripting.File
Private mFiles As Scripting.Files
Private mSubFolders As Scripting.folders
Private mDrive As String
Private mType As String
Private mDateCreated As Date
Private mLastAccessed As Date
Private mLastModified As Date
Private mStream As Scripting.TextStream
Private mError As String
Private mNotification As String



'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   METHODS  ------------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------



'---------------------------------------------------------------------------------
'   Type:            Constructor
'   Name:
'   Parameters:      Void
'   Retval:          BudgetFile
'   Purpose:
'---------------------------------------------------------------------------------
Private Sub Class_Initialize()
End Sub



'---------------------------------------------------------------------------------
'   Type:            Destructor
'   Name:
'   Parameters:      Void
'   Retval:          BudgetFile
'   Purpose:
'---------------------------------------------------------------------------------
Private Sub Class_Terminate()
End Sub



'---------------------------------------------------------------------------------
'   Type:            Property Let
'   Name:
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let Location(fp As String)
    If Not fp & "" = "" Then
        mLocation = fp
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:            Property Let
'   Name:
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get Location() As String
    If Not mLocation & "" = "" Then
        Location = mLocation
    End If
End Property




'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:            Exists
'   Parameters:      String
'   Retval:          Boolean
'   Purpose:
'---------------------------------------------------------------------------------
Public Function Exists() As Boolean
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        If mFileSys.FolderExists(mLocation) = True Then
            Exists = True
        Else
            Exists = False
        End If
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     Exists()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:            Exists
'   Parameters:      String
'   Retval:          Boolean
'   Purpose:
'---------------------------------------------------------------------------------
Public Function IsRooted() As Boolean
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        If mFileSys.GetFolder(mLocation).IsRootFolder = True Then
            IsRooted = True
        Else
            IsRooted = False
        End If
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     IsRooted()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function


'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:            FolderExists
'   Parameters:      String
'   Retval:          Boolean
'   Purpose:
'---------------------------------------------------------------------------------
Public Static Function VerifyExists(pPath As String) As Boolean
    On Error GoTo ErrorHandler:
    If Not pPath & "" = "" And _
        Not mLocation & "" = "" Then
            Set mFileSys = New FileSystemObject
            Set mFileSys = CreateObject("Scripting.FileSystemObject")
            If mFileSys.FolderExists(pPath) = True Then
                VerifyExists = True
            Else
                VerifyExists = False
            End If
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     VerifyExists(String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Property Let
'   Name:
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Function Create() As Scripting.folder
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        Set mFolder = mFileSys.CreateFolder(mLocation)
        Set Create = mFolder
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     Create()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function




'---------------------------------------------------------------------------------
'   Type:            Property Let
'   Name:
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Static Function CreateDirectory(pLocation As String) As Scripting.folder
    On Error GoTo ErrorHandler:
    Dim folder As Scripting.folder
    If Not pLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        Set folder = mFileSys.CreateFolder(pLocation)
        Set CreateDirectory = folder
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     CreateDirectory(String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function





'---------------------------------------------------------------------------------
'   Type:            Function
'   Name:            GetCurrentDirectory()
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Static Function GetCurrentDirectory() As String
    On Error GoTo ErrorHandler:
    Dim mCurrent As String
    mCurrent = CurDir()
    GetCurrentDirectory = mCurrent
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetCurrentDirectory()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function




'---------------------------------------------------------------------------------
'   Type:            Function
'   Name:            GetCurrentDirectory()
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Static Sub ChangeDirectory(pLocation As String)
    On Error GoTo ErrorHandler:
    If Not pLocation & "" = "" Then
        ChDir (mLocation)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     ChangeDirectory()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub


'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetPath() As String
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        mPath = mFileSys.GetFolder(mLocation).ShortPath
        GetPath = mPath
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetPath()" _
            & vbCrLf & "Descript:   " & Err.Description
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetDrive() As String
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        mDrive = mFileSys.GetFolder(mLocation).Drive
        GetDrive = mDrive
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetDrive()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetParentFolder() As String
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" And _
        mParentFolder & "" = "" Then
            Set mFileSys = New FileSystemObject
            Set mFileSys = CreateObject("Scripting.FileSystemObject")
            mParentFolder = mFileSys.GetParentFolderName(mLocation)
            GetParentFolder = mParentFolder
            Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetParentFolder()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetDateCreated() As Date
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        mDateCreated = mFileSys.GetFolder(mLocation).DateCreated
        GetDateCreated = mDateCreated
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetDateCreated()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function


'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetLastAccessed() As Date
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        mLastAccessed = mFileSys.GetFolder(mLocation).DateLastAccessed
        GetLastAccessed = mLastAccessed
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetLastAccessed()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetLastModified() As Date
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        mLastModified = mFileSys.GetFolder(mLocation).DateLastModified
        GetLastModified = mLastModified
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetLastModified()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetName() As String
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        mName = mFileSys.GetFolder(mLocation).ShortName
        GetName = mName
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetName()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetType() As String
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        mType = mFileSys.GetFile(mLocation).Type
        GetType = mType
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetType()" _
            & vbCrLf & "Descript:   " & Err.Description
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetSize() As Variant
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        Set GetSize = mFileSys.GetFolder(mLocation).Size
    End If
    Set mFileSys = Nothing
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetSize()" _
            & vbCrLf & "Descript:   " & Err.Description
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



 
'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:            Extension
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetSubFolders() As Scripting.folders
    On Error GoTo ErrorHandler:
    Dim count As Integer
    Dim folders As Scripting.folders
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        Set mSubFolders = mFileSys.GetFolder(mLocation).SubFolders
        Set GetSubFolders = mSubFolders
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetSubFolders()" _
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
Public Function GetFiles() As Scripting.Files
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        Set GetFiles = mFileSys.GetFolder(mLocation).Files
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     GetFiles()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            Move
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub Move(des As String)
    On Error GoTo ErrorHandler:
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     Move(String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub




'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            FileCopy
'   Parameters:      String, String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub Copy(dest As String)
    On Error GoTo ErrorHandler:
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     Copy(String, String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub



'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            Delete
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub Delete()
    On Error GoTo ErrorHandler:
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     Delete()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub


'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            CreateTextFile
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Function CreateTextFile(pFileName As String) As Scripting.TextStream
    On Error GoTo ErrorHandler:
    If Not pFileName & "" = "" And _
        Not mLocation & "" = "" Then
            Dim mTextFile As Scripting.TextStream
            Set mFileSys = New FileSystemObject
            Set mFileSys = CreateObject("Scripting.FileSystemObject")
            Set mTextFile = mFileSys.CreateTextFile(filename:=pFileName, Overwrite:=True)
            CreateTextFile = mTextFile
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     CreateTextFile(String)" _
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
Public Sub Browse()
    On Error GoTo ErrorHandler:
    Set mFileSys = New FileSystemObject
    Set mFileSys = CreateObject("Scripting.FileSystemObject")
    Dim mDialog As FileDialog
    Dim result As Integer
    Set mDialog = Application.FileDialog(msoFileDialogFilePicker)
    mDialog.AllowMultiSelect = False
    mDialog.Title = "Select a file"
    mDialog.InitialFileName = "C:\"
    mDialog.Filters.Clear
    mDialog.Filters.add "Text files", "*.txt"
    mDialog.Filters.add "All files", "*.*"
    If mDialog.Show = -1 Then
       mFileSys.OpenTextFile (mDialog.Item)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     Browse()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub

 


'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            FileRename
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub Rename(pName As String)
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" And _
        Not pName & "" = "" Then
         If Dir(mLocation) <> "" Then
            Name mLocation As pName
        End If
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFolder" _
            & vbCrLf & "Member:     Rename(String)" _
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
        mError = "Source:       BudgetFolder" _
            & vbCrLf & "Member:     OpenFolderDialog()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub



