Option Compare Database
Option Explicit


'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   FIELDS   -----------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------


Private mFundCode As String
Private mFundName As String
Private mFundTitle As String
Private mTreasurySymbol As String
Private mID As Integer



'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   PROPERTIES  ---------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Private Sub Class_Initialize()
End Sub


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Private Sub Class_Terminate()
End Sub



'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let ID(num As Integer)
    If num > 0 Then
        mID = num
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get ID() As Integer
    If mID > 0 Then
        ID = mID
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Code(cd As String)
    If Not cd & "" = "" Then
        mFundCode = cd
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Code() As String
    If Not mFundCode & "" = "" Then
        Code = mFundCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Name(nm As String)
    If Not nm & "" = "" Then
        mFundName = nm
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Name() As String
    If Not mFundName & "" = "" Then
        Name = mFundName
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Title(tit As String)
    If Not tit & "" = "" Then
        mFundTitle = tit
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Title() As String
    If Not mFundTitle & "" = "" Then
        Title = mFundTitle
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let TreasurySymbol(ts As String)
    If Not ts & "" = "" Then
        mTreasurySymbol = ts
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get TreasurySymbol() As String
    If Not mTreasurySymbol & "" = "" Then
        TreasurySymbol = mTreasurySymbol
    End If
End Property


