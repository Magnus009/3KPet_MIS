Public Class sub_frmPetInformation
    Dim dsPetInfo As New DataSet
    Dim strTransactionCode As String

    Public Sub loadPetsInformation(strOwner As String)
        Try
            'load Pet
            Dim dtPets As New DataTable("Pets")
            sqlQuery = ""
            sqlQuery = "SELECT * FROM Pets" & vbCrLf
            sqlQuery += "WHERE OwnerID ='" + strOwner + "'" & vbCrLf
            dtPets = SQLPetMIS(sqlQuery).Tables(0)

            cboPet.DataSource = Nothing
            cboPet.DataSource = dtPets
            cboPet.DisplayMember = "Name"
            cboPet.ValueMember = "PetID"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub loadTransactionDetails(strTransactionID As String)
        Try
            strTransactionCode = strTransactionID
            Dim dtTransHeader As New DataTable("TransactionHeader")
            sqlQuery = "SELECT * FROM TransactionHeader" + vbCrLf
            sqlQuery += "WHERE TransactionID = '" + strTransactionID + "'" + vbCrLf
            sqlQuery += "AND PetID = '" + cboPet.SelectedValue + "'"
            dtTransHeader = SQLPetMIS(sqlQuery).Tables(0)

            If dtTransHeader.Rows.Count <> 0 Then
                dtpVisitDate.Value = dtTransHeader.Rows(0)("VisitDate")
                txtWT.Text = dtTransHeader.Rows(0)("WT")
                txtTemp.Text = dtTransHeader.Rows(0)("Temp")
                txtTemp.Text += "°C"
                txtDX.Text = dtTransHeader.Rows(0)("Diagnostic")
                txtAmount.Text = dtTransHeader.Rows(0)("Amount")
                dtpNextVisit.Value = dtTransHeader.Rows(0)("NextVisit")

                'History
                datHistory.Columns.Clear()
                Dim dtPetMedHistory As New DataTable("PetMedHistory")
                sqlQuery = "SELECT TransactionID, VisitDate FROM TransactionHeader" + vbCrLf
                sqlQuery += "WHERE PetID = '" + cboPet.SelectedValue + "'"
                dtPetMedHistory = SQLPetMIS(sqlQuery).Tables(0)
                datHistory.DataSource = dtPetMedHistory

                'view Button
                Dim btnView As New DataGridViewButtonColumn
                btnView.Text = "•••"
                btnView.UseColumnTextForButtonValue = True
                btnView.Width = datHistory.Width * 0.15
                datHistory.Columns.Add(btnView)

            Else
                dtpVisitDate.Value = Today
                txtWT.Text = ""
                txtTemp.Text = ""
                txtDX.Text = ""
                txtAmount.Text = ""
                dtpNextVisit.Value = Today
                datHistory.Columns.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cboPet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPet.SelectedIndexChanged
        If strTransactionCode <> "" Then
            loadTransactionDetails(strTransactionCode)
        End If
    End Sub

    Private Sub datHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datHistory.CellContentClick
        If e.ColumnIndex = 2 Then
            loadTransactionDetails(datHistory.Rows(e.RowIndex).Cells(0).Value)
        End If
    End Sub
End Class