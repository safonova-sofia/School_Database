Module GlobalState
    Public CurrentFilter As String = ""
    Public CurrentSortColumn As String = ""
    Public CurrentSortDirection As System.ComponentModel.ListSortDirection = System.ComponentModel.ListSortDirection.Ascending

    Public ReportFilter As String = "" ' Для передачи фильтра в отчет
End Module