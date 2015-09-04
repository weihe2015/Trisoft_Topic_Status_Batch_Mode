﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
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

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
'
Namespace MetaDataAssist20
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="MetaDataAssist20Soap", [Namespace]:="urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0")>  _
    Partial Public Class MetaDataAssist20
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private GetLOVValuesOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetLOVOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetUsersOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetUserGroupsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.Topic_Status.My.MySettings.Default.Topic_Status_MetaDataAssist20_MetaDataAssist20
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event GetLOVValuesCompleted As GetLOVValuesCompletedEventHandler
        
        '''<remarks/>
        Public Event GetLOVCompleted As GetLOVCompletedEventHandler
        
        '''<remarks/>
        Public Event GetUsersCompleted As GetUsersCompletedEventHandler
        
        '''<remarks/>
        Public Event GetUserGroupsCompleted As GetUserGroupsCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0/GetLOVValues", RequestNamespace:="urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0", ResponseNamespace:="urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetLOVValues(ByVal psAuthContext As String, ByVal psLOVName As String, ByRef psOutLOVValues() As String) As String
            Dim results() As Object = Me.Invoke("GetLOVValues", New Object() {psAuthContext, psLOVName, psOutLOVValues})
            psOutLOVValues = CType(results(1),String())
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetLOVValuesAsync(ByVal psAuthContext As String, ByVal psLOVName As String, ByVal psOutLOVValues() As String)
            Me.GetLOVValuesAsync(psAuthContext, psLOVName, psOutLOVValues, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetLOVValuesAsync(ByVal psAuthContext As String, ByVal psLOVName As String, ByVal psOutLOVValues() As String, ByVal userState As Object)
            If (Me.GetLOVValuesOperationCompleted Is Nothing) Then
                Me.GetLOVValuesOperationCompleted = AddressOf Me.OnGetLOVValuesOperationCompleted
            End If
            Me.InvokeAsync("GetLOVValues", New Object() {psAuthContext, psLOVName, psOutLOVValues}, Me.GetLOVValuesOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetLOVValuesOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetLOVValuesCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetLOVValuesCompleted(Me, New GetLOVValuesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0/GetLOV", RequestNamespace:="urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0", ResponseNamespace:="urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetLOV(ByVal psAuthContext As String, ByVal psLOVName As String, ByRef psOutXMLLOV As String) As String
            Dim results() As Object = Me.Invoke("GetLOV", New Object() {psAuthContext, psLOVName, psOutXMLLOV})
            psOutXMLLOV = CType(results(1),String)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetLOVAsync(ByVal psAuthContext As String, ByVal psLOVName As String, ByVal psOutXMLLOV As String)
            Me.GetLOVAsync(psAuthContext, psLOVName, psOutXMLLOV, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetLOVAsync(ByVal psAuthContext As String, ByVal psLOVName As String, ByVal psOutXMLLOV As String, ByVal userState As Object)
            If (Me.GetLOVOperationCompleted Is Nothing) Then
                Me.GetLOVOperationCompleted = AddressOf Me.OnGetLOVOperationCompleted
            End If
            Me.InvokeAsync("GetLOV", New Object() {psAuthContext, psLOVName, psOutXMLLOV}, Me.GetLOVOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetLOVOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetLOVCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetLOVCompleted(Me, New GetLOVCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0/GetUsers", RequestNamespace:="urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0", ResponseNamespace:="urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetUsers(ByVal psAuthContext As String, ByVal psRightFilter As String, ByVal psUserGroupFilter As String, ByRef pasOutUserNames() As String) As String
            Dim results() As Object = Me.Invoke("GetUsers", New Object() {psAuthContext, psRightFilter, psUserGroupFilter, pasOutUserNames})
            pasOutUserNames = CType(results(1),String())
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetUsersAsync(ByVal psAuthContext As String, ByVal psRightFilter As String, ByVal psUserGroupFilter As String, ByVal pasOutUserNames() As String)
            Me.GetUsersAsync(psAuthContext, psRightFilter, psUserGroupFilter, pasOutUserNames, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetUsersAsync(ByVal psAuthContext As String, ByVal psRightFilter As String, ByVal psUserGroupFilter As String, ByVal pasOutUserNames() As String, ByVal userState As Object)
            If (Me.GetUsersOperationCompleted Is Nothing) Then
                Me.GetUsersOperationCompleted = AddressOf Me.OnGetUsersOperationCompleted
            End If
            Me.InvokeAsync("GetUsers", New Object() {psAuthContext, psRightFilter, psUserGroupFilter, pasOutUserNames}, Me.GetUsersOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetUsersOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetUsersCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetUsersCompleted(Me, New GetUsersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0/GetUserGroups", RequestNamespace:="urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0", ResponseNamespace:="urn:trisoft.be:WebServices:InfoShare:MetaDataAssist:2.0", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetUserGroups(ByVal psAuthContext As String, ByRef pasOutUsergroup() As String) As String
            Dim results() As Object = Me.Invoke("GetUserGroups", New Object() {psAuthContext, pasOutUsergroup})
            pasOutUsergroup = CType(results(1),String())
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetUserGroupsAsync(ByVal psAuthContext As String, ByVal pasOutUsergroup() As String)
            Me.GetUserGroupsAsync(psAuthContext, pasOutUsergroup, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetUserGroupsAsync(ByVal psAuthContext As String, ByVal pasOutUsergroup() As String, ByVal userState As Object)
            If (Me.GetUserGroupsOperationCompleted Is Nothing) Then
                Me.GetUserGroupsOperationCompleted = AddressOf Me.OnGetUserGroupsOperationCompleted
            End If
            Me.InvokeAsync("GetUserGroups", New Object() {psAuthContext, pasOutUsergroup}, Me.GetUserGroupsOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetUserGroupsOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetUserGroupsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetUserGroupsCompleted(Me, New GetUserGroupsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub GetLOVValuesCompletedEventHandler(ByVal sender As Object, ByVal e As GetLOVValuesCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetLOVValuesCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property psOutLOVValues() As String()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub GetLOVCompletedEventHandler(ByVal sender As Object, ByVal e As GetLOVCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetLOVCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property psOutXMLLOV() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub GetUsersCompletedEventHandler(ByVal sender As Object, ByVal e As GetUsersCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetUsersCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pasOutUserNames() As String()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub GetUserGroupsCompletedEventHandler(ByVal sender As Object, ByVal e As GetUserGroupsCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetUserGroupsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
        
        '''<remarks/>
        Public ReadOnly Property pasOutUsergroup() As String()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(1),String())
            End Get
        End Property
    End Class
End Namespace
