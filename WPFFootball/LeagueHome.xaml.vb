Imports System.Data
Imports System.Globalization

Public Class LeagueHome
    Dim MyVM as new LeagueHomeViewModel
    Dim TempDT as New DataTable
    Sub New

        ' This call is required by the designer.
        InitializeComponent()
       ' Add any initialization after the InitializeComponent() call.
        DataContext=MyVM
        MyVM.Leaguedate= "2/16/16"
       
    End Sub

    Public Sub GetLgEventDT
       
        TempDT.Columns.Add("Date",GetType(Date))
        TempDT.Columns.Add("Event Scheduled",GetType(String))
        
        TempDT.Rows.Add(String.Format("{0:dddd MMMM dd, yyyy}","2/20/16"),"NFL Combine")
        TempDT.Rows.Add(String.Format("{0:dddd MMMM dd, yyyy}","3/7/16"),"Free Agency Begins")
        TempDT.Rows.Add(string.Format("{0:dddd MMMM dd, yyyy}","4/28/16"),"NFL Draft Round 1")
        TempDT.Rows.Add(string.Format("{0:dddd MMMM dd, yyyy}","4/29/16"),"NFL Draft Round 2 and 3")
        TempDT.Rows.Add(string.Format("{0:dddd MMMM dd, yyyy}","4/30/16"),"NFL Draft Round 4 thru 7")
        TempDT.Rows.Add(string.Format("{0:dddd MMMM dd, yyyy}","5/21/16"),"Rookie Minicamps Begin")

        MyVM.MyDT.Add(TempDT)      
        
    End Sub

End Class
