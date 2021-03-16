Public Class frmVaccine
    Dim intVaccineID As Integer
  
    Private Sub frmVaccine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getVaccines()
        datVaccine.Enabled = False
    End Sub

    Private Sub getVaccines()
        Try
            Dim dsVaccines As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT VXID, VXDesvription FROM Vaccinations " & vbCrLf
            sqlQuery += "WHERE DeletedDate IS NULL" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "AND VXID LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR VXDesvription Like '%" + txtSearch.Text + "%'" & vbCrLf
            End If
            dsVaccines = SQLPetMIS(sqlQuery)
            With datVaccine
                .DataSource = dsVaccines
                .DataMember = "Table"
                .Columns(0).Width = .Width * 0.2
                .Columns(1).Width = .Width * 0.79
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call getVaccines()
    End Sub

    Private Sub chkisUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles chkisUpdate.CheckedChanged
        datVaccine.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim blnIsSave As Boolean

            If chkisUpdate.Checked = False Then

                sqlQuery = ""
                sqlQuery += "INSERT INTO dbo.Vaccinations " & vbCrLf
                sqlQuery += "Values" & vbCrLf
                sqlQuery += "(" & vbCrLf
                sqlQuery += "'" + txtName.Text + "'," & vbCrLf
                sqlQuery += "getdate()," & vbCrLf
                sqlQuery += "getdate()," & vbCrLf
                sqlQuery += "null," & vbCrLf
                sqlQuery += "'" + _gbAccountID + "')" & vbCrLf

                blnIsSave = sqlExecute(sqlQuery)

                If blnIsSave Then
                    MsgBox("Data save successfully!", vbOKOnly + vbExclamation)
                    Call saveLogs(1, "Insert new Vaccines")
                    Call getVaccines()
                End If
            Else
                sqlQuery = ""
                sqlQuery += "UPDATE dbo.Vaccinations" & vbCrLf
                sqlQuery += "SET VXDesvription = '" + txtName.Text + "'," & vbCrLf
                sqlQuery += "UpdatedDate = getdate()," & vbCrLf
                sqlQuery += "UpdatedBy = '" + _gbAccountID + "'" & vbCrLf
                sqlQuery += "WHERE VXID = " + intVaccineID.ToString & vbCrLf

                blnIsSave = sqlExecute(sqlQuery)

                If blnIsSave Then
                    MsgBox("Data save successfully!", vbOKOnly + vbInformation)
                    Call getVaccines()
                    Call saveLogs(2, "Update Vaccine description with ID " + intVaccineID.ToString)
                    txtName.Text = ""
                    chkisUpdate.Checked = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datVaccine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datVaccine.CellContentClick
        Try
            intVaccineID = datVaccine.Rows(e.RowIndex).Cells(0).Value
            txtName.Text = datVaccine.Rows(e.RowIndex).Cells(1).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class