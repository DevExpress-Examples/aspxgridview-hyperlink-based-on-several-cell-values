Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace Solution

    Public Partial Class Default2
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not String.IsNullOrEmpty(Request.QueryString("id")) Then
                Response.Write("ID = " & Request.QueryString("id"))
            ElseIf Not String.IsNullOrEmpty(Request.QueryString("category")) Then
                Response.Write("Category = " & Request.QueryString("category"))
            End If
        End Sub
    End Class
End Namespace
