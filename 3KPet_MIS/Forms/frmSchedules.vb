Public Class frmSchedules
    Dim blnFilter As Boolean



    Private Sub frmSchedules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpVisitDateFrom.Value = Date.Now
        dtpVisitDateTo.Value = Date.Now
        Call getSchedules()

    End Sub

    Public Sub getSchedules()
        Try
            Dim dsSched As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT SD.ScheduleCode, SD.CustomerID, O.LastName + ', ' + O.FirstName as CUSTOMERNAme, S.Description, SD.Purpose, SD.ScheduleDate, SD.isArrived, SD.isCancelled FROM Schedules SD" & vbCrLf
            sqlQuery += "INNER JOIN Owners O ON SD.CustomerID = O.OwnerID" & vbCrLf
            sqlQuery += "Left JOIN Services S ON SD.ServiceID = S.ServiceID" & vbCrLf
            sqlQuery += "WHERE SD.DeletedDate IS NULL" & vbCrLf
            If blnFilter Then
                sqlQuery += "AND ScheduleDate " & vbCrLf
                sqlQuery += "BETWEEN '" + dtpVisitDateFrom.Text + " 00:00:00' " & vbCrLf
                sqlQuery += "and '" + dtpVisitDateTo.Text + " 23:59:59' " & vbCrLf
            Else
                sqlQuery += "AND convert(VARCHAR, SD.ScheduleDate, 1) = convert(VARCHAR, getdate(), 1)" & vbCrLf
            End If
            dsSched = SQLPetMIS(sqlQuery)

            With datSchedules
                .Columns.Clear()
                .Columns.Add("colCode", "CODE")
                .Columns("colCode").Width = .Width * 0.15
                .Columns.Add("colCustomer", "CUSTOMER")
                .Columns("colCustomer").Width = .Width * 0.2
                .Columns.Add("colService", "SERVICE")
                .Columns("colService").Width = .Width * 0.13
                .Columns.Add("colPurpose", "PURPOSE")
                .Columns("colPurpose").Width = .Width * 0.2
                .Columns.Add("colDate", "DATE")
                .Columns("colDate").Width = .Width * 0.12

                Dim chkIsArrived As New DataGridViewCheckBoxColumn
                chkIsArrived.Width = 45
                chkIsArrived.HeaderText = "ARRIVE"
                chkIsArrived.Name = "colArrived"
                .Columns.Add(chkIsArrived)
                .Columns("colArrived").ReadOnly = True

                Dim chkIsCancel As New DataGridViewCheckBoxColumn
                chkIsCancel.Width = 45
                chkIsCancel.HeaderText = "CANCEL"
                chkIsCancel.Name = "colCancel"
                .Columns.Add(chkIsCancel)
                .Columns("colCancel").ReadOnly = True

                Dim btnSelect As New DataGridViewButtonColumn
                btnSelect.Text = "•••"
                btnSelect.UseColumnTextForButtonValue = True
                btnSelect.Width = .Width * 0.06
                .Columns.Add(btnSelect)

                For Each row As DataRow In dsSched.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("ScheduleCode")
                    .Rows(.RowCount - 1).Cells(1).Value = row.Item("CustomerName")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("Description")
                    .Rows(.RowCount - 1).Cells(3).Value = row.Item("Purpose")
                    .Rows(.RowCount - 1).Cells(4).Value = Format(row.Item("ScheduleDate"), "Short Date")
                    .Rows(.RowCount - 1).Cells(5).Value = row.Item("isArrived")
                    .Rows(.RowCount - 1).Cells(6).Value = row.Item("isCancelled")
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

    Private Sub datSchedules_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datSchedules.CellContentClick
        If e.ColumnIndex = 7 Then
            frmScheduleReservation.txtSchedCode.Text = datSchedules.Rows(e.RowIndex).Cells(0).Value
            With frmScheduleReservation
                .btnOwner.Visible = False
                .blnisUpdate = True
                .chkCancel.Enabled = True
                .chkIsArrived.Enabled = True
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs)
        Call clearFields(frmScheduleReservation)
        frmScheduleReservation.Text = "Reservation Details"
        frmScheduleReservation.ShowDialog()
    End Sub
End Class