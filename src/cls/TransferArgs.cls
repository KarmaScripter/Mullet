Option Compare Database
Option Explicit



Private mTransferId As Integer
Private mBFY As String
Private mRpioCode As String
Private mRpioName As String
Private mAhCode As String
Private mAhName As String
Private mOrgCode As String
Private mOrgName As String
Private mFundCode As String
Private mFundName As String
Private mAccountCode As String
Private mProgramProjectCode As String
Private mProgramProjectName As String
Private mProgramAreaCode As String
Private mProgramAreaName As String
Private mNpmCode As String
Private mNpmName As String
Private mFromTo As String
Private mBocCode As String
Private mRcCode As String
Private mDivisionName As String
Private mStartDate As String
Private mEndDate As String
Private mProcessedDate As Date
Private mReprogrammingNumber As String
Private mControlNumber As String
Private mDocPrefix As String
Private mDocType As String
Private mLine As String
Private mSubline As String
Private mPurpose As String
Private mExtendedPurpose As String
Private mResourceType As String
Private mAmount As Double



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
Public Property Let TransferId(tid As Integer)
    If tid > 0 Then
        mTransferId = tid
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get TransferId() As Integer
    If mTransferId > 0 Then
        TransferId = mTransferId
    End If
End Property


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



'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let RpioName(rn As String)
    If Not rn & "" = "" Then
        mRpioName = rn
    End If
End Property


'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RpioName() As String
    If Not mRpioName & "" = "" Then
        RpioName = mRpioName
    End If
End Property

'---------------------------------------------------------------------------------
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




'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let AhName(an As String)
    If Not an & "" = "" Then
        mAhName = an
    End If
End Property


'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get AhName() As String
    If Not mAhName & "" = "" Then
        AhName = mAhName
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let OrgCode(oc As String)
    If Not oc & "" = "" Then
       mOrgCode = oc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get OrgCode() As String
    If Not mOrgCode & "" = "" Then
        OrgCode = mOrgCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let OrgName(wc As String)
    If Not wc & "" = "" Then
        mOrgName = wc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get OrgName() As String
    If Not mOrgName & "" = "" Then
        OrgName = mOrgName
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






'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ProgramProjectCode(ppc As String)
    If Not ppc & "" = "" Then
        mProgramProjectCode = ppc
    End If
End Property



'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ProgramProjectCode() As String
    If Not mProgramProjectCode & "" = "" Then
        ProgramProjectCode = mProgramProjectCode
    End If
End Property




'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ProgramProjectName(ppn As String)
    If Not ppn & "" = "" Then
        mProgramProjectName = ppn
    End If
End Property



'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ProgramProjectName() As String
    If Not mProgramProjectName & "" = "" Then
        ProgramProjectName = mProgramProjectName
    End If
End Property





'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ProgramAreaCode(pac As String)
    If Not pac & "" = "" Then
        mProgramAreaCode = pac
    End If
End Property



'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ProgramAreaCode() As String
    If Not mProgramAreaCode & "" = "" Then
        ProgramAreaCode = mProgramAreaCode
    End If
End Property




'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ProgramAreaName(pan As String)
    If Not pan & "" = "" Then
        mProgramAreaName = pan
    End If
End Property



'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ProgramAreaName() As String
    If Not mProgramAreaName & "" = "" Then
        ProgramAreaName = mProgramAreaName
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
Public Property Let ProcessedDate(pd As String)
    If Not pd & "" = "" Then
        mProcessedDate = pd
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ProcessedDate() As String
    If Not mProcessedDate & "" = "" Then
        ProcessedDate = mProcessedDate
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let DocType(dt As String)
    If Not dt & "" = "" Then
        mDocType = dt
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get DocType() As String
    If Not mDocType & "" = "" Then
        DocType = mDocType
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ReprogrammingNumber(rpn As String)
    If Not rpn & "" = "" Then
        mReprogrammingNumber = rpn
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ReprogrammingNumber() As String
    If Not mReprogrammingNumber & "" = "" Then
        ReprogrammingNumber = mReprogrammingNumber
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ControlNumber(cn As String)
    If Not cn & "" = "" Then
        mControlNumber = cn
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ControlNumber() As String
    If Not mControlNumber & "" = "" Then
        ControlNumber = mControlNumber
    End If
End Property

'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Line(eid As String)
    If eid & "" = "" Then
        mLine = eid
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Line() As String
    If Not mLine & "" = "" Then
        Line = mLine
    End If
End Property




'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Subline(sl As String)
    If Not sl & "" = "" Then
        mSubline = sl
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Subline() As String
    If Not mSubline & "" = "" Then
        Subline = mSubline
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let FromTo(fcc As String)
    If Not fcc & "" = "" Then
        mFromTo = fcc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FromTo() As String
    If Not mFromTo & "" = "" Then
        FromTo = mFromTo
    End If
End Property




'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Purpose(pr As String)
    If Not pr & "" = "" Then
        mPurpose = pr
    End If
End Property



'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Purpose() As String
    If Not mPurpose & "" = "" Then
        Purpose = mPurpose
    End If
End Property



'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ExtendedPurpose(ep As String)
    If Not ep & "" = "" Then
        mExtendedPurpose = ep
    End If
End Property



'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ExtendedPurpose() As String
    If Not mExtendedPurpose & "" = "" Then
        ExtendedPurpose = mExtendedPurpose
    End If
End Property


'---------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ResourceType(rt As String)
    If Not rt & "" = "" Then
        mResourceType = rt
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ResourceType() As String
    If Not mResourceType & "" = "" Then
        ResourceType = mResourceType
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Amount(am As Double)
    If am > 0 Then
        mAmount = am
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Amount() As Double
    If mAmount > 0 Then
        Amount = mAmount
    End If
End Property

