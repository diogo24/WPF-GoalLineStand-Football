Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data


Public Class LeagueHomeViewModel
    Inherits NewGameViewModel
    Implements INotifyPropertyChanged

#Region "INotifyPropertyChanged"

    Public Shadows Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    private Sub OnPropertyChanged(name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub

#End Region

#Region "Private Variables"
    Private _leaguedate as Date
    Private _myDT as New ObservableCollection(Of DataTable)
    Private ReadOnly _eventBtn as New Command(AddressOf LgEvent)

#End Region

#Region "Public Properties"
    Public Property Leaguedate as Date
    Get
       return _leaguedate            
    End Get
        Set(value as Date)
            _leaguedate=value
            OnPropertyChanged("Leaguedate")
        End Set
    End Property

    Public Property MyDT as ObservableCollection(Of DataTable)
        Get
            Return _myDT
        End Get
        Set(value as ObservableCollection(Of DataTable))
            _myDT=value
            OnPropertyChanged("MyDT")
        End Set
    End Property

    Public ReadOnly Property EventBtn as ICommand
        Get
            return _eventBtn
        End Get
    End Property

#End Region
    ''' <summary>
    ''' Controls what happens when Event Button is clicked
    ''' </summary>
    Private Sub LgEvent
     dim LgEventHome as new LeagueHome
        
        LgEventHome.GetLgEventDT()
        '###TODO Code for LgEvent Button Click goes here 
    End Sub

Public Class Command
        Implements ICommand

#Region "Private Variables"
        Private ReadOnly _action as Action
#End Region
        Sub New(myAction As Action)
            _action = myAction
        End Sub

        Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

        Public Sub Execute(parameter As Object) Implements ICommand.Execute
            _action
        End Sub

        Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
            Return True
        End Function
    End Class

End Class
