Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = mysqldb()
 
    Public Sub login(ByVal username As Object, ByVal pass As Object)
        Try

            con.Open()
            reloadtxt("SELECT * FROM `tbluseraccounts` WHERE Username= '" & username & "' and Pass = sha1('" & pass & "')")


            If dt.Rows.Count > 0 Then

                If dt.Rows(0).Item("Role") = "Administrator" Then
                    MsgBox("Welcome " & dt.Rows(0).Item("Role"))
                    '.Text = "User :" & dt.Rows(0).Item("Fullname")
                    With Form1
                        '.FileToolStripMenuItem.Visible = True
                        '.TransactionToolStripMenuItem.Visible = True
                        '.ListOfItemsToolStripMenuItem.Visible = True
                        ''.ReportsToolStripMenuItem.Visible = True
                        '.Show()
                        '.Focus()
                        .tsCourse.Enabled = True
                        .tsExcuseSlip.Enabled = True
                        .tsReport.Enabled = True
                        .tsStudents.Enabled = True
                        .tsGuidance.Enabled = True
                        .tsUsers.Enabled = True
                        .tsUserDetails.Text = dt.Rows(0).Item("Fullname")
                    End With
                    yesEnable()
                    LoginForm1.Close()
                Else
                    With Form1 
                        .tsExcuseSlip.Enabled = True
                        .tsReport.Enabled = True
                        .tsStudents.Enabled = True
                        .tsGuidance.Enabled = True
                        .tsUserDetails.Text = dt.Rows(0).Item("Fullname")
                    End With
                    'frmListItems.btnEdit.Visible = False
                    ' frm_Login.Hide() 
                    LoginForm1.Close()
                End If

            Else
                MsgBox("Acount doest not exits!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
    End Sub
    Public Sub append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        reloadtxt(sql)
        Try
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       

    End Sub
End Module
