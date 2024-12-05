Imports System.Data.SqlClient

Public Class LoginForm
    ' Объявление строки подключения на уровне класса
    Dim connection As New SqlConnection("Data Source=DESKTOP-NI2O2HU;Initial Catalog=School;Integrated Security=True")

    ' Обработчик события нажатия кнопки входа
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Проверка, что поля не пустые
        If username = "" OrElse password = "" Then
            MessageBox.Show("Пожалуйста, введите имя пользователя и пароль.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL-запрос для проверки учетных данных
        Dim query As String = "SELECT UserType FROM Users WHERE Username=@Username AND Password=@Password"
        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@Username", username)
        cmd.Parameters.AddWithValue("@Password", password)

        Try
            connection.Open()
            Dim userType As Object = cmd.ExecuteScalar()
            connection.Close()

            ' Проверка типа пользователя и переход на соответствующую форму
            If userType IsNot Nothing Then
                Select Case userType.ToString()
                    Case "Admin"
                        MessageBox.Show("Добро пожаловать, Администратор!", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Открыть SchoolDatabaseForm и передать тип пользователя
                        Dim schoolDatabaseForm As New SchoolDatabaseForm()
                        schoolDatabaseForm.SetUserType(userType.ToString())
                        HRdepartmentForm.SetUserType(userType.ToString())
                        schoolDatabaseForm.Show()
                        Me.Hide()

                    Case "Teacher"
                        MessageBox.Show("Добро пожаловать, Учитель!", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Открыть SchoolDatabaseForm и передать тип пользователя
                        Dim schoolDatabaseFormTeacher As New SchoolDatabaseForm()
                        schoolDatabaseFormTeacher.SetUserType(userType.ToString())
                        HRdepartmentForm.SetUserType(userType.ToString())
                        schoolDatabaseFormTeacher.Show()
                        Me.Hide()

                    Case "Student"
                        MessageBox.Show("Добро пожаловать, Ученик!", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Открыть SchoolDatabaseForm и передать тип пользователя
                        Dim schoolDatabaseFormStudent As New SchoolDatabaseForm()
                        schoolDatabaseFormStudent.SetUserType(userType.ToString())
                        HRdepartmentForm.SetUserType(userType.ToString())
                        schoolDatabaseFormStudent.Show()
                        Me.Hide()

                    Case Else
                        MessageBox.Show("Неизвестный тип пользователя.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            Else
                MessageBox.Show("Неправильное имя пользователя или пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Гарантируем закрытие соединения
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub
End Class
