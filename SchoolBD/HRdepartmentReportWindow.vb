Public Class HRdepartmentReportWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Загружаем данные в таблицу "Отдел_кадров"
        Me.Отдел_кадровTableAdapter.Fill(Me.SchoolDataSet.Отдел_кадров)

        ' Получаем фильтр и сортировку из GlobalState
        Dim filter As String = GlobalState.CurrentFilter
        Dim sortColumn As String = GlobalState.CurrentSortColumn
        Dim sortDirection As System.ComponentModel.ListSortDirection = GlobalState.CurrentSortDirection

        ' Применяем фильтр и сортировку к источнику данных отчета
        ApplyFilterAndSort(filter, sortColumn, sortDirection)

        ' Обновляем отчет
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ApplyFilterAndSort(filter As String, sortColumn As String, sortDirection As System.ComponentModel.ListSortDirection)
        ' Применяем фильтр
        ' Если фильтр пустой, то фильтрация не применяется
        If Not String.IsNullOrEmpty(filter) Then
            ' Применяем фильтр к источнику данных
            Me.Отдел_кадровBindingSource.Filter = filter
        Else
            ' Если фильтра нет, очищаем фильтрацию
            Me.Отдел_кадровBindingSource.Filter = ""
        End If

        ' Применяем сортировку
        ' Если сортировка не пуста и колонка сортировки указана, применяем сортировку
        If Not String.IsNullOrEmpty(sortColumn) Then
            Dim direction As String = If(sortDirection = System.ComponentModel.ListSortDirection.Ascending, "ASC", "DESC")
            ' Если необходимо, можно изменить сортировку данных в источнике (например, через запрос SQL в адаптере или настройку источника данных)
            ' Для примера предполагаем, что сортировка должна быть настроена на уровне SQL или источника данных
            ' В данном случае, если вы используете таблицу, фильтрацию и сортировку можно применить в запросе SQL через TableAdapter.
            Me.Отдел_кадровTableAdapter.FillByFilterAndSort(Me.SchoolDataSet.Отдел_кадров, filter, sortColumn, direction)
        End If
    End Sub
End Class
