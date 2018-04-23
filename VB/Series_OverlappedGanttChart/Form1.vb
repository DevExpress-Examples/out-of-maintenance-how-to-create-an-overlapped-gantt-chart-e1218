Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_OverlappedGanttChart
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            ' Create a new chart.
            Dim overlappedGanttChart As New ChartControl()

            ' Create two Gantt series.
            Dim series1 As New Series("Planned", ViewType.Gantt)
            Dim series2 As New Series("Completed", ViewType.Gantt)

            ' Set the date-time values scale type for both series,
            ' as it is qualitative, by default.
            series1.ValueScaleType = ScaleType.DateTime
            series2.ValueScaleType = ScaleType.DateTime

            ' Add points to them.
            series1.Points.Add(New SeriesPoint("Market analysis", New DateTime() _
                                               {New DateTime(2006, 8, 16), New DateTime(2006, 8, 23)}))
            series1.Points.Add(New SeriesPoint("Feature planning", New DateTime() _
                                               {New DateTime(2006, 8, 23), New DateTime(2006, 8, 26)}))
            series1.Points.Add(New SeriesPoint("Implementation", New DateTime() _
                                               {New DateTime(2006, 8, 26), New DateTime(2006, 9, 26)}))
            series1.Points.Add(New SeriesPoint("Testing & bug fixing", New DateTime() _
                                               {New DateTime(2006, 9, 26), New DateTime(2006, 10, 10)}))

            series2.Points.Add(New SeriesPoint("Market analysis", New DateTime() _
                                               {New DateTime(2006, 8, 16), New DateTime(2006, 8, 23)}))
            series2.Points.Add(New SeriesPoint("Feature planning", New DateTime() _
                                               {New DateTime(2006, 8, 23), New DateTime(2006, 8, 26)}))
            series2.Points.Add(New SeriesPoint("Implementation", New DateTime() _
                                               {New DateTime(2006, 8, 26), New DateTime(2006, 9, 10)}))

            ' Add both series to the chart.
            overlappedGanttChart.Series.AddRange(New Series() {series1, series2})

            ' Access the view-type-specific options of the series.
            CType(series1.View, GanttSeriesView).BarWidth = 0.6
            CType(series2.View, GanttSeriesView).BarWidth = 0.3

            ' Access the type-specific options of the diagram.
            Dim myDiagram As GanttDiagram = CType(overlappedGanttChart.Diagram, GanttDiagram)

            myDiagram.AxisY.Interlaced = True
            myDiagram.AxisY.GridSpacing = 10
            myDiagram.AxisY.DateTimeOptions.Format = DateTimeFormat.MonthAndDay

            ' Add task links for the first Gantt series.
            CType(series1.View, GanttSeriesView).LinkOptions.ArrowHeight = 7
            CType(series1.View, GanttSeriesView).LinkOptions.ArrowWidth = 11
            For i As Integer = 1 To series1.Points.Count - 1
                series1.Points(i).Relations.Add(series1.Points(i - 1))
            Next i

            ' Add a progress line.
            Dim progress As New ConstantLine("Current progress", New DateTime(2006, 9, 10))
            progress.ShowInLegend = False
            progress.Title.Alignment = ConstantLineTitleAlignment.Far
            myDiagram.AxisY.ConstantLines.Add(progress)

            ' Adjust the legend.
            overlappedGanttChart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Right

            ' Add a title to the chart (if necessary).
            overlappedGanttChart.Titles.Add(New ChartTitle())
            overlappedGanttChart.Titles(0).Text = "R&D Schedule"

            ' Add the chart to the form.
            overlappedGanttChart.Dock = DockStyle.Fill
            Me.Controls.Add(overlappedGanttChart)
        End Sub
    End Class
End Namespace