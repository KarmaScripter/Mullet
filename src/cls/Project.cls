Option Compare Database
Option Explicit


Private mCode As String
Private mName As String
Private mID As Integer



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
Public Property Let ID(intId As Integer)
    If intId > -1 Then
        mID = intId
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ID() As Integer
    If Not mID > -1 Then
        ID = mID
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Code(cd As String)
    If Not cd & "" = "" Then
        mCode = cd
    End If
End Property




'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Code() As String
    If Not mCode & "" = "" Then
        Code = mCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Name(OrgName As String)
    If Not OrgName & "" = "" Then
        mName = OrgName
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Name() As String
    If Not mName & "" = "" Then
        Name = mName
    End If
End Property

