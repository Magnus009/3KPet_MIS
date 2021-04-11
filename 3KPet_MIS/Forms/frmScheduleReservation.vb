Public Class frmScheduleReservation
    Public blnisUpdate As Boolean

    Private Sub frmScheduleReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call getServices()
        If txtSchedCode.Text <> "" And txtSchedCode.Text <> "- - -" Then
            Call getSchedule()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim dsID As New DataSet
            Dim strScheduleID As String
            Dim blnSQLRun As Boolean


            If blnisUpdate Then
                If MsgBox("Are you sure you want to update?", vbYesNo + vbQuestion) = vbYes Then
                    sqlQuery = ""
                    sqlQuery += "UPDATE dbo.Schedules" & vbCrLf
                    sqlQuery += "SET ScheduleDate = '" + Format(dtpDateSched.Value, "yyyy/MM/dd") + "'" & vbCrLf
                    sqlQuery += ", ServiceID = '" + cboServices.SelectedValue + "'" & vbCrLf
                    sqlQuery += ", Purpose = '" + txtPurpose.Text + "'" & vbCrLf
                    sqlQuery += ", isArrived = " + Convert.ToInt32(chkIsArrived.CheckState).ToString & vbCrLf
                    sqlQuery += ", isCancelled = " + Convert.ToInt32(chkCancel.CheckState).ToString & vbCrLf
                    sqlQuery += ", UpdatedDate = getdate()" & vbCrLf
                    sqlQuery += ", UpdatedBy = '" + _gbAccountID + "'" & vbCrLf
                    sqlQuery += "WHERE ScheduleCode = '" + txtSchedCode.Text + "'" & vbCrLf
                    blnSQLRun = sqlExecute(sqlQuery)

                    If blnSQLRun Then
                        MsgBox("Schedule updated!", vbOKOnly + vbInformation)
                        Call saveLogs(2, "Updated schedule wirh Schedule code of : " + txtSchedCode.Text)
                        frmSchedules.getSchedules()
                        blnisUpdate = False
                        Me.Hide()
                        Call clearFields(Me)

                    End If
                End If

            Else
                
                If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) = vbYes Then
                    sqlQuery = ""
                    sqlQuery += "SELECT dbo.fn_colID ('S')"

                    dsID = SQLPetMIS(sqlQuery)

                    txtCustomer.Text = dsOwnerInfo.Tables(0).Rows(0)("LastName") + ", " + dsOwnerInfo.Tables(0).Rows(0)("FirstName")
                    txtAddress.Text = dsOwnerInfo.Tables(0).Rows(0)("Address")
                    txtContact.Text = dsOwnerInfo.Tables(0).Rows(0)("ContactNo")
                    strScheduleID = dsID.Tables(0).Rows(0)(0)


                    strRequire = "" : blnRequired = False
                    If fn_CheckRequire(Me) Then
                        MsgBox("Please Fill out Required Field:" & vbCrLf & strRequire, MsgBoxStyle.Exclamation)
                        strRequire = "" : blnRequired = False
                    Else
                        sqlQuery = ""
                        sqlQuery += "INSERT INTO dbo.Schedules " & vbCrLf
                        sqlQuery += "(" & vbCrLf
                        sqlQuery += "ScheduleCode, " & vbCrLf
                        sqlQuery += "CustomerID, " & vbCrLf
                        sqlQuery += "ScheduleDate," & vbCrLf
                        sqlQuery += "ServiceID," & vbCrLf
                        sqlQuery += "Purpose," & vbCrLf
                        sqlQuery += "isArrived," & vbCrLf
                        sqlQuery += "isCancelled," & vbCrLf
                        sqlQuery += "CreatedDate," & vbCrLf
                        sqlQuery += "UpdatedDate," & vbCrLf
                        sqlQuery += "DeletedDate," & vbCrLf
                        sqlQuery += "UpdatedBy" & vbCrLf
                        sqlQuery += ")" & vbCrLf
                        sqlQuery += "VALUES " & vbCrLf
                        sqlQuery += "(" & vbCrLf
                        sqlQuery += "'" + strScheduleID + "', " & vbCrLf
                        sqlQuery += "'" + dsOwnerInfo.Tables(0).Rows(0)("OwnerID") + "', " & vbCrLf
                        sqlQuery += "'" + Format(dtpDateSched.Value, "yyyy/MM/dd") + "'," & vbCrLf
                        sqlQuery += "'" + cboServices.SelectedValue + "'," & vbCrLf
                        sqlQuery += "'" + txtPurpose.Text + "'," & vbCrLf
                        sqlQuery += Convert.ToInt32(chkIsArrived.CheckState).ToString + "," & vbCrLf
                        sqlQuery += Convert.ToInt32(chkCancel.CheckState).ToString + "," & vbCrLf
                        sqlQuery += "getdate()," & vbCrLf
                        sqlQuery += "getdate()," & vbCrLf
                        sqlQuery += "null," & vbCrLf
                        sqlQuery += "'" + _gbAccountID + "'" & vbCrLf
                        sqlQuery += ")" & vbCrLf


                        blnSQLRun = sqlExecute(sqlQuery)

                        If blnSQLRun = True Then
                            MsgBox("Schedule saved succesfully", vbInformation + vbOKOnly)
                            strNextvisit = Format(dtpDateSched.Value, "yyyy/MM/dd")
                            Call saveLogs(1, "Save a schedule with Schedule code of : " + strScheduleID)
                            frmSchedules.getSchedules()
                            frmDashboard.getSchedules()
                            Me.Hide()
                            Call clearFields(Me)

                        End If


                    End If
                End If

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnOwner_Click(sender As Object, e As EventArgs) Handles btnOwner.Click
        frmOwnerList.ShowDialog()
        txtCustomer.Text = dsOwnerInfo.Tables(0).Rows(0)("LastName") + ", " + dsOwnerInfo.Tables(0).Rows(0)("FirstName")
        txtAddress.Text = dsOwnerInfo.Tables(0).Rows(0)("Address")
        txtContact.Text = dsOwnerInfo.Tables(0).Rows(0)("ContactNo")
    End Sub

    Private Sub getServices()
        Try
            Dim dsServices As New DataSet

            sqlQuery = ""
            sqlQuery = "SELECT * FROM Services" & vbCrLf
            sqlQuery += "WHERE DeletedDate IS null"

            dsServices = New DataSet
            dsServices = SQLPetMIS(sqlQuery)


            'cboServices.Items.Clear()
            cboServices.DataSource = dsServices.Tables(0)
            cboServices.DisplayMember = "Description"
            cboServices.ValueMember = "ServiceID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getSchedule()
        Try
            Dim dsSched As New DataSet

            sqlQuery = ""
            sqlQuery += "SELECT SD.ScheduleCode, SD.CustomerID, O.LastName + ', ' + O.FirstName as CUSTOMERNAme, O.Address, O.ContactNo,S.ServiceID, S.Description, SD.Purpose, SD.ScheduleDate, SD.isArrived, SD.isCancelled FROM Schedules SD" & vbCrLf
            sqlQuery += "INNER JOIN Owners O ON SD.CustomerID = O.OwnerID" & vbCrLf
            sqlQuery += "Left JOIN Services S ON SD.ServiceID = S.ServiceID" & vbCrLf
            sqlQuery += "WHERE SD.ScheduleCode ='" + txtSchedCode.Text + "'" & vbCrLf
            dsSched = SQLPetMIS(sqlQuery)

            txtCustomer.Text = dsSched.Tables(0).Rows(0)("CUSTOMERNAme")
            txtAddress.Text = dsSched.Tables(0).Rows(0)("Address")
            txtContact.Text = dsSched.Tables(0).Rows(0)("ContactNo")
            dtpDateSched.Value = Format(dsSched.Tables(0).Rows(0)("ScheduleDate"), "yyyy/MM/dd")
            cboServices.Text = IIf(IsDBNull(dsSched.Tables(0).Rows(0)("Description")), "", dsSched.Tables(0).Rows(0)("Description"))
            txtPurpose.Text = dsSched.Tables(0).Rows(0)("Purpose")
            chkCancel.Visible = True
            chkCancel.Checked = dsSched.Tables(0).Rows(0)("isCancelled")
            chkIsArrived.Visible = True
            chkIsArrived.Checked = dsSched.Tables(0).Rows(0)("isArrived")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class