Public Class frmScheduleInfo
    Dim subform As New sub_frmPetInformation

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmOwnerList.ShowDialog()
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