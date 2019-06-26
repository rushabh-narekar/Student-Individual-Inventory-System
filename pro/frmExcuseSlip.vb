Public Class frmExcuseSlip

    Private Sub txtStudentID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStudentID.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'MsgBox("yes")
                sql = " SELECT * FROM `tblstudent` s,`tblcourse` c WHERE s.`COURSEID`=c.`COURSEID` AND `StudentID` = '" & txtStudentID.Text & "'"
                reloadtxt(sql)
                With dt.Rows(0)
                    If dt.Rows.Count > 0 Then
                        txtName.Text = .Item("FirstName") & " " & .Item("LastName")
                        txtCourse.Text = .Item("Course") & " " & .Item("S_Level") & "-" & .Item("S_Section")
                    Else
                        MsgBox("No Record Found!", MsgBoxStyle.Exclamation)
                        ClearESlip()
                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox("No Record Found!", MsgBoxStyle.Exclamation)
            ClearESlip()
        End Try
    End Sub
    Private Sub ClearESlip()
        rdoExcused.Checked = True
        rdoStudentLetterExcuse.Checked = True
        dtglist.Rows.Clear()
        txtCourse.Clear()
        txtName.Clear()
        txtStudentID.Clear()
        dtpDate.Text = Now()
        dtpInclusiveDate.Text = Now()
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearESlip()
    End Sub

    Private Sub frmExcuseSlip_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        disableIsMdiContainer()
    End Sub

    Private Sub frmExcuseSlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnClear_Click(sender, e)
        txtAutocomplete(txtStudentID, "tblstudent", "StudentID")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            initializeExcuseSlip()
            For i As Integer = 0 To dtglist.Rows.Count - 2
                With dtglist
                    sql = "INSERT INTO `tblexcuseslip` " &
              "(`SlipNo`,`StudentID`,`CourseYear`, `Subject`, `ProfessorSignature`, `ExcusedDate`, `InclusiveDate`, `Reasons`, `StudentPresented`, `Remarks`) VALUES " &
              "('" & txtAutoNumber_noObject(1) & "','" & StudentID & "','" & txtCourse.Text & "','" & .Rows(i).Cells(0).Value & "','" & .Rows(i).Cells(1).Value & "','" & ExcusedDate & "','" & InclusiveDate & "','" & Reasons & "','" & StudentPresented & "','" & Remarks & "')"
                    create(sql)
                End With
            Next

            sql = "SELECT * FROM `tblexcuseslip` WHERE `StudentID`='" & txtStudentID.Text & "' GROUP BY SlipNo"
            reloadtxt(sql)

            If dt.Rows.Count >= 3 Then

                MsgBox("This is your third attemp!", MsgBoxStyle.Exclamation)
                sql = "SELECT * FROM `tblstudent` WHERE `StudentID`='" & txtStudentID.Text & "'"
                reloadtxt(sql)
                With dt.Rows(0)
                    sql = "INSERT INTO `messageout` (`Id`, `MessageTo`, `MessageFrom`, `MessageText`) VALUES " &
                        "(Null, '" & .Item("MobileNo") & "','Janno','FROM Guidance Counselor : Yes')"
                    create(sql)
                End With
            End If
            MsgBox("Record has been saved in the databse.")

            sql = "SELECT SlipNo,s.StudentID, CONCAT(`FirstName`,' ', `LastName`) As FullName,CourseYear,`Subject`, `ExcusedDate`, `InclusiveDate`, `Reasons`, `StudentPresented`, `Remarks` FROM  `tblcourse` c, `tblstudent` s,`tblexcuseslip` e WHERE c.`COURSEID`=s.`COURSEID` AND s.`StudentID`=e.`StudentID` AND SlipNo='" & txtAutoNumber_noObject(1) & "'"
            reports(sql, "ExcuseSlip", printExcuseSlip.CrystalReportViewer1)
            txtAutoNumberUpdate(1)
            closeChildForm()
            anyfrm(printExcuseSlip)
            With printExcuseSlip
                .Show()
                .Focus()
            End With
            ClearESlip()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
        closeChildForm()
        anyfrm(frmListofExcuseSlip)
    End Sub
End Class