<%@ Page Language="VB" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Solution.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to display a hyperlink based on several cell values</title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:aspxgridview id="grid" clientinstancename="grid" runat="server" datasourceid="AccessDataSource2" keyfieldname="CategoryID" previewfieldname="Notes" autogeneratecolumns="False" enablerowscache="False">
            <columns>
                <dx:gridviewdatatextcolumn fieldname="CategoryID" readonly="True">
                    <editformsettings visible="False" />
                </dx:gridviewdatatextcolumn>
                <dx:gridviewdatatextcolumn fieldname="CategoryName">
                </dx:gridviewdatatextcolumn>
                <dx:gridviewdatatextcolumn fieldname="Description">
                </dx:gridviewdatatextcolumn>
                <dx:gridviewdatatextcolumn caption="ASPxHyperlink in DataItemTemplate">
                    <dataitemtemplate>
                        <dx:aspxhyperlink runat="server" id="keyFieldLink" oninit="keyFieldLink_Init"></dx:aspxhyperlink>
                    </dataitemtemplate>
                </dx:gridviewdatatextcolumn>
                <dx:gridviewdatatextcolumn caption="The 'a' tag in DataItemTemplate">
                    <dataitemtemplate>
                        <a id="clickElement" target="_blank" href="Default2.aspx?category=<%# GetRowValue(Container)%>"><%# "Show New Form, CategoryName = " + Eval("CategoryName").ToString()%></a>
                    </dataitemtemplate>
                </dx:gridviewdatatextcolumn>
            </columns>
        </dx:aspxgridview>
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT * FROM [Categories]"></asp:AccessDataSource>
    </form>
</body>
</html>
