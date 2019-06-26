Public Class frmCourse
    Private courseid As Integer = 0
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cleartext(Me)
        sql = "Select * From tblcourse"
        reloadDtg(sql, dtgList)
        dtgList.Columns(0).Visible = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
        courseid = 0
    End Sub
    Private Sub frmCourse_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        disableIsMdiContainer()
    End Sub
    Private Sub frmCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call btnClear_Click(sender, e)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtCouseCode.Text = "" Or txtDesc.Text = "" Then
                MsgBox("Empty fields must be filled out!", MsgBoxStyle.Exclamation)
                Return
            End If

            sql = "INSERT INTO `tblcourse`  (`COURSE`, `DESCRIPTION`) VALUES ('" & txtCouseCode.Text & "','" & txtDesc.Text & "')"
            result = create(sql)
            If result = True Then
                MsgBox("New Course already added in the database.")
            End If
            Call btnClear_Click(sender, e)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgList.Click
        Try
            With dtgList.CurrentRow
                courseid = .Cells(0).FormattedValue
                txtCouseCode.Text = .Cells(1).FormattedValue
                txtDesc.Text = .Cells(2).FormattedValue
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                btnSave.Enabled = False
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If txtCouseCode.Text = "" Or txtDesc.Text = "" Then
                MsgBox("Empty fields must be filled out!", MsgBoxStyle.Exclamation)
                Return
            End If
            sql = "Update `tblcourse` SET `COURSE`='" & txtCouseCode.Text & "',`DESCRIPTION`='" & txtDesc.Text & "' WHERE `COURSEID`=" & courseid
            result = updates(sql)
            If result = True Then
                MsgBox("Course already updated in the database.")
            End If
            Call btnClear_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            sql = "DELETE FROM `tblcourse` WHERE `COURSEID`=" & courseid
            result = deletes(sql)
            If result = True Then
                MsgBox("Course already deleted in the database.")
            End If
            Call btnClear_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class