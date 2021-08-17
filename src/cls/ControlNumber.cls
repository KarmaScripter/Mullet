Option Compare Database
Option Explicit

'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   FIELDS   -----------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------

Private pAnd As String
Private mInsert As String
Private mIssuedDate As Date
Private mControlNumberId As Integer
Private mFundCode As String
Private mFundControl As String
Private mFundNumber As Integer
Private mDivisionControl As String
Private mDivisionNumber As Integer
Private mRpioCode As String
Private mRegionControl As String
Private mRegionNumber As Integer
Private mFCN As Integer
Private mDCN As String
Private mCalendarYear As String
Private mBFY As String
Private mOrgCode As String
Private mAhCode As String
Private mRcCode As String
Private mDivisionName As String
Private mPurpose As String
Private mError As String

'---------------------------------------------------------------------------------------------------------------------------------------------------
'--------------------------------------------------------------- CONSTRUCTOR -----------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------

Private Sub Class_Initialize()
    pAnd = "-"
End Sub

'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------    METHODS  -----------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        ControlNumberId
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ControlNumberId(cid As Integer)
    If cid > 0 Then
        mControlNumberId = cid
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        ControlNumberId
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ControlNumberId() As Integer
    If mControlNumberId > 0 Then
        ControlNumberId = mControlNumberId
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        RpioCode
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RpioCode() As String
    If Not mAhCode & "" = "" And _
        mAhCode = "06" Then
            RpioCode = "06"
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        AhCode
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let AhCode(ac As String)
    If Not ac & "" = "" Then
        mAhCode = ac
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        AhCode
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get AhCode() As String
    If Not mAhCode & "" = "" Then
        AhCode = mAhCode
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        BFY
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let BFY(fy As String)
    If Not fy & "" = "" Then
        mBFY = fy
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        BFY
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get BFY() As String
    If Not mBFY & "" = "" Then
        BFY = mBFY
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        RcCode
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let RcCode(rc As String)
    If Not rc & "" = "" Then
        mRcCode = rc
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        RcCode
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RcCode() As String
    If Not mRcCode & "" = "" Then
        RcCode = mRcCode
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        FundCode
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let FundCode(fcn As String)
    If Not fcn & "" = "" Then
        mFundCode = fcn
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        FundCode
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FundCode() As String
    If Not mFundCode & "" = "" Then
        FundCode = mFundCode
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FundNumber() As Integer
    If Not mFundCode & "" = "" Then
        mFundNumber = DCount("FundCode", "ControlNumbers", "ControlNumbers.FundCode = '" & mFundCode & "'") + 1
        FundNumber = mFundNumber
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        Division
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Division() As String
    If Not mRcCode & "" = "" Then
        Dim Name As String
        Name = DLookup("Name", "Divisions", "Divisions.Code = '" & mRcCode & "'")
        Division = Name
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        DivisionNumber
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get DivisionNumber() As Integer
    If Not mRcCode & "" = "" Then
        mDivisionNumber = DCount("RcCode", "ControlNumbers", "ControlNumbers.RcCode = '" & mRcCode & "'") + 1
        DivisionNumber = mDivisionNumber
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        RegionNumber
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RegionNumber() As Integer
    If Not mAhCode & "" = "" Then
        mRegionNumber = DCount("ControlNumberId", "ControlNumbers", "ControlNumbers.AhCode = '" & mAhCode & "'") + 1
        RegionNumber = mRegionNumber
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        CalendarYear
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get CalendarYear() As String
    If Not mBFY & "" = "" Then
        CalendarYear = Right(mBFY, 2)
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        IssuedDate
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let IssuedDate(dt As Date)
    If IsDate(dt) Then
        mIssuedDate = dt
    Else
        mIssuedDate = Now()
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        IssuedDate
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get IssuedDate() As Date
        mIssuedDate = Now()
        IssuedDate = mIssuedDate
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        Purpose
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Purpose(ps As String)
    If Not ps & "" = "" Then
        mPurpose = ps
    End If
    If ps & "" = "" Then
        mPurpose = "NOT SPECIFIED"
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        Purpose
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Purpose() As String
    If Not mPurpose & "" = "" Then
        Purpose = mPurpose
    End If
    If mPurpose & "" = "" Then
        mPurpose = "NOT SPECIFIED"
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        Create
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Sub Create(ac As String, fy As String, rc As String, fc As String)
    If Not ac & "" = "" Then
       AhCode = ac
    End If
    If Not fy & "" = "" Then
        BFY = fy
    End If
    If Not rc & "" = "" Then
        RcCode = rc
    End If
    If Not fc & "" = "" Then
        FundCode = fc
    End If
End Sub


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name        Generate
'   Parameters  String
'   RetVal      String
'   Purpose
'---------------------------------------------------------------------------------
Public Function Generate(ac As String, fy As String, _
    rc As String, fc As String) As String
    Dim control As String
    If Not ac & "" = "" Then
        AhCode = ac
    End If
    If Not fy & "" = "" Then
        BFY = fy
    End If
    If Not rc & "" = "" Then
        RcCode = rc
    End If
    If Not fc & "" = "" Then
        FundCode = fc
    End If
    If Not AhCode & "" = "" And _
        Not BFY & "" = "" And _
        Not RcCode & "" = "" And _
        Not FundCode & "" = "" And _
        Not Division & "" = "" Then
            control = AhCode & pAnd & BFY & pAnd _
                & CalendarYear & FundCode & pAnd _
                & FundNumber & pAnd _
                & Division & pAnd _
                & DivisionNumber & pAnd _
                & RegionNumber
    End If
    Generate = control
End Function


'----------------------------------------------------------------------------------
'   Type        Property Procedure
'   Name
'   Parameters  Integer
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Private Sub add()
    Dim SQL As String
    SQL = "INSERT INTO ControlNumbers (RpioCode, RegionNumber, AhCode, BFY, CalendarYear, " _
        & "RcCode, DivisionNumber, FundCode, FundNumber, IssuedDate) " _
        & "VALUES " & Me.RpioCode & ", " & Me.RegionNumber _
        & ", " & Me.AhCode & ", " & Me.BFY & ", " & Me.CalendarYear _
        & ", " & Me.RcCode & ", " & Me.DivisionNumber _
        & ", " & Me.FundCode & ", " & Me.FundNumber _
        & ", " & Me.IssuedDate & ";"
        
    DoCmd.RunSQL SQL
End Sub
