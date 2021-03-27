Public Class frmForgetPassword
    Dim strID As String
    Private Sub frmForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subPanelSwitch(False)
        Call subLoadUserInfo()
    End Sub

    Private Sub subLoadUserInfo()
        Try
            Dim dsUsers As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT UserID, LastName, FirstName, MiddleName FROM Users" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "WHERE LastName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR FirstName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
                sqlQuery += "OR MiddleName LIKE '%" + txtSearch.Text + "%'" & vbCrLf
            End If

            datUserInfo.Columns.Clear()
            dsUsers = SQLPetMIS(sqlQuery)
            datUserInfo.DataSource = dsUsers
            datUserInfo.DataMember = "Table"

            'hide ID
            datUserInfo.Columns(0).Visible = False

            'add Button
            Dim btnView As New DataGridViewButtonColumn

            btnView.Text = "SELECT"
            btnView.UseColumnTextForButtonValue = True
            datUserInfo.Columns.Add(btnView)
            datUserInfo.Columns(datUserInfo.ColumnCount - 1).Width = 50
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            Dim dsAnswers As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT AccountID,A1,A2 FROM Accounts " & vbCrLf
            sqlQuery += "WHERE AccountID = '" + strID + "'"

            dsAnswers = SQLPetMIS(sqlQuery)

            If txtQuestion_1.Text <> "" And txtQuestion_2.Text <> "" Then
                If fn_CheckRequire(pnlRight) Then
                    MsgBox("Answer required!", vbExclamation + vbOKOnly)
                    strRequire = ""
                    blnRequired = False
                Else
                    If txtAnswer_1.Text.ToUpper = dsAnswers.Tables(0).Rows(0)(1).ToString.ToUpper And txtAnswer_2.Text.ToUpper = dsAnswers.Tables(0).Rows(0)(2).ToString.ToUpper Then
                        subPanelSwitch(True)
                    Else
                        MsgBox("The answer you've entered is incorrect. Please, Try again.", vbExclamation + vbOKOnly)
                        If txtAnswer_1.Text.ToUpper <> dsAnswers.Tables(0).Rows(0)(1) Then
                            txtAnswer_1.ForeColor = Color.Red
                        End If

                        If txtAnswer_2.Text.ToUpper <> dsAnswers.Tables(0).Rows(0)(2) Then
                            txtAnswer_2.ForeColor = Color.Red
                        End If
                    End If


                End If
            Else
                MsgBox("Please select user", vbExclamation + vbOKOnly)
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


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call subLoadUserInfo()
    End Sub

    Private Sub datUserInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datUserInfo.CellContentClick
        Try
            Dim dsQuestions As New DataSet

            If e.ColumnIndex = 4 Then
                strID = datUserInfo.Rows(e.RowIndex).Cells(0).Value
                sqlQuery = ""
                sqlQuery += "SELECT A.AccountID, SQ1.Question, SQ2.Question FROM Accounts A" & vbCrLf
                sqlQuery += "INNER JOIN M_SecurityQuestion SQ1 ON A.Q1 = SQ1.QuestionID" & vbCrLf
                sqlQuery += "INNER JOIN M_SecurityQuestion SQ2 ON A.Q2 = SQ2.QuestionID" & vbCrLf
                sqlQuery += "WHERE AccountID = '" + strID + "'"

                dsQuestions = SQLPetMIS(sqlQuery)

                txtQuestion_1.Text = dsQuestions.Tables(0).Rows(0)(1)
                txtQuestion_2.Text = dsQuestions.Tables(0).Rows(0)(2)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

       
    End Sub

    Private Sub txtAnswer_1_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer_1.TextChanged
        txtAnswer_1.ForeColor = Color.Black
    End Sub

    Private Sub txtAnswer_2_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer_2.TextChanged
        txtAnswer_2.ForeColor = Color.Black
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            Dim blnResult As Boolean

            sqlQuery = ""
            sqlQuery += "UPDATE dbo.Accounts" & vbCrLf
            sqlQuery += "SET Password = '" + txtNewPass.Text + "'"
            sqlQuery += "WHERE AccountID = '" + strID + "'"

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
End Class