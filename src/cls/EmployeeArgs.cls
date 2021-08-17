Option Compare Database
Option Explicit


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
'   Type:        Property Procedure Let
'   Name:        EmployeeNumber
'   Parameters:  String
'   Retval:      Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let EmployeeNumber(eid As String)
    If eid & "" = "" Then
        mEmployeeNumber = eid
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        EmployeeNumber
'   Parameters:  Void
'   RetVal:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get EmployeeNumber() As String
    If Not mEmployeeNumber & "" = "" Then
        EmployeeNumber = mEmployeeNumber
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:        LastName
'   Parameters:  String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let LastName(ln As String)
    If ln & "" = "" Then
        mLastName = ln
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        LastName
'   Parameters:  Void
'   RetVal:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get LastName() As String
    If Not mLastName & "" = "" Then
        LastName = mLastName
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:        FirstName
'   Parameters:  String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let FirstName(fn As String)
    If fn & "" = "" Then
    mFirstName = fn
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        FirstName
'   Parameters:  Void
'   RetVal:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get FirstName() As String
    If Not mFirstName & "" = "" Then
        FirstName = mFirstName
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:        RcCode
'   Parameters:  String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let RcCode(rc As String)
    If Not rc & "" = "" Then
        mRcCode = rc
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        RcCode
'   Parameters:  Void
'   RetVal:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get RcCode() As String
    If Not mRcCode & "" = "" Then
        RcCode = mRcCode
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:        PayGrade
'   Parameters:  String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let PayGrade(pg As String)
    If Not pg & "" = "" Then
        mPayGrade = pg
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        PayGrade
'   Parameters:  Void
'   RetVal:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get PayGrade() As String
    If Not mPayGrade & "" = "" Then
        PayGrade = mPayGrade
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Let
'   Name:        JobTitle
'   Parameters:  String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let JobTitle(jt As String)
    If Not jt & "" = "" Then
        mJobTitle = jt
    End If
End Property


'----------------------------------------------------------------------------------
'   Type:        Property Procedure Get
'   Name:        JobTitle
'   Parameters:  Void
'   RetVal:      String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get JobTitle() As String
    If Not mJobTitle & "" = "" Then
        JobTitle = mJobTitle
    End If
End Property


