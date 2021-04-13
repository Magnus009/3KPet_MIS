Imports Microsoft.Reporting.WinForms

Public Class frmPrintProducts

    Private Sub frmPrintTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setCBO()
    End Sub

    Private Sub setCBO()
        Try
            Dim cboSource As New Dictionary(Of String, String)()
            cboSource.Add("1", "Day")
            cboSource.Add("2", "Week")
            cboSource.Add("3", "Month")
            cboSource.Add("4", "Year")
            cboFilter.DataSource = New BindingSource(cboSource, Nothing)
            cboFilter.DisplayMember = "Value"
            cboFilter.ValueMember = "Key"

            AddHandler cboFilter.SelectedIndexChanged, AddressOf filterChange
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub filterChange(sender As Object, e As EventArgs)
        Try
            Dim cboSource As New Dictionary(Of String, String)()
            cboSource.Clear()

            If cboFilter.SelectedValue = 1 Then
                dtpDay.Visible = True
                txtYear.Visible = False
                cboFil.Visible = False
                lblFilterlabel.Text = "Date :"
            ElseIf cboFilter.SelectedValue = 2 Then
                Dim minWeek As Integer
                Dim maxWeek As Integer

                sqlQuery = ""
                sqlQuery += "SELECT datepart(week, min(VisitDate)) FROM TransactionHeader"
                minWeek = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0)

                sqlQuery = ""
                sqlQuery += "SELECT datepart(week, max(VisitDate)) FROM TransactionHeader"
                maxWeek = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0)

                cboFil.Items.Clear()
                cboFil.SelectedText = ""
                For i As Integer = minWeek To maxWeek
                    cboFil.Items.Add(i)
                Next
                cboFil.Visible = True
                dtpDay.Visible = False
                txtYear.Visible = False
                lblFilterlabel.Text = "Week :"
            ElseIf cboFilter.SelectedValue = 3 Then
                Dim minMonth As Integer
                Dim maxMonth As Integer

                sqlQuery = ""
                sqlQuery += "SELECT datepart(month, min(VisitDate)) FROM TransactionHeader"
                minMonth = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0)

                sqlQuery = ""
                sqlQuery += "SELECT datepart(month, max(VisitDate)) FROM TransactionHeader"
                maxMonth = SQLPetMIS(sqlQuery).Tables(0).Rows(0)(0)

                cboFil.SelectedText = ""
                cboFil.Items.Clear()
                For i As Integer = minMonth To maxMonth
                    cboFil.Items.Add(New DictionaryEntry(i, MonthName(i)))
                    'cboSource.Add(i, DateAndTime.MonthName(i, False))
                Next

                'cboFil.DataSource = New BindingSource(cboSource, Nothing)
                cboFil.DisplayMember = "Value"
                cboFil.ValueMember = "Key"
                cboFil.Visible = True
                dtpDay.Visible = False
                txtYear.Visible = False
                lblFilterlabel.Text = "Month :"
            ElseIf cboFilter.SelectedValue = 4 Then
                txtYear.Visible = True
                cboFil.Visible = False
                dtpDay.Visible = False
                lblFilterlabel.Text = "Year :"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim dtProducts As New DataTable

            sqlQuery = ""
            sqlQuery += "SELECT PP.TransactionID,TH.VisitDate,PP.ProductID, P.Description, QTY, TotatlPrice as 'TotalPrice'  FROM PurschasedProducts PP" & vbCrLf
            sqlQuery += "inner JOIN TransactionHeader TH ON PP.TransactionID = TH.TransactionID" & vbCrLf
            sqlQuery += "INNER JOIN Products P ON PP.ProductID = P.ProductID" & vbCrLf
            If cboFilter.SelectedValue = 1 Then
                sqlQuery += "WHERE convert(VARCHAR(10),CAST(TH.VisitDate AS DATE) , 1) = convert(VARCHAR(10),CAST('" + dtpDay.Value + "' AS DATE), 1)" & vbCrLf
            ElseIf cboFilter.SelectedValue = 2 Then
                sqlQuery += "WHERE datepart(week, VisitDate) = " + cboFil.SelectedItem.ToString & vbCrLf
            ElseIf cboFilter.SelectedValue = 3 Then
                sqlQuery += "WHERE datepart(month, VisitDate) = " + cboFil.SelectedValue & vbCrLf
            ElseIf cboFilter.SelectedValue = 4 Then
                sqlQuery += "WHERE datepart(year, VisitDate) =  " + txtYear.Text & vbCrLf
            End If
            dtProducts = SQLPetMIS(sqlQuery).Tables(0)

            If dtProducts.Rows.Count = 0 Then
                MsgBox("No record found!", vbOKOnly + vbExclamation)
            Else
                With frmProductsReport.rpvProducts
                    .LocalReport.DataSources.Clear()
                    .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsPurchasedProd", dtProducts))
                    .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                    .ZoomMode = ZoomMode.Percent
                    .ZoomPercent = 100
                End With
                frmProductsReport.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class