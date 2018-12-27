Imports System
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports NWA.Safetrac.Scanner.BO
Imports NWA.Safetrac.Scanner.Hardware

Namespace NWA.Safetrac.Scanner.UI
    Public Class frmMainMenu

        Private _currentMenuFilter As MenuFliter
        Private _diMenuList As New Dictionary(Of Keys, String)

        Private Sub InitializeMenu()
            _diMenuList.Add(MenuItems.BagsToBinBulk, "BAGS TO BIN/BULK")
            _diMenuList.Add(MenuItems.MailToBinBulk, "MAIL TO BIN/BULK")
            _diMenuList.Add(MenuItems.BinBulkInquiry, "BIN/BULK INQUIRY")
            _diMenuList.Add(MenuItems.ContainerInquiry, "ULD/CART INQUIRY")
            _diMenuList.Add(MenuItems.PositionContainer, "ULD POSITION")
            _diMenuList.Add(MenuItems.MergeUldCartBin, "MERGE ULD/CART/BIN")
            _diMenuList.Add(MenuItems.BagsToUnload, "BAGS TO UNLOAD")
            _diMenuList.Add(MenuItems.ExpediteBagsToBinBulk, "EXP BAGS TO BIN/BULK")
            _diMenuList.Add(MenuItems.CloseReopenFlight, "CLOSE/REOPEN FLIGHT")
            _diMenuList.Add(MenuItems.ContainerSheetCreation, "ULD SHEET CREATION")
            _diMenuList.Add(MenuItems.BagtagInquiry, "BAGTAG INQUIRY")
            _diMenuList.Add(MenuItems.ViewLineItems, "VIEW LINE ITEMS")
            _diMenuList.Add(MenuItems.CreateMultipleContainers, "ULD SHEETS CREATION")
            _diMenuList.Add(MenuItems.AddLateBags, "ADD LATE BAGS")
            _diMenuList.Add(MenuItems.UnloadBags, "UNLOAD BAGS")
            _diMenuList.Add(MenuItems.BagsToContainer, "BAGS TO ULD/CART")
            _diMenuList.Add(MenuItems.ViewHHTInformation, "HHT INFORMATION")
            _diMenuList.Add(MenuItems.LoadUnloadFreight, "LOAD/UNLOAD FREIGHT")
            _diMenuList.Add(MenuItems.UldRegistration, "ULD REGISTRATION")
            _diMenuList.Add(MenuItems.UldDefinition, "ULD DEFINITION")
            _diMenuList.Add(MenuItems.UnloadMail, "UNLOAD MAIL")
            _diMenuList.Add(MenuItems.MailToContainer, "MAIL TO ULD/CART")
            _diMenuList.Add(MenuItems.BagsToGo, "BAGS TO GO")
            _diMenuList.Add(MenuItems.Logoff, "LOGOFF")
            _diMenuList.Add(MenuItems.FlightsMenu, "FLIGHTS MANAGEMENT")
            _diMenuList.Add(MenuItems.BagtagAlerts, "BAGTAG ALERTS")
        End Sub

        Public Overrides Sub OnScan(ByVal sender As Object, ByVal e As Hardware.ScanEventArgs)
            If UIController.CurrentFunction = SafetracFunction.MainMenu Then
                Dim strScannedValue As String = e.ScannedValue
                If Validate.IsContainerNumValid(strScannedValue) Then
                    SelectFunction(MenuItems.ContainerInquiry)
                ElseIf Validate.IsBagtagValid(strScannedValue) Then
                    SelectFunction(MenuItems.BagtagInquiry)
                ElseIf Validate.IsMailValid(strScannedValue) Then
                    SelectFunction(MenuItems.MailToContainer)
                ElseIf Validate.IsAWBValid(strScannedValue) Then
                    SelectFunction(MenuItems.LoadUnloadFreight)
                End If
            End If
        End Sub

        Public Sub New()
            InitializeComponent()
            InitializeMenu()
        End Sub

        Private Sub AddMenuItem(ByVal menuItem As MenuItems)
            If _diMenuList.ContainsKey(menuItem) Then
                lblCode.Items.Add("C" & Convert.ToChar(menuItem))
                lstMenu.Items.Add(_diMenuList(menuItem))
            End If
        End Sub

        Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Dim objsyncInstance As SyncManager.SyncManager
            objsyncInstance = SyncManager.SyncManager.GetSyncInstance()
            objsyncInstance.InitSyncManager()
            UIController.CurrentFunction = SafetracFunction.MainMenu
            FilterMenu(MenuFliter.MenuAll)
            lblCode.SelectedIndex = 0
            lstMenu.SelectedIndex = 0
            lstMenu.Focus()
            MyBase.HideFooter()
        End Sub

        Private Sub frmMainMenu_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
            lblCode.SelectedIndex = 0
            lstMenu.SelectedIndex = 0
            lstMenu.Focus()
        End Sub

        Private Sub lblMenu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstMenu.KeyDown
            lblCode.SelectedIndex = lstMenu.SelectedIndex
            'If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            If e.Control Then
                SelectFunction(e.KeyCode)
            ElseIf e.KeyCode = Keys.Enter Then
                Dim intCode = Asc(lblCode.Text.Substring(1, 1))
                SelectFunction(intCode)
                'SelectFunction(e.KeyCode)
            End If
        End Sub

        Private Sub lblMenu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMenu.SelectedIndexChanged
            lblCode.SelectedIndex = lstMenu.SelectedIndex
        End Sub

        Private Sub lblCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCode.SelectedIndexChanged
            lstMenu.SelectedIndex = lblCode.SelectedIndex
        End Sub

        Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
            Dim filterCode As Integer
            Dim objMenuViews As New dlgMenuViews()

            If objMenuViews.ShowDialog() = Windows.Forms.DialogResult.OK Then
                filterCode = objMenuViews.FilterCriteria
                If _currentMenuFilter <> filterCode Then
                    FilterMenu(filterCode)
                    Exit Sub
                End If
            End If
        End Sub

        Private Sub FilterMenu(ByVal filterCriteria As MenuFliter)

            Dim strTitle As String = String.Empty
            lblCode.Items.Clear()
            lstMenu.Items.Clear()

            Select Case filterCriteria
                Case MenuFliter.MenuAll
                    'COMPLETE MENU
                    AddMenuItem(MenuItems.BagsToBinBulk)
                    AddMenuItem(MenuItems.MailToBinBulk)
                    AddMenuItem(MenuItems.BinBulkInquiry)
                    AddMenuItem(MenuItems.ContainerInquiry)
                    AddMenuItem(MenuItems.PositionContainer)
                    AddMenuItem(MenuItems.MergeUldCartBin)
                    AddMenuItem(MenuItems.BagsToUnload)
                    AddMenuItem(MenuItems.ExpediteBagsToBinBulk)
                    AddMenuItem(MenuItems.CloseReopenFlight)
                    AddMenuItem(MenuItems.ContainerSheetCreation)
                    AddMenuItem(MenuItems.BagtagInquiry)
                    AddMenuItem(MenuItems.ViewLineItems)
                    AddMenuItem(MenuItems.CreateMultipleContainers)
                    AddMenuItem(MenuItems.AddLateBags)
                    AddMenuItem(MenuItems.UnloadBags)
                    AddMenuItem(MenuItems.BagsToContainer)
                    AddMenuItem(MenuItems.ViewHHTInformation)
                    AddMenuItem(MenuItems.LoadUnloadFreight)
                    AddMenuItem(MenuItems.UldRegistration)
                    AddMenuItem(MenuItems.UldDefinition)
                    AddMenuItem(MenuItems.UnloadMail)
                    AddMenuItem(MenuItems.MailToContainer)
                    AddMenuItem(MenuItems.BagsToGo)
                    AddMenuItem(MenuItems.Logoff)
                    AddMenuItem(MenuItems.FlightsMenu)
                    AddMenuItem(MenuItems.BagtagAlerts)
                    strTitle = "[ALL]"
                    _currentMenuFilter = MenuFliter.MenuAll
                Case MenuFliter.MenuBag
                    ' BAGTAG-RELATED FUNCTIONS
                    AddMenuItem(MenuItems.BagsToBinBulk)
                    AddMenuItem(MenuItems.BinBulkInquiry)
                    AddMenuItem(MenuItems.ContainerInquiry)
                    AddMenuItem(MenuItems.ExpediteBagsToBinBulk)
                    AddMenuItem(MenuItems.BagtagInquiry)
                    AddMenuItem(MenuItems.UnloadMail)
                    AddMenuItem(MenuItems.BagsToContainer)
                    AddMenuItem(MenuItems.BagsToGo)
                    AddMenuItem(MenuItems.BagtagAlerts)
                    strTitle = "[Bags]"
                    _currentMenuFilter = MenuFliter.MenuBag
                Case MenuFliter.MenuInquiry
                    ' INQUIRY FUNCTIONS
                    AddMenuItem(MenuItems.BinBulkInquiry)
                    AddMenuItem(MenuItems.ContainerInquiry)
                    AddMenuItem(MenuItems.BagsToUnload)
                    AddMenuItem(MenuItems.BagtagInquiry)
                    AddMenuItem(MenuItems.ViewHHTInformation)
                    AddMenuItem(MenuItems.BagsToGo)
                    strTitle = "[Inq]"
                    _currentMenuFilter = MenuFliter.MenuInquiry
                Case MenuFliter.MenuUld
                    ' ULD/CART FUNCTIONS
                    AddMenuItem(MenuItems.ContainerInquiry)
                    AddMenuItem(MenuItems.MergeUldCartBin)
                    AddMenuItem(MenuItems.ContainerSheetCreation)
                    AddMenuItem(MenuItems.CreateMultipleContainers)
                    AddMenuItem(MenuItems.UnloadBags)
                    AddMenuItem(MenuItems.BagsToContainer)
                    AddMenuItem(MenuItems.UldRegistration)
                    AddMenuItem(MenuItems.UldDefinition)
                    AddMenuItem(MenuItems.MailToContainer)
                    strTitle = "[ULD]"
                    _currentMenuFilter = MenuFliter.MenuUld
            End Select

            MyBase.SetHeader("HHT MAIN MENU " & strTitle)
            lblCode.SelectedIndex = 0
            lstMenu.SelectedIndex = 0
            lstMenu.Focus()

        End Sub

        Private Sub SelectFunction(ByVal menuItem As MenuItems)
            Select Case menuItem
                Case MenuItems.BagsToBinBulk
                    'BAGS TO BIN/BULK
                    UIController.CurrentFunction = SafetracFunction.LoadBagIntoBinBulk
                    UIController.NextForm = New frmBinBulkInquiry
                    UIController.NextForm.ShowDialog()
                Case MenuItems.MailToBinBulk
                    'MAIL TO BIN/BULK
                    UIController.CurrentFunction = SafetracFunction.LoadMailIntoBinBulk
                    UIController.NextForm = New frmBinBulkInquiryForLoadMail()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.BinBulkInquiry
                    'BIN/BLK INQUIRY
                    UIController.CurrentFunction = SafetracFunction.BinBulkInquiry
                    UIController.NextForm = New frmBinBulkInquiry()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.ContainerInquiry
                    'ULD/CART INQUIRY
                    UIController.CurrentFunction = SafetracFunction.ContainerInquiry
                    UIController.NextForm = New frmContainerSummary
                    UIController.NextForm.ShowDialog()
                Case MenuItems.PositionContainer
                    'ULD POSITION
                    If MyBase.IsInNetwork(True) Then
                        UIController.CurrentFunction = SafetracFunction.PositionContainer
                        UIController.NextForm = New frmFlightInfo()
                        UIController.NextForm.ShowDialog()
                    End If
                Case MenuItems.MergeUldCartBin
                    'MERGE ULD/CART/BIN
                    UIController.CurrentFunction = SafetracFunction.MergeContainersAndHolds
                    UIController.NextForm = New frmMergeContainers()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.BagsToUnload
                    'BAGS TO UNLOAD 
                    UIController.CurrentFunction = SafetracFunction.ViewBagsToBeUnloaded
                    UIController.NextForm = New frmFlightInquiry
                    UIController.NextForm.ShowDialog()
                Case MenuItems.ExpediteBagsToBinBulk
                    'EXP BAGS TO BIN/BLK
                    UIController.CurrentFunction = SafetracFunction.ExpediteBag
                    UIController.NextForm = New frmExpediteReason()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.CloseReopenFlight
                    'CLOSE/REOPEN FLIGHT
                    Dim oblDlgCloseReopen As New dlgCloseReopenFlight()
                    oblDlgCloseReopen.ShowDialog()
                    If UIController.CurrentFunction = SafetracFunction.CloseFlight Or _
                    UIController.CurrentFunction = SafetracFunction.ReopenFlight Then
                        If MyBase.IsInNetwork(True) Then
                            UIController.NextForm = New frmCloseReopenFlight()
                            UIController.NextForm.ShowDialog()
                        End If
                    End If
                Case MenuItems.ContainerSheetCreation
                    'ULD SHEET CREATION
                    If MyBase.IsInNetwork(True) Then
                        UIController.CurrentFunction = SafetracFunction.CreateContainerSheetNumber
                        UIController.NextForm = New frmContainerInquiryTwo()
                        UIController.NextForm.ShowDialog()
                    End If
                Case MenuItems.BagtagInquiry
                    'BAGTAG INQUIRY 
                    UIController.CurrentFunction = SafetracFunction.ViewBagTagInquiry
                    UIController.NextForm = New frmBagtagInquiry()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.ViewLineItems
                    'VIEW LINE ITEMS
                    UIController.CurrentFunction = SafetracFunction.ViewLineItems
                    UIController.NextForm = New frmFlightInquiry
                    UIController.NextForm.ShowDialog()
                Case MenuItems.ContainerSheetCreation
                    'CREATE MULTIPLE CONTAINER SHEETS
                    UIController.CurrentFunction = SafetracFunction.CreateContainerSheetNumber
                    UIController.NextForm = New frmContainerInquiryTwo
                    UIController.NextForm.ShowDialog()
                Case MenuItems.CreateMultipleContainers
                    UIController.CurrentFunction = SafetracFunction.CreateMultipleContainerSheets
                    UIController.NextForm = New frmFlightInquiry
                    UIController.NextForm.ShowDialog()
                Case MenuItems.AddLateBags
                    'ADD LATE BAGS 
                    UIController.CurrentFunction = SafetracFunction.AddLateBag
                    UIController.NextForm = New frmFlightInquiry
                    UIController.NextForm.ShowDialog()
                    'MessageBox.Show("AddLateBags")
                Case MenuItems.UnloadBags
                    'UNLOAD BAGS
                    UIController.CurrentFunction = SafetracFunction.UnloadBag
                    UIController.NextForm = New frmUnloadBag
                    UIController.NextForm.ShowDialog()
                Case MenuItems.BagsToContainer
                    'BAGS TO ULD/CART
                    UIController.CurrentFunction = SafetracFunction.LoadBagToContainer
                    UIController.NextForm = New frmContainerInquiry()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.ViewHHTInformation
                    'HHT INFORMATION
                    UIController.CurrentFunction = SafetracFunction.ViewHHTInformation
                    UIController.NextForm = New frmViewHTTInformation()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.LoadUnloadFreight
                    'LOAD/UNLOAD FREIGHT
                    Dim objDlgLoadUnloadFreight As New dlgLoadUnloadFreight()
                    objDlgLoadUnloadFreight.ShowDialog()
                    If UIController.CurrentFunction = SafetracFunction.LoadBagIntoBinBulk Then
                        UIController.NextForm = New frmBinBulkInquiryForFreight()
                        UIController.NextForm.ShowDialog()
                    ElseIf UIController.CurrentFunction = SafetracFunction.UnloadFreight Then
                        UIController.NextForm = New frmUnloadFreight()
                        UIController.NextForm.ShowDialog()
                    End If
                Case MenuItems.UldRegistration
                    'ULD REGISTRATION
                    If MyBase.IsInNetwork(True) Then
                        UIController.CurrentFunction = SafetracFunction.RegisterContainer
                        UIController.NextForm = New frmContainerInquiry()
                        UIController.NextForm.ShowDialog()
                    End If
                Case MenuItems.UldDefinition
                    'ULD DEFINITION
                    UIController.CurrentFunction = SafetracFunction.ChangeContainerDefinition
                    UIController.NextForm = New frmChangeContainerDefinition()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.UnloadMail
                    'UNLOAD MAIL
                    Dim objdlgUnloadMailFrom As New dlgUnloadMailFrom()
                    objdlgUnloadMailFrom.ShowDialog()
                    If UIController.CurrentFunction = SafetracFunction.UnloadMailFromBinBulk Then
                        UIController.NextForm = New frmBinBulkInquiryForLoadMail()
                        UIController.NextForm.ShowDialog()
                    ElseIf UIController.CurrentFunction = SafetracFunction.UnloadMailFromContainer Then
                        UIController.NextForm = New frmMailType()
                        UIController.NextForm.ShowDialog()
                    ElseIf objdlgUnloadMailFrom.Message IsNot String.Empty Then
                        MyBase.SetError(objdlgUnloadMailFrom.Message)
                    End If
                Case MenuItems.MailToContainer
                    'MAIL  TO ULD/CART
                    'Pending : Dummy Code to test
                    Dim conRet As ContainerReturnCodes
                    conRet = IsContainerNameValid("AKE12345NW")
                    MyBase.FlightsCollection.CurrentFlight.IsContainerNameValid("AKE12345NW")
                    If MyBase.FlightsCollection.CurrentFlight.CurrentContainer Is Nothing Then
                        MyBase.SetFooter("REGISTER ULD FIRST")
                        Exit Sub
                    End If
                    UIController.CurrentFunction = SafetracFunction.LoadMailIntoContainer
                    UIController.NextForm = New frmMailType()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.BagsToGo
                    'BAGS TO GO
                    UIController.CurrentFunction = SafetracFunction.ViewBagsToGo
                    UIController.NextForm = New frmFlightInquiry()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.FlightsMenu
                    'Add, Remove, Modify Flights
                    UIController.CurrentFunction = SafetracFunction.FlightsMenu
                    UIController.NextForm = New frmFlightMenu()
                    UIController.NextForm.ShowDialog()
                Case MenuItems.Logoff
                    'LOGOFF
                    If LoginController.PerformLogoff() Then
                        UIController.CurrentFunction = SafetracFunction.Login
                        UIController.NextForm = New frmLogin()
                        UIController.NextForm.ShowDialog()
                    End If
                Case MenuItems.BagtagAlerts
                    UIController.CurrentFunction = SafetracFunction.AlertMenu
                    UIController.NextForm = New frmBagAlertMenu()
                    UIController.NextForm.ShowDialog()
            End Select
        End Sub

        Private Enum MenuItems
            BagsToBinBulk = Keys.A
            MailToBinBulk = Keys.B
            BinBulkInquiry = Keys.D
            ContainerInquiry = Keys.E
            PositionContainer = Keys.F
            MergeUldCartBin = Keys.G
            BagsToUnload = Keys.H
            ExpediteBagsToBinBulk = Keys.I
            CloseReopenFlight = Keys.J
            ContainerSheetCreation = Keys.K
            BagtagInquiry = Keys.L
            ViewLineItems = Keys.D1
            CreateMultipleContainers = Keys.D2
            AddLateBags = Keys.N
            UnloadBags = Keys.O
            BagsToContainer = Keys.P
            ViewHHTInformation = Keys.Q
            LoadUnloadFreight = Keys.R
            UldRegistration = Keys.S
            UldDefinition = Keys.T
            UnloadMail = Keys.U
            MailToContainer = Keys.V
            BagsToGo = Keys.W
            Logoff = Keys.X
            FlightsMenu = Keys.Y
            BagtagAlerts = Keys.Z
        End Enum

    End Class


End Namespace