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
Private mFile As Scripting.File
Private mCurrentDirectory As String
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
'   Name:            FileExists
'   Parameters:      String
'   Retval:          Boolean
'   Purpose:
'---------------------------------------------------------------------------------
Public Function Exists() As Boolean
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        If mFileSys.FileExists(mLocation) = True Then
            Exists = True
        Else
            Exists = False
        End If
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     Exists()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function


'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:            FileExists
'   Parameters:      String
'   Retval:          Boolean
'   Purpose:
'---------------------------------------------------------------------------------
Public Static Function Verify(pPath As String) As Boolean
    On Error GoTo ErrorHandler:
    If Not pPath & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        If mFileSys.FileExists(pPath) = True Then
            Verify = True
        Else
            Verify = False
        End If
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     Verify(String)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function


'---------------------------------------------------------------------------------
'   Type:            Function
'   Name:            GetStreamReader
'   Parameters:      String
'   Retval:          TextStream
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetStreamReader() As Scripting.TextStream
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFileSys = CreateObject("Scripting.FileSystemObject")
        Set mFile = mFileSys.GetFile(mLocation)
        Set GetStreamReader = mFile.OpenAsTextStream(IOMode:=ForReading, _
            Format:=TristateUseDefault)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     GetStreamReader" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type:            Function
'   Name:            GetStreamReader
'   Parameters:      String
'   Retval:          TextStream
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetStreamWriter() As Scripting.TextStream
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
            Set mFileSys = New FileSystemObject
            Set mFileSys = CreateObject("Scripting.FileSystemObject")
            Set mFile = mFileSys.GetFile(mLocation)
            Set GetStreamReader = mFile.OpenAsTextStream(IOMode:=ForWriting, _
                Format:=TristateUseDefault)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     GetStreamReader" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function


'---------------------------------------------------------------------------------
'   Type:            Function
'   Name:            Create()
'   Parameters:      String
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Function CreateText(pFileName As String) As Scripting.TextStream
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" And _
        Not pFileName & "" = "" Then
            Set mFileSys = New FileSystemObject
            Set mFileSys = CreateObject("Scripting.FileSystemObject")
            Set CreateText = mFileSys.CreateTextFile(filename:=pFileName, _
                Overwrite:=True)
            Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     Create()" _
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
Public Function GetDrive() As String
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        mDrive = mFileSys.GetFile(mLocation).Drive
        GetDrive = mDrive
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
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
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        mParentFolder = mFileSys.GetFile(mLocation).ParentFolder
        GetParentFolder = mParentFolder
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     GetPath()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function




'---------------------------------------------------------------------------------
'   Type:            Function Procedure
'   Name:            GetFullPath()
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Function GetFullPath() As String
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        mPath = mFileSys.GetAbsolutePathName(mLocation)
        GetFullPath = mPath
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     GetFullPath()" _
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
        mDateCreated = mFileSys.GetFile(mLocation).DateCreated
        GetDateCreated = mDateCreated
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     GetDateCreated()" _
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
Public Function GetLastAccessed() As Date
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        mLastAccessed = mFileSys.GetFile(mLocation).DateLastAccessed
        GetLastAccessed = mLastAccessed
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
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
        mLastModified = mFileSys.GetFile(mLocation).DateLastModified
        GetLastModified = mLastModified
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
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
        mName = mFileSys.GetFile(mLocation).ShortName
        GetName = mName
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     GetFileName()" _
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
        mType = mFileSys.GetFile(mLocation).Type
        GetType = mType
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     GetType()" _
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
Public Function GetSize() As Variant
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        GetSize = mFileSys.GetFile(mLocation).Size
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     GetFileName()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
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
Public Function GetExtension() As String
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        mExtension = mFileSys.GetExtensionName(mLocation)
        GetExtension = mExtension
        Set mFileSys = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     GetExtension()" _
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
Public Function GetLength() As Long
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        GetLength = FileLen(mLocation)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     GetLength()" _
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
Public Function ReadAll() As String
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFile = mFileSys.GetFile(mLocation)
        Dim mOut As String
        Dim mStream As Scripting.TextStream
        Set mStream = mFile.OpenAsTextStream
        mOut = mStream.ReadAll
        Set mFileSys = Nothing
        Set mFile = Nothing
        Set mStream = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     ReadAll()" _
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
Public Function Readline() As String
    On Error GoTo ErrorHandler:
    If Not mLocation & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFile = mFileSys.GetFile(mLocation)
        Dim mOut As String
        Dim mStream As Scripting.TextStream
        Set mStream = mFile.OpenAsTextStream
        mOut = mStream.Readline
        Set mFileSys = Nothing
        Set mFile = Nothing
        Set mStream = Nothing
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     Readline" _
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
    If Not mPath & "" = "" And _
        Not des & "" = "" Then
            Set mFileSys = New FileSystemObject
            Set mFile = mFileSys.GetFile(mLocation)
            mFile.Move (des)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
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
    If Not mLocation & "" = "" And Not dest & "" = "" Then
        Set mFileSys = New FileSystemObject
        Set mFile = mFileSys.GetFile(mLocation)
        mFile.Copy Destination:=dest, OverWriteFiles:=True
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
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
    Dim mFileSys As FileSystemObject
    Set mFileSys = New FileSystemObject
    Set mFileSys = CreateObject("Scripting.FileSystemObject")
    If Not mLocation & "" = "" Then
        mFileSys.DeleteFile mPath
        Kill (mPath)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     Delete()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub



