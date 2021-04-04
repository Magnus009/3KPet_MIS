Public Class frmForgetPassword
    Dim strID As String
    Dim dsAccount As New DataSet

    Private Sub frmForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subPanelSwitch(False)
        Call subLoadUserInfo()
    End Sub

    Private Sub subLoadUserInfo()
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            Dim dsAnswer As New DataSet

            If txtAnswer_1.Text <> "" Then
                If fn_CheckRequire(pnlRight) Then
                    MsgBox("Answer required!", vbExclamation + vbOKOnly)
                    strRequire = ""
                    blnRequired = False
                Else
                    sqlQuery = ""
                    sqlQuery += "DECLARE @question AS NVARCHAR" & vbCrLf
                    sqlQuery += "SET @question = '" + cboQuestions.SelectedValue + "'" & vbCrLf
                    sqlQuery += "SELECT CASE WHEN Q1 = @question THEN A1" & vbCrLf
                    sqlQuery += "WHEN Q2  = @question THEN A2" & vbCrLf
                    sqlQuery += "END AS Answer FROM Accounts" & vbCrLf
                    sqlQuery += "WHERE AccountID = '" + dsAccount.Tables(0).Rows(0)("AccountID") + "'" & vbCrLf
                    dsAnswer = SQLPetMIS(sqlQuery)

                    If txtAnswer_1.Text.ToUpper = dsAnswer.Tables(0).Rows(0)("Answer").ToString.ToUpper Then
                        subPanelSwitch(True)
                    Else
                        MsgBox("The answer you've entered is incorrect. Please, Try again.", vbExclamation + vbOKOnly)
                        txtAnswer_1.ForeColor = Color.Red

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub subPanelSwitch(isLeft As Boolean)
        If isLeft Then
            For i As Integer = pnlLeft.Width To 430 Step 21
                pnlLeft.Width = i
            Next
            pnlLeft.Width = 430
            pnlRight.Width = 20
        Else
            For i As Integer = pnlLeft.Width To 20 Step -21
                pnlLeft.Width = i
            Next
            pnlLeft.Width = 20
            pnlRight.Width = 430
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        subPanelSwitch(False)
    End Sub

    Private Sub picOP_Click(sender As Object, e As EventArgs) Handles picOP.Click
        Call subShowHidePassword(picOP, txtOldPass)
    End Sub

    Private Sub picNP_Click(sender As Object, e As EventArgs) Handles picNP.Click
        Call subShowHidePassword(picNP, txtNewPass)
    End Sub

    Private Sub picCNP_Click(sender As Object, e As EventArgs) Handles picCNP.Click
        Call subShowHidePassword(picCNP, txtConfirmNewPass)
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        Call subLoadUserInfo()
    End Sub



    Private Sub txtAnswer_1_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer_1.TextChanged
        txtAnswer_1.ForeColor = Color.Black
    End Sub

    Private Sub txtAnswer_2_TextChanged(sender As Object, e As EventArgs)
        'txtAnswer_2.ForeColor = Color.Black
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            Dim blnResult As Boolean

            sqlQuery = ""
            sqlQuery += "UPDATE dbo.Accounts" & vbCrLf
            sqlQuery += "SET Password = '" + txtNewPass.Text + "'"
            sqlQuery += "WHERE AccountID = '" + dsAccount.Tables(0).Rows(0)("AccountID") + "'"

            If fn_CheckRequire(pnlLeft) Then
                MsgBox("Please filled out all the required field", vbExclamation + vbOKOnly)
                strRequire = ""
                blnRequired = False
            Else
                If txtNewPass.Text <> txtConfirmNewPass.Text Then
                    MsgBox("Password does not match!", vbExclamation + vbOKOnly)
                    txtConfirmNewPass.ForeColor = Color.Red
                Else
                    blnResult = sqlExecute(sqlQuery)
                    If blnResult Then
                        _gbAccountID = strID
                        Call saveLogs(2, "Account " + _gbAccountID + " changed password")
                        MsgBox("Your password has been changed succesfully", vbInformation + vbOKOnly)
                        clearFields(Me)
                        frmUserLogin.Show()
                        Me.Hide()
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtOldPass_TextChanged(sender As Object, e As EventArgs) Handles txtOldPass.TextChanged
        txtOldPass.ForeColor = Color.Black
    End Sub

    Private Sub txtConfirmNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmNewPass.TextChanged
        txtConfirmNewPass.ForeColor = Color.Black
    End Sub

    Private Sub txtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
        Try


            sqlQuery = ""
            sqlQuery += "SELECT AccountID,UserName,Q1,Q1.Question as QS1 ,Q2,Q2.Question as QS2,A1,A2 FROM Accounts A" & vbCrLf
            sqlQuery += "INNER JOIN M_SecurityQuestion Q1 ON A.Q1 = Q1.QuestionID" & vbCrLf
            sqlQuery += "INNER JOIN M_SecurityQuestion Q2 ON A.Q2 = Q2.QuestionID" & vbCrLf
            sqlQuery += "WHERE A.UserName ='" + txtUserName.Text + "'" & vbCrLf
            dsAccount = SQLPetMIS(sqlQuery)

            If dsAccount.Tables(0).Rows.Count = 0 Then
                MsgBox("User name doesn't exist!", vbOKOnly + vbExclamation)
            Else
                cboQuestions.Items.Clear()
                Dim comboSource As New Dictionary(Of String, String)()
                comboSource.Add(dsAccount.Tables(0).Rows(0)("Q1"), dsAccount.Tables(0).Rows(0)("QS1"))
                comboSource.Add(dsAccount.Tables(0).Rows(0)("Q2"), dsAccount.Tables(0).Rows(0)("QS2"))
                cboQuestions.DataSource = New BindingSource(comboSource, Nothing)
                cboQuestions.DisplayMember = "Value"
                cboQuestions.ValueMember = "Key"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class