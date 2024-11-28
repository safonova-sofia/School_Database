Public Class ScheduleTable
    Private Sub РасписаниеBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles РасписаниеBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.РасписаниеBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SchoolDataSet)

    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Расписание". При необходимости она может быть перемещена или удалена.
        Me.РасписаниеTableAdapter.Fill(Me.SchoolDataSet.Расписание)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn2
            Case 1
                Col = DataGridViewTextBoxColumn3
            Case 2
                Col = DataGridViewTextBoxColumn4
            Case 3
                Col = DataGridViewTextBoxColumn5
            Case 4
                Col = DataGridViewTextBoxColumn6
            Case 5
                Col = DataGridViewTextBoxColumn7
        End Select
        If RadioButton1.Checked Then
            РасписаниеDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            РасписаниеDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        РасписаниеBindingSource.Filter = "Дата='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        РасписаниеBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To РасписаниеDataGridView.ColumnCount - 1
            For j = 0 To РасписаниеDataGridView.RowCount - 1
                РасписаниеDataGridView.Item(i, j).Style.BackColor = Color.White
                РасписаниеDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i

        For i = 0 To РасписаниеDataGridView.ColumnCount - 1
            For j = 0 To РасписаниеDataGridView.RowCount - 1
                If РасписаниеDataGridView.Item(i, j).Value IsNot Nothing AndAlso InStr(РасписаниеDataGridView.Item(i, j).Value.ToString(), TextBox1.Text) > 0 Then
                    РасписаниеDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    РасписаниеDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub
End Class