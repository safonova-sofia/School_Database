Public Class ClassesReportWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Классы". При необходимости она может быть перемещена или удалена.
        Me.КлассыTableAdapter.Fill(Me.SchoolDataSet.Классы)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class