Imports DevExpress.Web
Imports System

Namespace Solution

    Public Partial Class [Default]
        Inherits Web.UI.Page

        Protected Function GetRowValue(ByVal container As GridViewDataItemTemplateContainer) As String
            Return container.Grid.GetRowValuesByKeyValue(container.KeyValue, "CategoryName").ToString()
        End Function

        Protected Sub keyFieldLink_Init(ByVal sender As Object, ByVal e As EventArgs)
            Dim link As ASPxHyperLink = TryCast(sender, ASPxHyperLink)
            Dim container As GridViewDataItemTemplateContainer = TryCast(link.NamingContainer, GridViewDataItemTemplateContainer)
            link.Text = "Show New Form, Key Field = " & container.KeyValue
            link.Target = "_blank"
            link.NavigateUrl = "Default2.aspx?id=" & container.KeyValue
        End Sub
    End Class
End Namespace
