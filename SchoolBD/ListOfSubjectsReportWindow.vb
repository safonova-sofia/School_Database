Public Class ListOfSubjectsReportWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Список_предметов". При необходимости она может быть перемещена или удалена.
        Me.Список_предметовTableAdapter.Fill(Me.SchoolDataSet.Список_предметов)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class