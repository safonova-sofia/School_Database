Imports System.Data.SqlClient


Public Class ListOfSubjectsReportWindow

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
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Список_предметов". При необходимости она может быть перемещена или удалена.

        Dim baseQuery As String = "SELECT * FROM [Список предметов]"
        Dim filterQuery As String = ""
        Dim sortQuery As String = ""

        ' Применить фильтр
        If Not String.IsNullOrEmpty(_appliedFilter) Then
            filterQuery = " WHERE ФИО = '" & _appliedFilter.Replace("'", "''") & "'"
        End If

        ' Применить сортировку
        If Not String.IsNullOrEmpty(_sortColumn) AndAlso Not String.IsNullOrEmpty(_sortDirection) Then
            sortQuery = " ORDER BY CAST(" & _sortColumn & " AS NVARCHAR(MAX)) " & _sortDirection
        End If

        ' Итоговый SQL-запрос
        Dim query As String = baseQuery & filterQuery & sortQuery


        Try
            ' Загрузить данные в отчет
            Using connection As New SqlConnection("Data Source=DESKTOP-NI2O2HU;Initial Catalog=School;Integrated Security=True")
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "Список предметов")

                ' Привязать данные к отчету
                Dim reportDataSource As New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataSet.Tables("Список предметов"))
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