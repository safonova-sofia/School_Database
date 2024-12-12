Public Class ListOfStudentsForm

    Private UserType As String

    ' Метод для установки типа пользователя
    Public Sub SetUserType(type As String)
        UserType = type
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Список_учениковBindingSource.MoveFirst()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Виды_классов". При необходимости она может быть перемещена или удалена.
        Me.Виды_классовTableAdapter.Fill(Me.SchoolDataSet.Виды_классов)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.SchoolDataSet.Сотрудники)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Список_учеников". При необходимости она может быть перемещена или удалена.
        Me.Список_учениковTableAdapter.Fill(Me.SchoolDataSet.Список_учеников)

        If UserType = "Student" Then
            ApplyStudentRestrictions()
            ' Сообщение о том, что пользователь вошел как учитель
            MessageBox.Show("Вы вошли как ученик. Доступ ограничен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ApplyStudentRestrictions()


        ' Скрытие кнопок управления данными
        Button3.Visible = False    ' Добавить
        Button6.Visible = False    ' Удалить
        Button7.Visible = False    ' Сохранить изменения
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Список_учениковBindingSource.MoveLast()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Список_учениковBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Список_учениковBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Список_учениковBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Список_учениковBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Список_учениковBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListOfStudentsTable.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim f As New ListOfStudentsReportWindow(GlobalState.CurrentFilter, GlobalState.CurrentSortColumn, GlobalState.CurrentSortDirection.ToString())
        f.Show()
    End Sub

    Private Sub BindingNavigator2_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems
        If UserType = "Student" Then
            BindingNavigatorAddNewItem.Visible = False
            BindingNavigatorDeleteItem.Visible = False
        Else
            BindingNavigatorAddNewItem.Visible = True
            BindingNavigatorDeleteItem.Visible = True
        End If
    End Sub
End Class