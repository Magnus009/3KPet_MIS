﻿Public Class frmVisitHistory
    Dim dsVisitLogs As New DataSet
    Dim blnFilter As Boolean = False


    Private Sub frmVisitHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = Date.Now
        dtpTo.Value = Date.Now
        Call getVisitLogs()
    End Sub

    Public Sub getVisitLogs()
        Try

            sqlQuery = ""
            sqlQuery += "SELECT TransactionID, TH.OwnerID, LastName + ', ' + FirstName AS 'OwnerName', ContactNo,TH.PetID, Address, Name, VisitDate FROM TransactionHeader TH" & vbCrLf
            sqlQuery += "INNER JOIN Owners O ON TH.OwnerID = O.OwnerID " & vbCrLf
            sqlQuery += "INNER JOIN Pets P ON TH.PetID = P.PetID" & vbCrLf
            sqlQuery += "WHERE TH.DeletedDate is null" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "and (TH.TransactionID LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR O.LastName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR O.FirstName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR O.ContactNo LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR P.Name LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR TH.VisitDate LIKE '%" + txtSearch.Text + "%')" & vbCrLf
            End If
            If blnFilter Then
                sqlQuery += "AND VisitDate" & vbCrLf
                sqlQuery += "BETWEEN '" + dtpFrom.Text + " 00:00:00' " & vbCrLf
                sqlQuery += "and '" + dtpTo.Text + " 23:59:59' " & vbCrLf
            End If
            sqlQuery += "ORDER BY VisitDate Desc" & vbCrLf

            dsVisitLogs = SQLPetMIS(sqlQuery)

            With datLogs
                .Columns.Clear()
                .Columns.Add("colTransID", "TRANSACTION ID") : .Columns("colTransID").Width = .Width * 0.15
                .Columns.Add("colOwnerName", "OWNER NAME") : .Columns("colOwnerName").Width = .Width * 0.2
                .Columns.Add("colContact", "CONTACT #") : .Columns("colContact").Width = .Width * 0.15
                .Columns.Add("colPetName", "PET NAME") : .Columns("colPetName").Width = .Width * 0.2
                .Columns.Add("colVisitDate", "VISIT DATE") : .Columns("colVisitDate").Width = .Width * 0.2
                .Columns.Add("colOwnerID", "OwnerID") : .Columns("colOwnerID").Visible = False
                .Columns.Add("colAddress", "Address") : .Columns("colAddress").Visible = False
                .Columns.Add("colPetID", "PetID") : .Columns("colPetID").Visible = False

                Dim btnSelect As New DataGridViewButtonColumn
                btnSelect.Text = "•••"
                btnSelect.UseColumnTextForButtonValue = True
                btnSelect.Width = .Width * 0.09
                .Columns.Add(btnSelect)


                For Each row As DataRow In dsVisitLogs.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("TransactionID")
                    .Rows(.RowCount - 1).Cells(1).Value = row.Item("OwnerName")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("ContactNo")
                    .Rows(.RowCount - 1).Cells(3).Value = row.Item("Name")
                    .Rows(.RowCount - 1).Cells(4).Value = Format(row.Item("VisitDate"), "Short Date")
                    .Rows(.RowCount - 1).Cells(5).Value = row.Item("OwnerId")
                    .Rows(.RowCount - 1).Cells(6).Value = row.Item("Address")
                    .Rows(.RowCount - 1).Cells(7).Value = row.Item("PetID")
                Next
            End With
            blnFilter = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datLogs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datLogs.CellContentClick
        Try
            If e.ColumnIndex = 8 Then
                With frmScheduleInfo
                    '.txtTransactionID.Text = datLogs.Rows(e.RowIndex).Cells(0).Value
                    .txtOwnerID.Text = datLogs.Rows(e.RowIndex).Cells(5).Value
                    .txtCustomer.Text = datLogs.Rows(e.RowIndex).Cells(1).Value
                    .txtAddress.Text = datLogs.Rows(e.RowIndex).Cells(6).Value
                    .txtContactNo.Text = datLogs.Rows(e.RowIndex).Cells(2).Value

                    getOwnerInfo(.txtOwnerID.Text)
                    .strPetID = datLogs.Rows(e.RowIndex).Cells(7).Value
                    'sub_frmPetInformation.loadPetsInformation(.txtOwnerID.Text)
                    .strTID = datLogs.Rows(e.RowIndex).Cells(0).Value
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call getVisitLogs()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        blnFilter = True
        Call getVisitLogs()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmSchedInfo As New frmScheduleInfo
        frmSchedInfo.ShowDialog()
    End Sub
End Class