Option Compare Database
Option Explicit

Private mID As Integer
Private mCode As String
Private mGoalCode As String
Private mObjectiveCode As String
Private mProgramProjectCode As String
Private mActivityCode As String


'---------------------------------------------------------------------------------
'   Type            Constructor
'   Name            Class_Initialize
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Private Sub Class_Initialize()
End Sub



'---------------------------------------------------------------------------------
'   Type            Destructor
'   Name            Class_Terminate
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Private Sub Class_Terminate()
End Sub



'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            ID
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ID(num As Integer)
    If Not num < 0 Then
        mID = num
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            ID
'   Parameters      Void
'   Return          Integer
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ID() As Integer
    If Not mID < 0 Then
        ID = mID
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            Code
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Code(cd As String)
    If Not cd & "" = "" Then
        mCode = cd
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            Code
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Code() As String
    If Not mCode & "" = "" Then
        Code = mCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            Goal
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Goal(gc As String)
    If Not gc & "" = "" Then
        mGoalCode = gc
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            Goal
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Goal() As String
    If Not mGoalCode & "" = "" Then
        Goal = mGoalCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            Objective
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Objective(oc As String)
    If Not oc & "" = "" Then
        mObjectiveCode = oc
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            Objective
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Objective() As String
    If Not mObjectiveCode & "" = "" Then
        Objective = mObjectiveCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name            ProgramProjectCode
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ProgramProjectCode(ppc As String)
    If Not ppc & "" = "" Then
        mProgramProjectCode = ppc
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            ProgramProjectCode
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ProgramProjectCode() As String
    If Not mProgramProjectCode & "" = "" Then
        ProgramProjectCode = mProgramProjectCode
    End If
End Property

