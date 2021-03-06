Public Class frmSchedules
    Dim blnFilter As Boolean

    Private Sub btnArrive_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        frmScheduleReservation.Text = "Reservation Details"
        frmScheduleReservation.ShowDialog()
    End Sub

    Private Sub frmSchedules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getSchedules()

    End Sub

    Private Sub getSchedules()
        Try
            Dim dsSched As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT * FROM Schedules SD" & vbCrLf
            sqlQuery += "Left JOIN Services S ON SD.ServiceID = S.ServiceID" & vbCrLf
            sqlQuery += "WHERE SD.DeletedDate IS NULL" & vbCrLf
            If blnFilter Then
                sqlQuery += "AND ScheduleDate "
                sqlQuery += "BETWEEN '" + dtpVisitDateFrom.Text + " 00:00:00' "
                sqlQuery += "and '" + dtpVisitDateTo.Text + " 23:59:59' "
            End If
            dsSched = SQLPetMIS(sqlQuery)

            With datSchedules
                .Columns.Clear()
                .Columns.Add("colCode", "CODE")
                .Columns("colCode").Width = .Width * 0.15
                .Columns.Add("colCustomer", "CUSTOMER")
                .Columns("colCustomer").Width = .Width * 0.2
                .Columns.Add("colService", "SERVICE")
                .Columns("colService").Width = .Width * 0.15
                .Columns.Add("colPurpose", "PURPOSE")
                .Columns("colPurpose").Width = .Width * 0.3
                .Columns.Add("colDate", "DATE")
                .Columns("colDate").Width = .Width * 0.19

                For Each row As DataRow In dsSched.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("ScheduleCode")
                    .Rows(.RowCount - 1).Cells(1).Value = row.Item("CustomerName")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("Description")
                    .Rows(.RowCount - 1).Cells(3).Value = row.Item("Purpose")
                    .Rows(.RowCount - 1).Cells(4).Value = Format(row.Item("ScheduleDate"), "Short Date")
                Next
            End With
            blnFilter = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        blnFilter = True
        Call getSchedules()
    End Sub
End Class