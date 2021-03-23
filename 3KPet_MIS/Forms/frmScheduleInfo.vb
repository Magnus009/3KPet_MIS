Public Class frmScheduleInfo
    Dim subform As New sub_frmPetInformation

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim dtHistory As New DataTable

        frmOwnerList.ShowDialog()
        txtOwnerID.Text = dsOwnerInfo.Tables(0).Rows(0)("OwnerID")
        txtCustomer.Text = dsOwnerInfo.Tables(0).Rows(0)("LastName") + ", " + dsOwnerInfo.Tables(0).Rows(0)("FirstName")
        txtAddress.Text = dsOwnerInfo.Tables(0).Rows(0)("Address")
        txtContactNo.Text = dsOwnerInfo.Tables(0).Rows(0)("ContactNo")

        sqlQuery = "SELECT * FROM TransactionHeader" + vbCrLf
        sqlQuery += "WHERE OwnerID = '" + txtOwnerID.Text + "'"
        dtHistory = SQLPetMIS(sqlQuery).Tables(0)

        Call subform.loadPetsInformation(txtOwnerID.Text)
        Call subform.loadTransactionDetails(dtHistory.Rows(0)(0))


    End Sub

    Private Sub frmScheduleInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subform.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        subform.TopLevel = False
        subform.ShowInTaskbar = False
        subform.Show()
        'subform.loadPetsInformation(txtOwnerID.Text)
        subform.loadTransactionDetails(txtTransactionID.Text)
        subform.Dock = DockStyle.Fill
        pnlPetInfo.Controls.Add(subform)
    End Sub

    Private Sub txtCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtCustomer.TextChanged
        subform.loadPetsInformation(txtOwnerID.Text)
    End Sub
End Class