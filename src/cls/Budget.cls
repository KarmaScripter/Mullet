Option Compare Database
Option Explicit

'---------------------------------------------------------------------------------------------------------------------------------------------------
'---------------------------------------------------------------  FIELDS      ----------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------

Private mAhCode As String
Private mBFY As String
Private mRcCode As String
Private mFundCode As String
Private Args As BudgetArgs
Private mDivision As String
Private mControlNumber As String

'---------------------------------------------------------------------------------------------------------------------------------------------------
'-------------------------------------------------------------- CONSTRUCTORS -----------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------

Private Sub Class_Initialize()
    Set Args = New BudgetArgs
End Sub

'---------------------------------------------------------------------------------------------------------------------------------------------------
'--------------------------------------------------------------- PROPERTIES  -----------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let AhCode(ac As String)
    If Not ac & "" = "" Then
        mAhCode = ac
        Args.AhCode = mAhCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get AhCode() As String
    If Not mAhCode & "" = "" Then
        AhCode = mAhCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let BFY(fy As String)
    If Not fy & "" = "" Then
        mBFY = fy
        Args.BFY = mBFY
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get BFY() As String
    If Not mBFY & "" = "" Then
        BFY = mBFY
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let RcCode(rc As String)
    If Not rc & "" = "" Then
        mRcCode = rc
        Args.RcCode = mRcCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get RcCode() As String
    If Not mRcCode & "" = "" Then
        RcCode = mRcCode
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Let
'   Name
'   Parameters      Void
'   Return          Void
'   Purpose
'---------------------------------------------------------------------------------
Public Property Let FundCode(fc As String)
    If Not fc & "" = "" Then
        mFundCode = fc
        Args.FundCode = mFundCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get FundCode() As String
    If Not mFundCode & "" = "" Then
        FundCode = mFundCode
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get PublicLaw() As String
    If Not mBFY & "" = "" Then
        PublicLaw = DLookup("PublicLaw", "Appropriations", "Appropriations.BFY = '" & mBFY & "'")
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get AppropriationBill() As String
    If Not mBFY & "" = "" Then
        AppropriationBill = DLookup("Title", "Appropriations", "Appropriations.BFY = '" & mBFY & "'")
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get DivisionName() As String
    If Not mRcCode & "" = "" Then
        DivisionName = DLookup("Title", "Divisions", "Divisions.Code = '" & mRcCode & "'")
    End If
End Property


'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name
'   Parameters      Void
'   Return          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get DivisionCaption() As String
    If Not mRcCode & "" = "" Then
        DivisionCaption = DLookup("Caption", "Divisions", "Divisions.Code = '" & mRcCode & "'")
    End If
End Property


'---------------------------------------------------------------------------------------------------------------------------------------------------
'--------------------------------------------------------------- METHODS  --------------------------------------------------------------------------
'---------------------------------------------------------------------------------------------------------------------------------------------------


'----------------------------------------------------------------------------------
'   Type            Sub-Procedure
'   Name            Generate
'   Parameters      Void
'   Purpose         Initializes BudgetArg members
'---------------------------------------------------------------------------------
Public Sub Generate(bargs As BudgetArgs)

    'Declarations
    Dim DB As DAO.Database
    Dim Data As DAO.Recordset
    Dim query As DAO.QueryDef
    Dim Budget As Report
    
    On Error GoTo ErrorHandler:

    'Initialize memebers
    If Not Args.AhCode & "" = "" Then
        AhCode = Args.AhCode
    Else
        AhCode = "06"
    End If
    If Not bargs.BFY & "" = "" Then
        BFY = Args.BFY
    End If
    If Not bargs.RcCode & "" = "" Then
        RcCode = Args.RcCode
    End If
    If Not bargs.FundCode & "" = "" Then
        FundCode = Args.FundCode
    End If
    Set DB = CurrentDb
    Set Budget = Forms("DivisionBudgetAuthority")
    Set query = DB.QueryDefs("SelectParamBudgetAuthorityData")
    query.Parameters("AhCodeArgs") = AhCode
    query.Parameters("FiscalYearArgs") = BFY
    query.Parameters("RcCodeArgs") = RcCode
    query.Parameters("FundCodeArgs") = FundCode
    
    'Assign recordset to report
    Set Data = query.OpenRecordset(dbOpenDynaset)
    Budget.Recordset = Data
    
    'Open Report
    DoCmd.OpenReport (Budget.Name)
    
    'Close Report
    query.Close
    
ErrorHandler:
    Dim msg As String
    msg = "Budget Object 'Generate' Function Error!"
    MessageFactory.Message = msg
    MessageFactory.ShowError msg
    Resume Next
End Sub

