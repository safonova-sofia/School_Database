Imports System.Data.SqlClient

Public Class HRdepartmentReportWindow
    Private Sub HRdepartmentReportWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Базовый SQL-запрос
        Dim baseQuery As String = "SELECT * FROM [Отдел кадров]"
        Dim filterQuery As String = ""
        Dim sortQuery As String = ""


        ' Итоговый запрос
        Dim query As String = baseQuery & filterQuery & sortQuery

        Try
            ' Загружаем данные в DataSet
            Using connection As New SqlConnection("Data Source=DESKTOP-NI2O2HU;Initial Catalog=School;Integrated Security=True")
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim dataSet As New DataSet()
                adapter.Fill(dataSet, "Отдел кадров")

                ' Привязываем данные к отчету
                Dim reportDataSource As New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataSet.Tables("Отдел кадров"))

                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
            End Using

            ' Обновляем отчет
            Me.ReportViewer1.RefreshReport()
        Catch ex As SqlException
            MessageBox.Show("Ошибка выполнения SQL-запроса: " & ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
