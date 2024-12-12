

Imports System.Data.SqlClient
Public Class ScheduleOfLessonsReportWindow
    Private _appliedFilter As String
    Private _sortColumn As String
    Private _sortDirection As String

    ' Конструктор, принимающий параметры фильтра и сортировки
    Public Sub New(appliedFilter As String, sortColumn As String, sortDirection As String)
        InitializeComponent()
        _appliedFilter = appliedFilter
        _sortColumn = sortColumn
        ' Преобразуем направление сортировки в SQL-совместимый формат
        _sortDirection = If(sortDirection = "Ascending", "ASC", "DESC")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Расписание". При необходимости она может быть перемещена или удалена.
        Dim baseQuery As String = "SELECT * FROM [Расписание занятий]"
        Dim filterQuery As String = ""
        Dim sortQuery As String = ""

        ' Применить фильтр
        If Not String.IsNullOrEmpty(_appliedFilter) Then
            filterQuery = " WHERE " & _appliedFilter
        End If

        ' Если есть сортировка
        If Not String.IsNullOrEmpty(_sortColumn) AndAlso Not String.IsNullOrEmpty(_sortDirection) Then
            sortQuery = " ORDER BY " & _sortColumn & " " & _sortDirection
        End If

        ' Итоговый запрос
        Dim query As String = baseQuery & filterQuery & sortQuery


        Try
            ' Загрузить данные в отчет
            Using connection As New SqlConnection("Data Source=DESKTOP-NI2O2HU;Initial Catalog=School;Integrated Security=True")
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "Расписание занятий")

                ' Привязать данные к отчету
                Dim reportDataSource As New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataSet.Tables("Расписание занятий"))
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
            End Using

            ' Обновить отчет
            Me.ReportViewer1.RefreshReport()
        Catch ex As SqlException
            MessageBox.Show("Ошибка выполнения SQL-запроса: " & ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class