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
     System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, Name={Name}"),  _
     System.ComponentModel.TypeConverterAttribute(GetType(CodeFluent.Runtime.Design.NameTypeConverter))>  _
    Partial Public Class Branch
        Implements System.ICloneable, System.IComparable, System.IComparable(Of car1.Branch), CodeFluent.Runtime.ICodeFluentCollectionEntity(Of String), System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable(Of car1.Branch)
        
        Private _raisePropertyChangedEvents As Boolean = true
        
        Private _entityState As CodeFluent.Runtime.CodeFluentEntityState
        
        Private _rowVersion() As Byte
        
        Private _id As Integer = -1
        
        Private _name As String = CType(Nothing, String)
        
        Private _line1 As String = CType(Nothing, String)
        
        Private _line2 As String = CType(Nothing, String)
        
        Private _zip As String = CType(Nothing, String)
        
        Private _cityId As Integer = -1
        
        <System.NonSerializedAttribute()>  _
        Private _city As car1.City = Nothing
        
        <System.NonSerializedAttribute()>  _
        Private _pickedUpRentals As car1.RentalAgreementCollection
        
        <System.NonSerializedAttribute()>  _
        Private _returnedRentals As car1.RentalAgreementCollection
        
        <System.NonSerializedAttribute()>  _
        Private _scheduledRentals As car1.RentalAgreementCollection
        
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
                Return Me.Name
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
                Me._id = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("Id"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property Name() As String
            Get
                Return Me._name
            End Get
            Set
                If (System.Collections.Generic.EqualityComparer(Of String).Default.Equals(value, Me._name) = true) Then
                    Return
                End If
                Dim oldKey As String = Me._name
                Me._name = value
                Try 
                    Me.OnCollectionKeyChanged(oldKey)
                Catch __exception As System.ArgumentException
                    Me._name = oldKey
                    Return
                End Try
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("Name"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property Line1() As String
            Get
                Return Me._line1
            End Get
            Set
                Me._line1 = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("Line1"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property Line2() As String
            Get
                Return Me._line2
            End Get
            Set
                Me._line2 = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("Line2"))
            End Set
        End Property
        
        <System.ComponentModel.DefaultValueAttribute(CType(Nothing, String)),  _
         System.Xml.Serialization.XmlElementAttribute(IsNullable:=true, Type:=GetType(String))>  _
        Public Property Zip() As String
            Get
                Return Me._zip
            End Get
            Set
                Me._zip = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("Zip"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=false),  _
         System.ComponentModel.DataObjectFieldAttribute(true)>  _
        Public Property CityId() As Integer
            Get
                If ((Me._cityId = -1)  _
                            AndAlso (Not (Me._city) Is Nothing)) Then
                    Me._cityId = Me._city.Id
                End If
                Return Me._cityId
            End Get
            Set
                If (System.Collections.Generic.EqualityComparer(Of Integer).Default.Equals(value, Me.CityId) = true) Then
                    Return
                End If
                Me._city = Nothing
                Me._cityId = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("City"))
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("CityId"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property City() As car1.City
            Get
                If (Me._city Is Nothing) Then
                    Me._city = car1.City.Load(Me._cityId)
                End If
                Return Me._city
            End Get
            Set
                Me._cityId = -1
                Me._city = value
                Me.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("City"))
                Me.OnPropertyChanged(New System.ComponentModel.PropertyChangedEventArgs("CityId"))
            End Set
        End Property
        
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property PickedUpRentals() As car1.RentalAgreementCollection
            Get
                If (Me._pickedUpRentals Is Nothing) Then
                    If ((Me.Id = -1)  _
                                OrElse (Me.EntityState.Equals(CodeFluent.Runtime.CodeFluentEntityState.Created) = true)) Then
                        Me._pickedUpRentals = New car1.RentalAgreementCollection(Nothing, Nothing, Me, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                        Return Me._pickedUpRentals
                    End If
                    Me._pickedUpRentals = car1.RentalAgreementCollection.LoadByPickupBranch(Me)
                End If
                Return Me._pickedUpRentals
            End Get
        End Property
        
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ReturnedRentals() As car1.RentalAgreementCollection
            Get
                If (Me._returnedRentals Is Nothing) Then
                    If ((Me.Id = -1)  _
                                OrElse (Me.EntityState.Equals(CodeFluent.Runtime.CodeFluentEntityState.Created) = true)) Then
                        Me._returnedRentals = New car1.RentalAgreementCollection(Nothing, Nothing, Nothing, Me, Nothing, Nothing, Nothing, Nothing, Nothing)
                        Return Me._returnedRentals
                    End If
                    Me._returnedRentals = car1.RentalAgreementCollection.LoadByActualReturnBranch(Me)
                End If
                Return Me._returnedRentals
            End Get
        End Property
        
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ScheduledRentals() As car1.RentalAgreementCollection
            Get
                If (Me._scheduledRentals Is Nothing) Then
                    If ((Me.Id = -1)  _
                                OrElse (Me.EntityState.Equals(CodeFluent.Runtime.CodeFluentEntityState.Created) = true)) Then
                        Me._scheduledRentals = New car1.RentalAgreementCollection(Nothing, Nothing, Nothing, Nothing, Me, Nothing, Nothing, Nothing, Nothing)
                        Return Me._scheduledRentals
                    End If
                    Me._scheduledRentals = car1.RentalAgreementCollection.LoadByScheduledReturnBranch(Me)
                End If
                Return Me._scheduledRentals
            End Get
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
        
        ReadOnly Property CodeFluent_Runtime_Utilities_IKeyable_System_String__Key() As String Implements CodeFluent.Runtime.Utilities.IKeyable(Of String).Key
            Get
                Return Me.Name
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
        
        Public Event KeyChanged As System.EventHandler(Of CodeFluent.Runtime.Utilities.KeyChangedEventArgs(Of String)) Implements CodeFluent.Runtime.Utilities.IKeyable(Of String).KeyChanged
        
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
        
        Public Overloads Overridable Function Equals(ByVal branch As car1.Branch) As Boolean Implements System.IEquatable(Of car1.Branch).Equals
            If (branch Is Nothing) Then
                Return false
            End If
            If (Me.Id = -1) Then
                Return MyBase.Equals(branch)
            End If
            Return (Me.Id.Equals(branch.Id) = true)
        End Function
        
        Public Overloads Overrides Function GetHashCode() As Integer
            Return Me._id
        End Function
        
        Public Overloads Overrides Function Equals(ByVal obj As Object) As Boolean
            Dim branch As car1.Branch = Nothing
            Try 
                branch = CType(obj,car1.Branch)
            Catch icex As System.InvalidCastException
                branch = Nothing
            End Try
            Return Me.Equals(branch)
        End Function
        
        Overridable Function System_IComparable_CompareTo(ByVal value As Object) As Integer Implements System.IComparable.CompareTo
            Dim branch As car1.Branch = Nothing
            Try 
                branch = CType(value,car1.Branch)
            Catch icex As System.InvalidCastException
                branch = Nothing
            End Try
            If (branch Is Nothing) Then
                Throw New System.ArgumentException("value")
            End If
            Dim localCompareTo As Integer = Me.CompareTo(branch)
            Return localCompareTo
        End Function
        
        Public Overridable Function CompareTo(ByVal branch As car1.Branch) As Integer Implements System.IComparable(Of car1.Branch).CompareTo
            If (branch Is Nothing) Then
                Throw New System.ArgumentNullException("branch")
            End If
            Dim localCompareTo As Integer = Me.Name.CompareTo(branch.Name)
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
                    externalValidate = car1.Resources.Manager.GetStringWithDefault(culture, "car1.Branch.ExternalValidate", "Type 'car1.Branch' cannot be validated.", Nothing)
                End If
                CodeFluentPersistence.AddValidationError(results, externalValidate)
            End If
            CodeFluentPersistence.ValidateMember(culture, results, Me, Nothing)
            If (Me.Name Is CType(Nothing, String)) Then
                Dim localValidate As String = car1.Resources.Manager.GetStringWithDefault(culture, "car1.Branch.Name.NullException", "'Name' property cannot be set to '' for type 'car1.Branch'", Nothing)
                CodeFluentPersistence.AddValidationError(results, localValidate)
            End If
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
            persistence.CreateStoredProcedureCommand(Nothing, "Branch", "Delete")
            persistence.AddParameter("@Branch_Id", Me.Id, CType(-1,Integer))
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
                Me._id = CodeFluentPersistence.GetReaderValue(reader, "Branch_Id", CType(-1,Integer))
                Me._name = CodeFluentPersistence.GetReaderValue(reader, "Branch_Name", CType(CType(Nothing, String),String))
                Me._line1 = CodeFluentPersistence.GetReaderValue(reader, "Branch_Line1", CType(CType(Nothing, String),String))
                Me._line2 = CodeFluentPersistence.GetReaderValue(reader, "Branch_Line2", CType(CType(Nothing, String),String))
                Me._zip = CodeFluentPersistence.GetReaderValue(reader, "Branch_Zip", CType(CType(Nothing, String),String))
                Me.CityId = CodeFluentPersistence.GetReaderValue(reader, "Branch_City_Id", CType(-1,Integer))
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
            Me._id = CodeFluentPersistence.GetReaderValue(reader, "Branch_Id", CType(-1,Integer))
            Me._rowVersion = CodeFluentPersistence.GetReaderValue(reader, "_rowVersion", CType(Nothing,Byte()))
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false))
        End Sub
        
        Sub CodeFluent_Runtime_ICodeFluentEntity_ReadRecordOnSave(ByVal reader As System.Data.IDataReader) Implements CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave
            Me.ReadRecordOnSave(reader)
        End Sub
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Shared Function Load(ByVal id As Integer) As car1.Branch
            If (id = -1) Then
                Return Nothing
            End If
            Dim branch As car1.Branch = New car1.Branch()
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(car1.Constants.car1StoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "Branch", "Load")
            persistence.AddParameter("@Id", id, CType(-1,Integer))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    branch.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
                    branch.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    Return branch
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
        Public Shared Function LoadByName(ByVal name As String) As car1.Branch
            If (name Is CType(Nothing, String)) Then
                Return Nothing
            End If
            Dim branch As car1.Branch = New car1.Branch()
            Dim persistence As CodeFluent.Runtime.CodeFluentPersistence = CodeFluentContext.Get(car1.Constants.car1StoreName).Persistence
            persistence.CreateStoredProcedureCommand(Nothing, "Branch", "LoadByName")
            persistence.AddParameter("@Name", name, CType(Nothing, String))
            Dim reader As System.Data.IDataReader = Nothing
            Try 
                reader = persistence.ExecuteReader
                If (reader.Read = true) Then
                    branch.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.[Default])
                    branch.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged
                    Return branch
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
            persistence.CreateStoredProcedureCommand(Nothing, "Branch", "Load")
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
                car1.Branch.Delete(Me)
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
            persistence.CreateStoredProcedureCommand(Nothing, "Branch", "Save")
            persistence.AddParameter("@Branch_Id", Me.Id, CType(-1,Integer))
            persistence.AddParameter("@Branch_Name", Me.Name, CType(Nothing, String))
            persistence.AddParameter("@Branch_Line1", Me.Line1, CType(Nothing, String))
            persistence.AddParameter("@Branch_Line2", Me.Line2, CType(Nothing, String))
            persistence.AddParameter("@Branch_Zip", Me.Zip, CType(Nothing, String))
            persistence.AddParameter("@Branch_City_Id", Me.CityId, CType(-1,Integer))
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
        Public Overloads Shared Function Save(ByVal branch As car1.Branch) As Boolean
            If (branch Is Nothing) Then
                Return false
            End If
            Dim ret As Boolean = branch.Save
            Return ret
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Shared Function Insert(ByVal branch As car1.Branch) As Boolean
            Dim ret As Boolean = car1.Branch.Save(branch)
            Return ret
        End Function
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overloads Shared Function Delete(ByVal branch As car1.Branch) As Boolean
            If (branch Is Nothing) Then
                Return false
            End If
            Dim ret As Boolean = branch.Delete
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
            writer.Write("Name=")
            writer.Write(Me.Name)
            writer.Write(",")
            writer.Write("Line1=")
            writer.Write(Me.Line1)
            writer.Write(",")
            writer.Write("Line2=")
            writer.Write(Me.Line2)
            writer.Write(",")
            writer.Write("Zip=")
            writer.Write(Me.Zip)
            writer.Write(",")
            writer.Write("City=")
            If (Not (Me._city) Is Nothing) Then
                CType(Me._city,CodeFluent.Runtime.ICodeFluentObject).Trace(writer)
            Else
                writer.Write("<null>")
            End If
            writer.Write(",")
            writer.Write("_cityId=")
            writer.Write(Me._cityId)
            writer.Write(",")
            writer.Write("PickedUpRentals=")
            If (Not (Me._pickedUpRentals) Is Nothing) Then
                CType(Me._pickedUpRentals,CodeFluent.Runtime.ICodeFluentObject).Trace(writer)
            Else
                writer.Write("<null>")
            End If
            writer.Write(",")
            writer.Write("ReturnedRentals=")
            If (Not (Me._returnedRentals) Is Nothing) Then
                CType(Me._returnedRentals,CodeFluent.Runtime.ICodeFluentObject).Trace(writer)
            Else
                writer.Write("<null>")
            End If
            writer.Write(",")
            writer.Write("ScheduledRentals=")
            If (Not (Me._scheduledRentals) Is Nothing) Then
                CType(Me._scheduledRentals,CodeFluent.Runtime.ICodeFluentObject).Trace(writer)
            Else
                writer.Write("<null>")
            End If
            writer.Write(", EntityState=")
            writer.Write(Me.EntityState)
            writer.Write("]")
        End Sub
        
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], true)>  _
        Public Shared Function LoadByEntityKey(ByVal key As String) As car1.Branch
            If (key Is String.Empty) Then
                Return Nothing
            End If
            Dim branch As car1.Branch
            Dim var As Integer = CType(ConvertUtilities.ChangeType(key, GetType(Integer), -1),Integer)
            branch = car1.Branch.Load(var)
            Return branch
        End Function
        
        Protected Overridable Sub ValidateMember(ByVal culture As System.Globalization.CultureInfo, ByVal memberName As String, ByVal results As System.Collections.Generic.IList(Of CodeFluent.Runtime.CodeFluentValidationException))
        End Sub
        
        Public Overloads Function Clone(ByVal deep As Boolean) As car1.Branch
            Dim branch As car1.Branch = New car1.Branch()
            Me.CopyTo(branch, deep)
            Return branch
        End Function
        
        Public Overloads Function Clone() As car1.Branch
            Dim localClone As car1.Branch = Me.Clone(true)
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
            If (dict.Contains("Name") = true) Then
                Me.Name = CType(ConvertUtilities.ChangeType(dict("Name"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("Zip") = true) Then
                Me.Zip = CType(ConvertUtilities.ChangeType(dict("Zip"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("Line2") = true) Then
                Me.Line2 = CType(ConvertUtilities.ChangeType(dict("Line2"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("Line1") = true) Then
                Me.Line1 = CType(ConvertUtilities.ChangeType(dict("Line1"), GetType(String), CType(Nothing, String)),String)
            End If
            If (dict.Contains("CityId") = true) Then
                Me.CityId = CType(ConvertUtilities.ChangeType(dict("CityId"), GetType(Integer), -1),Integer)
            End If
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict))
        End Sub
        
        Public Overloads Overridable Sub CopyTo(ByVal branch As car1.Branch, ByVal deep As Boolean)
            If (branch Is Nothing) Then
                Throw New System.ArgumentNullException("branch")
            End If
            branch.Id = Me.Id
            branch.Name = Me.Name
            branch.Zip = Me.Zip
            branch.Line2 = Me.Line2
            branch.Line1 = Me.Line1
            branch.CityId = Me.CityId
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, branch))
        End Sub
        
        Public Overloads Overridable Sub CopyTo(ByVal dict As System.Collections.IDictionary, ByVal deep As Boolean)
            If (dict Is Nothing) Then
                Throw New System.ArgumentNullException("dict")
            End If
            dict("Id") = Me.Id
            dict("Name") = Me.Name
            dict("Zip") = Me.Zip
            dict("Line2") = Me.Line2
            dict("Line1") = Me.Line1
            dict("CityId") = Me.CityId
            Me.OnEntityAction(New CodeFluent.Runtime.CodeFluentEntityActionEventArgs(Me, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict))
        End Sub
        
        Protected Sub OnCollectionKeyChanged(ByVal key As String)
            If (Not (Me.KeyChangedEvent) Is Nothing) Then
                RaiseEvent KeyChanged(Me, New CodeFluent.Runtime.Utilities.KeyChangedEventArgs(Of String)(key))
            End If
        End Sub
    End Class
End Namespace