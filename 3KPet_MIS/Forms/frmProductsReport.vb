Public Class frmProductsReport

    Private Sub frmProductsReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpvProducts.RefreshReport()
    End Sub
End Class