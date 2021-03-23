﻿Public Class frmDashboard
    'Private Sub btnHide_Click(sender As Object, e As EventArgs)
    '    pnlNav.Width = 0
    'End Sub

    'Private Sub frmDashboardvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    pnlNav.Width = 200
    'End Sub

    'Private Sub picMenu_Click(sender As Object, e As EventArgs)
    '    If pnlNav.Width = 0 Then
    '        pnlNav.Width = 200
    '    Else
    '        pnlNav.Width = 0
    '    End If
    'End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs)
        strdestination = "ADD"
        frmRecords.Text = Me.Text
        frmRecords.lblHeader.Text = "ADD RECORD"
        frmRecords.ShowDialog()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Call subLogout()
    End Sub

    Private Sub subLogout()
        MsgBox("Do you want to Logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "LOG OUT")
        If vbYes Then
            Me.Close()
            frmUserLogin.Show()
        End If
    End Sub

    'Private Sub btnUpdateRecord_Click(sender As Object, e As EventArgs)
    '    strdestination = "UPDATE"
    '    frmRecords.Text = Me.Text
    '    frmRecords.lblHeader.Text = "UPDATE RECORD"
    '    frmRecords.ShowDialog()

    'End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs)
        frmTransactions.Text = Me.Text
        frmTransactions.ShowDialog()
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs)
        frmSchedules.Text = Me.Text
        frmSchedules.lblHeader.Text = "UPDATE RECORD"
        frmSchedules.ShowDialog()
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs)
        Call frmAccountsRecords.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        strdestination = "ADD"
        frmRecords.Text = Me.Text
        frmRecords.lblHeader.Text = "ADD RECORD"
        frmRecords.ShowDialog()
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        strdestination = "UPDATE"
        frmRecords.Text = Me.Text
        frmRecords.lblHeader.Text = "UPDATE RECORD"
        frmRecords.ShowDialog()
    End Sub


    Private Sub RECORDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RECORDSToolStripMenuItem.Click
        frmRecords.Text = Me.Text
        strdestination = "ADD"
        frmRecords.lblHeader.Text = "RECORDS"
        frmRecords.ShowDialog()
    End Sub



    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnuAccount.Text = UCase(_gbUSerName)
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
            'If blnFilter Then
            '    sqlQuery += "AND ScheduleDate " & vbCrLf
            '    sqlQuery += "BETWEEN '" + dtpVisitDateFrom.Text + " 00:00:00' " & vbCrLf
            '    sqlQuery += "and '" + dtpVisitDateTo.Text + " 23:59:59' " & vbCrLf
            'End If
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
                .Columns("colPurpose").Width = .Width * 0.2
                .Columns.Add("colDate", "DATE")
                .Columns("colDate").Width = .Width * 0.12

                Dim chkIsArrived As New DataGridViewCheckBoxColumn
                chkIsArrived.Width = 50
                chkIsArrived.HeaderText = "ARRIVE"
                chkIsArrived.Name = "colArrived"
                .Columns.Add(chkIsArrived)
                .Columns("colArrived").ReadOnly = True

                Dim chkIsCancel As New DataGridViewCheckBoxColumn
                chkIsCancel.Width = 50
                chkIsCancel.HeaderText = "CANCEL"
                chkIsCancel.Name = "colCancel"
                .Columns.Add(chkIsCancel)
                .Columns("colCancel").ReadOnly = True

                'Dim btnSelect As New DataGridViewButtonColumn
                'btnSelect.Text = "•••"
                'btnSelect.UseColumnTextForButtonValue = True
                'btnSelect.Width = .Width * 0.06
                '.Columns.Add(btnSelect)

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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SCHEDULESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SCHEDULESToolStripMenuItem.Click
        frmSchedules.ShowDialog()
    End Sub

    Private Sub PAYMENTMODULEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAYMENTMODULEToolStripMenuItem.Click
        frmTransactions.ShowDialog()
    End Sub

    Private Sub MEDICALHISTORIESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEDICALHISTORIESToolStripMenuItem.Click
        frmVisitHistory.ShowDialog()
    End Sub

    Private Sub INVENTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INVENTORYToolStripMenuItem.Click
        frmInventory.ShowDialog()
    End Sub

    Private Sub AUDITTRAILToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AUDITTRAILToolStripMenuItem.Click
        frmActivityLogs.ShowDialog()
    End Sub

    Private Sub ACCOUNTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACCOUNTSToolStripMenuItem.Click
        frmAccountsRecords.ShowDialog()
    End Sub

    Private Sub TREATMENTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TREATMENTSToolStripMenuItem.Click
        frmTreatment.ShowDialog()
    End Sub

    Private Sub VACCINESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VACCINESToolStripMenuItem.Click
        frmVaccine.ShowDialog()
    End Sub

    Private Sub ARCHIVEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ARCHIVEToolStripMenuItem1.Click
        frmArchive.ShowDialog()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Hide()
        frmUserLogin.txtUsername.Text = ""
        frmUserLogin.txtPassword.Text = ""
        _gbAccountID = ""
        _gbUSerName = ""
        frmUserLogin.Show()
    End Sub
End Class