<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574063/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1218)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Series_OverlappedGanttChart/Form1.cs) (VB: [Form1.vb](./VB/Series_OverlappedGanttChart/Form1.vb))
<!-- default file list end -->
# How to create an Overlapped Gantt chart

The following example demonstrates how to create an [Overlapped Gantt](https://docs.devexpress.com/WindowsForms/2982/controls-and-libraries/chart-control/series-views/2d-series-views/gantt-series-views/overlapped-gantt-chart?p=netframework) chart at runtime.

Note that this series view type is associated with the [Gantt Diagram](https://docs.devexpress.com/WindowsForms/5910/controls-and-libraries/chart-control/diagram/gantt-diagram?p=netframework) type, and you should cast your [diagram](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.Diagram?p=netframework) object to this type, in order to access its specific options.

Starting from v14.1, text pattern properties ([AxisLabel.TextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.AxisLabel.TextPattern?p=netframework), [SeriesLabelBase.TextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesLabelBase.TextPattern?p=netframework), [SeriesBase.LegendTextPattern](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.LegendTextPattern?p=netframework)) have been introduced instead of point options.
