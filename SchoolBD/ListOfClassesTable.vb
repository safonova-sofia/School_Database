Public Class ListOfClassesTable

    Public UserType As String

    Public Sub SetUserType(type As String)
        UserType = type
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Загружаем данные в таблицу
        Me.Список_классовTableAdapter.Fill(Me.SchoolDataSet.Список_классов)

        ' Загружаем данные в ComboBox
        LoadUniqueValuesToComboBox()

        If UserType = "Student" Then
            MessageBox.Show("Режим ученика: некоторые данные скрыты.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Скрытие столбцов
            DataGridViewTextBoxColumn10.Visible = False
            DataGridViewTextBoxColumn11.Visible = False
            DataGridViewTextBoxColumn12.Visible = False
            DataGridViewTextBoxColumn8.Visible = False



            ' Установка доступных полей в ListBox1
            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(New String() {
                "Количество_учеников",
                "Буква",
                "Год_обучения",
                "Год_создания",
                "Наименование",
                "Описание",
                "ФИО",
                "Пол"
            })
        End If
    End Sub

    ' Метод для загрузки уникальных значений в ComboBox
    Private Sub LoadUniqueValuesToComboBox()
        ' Для ComboBox1 - уникальные значения из первого столбца (Наименование предмета)
        Dim uniqueNames As New HashSet(Of String)()
        For Each row As DataGridViewRow In Список_классовDataGridView.Rows
            If Not row.IsNewRow Then
                Dim nameValue As String = row.Cells(4).Value?.ToString() ' Используем индекс 0 для первого столбца
                If Not String.IsNullOrEmpty(nameValue) Then
                    uniqueNames.Add(nameValue)
                End If
            End If
        Next
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("") ' Пустое значение для сброса фильтра
        ComboBox1.Items.AddRange(uniqueNames.OrderBy(Function(v) v).ToArray())

        ' Для ComboBox2 - уникальные значения из второго столбца (Год обучения)
        Dim uniqueYears As New HashSet(Of String)()
        For Each row As DataGridViewRow In Список_классовDataGridView.Rows
            If Not row.IsNewRow Then
                Dim yearValue As String = row.Cells(2).Value?.ToString() ' Используем индекс 1 для второго столбца
                If Not String.IsNullOrEmpty(yearValue) Then
                    uniqueYears.Add(yearValue)
                End If
            End If
        Next
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("") ' Пустое значение для сброса фильтра
        ComboBox2.Items.AddRange(uniqueYears.OrderBy(Function(v) v).ToArray())
    End Sub

    ' Применение фильтра по кнопке
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filter As String = ""

        ' Проверка и фильтрация по наименованию предмета
        If Not String.IsNullOrEmpty(ComboBox1.Text) Then
            If Not IsNumeric(ComboBox1.Text) Then
                filter = $"[Наименование] = '{ComboBox1.Text}'"
            Else
                MessageBox.Show("Наименование предмета не должно содержать цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        ' Проверка и фильтрация по году обучения
        If Not String.IsNullOrEmpty(ComboBox2.Text) Then
            Dim year As Integer
            If Integer.TryParse(ComboBox2.Text, year) Then
                If Not String.IsNullOrEmpty(filter) Then
                    filter &= " AND "
                End If
                filter &= $"[Год_обучения] = {year}"
            Else
                MessageBox.Show("Некорректное значение года обучения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        ' Применяем фильтр
        If String.IsNullOrEmpty(filter) Then
            Список_классовBindingSource.RemoveFilter() ' Удаление фильтра
        Else
            Try
                Список_классовBindingSource.Filter = filter
            Catch ex As Exception
                MessageBox.Show("Ошибка при применении фильтра: " & ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Список_классовBindingSource.RemoveFilter() ' Удаляем фильтр при ошибке
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Очищаем фильтр и перезагружаем данные
        Список_классовBindingSource.RemoveFilter()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        Список_классовTableAdapter.Fill(SchoolDataSet.Список_классов) ' Перезагрузка данных


        Список_классовBindingSource.Filter = ""
        GlobalState.CurrentFilter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To Список_классовDataGridView.ColumnCount - 1
            For j = 0 To Список_классовDataGridView.RowCount - 1
                Список_классовDataGridView.Item(i, j).Style.BackColor = Color.White
                Список_классовDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i

        For i = 0 To Список_классовDataGridView.ColumnCount - 1
            For j = 0 To Список_классовDataGridView.RowCount - 1
                Dim cellValue As String = Convert.ToString(Список_классовDataGridView.Item(i, j).Value)
                If InStr(cellValue, TextBox1.Text) > 0 Then
                    Список_классовDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    Список_классовDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Установить значения глобальных переменных
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
        End If

        ' Определить выбранный столбец для сортировки
        If ListBox1.SelectedIndex >= 0 Then
            Select Case ListBox1.SelectedIndex
                Case 0
                    GlobalState.CurrentSortColumn = "Количество_учеников"
                Case 1
                    GlobalState.CurrentSortColumn = "Буква"
                Case 2
                    GlobalState.CurrentSortColumn = "Год_обучения"
                Case 3
                    GlobalState.CurrentSortColumn = "Год_создания"
                Case 4
                    GlobalState.CurrentSortColumn = "Наименование"
                Case 5
                    GlobalState.CurrentSortColumn = "Описание"
                Case 6
                    GlobalState.CurrentSortColumn = "ФИО"
                Case 7
                    GlobalState.CurrentSortColumn = "Возраст"
                Case 8
                    GlobalState.CurrentSortColumn = "Пол"
                Case 9
                    GlobalState.CurrentSortColumn = "Адрес"
                Case 10
                    GlobalState.CurrentSortColumn = "Телефон"
                Case 11
                    GlobalState.CurrentSortColumn = "Паспортные_данные"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Проверяем, выбран ли элемент в ListBox
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Выберите столбец для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Проверяем, есть ли строки для сортировки
        If Список_классовDataGridView.Rows.Count = 0 Then
            MessageBox.Show("Нет данных для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Col As System.Windows.Forms.DataGridViewColumn = Nothing

        ' Определяем, по какому столбцу сортировать
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn1
            Case 1
                Col = DataGridViewTextBoxColumn2
            Case 2
                Col = DataGridViewTextBoxColumn3
            Case 3
                Col = DataGridViewTextBoxColumn4
            Case 4
                Col = DataGridViewTextBoxColumn5
            Case 5
                Col = DataGridViewTextBoxColumn6
            Case 6
                Col = DataGridViewTextBoxColumn7
            Case 7
                Col = DataGridViewTextBoxColumn8
            Case 8
                Col = DataGridViewTextBoxColumn9
            Case 9
                Col = DataGridViewTextBoxColumn10
            Case 10
                Col = DataGridViewTextBoxColumn11
            Case 11
                Col = DataGridViewTextBoxColumn12


        End Select

        ' Если столбец не определён (не выбран корректный индекс)
        If Col Is Nothing Then
            MessageBox.Show("Выбранный столбец не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Применяем сортировку
        Try
            If RadioButton1.Checked Then
                Список_классовDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
            Else
                Список_классовDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
            End If
        Catch ex As Exception
            MessageBox.Show($"Ошибка сортировки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
