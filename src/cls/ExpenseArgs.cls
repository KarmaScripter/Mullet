Option Compare Database
Option Explicit



Private mBFY As String
Private mRpioCode As String
Private mAhCode As String
Private mFundCode As String
Private mAccountCode As String
Private mWorkCode As String
Private mBocCode As String
Private mRcCode As String
Private mFocCode As String
Private mFocName As String
Private mCommitments As Double
Private mOpenCommitments As Double
Private mObligations As Double
Private mDeobligations As Double
Private mULO As Double
Private mExpenditures As Double

Public Sub Class_Initialize()
End Sub

Public Sub Class_Terminate()
End Sub

'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let BFY(yr As String)
    If Not yr & "" = "" Then
        mBFY = yr
    End If
End Property


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
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let RpioCode(rp As String)
    If Not rp & "" = "" Then
        mRpioCode = rp
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get RpioCode() As String
    If Not mRpioCode & "" = "" Then
        RpioCode = mRpioCode
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let AhCode(ac As String)
    If Not ac & "" = "" Then
        mAhCode = ac
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
Public Property Let BocCode(bc As String)
    If Not bc & "" = "" Then
        mBocCode = bc
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get BocCode() As String
    If Not mBocCode & "" = "" Then
        BocCode = mBocCode
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
Public Property Let FocCode(fcc As String)
    If Not fcc & "" = "" Then
        mFocCode = fcc
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get FocCode() As String
    If Not mFocCode & "" = "" Then
        FocCode = mFocCode
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let FocName(fcn As String)
    If Not fcn & "" = "" Then
        mFocName = fcn
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:
'   Parameters:  Void
'   Retval:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get FocName() As String
    If Not mFocName & "" = "" Then
        FocName = mFocName
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:        Commitments
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let Commitments(cm As Double)
    If Not cm & "" = "" Then
        mCommitments = cm
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        Commitments
'   Parameters:  Void
'   Retval:      Double
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get Commitments() As Double
    If Not mCommitments & "" = "" Then
        Commitments = mCommitments
    End If
End Property

'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:        OpenCommitments
'   Parameters:  Double
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let OpenCommitments(oc As Double)
    If Not oc & "" = "" Then
        mOpenCommitments = oc
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        OpenCommitments
'   Parameters:  Void
'   Retval:      Double
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get OpenCommitments() As Double
    If Not mCommitments & "" = "" Then
        Commitments = mCommitments
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  Double
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let Obligations(ob As Double)
    If Not ob & "" = "" Then
        mObligations = ob
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        Obligations
'   Parameters:  Void
'   Retval:      Double
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get Obligations() As Double
    If Not mObligations & "" = "" Then
        Obligations = mObligations
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:        Deobligations
'   Parameters:  Double
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let Deobligations(od As Double)
    If Not od & "" = "" Then
        mDeobligations = od
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        Deobligations
'   Parameters:  Void
'   Retval:      Double
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get Deobligations() As Double
    If Not mDeobligations & "" = "" Then
        Deobligations = mDeobligations
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:
'   Parameters:  Double
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let ULO(uo As Double)
    If Not uo & "" = "" Then
        mULO = uo
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        ULO
'   Parameters:  Void
'   Retval:      Double
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get ULO() As Double
    If Not mULO & "" = "" Then
        ULO = mULO
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:        Expenditures
'   Parameters:  Double
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let Expenditure(ex As Double)
    If Not ex & "" = "" Then
        mExpenditures = ex
    End If
End Property



'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        Expenditures
'   Parameters:  Void
'   Retval:      Double
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get Expenditures() As Double
    If Not mExpenditures & "" = "" Then
        Expenditures = mExpenditures
    End If
End Property

