using DevExpress.Web;
using System;

namespace Solution {
    public partial class Default : System.Web.UI.Page {
        protected string GetRowValue(GridViewDataItemTemplateContainer container) {
            return container.Grid.GetRowValuesByKeyValue(container.KeyValue, "CategoryName").ToString();
        }

        protected void keyFieldLink_Init(object sender, EventArgs e) {
            ASPxHyperLink link = sender as ASPxHyperLink;
            GridViewDataItemTemplateContainer container = link.NamingContainer as GridViewDataItemTemplateContainer;
            link.Text = "Show New Form, Key Field = " + container.KeyValue;
            link.Target = "_blank";
            link.NavigateUrl = "Default2.aspx?id=" + container.KeyValue;
        }
    }
}