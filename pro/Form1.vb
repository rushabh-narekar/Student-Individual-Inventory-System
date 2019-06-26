Public Class Form1

    Private Sub tsUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUsers.Click

        closeChildForm()
        anyfrm(frmUser)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disEnable()
    End Sub

    Private Sub tsLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLogin.Click
        If tsLogin.Text = "Login" Then
            With LoginForm1
                .Show()
                .Focus()
            End With
        Else
            tsLogin.Text = "Login"
            disEnable()
            closeChildForm()
        End If
        Me.IsMdiContainer = False
    End Sub

    Private Sub tsStudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsStudents.Click
        closeChildForm()
        anyfrm(frmListofStudents)
    End Sub

    Private Sub tsCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCourse.Click
        closeChildForm()
        anyfrm(frmCourse)
    End Sub

    Private Sub tsExcuseSlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExcuseSlip.Click
        closeChildForm()
        anyfrm(frmExcuseSlip)
    End Sub

    Private Sub tsReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsReport.Click
        closeChildForm()
        anyfrm(frmReport)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsGuidance.Click
        closeChildForm()
        anyfrm(frmStudentinOffice)
    End Sub
End Class
