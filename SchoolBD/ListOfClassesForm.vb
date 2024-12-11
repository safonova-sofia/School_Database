Public Class ListOfClassesForm
    Public UserType As String

    Public Sub SetUserType(type As String)
        UserType = type
    End Sub





    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ListOfClassesReportWindow.Show()

    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim classesTable As New ListOfClassesTable() ' Создание экземпляра формы HRdepartmentTable
        classesTable.SetUserType(UserType)          ' Передача типа пользователя
        classesTable.Show()                         ' Открытие формы
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Список_классовBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Список_классовBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Список_классовBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Список_классовBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Список_классовBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Список_классовBindingSource.MovePrevious()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Список_классовBindingSource.MoveFirst()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Должности". При необходимости она может быть перемещена или удалена.
        Me.ДолжностиTableAdapter.Fill(Me.SchoolDataSet.Должности)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.SchoolDataSet.Сотрудники)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Список_классов". При необходимости она может быть перемещена или удалена.
        Me.Список_классовTableAdapter.Fill(Me.SchoolDataSet.Список_классов)


        ' Настройка интерфейса в зависимости от типа пользователя
        If UserType = "Student" Then
            ApplyStudentRestrictions()
            ' Сообщение о том, что пользователь вошел как учитель
            MessageBox.Show("Вы вошли как ученик. Доступ ограничен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub ApplyStudentRestrictions()
        Button3.Visible = False
        Button6.Visible = False
        Button7.Visible = False

        ' Скрыть поля
        MaskedTextBox1.Visible = False
        MaskedTextBox2.Visible = False
        TextBox4.Visible = False
        NumericUpDown7.Visible = False
    End Sub
End Class