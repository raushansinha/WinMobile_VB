Namespace NWA.Safetrac.Scanner.BO

    ''' <summary>
    ''' This class contains the format validation methods that are rquired across the 
    ''' Safetrac Business Objects
    ''' </summary>
    ''' <remarks></remarks>
    Public Module Validate

        ''' <summary>
        ''' Determine if given string is alphabetic (not alphanum); does
        ''' not include punctuation, unprintables, etc.; uses ASCII values
        ''' </summary>
        ''' <param name="alphaString"></param>
        ''' <returns>True if alpha, false otherwise</returns>
        ''' <remarks></remarks>
        Public Function IsAlpha(ByVal alphaString As String) As Boolean
            Dim intPos As Integer
            Dim intAscii As Integer
            For intPos = 0 To alphaString.Length - 1
                intAscii = Asc(alphaString.Substring(intPos, 1))
                If intAscii < 65 Or intAscii > 123 Then
                    Return False
                ElseIf intAscii >= 91 And intAscii <= 96 Then
                    Return False
                End If
            Next
            Return True
        End Function

        Public Function GetAirlineCode(ByVal flightNum As String) As String
            If IsAlpha(flightNum.Substring(0, 2)) Then
                Return flightNum.Substring(0, 2)
            ElseIf IsNumeric(flightNum) Then
                Return "NW"
            End If
        End Function

        Public Function GetFlightNum(ByVal flightNum As String) As String
            If IsAlpha(flightNum.Substring(0, 2)) Then
                Return flightNum.Substring(2)
            ElseIf IsNumeric(flightNum) Then
                Return flightNum
            End If
        End Function

        ''' <summary>
        ''' Determine if given string is alphanumeric does
        ''' not include punctuation, unprintables, etc. uses ASCII values
        ''' </summary>
        ''' <param name="alphaNumString"></param>
        ''' <returns>True if alphanumeric, false otherwise</returns>
        ''' <remarks></remarks>
        Public Function IsAlphaNum(ByVal alphaNumString As String) As Boolean
            Dim intPos As Integer
            Dim intAscii As Integer

            For intPos = 0 To alphaNumString.Length - 1
                intAscii = Asc(alphaNumString.Substring(intPos, 1))
                If intAscii < 48 Or intAscii > 123 Then
                    Return False
                ElseIf intAscii >= 91 And intAscii <= 96 Then
                    Return False
                ElseIf intAscii >= 58 And intAscii <= 64 Then
                    Return False
                End If
            Next
            Return True
        End Function

        ''' <summary>
        ''' To check the format of the Bagtag number entered by the user
        ''' </summary>
        ''' <param name="BagtagNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks> 
        Public Function IsBagtagValid(ByRef bagtagNum As String) As BagTagReturnCodes
            Return IsBagtagValid(bagtagNum, False)
        End Function


        ''' <summary>
        ''' To check the format of the Bagtag number entered by the user
        ''' </summary>
        ''' <param name="bagtagNum"></param>
        ''' <param name="holdSwitch"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsBagtagValid(ByRef bagtagNum As String, ByVal holdSwitch As Boolean) _
                        As BagTagReturnCodes
            ' GIVEN: Bagtag to check for validity, allow hold/uld switches
            ' TASK: Determine if given bagtag is syntactically valid; may also be a hold/ULD switch
            ' RETURN: < 10 = valid, >= 100 otherwise

            Dim retCode As BagTagReturnCodes

            Select Case bagtagNum.Length
                Case 1
                    ' ----------------------------
                    ' User may want to switch bins
                    ' ----------------------------
                    If holdSwitch Then
                        If IsNumeric(bagtagNum) Then
                            If Convert.ToInt16(bagtagNum) >= BagtagBinLow And Convert.ToInt16(bagtagNum) <= BagtagBinHigh Then
                                ' MsgBox "DebugOFF: Len = 1, BAGTAG_SWITCH_BIN"
                                retCode = BagTagReturnCodes.BagtagSwitchBin
                            Else
                                ' MsgBox "DebugOFF: Len = 1, BAGTAG_INVALID_BIN"
                                retCode = BagTagReturnCodes.BagtagInvalidBin
                            End If
                        Else
                            ' MsgBox "DebugOFF: Len = 1, BAGTAG_INVALID_GENERAL"
                            retCode = BagTagReturnCodes.BagtagInvalidGeneral
                        End If
                    Else
                        ' MsgBox "DebugOFF: Len = 1, BAGTAG_INVALID_NOSWITCH"
                        retCode = BagTagReturnCodes.BagtagInvalidNoSwitch
                    End If

                Case 2
                    ' --------------------------------------
                    ' User may want to switch bulk locations
                    ' --------------------------------------
                    If holdSwitch Then
                        If IsNumeric(bagtagNum) Then
                            If CInt(bagtagNum) >= BagtagBulkLow And CInt(bagtagNum) <= BagtagBulkHigh Then
                                ' MsgBox "DebugOFF: Len = 2, BAGTAG_SWITCH_BULK"
                                retCode = BagTagReturnCodes.BagtagSwitchBulk
                            Else
                                ' MsgBox "DebugOFF: Len = 2, BAGTAG_INVALID_BULK"
                                retCode = BagTagReturnCodes.BagtagInvalidBulk
                            End If
                        Else
                            ' MsgBox "DebugOFF: Len = 2, BAGTAG_INVALID_GENERAL"
                            retCode = BagTagReturnCodes.BagtagInvalidGeneral
                        End If
                    Else
                        ' MsgBox "DebugOFF: Len = 2, BAGTAG_INVALID_NOSWITCH"
                        retCode = BagTagReturnCodes.BagtagInvalidNoSwitch
                    End If

                Case 6
                    ' ---------------------------------------------------
                    ' User entered bagtag number without the airline code
                    ' ---------------------------------------------------
                    If Not IsNumeric(Left(bagtagNum, 1)) Then
                        ' MsgBox "DebugOFF: Len = 6, BAGTAG_INVALID_GENERAL"
                        retCode = BagTagReturnCodes.BagtagInvalidGeneral
                    Else
                        If IsNumeric(bagtagNum) Then
                            ' MsgBox "DebugOFF: Len = 6, BAGTAG_VALID"
                            IsBagtagValid = BagTagReturnCodes.BagtagValid
                            bagtagNum = "NW" & bagtagNum
                        Else
                            ' MsgBox "DebugOFF: Len = 6, BAGTAG_INVALID_GENERAL 2"
                            retCode = BagTagReturnCodes.BagtagInvalidGeneral
                        End If
                    End If

                Case 7, 9
                    ' ----------------------------------------------------
                    ' User entered actual container number to switch holds
                    ' ----------------------------------------------------
                    If holdSwitch Then
                        ' MsgBox "DebugOFF: Len = 7/9, checking container"
                        Dim retCodeCont As ContainerReturnCodes
                        retCodeCont = IsContainerNameValid(bagtagNum)

                        Select Case retCodeCont
                            Case ContainerReturnCodes.ContainerValidActual, ContainerReturnCodes.ContainerValidSubst
                                ' Switch container
                                ' MsgBox "DebugOFF: Len = 7/9, BAGTAG_SWITCH_CONT"
                                retCode = BagTagReturnCodes.BagtagSwitchContainer

                            Case ContainerReturnCodes.ContainerInvalidGeneral
                                ' MsgBox "DebugOFF: Len = 7/9, BAGTAG_INVALID_GENERAL"
                                retCode = BagTagReturnCodes.BagtagInvalidGeneral

                            Case ContainerReturnCodes.ContainerInvalidTooShort
                                ' MsgBox "DebugOFF: Len = 7/9, BAGTAG_INVALID_GENERAL"
                                retCode = BagTagReturnCodes.BagtagInvalidGeneral


                        End Select
                    Else
                        ' MsgBox "DebugOFF: Len = 7/9, BAGTAG_INVALID_NOSWITCH"

                        'When entering 7 or 9 digits for bag tag, the error message displayed is "CNT SWITCH HOLDS" Should read
                        '"INVALID TAG FMT". Refer to AOT defect log 229
                        retCode = BagTagReturnCodes.BagtagInvalidGeneral
                    End If

                Case 8
                    ' ------------------------------------
                    ' User entered container or bag number
                    ' ------------------------------------

                    ' If the third char is a number, then its a bag
                    If IsNumeric(bagtagNum.Substring(2, 1)) Then
                        ' MsgBox "DebugOFF: Len = 8, numeric, bagtag"
                        If IsAlpha(Left(bagtagNum, 1)) Or IsAlpha(bagtagNum.Substring(1, 1)) Then
                            ' If any of the following are alpha, then invalid
                            If Not IsNumeric(bagtagNum.Substring(2)) Then
                                ' MsgBox "DebugOFF: Len = 8, BAGTAG_INVALID_GENERAL"
                                retCode = BagTagReturnCodes.BagtagInvalidGeneral
                            Else
                                ' MsgBox "DebugOFF: Len = 8, BAGTAG_VALID"
                                retCode = BagTagReturnCodes.BagtagValid
                            End If
                        Else
                            ' MsgBox "DebugOFF: Len = 8, BAGTAG_INVALID_GENERAL 2"
                            retCode = BagTagReturnCodes.BagtagInvalidGeneral
                        End If
                    Else
                        ' MsgBox "DebugOFF: Len = 8, non-numeric"
                        ' 3rd char not a digit, could be an actual container number
                        If holdSwitch Then

                            Dim retCodeCont As ContainerReturnCodes
                            retCodeCont = IsContainerNameValid(bagtagNum)

                            Select Case retCodeCont
                                Case ContainerReturnCodes.ContainerValidActual, ContainerReturnCodes.ContainerValidSubst
                                    ' Switch container
                                    ' MsgBox "DebugOFF: Len = 8, BAGTAG_SWITCH_CONT"
                                    retCode = BagTagReturnCodes.BagtagSwitchContainer

                                Case ContainerReturnCodes.ContainerInvalidGeneral
                                    ' MsgBox "DebugOFF: Len = 8, CONT_INVALID_GENERAL"
                                    retCode = BagTagReturnCodes.ContainerInvalidGeneral

                                Case ContainerReturnCodes.ContainerInvalidTooShort
                                    ' MsgBox "DebugOFF: Len = 8, CONT_INVALID_TOOSHORT"
                                    retCode = BagTagReturnCodes.ContainerInvalidTooShort

                                    '                        Case CONT_INVALID_BODYTYPE:
                                    '                            ' Want to return a useful message to user about this
                                    '                            ' MsgBox "DebugOFF: Len = 8, CONT_INVALID_BODYTYPE"
                                    '                            IsBagtagValid = CONT_INVALID_BODYTYPE
                            End Select
                        Else
                            ' MsgBox "DebugOFF: Len = 8, BAGTAG_INVALID_NOSWITCH"
                            retCode = BagTagReturnCodes.BagtagInvalidNoSwitch
                        End If
                    End If

                Case 10
                    '// the 1st digit for bulk:4; bin:4; container:3; bag number:0,1
                    '// the 1st char is alpha if Code39 or actual container keyin
                    ' There are all sorts of case statements here, included only because the
                    ' original PBM code had it.
                    Select Case Left(bagtagNum, 1)
                        Case "1"                    ' 1 = Fallback license plate ("LP") tag
                            retCode = BagTagReturnCodes.BagtagInvalidGeneral

                        Case "3", "4"               ' 3012 = ULD Container LP tag
                            ' 4012 = Bin/bulk LP tag
                            If Left(bagtagNum, 4) = "4012" Or Left(bagtagNum, 4) = "3012" Then
                                If holdSwitch Then

                                    Dim retCodeCont As ContainerReturnCodes
                                    retCodeCont = IsContainerNameValid(bagtagNum)

                                    Select Case retCodeCont
                                        Case ContainerReturnCodes.ContainerValidActual, ContainerReturnCodes.ContainerValidSubst
                                            ' Switch container
                                            ' MsgBox "DebugOFF: Len = 8, BAGTAG_SWITCH_CONT"
                                            retCode = BagTagReturnCodes.BagtagSwitchContainer

                                        Case ContainerReturnCodes.ContainerInvalidGeneral
                                            ' MsgBox "DebugOFF: Len = 8, CONT_INVALID_GENERAL"
                                            retCode = BagTagReturnCodes.ContainerInvalidGeneral

                                        Case ContainerReturnCodes.ContainerInvalidTooShort
                                            ' MsgBox "DebugOFF: Len = 8, CONT_INVALID_TOOSHORT"
                                            retCode = BagTagReturnCodes.ContainerInvalidTooShort

                                            '                                Case CONT_INVALID_BODYTYPE:
                                            '                                    ' Want to return a useful message to user about this
                                            '                                    ' MsgBox "DebugOFF: Len = 8, CONT_INVALID_BODYTYPE"
                                            '                                    IsBagtagValid = CONT_INVALID_BODYTYPE
                                    End Select
                                Else
                                    ' MsgBox "DebugOFF: Len = 8, BAGTAG_INVALID_NOSWITCH"
                                    retCode = BagTagReturnCodes.BagtagInvalidNoSwitch
                                End If
                            Else
                                ' Valid OA bagtag
                                retCode = BagTagReturnCodes.BagtagValid
                            End If

                            '                    If bHoldSwitch Then     ' 4 = Bin/bulk LP tag
                            '                        ' Handle container switch
                            '                        IsBagtagValid = BAGTAG_SWITCH_CONT
                            '                    Else
                            '                        IsBagtagValid = BAGTAG_INVALID_NOSWITCH
                            '                    End If

                        Case "0", "2", "5", "6", "7", "8", "9"
                            ' 0 = Interline License Plate Tag
                            ' 2 = Expedite License Plate Tag
                            ' 5 = On-line License Plate Tag
                            ' 6 = Preprinted String Tag
                            ' 7 = Undefined License Plate Tag
                            ' 8 = Xfer Beyond/Xray License Plate Tag
                            ' 9 = Selectee License Plate Tag
                            ' MsgBox "DebugOFF: Len = 10, Doing LP check"
                            If holdSwitch Then
                                ' Ensure whole string is numeric
                                If IsNumeric(bagtagNum) Then
                                    retCode = BagTagReturnCodes.BagtagValid
                                Else
                                    ' MsgBox "DebugOFF: Len = 10, BAGTAG_INVALID_GENERAL 2"
                                    retCode = BagTagReturnCodes.BagtagInvalidGeneral
                                End If
                            Else
                                ' MsgBox "DebugOFF: Len = 10, BAGTAG_INVALID_NOSWITCH"
                                If IsNumeric(bagtagNum) Then
                                    retCode = BagTagReturnCodes.BagtagValid
                                Else
                                    retCode = BagTagReturnCodes.BagtagInvalidNoSwitch
                                End If
                            End If
                    End Select      ' Case Left(sBagtag, 1) for bagtag length = 10

                Case Else
                    retCode = BagTagReturnCodes.BagtagInvalidGeneral
            End Select  ' Case Len(sBagtag)
            IsBagtagValid = retCode
        End Function

        ''' <summary>
        ''' To check the format of the Container Sheet Number entered by the user
        ''' </summary>
        ''' <param name="ContainerSheetNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsContainerNumValid(ByVal containerSheetNum As String) As Boolean
            ' GIVEN: Container sheet number
            ' TASK: Determine if given sheet number is valid
            ' FORMAT: NNNNNAAANNNNN

            Dim blnReturn As Boolean

            If containerSheetNum.Length = 13 Then
                If IsNumeric(Left(containerSheetNum, 5)) And IsNumeric(Right(containerSheetNum, 5)) And _
                        IsAlpha(containerSheetNum.Substring(5, 3)) Then
                    blnReturn = True
                Else
                    blnReturn = False
                End If
            Else
                blnReturn = False
            End If
            IsContainerNumValid = blnReturn
        End Function
        ''' <summary>
        ''' To check the format of the Container Name entered by the user
        ''' </summary>
        ''' <param name="ContainerName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsContainerNameValid(ByRef containerName As String) As ContainerReturnCodes
            ' GIVEN: Container number (actual or substitute, or bin/bulk)
            ' TASK: Determine if given container is valid syntactically or not
            ' RETURNS: 0 = valid, >= 200 otherwise
            ' NOTE: May also modify given container, only to append "NW"

            ' CONTAINER (ACTUAL type) FORMAT (from original C code):
            ' Actual container 3 Alpha or Alpha-Numeric-Alpha
            ' followed by 1 Alpha/Numeric
            ' followed by 3 or 4 Numeric
            ' Data Mask A = Alpha Only  N = Numeric Only  X = Alpha/Numeric
            ' AXAXNNNXXX

            ' CONTAINER (SUBSTITUTE type) FORMAT:
            ' 3NNNNNNNNNN (container/cart)
            ' 4NNNNNNNNBB, where BB is 01 - 04, or 51 - 54 (bin/bulk)
            ' The check for 3 or 4 in the first digit is NOT enforced here.
            ' We assume that we know it is a container coming in.

            Dim retCode As ContainerReturnCodes
            Dim strTemp As String
            'Dim iTemp As Integer
            'Dim sRet As String

            ' User may have entered "BIN 1" or "BULK 52", so trim off "BIN" or "BULK"
            If Left(containerName, 3).ToUpper() = "BIN" Then
                containerName = Right(containerName, 1)
            ElseIf Left(containerName, 4).ToUpper = "BULK" Then
                containerName = Right(containerName, 2)
            End If
            If containerName.Length >= ContainerMinLength Then
                ' Container number given is numeric if scanned (or barcode is hand-entered)
                If IsNumeric(containerName) Then
                    ' --------------------------------
                    ' Barcode entered
                    ' --------------------------------
                    ' Length MUST be 10
                    If (containerName.Length = 10) And (containerName.Substring(1, 3) = "012") Then
                        If Left(containerName, 1) = "4" Then
                            Dim binBulkRet As BinBulkReturnCodes
                            binBulkRet = IsBinBulkValid(Right(containerName, 2))
                            ' MsgBox "DebugOff: BinBulkValid() = " & iRet
                            Select Case binBulkRet
                                Case BinBulkReturnCodes.BinValid, BinBulkReturnCodes.BulkValid
                                    retCode = ContainerReturnCodes.ContainerValidSubst
                                    'Case BINBULK_INVALID_BODYTYPE
                                    '    iRet = CONT_INVALID_BODYTYPE
                                Case BinBulkReturnCodes.BinBulkInvalidGeneral
                                    retCode = ContainerReturnCodes.ContainerInvalidGeneral
                            End Select
                        Else
                            retCode = ContainerReturnCodes.ContainerValidSubst
                        End If
                    Else
                        retCode = ContainerReturnCodes.ContainerInvalidGeneral
                    End If
                Else
                    ' --------------------------------
                    ' Actual container number entered
                    ' --------------------------------

                    ' First char must be alpha
                    ' MsgBox "DebugOFF: Checking 1st char"
                    If IsAlpha(Left(containerName, 1)) Then
                        ' Second char can be alphanum
                        ' MsgBox "DebugOFF: Checking 2nd char"
                        If IsAlphaNum(containerName.Substring(1, 1)) Then
                            ' Third char must be alpha only
                            ' MsgBox "DebugOFF: Checking 3rd char"
                            If IsAlpha(containerName.Substring(2, 1)) Then
                                ' Fourth char can be alphanum
                                ' MsgBox "DebugOFF: Checking 4th char"
                                If IsAlphaNum(containerName.Substring(3, 1)) Then
                                    ' Next three chars should be numbers
                                    ' MsgBox "DebugOFF: Checking 5th char"
                                    If IsNumeric(containerName.Substring(4, 3)) Then
                                        ' The rest of the chars should be alpha num
                                        ' MsgBox "DebugOFF: Checking more chars"
                                        If IsAlphaNum(containerName.Substring(7)) Then
                                            ' Not true, just taking an indentation break.
                                            ' Check continues below
                                            retCode = ContainerReturnCodes.ContainerValidActual
                                        Else
                                            retCode = ContainerReturnCodes.ContainerInvalidGeneral
                                        End If
                                    Else
                                        retCode = ContainerReturnCodes.ContainerInvalidGeneral
                                    End If
                                Else
                                    retCode = ContainerReturnCodes.ContainerInvalidGeneral
                                End If
                            Else
                                retCode = ContainerReturnCodes.ContainerInvalidGeneral
                            End If
                        Else
                            retCode = ContainerReturnCodes.ContainerInvalidGeneral
                        End If
                    Else
                        retCode = ContainerReturnCodes.ContainerInvalidGeneral
                    End If
                End If
            Else
                ' Check for bin/bulk
                If containerName.Length < 3 Then
                    'Aditya - Added newly - validation pending
                    Dim iBinBulkRet As BinBulkReturnCodes
                    iBinBulkRet = IsBinBulkValid(containerName)
                    Select Case iBinBulkRet
                        Case BinBulkReturnCodes.BinValid
                        Case BinBulkReturnCodes.BulkValid
                            'Aditya - Validate with the code
                            retCode = ContainerReturnCodes.ContainerValidActual
                        Case BinBulkReturnCodes.BinBulkInvalidBodyType
                            'Aditya - Validate with the code
                            retCode = ContainerReturnCodes.ContainerInvalidBodyType
                        Case BinBulkReturnCodes.BinBulkInvalidGeneral
                            'Aditya - Validate with the code
                            retCode = ContainerReturnCodes.ContainerInvalidGeneral
                        Case BinBulkReturnCodes.BinBulkInvalidTooLong
                            'Aditya - Validate with the code
                            retCode = ContainerReturnCodes.ContainerInvalidTooLong
                    End Select

                Else
                    retCode = ContainerReturnCodes.ContainerInvalidTooShort
                End If
            End If

            ' ---------------------------------
            ' Continuing very long syntax check
            ' ---------------------------------

            ' MsgBox "DebugOFF: iRet = " & iRet

            If retCode = ContainerReturnCodes.ContainerValidActual Then
                If containerName.Length > 8 Then
                    ' User keyed in airline code, e.g. "NW", so one of these chars
                    ' must be alpha:
                    strTemp = Right(containerName, 2)
                    If IsAlpha(Left(strTemp, 1)) Or IsAlpha(Right(strTemp, 1)) Then
                        ' ELIMINATED BODY TYPE CHECK
                        retCode = ContainerReturnCodes.ContainerValidActual
                    Else
                        retCode = ContainerReturnCodes.ContainerInvalidGeneral
                    End If

                Else
                    If (containerName.Length = 8) And (IsAlpha(Right(containerName, 1))) Then
                        ' Straight from the old PBM Code:
                        ' // Odd case where  AAANNNxx was entered
                        ' // and xx is airline code that starts w/ a number
                        retCode = ContainerReturnCodes.ContainerValidActual
                    Else
                        ' ELIMINATED BODY TYPE CHECK
                        containerName = containerName & "NW"
                        retCode = ContainerReturnCodes.ContainerValidActual
                    End If
                End If
            End If
            IsContainerNameValid = retCode
        End Function

        ''' <summary>
        ''' To check the format of the Mail Number entered by the user
        ''' </summary>
        ''' <param name="MailNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsMailValid(ByVal mailNum As String) As MailReturnCodes
            ' GIVEN: String containing barcode
            ' TASK: Verify given barcode as a mail barcode

            'Dim iRet As MailReturnCodes

            ' Data Mask A = Alpha Only  N = Numeric Only  X = Alpha/Numeric

            ' INTL Mail:
            ' AAAAAAAAAAAAAAANNNNNNNNNNNNNN

            ' DOM Mail:
            ' 07/16/03 final two chars are now weight
            ' AAAAXXXXNN
            ' NNNANNNNNN

            ' XXX%XXXXNN
            ' XXX$XXXXNN
            ' XXXAXXXXNN
            ' XXXXXXXXAX

            ' EMERY MAIL:
            ' XXX#XXXXNN

            ' OR, could be a keyed bin/bulk or scanned bin/bulk

            Dim retCode As MailReturnCodes

            Select Case Trim(mailNum).Length

                Case 29
                    ' Check for FOR mail
                    If IsAlpha(Left(mailNum, 15)) And IsNumeric(Right(mailNum, 14)) Then
                        retCode = MailReturnCodes.MailForeignOk
                    Else
                        retCode = MailReturnCodes.MailInvalid
                    End If

                Case 10
                    ' Check for EMERY barcode
                    If mailNum.Substring(3, 1) = "#" Then
                        If IsNumeric(Right(mailNum, 2)) Then
                            retCode = MailReturnCodes.MailEmeOk
                        Else
                            retCode = MailReturnCodes.MailInvalid
                        End If

                    ElseIf Left(mailNum, 1) = "4" Then
                        ' Switching to different bin/bulk
                        Dim retCodeBin As BinBulkReturnCodes

                        retCodeBin = IsBinBulkValid(Right(mailNum, 2))

                        Select Case retCodeBin
                            Case BinBulkReturnCodes.BinValid
                                retCode = MailReturnCodes.MailSwitchBin

                            Case BinBulkReturnCodes.BulkValid
                                retCode = MailReturnCodes.MailSwitchBulk

                        End Select
                    End If

                Case 12
                    ' Domestic 10-character code
                    If mailNum.Substring(3, 1) = "%" Or _
                       mailNum.Substring(3, 1) = "$" Then

                        If IsNumeric(Right(mailNum, 2)) Then
                            retCode = MailReturnCodes.MailDomesticOk
                        Else
                            retCode = MailReturnCodes.MailInvalid
                        End If
                    Else
                        If IsAlpha(mailNum.Substring(3, 1)) And _
                            IsNumeric(Right(mailNum, 2)) Then

                            retCode = MailReturnCodes.MailDomesticOk
                        Else
                            ' 9th char must be alpha
                            If IsAlpha(mailNum.Substring(8, 1)) And IsNumeric(Right(mailNum, 2)) Then
                                retCode = MailReturnCodes.MailDomesticOk
                            Else
                                retCode = MailReturnCodes.MailInvalid
                            End If

                        End If

                    End If

                Case 8
                    ' Check for domestic
                    If IsAlpha(Left(mailNum, 4)) Then
                        IsMailValid = MailReturnCodes.MailDomesticOk
                    Else
                        If IsNumeric(Left(mailNum, 3)) And _
                           IsNumeric(Right(mailNum, 4)) And _
                           IsAlpha(mailNum.Substring(3, 1)) Then

                            retCode = MailReturnCodes.MailDomesticOk
                        Else
                            retCode = MailReturnCodes.MailInvalid
                        End If
                    End If

                Case 2
                    ' --------------------------------------
                    ' User may want to switch bulk locations
                    ' --------------------------------------
                    Dim iBinBulkRet As BinBulkReturnCodes
                    iBinBulkRet = IsBinBulkValid(mailNum)

                    Select Case iBinBulkRet
                        Case BinBulkReturnCodes.BulkValid, BinBulkReturnCodes.BinValid
                            retCode = MailReturnCodes.MailSwitchBulk

                        Case Else
                            retCode = MailReturnCodes.MailInvalidBulk

                    End Select

                Case 1
                    ' --------------------------------------
                    ' User may want to switch bin locations
                    ' --------------------------------------
                    Dim iBinBulkRet As BinBulkReturnCodes
                    iBinBulkRet = IsBinBulkValid(mailNum)

                    Select Case iBinBulkRet
                        Case BinBulkReturnCodes.BulkValid, BinBulkReturnCodes.BinValid
                            retCode = MailReturnCodes.MailSwitchBin

                        Case Else
                            retCode = MailReturnCodes.MailInvalidBin

                    End Select

                Case Else
                    'Check if this return is valid - Aditya
                    'IsMailNumFormatValid = False
                    retCode = MailReturnCodes.MailInvalid
            End Select
            IsMailValid = retCode
        End Function
        ''' <summary>
        ''' To check if the weight entered by the user is a valid weight
        ''' </summary>
        ''' <param name="weight"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function IsMailWeightValid(ByVal weight As String) As Boolean

            ' TASK: Return TRUE/FALSE if mail weight is valid/invalid
            ' Allow for "K" for "kilogram"
            Dim retCode As Boolean
            Dim strTemp As String

            If Right(weight, 1).ToUpper = "K" Then
                strTemp = weight.Substring(0, weight.Length - 1)
            Else
                strTemp = weight
            End If

            If IsNumeric(strTemp) Then
                retCode = True
            Else
                retCode = False
            End If
            IsMailWeightValid = retCode
        End Function
        ''' <summary>
        ''' To validate is the date entered by the user is a valid NWA date
        ''' </summary>
        ''' <param name="nwaDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function IsNWADateValid(ByRef nwaDate As String) As Boolean

            ' GIVEN: Date in DDMON format
            ' TASK: Determine if given date is in valid DDMON format,
            '           and MON is valid.
            ' RETURNS: True = valid date, False otherwise
            Dim strTemp As String = String.Empty
            Dim strDay As String
            Dim strMonth As String
            Dim blnMonthValid As Boolean
            Dim blnDayValid As Boolean

            If LTrim(RTrim(nwaDate)).Length < 4 Then
                IsNWADateValid = False
            ElseIf Trim(nwaDate).Length = 4 Then
                strDay = Left(nwaDate, 1)
                strMonth = UCase(Right(nwaDate, 3))
                If IsNumeric(strDay) Then
                    blnDayValid = True
                Else
                    blnDayValid = False
                End If
                Select Case strMonth
                    Case "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"
                        blnMonthValid = True
                    Case Else
                        blnMonthValid = False
                End Select
                If blnDayValid And blnMonthValid Then
                    strTemp = "0" & nwaDate
                    strTemp = Right(strTemp, 5)
                    nwaDate = strTemp.ToUpper
                    IsNWADateValid = True
                Else
                    IsNWADateValid = False
                End If
            ElseIf Trim(nwaDate).Length = 5 Then
                strDay = Left(nwaDate, 2)
                strMonth = Right(nwaDate, 3).ToUpper
                If IsNumeric(strDay) Then
                    blnDayValid = True
                Else
                    blnDayValid = False
                End If
                Select Case strMonth
                    Case "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"
                        blnMonthValid = True
                    Case Else
                        blnMonthValid = False
                End Select
                If blnDayValid And blnMonthValid Then
                    If IsDate(MonthNameToNum(strMonth) & "-" & strDay & "-" & CStr(Year(Now))) Then
                        nwaDate = nwaDate.ToUpper
                        IsNWADateValid = True
                    Else
                        IsNWADateValid = False
                    End If
                Else
                    IsNWADateValid = False
                End If
            Else
                IsNWADateValid = False
            End If


        End Function

        ''' <summary>
        ''' To check the format of the Freight Number entered by the user
        ''' </summary>
        ''' <param name="FreightNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsAWBValid(ByRef freightNum As String) As AWBReturnCodes
            ' TASK: Determine if given value is a valid air waybill number

            Dim intRetVal As AWBReturnCodes

            ' For example purposes, use AWB: 0121122334400001

            Select Case freightNum.Length
                Case 8
                    ' e.g. 11223344
                    freightNum = "012" & freightNum & "00001"
                    intRetVal = AWBReturnCodes.AWBValid

                Case 11
                    ' e.g. 01211223344
                    freightNum = freightNum & "00001"
                    intRetVal = AWBReturnCodes.AWBValid

                Case 16
                    ' e.g. 0121122334400001
                    intRetVal = AWBReturnCodes.AWBValid

                Case Else
                    intRetVal = AWBReturnCodes.AWBInvalid
            End Select

            IsAWBValid = intRetVal
        End Function

        ''' <summary>
        ''' To check the format of the Flight Number entered by the user
        ''' </summary>
        ''' <param name="FlightNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsNWAFlightValid(ByRef flightNum As String) As Boolean
            ' GIVEN: String to check for date format
            ' TASK: Validate the flight given is valid format (A = alpha, N = number):
            '       1. AANNNN  -- e.g. CO6019
            '       2. N* -- e.g. 19 = NW0019, 353 = NW0353

            Dim blnRetVal As Boolean
            Dim strAC As String

            flightNum = Trim(flightNum)

            ' MsgBox "DebugOff: Checking flight = >" & sFlt & "<"

            If flightNum.Length >= 1 And flightNum.Length <= 6 Then
                If IsNumeric(flightNum) Then
                    ' Ensure no longer than 4-digits, no less than one
                    If flightNum.Length <= 4 Then
                        flightNum = Validate.ToFourDigitFltNum(flightNum)
                        flightNum = "NW" & flightNum
                        blnRetVal = True
                    Else
                        blnRetVal = False
                    End If
                Else
                    ' Alpha in there, make sure AC is formatted as AA or AN,
                    ' and ensure the user entered more than one digit for flight.
                    ' e.g. valid = "NW9" (NW0009)  invalid = "KL"   invalid = "3W"
                    If IsAlpha(Left(flightNum, 1)) And flightNum.Length > 2 Then
                        ' Take first two chars off for airline code, 4-digit-format
                        '   the remainder.
                        strAC = Left(flightNum, 2)                 ' Strip AC
                        flightNum = flightNum.Substring(2)                 ' Get remainder
                        flightNum = strAC & Validate.ToFourDigitFltNum(flightNum)     ' Format remainder, prepend AC
                        blnRetVal = True
                    Else
                        ' Cannot start airline code with number
                        blnRetVal = False
                    End If
                End If
            Else
                ' Can't have 0 length
                blnRetVal = False
            End If

            IsNWAFlightValid = blnRetVal

        End Function

        ''' <summary>
        ''' To check the format of the User ID entered by the user
        ''' </summary>
        ''' <param name="UserID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsUserIDFormatValid(ByVal userID As String) As Boolean

        End Function

        ''' <summary>
        ''' To validate if the bin bulk number entered by the user is valid
        ''' </summary>
        ''' <param name="binbulkNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsBinBulkValid(ByVal binbulkNum As String) As BinBulkReturnCodes
            ' GIVEN: Bin/bulk location to validate
            ' TASK: Decide if given location is a valid bin or bulk location.
            '       Tells calling function what type it is, if needed.
            ' RETURNS: 300/301 = success, > 301 otherwise

            Dim intBinBulk As Integer
            Dim retCode As BinBulkReturnCodes

            If binbulkNum.Length > 2 Then
                IsBinBulkValid = BinBulkReturnCodes.BinBulkInvalidTooLong
            Else
                If IsNumeric(binbulkNum) Then
                    intBinBulk = Convert.ToInt16(binbulkNum)
                    ' Check range
                    If intBinBulk >= 51 And intBinBulk <= 54 Then
                        ' ELIMINATED BODY TYPE CHECK
                        retCode = BinBulkReturnCodes.BulkValid
                    ElseIf intBinBulk >= 1 And intBinBulk <= 4 Then
                        ' ELIMINATED BODY TYPE CHECK
                        retCode = BinBulkReturnCodes.BinValid
                    Else
                        retCode = BinBulkReturnCodes.BinBulkInvalidGeneral
                    End If
                Else
                    retCode = BinBulkReturnCodes.BinBulkInvalidGeneral
                End If
            End If
            IsBinBulkValid = retCode
        End Function
        ''' <summary>
        ''' To validate if the ULD Number is of valid format
        ''' </summary>
        ''' <param name="uldName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsULDNumFormatValid(ByRef uldName As String) As Boolean

            ' GIVEN: ULD
            ' TASK: Determine if given ULD is valid format, reformats string for display,
            '           if necessary
            ' RETURNS: TRUE = valid uld, FALSE = invalid

            ' VALID ULD FORMATS (A = alpha, N = number, ? = any):

            ' A?ANNNNNA?    len = 10
            ' A?ANNNNN?A    len = 10
            ' A?A?NNN?A     len = 9
            ' A?A?NNNA?     len = 9
            ' A?ANNNNN ( + "NW")    len = 8
            ' A?A?NNN ( + "NW")     len = 7
            ' ("AKE" + ) NNNNN ( + "NW")    len = 5
            ' ("AKE" + ) ?NNN ( + "NW")     len = 4
            ' ("CAR0" + ) NNN ( + "NW")     len = 3   -- that's a zero, not a letter "oh"
            ' VNNNNN (+ "NW") or KNNNNN (+ "NW")    len = 6   -- Changes to AKE or AVE
            ' VNNNN (+ "NW") or KNNNN (+ "NW")    len = 5   -- Changes to AKE or AVE

            Dim blnRet As Boolean

            ' --------------------------------------------
            ' BASE CHECKS ON INPUTTED STRING LENGTH
            ' This way is probably the most clear and straightforward for
            ' future modifications and programmers
            ' --------------------------------------------

            Select Case uldName.Length

                Case 10
                    ' CHECK FIRST THREE CHARS:
                    If IsAlpha(Left(uldName, 1)) And IsAlphaNum(uldName.Substring(1, 1)) And _
                        IsAlpha(uldName.Substring(2, 1)) Then
                        ' CHECK MIDDLE 5
                        If IsNumeric(uldName.Substring(3, 5)) Then
                            ' CHECK LAST 2 CHARS; must be "A?" or "?A"
                            If ((IsAlpha(uldName.Substring(8, 1)) And IsAlphaNum(Right(uldName, 1))) Or _
                                (IsAlpha(Right(uldName, 1)) And IsAlphaNum(uldName.Substring(8, 1)))) Then
                                blnRet = True
                            Else
                                blnRet = False
                            End If
                        Else
                            blnRet = False
                        End If
                    Else
                        blnRet = False
                    End If

                Case 9
                    ' CHECK FIRST FOUR CHARS:
                    If IsAlpha(Left(uldName, 1)) And IsAlphaNum(uldName.Substring(1, 1)) And _
                        IsAlpha(uldName.Substring(2, 1)) And IsAlphaNum(uldName.Substring(3, 1)) Then
                        ' CHECK MIDDLE 3
                        If IsNumeric(uldName.Substring(4, 3)) Then
                            ' CHECK LAST 2 CHARS; must be "A?" or "?A"
                            If ((IsAlpha(uldName.Substring(7, 1)) And IsAlphaNum(Right(uldName, 1))) Or _
                                (IsAlpha(Right(uldName, 1)) And IsAlphaNum(uldName.Substring(7, 1)))) Then
                                blnRet = True
                            Else
                                blnRet = False
                            End If
                        Else
                            blnRet = False
                        End If
                    Else
                        blnRet = False
                    End If

                Case 8
                    ' CHECK FIRST THREE CHARS:
                    If IsAlpha(Left(uldName, 1)) And IsAlphaNum(uldName.Substring(1, 1)) And _
                        IsAlpha(uldName.Substring(2, 1)) Then
                        If IsNumeric(Right(uldName, 5)) Then
                            blnRet = True
                            uldName = uldName & "NW"
                        Else
                            blnRet = False
                        End If
                    Else
                        blnRet = False
                    End If

                Case 7
                    ' CHECK FIRST FOUR CHARS:
                    If IsAlpha(Left(uldName, 1)) And IsAlphaNum(uldName.Substring(1, 1)) And _
                        IsAlpha(uldName.Substring(2, 1)) And IsAlphaNum(uldName.Substring(3, 1)) Then
                        If IsNumeric(Left(uldName, 1)) Then
                            blnRet = True
                            uldName = uldName & "NW"
                        Else
                            blnRet = False
                        End If
                    Else
                        blnRet = False
                    End If

                Case 6
                    If IsAlpha(Left(uldName, 1)) Then
                        Select Case UCase(Left(uldName, 1))
                            Case "V"
                                blnRet = True
                                uldName = "AVE" & uldName.Substring(1) & "NW"

                            Case "K"
                                blnRet = True
                                uldName = "AKE" & uldName.Substring(1) & "NW"

                            Case Else
                                blnRet = False

                        End Select
                    Else
                        blnRet = False
                    End If

                Case 5
                    ' CHECK ALL CHARS
                    If IsNumeric(uldName) Then
                        blnRet = True
                        uldName = "AKE" & uldName & "NW"
                    Else
                        ' CHECK FOR V or K shortcut
                        If IsAlpha(Left(uldName, 1)) Then
                            Select Case Left(uldName, 1).ToUpper
                                Case "V"
                                    blnRet = True
                                    uldName = "AVE" & uldName.Substring(1) & "NW"

                                Case "K"
                                    blnRet = True
                                    uldName = "AKE" & uldName.Substring(1) & "NW"

                                Case Else
                                    blnRet = False

                            End Select
                        Else
                            blnRet = False
                        End If
                    End If

                Case 4
                    ' CHECK FIRST CHAR and LAST THREE
                    If IsAlphaNum(Left(uldName, 1)) And IsNumeric(Right(uldName, 3)) Then
                        blnRet = True
                        uldName = "AKE" & uldName & "NW"
                    Else
                        blnRet = False
                    End If

                Case 3
                    ' CHECK ALL CHARS
                    If IsNumeric(uldName) Then
                        blnRet = True
                        uldName = "CAR0" & uldName & "NW"
                    Else
                        blnRet = False
                    End If

                Case Else
                    blnRet = False

            End Select

            IsULDNumFormatValid = blnRet

        End Function
        ''' <summary>
        ''' Convert the given string into a five digit date
        ''' </summary>
        ''' <param name="dateString"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function ToFiveDigitDate(ByVal dateString As String) As String

            ' GIVEN: entire 5-digit date
            ' TASK: Ensures numeric part of date has two digits
            ' RETURNS: 5-digit flight date, RJust, 0-padded

            Dim strTemp As String

            strTemp = "0" & dateString
            strTemp = Right(strTemp, 5)

            ' If only "0" is there, then just return nothing
            If strTemp = "0" Then
                strTemp = ""
            End If

            ToFiveDigitDate = strTemp

        End Function
        ''' <summary>
        ''' Convert the given string into four digit flight number
        ''' </summary>
        ''' <param name="flightNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function ToFourDigitFltNum(ByVal flightNum As String) As String

            ' GIVEN: Flight number
            ' TASK: Ensures given flight number is four digits, 0 padded
            ' RETURNS: 4-digit flight number, RJust, 0-padded

            Dim strTemp As String
            Dim intLen As Integer

            strTemp = flightNum.Trim

            strTemp = "0000" & strTemp

            ' Now trim off proper number of zeroes
            intLen = strTemp.Length

            strTemp = Right(strTemp, 4)

            ToFourDigitFltNum = strTemp

        End Function

        Function TwoDigitNumber(ByVal twoDigitNum As String) As String

            ' GIVEN: number
            ' TASK: Ensures given number is two digits, 0 padded
            ' RETURNS: 2-digit number, RJust, 0-padded

            Dim strTemp As String
            Dim intLen As Integer

            strTemp = twoDigitNum.Trim

            strTemp = "00" & strTemp

            ' Now trim off proper number of zeroes
            intLen = strTemp.Length

            strTemp = Right(strTemp, 2)

            TwoDigitNumber = strTemp

        End Function
        ''' <summary>
        ''' Convert the given month name to corresponding month number
        ''' </summary>
        ''' <param name="monthName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MonthNameToNum(ByVal monthName As String) As String
            Select Case Left(monthName, 3).ToUpper
                Case "JAN"
                    MonthNameToNum = "01"
                Case "FEB"
                    MonthNameToNum = "02"
                Case "MAR"
                    MonthNameToNum = "03"
                Case "APR"
                    MonthNameToNum = "04"
                Case "MAY"
                    MonthNameToNum = "05"
                Case "JUN"
                    MonthNameToNum = "06"
                Case "JUL"
                    MonthNameToNum = "07"
                Case "AUG"
                    MonthNameToNum = "08"
                Case "SEP"
                    MonthNameToNum = "09"
                Case "OCT"
                    MonthNameToNum = "10"
                Case "NOV"
                    MonthNameToNum = "11"
                Case "DEC"
                    MonthNameToNum = "12"
                Case Else
                    MonthNameToNum = "00"
            End Select
        End Function
        ''' <summary>
        ''' Returns the corresponding month name based upon month number
        ''' </summary>
        ''' <param name="monthNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MonthNumToName(ByVal monthNum As Object) As String
            If IsNumeric(monthNum) Then
                Select Case Convert.ToInt64(monthNum)
                    Case 1
                        MonthNumToName = "JAN"
                    Case 2
                        MonthNumToName = "FEB"
                    Case 3
                        MonthNumToName = "MAR"
                    Case 4
                        MonthNumToName = "APR"
                    Case 5
                        MonthNumToName = "MAY"
                    Case 6
                        MonthNumToName = "JUN"
                    Case 7
                        MonthNumToName = "JUL"
                    Case 8
                        MonthNumToName = "AUG"
                    Case 9
                        MonthNumToName = "SEP"
                    Case 10
                        MonthNumToName = "OCT"
                    Case 11
                        MonthNumToName = "NOV"
                    Case 12
                        MonthNumToName = "DEC"
                End Select
            Else
                MonthNumToName = String.Empty
            End If
        End Function
        ''' <summary>
        ''' Convert the given string date into VB date
        ''' </summary>
        ''' <param name="dateString"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function NWADateToVB(ByVal dateString As String) As Date

            ' Converts a DDMMM to a VB Date
            ' If we want a "future" date, we assume it's for last year
            ' e.g. it's 1/24/00, but we enter 12DEC
            ' otherwise,
            ' e.g. it's 6/1/00, and we enter 22JUN

            Dim strMonthNum As String
            Dim strWholeDate As String

            strMonthNum = MonthNameToNum(Right(dateString, 3))

            If CInt(strMonthNum) <= Month(Now) Then
                strWholeDate = strMonthNum & "/" & Left(dateString, 2) & "/" & Convert.ToSingle(Year(Now))
            Else
                strWholeDate = strMonthNum & "/" & Left(dateString, 2) & "/" & Convert.ToSingle(Year(Now) - 1)
            End If

            NWADateToVB = CDate(strWholeDate)

        End Function
        ''' <summary>
        ''' Converts the given VB date into NWA date
        ''' </summary>
        ''' <param name="vbDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function VBDateToNWA(ByVal vbDate As Date) As String

            Dim strDate As String

            'sDate = MonthNumToName(Left(Format(CStr(dtDate), "MM/DD/YY"), 2))
            'sDate = Mid(Format(CStr(dtDate), "MM/DD/YY"), 4, 2) & sDate

            'sDate = CStr(Day(dtDate))
            strDate = vbDate.Day.ToString()

            ' Ensure we have two-char date
            If strDate.Length = 1 Then
                strDate = "0" & strDate
            End If

            ' Tack on the month name
            strDate = strDate & MonthNumToName(Month(vbDate))
            VBDateToNWA = strDate
        End Function
        'Public Function PopField(ByRef lineNum As String, ByVal delimString As String) As String

        '    Dim intPos As Integer
        '    Dim strFlield As String

        '    intPos = lineNum.IndexOf(delimString)

        '    If intPos = 0 Then
        '        strFlield = Trim(lineNum)
        '        lineNum = ""
        '    Else
        '        strFlield = Left(lineNum, intPos - 1)
        '        lineNum = lineNum.Substring(intPos + 1, lineNum.Length - strFlield.Length - 1)
        '    End If
        '    PopField = Trim(strFlield)
        'End Function





        ''' <summary>
        ''' Appends the given NWA date along with the current year number
        ''' </summary>
        ''' <param name="flightDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetFlightDateWithYear(ByVal flightDate As String) As String
            Dim strNewFlightDate As String
            flightDate = flightDate.Trim.ToUpper
            'if format passed equals ddMON
            If flightDate.Trim.Length = 5 Then
                'if flight month equals "DEC" and current month equals "JAN" then get previous year
                If flightDate.Substring(2) = "DEC" Then
                    If Month(Now) = 1 Then
                        strNewFlightDate = flightDate & (Year(Now) - 1)
                    Else
                        strNewFlightDate = flightDate & Year(Now)
                    End If
                ElseIf flightDate.Substring(2) = "JAN" Then
                    If Month(Now) = 12 Then
                        strNewFlightDate = flightDate & (Year(Now) + 1)
                    Else
                        strNewFlightDate = flightDate & Year(Now)
                    End If
                Else
                    strNewFlightDate = flightDate & Year(Now)
                End If
            Else
                strNewFlightDate = flightDate
            End If
            GetFlightDateWithYear = strNewFlightDate
        End Function
    End Module ' END CLASS DEFINITION Common
End Namespace ' BO

