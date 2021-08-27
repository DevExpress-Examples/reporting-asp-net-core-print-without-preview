<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/343264953/2020.2)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T977689)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
## How to Print and Export a Report in the  ASP.NET Core Application without the Document Viewer

This example prints and exports a report in a browser without previewing it on a web page with a Document Viewer.

**Print**

On the **server side**, a controller performs the following actions:
- [creates a report](https://docs.devexpress.com/XtraReports/2440/get-started-with-devexpress-reporting/create-a-report-from-a-to-z);
- [exports the report to PDF](https://docs.devexpress.com/XtraReports/2574/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/export-reports/export-to-pdf) with the [XtraReport.ExportToPdfAsync](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.ExportToPdfAsync.overloads) method;
- sends the PDF file back to the client.

On the **client-side**, a user can do one of the following:

* Print a report in a new tab.
Click a button to call the client-side `window.Open(url, "_blank")` method to open a new window that contains a PDF file and print the window content.

* Print a report in iFrame. 
Click a button to load a PDF file in the `HTMLIFrameElement` and print its content.

*NOTE: We don't recommend printing with an invisible iFrame element because not all browsers support it.* 

**Export**

The user selects the format and clicks a button to send the format to the server-side controller. The controller calls the export method for the selected format and sends the file back to the browser.

For more information review the following help topic:
*  [Export Reports](https://docs.devexpress.com/XtraReports/1302/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/export-reports).
