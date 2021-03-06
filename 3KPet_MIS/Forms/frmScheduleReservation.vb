Public Class frmScheduleReservation

    Private Sub txtTimeFrom_Leave(sender As Object, e As EventArgs) Handles txtTimeFrom.Leave
        subCheckTime(sender)
    End Sub
    Private Sub txtTimeTo_Leave(sender As Object, e As EventArgs) Handles txtTimeTo.Leave
        subCheckTime(sender)
    End Sub

    Private Sub subCheckTime(txtInput As MaskedTextBox)
        If txtInput.Text <> "" Then
            txtInput.TextMaskFormat = MaskFormat.IncludePromptAndLiterals

            Dim strErr As String = ""
            Dim intTime As Integer = Val(txtInput.Text.Substring(0, 2))

            Select Case True
                Case Not txtInput.MaskCompleted
                    strErr = "Input Incomplete"
                Case intTime > 23
                    strErr = "Invalid Input"
            End Select

            If strErr <> "" Then
                MessageBox.Show(strErr, "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtInput.Select()
            End If
        End If
        txtInput.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
    End Sub

    Private Sub frmScheduleReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dsServices As DataSet

            sqlQuery = ""
            sqlQuery = "SELECT * FROM Services" & vbCrLf
            sqlQuery += "WHERE DeletedDate IS null"

            dsServices = SQLPetMIS(sqlQuery)

            For Each row As DataRow In dsServices.Tables(0).Rows
                cboServices.Items.Add(row.Item("Description"))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim dsID As New DataSet
            Dim strCustomerID As String

            sqlQuery = ""
            sqlQuery += "SELECT dbo.fn_colID ('S')"

            dsID = SQLPetMIS(sqlQuery)

            strCustomerID = dsID.Tables(0).Rows(0)(0)

            If fn_CheckRequire(Me) Then
                MsgBox("Please Fill out Required Field:" & vbCrLf & strRequire, MsgBoxStyle.Exclamation)
                strRequire = ""
            Else
                sqlQuery = ""
                sqlQuery += "INSERT INTO dbo.Schedules " & vbCrLf
                sqlQuery += "(" & vbCrLf
                sqlQuery += "ScheduleCode, " & vbCrLf
                sqlQuery += "CustomerName, " & vbCrLf
                sqlQuery += "ScheduleDate," & vbCrLf
                sqlQuery += "TimeFrom," & vbCrLf
                sqlQuery += "TimeTo," & vbCrLf
                sqlQuery += "ServiceID," & vbCrLf
                sqlQuery += "Purpose," & vbCrLf
                sqlQuery += "CreatedDate," & vbCrLf
                sqlQuery += "UpdatedDate," & vbCrLf
                sqlQuery += "DeletedDate," & vbCrLf
                sqlQuery += "UpdatedBy" & vbCrLf
                sqlQuery += ")" & vbCrLf
                sqlQuery += "VALUES " & vbCrLf
                sqlQuery += "(" & vbCrLf
                sqlQuery += "'" + strCustomerID + "'," + vbCrLf
                sqlQuery += "'" + txtCustomer.Text + "'," + vbCrLf
                sqlQuery += "'" + Format(dtpDateSched.Value, "Short Date") + "'," + vbCrLf
                txtTimeFrom.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
                sqlQuery += "'" + txtTimeFrom.Text + "'," + vbCrLf
                txtTimeTo.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
                sqlQuery += "'" + txtTimeTo.Text + "'," + vbCrLf
                sqlQuery += "'" + cboServices.SelectedIndex.ToString + "'," + vbCrLf
                sqlQuery += "'" + txtPurpose.Text + "'," + vbCrLf
                sqlQuery += "getdate()," + vbCrLf
                sqlQuery += "getdate(), " + vbCrLf
                sqlQuery += "Null," + vbCrLf
                sqlQuery += "'" + strCustomerID + "')" + vbCrLf

                blnRequired = sqlExecute(sqlQuery)

                If blnRequired = True Then
                    MsgBox("Schedule saved succesfully", vbInformation + vbOKOnly)
                End If


            End If

           
        Catch ex As Exception

        End Try
    End Sub
End Class