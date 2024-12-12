Public Class ListOfSubjectsTable

    Private UserType As String

    Public Sub SetUserType(type As String)
        UserType = type
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn = Nothing ' Инициализируем переменную как Nothing

        ' Проверка на выбранный элемент
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Выберите столбец для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Присваиваем значение в зависимости от выбранного индекса
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
            Case Else
                MessageBox.Show("Некорректный выбор столбца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        ' Сортировка только если колонка определена
        If Col IsNot Nothing Then
            If RadioButton1.Checked Then
                Список_предметовDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
            Else
                Список_предметовDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
            End If
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Список_предметов". При необходимости она может быть перемещена или удалена.
        Me.Список_предметовTableAdapter.Fill(Me.SchoolDataSet.Список_предметов)

        ' Логика ограничения для "Ученика"
        If UserType = "Student" Then
            MessageBox.Show("Режим ученика: некоторые данные скрыты.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Скрытие столбцов
            DataGridViewTextBoxColumn3.Visible = False
            DataGridViewTextBoxColumn5.Visible = False
            DataGridViewTextBoxColumn6.Visible = False
            DataGridViewTextBoxColumn7.Visible = False


            ' Установка доступных полей в ListBox1
            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(New String() {
                "Наименование",
                "ФИО",
                "Пол",
                "Описание"
            })
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Список_предметовBindingSource.Filter = "ФИО='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Список_предметовBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To Список_предметовDataGridView.ColumnCount - 1
            For j = 0 To Список_предметовDataGridView.RowCount - 1
                Список_предметовDataGridView.Item(i, j).Style.BackColor = Color.White
                Список_предметовDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i

        For i = 0 To Список_предметовDataGridView.ColumnCount - 1
            For j = 0 To Список_предметовDataGridView.RowCount - 1
                If InStr(Список_предметовDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    Список_предметовDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    Список_предметовDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Установить значения глобальных переменных
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim selectedItem = ComboBox1.SelectedItem
            If TypeOf selectedItem Is DataRowView Then
                ' Извлекаем значение из столбца "ФИО"
                GlobalState.CurrentFilter = CType(selectedItem, DataRowView)("ФИО").ToString()
            Else
                GlobalState.CurrentFilter = selectedItem.ToString()
            End If
        End If


        ' Определить выбранный столбец для сортировки
        If ListBox1.SelectedIndex >= 0 Then
            Select Case ListBox1.SelectedIndex
                Case 0
                    GlobalState.CurrentSortColumn = "Наименование"
                Case 1
                    GlobalState.CurrentSortColumn = "ФИО"
                Case 2
                    GlobalState.CurrentSortColumn = "Возраст"
                Case 3
                    GlobalState.CurrentSortColumn = "Пол"
                Case 4
                    GlobalState.CurrentSortColumn = "Адрес"
                Case 5
                    GlobalState.CurrentSortColumn = "Телефон"
                Case 6
                    GlobalState.CurrentSortColumn = "Паспортные_данные"
                Case 7
                    GlobalState.CurrentSortColumn = "Описание"
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class