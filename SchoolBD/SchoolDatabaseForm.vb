Public Class SchoolDatabaseForm


    Private UserType As String

    ' Метод для установки типа пользователя
    Public Sub SetUserType(type As String)
        UserType = type
    End Sub

    ' Обработчик события для открытия HRdepartmentForm
    Private Sub OpenHRDepartmentForm()
        Dim hrForm As New HRdepartmentForm()
        hrForm.SetUserType(UserType)  ' Передаем тип пользователя
        hrForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TypesOfClassesForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PositionsForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClassesForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SubjectsForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ScheduleForm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        StaffForm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        StudentsForm.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        HRdepartmentForm.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ScheduleOfLessonsForm.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListOfClassesForm.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ListOfSubjectsForm.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListOfStudentsForm.Show()
    End Sub

    Private Sub SchoolDatabaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
