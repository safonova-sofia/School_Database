Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class HRDepartmentBarChart
    ' Подключение к базе данных
    Dim connectionString As String = "Data Source=DESKTOP-NI2O2HU;Initial Catalog=School;Integrated Security=True"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Настроить диаграмму
        SetupChart()
        ' Загрузить данные из базы
        LoadData()
    End Sub

    Private Sub SetupChart()
        ' Настройки для компонента Chart
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        Chart1.Titles.Clear()

        ' Добавляем область графика
        Dim chartArea As New ChartArea("MainArea")
        Chart1.ChartAreas.Add(chartArea)

        ' Добавляем серию данных
        Dim series As New Series("Оклад")
        series.ChartType = SeriesChartType.Column ' Тип графика - гистограмма
        series.IsValueShownAsLabel = True ' Отображение значений на столбцах
        Chart1.Series.Add(series)

        ' Настройка осей
        chartArea.AxisX.Title = "Должность"
        chartArea.AxisX.TitleFont = New Font("Arial", 12, FontStyle.Bold)
        chartArea.AxisX.LabelStyle.Font = New Font("Arial", 10)
        chartArea.AxisX.Interval = 1 ' Отображение всех подписей
        chartArea.AxisX.LabelStyle.Angle = -45 ' Наклон подписей для лучшей читаемости

        chartArea.AxisY.Title = "Средний оклад"
        chartArea.AxisY.TitleFont = New Font("Arial", 12, FontStyle.Bold)
        chartArea.AxisY.LabelStyle.Font = New Font("Arial", 10)

        ' Настройка сетки
        chartArea.AxisX.MajorGrid.Enabled = False ' Убираем сетку по оси X
        chartArea.AxisY.MajorGrid.LineColor = Color.LightGray ' Цвет линии сетки

        ' Добавляем заголовок
        Chart1.Titles.Add("Гистограмма средних окладов по должностям")
        Chart1.Titles(0).Font = New Font("Arial", 14, FontStyle.Bold)
        Chart1.Titles(0).ForeColor = Color.DarkBlue
    End Sub

    Private Sub LoadData()
        ' Массив цветов для столбцов
        Dim colors As Color() = {Color.Blue, Color.Green, Color.Red, Color.Orange, Color.Purple, Color.Cyan}

        ' Подключение к базе и выполнение запроса
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT Наименование_должности, AVG(Оклад) AS СреднийОклад FROM [Отдел кадров] GROUP BY Наименование_должности"
            Dim command As New SqlCommand(query, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            Dim colorIndex As Integer = 0

            While reader.Read()
                Dim positionName As String = reader("Наименование_должности").ToString()
                Dim averageSalary As Decimal = Convert.ToDecimal(reader("СреднийОклад"))

                ' Добавляем уникальную должность и средний оклад на график
                Dim point = Chart1.Series("Оклад").Points.AddXY(positionName, averageSalary)

                ' Применяем цвет к столбцу
                Chart1.Series("Оклад").Points(point).Color = colors(colorIndex Mod colors.Length)

                colorIndex += 1
            End While

            reader.Close()
        End Using
    End Sub


End Class
