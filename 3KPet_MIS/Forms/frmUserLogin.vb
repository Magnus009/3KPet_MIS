Public Class frmUserLogin

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dsRecord As New DataSet

        '
        '

        strRequire = ""
        If fn_CheckRequire(Me) Then
            MsgBox("Please insert a correct username and password.", MsgBoxStyle.Exclamation)
            strRequire = ""
        Else
            sqlQuery = ""
            sqlQuery += "SELECT * FROM Accounts" & vbCrLf
            sqlQuery += "WHERE UserName COLLATE Latin1_General_CS_AS = '" + txtUsername.Text + "' AND " & vbCrLf
            sqlQuery += "Password COLLATE Latin1_General_CS_AS = '" + txtPassword.Text + "'"

            dsRecord = SQLPetMIS(sqlQuery)

            If dsRecord.Tables(0).Rows.Count = 0 Then
                MsgBox("Please insert a correct username and password.", MsgBoxStyle.Exclamation)
            ElseIf dsRecord.Tables(0).Rows(0)("isDeactivate") = True Then
                MsgBox("Account has been deactivated!", vbExclamation)
            Else
                _gbAccountID = dsRecord.Tables(0).Rows(0)(0)
                Call saveLogs(4, "Account " + _gbAccountID + " logged in")
                frmDashboard.Show()
                Me.Hide()
            End If
        End If


    End Sub

    Private Sub lnkCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCreateAccount.LinkClicked
        frmCreateAccount.ShowDialog()
    End Sub

    Private Sub picHideShow_Click(sender As Object, e As EventArgs) Handles picHideShow.Click
        Call subShowHidePassword(sender, txtPassword)
    End Sub

    Private Sub lnkForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPass.LinkClicked
        frmForgetPassword.ShowDialog()
    End Sub
End Class
