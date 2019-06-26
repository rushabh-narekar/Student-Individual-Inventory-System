Public Class frmStudentinOffice
    Public TRANSID As Integer = 0
    Private Sub clearStudOfis()
        txtStudentName.Clear()
        txtStudentID.Clear()
        txtCourse.Clear()
        txtReason.Clear()
        sql = "SELECT TRANSID , `FirstName`, `MiddleName`, `LastName`,CourseYear as 'Course and Year' , `Reasons`, `TransDate` as Date FROM `tblstudent` s, `tblstudentguidanceoffice` g WHERE s.`StudentID`=g.`StudentID`"
        reloadDtg(sql, DataGridView1)
        DataGridView1.Columns(0).Visible = False
    End Sub

    Private Sub txtStudentID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStudentID.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'MsgBox("yes")
                sql = " SELECT * FROM `tblstudent` s,`tblcourse` c WHERE s.`COURSEID`=c.`COURSEID` AND `StudentID` = '" & txtStudentID.Text & "'"
                reloadtxt(sql)
                With dt.Rows(0)
                    If dt.Rows.Count > 0 Then
                        txtStudentName.Text = .Item("FirstName") & " " & .Item("LastName")
                        txtCourse.Text = .Item("Course") & " " & .Item("S_Level") & "-" & .Item("S_Section")
                    Else
                        MsgBox("No Record Found!", MsgBoxStyle.Exclamation)
                        clearStudOfis()
                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox("No Record Found!", MsgBoxStyle.Exclamation)
            clearStudOfis()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtStudentName.Text = "" Then
                MsgBox("Unable to save! Please provide the correct details.", MsgBoxStyle.Exclamation)
                Return
            End If
            sql = " SELECT * FROM `tblstudent` s,`tblstudentguidanceoffice` g WHERE s.`StudentID`=g.`StudentID`  AND TRANSID = '" & TRANSID & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                sql = "UPDATE `tblstudentguidanceoffice` SET `StudentID`='" & txtStudentID.Text & "',CourseYear='" & txtCourse.Text & "', `Reasons`='" & txtReason.Text & "' WHERE TRANSID=" & TRANSID
                result = updates(sql)
                If result Then
                    MsgBox("Record has been updated in the database.")
                    clearStudOfis()
                Else
                    MsgBox("Error to update.", MsgBoxStyle.Exclamation)
                End If
            Else
                sql = "INSERT INTO `tblstudentguidanceoffice` (`StudentID`,CourseYear, `Reasons`, `TransDate`) " &
                    " VALUES ('" & txtStudentID.Text & "','" & txtCourse.Text & "','" & txtReason.Text & "',Now())"
                result = create(sql)
                sql = "SELECT * FROM `tblstudentguidanceoffice` WHERE `StudentID`='" & txtStudentID.Text & "'"
                reloadtxt(sql)
                If dt.Rows.Count >= 3 Then

                    MsgBox("This is your " & dt.Rows.Count & "th times to go to guidance office", MsgBoxStyle.Exclamation)
                    sql = "SELECT * FROM `tblstudent` WHERE `StudentID`='" & txtStudentID.Text & "'"
                    reloadtxt(sql)
                    With dt.Rows(0)
                        sql = "INSERT INTO `messageout` (`Id`, `MessageTo`, `MessageFrom`, `MessageText`) VALUES " &
                            "(Null, '" & .Item("MobileNo") & "','Janno','FROM Guidance Counselor : Yes')"
                        create(sql)
                    End With
                End If
                If result Then
                    MsgBox("New Record has been saved in the database.")
                    clearStudOfis()
                Else
                    MsgBox("Error to save.", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearStudOfis()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmStudentinOffice_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        disableIsMdiContainer()
    End Sub

    Private Sub frmStudentinOffice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearStudOfis()
        txtAutocomplete(txtStudentID, "tblstudent", "StudentID")
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Try
            TRANSID = DataGridView1.CurrentRow.Cells(0).Value
            sql = " SELECT * FROM `tblstudent` s,`tblstudentguidanceoffice` g WHERE s.`StudentID`=g.`StudentID`  AND TRANSID = '" & TRANSID & "'"
            reloadtxt(sql)
            With dt.Rows(0)
                If dt.Rows.Count > 0 Then
                    txtStudentName.Text = .Item("FirstName") & " " & .Item("LastName")
                    txtCourse.Text = .Item("CourseYear")
                    txtStudentID.Text = .Item("StudentID")
                    txtReason.Text = .Item("Reasons")
                Else
                    MsgBox("No Record Found!", MsgBoxStyle.Exclamation)
                    clearStudOfis()
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            sql = "DELETE FROM tblstudentguidanceoffice WHERE TRANSID = " & TRANSID
            result = deletes(sql)
            If result Then
                MsgBox("Record has been deleted in the database.")
                clearStudOfis()
            Else
                MsgBox("Error to delete.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtStudentID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentID.TextChanged
        Try
            sql = " SELECT * FROM `tblstudent` s,`tblcourse` c WHERE s.`COURSEID`=c.`COURSEID` AND `StudentID` = '" & txtStudentID.Text & "'"
            reloadtxt(sql)
            With dt.Rows(0)
                If dt.Rows.Count > 0 Then
                    txtStudentName.Text = .Item("FirstName") & " " & .Item("LastName")
                    txtCourse.Text = .Item("Course") & " " & .Item("S_Level") & "-" & .Item("S_Section")
                Else
                    MsgBox("No Record Found!", MsgBoxStyle.Exclamation)
                    clearStudOfis()
                End If
            End With
        Catch ex As Exception

        End Try

    End Sub
End Class