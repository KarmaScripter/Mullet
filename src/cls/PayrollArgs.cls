Option Compare Database
Option Explicit


Private mBFY As String
Private mRpioCode As String
Private mAhCode As String
Private mFundCode As String
Private mFundName As String
Private mHROrgCode As String
Private mAccountCode As String
Private mWorkCode As String
Private mBocCode As String
Private mBocName As String
Private mRcCode As String
Private mDivisionName As String
Private mEmployeeNumber As String
Private mLastName As String
Private mFirstName As String
Private mPayPeriod As String
Private mPayGrade As String
Private mStep As String
Private mStartDate As String
Private mEndDate As String
Private mJobTitle As String
Private mReportingCode As String
Private mReportingCodeName As String
Private mFocCode As String
Private mFocName As String


Public Sub Class_Initialize()
End Sub

Public Sub Class_Terminate()
End Sub



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let BFY(yr As String)
    If Not yr & "" = "" Then
        mBFY = yr
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get BFY() As String
    If Not mBFY & "" = "" Then
        BFY = mBFY
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


'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let RpioCode(rp As String)
    If Not rp & "" = "" Then
        mRpioCode = rp
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RpioCode() As String
    If Not mRpioCode & "" = "" Then
        RpioCode = mRpioCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let AhCode(ac As String)
    If Not ac & "" = "" Then
        mAhCode = ac
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get AhCode() As String
    If Not mAhCode & "" = "" Then
        AhCode = mAhCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let HrOrgCode(oc As String)
    If Not oc & "" = "" Then
       mHROrgCode = oc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get HrOrgCode() As String
    If Not mHROrgCode & "" = "" Then
        HrOrgCode = mHROrgCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let WorkCode(wc As String)
    If Not wc & "" = "" Then
        mWorkCode = wc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get WorkCode() As String
    If Not mWorkCode & "" = "" Then
        WorkCode = mWorkCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let FundCode(fc As String)
    If Not fc & "" = "" Then
        mFundCode = fc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FundName() As String
    If Not mFundName & "" = "" Then
        FundName = mFundName
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
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
Public Property Get FundCode() As String
    If Not mFundCode & "" = "" Then
        FundCode = mFundCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let AccountCode(ac As String)
    If Not ac & "" = "" Then
        mAccountCode = ac
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get AccountCode() As String
    If Not mAccountCode & "" = "" Then
        AccountCode = mAccountCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let EmployeeNumber(eid As String)
    If eid & "" = "" Then
        mEmployeeNumber = eid
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get EmployeeNumber() As String
    If Not mEmployeeNumber & "" = "" Then
        EmployeeNumber = mEmployeeNumber
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let BocCode(bc As String)
    If Not bc & "" = "" Then
        mBocCode = bc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get BocCode() As String
    If Not mBocCode & "" = "" Then
        BocCode = mBocCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let RcCode(rc As String)
    If Not rc & "" = "" Then
        mRcCode = rc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RcCode() As String
    If Not mRcCode & "" = "" Then
        RcCode = mRcCode
    End If
End Property




'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let DivisionName(dn As String)
    If Not dn & "" = "" Then
        mDivisionName = dn
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get DivisionName() As String
    If Not mDivisionName & "" = "" Then
        DivisionName = mDivisionName
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let PayPeriod(pyp As String)
    If Not pyp & "" = "" Then
        mPayPeriod = pyp
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get PayPeriod() As String
    If Not mPayPeriod & "" = "" Then
        PayPeriod = mPayPeriod
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let PayGrade(pg As String)
    If Not pg & "" = "" Then
        mPayGrade = pg
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get PayGrade() As String
    If Not mPayGrade & "" = "" Then
        PayGrade = mPayGrade
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let JobTitle(jt As String)
    If Not jt & "" = "" Then
        mJobTitle = jt
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get JobTitle() As String
    If Not mJobTitle & "" = "" Then
        JobTitle = mJobTitle
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ReportingCode(ppl As String)
    If Not ppl & "" = "" Then
        mReportingCode = ppl
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ReportingCode() As String
    If Not mReportingCode & "" = "" Then
        ReportingCode = mReportingCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ReportingCodeName(ppn As String)
    If Not ppn & "" = "" Then
        mReportingCodeName = ppn
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ReportingCodeName() As String
    If Not mReportingCodeName & "" = "" Then
        ReportingCodeName = mReportingCodeName
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let FocCode(fcc As String)
    If Not fcc & "" = "" Then
        mFocCode = fcc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FocCode() As String
    If Not mFocCode & "" = "" Then
        FocCode = mFocCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let FocName(fcn As String)
    If Not fcn & "" = "" Then
        mFocName = fcn
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FocName() As String
    If Not mFocName & "" = "" Then
        FocName = mFocName
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let BocName(bn As String)
    If Not bn & "" = "" Then
        mBocName = bn
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get BocName() As String
    If Not mBocName & "" = "" Then
        BocName = mBocName
    End If
End Property



