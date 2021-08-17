Option Compare Database
Option Explicit


Private mBFY As String
Private mRcCode As String
Private mFundCode As String
Private mFundName As String
Private mAhCode As String
Private mRPIO As String
Private mDivision As String
Private mDivisionName As String
Private mBocCode As String
Private mBocName As String
Private mAccountCode As String
Private mProgramProjectCode As String
Private mProgramProjectName As String
Private mStartDate As String
Private mEndDate As String


'---------------------------------------------------------------------------------
'   Type:        Constructor
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub Class_Initialize()
End Sub



'---------------------------------------------------------------------------------
'   Type:        Destructor
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Sub Class_Terminate()
End Sub



'---------------------------------------------------------------------------------
'   Type:        Property Procedure
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let BocCode(ac As String)
    If Not ac & "" = "" Then
        mBocCode = ac
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get BocCode() As String
    If Not mBocCode & "" = "" Then
        BocCode = mBocCode
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let BocName(bn As String)
    If Not bn & "" = "" Then
        mBocName = bn
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get BocName() As String
    If Not mBocName & "" = "" Then
        BocName = mBocName
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let AhCode(ac As String)
    If Not ac & "" = "" Then
        mAhCode = Left(ac, 2)
        mRPIO = mAhCode
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get AhCode() As String
    If Not mAhCode & "" = "" Then
        AhCode = mAhCode
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get RPIO() As String
    If Not mRPIO & "" = "" Then
        RPIO = mRPIO
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let BFY(yr As String)
    If Not yr & "" = "" Then
        mBFY = yr
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get BFY() As String
    If Not mBFY & "" = "" Then
        BFY = mBFY
    End If
End Property




'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let ProgramProjectName(pn As String)
    If Not pn & "" = "" Then
        mProgramProjectName = pn
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get ProgramProjectName() As String
    If Not mProgramProjectName & "" = "" Then
        ProgramProjectName = mProgramProjectName
    End If
End Property




'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let ProgramProjectCode(pc As String)
    If Not pc & "" = "" Then
        mProgramProjectCode = pc
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get ProgramProjectCode() As String
    If Not mProgramProjectCode & "" = "" Then
        ProgramProjectCode = mProgramProjectCode
    End If
End Property




'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let RcCode(rc As String)
    If Not rc & "" = "" Then
        mRcCode = rc
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get RcCode() As String
    If Not mRcCode & "" = "" Then
        RcCode = mRcCode
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let DivisionName(dn As String)
    If Not dn & "" = "" Then
        mDivisionName = dn
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get Division() As String
    If Not mRcCode & "" = "" Then
        RcCode = DLookup("Caption", "Divisions", "Divisions.Code = '" & mRcCode & "'")
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get DivisionName() As String
    If Not mDivisionName & "" = "" Then
        DivisionName = mDivisionName
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let FundCode(fc As String)
    If Not fc & "" = "" Then
        mFundCode = fc
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get FundCode() As String
    If Not mFundCode & "" = "" Then
        FundCode = mFundCode
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get FundName() As String
    If Not mFundName & "" = "" Then
        FundName = mFundName
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:
'   Name:
'   Parameters:  Void
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let FundName(fn As String)
    If Not fn & "" = "" Then
        mFundName = fn
    End If
End Property

'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let StartDate(sd As String)
    If Not sd & "" = "" Then
        mStartDate = sd
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get StartDate() As String
    If Not mStartDate & "" = "" Then
        StartDate = mStartDate
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let EndDate(ed As String)
    If Not ed & "" = "" Then
        mEndDate = ed
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get EndDate() As String
    If IsDate(mEndDate) Then
        EndDate = mEndDate
    End If
End Property


