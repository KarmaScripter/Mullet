Option Compare Database
Option Explicit


Private strAreaCode As String
Private strAreaName As String
Private strProgramProject As String
Private intAreaId As Integer



Private Sub Class_Initialize()
    strAreaCode = ""
    strAreaName = ""
    strProgramProject = ""
    intAreaId = 0
End Sub

Private Sub Class_Terminate()
    strAreaCode = ""
    strAreaName = ""
    strProgramProject = ""
    intAreaId = 0
End Sub



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ID(num As Integer)
    If Not num < 0 Then
        intAreaId = num
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
    If Not intAreaId < 0 Then
        ID = intAreaId
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
        strAreaCode = cd
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
    If Not strAreaCode & "" = "" Then
        Code = strAreaCode
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Name(nm As String)
    If Not nm & "" = "" Then
        strAreaName = nm
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
    If Not strAreaName & "" = "" Then
        Name = strAreaName
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ProgramProjectCode(pp As String)
    If Not pp & "" = "" Then
        strProgramProject = pp
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property Get
'   Name
'   Parameters  Void
'   Retval      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ProgramProjectCode() As String
    If Not strProgramProject & "" = "" Then
        ProgramProjectCode = strProgramProject
    End If
End Property
