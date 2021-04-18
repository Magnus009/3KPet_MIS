Imports System.IO

Public Class frmBackupRestore

    Private Sub frmBackupRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabasesBak()
        checkBackupDirectory()
        txtPath.Text = "C:\BACKUP\Pet_MIS_" + Format(Today, "yyyyMMdd") + ".bak"
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            Dim msgDlg As DialogResult
            msgDlg = MsgBox("Do you want to backup", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BACKUP")
            If msgDlg = Windows.Forms.DialogResult.Yes Then
                sqlQuery = "BACKUP DATABASE Pet_MIS TO DISK = '" + txtPath.Text + "'"
                If sqlExecute(sqlQuery) Then
                    MsgBox("Database Backup Successfully!", MsgBoxStyle.Information)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub checkBackupDirectory()
        Dim strPath As String
        strPath = "C:\BACKUP\"

        If Not Directory.Exists(strPath) Then
            Directory.CreateDirectory(strPath)
        End If
    End Sub

    Private Sub DatabasesBak()
        Try
            Dim arrFiles() As String = Directory.GetFiles("C:\BACKUP\")
            Dim strBak As String()

            datDatabaseBAK.Columns(1).Width = 75
            datDatabaseBAK.Rows.Clear()
            For Each strFile As String In arrFiles
                strBak = New String() {strFile, "RESTORE"}
                datDatabaseBAK.Rows.Add(strBak)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub datDatabaseBAK_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datDatabaseBAK.CellContentClick
        Try
            If e.ColumnIndex = 1 Then
                Dim msgDlg As DialogResult
                msgDlg = MsgBox("Do you want to Restore Database?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "RESTORE")
                If msgDlg = Windows.Forms.DialogResult.Yes Then
                    Dim strBakFile As String = datDatabaseBAK.Rows(e.RowIndex).Cells(0).Value

                    sqlQuery = "RESTORE DATABASE Pet_MIS FROM DISK = '" + strBakFile + "'"
                    If restoreBAK(sqlQuery) Then
                        MsgBox("Database Successfully Restored!", MsgBoxStyle.Information)
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function restoreBAK(strQuery) As Boolean
        Try
            Dim strMasterConnection As String = My.Resources.ConnectionString.Replace("Pet_MIS", "master")
            Dim sqlConnection As New SqlClient.SqlConnection(strMasterConnection)
            Dim sqlCommand As New SqlClient.SqlCommand(strQuery, sqlConnection)

            sqlCommand.CommandType = CommandType.Text
            sqlConnection.Open()
            If sqlCommand.ExecuteNonQuery.Equals(0) Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class