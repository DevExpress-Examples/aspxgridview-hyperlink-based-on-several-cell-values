<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128543418/22.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E993)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Grid View for ASP.NET Web Forms - How to display a hyperlink based on several cell values
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128543418/)**
<!-- run online end -->

This example demonstrates how to configure a grid column's data item template to display a hyperlink based on several cell values.

> For an example on how to implement a similar functionality based on an unbound GridViewDataHyperLinkColumn, refer to the following example: [Grid View for ASP.NET Web Forms - How to create a HyperLink column whose URL depends on several column values](https://www.devexpress.com/Support/Center/p/T517626)

## Implementation Details

The example application illustrates a common use case scenario when values from several data fields are used to produce the URL and/or display text of a hyperlink displayed within a grid cell.

Two equivalent techniques are demonstrated:

1. Based on the ASPxHyperLink control. The control's NavigateUrl property value includes the processed row's KeyValue property value.

2. Based on the `<a>` HTML element. The server `GetRowValue` method calculates the `href` parameter's value.

## Files to Review

## Documentation

## More Examples