﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.832
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization
Imports NWA.Safetrac.Scanner.Utils


'
'This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.832.
'
Namespace NWA.Safetrac.Scanner.WebReferences.NET.ReadDDSG
    
    '''<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="WS_ReadDDSGLineItemsSoap", [Namespace]:="http://safetrac.nwa.com/")>  _
    Partial Public Class WS_ReadDDSGLineItems
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = ConfigManager.WS_ReadDDSGLineItems_AOT
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("http://safetrac.nwa.com/ReadDDSGLineItems", RequestNamespace:="http://safetrac.nwa.com/", ResponseNamespace:="http://safetrac.nwa.com/")>  _
        Public Function ReadDDSGLineItems(ByVal DeviceId As String, ByVal Carrier As String, ByVal Flight As String, ByVal FlightDate As String, ByVal Station As String) As String
            Dim results() As Object = Me.Invoke("ReadDDSGLineItems", New Object() {DeviceId, Carrier, Flight, FlightDate, Station})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginReadDDSGLineItems(ByVal DeviceId As String, ByVal Carrier As String, ByVal Flight As String, ByVal FlightDate As String, ByVal Station As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ReadDDSGLineItems", New Object() {DeviceId, Carrier, Flight, FlightDate, Station}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndReadDDSGLineItems(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
    End Class
End Namespace
