Public Class StudentsReportWindow
    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Ученики". При необходимости она может быть перемещена или удалена.
        Me.УченикиTableAdapter.Fill(Me.SchoolDataSet.Ученики)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class