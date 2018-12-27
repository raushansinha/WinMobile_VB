Namespace NWA.Safetrac.Scanner.BO

    Public Module BOConstants
        Public Const LoginAdminUserId As String = "ADMIN"
        Public Const LoginAdminPassword As String = "NWAACE"
        Public Const LoginVersionUserId As String = "VERS"
        Public Const LoginAutoConfigUserId As String = "AUTO"
        Public Const LoginAutoConfigPassword As String = "CONFIG"
        Public Const BagtagMinLength As Integer = 6
        Public Const BagtagMaxLength As Integer = 10
        Public Const BagtagBinLow As Integer = 1         ' Lowest bin number you can enter in bagtag field to switch bins
        Public Const BagtagBinHigh As Integer = 4          ' Highest bin number you can enter in bagtag field to switch bins
        Public Const BagtagBulkLow As Integer = 51       ' Lowest bulk number you can enter in bagtag field to switch bins
        Public Const BagtagBulkHigh As Integer = 54        ' Highest bulk number you can enter in bagtag field to switch bins
        Public Const ContainerMinLength As Integer = 7
        Public Const ContainerCartLabel As String = "CAR"
        Public Const NwaAc As String = "012"
        Public Const NwaAcBagtag As String = "0012"
        Public Const AllowULDSwitch As Boolean = True
        Public Const DisallowULDSwitch As Boolean = False
        Public Const NormalBagWeight As Integer = 30
        Public Const HeavyBagWeight As Integer = 60          ' What weight to pass to server if user entered "heavy bag" scanning
        Public Const PlanesideBagWeight As Integer = 20      ' Planeside bag scanning
        'Expedite Constants
        Public Const NoExpedite As String = "N"
        Public Const ExpediteXRay As String = "A"
        Public Const ExpediteMisconnect As String = "C"
        Public Const ExpeditePaxOnboard As String = "D"
        Public Const EexpediteCancelledFlight As String = "E"
        Public Const ExpediteDomesticXFR As String = "G"
        Public Const DefaultMailWeight As String = ""
    End Module
End Namespace