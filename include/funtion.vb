Imports MySql.Data.MySqlClient
Module funtion
    Public con As MySqlConnection = mysqldb()
    Public Sub findthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally

            da.Dispose()
            con.Close()

        End Try

    End Sub

    Public Sub LoadData(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()

            Select Case param

                Case "EducationalBackground"
                    Do While dReader.Read = True
                        '`LEVEL`, `SCHOOLGRADUATED`, `SCHOOLADDRESS`, `PUBLICPRIVATE`, `DATESOFATTENDANCE`, `HONORSRECEIVED`
                        obj.Rows.Add(dReader("LEVEL").ToString, dReader("SCHOOLGRADUATED").ToString, dReader("SCHOOLADDRESS").ToString, dReader("PUBLICPRIVATE").ToString, dReader("DATESOFATTENDANCE").ToString, dReader("HONORSRECEIVED").ToString, dReader("EDUCID").ToString)
                    Loop
                Case "LoadListStudents"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop
                Case "CourseList"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop
                Case "ItemList"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(6), dReader(1), dReader(2), dReader(3), dReader(4))
                    Loop
                Case "Registration"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1))
                    Loop
                Case "loadfees"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2))
                    Loop
                Case "loadfeesMiscellanous"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1))
                    Loop

                Case "loadfeesCollege"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1))
                    Loop
                Case ("loadpayment")
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop
                Case "loaduser"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop

            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub cleartext(ByVal group As Object)
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(RichTextBox) Then
                ctrl.Text = Nothing
            End If
        Next
    End Sub
    Public Sub disEnable()
        With Form1 
            .tsStudents.Enabled = False
            .tsUsers.Enabled = False 
            .tsCourse.Enabled = False
            .tsExcuseSlip.Enabled = False
            .tsReport.Enabled = False
            .tsGuidance.Enabled = False
        End With

    End Sub

    Public Sub yesEnable()
        With Form1
            .tsStudents.Enabled = True
            .tsUsers.Enabled = True
            .tsExcuseSlip.Enabled = True
            .tsCourse.Enabled = True
            .tsReport.Enabled = True
            .tsLogin.Text = "Logout"
        End With

    End Sub

    Public Sub closeChildForm() 
        For Each ChildForm As Form In Form1.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Public Sub anyfrm(ByVal frm As Object)
        Form1.PictureBox1.Visible = False
        Form1.IsMdiContainer = True
        With frm
            .MdiParent = Form1
            '.Dock = DockStyle.Fill
            .Show()
        End With
    End Sub
    Public Sub disableIsMdiContainer()
        Form1.PictureBox1.Visible = True
        Form1.IsMdiContainer = False
    End Sub

    Public Sub janobeAutocomplete(ByVal sql As String, ByVal txt As TextBox)
        Try
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            dt = New DataTable
            da.Fill(dt)

            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt.AutoCompleteCustomSource.Clear()
            Dim r As DataRow

            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            Next r

        Catch ex As Exception

        End Try
    End Sub
    Public Sub getallforms()
        Try


            For Each f As Form In My.Application.OpenForms
                Select Case f.Name
                    Case "frm_Login"
                        'frm_Login.Show()
                    Case Else
                        f.Hide()
                End Select

            Next
        Catch ex As Exception

        End Try

        'For Each t As Type In sender.GetType().Assembly.GetTypes()
        '    If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then

        '        MsgBox(t.Name)

        '    End If
        'Next
    End Sub
    Public Function txtAutoNumber_noObject(ByVal autoid As Integer)
        Dim autonum As String = ""
        Try
            con.Open()

            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = "SELECT CONCAT(STARTNUM , ENDNUM) FROM tblAutonumber WHERE AUTOID=" & autoid
            End With

            da = New MySqlDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                autonum = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " at Public Function txtAutoNumber")
        Finally
            con.Close()
            da.Dispose()
        End Try
        Return autonum
    End Function
    Public Function txtAutoNumber_withObject(ByVal autoid As Integer, ByVal txt As Object) As Boolean

        Try
            con.Open()

            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = "SELECT CONCAT(STARTNUM , ENDNUM) FROM tblAutonumber WHERE AUTOID=" & autoid
            End With

            da = New MySqlDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txt.text = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " at Public Function txtAutoNumber")
        Finally
            con.Close()
            da.Dispose()

        End Try

        Return True
    End Function
    Public Function txtAutoNumberUpdate(ByVal autoid As Integer) As Boolean

        Try
            con.Open()

            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = "Update tblAutonumber set ENDNUM = ENDNUM + INCREMENTNUM WHERE AUTOID=" & autoid
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            MsgBox(ex.Message & " at Public Function txtAutoNumber")
        Finally
            con.Close()
            da.Dispose()

        End Try

        Return True
    End Function
    Public Sub cbo_fill(ByVal cbo As ComboBox, ByVal member As String, ByVal id As String, ByVal table As String)

        Try
            con.Open()

            With cmd
                .Connection = con
                .CommandText = "Select * From " & table
            End With

            da = New MySqlDataAdapter("Select * From " & table, con)
            da.SelectCommand = cmd
            dt = New DataTable
            da.Fill(dt)
            With cbo
                .DataSource = dt
                .ValueMember = id
                .DisplayMember = member
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con.Close()
        'da.Dispose()

    End Sub

    Public Sub emptymessage()
        MsgBox("There are empty fields left that must be filled up!", MsgBoxStyle.Exclamation)
    End Sub


    Public inc As Integer = 0
    Public maxrows As Integer

    Public Sub select_navigation(ByVal sql As String)
        Try
            Try
                con.Open()
                With cmd
                    .Connection = con
                    .CommandText = sql
                End With
                dt = New DataTable
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)
                maxrows = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message & "select_navigation")
            End Try

            con.Close()
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub navagate_records(ByVal txt As Object)
        Try
            txt.text = dt.Rows(inc).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'Public Sub auto_suggest(ByVal member As String, ByVal table As String, ByVal txt As Object)
    '    Try
    '        reload("select  " & member & " from  " & table)
    '        filltxtshow()

    '        Dim r As DataRow
    '        txt.AutoCompleteCustomSource.Clear()

    '        For Each r In dt.Rows
    '            txt.AutoCompleteCustomSource.Add(r.Item(0).ToString)

    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    'Public Sub query(ByVal member As String, ByVal table As String, ByVal dtg As Object)
    '    Try
    '        reload("SELECT " & member & " FROM " & table)
    '        filltable(dtg)

    '    Catch ex As Exception

    '    End Try
    'End Sub
    Public Sub validation(ByVal frm As Object)
        Try
            For Each txt As Control In frm.Controls

                If txt.GetType Is GetType(TextBox) Then
                    If txt.Text = "" Then
                        MsgBox("One of the box is empty, you filled out!")
                    Else
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ErrorMessage(ByVal lbl As Label, ByVal message As String, ByVal btn As Button)
        lbl.BackColor = Color.Red
        lbl.ForeColor = Color.White
        lbl.Text = message
        btn.Enabled = False
    End Sub
    Public Sub ClearErrorMessage(ByVal lbl As Label, ByVal btn As Button)
        lbl.BackColor = Color.Transparent
        lbl.Text = ""
        btn.Enabled = True
    End Sub
    'declarations
    Dim day As String = Format(Today, "dddd") 'string format of days
    Dim hoursinterval As Integer
    Dim retrievtime As Date 'date borrowed 
    Dim convertedtimeH As Integer    'hour borrowed 
    Dim convertedtimeM As Integer   'minute borrowed 


    Dim time As Date 'current date
    Dim CurrHour As Integer ' current hour
    Dim CurrMinute As Integer 'current minute

    Public Sub checkOverduePurposed(ByVal sql As String, ByVal choiceofporpuse As String)
        'for retriving the data
        With cmd
            .Connection = con
            .CommandText = sql
        End With
        dt = New DataTable
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        For Each row As DataRow In dt.Rows
            Dim id As Integer = row.Item(1)
            Select Case day
                Case "Monday"
                    Select Case choiceofporpuse
                        Case "Research"
                            timeOfresearch(id)
                        Case "Photocopy"
                            timeOfPhotocopy(id, row.Item(0))
                        Case "Overnight"

                            ' MsgBox("Overnight")
                            timeOfOvernight(id, row.Item(0))
                    End Select

                Case "Tuesday"
                    Select Case choiceofporpuse
                        Case "Research"
                            timeOfresearch(id)
                        Case "Photocopy"
                            timeOfPhotocopy(id, row.Item(0))
                        Case "Overnight"

                            ' MsgBox("Overnight")
                            timeOfOvernight(id, row.Item(0))
                    End Select

                Case "Wednesday"
                    Select Case choiceofporpuse
                        Case "Research"
                            timeOfresearch(id)
                        Case "Photocopy"
                            timeOfPhotocopy(id, row.Item(0))
                        Case "Overnight"


                            timeOfOvernight(id, row.Item(0))
                    End Select

                Case "Thursday"
                    Select Case choiceofporpuse
                        Case "Research"
                            timeOfresearch(id)
                        Case "Photocopy"
                            timeOfPhotocopy(id, row.Item(0))
                        Case "Overnight"

                            ' MsgBox("Overnight")
                            timeOfOvernight(id, row.Item(0))
                    End Select

                Case "Friday"
                    Select Case choiceofporpuse
                        Case "Research"
                            timeOfresearch(id)
                        Case "Photocopy"
                            timeOfPhotocopy(id, row.Item(0))
                        Case "Overnight"

                            ' MsgBox("Overnight")
                            timeOfOvernight(id, row.Item(0))
                    End Select

                Case "Saturday"
                    Select Case choiceofporpuse
                        Case "Research"
                            timeOfresearch(id)
                        Case "Photocopy"
                            timeOfPhotocopy(id, row.Item(0))
                        Case "Overnight"

                            ' MsgBox("Overnight")
                            timeOfOvernight(id, row.Item(0))
                    End Select
                Case "Sunday"
                    Select Case choiceofporpuse
                        Case "Research"
                            timeOfresearch(id)
                        Case "Photocopy"
                            timeOfPhotocopy(id, row.Item(0))
                        Case "Overnight"

                            ' MsgBox("Overnight")
                            timeOfOvernight(id, row.Item(0))
                    End Select
            End Select
        Next
    End Sub
    Public Sub timeOfresearch(ByVal id As Integer)
        If Format(Now, "tt") = "AM" Then
            Dim checktime As Integer = DatePart("h", Now) & Format(Now, "mm")
            If checktime <= 830 Or checktime >= 1130 Then
                ' MsgBox(Format(Date.Now().Date, "yyyy-MM-dd") & " 11:30:00")
                sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue'  " _
                & " WHERE Status='Borrowed' AND `Purpose` ='Research' and BorrowId='" & id & "'"
                updates(sql)
            End If

        ElseIf Format(Now, "tt") = "PM" Then
            Dim checktime As Integer = DatePart("h", Now) & DatePart("n", Now)
            If checktime <= 1330 Or checktime >= 1730 Then
                sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue'  " _
                 & " WHERE Status='Borrowed' AND `Purpose` ='Research' and BorrowId='" & id & "'"
                updates(sql)
            End If

        End If

    End Sub
    Public Sub timeOfPhotocopy(ByVal id As Integer, ByVal retrievtime As Integer)

        If retrievtime >= 30 Then
            'sql = "Update `borrow` SET `status` = 'Due'  WHERE borrowed=true AND `purpose` ='Photocopy' and borrow_id in ('" & id & "')"
            'updates(sql)
            sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue' " _
               & " WHERE Status='Borrowed' AND `Purpose` ='Photocopy' and BorrowId='" & id & "'"
            updates(sql)
            Return

        End If
    End Sub
    Public Sub timeOfOvernight(ByVal id As Integer, ByVal hoursinterval As Integer)
        If hoursinterval >= 24 Then
            'sql = "Update `borrow` SET `status` = 'Due'  WHERE borrowed=true AND `purpose`='Overnight' and borrow_id in ('" & id & "')"
            'updates(sql)
            sql = "UPDATE `tblborrow` SET `Due` = 1,`Remarks`='Overdue' " _
             & " WHERE Status='Borrowed' AND `Purpose` ='Overnight' and BorrowId='" & id & "'"
            updates(sql)
            Return
        End If
    End Sub

    Public Sub columnInvisible(ByVal dtg As DataGridView)
        Dim c As DataGridViewColumn
        For Each c In dtg.Columns

        Next

    End Sub

    Public Function numbersOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Try
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception

        End Try

        Return True
    End Function
    Public Function formatMySQLdate(ByVal dtp As String)


        Dim strDate As String 

        strDate = Format(Date.Parse(dtp), "yyyy-MM-dd")

        Return strDate
    End Function

    Public Function ValidateOverDue() As Boolean
        Dim strtime As String
        Dim strdate As String
        Dim strToDate As String
        sql = "SELECT `SlipNo`,`DateReturn`, `TimeReturn`,BorrowerId FROM `tblborrow` WHERE Status='Borrowed'"
        reloadtxt(sql)
        If dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows

                strtime = Format(Date.Parse(r.Item(2)), "HH:mm:ss")
                strdate = Format(Date.Parse(r.Item(1)), "MM/dd/yyyy") & " " & strtime
                strToDate = Format(Now(), "MM/dd/yyyy HH:mm:ss")
                'MsgBox(Date.Parse(strToDate))
                If Date.Parse(strToDate) >= Date.Parse(strdate) Then
                    'MsgBox("yes") 
                    sql = "UPDATE `tblborrow` SET Status='OverDue' WHERE SlipNo ='" & r.Item(0) & "'"
                    updates(sql)

                    sql = "UPDATE `tblborrower` SET DueDate=1 WHERE `BorrowerId`='" & r.Item(3) & "'"
                    updates(sql)
                End If
            Next
        End If

        Return True
    End Function

    Public Function getAge(ByVal birthDate As String)
        Dim MyAge As String
        Dim dateofbirth As Date
        dateofbirth = Format(Date.Parse(birthDate), "MM/dd/yyyy")
        MyAge = DateDiff(DateInterval.Year, dateofbirth, Now())
        Return MyAge

    End Function
    Public Sub txtAutocomplete(ByVal obj As Object, ByVal tbl As String, ByVal field As String)
        Try
            con.Open()
            sql = "SELECT " & field & " FROM " & tbl
            Dim da As New MySqlDataAdapter(sql, con)
            Dim dt As New DataTable
            Dim r As DataRow
            da.Fill(dt)
            obj.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                obj.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next 
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

End Module
