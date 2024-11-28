Public Class ScheduleReportWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Расписание". При необходимости она может быть перемещена или удалена.
        Me.РасписаниеTableAdapter.Fill(Me.SchoolDataSet.Расписание)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class