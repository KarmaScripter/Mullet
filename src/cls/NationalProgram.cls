Option Compare Database
Option Explicit


Private mCode As String
Private mName As String
Private mTitle As String
Private mRPIO As String
Private mNpmId As Integer

'----------------------------------------------------------------------------------
'   Type        Constructor
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Sub Class_Initialize()
End Sub



'----------------------------------------------------------------------------------
'   Type        Destructor
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Sub Class_Terminate()
End Sub



'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ID(num As Integer)
    If num > 0 Then
        mNpmId = num
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ID() As Integer
    If Not mNpmId < 0 Then
        ID = mNpmId
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Code(cd As String)
    If Not cd & "" = "" Then
        mCode = cd
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Code() As String
    If Not mCode & "" = "" Then
        Code = mCode
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Name(nm As String)
    If Not nm & "" = "" Then
        mName = nm
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Name() As String
    If Not mName & "" = "" Then
        Name = mName
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let RPIO(rp As String)
    If Not rp & "" = "" Then
        mRPIO = rp
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RPIO() As String
    If Not mRPIO & "" = "" Then
        RPIO = mRPIO
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Title(tl As String)
    If Not tl & "" = "" Then
        mTitle = tl
    End If
End Property



'----------------------------------------------------------------------------------
'   Type        Property
'   Name
'   Parameters  Void
'   RetVal
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Title() As String
    If Not mTitle & "" = "" Then
        Title = mTitle
    End If
End Property


