<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsUserDetails = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsLogin = New System.Windows.Forms.ToolStripButton()
        Me.tsStudents = New System.Windows.Forms.ToolStripButton()
        Me.tsCourse = New System.Windows.Forms.ToolStripButton()
        Me.tsExcuseSlip = New System.Windows.Forms.ToolStripButton()
        Me.tsGuidance = New System.Windows.Forms.ToolStripButton()
        Me.tsUsers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsReport = New System.Windows.Forms.ToolStripButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1136, 435)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.tsUserDetails})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1136, 22)
        Me.StatusStrip.TabIndex = 11
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel.Text = "User Details :"
        '
        'tsUserDetails
        '
        Me.tsUserDetails.Name = "tsUserDetails"
        Me.tsUserDetails.Size = New System.Drawing.Size(70, 17)
        Me.tsUserDetails.Text = "#########"
        '
        'ToolStrip
        '
        Me.ToolStrip.GripMargin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLogin, Me.tsStudents, Me.tsCourse, Me.tsExcuseSlip, Me.tsGuidance, Me.tsUsers, Me.ToolStripSeparator1, Me.tsReport})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1136, 54)
        Me.ToolStrip.TabIndex = 10
        Me.ToolStrip.Text = "ToolStrip"
        '
        'tsLogin
        '
        Me.tsLogin.Image = CType(resources.GetObject("tsLogin.Image"), System.Drawing.Image)
        Me.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLogin.Name = "tsLogin"
        Me.tsLogin.Size = New System.Drawing.Size(41, 51)
        Me.tsLogin.Text = "Login"
        Me.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsStudents
        '
        Me.tsStudents.Image = CType(resources.GetObject("tsStudents.Image"), System.Drawing.Image)
        Me.tsStudents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsStudents.Name = "tsStudents"
        Me.tsStudents.Size = New System.Drawing.Size(57, 51)
        Me.tsStudents.Text = "Students"
        Me.tsStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsCourse
        '
        Me.tsCourse.Image = CType(resources.GetObject("tsCourse.Image"), System.Drawing.Image)
        Me.tsCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCourse.Name = "tsCourse"
        Me.tsCourse.Size = New System.Drawing.Size(48, 51)
        Me.tsCourse.Text = "Course"
        Me.tsCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsExcuseSlip
        '
        Me.tsExcuseSlip.Image = CType(resources.GetObject("tsExcuseSlip.Image"), System.Drawing.Image)
        Me.tsExcuseSlip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsExcuseSlip.Name = "tsExcuseSlip"
        Me.tsExcuseSlip.Size = New System.Drawing.Size(68, 51)
        Me.tsExcuseSlip.Text = "Excuse Slip"
        Me.tsExcuseSlip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsGuidance
        '
        Me.tsGuidance.Image = CType(resources.GetObject("tsGuidance.Image"), System.Drawing.Image)
        Me.tsGuidance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsGuidance.Name = "tsGuidance"
        Me.tsGuidance.Size = New System.Drawing.Size(96, 51)
        Me.tsGuidance.Text = "Guidance Office"
        Me.tsGuidance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsUsers
        '
        Me.tsUsers.Image = CType(resources.GetObject("tsUsers.Image"), System.Drawing.Image)
        Me.tsUsers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUsers.Name = "tsUsers"
        Me.tsUsers.Size = New System.Drawing.Size(36, 51)
        Me.tsUsers.Text = "User"
        Me.tsUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'tsReport
        '
        Me.tsReport.Image = CType(resources.GetObject("tsReport.Image"), System.Drawing.Image)
        Me.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReport.Name = "tsReport"
        Me.tsReport.Size = New System.Drawing.Size(46, 51)
        Me.tsReport.Text = "Report"
        Me.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 511)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ToolStrip)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents tsUserDetails As ToolStripStatusLabel
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents tsLogin As ToolStripButton
    Friend WithEvents tsStudents As ToolStripButton
    Friend WithEvents tsCourse As ToolStripButton
    Friend WithEvents tsExcuseSlip As ToolStripButton
    Friend WithEvents tsGuidance As ToolStripButton
    Friend WithEvents tsUsers As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsReport As ToolStripButton
End Class
