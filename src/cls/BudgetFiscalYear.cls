Option Compare Database
Option Explicit



Private mBFY As String
Private mEFY As String
Private mID As Integer
Private mStartDate As Date
Private mEndDate As Date
Private mCalendarDate As Date
Private mCalendarYear As String
Private mDay As String
Private mMonth As String
Private mExpirationDate As Date
Private mExpiringYear As String
Private mSweepDate As Date
Private mIsWorkDay As Boolean
Private mIsExpiring As Boolean
Private mData As AccessData
Private mConnection As ADODB.Connection
Private mRecords As ADODB.Recordset
Private mError As String
Private mNotification As String
Private mArgs As String


'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------     METHODS   ---------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------



'---------------------------------------------------------------------------------
'   Type            Constructor
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Private Sub Class_Initialize()
        mCalendarYear = str(year(Now()))
End Sub



'---------------------------------------------------------------------------------
'   Type            Destructor
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Private Sub Class_Terminate()
End Sub




'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Args(yr As String)
    If Not yr & "" = "" Then
        mArgs = yr
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Args() As String
    If Not mArgs & "" = "" Then
        Args = mArgs
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ID(num As Integer)
    If num > 0 Then
        mID = num
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ID() As Integer
    If mID > 0 Then
        ID = mID
    End If
End Property




'---------------------------------------------------------------------------------
'   Type            Function
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Function GetCalendarDate() As Date
    On Error GoTo ErrorHandler:
    If Not IsDate(mCalendarDate) Then
        mCalendarDate = Now()
        mMonth = Month(Now())
        mDay = Day(Now())
        GetCalendarDate = mCalendarDate
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFiscalYear" _
            & vbCrLf & "Member:     GetCalendarDate" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type            Function
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Function GetCalendarMonth() As Date
    On Error GoTo ErrorHandler:
    If IsDate(mMonth) Then
        GetCalendarMonth = mMonth
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFiscalYear" _
            & vbCrLf & "Member:     GetCalendarMonth()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type            Function
'   Name
'   Parameters      Void
'   Return          Date
'   Purpose
'---------------------------------------------------------------------------------
Public Function GetCalendarDay() As Date
    On Error GoTo ErrorHandler:
    If IsDate(mDay) Then
        GetCalendarDay = mDay
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFiscalYear" _
            & vbCrLf & "Member:     GetCalendarDay()" _
            & vbCrLf & "Descript:    " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function



'---------------------------------------------------------------------------------
'   Type            Function
'   Name            GetCalendarYear
'   Parameters      Void
'   Return          Date
'   Purpose
'---------------------------------------------------------------------------------
Public Function GetCalendarYear() As String
    On Error GoTo ErrorHandler:
    If Not mCalendarYear & "" = "" Then
        GetCalendarYear = mCalendarYear
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFiscalYear" _
            & vbCrLf & "Member:     GetCalendarYear()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function


'---------------------------------------------------------------------------------
'   Type            Sub-Procedure
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let BeginingFiscalYear(by As String)
    If Not by & "" = "" Then
        mBFY = by
    Else
        mBFY = str(year(Now()))
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Function
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get BeginingFiscalYear() As String
    If Not mBFY & "" = "" Then
        BeginingFiscalYear = mBFY
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Sub-Procedure
'   Name            SetLastYear
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let EndingFiscalYear(by As String)
    If Not by & "" = "" Then
        mEFY = by
    Else
        mEFY = mBFY
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Function
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get EndingFiscalYear() As String
    If Not mEFY & "" = "" Then
        EndingFiscalYear = mEFY
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Sub-Procedure
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ExpirationYear(ex As String)
    If Not ex & "" = "" And _
        Not mBFY & "" = "" And _
        Not mEFY & "" = "" And _
        mBFY <> mEFY Then
            mExpiringYear = mEFY
    End If
End Property





'---------------------------------------------------------------------------------
'   Type            Function
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ExpirationYear() As String
    If Not mExpiringYear & "" = "" Then
        ExpirationYear = mExpiringYear
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Function
'   Name            IsExpiring
'   Parameters      Void
'   Return          Boolean
'   Purpose
'---------------------------------------------------------------------------------
Public Function IsExpiring() As Boolean
    On Error GoTo ErrorHandler:
    If Not mExpiringYear & "" = "" Then
        IsExpiring = True
    End If
    If mExpiringYear & "" = "" Then
        IsExpiring = False
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFiscalYear Class" _
            & vbCrLf & "Member: IsExpiring()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function





'---------------------------------------------------------------------------------
'   Type            Sub-Procedure
'   Name            SetSweepDate
'   Parameters      Date
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let SweepDate(sd As Date)
    If IsDate(sd) And _
        IsExpiring() And _
        Not IsDate(mSweepDate) Then
            mSweepDate = sd
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Sub-Procedure
'   Name            SetSweepDate
'   Parameters      Date
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get SweepDate() As Date
    If IsDate(mSweepDate) And _
        IsExpiring() And _
        Not IsDate(mSweepDate) Then
            SweepDate = mSweepDate
    End If
End Property




'---------------------------------------------------------------------------------
'   Type            Sub-Procedure
'   Name            SetSweepDate
'   Parameters      Date
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Function CalculateCalendarDaysUntil(sd As Date) As Integer
    On Error GoTo ErrorHandler:
    If IsDate(sd) Then
        CalculateCalendarDaysUntil = DateDiff("d", Now, sd)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFiscalYear" _
            & vbCrLf & "Member:     CalculateDaysUntil(Date)" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function





'---------------------------------------------------------------------------------
'   Type            Sub-Procedure
'   Name            SetSweepDate
'   Parameters      Date
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Function CalculateRemainingFullTimeDays() As Integer
    On Error GoTo ErrorHandler:
    If Not mCalendarYear & "" = "" Then
        Dim yr As String
        yr = "10/01/" & mCalendarYear
        Dim dt As Date
        dt = CDate(yr)
        CalculateRemainingFullTimeDays = DateDiff("d", Now, dt)
    End If
ErrorHandler:
    If Err.Number > 0 Then
        mError = "Source:   BudgetFiscalYear" _
            & vbCrLf & "Member:     CalculateFiscalDaysRemaining()" _
            & vbCrLf & "Descript:   " & Err.Description
        Err.Clear
    End If
    MessageFactory.ShowError (mError)
    Exit Function
End Function




