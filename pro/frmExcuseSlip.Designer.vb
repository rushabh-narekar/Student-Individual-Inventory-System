<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExcuseSlip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtNotExcused = New System.Windows.Forms.TextBox()
        Me.txtTempExcused = New System.Windows.Forms.TextBox()
        Me.rdoNotExcused = New System.Windows.Forms.RadioButton()
        Me.rdoExcused = New System.Windows.Forms.RadioButton()
        Me.rdoProfessorDiscretion = New System.Windows.Forms.RadioButton()
        Me.rdoTempExcused = New System.Windows.Forms.RadioButton()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoParentIDRC = New System.Windows.Forms.RadioButton()
        Me.rdoMedicalCert = New System.Windows.Forms.RadioButton()
        Me.rdoParentLetterExcuse = New System.Windows.Forms.RadioButton()
        Me.rdoStudentLetterExcuse = New System.Windows.Forms.RadioButton()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.dtpInclusiveDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Id No. :"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClose.Location = New System.Drawing.Point(481, 550)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 34
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnList.Location = New System.Drawing.Point(400, 550)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 33
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClear.Location = New System.Drawing.Point(319, 550)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.Location = New System.Drawing.Point(238, 550)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtNotExcused
        '
        Me.txtNotExcused.Location = New System.Drawing.Point(142, 73)
        Me.txtNotExcused.Name = "txtNotExcused"
        Me.txtNotExcused.Size = New System.Drawing.Size(236, 20)
        Me.txtNotExcused.TabIndex = 9
        '
        'txtTempExcused
        '
        Me.txtTempExcused.Location = New System.Drawing.Point(180, 50)
        Me.txtTempExcused.Name = "txtTempExcused"
        Me.txtTempExcused.Size = New System.Drawing.Size(198, 20)
        Me.txtTempExcused.TabIndex = 8
        '
        'rdoNotExcused
        '
        Me.rdoNotExcused.AutoSize = True
        Me.rdoNotExcused.Location = New System.Drawing.Point(6, 74)
        Me.rdoNotExcused.Name = "rdoNotExcused"
        Me.rdoNotExcused.Size = New System.Drawing.Size(140, 17)
        Me.rdoNotExcused.TabIndex = 7
        Me.rdoNotExcused.TabStop = True
        Me.rdoNotExcused.Text = "Not Excused(pls. spicify)"
        Me.rdoNotExcused.UseVisualStyleBackColor = True
        '
        'rdoExcused
        '
        Me.rdoExcused.AutoSize = True
        Me.rdoExcused.Location = New System.Drawing.Point(6, 28)
        Me.rdoExcused.Name = "rdoExcused"
        Me.rdoExcused.Size = New System.Drawing.Size(66, 17)
        Me.rdoExcused.TabIndex = 4
        Me.rdoExcused.TabStop = True
        Me.rdoExcused.Text = "Excused"
        Me.rdoExcused.UseVisualStyleBackColor = True
        '
        'rdoProfessorDiscretion
        '
        Me.rdoProfessorDiscretion.AutoSize = True
        Me.rdoProfessorDiscretion.Location = New System.Drawing.Point(6, 97)
        Me.rdoProfessorDiscretion.Name = "rdoProfessorDiscretion"
        Me.rdoProfessorDiscretion.Size = New System.Drawing.Size(124, 17)
        Me.rdoProfessorDiscretion.TabIndex = 6
        Me.rdoProfessorDiscretion.TabStop = True
        Me.rdoProfessorDiscretion.Text = "Professor's discretion"
        Me.rdoProfessorDiscretion.UseVisualStyleBackColor = True
        '
        'rdoTempExcused
        '
        Me.rdoTempExcused.AutoSize = True
        Me.rdoTempExcused.Location = New System.Drawing.Point(6, 51)
        Me.rdoTempExcused.Name = "rdoTempExcused"
        Me.rdoTempExcused.Size = New System.Drawing.Size(172, 17)
        Me.rdoTempExcused.TabIndex = 5
        Me.rdoTempExcused.TabStop = True
        Me.rdoTempExcused.Text = "Temporary excused(pls. spicify)"
        Me.rdoTempExcused.UseVisualStyleBackColor = True
        '
        'txtStudentID
        '
        Me.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStudentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtStudentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtStudentID.Location = New System.Drawing.Point(148, 96)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(223, 20)
        Me.txtStudentID.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.txtNotExcused)
        Me.GroupBox2.Controls.Add(Me.txtTempExcused)
        Me.GroupBox2.Controls.Add(Me.rdoNotExcused)
        Me.GroupBox2.Controls.Add(Me.rdoExcused)
        Me.GroupBox2.Controls.Add(Me.rdoProfessorDiscretion)
        Me.GroupBox2.Controls.Add(Me.rdoTempExcused)
        Me.GroupBox2.Location = New System.Drawing.Point(413, 393)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 134)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Remarks"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.rdoParentIDRC)
        Me.GroupBox1.Controls.Add(Me.rdoMedicalCert)
        Me.GroupBox1.Controls.Add(Me.rdoParentLetterExcuse)
        Me.GroupBox1.Controls.Add(Me.rdoStudentLetterExcuse)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 393)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 134)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Presented"
        '
        'rdoParentIDRC
        '
        Me.rdoParentIDRC.AutoSize = True
        Me.rdoParentIDRC.Location = New System.Drawing.Point(30, 74)
        Me.rdoParentIDRC.Name = "rdoParentIDRC"
        Me.rdoParentIDRC.Size = New System.Drawing.Size(152, 17)
        Me.rdoParentIDRC.TabIndex = 3
        Me.rdoParentIDRC.TabStop = True
        Me.rdoParentIDRC.Text = "Parent's/Guardian's ID/RC"
        Me.rdoParentIDRC.UseVisualStyleBackColor = True
        '
        'rdoMedicalCert
        '
        Me.rdoMedicalCert.AutoSize = True
        Me.rdoMedicalCert.Location = New System.Drawing.Point(30, 97)
        Me.rdoMedicalCert.Name = "rdoMedicalCert"
        Me.rdoMedicalCert.Size = New System.Drawing.Size(112, 17)
        Me.rdoMedicalCert.TabIndex = 2
        Me.rdoMedicalCert.TabStop = True
        Me.rdoMedicalCert.Text = "Medical Certificate"
        Me.rdoMedicalCert.UseVisualStyleBackColor = True
        '
        'rdoParentLetterExcuse
        '
        Me.rdoParentLetterExcuse.AutoSize = True
        Me.rdoParentLetterExcuse.Location = New System.Drawing.Point(30, 51)
        Me.rdoParentLetterExcuse.Name = "rdoParentLetterExcuse"
        Me.rdoParentLetterExcuse.Size = New System.Drawing.Size(193, 17)
        Me.rdoParentLetterExcuse.TabIndex = 1
        Me.rdoParentLetterExcuse.TabStop = True
        Me.rdoParentLetterExcuse.Text = "Parent's/Guardian's letter of excuse"
        Me.rdoParentLetterExcuse.UseVisualStyleBackColor = True
        '
        'rdoStudentLetterExcuse
        '
        Me.rdoStudentLetterExcuse.AutoSize = True
        Me.rdoStudentLetterExcuse.Location = New System.Drawing.Point(30, 28)
        Me.rdoStudentLetterExcuse.Name = "rdoStudentLetterExcuse"
        Me.rdoStudentLetterExcuse.Size = New System.Drawing.Size(144, 17)
        Me.rdoStudentLetterExcuse.TabIndex = 0
        Me.rdoStudentLetterExcuse.TabStop = True
        Me.rdoStudentLetterExcuse.Text = "Student's letter of excuse"
        Me.rdoStudentLetterExcuse.UseVisualStyleBackColor = True
        '
        'txtReason
        '
        Me.txtReason.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtReason.Location = New System.Drawing.Point(85, 367)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(712, 20)
        Me.txtReason.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Reason :"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Subject"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 500
        '
        'Column2
        '
        Me.Column2.HeaderText = "Professors Signature"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 220
        '
        'dtglist
        '
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dtglist.Location = New System.Drawing.Point(32, 190)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.Size = New System.Drawing.Size(763, 171)
        Me.dtglist.TabIndex = 26
        '
        'dtpInclusiveDate
        '
        Me.dtpInclusiveDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpInclusiveDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpInclusiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInclusiveDate.Location = New System.Drawing.Point(597, 147)
        Me.dtpInclusiveDate.Name = "dtpInclusiveDate"
        Me.dtpInclusiveDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpInclusiveDate.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(507, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Inclusive Date :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(552, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Date :"
        '
        'txtCourse
        '
        Me.txtCourse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCourse.Enabled = False
        Me.txtCourse.Location = New System.Drawing.Point(148, 148)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(320, 20)
        Me.txtCourse.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Course Year & Section :"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(148, 122)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(320, 20)
        Me.txtName.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(839, 67)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Excuse Slip"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(597, 118)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(375, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Search then Enter"
        '
        'frmExcuseSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 584)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtglist)
        Me.Controls.Add(Me.dtpInclusiveDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDate)
        Me.Name = "frmExcuseSlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excuse Slip"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnList As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtNotExcused As TextBox
    Friend WithEvents txtTempExcused As TextBox
    Friend WithEvents rdoNotExcused As RadioButton
    Friend WithEvents rdoExcused As RadioButton
    Friend WithEvents rdoProfessorDiscretion As RadioButton
    Friend WithEvents rdoTempExcused As RadioButton
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoParentIDRC As RadioButton
    Friend WithEvents rdoMedicalCert As RadioButton
    Friend WithEvents rdoParentLetterExcuse As RadioButton
    Friend WithEvents rdoStudentLetterExcuse As RadioButton
    Friend WithEvents txtReason As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents dtglist As DataGridView
    Friend WithEvents dtpInclusiveDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label8 As Label
End Class
