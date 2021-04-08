
Public Class frmCreateAccount
    Public blnIsUpdate As Boolean = False
    Public isExisting As Boolean = False
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

            If blnIsUpdate = False Then
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
                    ElseIf dsUserName.Tables(0).Rows(0)(0) <> 0 Then
                        MsgBox("User name already exist!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                        txtUserName.ForeColor = Color.Red
                        txtUserName.Focus()
                    Else
                        If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) = vbYes Then
                            strSQL = ""
                            strSQL = "SELECT dbo.fn_colID ('U')"

                            dsID = SQLPetMIS(strSQL)
                            strID = dsID.Tables(0).Rows(0)(0)

                            sqlQuery = ""
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
                            strSQL += "isDeactivate," + vbCrLf
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
                            strSQL += "'" + cboLevel.SelectedValue.ToString + "'," + vbCrLf
                            strSQL += "" + cboQuestion_1.SelectedValue.ToString + "," + vbCrLf
                            strSQL += "" + cboQuestion_2.SelectedValue.ToString + "," + vbCrLf
                            strSQL += "'" + txtAnswer_1.Text + "'," + vbCrLf
                            strSQL += "'" + txtAnswer_2.Text + "'," + vbCrLf
                            strSQL += "0," + vbCrLf
                            strSQL += "getdate()," + vbCrLf
                            strSQL += "getdate()," + vbCrLf
                            strSQL += "null," + vbCrLf
                            strSQL += "'" + strID + "'" + vbCrLf
                            strSQL += ")" + vbCrLf

                            blResult = sqlExecute(strSQL)

                            If (blResult = True) Then
                                _gbAccountID = strID
                                Call saveLogs(1, "Account created")
                                MsgBox("Account Registered", vbOKOnly & vbInformation)
                                Me.Close()
                            End If
                        End If
                        End If
                       
                End If
            Else
                strSQL = ""
                strSQL += "SELECT count(UserName) FROM Accounts" & vbCrLf
                strSQL += "WHERE AccountID <> '" + txtUserID.Text + "'" & vbCrLf
                strSQL += "AND UserName = '" + txtUserName.Text + "'"
                dsUserName = SQLPetMIS(strSQL)
                If (txtPassword.Text <> txtConfirmPassword.Text Or txtConfirmPassword.Text = "") Then
                    MsgBox("Make sure your passwords match!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PASSWORD MISMATCH")
                    txtConfirmPassword.ForeColor = Color.Red
                    txtConfirmPassword.Focus()
                ElseIf dsUserName.Tables(0).Rows(0)(0) <> 0 Then
                    MsgBox("User name already exist!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    txtUserName.ForeColor = Color.Red
                    txtUserName.Focus()
                Else
                    If MsgBox("Are you sure you want to save changes?", vbYesNo + vbQuestion) = vbYes Then
                        strSQL = ""
                        strSQL += "UPDATE dbo.Accounts" & vbCrLf
                        strSQL += "SET UserName = '" + txtUserName.Text + "'" & vbCrLf
                        strSQL += ", Password = '" + txtPassword.Text + "'" & vbCrLf
                        strSQL += ", UserLevel = '" + cboLevel.SelectedValue.ToString + "'" & vbCrLf
                        strSQL += ", Q1 = '" + cboQuestion_1.SelectedValue.ToString + "'" & vbCrLf
                        strSQL += ", Q2 = '" + cboQuestion_2.SelectedValue.ToString + "'" & vbCrLf
                        strSQL += ", A1 = '" + txtAnswer_1.Text + "'" & vbCrLf
                        strSQL += ", A2 = '" + txtAnswer_2.Text + "'" & vbCrLf
                        strSQL += ", UpdatedDate =getdate()" & vbCrLf
                        strSQL += "WHERE AccountID = '" + txtUserID.Text + "'" & vbCrLf
                        blResult = sqlExecute(strSQL)

                        strSQL = ""
                        strSQL += "UPDATE dbo.Users" & vbCrLf
                        strSQL += "SET LastName = '" + txtLName.Text + "'" & vbCrLf
                        strSQL += ", FirstName = '" + txtFName.Text + "'" & vbCrLf
                        strSQL += ", MiddleName = '" + txtMName.Text + "'" & vbCrLf
                        strSQL += ", UpdatedDate =getdate()" & vbCrLf
                        strSQL += "WHERE UserID = '" + txtUserID.Text + "'" & vbCrLf
                        blResult = sqlExecute(strSQL)

                        If (blResult = True) Then
                            _gbAccountID = txtUserID.Text
                            Call saveLogs(2, "Account updated")
                            MsgBox("Account Updated!", vbOKOnly & vbInformation)
                            Me.Close()
                        End If
                    End If
                   
                End If
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsQuestions As New DataSet
        Dim dsUserLevel As New DataSet

        sqlQuery = ""
        sqlQuery += "SELECT * FROM M_SecurityQuestion" + vbCrLf
        sqlQuery += "WHERE DeletedDate IS NULL"
        dsQuestions = SQLPetMIS(sqlQuery)

        sqlQuery = ""
        sqlQuery += "SELECT * FROM UserLevel" & vbCrLf
        sqlQuery += "WHERE DeletedDate IS NULL"
        dsUserLevel = SQLPetMIS(sqlQuery)

        'cboQuestion_1.Items.Clear()
        'cboQuestion_2.Items.Clear()

        cboQuestion_1.DataSource = dsQuestions.Tables(0)
        cboQuestion_1.DisplayMember = "Question"
        cboQuestion_1.ValueMember = "QuestionID"

        cboQuestion_2.DataSource = dsQuestions.Tables(0)
        cboQuestion_2.DisplayMember = "Question"
        cboQuestion_2.ValueMember = "QuestionID"
        'For Each row As DataRow In dsQuestions.Tables(0).Rows
        '    cboQuestion_1.Items.Add(row.Item("Question"))
        '    cboQuestion_2.Items.Add(row.Item("Question"))
        'Next

        'cboLevel.Items.Clear()
        'cboLevel.Items.Add("Admin")
        'cboLevel.Items.Add("Staff")
        'sqlQuery = ""

        cboLevel.DataSource = dsUserLevel.Tables(0)
        cboLevel.DisplayMember = "Description"
        cboLevel.ValueMember = "LevelID"

        getAccountInfo()


    End Sub

    Private Sub getAccountInfo()
        Try
            Dim dsAccount As New DataSet
            txtUserID.ReadOnly = True
            txtLName.ReadOnly = True
            txtFName.ReadOnly = True
            txtMName.ReadOnly = True
            txtPassword.Text = ""
            cboQuestion_1.Enabled = False
            cboQuestion_2.Enabled = False
            txtAnswer_1.ReadOnly = True
            txtAnswer_2.ReadOnly = True
            btnDeactivate.Enabled = False

            sqlQuery = ""
            sqlQuery += "SELECT * FROM Accounts A" & vbCrLf
            sqlQuery += "INNER JOIN UserLevel UL ON A.Userlevel = UL.LevelID" & vbCrLf
            sqlQuery += "INNER JOIN Users U ON A.AccountID = U.UserID" & vbCrLf
            sqlQuery += "WHERE U.UserID = '" + _gbAccountID + "'" & vbCrLf
            dsAccount = SQLPetMIS(sqlQuery)

            txtUserID.Text = dsAccount.Tables(0).Rows(0)("UserID")
            txtLName.Text = dsAccount.Tables(0).Rows(0)("LastName")
            txtFName.Text = dsAccount.Tables(0).Rows(0)("FirstName")
            txtMName.Text = dsAccount.Tables(0).Rows(0)("MiddleName")

            cboLevel.SelectedValue = Convert.ToInt32(dsAccount.Tables(0).Rows(0)("UserLevel"))
            txtUserName.Text = dsAccount.Tables(0).Rows(0)("UserName")
            cboQuestion_1.SelectedValue = dsAccount.Tables(0).Rows(0)("Q1")
            cboQuestion_2.SelectedValue = dsAccount.Tables(0).Rows(0)("Q2")
            txtAnswer_1.Text = dsAccount.Tables(0).Rows(0)("A1")
            txtAnswer_2.Text = dsAccount.Tables(0).Rows(0)("A2")
            blnIsUpdate = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        txtUserName.ForeColor = Color.Black
    End Sub

    Private Sub frmCreateAccount_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        frmAccountsRecords.getAccounts()
    End Sub
End Class