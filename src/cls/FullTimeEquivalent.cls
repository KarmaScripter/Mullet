Option Compare Database

'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   FIELDS   -----------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------

Private mRpioCode As String
Private mBFY As String
Private mBudgetLevel As String
Private mFundCode As String
Private mAhCode As String
Private mOrgCode As String
Private mAccountCode As String
Private mActivityCode As String
Private mBocCode As String
Private mRcCode As String
Private mAmount As Double


'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   CONSTRUCTORS --------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------

Public Sub Class_Initialize()
End Sub

Public Sub Class_Terminate()
End Sub


'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   METHODS        ------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get BFY() As String
    If Not mBFY & "" = "" Then
        BFY = mBFY
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let BFY(year As String)
    If Not year & "" = "" Then
        mBFY = year
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get RPIO() As String
    If Not mRpioCode & "" = "" Then
        RPIO = mRpioCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let RPIO(rp As String)
    If Not rp & "" = "" Then
        mRpioCode = rp
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let BudgetLevel(bl As String)
    If Not bl & "" = "" Then
        mBudgetLevel = bl
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get BudgetLevel() As String
    If Not mBudgetLevel & "" = "" Then
        BudgetLevel = mBudgetLevel
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let FundCode(fc As String)
    If Not fc & "" = "" Then
        mFundCode = fc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get FundCode() As String
    If Not mFundCode & "" = "" Then
        FundCode = mFundCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let AhCode(AH As String)
    If Not AH & "" = "" Then
        mAhCode = AH
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get AhCode() As String
    If Not mAhCode & "" = "" Then
        AhCode = mAhCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let OrgCode(ORG As String)
    If Not ORG & "" = "" Then
        mOrgCode = ORG
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get OrgCode() As String
    If Not mOrgCode & "" = "" Then
        OrgCode = mOrgCode
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let AccountCode(ac As String)
    If Not ac & "" = "" Then
        mAccountCode = ac
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get AccountCode() As String
    If Not mAccountCode & "" = "" Then
        AccountCode = mAccountCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let RcCode(rc As String)
    If Not rc & "" = "" Then
        mRcCode = rc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get RcCode() As String
    If Not mRcCode & "" = "" Then
        RcCode = mRcCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let Amount(funds As Double)
    If Not IsNull(funds) Or Not funds < 0 Then
        mAmount = funds
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get Amount() As Double
    If Not IsNull(mAmount) Or Not mAmount < 0 Then
        Amount = mAmount
    End If
End Property
