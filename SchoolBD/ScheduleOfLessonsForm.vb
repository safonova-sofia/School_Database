Public Class ScheduleOfLessonsForm
    Private UserType As String

    ' Метод для установки типа пользователя
    Public Sub SetUserType(type As String)
        UserType = type
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Загрузка данных в таблицы
        Me.Виды_классовTableAdapter.Fill(Me.SchoolDataSet.Виды_классов)
        Me.СотрудникиTableAdapter.Fill(Me.SchoolDataSet.Сотрудники)
        Me.Расписание_занятийTableAdapter.Fill(Me.SchoolDataSet.Расписание_занятий)

        ' Проверяем тип пользователя и скрываем кнопки редактирования для "ученик" и "учитель"
        If UserType = "Student" Or UserType = "Teacher" Then
            If UserType = "Teacher" Then
                ApplyTeacherOrStudentRestrictions()
                ' Сообщение о том, что пользователь вошел как учитель
                MessageBox.Show("Вы вошли как учитель. Доступ ограничен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf UserType = "Student" Then
                ' Сообщение о том, что пользователь вошел как ученик
                ApplyTeacherOrStudentRestrictions()
                MessageBox.Show("Вы вошли как ученик. Доступ ограничен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub ApplyTeacherOrStudentRestrictions()
        ' Скрываем кнопки для добавления и сохранения
        Button3.Visible = False ' Кнопка добавления
        Button7.Visible = False ' Кнопка сохранения
        Button6.Visible = False ' Кнопка удаления

        ' Также можно сделать кнопки недоступными
        Button3.Enabled = False
        Button7.Enabled = False
        Button6.Enabled = False
    End Sub


    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        ' Ваш код
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Расписание_занятийBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Расписание_занятийBindingSource.MoveLast()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Расписание_занятийBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Расписание_занятийBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Кнопка добавления
        Расписание_занятийBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Кнопка удаления
        Расписание_занятийBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ScheduleOfLessonsTable.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim f As New ScheduleOfLessonsReportWindow(GlobalState.CurrentFilter, GlobalState.CurrentSortColumn, GlobalState.CurrentSortDirection.ToString())
        f.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Кнопка сохранения
        Me.Validate()
        Расписание_занятийBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet)
    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems
        If UserType = "Teacher" Or UserType = "Student" Then
            BindingNavigatorAddNewItem.Visible = False
            BindingNavigatorDeleteItem.Visible = False
        Else
            BindingNavigatorAddNewItem.Visible = True
            BindingNavigatorDeleteItem.Visible = True
        End If
    End Sub

End Class
