Imports Microsoft.Office.Interop.Excel

Module Print
    Sub PrintToExcel(dataGridView As DataGridView)
        Dim excelApp As New Application
        Dim workbook As Workbook = excelApp.Workbooks.Add
        Dim worksheet As Worksheet = workbook.Sheets(1)

        For i As Integer = 0 To dataGridView.Columns.Count - 1
            worksheet.Cells(1, i + 1) = dataGridView.Columns(i).HeaderText
        Next
        For i As Integer = 0 To dataGridView.Rows.Count - 1
            For j As Integer = 0 To dataGridView.Columns.Count - 1
                Dim value As Object = dataGridView.Rows(i).Cells(j).Value
                If value IsNot Nothing AndAlso Not IsDBNull(value) Then
                    worksheet.Cells(i + 2, j + 1) = value.ToString()
                Else
                    worksheet.Cells(i + 2, j + 1) = ""
                End If
            Next
        Next

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            workbook.SaveAs(saveFileDialog.FileName)
            MessageBox.Show("Print Successful!")
        End If

        workbook.Close()
        excelApp.Quit()
        releaseObject(worksheet)
        releaseObject(workbook)
        releaseObject(excelApp)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Module
