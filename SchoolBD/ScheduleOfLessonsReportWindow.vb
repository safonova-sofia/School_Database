Public Class ScheduleOfLessonsReportWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Расписание_занятий". При необходимости она может быть перемещена или удалена.
        Me.Расписание_занятийTableAdapter.Fill(Me.SchoolDataSet.Расписание_занятий)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class