  Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "update TestVB set " + column + "=" + txtContent2.Text + " where Component='" + row + "'"
                Dim insertCommand As New SqlCommand(sql, conn)

                ' 执行命令  
                Dim count As Integer = insertCommand.ExecuteNonQuery()
                If count > 0 Then
                    MessageBox.Show("修改成功！")
                    LoadDataGridView()
                    DataGridView1.Rows(rowIndex).Cells(colIndex).Style.BackColor = Color.Blue
                End If


            End Using
    Catch ex As Exception
            ' 异常处理
            MessageBox.Show("Error: " & ex.Message)
    End Try