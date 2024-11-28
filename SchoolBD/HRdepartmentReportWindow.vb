Public Class HRdepartmentReportWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Отдел_кадров". При необходимости она может быть перемещена или удалена.
        Me.Отдел_кадровTableAdapter.Fill(Me.SchoolDataSet.Отдел_кадров)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class