Imports System.IO

Public Class GameSettings
    Dim ReadOnly myTeam as integer
    Dim ReadOnly SetArray(22) as string
    Dim ReadOnly TempArray(125) as string
    dim DoOnce as Boolean

    Sub New(TeamID As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        myTeam = TeamID
        ' Add any initialization after the InitializeComponent() call.
        GetSettings(TeamID)
    End Sub

    ''' <summary>
    '''     Saves any changes to game state and returns to previous menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Accept_OnClick(sender As Object, e As RoutedEventArgs)
        dim userTeam as new UserScreen(myTeam)
        'WindowSize =Display.SelectedItem.GetHashCode()
        userTeam.Show()
        GetWindow(userTeam)
        close
    End Sub

    Private Sub GetSettings(TeamID As Integer)
        LgSettingsGridBG.ImageSource = New BitmapImage(New Uri(NewGameViewModel.GetBackgroundFilePath(TeamID),
                                                               UriKind.RelativeOrAbsolute))
        LoadSettings()
        'LgSettingsTabControlBG=
        RosterSize.SelectedIndex = 7
        GameInactives.SelectedIndex = 7
        OTFormat.SelectedIndex = 2
        For i = 0 To 15

        Next i
    End Sub

    Private Sub ChkBxLuxTax_Checked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(2))
        TempArray(2) += "True"
    End Sub

    Private Sub ChkBxLuxTax_Unchecked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(2))
        TempArray(2) += "False"
    End Sub

    Private Sub SalCapType_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        ResetValues(temparray(1))
        TempArray(1) += SalCapType.SelectedItem.Tag.tostring
    End Sub

    Private Sub ChkBxAdjustCap_Checked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(3))
        TempArray(3) += "True"
    End Sub

    Private Sub ChkBxAdjustCap_Unchecked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(3))
        TempArray(3) += "False"
    End Sub

    Private Sub ChkBxRookiePool_Checked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(4))
        TempArray(4) += "True"
    End Sub

    Private Sub ChkBxRookiePool_Unchecked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(4))
        TempArray(4) += "False"
    End Sub

    Private Sub ChkBxCapCarryover_Checked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(5))
        TempArray(5) += "True"
    End Sub

    Private Sub ChkBxCapCarryover_Unchecked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(5))
        TempArray(5) += "False"
    End Sub

    Private Sub ChkBxSalCap_Checked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(0))
        TempArray(0) += "True"
    End Sub

    Private Sub ChkBxSalCap_Unchecked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(0))
        TempArray(0) += "False"
    End Sub

    Private Sub GateRev_OnLostFocus(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(6))
        TempArray(6) += GateRev.Text
    End Sub

    Private Sub LgSalCap_OnLostFocus(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(7))
        dim num = CInt(lgsalCap.Text)
        LgSalCap.Text = num.ToString("N0")
        TempArray(7) += LGSalCap.text
    End Sub

    Private Sub ChkBxLuxBoxSharedRev_Checked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(8))
        TempArray(8) += "True"
    End Sub

    Private Sub ChkBxLuxBoxSharedRev_Unchecked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(8))
        TempArray(8) += "False"
    End Sub

    Private Sub ChkBxShareMerchRev_Checked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(9))
        TempArray(9) += "True"
    End Sub

    Private Sub ChkBxShareMerchRev_Unchecked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(9))
        TempArray(9) += "False"
    End Sub

    Private Sub MinSal_OnLostFocus(sender As Object, e As RoutedEventArgs)
        If MinSal.Text <> "" then
            Dim num = CInt(minsal.Text)

            MinSal.Text = num.ToString("N0")
            Select Case MinConExp.SelectedIndex
                Case 0 :
                    ResetValues(temparray(10))
                    TempArray(10) += minsal.text
                Case 1 :
                    ResetValues(temparray(11))
                    TempArray(11) += MinSal.text
                Case 2 :
                    ResetValues(temparray(12))
                    TempArray(12) += MinSal.text
                Case 3 :
                    ResetValues(temparray(13))
                    TempArray(13) += MinSal.text
                Case 4 :
                    ResetValues(temparray(14))
                    TempArray(14) += MinSal.text
                Case 5 :
                    ResetValues(temparray(15))
                    TempArray(15) += MinSal.text
                Case 6 :
                    ResetValues(temparray(16))
                    TempArray(16) += MinSal.text
                Case 7 :
                    ResetValues(temparray(17))
                    TempArray(17) += MinSal.text
                Case 8 :
                    ResetValues(temparray(18))
                    TempArray(18) += MinSal.text
                Case 9 :
                    ResetValues(temparray(19))
                    TempArray(19) += MinSal.text
                Case 10 :
                    ResetValues(temparray(20))
                    TempArray(20) += MinSal.text
                Case 11 :
                    ResetValues(temparray(21))
                    TempArray(21) += MinSal.text
                Case 12 :
                    ResetValues(temparray(22))
                    TempArray(22) += MinSal.text
                Case 13 :
                    ResetValues(temparray(23))
                    TempArray(23) += MinSal.text
                Case 14 :
                    ResetValues(temparray(24))
                    TempArray(24) += MinSal.text
            End Select
        End if
    End Sub

    Private Sub ChkBxAllowVetDisc_Checked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(25))
        TempArray(25) += "True"
    End Sub

    Private Sub ChkBxAllowVetDisc_Unchecked(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(25))
        TempArray(25) += "False"
    End Sub

    Private Sub MinExp_OnLostFocus(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(26))
        TempArray(26) += MinExp.text
    End Sub

    Private Sub VetMinConCapHit_OnLostFocus(sender As Object, e As RoutedEventArgs)
        ResetValues(temparray(27))
        dim num = CInt(VetMinConCapHit.Text)
        VetMinConCapHit.Text = num.ToString("N0")
        TempArray(27) += VetMinConCapHit.text
    End Sub

    Private Sub FranSal_OnLostFocus(sender As Object, e As RoutedEventArgs)
        Dim num = CInt(FranSal.Text)
        FranSal.Text = num.ToString("N0")
        select case PosConValues.SelectedIndex
            Case 0 :
                ResetValues(temparray(28))
                TempArray(28) += FranSal.Text
            Case 1 :
                ResetValues(temparray(34))
                TempArray(34) += FranSal.Text
            Case 2 :
                ResetValues(temparray(40))
                TempArray(40) += FranSal.Text
            Case 3 :
                ResetValues(temparray(46))
                TempArray(46) += FranSal.Text
            Case 4 :
                ResetValues(temparray(52))
                TempArray(52) += FranSal.Text
            Case 5 :
                ResetValues(temparray(58))
                TempArray(58) += FranSal.Text
            Case 6 :
                ResetValues(temparray(64))
                TempArray(64) += FranSal.Text
            Case 7 :
                ResetValues(temparray(70))
                TempArray(70) += FranSal.Text
            Case 8 :
                ResetValues(temparray(76))
                TempArray(76) += FranSal.Text
            Case 9 :
                ResetValues(temparray(82))
                TempArray(82) += FranSal.Text
            Case 10 :
                ResetValues(temparray(88))
                TempArray(88) += FranSal.Text
            Case 11 :
                ResetValues(temparray(94))
                TempArray(94) += FranSal.Text
            Case 12 :
                ResetValues(temparray(100))
                TempArray(100) += FranSal.Text
            Case 13 :
                ResetValues(temparray(106))
                TempArray(106) += FranSal.Text
            Case 14 :
                ResetValues(temparray(112))
                TempArray(112) += FranSal.Text
            Case 15 :
                ResetValues(temparray(118))
                TempArray(118) += FranSal.Text
        End Select
    End Sub

    Private Sub VeryGoodSal_OnLostFocus(sender As Object, e As RoutedEventArgs)
        Dim num = CInt(VeryGoodSal.Text)
        VeryGoodSal.Text = num.ToString("N0")
        select case PosConValues.SelectedIndex
            Case 0 :
                ResetValues(temparray(29))
                TempArray(29) += VeryGoodSal.Text
            Case 1 :
                ResetValues(temparray(35))
                TempArray(35) += VeryGoodSal.Text
            Case 2 :
                ResetValues(temparray(41))
                TempArray(41) += VeryGoodSal.Text
            Case 3 :
                ResetValues(temparray(47))
                TempArray(47) += VeryGoodSal.Text
            Case 4 :
                ResetValues(temparray(53))
                TempArray(53) += VeryGoodSal.Text
            Case 5 :
                ResetValues(temparray(59))
                TempArray(59) += VeryGoodSal.Text
            Case 6 :
                ResetValues(temparray(65))
                TempArray(65) += VeryGoodSal.Text
            Case 7 :
                ResetValues(temparray(71))
                TempArray(71) += VeryGoodSal.Text
            Case 8 :
                ResetValues(temparray(77))
                TempArray(77) += VeryGoodSal.Text
            Case 9 :
                ResetValues(temparray(83))
                TempArray(83) += VeryGoodSal.Text
            Case 10 :
                ResetValues(temparray(89))
                TempArray(89) += VeryGoodSal.Text
            Case 11 :
                ResetValues(temparray(95))
                TempArray(95) += VeryGoodSal.Text
            Case 12 :
                ResetValues(temparray(101))
                TempArray(101) += VeryGoodSal.Text
            Case 13 :
                ResetValues(temparray(107))
                TempArray(107) += VeryGoodSal.Text
            Case 14 :
                ResetValues(temparray(113))
                TempArray(113) += VeryGoodSal.Text
            Case 15 :
                ResetValues(temparray(119))
                TempArray(119) += VeryGoodSal.Text
        End Select
    End Sub

    Private Sub GoodSal_OnLostFocus(sender As Object, e As RoutedEventArgs)
        Dim num = CInt(GoodSal.Text)
        GoodSal.Text = num.ToString("N0")
        select case PosConValues.SelectedIndex
            Case 0 :
                ResetValues(temparray(30))
                TempArray(30) += GoodSal.Text
            Case 1 :
                ResetValues(temparray(36))
                TempArray(36) += GoodSal.Text
            Case 2 :
                ResetValues(temparray(42))
                TempArray(42) += GoodSal.Text
            Case 3 :
                ResetValues(temparray(48))
                TempArray(48) += GoodSal.Text
            Case 4 :
                ResetValues(temparray(54))
                TempArray(54) += GoodSal.Text
            Case 5 :
                ResetValues(temparray(60))
                TempArray(60) += GoodSal.Text
            Case 6 :
                ResetValues(temparray(66))
                TempArray(66) += GoodSal.Text
            Case 7 :
                ResetValues(temparray(72))
                TempArray(72) += GoodSal.Text
            Case 8 :
                ResetValues(temparray(78))
                TempArray(78) += GoodSal.Text
            Case 9 :
                ResetValues(temparray(84))
                TempArray(84) += GoodSal.Text
            Case 10 :
                ResetValues(temparray(90))
                TempArray(90) += GoodSal.Text
            Case 11 :
                ResetValues(temparray(96))
                TempArray(96) += GoodSal.Text
            Case 12 :
                ResetValues(temparray(102))
                TempArray(102) += GoodSal.Text
            Case 13 :
                ResetValues(temparray(108))
                TempArray(108) += GoodSal.Text
            Case 14 :
                ResetValues(temparray(114))
                TempArray(114) += GoodSal.Text
            Case 15 :
                ResetValues(temparray(120))
                TempArray(120) += GoodSal.Text
        End Select
    End Sub

    Private Sub AvgSal_OnLostFocus(sender As Object, e As RoutedEventArgs)
        Dim num = CInt(AvgSal.Text)
        AvgSal.Text = num.ToString("N0")
        select case PosConValues.SelectedIndex
            Case 0 :
                ResetValues(temparray(31))
                TempArray(31) += AvgSal.Text
            Case 1 :
                ResetValues(temparray(37))
                TempArray(37) += AvgSal.Text
            Case 2 :
                ResetValues(temparray(43))
                TempArray(43) += AvgSal.Text
            Case 3 :
                ResetValues(temparray(49))
                TempArray(49) += AvgSal.Text
            Case 4 :
                ResetValues(temparray(55))
                TempArray(55) += AvgSal.Text
            Case 5 :
                ResetValues(temparray(61))
                TempArray(61) += AvgSal.Text
            Case 6 :
                ResetValues(temparray(67))
                TempArray(67) += AvgSal.Text
            Case 7 :
                ResetValues(temparray(73))
                TempArray(73) += AvgSal.Text
            Case 8 :
                ResetValues(temparray(79))
                TempArray(79) += AvgSal.Text
            Case 9 :
                ResetValues(temparray(85))
                TempArray(85) += AvgSal.Text
            Case 10 :
                ResetValues(temparray(91))
                TempArray(91) += AvgSal.Text
            Case 11 :
                ResetValues(temparray(97))
                TempArray(97) += AvgSal.Text
            Case 12 :
                ResetValues(temparray(103))
                TempArray(103) += AvgSal.Text
            Case 13 :
                ResetValues(temparray(109))
                TempArray(109) += AvgSal.Text
            Case 14 :
                ResetValues(temparray(115))
                TempArray(115) += AvgSal.Text
            Case 15 :
                ResetValues(temparray(121))
                TempArray(121) += AvgSal.Text
        End Select
    End Sub

    Private Sub BackUpSal_OnLostFocus(sender As Object, e As RoutedEventArgs)
        Dim num = CInt(BackUpSal.Text)
        BackUpSal.Text = num.ToString("N0")
        select case PosConValues.SelectedIndex
            Case 0 :
                ResetValues(temparray(32))
                TempArray(32) += BackUpSal.Text
            Case 1 :
                ResetValues(temparray(38))
                TempArray(38) += BackUpSal.Text
            Case 2 :
                ResetValues(temparray(44))
                TempArray(44) += BackUpSal.Text
            Case 3 :
                ResetValues(temparray(50))
                TempArray(50) += BackUpSal.Text
            Case 4 :
                ResetValues(temparray(56))
                TempArray(56) += BackUpSal.Text
            Case 5 :
                ResetValues(temparray(62))
                TempArray(62) += BackUpSal.Text
            Case 6 :
                ResetValues(temparray(68))
                TempArray(68) += BackUpSal.Text
            Case 7 :
                ResetValues(temparray(74))
                TempArray(74) += BackUpSal.Text
            Case 8 :
                ResetValues(temparray(80))
                TempArray(80) += BackUpSal.Text
            Case 9 :
                ResetValues(temparray(86))
                TempArray(86) += BackUpSal.Text
            Case 10 :
                ResetValues(temparray(92))
                TempArray(92) += BackUpSal.Text
            Case 11 :
                ResetValues(temparray(98))
                TempArray(98) += BackUpSal.Text
            Case 12 :
                ResetValues(temparray(104))
                TempArray(104) += BackUpSal.Text
            Case 13 :
                ResetValues(temparray(110))
                TempArray(110) += BackUpSal.Text
            Case 14 :
                ResetValues(temparray(116))
                TempArray(116) += BackUpSal.Text
            Case 15 :
                ResetValues(temparray(122))
                TempArray(122) += BackUpSal.Text
        End Select
    End Sub

    Private Sub DepthSal_OnLostFocus(sender As Object, e As RoutedEventArgs)
        Dim num = CInt(DepthSal.Text)
        DepthSal.Text = num.ToString("N0")
        select case PosConValues.SelectedIndex
            Case 0 :
                ResetValues(temparray(33))
                TempArray(33) += DepthSal.Text
            Case 1 :
                ResetValues(temparray(39))
                TempArray(39) += DepthSal.Text
            Case 2 :
                ResetValues(temparray(45))
                TempArray(45) += DepthSal.Text
            Case 3 :
                ResetValues(temparray(51))
                TempArray(51) += DepthSal.Text
            Case 4 :
                ResetValues(temparray(57))
                TempArray(57) += DepthSal.Text
            Case 5 :
                ResetValues(temparray(63))
                TempArray(63) += DepthSal.Text
            Case 6 :
                ResetValues(temparray(69))
                TempArray(69) += DepthSal.Text
            Case 7 :
                ResetValues(temparray(75))
                TempArray(75) += DepthSal.Text
            Case 8 :
                ResetValues(temparray(81))
                TempArray(81) += DepthSal.Text
            Case 9 :
                ResetValues(temparray(87))
                TempArray(87) += DepthSal.Text
            Case 10 :
                ResetValues(temparray(93))
                TempArray(93) += DepthSal.Text
            Case 11 :
                ResetValues(temparray(99))
                TempArray(99) += DepthSal.Text
            Case 12 :
                ResetValues(temparray(105))
                TempArray(105) += DepthSal.Text
            Case 13 :
                ResetValues(temparray(111))
                TempArray(111) += DepthSal.Text
            Case 14 :
                ResetValues(temparray(117))
                TempArray(117) += DepthSal.Text
            Case 15 :
                ResetValues(temparray(123))
                TempArray(123) += DepthSal.Text
        End Select
    End Sub

    Private Sub StartingYear_TextChanged(sender As Object, e As TextChangedEventArgs)
        SetArray(0) = ResetValues(SetArray(0))
        SetArray(0) += StartingYear.text
    End Sub

    Private Sub LeagueRules_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        SetArray(1) = ResetValues(SetArray(1))
        SetArray(1) += LeagueRules.SelectedItem.Tag.ToString()
    End Sub

    Private Sub LeagueType_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        SetArray(2) = ResetValues(SetArray(2))
        SetArray(2) += LeagueType.Selecteditem.tag.ToString()
    End Sub

    Private Sub RosterSize_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        if setarray(3) <> "" Then
            SetArray(3) = ResetValues(SetArray(3))
        end if
        SetArray(3) += RosterSize.SelectedItem.Tag.ToString()
    End Sub

    Private Sub GameInactives_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        SetArray(4) = ResetValues(SetArray(4))
        SetArray(4) += GameInactives.SelectedItem.Tag.ToString()
    End Sub

    Private Sub PracSquad_OnSelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        SetArray(5) = ResetValues(SetArray(5))
        SetArray(5) += PracSquad.SelectedItem.Tag.ToString()
    End Sub

    Private Sub OTFormat_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        SetArray(6) = ResetValues(SetArray(6))
        SetArray(6) += OTFormat.Selecteditem.tag.ToString()
    End Sub

    Private Sub FieldType_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        setarray(7) = ResetValues(SetArray(7))
        SetArray(7) += FieldType.Selecteditem.tag.ToString()
    End Sub

    Private Sub PenaltyValue_TextChanged(sender As Object, e As TextChangedEventArgs)
        if SetArray(8) <> "" Then
            SetArray(8) = ResetValues(SetArray(8))
        end if
        SetArray(8) += PenaltyValue.text
    End Sub

    Private Sub NumTeams_TextChanged(sender As Object, e As TextChangedEventArgs)
        setarray(9) = ResetValues(SetArray(9))
        SetArray(9) += NumTeams.Text
    End Sub

    Private Sub NumConf_TextChanged(sender As Object, e As TextChangedEventArgs)
        SetArray(10) = ResetValues(SetArray(10))
        SetArray(10) += NumConf.Text
    End Sub

    Private Sub NumDivs_TextChanged(sender As Object, e As TextChangedEventArgs)
        setarray(11) = ResetValues(SetArray(11))
        SetArray(11) += NumDivs.Text
    End Sub

    Private Sub ChkBxFantasyDraft_Checked(sender As Object, e As RoutedEventArgs)
        SetArray(12) = ResetValues(SetArray(12))
        SetArray(12) += "True"
    End Sub

    Private Sub ChkBxFantasyDraft_Unchecked(sender As Object, e As RoutedEventArgs)
        SetArray(12) = ResetValues(SetArray(12))
        SetArray(12) += "False"
    End Sub

    Private Sub ChkBxFired_Checked(sender As Object, e As RoutedEventArgs)
        SetArray(13) = ResetValues(SetArray(13))
        SetArray(13) += "True"
    End Sub

    Private Sub ChkBxFired_Unchecked(sender As Object, e As RoutedEventArgs)
        setarray(13) = ResetValues(SetArray(13))
        SetArray(13) += "False"
    End Sub

    Private Sub ChkBxExpansion_Checked(sender As Object, e As RoutedEventArgs)
        SetArray(14) = ResetValues(SetArray(14))
        SetArray(14) += "True"
    End Sub

    Private Sub ChkBxExpansion_Unchecked(sender As Object, e As RoutedEventArgs)
        SetArray(14) = ResetValues(SetArray(14))
        SetArray(14) += "False"
    End Sub

    Private Sub ChkBxRelocation_Checked(sender As Object, e As RoutedEventArgs)
        SetArray(15) = ResetValues(SetArray(15))
        SetArray(15) += "True"
    End Sub

    Private Sub ChkBxRelocation_Unchecked(sender As Object, e As RoutedEventArgs)
        SetArray(15) = ResetValues(SetArray(15))
        SetArray(15) += "False"
    End Sub

    Private Sub ChkBxAllowFA_Checked(sender As Object, e As RoutedEventArgs)
        SetArray(16) = ResetValues(SetArray(16))
        SetArray(16) += "True"
    End Sub

    Private Sub ChkBxAllowFA_Unchecked(sender As Object, e As RoutedEventArgs)
        SetArray(16) = ResetValues(SetArray(16))
        SetArray(16) += "False"
    End Sub

    Private Sub ChkBxCollegeDraft_Checked(sender As Object, e As RoutedEventArgs)
        SetArray(17) = ResetValues(SetArray(17))
        SetArray(17) += "True"
    End Sub

    Private Sub ChkBxCollegeDraft_Unchecked(sender As Object, e As RoutedEventArgs)
        SetArray(17) = ResetValues(SetArray(17))
        SetArray(17) += "False"
    End Sub

    Private Sub NumDraftRounds_TextChanged(sender As Object, e As TextChangedEventArgs)
        if SetArray(18) <> "" Then
            SetArray(18) = ResetValues(SetArray(18))
        end if
        SetArray(18) += NumDraftRounds.Text
    End Sub

    Private Sub ChkBxSupDraft_Checked(sender As Object, e As RoutedEventArgs)
        SetArray(19) = ResetValues(SetArray(19))
        SetArray(19) += "True"
    End Sub

    Private Sub ChkBxSupDraft_Unchecked(sender As Object, e As RoutedEventArgs)
        setarray(19) = ResetValues(SetArray(19))
        SetArray(19) += "False"
    End Sub

    Private Sub ChkBxCompPicks_Checked(sender As Object, e As RoutedEventArgs)
        SetArray(20) = ResetValues(SetArray(20))
        SetArray(20) += "True"
    End Sub

    Private Sub ChkBxCompPicks_Unchecked(sender As Object, e As RoutedEventArgs)
        SetArray(20) = ResetValues(SetArray(20))
        SetArray(20) += "False"
    End Sub

    Private Sub LoadSettings
        if DoOnce = False
            dim i as integer
            dim mystring as string
            using SR = New StreamReader(CurDir + "\GLSsettings.txt")
                mystring = SR.Readline
                While mystring <> "LEAGUE FINANCE SETTINGS" 'sets a loop until it reaches the proper line
                    mystring = SR.ReadLine()
                    SetArray(i) = mystring
                    i += 1
                End While
                i = 0
                Do While SR.EndOfStream = False 'reads to end of file from this point          
                    TempArray(i) = SR.ReadLine
                    i += 1
                Loop
                DoOnce = True
            end using
        end if
    End Sub

    Private Sub TabFinances_GotFocus(sender As Object, e As RoutedEventArgs)
    End Sub

    private Function ResetValues(tempstring As string) As string
        dim myIndex as integer
        myIndex = tempstring.IndexOf("=")
        If myIndex <> tempstring.Length - 1 Then
            myIndex = tempstring.IndexOf("=") + 1
            tempstring = tempstring.Remove(myIndex)
        end if
        Return tempstring
    End Function

    ''' <summary>
    '''     Writes changes to settings file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LgFinAcceptBtn_Click(sender As Object, e As RoutedEventArgs)
        dim DelFile as String = CurDir + "\GLSsettings.text" 'deletes current settings file and replaces with new one
        if File.Exists(DelFile) Then
            File.delete(DelFile)
        End If

        using SW = New StreamWriter(CurDir + "\GLSsettings.text")
            SW.WriteLine("OVERALL LEAGUE SETTINGS")
            for i = 0 to SetArray.Count - 1
                SW.WriteLine(SetArray(i))
            Next i
            for i = 0 To TempArray.Count - 1
                SW.WriteLine(TempArray(i))
            Next i
        end using
    End Sub


    ''' <summary>
    '''     resets settings to default settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LgFinResetBtn_Click(sender As Object, e As RoutedEventArgs)
        dim i as integer
        using SR = New StreamReader(CurDir + "\GLSDefaultSettings.txt")
            While SR.ReadLine <> "LEAGUE FINANCE SETTINGS" 'sets a loop until it reaches the proper line           
                SetArray(i) = SR.ReadLine
                i += 1
            End While
            i = 0
            Do While SR.EndOfStream = False 'reads to end of file from this point          
                TempArray(i) = SR.ReadLine
                i += 1
            Loop
        end using

        i = 0
        using SW = New StreamWriter(CurDir + "\GLSsettings.text")
            SW.WriteLine("OVERALL LEAGUE SETTINGS")
            for i = 0 to SetArray.Count - 1
                SW.WriteLine(SetArray(i))
            Next i

            SW.WriteLine("LEAGUE FINANCE SETTINGS")
            for i = 0 To TempArray.Count - 1
                SW.WriteLine(TempArray(i))
            Next i
        end using
    End Sub
End Class
