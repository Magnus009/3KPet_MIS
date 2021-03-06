Module M_Connection
    Public sqlQuery As String = ""
    Public strdestination As String = False

    Public Function SQLPetMIS(strQuery As String) As DataSet
        Try
            Dim sqlConnection As New SqlClient.SqlConnection(My.Resources.ConnectionString)
            Dim sqlAdapter As New SqlClient.SqlDataAdapter(strQuery, sqlConnection)
            Dim dsData As New DataSet

            sqlConnection.Open()
            sqlAdapter.Fill(dsData)
            sqlConnection.Close()
            Return dsData
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function sqlExecute(strQuery As String) As Boolean
        Try
            Dim sqlConnection As New SqlClient.SqlConnection(My.Resources.ConnectionString)
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

End Module
