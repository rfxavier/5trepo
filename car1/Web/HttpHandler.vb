﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports CodeFluent.Runtime
Imports CodeFluent.Runtime.Utilities

Namespace car1.Web
    
    'CodeFluent Entities generated (http://www.softfluent.com). Date: Saturday, 12 April 2014 18:46.
    <System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0769")>  _
    Partial Public Class HttpHandler
        Inherits CodeFluent.Runtime.Web.UI.BinaryLargeObjectHttpHandler
        
        Private _context As CodeFluent.Runtime.CodeFluentContext
        
        Public Overloads Overrides ReadOnly Property CodeFluentContext() As CodeFluent.Runtime.CodeFluentContext
            Get
                If (Me._context Is Nothing) Then
                    If (Me.EntityClrFullTypeName = "car1.Car") Then
                        Me._context = CodeFluentContext.Get(car1.Constants.car1StoreName)
                        Return Me._context
                    End If
                    If (Me.EntityClrFullTypeName = "car1.Truck") Then
                        Me._context = CodeFluentContext.Get(car1.Constants.car1StoreName)
                        Return Me._context
                    End If
                    Me._context = CodeFluentContext.Get(car1.Constants.car1StoreName)
                End If
                Return Me._context
            End Get
        End Property
        
        Public Overloads Overrides Function LoadBinaryLargeObject(ByVal context As System.Web.HttpContext, ByVal propertyName As String, ByVal identifiersValues() As Object) As CodeFluent.Runtime.BinaryServices.BinaryLargeObject
            If (Me.EntityClrFullTypeName = "car1.Car") Then
                Dim Car As car1.Car = car1.Car.Load(CType(ConvertUtilities.ChangeType(identifiersValues(0), GetType(Integer), -1),Integer))
                If (Car Is Nothing) Then
                    Return Nothing
                End If
                If (propertyName = "Car_CarPicture") Then
                    Return Car.CarPicture
                End If
                If (propertyName = "Car_CarDocument") Then
                    Return Car.CarDocument
                End If
                If (propertyName = "Car_CarVideo") Then
                    Return Car.CarVideo
                End If
            End If
            If (Me.EntityClrFullTypeName = "car1.Truck") Then
                Dim Truck As car1.Truck = car1.Truck.Load(CType(ConvertUtilities.ChangeType(identifiersValues(0), GetType(Integer), -1),Integer))
                If (Truck Is Nothing) Then
                    Return Nothing
                End If
                If (propertyName = "Car_CarPicture") Then
                    Return Truck.CarPicture
                End If
                If (propertyName = "Car_CarDocument") Then
                    Return Truck.CarDocument
                End If
                If (propertyName = "Car_CarVideo") Then
                    Return Truck.CarVideo
                End If
                If (propertyName = "Truck_Image") Then
                    Return Truck.Image
                End If
            End If
            Return Nothing
        End Function
    End Class
End Namespace
