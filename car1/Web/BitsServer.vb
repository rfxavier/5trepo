﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
' CodeFluent Entities generated (http://www.softfluent.com). Date: Monday, 14 April 2014 09:11. Build: 1.0.61214.0769
Namespace car1.Web
	
	<System.CodeDom.Compiler.GeneratedCode("CodeFluent Entities", "1.0.01234.05678")> _
	Public Partial Class car1BitsServer
		Inherits CodeFluent.Runtime.BinaryServices.BitsServer

		Private Shared _current As car1BitsServer
		
		Public Sub New()
			Me.New(CodeFluent.Runtime.CodeFluentContext.Get(car1.Constants.car1StoreName))
		End Sub

		Public Sub New(ByVal context As CodeFluent.Runtime.CodeFluentContext)
			MyBase.New(context)
		End Sub

		Protected Overrides Sub OnInformation(ByVal ctx As System.Object)
			If (ctx Is Nothing) Then
				Throw New System.ArgumentNullException("ctx")
			End If
			
			Dim entityTypeName As String = Nothing
			Dim propertyName As String = Nothing
			Dim entityKey As String = Nothing
			Dim context As System.Net.HttpListenerContext = DirectCast(ctx, System.Net.HttpListenerContext)
			
			Me.ParseUri(context.Request.Url, entityTypeName, propertyName, entityKey)
			
			If entityTypeName = "car1.Car" Then
				
				If propertyName = "CarPicture" Then
					Dim entity As car1.Car = car1.Car.LoadByEntityKey(entityKey)
					If entity Is Nothing Then
						Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerEntityNotFound", "Entity of type '{0}' with entity key '{1}' was not found.", New Object() { entityTypeName, entityKey }))
					End If
					Me.OnInformation(context, entity.CarPicture)
					Return
				End If
				
				If propertyName = "CarDocument" Then
					Dim entity As car1.Car = car1.Car.LoadByEntityKey(entityKey)
					If entity Is Nothing Then
						Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerEntityNotFound", "Entity of type '{0}' with entity key '{1}' was not found.", New Object() { entityTypeName, entityKey }))
					End If
					Me.OnInformation(context, entity.CarDocument)
					Return
				End If
				
				If propertyName = "CarVideo" Then
					Dim entity As car1.Car = car1.Car.LoadByEntityKey(entityKey)
					If entity Is Nothing Then
						Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerEntityNotFound", "Entity of type '{0}' with entity key '{1}' was not found.", New Object() { entityTypeName, entityKey }))
					End If
					Me.OnInformation(context, entity.CarVideo)
					Return
				End If
				
			End If
			
			If entityTypeName = "car1.Truck" Then
				
				If propertyName = "Image" Then
					Dim entity As car1.Truck = car1.Truck.LoadByEntityKey(entityKey)
					If entity Is Nothing Then
						Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerEntityNotFound", "Entity of type '{0}' with entity key '{1}' was not found.", New Object() { entityTypeName, entityKey }))
					End If
					Me.OnInformation(context, entity.Image)
					Return
				End If
				
			End If
			
			Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerInvalidUrl", "Invalid url '{0}'.", New Object() { context.Request.Url }))
		End Sub

		Protected Overrides Function OnDownload(ByVal ctx As Object, ByVal start As Long, ByVal [end] As Long) As Long
			If ctx Is Nothing Then
				Throw New System.ArgumentNullException("ctx")
			End If
			
			Dim entityTypeName As String = Nothing
			Dim propertyName As String = Nothing
			Dim entityKey As String = Nothing
			Dim context As System.Net.HttpListenerContext = DirectCast(ctx, System.Net.HttpListenerContext)

			Me.ParseUri(context.Request.Url, entityTypeName, propertyName, entityKey)
			
			If entityTypeName = "car1.Car" Then
				
				If propertyName = "CarPicture" Then
					Dim entity As car1.Car = car1.Car.LoadByEntityKey(entityKey)
					If entity Is Nothing Then
						Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerEntityNotFound", "Entity of type '{0}' with entity key '{1}' was not found.", New Object() { entityTypeName, entityKey }))
					End If
					Return Me.OnDownload(context, entity.CarPicture, start, [end])
				End If
				
				If propertyName = "CarDocument" Then
					Dim entity As car1.Car = car1.Car.LoadByEntityKey(entityKey)
					If entity Is Nothing Then
						Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerEntityNotFound", "Entity of type '{0}' with entity key '{1}' was not found.", New Object() { entityTypeName, entityKey }))
					End If
					Return Me.OnDownload(context, entity.CarDocument, start, [end])
				End If
				
				If propertyName = "CarVideo" Then
					Dim entity As car1.Car = car1.Car.LoadByEntityKey(entityKey)
					If entity Is Nothing Then
						Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerEntityNotFound", "Entity of type '{0}' with entity key '{1}' was not found.", New Object() { entityTypeName, entityKey }))
					End If
					Return Me.OnDownload(context, entity.CarVideo, start, [end])
				End If
				
			End If
			
			If entityTypeName = "car1.Truck" Then
				
				If propertyName = "Image" Then
					Dim entity As car1.Truck = car1.Truck.LoadByEntityKey(entityKey)
					If entity Is Nothing Then
						Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerEntityNotFound", "Entity of type '{0}' with entity key '{1}' was not found.", New Object() { entityTypeName, entityKey }))
					End If
					Return Me.OnDownload(context, entity.Image, start, [end])
				End If
				
			End If
			
			Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerInvalidUrl", "Invalid url '{0}'.", New Object() { context.Request.Url }))
		End Function

		Protected Overrides Sub OnSessionClose(ByVal ctx As Object, ByVal session As CodeFluent.Runtime.BinaryServices.Session)
			If ctx Is Nothing Then
				Throw New System.ArgumentNullException("ctx")
			End If
			
			If session Is Nothing Then
				Throw New System.ArgumentNullException("session")
			End If

			If MyBase.OnSessionChange(session, CodeFluent.Runtime.BinaryServices.SessionChangeType.Closing, ctx, True, Nothing) Then
				Dim entityTypeName As String = Nothing
				Dim propertyName As String = Nothing
				Dim entityKey As String = Nothing
				Dim context As System.Net.HttpListenerContext = DirectCast(ctx, System.Net.HttpListenerContext)
				Me.ParseUri(context.Request.Url, entityTypeName, propertyName, entityKey)
				Me.OnSessionClose(context, session, entityTypeName, propertyName, entityKey)
				MyBase.OnSessionChange(session, CodeFluent.Runtime.BinaryServices.SessionChangeType.Closed, ctx, False, Nothing)
			End If
		End Sub

		Protected Overridable Overloads Sub OnSessionClose(ByVal context As System.Net.HttpListenerContext, ByVal session As CodeFluent.Runtime.BinaryServices.Session, ByVal entityTypeName As String, ByVal propertyName As String, ByVal entityKey As String)
			
			If entityTypeName = "car1.Car" Then
				
				If propertyName = "CarPicture" Then
					Dim entity As car1.Car = car1.Car.LoadByEntityKey(entityKey)
					If Not entity Is Nothing Then
						Me.CloseSession(context, entity.CarPicture, session)
						Return
					End If
				End If
				
				If propertyName = "CarDocument" Then
					Dim entity As car1.Car = car1.Car.LoadByEntityKey(entityKey)
					If Not entity Is Nothing Then
						Me.CloseSession(context, entity.CarDocument, session)
						Return
					End If
				End If
				
				If propertyName = "CarVideo" Then
					Dim entity As car1.Car = car1.Car.LoadByEntityKey(entityKey)
					If Not entity Is Nothing Then
						Me.CloseSession(context, entity.CarVideo, session)
						Return
					End If
				End If
				
			End If
			
			If entityTypeName = "car1.Truck" Then
				
				If propertyName = "Image" Then
					Dim entity As car1.Truck = car1.Truck.LoadByEntityKey(entityKey)
					If Not entity Is Nothing Then
						Me.CloseSession(context, entity.Image, session)
						Return
					End If
				End If
				
			End If
			
			Throw New System.InvalidOperationException(car1.Resources.Manager.GetStringWithDefault("bitsServerInvalidUrl", "Invalid url '{0}'.", New Object() { context.Request.Url }))
		End Sub

		Public Shared ReadOnly Property Current As car1BitsServer
			Get
				If _current Is Nothing Then
					_current = New car1BitsServer
				End If
				Return _current
			End Get
		End Property
	End Class
	
End Namespace
