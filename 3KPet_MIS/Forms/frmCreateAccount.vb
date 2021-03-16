
Public Class frmCreateAccount

    Private Sub picHideShowPassword_Click(sender As Object, e As EventArgs) Handles picHideShowPassword.Click
        Call subShowHidePassword(sender, txtPassword)
    End Sub

    Private Sub picHideShowConfirmPassword_Click(sender As Object, e As EventArgs) Handles picHideShowConfirmPassword.Click
        Call subShowHidePassword(sender, txtConfirmPassword)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim strSQL As String
            Dim dsID As New DataSet
            Dim strID As String
            Dim blResult As Boolean
            Dim dsUserName As New DataSet


            strSQL = ""
            strSQL += "SELECT count(AccountID) FROM Accounts" & vbCrLf
            strSQL += "WHERE UserName ='" + txtUserName.Text + "'" + vbCrLf

            dsUserName = SQLPetMIS(strSQL)

            strRequire = ""
            If fn_CheckRequire(Me) Then
                MsgBox("Please Fill out Required Field:" & vbCrLf & strRequire, MsgBoxStyle.Exclamation)
                strRequire = ""
            Else
                If (txtPassword.Text <> txtConfirmPassword.Text Or txtConfirmPassword.Text = "") Then
                    MsgBox("Make sure your passwords match!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PASSWORD MISMATCH")
                    txtConfirmPassword.ForeColor = Color.Red
                    txtConfirmPassword.Focus()
                ElseIf dsUserName.Tables(0).Rows.Count <> 0 Then
                    MsgBox("User name already exist!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    txtUserName.ForeColor = Color.Red
                    txtUserName.Focus()
                Else
                    strSQL = ""
                    strSQL = "SELECT dbo.fn_colID ('U')"

                    dsID = SQLPetMIS(strSQL)
                    strID = dsID.Tables(0).Rows(0)(0)

                    sqlQuery += "INSERT INTO dbo.Users " + vbCrLf
                    sqlQuery += "(" + vbCrLf
                    sqlQuery += "UserID," + vbCrLf
                    sqlQuery += "LastName," + vbCrLf
                    sqlQuery += "FirstName," + vbCrLf
                    sqlQuery += "MiddleName," + vbCrLf
                    sqlQuery += "CreatedDate," + vbCrLf
                    sqlQuery += "UpdatedDate," + vbCrLf
                    sqlQuery += "DeletedDate, " + vbCrLf
                    sqlQuery += "UpdatedBy" + vbCrLf
                    sqlQuery += ")" + vbCrLf
                    sqlQuery += "VALUES " + vbCrLf
                    sqlQuery += "(" + vbCrLf
                    sqlQuery += "'" + strID + "'," + vbCrLf
                    sqlQuery += "'" + txtLName.Text + "'," + vbCrLf
                    sqlQuery += "'" + txtFName.Text + "'," + vbCrLf
                    sqlQuery += "'" + txtMName.Text + "'," + vbCrLf
                    sqlQuery += "getdate()," + vbCrLf
                    sqlQuery += "getdate(), " + vbCrLf
                    sqlQuery += "Null," + vbCrLf
                    sqlQuery += "'" + strID + "')" + vbCrLf

                    blResult = sqlExecute(sqlQuery)

                    strSQL = ""
                    strSQL += "INSERT INTO dbo.Accounts " + vbCrLf
                    strSQL += "(" + vbCrLf
                    strSQL += "AccountID, " + vbCrLf
                    strSQL += "UserName," + vbCrLf
                    strSQL += "Password," + vbCrLf
                    strSQL += "UserLevel," + vbCrLf
                    strSQL += "Q1," + vbCrLf
                    strSQL += "Q2," + vbCrLf
                    strSQL += "A1," + vbCrLf
                    strSQL += "A2," + vbCrLf
                    strSQL += "CreatedDate," + vbCrLf
                    strSQL += "UpdatedDate," + vbCrLf
                    strSQL += "DeletedDate," + vbCrLf
                    strSQL += "UpdatedBy" + vbCrLf
                    strSQL += ")" + vbCrLf
                    strSQL += "VALUES" + vbCrLf
                    strSQL += "(" + vbCrLf
                    strSQL += "'" + strID + "'," + vbCrLf
                    strSQL += "'" + txtUserName.Text + "'," + vbCrLf
                    strSQL += "'" + txtPassword.Text + "'," + vbCrLf
                    strSQL += "'" + cboLevel.Text + "'," + vbCrLf
                    strSQL += "" + cboQuestion_1.SelectedIndex.ToString + "," + vbCrLf
                    strSQL += "" + cboQuestion_2.SelectedIndex.ToString + "," + vbCrLf
                    strSQL += "'" + txtAnswer_1.Text + "'," + vbCrLf
                    strSQL += "'" + txtAnswer_2.Text + "'," + vbCrLf
                    strSQL += "getdate()," + vbCrLf
                    strSQL += "getdate()," + vbCrLf
                    strSQL += "null," + vbCrLf
                    strSQL += "'" + strID + "'" + vbCrLf
                    strSQL += ")" + vbCrLf

                    blResult = sqlExecute(strSQL)

                    If (blResult = True) Then
                        _gbAccountID = strID
                        Call saveLogs(1, "Account created")
                        MsgBox("Account Registered", vbOKOnly, "SUCCESS")
                        Me.Close()
                    End If
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsQuestions As New DataSet

        sqlQuery = ""
        sqlQuery += "SELECT * FROM M_SecurityQuestion" + vbCrLf
        sqlQuery += "WHERE DeletedDate IS NULL"

        dsQuestions = SQLPetMIS(sqlQuery)


        For Each row As DataRow In dsQuestions.Tables(0).Rows
            cboQuestion_1.Items.Add(row.Item("Question"))
            cboQuestion_2.Items.Add(row.Item("Question"))
        Next

        cboLevel.Items.Add("Doctor")
        cboLevel.Items.Add("Staff")
        sqlQuery = ""
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        txtConfirmPassword.ForeColor = Color.Black
    End Sub


    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click

        Try
            If btnDeactivate.Text = "DEACTIVATE" Then
                Dim strPass As String
                If MsgBox("Are you sure you want to deactivate your account?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    strPass = InputBox("Please, enter your password", "Verification")

                    If strPass = txtPassword.Text Then
                        sqlQuery = ""
                        sqlQuery += "UPDATE dbo.Accounts" & vbCrLf
                        sqlQuery += "SET isDeactivate = 1" & vbCrLf
                        sqlQuery += "WHERE AccountID = '" + txtUserID.Text + "'"

                        If sqlExecute(sqlQuery) = True Then
                            Call saveLogs(7, "Account " + _gbAccountID + "has been deactivated")
                            MsgBox("Account has been deactivated!", vbInformation)
                            frmAccountsRecords.getAccounts()
                            Me.Hide()
                        End If
                    Else
                        MsgBox("Password mismatch! Please, try again", vbExclamation)
                    End If
                End If
            Else
                If MsgBox("Are you sure you want to deactivate your account?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    sqlQuery = ""
                    sqlQuery += "UPDATE dbo.Accounts" & vbCrLf
                    sqlQuery += "SET isDeactivate = 0" & vbCrLf
                    sqlQuery += "WHERE AccountID = '" + txtUserID.Text + "'"

                    If sqlExecute(sqlQuery) = True Then
                        Call saveLogs(6, "Account " + _gbAccountID + "has been activated")
                        MsgBox("Account has been Activated!", vbInformation)
                        frmAccountsRecords.getAccounts()
                        Me.Hide()
                    End If

                End If
            End If
         
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        txtUserName.ForeColor = Color.Black
    End Sub
End Class