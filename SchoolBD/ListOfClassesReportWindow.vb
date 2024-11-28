Public Class ListOfClassesReportWindow
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Список_классов". При необходимости она может быть перемещена или удалена.
        Me.Список_классовTableAdapter.Fill(Me.SchoolDataSet.Список_классов)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class