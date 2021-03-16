Public Class frmInfoDialog
    'Dim dsRecords As New DataSet
    Dim dtData As New DataTable("Owner_Pet_Information")
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim dsData As New DataSet
            dsData = frmRecords.dsRecords


            dtData = dsData.Tables(0).Select(frmRecords.strSearch, "OwnerID ASC").CopyToDataTable

            With frmRecords

                'Owner Info
                .txtOwnerID.Text = dtData.Rows(0)("OwnerID")
                .txtOwnerLName.Text = dtData.Rows(0)("LastName")
                .txtOwnerFName.Text = dtData.Rows(0)("FirstName")
                .txtOwnerContactNo.Text = dtData.Rows(0)("ContactNo")
                .txtOwnerAddress.Text = dtData.Rows(0)("Address")

                .txtPetID.Text = dtData.Rows(0)("PetID")
                .txtPetName.Text = dtData.Rows(0)("Name")
                .txtPetBreed.Text = dtData.Rows(0)("Breed")
                .txtPetColor.Text = dtData.Rows(0)("PetColor")
                .txtPetAge.Text = dtData.Rows(0)("Age")
                .chkisDeceased.Checked = dtData.Rows(0)("isDeceased")



                'If strdestination <> "ADD" Then
                '    .txtOwnerLName.ReadOnly = False
                '    .txtOwnerFName.ReadOnly = False
                '    .txtOwnerContactNo.ReadOnly = False
                '    .txtOwnerContactNo.ReadOnly = False
                '    .txtOwnerAddress.ReadOnly = False
                '    .txtPetName.ReadOnly = False
                '    .txtPetBreed.ReadOnly = False
                '    .txtPetColor.ReadOnly = False
                '    .txtPetAge.ReadOnly = False
                '    .optFemale.Enabled = True
                '    .optMale.Enabled = True

                '    .btnConfirm.Enabled = True
                'Else
                .txtOwnerLName.ReadOnly = True
                .txtOwnerFName.ReadOnly = True
                .txtOwnerContactNo.ReadOnly = True
                .txtOwnerContactNo.ReadOnly = True
                .txtOwnerAddress.ReadOnly = True

                .txtPetName.ReadOnly = True
                .txtPetBreed.ReadOnly = True
                .txtPetColor.ReadOnly = True
                .txtPetAge.ReadOnly = True
                .optFemale.Enabled = False
                .optMale.Enabled = False
                .chkisDeceased.Enabled = False



                .btnConfirm.Enabled = False
                'End If
            End With
            frmRecords.subGenerateOwnerID(False)
            Me.Hide()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        Try
            With frmRecords
                Dim dsData As New DataSet

                dsData = frmRecords.dsRecords


                dtData = dsData.Tables(0).Select(frmRecords.strSearch, "OwnerID ASC").CopyToDataTable

                'Owner Info
                .txtOwnerID.Text = dtData.Rows(0)("OwnerID")
                .txtOwnerLName.Text = dtData.Rows(0)("LastName")
                .txtOwnerFName.Text = dtData.Rows(0)("FirstName")
                .txtOwnerContactNo.Text = dtData.Rows(0)("ContactNo")
                .txtOwnerAddress.Text = dtData.Rows(0)("Address")

                If strdestination = "UPDATE" Then
                    .txtPetID.Text = dtData.Rows(0)("PetID")
                    .txtPetName.Text = dtData.Rows(0)("Name")
                    .txtPetBreed.Text = dtData.Rows(0)("Breed")
                    .txtPetColor.Text = dtData.Rows(0)("PetColor")
                    .txtPetAge.Text = dtData.Rows(0)("Age")
                    .chkisDeceased.Checked = dtData.Rows(0)("isDeceased")
                End If

                .txtOwnerLName.ReadOnly = True
                .txtOwnerFName.ReadOnly = True
                .txtOwnerContactNo.ReadOnly = True
                .txtOwnerContactNo.ReadOnly = True
                .txtOwnerAddress.ReadOnly = True
                'Pet Info
                .txtPetName.ReadOnly = False
                .txtPetBreed.ReadOnly = False
                .txtPetColor.ReadOnly = False
                .txtPetAge.ReadOnly = False
                .optFemale.Enabled = True
                .optMale.Enabled = True
                .chkisDeceased.Enabled = True

                .btnConfirm.Enabled = True
            End With
            frmRecords.subGenerateOwnerID(True)
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmInfoDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If strdestination = "ADD" Then
            btnAddPet.Text = "ADD PET"
        Else
            btnAddPet.Text = "UPDATE RECORD"
        End If
    End Sub
End Class