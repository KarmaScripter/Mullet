Option Compare Database
Option Explicit


'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   FIELDS   ------------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------

Private mError As String


'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   METHODS  ------------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------



'---------------------------------------------------------------------------------
'   Type            Function
'   Name            ToProperCase
'   Parameters      Void
'   Return          Void
'   Purpose
'                   Capitalize the first character and add a space before
'                   each capitalized letter (except the first character).
'---------------------------------------------------------------------------------
Public Static Function ToProperCase(ByVal pString As String) As String
    On Error GoTo ErrorHandler:
    Dim result As String
    Dim i As Integer
    Dim ch As String
    If Len(pString) < 2 Then
        ToProperCase = UCase$(pString)
        Exit Function
    End If
    result = UCase$(mID$(pString, 1, 1))
    For i = 2 To Len(pString)
        ch = mID$(pString, i, 1)
        If (UCase$(ch) = ch) Then result = result & " "
        result = result & ch
    Next i
    ToProperCase = result
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Member:      ToProperCase(String)" _
            & vbCrLf & "Source:       String" _
            & vbCrLf & "Descrip:      " & Err.Description & "'"
        Err.Clear
        Exit Function
    End If
    MessageFactory.ShowError mError
End Function




'---------------------------------------------------------------------------------
'   Type            Function
'   Name            ToCamelCase
'   Parameters      Void
'   Return          Void
'   Purpose
'                   Capitalize the first character and add a space before
'                   each capitalized letter (except the first character).
'---------------------------------------------------------------------------------
Public Function ToCamelCase(ByVal pString As String) As String
    On Error GoTo ErrorHandler:
    Dim result As String
    result = ToPascalCase(pString)
    If Len(result) > 0 Then
        Mid$(result, 1, 1) = LCase$(mID$(result, 1, 1))
    End If
    ToCamelCase = result
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Member:      ToProperCase(String)" _
            & vbCrLf & "Source:       Strings" _
            & vbCrLf & "Descrip:      " & Err.Description & "'"
        Err.Clear
        Exit Function
    End If
    MessageFactory.ShowError mError
End Function



'---------------------------------------------------------------------------------
'   Type            Function
'   Name            ToPascalCase
'   Parameters      Void
'   Return          Void
'   Purpose
'                   Capitalize the first character and add a space before
'                   each capitalized letter (except the first character).
'---------------------------------------------------------------------------------
Public Function ToPascalCase(ByVal pString As String) As String
    On Error GoTo ErrorHandler:
    Dim words() As String
    Dim i As Integer
    If Len(pString) < 2 Then
        ToPascalCase = UCase$(pString)
        Exit Function
    End If
    words = Split(pString)
    For i = LBound(words) To UBound(words)
        If (Len(words(i)) > 0) Then
            Mid$(words(i), 1, 1) = UCase$(mID$(words(i), 1, _
                1))
        End If
    Next i
    ToPascalCase = Join(words, "")
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Member:      ToPascalCase(String)" _
            & vbCrLf & "Source:       Strings" _
            & vbCrLf & "Descrip:      " & Err.Description & "'"
        Err.Clear
        Exit Function
    End If
    MessageFactory.ShowError mError
End Function





'---------------------------------------------------------------------------------
'   Type            Function
'   Name            SearchArray
'   Parameters      Void
'   Return          Void
'   Purpose
'                   Capitalize the first character and add a space before
'                   each capitalized letter (except the first character).
'---------------------------------------------------------------------------------
Public Function SearchArray(mArray As Variant, pString As String) As Integer
    Dim FindStrInArray As Integer
    FindStrInArray = -1
    Dim i As Integer
    For i = LBound(mArray) To UBound(mArray)
        If pString = mArray(i) Then
            FindStrInArray = i
            Exit For
        End If
    Next i
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Member:      SearchArray(String)" _
            & vbCrLf & "Source:       Strings" _
            & vbCrLf & "Descrip:      " & Err.Description & "'"
        Err.Clear
        Exit Function
    End If
    MessageFactory.ShowError mError
End Function




'---------------------------------------------------------------------------------
'   Type            Function
'   Name            SplitToArray
'   Parameters      Void
'   Return          Void
'   Purpose
'                   Capitalize the first character and add a space before
'                   each capitalized letter (except the first character).
'---------------------------------------------------------------------------------
Public Function SplitIntoArray(pString As String, mSeparator As String) As Variant
    Dim Arr As Variant
    If Len(pString) > 0 Then
        Arr = Split(pString, mSeparator)
        Dim i As Integer
        For i = LBound(Arr) To UBound(Arr)
            Arr(i) = Trim(Arr(i))
        Next i
    Else
        Arr = Array()
    End If
    SplitIntoArray = Arr
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Member:      SplitToArray(String)" _
            & vbCrLf & "Source:       Strings" _
            & vbCrLf & "Descrip:      " & Err.Description & "'"
        Err.Clear
        Exit Function
    End If
    MessageFactory.ShowError mError
End Function
