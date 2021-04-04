Public Class frmTreatment

    Dim intTreatmentID As Integer

    Private Sub frmTreatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getTreatments()
        datTreatment.Enabled = False
    End Sub

    Private Sub getTreatments()
        Try
            Dim dsTreatments As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT TRID, TRDescription FROM Treatments" & vbCrLf
            sqlQuery += "WHERE DeletedDate IS NULL " & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "AND (TRID LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR TRDescription LIKE '%" + txtSearch.Text + "%')" & vbCrLf
            End If

            dsTreatments = SQLPetMIS(sqlQuery)
            With datTreatment
                .DataSource = dsTreatments
                .DataMember = "Table"
                .Columns(0).Width = .Width * 0.2
                .Columns(1).Width = .Width * 0.79
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim blnIsSave As Boolean

            If chkisUpdate.Checked = False Then

                sqlQuery = ""
                sqlQuery += "INSERT INTO dbo.Treatments " & vbCrLf
                sqlQuery += "Values" & vbCrLf
                sqlQuery += "(" & vbCrLf
                sqlQuery += "'" + txtName.Text +"'," & vbCrLf
                sqlQuery += "getdate()," & vbCrLf
                sqlQuery += "getdate()," & vbCrLf
                sqlQuery += "null," & vbCrLf
                sqlQuery += "'" + _gbAccountID + "')" & vbCrLf

                blnIsSave = sqlExecute(sqlQuery)

                If blnIsSave Then
                    MsgBox("Data save successfully!", vbOKOnly + vbExclamation)
                    Call saveLogs(1, "Insert new treatment")
                    Call getTreatments()
                End If
            Else
                sqlQuery = ""
                sqlQuery += "UPDATE dbo.Treatments" & vbCrLf
                sqlQuery += "SET TRDescription = '" + txtName.Text + "'," & vbCrLf
                sqlQuery += "UpdatedDate = getdate()," & vbCrLf
                sqlQuery += "UpdatedBy = '" + _gbAccountID + "'" & vbCrLf
                sqlQuery += "WHERE TRID = " + intTreatmentID.ToString & vbCrLf

                blnIsSave = sqlExecute(sqlQuery)

                If blnIsSave Then
                    MsgBox("Data save successfully!", vbOKOnly + vbInformation)
                    Call getTreatments()
                    Call saveLogs(2, "Update treatment description with ID " + intTreatmentID.ToString)
                    txtName.Text = ""
                    chkisUpdate.Checked = False
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub datTreatment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datTreatment.CellContentClick
        Try
            intTreatmentID = datTreatment.Rows(e.RowIndex).Cells(0).Value
            txtName.Text = datTreatment.Rows(e.RowIndex).Cells(1).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkisUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles chkisUpdate.CheckedChanged
        datTreatment.Enabled = True
        If chkisUpdate.Checked = False Then
            txtName.Text = ""
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call getTreatments()
    End Sub
End Class