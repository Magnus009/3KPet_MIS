Public Class frmActivityLogs
    Dim blnFilter As Boolean
    Private Sub frmActivityLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = Date.Now
        dtpTo.Value = Date.Now
        Call getLogs()
        Call getActions()

    End Sub

    Private Sub getLogs()
        Try
            Dim dsLogs As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT Seq,UserID,ActionDate, L.ActionID, A.Description, Remarks  FROM LogHistories L" & vbCrLf
            sqlQuery += "INNER JOIN Actions A ON L.ActionID = A.ActionID " & vbCrLf
            If blnFilter Then
                sqlQuery += "WHERE L.ActionDate BETWEEN" & vbCrLf
                sqlQuery += "'" + Format(dtpFrom.Value, "yyyy/MM/dd") & " 00:00:00' and '" + Format(dtpTo.Value, "yyyy/MM/dd") + " 23:59:59'" & vbCrLf
                If cboActions.Text <> "ALL" Then
                    sqlQuery += "AND L.ActionID =" + cboActions.SelectedIndex.ToString & vbCrLf
                End If

            End If
            sqlQuery += "ORDER BY L.ActionDate DESC" & vbCrLf

            dsLogs = New DataSet
            dsLogs = SQLPetMIS(sqlQuery)

            With datLogs
                .Columns.Clear()
                .Columns.Add("colUserID", "USER ID")
                .Columns("colUserID").Width = .Width * 0.2
                .Columns.Add("colActionDate", "DATE")
                .Columns("colActionDate").Width = .Width * 0.3
                .Columns.Add("colAction", "ACTION")
                .Columns("colAction").Width = .Width * 0.2
                .Columns.Add("colDescription", "DESCRIPTION")
                .Columns("colDescription").Width = .Width * 0.29

                For Each row As DataRow In dsLogs.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("UserID")
                    .Rows(.RowCount - 1).Cells(1).Value = Format(row.Item("ActionDate"), "dd/MM/yyyy")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("Description")
                    .Rows(.RowCount - 1).Cells(3).Value = row.Item("Remarks")
                Next

            End With

           
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getActions()
        Try
            Dim dsActions As New DataSet

            dsActions = New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT * FROM Actions "

            dsActions = SQLPetMIS(sqlQuery)

            cboActions.Items.Add("ALL")
            For Each row As DataRow In dsActions.Tables(0).Rows
                cboActions.Items.Add(row.Item("Description"))
            Next
            cboActions.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        blnFilter = True
        Call getLogs()
    End Sub


End Class