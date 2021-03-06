Public Class frmTransactions

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        frmNewTransaction.Text = "New Transaction"
        frmNewTransaction.ShowDialog()
    End Sub
End Class