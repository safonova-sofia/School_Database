Public Class ScheduleOfLessonsTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSetNew.Расписание_занятий". При необходимости она может быть перемещена или удалена.

        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Расписание_занятий". При необходимости она может быть перемещена или удалена.
        Me.Расписание_занятийTableAdapter.Fill(Me.SchoolDataSet.Расписание_занятий)
        Расписание_занятийDataGridView.DataSource = Расписание_занятийBindingSource

        LoadComboBoxValues()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Проверяем, выбран ли элемент в ListBox
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Выберите столбец для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Проверяем, есть ли строки для сортировки
        If Расписание_занятийDataGridView.Rows.Count = 0 Then
            MessageBox.Show("Нет данных для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Col As System.Windows.Forms.DataGridViewColumn = Nothing

        ' Определяем, по какому столбцу сортировать
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = ДатаDataGridViewTextBoxColumn
            Case 1
                Col = ДеньнеделиDataGridViewTextBoxColumn
            Case 2
                Col = ВремяначалаDataGridViewTextBoxColumn
            Case 3
                Col = ВремяокончанияDataGridViewTextBoxColumn
            Case 4
                Col = НаименованиеDataGridViewTextBoxColumn
            Case 5
                Col = ОписаниеDataGridViewTextBoxColumn
            Case 6
                Col = КоличествоучениковDataGridViewTextBoxColumn
            Case 7
                Col = БукваDataGridViewTextBoxColumn
            Case 8
                Col = ГодобученияDataGridViewTextBoxColumn
            Case 9
                Col = ГодсозданияDataGridViewTextBoxColumn
            Case 10
                Col = ПреподавательDataGridViewTextBoxColumn
            Case 11
                Col = КлассныйруководительDataGridViewTextBoxColumn
            Case 12
                Col = НаименованиеклассаDataGridViewTextBoxColumn

        End Select

        ' Если столбец не определён (не выбран корректный индекс)
        If Col Is Nothing Then
            MessageBox.Show("Выбранный столбец не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Применяем сортировку
        Try
            If RadioButton1.Checked Then
                Расписание_занятийDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
            Else
                Расписание_занятийDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
            End If
        Catch ex As Exception
            MessageBox.Show($"Ошибка сортировки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Расписание_занятийBindingSource.Filter = "Дата='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Расписание_занятийBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        For i = 0 To Расписание_занятийDataGridView.ColumnCount - 1
            For j = 0 To Расписание_занятийDataGridView.RowCount - 1
                Расписание_занятийDataGridView.Item(i, j).Style.BackColor = Color.White
                Расписание_занятийDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i

        For i = 0 To Расписание_занятийDataGridView.ColumnCount - 1
            For j = 0 To Расписание_занятийDataGridView.RowCount - 1
                Dim cellValue As String = Convert.ToString(Расписание_занятийDataGridView.Item(i, j).Value)
                If InStr(cellValue, TextBox1.Text) > 0 Then
                    Расписание_занятийDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    Расписание_занятийDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        If ComboBox1.SelectedItem IsNot Nothing Then
            ' Проверяем тип объекта и извлекаем текст

            Dim selectedItem = ComboBox1.SelectedItem
            If TypeOf selectedItem Is DataRowView Then
                ' Если элемент привязан к DataRowView, извлекаем нужное значение
                GlobalState.CurrentFilter = CType(selectedItem, DataRowView)("ColumnName").ToString()
            Else
                ' Если элемент не привязан, берем строковое представление
                GlobalState.CurrentFilter = selectedItem.ToString()
            End If




            ' Попытка преобразования строки в дату
            Dim formattedDate As String = ""
            If DateTime.TryParse(GlobalState.CurrentFilter, Nothing) Then
                Dim parsedDate As DateTime = DateTime.Parse(GlobalState.CurrentFilter)
                formattedDate = parsedDate.ToString("dd.MM.yyyy") ' Применение формата только даты
            Else
                MessageBox.Show("Неверный формат даты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Сохранение отформатированной даты в фильтр
            GlobalState.CurrentFilter = formattedDate
        End If



        ' Определить выбранный столбец для сортировки
        If ListBox1.SelectedIndex >= 0 Then
            Select Case ListBox1.SelectedIndex
                Case 0
                    GlobalState.CurrentSortColumn = "Дата"
                Case 1
                    GlobalState.CurrentSortColumn = "День_недели"
                Case 2
                    GlobalState.CurrentSortColumn = "Время_начала"
                Case 3
                    GlobalState.CurrentSortColumn = "Время_окончания"
                Case 4
                    GlobalState.CurrentSortColumn = "Наименование"
                Case 5
                    GlobalState.CurrentSortColumn = "Описание"
                Case 6
                    GlobalState.CurrentSortColumn = "Количество_учеников"
                Case 7
                    GlobalState.CurrentSortColumn = "Буква"
                Case 8
                    GlobalState.CurrentSortColumn = "Год_обучения"
                Case 9
                    GlobalState.CurrentSortColumn = "Год_создания"
                Case 10
                    GlobalState.CurrentSortColumn = "Преподаватель"
                Case 11
                    GlobalState.CurrentSortColumn = "Классный_руководитель"
            End Select
        End If

        ' Установить направление сортировки
        If RadioButton1.Checked Then
            GlobalState.CurrentSortDirection = System.ComponentModel.ListSortDirection.Ascending
        Else
            GlobalState.CurrentSortDirection = System.ComponentModel.ListSortDirection.Descending
        End If

        ' Закрыть текущую форму
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filterParts As New List(Of String)

        ' Фильтрация по дате
        If Not String.IsNullOrEmpty(ComboBox1.Text) Then
            Dim dateValue As DateTime
            If DateTime.TryParseExact(ComboBox1.Text, "dd.MM.yyyy", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, dateValue) Then
                filterParts.Add($"Дата = '{dateValue:yyyy-MM-dd}'")
            Else
                MessageBox.Show("Некорректный формат даты. Используйте формат DD.MM.YYYY.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        ' Фильтрация по году обучения
        If Not String.IsNullOrEmpty(ComboBox2.Text) Then
            filterParts.Add($"Год_обучения = '{ComboBox2.Text}'")
        End If

        ' Фильтрация по букве класса
        If Not String.IsNullOrEmpty(ComboBox3.Text) Then
            filterParts.Add($"Буква = '{ComboBox3.Text}'")
        End If

        ' Объединить фильтры
        Dim filter = String.Join(" AND ", filterParts)

        ' Установить фильтр
        Расписание_занятийBindingSource.Filter = filter
        GlobalState.CurrentFilter = filter
    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To Расписание_занятийDataGridView.ColumnCount - 1
            For j = 0 To Расписание_занятийDataGridView.RowCount - 1
                Расписание_занятийDataGridView.Item(i, j).Style.BackColor = Color.White
                Расписание_занятийDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i

        For i = 0 To Расписание_занятийDataGridView.ColumnCount - 1
            For j = 0 To Расписание_занятийDataGridView.RowCount - 1
                Dim cellValue = Расписание_занятийDataGridView.Item(i, j).Value

                ' Проверяем, что значение не является DBNull и преобразуем его в строку
                If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                    Dim cellText As String = cellValue.ToString() ' Преобразование в строку

                    If InStr(cellText, TextBox1.Text) > 0 Then
                        Расписание_занятийDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                        Расписание_занятийDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                    End If
                End If
            Next j
        Next i
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Расписание_занятийBindingSource.Filter = ""
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Логика, если требуется что-то выполнить при выборе значения
    End Sub

    Private Sub LoadUniqueValues(source As BindingSource, columnName As String, comboBox As ComboBox, Optional format As String = Nothing)
        Try
            Dim uniqueValues As New HashSet(Of String)

            ' Добавляем пустое значение
            uniqueValues.Add("")

            ' Проходим по всем строкам в BindingSource
            For Each row As DataRowView In source.List
                Dim value As Object = row(columnName)
                Dim formattedValue As String

                ' Форматируем значение, если это дата
                If TypeOf value Is DateTime Then
                    formattedValue = CType(value, DateTime).ToString("dd.MM.yyyy")
                Else
                    formattedValue = value.ToString()
                End If

                ' Добавляем уникальные значения
                If Not uniqueValues.Contains(formattedValue) Then
                    uniqueValues.Add(formattedValue)
                End If
            Next

            ' Очищаем ComboBox и добавляем уникальные значения
            comboBox.Items.Clear()
            comboBox.Items.AddRange(uniqueValues.ToArray())
        Catch ex As Exception
            MessageBox.Show($"Ошибка загрузки уникальных значений для {comboBox.Name}: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadComboBoxValues()
        ' Загрузка уникальных дат в ComboBox1 (теперь формат DD.MM.YYYY)
        LoadUniqueValues(Расписание_занятийBindingSource, "Дата", ComboBox1)

        ' Загрузка уникальных чисел в ComboBox2
        LoadUniqueValues(Расписание_занятийBindingSource, "Год_обучения", ComboBox2)

        ' Загрузка уникальных букв в ComboBox3
        LoadUniqueValues(Расписание_занятийBindingSource, "Буква", ComboBox3)
    End Sub


    Private Sub Расписание_занятийDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Расписание_занятийDataGridView.CellContentClick

    End Sub
End Class