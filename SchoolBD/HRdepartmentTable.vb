Public Class HRdepartmentTable

    Private UserType As String

    Public Sub SetUserType(type As String)
        UserType = type
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Загрузка данных в таблицы
        Me.ДолжностиTableAdapter.Fill(Me.SchoolDataSet.Должности)
        Me.Отдел_кадровTableAdapter.Fill(Me.SchoolDataSet.Отдел_кадров)

        ' Логика ограничения для "Учителя"
        If UserType = "Teacher" Then
            MessageBox.Show("Режим учителя: некоторые данные скрыты.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Скрытие столбцов
            DataGridViewTextBoxColumn10.Visible = False
            DataGridViewTextBoxColumn9.Visible = False
            DataGridViewTextBoxColumn8.Visible = False
            DataGridViewTextBoxColumn6.Visible = False
            DataGridViewTextBoxColumn2.Visible = False

            ' Установка доступных полей в ListBox1
            ListBox1.Items.Clear()
            ListBox1.Items.AddRange(New String() {
                "Наименование должности",
                "Обязанности",
                "Требования",
                "ФИО",
                "Пол"
            })
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn = Nothing ' Инициализация переменной

        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn1
            Case 1
                Col = DataGridViewTextBoxColumn3
            Case 2
                Col = DataGridViewTextBoxColumn4
            Case 3
                Col = DataGridViewTextBoxColumn5
            Case 4
                Col = DataGridViewTextBoxColumn7
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

            Case Else
                MessageBox.Show("Выберите корректный столбец для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
        End Select

        If Col IsNot Nothing Then
            If RadioButton1.Checked Then
                Отдел_кадровDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
            Else
                Отдел_кадровDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Отдел_кадровBindingSource.Filter = "Наименование_должности='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Отдел_кадровBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To Отдел_кадровDataGridView.ColumnCount - 1
            For j = 0 To Отдел_кадровDataGridView.RowCount - 1
                Отдел_кадровDataGridView.Item(i, j).Style.BackColor = Color.White
                Отдел_кадровDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i

        For i = 0 To Отдел_кадровDataGridView.ColumnCount - 1
            For j = 0 To Отдел_кадровDataGridView.RowCount - 1
                If InStr(Отдел_кадровDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    Отдел_кадровDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    Отдел_кадровDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Отдел_кадровDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Отдел_кадровDataGridView.CellContentClick

    End Sub
End Class