Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace ChartExample.Module
	<DefaultClassOptions, DefaultProperty("FullName"), ImageName("BO_Person")> _
	Public Class Employee
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private firstName_Renamed As String
		Private lastName_Renamed As String
		Private position_Renamed As String
		<VisibleInListView(False)> _
		Public Property FirstName() As String
			Get
				Return firstName_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("FirstName", firstName_Renamed, value)
			End Set
		End Property
		<VisibleInListView(False)> _
		Public Property LastName() As String
			Get
				Return lastName_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("LastName", lastName_Renamed, value)
			End Set
		End Property
		<VisibleInDetailView(False)> _
		Public ReadOnly Property FullName() As String
			Get
				Return String.Format("{0} {1}", FirstName, LastName)
			End Get
		End Property
		Public Property Position() As String
			Get
				Return position_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Position", position_Renamed, value)
			End Set
		End Property
	End Class
End Namespace
