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

Namespace car1
    
    'CodeFluent Entities generated (http://www.softfluent.com). Date: Saturday, 12 April 2014 18:46.
    'Build:1.0.61214.0769
    <System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0769"),  _
     System.SerializableAttribute(),  _
     System.ComponentModel.DataObjectAttribute(),  _
     System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, Description={Description}, Id={Id}"),  _
     System.ComponentModel.TypeConverterAttribute(GetType(CodeFluent.Runtime.Design.NameTypeConverter))>  _
    Partial Public Class CarRepair
        Implements System.ICloneable, System.IComparable, System.IComparable(Of car1.CarRepair), CodeFluent.Runtime.ICodeFluentCollectionEntity(Of Integer), System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable(Of car1.CarRepair)
        
        Private _raisePropertyChangedEvents As Boolean = true
        
        Private _entityState As CodeFluent.Runtime.CodeFluentEntityState
        
        Private _rowVersion() As Byte
        
        Private _id As Integer = -1
        
        Private _carId As Integer = -1
        
        <System.NonSerializedAttribute()>  _
        Private _car As car1.Car = Nothing
        
        Private _repairDate As Date = CodeFluentPersistence.DefaultDateTimeValue
        
        Private _description As String = CType(Nothing, String)
        
        Public Sub New()
            MyBase.New
            Me._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created
        End Sub
        
        <System.ComponentModel.BrowsableAttribute(false),  _
         System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Overridable Property RaisePropertyChangedEvents() As Boolean
            Get
                Return Me._raisePropertyChangedEvents
            End Get
            Set
                Me._raisePropertyChangedEvents = value
            End Set
        End Property
        
        Public Overridable Property EntityKey() As String Implements CodeFluent.Runtime.ICodeFluentEntity.EntityKey
            Get
                Return Me.Id.ToString
            End Get
            Set
                Me.Id = CType(ConvertUtilities.ChangeType(value, GetType(Integer), -1),Integer)
            End Set
        End Property
        
        Public Overridable ReadOnly Property EntityDisplayName() As String Implements CodeFluent.Runtime.ICodeFluentEntity.EntityDisplayName
            Get
                Return Me.Description
            End Get
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true),  _
         System.ComponentModel.DataObjectFieldAttribute(false, true),  _
         System.ComponentModel.TypeConverterAttribute(GetType(CodeFluent.Runtime.Design.ByteArrayConverter))>  _
        Public Property RowVersion() As Byte()
            Get
                Return Me._rowVersion
            End Get
            Set
                If ((Not (value) Is Nothing)  _
                            AndAlso (value.Length = 0)) Then
                    value = Nothing
                End If
                Me._rowVersion = value
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("RowVersion"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(-1,Integer)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Integer)),  _
         System.ComponentModel.DataObjectFieldAttribute(true)>  _
        Public Property Id() As Integer
            Get
                Return Me._id
            End Get
            Set
                If (System.Collections.Generic.EqualityComparer(Of Integer).Default.Equals(value, Me._id) = true) Then
                    Return
                End If
                Dim oldKey As Integer = Me._id
                Me._id = value
                Try 
                    Me.OnCollectionKeyChanged(oldKey)
                Catch __exception As System.ArgumentException
                    Me._id = oldKey
                    Return
                End Try
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("Id"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false),  _
         System.ComponentModel.DataObjectFieldAttribute(true)>  _
        Public Property CarId() As Integer
            Get
                If ((Me._carId = -1)  _
                            AndAlso (Not (Me._car) Is Nothing)) Then
                    Me._carId = Me._car.Id
                End If
                Return Me._carId
            End Get
            Set
                If (System.Collections.Generic.EqualityComparer(Of Integer).Default.Equals(value, Me.CarId) = true) Then
                    Return
                End If
                Me._car = Nothing
                Me._carId = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("Car"))
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("CarId"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property Car() As car1.Car
            Get
                If (Me._car Is Nothing) Then
                    Me._car = car1.Car.Load(Me._carId)
                End If
                Return Me._car
            End Get
            Set
                Me._carId = -1
                Me._car = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("Car"))
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("CarId"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false, Type:=GetType(Date))>  _
        Public Property RepairDate() As Date
            Get
                Return Me._repairDate
            End Get
            Set
                Me._repairDate = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("RepairDate"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property Description() As String
            Get
                Return Me._description
            End Get
            Set
                Me._description = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("Description"))
            End Set
        End Property
        
        ReadOnly Property System_ComponentModel_IDataErrorInfo_Error() As String Implements System.ComponentModel.IDataErrorInfo.[Error]
            Get
                Return Me.Validate(System.Globalization.CultureInfo.CurrentCulture)
            End Get
        End Property
        
        ReadOnly Property System_ComponentModel_IDataErrorInfo_Item(ByVal columnName As String) As String Implements System.ComponentModel.IDataErrorInfo.Item
            Get
                Return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, Me, columnName, Nothing)
            End Get
        End Property
        
        ReadOnly Property CodeFluent_Runtime_Utilities_IKeyable_System_Int32__Key() As Integer Implements CodeFluent.Runtime.Utilities.IKeyable(Of Integer).Key
            Get
                Return Me.Id
            End Get
        End Property
        
        Public Overridable Property EntityState() As CodeFluent.Runtime.CodeFluentEntityState Implements CodeFluent.Runtime.ICodeFluentEntity.EntityState
            Get
                Return Me._entityState
            End Get
            Set
                If (System.Collections.Generic.EqualityComparer(Of CodeFluent.Runtime.CodeFluentEntityState).Default.Equals(value, Me.EntityState) = true) Then
                    Return
                End If
                If ((Me._entityState = CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted)  _
                            AndAlso (value = CodeFluent.Runtime.CodeFluentEntityState.Modified)) Then
                    Return
                End If
                If ((Me._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created)  _
                            AndAlso (value = CodeFluent.Runtime.CodeFluentEntityState.Modified)) Then
                    Return
                End If
                Me._entityState = value
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("EntityState"))
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Public Event EntityAction As CodeFluent.Runtime.CodeFluentEntityActionEventHandler Implements CodeFluent.Runtime.ICodeFluentEntity.EntityAction
        
        Public Event KeyChanged As System.EventHandler(Of CodeFluent.Runtime.Utilities.KeyChangedEventArgs(Of Integer)) Implements CodeFluent.Runtime.Utilities.IKeyable(Of Integer).KeyChanged
        
        Protected Overridable Sub OnPropertyChanged(ByVal e As System.ComponentModel.PropertyChangedEventArgs)
            If (Me.RaisePropertyChangedEvents = false) Then
                Return
            End If
            If (Not (Me.PropertyChangedEvent) Is Nothing) Then
                RaiseEvent PropertyChanged(Me, e)
            End If
        End Sub
        
        Protected Overridable Sub OnEntityAction(ByVal e As CodeFluent.Runtime.CodeFluentEntityActionEventArgs)
            If (Not (Me.EntityActionEvent) Is Nothing) Then
                RaiseEvent EntityAction(Me, e)
            End If
        End Sub
        
        Public Overloads Overridable Function Equals(ByVal carRepair As car1.CarRepair) As Boolean Implements System.IEquatable(Of car1.CarRepair).Equals
            If (carRepair Is Nothing) Then
                Return false
            End If
            If (Me.Id = -1) Then
                Return MyBase.Equals(carRepair)
            End If
            Return (Me.Id.Equals(carRepair.Id) = true)
        End Function
        
        Public Overloads Overrides Function GetHashCode() As Integer
            Return Me._id
        End Function
        
        Public Overloads Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim carRepair As car1.CarRepair = Nothing
            Try 
                carRepair = CType(obj,car1.CarRepair)
            Catch icex As System.InvalidCastException
                carRepair = Nothing
            End Try
            Return Me.Equals(carRepair)
        End Function
        
        Overridable Function System_IComparable_CompareTo(ByVal value As Object) As Integer Implements System.IComparable.CompareTo
            Dim carRepair As car1.CarRepair = Nothing
            Try 
                carRepair = CType(value,car1.CarRepair)
            Catch icex As System.InvalidCastException
                carRepair = Nothing
            End Try
            If (carRepair Is Nothing) Then
                Throw New System.ArgumentException("value")
            End If
            Dim localCompareTo As Integer = Me.CompareTo(carRepair)
            Return localCompareTo
        End Function
        
        Public Overridable Function CompareTo(ByVal carRepair As car1.CarRepair) As Integer Implements System.IComparable(Of car1.CarRepair).CompareTo
            If (carRepair Is Nothing) Then
                Throw New System.ArgumentNullException("carRepair")
            End If
            Dim localCompareTo As Integer = Me.Id.CompareTo(carRepair.Id)
            Return localCompareTo
        End Function
        
        Public Overloads Overridable Function Validate(ByVal culture As System.Globalization.CultureInfo) As String
            Return CodeFluentPersistence.Validate(culture, Me, Nothing)
        End Function
        
        Public Overloads Overridable Sub Validate(ByVal culture As System.Globalization.CultureInfo, ByVal results As System.Collections.Generic.IList(Of CodeFluent.Runtime.CodeFluentValidationException)) Implements CodeFluent.Runtime.ICodeFluentSummaryValidator.Validate
            Dim evt As CodeFluent.Runtime.CodeFluentEntityActionEventArgs = New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results)
            evt.Culture = culture
            Me.OnEntityAction(evt)
            If (evt.Cancel = true) Then
                Dim externalValidate As String
                If (Not (evt.Argument) Is Nothing) Then
                    externalValidate = evt.Argument.ToString
                Else
                    externalValidate = car1.Resources.Manager.GetStringWithDefault(culture, "car1.CarRepair.ExternalValidate", "Type 'car1.CarRepair' cannot be validated.", Nothing)
                End If
                CodeFluentPersistence.AddValidationError(results, externalValidate)
            End If
            CodeFluentPersistence.ValidateMember(culture, results, Me, Nothing)
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results))
        End Sub
        
        Public Overloads Sub Validate()
            Dim var As String = Me.Validate(System.Globalization.CultureInfo.CurrentCulture)
            If (Not (var) Is Nothing) Then
                Throw New CodeFluent.Runtime.CodeFluentValidationException(var)
            End If
        End Sub
        
        Function CodeFluent_Runtime_ICodeFluentValidator_Validate(ByVal culture As System.Globalization.CultureInfo) As String Implements CodeFluent.Runtime.ICodeFluentValidator.Validate
            Dim localValidate As String = Me.Validate(culture)
            Return localValidate
        End Function
        
        Sub CodeFluent_Runtime_ICodeFluentMemberValidator_Validate(ByVal culture As System.Globalization.CultureInfo, ByVal memberName As String, ByVal results As System.Collections.Generic.IList(Of CodeFluent.Runtime.CodeFluentValidationException)) Implements CodeFluent.Runtime.ICodeFluentMemberValidator.Validate
            Me.ValidateMember(culture, memberName, results)
        End Sub
        
        Public Overloads Overridable Function Delete() As Boolean Implements CodeFluent.Runtime.ICodeFluentEntity.Delete
            Dim ret As Boolean = false
            Dim evt As CodeFluent.Runtime.CodeFluentEntityActionEventArgs = New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true)
            Me.OnEntityAction(evt)
            If (evt.Cancel = true) Then
                Return ret
            End If
            If (Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted) Then
                Return ret
            End If
            If (Me.RowVersion Is Nothing) Then
                Return ret
            End If
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(car1.Constants.car1StoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "CarRepair", "Delete")
            persistence.AddParameter("@CarRepair_Id", Me.Id, CType(-1,Integer))
            persistence.AddParameter("@_rowVersion", Me.RowVersion)
            persistence.ExecuteNonQuery
            Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false))
            ret = true
            Return ret
        End Function
        
        Protected Overridable Sub ReadRecord(ByVal reader As System.Data.IDataReader, ByVal options As CodeFluent.Runtime.CodeFluentReloadOptions)
            If (reader Is Nothing) Then
                Throw New System.ArgumentNullException("reader")
            End If
            If (((options And CodeFluent.Runtime.CodeFluentReloadOptions.Properties)  _
                        = 0)  _
                        = false) Then
                Me._id = CodeFluentPersistence.GetReaderValue(reader, "CarRepair_Id", CType(-1,Integer))
                Me.CarId = CodeFluentPersistence.GetReaderValue(reader, "CarRepair_Car_Id", CType(-1,Integer))
                Me._repairDate = CodeFluentPersistence.GetReaderValue(reader, "CarRepair_RepairDate", CType(CodeFluentPersistence.DefaultDateTimeValue,Date))
                Me._description = CodeFluentPersistence.GetReaderValue(reader, "CarRepair_Description", CType(CType(Nothing, String),String))
            End If
            If (((options And CodeFluent.Runtime.CodeFluentReloadOptions.RowVersion)  _
                        = 0)  _
                        = false) Then
                Me._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", CType(Nothing,Byte()))
            End If
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false))
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentEntity_ReadRecord(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentEntity.ReadRecord
            Me.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
        End Sub
        
        Protected Overridable Sub ReadRecordOnSave(ByVal reader As System.Data.IDataReader)
            If (reader Is Nothing) Then
                Throw New System.ArgumentNullException("reader")
            End If
            Me._id = CodeFluentPersistence.GetReaderValue(reader, "CarRepair_Id", CType(-1,Integer))
            Me._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", CType(Nothing,Byte()))
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false))
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentEntity_ReadRecordOnSave(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave
            Me.ReadRecordOnSave(reader)
        End Sub
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Shared Function Load(ByVal id As Integer) As car1.CarRepair
            If (id = -1) Then
                Return Nothing
            End If
            Dim carRepair As car1.CarRepair = New car1.CarRepair()
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(car1.Constants.car1StoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "CarRepair", "Load")
            persistence.AddParameter("@Id", id, CType(-1,Integer))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    carRepair.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
                    carRepair.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    Return carRepair
                End If
            Finally
                If (Not (reader) Is Nothing) Then
                    reader.Dispose
                End If
                persistence.CompleteCommand
            End Try
            Return Nothing
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], false)>  _
        Public Shared Function LoadById(ByVal id As Integer) As car1.CarRepair
            If (id = -1) Then
                Return Nothing
            End If
            Dim carRepair As car1.CarRepair = New car1.CarRepair()
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(car1.Constants.car1StoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "CarRepair", "LoadById")
            persistence.AddParameter("@Id", id, CType(-1,Integer))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    carRepair.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
                    carRepair.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    Return carRepair
                End If
            Finally
                If (Not (reader) Is Nothing) Then
                    reader.Dispose
                End If
                persistence.CompleteCommand
            End Try
            Return Nothing
        End Function
        
        Public Overridable Function Reload(ByVal options As CodeFluent.Runtime.CodeFluentReloadOptions) As Boolean
            Dim ret As Boolean = false
            If (Me.Id = -1) Then
                Return ret
            End If
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(car1.Constants.car1StoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "CarRepair", "Load")
            persistence.AddParameter("@Id", Me.Id, CType(-1,Integer))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    Me.ReadRecord(reader, options)
                    Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    ret = true
                Else
                    Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted
                End If
            Finally
                If (Not (reader) Is Nothing) Then
                    reader.Dispose
                End If
                persistence.CompleteCommand
            End Try
            Return ret
        End Function
        
        Protected Overridable Function BaseSave(ByVal force As Boolean) As Boolean
            If (Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted) Then
                car1.CarRepair.Delete(Me)
                Return false
            End If
            Dim evt As CodeFluent.Runtime.CodeFluentEntityActionEventArgs = New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true)
            Me.OnEntityAction(evt)
            If (evt.Cancel = true) Then
                Return false
            End If
            CodeFluentPersistence.ThrowIfDeleted(Me)
            Me.Validate
            If ((force = false)  _
                        AndAlso (Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged)) Then
                Return false
            End If
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(car1.Constants.car1StoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "CarRepair", "Save")
            persistence.AddParameter("@CarRepair_Id", Me.Id, CType(-1,Integer))
            persistence.AddParameter("@CarRepair_Car_Id", Me.CarId, CType(-1,Integer))
            persistence.AddParameter("@CarRepair_RepairDate", Me.RepairDate, CodeFluentPersistence.DefaultDateTimeValue)
            persistence.AddParameter("@CarRepair_Description", Me.Description, CType(Nothing, String))
            persistence.AddParameter("@_trackLastWriteUser", persistence.Context.User.Name)
            persistence.AddParameter("@_rowVersion", Me.RowVersion)
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    Me.ReadRecordOnSave(reader)
                End If
                CodeFluentPersistence.NextResults(reader)
            Finally
                If (Not (reader) Is Nothing) Then
                    reader.Dispose
                End If
                persistence.CompleteCommand
            End Try
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false))
            Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
            Return true
        End Function
        
        Public Overloads Overridable Function Save() As Boolean Implements CodeFluent.Runtime.ICodeFluentEntity.Save
            Dim localSave As Boolean = Me.BaseSave(false)
            Return localSave
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Shared Function Save(ByVal carRepair As car1.CarRepair) As Boolean
            If (carRepair Is Nothing) Then
                Return false
            End If
            Dim ret As Boolean = carRepair.Save
            Return ret
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Shared Function Insert(ByVal carRepair As car1.CarRepair) As Boolean
            Dim ret As Boolean = car1.CarRepair.Save(carRepair)
            Return ret
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overloads Shared Function Delete(ByVal carRepair As car1.CarRepair) As Boolean
            If (carRepair Is Nothing) Then
                Return false
            End If
            Dim ret As Boolean = carRepair.Delete
            Return ret
        End Function
        
        Public Function Trace() As String
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder()
            Dim stringWriter As System.IO.StringWriter = New System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture)
            Dim writer As System.CodeDom.Compiler.IndentedTextWriter = New System.CodeDom.Compiler.IndentedTextWriter(stringWriter)
            Me.BaseTrace(writer)
            writer.Flush
            CType(writer,System.IDisposable).Dispose
            CType(stringWriter,System.IDisposable).Dispose
            Dim sr As String = stringBuilder.ToString
            Return sr
        End Function
        
        <System.ComponentModel.BrowsableAttribute(false),  _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)>  _
        Sub CodeFluent_Runtime_ICodeFluentObject_Trace(ByVal writer As System.CodeDom.Compiler.IndentedTextWriter) Implements CodeFluent.Runtime.ICodeFluentObject.Trace
            Me.BaseTrace(writer)
        End Sub
        
        Protected Overridable Sub BaseTrace(ByVal writer As System.CodeDom.Compiler.IndentedTextWriter)
            writer.Write("[")
            writer.Write("Id=")
            writer.Write(Me.Id)
            writer.Write(",")
            writer.Write("Car=")
            If (Not (Me._car) Is Nothing) Then
                CType(Me._car,CodeFluent.Runtime.ICodeFluentObject).Trace(writer)
            Else
                writer.Write("<null>")
            End If
            writer.Write(",")
            writer.Write("_carId=")
            writer.Write(Me._carId)
            writer.Write(",")
            writer.Write("RepairDate=")
            writer.Write(Me.RepairDate)
            writer.Write(",")
            writer.Write("Description=")
            writer.Write(Me.Description)
            writer.Write(", EntityState=")
            writer.Write(Me.EntityState)
            writer.Write("]")
        End Sub
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Shared Function LoadByEntityKey(ByVal key As String) As car1.CarRepair
            If (key Is String.Empty) Then
                Return Nothing
            End If
            Dim carRepair As car1.CarRepair
            Dim var As Integer = CType(ConvertUtilities.ChangeType(key, GetType(Integer), -1),Integer)
            carRepair = car1.CarRepair.Load(var)
            Return carRepair
        End Function
        
        Protected Overridable Sub ValidateMember(ByVal culture As System.Globalization.CultureInfo, ByVal memberName As String, ByVal results As System.Collections.Generic.IList(Of CodeFluent.Runtime.CodeFluentValidationException))
        End Sub
        
        Public Overloads Function Clone(ByVal deep As Boolean) As car1.CarRepair
            Dim carRepair As car1.CarRepair = New car1.CarRepair()
            Me.CopyTo(carRepair, deep)
            Return carRepair
        End Function
        
        Public Overloads Function Clone() As car1.CarRepair
            Dim localClone As car1.CarRepair = Me.Clone(true)
            Return localClone
        End Function
        
        Function System_ICloneable_Clone() As Object Implements System.ICloneable.Clone
            Dim localClone As Object = Me.Clone
            Return localClone
        End Function
        
        Public Overridable Sub CopyFrom(ByVal dict As System.Collections.IDictionary, ByVal deep As Boolean)
            If (dict Is Nothing) Then
                Throw New System.ArgumentNullException("dict")
            End If
            If (dict.Contains("Id") = true) Then
                Me.Id = CType(ConvertUtilities.ChangeType(dict("Id"), GetType(Integer), -1),Integer)
            End If
            If (dict.Contains("RepairDate") = true) Then
                Me.RepairDate = CType(ConvertUtilities.ChangeType(dict("RepairDate"), GetType(Date), CodeFluentPersistence.DefaultDateTimeValue),Date)
            End If
            If (dict.Contains("Description") = true) Then
                Me.Description = CType(ConvertUtilities.ChangeType(dict("Description"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("CarId") = true) Then
                Me.CarId = CType(ConvertUtilities.ChangeType(dict("CarId"), GetType(Integer), -1),Integer)
            End If
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict))
        End Sub
        
        Public Overloads Overridable Sub CopyTo(ByVal carRepair As car1.CarRepair, ByVal deep As Boolean)
            If (carRepair Is Nothing) Then
                Throw New System.ArgumentNullException("carRepair")
            End If
            carRepair.Id = Me.Id
            carRepair.RepairDate = Me.RepairDate
            carRepair.Description = Me.Description
            carRepair.CarId = Me.CarId
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, carRepair))
        End Sub
        
        Public Overloads Overridable Sub CopyTo(ByVal dict As System.Collections.IDictionary, ByVal deep As Boolean)
            If (dict Is Nothing) Then
                Throw New System.ArgumentNullException("dict")
            End If
            dict("Id") = Me.Id
            dict("RepairDate") = Me.RepairDate
            dict("Description") = Me.Description
            dict("CarId") = Me.CarId
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict))
        End Sub
        
        Protected Sub OnCollectionKeyChanged(ByVal key As Integer)
            If (Not (Me.KeyChangedEvent) Is Nothing) Then
                RaiseEvent KeyChanged(Me, New CodeFluent.Runtime.Utilities.KeyChangedEventArgs(Of Integer)(key))
            End If
        End Sub
    End Class
End Namespace
