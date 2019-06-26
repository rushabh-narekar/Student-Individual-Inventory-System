Public Class frmListofStudents

    Private Sub frmListofStudents_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        disableIsMdiContainer()
    End Sub
    Private Sub frmListofStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT `StudentID`, CONCAT(  `FirstName` ,  `MiddleName` ,  `LastName` ) AS  'Name',  `Sex` ,  `CityAddress` ,  `ProvincialAddress` ,  `EmailAddress` ,  `TelephoneNo` ,  `MobileNo` ,  `CivilStatus` ,`COURSE` FROM `tblstudent` s, `tblcourse` c WHERE s.`COURSEID`=c.`COURSEID`"
        reloadDtg(sql, dtgList)
    End Sub

    Private Sub btnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddnew.Click
        closeChildForm()
        anyfrm(frmStudent)
        frmStudent.Text = "Add Student"
        frmStudent.lblStudentTitle.Text = "Add New Student"
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            With frmStudent
                cbo_fill(.cboCourse, "Course", "CourseID", "tblcourse")
                .Text = "Edit Student"
                .lblStudentTitle.Text = "Edit Student"
                .txtStudenID.Text = dtgList.CurrentRow.Cells(0).Value
                .txtStudenID.Enabled = False
                '.btnClear.Visible = False
            End With
            closeChildForm()
            anyfrm(frmStudent)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        sql = "SELECT `StudentID`, CONCAT(  `FirstName` ,  `MiddleName` ,  `LastName` ) AS  'Name',  `Sex` ,  `CityAddress` ,  `ProvincialAddress` ,  `EmailAddress` ,  `TelephoneNo` ,  `MobileNo` ,  `CivilStatus` ,`COURSE` FROM `tblstudent` s, `tblcourse` c WHERE s.`COURSEID`=c.`COURSEID` AND `StudentID`='" & txtSearch.Text & "'"
        reloadDtg(sql, dtgList)
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            sql = "DELETE FROM tblstudent WHERE StudentID = " & dtgList.CurrentRow.Cells(0).Value
            result = deletes(sql)
            If result Then
                MsgBox("Student has been deleted in the database.")
                frmListofStudents_Load(sender, e)
            Else
                MsgBox("Error to delete.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class