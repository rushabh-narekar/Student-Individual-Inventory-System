﻿Public Class frmUser

    Private Sub frmUser_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        disableIsMdiContainer()
    End Sub

    Private Sub frm_adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cbo_type.Text = "Administrator"
            reloadDtg("Select UserID as 'ID' ,Fullname as 'Name',Username as 'Username',Role as 'Type' From tbluseraccounts WHERE Status='Active'", dtg_listUser)
            dtg_listUser.Columns(0).Visible = False
            If lbl_id.Text = "id" Then

                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True

            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If


        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        lbl_id.Text = "id"
        Call frm_adduser_Load(sender, e)
        cleartext(Me)
    End Sub

    Private Sub btn_saveuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_saveuser.Click

        If txt_name.Text = "" Or txt_pass.Text = "" Or txt_username.Text = "" Then
            emptymessage()
        Else
            result = create("insert into tbluseraccounts (`Fullname`, `Username`, `Pass`, `Role`,`Status`) " _
             & "values('" & txt_name.Text & "','" & txt_username.Text _
             & "',sha1('" & txt_pass.Text & "'),'" & cbo_type.Text _
             & "','Active')")
            If result = True Then
                MsgBox("User has been saved in the database.")
            End If
            Call btn_close_Click(sender, e)
            cleartext(Me)
        End If

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Try
            If txt_name.Text = "" Or txt_pass.Text = "" Or txt_username.Text = "" Then
                emptymessage()
            Else
                result = updates("update tbluseraccounts set Fullname = '" & txt_name.Text & "',Username= '" & txt_username.Text _
                            & "',Pass= sha1('" & txt_pass.Text & "'),Role= '" & cbo_type.Text _
                            & "' where UserID = " & lbl_id.Text)
                If result = True Then
                    MsgBox("User has been updated in the database.")
                End If

                Call btn_close_Click(sender, e)
                cleartext(Me)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Try

            If MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                'result = deletes("delete from tbluseraccounts where UserId = '" & lbl_id.Text & "'")
                result = updates("update tbluseraccounts set Status='NotActive' where UserId = " & lbl_id.Text)
                If result = True Then
                    MessageBox.Show("User has been deleted in the database.", "Success", MessageBoxButtons.OK)
                End If
                'Call frm_adduser_Load(sender, e)
                cleartext(Me)
                Call btn_close_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtg_listUser_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_listUser.CellClick

    End Sub

    Private Sub dtg_listUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg_listUser.Click
        Try
            With dtg_listUser.CurrentRow
                lbl_id.Text = .Cells(0).Value
                txt_name.Text = .Cells(1).Value
                txt_username.Text = .Cells(2).Value
                cbo_type.Text = .Cells(3).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtg_listUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtg_listUser.DoubleClick
        Try
            With dtg_listUser.CurrentRow
                lbl_id.Text = .Cells(0).Value
                txt_name.Text = .Cells(1).Value
                txt_username.Text = .Cells(2).Value
                cbo_type.Text = .Cells(3).Value
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lbl_id_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_id.TextChanged
        Try
            If lbl_id.Text = "id" Then

                btn_update.Enabled = False
                btn_delete.Enabled = False
                btn_saveuser.Enabled = True

            Else
                btn_saveuser.Enabled = False
                btn_update.Enabled = True
                btn_delete.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class