Public Class frmScheduleInfo
    Dim subform As New sub_frmPetInformation
    Public strTID As String
    Public strPetID As String

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

        Call subform.loadPetsInformation(txtOwnerID.Text) '/Gets Pet Info
        If dtHistory.Rows.Count <> 0 Then
            Call subform.loadTransactionDetails(dtHistory.Rows(0)(0))
        End If
    End Sub

    Private Sub frmScheduleInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtCustomer.Text <> "" Then
            If strTID <> "" Then
                subform.loadPetsInformation(txtOwnerID.Text)
                subform.cboPet.SelectedValue = strPetID
                subform.loadTransactionDetails(strTID)
            End If
        End If
    End Sub

    Private Sub txtCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtCustomer.TextChanged
        With subform
            getsubForm()
            clearFields(.grpHistory)
            .datProduct.Columns.Clear()
            .loadPetsInformation(txtOwnerID.Text)
        End With
    End Sub

    Public Sub getsubForm()
        subform.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        subform.TopLevel = False
        subform.ShowInTaskbar = False
        subform.Show()
        subform.Dock = DockStyle.Fill
        pnlPetInfo.Controls.Add(subform)
    End Sub

End Class