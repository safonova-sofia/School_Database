Public Class TypesOfClassesReportWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SchoolDataSet.Виды_классов". При необходимости она может быть перемещена или удалена.
        Me.Виды_классовTableAdapter.Fill(Me.SchoolDataSet.Виды_классов)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class