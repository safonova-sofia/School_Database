Public Class SubjectsReportWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Предметы". При необходимости она может быть перемещена или удалена.
        Me.ПредметыTableAdapter.Fill(Me.SchoolDataSet.Предметы)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class