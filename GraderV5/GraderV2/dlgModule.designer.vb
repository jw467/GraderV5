<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgModule
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.tbxYourTitle = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbxModName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbxModID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.nud1Weight = New System.Windows.Forms.NumericUpDown
        Me.cbx1Type = New System.Windows.Forms.ComboBox
        Me.cbx2Type = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.nud2Weight = New System.Windows.Forms.NumericUpDown
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nud1Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud2Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(210, 208)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 6
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 7
        Me.Cancel_Button.Text = "Cancel"
        '
        'tbxYourTitle
        '
        Me.tbxYourTitle.Location = New System.Drawing.Point(156, 15)
        Me.tbxYourTitle.Name = "tbxYourTitle"
        Me.tbxYourTitle.Size = New System.Drawing.Size(147, 20)
        Me.tbxYourTitle.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Module Name:"
        '
        'tbxModName
        '
        Me.tbxModName.Location = New System.Drawing.Point(156, 40)
        Me.tbxModName.Name = "tbxModName"
        Me.tbxModName.Size = New System.Drawing.Size(147, 20)
        Me.tbxModName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Module ID:"
        '
        'tbxModID
        '
        Me.tbxModID.Location = New System.Drawing.Point(156, 65)
        Me.tbxModID.Name = "tbxModID"
        Me.tbxModID.Size = New System.Drawing.Size(147, 20)
        Me.tbxModID.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "First Test Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "First Test Weight:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Second Test Type"
        '
        'nud1Weight
        '
        Me.nud1Weight.Location = New System.Drawing.Point(156, 116)
        Me.nud1Weight.Name = "nud1Weight"
        Me.nud1Weight.Size = New System.Drawing.Size(43, 20)
        Me.nud1Weight.TabIndex = 4
        Me.nud1Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nud1Weight.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'cbx1Type
        '
        Me.cbx1Type.Items.AddRange(New Object() {"E", "A", "T", "?"})
        Me.cbx1Type.Location = New System.Drawing.Point(156, 90)
        Me.cbx1Type.Name = "cbx1Type"
        Me.cbx1Type.Size = New System.Drawing.Size(43, 21)
        Me.cbx1Type.TabIndex = 3
        '
        'cbx2Type
        '
        Me.cbx2Type.FormattingEnabled = True
        Me.cbx2Type.Items.AddRange(New Object() {"E", "A", "T", "?"})
        Me.cbx2Type.Location = New System.Drawing.Point(156, 140)
        Me.cbx2Type.Name = "cbx2Type"
        Me.cbx2Type.Size = New System.Drawing.Size(43, 21)
        Me.cbx2Type.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(206, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(206, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(12, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(230, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "* E=Exam  A=Assignment  T=Test  ?=Unknown"
        '
        'nud2Weight
        '
        Me.nud2Weight.Location = New System.Drawing.Point(95, 208)
        Me.nud2Weight.Name = "nud2Weight"
        Me.nud2Weight.Size = New System.Drawing.Size(43, 20)
        Me.nud2Weight.TabIndex = 22
        Me.nud2Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nud2Weight.Visible = False
        '
        'dlgModule
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(368, 249)
        Me.Controls.Add(Me.nud2Weight)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbx2Type)
        Me.Controls.Add(Me.cbx1Type)
        Me.Controls.Add(Me.nud1Weight)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxModID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxModName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxYourTitle)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgModule"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Module"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.nud1Weight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud2Weight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents tbxYourTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxModName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbxModID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nud1Weight As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbx1Type As System.Windows.Forms.ComboBox
    Friend WithEvents cbx2Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nud2Weight As System.Windows.Forms.NumericUpDown

End Class
