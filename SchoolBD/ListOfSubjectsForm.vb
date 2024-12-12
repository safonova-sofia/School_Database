Public Class ListOfSubjectsForm
    Public UserType As String ' Тип пользователя: "Учитель", "Ученик" или "Администрация"

    Public Sub SetUserType(type As String)
        UserType = type
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Должности". При необходимости она может быть перемещена или удалена.
        Me.ДолжностиTableAdapter.Fill(Me.SchoolDataSet.Должности)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Список_предметов". При необходимости она может быть перемещена или удалена.
        Me.Список_предметовTableAdapter.Fill(Me.SchoolDataSet.Список_предметов)

        ' Настройка интерфейса в зависимости от типа пользователя
        If UserType = "Teacher" Then
            ApplyTeacherAndAdminRestrictions()
            ' Сообщение о том, что пользователь вошел как учитель
            MessageBox.Show("Вы вошли как учитель. Доступ ограничен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf UserType = "Student" Then
            ' Сообщение о том, что пользователь вошел как ученик
            ApplyStudentRestrictions()
            MessageBox.Show("Вы вошли как ученик. Доступ ограничен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf UserType = "Admin" Then
            ' Сообщение о том, что пользователь вошел как ученик
            ApplyStudentRestrictions()
            MessageBox.Show("Вы вошли как админ. Доступ ограничен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ApplyTeacherAndAdminRestrictions()
        Button3.Visible = False ' Кнопка AddNew
        Button6.Visible = False ' Кнопка RemoveCurrent
        Button7.Visible = False ' Кнопка Save
    End Sub

    Private Sub ApplyStudentRestrictions()
        Button3.Visible = False
        Button6.Visible = False
        Button7.Visible = False

        ' Скрыть поля
        NumericUpDown1.Visible = False
        MaskedTextBox1.Visible = False
        MaskedTextBox2.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Список_предметовBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Список_предметовBindingSource.MoveLast()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Список_предметовBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Список_предметовBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Список_предметовBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Список_предметовBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Список_предметовBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim subjectsTable As New ListOfSubjectsTable() ' Создание экземпляра формы HRdepartmentTable
        subjectsTable.SetUserType(UserType)          ' Передача типа пользователя
        subjectsTable.Show()                         ' Открытие формы
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim f As New ListOfSubjectsReportWindow(GlobalState.CurrentFilter, GlobalState.CurrentSortColumn, GlobalState.CurrentSortDirection.ToString())
        f.Show()
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
