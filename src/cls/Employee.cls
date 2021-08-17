Option Compare Database
Option Explicit



Private mHireDate As String
Private mRpioCode As String
Private mHROrgCode As String
Private mRcCode As String
Private mEmployeeNumber As String
Private mLastName As String
Private mFirstName As String
Private mPayGrade As String
Private mStep As String
Private mJobTitle As String



Public Sub Class_Initialize()
End Sub

Public Sub Class_Terminate()
End Sub

'----------------------------------------------------------------------------------
'   Type:        Property-Let
'   Name:        RpioCode
'   Parameters:  String
'   RetVal:      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let RpioCode(rp As String)
    If Not rp & "" = "" Then
        mRpioCode = rp
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Get
'   Name:        RpioCode
'   Parameters:  Void
'   RetVal:      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RpioCode() As String
    If Not mRpioCode & "" = "" Then
        RpioCode = mRpioCode
    End If
End Property

'----------------------------------------------------------------------------------
'   Type:        Property-Let
'   Name:        HrOrgCode
'   Parameters:  String
'   RetVal:      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let HrOrgCode(oc As String)
    If Not oc & "" = "" Then
       mHROrgCode = oc
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Get
'   Name:        HrOrgCode
'   Parameters:  Void
'   RetVal:      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get HrOrgCode() As String
    If Not mHROrgCode & "" = "" Then
        HrOrgCode = mHROrgCode
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Let
'   Name:        EmployeeNumber
'   Parameters:  String
'   RetVal:      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let EmployeeNumber(eid As String)
    If eid & "" = "" Then
        mEmployeeNumber = eid
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Get
'   Name:        EmployeeNumber
'   Parameters:  Void
'   RetVal:      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get EmployeeNumber() As String
    If Not mEmployeeNumber & "" = "" Then
        EmployeeNumber = mEmployeeNumber
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Let
'   Name:        LastName
'   Parameters:  String
'   RetVal:      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let LastName(ln As String)
    If ln & "" = "" Then
        mLastName = ln
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Get
'   Name:        LastName
'   Parameters:  Void
'   RetVal:      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get LastName() As String
    If Not mLastName & "" = "" Then
        LastName = mLastName
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Let
'   Name:        FirstName
'   Parameters:  String
'   RetVal:      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let FirstName(fn As String)
    If fn & "" = "" Then
    mFirstName = fn
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Get
'   Name:        FirstName
'   Parameters:  Void
'   RetVal:      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FirstName() As String
    If Not mFirstName & "" = "" Then
        FirstName = mFirstName
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Let
'   Name:        RcCode
'   Parameters:  String
'   RetVal:      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let RcCode(rc As String)
    If Not rc & "" = "" Then
        mRcCode = rc
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Get
'   Name:        RcCode
'   Parameters:  Void
'   RetVal:      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RcCode() As String
    If Not mRcCode & "" = "" Then
        RcCode = mRcCode
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Let
'   Name:        PayGrade
'   Parameters:  String
'   RetVal:      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let PayGrade(pg As String)
    If Not pg & "" = "" Then
        mPayGrade = pg
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Get
'   Name:        PayGrade
'   Parameters:  Void
'   RetVal:      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get PayGrade() As String
    If Not mPayGrade & "" = "" Then
        PayGrade = mPayGrade
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Let
'   Name:        Step
'   Parameters:  String
'   RetVal:      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Step(sp As String)
    If Not sp & "" = "" Then
        mStep = sp
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Get
'   Name:        Step
'   Parameters:  Void
'   RetVal:      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Step() As String
    If Not mStep & "" = "" Then
        Step = mStep
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Let
'   Name:        JobTitle
'   Parameters:  String
'   RetVal:      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let JobTitle(jt As String)
    If Not jt & "" = "" Then
        mJobTitle = jt
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Get
'   Name:        JobTitle
'   Parameters:  Void
'   RetVal:      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get JobTitle() As String
    If Not mJobTitle & "" = "" Then
        JobTitle = mJobTitle
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Let
'   Name:        HireDate
'   Parameters:  Date
'   RetVal:      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let HireDate(hd As Date)
    If Not hd & "" = "" Then
        mHireDate = hd
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property-Get
'   Name:        HireDate
'   Parameters:  Void
'   RetVal:      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get HireDate() As Date
    If Not mHireDate & "" = "" Then
        HireDate = mHireDate
    End If
End Property


