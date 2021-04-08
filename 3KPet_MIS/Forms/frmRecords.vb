Public Class frmRecords

    Public dsRecords As New DataSet
    Public strFilter As String
    Public strSearch As String
    Dim strOwnerID As String
    Dim blnAddPet As Boolean = False
    Dim blnUpdate As Boolean = False

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            saveInfo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loadOwnerInfo()
        Try
            dsRecords = New DataSet
            sqlQuery = ""
            sqlQuery += "SELECT * FROM Owners O" & vbCrLf
            sqlQuery += "INNER JOIN Pets P ON O.OwnerID = P.OwnerID" & vbCrLf
            'sqlQuery += "Left JOIN TransactionHeader TH ON O.OwnerID = TH.OwnerID" & vbCrLf
            'sqlQuery += "WHERE  month(getdate())-3 < month(TH.VisitDate) OR TH.VisitDate IS null" & vbCrLf
            If txtSearch.Text <> "" Then
                sqlQuery += "Where O.OwnerID LIKE '%" + txtSearch.Text + "%' " & vbCrLf
                sqlQuery += "OR O.LastName LIKE '%" + txtSearch.Text + "%' " & vbCrLf
                sqlQuery += "OR O.FirstName LIKE '%" + txtSearch.Text + "%' " & vbCrLf
                sqlQuery += "OR P.Name LIKE '%" + txtSearch.Text + "%' " & vbCrLf
                sqlQuery += "OR P.Breed LIKE '%" + txtSearch.Text + "%' " & vbCrLf
                sqlQuery += "OR P.PetColor LIKE '%" + txtSearch.Text + "%'" & vbCrLf
            End If


            dsRecords = SQLPetMIS(sqlQuery)
            With datInformation
                .Columns.Clear()
                .Columns.Add("colOwnerName", "OWNER NAME")
                .Columns("colOwnerName").Width = .Width * 0.2
                .Columns.Add("colPetID", "PET ID")
                .Columns("colOwnerName").Width = .Width * 0.2
                .Columns.Add("colPetName", "PET NAME")
                .Columns("colPetName").Width = .Width * 0.2
                .Columns.Add("colBreed", "BREED")
                .Columns("colBreed").Width = .Width * 0.15
                .Columns.Add("colColor", "COLOR")
                .Columns("colColor").Width = .Width * 0.1
                .Columns.Add("colStatus", "STATUS")
                .Columns("colStatus").Visible = False

                Dim btnSelect As New DataGridViewButtonColumn
                btnSelect.Text = "ADD PET"
                btnSelect.UseColumnTextForButtonValue = True
                btnSelect.Width = .Width * 0.12
                .Columns.Add(btnSelect)

                For Each row As DataRow In dsRecords.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("LastName") + ", " + row.Item("FirstName")
                    .Rows(.RowCount - 1).Cells(1).Value = row.Item("PetID")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("Name")
                    .Rows(.RowCount - 1).Cells(3).Value = row.Item("Breed")
                    .Rows(.RowCount - 1).Cells(4).Value = row.Item("PetColor")
                    .Rows(.RowCount - 1).Cells("colStatus").Value = IIf(IsDBNull(row.Item("DeletedDate")), "", "deleted")
                    '.Rows(.RowCount - 1).Cells("colPetID").Value = row.Item("PetID")
                Next

                AddHandler .CellFormatting, AddressOf subCellFormat
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txtPetAge.KeyPress, AddressOf numericOnly
        AddHandler txtOwnerContactNo.KeyPress, AddressOf numericOnly
        Call loadOwnerInfo()
        btnNewRecord.Enabled = False
        txtOwnerLName.ReadOnly = False
        txtOwnerFName.ReadOnly = False
        txtOwnerContactNo.ReadOnly = False
        txtOwnerContactNo.ReadOnly = False
        txtOwnerAddress.ReadOnly = False
    End Sub

    Public Sub datInformation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datInformation.CellContentClick
        Try
            If e.ColumnIndex = 6 Then

                Dim dtData As New DataTable

                blnAddPet = True
                dtData = dsRecords.Tables(0).Select(strSearch, "OwnerID ASC").CopyToDataTable

                'Owner Info
                txtOwnerID.Text = dtData.Rows(e.RowIndex)("OwnerID")
                txtOwnerLName.Text = dtData.Rows(e.RowIndex)("LastName")
                txtOwnerFName.Text = dtData.Rows(e.RowIndex)("FirstName")
                txtOwnerContactNo.Text = dtData.Rows(e.RowIndex)("ContactNo")
                txtOwnerAddress.Text = dtData.Rows(e.RowIndex)("Address")

                'txtPetID.Text = dtData.Rows(0)("PetID")
                'txtPetName.Text = dtData.Rows(0)("Name")
                'txtPetBreed.Text = dtData.Rows(0)("Breed")
                'txtPetColor.Text = dtData.Rows(0)("PetColor")
                'txtPetAge.Text = IIf(IsDBNull(dtData.Rows(0)("Age")), "", dtData.Rows(0)("Age"))
                'chkisDeceased.Checked = dtData.Rows(0)("isDeceased")


                txtOwnerLName.ReadOnly = True
                txtOwnerFName.ReadOnly = True
                txtOwnerContactNo.ReadOnly = True
                txtOwnerContactNo.ReadOnly = True
                txtOwnerAddress.ReadOnly = True
                btnNewRecord.Enabled = True


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call loadOwnerInfo()
    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        Call clearFields(Me)
        Call subGenerateOwnerID(False)

        txtOwnerID.Text = "- - -"
        txtPetID.Text = "- - -"
        txtOwnerLName.ReadOnly = False
        txtOwnerFName.ReadOnly = False
        txtOwnerContactNo.ReadOnly = False
        txtOwnerContactNo.ReadOnly = False
        txtOwnerAddress.ReadOnly = False
        txtPetName.ReadOnly = False
        txtPetBreed.ReadOnly = False
        txtPetColor.ReadOnly = False
        txtPetAge.ReadOnly = False
        optFemale.Enabled = True
        optMale.Enabled = True
        chkisDeceased.Enabled = True
        chkisDeceased.Checked = False
        btnNewRecord.Enabled = False
        btnConfirm.Enabled = True
    End Sub

    Public Sub subGenerateOwnerID(blnAddPet As Boolean)
        If blnAddPet Then
            strOwnerID = txtOwnerID.Text
        Else
            sqlQuery = ""
            sqlQuery = "SELECT dbo.fn_colID ('O')"
            strOwnerID = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0).ToString
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(My.Application.Info.DirectoryPath)
    End Sub

    Private Sub saveInfo()
        Try
            Dim strPetID As String
            Dim blnResult As Boolean

            sqlQuery = ""
            sqlQuery = "SELECT dbo.fn_colID ('O')"
            strOwnerID = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0).ToString

            'Pet ID
            sqlQuery = ""
            sqlQuery = "SELECT dbo.fn_colID ('P')"
            strPetID = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0).ToString


            If fn_CheckRequire(Me) Then
                MsgBox("Please fill out all the required details", vbOKOnly + vbExclamation)
            Else
                If MsgBox("Are you sure you want to save?", vbYesNo + vbQuestion) = vbYes Then
                    If blnAddPet Then
                        sqlQuery = ""
                        sqlQuery += "INSERT INTO dbo.Pets " & vbCrLf
                        sqlQuery += "(" & vbCrLf
                        sqlQuery += "PetID," & vbCrLf
                        sqlQuery += "OwnerID," & vbCrLf
                        sqlQuery += "Name," & vbCrLf
                        sqlQuery += "Breed," & vbCrLf
                        sqlQuery += "PetColor," & vbCrLf
                        sqlQuery += "Age," & vbCrLf
                        sqlQuery += "Gender," & vbCrLf
                        sqlQuery += "Birthday," & vbCrLf
                        sqlQuery += "isDeceased," & vbCrLf
                        sqlQuery += "CreatedDate," & vbCrLf
                        sqlQuery += "UpdateDate," & vbCrLf
                        sqlQuery += "DeletedDate," & vbCrLf
                        sqlQuery += "UpdatedBy" & vbCrLf
                        sqlQuery += ")" & vbCrLf
                        sqlQuery += "VALUES" & vbCrLf
                        sqlQuery += "(" & vbCrLf
                        sqlQuery += "'" + strPetID + "'," & vbCrLf
                        sqlQuery += "'" + txtOwnerID.Text + "'," & vbCrLf
                        sqlQuery += "'" + txtPetName.Text + "'," & vbCrLf
                        sqlQuery += "'" + txtPetBreed.Text + "'," & vbCrLf
                        sqlQuery += "'" + txtPetColor.Text + "'," & vbCrLf
                        If txtPetAge.Text <> "" Then
                            sqlQuery += "" + txtPetAge.Text + "," & vbCrLf
                        Else
                            sqlQuery += "null," & vbCrLf
                        End If

                        sqlQuery += "'" + IIf(optMale.Checked = True, "M", "F") + "'," & vbCrLf
                        If chkBirthday.Checked Then
                            sqlQuery += "'" + dtpBirthday.Value + "'," & vbCrLf
                        Else
                            sqlQuery += "null," & vbCrLf
                        End If
                        sqlQuery += "" + Convert.ToInt32(chkisDeceased.Checked).ToString + "," & vbCrLf
                        sqlQuery += "getdate()," & vbCrLf
                        sqlQuery += "getdate()," & vbCrLf
                        sqlQuery += "null," & vbCrLf
                        sqlQuery += "'" + _gbAccountID + "')" & vbCrLf

                        blnResult = sqlExecute(sqlQuery)

                        If blnResult Then
                            MsgBox("Records saved succesfully", vbInformation + vbOKOnly)
                            saveLogs(1, "Add pet to owner " + txtOwnerID.Text)
                            blnAddPet = False
                            Call clearFields(Me)
                            Call loadOwnerInfo()
                        End If
                    ElseIf blnUpdate Then
                        sqlQuery = ""
                        sqlQuery += "UPDATE dbo.Pets" & vbCrLf
                        sqlQuery += "SET OwnerID ='" + txtOwnerID.Text + "'," & vbCrLf
                        sqlQuery += "Name ='" + txtPetName.Text + "'," & vbCrLf
                        sqlQuery += "Breed ='" + txtPetBreed.Text + "'," & vbCrLf
                        sqlQuery += "PetColor ='" + txtPetColor.Text + "'," & vbCrLf
                        sqlQuery += "Age ='" + txtPetAge.Text + "'," & vbCrLf
                        sqlQuery += "Gender ='" + IIf(optMale.Checked = True, "M", "F") + "'," & vbCrLf
                        If chkBirthday.Checked Then
                            sqlQuery += "Birthday = '" + dtpBirthday.Value + "'," & vbCrLf
                        Else
                            sqlQuery += "Birthday = null," & vbCrLf
                        End If
                        sqlQuery += "UpdateDate = getdate()" & vbCrLf
                        sqlQuery += "WHERE PetID = '" + txtPetID.Text + "'" & vbCrLf

                        blnResult = sqlExecute(sqlQuery)

                        If blnResult Then
                            MsgBox("Records saved succesfully", vbInformation + vbOKOnly)
                            saveLogs(2, "Update pet records to owner " + txtOwnerID.Text)
                            blnUpdate = False
                            Call clearFields(Me)
                            Call loadOwnerInfo()
                        End If
                    Else


                        sqlQuery = ""
                        sqlQuery += "INSERT INTO dbo.Owners" & vbCrLf
                        sqlQuery += "(" & vbCrLf
                        sqlQuery += "OwnerID," & vbCrLf
                        sqlQuery += "LastName," & vbCrLf
                        sqlQuery += "FirstName," & vbCrLf
                        sqlQuery += "Address," & vbCrLf
                        sqlQuery += "ContactNo," & vbCrLf
                        sqlQuery += "CreatedDate," & vbCrLf
                        sqlQuery += "UpdateDate," & vbCrLf
                        sqlQuery += "DeletedDate," & vbCrLf
                        sqlQuery += "UpdatedBy" & vbCrLf
                        sqlQuery += ")" & vbCrLf
                        sqlQuery += "VALUES" & vbCrLf
                        sqlQuery += "(" & vbCrLf
                        sqlQuery += "'" + strOwnerID + "'," & vbCrLf
                        sqlQuery += "'" + txtOwnerLName.Text + "'," & vbCrLf
                        sqlQuery += "'" + txtOwnerFName.Text + "'," & vbCrLf
                        sqlQuery += "'" + txtOwnerAddress.Text + "'," & vbCrLf
                        sqlQuery += "'" + txtOwnerContactNo.Text + "'," & vbCrLf
                        sqlQuery += "getdate()," & vbCrLf
                        sqlQuery += "getdate()," & vbCrLf
                        sqlQuery += "null," & vbCrLf
                        sqlQuery += "'" + _gbAccountID + "')" & vbCrLf

                        blnResult = sqlExecute(sqlQuery)


                        sqlQuery = ""
                        sqlQuery += "INSERT INTO dbo.Pets " & vbCrLf
                        sqlQuery += "(" & vbCrLf
                        sqlQuery += "PetID," & vbCrLf
                        sqlQuery += "OwnerID," & vbCrLf
                        sqlQuery += "Name," & vbCrLf
                        sqlQuery += "Breed," & vbCrLf
                        sqlQuery += "PetColor," & vbCrLf
                        sqlQuery += "Age," & vbCrLf
                        sqlQuery += "Gender," & vbCrLf
                        sqlQuery += "Birthday," & vbCrLf
                        sqlQuery += "isDeceased," & vbCrLf
                        sqlQuery += "CreatedDate," & vbCrLf
                        sqlQuery += "UpdateDate," & vbCrLf
                        sqlQuery += "DeletedDate," & vbCrLf
                        sqlQuery += "UpdatedBy" & vbCrLf
                        sqlQuery += ")" & vbCrLf
                        sqlQuery += "VALUES" & vbCrLf
                        sqlQuery += "(" & vbCrLf
                        sqlQuery += "'" + strPetID + "'," & vbCrLf
                        sqlQuery += "'" + strOwnerID + "'," & vbCrLf
                        sqlQuery += "'" + txtPetName.Text + "'," & vbCrLf
                        sqlQuery += "'" + txtPetBreed.Text + "'," & vbCrLf
                        sqlQuery += "'" + txtPetColor.Text + "'," & vbCrLf
                        If txtPetAge.Text <> "" Then
                            sqlQuery += "" + txtPetAge.Text + "," & vbCrLf
                        Else
                            sqlQuery += "null," & vbCrLf
                        End If

                        sqlQuery += "'" + IIf(optMale.Checked = True, "M", "F") + "'," & vbCrLf

                        If chkBirthday.Checked Then
                            sqlQuery += "'" + Format(dtpBirthday.Value, "yyyy/MM/dd") + "'," & vbCrLf
                        Else
                            sqlQuery += "null," & vbCrLf
                        End If
                        sqlQuery += "" + Convert.ToInt32(chkisDeceased.Checked).ToString + "," & vbCrLf
                        sqlQuery += "getdate()," & vbCrLf
                        sqlQuery += "getdate()," & vbCrLf
                        sqlQuery += "null," & vbCrLf
                        sqlQuery += "'" + _gbAccountID + "')" & vbCrLf

                        blnResult = sqlExecute(sqlQuery)

                        If blnResult Then
                            MsgBox("Records saved succesfully", vbInformation + vbOKOnly)
                            saveLogs(1, "Added new patient records")
                            Call clearFields(Me)
                            Call loadOwnerInfo()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub datInformation_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datInformation.CellContentDoubleClick
        Try
            If e.ColumnIndex <> 6 Then
                Dim dtData As New DataTable

                blnUpdate = True
                dtData = dsRecords.Tables(0).Select(strSearch, "OwnerID ASC").CopyToDataTable

                'Owner Info
                txtOwnerID.Text = dtData.Rows(e.RowIndex)("OwnerID")
                txtOwnerLName.Text = dtData.Rows(e.RowIndex)("LastName")
                txtOwnerFName.Text = dtData.Rows(e.RowIndex)("FirstName")
                txtOwnerContactNo.Text = dtData.Rows(e.RowIndex)("ContactNo")
                txtOwnerAddress.Text = dtData.Rows(e.RowIndex)("Address")

                txtPetID.Text = dtData.Rows(e.RowIndex)("PetID")
                txtPetName.Text = dtData.Rows(e.RowIndex)("Name")
                txtPetBreed.Text = dtData.Rows(e.RowIndex)("Breed")
                txtPetColor.Text = dtData.Rows(e.RowIndex)("PetColor")
                txtPetAge.Text = IIf(IsDBNull(dtData.Rows(e.RowIndex)("Age")), "", dtData.Rows(e.RowIndex)("Age"))
                dtpBirthday.Value = IIf(IsDBNull(dtData.Rows(e.RowIndex)("Birthday")), DateTime.Now, dtData.Rows(e.RowIndex)("Birthday"))
                chkBirthday.Checked = IIf(IsDBNull(dtData.Rows(e.RowIndex)("Birthday")), False, True)
                chkisDeceased.Checked = dtData.Rows(e.RowIndex)("isDeceased")


                txtOwnerLName.ReadOnly = True
                txtOwnerFName.ReadOnly = True
                txtOwnerContactNo.ReadOnly = True
                txtOwnerContactNo.ReadOnly = True
                txtOwnerAddress.ReadOnly = True
                btnNewRecord.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkBirthday_CheckedChanged(sender As Object, e As EventArgs) Handles chkBirthday.CheckedChanged
        If chkBirthday.Checked Then
            dtpBirthday.Enabled = True
            txtPetAge.Enabled = False
        Else
            dtpBirthday.Enabled = False
            txtPetAge.Enabled = True
        End If
    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        Try
            txtPetAge.Text = Math.Round(DateDiff(DateInterval.Day, dtpBirthday.Value, Now) / 365.25, 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtPetColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPetColor.KeyPress
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            If Not Char.IsLetter(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub
End Class