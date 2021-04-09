Imports System.IO
Module M_Functions
    Public strRequire As String
    Public blnRequired As Boolean = False
    Public _gbAccountID As String
    Public _gbUSerName As String
    Public _gbUserType As String
    Public dsOwnerInfo As New DataSet
    Public strNextvisit As String
    Public dtPurchasedProd As New DataTable("Products")

    Public Sub subShowHidePassword(obj As PictureBox, txtInput As TextBox)
        If obj.Image.Tag = "SHOW" Then
            obj.Image = My.Resources.hide
            obj.Image.Tag = "HIDE"
            txtInput.PasswordChar = ""
        Else
            obj.Image = My.Resources.show
            obj.Image.Tag = "SHOW"
            txtInput.PasswordChar = "•"
        End If
    End Sub

    Public Function fn_CheckRequire(container As Control) As Boolean
        For Each ctrl As Control In container.Controls
            Select Case ctrl.GetType()
                Case GetType(GroupBox)
                    fn_CheckRequire(ctrl)
                Case GetType(Panel)
                    fn_CheckRequire(ctrl)
                Case Else
                    If Left(ctrl.Tag, 1) = "*" Then
                        If ctrl.Text = "" Then
                            strRequire &= "- " & Mid(ctrl.Tag, 2, Len(ctrl.Tag) - 1) & vbCrLf
                        End If
                    End If
            End Select
        Next
        If strRequire <> "" Then
            blnRequired = True
        End If

        Return blnRequired
    End Function

    Public Sub clearFields(container As Control)
        For Each ctrl As Control In container.Controls
            Select Case ctrl.GetType()
                Case GetType(Label)
                    'No Event
                Case GetType(TextBox)
                    ctrl.Text = ""
                Case GetType(MaskedTextBox)
                    ctrl.ResetText()
                Case GetType(ComboBox)
                    Dim cbo As New ComboBox
                    cbo = ctrl
                    cbo.SelectedIndex = -1
                Case GetType(GroupBox)
                    clearFields(ctrl)
                Case GetType(Panel)
                    clearFields(ctrl)
                Case GetType(DateTimePicker)
                    Dim dtP As New DateTimePicker
                    dtP = ctrl
                    dtP.Value = Now
                Case GetType(CheckedListBox)
                    Dim chkListBox As New CheckedListBox
                    chkListBox = ctrl
                    For i As Integer = 1 To chkListBox.Items.Count - 1
                        chkListBox.SetItemChecked(i, False)
                    Next
                Case Else
                    'No Event
            End Select
        Next
    End Sub

    Public Sub subReadOnly(container As Control, blnReadOnly As Boolean)
        For Each ctrl As Control In container.Controls
            Select Case ctrl.GetType()
                Case GetType(TextBox)
                    Dim txt As New TextBox
                    txt = ctrl
                    txt.ReadOnly = blnReadOnly
                Case GetType(ComboBox)
                    Dim cbo As New ComboBox
                    cbo = ctrl
                    cbo.Enabled = Not blnReadOnly
                Case GetType(MaskedTextBox)
                    Dim msk As New MaskedTextBox
                    msk = ctrl
                    msk.ReadOnly = blnReadOnly
                Case GetType(DateTimePicker)
                    Dim dtp As New DateTimePicker
                    dtp = ctrl
                    dtp.Enabled = Not blnReadOnly
            End Select
        Next
    End Sub

    Public Sub numericOnly(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim numbers As TextBox = sender
        If InStr("1234567890.-", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Public Sub subCellFormat(ByVal sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim dvgObj As New DataGridView
        dvgObj = sender
        With dvgObj
            For i As Integer = 0 To .Rows.Count - 1
                Select Case LCase(.Rows(i).Cells("colStatus").Value)
                    Case "deleted"
                        .Rows(i).DefaultCellStyle.BackColor = My.Settings.Deleted
                    Case "deactivated"
                        .Rows(i).DefaultCellStyle.BackColor = My.Settings.Deactivated
                End Select
            Next
        End With
    End Sub

    Public Sub saveLogs(intActions As Integer, strRemarks As String)
        Try
            sqlQuery = ""
            sqlQuery += "INSERT INTO dbo.LogHistories " & vbCrLf
            sqlQuery += "(" & vbCrLf
            sqlQuery += "UserID," & vbCrLf
            sqlQuery += "ActionDate," & vbCrLf
            sqlQuery += "ActionID," & vbCrLf
            sqlQuery += "Remarks," & vbCrLf
            sqlQuery += "CreatedDate," & vbCrLf
            sqlQuery += "UpdatedDate," & vbCrLf
            sqlQuery += "DeletedDate," & vbCrLf
            sqlQuery += "UpdatedBy" & vbCrLf
            sqlQuery += ")" & vbCrLf
            sqlQuery += "VALUES" & vbCrLf
            sqlQuery += "(" & vbCrLf
            sqlQuery += "'" + _gbAccountID + "'," & vbCrLf
            sqlQuery += "getdate()," & vbCrLf
            sqlQuery += intActions.ToString & "," & vbCrLf
            sqlQuery += "'" + strRemarks + "'," & vbCrLf
            sqlQuery += "getdate()," & vbCrLf
            sqlQuery += "getdate()," & vbCrLf
            sqlQuery += "null," & vbCrLf
            sqlQuery += "'" + _gbAccountID + "')" & vbCrLf

            sqlExecute(sqlQuery)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub getOwnerInfo(strOwnerId As String)
        Try
            sqlQuery = ""
            sqlQuery += "SELECT * FROM Owners" & vbCrLf
            sqlQuery += "WHERE OwnerID = '" + strOwnerId + "'" & vbCrLf
            dsOwnerInfo = SQLPetMIS(sqlQuery)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function openFileDialog() As String
        Dim fileDialog As New OpenFileDialog
        Dim strFileName As String = ""

        With fileDialog
            .Title = "Select Pet Profile"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;"

            If .ShowDialog = DialogResult.OK Then 'When dialog is close and result is OK
                strFileName = .FileName 'get File path name
            End If
        End With
        Return strFileName
    End Function

    Public Function getDesktopProfilesPath() As String
        Dim strDesktopPath As String

        strDesktopPath = My.Computer.FileSystem.SpecialDirectories.Desktop + "\PetProfiles\"

        If Not Directory.Exists(strDesktopPath) Then
            Directory.CreateDirectory(strDesktopPath)
        End If

        Return strDesktopPath
    End Function
End Module