'---------------------------------------------------------------------------------
'   Type:            Sub-Procedure
'   Name:            FileRename
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub Rename(pName As String)
    On Error GoTo ErrorHandler:
    If Not mPath & "" = "" And _
        Not pName & "" = "" Then
            Name mPath As pName
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     Rename(String)" _
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
Public Sub RecursiveDelete(FilePath As String, filename As String)
    On Error GoTo ErrorHandler:
    Dim currDir As String
    Dim currentPath As String
    Dim dirItem As Variant
    Dim dirCollection As Collection
    Set dirCollection = New Collection
    If Len(Dir(FilePath & filename)) > 0 Then
       SetAttr FilePath & filename, vbNormal
       Kill FilePath & filename
    End If
    currDir = Dir(FilePath, vbDirectory)
    Do Until currDir = vbNullString
        If Left(currDir, 1) <> "." _
            And (GetAttr(FilePath & currDir) _
            And vbDirectory) = vbDirectory Then
                dirCollection.add FilePath & currDir & "\"
        End If
        currDir = Dir()
    Loop
    For Each dirItem In dirCollection
        RecursiveDelete CStr(dirItem), filename
    Next dirItem
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     RecursiveDelete(String, String)" _
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
Public Sub Browse()
    On Error GoTo ErrorHandler:
    Dim mDialog As FileDialog
    Dim result As Integer
    Set mDialog = Application.FileDialog(msoFileDialogFilePicker)
    mDialog.AllowMultiSelect = False
    mDialog.Title = "Select a file"
    mDialog.InitialFileName = "C:\"
    mDialog.Filters.Clear
    mDialog.Filters.add "All files", "*.*"
    If mDialog.Show = -1 Then
       Debug.Print mDialog.SelectedItems(1)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     BrowseFile()" _
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
Public Function UnZip(pSource As String, pDestination As String) As String
    On Error GoTo ErrorHandler:
    Dim mFailedReason As String
    Dim mZipToolPath As String
    Dim mShellCmd As String
    Dim mSuccess As Boolean
    mZipToolPath = CurrentProject.path & "\etc\7za"
    mShellCmd = mZipToolPath & " x " & pSource & " -o" & pDestination & " -ry"
    mSuccess = Shell(mShellCmd, vbHide)
    If mSuccess = True Then
        Kill pSource
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFile" _
            & vbCrLf & "Member:     BrowseFile()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    mFailedReason = Err.Description
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
    mCurrentDirectory = CurDir()
    GetCurrentDirectory = mCurrentDirectory
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
        mError = "Source:       BudgetFile" _
            & vbCrLf & "Member:     OpenSaveDialog()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Sub
End Sub




