Module mdExcuseSlip
    Public Subject, ProfessorSignature, ExcusedDate, InclusiveDate, Reasons, StudentPresented, Remarks As String
    Public Approved As Boolean

    Public Sub initializeExcuseSlip()
        Try
            With frmExcuseSlip
                StudentID = .txtStudentID.Text
                ExcusedDate = formatMySQLdate(.dtpDate.Text)
                InclusiveDate = formatMySQLdate(.dtpInclusiveDate.Text)
                Reasons = .txtReason.Text
                If .rdoStudentLetterExcuse.Checked = True Then
                    StudentPresented = "Students letter of excuse"
                ElseIf .rdoParentLetterExcuse.Checked = True Then
                    StudentPresented = "Parents/Guardians letter of excuse"
                ElseIf .rdoParentIDRC.Checked = True Then
                    StudentPresented = "Parents/Guardians ID/RC"
                ElseIf .rdoMedicalCert.Checked = True Then
                    StudentPresented = "Medical Certificate"
                End If

                If .rdoExcused.Checked = True Then
                    Remarks = "Excused"
                ElseIf .rdoTempExcused.Checked = True Then
                    Remarks = "Temporary Excused"
                ElseIf .rdoNotExcused.Checked = True Then
                    Remarks = "Not Excused"
                ElseIf .rdoProfessorDiscretion.Checked = True Then
                    Remarks = "Professors Discretion"
                End If

            End With
        Catch ex As Exception

        End Try
    End Sub
End Module
