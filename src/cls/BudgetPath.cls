Option Compare Database
Option Explicit


Private mReferenceModels As String
Private mViewModels As String
Private mDataModels As String
Private mExcelReport As String
Private mExcelBudget As String
Private mBudgetFolder As String
Private mDivisionModels As String
Private mPath As String

'---------------------------------------------------------------------------------
'   Type:            Constructor
'   Name:
'   Parameters:      Void
'   Retval:          BudgetPath
'   Purpose:
'---------------------------------------------------------------------------------
Private Sub Class_Initialize()
    mViewModels = "Provider=Microsoft.Access.OLEDB.10.0;" _
        & "Persist Security Info=False;" _
        & "Data Source=" _
        & CurrentProject.path _
        & "\Views.accdb;" _
        & "User ID=Admin;" _
        & "Data Provider=Microsoft.ACE.OLEDB.12.0"
        
    mDataModels = "Provider=Microsoft.Access.OLEDB.10.0;" _
        & "Persist Security Info=False;" _
        & "Data Source=" _
        & CurrentProject.path _
        & "\Data.accdb;" _
        & "User ID=Admin;" _
        & "Data Provider=Microsoft.ACE.OLEDB.12.0"
     
    mReferenceModels = "Provider=Microsoft.Access.OLEDB.10.0;" _
        & "Persist Security Info=False;" _
        & "Data Source=" _
        & CurrentProject.path _
        & "\References.accdb;" _
        & "User ID=Admin;" _
        & "Data Provider=Microsoft.ACE.OLEDB.12.0"
        
    mDivisionModels = "Provider=Microsoft.Access.OLEDB.10.0;" _
        & "Persist Security Info=False;" _
        & "Data Source=" _
        & CurrentProject.path _
        & "\Divisions.accdb;" _
        & "User ID=Admin;" _
        & "Data Provider=Microsoft.ACE.OLEDB.12.0"
      
    mExcelReport = CurrentProject.path & "\etc\templates\reports\ReportBase.xlsx"
        
    mExcelBudget = CurrentProject.path & "\etc\templates\reports\budgets\BudgetBase.xlsx"
End Sub


'---------------------------------------------------------------------------------
'   Type:            Property-Get
'   Name:            References
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get References() As String
    If Not mReferenceModels & "" = "" Then
        References = mReferenceModels
    End If
End Property




'---------------------------------------------------------------------------------
'   Type:            Property-Get
'   Name:            Data
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get Data() As String
    If Not mDataModels & "" = "" Then
        Data = mDataModels
    End If
End Property



'---------------------------------------------------------------------------------
'   Type:            Property-Get
'   Name:            Divisions
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get Divisions() As String
    If Not mDivisionModels & "" = "" Then
        Divisions = mDivisionModels
    End If
End Property




'---------------------------------------------------------------------------------
'   Type:            Property-Get
'   Name:            ReportTemplate
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get ReportTemplate() As String
    If Not mExcelReport & "" = "" Then
        ReportTemplate = mExcelReport
    End If
End Property





'---------------------------------------------------------------------------------
'   Type:            Property-Get
'   Name:            ExcelBudget
'   Parameters:      Void
'   Retval:          String
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Get BudgetTemplate() As String
    If Not mExcelBudget & "" = "" Then
        BudgetTemplate = mExcelBudget
    End If
End Property




'---------------------------------------------------------------------------------
'   Type:            Property-Let
'   Name:            External
'   Parameters:      Void
'   Retval:          Void
'   Purpose:
'---------------------------------------------------------------------------------
Public Property Let External(fp As String)
    If Not fp & "" = "" And Not Dir(fp) = "" Then
        mPath = fp
    End If
End Property



'---------------------------------------------------------------------------------
'   Type            Property-Get
'   Name            ExternalFile
'   Parameters      Void
'   Retval          String
'   Purpose
'---------------------------------------------------------------------------------
Public Property Get External() As String
    If Not mPath & "" = "" Then
        External = mPath
    End If
End Property
