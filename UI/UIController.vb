Imports System.Threading
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports NWA.Safetrac.Scanner.Utils
Imports NWA.Safetrac.Scanner.BO

Namespace NWA.Safetrac.Scanner.UI

    Public Module UIController
        Private _objCurrentFunction As SafetracFunction
        Private _objPreviousFunction As SafetracFunction
        Private _objNextForm As frmSafetracBase
        Private _objPreviousForm As Form
        Private _thrdUI As Thread

        Public Property NextForm() As frmSafetracBase
            Get
                Return _objNextForm
            End Get
            Set(ByVal value As frmSafetracBase)
                _objPreviousForm = _objNextForm
                _objNextForm = Nothing
                _objNextForm = value
            End Set
        End Property

        Public Property CurrentFunction() As SafetracFunction
            Get
                Return _objCurrentFunction
            End Get
            Set(ByVal value As SafetracFunction)
                _objPreviousFunction = _objCurrentFunction
                _objCurrentFunction = value
            End Set
        End Property
        Public Property PreviousForm() As Form
            Get
                Return _objPreviousForm
            End Get
            Set(ByVal value As Form)
                _objPreviousForm = value
            End Set
        End Property
    End Module
End Namespace