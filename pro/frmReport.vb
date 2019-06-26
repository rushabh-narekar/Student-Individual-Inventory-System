Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnListOfStudents_Click(sender As Object, e As EventArgs) Handles btnListOfStudents.Click
        sql = "SELECT * FROM tblstudent"
        reports(sql, "listofstudents", CrystalReportViewer1)
    End Sub

    Private Sub btnExcuseSlip_Click(sender As Object, e As EventArgs) Handles btnExcuseSlip.Click
        sql = "SELECT  s.`StudentID`,concat(`FirstName`, ' ', `MiddleName`,' ' , `LastName`) as Name,`Sex`, `CityAddress`, `ProvincialAddress`, `EmailAddress`, `MobileNo`,CourseYear,GROUP_CONCAT(`Subject`) as Subject, `ExcusedDate`, `InclusiveDate`, `Reasons`, `StudentPresented`, `Remarks` FROM  `tblstudent` s,`tblexcuseslip` e WHERE s.`StudentID`=e.`StudentID`  AND DATE(`ExcusedDate`) BETWEEN '" & formatMySQLdate(dtpFrom.Text) & "' AND '" & formatMySQLdate(dtpTo.Text) & "' GROUP BY SlipNo"
        'sql = "SELECT  * FROM  `tblstudent` s,`tblexcuseslip` e WHERE s.`StudentID`=e.`StudentID`  AND DATE(`ExcusedDate`) BETWEEN '" & formatMySQLdate(dtpFrom.Text) & "' AND '" & formatMySQLdate(dtpTo.Text) & "' GROUP BY SlipNo"

        '  sql = "SELECT  s.`StudentID`,concat(`FirstName`, ' ', `MiddleName`,' ' , `LastName`) as Name,`Sex`, `CityAddress`, `ProvincialAddress`, `EmailAddress`, `MobileNo`,concat(`COURSE`,' ',`S_Level`,' /', `S_Section`) as CourseYear,`Subject`, `ExcusedDate`, `InclusiveDate`, `Reasons` FROM `tblstudent`  s, `tblcourse`  c, `tblexcuseslip` e " &
        '" WHERE s.`COURSEID`=c.`COURSEID` AND s.`StudentID`=e.`StudentID` AND DATE(`ExcusedDate`) BETWEEN '" & formatMySQLdate(dtpFrom.Text) & "' AND '" & formatMySQLdate(dtpTo.Text) & "'"
        reports(sql, "listofexcuseslip", CrystalReportViewer1)
    End Sub
End Class