Imports Microsoft.Win32

Public Class UserScreen
    Dim ReadOnly myTeam as integer

    ''' <summary>
    '''     TeamID gets the the team the user selected when creating the window passed in as a parameter
    ''' </summary>
    ''' <param name="TeamID"></param>
    Sub New(TeamID As integer)

        ' This call is required by the designer.
        InitializeComponent()
        GridBackground.ImageSource= New BitmapImage(New Uri(NewGameViewModel.GetBackgroundFilePath(TeamID),
                                                             UriKind.RelativeOrAbsolute))
        ' Add any initialization after the InitializeComponent() call.
        myTeam = TeamID
    End Sub

    ''' <summary>
    '''     Loads Game from file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FileLoad_OnClick(sender As Object, e As RoutedEventArgs)
        dim myFile as New OpenFileDialog
        myFile.Filter = "GLS Save Game Files (*.gls)|*.gls"
        dim result as Boolean = myFile.ShowDialog()

        if result = True then
            '#TODO need to figure out what gets loaded for the game
        end if
    End Sub

    Private Sub FileSave_OnClick(sender As Object, e As RoutedEventArgs)
        dim myFile as new OpenFileDialog
        dim result as Boolean = myFile.ShowDialog()

        myFile.Filter = "GLS Save Game Files (*.gls)|*.gls"

        if result = True Then
            '#TODO need to figure out what to save so the file can then be loaded properly again and the game resumed.
        End If
    End Sub

    Private Sub FileHelp_OnClick(sender As Object, e As RoutedEventArgs)
        'bring up help file 
    End Sub

    Private Sub FileExit_OnClick(sender As Object, e As RoutedEventArgs)
        dim res as MsgBoxResult = MsgBox("Are you sure you want to exit the game? Any unsaved data will be lost!",
                                         MsgBoxStyle.YesNo, "Exit Game")
        if res = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub MenuItem_OnClick(sender As Object, e As RoutedEventArgs)
        dim mySettings as new GameSettings(myTeam)
        mysettings.Show()
        GetWindow(mysettings)
        Close
    End Sub
End Class
