<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/343264953/2023.1)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T977689)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Reporting for ASP.NET Core - How to Print and Export a Report without the Document Viewer

This example prints and exports a report in a browser without previewing it on a web page with a Document Viewer.

**Print**

On the **server side**, a controller performs the following actions:
- creates a report
- exports the report to PDF
- sends the PDF file back to the client.

On the **client-side**, a user can do one of the following:

* Print a report in a new tab.
Click a button to call the client-side `window.Open(url, "_blank")` method to open a new window that contains a PDF file and print the window content.

* Print a report in iFrame. 
Click a button to load a PDF file in the `HTMLIFrameElement` and print its content.

**Export**

The user selects the format and clicks a button to send the format to the server-side controller. The controller calls the export method for the selected format and sends the file back to the browser.

## Files to Review

- [Index.cshtml](./Views/Home/Index.cshtml)
- [ExportController.cs](./Controllers/ExportController.cs)

## Documentation

- [Export Reports](https://docs.devexpress.com/XtraReports/1302/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/export-reports)
- [Print and Export Reports in ASP.NET Core Applications](https://docs.devexpress.com/XtraReports/401841/web-reporting/asp-net-core-reporting/print-and-export-reports-in-asp-net-core-applications)

## More Examples

- [How to print and export DevExpress reports without previewing them on a web page in an ASP.NET Core Angular application](https://github.com/DevExpress-Examples/Reporting-Angular-Print-Without-Preview)
- [How to Print and Export a Report in a React Application without Displaying the Report](https://github.com/DevExpress-Examples/Reporting-React-Print-Without-Preview)
- [Reporting for ASP.NET MVC - How to print or export a report without showing a preview](https://github.com/DevExpress-Examples/reporting-print-export-report-without-showing-a-preview)
- [Reporting for ASP.NET WebForms - How to print or export a report without showing a preview](https://github.com/DevExpress-Examples/reporting-webforms-print-export-report-without-showing-a-preview)
