Public Class frmListofExcuseSlip

    Private Sub btnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddnew.Click
        closeChildForm()
        anyfrm(frmExcuseSlip)
    End Sub

    Private Sub frmListofExcuseSlip_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        disableIsMdiContainer()
    End Sub

    Private Sub frmListofExcuseSlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT s.StudentID, `FirstName`, `LastName`,GROUP_CONCAT(`Subject`) as Subject, `ExcusedDate`, `InclusiveDate`, `Reasons`, `StudentPresented`, `Remarks` FROM  `tblstudent` s,`tblexcuseslip` e WHERE s.`StudentID`=e.`StudentID` GROUP BY SlipNo"
        reloadDtg(sql, dtgList)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        sql = "SELECT s.StudentID, `FirstName`, `LastName`,GROUP_CONCAT(`Subject`) as Subject, `ExcusedDate`, `InclusiveDate`, `Reasons`, `StudentPresented`, `Remarks` FROM  `tblstudent` s,`tblexcuseslip` e WHERE s.`StudentID`=e.`StudentID`  AND s.`StudentID` LIKE '%" & txtSearch.Text & "' GROUP BY SlipNo"
        reloadDtg(sql, dtgList)
    End Sub
End Class