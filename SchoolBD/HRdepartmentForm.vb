Public Class HRdepartmentForm



    Private UserType As String

    ' Метод для установки типа пользователя
    Public Sub SetUserType(type As String)
        UserType = type
    End Sub

    Private Sub HRdepartmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Загрузка данных из таблицы "Отдел_кадров"
        Me.Отдел_кадровTableAdapter.Fill(Me.SchoolDataSet.Отдел_кадров)

        ' Проверка на тип пользователя и применение ограничений
        If UserType = "Teacher" Then
            ApplyTeacherRestrictions()
            ' Сообщение о том, что пользователь вошел как учитель
            MessageBox.Show("Вы вошли как учитель. Доступ ограничен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf UserType = "Admin" Then
            ApplyAdminRestrictions()
            MessageBox.Show("Вы вошли как админ. Доступ ограничен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    ' Метод для ограничения доступа учителю
    Private Sub ApplyTeacherRestrictions()
        ' Скрытие определённых полей
        NumericUpDown1.Visible = False   ' Оклад
        NumericUpDown2.Visible = False   ' Возраст
        TextBox5.Visible = False         ' Адрес
        MaskedTextBox1.Visible = False   ' Телефон
        MaskedTextBox2.Visible = False   ' Паспортные данные

        ' Скрытие кнопок управления данными
        Button3.Visible = False    ' Добавить
        Button6.Visible = False    ' Удалить
        Button7.Visible = False    ' Сохранить изменения
    End Sub

    Private Sub ApplyAdminRestrictions()

        ' Скрытие кнопок управления данными
        Button3.Visible = False    ' Добавить
        Button6.Visible = False    ' Удалить
        Button7.Visible = False    ' Сохранить изменения
    End Sub

    ' Остальные обработчики кнопок и элементов формы
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Отдел_кадровBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Отдел_кадровBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Отдел_кадровBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Отдел_кадровBindingSource.MoveNext()
    End Sub

    ' Отключённые кнопки (для учителя)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Отдел_кадровBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Отдел_кадровBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Отдел_кадровBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet)
    End Sub

    ' Переход к дополнительным формам
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim hrTable As New HRdepartmentTable() ' Создание экземпляра формы HRdepartmentTable
        hrTable.SetUserType(UserType)          ' Передача типа пользователя
        hrTable.Show()                         ' Открытие формы
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim f As New HRdepartmentReportWindow(GlobalState.CurrentFilter, GlobalState.CurrentSortColumn, GlobalState.CurrentSortDirection.ToString())
        f.Show()
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        HRDepartmentBarChart.Show()
    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems
        ' Скрыть кнопку "Добавить" для учителя
        If UserType = "Teacher" Or UserType = "Admin" Then
            BindingNavigatorAddNewItem.Visible = False
            BindingNavigatorDeleteItem.Visible = False
        Else
            BindingNavigatorAddNewItem.Visible = True
            BindingNavigatorDeleteItem.Visible = True
        End If
    End Sub
End Class
