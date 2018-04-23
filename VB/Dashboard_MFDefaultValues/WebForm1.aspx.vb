Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb

Namespace Dashboard_MFDefaultValues
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxDashboardViewer1_MasterFilterDefaultValues(ByVal sender As Object,
                                                                     ByVal e As MasterFilterDefaultValuesWebEventArgs)
            If e.ItemComponentName = "gridDashboardItem1" Then
                e.FilterValues = e.AvailableFilterValues.Where(Function(v) CStr(v("Sales Person")) = "Laura Callahan")
            End If
            If e.ItemComponentName = "treeViewDashboardItem1" Then
                e.FilterValues = e.AvailableFilterValues.Where(Function(v) CStr(v("Category")) = "Beverages" _
                                                                   OrElse CStr(v("Product")) = "Aniseed Syrup")
            End If
        End Sub

        Protected Sub ASPxDashboardViewer1_RangeFilterDefaultValue(ByVal sender As Object,
                                                                   ByVal e As RangeFilterDefaultValueEventArgs)
            If e.DashboardItemName = "rangeFilterDashboardItem1" Then
                e.Range = New RangeFilterSelection(New Date(2015, 6, 1), New Date(2016, 4, 1))
            End If
        End Sub
    End Class
End Namespace