Public Class frmStudent

    Private Sub frmStudent_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        disableIsMdiContainer()
    End Sub

    Private Sub cboCourse_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboYear.KeyPress, cboCourse.KeyPress, cboCivilStatus.KeyPress
        e.Handled = True
    End Sub
    Private Sub ClearAll()
        Try
            cleartext(tpPesonalBackground)
            cleartext(tpHomeFamilyBackground)
            dtpDateofBirth.Text = Now()
            cbo_fill(cboCourse, "Course", "CourseID", "tblcourse")
            Me.Text = "Add Student"
            lblStudentTitle.Text = "Add New Student"
            txtStudenID.Enabled = True
            rdoF_Living.Checked = True
            rdoM_Living.Checked = True
            rdoG_Living.Checked = True
            rdoPMR_Married_ST.Checked = True
            rdoFamily.Checked = True
            rdoParents.Checked = True
            cboYear.Text = "1st"
            txtSection.Clear()
            With dtglist_EducBackground.Rows
                .Clear()
                .Add("Pre-Elementary")
                .Add("Elementary")
                .Add("High School")
                .Add("Vocational")
                .Add("College")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    Private Sub frmStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If lblStudentTitle.Text <> "Edit Student" Then
            ClearAll()
        Else
            If Me.Text = "Add Student" Then
                btnClear.Text = "Clear"
            Else
                btnClear.Text = "New"
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        closeChildForm()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            Personal_Background(Me)
            HomeAndFamily_Background(Me)

            sql = "SELECT * FROM `tbleducationalbackground` WHERE  `StudentID`='" & txtStudenID.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                UpdateStudent()
                MsgBox("Student has been updated in the database")
                ClearAll()
            Else
                SaveStudents()
                MsgBox("New Student has been saved in the database")
                ClearAll()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtStudenID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudenID.TextChanged

        sql = "SELECT * FROM `tblstudent` s,`tbleducationalbackground` e , `tblfamilybackground` f WHERE s.`StudentID`=e.`StudentID` AND e.`StudentID`=f.`StudentID` AND  e.`StudentID`='" & txtStudenID.Text & "'"
        reloadtxt(sql)
        If dt.Rows.Count > 0 Then
            loadPersonalBackground()
            loadEducationalBackground()
            loadFamilyBackground()
            Me.Text = "Edit Student"
            lblStudentTitle.Text = "Edit Student"
        End If
    End Sub

    Private Sub lblStudentTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStudentTitle.TextChanged
        If Me.Text = "Add Student" Then
            btnClear.Text = "Clear"
        Else
            btnClear.Text = "New"
        End If
    End Sub
End Class