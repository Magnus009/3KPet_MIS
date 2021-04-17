Imports System.IO

Public Class frmBackupRestore

    Private Sub frmBackupRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkBackupDirectory()
        txtPath.Text = "C:\BACKUP\Pet_MIS_" + Format(Today, "yyyyMMdd") + ".bak"
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            sqlQuery = "BACKUP DATABASE Pet_MIS TO DISK = '" + txtPath.Text + "'"
            If sqlExecute(sqlQuery) Then
                MsgBox("Database Backup Successfully!", MsgBoxStyle.Information)
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
End Class