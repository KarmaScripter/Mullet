Option Compare Database
Option Explicit


Private mPrcId As Integer
Private mBFY As String
Private mRpioCode As String
Private mBudgetLevel As String
Private mAhCode As String
Private mFundCode As String
Private mFundName As String
Private mOrgCode As String
Private pAccountCode As String
Private mBocCode As String
Private mBocName As String
Private mRcCode As String
Private mDivisionName As String
Private mActivityCode As String
Private mProgramProjectName As String


Public Sub Class_Initialize()
End Sub

Public Sub Class_Terminate()
End Sub


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            ID
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ID(pid As Integer)
    If Not pid < 0 Then
        mPrcId = pid
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            ID
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ID() As Integer
    If Not mPrcId < 0 Then
        ID = mPrcId
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            BFY
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let BFY(yr As String)
    If Not yr & "" = "" Then
        mBFY = yr
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            BFY
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get BFY() As String
    If Not mBFY & "" = "" Then
        BFY = mBFY
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            BudgetLevel
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let BudgetLevel(bl As String)
    If Not bl & "" = "" Then
        mBudgetLevel = bl
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            BudgetLevel
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get BudgetLevel() As String
    If Not mBudgetLevel & "" = "" Then
        BudgetLevel = mBudgetLevel
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            RpioCode
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let RpioCode(rp As String)
    If Not rp & "" = "" Then
        mRpioCode = rp
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            RpioCode
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RpioCode() As String
    If Not mRpioCode & "" = "" Then
        RpioCode = mRpioCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            AhCode
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let AhCode(ac As String)
    If Not ac & "" = "" Then
        mAhCode = ac
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            AhCode
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get AhCode() As String
    If Not mAhCode & "" = "" Then
        AhCode = mAhCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            OrgCode
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let OrgCode(oc As String)
    If Not oc & "" = "" Then
        mOrgCode = oc
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            OrgCode
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get OrgCode() As String
    If Not mOrgCode & "" = "" Then
        OrgCode = mOrgCode
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let FundCode(fc As String)
    If Not fc & "" = "" Then
        mFundCode = fc
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FundCode() As String
    If Not mFundCode & "" = "" Then
        FundCode = mFundCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let FundName(fn As String)
    If Not fn & "" = "" Then
        mFundName = fn
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FundName() As String
    If Not mFundName & "" = "" Then
        FundName = mFundName
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let AccountCode(ac As String)
    If Not ac & "" = "" Then
        pAccountCode = ac
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get AccountCode() As String
    If Not pAccountCode & "" = "" Then
        AccountCode = pAccountCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ActivityCode(act As String)
    If act & "" = "" Then
        mActivityCode = act
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ActivityCode() As String
    If Not mActivityCode & "" = "" Then
        ActivityCode = mActivityCode
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let BocCode(bc As String)
    If Not bc & "" = "" Then
        mBocCode = bc
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get BocCode() As String
    If Not mBocCode & "" = "" Then
        BocCode = mBocCode
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


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let RcCode(rc As String)
    If Not rc & "" = "" Then
        mRcCode = rc
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RcCode() As String
    If Not mRcCode & "" = "" Then
        RcCode = mRcCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Retval          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let DivisionName(dn As String)
    If Not dn & "" = "" Then
        mDivisionName = dn
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get DivisionName() As String
    If Not mDivisionName & "" = "" Then
        DivisionName = mDivisionName
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ProgramProjectName(pn As String)
    If Not pn & "" = "" Then
        mProgramProjectName = pn
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ProgramProjectName() As String
    If Not mProgramProjectName & "" = "" Then
        ProgramProjectName = mProgramProjectName
    End If
End Property


