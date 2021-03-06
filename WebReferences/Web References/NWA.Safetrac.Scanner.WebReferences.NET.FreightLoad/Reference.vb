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
Namespace NWA.Safetrac.Scanner.WebReferences.NET.FreightLoad
    
    '''<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="WS_Freight_LoadSoap", [Namespace]:="http://safetrac.nwa.com/")>  _
    Partial Public Class WS_Freight_Load
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = ConfigManager.WS_Freight_Load_AOT
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("http://safetrac.nwa.com/UnloadFreight", RequestNamespace:="http://safetrac.nwa.com/", ResponseNamespace:="http://safetrac.nwa.com/")>  _
        Public Function UnloadFreight(ByVal DeviceId As String, ByVal Station As String, ByVal UserId As String, ByVal AWB As String) As String
            Dim results() As Object = Me.Invoke("UnloadFreight", New Object() {DeviceId, Station, UserId, AWB})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginUnloadFreight(ByVal DeviceId As String, ByVal Station As String, ByVal UserId As String, ByVal AWB As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("UnloadFreight", New Object() {DeviceId, Station, UserId, AWB}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndUnloadFreight(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("http://safetrac.nwa.com/InitiateCargo", RequestNamespace:="http://safetrac.nwa.com/", ResponseNamespace:="http://safetrac.nwa.com/")>  _
        Public Function InitiateCargo(ByVal DeviceId As String, ByVal Carrier As String, ByVal Flight As String, ByVal FlightDate As String, ByVal Station As String, ByVal UserId As String) As String
            Dim results() As Object = Me.Invoke("InitiateCargo", New Object() {DeviceId, Carrier, Flight, FlightDate, Station, UserId})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginInitiateCargo(ByVal DeviceId As String, ByVal Carrier As String, ByVal Flight As String, ByVal FlightDate As String, ByVal Station As String, ByVal UserId As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("InitiateCargo", New Object() {DeviceId, Carrier, Flight, FlightDate, Station, UserId}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndInitiateCargo(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("http://safetrac.nwa.com/LoadFreightInBinBulk", RequestNamespace:="http://safetrac.nwa.com/", ResponseNamespace:="http://safetrac.nwa.com/")>  _
        Public Function LoadFreightInBinBulk(ByVal DeviceId As String, ByVal Carrier As String, ByVal Flight As String, ByVal FlightDate As String, ByVal Station As String, ByVal UserId As String, ByVal AWB As String, ByVal HoldId As String, ByVal ManualInputInd As String, ByVal Dest As String, ByVal FinalDest As String, ByVal Remarks As String, ByVal ExpediteInd As String) As String
            Dim results() As Object = Me.Invoke("LoadFreightInBinBulk", New Object() {DeviceId, Carrier, Flight, FlightDate, Station, UserId, AWB, HoldId, ManualInputInd, Dest, FinalDest, Remarks, ExpediteInd})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginLoadFreightInBinBulk(ByVal DeviceId As String, ByVal Carrier As String, ByVal Flight As String, ByVal FlightDate As String, ByVal Station As String, ByVal UserId As String, ByVal AWB As String, ByVal HoldId As String, ByVal ManualInputInd As String, ByVal Dest As String, ByVal FinalDest As String, ByVal Remarks As String, ByVal ExpediteInd As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("LoadFreightInBinBulk", New Object() {DeviceId, Carrier, Flight, FlightDate, Station, UserId, AWB, HoldId, ManualInputInd, Dest, FinalDest, Remarks, ExpediteInd}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndLoadFreightInBinBulk(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("http://safetrac.nwa.com/LoadNewFreightBinBulk", RequestNamespace:="http://safetrac.nwa.com/", ResponseNamespace:="http://safetrac.nwa.com/")>  _
        Public Function LoadNewFreightBinBulk( _
                    ByVal DeviceId As String,  _
                    ByVal Carrier As String,  _
                    ByVal Flight As String,  _
                    ByVal FlightDate As String,  _
                    ByVal Station As String,  _
                    ByVal UserId As String,  _
                    ByVal AWB As String,  _
                    ByVal HoldId As String,  _
                    ByVal ManualInputInd As String,  _
                    ByVal Dest As String,  _
                    ByVal FinalDest As String,  _
                    ByVal Remarks As String,  _
                    ByVal ExpediteInd As String,  _
                    ByVal PieceCount As String,  _
                    ByVal PieceWeight As String,  _
                    ByVal CommodityType As String) As Object
            Dim results() As Object = Me.Invoke("LoadNewFreightBinBulk", New Object() {DeviceId, Carrier, Flight, FlightDate, Station, UserId, AWB, HoldId, ManualInputInd, Dest, FinalDest, Remarks, ExpediteInd, PieceCount, PieceWeight, CommodityType})
            Return CType(results(0),Object)
        End Function
        
        '''<remarks/>
        Public Function BeginLoadNewFreightBinBulk( _
                    ByVal DeviceId As String,  _
                    ByVal Carrier As String,  _
                    ByVal Flight As String,  _
                    ByVal FlightDate As String,  _
                    ByVal Station As String,  _
                    ByVal UserId As String,  _
                    ByVal AWB As String,  _
                    ByVal HoldId As String,  _
                    ByVal ManualInputInd As String,  _
                    ByVal Dest As String,  _
                    ByVal FinalDest As String,  _
                    ByVal Remarks As String,  _
                    ByVal ExpediteInd As String,  _
                    ByVal PieceCount As String,  _
                    ByVal PieceWeight As String,  _
                    ByVal CommodityType As String,  _
                    ByVal callback As System.AsyncCallback,  _
                    ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("LoadNewFreightBinBulk", New Object() {DeviceId, Carrier, Flight, FlightDate, Station, UserId, AWB, HoldId, ManualInputInd, Dest, FinalDest, Remarks, ExpediteInd, PieceCount, PieceWeight, CommodityType}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndLoadNewFreightBinBulk(ByVal asyncResult As System.IAsyncResult) As Object
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Object)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("http://safetrac.nwa.com/ProcessFreight", RequestNamespace:="http://safetrac.nwa.com/", ResponseNamespace:="http://safetrac.nwa.com/")>  _
        Public Function ProcessFreight(ByVal DeviceId As String, ByVal Carrier As String, ByVal Flight As String, ByVal FlightDate As String, ByVal Station As String, ByVal LDFlag As String) As String
            Dim results() As Object = Me.Invoke("ProcessFreight", New Object() {DeviceId, Carrier, Flight, FlightDate, Station, LDFlag})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginProcessFreight(ByVal DeviceId As String, ByVal Carrier As String, ByVal Flight As String, ByVal FlightDate As String, ByVal Station As String, ByVal LDFlag As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ProcessFreight", New Object() {DeviceId, Carrier, Flight, FlightDate, Station, LDFlag}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndProcessFreight(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
    End Class
End Namespace
