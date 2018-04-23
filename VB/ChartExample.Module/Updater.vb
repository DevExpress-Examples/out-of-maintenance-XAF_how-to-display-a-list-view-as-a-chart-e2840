Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl
Imports System.Collections
Imports System.Collections.Generic

Namespace ChartExample.Module
    Public Class Updater
        Inherits ModuleUpdater
        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            Dim employees As List(Of Employee) = New List(Of Employee)()
            For i As Integer = 0 To 5
                employees.Add(ObjectSpace.CreateObject(Of Employee)())
            Next i
            employees(0).FirstName = "Mary"
            employees(0).LastName = "Tellitson"
            employees(0).Position = "Developer"

            employees(1).FirstName = "Robert"
            employees(1).LastName = "King"
            employees(1).Position = "Senior Developer"

            employees(2).FirstName = "Steven"
            employees(2).LastName = "Buchanan"
            employees(2).Position = "Developer"

            employees(3).FirstName = "Nancy"
            employees(3).LastName = "Davolio"
            employees(3).Position = "Developer"

            employees(4).FirstName = "Michael"
            employees(4).LastName = "Suyama"
            employees(4).Position = "Developer"

            employees(5).FirstName = "Andrew"
            employees(5).LastName = "Fuller"
            employees(5).Position = "Sales Manager"

            For Each employee As Employee In employees
                employee.Save()
            Next employee
        End Sub
    End Class
End Namespace
