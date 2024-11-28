Public Class StudentsForm
    Private Sub УченикиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles УченикиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.УченикиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Классы". При необходимости она может быть перемещена или удалена.
        Me.КлассыTableAdapter.Fill(Me.SchoolDataSet.Классы)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Ученики". При необходимости она может быть перемещена или удалена.
        Me.УченикиTableAdapter.Fill(Me.SchoolDataSet.Ученики)

    End Sub

    Private Sub ФИО_отцаLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ФИО_отцаTextBox_TextChanged(sender As Object, e As EventArgs) Handles ФИО_отцаTextBox.TextChanged

    End Sub

    Private Sub ФИО_материTextBox_TextChanged(sender As Object, e As EventArgs) Handles ФИО_материTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        УченикиBindingSource.MoveFirst()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        УченикиBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        УченикиBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        УченикиBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        УченикиBindingSource.AddNew()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        УченикиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        УченикиBindingSource.MovePrevious()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        StudentsTable.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        StudentsReportWindow.Show()
    End Sub
End Class