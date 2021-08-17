Option Compare Database
Option Explicit


'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------   FIELDS   ------------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------

Private mMessage As String


'---------------------------------------------------------------------------------------------------------------------------------------------------
'------------------------------------------------------------  PROPERTIES   ------------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        Message
'   Parameters  String
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let Message(text As String)
    If Not text & "" = "" Then
        mMessage = text
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Property
'   Name        Message
'   Parameters  Void
'   RetVal      String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get Message() As String
    If Not mMessage & "" = "" Then
        Message = mMessage
    End If
End Property


'----------------------------------------------------------------------------------
'   Type        Sub-Procedure
'   Name        ShowError
'   Parameters  String
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Sub ShowError(msg As String)
    If Not msg & "" = "" Then
        mMessage = msg
        DoCmd.OpenForm FormName:="ErrorDialog", OpenArgs:=mMessage, WindowMode:=acDialog
    End If
End Sub




'----------------------------------------------------------------------------------
'   Type        Sub-Procedure
'   Name        ShowError
'   Parameters  String
'   RetVal      Void
'   Purpose
'---------------------------------------------------------------------------------
Public Sub ShowNotfication(msg As String)
    If Not msg & "" = "" Then
        mMessage = msg
        DoCmd.OpenForm FormName:="MessageDialog", OpenArgs:=mMessage
    End If
End Sub


