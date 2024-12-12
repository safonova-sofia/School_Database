Public Class ListOfStudentsTable
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Виды_классов". При необходимости она может быть перемещена или удалена.
        Me.Виды_классовTableAdapter.Fill(Me.SchoolDataSet.Виды_классов)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Список_учеников". При необходимости она может быть перемещена или удалена.
        Me.Список_учениковTableAdapter.Fill(Me.SchoolDataSet.Список_учеников)
        LoadUniqueValuesIntoComboBox1()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
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
                Col = DataGridViewTextBoxColumn9
            Case 8
                Col = DataGridViewTextBoxColumn10
            Case 9
                Col = DataGridViewTextBoxColumn11
            Case 10
                Col = DataGridViewTextBoxColumn12
            Case 11
                Col = DataGridViewTextBoxColumn13
            Case 12
                Col = DataGridViewTextBoxColumn14
            Case 13
                Col = DataGridViewTextBoxColumn15

        End Select
        If RadioButton1.Checked Then
            Список_учениковDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            Список_учениковDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Список_учениковBindingSource.Filter = "Наименование_класса='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Список_учениковBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To Список_учениковDataGridView.ColumnCount - 1
            For j = 0 To Список_учениковDataGridView.RowCount - 1
                Список_учениковDataGridView.Item(i, j).Style.BackColor = Color.White
                Список_учениковDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i

        For i = 0 To Список_учениковDataGridView.ColumnCount - 1
            For j = 0 To Список_учениковDataGridView.RowCount - 1
                If InStr(Список_учениковDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    Список_учениковDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    Список_учениковDataGridView.Item(i, j).Style.ForeColor = Color.Blue
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
                GlobalState.CurrentFilter = CType(selectedItem, DataRowView)("Наименование_класса").ToString()
            Else
                ' Если элемент не привязан, берем строковое представление
                GlobalState.CurrentFilter = selectedItem.ToString()
            End If
        End If

        ' Определить выбранный столбец для сортировки
        If ListBox1.SelectedIndex >= 0 Then
            Select Case ListBox1.SelectedIndex
                Case 0
                    GlobalState.CurrentSortColumn = "ФИО"
                Case 1
                    GlobalState.CurrentSortColumn = "Дата_рождения"
                Case 2
                    GlobalState.CurrentSortColumn = "Пол"
                Case 3
                    GlobalState.CurrentSortColumn = "Адрес"
                Case 4
                    GlobalState.CurrentSortColumn = "ФИО_отца"
                Case 5
                    GlobalState.CurrentSortColumn = "ФИО_матери"
                Case 6
                    GlobalState.CurrentSortColumn = "Дополнительная_информация"
                Case 7
                    GlobalState.CurrentSortColumn = "Количество_учеников"
                Case 8
                    GlobalState.CurrentSortColumn = "Буква"
                Case 9
                    GlobalState.CurrentSortColumn = "Год_обучения"
                Case 10
                    GlobalState.CurrentSortColumn = "Год_создания"
                Case 11
                    GlobalState.CurrentSortColumn = "Классный_руководитель"
                Case 12
                    GlobalState.CurrentSortColumn = "Наименование_класса"
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



    Private Sub LoadUniqueValuesIntoComboBox1()
        Try
            ' Очищаем ComboBox перед загрузкой
            ComboBox1.Items.Clear()

            ' Проверяем источник данных BindingSource
            Dim dataSource As DataSet = TryCast(Список_учениковBindingSource.DataSource, DataSet)
            If dataSource Is Nothing Then
                Throw New Exception("Источник данных не задан.")
            End If

            ' Проверяем наличие таблицы с именем "Список_учеников"
            If Not dataSource.Tables.Contains("Список учеников") Then
                Throw New Exception("Таблица 'Список учеников' отсутствует в DataSet.")
            End If

            ' Получаем таблицу из источника данных
            Dim studentsTable As DataTable = dataSource.Tables("Список учеников")

            ' Сохраняем уникальные значения в HashSet для исключения дубликатов
            Dim uniqueValues As New HashSet(Of String)

            ' Проходим по строкам таблицы и извлекаем значения
            For Each row As DataRow In studentsTable.Rows
                If Not IsDBNull(row("Наименование_класса")) Then ' Проверяем на NULL
                    Dim value As String = row("Наименование_класса").ToString()
                    uniqueValues.Add(value) ' Добавляем в HashSet (убирает дубликаты автоматически)
                End If
            Next

            ' Сортируем и добавляем уникальные значения в ComboBox
            ComboBox1.Items.AddRange(uniqueValues.OrderBy(Function(v) v).ToArray())
        Catch ex As Exception
            MessageBox.Show($"Ошибка загрузки уникальных значений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class