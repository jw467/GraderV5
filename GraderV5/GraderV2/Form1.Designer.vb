<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnExit = New System.Windows.Forms.Button
        Me.pnlGrades = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblModuleTitle = New System.Windows.Forms.Label
        Me.btnEnterModule = New System.Windows.Forms.Button
        Me.btnEnterMarks = New System.Windows.Forms.Button
        Me.btnShowMarks = New System.Windows.Forms.Button
        Me.tbx5Average = New System.Windows.Forms.TextBox
        Me.tbxYearPercent = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.pnlGrades.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(852, 666)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 40)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pnlGrades
        '
        Me.pnlGrades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGrades.Controls.Add(Me.Label11)
        Me.pnlGrades.Controls.Add(Me.Label7)
        Me.pnlGrades.Controls.Add(Me.Label8)
        Me.pnlGrades.Controls.Add(Me.Label9)
        Me.pnlGrades.Controls.Add(Me.Label10)
        Me.pnlGrades.Controls.Add(Me.Label6)
        Me.pnlGrades.Controls.Add(Me.Label5)
        Me.pnlGrades.Controls.Add(Me.Label4)
        Me.pnlGrades.Controls.Add(Me.Label3)
        Me.pnlGrades.Controls.Add(Me.Label2)
        Me.pnlGrades.Controls.Add(Me.Label1)
        Me.pnlGrades.Location = New System.Drawing.Point(12, 253)
        Me.pnlGrades.Name = "pnlGrades"
        Me.pnlGrades.Size = New System.Drawing.Size(966, 306)
        Me.pnlGrades.TabIndex = 1114
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(891, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 24)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Grade"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(719, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 24)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Second Test"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(813, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Mark"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(742, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Weighting"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(702, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(531, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "First Test"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(615, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mark"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(544, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Weighting"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(504, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(343, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Module ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(88, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Module Name"
        '
        'lblModuleTitle
        '
        Me.lblModuleTitle.AutoSize = True
        Me.lblModuleTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblModuleTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblModuleTitle.Location = New System.Drawing.Point(308, 221)
        Me.lblModuleTitle.Name = "lblModuleTitle"
        Me.lblModuleTitle.Size = New System.Drawing.Size(217, 31)
        Me.lblModuleTitle.TabIndex = 1115
        Me.lblModuleTitle.Text = "                             "
        '
        'btnEnterModule
        '
        Me.btnEnterModule.Location = New System.Drawing.Point(171, 666)
        Me.btnEnterModule.Name = "btnEnterModule"
        Me.btnEnterModule.Size = New System.Drawing.Size(169, 37)
        Me.btnEnterModule.TabIndex = 1118
        Me.btnEnterModule.Text = "Add New Module"
        Me.btnEnterModule.UseVisualStyleBackColor = True
        '
        'btnEnterMarks
        '
        Me.btnEnterMarks.Location = New System.Drawing.Point(371, 666)
        Me.btnEnterMarks.Name = "btnEnterMarks"
        Me.btnEnterMarks.Size = New System.Drawing.Size(169, 37)
        Me.btnEnterMarks.TabIndex = 1117
        Me.btnEnterMarks.Text = "Enter Marks"
        Me.btnEnterMarks.UseVisualStyleBackColor = True
        '
        'btnShowMarks
        '
        Me.btnShowMarks.Location = New System.Drawing.Point(571, 666)
        Me.btnShowMarks.Name = "btnShowMarks"
        Me.btnShowMarks.Size = New System.Drawing.Size(169, 37)
        Me.btnShowMarks.TabIndex = 1116
        Me.btnShowMarks.Text = "Show Marks"
        Me.btnShowMarks.UseVisualStyleBackColor = True
        '
        'tbx5Average
        '
        Me.tbx5Average.Location = New System.Drawing.Point(924, 566)
        Me.tbx5Average.MaxLength = 3
        Me.tbx5Average.Name = "tbx5Average"
        Me.tbx5Average.Size = New System.Drawing.Size(42, 29)
        Me.tbx5Average.TabIndex = 1119
        '
        'tbxYearPercent
        '
        Me.tbxYearPercent.Location = New System.Drawing.Point(924, 601)
        Me.tbxYearPercent.MaxLength = 3
        Me.tbxYearPercent.Name = "tbxYearPercent"
        Me.tbxYearPercent.Size = New System.Drawing.Size(42, 29)
        Me.tbxYearPercent.TabIndex = 1120
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(825, 569)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 24)
        Me.Label12.TabIndex = 1121
        Me.Label12.Text = "5 Average"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(848, 604)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 24)
        Me.Label13.TabIndex = 1122
        Me.Label13.Text = "Year %"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(704, 566)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 31)
        Me.Button1.TabIndex = 1123
        Me.Button1.Text = "Year Grade"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(990, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbxYearPercent)
        Me.Controls.Add(Me.tbx5Average)
        Me.Controls.Add(Me.btnEnterModule)
        Me.Controls.Add(Me.btnEnterMarks)
        Me.Controls.Add(Me.btnShowMarks)
        Me.Controls.Add(Me.lblModuleTitle)
        Me.Controls.Add(Me.pnlGrades)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "App Developed by Russy P"
        Me.pnlGrades.ResumeLayout(False)
        Me.pnlGrades.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlGrades As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblModuleTitle As System.Windows.Forms.Label
    Friend WithEvents btnEnterModule As System.Windows.Forms.Button
    Friend WithEvents btnEnterMarks As System.Windows.Forms.Button
    Friend WithEvents btnShowMarks As System.Windows.Forms.Button
    Friend WithEvents tbx5Average As System.Windows.Forms.TextBox
    Friend WithEvents tbxYearPercent As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
