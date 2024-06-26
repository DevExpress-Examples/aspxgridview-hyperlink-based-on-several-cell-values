<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E993)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# How to use a hyperlink whose argument depends on several cell values in the ASPxGridView


<p>It is an often situation when a developer should include sever field values in a hyperlink shown in a GridView column cells. The best solution to this problem is to use templates. The attached example shows how this can be done and suggests two similar approaches:</p>
<p>1) in the "simple" case the href parameter of the <a> element is defined by the KeyValue of the processed row<br> 2) in the "complex" case, the href parameter of the <a> element is defined in the server side GetRowValue method.<br><br><strong>Update:</strong><br>If you want to use GridViewDataHyperLinkColumn and preserve its functionality, use unbound columns instead of the DataItem template. Please refer to the <a href="https://www.devexpress.com/Support/Center/p/T517626">ASPxGridView - How to create GridViewDataHyperLinkColumn whose URL depends on several column values</a> example for more information. </p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=aspxgridview-hyperlink-based-on-several-cell-values&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=aspxgridview-hyperlink-based-on-several-cell-values&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
