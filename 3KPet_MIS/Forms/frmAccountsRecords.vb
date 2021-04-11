Public Class frmAccountsRecords

    Dim dsAccounts As DataSet

    Private Sub frmAccountsRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getAccounts()
    End Sub

    Public Sub getAccounts()
        Try


            dsAccounts = New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT * FROM Accounts A" & vbCrLf
            sqlQuery += "INNER JOIN UserLevel UL ON A.Userlevel = UL.LevelID" & vbCrLf
            sqlQuery += "INNER JOIN Users U ON A.AccountID = U.UserID" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "WHERE AccountID LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR UserName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
            End If

            dsAccounts = SQLPetMIS(sqlQuery)
            With datAccounts
                .Columns.Clear()
                .Columns.Add("colAccID", "ID")
                .Columns("colAccID").Width = .Width * 0.2
                .Columns.Add("colUserName", "USER NAME")
                .Columns("colUserName").Width = .Width * 0.4
                .Columns.Add("colUserLevel", "USER TYPE")
                .Columns("colUserLevel").Width = .Width * 0.2
                .Columns.Add("colStatus", "STATUS")
                .Columns("colStatus").Width = .Width * 0.15

                Dim btnSelect As New DataGridViewButtonColumn
                btnSelect.Text = "•••"
                btnSelect.UseColumnTextForButtonValue = True
                btnSelect.Width = .Width * 0.04
                .Columns.Add(btnSelect)

                For Each row As DataRow In dsAccounts.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("AccountID")
                    .Rows(.RowCount - 1).Cells(1).Value = row.Item("UserName")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("Description")
                    .Rows(.RowCount - 1).Cells(3).Value = IIf(row.Item("isDeactivate") = 0, "Active", "Deactivated")
                Next

                AddHandler .CellFormatting, AddressOf subCellFormat

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call getAccounts()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        clearFields(frmCreateAccount)
        With frmCreateAccount
            .blnIsUpdate = False
            .isNew = True
            .btnDeactivate.Enabled = False
            enableObjects()
            .txtUserID.Enabled = False
            .ShowDialog()
        End With



    End Sub

    Private Sub datAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datAccounts.CellContentClick
        Try
            Dim drResult As DataRow
            Dim strFilter As String

            strFilter = "AccountID ='" & datAccounts.Rows(e.RowIndex).Cells(0).Value & "'"

            If e.ColumnIndex = 4 Then

                drResult = dsAccounts.Tables(0).Select(strFilter)(0)
                With frmCreateAccount
                    .strUserID = datAccounts.Rows(e.RowIndex).Cells(0).Value
                    '.blnIsUpdate = True
                    '.txtUserID.Text = drResult.Item("AccountID")
                    '.txtLName.Text = drResult.Item("LastName")
                    '.txtFName.Text = drResult.Item("FirstName")
                    '.txtMName.Text = drResult.Item("MiddleName")
                    '.txtUserName.Text = drResult.Item("UserName")
                    '.txtPassword.Text = drResult.Item("Password") : .txtPassword.Enabled = False
                    '.cboLevel.Text = drResult.Item("UserLevel")
                    '.cboQuestion_1.SelectedValue = drResult.Item("Q1")
                    '.txtAnswer_1.Text = drResult.Item("A1")
                    '.cboQuestion_2.SelectedValue = drResult.Item("Q2")
                    '.txtAnswer_2.Text = drResult.Item("A2")
                    '.btnDeactivate.Enabled = True
                    'Dim blnDeactivate As Boolean = drResult.Item("isDeactivate")
                    '.lblDeact.Visible = blnDeactivate
                    'If blnDeactivate = True Then
                    '    .btnDeactivate.Text = "ACTIVATE"
                    'Else
                    '    .btnDeactivate.Text = "DEACTIVATE"
                    'End If

                    If _gbAccountID <> .strUserID Then
                        .btnSave.Enabled = False
                        .btnDeactivate.Enabled = False
                        .txtFName.Enabled = False
                        .txtLName.Enabled = False
                        .txtMName.Enabled = False
                        .txtPassword.Enabled = False
                        .txtConfirmPassword.Enabled = False
                        .txtAnswer_1.Enabled = False
                        .txtAnswer_2.Enabled = False
                        .txtUserID.Enabled = False
                        .txtUserName.Enabled = False
                        .cboQuestion_1.Enabled = False
                        .cboQuestion_2.Enabled = False
                    Else
                        enableObjects()
                    End If

                    .ShowDialog()

                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub enableObjects()
        With frmCreateAccount
            .txtUserID.Enabled = True
            .txtLName.Enabled = True
            .txtFName.Enabled = True
            .txtMName.Enabled = True
            .txtPassword.Enabled = True
            .txtConfirmPassword.Enabled = True
            .cboQuestion_1.Enabled = True
            .cboQuestion_2.Enabled = True
            .txtAnswer_1.Enabled = True
            .txtAnswer_2.Enabled = True
            .btnDeactivate.Enabled = True
            .txtUserName.Enabled = True
            .txtPassword.Text = ""

        End With
    End Sub
End Class