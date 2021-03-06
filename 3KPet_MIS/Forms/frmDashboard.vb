Public Class frmDashboard
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        pnlNav.Width = 0
    End Sub

    Private Sub frmDashboardvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlNav.Width = 200
    End Sub

    Private Sub picMenu_Click(sender As Object, e As EventArgs) Handles picMenu.Click
        If pnlNav.Width = 0 Then
            pnlNav.Width = 200
        Else
            pnlNav.Width = 0
        End If
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        strdestination = "ADD"
        frmRecords.Text = Me.Text
        frmRecords.lblHeader.Text = "ADD RECORD"
        frmRecords.ShowDialog()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Call subLogout()
    End Sub

    Private Sub subLogout()
        MsgBox("Do you want to Logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "LOG OUT")
        If vbYes Then
            Me.Close()
            frmUserLogin.Show()
        End If
    End Sub

    Private Sub btnUpdateRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateRecord.Click
        strdestination = "UPDATE"
        frmRecords.Text = Me.Text
        frmRecords.lblHeader.Text = "UPDATE RECORD"
        frmRecords.ShowDialog()

    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        frmTransactions.Text = Me.Text
        frmTransactions.ShowDialog()
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        frmSchedules.Text = Me.Text
        frmSchedules.lblHeader.Text = "UPDATE RECORD"
        frmSchedules.ShowDialog()
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        Call frmAccountsRecords.ShowDialog()

    End Sub
End Class