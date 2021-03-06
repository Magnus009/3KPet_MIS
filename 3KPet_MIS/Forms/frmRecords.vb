Public Class frmRecords

    Public dsRecords As New DataSet
    Public strFilter As String
    Public strSearch As String
    Dim strOwnerID As String
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            Dim strPetID As String
            'Dim strOwnerID As String
            Dim blnResult As Boolean
            Dim dsCount As New DataSet

            If strdestination = "ADD" Then
                'Owner ID
                'sqlQuery = ""
                'sqlQuery = "SELECT dbo.fn_colID ('O')"
                'strOwnerID = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0).ToString

                'Pet ID
                sqlQuery = ""
                sqlQuery = "SELECT dbo.fn_colID ('P')"
                strPetID = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0).ToString

                If fn_CheckRequire(Me) Then
                    MsgBox("Please Fill out Required Field:" & vbCrLf & strRequire, MsgBoxStyle.Exclamation)
                    strRequire = ""
                Else
                    sqlQuery = ""
                    sqlQuery += "SELECT count(OwnerID) FROM OWNERS" & vbCrLf
                    sqlQuery += "WHERE OwnerID ='" + strOwnerID + "'"

                    dsCount = SQLPetMIS(sqlQuery)

                    If dsCount.Tables(0).Rows(0)(0) = 0 Then
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
                        sqlQuery += "'" + txtOwnerContactNo.Text + "'," & vbCrLf
                        sqlQuery += "'" + txtOwnerAddress.Text + "'," & vbCrLf
                        sqlQuery += "getdate()," & vbCrLf
                        sqlQuery += "getdate()," & vbCrLf
                        sqlQuery += "null," & vbCrLf
                        sqlQuery += "'" + strOwnerID + "')" & vbCrLf

                        blnResult = sqlExecute(sqlQuery)
                    End If
                   
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
                    sqlQuery += "" + txtPetAge.Text + "," & vbCrLf
                    sqlQuery += "'" + IIf(optMale.Checked = True, "M", "F") + "'," & vbCrLf
                    sqlQuery += "getdate()," & vbCrLf
                    sqlQuery += "getdate()," & vbCrLf
                    sqlQuery += "null," & vbCrLf
                    sqlQuery += "'" + strOwnerID + "')" & vbCrLf

                    blnResult = sqlExecute(sqlQuery)

                    If blnResult Then
                        MsgBox("Records saved succesfully", vbInformation + vbOKOnly)
                        Call clearFields(Me)
                        Call loadOwnerInfo()
                    End If
                End If
            Else
                If fn_CheckRequire(Me) Then
                    MsgBox("Please, select account first", vbExclamation + vbOKOnly)
                    strRequire = ""
                Else
                    sqlQuery = ""
                    sqlQuery += "UPDATE dbo.Pets" & vbCrLf
                    sqlQuery += "SET OwnerID ='" + txtOwnerID.Text + "'," & vbCrLf
                    sqlQuery += "Name ='" + txtPetName.Text + "'," & vbCrLf
                    sqlQuery += "Breed ='" + txtPetBreed.Text + "'," & vbCrLf
                    sqlQuery += "PetColor ='" + txtPetColor.Text + "'," & vbCrLf
                    sqlQuery += "Age ='" + txtPetAge.Text + "'," & vbCrLf
                    sqlQuery += "Gender ='" + IIf(optMale.Checked = True, "M", "F") + "'," & vbCrLf
                    sqlQuery += "UpdateDate = getdate()" & vbCrLf
                    sqlQuery += "WHERE PetID = '" + txtPetID.Text + "'" & vbCrLf

                    blnResult = sqlExecute(sqlQuery)


                    If blnResult = True Then
                        MsgBox("Record updated!", vbInformation + vbOKOnly)
                        Call clearFields(Me)
                        Call loadOwnerInfo()
                    End If

                End If
            End If
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
            If txtSearch.Text <> "" Then
                sqlQuery += "WHERE O.OwnerID LIKE '%" + txtSearch.Text + "%' " & vbCrLf
                sqlQuery += "OR O.LastName LIKE '%" + txtSearch.Text + "%' " & vbCrLf
                sqlQuery += "OR O.FirstName LIKE '%" + txtSearch.Text + "%' " & vbCrLf
                sqlQuery += "OR P.Name LIKE '%" + txtSearch.Text + "%' " & vbCrLf
            End If


            dsRecords = SQLPetMIS(sqlQuery)
            With datInformation
                .Columns.Clear()
                .Columns.Add("colOwnerID", "OWNER ID")
                .Columns("colOwnerID").Width = .Width * 0.2
                .Columns.Add("colOwnerName", "OWNER NAME")
                .Columns("colOwnerName").Width = .Width * 0.4
                .Columns.Add("colPetName", "PET NAME")
                .Columns("colPetName").Width = .Width * 0.3
                .Columns.Add("colPetID", "PETID")
                .Columns("colPetID").Visible = False
                .Columns.Add("colStatus", "STATUS")
                .Columns("colStatus").Visible = False

                Dim btnSelect As New DataGridViewButtonColumn
                btnSelect.Text = "•••"
                btnSelect.UseColumnTextForButtonValue = True
                btnSelect.Width = .Width * 0.09
                .Columns.Add(btnSelect)

                For Each row As DataRow In dsRecords.Tables(0).Rows
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = row.Item("OwnerID")
                    .Rows(.RowCount - 1).Cells(1).Value = row.Item("LastName") + ", " + row.Item("FirstName")
                    .Rows(.RowCount - 1).Cells(2).Value = row.Item("Name")
                    .Rows(.RowCount - 1).Cells("colStatus").Value = IIf(IsDBNull(row.Item("DeletedDate")), "", "deleted")
                    .Rows(.RowCount - 1).Cells("colPetID").Value = row.Item("PetID")
                Next

                AddHandler .CellFormatting, AddressOf subCellFormat
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txtPetAge.KeyPress, AddressOf numericOnly
        Call loadOwnerInfo()

        If (strdestination = "UPDATE") Then
            btnNewRecord.Hide()
        Else
            btnNewRecord.Show()
        End If
    End Sub

    Public Sub datInformation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datInformation.CellContentClick
        Try
            If e.ColumnIndex = 5 Then
                'strFilter = datInformation.Rows(e.RowIndex).Cells(0).Value
                strSearch = "OwnerID = '" + datInformation.Rows(e.RowIndex).Cells(0).Value + "' "
                strSearch += "AND PetID = '" + datInformation.Rows(e.RowIndex).Cells("colPetID").Value + "' "
                frmInfoDialog.Show()

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

  
End Class